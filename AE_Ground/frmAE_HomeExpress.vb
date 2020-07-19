Option Strict On
Option Explicit On

Imports System.IO
Imports System.Xml.Serialization
Imports System.Data.OleDb
Imports AE_Ground.clsAE_Utilities
Imports System.Net.Mail




Public Class frmAE_HomeExpress



#Region " Database Communication"



#End Region



#Region " Properties"



#End Region



#Region " Class-Level Declarations"


	'Dim daysOfWeek As String() = New String() {"14", "16", "18", "20", "24"}
	Dim cxStatus As Boolean

	Dim drag As Boolean
	Dim mousex As Integer
	Dim mousey As Integer




#End Region



#Region " Methods & Functions"

	Private Function GetJobDescription(ByVal job As String) As String
		Try
			Dim jobD As String

			Dim t As DataTable = Me.QryJobDescriptionTableAdapter.GetData(My.Settings.ae_CurrentJob)
			jobD = t.Rows.Item(0).Item(0).ToString

			Return jobD

		Catch ex As Exception
			Return Nothing
		End Try


	End Function


#End Region



#Region " Event Handlers"

	Private Sub frmAE_HomeExpress_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

		' Reduce Flicker
		Me.pnlHomeSummary.Visible = False
		Me.pnlMainBack.Visible = False
		Me.btnDP.Select()

		'dddd, dd MMMM yyyy HH:mm:ss

		Dim dateToday As String = Now.ToString("dddd, MMMM dd, yyyy h:mm tt")
		Me.lblTodayDate.Text = dateToday
		Me.lblUserName.Text = "Welcome, " & My.Settings.ae_DisplayName

		AE_mdiMain.ToolStripProgressBar1.MarqueeAnimationSpeed = 200
		AE_mdiMain.ToolStripStatusLabel1.Text = "Background Services Running"
		Me.bgWorker2.RunWorkerAsync()

		If My.Settings.ae_UserID > 6 Then
			'btnReviewDP.Enabled = False
			'btnViewImages.Enabled = False
			'btnRecieveImages.Enabled = False
		End If


	End Sub

	Private Sub btnDP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDP.Click
		Dim dp As New frmAE_DP
		dp.MdiParent = AE_mdiMain
		dp.Show()
		Me.Hide()
	End Sub

	Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click
		Try
			' The 2nd argument (1) indicates Transfer Direction (1 = Upload, 2 = Download)
			' The 3rd argument indicates File Type (1 = XML, 2 = Images)
			Dim qAE As New frmDataSyncProgress(Directory.GetFiles(My.Settings.ae_DataSyncPath), 1, 1)
			qAE.MdiParent = AE_mdiMain.MdiParent
			qAE.Show()
		Catch ex As Exception
			MessageBox.Show(ex.Message, "btnUpload_Click()")
		End Try
	End Sub

	Private Sub btnTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTime.Click
		Dim time As New frmTimeReporting
		time.MdiParent = AE_mdiMain
		time.Show()
	End Sub

	Private Sub btnSubmitTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmitTime.Click
		Try
			If My.Computer.Network.IsAvailable = True Then
				btnSubmitTime.Enabled = False
				Dim Files() As String = Directory.GetFiles(My.Settings.ae_TimeSheetTxtPath)
				Dim mailCount As Integer = 0
				Dim smtpServer As New System.Net.Mail.SmtpClient
				Dim mail As New MailMessage

				For Each File As String In Files

					'ftp
					If (My.Computer.Network.IsAvailable) Then
						My.Computer.Network.UploadFile(File, My.Settings.ae_FtpTime & Path.GetFileName(File), My.Settings.ae_FTPuserName, My.Settings.ae_FTPuserCred, True, 9999, FileIO.UICancelOption.ThrowException)
					Else
						MessageBox.Show("Network unavailable try again later.", "Network Unavailable")
						Exit For
					End If

					''email
					'Dim reader As New System.IO.StreamReader(File)
					'Dim strMsg As String = reader.ReadLine
					'Dim dateStr() As String = strMsg.Split(New Char() {" "c})

					'While reader.Peek <> -1
					'	strMsg = strMsg & reader.ReadLine & vbCrLf
					'End While

					'smtpServer.Credentials = New Net.NetworkCredential("ActionEntry@gmail.com", "actionentry5182")
					'smtpServer.Port = 587
					'smtpServer.Host = "smtp.gmail.com"
					'mail = New MailMessage()
					'mail.From = New MailAddress("ActionEntry@gmail.com")

					'mail.Bcc.Add("jeff@actiontraffic.net")
					'mail.Bcc.Add("mike@actiontraffic.net")

					'mail.To.Add("shelby@actiontraffic.net")
					'mail.To.Add("shelia@actiontraffic.net")
					''mail.To.Add("sophie@actiontraffic.net")
					''mail.To.Add("mcclain137@gmail.com")


					'mail.Subject = "TimeSheet_" & My.Settings.ae_DisplayName & "_" & dateStr(1)
					'mail.Body = strMsg
					'smtpServer.Send(mail)
					mailCount += 1
					'reader.Close()
					btnSubmitTime.Enabled = True

					My.Computer.FileSystem.MoveFile(File, My.Settings.ae_WarehouseTimeSheet & Path.GetFileName(File))
				Next


				MessageBox.Show("You submitted " & mailCount.ToString & " timesheet(s)", "Timesheet(s) Submitted")
			Else
				MessageBox.Show("You must be connected to the internet to submit time.", "No Internet Connection")
			End If


		Catch ex As Exception
			MessageBox.Show(ex.Message, "Submit Time")
			btnSubmitTime.Enabled = True
		End Try
	End Sub

	Private Sub frmAE_HomeExpress_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

		' Reduce Flicker
		Me.pnlHomeSummary.Visible = True
		Me.pnlMainBack.Visible = True

	End Sub


	Private Sub bgWorker2_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgWorker2.DoWork
		cxStatus = AtWorkOrNot()
		'MessageBox.Show(cxStatus)
	End Sub

	Private Sub bgWorker2_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bgWorker2.ProgressChanged

	End Sub

	Private Sub bgWorker2_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWorker2.RunWorkerCompleted
		With AE_mdiMain.ToolStripProgressBar1
			.MarqueeAnimationSpeed = 0
			.Value = 0
		End With

		AE_mdiMain.ToolStripStatusLabel1.Text = "System Is Idle."
	End Sub






#End Region










End Class