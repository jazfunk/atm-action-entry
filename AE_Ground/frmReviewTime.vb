Option Strict On
Option Explicit On

Imports System.IO
Imports System.Xml.Serialization
Imports System.Data.OleDb
Imports AE_Ground.clsAE_Utilities



Public Class frmReviewTime
	Dim submittedFiles() As String
	Dim savedFiles() As String

	Private Sub frmReviewTime_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Try
			Me.cmbTimeSheetDays.Items.Clear()

			'Saved Timesheets
			savedFiles = System.IO.Directory.GetFiles(My.Settings.ae_TimeSheetTxtPath)
			'System.Array.Sort(Of String)(savedFiles)
			'Array.Sort(savedFiles)

			For Each fileSaved In savedFiles
				Dim saved As String = System.IO.Path.GetFileNameWithoutExtension(fileSaved)
				Dim savedArray() As String = saved.Split(New Char() {"_"c})
				'Array.Sort(Of String)(savedArray)
				Dim save As String = savedArray(3)
				If savedArray(0) = "ts" Then
					Me.cmbTimeSheetDays.Items.Add(save)
				End If
			Next
		Catch ex As Exception
			MessageBox.Show(ex.Message, "frmReviewTime_Load")
		End Try
	End Sub

	Private Sub rbtnSubmitted_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnSubmitted.CheckedChanged
		Try
			If Me.rbtnSubmitted.Checked = True Then
				Me.cmbTimeSheetDays.Items.Clear()
				Me.cmbTimeSheetDays.Text = Nothing
				submittedFiles = System.IO.Directory.GetFiles(My.Settings.ae_WarehouseTimeSheet)
				'System.Array.Sort(Of String)(submittedFiles)
				'Array.Sort(Of String)(submittedFiles)

				For Each fileSubmitted In submittedFiles
					Dim submitted As String = System.IO.Path.GetFileNameWithoutExtension(fileSubmitted)
					Dim submittedArray() As String = submitted.Split(New Char() {"_"c})
					'Array.Sort(Of String)(submittedArray)
					Dim submit As String = submittedArray(3)
					If submittedArray(0) = "ts" Then
						Me.cmbTimeSheetDays.Items.Add(submit)
					End If
				Next
			End If

		Catch ex As Exception
			MessageBox.Show(ex.Message, "rbtnSubmitted_Checkedchanged")
		End Try
	End Sub

	Private Sub rbtnSaved_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnSaved.CheckedChanged
		Try
			If Me.rbtnSaved.Checked = True Then
				Me.cmbTimeSheetDays.Items.Clear()
				Me.cmbTimeSheetDays.Text = Nothing
				Dim savedFiles() As String = System.IO.Directory.GetFiles(My.Settings.ae_TimeSheetTxtPath)
				'System.Array.Sort(Of String)(savedFiles)
				'Array.Sort(Of String)(savedFiles)

				For Each fileSaved In savedFiles
					Dim saved As String = System.IO.Path.GetFileNameWithoutExtension(fileSaved)
					Dim savedArray() As String = saved.Split(New Char() {"_"c})
					'Array.Sort(Of String)(savedArray)
					Dim save As String = savedArray(3)
					If savedArray(0) = "ts" Then
						Me.cmbTimeSheetDays.Items.Add(save)
					End If
				Next
			End If
		Catch ex As Exception
			MessageBox.Show(ex.Message, "rbtnSave_CheckChanged")
		End Try

	End Sub

	Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click

		ShowHome(My.Settings.ae_UserID)
		Me.Close()

	End Sub

	Private Sub cmbTimeSheetDays_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTimeSheetDays.SelectedIndexChanged
		Try
			'Time Saved
			If rbtnSaved.Checked = True Then
				For Each fsaved In savedFiles
					Dim f As String = System.IO.Path.GetFileNameWithoutExtension(fsaved)
					Dim s() As String = f.Split(New Char() {"_"c})
					If s(0) = "ts" Then
						If s(1) = My.Settings.ae_UserID.ToString And s(3) = Me.cmbTimeSheetDays.Text.Trim Then
							Dim xmlFile As System.Xml.XmlReader
							xmlFile = System.Xml.XmlReader.Create(fsaved)
							Dim ds As New DataSet
							ds.ReadXml(xmlFile)
							dgvReviewTime.DataSource = ds.Tables("atmTimeDT")
							Me.lblReviewTime.Text = "Reviewing saved time for " & Me.cmbTimeSheetDays.Text
							Exit For
						End If
					End If
				Next
			End If

			'Time Submitted
			If rbtnSubmitted.Checked = True Then
				For Each fsubmit In submittedFiles
					Dim submitf As String = System.IO.Path.GetFileNameWithoutExtension(fsubmit)
					Dim fsub() As String = submitf.Split(New Char() {"_"c})
					If fsub(0) = "ts" Then
						If fsub(1) = My.Settings.ae_UserID.ToString And fsub(3) = Me.cmbTimeSheetDays.SelectedItem.ToString Then
							Dim xmlfile As System.Xml.XmlReader
							xmlfile = System.Xml.XmlReader.Create(fsubmit)
							Dim ds As New DataSet
							ds.ReadXml(xmlfile)
							dgvReviewTime.DataSource = ds.Tables("atmTimeDT")
							Me.lblReviewTime.Text = "Reviewing submitted time for " & Me.cmbTimeSheetDays.Text
							Exit For
						End If
					End If
				Next
			End If

		Catch ex As Exception
			MessageBox.Show(ex.Message, "cmbTimeSheet_SelectionChange")
		End Try

	End Sub



End Class