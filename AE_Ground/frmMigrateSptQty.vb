Option Strict On
Option Explicit On

Imports System.Data.OleDb




Public Class frmMigrateSptQty


	'  ActionTraffic.mdb
	Dim atmCon As New OleDbConnection(My.Settings.ATMConnectionString)
	Dim atmBS As BindingSource
	Dim atmDA As OleDbDataAdapter
	Dim atmDS As DataSet
	Dim atmDT As DataTable


	' ActionEntry.mdb
	Dim aeCon As New OleDbConnection(My.Settings.ActionEntryConnectionString)
	Dim aeCB As OleDbCommandBuilder
	Dim aeBS As BindingSource
	Dim aeDA As OleDbDataAdapter
	Dim aeDS As DataSet
	Dim aeDT As DataTable


	Dim ssID As Integer
	Dim pId As Integer
	Dim sQty As Integer





	Private Sub PopulateProduction()

		'  Change to select only records not null or zero or zls
		Try
			Dim cmdProduction As OleDbCommand = New OleDbCommand _
			 ("SELECT [Daily Production].[Number of Supports], " & _
			  "[Daily Production].[Autonum] " & _
			  "FROM [Daily Production] " & _
			  "WHERE [Daily Production].[Number of Supports] Is Not Null And [Daily Production].[Number of Supports] <> '0' " & _
			  "ORDER By [Daily Production].[Autonum]", atmCon)

			' Open connection to Db
			atmCon.Open()

			'  Fill dataAdapter with query result from Db
			atmDA = New OleDbDataAdapter(cmdProduction)

			' Instantiate DataSet object
			atmDS = New DataSet()

			' Fill DataSet with data from dataAdapater
			atmDA.Fill(atmDS, "Daily Production")

			'  Close the connection
			atmCon.Close()

			' Create binding source
			atmBS = New BindingSource(atmDS, "Daily Production")

			' DataTable -   Fill the DataTable object with data
			atmDT = atmDS.Tables("Daily Production")

			With Me.DataGridView1
				.DataSource = atmBS
			End With

		Catch ex As Exception
			'  Close the connection
			atmCon.Close()
			MessageBox.Show(ex.Message, "PopulateProduction()")
		End Try

	End Sub

	Private Sub PopulateCloud()

		Try
			Dim cmdCloud As OleDbCommand = New OleDbCommand _
			("SELECT tblDailyProductions.dpID, " & _
			 "tblDailyProductions.sptQty FROM tblDailyProductions ORDER By tblDailyProductions.dpID", aeCon)

			' Open connection to Db
			aeCon.Open()

			'  Fill dataAdapter with query result from Db
			aeDA = New OleDbDataAdapter(cmdCloud)

			' Instantiate DataSet object
			aeDS = New DataSet()

			' Fill DataSet with data from dataAdapater
			aeDA.Fill(aeDS, "tblDailyProductions")

			'  Close the connection
			aeCon.Close()

			' Create binding source
			aeBS = New BindingSource(aeDS, "tblDailyProductions")

			' DataTable -   Fill the DataTable object with data
			aeDT = aeDS.Tables("tblDailyProductions")

			With Me.DataGridView2
				.DataSource = aeBS
			End With

		Catch ex As Exception
			'  Close the connection
			aeCon.Close()
			MessageBox.Show(ex.Message, "PopulateCloud()")
		End Try

	End Sub




	Private Sub frmMigrateSptQty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


		PopulateProduction()
		PopulateCloud()



	End Sub

	Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

		Try

			For Each pRow As DataGridViewRow In DataGridView1.Rows
				sQty = CInt(pRow.Cells.Item(0).Value)
				pId = CInt(pRow.Cells.Item(1).Value)

				For Each cRow As DataGridViewRow In DataGridView2.Rows
					If CInt(cRow.Cells.Item(0).Value) = pId Then
						cRow.Cells.Item(1).Value = sQty
					End If
				Next
			Next

		Catch ex As Exception
			MessageBox.Show(ex.Message)

		End Try

	End Sub
End Class