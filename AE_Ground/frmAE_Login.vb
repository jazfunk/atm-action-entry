Option Strict On
Option Explicit On

Imports System.IO
Imports System.Xml.Serialization
Imports System.Data.OleDb
Imports AE_Ground.clsAE_Utilities

Imports System.Text
Imports System.Security.Cryptography



Public Class frmAE_Login


	Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
		Try
			Dim i As Integer = CInt(Me.cmbUsers.SelectedValue)
			Dim n As String = Me.cmbUsers.Text

			' Need to figure out to compare the hash inside the Access Query???
			'Dim p As String = GenerateHash(Me.txtPW.Text.Trim())
			'MessageBox.Show(p)

			Dim p As String = Me.txtPW.Text.Trim()
			Dim t As DataTable = Me.QryValidatePWTableAdapter.GetValidatePW(i, p)
			Dim v As Integer = t.Rows.Count
			Dim c As Boolean = CBool(Me.ckbRetain.Checked)

			' The query returns the numbers of matching records
			' (1: login success, 0: Login Failure)
			If v > 0 Then

				InitializeMySettings()

				'  UserID
				My.Settings.ae_UserID = i

				'  firstName & lastName
				My.Settings.ae_DisplayName = n


				If i <= 6 Then AE_mdiMain.ToolStripDropDownButtonTesting.Enabled = True


				'  If user selects "Remember Me" retain UserCred
				'If c And Not p Is Nothing Then My.Settings.ae_UserCred = p

				' Make sure User has entered something into the TextBox
				If p Is Nothing Or p Is String.Empty Then
					MessageBox.Show("Please provide a password." & vbCrLf & _
					 "Empty values not accepted.", "User Credentials")
				Else
					' The 'Remember Me' CheckBox
					If c Then
						My.Settings.ae_UserCred = p
						My.Settings.ae_RetainUser = True
					Else
						My.Settings.ae_UserCred = Nothing
						My.Settings.ae_RetainUser = False
					End If

					' Check for DataSync Folders
					CreateDataSyncDirectories()

					' Show Home Page
					' Develop logic to direct user to specific section/page depending on UserID or My.Settings
					' ...now I have done so...
					ShowHome(My.Settings.ae_UserID)
					'Dim showHome As New frmAE_Home
					'showHome.MdiParent = AE_mdiMain
					'showHome.Show()

					''  Display StatusText
					'AE_mdiMain.ToolStripStatusLabel.Text = "Welcome " & n

				End If

				i = Nothing
				n = Nothing
				p = Nothing
				t = Nothing
				v = Nothing

				Me.Close()

				AE_mdiMain.ToolStrip.Enabled = True

				'Dim am As New frmActionMail()
				'am.MdiParent = AE_mdiMain
				'am.Show()
				'am.Hide()



				'' Show ActionMail form only if connected
				'If InternetGetConnectedState(InternetConnectionIsConfigured, 0) = 0 Then
				'	'no connection
				'ElseIf InternetGetConnectedState(InternetConnectionIsConfigured, 0) = 1 Then
				'	'is connected

				'End If

			Else
				Dim result As DialogResult = MessageBox.Show("Authentication Failure!.  Retry?" & vbCrLf & _
				   "(Clicking CANCEL will exit ActionEntry.)", "Invalid Credentials!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

				Select Case result
					Case Windows.Forms.DialogResult.OK
						' Do nothing, return to login form
						AE_mdiMain.ToolStripStatusLabel.Text = "Login failure.  Please try again."
					Case Windows.Forms.DialogResult.Cancel
						AE_mdiMain.Close()
				End Select
			End If

			' I've disabled "Save My.Settings on Shutdown" and doing so manually
			' to hopefully resolve an error on all the netbooks (Atom processors)
			My.Settings.Save()

		Catch ex As Exception
			MessageBox.Show(ex.Message, "OK_Click()")
		End Try

	End Sub

	Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
		Application.Exit()

	End Sub

	Private Sub frmAE_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

		Try

			'' Check for DataSync Folders
			'CreateDataSyncDirectories()

			' Load users Display Names
			Me.QryUsersDisplayNamesTableAdapter.Fill(Me.ActionEntryDataSet.qryUsersDisplayNames)

			Me.QryUsersDisplayNamesBindingSource.Filter = "groupID <= 3"


			' Test for previous login ID in settings
			If Not My.Settings.ae_DisplayName Is Nothing Then

				' Set CheckBox
				Me.ckbRetain.Checked = My.Settings.ae_RetainUser

				' Test for previous UserCred in settings
				If Not My.Settings.ae_UserCred Is Nothing Then

					' select user from Settings
					With Me.cmbUsers
						.Enabled = True
						'.SelectedValue = My.Settings.ae_UserID
						.Text = My.Settings.ae_DisplayName
					End With

					' assign pw to txtPW and select
					With Me.txtPW
						.Enabled = True
						.Clear()
						.ForeColor = Color.DarkGreen
						.Text = My.Settings.ae_UserCred
					End With

					' Select OK button
					Me.OK.Select()

				Else ' Detected prev login but no saved UserCred

					' select user ID from Settings
					With Me.cmbUsers
						.Enabled = True
						'.SelectedValue = My.Settings.ae_UserID
						.Text = My.Settings.ae_DisplayName
					End With

					' Clear CheckBox
					Me.ckbRetain.Checked = False

					' Enable and Select txtPW
					With Me.txtPW
						.Enabled = True
						.Clear()
						.ForeColor = Color.Black
					End With
				End If

			Else  ' No prev login detected in settings

				' cmbUsers Default State
				With Me.cmbUsers
					.SelectedIndex = -1
					.Text = "Please Login"
					.Enabled = True
					.SelectAll()
				End With

				' txtPW Default State
				With Me.txtPW
					.ForeColor = Color.DarkGray
					.Clear()
					'.Enabled = False
				End With
			End If

		Catch ex As Exception
			DisplayEXMessage(ex, "frmAE_Login_Load()", Nothing, Nothing, Nothing, Nothing)
		End Try

	End Sub

	Private Sub cmbUsers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUsers.SelectedIndexChanged

		If Not ckbRetain.Checked Then
			Me.txtPW.Clear()
		Else
			Me.txtPW.SelectAll()
		End If
		

	End Sub



	Private Sub DisplayEXMessage(ByVal ex As Exception, _
		ByVal title As String, _
		ByVal s1 As String, _
		ByVal s2 As String, _
		ByVal s3 As String, _
		ByVal s4 As String)

		Dim t As String = Nothing
		If Not s1 Is Nothing Then
			t = _
			  "Message #1:  " & vbCrLf & s1 & vbCrLf & vbCrLf & _
			  "Message #2:  " & vbCrLf & s2 & vbCrLf & vbCrLf & _
			  "Message #3:  " & vbCrLf & s3 & vbCrLf & vbCrLf & _
			  "Message #4:  " & vbCrLf & s4 & vbCrLf & vbCrLf
			MessageBox.Show(t, title)
		Else
			MessageBox.Show(ex.Message, title)
		End If
	End Sub

End Class
