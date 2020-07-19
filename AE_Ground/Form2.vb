Option Strict On
Option Explicit On

Imports System.IO
Imports System.Xml.Serialization
Imports System.Data.OleDb
Imports AE_Ground.clsAE_Utilities



Public Class Form2

	Dim startDate As Date
	Dim endDate As Date




	Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

		
		Me.DPTableAdapter.Fill(Me.ActionEntryDataSet.DP, My.Settings.ae_CurrentJob)
		'Dim jobsDT As DataTable = AE_Ground.ActionEntryDataSetTableAdapters.tblJobsTableAdapter

		'Dim activeJobsTableAdapter As New AE_Ground.ActionEntryDataSetTableAdapters.qryActiveJobsTableAdapter
		'activeJobsTableAdapter.Fill(Me.ActionEntryDataSet.qryActiveJobs)
		Dim jobsDT As New AE_Ground.ActionEntryDataSet.qryActiveJobsDataTable
		jobsDT = Me.ActionEntryDataSet.qryActiveJobs

		With Me.cmbJob
			.DataSource = jobsDT
			.DisplayMember = "jobNum"
			.ValueMember = "jobNum"
			.Text = My.Settings.ae_CurrentJob
		End With

	End Sub

	Private Sub btnRange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRange.Click


		Try

			Me.startDate = Me.dtpStartDate.Value
			Me.endDate = Me.dtpEndDate.Value

			Me.DPTableAdapter.Fill(Me.ActionEntryDataSet.DP, Me.cmbJob.Text)
			Me.DPBindingSource.Filter = "foreman = " & My.Settings.ae_UserID & " AND " & _
				String.Format("entryDate >= #{0:MM/dd/yyyy}# AND entryDate <= #{1:M/dd/yyyy}#", startDate, endDate)

			rptDP31.SetDataSource(CType(Me.DPBindingSource.List, DataView).ToTable)

			With Me.CrystalReportViewer1
				.ReportSource = rptDP31
				.Zoom(1)
				'.DisplayGroupTree = False

			End With

		Catch ex As Exception
			MessageBox.Show(ex.Message, "btnRange_Click()")

		End Try


	End Sub












End Class