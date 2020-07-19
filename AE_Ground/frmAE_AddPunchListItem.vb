Option Strict On
Option Explicit On

Imports System.IO
Imports System.Xml.Serialization
Imports System.Data.OleDb
Imports AE_Ground.clsAE_Utilities



Public Class frmAE_AddPunchListItem

	Dim ViewAll As Boolean = False


	Private Sub BuildFileName()
		Try
			My.Settings.ae_CurrentPLfileName = _
			 "pl_" & _
			  My.Settings.ae_UserID.ToString & "_" & _
			  Now.ToString("MM-dd-yyyy") & ".xml"
		Catch ex As Exception
			My.Settings.ae_CurrentPLfileName = _
			 "pl_exception." & _
			 My.Settings.ae_UserID.ToString & "_" & _
			 Now.ToString("MM-dd-yyyy_HH:mm:ss tt") & ".xml"
		End Try
	End Sub



	Private Sub frmAE_AddPunchListItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


		' Load PunchList Categories from DataBase to ADO.NET DataSet (.xsd)
		Me.TblPunchListCategoriesTableAdapter.Fill(Me.ActionEntryDataSet.tblPunchListCategories)

		' Load Punch list Items from DataBase to ADO.NET DataSet(.xsd)
		Me.TblPunchListTableAdapter1.Fill(Me.ActionEntryDataSet.tblPunchList)

		' Load Punch List Items from DataBase to ADO.NET DataSet (.xsd) - Query
		Me.QryPunchListItemsTableAdapter.Fill(Me.ActionEntryDataSet.qryPunchListItems)

		' Filter only current user's entries
		Me.QryPunchListItemsBindingSource.Filter = "userID = " & My.Settings.ae_UserID

	End Sub

	Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

		Try
			If Me.rtbNote.Text = Nothing Or rtbNote.Text = String.Empty Then
				MessageBox.Show("You must provide a note/item for this entry.", "Error!")
				Me.rtbNote.SelectAll()
			Else
				Dim x As Integer = Me.TblPunchListTableAdapter1.Insert(CInt(Me.cmbCategories.SelectedValue), _ 
																	   My.Settings.ae_UserID, _ 
																	   Me.rtbNote.Text, _ 
																	   Now(), _ 
																	   False, _ 
																	   Nothing, _ 
																	   Nothing)

				If x > 0 Then

					Dim dt As DataTable = Me.QryPunchListItemsTableAdapter.GetData
					dt.DefaultView.RowFilter = "userID = " & My.Settings.ae_UserID

					BuildFileName()

					WriteDataSync(dt, My.Settings.ae_CurrentPLfileName)

					MessageBox.Show("Item added.  Click OK to add additional items.")
					Me.rtbNote.Clear()
					Me.rtbNote.SelectAll()

					' Reload and Refilter Data
					Me.QryPunchListItemsTableAdapter.Fill(Me.ActionEntryDataSet.qryPunchListItems)
					Me.QryPunchListItemsBindingSource.Filter = "userID = " & My.Settings.ae_UserID
				End If
			End If
		Catch ex As Exception
			MessageBox.Show(ex.Message, "btnOK_Click()")
		End Try

	End Sub

	Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
		Me.Close()

	End Sub


	Private Sub ckbViewAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbViewAll.CheckedChanged

		Select Case ViewAll
			Case True
				' Filter only current user's entries
				Me.QryPunchListItemsBindingSource.Filter = "userID = " & My.Settings.ae_UserID
			Case False
				' Filter only current user's entries
				Me.QryPunchListItemsBindingSource.Filter = Nothing
		End Select

	End Sub

	Private Sub btnAddCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCategory.Click


		Try
			Dim cat As String = InputBox("Enter Category Title.", "Enter New Category", "New Category")

			Dim x As Integer = Me.TblPunchListCategoriesTableAdapter.Insert(cat)

			If x > 0 Then
				Me.TblPunchListCategoriesTableAdapter.Fill(Me.ActionEntryDataSet.tblPunchListCategories)
			Else
				MessageBox.Show("New Category Not Entered!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			End If

		Catch ex As Exception

		End Try



	End Sub

	Private Sub rtbNote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtbNote.Click

		Me.lblInstructions.Visible = False

	End Sub
End Class