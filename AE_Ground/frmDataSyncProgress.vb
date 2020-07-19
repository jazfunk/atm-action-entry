Option Strict On
Option Explicit On

Imports System.IO
Imports System.Xml.Serialization
Imports System.Data.OleDb
Imports AE_Ground.clsAE_Utilities





Public Class frmDataSyncProgress

	Public Sub New(ByVal fileNames() As String, ByRef transferDirection As Integer, ByRef fileType As Integer)

		
		' This call is required by the Windows Form Designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

		' transferDirection:  1 = Upload, 2 = Download
		' filetype:  1 = XML, 2 = Images

		filesToXfer = fileNames
		fileCount = filesToXfer.Count
		typeOfFile = fileType
		dir = transferDirection

		UploadComplete = False


	End Sub

	Private _uploadComplete As Boolean
	Public Property UploadComplete() As Boolean
		Get
			Return _uploadComplete
		End Get
		Set(ByVal value As Boolean)
			_uploadComplete = value
		End Set
	End Property



	Dim drag As Boolean
	Dim mousex As Integer
	Dim mousey As Integer


	' Class level
	Dim filesToXfer() As String
	Dim fileCount As Integer
	Dim dir As Integer
	Dim typeOfFile As Integer
	Dim countDisplay As String
	Dim currentFileName As String


	Private Sub frmDataSyncProgress_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Try
			Me.lblStatus.Text = "Ready to Transfer " & fileCount.ToString & " files"
			Me.btnCloseProgress.Enabled = False

			Select Case dir

				Case 1
					Me.picAvatar.Image = My.Resources.Upload

				Case 2
					Me.picAvatar.Image = My.Resources.Download

			End Select

		Catch ex As Exception
			MessageBox.Show(ex.Message, "frmDataSyncProgress_Load()")
		End Try


	End Sub

	Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick




	End Sub

	Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

		Try
			' Counter
			'Dim myUri As Uri
			Dim x As Integer = 1
			Select Case dir
				Case 1	' Upload
					For Each f As String In filesToXfer

						If BackgroundWorker1.CancellationPending Then
							e.Cancel = True
							Exit For
						End If

						' Determine if XML or Images

						Select Case typeOfFile
							Case 1	' XML

								'myUri = New Uri(My.Settings.ae_FTPDataSyncURL & Path.GetFileName(f))
								XmlUpload(f)
								'UploadSingleFile(f, myUri, "www.actiontraffic.net")


							Case 2	' Images
								'myUri = New Uri(My.Settings.ae_FTPImageSyncURL & Path.GetFileName(f))

								'ImageUpload(Path.GetFileName(f))
								ImageUpload(f)
								'UploadSingleFile(f, myUri, "www.actiontraffic.net")

							Case 3	 ' XML TimeSheets

								TimeXmlUpload(f)

							Case 4

								ExpDecXmlUpload(f)


						End Select

						currentFileName = f
						Me.BackgroundWorker1.ReportProgress(CInt((x / fileCount) * 100))
						x += 1
						countDisplay = "Uploading File " & x.ToString & " of " & fileCount.ToString

					Next

				Case 2	' Download

					For Each f2 As String In filesToXfer
						If BackgroundWorker1.CancellationPending Then
							e.Cancel = True
							Exit For
						End If

						' Determine if XML or Images

						Select Case typeOfFile
							Case 1	' XML
								'myUri = New Uri(My.Settings.ae_FTPDataSyncURL & Path.GetFileName(f2))
								'MessageBox.Show(myUri.ToString)
								'DownloadSingleFile(f2, myUri, "www.actiontraffic.net")

								XmlDownload(Path.GetFileName(f2))

								If File.Exists(My.Settings.ae_TransferDataSyncPath & Path.GetFileName(f2)) Then
									DeleteFile(My.Settings.ae_FTPDataSyncURL & f2)
									Dim lastFile As Date = File.GetLastAccessTime(f2)
								End If
								'GetImageFromFTP(My.Settings.ae_FTPDataSyncURL, Path.GetFileName(f2), My.Settings.ae_TransferDataSyncPath)

							Case 2	' Images
								'myUri = New Uri(My.Settings.ae_FTPImageSyncURL & Path.GetFileName(f2))
								'MessageBox.Show(myUri.ToString)
								'DownloadSingleFile(f2, myUri, "www.actiontraffic.net")

								ImageDownload(Path.GetFileName(f2))

								Dim fName As String = Path.GetFileName(f2)
								Dim astr() As String = fName.Split(New Char() {"_"c})

								'if the download was sucessful delete from the ftp server
								If File.Exists(My.Settings.ae_DownloadImagePath & astr(2) & "\Images\Pic_" & astr(4) & "\" & Path.GetFileName(f2)) Then
									DeleteFile(My.Settings.ae_FTPImageSyncURL & f2)
								End If

								'GetImageFromFTP(My.Settings.ae_FTPImageSyncURL, Path.GetFileName(f2), My.Settings.ae_DownloadImagePath)

						End Select

						currentFileName = f2
						Me.BackgroundWorker1.ReportProgress(CInt((x / fileCount) * 100))
						x += 1
						countDisplay = "Downloading File " & x.ToString & " of " & fileCount.ToString

					Next

			End Select

		Catch ex As Exception
			MessageBox.Show(ex.Message, "BackgroundWorker1_DoWork()")
		End Try

	End Sub

	Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged

		' Update the progress bar
		Me.ProgressBar1.Value = e.ProgressPercentage

		Me.lblStatus.Text = countDisplay
		Me.lstTransferList.Items.Add(Path.GetFileName(currentFileName))
		Me.lstTransferList.SelectedIndex = Me.lstTransferList.Items.Count - 1

		Me.lblDisplayPercentage.Text = e.ProgressPercentage.ToString & "%"

	End Sub

	Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

		If e.Cancelled Then
			My.Settings.ae_DataSyncComplete = True
			Me.btnCloseProgress.Enabled = False
			Me.btnAction.Text = "Close"
			Me.lblStatus.Text = "Transfer Cancelled"
		Else
			Me.UploadComplete = True
			Me.btnCloseProgress.Enabled = False
			Me.btnAction.Enabled = True
			Me.btnAction.Text = "Close"

			Me.lblStatus.Text = "All files transferred successfully!"
		End If
		With AE_mdiMain.ToolStripProgressBar1
			.MarqueeAnimationSpeed = 0
			.ProgressBar.Value = 0
		End With
		AE_mdiMain.ToolStripStatusLabel1.Text = "Idle"


	End Sub

	Private Sub btnAction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAction.Click

		Try
			Me.lblStatus.Text = "-->Gathering required information." & vbCrLf


			If Me.btnAction.Text = "Close" Then
				Me.Close()
			Else
				Select Case dir
					Case 1
						Me.btnAction.Text = "Uploading"
					Case 2
						Me.btnAction.Text = "Downloading"
				End Select

				Me.btnAction.Enabled = False
				Me.btnCloseProgress.Enabled = True

				Me.lblStatus.Text = Me.btnAction.Text & " File 1 of " & fileCount
				' Upload DataSync on a separate thread 
				With AE_mdiMain.ToolStripProgressBar1
					.MarqueeAnimationSpeed = 200
					.ProgressBar.Value = 0
				End With
				AE_mdiMain.ToolStripStatusLabel1.Text = "Working"
				Me.BackgroundWorker1.RunWorkerAsync()
			End If


		Catch ex As Exception
			MessageBox.Show(ex.Message, "btnAction_Click()")
		End Try

	End Sub

	Private Sub btnCloseProgress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseProgress.Click

		If MessageBox.Show("Are you sure you want to cancel the transfer?", _
			   "DataSync Interrupted", _
			   MessageBoxButtons.OKCancel, _
			   MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then

			' Is BackGroundWorker1 Working?
			Try
				If Me.BackgroundWorker1.IsBusy Then
					If Me.BackgroundWorker1.WorkerSupportsCancellation Then
						Me.btnAction.Enabled = True
						Me.BackgroundWorker1.CancelAsync()
					End If
				Else
					MessageBox.Show("BackGroundWorker is not currently busy", "Cannot Stop")
				End If
			Catch ex As Exception
				MessageBox.Show(ex.Message, "btnCloseProgress_Click()")
			End Try
		End If

	End Sub


	' Form Dragging Logic

	Private Sub pnlTitleBar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlTitleBar.MouseDown

		drag = True
		mousex = Windows.Forms.Cursor.Position.X - Me.Left
		mousey = Windows.Forms.Cursor.Position.Y - Me.Top
	
	End Sub

	Private Sub pnlTitleBar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlTitleBar.MouseMove
		If drag Then
			Me.Top = Windows.Forms.Cursor.Position.Y - mousey
			Me.Left = Windows.Forms.Cursor.Position.X - mousex
		End If
	End Sub

	Private Sub pnlTitleBar_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlTitleBar.MouseUp
		drag = False

	End Sub

	Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
		Me.Close()
	End Sub

	'Private Sub frmDataSyncProgress_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown

	'End Sub

	
End Class