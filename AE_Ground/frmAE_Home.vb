Option Strict On
Option Explicit On

Imports System.IO
Imports System.Xml.Serialization
Imports System.Data.OleDb
Imports AE_Ground.clsAE_Utilities
Imports System.Net.Mail




Public Class frmAE_Home




#Region " Class Declarations"


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

	Private Sub frmAE_Home_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

		Me.pnlHomeSummary.Visible = False
		Me.pnlMainBack.Visible = False
		Me.btnDP.Select()

		'dddd, dd MMMM yyyy HH:mm:ss

		Dim dateToday As String = Now.ToString("dddd, MMMM dd, yyyy h:mm tt")
		Me.lblTodayDate.Text = dateToday
		Me.lblUserName.Text = "Welcome, " & My.Settings.ae_DisplayName

		AE_mdiMain.ToolStripProgressBar1.MarqueeAnimationSpeed = 200
		AE_mdiMain.ToolStripStatusLabel1.Text = "Working"
		Me.bgWorker1.RunWorkerAsync()

		If My.Settings.ae_UserID > 6 Then
			InitializeUserAccess(My.Settings.ae_UserID)
			'btnReviewDP.Enabled = False
			'btnViewImages.Enabled = False
			'btnRecieveImages.Enabled = False
		End If

	End Sub

	Private Sub frmAE_Home_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged

		'If Not (My.Settings.ae_CurrentJob Is Nothing) Then
		'	Me.btnSubmitDP.Enabled = False
		'Else
		'	Me.btnSubmitDP.Enabled = True
		'End If

	End Sub

	'Private Sub btnChangeViewHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeViewHome.Click

	'	'Select Case Me.WindowState
	'	'	Case FormWindowState.Normal
	'	'		Me.btnChangeViewHome.Text = "Normal"
	'	'		Me.WindowState = FormWindowState.Maximized
	'	'	Case FormWindowState.Maximized
	'	'		Me.btnChangeViewHome.Text = "Full Screen"
	'	'		Me.WindowState = FormWindowState.Normal
	'	'End Select

	'	'Me.Validate()

	'End Sub

	Private Sub btnDP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDP.Click, lblEnterDP.Click
		Dim dp As New frmAE_DP
		dp.MdiParent = AE_mdiMain
		dp.Show()
		Me.Hide()
	End Sub

	Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
		Dim About1 As New AboutBox1
		About1.MdiParent = AE_mdiMain
		About1.Show()
	End Sub






	Private Sub btnSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSettings.Click

		Dim aView As Boolean = False

		Select Case My.Settings.ae_UserID
			Case 1, 6
				aView = True
			Case Else
				aView = False
		End Select

		Dim viewSettings As New frmSettings(aView)
		viewSettings.MdiParent = AE_mdiMain
		viewSettings.Show()

	End Sub

	Private Sub frmAE_Home_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

		Me.pnlHomeSummary.Visible = True
		Me.pnlMainBack.Visible = True

	End Sub

	

	Private Sub btnUtilityHits_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUtilityHits.Click

		Dim whereJobIs As String = GetJobDescription(My.Settings.ae_CurrentJob)
		Dim UtilHitWzd As New frmUH_Wizard(My.Settings.ae_CurrentJob, whereJobIs)
		UtilHitWzd.MdiParent = AE_mdiMain
		UtilHitWzd.Show()

	End Sub

	Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click, lblSubmitDP.Click

		'  Prepare System Info to submit
		Dim strHostName As String = System.Net.Dns.GetHostName()
		Dim strIPAddress As String = System.Net.Dns.GetHostEntry(strHostName).AddressList(0).ToString()

		' Message Body 
		Dim myComputerInfo As String = "Computer Name: " & strHostName & vbCrLf & _
				 "IP: " & strIPAddress & vbCrLf & _
				 "OS:  " & My.Computer.Info.OSFullName & vbCrLf & _
				 "Platform:  " & My.Computer.Info.OSPlatform & vbCrLf & _
				 "RAM:  " & My.Computer.Info.TotalPhysicalMemory.ToString & vbCrLf & _
				 "Avail RAM:  " & My.Computer.Info.AvailablePhysicalMemory.ToString

		' Message Subject
		Dim strSubject As String = "SysInfo for AE User:  " & My.Settings.ae_DisplayName
		Try
			If My.Settings.ae_SubmitSysInfo Then
				' Disabled - jk 2018.08.05
				'SubmitSystemInfo(strSubject, myComputerInfo)
			End If
		Catch ex As Exception

		End Try

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

	Private Sub btnUploadDeBug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUploadDeBug.Click

		Try
			' The 2nd argument (1) indicates Transfer Direction (1 = Upload, 2 = Download)
			' The 3rd argument indicates File Type (1 = XML, 2 = Images)
			Dim qAEpl As New frmDataSyncProgress(Directory.GetFiles(My.Settings.ae_DebugPath), 1, 1)
			qAEpl.MdiParent = AE_mdiMain.MdiParent
			qAEpl.Show()

		Catch ex As Exception
			MessageBox.Show(ex.Message, "btnUploadDeBug_Click")
		End Try

	End Sub

	Private Sub btnDeBugging_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeBugging.Click

		Dim pl As New frmAE_AddPunchListItem
		pl.MdiParent = AE_mdiMain
		pl.Show()

	End Sub

	Private Sub btnViewReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewReports.Click

		Dim rpt As New Form2
		rpt.MdiParent = AE_mdiMain
		rpt.Show()

	End Sub



	Private Sub bgWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgWorker1.DoWork

		cxStatus = AtWorkOrNot()
		'MessageBox.Show(cxStatus)



	End Sub

	Private Sub bgWorker1_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bgWorker1.ProgressChanged


	End Sub

	Private Sub bgWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWorker1.RunWorkerCompleted

		With AE_mdiMain.ToolStripProgressBar1
			.MarqueeAnimationSpeed = 0
			.Value = 0
		End With

		AE_mdiMain.ToolStripStatusLabel1.Text = "System Is Idle."
	
	End Sub



	Private Sub btnReviewDP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReviewDP.Click


		Dim reviewDP As New frmReconcileDP
		reviewDP.MdiParent = AE_mdiMain
		reviewDP.Show()



	End Sub






