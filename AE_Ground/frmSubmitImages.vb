Public Class frmSubmitImages
	Dim usedDate As String
	Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
		Me.Close()
	End Sub

	Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

		btnOK.Enabled = False
		btnClose.Enabled = False
		lblProcessing.Visible = True

		Dim folderDate As String = dtpSubmitImages.Value.ToString("MM-dd-yyyy")
		usedDate = dtpSubmitImages.Value.ToString("MM-dd-yyyy")
		Dim folderPath As String = My.Settings.ae_TransferImagePath & _
	 "pic_" & _
	 folderDate & "\"

		If System.IO.Directory.Exists(folderPath) Then
			Dim imageDirectory As String() = System.IO.Directory.GetFiles(folderPath)
			Dim imageCount As Integer = System.IO.Directory.GetFiles(folderPath).Count

			MessageBox.Show("Number of images to upload: " & imageCount.ToString)



			Try

				For Each filePath In imageDirectory

					Dim fileName As String = System.IO.Path.GetFileName(filePath)
					Me.Label1.Text = "Currently uploading:  " & fileName

					My.Computer.Network.UploadFile(filePath, My.Settings.ae_FTPImageSyncURL & _
							 fileName, My.Settings.ae_FTPuserName, My.Settings.ae_FTPuserCred)

					My.Computer.FileSystem.MoveFile(filePath, My.Settings.ae_AppPath & "Warehouse\Images\pic_" & folderDate & "\" & fileName)

				Next



			Catch ex As Exception
				MessageBox.Show(ex.Message)

			End Try

		Else
			MessageBox.Show("No images available for " & dtpSubmitImages.Value.ToString("MM-dd-yyyy"))
		End If
		btnOK.Enabled = True
		btnClose.Enabled = True
		lblProcessing.Visible = False
	End Sub

	Private Sub frmUploadPics_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		usedDate = Nothing
	End Sub


	Private Sub dtpSubmitImages_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpSubmitImages.ValueChanged
		If dtpSubmitImages.Value.ToString("MM-dd-yyyy") = usedDate Then
			btnOK.Enabled = False
		Else
			btnOK.Enabled = True
		End If
	End Sub
End Class