Option Strict On
Option Explicit On

Imports System.IO
Imports System.Xml.Serialization
Imports System.Data.OleDb
Imports AE_Ground.clsAE_Utilities



Public Class frmViewReports

#Region " Properties"


#End Region


#Region " Methods & Functions"

	Private Sub DataSyncTypeRadioButtonControl(ByVal sender As System.Object, ByVal e As System.EventArgs) _
		Handles rbtnDP.CheckedChanged, _
		rbtnNPI.CheckedChanged, _
		rbtnGR.CheckedChanged, _
		rbtnUH.CheckedChanged

		Dim rBtn As RadioButton = DirectCast(sender, RadioButton)
		Dim dpDT As DataTable

		Select Case rBtn.Name

			Case "rbtnDP"

				If rBtn.Checked Then

					dpDT = CType(QryMyDPTodayBindingSource.List, DataView).ToTable
					Dim rptDP As New rptMyDPToday()

					rptDP.SetDataSource(dpDT)
					'CrystalReportViewer1.DisplayGroupTree = False
					CrystalReportViewer1.ReportSource = rptDP

				Else

				End If

			Case "rbtnNPI"



			Case "rbtnGR"



			Case "rbtnUH"




		End Select


	End Sub


#End Region


#Region " Class Declarations"


	Dim drag As Boolean
	Dim mousex As Integer
	Dim mousey As Integer


#End Region


#Region " Event Handlers"





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




	Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
		ShowHome(My.Settings.ae_UserID)
		Me.Close()
	End Sub









#End Region











	Private Sub frmViewReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		'TODO: This line of code loads data into the 'ActionEntryDataSet.qryMyDPToday' table. You can move, or remove it, as needed.
		Me.QryMyDPTodayTableAdapter.Fill(Me.ActionEntryDataSet.qryMyDPToday)

	End Sub
End Class