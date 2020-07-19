Option Strict On
Option Explicit On

Imports System.IO
Imports System.Xml.Serialization
Imports System.Data.OleDb
Imports AE_Ground.clsAE_Utilities
Imports System.Threading



Public Class frmReconcileDP


#Region " Class-Level ADO.Net Objects"

	'  (Action Traffic.mdb) connection
	Dim ATMconn As New OleDbConnection(My.Settings.atmLocalConStr)

	Dim payItemDA As OleDbDataAdapter
	Dim payItemBS As BindingSource
	Dim payItemDS As DataSet
	Dim payItemDT As DataTable

	Dim atmJobDA As OleDbDataAdapter
	Dim atmJobBS As BindingSource
	Dim atmJobDS As DataSet
	Dim atmJobDT As DataTable

	Dim productionBS As BindingSource
	Dim productionDA As OleDbDataAdapter
	Dim productionDS As DataSet
	Dim productionDT As DataTable

	'  :-(
	Dim foremanDA As OleDbDataAdapter
	Dim foremanDS As DataSet
	Dim foremanDT As DataTable

	' Cloud (DataSync)
	Dim xmlBS As BindingSource
	Dim xmlDS As DataSet
	Dim xmlDT As DataTable





#End Region


#Region " Methods & Functions"

	' Cloud (DataSync) DB

	Public Function GetDataSetFromDataSync(ByVal DataSyncToClean As String) As DataSet

		Dim cleanDS As DataSet
		Try
			cleanDS = New DataSet(DataSyncToClean)
			cleanDS.ReadXml(My.Settings.ae_TransferDataSyncPath & DataSyncToClean)
			Return cleanDS

		Catch ex As Exception
			Return Nothing
		End Try

	End Function

	Private Function MergeAllDataSets(ByVal targetDirectory As String) As DataSet

		Try
			Dim MasterDataSet As New DataSet
			Dim fileEntries As String() = System.IO.Directory.GetFiles(targetDirectory)
			
			For Each f As String In fileEntries
				ListBox1.Items.Add(Path.GetFileName(f))
				Dim tempName As String = Path.GetFileName(f)
				'' Split the string on the underscore character
				'Dim parts As String() = fileName.Split(New Char() {"_"c})
				'For Each part As String In parts

				'  Get jobNum from each fileName and create an array, bound to a cmb
				'  to display only available DataSync files.d

				''Next

				Dim tDs As New TempDataSet
				tDs.TheDataSet = GetDataSetFromDataSync(tempName)
				MasterDataSet.Merge(tDs.TheDataSet, True)

			Next
			
			Return MasterDataSet

		Catch ex As Exception
			MessageBox.Show(ex.Message, "MergeAllDataSets()")

			Return Nothing

		End Try



	End Function

	Private Sub ViewAllDP()
		Try
			xmlDS = MergeAllDataSets(My.Settings.ae_TransferDataSyncPath)

			'create dataset from not verified xml
			'merge datasets
			'recreate not verified xml
			'10.1.11

			If xmlDS IsNot Nothing Then
				xmlBS = New BindingSource(xmlDS, "qryMyDPToday")
				With Me.dgvCloudDP
					.DataSource = xmlBS

					' Foreman ID
					.Columns(0).Visible = False

					' EntryDate
					.Columns(1).Visible = False

					' DisplayName
					.Columns(2).Visible = True
					.Columns(2).HeaderText = "Foreman"

					' ID
					.Columns(3).Visible = False

					' dpID
					.Columns(4).Visible = False

					' jobNum
					.Columns(5).Visible = True

					' Station#
					.Columns(6).Visible = True
					.Columns(6).HeaderText = "Station #"

					' payItemID
					.Columns(7).Visible = False

					' code
					.Columns(8).Visible = False

					' Description
					.Columns(9).Visible = True
					.Columns(9).HeaderText = "Description"

					' Qty
					.Columns(10).Visible = True
					.Columns(10).HeaderText = "Qty"

					' siteNotes
					.Columns(11).Visible = False
				End With
				BindCloud()
			End If

		Catch ex As Exception
			'MessageBox.Show(ex.Message, "")
		End Try
	End Sub

	Private Sub BindCloud()

		' Clear DataBindings
		Me.lblCloudDisplayName.DataBindings.Clear()
		Me.txtCloudStation.DataBindings.Clear()
		Me.txtQty.DataBindings.Clear()
		Me.txtSiteNotes.DataBindings.Clear()


		' Add DataBindings
		Me.lblCloudDisplayName.DataBindings.Add("Text", xmlBS, "displayName")
		Me.txtCloudStation.DataBindings.Add("Text", xmlBS, "displayName")
		Me.txtQty.DataBindings.Add("Text", xmlBS, "dpQty")
		Me.txtSiteNotes.DataBindings.Add("Text", xmlBS, "siteNotes")
		Me.cmbPayItems.DataBindings.Add("Text", xmlBS, "description")



	End Sub

	Private Sub FilterCloud(ByVal fieldName As String, ByVal searchStr As String)

		'Try
		'	Dim filterStr As String = String.Format("{0} = '{1}'", fieldName, searchStr)
		'	Me.xmlDT.DefaultView.RowFilter = filterStr
		'Catch ex As Exception
		'	MessageBox.Show(ex.Message, "FilterProduction()")
		'End Try


	End Sub



	' Production DB

	Private Sub GetJobPayItems(ByVal Project As String)

		Try

			'("SELECT * FROM [PAY ITEM PICK LIST]", ATMconn)

			Dim payItemCmd As OleDbCommand = New OleDbCommand _
			 ("SELECT [Job Pay Items].[Job #], [Job Pay Items].[PayItemID] as jPid, " & _
			 "[PAY ITEM PICK LIST].[PayItemID], [PAY ITEM PICK LIST].[CODE], " & _
			 "[PAY ITEM PICK LIST].[DESCRIPTION], [PAY ITEM PICK LIST].[UNIT] " & _
			 "FROM [Job Pay Items] " & _
			 "LEFT OUTER JOIN [PAY ITEM PICK LIST] " & _
			 "ON [Job Pay Items].[PayItemID] = [PAY ITEM PICK LIST].[PayItemID]" & _
			 "WHERE [Job Pay Items].[Job #] = @atmJobNum", ATMconn)

			payItemCmd.Parameters.AddWithValue("@atmJobNum", Project)

			' Open connection to Db
			ATMconn.Open()

			'  Fill dataAdapter with query result from Db
			payItemDA = New OleDbDataAdapter(payItemCmd)

			' Instantiate DataSet object
			payItemDS = New DataSet()

			' Fill DataSet with data from dataAdapater
			payItemDA.Fill(payItemDS, "[Job Pay Items]")

			' Create binding source
			payItemBS = New BindingSource(payItemDS, "[Job Pay Items]")

			'  Close the connection
			ATMconn.Close()

			' Bind pay item combo box and set properties
			With Me.cmbPayItems
				.DataSource = payItemBS
				.DisplayMember = "description"
				.ValueMember = "jpid"
			End With

		Catch ex As Exception
			MessageBox.Show(ex.Message, "getJobPayItems()")
		End Try

	End Sub

	Private Sub GetActiveJobs()

		Try
			Dim atmJobCmd As OleDbCommand = New OleDbCommand _
			 ("SELECT [JOB #] As jn, [LOCATION] As location From [JOB LIST] As atmJL WHERE Active = True ORDER By [JOB #] DESC", ATMconn)

			' Open connection to Db
			ATMconn.Open()

			'  Fill dataAdapter with query result from Db
			atmJobDA = New OleDbDataAdapter(atmJobCmd)

			' Instantiate DataSet object
			atmJobDS = New DataSet()

			' Fill DataSet with data from dataAdapater
			Dim x As Integer = atmJobDA.Fill(atmJobDS, "atmJL")
			'MessageBox.Show(x.ToString)


			' Create binding source
			atmJobBS = New BindingSource(atmJobDS, "atmJL")

			' DataTable -   Fill the DataTable object with data
			atmJobDT = atmJobDS.Tables(0)

			'  Close the connection
			ATMconn.Close()

			With Me.cmbJobs
				.DataSource = atmJobBS
				.DisplayMember = "jn"
			End With

			Me.Label1.DataBindings.Clear()
			Me.Label1.DataBindings.Add("Text", atmJobBS, "location")



		Catch ex As Exception
			MessageBox.Show(ex.Message, "PopulateATMJobs()")

		End Try

	End Sub

	Private Sub GetProduction()

		' Declare and set the alignment property
		Dim objAlignMidcellStyle As New DataGridViewCellStyle()
		objAlignMidcellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

		' Declare and set the alignment property
		Dim objAlignMidRightcellStyle As New DataGridViewCellStyle()
		objAlignMidRightcellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

		Try
			Dim cmdProduction As OleDbCommand = New OleDbCommand _
			 ("SELECT [Daily Production].[JOB #], " & _
			  "[Daily Production].Site, " & _
			  "[PAY ITEM PICK LIST].CODE, " & _
			  "[PAY ITEM PICK LIST].DESCRIPTION, " & _
			  "[Daily Production].[Daily Production], " & _
			  "[PAY ITEM PICK LIST].UNIT, " & _
			  "[Daily Production].[Contract Qty], " & _
			  "[Daily Production].Date, " & _
			  "[Daily Production].[Station with Support], " & _
			  "[Daily Production].Foreman, " & _
			  "[Daily Production].[Autonum] " & _
			  "FROM [Daily Production] " & _
			  "INNER JOIN [PAY ITEM PICK LIST] ON [Daily Production].PayItemID = [PAY ITEM PICK LIST].PayItemID " & _
			  "WHERE ((([Daily Production].[JOB #])=@atmJob)) ORDER By [Daily Production].Site ASC", ATMconn)

			cmdProduction.Parameters.AddWithValue("@atmJob", My.Settings.ae_CurrentJob)

			' Open connection to Db
			ATMconn.Open()

			'  Fill dataAdapter with query result from Db
			productionDA = New OleDbDataAdapter(cmdProduction)

			' Instantiate DataSet object
			productionDS = New DataSet()

			' Fill DataSet with data from dataAdapater
			productionDA.Fill(productionDS, "Daily Production")

			'  Close the connection
			ATMconn.Close()

			' Create binding source
			productionBS = New BindingSource(productionDS, "Daily Production")

			'' DataTable -   Fill the DataTable object with data
			'productionDT = productionDS.Tables("Daily Production")

			'Me.dgvDailyProductions.DataSource = productionBS

			'Me.lblSite.DataBindings.Clear()
			'Me.lblDescription.DataBindings.Clear()
			'Me.lblCQty.DataBindings.Clear()

			'Me.lblSite.DataBindings.Add("Text", productionBS, "site")
			'Me.lblDescription.DataBindings.Add("Text", productionBS, "DESCRIPTION")
			'Me.lblCQty.DataBindings.Add("Text", productionBS, "Contract Qty")




		Catch ex As Exception
			MessageBox.Show(ex.Message, "PopulateProduction()")

		End Try

	End Sub

	Private Sub BindProduction()

		Me.lblSite.DataBindings.Clear()
		Me.lblDescription.DataBindings.Clear()
		Me.lblCQty.DataBindings.Clear()

		Me.lblSite.DataBindings.Add("Text", productionBS, "site")
		Me.lblDescription.DataBindings.Add("Text", productionBS, "DESCRIPTION")
		Me.lblCQty.DataBindings.Add("Text", productionBS, "Contract Qty")



	End Sub

	Private Sub UpdateDb(ByVal i As Integer)

		Me.Cursor = Cursors.WaitCursor


		Try

			Dim cmdUpdateProduction As New OleDbCommand("UPDATE [Daily Production] SET " & _
			  "[Daily Production].[PayItemID] = @pID, " & _
			  "[Daily Production].[Daily Production] = @dp, " & _
			  "[Daily Production].[Contract Qty] = @cQty, " & _
			  "[Daily Production].[Date] = @InstallDate, " & _
			  "[Daily Production].[Station with Support] = @sptStn, " & _
			  "[Daily Production].[Foreman] = @foreMan " & _
			  "WHERE [Daily Production].[Autonum] = @ID", ATMconn)



			'cmdUpdateProduction.Parameters.AddWithValue("@pID", Me.Label2.Text)



			'If Me.txtProductionQty.Text = String.Empty Then
			'	cmdUpdateProduction.Parameters.AddWithValue("@dp", DBNull.Value)
			'Else
			'	cmdUpdateProduction.Parameters.AddWithValue("@dp", Me.txtProductionQty.Text)
			'End If



			'If Me.txtContractQty.Text = String.Empty Then
			'	cmdUpdateProduction.Parameters.AddWithValue("cQty", DBNull.Value)
			'Else
			'	cmdUpdateProduction.Parameters.AddWithValue("@cQty", Me.txtContractQty.Text)
			'End If




			'If Not Me.ckbNullDate.Checked Or Me.txtProductionQty.Text = CStr(0) Then
			'	cmdUpdateProduction.Parameters.AddWithValue("@InstallDate", DBNull.Value)
			'Else
			'	cmdUpdateProduction.Parameters.AddWithValue("@InstallDate", Me.eDTPInstallDate.Value)
			'End If





			'If Me.txtStationWithSupport.Text = String.Empty Then
			'	cmdUpdateProduction.Parameters.AddWithValue("sptStn", DBNull.Value)
			'Else
			'	cmdUpdateProduction.Parameters.AddWithValue("@sptStn", Me.txtStationWithSupport.Text)
			'End If


			'If Not Me.ckbNullForeman.Checked Or Me.cmbForeman.Text = String.Empty Then
			'	cmdUpdateProduction.Parameters.AddWithValue("@foreMan", DBNull.Value)
			'Else
			'	cmdUpdateProduction.Parameters.AddWithValue("@foreMan", Me.cmbForeman.Text)
			'End If




			Dim dpID As Double
			Try
				dpID = CDbl(Me.Label1.Text)

			Catch ex As Exception
				dpID = 0
			End Try

			cmdUpdateProduction.Parameters.AddWithValue("@ID", dpID)


			ATMconn.Open()
			' use this variable later to display number of records updated
			Dim updateCount As Integer = cmdUpdateProduction.ExecuteNonQuery()
			ATMconn.Close()

			'signINMain1.tsbStatusLabelLeft.Text = Me.lblStation.Text & ", " & Me.txtProductionQty.Text & " " & Me.lblUnit.Text & ",  " & Me.lblPayItemDesc.Text & " Updated Sucessfully."

			'AddToUpdatedRecords(Me.lblStation.Text, dpID, Me.txtProductionQty.Text)

			Me.dgvDailyProductions.Select()



		Catch ex As Exception
			MessageBox.Show(ex.Message, "updateDB()")
			ATMconn.Close()

			'signINMain1.tsbStatusLabelLeft.Text = "Error during Update Process.  No Data Has Been Changed."


		End Try

		Me.Cursor = Cursors.Arrow


	End Sub




	Public Function PathExists(ByVal path As String, ByVal timeout As Integer) As Boolean
		Dim exists As Boolean = True
		Dim t As New Thread(DirectCast(Function() CheckPathFunction(path), ThreadStart))
		t.Start()
		Dim completed As Boolean = t.Join(timeout)
		If Not completed Then
			exists = False
			t.Abort()
		End If
		Return exists


		'Note: To use this method, you would call the function like done below, passing in an integer representing milliseconds before it stops trying to reach the path – in this case I have set it to 3 seconds.

		'If PathExists("\\BLAH\PATH\", 3000) Then 
		'...
		'End If



	End Function

	Public Function CheckPathFunction(ByVal path As String) As Boolean
		Return System.IO.File.Exists(path)
	End Function

	Private Sub moveFile(ByVal remoteDirectory As String, ByVal fileName As String)
		'Dim moveDirectory As String = "ftp://03294ad.netsolhost.com/htdocs/ActionEntry/dpdatasync/Warehouse/"
		'Dim movefile As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create(remoteDirectory & fileName), System.Net.FtpWebRequest)
		'movefile.Credentials = New System.Net.NetworkCredential(My.Settings.ae_FTPuserName, My.Settings.ae_FTPuserCred)
		'movefile.KeepAlive = False
		'movefile.UseBinary = True
		'movefile.Method = System.Net.WebRequestMethods.Ftp.Rename
		'MessageBox.Show(moveDirectory & fileName.ToString)
		'movefile.RenameTo() = moveDirectory & fileName.ToString

	End Sub





	'' If ActionTraffic Network is available
	'If PathExists(My.Settings.atmServerDataSync, 1000) Then
	'	'  Use ActionTraffic LDAP
	'	pathToUse = My.Settings.atmServerDataSync & fileName
	'Else
	'	' Use Local
	'	pathToUse = My.Settings.atmLocalDataSync & fileName
	'End If




