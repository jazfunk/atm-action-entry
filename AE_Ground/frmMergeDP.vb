Option Strict On
Option Explicit On

Imports System.IO
Imports System.Xml.Serialization
Imports System.Data.OleDb
Imports AE_Ground.clsAE_Utilities
Imports System.Collections.ObjectModel
Imports System.Deployment
Imports System.Text.RegularExpressions



Structure Production
	Dim code, units, signCode As String
	Dim foreman, ID, dpId As Integer
	Dim payItemId As Double
End Structure

Structure VerifiedProduction
	Dim foreman, notes As String
	Dim entryDate As Date
	Dim dpQty, cQty As Double
End Structure

Structure NPI
	Dim id As Integer
	Dim userId As Integer
	Dim firstName As String
	Dim lastName As String
	Dim dpId As String
	Dim jobNum As String
	Dim site As String
	Dim expr1 As String
	Dim npId As Integer
	Dim npDescription As String
	Dim npQty As Double
	Dim npUnit As String
	Dim productionDate As Date
End Structure


Public Class frmMergeDP


#Region " Database Communication"

	Dim atmCon As New OleDbConnection(My.Settings.atmProductionConStr)
	Dim aeCon As New OleDb.OleDbConnection(My.Settings.ae_ProductionConStr)

	'Dim atmCon As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\ActionEntry\SyncTesting\Action Traffic.mdb")
	'Dim aeCon As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\ActionEntry\SyncTesting\ActionEntry.mdb")



#End Region


#Region " Properties"



#End Region


#Region " Class-Level Declarations"

	'Node that holds all of the production 
	'Would it be better to hold all the data from the xml file in an array of Production structure
	'or would that almost be the same as a dataset???

	Dim prodNode As Production
	Dim vpNode As VerifiedProduction

	'itemCount - number of records in xml file, currItem - current Item (indexed from dataset)
	Dim currItem, itemCount As Integer

	'ds, dt, dr - of xml file
	Dim ds As DataSet = New DataSet
	Dim dt As DataTable = New DataTable
	Dim dr As DataRow

	Dim npiDS As DataSet = New DataSet
	Dim npiDT As DataTable = New DataTable

	Friend WithEvents bs As BindingSource
	Friend WithEvents npiBS As BindingSource

	' Cloud (DataSync)
	Friend WithEvents xmlBS As BindingSource
	Dim xmlDS As DataSet
	Dim xmlDT As DataTable
	Dim jobDT As DataTable
	Dim foremanDT As DataTable
	
	Dim aeDP() As String
	Dim aeNPI() As String
	Dim uh() As String

	Dim tList As New List(Of clsFileName)
	Dim files As ReadOnlyCollection(Of String)
	Dim usersDCT As New Dictionary(Of Integer, String)

	'Foreman Name Dictionary for ATM
	Dim foremanNameDCT As New Dictionary(Of Integer, String)

	
	'dataset for ae and atm db
	Dim aeDs, atmDs As New DataSet

	Dim currentFilePath As String

#End Region


