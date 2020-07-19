Option Strict On
Option Explicit On

Imports System.IO
Imports System.Xml.Serialization
Imports System.Data.OleDb
Imports AE_Ground.clsAE_Utilities


Public Class frmPassWzd


	'  (Action Traffic.mdb) connection
	Dim ATMconn As New OleDbConnection(My.Settings.ActionEntryConnectionString)



	Private Sub frmPassWzd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		''TODO: This line of code loads data into the 'ActionEntryDataSet.tblUsers' table. You can move, or remove it, as needed.
		'Me.TblUsersTableAdapter.Fill(Me.ActionEntryDataSet.tblUsers)

	End Sub

	Private Sub wzd_PassCurrentPass_CancelButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles wzd_PassCurrentPass.CancelButtonClick
		Me.Close()
	End Sub


	Private Sub wzd_PassCurrentPass_NextButtonClick(ByVal sender As Object, ByVal e As ActiproSoftware.Wizard.WizardPageCancelEventArgs) Handles wzd_PassCurrentPass.NextButtonClick
		If Me.txtCurrentPass.Text = My.Settings.ae_UserCred Then

		Else
			e.Cancel = True
			MessageBox.Show("Incorrect Password!", "Incorrect Password")
		End If
	End Sub

	Private Sub wzd_PassNewPass_CancelButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles wzd_PassNewPass.CancelButtonClick
		Me.Close()
	End Sub


	Private Sub wzd_PassNewPass_NextButtonClick(ByVal sender As Object, ByVal e As ActiproSoftware.Wizard.WizardPageCancelEventArgs) Handles wzd_PassNewPass.NextButtonClick
		If txtNewPass.Text = Nothing Or txtConfirmPass.Text = Nothing Then
			e.Cancel = True
			MessageBox.Show("You must enter a password.", "Must Enter Password")
		Else
			If Me.txtNewPass.Text = Me.txtConfirmPass.Text Then
				Me.lblHidden.Text = Me.txtNewPass.Text

				UpdateDb(My.Settings.ae_UserID)
				My.Settings.ae_UserCred = Me.txtNewPass.Text

				'Me.Validate()
				'Me.TblUsersBindingSource.EndEdit()
				'Dim processedRecords As Integer = Me.TblUsersTableAdapter.Update(Me.ActionEntryDataSet.tblUsers)

				'If processedRecords > 0 Then
				'	MessageBox.Show(processedRecords.ToString)
				'Else
				'	e.Cancel = True
				'	MessageBox.Show("Something is wrong, the database was not updated." & processedRecords.ToString)
				'End If

			Else

				MessageBox.Show("Passwords do not match.", "Do not match")
				e.Cancel = True

			End If
		End If

	End Sub


	Private Sub UpdateDb(ByVal i As Integer)

		' Validate for:
		' String.Empty
		' Invalid characters (spaces, etc.)

		' DataSync!  Need to figure out how to notify
		' master DB that pw was changed




		Me.Cursor = Cursors.WaitCursor


		Try

			Dim cmdUpdateUserCred As New OleDbCommand("UPDATE tblUsers SET " & _
			  "pw = @pw " & _
			  "WHERE ID = @ID", ATMconn)

			cmdUpdateUserCred.Parameters.AddWithValue("@pw", Me.txtConfirmPass.Text)
			cmdUpdateUserCred.Parameters.AddWithValue("@ID", i)


			ATMconn.Open()
			' use this variable later to display number of records updated
			Dim updateCount As Integer = cmdUpdateUserCred.ExecuteNonQuery()
			ATMconn.Close()

			If updateCount > 0 Then
				My.Settings.ae_UserCred = Me.txtConfirmPass.Text
				MessageBox.Show("updated")
			Else
				MessageBox.Show("not updated")

			End If

		Catch ex As Exception
			MessageBox.Show(ex.Message, "updateDB()")
			ATMconn.Close()

		End Try

		Me.Cursor = Cursors.Arrow


	End Sub

	Private Sub wzd_PassWelcomePage_CancelButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles wzd_PassWelcomePage.CancelButtonClick
		Me.Close()
	End Sub

	Private Sub wzd_PassCurrentUser_CancelButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles wzd_PassCurrentUser.CancelButtonClick
		Me.Close()
	End Sub

	Private Sub wzd_PassFinish_CancelButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles wzd_PassFinish.CancelButtonClick
		Me.Close()
	End Sub

	Private Sub wzd_PassFinish_FinishButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles wzd_PassFinish.FinishButtonClick
		Me.Close()
	End Sub
End Class
