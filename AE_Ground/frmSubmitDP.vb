Option Strict On
Option Explicit On

Imports System.IO
Imports System.Xml.Serialization
Imports System.Data.OleDb
Imports AE_Ground.clsAE_Utilities





Public Class frmSubmitDP





	Private Sub frmSubmitDP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

		' Load All Active Jobs
		Me.QryActiveJobsTableAdapter.Fill(Me.ActionEntryDataSet.qryActiveJobs)
		Me.dtpDpDate.Value = Now()
		My.Settings.ae_WorkingDate = Now()

		'My.Settings.ae_CurrDataSyncFileName = "ae_" & My.Settings.ae_UserID & "_" & _
		'  Me.cmbJobs.Text & "_" & _
		'  Me.dtpDpDate.Value.ToString("MM-dd-yyyy") & ".xml"

		'If Not My.Settings.ae_CurrentJob Is Nothing Then
		'	Me.btnWriteXML.Enabled = True
		'	' Set The FileName property of DataSync in advance for easy reference
		'	My.Settings.ae_CurrDataSyncFileName = "ae_" & My.Settings.ae_UserID & "_" & _
		'	  Me.cmbJobs.Text & "_" & _
		'	  Me.dtpDpDate.Value.ToString("MM-dd-yyyy") & ".xml"
		'Else
		'	'Me.btnWriteXML.Enabled = False
		'	Me.cmbJobs.SelectAll()
		'End If

		


	End Sub

	Private Sub GetUsersDPforToday()
		Try

			Dim results As Integer = Me.QryMyDPTodayTableAdapter.Fill(Me.ActionEntryDataSet.qryMyDPToday)

			If Not Me.dtpDpDate.Checked Then
				My.Settings.ae_WorkingDate = Now()
			Else
				My.Settings.ae_WorkingDate = Me.dtpDpDate.Value
			End If

			My.Settings.ae_CurrentJob = Me.cmbJobs.Text

			Dim filterString As String = "jobNum = '" & Me.cmbJobs.Text & "' And foreman = " & My.Settings.ae_UserID & " And entryDate = #" & My.Settings.ae_WorkingDate.Date & "#"
			Me.QryMyDPTodayBindingSource.Filter = filterString

			BuildFileName()

			Me.btnWriteXML.Enabled = True

			Dim resultString As String = Me.QryMyDPTodayBindingSource.List.Count.ToString & "  (of " & results.ToString & ")  Items loaded. Click to Submit"
			Me.btnSubmitDataSync.Text = resultString

		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
	End Sub



	Private Sub DataSync()

		Try

			Me.QryMyDPTodayBindingSource.EndEdit()
			Dim dvw As DataView = CType(Me.QryMyDPTodayBindingSource.List, DataView)
			Dim dtbl As DataTable = dvw.ToTable()

			Dim i As Integer = dtbl.Rows.Count
			MessageBox.Show(i & " Records Ready to Update DataSync.  " & vbCrLf & "Click 'OK' to Continue.", "DataSync()")

			' Utilities Method
			WriteDataSync(dtbl, My.Settings.ae_CurrDataSyncFileName)

			'Me.btnSubmitDataSync.Enabled = True
			'Me.btnWriteXML.Enabled = False


		Catch ex As Exception
			MessageBox.Show(ex.Message, "DataSync()")
		End Try

	End Sub



	Private Sub btnWriteXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWriteXML.Click
		DataSync()
	End Sub

	Private Sub cmbJobs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbJobs.SelectedIndexChanged

		BuildFileName()
		
		GetUsersDPforToday()
	End Sub

	Private Sub btnSubmitDailyProductions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmitDataSync.Click

		BuildFileName()

		' Utilities Method
		'DataSyncUpload(My.Settings.ae_CurrDataSyncFileName)


	End Sub

	Private Sub dtpDpDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDpDate.ValueChanged
		GetUsersDPforToday()
	End Sub


	'Private Sub UploadXMLDataSync(ByVal fileName As String)

	'	'Try

	'	'	'Variables
	'	'	'Dim ftpsite As String = "ftp://03294ad.netsolhost.com/htdocs/ActionEntry/dpDataSync/"
	'	'	Dim local_file As String = My.Settings.ae_DataSyncPath & fileName
	'	'	Dim remote_file As String = My.Settings.ae_FTPDataSyncURL & fileName
	'	'	Dim cls_request As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create(remote_file), System.Net.FtpWebRequest)
	'	'	Dim user_name As String = "aeDataSyncFTP"
	'	'	Dim password As String = "@ctionTra44ic"

	'	'	'Establish credentials for logging into ftp site
	'	'	cls_request.Credentials = New System.Net.NetworkCredential(user_name, password)

	'	'	'Set properties
	'	'	cls_request.KeepAlive = False
	'	'	cls_request.Proxy = Nothing
	'	'	cls_request.Method = System.Net.WebRequestMethods.Ftp.UploadFile
	'	'	cls_request.UseBinary = True

	'	'	'Read in the file
	'	'	Dim b_file() As Byte = System.IO.File.ReadAllBytes(local_file)

	'	'	'Upload the file
	'	'	Dim cls_stream As System.IO.Stream = cls_request.GetRequestStream()
	'	'	cls_stream.Write(b_file, 0, b_file.Length)
	'	'	cls_stream.Close()
	'	'	cls_stream.Dispose()

	'	'	MessageBox.Show("XML file uploaded")
	'	'Catch ex As Exception
	'	'	MessageBox.Show(ex.Message)


	'	'End Try


	'End Sub


	Private Sub BuildFileName()
		My.Settings.ae_CurrDataSyncFileName = "ae_" & My.Settings.ae_UserID & "_" & _
		  Me.cmbJobs.Text & "_" & _
		  Me.dtpDpDate.Value.ToString("MM-dd-yyyy") & ".xml"
	End Sub



End Class