#Region " Methods & Functions"

	''' <summary>
	''' Assign DataRow Values to Structure Object
	''' </summary>
	''' <remarks></remarks>
	Private Sub FillFieldWork()

		Try
			Dim currRow = DirectCast(Me.xmlBS.Current, DataRowView)
			Dim currDate As Date = CDate(currRow.Item("entrydate"))

			With prodNode
				.code = currRow.Item("code").ToString
				.dpId = CInt(currRow.Item("dpId"))
				.foreman = CInt(currRow.Item("foreman"))
				.ID = CInt(currRow.Item("ID"))
				.payItemId = CInt(currRow.Item("PayItemID"))
			End With

			Me.Text = "Confirm Submitted Productions - " & _
				currRow.Item("displayName").ToString & " - (" & _
				currRow.Item("jobNum").ToString & " - " & _
				currDate.ToShortDateString & ")"


		Catch ex As Exception
			MessageBox.Show(ex.Message, "FillFieldWork()")
		End Try

	End Sub

	''' <summary>
	''' Bind Submitted Values 
	''' </summary>
	''' <remarks></remarks>
	Private Sub BindFieldWork()

		If xmlBS IsNot Nothing Then

			' Clear DataBindings
			Me.lblJobNum.DataBindings.Clear()
			Me.lblStationNum.DataBindings.Clear()
			Me.lblFieldDescription.DataBindings.Clear()
			Me.lblFieldName.DataBindings.Clear()
			Me.lblFieldDate.DataBindings.Clear()
			Me.txtQty.DataBindings.Clear()
			Me.rtxtFieldNotes.DataBindings.Clear()
			Me.lblFieldPayItemCode.DataBindings.Clear()
			Me.lblFieldId.DataBindings.Clear()

			' Add DataBindings
			Me.lblJobNum.DataBindings.Add("Text", xmlBS, "jobNum")
			Me.lblStationNum.DataBindings.Add("Text", xmlBS, "site")
			Me.lblFieldDescription.DataBindings.Add("Text", xmlBS, "description")
			Me.lblFieldName.DataBindings.Add("Text", xmlBS, "displayName")
			Me.lblFieldDate.DataBindings.Add("Text", xmlBS, "entryDate", True).FormatString = "MM/dd/yyyy"
			Me.txtQty.DataBindings.Add("Text", xmlBS, "dpQty")
			Me.rtxtFieldNotes.DataBindings.Add("Text", xmlBS, "siteNotes")
			Me.lblFieldPayItemCode.DataBindings.Add("Text", xmlBS, "code")
			Me.lblFieldId.DataBindings.Add("Text", xmlBS, "dpID")

		End If

	End Sub

	''' <summary>
	''' Load Data from Production DB
	''' </summary>
	''' <remarks></remarks>
	Private Sub FillAtmWork()

		Try
			Dim atmWork As New OleDb.OleDbCommand("SELECT Site, " & _
			  "[Daily Production].[Daily Production], " & _
			  "[Daily Production].Date, " & _
			  "[Daily Production].[Contract Qty], " & _
			  "[Daily Production].Foreman, " & _
			  "[Daily Production].[Sign Code], " & _
			  "[PAY ITEM PICK LIST].[UNIT], " & _
			  "[PAY ITEM PICK LIST].[DESCRIPTION], " & _
			  "[Daily Production].Autonum " & _
			  "FROM [Daily Production] " & _
			  "INNER JOIN [PAY ITEM PICK LIST] ON [Daily Production].PayItemID = [PAY ITEM PICK LIST].PayItemID " & _
			  "WHERE [Daily Production].Autonum = @dpID", atmCon)

			atmWork.Parameters.AddWithValue("@dpID", prodNode.dpId)

			atmCon.Open()
			Dim atmDa = New OleDb.OleDbDataAdapter(atmWork)
			atmDs = New DataSet
			Dim x As Integer = atmDa.Fill(atmDs, "Daily Production")
			atmCon.Close()


			Dim atmDt As DataTable = atmDs.Tables("Daily Production")

			Me.lblConfSite.DataBindings.Clear()
			Me.lblConfQty.DataBindings.Clear()
			Me.lblConfQtyUnits.DataBindings.Clear()
			Me.lblFieldUnits.DataBindings.Clear()
			Me.lblConfContractQty.DataBindings.Clear()
			Me.lblConfContQtyUnits.DataBindings.Clear()
			Me.lblConfName.DataBindings.Clear()
			Me.lblConfDate.DataBindings.Clear()
			Me.lblConfDescription.DataBindings.Clear()
			Me.lblSignCode.DataBindings.Clear()
			Me.lblConfId.DataBindings.Clear()

			If x > 0 Then


				Me.lblConfSite.DataBindings.Add("Text", atmDt, "Site")
				Me.lblConfQty.DataBindings.Add("Text", atmDt, "Daily Production")
				Me.lblConfQtyUnits.DataBindings.Add("Text", atmDt, "UNIT")
				Me.lblFieldUnits.DataBindings.Add("Text", atmDt, "UNIT")
				Me.lblConfContractQty.DataBindings.Add("Text", atmDt, "Contract Qty")
				Me.lblConfContQtyUnits.DataBindings.Add("Text", atmDt, "UNIT")
				Me.lblConfName.DataBindings.Add("Text", atmDt, "Foreman")
				Me.lblConfDate.DataBindings.Add("Text", atmDt, "Date", True).FormatString = "MM/dd/yyyy"
				Me.lblConfDescription.DataBindings.Add("Text", atmDt, "DESCRIPTION")
				Me.lblSignCode.DataBindings.Add("Text", atmDt, "Sign Code")
				Me.lblConfId.DataBindings.Add("Text", atmDt, "Autonum")

				prodNode.units = Me.lblFieldUnits.Text

			Else

				ResetProductionFields()
				'MessageBox.Show("No Matching Production Record")


			End If

		Catch ex As Exception
			MessageBox.Show(ex.Message, "FillAtmWork()")
			atmCon.Close()
		End Try



	End Sub

	''' <summary>
	''' Load Matching Cloud (Source Version)
	''' </summary>
	''' <remarks>Not Used 03.07.2012</remarks>
	Private Sub FillAeWork()
		'Try
		'	Dim aeWork As New OleDb.OleDbCommand("SELECT dpQty, cQty, siteNotes, foreman, entryDate FROM tblDailyProductions WHERE ID = @ID", aeCon)
		'	aeWork.Parameters.AddWithValue("@ID", prodNode.ID)

		'	aeCon.Open()

		'	Dim aeDa = New OleDb.OleDbDataAdapter(aeWork)
		'	aeDs = New DataSet
		'	aeDa.Fill(aeDs, "tblDailyProductions")
		'	aeCon.Close()

		'	'dataTable is used to fill the datagrid view - Not needed when dgv is no longer needed
		'	Dim aeDt As DataTable = aeDs.Tables("tblDailyProductions")
		'	'Me.dgvAE.DataSource = aeDt

		'Catch ex As Exception
		'	MessageBox.Show(ex.Message, "FillAeWork()")
		'	aeCon.Close()
		'End Try

	End Sub

	''' <summary>
	''' Filter the NonPayItem BindingSource by station/site/location
	''' </summary>
	''' <remarks></remarks>
	Private Sub FilterNonPayItems()

		Me.npiBS.Filter = "dpID = " & prodNode.ID

	End Sub

	''' <summary>
	''' Update Production Database (ActionTraffic)
	''' </summary>
	''' <remarks></remarks>
	Private Sub UpdateATM()
		Try
			Dim cmdAtmUpdate As New OleDb.OleDbCommand("UPDATE [Daily Production] SET " & _
			 "[Daily Production].[Daily Production] = @dpQty, " & _
			 "[Daily Production].[Foreman] = @foreman, " & _
			 "[Daily Production].[Date] = @entryDate, " & _
			 "[Daily Production].[PayItemID] = @pid, " & _
			  "[Daily Production].[Plan Issue Notes] = @notes " & _
			 "WHERE [Daily Production].[Autonum] = @ID", atmCon)

			With cmdAtmUpdate.Parameters
				.AddWithValue("@dpQty", Me.txtQty.Text)
				.AddWithValue("@foreman", Me.foremanNameDCT(Me.prodNode.foreman))
				.AddWithValue("@entryDate", CDate(Me.lblFieldDate.Text))
				.AddWithValue("@pid", prodNode.payItemId)

				If Me.rtxtFieldNotes.Text = String.Empty Then
					.AddWithValue("@notes", DBNull.Value)
				Else
					.AddWithValue("@notes", Me.rtxtFieldNotes.Text)
				End If

				.AddWithValue("@ID", prodNode.dpId)
			End With

			atmCon.Open()
			Dim updateCount As Integer = cmdAtmUpdate.ExecuteNonQuery()
			atmCon.Close()

			If updateCount <= 0 Then
				MessageBox.Show("An error occurred while updating.  (" & updateCount.ToString & ") records updated.")
			End If
		Catch ex As Exception
			MessageBox.Show(ex.Message, "UpdateATM()")
			atmCon.Close()
		End Try

	End Sub

	''' <summary>
	''' Update Cloud Database (ActionEntry)
	''' </summary>
	''' <remarks></remarks>
	Private Sub UpdateAE()
		Try
			Dim cmdAeUpdate As New OleDb.OleDbCommand("UPDATE tblDailyProductions SET " & _
			 "dpQty = @Qty, " & _
			 "foreman = @fore, " & _
			 "entryDate = @entry, " & _
			 "siteNotes = @siteNotes, " & _
			 "payItemId = @payItemId " & _
			 "WHERE ID = @eyeD", aeCon)

			cmdAeUpdate.Parameters.AddWithValue("@Qty", Me.txtQty.Text)
			cmdAeUpdate.Parameters.AddWithValue("@fore", prodNode.foreman)
			cmdAeUpdate.Parameters.AddWithValue("@entry", CDate(Me.lblFieldDate.Text))
			cmdAeUpdate.Parameters.AddWithValue("@siteNotes", Me.rtxtFieldNotes.Text)
			cmdAeUpdate.Parameters.AddWithValue("@payItemId", prodNode.payItemId)
			cmdAeUpdate.Parameters.AddWithValue("@eyeD", prodNode.ID)

			aeCon.Open()
			Dim updateCount As Integer = cmdAeUpdate.ExecuteNonQuery()
			aeCon.Close()

			If updateCount <= 0 Then
				MessageBox.Show("Something went wrong when updating AE")
			End If
		Catch ex As Exception
			MessageBox.Show(ex.Message, "UpdateAE()")
			aeCon.Close()
		End Try

	End Sub

	''' <summary>
	''' Visual display of location status
	''' </summary>
	''' <remarks></remarks>
	Private Sub VisualEffects()

		'Show if verified
		If Me.lblConfQty.Text.Trim = Nothing Then
			Me.lblStatus.Text = "--"
			Me.lblStatus.ForeColor = Color.Black
		Else
			Me.lblStatus.Text = "Verified"
			Me.lblStatus.ForeColor = Color.Blue

		End If

		'If the contract quanity is different from the submitted quanity:
		'MessageBox.Show(prodNode.dpQty.ToString & " " & vpNode.cQty.ToString)
		If Me.txtQty.Text = Me.lblConfContractQty.Text Then

			Me.lblConfContractQty.BackColor = Color.Transparent
			Me.txtQty.BackColor = Color.White
		Else
			Me.lblConfContractQty.BackColor = Color.Yellow
			Me.txtQty.BackColor = Color.Yellow
		End If

		'if there are notes make it obvious -pauls request
		If Me.rtxtFieldNotes.Text = Nothing Then
			Me.rtxtFieldNotes.BackColor = Color.White
		Else
			Me.rtxtFieldNotes.BackColor = Color.Cyan
		End If

		'if the dpId's are different
		If Me.lblFieldId.Text = Me.lblConfId.Text Then
			Me.lblFieldId.BackColor = Color.Transparent
			Me.lblConfId.BackColor = Color.Transparent
		Else
			Me.lblFieldId.BackColor = Color.Yellow
			Me.lblConfId.BackColor = Color.Yellow

		End If
	End Sub

	''' <summary>
	''' Display current position and record count of BindingSource
	''' </summary>
	''' <remarks></remarks>
	Private Sub ShowPosition()

		Dim recPosition As String
		Dim currentPosition As Integer = xmlBS.Position + 1
		If xmlBS IsNot Nothing Then
			recPosition = currentPosition.ToString & " of " & xmlBS.Count.ToString
		Else
			recPosition = "Error occurred while processing"
		End If
		Me.lblRecordCount.Text = recPosition

	End Sub

	''' <summary>
	''' Iterate through Users Table and populate Dictionary
	''' with Key/Value pair; ID,DisplayName  (Of Integer, String)
	''' </summary>
	''' <remarks></remarks>
	Private Sub CreateUsersDictionary()

		Try
			Dim dt As DataTable = CType(Me.QryUsersDisplayNamesBindingSource.List, DataView).ToTable
			Dim x As Integer = 0
			Dim y As String = Nothing

			For Each row As DataRow In dt.Rows
				x = CType(row.Item(0), Integer)
				y = CType(row.Item(1), String)
				Me.usersDCT.Add(x, y)
			Next
		Catch ex As Exception
			MessageBox.Show(ex.Message, "CreateUsersDictionary()")
		End Try

	End Sub

	''' <summary>
	''' Creates a list of clsFileName objects
	''' representing each DataSync file submitted
	''' </summary>
	''' <remarks>Also invokes the CreateFileList() Method</remarks>
	Private Sub CreateFileList()
		Try
			tList.Clear()
			Me.dgvDPlist.DataSource = Nothing

			'CreateUsersDictionary()

			' Send each path/filename to class constructor
			' which spits out a filename class with the filename
			' elements broken down into usable properties. 
			' Then builds/adds to a list of clsFileName objects
			For Each item As String In files
				If Path.GetFileName(item).Substring(0, 3) = "ae_" Then
					' Instantiate clsFileName object, with a full path filename
					' and the users Dictionary to get display name
					Dim t As New clsFileName(item, Me.usersDCT)
					' Add clsFileName object to list
					tList.Add(t)
				End If
			Next



			RemoveHandler dgvDPlist.SelectionChanged, AddressOf dgvDPlist_SelectionChanged
			With Me.dgvDPlist
				.DataSource = tList
				.Columns(0).Visible = False
				.Columns(1).Visible = False
				.Columns(2).Width = 10
				.Columns(3).Width = 20
				.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
				.Columns(4).Width = 70
			End With
			AddHandler dgvDPlist.SelectionChanged, AddressOf dgvDPlist_SelectionChanged

			Me.dgvDPlist.Columns(2).HeaderText = "Job"
			Me.dgvDPlist.Columns(3).HeaderText = "Date"
			Me.dgvDPlist.Columns(4).HeaderText = "Foreman"

		Catch ex As Exception
			MessageBox.Show(ex.Message & vbCrLf & ex.InnerException.ToString, "CreateFileList()")
		End Try


	End Sub

	''' <summary>
	''' Layout the DataGridView, set it's DataSource
	''' </summary>
	''' <remarks></remarks>
	Private Sub BindAndLayoutDGV()

		'Try
		'	If xmlBS IsNot Nothing Then
		'		With Me.dgvCloudDP
		'			.DataSource = xmlBS

		'			' Foreman ID
		'			.Columns(0).Visible = False

		'			' EntryDate
		'			.Columns(1).Visible = False

		'			' DisplayName
		'			.Columns(2).Visible = True
		'			.Columns(2).HeaderText = "Foreman"

		'			' ID
		'			.Columns(3).Visible = False

		'			' dpID
		'			.Columns(4).Visible = False

		'			' jobNum
		'			.Columns(5).Visible = True

		'			' Station#
		'			.Columns(6).Visible = True
		'			.Columns(6).HeaderText = "Station #"

		'			' payItemID
		'			.Columns(7).Visible = False

		'			' code
		'			.Columns(8).Visible = False

		'			' Description
		'			.Columns(9).Visible = True
		'			.Columns(9).HeaderText = "Description"

		'			' Qty
		'			.Columns(10).Visible = True
		'			.Columns(10).HeaderText = "Qty"

		'			' siteNotes
		'			.Columns(11).Visible = False
		'		End With

		'	End If

		'Catch ex As Exception
		'	MessageBox.Show(ex.Message, "BindAndLayoutDGV")
		'End Try


	End Sub

	''' <summary>
	''' Loads Selected XML DataSync File into ADO.Net Objects
	''' </summary>
	''' <param name="aPath"></param>
	''' <remarks></remarks>
	Private Sub LoadSelectedDataSync(ByVal aPath As String)
		Try
			' PayItems
			xmlDS = ReadDataSyncToDataSet(aPath)
			xmlBS = New BindingSource(xmlDS, "qryMyDPToday")
			xmlDT = xmlDS.Tables("qryMyDPToday")

			'NonPayItems
			Dim npiFile As String = aPath.Replace("ae_", "npi_")
			npiDS.ReadXml(npiFile)
			npiBS = New BindingSource(npiDS, "qryNPIdataSync")
			npiDT = npiDS.Tables("qryNPIdataSync")
			Me.dgvNPI.DataSource = npiBS
			FormatNpiDGV()

			' Bind Controls to XML DataSource (ADO.Net Object)
			' Need to incorporate NonPayItems 03.07.2012
			BindFieldWork()
			xmlBS_PositionChanged(Nothing, Nothing)

		Catch ex As Exception
			'MessageBox.Show(ex.Message, "LoadSelectedDataSync()")

		End Try

	End Sub

	''' <summary>
	''' Display Station number in GroupBox Header
	''' </summary>
	''' <remarks></remarks>
	Private Sub DataDisplayRoutines()

		Dim t As String = " (" & Me.lblStationNum.Text & ")"
		Me.grbFieldWork.Text = "Field Work: " & t

		Dim t2 As String = " (" & Me.lblConfSite.Text & ")"
		Me.grbConfirmedWork.Text = "Confirmed Work: " & t2


	End Sub

	''' <summary>
	''' Format NonPayItems DataGridView
	''' </summary>
	''' <remarks></remarks>
	Private Sub FormatNpiDGV()

		Try

			With Me.dgvNPI

				.Columns("ID").Visible = False
				.Columns("userID").Visible = False
				.Columns(2).Visible = False
				.Columns(3).Visible = False
				.Columns(4).Visible = False
				.Columns(5).Visible = False
				.Columns(6).Visible = False
				.Columns(7).Visible = False
				.Columns(8).Visible = False

				.Columns(9).HeaderText = "Description"
				.Columns(9).Width = 100

				.Columns(10).HeaderText = "Qty"
				.Columns(10).Width = 50

				.Columns(11).HeaderText = "Unit"
				.Columns(11).Width = 20

				.Columns(12).HeaderText = "Date"
				.Columns(12).Width = 50

				.Columns(13).HeaderText = "Notes"
				.Columns(13).Width = 50

			End With


		Catch ex As Exception
			MessageBox.Show(ex.Message, "FormatNpiDGV()")

		End Try



	End Sub

	''' <summary>
	''' Clear Data Displayed from 'Action Traffic.mdb'
	''' </summary>
	''' <remarks></remarks>
	Private Sub ResetProductionFields()

		Try
			Me.lblConfName.Text = Nothing
			Me.lblConfDate.Text = Nothing
			Me.lblConfDescription.Text = Nothing
			Me.lblConfSite.Text = Nothing
			Me.lblConfContractQty.Text = Nothing
			Me.lblConfQty.Text = Nothing
			Me.lblConfContQtyUnits.Text = Nothing
			Me.lblConfQtyUnits.Text = Nothing

			Me.lblConfId.Text = Nothing

		Catch ex As Exception

		End Try


	End Sub


	''' <summary>
	''' Insert Manually entered items into ATM
	''' </summary>
	''' <remarks></remarks>
	Private Sub InsertMEatm()
		Try


			Dim insertATMcmd As OleDbCommand = New OleDb.OleDbCommand
			insertATMcmd.Connection = atmCon
			insertATMcmd.CommandText = "INSERT INTO [Daily Productions] " & _
													   "([JOB #], [Site], [PayItemID], [Daily Production], [Date], [Plan Issue Notes], [Foreman])" & _
													   "VALUES (@jobNum, @site, @pid, @dp, @date, @notes, @foreman)"


			With insertATMcmd
				.Parameters.AddWithValue("@jobNum", Me.lblJobNum.Text)
				.Parameters.AddWithValue("@site", Me.lblStationNum.Text)
				.Parameters.AddWithValue("@pid", prodNode.payItemId)
				.Parameters.AddWithValue("@dp", Me.txtQty.Text)
				.Parameters.AddWithValue("@date", CDate(Me.lblFieldDate.Text))
				.Parameters.AddWithValue("@notes", Me.rtxtFieldNotes.Text)
				.Parameters.AddWithValue("@foreman", foremanNameDCT(prodNode.foreman))
			End With

			atmCon.Open()
			Dim insertCount As Integer = insertATMcmd.ExecuteNonQuery()
			insertATMcmd.CommandText = "SELECT @@IDENTITY"
			Me.lblFieldId.Text = insertATMcmd.ExecuteScalar().ToString
			atmCon.Close()

			If insertCount = 0 Then
				MessageBox.Show("Did not insert record!")
			End If

		Catch ex As Exception
			MessageBox.Show(ex.Message, "InsertMEatm()")
			atmCon.Close()
		End Try
	End Sub

	''' <summary>
	''' Insert Manually entered items into AE
	''' </summary>
	''' <remarks></remarks>
	Private Sub InsertMEae()
		Try


			Dim insertAEcmd As OleDb.OleDbCommand = New OleDb.OleDbCommand
			insertAEcmd.Connection = aeCon
			insertAEcmd.CommandText = "INSERT INTO tblDailyProductions " & _
													  "(jobNum, site, dpID, payItemID, dpQty, siteNotes, foreman, entryDate)" & _
													  "VALUES (@jobNum, @site, @dpID, @payItemId, @dpQty, @siteNotes, @foreman, @entryDate)"

			With insertAEcmd
				.Parameters.AddWithValue("@jobNum", Me.lblJobNum.Text)
				.Parameters.AddWithValue("@site", Me.lblStationNum.Text)
				.Parameters.AddWithValue("@dpID", CInt(Me.lblFieldId.Text))
				.Parameters.AddWithValue("@payItem", prodNode.payItemId)
				.Parameters.AddWithValue("@dpQty", CInt(Me.txtQty.Text))
				.Parameters.AddWithValue("@siteNotes", Me.rtxtFieldNotes.Text)
				.Parameters.AddWithValue("@foreman", prodNode.foreman)
				.Parameters.AddWithValue("@entryDate", CDate(Me.lblFieldDate.Text))
			End With

			aeCon.Open()
			Dim insertCount As Integer = insertAEcmd.ExecuteNonQuery()
			aeCon.Close()

			If insertCount = 0 Then
				MessageBox.Show("Did not insert record!")
			End If

		Catch ex As Exception
			MessageBox.Show(ex.Message, "InsertMEae()")
			aeCon.Close()
		End Try

	End Sub

	Private Sub GetDpFiles()
		'' Local for testing
		'files = CType(My.Computer.FileSystem.GetFiles("C:\ActionEntry\DataSync\LocalDataSync\"), ReadOnlyCollection(Of String))

		' Server - Live
		files = CType(My.Computer.FileSystem.GetFiles(My.Settings.ae_TransferDataSyncPath), ReadOnlyCollection(Of String))
	End Sub

	Private Sub InsertNPI()

		'0 - foreman
		'1 - entryDate
		'2 - displayName
		'3 - ID
		'4 - dpID
		'5 - jobNum 
		'6 - site
		'7 - payItemID 
		'8 - code
		'9 - description
		'10 - dpQty


		Dim insertCmdNpi As OleDbCommand = New OleDb.OleDbCommand
		insertCmdNpi.Connection = aeCon
		insertCmdNpi.CommandText = "INSERT INTO tblNonPIProductions (dpID, npID, npQty, userId, productionDate, npNotes) VAlUES (@dpid, @npid, @npqty, @uid, @pdte, @n)"

		For Each r As DataGridViewRow In dgvNPI.Rows

			If r.Cells(0) IsNot Nothing Then

				If r.Cells(13).FormattedValue.ToString.Length = 0 Then
					r.Cells(13).Value = " "
				End If

				With insertCmdNpi
					.Parameters.AddWithValue("@dpid", r.Cells(4).FormattedValue.ToString)
					.Parameters.AddWithValue("@npid", r.Cells(8).FormattedValue.ToString)
					.Parameters.AddWithValue("@npqty", r.Cells(10).FormattedValue.ToString)
					.Parameters.AddWithValue("@uid", r.Cells(1).FormattedValue.ToString)
					.Parameters.AddWithValue("@pdte", r.Cells(12).FormattedValue.ToString)
					.Parameters.AddWithValue("@n", r.Cells(13).FormattedValue.ToString)
				End With

				aeCon.Open()
				Dim insertCount As Integer = insertCmdNpi.ExecuteNonQuery()
				aeCon.Close()

				If insertCount <= 0 Then
					MessageBox.Show("No npi insert")
				End If
			End If

		Next
	End Sub

	Private Function BeenVerified() As Boolean
		If Me.lblConfQty.Text = Nothing Then
			Return False
		Else
			Return True
		End If
	End Function





#End Region


#Region " Event Handlers"

	Private Sub frmMergeDP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, btnRefresh.Click

		foremanNameDCT = InitializeForemanDictionary()


		' Reduce Flicker
		Me.SplitContainer1.Visible = False

		Me.QryUsersDisplayNamesTableAdapter.Fill(Me.ActionEntryDataSet.qryUsersDisplayNames)

		Me.lblConfQty.Text = Nothing
		Me.txtQty.Text = Nothing

		GetDpFiles()

		CreateUsersDictionary()
		CreateFileList()

		RemoveHandler rbtnUnconfirmed.CheckedChanged, AddressOf rbtnUnconfirmed_CheckedChanged
		rbtnUnconfirmed.Checked = True
		AddHandler rbtnUnconfirmed.CheckedChanged, AddressOf rbtnUnconfirmed_CheckedChanged

	End Sub

	Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click

		xmlBS.MovePrevious()

	End Sub

	Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click

		xmlBS.MoveNext()

	End Sub

	Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

		'if the item has already been submitted into the database
		If BeenVerified() = True Then

			Dim result As DialogResult = MessageBox.Show("Item has already been verified jackass, do you want to override it?", "Already Been Verified", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

			'if the user does not want to ovveride what already exist in database
			If result = Windows.Forms.DialogResult.No Then
				Exit Sub
			End If

		End If

		Me.btnNext.Enabled = False
		Me.btnPrev.Enabled = False
		Me.btnUpdate.Enabled = False

		'if the item is manually entered. 
		If Me.prodNode.dpId = 0 Then

			InsertMEatm()
			InsertMEae()
			Me.xmlBS.EndEdit()
			xmlDS.WriteXml(currentFilePath, XmlWriteMode.WriteSchema)
			xmlBS_PositionChanged(Nothing, Nothing)

		Else

			UpdateATM()
			UpdateAE()

		End If


		' * --> Disabled until we are updating ActionEntry db 4.25.12 -lm
		'' If there are npi's insert them into the db
		'If Me.dgvNPI.Rows.Count > 0 Then
		'	InsertNPI()
		'End If
		' * -->


		FillAtmWork()
		VisualEffects()

		Me.btnNext.Enabled = True
		Me.btnPrev.Enabled = True
		Me.btnUpdate.Enabled = True


	End Sub

	Private Sub lblFieldDescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFieldDescription.Click
		Try
			'Get only the pay items for this job
			Dim descriptionCmd As New OleDb.OleDbCommand("SELECT tblPayItemPickList.description, tblPayItemPickList.payItemId " & _
			   "FROM tblPayItemPickList INNER JOIN tblJobPayItems " & _
			   "ON tblPayItemPickList.payItemId = tblJobPayItems.payItemId " & _
			   "WHERE tblJobPayItems.jobNum = @jobNum", aeCon)

			'Job number to determine which pay items to get
			descriptionCmd.Parameters.AddWithValue("@jobNum", Me.lblJobNum.Text)

			aeCon.Open()
			Dim desDA As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(descriptionCmd)
			Dim desDS As New DataSet

			desDA.Fill(desDS)
			aeCon.Close()

			RemoveHandler cmbPayItem.SelectedIndexChanged, AddressOf cmbPayItem_SelectedIndexChanged
			With cmbPayItem
				.DataSource = desDS.Tables(0)
				.DisplayMember = "description"
				.ValueMember = "payItemID"
			End With
			AddHandler cmbPayItem.SelectedIndexChanged, AddressOf cmbPayItem_SelectedIndexChanged

			Me.cmbPayItem.Visible = True

		Catch ex As Exception
			MessageBox.Show(ex.Message, "lblFieldDescription_Click()")
			aeCon.Close()
		End Try
	End Sub

	Private Sub lblSignCode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblSignCode.TextChanged
		Try
			Dim imageLoc As String = My.Settings.ae_ImagePath & Me.lblSignCode.Text & ".jpg"
			Dim noImage As String = My.Settings.ae_ImagePath & "none.jpg"

			If System.IO.File.Exists(imageLoc) Then
				Me.PictureBox1.Load(imageLoc)
			Else
				Me.PictureBox1.Load(noImage)
			End If
		Catch ex As Exception
			'MessageBox.Show(ex.Message, "lblSignCode_TextChanged")
		End Try
	End Sub

	Private Sub cmbPayItem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPayItem.SelectedIndexChanged
		Try
			If Me.cmbPayItem.Text IsNot Nothing Then
				Me.lblFieldDescription.Text = Me.cmbPayItem.Text
				prodNode.payItemId = CInt(Me.cmbPayItem.SelectedValue)
				Me.cmbPayItem.Visible = False
			End If
		Catch ex As Exception
			MessageBox.Show(ex.Message, "cmbPayItem_SelectedIndexChanged()")
		End Try

	End Sub

	Private Sub btnDownloadDP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDownloadDP.Click
		Try

			'If ATM network exists do this here
			Dim filesToGet() As String = GetFileNameStringArrayFromFTP(My.Settings.ae_FTPDataSyncURL)

			'If My.Settings.ae_UserID <= 6 Then
			'	MessageBox.Show("Connected to the server: " & AtWorkOrNot().ToString)
			'Else
			'	AtWorkOrNot()
			'End If

			AtWorkOrNot()

			' The 2nd argument indicates Transfer Direction (1 = Upload, 2 = Download)
			' The 3rd argument indicates File Type (1 = XML, 2 = Images)
			Dim xmlDP As New frmDataSyncProgress(filesToGet, 2, 1)
			xmlDP.MdiParent = AE_mdiMain.MdiParent
			xmlDP.Show()


		Catch ex As Exception
			MessageBox.Show(ex.Message, "btnDownloadDP_Click()")
		End Try



	End Sub

	Private Sub xmlBS_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles xmlBS.PositionChanged

		FillFieldWork()
		FilterNonPayItems()
		FillAtmWork()
		ShowPosition()
		VisualEffects()
		DataDisplayRoutines()



	End Sub

	Private Sub btnLoadDataSync_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadDataSync.Click, dgvDPlist.DoubleClick

		LoadSelectedDataSync(CType(Me.dgvDPlist.CurrentRow.Cells.Item(0).Value, String))
		currentFilePath = CType(Me.dgvDPlist.CurrentRow.Cells.Item(0).Value, String)


	End Sub

	Private Sub frmMergeDP_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

		' Reduce Flicker
		Me.SplitContainer1.Visible = True

	End Sub

	Private Sub btnViewDGV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewDGV.Click

		If xmlBS IsNot Nothing Then
			xmlBS.Filter = Nothing
			Dim viewDGV As New frmAE_GenericDGV(CType(xmlBS.List, DataView))
			viewDGV.MdiParent = AE_mdiMain
			viewDGV.Show()
		End If

	End Sub

	Private Sub btnViewNPiDGV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewNPiDGV.Click

		If npiBS IsNot Nothing Then
			npiBS.Filter = Nothing
			Dim viewNPiDGV As New frmAE_GenericDGV(CType(npiBS.List, DataView))
			viewNPiDGV.MdiParent = AE_mdiMain
			viewNPiDGV.Show()
		End If

	End Sub

	Private Sub btnMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove.Click
		Try
			'get file name
			Dim filename As String = Path.GetFileName(Me.dgvDPlist.CurrentRow.Cells.Item(0).Value.ToString)
			'move ae to warehouse
			My.Computer.FileSystem.MoveFile(Me.dgvDPlist.CurrentRow.Cells.Item(0).Value.ToString, My.Settings.atmServerWarehouseXmlPath & filename)
			'npi file name
			Dim npiFileName As String = filename.Replace("ae_", "npi_")

			' if the npi file exists them move it as well
			If File.Exists(Path.GetDirectoryName(Me.dgvDPlist.CurrentRow.Cells.Item(0).Value.ToString) & "\" & npiFileName) Then
				File.Move(Path.GetDirectoryName(Me.dgvDPlist.CurrentRow.Cells.Item(0).Value.ToString) & "\" & npiFileName, My.Settings.atmServerWarehouseXmlPath & npiFileName)
			Else
				MessageBox.Show("No NPI file to move.", "No NPI File")
			End If

			'refresh the DP files list, the list has been changed
			GetDpFiles()
			'reload the dp files
			CreateFileList()

		Catch ex As Exception
			MessageBox.Show(ex.Message, "btnMove_Click")
		End Try
	End Sub

	Private Sub rbtnUnconfirmed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnUnconfirmed.CheckedChanged
		Try
			If rbtnUnconfirmed.Checked = True Then
				files = CType(My.Computer.FileSystem.GetFiles(My.Settings.ae_TransferDataSyncPath), ReadOnlyCollection(Of String))
			Else
				files = CType(My.Computer.FileSystem.GetFiles(My.Settings.atmServerWarehouseXmlPath), ReadOnlyCollection(Of String))
			End If

			CreateFileList()
		Catch ex As Exception
			MessageBox.Show(ex.Message, "rbtnUnconfirmed_CheckedChange")
		End Try

	End Sub

	Private Sub dgvDPlist_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvDPlist.SelectionChanged
		' event handler left for future use. Add/Remove handler are called in other methods
	End Sub


	''' <summary>
	''' Used to modify the station number entered by the user
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks></remarks>
	Private Sub lblStationNum_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblStationNum.Click

		Dim message, title, defaultValue As String
		Dim myValue As Object
		' Set prompt.
		message = "Edit Station Number"
		' Set title.
		title = "Station Number"
		defaultValue = Me.lblStationNum.Text	 ' Set default value.

		' Display message, title, and default value.
		myValue = InputBox(message, title, defaultValue)
		' If user has clicked Cancel, set myValue to defaultValue 
		If myValue Is "" Then myValue = defaultValue

		Me.lblStationNum.Text = CType(myValue, String)




	End Sub


	''' <summary>
	''' Used to modify the production date entered by the user
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks></remarks>
	Private Sub lblFieldDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFieldDate.Click

		Dim message, title, defaultValue As String
		Dim myValue As Object
		' Set prompt.
		message = "Edit Production Date"
		' Set title.
		title = "Production Date"
		defaultValue = Me.lblFieldDate.Text	 ' Set default value.

		' Display message, title, and default value.
		myValue = InputBox(message, title, defaultValue)
		' If user has clicked Cancel, set myValue to defaultValue 
		If myValue Is "" Then myValue = defaultValue

		' Check for proper date input
		If IsDate(myValue.ToString) Then
			' If proper date format then add to label
			Me.lblFieldDate.Text = CType(myValue, String)
		Else
			' If not proper date format then return original value
			MessageBox.Show("Only a Date value may be entered in this field.", "Improper Date Value")
			myValue = defaultValue
		End If




	End Sub


#End Region






End Class



Public Class clsFileName



#Region " Constructors"

	''' <summary>
	''' To create an empty object
	''' </summary>
	''' <remarks></remarks>
	Public Sub New()



	End Sub


	''' <summary>
	''' To automatically create an object based on a Path and Filename
	''' </summary>
	''' <param name="theFilePath">Path and Filename with Extension</param>
	''' <remarks></remarks>
	Public Sub New(ByVal theFilePath As String, ByVal dct As Dictionary(Of Integer, String))

		' Daily Productions "ae_" Legend:
		' 0 = Dp, Uh, Npi, etc.
		' 1 = UserID
		' 2 = Job#
		' 3 = Date

		Me._filePath = theFilePath
		Me._dct = dct

		' Split the string on the underscore character
		Dim parts As String() = Path.GetFileNameWithoutExtension(theFilePath).Split(New Char() {"_"c})

		' Returns false if string cannot be converted to Integer
		' Kills 2 birds with 1 stone by not running the code to
		' get the display name if there's no integer (primary key ID)
		' to do so.  Brilliant!
		If Integer.TryParse(parts(1), Me._foreman) Then
			Me._displayName = GetDisplayName(Me._foreman)
		End If
		Me._jobNum = parts(2)
		Date.TryParse(parts(3), Me._entryDate)





	End Sub



	''' <summary>
	''' To manually create object
	''' </summary>
	''' <param name="fID">Integer</param>
	''' <param name="job">String</param>
	''' <param name="eDate">Date</param>
	''' <param name="dName">String</param>
	''' <remarks></remarks>
	Public Sub New(ByVal fID As Integer, ByVal job As String, ByVal eDate As Date, ByVal dName As String)

		Me._foreman = fID
		Me._jobNum = job
		Me._entryDate = eDate
		Me._displayName = dName


	End Sub



#End Region

#Region " Class-Level Declarations"


	Private _filePath As String
	Private _foreman As Integer
	Private _jobNum As String
	Private _entryDate As Date
	Private _displayName As String

	Private _dct As Dictionary(Of Integer, String)




#End Region

#Region " Properties"


	Public Property FilePath() As String
		Get
			Return _filePath
		End Get
		Set(ByVal value As String)
			_filePath = value
		End Set
	End Property

	Public Property Foreman() As Integer
		Get
			Return _foreman
		End Get
		Set(ByVal value As Integer)
			_foreman = value
		End Set
	End Property

	Public Property jobNum() As String
		Get
			Return _jobNum
		End Get
		Set(ByVal value As String)
			_jobNum = value
		End Set
	End Property

	Public Property EntryDate() As Date
		Get
			Return _entryDate
		End Get
		Set(ByVal value As Date)
			_entryDate = value
		End Set
	End Property

	Public Property DisplayName() As String
		Get
			Return _displayName
		End Get
		Set(ByVal value As String)
			_displayName = value
		End Set
	End Property








#End Region

#Region " Methods & Functions"


	Private Function GetDisplayName(ByVal i As Integer) As String

		Return _dct(i)

	End Function


#End Region


End Class