#End Region

	
	Private Sub btnUploadImages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUploadImages.Click

		Dim uploadPic As New frmUploadPicDate
		uploadPic.MdiParent = AE_mdiMain
		uploadPic.btnOK.Enabled = False
		uploadPic.btnUpload.Enabled = True
		uploadPic.Show()

	End Sub

	Private Sub btnRecieveImages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecieveImages.Click

		'If ATM network exists do this here

		'Dim localDirectory As String = My.Settings.ae_DownloadImagePath
		Dim sAry() As String = GetFileNameStringArrayFromFTP(My.Settings.ae_FTPImageSyncURL)

		' The 2nd argument (1) indicates Transfer Direction (1 = Upload, 2 = Download)
		' The 3rd argument indicates File Type (1 = XML, 2 = Images)
		Dim qAE As New frmDataSyncProgress(sAry, 2, 2)
		qAE.MdiParent = AE_mdiMain.MdiParent
		qAE.Show()

	End Sub

	Private Sub btnViewImages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewImages.Click
		Try
			'if the user is below 6 and they are connected to the server then 
			If My.Settings.ae_UserID <= 6 And AtWorkOrNot() Then
				Process.Start("explorer.exe", My.Settings.ae_DownloadImagePath)
			Else
				Dim viewPic As New frmUploadPicDate
				viewPic.MdiParent = AE_mdiMain
				viewPic.btnOK.Enabled = True
				viewPic.btnUpload.Enabled = False
				viewPic.Show()
			End If
		Catch ex As Exception
			MessageBox.Show(ex.Message, "btnViewImages_Click")
		End Try

	End Sub






	
	Private Sub btnTransferImages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransferImages.Click
		btnTransferImages.Enabled = False
		Dim i As Integer = findDrives()
		Dim numProcessed As Integer
		Dim folderStr As String = Nothing

		If i = 1 Then
			Dim filePath As String = lstDrives.Items(0).ToString
			With AE_mdiMain.ToolStripProgressBar1
				.MarqueeAnimationSpeed = 4000
			End With
			AE_mdiMain.ToolStripStatusLabel1.Text = "Working"
			folderStr = processDirectory(filePath, numProcessed)

		ElseIf i = 0 Then
			MessageBox.Show("There are zero removable drives to use.")
		ElseIf i > 1 Then
			MessageBox.Show("There are more than one removable disks. Please remove unecessary disks.")
		End If
		With AE_mdiMain.ToolStripProgressBar1
			.MarqueeAnimationSpeed = 0
		End With

		AE_mdiMain.ToolStripStatusLabel1.Text = "Idle"
		btnTransferImages.Enabled = True

		If Not numProcessed = 0 Then
			Dim result As DialogResult = MessageBox.Show("Number of images processed: " & numProcessed.ToString & vbCrLf & "Would you like to view the pictures?", "Pictures", MessageBoxButtons.YesNo)
			If result = DialogResult.Yes Then
				Process.Start("explorer.exe", folderStr)
			End If
		End If
		MessageBox.Show("Number of images processed: " & numProcessed.ToString)

	End Sub

	Function findDrives() As Integer
		Dim x As Integer = 0
		For Each drive As System.IO.DriveInfo In My.Computer.FileSystem.Drives
			If drive.DriveType = 2 Then
				lstDrives.Items.Add(drive.Name)
				'x = x + 1
				' or
				x = Me.lstDrives.Items.Count
			End If
		Next
		Return x
	End Function

	Private Function processDirectory(ByVal targetDirectory As String, ByRef numProcessed As Integer) As String
		Try
			Dim fileEntries() As String = System.IO.Directory.GetFiles(targetDirectory)
			Dim count As Integer = 0
			' Process the list of files found in the directory.
			Dim fileName As String
			Dim folderStr As String = Nothing

			For Each fileName In fileEntries
				folderStr = processFile(fileName, numProcessed)
				count = count + 1
			Next fileName

			Dim subdirectoryEntries() As String = System.IO.Directory.GetDirectories(targetDirectory)
			' Recurse into subdirectories of this directory.
			'Dim subdirectory As String

			For Each subdirectory As String In subdirectoryEntries
				processDirectory(subdirectory, numProcessed)
			Next subdirectory
			'numProcessed += count
			Return folderStr

		Catch ex As Exception
			MessageBox.Show("Target directory does not hold a file.", "processDirectory(targetDirectory)")
			Return Nothing
		End Try



	End Function 'ProcessDirectory

	Private Function processFile(ByVal filePath As String, ByRef numprocessed As Integer) As String
		Try
			Dim folderDate As String = Now.ToString("MM-dd-yyyy")
			If filePath IsNot Nothing Then
				Dim ext As String = IO.Path.GetExtension(filePath)
				If ext = ".jpg" Or ext = ".png" Or ext = ".gif" Or ext = ".bmp" Or ext = ".JPG" Or ext = ".PNG" Or ext = ".GIF" Or ext = ".BMP" Then
					My.Computer.FileSystem.MoveFile(filePath, My.Settings.ae_TransferImagePath & "pic_" & _
					   folderDate & "\" & _
					   "pic_" & _
					   My.Settings.ae_UserID & "_" & _
					   My.Settings.ae_CurrentJob & "_" & _
					   "X" & _
					   "_" & _
					   Now.ToString("MM-dd-yyyy_hh.mm.ss.ff_tt") & ext)

					numprocessed += 1
				End If

			End If
			Return My.Settings.ae_TransferImagePath & "pic_" & folderDate & "\"
		Catch ex As Exception
			MessageBox.Show(ex.Message, "FillImageList")
			Return Nothing
		End Try

	End Function


	' Drag logic

	Private Sub pnlTitleMain_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlTitleMain.MouseDown
		drag = True
		mousex = Windows.Forms.Cursor.Position.X - Me.Left
		mousey = Windows.Forms.Cursor.Position.Y - Me.Top
	End Sub

	Private Sub pnlTitleMain_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlTitleMain.MouseMove
		If drag Then
			Me.Top = Windows.Forms.Cursor.Position.Y - mousey
			Me.Left = Windows.Forms.Cursor.Position.X - mousex
		End If
	End Sub

	Private Sub pnlTitleMain_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlTitleMain.MouseUp
		drag = False

	End Sub

	Private Sub btnTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTime.Click
		Dim time As New frmTimeReporting
		time.MdiParent = AE_mdiMain
		time.Show()
	End Sub

	Private Sub btnSubmitTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmitTime.Click

		Try

			' The 2nd argument (1) indicates Transfer Direction (1 = Upload, 2 = Download)
			' The 3rd argument indicates File Type (1 = XML, 2 = Images, 3 = TimeSheet XML, 4 = Exposure Declaration XML)
			Dim qTime As New frmDataSyncProgress(Directory.GetFiles(My.Settings.ae_TimeSheetTxtPath), 1, 3)
			qTime.MdiParent = AE_mdiMain.MdiParent
			qTime.Show()

			'Dim mailCount As Integer = 0
			'Dim smtpServer As New System.Net.Mail.SmtpClient
			'Dim mail As New MailMessage

			'' Send email reporting that timesheet(s) have been submitted
			'Dim strMessage As String = My.Settings.ae_DisplayName & " has submitted TimeSheet(s).  They are available for download via the ActionTimeReview Software."
			'SubmitTimeReported(My.Settings.ae_DisplayName, strMessage)


			'' Submit Exposure Declaration
			'Dim expD As New frmDataSyncProgress(Directory.GetFiles(My.Settings.expDeclPath), 1, 4)
			'expD.MdiParent = AE_mdiMain.MdiParent
			'expD.Show()





		Catch ex As Exception
			MessageBox.Show(ex.Message, "btnSubmitTime_Click")
		End Try


		'Try
		'	If My.Computer.Network.IsAvailable = True Then
		'		btnSubmitTime.Enabled = False
		'		Dim Files() As String = Directory.GetFiles(My.Settings.ae_TimeSheetTxtPath)


		'		For Each File As String In Files
		'			'ftp
		'			If (My.Computer.Network.IsAvailable) Then
		'				My.Computer.Network.UploadFile(File, My.Settings.ae_FtpTime & Path.GetFileName(File), My.Settings.ae_FTPuserName, My.Settings.ae_FTPuserCred, True, 9999, FileIO.UICancelOption.ThrowException)
		'			Else
		'				MessageBox.Show("Network unavailable try again later.", "Network Unavailable")
		'				Exit For
		'			End If

		'			mailCount += 1
		'			btnSubmitTime.Enabled = True

		'			My.Computer.FileSystem.MoveFile(File, My.Settings.ae_WarehouseTimeSheet & Path.GetFileName(File))
		'		Next
		'		MessageBox.Show("You submitted " & mailCount.ToString & " timesheet(s)", "Timesheet(s) Submitted")



		'	Else
		'		MessageBox.Show("You must be connected to the internet to submit time.", "No Internet Connection")
		'	End If


		'Catch ex As Exception
		'	MessageBox.Show(ex.Message, "Submit Time")
		'	btnSubmitTime.Enabled = True
		'End Try



	End Sub

	Private Sub btnSync_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSync.Click
		Try
			btnSync.Enabled = False

			If My.Computer.Network.IsAvailable = True Then
				Dim GetFileInfo As System.Net.FtpWebRequest = DirectCast(System.Net.FtpWebRequest.Create(My.Settings.ae_FTProotSync), System.Net.FtpWebRequest)
				With GetFileInfo
					.Credentials = New System.Net.NetworkCredential(My.Settings.ae_FTPuserName, My.Settings.ae_FTPuserCred)
					.KeepAlive = False
					.UseBinary = True
					.Method = System.Net.WebRequestMethods.Ftp.GetDateTimestamp
				End With

				Dim response As System.Net.FtpWebResponse = CType(GetFileInfo.GetResponse, System.Net.FtpWebResponse)
				Dim dt As DateTime = response.LastModified
				response.Close()

				If My.Settings.ae_RootSyncDateTime = Nothing Then

					System.IO.File.Copy(System.Deployment.Application.ApplicationDeployment.CurrentDeployment.DataDirectory & "\ActionEntry.mdb", _
					  System.Deployment.Application.ApplicationDeployment.CurrentDeployment.DataDirectory & "\ActionEntry_OLD.mdb", True)

					My.Computer.Network.DownloadFile(My.Settings.ae_FTProotSync, _
					   System.Deployment.Application.ApplicationDeployment.CurrentDeployment.DataDirectory & "\ActionEntry.mdb", _
					   My.Settings.ae_FTPuserName, _
					   My.Settings.ae_FTPuserCred, _
					   True, _
					   99999, _
					   True, _
					   FileIO.UICancelOption.ThrowException)
					My.Settings.ae_RootSyncDateTime = dt

				ElseIf dt > My.Settings.ae_RootSyncDateTime Then

					System.IO.File.Copy(System.Deployment.Application.ApplicationDeployment.CurrentDeployment.DataDirectory & "\ActionEntry.mdb", _
					System.Deployment.Application.ApplicationDeployment.CurrentDeployment.DataDirectory & "\ActionEntry_OLD.mdb", True)

					My.Computer.Network.DownloadFile(My.Settings.ae_FTProotSync, _
					   System.Deployment.Application.ApplicationDeployment.CurrentDeployment.DataDirectory & "\ActionEntry.mdb", _
					   My.Settings.ae_FTPuserName, _
					   My.Settings.ae_FTPuserCred, _
					   True, _
					   99999, _
					   True, _
					   FileIO.UICancelOption.ThrowException)
					My.Settings.ae_RootSyncDateTime = dt

				Else
					MessageBox.Show("No New Data. You are up to date.", "No New Data")
				End If

			Else
				MessageBox.Show("No internet connection. Check your network settings.", "No Internet Connection")
			End If
			btnSync.Enabled = True

		Catch ex As Exception

			System.IO.File.Copy(System.Deployment.Application.ApplicationDeployment.CurrentDeployment.DataDirectory & "\ActionEntry_OLD.mdb", _
			  System.Deployment.Application.ApplicationDeployment.CurrentDeployment.DataDirectory & "\ActionEntry.mdb", True)

			MessageBox.Show(ex.Message, "btnSync()")
			btnSync.Enabled = True

		End Try

	End Sub


	Private Sub btnReviewTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReviewTime.Click
		Dim review As New frmReviewTime
		review.MdiParent = AE_mdiMain
		review.Show()
	End Sub

	Private Sub btnManEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManEntry.Click

	End Sub

	Private Sub btnActionMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActionMail.Click, lblActionMail.Click

		For Each f As Form In AE_mdiMain.MdiChildren
			If f.Name = "frmActionMail" Then
				f.Show()
			End If
		Next


	End Sub

	
	
	Private Sub btnSheliaEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSheliaEmail.Click
		'Dim emailShelia As New frmEmailShelia
		'emailShelia.MdiParent = AE_mdiMain
		'emailShelia.Show()

	End Sub

	
	
	Private Sub btnReportEquipProb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReportEquipProb.Click
		Dim emailEquipProb As New frmEmailEquipProblem
		emailEquipProb.MdiParent = AE_mdiMain
		emailEquipProb.Show()

	End Sub

	
	Private Sub btnViewDocuments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewDocuments.Click
		Try



			Dim viewDocs As New frmDocumentsList
			viewDocs.MdiParent = AE_mdiMain.MdiParent
			viewDocs.Show()

			'' Submit Exposure Declaration
			'Dim expD As New frmDataSyncProgress(Directory.GetFiles(My.Settings.expDeclPath), 1, 4)
			'expD.MdiParent = AE_mdiMain.MdiParent
			'expD.Show()

		Catch ex As Exception

			MessageBox.Show(ex.Message, "btnViewDocuments_Click()")

		End Try
	End Sub
End Class