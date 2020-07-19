Option Strict On
Option Explicit On

Imports System.IO
Imports System.Xml.Serialization
Imports System.Data.OleDb
Imports AE_Ground.clsAE_Utilities


Imports System.Windows.Forms

Public Class AE_mdiMain

    

	Private Sub OpenFile()
		Dim OpenFileDialog As New OpenFileDialog
		OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
		OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
		If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
			Dim FileName As String = OpenFileDialog.FileName
			' TODO: Add code here to open the file.
		End If
	End Sub

	Private Sub SaveAsTool()
		Dim SaveFileDialog As New SaveFileDialog
		SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
		SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

		If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
			Dim FileName As String = SaveFileDialog.FileName
			' TODO: Add code here to save the current contents of the form to a file.
		End If
	End Sub


    

	
	Private Sub AE_mdiMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		Dim OpenLogin As New frmAE_Login
		OpenLogin.MdiParent = Me
		OpenLogin.Show()

	End Sub

	Private Sub btnCloseApp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseApp.Click

		'Application.Exit()

		Me.Close()

	End Sub

	Private Sub ToolStripButtonHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonHome.Click

		ShowHome(My.Settings.ae_UserID)
		'For Each f As Form In Me.MdiChildren
		'	If f.Name = "frmAE_Home" Then f.Show()
		'Next
	End Sub

	Private Sub ToolStripDropDownButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripDropDownButtonTesting.Click
		'Dim testForm As New frmReviewDataSync
		'testForm.MdiParent = Me
		'testForm.Show()

		'Dim mergeDP As New frmMergeDP
		'mergeDP.MdiParent = Me
		'mergeDP.Show()

	End Sub



	Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
		'Dim testNewHome As New frmAE_HomeExpress
		'testNewHome.MdiParent = Me
		'testNewHome.Show()

	End Sub

	Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
		Dim loadPassWzd As New frmPassWzd
		loadPassWzd.MdiParent = Me
		loadPassWzd.Show()
	End Sub

	Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click

		
		Dim s As String = System.Reflection.Assembly.GetExecutingAssembly().CodeBase
		MessageBox.Show(s, "GAC Location/Path")

		Dim f As New frmSafetyInspection
		f.MdiParent = Me
		f.Show()



	End Sub

	Private Sub DailyProductionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyProductionToolStripMenuItem.Click
		Dim viewRpt As New frmViewReports
		viewRpt.MdiParent = Me
		viewRpt.Show()

	End Sub

	Private Sub ToolStripDropDownButtonTesting_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripDropDownButtonTesting.ButtonClick
		Dim mergeDP As New frmMergeDP
		mergeDP.MdiParent = Me
		mergeDP.Show()
	End Sub

	Private Sub ToolStripSplitButtonTime_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSplitButtonTime.ButtonClick

	End Sub

	Private Sub ReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportsToolStripMenuItem.Click
		Dim frm As New frmReviewDataSync
		frm.MdiParent = Me
		frm.Show()

	End Sub

	Private Sub ActionMailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActionMailToolStripMenuItem.Click

		'Dim am As New frmActionMail()
		'am.MdiParent = Me
		For Each f As Form In Me.MdiChildren
			If f.Name = "frmActionMail" Then
				f.Show()
			End If
		Next

	End Sub

	
End Class
