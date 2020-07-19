Option Strict On
Option Explicit On

Imports System.IO
Imports System.Xml.Serialization
Imports System.Data.OleDb
Imports AE_Ground.clsAE_Utilities
Imports System.Text.RegularExpressions




Public Class frmServiceRequest


#Region " Initialization"


#End Region


#Region " Database Communication"




#End Region


#Region " Properties"





#End Region


#Region " Class-Level Declarations"




#End Region


#Region " Methods & Functions"




#End Region


#Region " Event Handlers"

	Private Sub frmServiceRequest_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load



	End Sub

	Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

	End Sub

	Private Sub btnClearFields_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearFields.Click

	End Sub



#End Region




	Private Sub test()

		'dsAE_DataSync.dtXMLsrDataTable()

		''Create the new row
		'Dim newRow As DataRow = Me.TimeReporting.Tables("atmTimeDT").NewRow


		''Add some data to it
		'newRow("Employee") = item(1).ToString
		'newRow("JobNumber") = Me.lblJobNumber.Text
		'newRow("Day") = Me.dtpDate.Value.ToString("MM-dd-yyyy")
		'newRow("StartTime") = Me.dtpStart.Value.ToString("hh:mm tt")
		'newRow("EndTime") = Me.dtpEnd.Value.ToString("hh:mm tt")
		'newRow("TotalHours") = tTime
		'newRow("Notes") = String.Empty
		'newRow("Foreman") = My.Settings.ae_DisplayName

		''Add it to the table
		'Me.TimeReporting.Tables("atmTimeDT").Rows.Add(newRow)

		'Me.dgvTime.DataSource = Me.TimeReporting.Tables("atmTimeDT")

	End Sub





End Class