Option Strict Off
Option Explicit On

Imports System.IO
Imports System.Xml.Serialization
Imports System.Data.OleDb
Imports AE_Ground.clsAE_Utilities
Imports System.Collections.ObjectModel
Imports System.Deployment
Imports System.Text.RegularExpressions





Public Class frmReviewDataSync





#Region " Class-Level Declarations"


	' Cloud (DataSync)
	Dim xmlBS As BindingSource
	Dim xmlDS As DataSet
	Dim xmlDT As DataTable

	Dim npiBS As BindingSource
	Dim npiDS As DataSet
	Dim npiDT As DataTable

	Dim grBS As BindingSource
	Dim grDS As DataSet
	Dim grDT As DataTable

	Dim uhBS As BindingSource
	Dim uhDS As DataSet
	Dim uhDT As DataTable

	Dim jobDT As DataTable
	Dim foremanDT As DataTable
	'Dim dateDT As DataTable
	'Dim payItemDT As DataTable

	Dim dsType As String

	Dim aeDP() As String
	Dim aeNPI() As String
	Dim uh() As String

	Dim tList As New List(Of clsFileNameOLD)
	Dim tDT As New DataTable()
	Dim threePoundDT As New DataTable()
	Dim fourBySixDT As New DataTable()
	Dim sixByEightDT As New DataTable()

	Dim files As ReadOnlyCollection(Of String)
	Dim usersDCT As New Dictionary(Of Integer, String)

	Dim startDate As Date = CDate("1/1/14")
	Dim endDate As Date = CDate("12/31/14")

#End Region





