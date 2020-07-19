Option Strict On
Option Explicit On

Imports System.IO
Imports System.Xml.Serialization
Imports System.Data.OleDb
Imports AE_Ground.clsAE_Utilities

Public Class frmUploadPicDate
	Dim fileList As New List(Of Date)

	Private Sub frmUploadPicDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Try
			Dim dir() As String = System.IO.Directory.GetDirectories(My.Settings.ae_TransferImagePath).ToArray
			Dim i As Integer = 0

			While i < dir.Length
				If dir(i) IsNot Nothing Then
					Dim splitdir() As String = dir(i).Split(New Char() {"\"c})


					Dim splitStr() As String = splitdir(3).Split(New Char() {"_"c})
					Dim astr As Date = Date.Parse(splitStr(1))

					If Not astr = Nothing Then

						fileList.Add(astr)

					End If
				End If
				i += 1
			End While

			mnthCalUploadPicDate.BoldedDates = fileList.ToArray

		Catch ex As Exception
			MessageBox.Show(ex.Message, "frmUploadPicDate_Load")
		End Try

	End Sub

	Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
		Me.Close()
	End Sub

	Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

		Dim filedate As Date = mnthCalUploadPicDate.SelectionEnd
		Dim x As Integer = 0
		Dim i As Integer = 0

		For Each file As Date In fileList.ToArray
			Dim dateStr As String = file.ToString("MM-dd-yyyy")

			'If the selected date matches a directory in C:\ActionEntry\picUpload\
			If filedate.ToString("MM-dd-yyyy") = dateStr Then
				Process.Start("explorer.exe", My.Settings.ae_TransferImagePath & "Pic_" & filedate.ToString("MM-dd-yyyy"))
				Me.Close()
				x = 1
			End If
			i += 1
		Next

		If x = 0 Then
			MessageBox.Show("No Images for " & filedate.ToString("MM-dd-yyyy") & ", please select a bolded date.", "No image for " & filedate.ToString("MM-dd-yyyy"))
		End If
	End Sub

	Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click
		Dim uploadDate As Date = mnthCalUploadPicDate.SelectionEnd
		Dim uploadDateStr As String = uploadDate.ToString("MM-dd-yyyy")

		If System.IO.Directory.Exists(My.Settings.ae_TransferImagePath & "Pic_" & uploadDateStr & "\") Then
			Dim imageDirectory As String() = System.IO.Directory.GetFiles(My.Settings.ae_TransferImagePath & "Pic_" & uploadDateStr & "\")
			Me.Close()

			' The 2nd argument indicates Transfer Direction (1 = Upload, 2 = Download)
			' The 3rd argument indicates File Type (1 = XML, 2 = Images)
			Dim qAE As New frmDataSyncProgress(imageDirectory, 1, 2)
			qAE.MdiParent = AE_mdiMain.MdiParent
			qAE.Show()

		Else
			MessageBox.Show("No images available for " & uploadDateStr)
		End If
	End Sub
End Class