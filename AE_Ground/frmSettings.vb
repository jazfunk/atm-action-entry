Option Strict On
Option Explicit On

Imports System.IO
Imports System.Xml.Serialization
Imports System.Data.OleDb
Imports AE_Ground.clsAE_Utilities



Public Class frmSettings

	Public Sub New(ByVal adminView As Boolean)

		' This call is required by the Windows Form Designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		If adminView = True Then
			Me.pGridMyAppSettings.Enabled = True
			Me.SplitContainer1.Panel1Collapsed = True
		Else
			Me.pGridMyAppSettings.Enabled = False
			Me.SplitContainer1.Panel2Collapsed = True
		End If


	End Sub

	Private Sub frmSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

		Me.pGridMyAppSettings.SelectedObject = My.Settings

		txtCurrentJob.Text = My.Settings.ae_CurrentJob
		txtPayItemFilter.Text = My.Settings.ae_PayItemsFilter
		txtUserCred.Text = My.Settings.ae_UserCred
		txtDisplayName.Text = My.Settings.ae_DisplayName
		txtUserId.Text = My.Settings.ae_UserID.ToString
		ckbRetainUser.Checked = My.Settings.ae_RetainUser

	End Sub

	Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
		Me.Close()
	End Sub
End Class