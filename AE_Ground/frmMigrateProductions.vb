Option Strict On
Option Explicit On

Imports System.Data
Imports System.Data.OleDb




Public Class frmMigrateProductions


#Region " Class-level declarations"





#End Region


#Region " Methods & Functions"





#End Region



#Region " Event Procedures"


	Private Sub frmMigrateProductions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

		'***********************************************************************************************
		' \\Vitals:
		'***********************************************************************************************
		'****************All Code, Logic, Concepts And DBMS Developed For And Owned By:****************'
		'	Action Traffic Maintenance, Inc.
		'	Michigan Highway Signs, Inc.
		'	Jeff King......:  Lead Software Engineer/DBMS Manager
		'	Luke McClain...:  Software Developer/Hardware Technician
		'	Michael Peake..:  Systems Consultant/End-User: Administrative
		'	Paul Roth......:  Systems Consultant/End-User: Administrative
		'***********************************************************************************************
		' \\Keys:
		'***********************************************************************************************
		'	Purpose....:  
		'	Input......:  
		'	Output.....:  
		'	Issues.....:  -
		'				  -
		'				  -
		'				  -
		'***********************************************************************************************

		Try
			' Change Cursor, Signal to user the application is thinking
			Me.Cursor = Cursors.WaitCursor


			'	TODO:  Process Logic 


		Catch ex As Exception
			MessageBox.Show(ex.Message, "frmMigrateProductions_Load()")
		Finally
			' Change Cursor to Normal
			Me.Cursor = Cursors.Arrow
		End Try


	End Sub



#End Region

	


#Region " Testing"





#End Region




End Class