#End Region


#Region " Event Handlers"

	Private Sub frmReconcileDP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

		RemoveHandler cmbJobs.SelectedIndexChanged, AddressOf cmbJobs_SelectedIndexChanged
		GetActiveJobs()
		AddHandler cmbJobs.SelectedIndexChanged, AddressOf cmbJobs_SelectedIndexChanged

	End Sub

	Private Sub btnGetDataSync_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetDataSync.Click

		Try

			'If ATM network exists do this here

			Dim filesToGet() As String = GetFileNameStringArrayFromFTP(My.Settings.ae_FTPDataSyncURL)

			MessageBox.Show("Connected to the sever: " & AtWorkOrNot().ToString)


			' The 2nd argument (1) indicates Transfer Direction (1 = Upload, 2 = Download)
			' The 3rd argument indicates File Type (1 = XML, 2 = Images)
			Dim xmlDP As New frmDataSyncProgress(filesToGet, 2, 1)
			xmlDP.MdiParent = AE_mdiMain.MdiParent
			xmlDP.Show()

		Catch ex As Exception
			MessageBox.Show(ex.Message, "btnGetDataSync_Click()")
		End Try

	End Sub

	Private Sub btnLoadCloudDP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadCloudDP.Click


		ViewAllDP()


	End Sub

	Private Sub cmbJobs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbJobs.SelectedIndexChanged

		GetJobPayItems(Me.cmbJobs.Text)

		'Me.xmlBS.Filter = "jobNum = '" & Me.cmbJobs.Text & "'"


	End Sub

	Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

		'Me.xmlBS.Filter = "entryDate = #" & Me.DateTimePicker1.Value.ToString("MM-dd-yyyy") & "#"

	End Sub

#End Region





End Class



Public Class TempDataSet

	

	Private _TheDataSet As DataSet
	Public Property TheDataSet() As DataSet
		Get
			Return _TheDataSet
		End Get
		Set(ByVal value As DataSet)
			_TheDataSet = value
		End Set
	End Property


	Private _JobNumber As String
	Public Property JobNumber() As String
		Get
			Return _JobNumber
		End Get
		Set(ByVal value As String)
			_JobNumber = value
		End Set
	End Property



	Private _Foreman As Integer
	Public Property Foreman() As Integer
		Get
			Return _Foreman
		End Get
		Set(ByVal value As Integer)
			_Foreman = value
		End Set
	End Property


	Private _EntryDate As Date
	Public Property EntryDate() As Date
		Get
			Return _EntryDate
		End Get
		Set(ByVal value As Date)
			_EntryDate = value
		End Set
	End Property








End Class