#Region " Methods & Functions"


	''' <summary>
	''' Takes a DataTable as an argument and opens up
	''' a Crystal Report based on that data
	''' </summary>
	''' <param name="dt">DataTable</param>
	''' <remarks></remarks>
	Private Sub LoadDataSyncFile(ByVal dt As DataTable)

		Try

			Select Case dt.TableName

				Case "qryMyDPToday"
					' Prepare Report
					Dim rptXMLReport As New rptXMLData()
					rptXMLReport.SetDataSource(dt)
					CrystalReportViewer1.DisplayGroupTree = False
					CrystalReportViewer1.ReportSource = rptXMLReport

				Case "qryNPIdataSync"
					' Prepare Report
					Dim rptNPI As New rptNPIxmlData()
					rptNPI.SetDataSource(dt)
					CrystalReportViewer1.DisplayGroupTree = False
					CrystalReportViewer1.ReportSource = rptNPI

				Case "tblGuardRailDailyProductions"
					' Prepare Report
					Dim rptGR As New rptGRxmlData()
					rptGR.SetDataSource(dt)
					CrystalReportViewer1.DisplayGroupTree = False
					CrystalReportViewer1.ReportSource = rptGR

				Case "atmUhDT"	' Temp name
					' Prepare Report
					Dim rptUH As New rptUHxmlData()
					rptUH.SetDataSource(dt)
					CrystalReportViewer1.DisplayGroupTree = False
					CrystalReportViewer1.ReportSource = rptUH

				Case "threePoundDT"	 ' 3# Post Totals
					Dim rpt3LB As New rptPostLengths()
					rpt3LB.SetDataSource(dt)
					CrystalReportViewer1.DisplayGroupTree = False
					CrystalReportViewer1.ReportSource = rpt3LB

				Case Else
					MessageBox.Show(dt.TableName)

			End Select


		Catch ex As Exception
			MessageBox.Show(ex.Message, "LoadDataSyncFile()")
		End Try

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
	''' <remarks>Also invokes the CreateUsersDictionary() Method</remarks>
	Private Sub CreateFileList()

		CreateUsersDictionary()

		' Send each path/filename to class constructor
		' which spits out a filename class with the filename
		' elements broken down into usable properties. 
		' Then builds/adds to a list of clsFileName objects
		For Each item As String In files
			' Instantiate clsFileName object, with a full path filename
			' and the users Dictionary to get display name
			Dim t As New clsFileNameOLD(item, Me.usersDCT)
			' Add clsFileName object to list
			tList.Add(t)

			'tDT.Rows.Add(t)

		Next


		RemoveHandler dgvDPlist.SelectionChanged, AddressOf dgvDPlist_SelectionChanged
		With Me.dgvDPlist
			.DataSource = tList
			'.Columns(0).Visible = False
			'.Columns(1).Visible = False
		End With
		AddHandler dgvDPlist.SelectionChanged, AddressOf dgvDPlist_SelectionChanged

	End Sub


	''' <summary>
	''' Layout the DataGridView, set it's DataSource
	''' </summary>
	''' <remarks></remarks>
	Private Sub BindAndLayoutDGV()

		Try
			If xmlBS IsNot Nothing Then
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

			End If

		Catch ex As Exception
			MessageBox.Show(ex.Message, "BindAndLayoutDGV")
		End Try


	End Sub


	Private Sub SelectReportType(ByVal postType As String)

		Try
			npiBS.Filter = "npDescription LIKE '*" & postType & "'"

			Select Case postType

				Case "3# Post"
					threePoundDT = CType(npiBS.List, DataView).ToTable
					Dim rpt3LB As New rptPostLengths()
					rpt3LB.SetDataSource(threePoundDT)
					CrystalReportViewer1.DisplayGroupTree = False
					CrystalReportViewer1.ReportSource = rpt3LB

				Case "4x6 Wood Post"
					fourBySixDT = CType(npiBS.List, DataView).ToTable
					Dim rpt4x6 As New rptPostLengths4x6
					rpt4x6.SetDataSource(fourBySixDT)
					CrystalReportViewer1.DisplayGroupTree = False
					CrystalReportViewer1.ReportSource = rpt4x6

				Case "6x8 Wood Post"
					sixByEightDT = CType(npiBS.List, DataView).ToTable
					Dim rpt6x8 As New rptPostLength6x8
					rpt6x8.SetDataSource(sixByEightDT)
					CrystalReportViewer1.DisplayGroupTree = False
					CrystalReportViewer1.ReportSource = rpt6x8

			End Select



		Catch ex As Exception
			MessageBox.Show(ex.Message, "SelectReportType()")

		End Try

	End Sub




#End Region



#Region " Event Handlers"

	Private Sub frmReviewDataSync_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

		Me.QryUsersDisplayNamesTableAdapter.Fill(Me.ActionEntryDataSet.qryUsersDisplayNames)
		Me.TblNonPayItemsTableAdapter.Fill(Me.ActionEntryDataSet.tblNonPayItems)

		Try

			'' Local for testing
			'files = CType(My.Computer.FileSystem.GetFiles("C:\ActionEntry\DataSync\LocalDataSync\"), ReadOnlyCollection(Of String))

			' Server - Live
			files = CType(My.Computer.FileSystem.GetFiles(My.Settings.ae_TransferDataSyncPath), ReadOnlyCollection(Of String))

			'MessageBox.Show(files.Count.ToString)

			CreateFileList()

		Catch ex As Exception
			MessageBox.Show(ex.Message, "frmReviewDataSync_Load")

		End Try



	End Sub

	Private Sub dgvDPlist_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDPlist.CellDoubleClick
		Try
			'Dim newDT As DataTable = New DataTable("dtXMLdp")
			'newDT = CType(Me.xmlBS.List, DataView).ToTable
			'LoadDataSyncFile(newDT)

			Select Case dsType
				Case "ae_"
					LoadDataSyncFile(xmlDT)
				Case "npi"
					LoadDataSyncFile(npiDT)
				Case "gr_"
					LoadDataSyncFile(grDT)
				Case "uh_"
					LoadDataSyncFile(uhDT)
				Case Else
			End Select

		Catch ex As Exception
			MessageBox.Show(ex.Message, "dgvDPlist_CellDoubleClick()")
		End Try

	End Sub

	Private Sub dgvDPlist_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvDPlist.SelectionChanged

		Try
			Dim f As String = CType(Me.dgvDPlist.CurrentRow.Cells.Item(0).Value, String)
			Dim fName As String = FileNameOnly(f).Substring(0, 3)

			Select Case fName
				Case "ae_"
					' Daily Productions
					xmlDS = ReadDataSyncToDataSet(f)
					xmlBS = New BindingSource(xmlDS, "qryMyDPToday")
					xmlDT = xmlDS.Tables("qryMyDPToday")
					BindAndLayoutDGV()

				Case "npi"
					' Non Pay Items
					'MessageBox.Show(fName)
					npiDS = ReadDataSyncToDataSet(f)
					npiBS = New BindingSource(npiDS, "qryNPIdataSync")
					npiDT = npiDS.Tables("qryNPIdataSync")

					With Me.dgvCloudDP
						.DataSource = Nothing
						.DataSource = npiBS
					End With

				Case "gr_"
					' Guard Rail Non Pay Items
					'MessageBox.Show(fName)
					grDS = ReadDataSyncToDataSet(f)
					grBS = New BindingSource(grDS, "tblGuardRailDailyProductions")
					grDT = grDS.Tables("tblGuardRailDailyProductions")

					With Me.dgvCloudDP
						.DataSource = Nothing
						.DataSource = grBS
					End With

				Case "uh_"
					' Utility Hits
					'MessageBox.Show(fName)
					uhDS = ReadDataSyncToDataSet(f)
					uhBS = New BindingSource(uhDS, "atmUhDT")
					uhDT = uhDS.Tables("atmUhDT")

					With Me.dgvCloudDP
						.DataSource = Nothing
						.DataSource = uhBS
					End With

				Case Else
					' Anything unexpected
					MessageBox.Show(fName)
					With Me.dgvCloudDP
						.DataSource = Nothing

					End With

			End Select

			' Set Global Variable to set DataSync type
			Me.dsType = fName



		Catch ex As Exception
			MessageBox.Show(ex.Message, "dgvDPlist_SelectionChanged()")
		End Try

	End Sub

	Private Sub btnThree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThree.Click, btn4x6.Click, btn6x8.Click

		Dim btn As Button = DirectCast(sender, Button)

		Select Case btn.Name

			Case "btnThree"
				SelectReportType("3# Post")
			Case "btn4x6"
				SelectReportType("4x6 Wood Post")
			Case "btn6x8"
				SelectReportType("6x8 Wood Post")

		End Select



	End Sub


#End Region


	' Good Stuff!!!  Grouping, etc.
	Private Sub InterestingDataTableGrouping()

		'_________________________________________
		'' Pasted Here for Reference only

		'' Non Pay Items
		''MessageBox.Show(fName)
		'npiDS = ReadDataSyncToDataSet(f)
		'npiBS = New BindingSource(npiDS, "qryNPIdataSync")
		'npiDT = npiDS.Tables("qryNPIdataSync")

		'With Me.dgvCloudDP
		'	.DataSource = Nothing
		'	.DataSource = npiBS
		'End With
		'_________________________________________




		''xmlDT = CType(xmlBS.List, DataView).ToTable(True, "jobNum")
		''xmlDT.DefaultView.ToTable(True, "jobNum")
		''.defaultview.totable(distinct as boolean, paramarray()) version to get distinct rows from table


		' Create Clone DataView to Get DISTINCT values ("Group By" Clause)
		Dim cView As DataView = CType(xmlBS.List, DataView)



		'' Fill DataTables with Grouped Values
		'jobDT = cView.ToTable(True, "jobNum")
		foremanDT = cView.ToTable(True, "displayName")
		'dateDT = cView.ToTable(True, "entryDate")
		'payItemDT = cView.ToTable(True, "description")

		''RemoveHandler cmbJob.SelectedIndexChanged, AddressOf cmbJob_SelectedIndexChanged
		''With Me.cmbJob
		''	.DataSource = jobDT
		''	.DisplayMember = "jobNum"
		''End With
		''AddHandler cmbJob.SelectedIndexChanged, AddressOf cmbJob_SelectedIndexChanged

		''RemoveHandler cmbForeman.SelectedIndexChanged, AddressOf cmbForeman_SelectedIndexChanged
		''With Me.cmbForeman
		''	.DataSource = foremanDT
		''	.DisplayMember = "displayName"
		''End With
		''AddHandler cmbForeman.SelectedIndexChanged, AddressOf cmbForeman_SelectedIndexChanged


	End Sub




#Region " Legacy Methods"

	Private Sub DownloadFiles()
		'Try

		'	'If ATM network exists do this here

		'	Dim filesToGet() As String = GetFileNameStringArrayFromFTP(My.Settings.ae_FTPDataSyncURL)

		'	If My.Settings.ae_UserID <= 6 Then
		'		MessageBox.Show("Connected to the server: " & AtWorkOrNot().ToString)
		'	Else
		'		AtWorkOrNot()
		'	End If



		'	' The 2nd argument indicates Transfer Direction (1 = Upload, 2 = Download)
		'	' The 3rd argument indicates File Type (1 = XML, 2 = Images)
		'	Dim xmlDP As New frmDataSyncProgress(filesToGet, 2, 1)
		'	xmlDP.MdiParent = AE_mdiMain.MdiParent
		'	xmlDP.Show()

		'Catch ex As Exception
		'	MessageBox.Show(ex.Message, "DownloadFiles()")
		'End Try


	End Sub


	'Private Function MergeAllDataSets(ByVal targetDirectory As String) As DataSet

	'	'Try
	'	'	Dim MasterDataSet As New DataSet
	'	'	Dim fileEntries As String() = System.IO.Directory.GetFiles(targetDirectory)

	'	'	For Each f As String In fileEntries
	'	'		Dim tempName As String = Path.GetFileName(f)
	'	'		If tempName.Substring(0, 2) = "ae" Then
	'	'			Dim tDs As New TempDataSet
	'	'			tDs.TheDataSet = GetDataSetFromDataSync(tempName)
	'	'			MasterDataSet.Merge(tDs.TheDataSet, True)
	'	'		Else
	'	'			' Can only handle dp xml in this method the way it is
	'	'			' currently written.
	'	'		End If


	'	'		'Dim x As Integer = 0

	'	'		'' Daily Productions "ae_" Legend:
	'	'		'' 0 = Dp, Uh, Npi, etc.
	'	'		'' 1 = UserID
	'	'		'' 2 = Job#
	'	'		'' 3 = Date

	'	'		'' Split the string on the underscore character
	'	'		'Dim parts As String() = tempName.Split(New Char() {"_"c})
	'	'		'For Each part As String In parts
	'	'		'	Select Case part
	'	'		'		Case "ae"
	'	'		'			aeDP(x) = part
	'	'		'			If x = 0 Then
	'	'		'				Dim tDs As New TempDataSet
	'	'		'				tDs.TheDataSet = GetDataSetFromDataSync(tempName)
	'	'		'				MasterDataSet.Merge(tDs.TheDataSet, True)
	'	'		'			End If

	'	'		'		Case "npi"

	'	'		'		Case "uh"

	'	'		'	End Select

	'	'		'	'Get jobNum from each fileName and create an array, bound to a cmb
	'	'		'	'to display only available DataSync files.d

	'	'		'Next

	'	'	Next

	'	'	Return MasterDataSet

	'	'Catch ex As Exception
	'	'	MessageBox.Show(ex.Message, "MergeAllDataSets()")
	'	'	Return Nothing
	'	'End Try



	'End Function


	'Private Sub ViewAllDP()
	'	'Try
	'	'	xmlDS = MergeAllDataSets(My.Settings.ae_TransferDataSyncPath)
	'	'	If xmlDS IsNot Nothing Then
	'	'		xmlBS = New BindingSource(xmlDS, "qryMyDPToday")
	'	'		With Me.dgvCloudDP
	'	'			.DataSource = xmlBS

	'	'			' Foreman ID
	'	'			.Columns(0).Visible = False

	'	'			' EntryDate
	'	'			.Columns(1).Visible = False

	'	'			' DisplayName
	'	'			.Columns(2).Visible = True
	'	'			.Columns(2).HeaderText = "Foreman"

	'	'			' ID
	'	'			.Columns(3).Visible = False

	'	'			' dpID
	'	'			.Columns(4).Visible = False

	'	'			' jobNum
	'	'			.Columns(5).Visible = True

	'	'			' Station#
	'	'			.Columns(6).Visible = True
	'	'			.Columns(6).HeaderText = "Station #"

	'	'			' payItemID
	'	'			.Columns(7).Visible = False

	'	'			' code
	'	'			.Columns(8).Visible = False

	'	'			' Description
	'	'			.Columns(9).Visible = True
	'	'			.Columns(9).HeaderText = "Description"

	'	'			' Qty
	'	'			.Columns(10).Visible = True
	'	'			.Columns(10).HeaderText = "Qty"

	'	'			' siteNotes
	'	'			.Columns(11).Visible = False
	'	'		End With


	'	'		BindContainers()


	'	'	End If

	'	'Catch ex As Exception
	'	'	'MessageBox.Show(ex.Message, "")
	'	'End Try
	'End Sub

	'Public Function GetDataSetFromDataSync(ByVal DataSyncToClean As String) As DataSet

	'	'Dim cleanDS As DataSet
	'	'Try
	'	'	cleanDS = New DataSet(DataSyncToClean)
	'	'	cleanDS.ReadXml(My.Settings.ae_TransferDataSyncPath & DataSyncToClean)
	'	'	Return cleanDS

	'	'Catch ex As Exception
	'	'	Return Nothing
	'	'End Try

	'End Function

















#End Region









	Private Sub btnNPIReview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNPIReview.Click

		Try
			Dim ds As DataSet = New DataSet

			'My.Settings.mhsFilePath = "C:\mhsTime\Time\"

			For Each npiFile As String In Directory.GetFiles("\\atmtermserv01\company data\action\aeDataSync\Warehouse\")
				Dim fName As String = Path.GetFileNameWithoutExtension(npiFile)
				Dim f() As String = fName.Split("_")
				Dim d8 As Date = Date.Parse(f(2))

				If d8 >= startDate And d8 <= endDate Then
					ds.ReadXml(npiFile)
				End If

			Next


			'myReport.SetDataSource(ds.Tables(0))
			'CrystalReportViewer1.DisplayGroupTree = False
			'CrystalReportViewer1.ReportSource = myReport
			'Dim dateStr As String = startDate & " - " & endDate
			'myReport.SetParameterValue("dateRange", dateStr)


		Catch ex As Exception
			MessageBox.Show(ex.Message, "btnNPIReview_Click")

		End Try

	End Sub
End Class











Public Class clsFileNameOLD



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