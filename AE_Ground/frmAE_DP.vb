Option Strict Off
Option Explicit On

Imports System.IO
Imports System.Xml.Serialization
Imports System.Data.OleDb
Imports AE_Ground.clsAE_Utilities
Imports System.Text.RegularExpressions


Public Class frmAE_DP

	Public Sub New()

		' This call is required by the Windows Form Designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

		'' Set DoubleBuffer to True for all Controls - Hope it works?!?!?!?
		'Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or _
		'ControlStyles.UserPaint Or _
		'ControlStyles.DoubleBuffer, True)

	End Sub


#Region " Class-Level Declarations"



	' Previous Site - "Station Number"
	Dim prevSite As String = Nothing

	' Initial Entry - Determines Re-Direct Location
	' After Successful login
	Dim ie As Boolean = True

	' Self Explanatory
	Dim ParentSiteCellFormat As New DataGridViewCellStyle
	Dim ChildSiteCellformat As New DataGridViewCellStyle

	Dim BoldRow As New DataGridViewCellStyle With {.Font = New System.Drawing.Font("Verdana", 8.0!, FontStyle.Bold)}
	Dim RegularRow As New DataGridViewCellStyle With {.Font = New System.Drawing.Font("Verdana", 8.0!, FontStyle.Regular)}

	' Junk DGV used in the MarkSelected() Method
	Dim dgv As DataGridView

	' CheckBox to be displayed in dgvJobPayItems 
	' header row.  Used for Select All/None
	Private WithEvents ckb As New CheckBox

	' Declare Event to raise for Dynamically instantiated CheckBox
	' This CheckBox is for dgvJobPayItems CheckBox column to Select All/None
	Public Event ckbCheck_Changed()

	Dim FOURSIXMAX As Double = 24
	Dim SIXEIGHTMAX As Double = 24
	Dim THREEPOUNDMAX As Double = 19

	Dim FOURSIXMIN As Double = 14
	Dim SIXEIGHTMIN As Double = 16
	Dim THREEPOUNDMIN As Double = 10


	' To Update tblDailyProductions
	Dim uID As Integer
	Dim uQty As Double
	Dim uNotes As String
	Dim uForeman As Integer
	Dim uDate As Date

	' Default ComboBox.Text (The Text displayed in the TextBox portion of the CombBox Control)
	Dim _AE_DefaultComboBoxText As String



#End Region


#Region " Properties"

	Public Property FourBySixMax() As Double
		Get
			Return FOURSIXMAX
		End Get
		Set(ByVal value As Double)
			FOURSIXMAX = value
		End Set
	End Property

	Public Property FourBySixMin() As Double
		Get
			Return FOURSIXMIN
		End Get
		Set(ByVal value As Double)
			FOURSIXMIN = value
		End Set
	End Property




	Public Property SixByEightMax() As Double
		Get
			Return SIXEIGHTMAX
		End Get
		Set(ByVal value As Double)
			SIXEIGHTMAX = value
		End Set
	End Property

	Public Property SixByEightMin() As Double
		Get
			Return SIXEIGHTMIN
		End Get
		Set(ByVal value As Double)
			SIXEIGHTMIN = value
		End Set
	End Property



	Public Property AE_DefaultComboBoxText() As String
		Get
			Return _AE_DefaultComboBoxText
		End Get
		Set(ByVal value As String)
			_AE_DefaultComboBoxText = value
		End Set
	End Property





#End Region




	'' *** Get a DataView of the table contained in the dataset. ***

	'Dim tables As DataTableCollection = set1.Tables
	'Dim view1 As New DataView(tables(0))


#Region " Methods and Functions"



	Private Sub DataSync()

		Try
			Me.QryMyDPTodayBindingSource.EndEdit()
			Dim dtbl As DataTable = CType(Me.QryMyDPTodayBindingSource.List, DataView).ToTable
			'Dim dtbl As DataTable = dvw.ToTable()

			My.Settings.ae_CurrDataSyncFileName = BuildXmlName("ae", My.Settings.ae_CurrentJob, Me.DateTimePicker1.Value.ToString("MM-dd-yyyy"))

			' Utilities Method
			WriteDataSync(dtbl, My.Settings.ae_CurrDataSyncFileName)

			' Write NonPayItems DataSyncFile
			NpiDataSync()

			'' Write GuardRail DataSyncFile
			'GuardRailDataSync()



		Catch ex As Exception
			MessageBox.Show(ex.Message, "DataSync()")
		End Try

	End Sub

	Private Sub NpiDataSync()

		Try

			Me.QryNPIdataSyncBindingSource.EndEdit()
			Me.QryNPIdataSyncBindingSource.Filter = "userID = " & My.Settings.ae_UserID & " And productionDate >= #" & My.Settings.ae_WorkingDate.Date & "#"

			Dim npiDT As DataTable = CType(Me.QryNPIdataSyncBindingSource.List, DataView).ToTable

			Dim thisFileName As String = BuildXmlName("npi", My.Settings.ae_CurrentJob, My.Settings.ae_WorkingDate.ToString("MM-dd-yyyy"))

			WriteDataSync(npiDT, thisFileName)


		Catch ex As Exception

		End Try
	End Sub

	Private Sub GuardRailDataSync()
		Try

			Me.TblGuardRailDailyProductionsBindingSource.EndEdit()
			Me.TblGuardRailDailyProductionsBindingSource.Filter = "foreman = " & My.Settings.ae_UserID & " And runDate >= #" & My.Settings.ae_WorkingDate.Date & "#"

			Dim grDT As DataTable = CType(Me.TblGuardRailDailyProductionsBindingSource.List, DataView).ToTable

			Dim thisFileName As String = BuildXmlName("gr", My.Settings.ae_CurrentJob, My.Settings.ae_WorkingDate.ToString("MM-dd-yyyy"))

			WriteDataSync(grDT, thisFileName)

			Me.TblGuardRailDailyProductionsBindingSource.Filter = Nothing

		Catch ex As Exception

		End Try
	End Sub

	'Private Sub BuildFileName()
	'	Try
	'		My.Settings.ae_CurrDataSyncFileName = _
	'		 "ae_" & _
	'		  My.Settings.ae_UserID.ToString & "_" & _
	'		  My.Settings.ae_CurrentJob & "_" & _
	'		  Me.DateTimePicker1.Value.ToString("MM-dd-yyyy") & ".xml"
	'	Catch ex As Exception
	'		My.Settings.ae_CurrDataSyncFileName = _
	'		 "ae_" & _
	'		 My.Settings.ae_UserID.ToString & "_" & _
	'		 Now.ToString("MM-dd-yyyy_HH:mm:ss tt") & ".xml"
	'	End Try
	'End Sub

	Private Sub GetUsersDPforToday()
		Try
			' Calling the Utilities fx returning a DataSet, then getting
			' a DataTableCollection, then getting a DataView from the DataSet
			Dim xmlDS As New DataSet
			If File.Exists(My.Settings.ae_DataSyncPath & My.Settings.ae_CurrDataSyncFileName) Then
				xmlDS = ReadDataSyncToDataSet(My.Settings.ae_DataSyncPath & My.Settings.ae_CurrDataSyncFileName)
			End If

			If Not xmlDS Is Nothing Then
				Dim xmlTables As DataTableCollection = xmlDS.Tables
				Dim xmlView As New DataView(xmlTables(0))

				With Me.DataGridView1
					.DataSource = xmlView
					.Columns(0).Visible = False
					.Columns(1).Visible = False
					.Columns(2).Visible = False
					.Columns(3).Visible = False
					.Columns(4).Visible = False
					.Columns(5).Visible = False
					.Columns(6).HeaderText = "Station #"
					.Columns(6).Width = 85
					.Columns(7).Visible = False
					.Columns(8).Visible = False
					.Columns(9).HeaderText = "Description"
					.Columns(9).Width = 204
					.Columns(10).HeaderText = "Qty"
					.Columns(10).Width = 51
					.Columns(11).Visible = False
				End With

				My.Settings.ae_WorkingDate = Me.DateTimePicker1.Value




				'If Not Me.DateTimePicker1.Checked Then
				'	My.Settings.ae_WorkingDate = Now()
				'Else
				'	My.Settings.ae_WorkingDate = Me.DateTimePicker1.Value
				'End If

			End If

			' I've disabled "Save My.Settings on Shutdown" and doing so manually
			' to hopefully resolve an error on all the netbooks (Atom processors)
			My.Settings.Save()

		Catch ex As Exception
			'MessageBox.Show(ex.Message, "GetUsersDPforToday()")
		End Try
	End Sub

	Private Sub LoadUsersDP_ManualEntry()

		' Add this record to todays production list 
		Me.QryMyDPTodayTableAdapter.Fill(Me.ActionEntryDataSet.qryMyDPToday)
		Dim filterString As String = "jobNum = '" & My.Settings.ae_CurrentJob & "' And foreman = " & My.Settings.ae_UserID & " And entryDate = #" & My.Settings.ae_WorkingDate.Date & "#"
		Me.QryMyDPTodayBindingSource.Filter = filterString

	End Sub

	Public Sub LoadJobPI()
		'***********************************************************************************************
		'	\\Vitals:
		'***********************************************************************************************
		'****************All Code, Logic, Concepts And DBMS Developed For And Owned By:****************'
		'	Action Traffic Maintenance, Inc.
		'	Michigan Highway Signs, Inc.
		'	Jeff King......:  Lead Software Engineer/DBMS Manager
		'	Luke McClain...:  Software Developer/Hardware Technician
		'	Michael Peake..:  Systems Consultant/End User-Administrative
		'	Paul Roth......:  Systems Consultant/End User-Administrative
		'***********************************************************************************************
		'	\\Keys:
		'***********************************************************************************************
		'	Purpose....:  Load Job Pay Items from ActionEntry.mdb 
		'	Input......:  Job Number - Not passed as an argument
		'	Output.....:  DataGridView Displaying all Pay Items for given Job
		'	Issues.....:  -Don't run the LoadJobDP Method yet...COMPLETED
		'				  -Make this more like a wizard...COMPLETED
		'				  -Wait until user selects pay item(s) or wants to view complete 
		'				  -production listing for all pay items in given job...COMPLETED
		'	
		'				  -Why did I mark this Method as "Public"?  -jk 07.11.2011
		'
		'***********************************************************************************************

		Try
			' Change Cursor, Signal to user the application is thinking
			Me.Cursor = Cursors.WaitCursor

			' Load Previous Session Job Number Setting
			Dim x As String = My.Settings.ae_CurrentJob

			' Skip this code if no value in previous Job number setting 
			If Not x Is Nothing Then
				If Me.drpActiveJobs.CurrentItemIndex >= 0 Then
					x = Me.drpActiveJobs.CurrentItem.Controls("lblJobNumber").Text
					My.Settings.ae_CurrentJob = x
					My.Settings.ae_WorkingDate = Now()

					My.Settings.ae_CurrDataSyncFileName = BuildXmlName("ae", My.Settings.ae_CurrentJob, My.Settings.ae_WorkingDate.ToString("MM-dd-yyyy"))
					'BuildFileName()

					Me.QryPayItemsByJobTableAdapter.Fill(Me.ActionEntryDataSet.qryPayItemsByJob, x)
					Me.QryPayItemsByJobBindingSource.Sort = "code ASC"
					With Me.dgvJobPayItems
						.DataSource = QryPayItemsByJobBindingSource
						'.ColumnHeadersVisible = False
						.Columns(0).Width = 24
						.Columns(1).Visible = False
						.Columns(2).Visible = False
						.Columns(3).Visible = False
						.Columns(4).Width = 222
						.Columns(4).Resizable = DataGridViewTriState.False
						.Columns(5).Visible = False
					End With
				End If
			End If
		Catch ex As Exception
			MessageBox.Show(ex.Message, "LoadJobPI()")
		Finally
			' Change Cursor to Normal
			Me.Cursor = Cursors.Arrow
		End Try

		' I've disabled "Save My.Settings on Shutdown" and doing so manually
		' to hopefully resolve an error on all the netbooks (Atom processors)
		My.Settings.Save()

	End Sub

	Private Sub LoadJobDP()
		'***********************************************************************************************
		'	\\Vitals:
		'***********************************************************************************************
		'****************All Code, Logic, Concepts And DBMS Developed For And Owned By:****************'
		'	Action Traffic Maintenance, Inc.
		'	Michigan Highway Signs, Inc.
		'	Jeff King......:  Lead Software Engineer/DBMS Manager
		'	Luke McClain...:  Software Developer/Hardware Technician
		'	Michael Peake..:  Systems Consultant/End User-Administrative
		'	Paul Roth......:  Systems Consultant/End User-Administrative
		'***********************************************************************************************
		'	\\Keys:
		'***********************************************************************************************
		'	Purpose....:  Type Here
		'	Input......:  Type Here
		'	Output.....:  Type Here
		'	Issues.....:  -Type Here
		'				  -Type Here
		'				  -Type Here
		'				  -Type Here
		'***********************************************************************************************

		Try
			' Change Cursor, Signal to user the application is thinking
			Me.Cursor = Cursors.WaitCursor

			' Load Daily Productions
			'Me.DPBindingSource.EndEdit()
			Me.DPTableAdapter.Fill(Me.ActionEntryDataSet.DP, My.Settings.ae_CurrentJob)

			' Load Current Day's Daily Production Items, if any.
			GetUsersDPforToday()

		Catch ex As Exception
			MessageBox.Show(ex.Message, "LoadJobDP()")
		Finally
			' Change Cursor to Normal
			Me.Cursor = Cursors.Arrow
		End Try

	End Sub

	Private Sub FilterTheDP_BS()

		'***********************************************************************************************
		'	\\Vitals:
		'***********************************************************************************************
		'****************All Code, Logic, Concepts And DBMS Developed For And Owned By:****************'
		'	Action Traffic Maintenance, Inc.
		'	Michigan Highway Signs, Inc.
		'	Jeff King......:  Lead Software Engineer/DBMS Manager
		'	Luke McClain...:  Software Developer/Hardware Technician
		'	Michael Peake..:  Systems Consultant/End User-Administrative
		'	Paul Roth......:  Systems Consultant/End User-Administrative
		'***********************************************************************************************
		'	\\Keys:
		'***********************************************************************************************
		'	Purpose....:  Type Here
		'	Input......:  Type Here
		'	Output.....:  Type Here
		'	Issues.....:  -Type Here
		'				  -Type Here
		'				  -Type Here
		'				  -Type Here
		'***********************************************************************************************

		' Dictionary to keep track of which items are Checked in the
		' Job Pay Items DataGridview (dgvJobPayItems)
		Dim checkList As New Dictionary(Of Integer, Boolean)

		Try

			' Used to build the Filter String of the
			' BindingSource.Filter Property.
			Dim pIDFilter As String = Nothing

			' Iterate/Loop through each row of the DataGridView 
			For Each row As DataGridViewRow In dgvJobPayItems.Rows
				' If CheckBox is Checked then include CurrentRow's payItemID value
				Dim ckd As Boolean = CBool(row.Cells(0).Value)
				checkList.Add(row.Index, ckd)
				If ckd Then
					' Check to see if this is the first value to be added to the string
					If pIDFilter Is Nothing Then
						' Declare Field name and CurrentRow's payItemID value as FilterString
						pIDFilter = "payItemID = " & row.Cells.Item(2).Value.ToString
					Else
						' Append CurrentRow's payItemID value to existing FilterString
						pIDFilter += " Or payItemID = " & row.Cells.Item(2).Value.ToString
					End If
				End If
			Next

			' Save the current List of Pay Items where 
			' quantity or activity was reported during this/previous
			' sessions.
			' Need to infuse the code to apply Saved (Settings) FilterString
			' When Form Loads.
			My.Settings.ae_PayItemsFilter = pIDFilter

			' Iterate through dgv rows
			For Each row2 As DataGridViewRow In Me.dgvJobPayItems.Rows
				' Check Dictionary to see if current row was previously Checked
				' before this method ran again, then make it Checked
				If checkList.Item(row2.Index) Then row2.Cells(0).Value = True
			Next

			' Apply Filter to BindingSource using the built FilterString
			Me.DPBindingSource.Filter = pIDFilter

			' Call Method to Iterate through dgv.Rows, alternating BackColor on Station#
			CommonSiteDGVBackColor()

		Catch ex As Exception
			MessageBox.Show(ex.Message, "FilterTheDP_BS()")
		Finally

			' Change Cursor to Normal
			Me.Cursor = Cursors.Arrow
		End Try

	End Sub

	Private Sub ReCheckPayItemDGV()

		'Me.DataGridView4.DataSource = Me.checkList.Select((Function(kv) New With {.myKeys = kv.Key, .myValues = kv.Value})).ToArray

		Dim NumberMatchCriteria As New Regex("[0-9]{1,}")
		Dim myListOfValues As List(Of Match) = NumberMatchCriteria.Matches(My.Settings.ae_PayItemsFilter).Cast(Of Match).ToList

		Try
			Dim x As Integer
			Dim ckd As Boolean
			Dim dt As DataTable = CType(Me.QryPayItemsByJobBindingSource.List, DataView).ToTable
			' Iterate through dgv rows and check selected pay items
			For Each row As DataGridViewRow In Me.dgvJobPayItems.Rows
				' PayItemID from Job Pay Items DGV
				x = CInt(row.Cells.Item(2).Value)
				For Each myValue As Match In myListOfValues
					ckd = False
					If CInt(myValue.Value) = x Then
						ckd = True
						Exit For
					End If
				Next
				row.Cells.Item(0).Value = ckd
			Next
		Catch ex As Exception
			MessageBox.Show(ex.Message, "ReCheckPayItemDGV()")
		End Try

	End Sub

	Private Sub LoadStationNPI(ByVal dpI As Integer)

		' Load All Non Pay Items Productions - Filtering occurs on each DP record
		Me.TblNonPIProductionsTableAdapter.Fill(Me.ActionEntryDataSet.tblNonPIProductions)

		Me.QryNPIdataSyncTableAdapter.Fill(Me.ActionEntryDataSet.qryNPIdataSync, My.Settings.ae_CurrentJob)

		Me.QryNonPITableAdapter.Fill(Me.ActionEntryDataSet.QryNonPI)
		Me.QryNonPIBindingSource.Filter = "dpID = " & dpI

	End Sub

	'Private Function GetNPIunit(ByVal npiID As Integer) As String


	'	' No!  Not this way!

	'	Dim unitStr As String = "ERROR"

	'	Try
	'		Me.TblNonPayItemsTableAdapter.Fill(Me.ActionEntryDataSet.tblNonPayItems)
	'		Me.TblNonPayItemsBindingSource.Filter = "ID = " & npiID

	'		Dim dtTemp As DataTable = CType(Me.TblNonPayItemsBindingSource.List, DataView).ToTable
	'		unitStr = dtTemp.Rows.Item(0).Item(3).ToString

	'	Catch ex As Exception
	'		MessageBox.Show(ex.Message, "GetNPIunit()")
	'	End Try

	'	Return unitStr

	'	Me.TblNonPayItemsBindingSource.Filter = Nothing


	'End Function

	Private Sub CommonSiteDGVBackColor()

		' Change Cursor, Signal to user the application is thinking
		Me.Cursor = Cursors.WaitCursor

		' Display current DGV/BS record count
		DisplayCounter()

		Dim switchBackColor As Boolean = False
		Dim prevSite As String = Nothing
		Dim x As Integer = 0  ' Counter to switch row colors 
		Dim LightBackColor As New Color
		Dim DarkBackColor As New Color

		LightBackColor = Color.WhiteSmoke
		DarkBackColor = Color.Aquamarine

		Try
			' Set initial backcolor here
			Me.dgvDP.DefaultCellStyle.BackColor = LightBackColor

			For Each row As DataGridViewRow In Me.dgvDP.Rows
				' If stations numbers are different then respond accordingly
				If row.Cells.Item(3).Value.ToString = prevSite Then
					switchBackColor = False
					Select Case x
						Case 0
							' Maintain
							row.DefaultCellStyle.BackColor = LightBackColor
						Case 1
							row.DefaultCellStyle.BackColor = DarkBackColor
							x = 1
					End Select
				Else
					If x = 0 Then
						row.DefaultCellStyle.BackColor = DarkBackColor
						x = 1
					Else
						row.DefaultCellStyle.BackColor = LightBackColor
						x = 0
					End If
				End If

				' Detect color and switch to alternate color
				Select Case switchBackColor
					Case True
						row.DefaultCellStyle.BackColor = DarkBackColor
					Case False
						' Do Nothing
				End Select

				' Remember the Previous Station Number (Site)
				prevSite = row.Cells.Item(3).Value.ToString

			Next

		Catch ex As Exception
			MessageBox.Show(ex.Message, "CommonSiteDGVBackColor()")
		Finally

			' Change Cursor to Normal
			Me.Cursor = Cursors.Arrow
		End Try


	End Sub

	Private Sub DGVCheckBoxHeader()
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

			'Get the column header cell bounds
			Dim rect As Rectangle = Me.dgvJobPayItems.GetCellDisplayRectangle(0, -1, True)

			ckb.BackColor = Color.Transparent
			ckb.CheckAlign = ContentAlignment.MiddleCenter

			Dim Pt As New Point(1, 0)
			'Pt.X = rect.Location.X + (rect.Width - ckb.Width) \ 2 '+ 1
			'Pt.Y = rect.Location.Y + (rect.Height - ckb.Height) \ 2	'+ 1

			'Change the location of the CheckBox; The Header
			ckb.Location = Pt

			'Add the CheckBox into the DataGridView
			Me.dgvJobPayItems.Controls.Add(ckb)

		Catch ex As Exception
			MessageBox.Show(ex.Message)
		Finally

			' Change Cursor to Normal
			Me.Cursor = Cursors.Arrow
		End Try


	End Sub

	Private Sub DisplayCounter()

		Try

			Dim x1 As CurrencyManager = Me.DPBindingSource.CurrencyManager
			Dim x As Integer = x1.Position + 1
			Dim y As Integer = Me.DPBindingSource.Count
			Me.lblRecCount.Text = x & "  of  " & y.ToString & "  Items"
		Catch ex As Exception

		Finally

		End Try

	End Sub

	Private Sub ToggleDPCompletedFilter()

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
		'	Issues.....:  -  Not needed now... see checkbox checkchanged event
		'				  -
		'				  -
		'				  -
		'***********************************************************************************************

		'Try
		'	' Change Cursor, Signal to user the application is thinking
		'	Me.Cursor = Cursors.WaitCursor

		'	'Dim query = From process In System.Diagnostics.Process.GetProcesses() _
		'	'			Order By process.StartTime Descending _
		'	'			Skip While process.Threads.Count > 1


		'	' Get absolute current row from the BindingSource
		'	Dim row As DataRow
		'	row = CType(CType(Me.DPBindingSource.Current, DataRowView).Row, DataRow)

		'	' LINQ is awesome!  Filters out Items previously reported as work completed
		'	' Filter needs option to invert back and forth
		'	Dim NotCompleted = From nPI In Me.DPBindingSource Skip While row.Item("entryDate") IsNot DBNull.Value Or row.Item("entryDate") IsNot String.Empty
		'	Dim CompletedPI = From cnPI In Me.DPBindingSource Skip While row.Item("entryDate") Is DBNull.Value Or row.Item("entryDate") Is String.Empty

		'	' Don't I have to explicity declare the DataType? I'm confused



		'	Select Case Me.CheckBox1.Checked
		'		Case True
		'			dgvDP.DataSource = CType(NotCompleted, DataTable)

		'		Case Else
		'			dgvDP.DataSource = CType(CompletedPI, DataTable)
		'	End Select
		'	dgvDP.DataSource = NotCompleted

		'Catch ex As Exception
		'	MessageBox.Show(ex.Message, "ToggleDPCompletedFilter()()")
		'Finally
		'	' Change Cursor to Normal
		'	Me.Cursor = Cursors.Arrow
		'End Try



	End Sub

	Private Sub AddToUpdatedRecords(ByVal cID As Integer, ByVal site As String, ByVal description As String, ByVal qty As String)

		'Try
		'	Me.dgvProduction.Rows.Insert(0, cID, site, description, qty)

		'	'' Deselect all rows
		'	'For Each row As DataGridViewRow In dgvProduction.Rows
		'	'	row.Selected = False
		'	'Next

		'Catch ex As Exception
		'	'MessageBox.Show(ex.Message, "AddToUpdatedRecords()")

		'Finally

		'End Try

	End Sub

	Private Function Need2Posts(ByVal s As Double, ByVal postPI As String) As Boolean
		Select Case postPI
			Case "8100156", "8100370", "8100371"	'3 # post
				If s > THREEPOUNDMAX Then
					Return True
				Else
					Return False
				End If
			Case "8100165", "8100165fdn", "8100170", "8100170fdn", "8100380", "8100380fdn", "8100381", "8100381fdn"	  '4x6 wood post
				If s > FOURSIXMAX Then
					Return True
				Else
					Return False
				End If
			Case "8100166", "8100166fdn", "8100171", "8100171fdn", "8100382", "8100382fdn", "8100383", "8100383fdn"	'6x8 wood post
				If s > SIXEIGHTMAX Then
					Return True
				Else
					Return False
				End If
			Case Else
				Return False
		End Select
	End Function

	Private Sub ViewSelectColor()
		' Accent Previous Reported Items
		Dim dV As Double
		'Dim dT As Date
		Try
			For Each r As DataGridViewRow In Me.dgvDP.Rows
				If Not r.Cells.Item(8).Value Is DBNull.Value Then
					Try
						dV = CDbl(r.Cells.Item(8).Value)
					Catch ex As Exception
						dV = 0
					End Try
					If dV > 0 Then
						r.DefaultCellStyle = New DataGridViewCellStyle _
						 With {.Font = New Drawing.Font("Verdana", 9.75!, FontStyle.Italic)}
						r.DefaultCellStyle.BackColor = Color.Gray
						r.DefaultCellStyle.ForeColor = Color.White
					End If
				End If
			Next

		Catch ex As Exception

		Finally

			'Me.panPayItemsMain.Visible = True
			'Me.panNonPayItemsMain.Visible = True

			' Hide Job's and Pay Items Panels
			Me.ckbDailyProductions.Checked = True

		End Try
	End Sub

	Private Sub ToggleEnabledFields(ByVal dpq As Integer, ByVal dpt As Date)
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
		'	Purpose....:  Enable/Disable/Hide/Show specific controls/fields as needed
		'	Input......:  dpq = Daily Produciton Qty, dpt = Entry Date
		'	Output.....:  Fields properly enabled/disabled
		'	Issues.....:  -
		'				  -
		'				  -
		'				  -
		'***********************************************************************************************

		'Try
		'	' Change Cursor, Signal to user the application is thinking
		'	Me.Cursor = Cursors.WaitCursor

		'	' Disable Reporting/Editing of previouly reported items
		'	' Will update this to compare its entryDate to Today

		'	' Difference, in days, between two given Dates.
		'	Dim result As Integer = Date.Compare(dpt, Today)

		'	'MessageBox.Show(result.ToString & vbCrLf & _
		'	' dpt.Date.ToString & vbCrLf & _
		'	' Today.Date.ToString)


		'	'  TODO: Should make sure the user trying to 
		'	'  edit is the same who entered

		'	Dim showOrNot As Boolean = False

		'	' Dates are the same
		'	' Allow user to edit
		'	If result = 0 Then
		'		Me.btnModifyQty.Enabled = True
		'		Me.btnQtyValid.Enabled = True
		'		Me.btnSelect.Enabled = True
		'		Me.SiteNotesRichTextBox.Enabled = True
		'	Else
		'		If dpq >= 0 Then	' Daily Production Qty is Greater than Zero
		'			showOrNot = False
		'			Me.lblEntryDate.Visible = True

		'		Else
		'			showOrNot = True
		'			Me.lblEntryDate.Visible = False
		'		End If
		'		Me.btnModifyQty.Enabled = showOrNot
		'		Me.btnQtyValid.Enabled = showOrNot
		'		'Me.btnSelect.Enabled = showOrNot
		'		Me.SiteNotesRichTextBox.Enabled = showOrNot
		'	End If

		'Catch ex As Exception
		'	MessageBox.Show(ex.Message, "ToggleEnabledFields()")
		'Finally
		'	' Change Cursor to Normal
		'	Me.Cursor = Cursors.Arrow
		'End Try

	End Sub

	' Not used
	Public Function CreateMyDateTimePicker(ByVal dtpName As String) As DateTimePicker
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
		'	Purpose....:  - Not used yet.  -jk  07.11.2011
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

			' Create a new DateTimePicker control and initialize it.
			Dim dateTimePicker1 As New DateTimePicker()

			With dateTimePicker1
				' Set the MinDate and MaxDate.
				.MinDate = New DateTime(1985, 6, 20)
				.MaxDate = DateTime.Today

				' Set the CustomFormat string.
				.CustomFormat = "MMMM dd, yyyy - dddd"
				.Format = DateTimePickerFormat.Custom

				' Show the CheckBox and display the control as an up-down control.
				.ShowCheckBox = True
				.ShowUpDown = True
			End With

			Return dateTimePicker1

		Catch ex As Exception
			MessageBox.Show(ex.Message, "CreateMyDateTimePicker()")
			Return Nothing
		Finally
			' Change Cursor to Normal
			Me.Cursor = Cursors.Arrow
		End Try

	End Function

	Private Sub UpdateDB()


		Dim uX As Integer = Me.TableAdapterManager.UpdateAll(Me.ActionEntryDataSet)

		'MessageBox.Show(uX.ToString & " records updated")

		Dim deletedChildRecords As ActionEntryDataSet.tblDailyProductionsDataTable = _
		 CType(ActionEntryDataSet.tblDailyProductions.GetChanges(Data.DataRowState.Deleted), ActionEntryDataSet.tblDailyProductionsDataTable)

		Dim newChildRecords As ActionEntryDataSet.tblDailyProductionsDataTable = _
		 CType(ActionEntryDataSet.tblDailyProductions.GetChanges(Data.DataRowState.Added), ActionEntryDataSet.tblDailyProductionsDataTable)

		Dim modifiedChildRecords As ActionEntryDataSet.tblDailyProductionsDataTable = _
		 CType(ActionEntryDataSet.tblDailyProductions.GetChanges(Data.DataRowState.Modified), ActionEntryDataSet.tblDailyProductionsDataTable)

		Try
			If deletedChildRecords IsNot Nothing Then
				Me.TblDailyProductionsTableAdapter.Update(deletedChildRecords)
			End If

			If newChildRecords IsNot Nothing Then
				Me.TblDailyProductionsTableAdapter.Update(newChildRecords)
			End If

			If modifiedChildRecords IsNot Nothing Then
				Me.TblDailyProductionsTableAdapter.Update(modifiedChildRecords)
			End If

			Me.ActionEntryDataSet.AcceptChanges()

		Catch ex As Exception
			MessageBox.Show("An error occurred during the update process")
			' Add code to handle error here.

		Finally
			If deletedChildRecords IsNot Nothing Then
				deletedChildRecords.Dispose()
			End If

			If newChildRecords IsNot Nothing Then
				newChildRecords.Dispose()
			End If

			If modifiedChildRecords IsNot Nothing Then
				modifiedChildRecords.Dispose()
			End If


		End Try



	End Sub

	Private Sub UpdateDataSet()

		' Not used

		'Try

		'	If Me.ActionEntryDataSet.HasChanges Then
		'		Me.ActionEntryDataSetBindingSource.EndEdit()
		'		Me.TableAdapterManager.UpdateAll(Me.ActionEntryDataSet)
		'	End If

		'Catch ex As Exception
		'	MessageBox.Show(ex.Message, "UpdateDataset()")

		'End Try


	End Sub

	Private Sub UpdateRoutine()

		'' Fills the QryMyDPforToday TableAdapter
		'LoadUsersDP_ManualEntry()

		'' Update DataSync XML DataFile
		'DataSync()

		'' Load DP(XML DataSync) for Today, if any
		'GetUsersDPforToday()




		' Run Method to group Station #'s together by common BackColor property
		CommonSiteDGVBackColor()

		' Accent Reported DP Items
		ViewSelectColor()

		' Fills the QryMyDPforToday Tableadapter
		LoadUsersDP_ManualEntry()

		' Update DataSync XML DataFile
		DataSync()

		' Load DP for Today, if any
		GetUsersDPforToday()


	End Sub


	Private Sub LoadPrevJobAndPIFilter()

		Try
			If My.Settings.ae_CurrentJob IsNot Nothing Then

				' Filter all other jobs for foreign users (HSC, J&J)
				Select Case My.Settings.ae_UserID
					Case 49 To 51
						Me.QryActiveJobsBindingSource.Filter = "jobNum = '" & My.Settings.ae_CurrentJob & "'"
					Case Else
						Me.QryActiveJobsBindingSource.Filter = Nothing
				End Select


				' Get Index of current Job
				Dim foundIndex As Integer = QryActiveJobsBindingSource.Find("jobNum", My.Settings.ae_CurrentJob)
				If foundIndex > -1 Then
					' Set all objects position
					Me.QryActiveJobsBindingSource.Position = foundIndex
					With Me.drpActiveJobs
						.CurrentItemIndex = foundIndex
						.ScrollItemIntoView(foundIndex, True)
					End With
				Else
					'MessageBox.Show("Job# Not Selected Yet." & vbCrLf & "You must first go to the 'Enter Daily Productions' form to set your current Job Number", "Current Job# Not Selected")
				End If


				' Load Daily Productions
				LoadJobDP()


				' Look for previous days Selected Pay Items
				If My.Settings.ae_PayItemsFilter IsNot Nothing Then
					' Run PayItem BindingSource Filter Method
					' Apply Filter to BindingSource using the built FilterString
					Me.DPBindingSource.Filter = My.Settings.ae_PayItemsFilter
					ReCheckPayItemDGV()
				End If

				CommonSiteDGVBackColor()
				ViewSelectColor()

			End If

		Catch ex As Exception
			MessageBox.Show(ex.Message, "LoadPrevJobAndPIFilter()")
		End Try

	End Sub





#Region " Non Pay Item Controls Display"

	Private Sub LoadPostValues(ByVal piCode As String, ByVal dView As DataView)
		'******************************************************************
		'Purpose: get the sign code to determine what the valid values are
		'Input: Pay Item Code and DataView
		'output: None, just assigns valid values
		'Issues: - type I, II, III removal may need to go to frmAdjQty
		'        - handle when only one post is installed but two posts are in the db
		'        - making combobox read only or only selecting valid values
		'        - me.cmbpost.selectedindex = -1 doesnt work!(with comboboxes)
		'		 - should we break this up or modify, 3# posts dont have 
		'			foundations. 
		'		 - [jk]:  Most of these declarations will be converted to an Application.Settings
		'		   [jk]:  'ActionAdmin' will provide AdminUser the ability to EDIT these complex
		'		 - [jk]:  In-Memory Objects and provide Scalability, etc.	

		' Enable 2nd Post Length ComboBox if Support Qty is Greater Than 1
		' We now must use the ContractQty [cQty, CQtyLabel1] because the 
		' SupportQty is a value recorded with the Sign, therefore a more 
		' complex Query will be need. 
		' Must validate whether the ContractQty will be a consistent and
		' accurate method to Automatically determine Support Qty.
		'******************************************************************
		Try
			' Remove ListBox Items
			Me.lstNPI.Items.Clear()


			' Clear previous ComboBox Items
			Me.cmbPost1.Items.Clear()
			Me.cmbPost2.Items.Clear()

			Me.cmbPost1_Actual.Items.Clear()
			Me.cmbPost2_Actual.Items.Clear()


			' Convert these to App.Settings
			Dim threePoundVals As String() = New String() {"10", "12", "13", "14", "15", "16", "17", "18", "19"} '3# values	
			Dim four6vals As String() = New String() {"14", "16", "18", "20", "24"}		 '4x6 values
			Dim Six8vals As String() = New String() {"16", "18", "20", "22", "24"}		 '6x8 values

			' ContractQty [cQty]
			Dim cQ As Double
			Try
				cQ = CDbl(Me.CQtyLabel1.Text)
			Catch ex As Exception
				cQ = 0
			End Try

			' Function to determine need for 2nd ComboBox
			Dim Is2ndCMBNeeded As Boolean = Need2Posts(cQ, piCode)

			' Row Count of DataTable passed via Argument
			Dim i As Integer = dView.Count

			' Foundations Reported  (True if needed)
			Dim fdn As Boolean = True

			' LeftPostLength Reported  (True if needed)
			Dim lPl As Boolean = True

			' RightPostLength Reported  (True if needed)
			Dim rPl As Boolean = True

			' FirstName/LastName
			Dim fLname As String = Nothing

			' NPI Reported Quantity
			Dim q As Double = 0

			' NPI Description
			Dim d As String = Nothing

			' NPI Date
			Dim eD As Date = Nothing

			' Separator 
			Dim sL As String = "*"

			' Text to add to ListBox
			Dim s1 As String = Nothing
			Dim s2 As String = Nothing
			Dim stringToAdd As String = "<-------Error------->" & Now.ToLongTimeString



			' NPI ID
			Dim x As Integer = 0

			Select Case piCode
				Case "8100156", "8100370", "8100371"	'3 # post
					Me.cmbPost1.Items.AddRange(threePoundVals)
					Me.cmbPost1_Actual.Items.AddRange(threePoundVals)
					If Is2ndCMBNeeded Then
						Me.cmbPost2.Items.AddRange(threePoundVals)
						Me.cmbPost2_Actual.Items.AddRange(threePoundVals)
					End If

				Case "8100165", "8100165fdn", "8100170", "8100170fdn", "8100380", "8100380fdn", "8100381", "8100381fdn"	  '4x6 wood post
					Me.cmbPost1.Items.AddRange(four6vals)
					Me.cmbPost1_Actual.Items.AddRange(four6vals)

					If Is2ndCMBNeeded Then
						Me.cmbPost2.Items.AddRange(four6vals)
						Me.cmbPost2_Actual.Items.AddRange(four6vals)
					End If

				Case "8100166", "8100166fdn", "8100171", "8100171fdn", "8100382", "8100382fdn", "8100383", "8100383fdn"	'6x8 wood post
					Me.cmbPost1.Items.AddRange(Six8vals)
					Me.cmbPost1_Actual.Items.AddRange(Six8vals)
					If Is2ndCMBNeeded Then
						Me.cmbPost2.Items.AddRange(Six8vals)
						Me.cmbPost2_Actual.Items.AddRange(Six8vals)
					End If

				Case Else
					MessageBox.Show(piCode & ", Was sent to the LoadPostValues() Method.  Not intended.  DeBug.")
			End Select


			' NonPayItemsProduction DataGridView Row Count
			If i > 0 Then

				Try

					' Iterate through DataTable Rows
					For Each r As DataRowView In dView

						' ID for specific NonPayitem
						x = CInt(r.Item(2))

						' Name
						fLname = r.Item(9).ToString & " " & r.Item(10).ToString

						' NPI Reported Quantity
						q = CDbl(r.Item(3))

						' NPI Description
						d = r.Item(7).ToString

						' NPI Date
						eD = CDate(r.Item(5))
						If eD = Nothing Then
							eD = #2/22/2022#
						End If


						' Text to add to ListBox
						s1 = q.ToString & " " & r.Item(8).ToString & ", " & d
						s2 = " [" & fLname & " - " & eD.ToShortDateString & "]"
						stringToAdd = s1 & s2


						' Add String to ListBox
						Me.lstNPI.Items.Add(stringToAdd)

						' ID (Primary Key) for Reported NonPayItem  (tblNonPayItems)
						Select Case x

							'  NonPayItemID Listing (tblNonPayItems)
							'  1 - 4x6 wpFdn
							'  2 - 6x8 wpFdn
							'  6 - 4x6 L
							'  7 - 4x6 R
							'  8 - 6x8 L
							'  9 - 6x8 R

							Case 0

								MessageBox.Show("NonPayItemID = 0 " & vbCrLf & "This should never be the case", "LoadPostValues()")

							Case 1, 2

								' WoodPost Foundations (1 = 4x6FDN, 2 = 6x8FDN)
								Me.lblWpFDNQty.Text = q.ToString

								fdn = False

								'Me.btnSubmitWpFDN.Enabled = False
								'Me.lblWpFDNQty.Enabled = False

								Me.btnSubmitPostLengths.Enabled = True
								Me.cmbPost1.Enabled = True
								Me.cmbPost2.Enabled = True
								Me.cmbPost1_Actual.Enabled = True
								Me.cmbPost2_Actual.Enabled = True

								'Me.lblPost1.Enabled = True
								'Me.lblPost2.Enabled = True


							Case 6, 8

								' 4x6 Post Lengths (6 = 4x6L, 7 = 4x6R)
								Me.cmbPost1.Text = q.ToString
								lPl = False

							Case 7, 9

								' 6x8 Post Lengths (6 = 6x8L, 7 = 6x8R)
								Me.cmbPost2.Text = q.ToString
								rPl = False

							Case Else

								' TODO:  Develop logic to deal with 3# Post
								'		 NonPayitems (Post Removal)
								'MessageBox.Show(x.ToString & " is the NonPayItemID not handled in the Select..Case Block" & vbCrLf & _
								'  r.Item(2).ToString & " is the PayItemDescription not handled.")

						End Select

					Next


				Catch ex As Exception
					MessageBox.Show(ex.Message & vbCrLf & "Try..Catch inside Parent Try..Catch", "loadpostvalues")

				End Try

			Else


			End If

			' Reset ComboBox Text
			Me.cmbPost1.ResetText()
			Me.cmbPost2.ResetText()

			Me.cmbPost1_Actual.ResetText()
			Me.cmbPost2_Actual.ResetText()


		Catch ex As Exception
			MessageBox.Show(ex.Message, "LoadPostValues()")
		End Try
	End Sub

	'Function BreakAwayElevations(ByVal pI As String, ByVal i As Integer) As String
	'	'Try
	'	'	Dim numFoundations As Integer = CInt(CQtyLabel1.Text)
	'	'	Dim BreakAwayString As String
	'	'	Dim breakElevL As Double = 0
	'	'	Dim breakElevR As Double = 0

	'	'	nudL.Value = 0
	'	'	nudR.Value = 0

	'	'	'MessageBox.Show(pI)

	'	'	Me.panBreakAway.Visible = True

	'	'	breakElevL = nudL.Value
	'	'	breakElevR = nudR.Value

	'	'	BreakAwayString = breakElevL & "," & breakElevR
	'	'	Return BreakAwayString
	'	'Catch ex As Exception
	'	'	MessageBox.Show("BreakAwayElevations()")
	'	'	Return Nothing
	'	'End Try
	'End Function

	Private Sub SlipBases(ByVal sSize As Double, ByVal pI As String, ByVal i As Integer)
		'*******************************************************************
		'Purpose: make the correct button visible
		'input: sign size which will be number of supports and the pay item id
		' why do we need ssize and pi???
		'output: None
		'issues: reconsider this function and function name
		'		look at method that handles the 2 buttons in the slip base panel
		'********************************************************************
		Try
			Me.panSlipBases.Visible = True
			If i > 0 Then	'if foundation has been reported
				'Me.btnReportSlipBases.Visible = True
				'Me.btnReportSbaseFoundation.Visible = False
			Else			' if foundation has not been reported 
				'Me.btnReportSbaseFoundation.Visible = True
				'Me.btnReportSlipBases.Visible = False
			End If

			'should we make the slip bases button visible jot not enabled so they know its there

		Catch ex As Exception
			MessageBox.Show("SlipBases()")
		End Try
	End Sub

	Private Sub NotVisible()
		''  Need to make cmbboxes and label not visible, may need to show one at a time. 
		''  Just making panel visible/notvisible will show all boxes and labels
		'Me.cmbPost1.Visible = False
		'Me.cmbPost2.Visible = False

		'Me.lblPost1.Visible = False
		'Me.lblPost2.Visible = False
		'Me.lblPostLeft.Visible = False
		'Me.lblPostRight.Visible = False

		'Me.panBreakAway.Visible = False
		'Me.panPosts.Visible = False
		'Me.panSlipBases.Visible = False
		'Me.lblColumns.Visible = False

	End Sub

	Private Sub FindNonPIProductions(ByVal id As Integer)
		'TODO:  Redo this!

		'  Wrong approach!!!
		'  Don't need to fill the TableAdapter each time
		'  Fill the TableAdapter once, then use BindingSourc.Filter Method
		'Return Me.TblNonPIProductionsTableAdapter.Fill(Me.ActionEntryDataSet.tblNonPIProductions, id)

		' ReWrite this to simply run a query, passing the id argument passed to this
		' method.  

		'  Filter the BindingSource, then display in a DGV (in a tab page), or, retain in a DataTable, etc.



	End Sub

	Private Sub ColumnLength(ByRef BreakAwayString As String, ByVal i As Integer)
		'************************************************************************
		'Purpose: Determine column length for the and right then to report
		'		Also for user to reference. 
		'input: The left and right column elevations, which is a string then split
		'output: left and right column length
		'issues:
		'************************************************************************

		Try
			' Change Cursor, Signal to user the application is thinking
			Me.Cursor = Cursors.WaitCursor

			If i > 0 Then		 ' if foundation reported 
				Dim stringArray As String() = Split(BreakAwayString)
				Dim LeftColumnEl As Double = CDbl(stringArray(0))
				Dim RightColumnEl As Double = CDbl(stringArray(1))
				MsgBox("Left Column: " & LeftColumnEl & " Right Column: " & RightColumnEl)
				'do the math for both columns retain and display 
			Else  ' if foundation not reported 
				'lblColumns.Visible = True
			End If




		Catch ex As Exception
			MessageBox.Show(ex.Message, "ColumnLength()")
		Finally
			' Change Cursor to Normal
			Me.Cursor = Cursors.Arrow
		End Try

	End Sub

	Private Sub EnableAllBut(ByVal ctlName As String, ByVal tab As TabControl)
		'For Each c As Control In tab.Controls
		'	If TypeOf c Is Panel Then
		'		If c.Name = ctlName Then
		'			c.Enabled = True
		'		Else
		'			c.Enabled = False
		'		End If
		'	End If
		'Next
	End Sub


	' Method for Suspend/Resume Layout to reduce flickering
	Private Sub StopTheFlicker(ByVal ResumeOrSuspend As Boolean)

		' False = .SuspendLayout
		' True  = .ResumeLayout

		Try
			For Each c As Control In Me.Controls
				If Not ResumeOrSuspend Then
					c.SuspendLayout()
				Else
					c.ResumeLayout()
				End If

			Next
		Catch ex As Exception

		End Try

	End Sub




	Private Sub AddButtons()
		' Suspend the form layout and add two buttons.
		Me.SuspendLayout()
		Dim buttonOK As New Button()
		buttonOK.Location = New Point(10, 10)
		buttonOK.Size = New Size(75, 25)
		buttonOK.Text = "OK"

		Dim buttonCancel As New Button()
		buttonCancel.Location = New Point(90, 10)
		buttonCancel.Size = New Size(75, 25)
		buttonCancel.Text = "Cancel"

		'Me.Controls.AddRange(New Control() {buttonOK, buttonCancel})
		Me.ResumeLayout()
	End Sub

	''' <summary>
	''' Insert Column Breakaway Elevation/Column Length NonPayItems
	''' </summary>
	''' <param name="lElev">Left Elevation</param>
	''' <param name="lCol">Left Column Length</param>
	''' <param name="rElev">Right Elevation</param>
	''' <param name="rCol">Right Column Length</param>
	''' <remarks></remarks>
	Private Sub InsertColumnNPI(ByVal lElev As Double, ByVal lCol As Double, ByVal rElev As Double, ByVal rCol As Double)

		' NonPayItems ID's  (tblNonPayItems)

		' W8x13
		' 14 - Left Elevation
		' 10 - Left Column Length
		' 15 - Right Elevation
		' 11 - Right Column Length

		' W8x18
		' 16 - Left Elevation
		' 12 - Left Column Length
		' 17 - Right Elevation
		' 13 - Right Column Length


		Dim theseNotes As String = Me.SiteNotesRichTextBox.Text.Trim
		If theseNotes Is String.Empty Then
			theseNotes = Nothing
		End If

		Try


			' Call the Insert method of the non pay items table adapter to insert
			' this/these non pay items.
			Select Case Me.dgvDP.CurrentRow.Cells.Item(4).Value.ToString
				Case "8100072", "8100160"  ' W8x13

					' W8x13

					' Left Elevation
					Me.TblNonPIProductionsTableAdapter.Insert(CInt(Me.dgvDP.CurrentRow.Cells.Item(0).Value), _
					  14, lElev, My.Settings.ae_UserID, Now(), _
					  theseNotes)

					' Left Column Length
					Me.TblNonPIProductionsTableAdapter.Insert(CInt(Me.dgvDP.CurrentRow.Cells.Item(0).Value), _
					  10, lCol, My.Settings.ae_UserID, Now(), _
					  theseNotes)

					' Right Elevation
					Me.TblNonPIProductionsTableAdapter.Insert(CInt(Me.dgvDP.CurrentRow.Cells.Item(0).Value), _
					  15, rElev, My.Settings.ae_UserID, Now(), _
					  theseNotes)

					' Right Column Length
					Me.TblNonPIProductionsTableAdapter.Insert(CInt(Me.dgvDP.CurrentRow.Cells.Item(0).Value), _
					  11, rCol, My.Settings.ae_UserID, Now(), _
					  theseNotes)



				Case "8100073", "8100161" ' W8x18

					' W8x18

					' Left Elevation
					Me.TblNonPIProductionsTableAdapter.Insert(CInt(Me.dgvDP.CurrentRow.Cells.Item(0).Value), _
					  16, lElev, My.Settings.ae_UserID, Now(), _
					  theseNotes)

					' Left Column Length
					Me.TblNonPIProductionsTableAdapter.Insert(CInt(Me.dgvDP.CurrentRow.Cells.Item(0).Value), _
					  12, lCol, My.Settings.ae_UserID, Now(), _
					  theseNotes)

					' Right Elevation
					Me.TblNonPIProductionsTableAdapter.Insert(CInt(Me.dgvDP.CurrentRow.Cells.Item(0).Value), _
					  17, rElev, My.Settings.ae_UserID, Now(), _
					  theseNotes)

					' Right Column Length
					Me.TblNonPIProductionsTableAdapter.Insert(CInt(Me.dgvDP.CurrentRow.Cells.Item(0).Value), _
					  13, rCol, My.Settings.ae_UserID, Now(), _
					  theseNotes)


			End Select


			' Refresh TblNonPIProductionsBindingSource
			LoadStationNPI(CInt(Me.dgvDP.CurrentRow.Cells.Item(0).Value))

			MessageBox.Show("Column Elevations reported successfully.", "Column Elevations")


		Catch ex As Exception
			MessageBox.Show("Error adding record." & vbCrLf & ex.Message, "Column Elevations")
		End Try

		
		

	End Sub

	


#End Region




#End Region


#Region " Event Handlers"

	Private Sub frmAE_DP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

		Try

			Me.DateTimePicker1.Value = Now()
			'MessageBox.Show(Now.ToString)

			Me.DateTimePicker1.MinDate = Now.AddDays(-1)
			Me.DateTimePicker1.MaxDate = Today

			' Load the Non Pay Items Table into Data Object (ADO.Net)
			Me.TblNonPayItemsTableAdapter.Fill(Me.ActionEntryDataSet.tblNonPayItems)

			' Load Active Jobs Query into Data Object (ADO.Net) 
			'RemoveHandler drpActiveJobs.CurrentItemIndexChanged, AddressOf drpActiveJobs_CurrentItemIndexChanged
			Me.QryActiveJobsTableAdapter.Fill(Me.ActionEntryDataSet.qryActiveJobs)
			'AddHandler drpActiveJobs.CurrentItemIndexChanged, AddressOf drpActiveJobs_CurrentItemIndexChanged

			Me.TblGuardRailDailyProductionsTableAdapter.Fill(Me.ActionEntryDataSet.tblGuardRailDailyProductions)
			Me.dgvGuardRailProductions.Columns(0).Visible = False


			' Add CheckBox in Job Pay Items DataGridView Header Row
			DGVCheckBoxHeader()

			Me.panPayItemsMain.Visible = False
			Me.panNonPayItemsMain.Visible = False

			'' Method Name says it all
			LoadPrevJobAndPIFilter()

			' Activate the Jobs DataRepeater Control 
			Me.drpActiveJobs.Select()

			'  Temporary fix to load Job Pay Items for HSC and J&J
			'  This method is triggered by the drpActiveJobs.SelectedIndexChanged Event
			'  Which doesn't fire when only one job is in the list.  HSC and J&J can only view 
			'  their respective jobs
			If My.Settings.ae_UserID > 48 Then
				LoadJobPI()
			End If

			'  Temporary fix to hide job 1338 from all users but Admins.
			'  Remove when this job is no longer active.  08.18.2013
			Select Case My.Settings.ae_UserID
				Case 1 To 6

				Case 7 To 48
					'Me.QryActiveJobsBindingSource.Filter = "jobNum <> '1338' AND jobNum <> '1338a' AND jobNum <> '1338b'"
			End Select


		Catch ex As Exception
			MessageBox.Show(ex.Message, "frmAE_DP_Load()")
		End Try

	End Sub

	Private Sub drpActiveJobs_CurrentItemIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles drpActiveJobs.CurrentItemIndexChanged
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
		'	Purpose....:  Load Pay Items for current select Job/Project
		'	Input......:  None
		'	Output.....:  Call LoadJobPI() Method
		'	Issues.....:  -  Need to incorporate Code to Load Job (My.Settings.ae_CurrentJob) and Pay Item's (My.Settings.ae_FilterString)
		'				  -  Where when loading these settings are already applied and the appropriate Data/Controls, etc. is displayed
		'				  -
		'				  -
		'***********************************************************************************************

		Try
			' Change Cursor, Signal to user the application is thinking
			Me.Cursor = Cursors.WaitCursor

			''TODO:  Incorporate Auto Loading of Previous Days' Job and Pay Items from My.Settings
			'If My.Settings.ae_CurrentJob IsNot Nothing Then

			'	' BindingSource.Find Method Returns the number of Items found matching the 
			'	' first Argument.  Obviously there should be only 1 or 0, as the "jobNum" field
			'	' is the Primary Key and will be absolutely Unique.
			'	If Me.QryActiveJobsBindingSource.Find("jobNum", My.Settings.ae_CurrentJob) > 0 Then

			'	End If
			'End If

			If ie = False Then
				LoadJobPI()
				' Hide JobList Panel
				Me.ckbJobList.Checked = False
			Else
				' Reset Initial Entry Variable
				ie = False
				Me.drpActiveJobs.Select()
			End If

		Catch ex As Exception
			MessageBox.Show(ex.Message, "drpActiveJobs_CurrentItemIndexChanged()")
		Finally

			' Change Cursor to Normal
			Me.Cursor = Cursors.Arrow
		End Try


	End Sub

	Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click

		Me.DPBindingSource.MovePrevious()

	End Sub

	Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
		Me.DPBindingSource.MoveNext()
	End Sub

	Private Sub ckbJobList_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbJobList.CheckedChanged

		Try
			'Me.panPayItemsMain.Visible = False
			'Me.panNonPayItemsMain.Visible = False

			Dim cb As CheckBox = TryCast(sender, CheckBox)
			Dim sc As SplitContainer = TryCast(Me.SplitContainerContentMain, SplitContainer)
			If Not cb Is Nothing And cb.Checked Then
				sc.Panel1Collapsed = False
			Else
				sc.Panel1Collapsed = True
			End If
		Catch ex As Exception
			MessageBox.Show(ex.Message & vbCrLf & vbCrLf & ex.InnerException.ToString, "ckbJobList_CheckChanged Event")

		Finally
			'Me.panPayItemsMain.Visible = True
			'Me.panNonPayItemsMain.Visible = True

		End Try

	End Sub

	Private Sub ckbPayItems_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbPayItems.CheckedChanged

		Try
			'Me.panPayItemsMain.Visible = False
			'Me.panNonPayItemsMain.Visible = False

			Dim cb As CheckBox = TryCast(sender, CheckBox)
			Dim sc As SplitContainer = TryCast(Me.SplitContainerJobPIandDP, SplitContainer)
			'MessageBox.Show(sc.Name)
			If Not cb Is Nothing And cb.Checked Then
				sc.Panel1Collapsed = False
				If Me.ckbDailyProductions.Checked Then
					Me.ckbPayItems.Checked = True
				End If
			Else
				sc.Panel1Collapsed = True
			End If

		Catch ex As Exception
			MessageBox.Show(ex.Message & vbCrLf & vbCrLf & ex.InnerException.ToString, "ckbPayitems_CheckChanged Event")
		Finally
			'Me.panPayItemsMain.Visible = True
			'Me.panNonPayItemsMain.Visible = True

		End Try

	End Sub

	Private Sub ckbDailyProductions_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbDailyProductions.CheckedChanged, JobNumLabel1.Click

		Try
			Me.panPayItemsMain.Visible = False
			Me.panNonPayItemsMain.Visible = False

			'Dim cb As CheckBox = TryCast(sender, CheckBox)
			Dim cb As CheckBox = DirectCast(Me.ckbDailyProductions, CheckBox)

			' Check to see if this click event is coming from 
			' the job number label.  If so, we need to mimic the
			' checking/unchecking of the checkbox.
			If TryCast(sender, Label) IsNot Nothing Then
				If cb.Checked Then
					cb.Checked = False
				Else
					cb.Checked = True
				End If
			End If

			If Not cb Is Nothing And cb.Checked Then
				Me.ckbPayItems.Checked = False
				Me.ckbJobList.Checked = False
			Else
				Me.ckbPayItems.Checked = True
				Me.ckbJobList.Checked = True
			End If
		Catch ex As Exception
			MessageBox.Show(ex.Message, "ckbDailyProductions_CheckChanged Event")
		Finally
			Me.panPayItemsMain.Visible = True
			Me.panNonPayItemsMain.Visible = True

		End Try

	End Sub


	Private Sub btnModifyQty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifyQty.Click

		Try
			' Needs better validating.  This is for testing only.

			If Me.CQtyLabel1.Text = Nothing Then
				Me.CQtyLabel1.Text = "0"
			End If

			Dim q As Double = CDbl(Me.CQtyLabel1.Text)
			Dim i As String = Me.dgvDP.CurrentRow.Cells.Item(4).Value.ToString
			Dim d As String = Me.DescriptionLabel1.Text

			If q < 0 Then
				q = 0
			End If

			Dim dlg As New frmAdjustQtyDialog(q, i, d)

			If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
				Me.lblDPQty.Text = dlg.ReturnQty.ToString
			End If

			' Dispose of the Dialog.  Forms using the ShowDialog Method do not automatically Dispose of their 
			' object.
			dlg.Dispose()

		Catch ex As Exception
			MessageBox.Show(ex.Message, "btnModifyQty_Click()", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Hand)
		Finally

		End Try
	End Sub


	' Located Here because it handles a Button.Click Event
	Private Sub MarkSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click

		' ReWrite this  - Poor design to create another object
		dgv = Me.dgvDP

		Try

			'//  Retain original CellStyle to Revert to.
			Dim oCS As New DataGridViewCellStyle(dgv.DefaultCellStyle)

			'//  Get Index at the Current Row
			Dim i As Integer = dgv.CurrentRow.Index

			With dgv.CurrentRow

				'' dpQty
				'If .Cells.Item(8).Value Is DBNull.Value Then
				'	MessageBox.Show("Production Quantity cannot be zero", "Update Productions")
				'	Exit Sub
				'End If

				Me.Validate()
				Me.DPBindingSource.EndEdit()


				If .Cells.Item(8).Value IsNot Nothing Then
					' Set foreman
					.Cells.Item(14).Value = My.Settings.ae_UserID
					' Set entryDate
					.Cells.Item(15).Value = My.Settings.ae_WorkingDate.Date

					Try
						Me.Validate()
						Me.DPBindingSource.EndEdit()
						UpdateDB()

						' Change Row Color to indicate updated record
						.DefaultCellStyle = New DataGridViewCellStyle _
						 With {.Font = New Drawing.Font("Verdana", 9.75!, FontStyle.Bold)}
						.DefaultCellStyle.BackColor = Color.Gray
						.DefaultCellStyle.ForeColor = Color.White

					Catch ex As Exception
						MessageBox.Show(ex.Message & vbCrLf & "Invalid Value Provided", "Data Update Failure")
						Exit Sub
					End Try

				Else

					' Reset DataGridViewRow BackColor and Font/ForeColor Properties
					.DefaultCellStyle = New DataGridViewCellStyle _
					  With {.Font = New Drawing.Font("Verdana", 9.75!, FontStyle.Italic)}
					.DefaultCellStyle.BackColor = oCS.BackColor
					.DefaultCellStyle.ForeColor = oCS.ForeColor

				End If






			End With


			' Run Method to group Station #'s together by common BackColor property
			CommonSiteDGVBackColor()

			' Accent Reported DP Items
			ViewSelectColor()

			' Fills the QryMyDPforToday Tableadapter
			LoadUsersDP_ManualEntry()

			' Update DataSync XML DataFile
			DataSync()

			' Load DP for Today, if any
			GetUsersDPforToday()



		Catch ex As Exception
			MessageBox.Show(ex.Message, "MarkSelected(A)")
		Finally


		End Try



	End Sub

	Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
		Me.DPBindingSource.MoveFirst()

	End Sub

	Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
		Me.DPBindingSource.MoveLast()

	End Sub

	Private Sub lblExitDP_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblExitDP.Click

		ShowHome(My.Settings.ae_UserID)

		Me.Close()

	End Sub

	Private Sub lblFullScreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFullScreen.Click


		Select Case Me.WindowState
			Case FormWindowState.Normal
				Me.lblFullScreen.Text = "2"
				Me.WindowState = FormWindowState.Maximized
				Me.ToolTip1.SetToolTip(Me.lblFullScreen, "Normal")
			Case FormWindowState.Maximized
				Me.lblFullScreen.Text = "1"
				Me.WindowState = FormWindowState.Normal
				Me.ToolTip1.SetToolTip(Me.lblFullScreen, "Full Screen")
		End Select

		Me.Validate()


	End Sub

	Private Sub lblHide_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblHide.Click
		Me.WindowState = FormWindowState.Minimized
	End Sub

	Private Sub ResetDPControls()

		Try

			Me.cmbPost1.Items.Clear()
			Me.cmbPost2.Items.Clear()
			Me.cmbPost1_Actual.Items.Clear()
			Me.cmbPost2_Actual.Items.Clear()

			Me.lblWpFDNQty.Text = Nothing

			'Me.lblLeftPost.Text = Nothing
			'Me.lblRightPost.Text = Nothing

			Me.nudL.Value = Nothing
			Me.nudR.Value = Nothing

			Me.nudSlipBaseFoundation.Value = Nothing

		Catch ex As Exception

		End Try

	End Sub

	Private Sub DPBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DPBindingSource.PositionChanged

		DisplayCounter()



	End Sub

	Private Sub dgvDP_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvDP.SelectionChanged
		'*********************************************************************
		'Purpose: Make the proper buttons, labels, comboboxes to appear
		'Input: Nothing, LoadPostValues handles everything
		'Output: None
		'Issues: None
		'**********************************************************************
		Dim cdpID As Integer ' Cloud:  tblDailyProductions Primary Key
		Dim thisDGV As DataGridView = CType(sender, DataGridView)



		Try

			' Reset Display Controls on dgvDP.SelectionChanged Event
			ResetDPControls()

			If thisDGV.CurrentRow IsNot Nothing Then

				' Get tblDailyProductions Primary Key (ID) for current row
				' Old Way
				'cdpID = CType(thisDGV.CurrentRow.Cells.Item(0).Value, Integer)
				' New Way
				cdpID = UsingNumericTryParseMyWay(thisDGV.CurrentRow.Cells.Item(0).Value)

				' Load all NonPayItem's for current Job
				LoadStationNPI(cdpID)

				' Get current PayItem (code)
				Dim payItem As String = thisDGV.CurrentRow.Cells.Item(4).Value.ToString


				' Determine course of action depending on PayItem Code
				Select Case payItem

					Case "8100156", "8100165", "8100165fdn", "8100166", "8100166fdn", "8100170", "8100170fdn", "8100171", "8100171fdn", "8100370", "8100371", "8100380", "8100381", "8100382", "8100383"	' 3#, 4x6, 6x8, 4x6DE, 6x8DE
						' Send the Current pay item description to the label on the NPI Tab control
						Me.lblCurrentPostType.Text = thisDGV.CurrentRow.Cells.Item(5).Value.ToString

						' TODO:  Need to develop logic in the LoadPostValues() Method to handle 3# Post

						' DataView to send to LoadPostValues() Method
						Dim npiDV As DataView = CType(Me.QryNonPIBindingSource.List, DataView)
						LoadPostValues(payItem, npiDV)

						Me.tabNonPayItems.SelectedTab = tbpWoodSteelPosts

					Case "8100072", "8100073", "8100160", "8100161"	' Columns Foundations
						' Need to determine if the foundations, elevations and post lengths reported
						''If n > 0 Then
						''	NPI() 's have been reported
						''	Me.panBreakAway.Enabled = False
						''Else
						''	No(NPI) 's reported yet
						''	Me.tabNonPayItems.SelectedTab = tbpColumns
						''	Me.panBreakAway.Enabled = True
						''	Me.nudL.Select()
						''End If

						Me.panBreakAway.Enabled = True
						Me.tabNonPayItems.SelectedTab = tbpColumns



					Case "8100054", "810054 - db", "8100126", "8100136", "8100291", "8100311", "8100330", "8107050", "8107001"

						' Perforated Sq. Tube - Slip Bases

						Me.tabNonPayItems.SelectedTab = tbpSlipBases
						Me.panSlipBases.Enabled = True
						Me.nudSlipBaseFoundation.Select()
						Me.lblSlipBaseTitle.Text = "Perf. Sq. Tube NonPayItems"

						'  Not sure what this is for.  jk 02.24.2013
						If Not (Decimal.TryParse(thisDGV.CurrentRow.Cells.Item(9).ToString, Me.nudSlipBaseFoundation.Value)) Then
							Me.nudSlipBaseFoundation.Value = 0
						End If


					Case "8100052", "8100053", "8100120", "8100121"				' Column Breakaways
						' Need to determine if the foundations, elevations and post lengths
						' have been reported
						' This will be a little crazy to develop 
						Me.panBreakAway.Enabled = True
						Me.tabNonPayItems.SelectedTab = tbpColumns


					Case "8100175", "8100176", "8100177", "8100179", "8100180", "8100181", "8100392", "8100393", "8100394", "8100395", "8100398", "8100399", "8100400", "8100401", "8100404", "8100405", "8100406", "8100407"
						' All Sign Types
						Me.tabNonPayItems.SelectedTab = tbpSignDetails


					Case "8070002", "8070043", "8070041", "8070051", "8070080", "8070027", "8070039", "2040035", "4011109"

						Me.tabNonPayItems.SelectedTab = tbpGuardRail


					Case Else

						Me.tabNonPayItems.SelectedTab = tbpCurrentList



				End Select

				' Filter GuardRail Productions on Site (station number)
				Dim siteNum As String = CType(thisDGV.CurrentRow.Cells.Item(3).Value, String)
				Me.TblGuardRailDailyProductionsBindingSource.Filter = "site = '" & siteNum & "'"

				SumGuardRailQty()


				' DailyProduction Quantity
				' New Way
				Dim q As Integer = UsingNumericTryParseMyWay(thisDGV.CurrentRow.Cells.Item(8).Value)

				' entryDate
				Dim d As Date

				' entryDate
				If thisDGV.CurrentRow.Cells.Item(15).Value Is DBNull.Value Then
					d = Now.Date
					Me.lblEntryDate.Text = Nothing
					Me.lblEntryDate.BackColor = Color.Transparent

				Else
					d = CDate(thisDGV.CurrentRow.Cells.Item(15).Value)
					Me.lblEntryDate.Text = "!!! Completed:  " & d.ToShortDateString & "  !!!"
					Me.lblEntryDate.BackColor = Color.Red

				End If

			End If

		Catch ex As Exception
			MessageBox.Show(ex.Message, "dgvDP_SelectionChanged")
		End Try


	End Sub

	Private Sub btnSubmitPostLengths_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmitPostLengths.Click
		'*************************************************************
		'Purpose: Combine the two comboboxes, put amount in label and update database
		'Input: quanities from comboboxes
		'Ouput: postTotal 
		'Issues: 
		'		
		'**************************************************************

		Try

			' Don't insert NonPayItems for Pay Items already reported.
			If Me.lblEntryDate.Text IsNot Nothing Then

				' ComboBoxes for DailyProduction
				Dim c1 As Double = CDbl(Me.cmbPost1.Text)
				Dim c2 As Double
				Dim cT As Double
				Try
					c2 = CDbl(Me.cmbPost2.Text)
				Catch ex As Exception
					c2 = 0
				End Try


				' Labels for NonPayItems
				Dim p1 As Double = CDbl(Me.cmbPost1_Actual.Text)
				Dim p2 As Double
				Dim postTotal As Double
				Try
					p2 = CDbl(Me.cmbPost2_Actual.Text)
				Catch ex As Exception
					p2 = 0
				End Try

				' Total ComboBox Values - dP
				cT = c1 + c2
				Me.lblDPQty.Text = cT.ToString

				' Total Label Values - nPi's
				postTotal = p1 + p2

				Dim theseNotes As String = Me.SiteNotesRichTextBox.Text.Trim
				If theseNotes Is String.Empty Then
					theseNotes = Nothing
				End If

				Dim pI As String = CType(Me.dgvDP.CurrentRow.Cells.Item(4).Value, String)

				' Call the Insert method of the non pay items table adapter to insert
				' this/these non pay items.
				Select Case pI
					Case "8100156", "8100371"
						If p2 > 0 Then
							Me.TblNonPIProductionsTableAdapter.Insert(CInt(Me.dgvDP.CurrentRow.Cells.Item(0).Value), _
							  4, p1, My.Settings.ae_UserID, Now(), _
							  theseNotes)

							Me.TblNonPIProductionsTableAdapter.Insert(CInt(Me.dgvDP.CurrentRow.Cells.Item(0).Value), _
							  5, p2, My.Settings.ae_UserID, Now(), _
							  theseNotes)

						Else
							Me.TblNonPIProductionsTableAdapter.Insert(CInt(Me.dgvDP.CurrentRow.Cells.Item(0).Value), _
							  4, p1, My.Settings.ae_UserID, Now(), _
							  theseNotes)

						End If



					Case "8100165", "8100170", "8100380"

						If p2 > 0 Then
							Me.TblNonPIProductionsTableAdapter.Insert(CInt(Me.dgvDP.CurrentRow.Cells.Item(0).Value), _
							  6, p1, My.Settings.ae_UserID, Now(), _
							  theseNotes)

							Me.TblNonPIProductionsTableAdapter.Insert(CInt(Me.dgvDP.CurrentRow.Cells.Item(0).Value), _
							  7, p2, My.Settings.ae_UserID, Now(), _
							  theseNotes)

						Else
							Me.TblNonPIProductionsTableAdapter.Insert(CInt(Me.dgvDP.CurrentRow.Cells.Item(0).Value), _
							  6, p1, My.Settings.ae_UserID, Now(), _
							  theseNotes)

						End If


					Case "8100166", "8100171", "8100382"

						If p2 > 0 Then
							Me.TblNonPIProductionsTableAdapter.Insert(CInt(Me.dgvDP.CurrentRow.Cells.Item(0).Value), _
							  8, p1, My.Settings.ae_UserID, Now(), _
							  theseNotes)

							Me.TblNonPIProductionsTableAdapter.Insert(CInt(Me.dgvDP.CurrentRow.Cells.Item(0).Value), _
							  9, p2, My.Settings.ae_UserID, Now(), _
							  theseNotes)

						Else
							Me.TblNonPIProductionsTableAdapter.Insert(CInt(Me.dgvDP.CurrentRow.Cells.Item(0).Value), _
							  8, p1, My.Settings.ae_UserID, Now(), _
							  theseNotes)

						End If

					Case Else

						MessageBox.Show(pI)

						Exit Sub


				End Select

				' Automaticlly update DP Record by calling the Click Method
				' of btnSelect (MarkSelected() Method)
				MarkSelected(Nothing, Nothing)


				' Refresh TblNonPIProductionsBindingSource
				LoadStationNPI(CInt(Me.dgvDP.CurrentRow.Cells.Item(0).Value))

				' DataView to send to LoadPostValues() Method
				Dim npiDV As DataView = CType(Me.QryNonPIBindingSource.List, DataView)
				LoadPostValues(Me.dgvDP.CurrentRow.Cells.Item(4).Value.ToString, npiDV)



			Else
				MessageBox.Show("Post lengths have already been reported for the given payitem.", "Submit Post Lengths")
			End If

		Catch ex As Exception
			MessageBox.Show(ex.Message, "btnSubmitPostLengths_Click()")

		End Try


	End Sub

	Private Sub btnViewSelected_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewSelected.Click


		LoadJobDP()
		FilterTheDP_BS()
		ViewSelectColor()



		'*************************************************************************************************
		' This used here temporarily to test the DataTable.WriteXML Method
		' Convert this to it's own method/function

		'Dim filePath As String = "c:/ActionEntry/"
		'Dim fileName As String = My.Settings.ae_CurrentJob & "_" & My.Settings.ae_DisplayName & "_Test.xml"


		'Dim dt As DataTable = CType(DPBindingSource.List, DataView).ToTable

		'Try

		'	dt.WriteXml(filePath & fileName)

		'Catch ex As Exception
		'	MessageBox.Show(ex.Message, "dt.WriteXML Method")
		'End Try
		'*************************************************************************************************


	End Sub

	' Need to Extend the SignViewer Component to include other PayItems
	' Will need images of each one as well, obviously
	Private Sub SignCodeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignCodeTextBox.TextChanged
		'******************************************************************
		'Purpose: to show image of sign to be installed
		'Input: None
		'Output: image of sign
		'Issues: When signcodetext does not change the sign does not change.  -----FIXED 05.18.11 JK (See commented code in exception)
		'*******************************************************************

		Dim viewImage As String

		Try
			StopTheFlicker(False)

			'Me.picImagePreview.Image = Nothing
			viewImage = My.Settings.ae_ImagePath & Me.SignCodeTextBox.Text & ".jpg"
			Me.picImagePreview.Load(viewImage)
		Catch ex As Exception
			'Me.picImagePreview.Load("none.jpg")
			Me.picImagePreview.Load(My.Settings.ae_ImagePath & "none.jpg")
		Finally
			StopTheFlicker(True)
		End Try
	End Sub

	Private Sub ckb_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ckb.CheckedChanged
		'******************************************************************
		'Purpose: To Select All or De-Select All in the Job Pay Items DataGridView
		'Input: None
		'Output: Toggle CheckBoxes in each row of the DataGridView
		'Issues: Not working... debugging...
		'*******************************************************************

		Try
			Me.dgvJobPayItems.SuspendLayout()

			' Iterate DataGridView to either Select or De-Select each CheckBox
			For j As Integer = 0 To Me.dgvJobPayItems.RowCount - 1
				' Set the CheckBox of the current row to the value of the
				' CheckBox in the Header Row.
				Me.dgvJobPayItems(0, j).Value = Me.ckb.Checked
			Next

			' Look into exactly why this Method is called
			Me.dgvJobPayItems.EndEdit()
		Catch ex As Exception

		Finally
			Me.dgvJobPayItems.ResumeLayout()


		End Try
	End Sub

	Private Sub dgvJobPayItems_ColumnWidthChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewColumnEventArgs) Handles dgvJobPayItems.ColumnWidthChanged

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
		'	Purpose....:  Change width of CheckBox Header to match width of column
		'	Input......:  None
		'	Output.....:  None
		'	Issues.....:  -  None
		'				  -
		'				  -
		'				  -
		'***********************************************************************************************

		Try
			Me.dgvJobPayItems.SuspendLayout()

			' Change Cursor, Signal to user the application is thinking
			Me.Cursor = Cursors.WaitCursor

			' Cast sender Object to DataGridView Object
			Dim d As DataGridView = TryCast(sender, DataGridView)

			' Check for Casting failure
			If Not d Is Nothing Then
				' Set Header CheckBox.Width to Column.Width
				ckb.Width = d.Columns.Item(0).Width
			Else
				MessageBox.Show("Cannot convert sender object " & vbCrLf _
				 & " to DataGridView.", "dgvJobPayItems_ColumnWidthChanged()")
			End If


		Catch ex As Exception
			MessageBox.Show(ex.Message, "dgvJobPayItems_ColumnWidthChanged()")
		Finally
			Me.dgvJobPayItems.ResumeLayout()

			' Change Cursor to Normal
			Me.Cursor = Cursors.Arrow
		End Try

	End Sub

	Private Sub ckbCompletedItems_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbCompletedItems.CheckedChanged
		Try
			Me.dgvDP.SuspendLayout()

			Dim cb As CheckBox = TryCast(sender, CheckBox)
			If Not cb Is Nothing And cb.Checked Then
				Me.DPBindingSource.Filter = "dpQty Is Null"

				' Alternate Row.BackColor Grouping By Station Number.
				CommonSiteDGVBackColor()

			Else
				Me.DPBindingSource.Filter = Nothing
				LoadPrevJobAndPIFilter()

			End If

			' Recalculate dp items count
			DisplayCounter()

		Catch ex As Exception
			MessageBox.Show(ex.Message, "ckbCompletedItems_CheckChanged Event")

		Finally
			Me.dgvDP.ResumeLayout()

		End Try
	End Sub

	Private Sub btnManualEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManualEntry.Click

		Dim MeWzd As New frmME_Wizard(My.Settings.ae_CurrentJob, Me.LocationLabel1.Text)
		MeWzd.ShowDialog()

		If MeWzd.DialogResult = Windows.Forms.DialogResult.OK Then
			Try
				Dim x As Integer = Me.TblDailyProductionsTableAdapter.Insert(MeWzd.JobNumber, _
				   MeWzd.StationNumber, _
				   0, MeWzd.PayItemID, _
				   MeWzd.EnteredQty, _
				   0, _
				   Nothing, _
				   Nothing, _
				   Nothing, _
				   MeWzd.StationNotes, _
				   My.Settings.ae_UserID, _
				   My.Settings.ae_WorkingDate.Date, _
				   Nothing)


				If x > 0 Then

					' Load All Productions for Current Job
					LoadJobDP()

					' Fills the QryMyDPforToday Tableadapter
					LoadUsersDP_ManualEntry()

					' Filter BindingSource based on Select PayItems
					FilterTheDP_BS()

					' Poorly named, this changes backColor and FontStyle
					' for items previously reported
					ViewSelectColor()

					' Write XML based upon instantiated DataTable
					DataSync()

					' Load XML into DataSet
					GetUsersDPforToday()

					MessageBox.Show("Item Entered Successfully!")

				Else
					MessageBox.Show("Error.  Item not entered")
				End If

			Catch ex As Exception
				MessageBox.Show(ex.Message, "btnManualEntry_Click")
			End Try

		Else
			MessageBox.Show("No insert, come back one year!!! btnManualEntry")
		End If

		' Use this code to create method to get data back from dialog form, including the button (dialog result) clicked
		' to react accordingly.

		'Dim dlg As New frmAdjustQtyDialog(CDbl(Me.CQtyLabel1.Text), Me.dgvDP.CurrentRow.Cells.Item(4).Value.ToString)
		'If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
		'	Me.CQtyLabel1.Text = dlg.ReturnQty.ToString
		'End If


	End Sub

	Private Sub btnReportElevations_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReportElevations.Click
		'*******************************************************************
		'Purpose: Compute Column Lengths
		'Input: LeftElevation, RightElevation
		'Output: ColumnLeft, ColumnRight
		'Issues: Having to make sure the column lengths followed MDOT Rules
		'MDOT Rules: (6.1.2011) for highway signs
		'   From Edge of Metal to sign bottom - 84" min
		'   From left foundation to breakaway - 84" min
		'   From right foundation to sign bottom - 48" min
		'   Breakaway takes 4" inches so columns can be 4" shorter
		'******************************************************************
		Try
			Dim LeftElevation As Double = CDbl(nudL.Value)
			Dim RightElevation As Double = CDbl(nudR.Value)
			Dim ColumnLeft As Double
			Dim ColumnRight As Double
			Dim SignHeightMin As Double = My.Settings.ae_signHeightMin
			Dim ColumnLeftMin As Double = My.Settings.ae_ColumnLeftMin
			Dim ColumnRightMin As Double = My.Settings.ae_ColumnRightMin
			Dim colNotes As String


			If LeftElevation >= 0 And RightElevation >= 0 Then 'Flat ground or downward slope
				ColumnLeft = SignHeightMin + LeftElevation
				ColumnRight = SignHeightMin + RightElevation + LeftElevation
			ElseIf LeftElevation < 0 And RightElevation < 0 Then 'Upward Slope
				ColumnLeft = SignHeightMin + LeftElevation
				ColumnRight = ColumnLeft - LeftElevation
				If ColumnRight > ColumnRightMin Then
					Dim L As Double = ColumnRightMin - ColumnRight
					ColumnRight = ColumnRight + L
					ColumnLeft = ColumnRight - RightElevation
				End If
				If ColumnLeft < ColumnLeftMin Then
					Dim L As Double = ColumnLeftMin - ColumnLeft
					ColumnLeft = ColumnLeft + L
					ColumnRight = ColumnRight + L
				End If

				' Notes reflecting calculations to add to 'SiteNotes' field
				colNotes = "(Left:  " & LeftElevation.ToString & ", " & ColumnLeft.ToString & ")(Right:  " & RightElevation.ToString & ", " & ColumnRight.ToString & ")"

				Me.SiteNotesRichTextBox.Text += colNotes

				InsertColumnNPI(LeftElevation, ColumnLeft, RightElevation, ColumnRight)


				Exit Sub


			ElseIf LeftElevation > RightElevation Then 'Ditch with left post in lower point
				ColumnLeft = SignHeightMin + LeftElevation
				ColumnRight = LeftElevation + RightElevation + SignHeightMin
			ElseIf LeftElevation < RightElevation Then 'Hill/Ditch with left post in higher point 
				ColumnLeft = SignHeightMin + LeftElevation
				ColumnRight = ColumnLeft + RightElevation
				If ColumnLeft < ColumnLeftMin Then
					Dim L As Double = ColumnLeftMin - ColumnLeft
					ColumnLeft = ColumnLeft + L
					ColumnRight = ColumnRight + L
				End If
			End If

			' Notes reflecting calculations to add to 'SiteNotes' field
			colNotes = "(Left:  " & LeftElevation.ToString & ", " & ColumnLeft.ToString & ")(Right:  " & RightElevation.ToString & ", " & ColumnRight.ToString & ")"

			Me.SiteNotesRichTextBox.Text += colNotes

			InsertColumnNPI(LeftElevation, ColumnLeft, RightElevation, ColumnRight)

			' Auto Qty 
			btnQtyValid_Click(Nothing, Nothing)

			' Automaticlly update DP Record by calling the Click Method
			' of btnSelect (MarkSelected() Method)
			MarkSelected(Nothing, Nothing)



		Catch ex As Exception
			MessageBox.Show("ComputeColumnLengths()")
		End Try
	End Sub

	Private Sub cmbPost1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPost1.SelectedIndexChanged

		Me.cmbPost1_Actual.Text = Me.cmbPost1.Text
		'Me.lblLeftPost.Text = Me.cmbPost1.Text
		'Me.cmbPost1.Text = Me.AE_DefaultComboBoxText

	End Sub

	Private Sub cmbPost2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPost2.SelectedIndexChanged

		Me.cmbPost2_Actual.Text = Me.cmbPost2.Text
		'Me.lblRightPost.Text = Me.cmbPost2.Text
		'Me.cmbPost2.Text = Me.AE_DefaultComboBoxText

	End Sub

	Private Sub btnQtyValid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQtyValid.Click

		Try
			If Not (Me.dgvDP.CurrentRow.Cells.Item(8).Value Is DBNull.Value) Then

				MessageBox.Show("This Item has already been reported")
				'Me.btnQtyValid.Enabled = False
				'Me.btnSelect.Enabled = False

			Else
				If Me.CQtyLabel1.Text = Nothing Then
					MessageBox.Show("You must adjust the quanity first. [+/-]", "Adjust Quanity!")
				Else
					' Transfer Plan/Contract Qty to Production Qty
					Me.lblDPQty.Text = Me.CQtyLabel1.Text
					'Me.btnQtyValid.ForeColor = Color.Red
				End If


			End If
		Catch ex As Exception
			MessageBox.Show(ex.Message, "btnQtyValid_Click()")
		End Try

	End Sub

	Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
		Try
			'Me.panPayItemsMain.SuspendLayout()
			'For Each c As Control In Me.panPayItemsMain.Controls
			'	c.SuspendLayout()
			'Next

			' Collapses/expands the notes RichTextBox
			Dim originalX As Integer = 6 ' This value remains constant
			Dim originalY As Integer = 181 ' This is the Collapsed LinkLabel Location.Y
			Dim expandedY As Integer = 229 ' This is the Expanded LinkLabel Location.Y 
			Dim origHeight As Integer = 60 ' This is the Collapsed .Height (Size) of the RichTextBox
			Dim expandedHeight As Integer = 108	' This is the Expanded .Height (Size) of the RichTextBox
			Dim panelCollapsedHeight As Integer = 200	' This is the Collapsed .Height (Size) of the Panel
			Dim panelExpandedHeight As Integer = 249 ' This is the Expanded .Height (Size) of the Panel
			Dim NavPanelCollapsedHeight As Integer = 186 ' This is the Collapsed NavPanel .Height (Size)
			Dim NavPanelExpandedHeight As Integer = 235	' This is the Expanded NavPanel .Height (Size)
			Dim NavPanelCollapsedY As Integer = 255	' This is the Expanded NavPanel Location.Y
			Dim NavPanelExpandedY As Integer = 209

			Select Case Me.pnlItemDetails.Height

				Case 1 To 222	' Collapsed .Height (Size)  Note:  Adjust values as needed.

					With Me.pnlNavigationSubmit
						.Location = New Point(3, NavPanelCollapsedY)
						.Height = NavPanelCollapsedHeight
					End With

					With Me.LinkLabel1
						.Location = New Point(originalX, expandedY)
						.Text = "[ - ] Collapse"
					End With

					With Me.lblEntryDate
						.Location = New Point(originalX, expandedY)
						.BringToFront()
					End With

					Me.pnlItemDetails.Height = panelExpandedHeight
					Me.SiteNotesRichTextBox.Height = expandedHeight


				Case 223 To 250	' Expanded .Height (Size)  Note:  Adjust values as needed.

					With Me.pnlNavigationSubmit
						.Location = New Point(3, NavPanelExpandedY)
						.Height = NavPanelCollapsedHeight
					End With

					With Me.LinkLabel1
						.Location = New Point(originalX, originalY)
						.Text = "[+] Expand"
					End With

					With Me.lblEntryDate
						.Location = New Point(originalX, originalY)
						.BringToFront()
					End With

					Me.pnlItemDetails.Height = panelCollapsedHeight
					Me.SiteNotesRichTextBox.Height = origHeight

				Case Else
					MessageBox.Show("Panel Height Value is outside Min/Max Values " & vbCrLf & _
					 "Height Collapsed Range:  200 To 222" & vbCrLf & _
					 "Expaded Height Range:  223 To 250", _
					 "Panel Height Value Invalid")
			End Select

		Catch ex As Exception

		End Try
	End Sub

	Private Sub AdjustPostLength(ByVal sender As System.Object, ByVal e As System.EventArgs) ' Handles lblLeftPost.Click, lblRightPost.Click

		''  Completely Re-Write This!!!  
		''  This is Crap!!!



		'Try
		'	Dim lbl As Label = TryCast(sender, Label)
		'	Dim post1 As Double = 0
		'	Dim post2 As Double = 0

		'	If Not lblLeftPost.Text = Nothing Then
		'		post1 = CDbl(Me.lblLeftPost.Text)
		'	End If

		'	If Not lblRightPost.Text = Nothing Then
		'		post2 = CDbl(Me.lblRightPost.Text)
		'	End If


		'	' Declare which post/value is calling the method
		'	Dim argToSend As Double

		'	Dim d As String = Me.lblCurrentPostType.Text
		'	Dim x As String = Me.Label2.Text

		'	' Set value based on control name
		'	Select Case lbl.Name
		'		Case "lblLeftPost"
		'			argToSend = post1
		'		Case "lblRightPost"
		'			argToSend = post2
		'	End Select

		'	Dim dlg As New frmAdjustQtyDialog(argToSend, x, d)

		'	If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
		'		Select Case lbl.Name
		'			Case "lblLeftPost"
		'				Me.lblLeftPost.Text = dlg.ReturnQty.ToString
		'			Case "lblRightPost"
		'				Me.lblRightPost.Text = dlg.ReturnQty.ToString
		'		End Select
		'	End If

		'Catch ex As Exception
		'	MessageBox.Show(ex.Message, "AdjustPostLength", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Hand)
		'End Try

	End Sub

	Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

		Me.lblDateAndTime.Text = DateTimePicker1.Value.ToString("D")
		GetUsersDPforToday()


	End Sub

	Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) _
	  Handles BackgroundWorker1.DoWork



	End Sub

	Private Sub btnSubmitWpFDN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmitWpFDN.Click, lblWpFDNQty.Click

		Dim defaultValue As Double = 0
		Dim thisID As Integer = 0
		Dim theseNotes As String = Me.SiteNotesRichTextBox.Text.Trim
		
		Dim thisCode As String = Me.dgvDP.CurrentRow.Cells.Item(4).Value.ToString & "fdn"


		If theseNotes Is String.Empty Then
			theseNotes = Nothing
		End If



		' Contract Qty
		Dim cQ As Double = CDbl(Me.dgvDP.CurrentRow.Cells.Item(9).Value)

		Select Case thisCode

			Case "8100165fdn", "8100170fdn", "8100380fdn", "8100381fdn"

				If cQ > FOURSIXMAX Then
					defaultValue = 2
				Else
					defaultValue = 1
				End If

			Case "8100166fdn", "8100171fdn", "8100382fdn", "8100383fdn"

				If cQ > SIXEIGHTMAX Then
					defaultValue = 2
				Else
					defaultValue = 1
				End If

		End Select

		

		Dim dlg As New frmAdjustQtyDialog(defaultValue, thisCode, "Wood Post Foundation(s)")

		Try
			If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then

				Me.lblWpFDNQty.Text = dlg.ReturnQty.ToString()

				Select Case dlg.PayItemCode
					Case "8100165fdn", "8100170fdn", "8100380fdn", "8100381fdn"
						thisID = 1
					Case "8100166fdn", "8100171fdn", "8100382fdn", "8100383fdn"
						thisID = 2
					Case Else
						thisID = 0
				End Select

				If thisID > 0 Then

					Me.TblNonPIProductionsTableAdapter.Insert(CInt(Me.dgvDP.CurrentRow.Cells.Item(0).Value), _
					  thisID, dlg.ReturnQty, My.Settings.ae_UserID, Now(), _
					  theseNotes)

					' Refresh TblNonPIProductionsBindingSource
					LoadStationNPI(CInt(Me.dgvDP.CurrentRow.Cells.Item(0).Value))

					' Update DataSync XML DataFile
					DataSync()

					' DataView to send to LoadPostValues() Method
					Dim npiDV As DataView = CType(Me.QryNonPIBindingSource.List, DataView)
					LoadPostValues(dlg.PayItemCode, npiDV)

					'Else
					'	MessageBox.Show(thisID.ToString & ":  thisID is NOT greater than Zero")

				End If

			End If

		Catch ex As Exception
			MessageBox.Show(ex.Message, "btnsubmitWpFDN_Click()")
		End Try
	End Sub

	Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked


		' Reset Values in case of error, etc.
		Try
			Dim result As DialogResult = MessageBox.Show("Click OK to Reset this Item", "Edit Reported Values")

			Select Case result
				Case Windows.Forms.DialogResult.OK

					Dim dRow As DataRowView = CType(Me.DPBindingSource.Current, DataRowView)
					dRow.Item(8) = DBNull.Value

					Try
						dRow.Item(14) = DBNull.Value
						'MessageBox.Show(dRow.Item(14).ToString, "foreman")
					Catch ex As Exception
						MessageBox.Show(ex.Message)
					End Try

					Try
						dRow.Item(15) = DBNull.Value
						'MessageBox.Show(dRow.Item(15).ToString, "entryDate")
					Catch ex As Exception
						MessageBox.Show("Cannot Reset at this time." & vbCrLf & vbCrLf & ex.Message, "Error - Not Reset!")
					End Try

					Me.DPBindingSource.EndEdit()
					Me.TblDailyProductionsBindingSource.EndEdit()
					UpdateDB()
					UpdateRoutine()

				Case Windows.Forms.DialogResult.Cancel

					' Do nothing

			End Select

		Catch ex As Exception
			MessageBox.Show(ex.Message, "LinkLabel2_LinkClicked()")

		End Try


	End Sub

	Private Sub btnViewProduction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewProduction.Click

		Dim rpt As New Form2
		rpt.MdiParent = AE_mdiMain
		rpt.Show()


	End Sub

	Private Sub txtSearchCriteria_ClickOrEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchCriteria.Enter, txtSearchCriteria.Click
		Me.txtSearchCriteria.SelectAll()
	End Sub

	Private Sub btnStationSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStationSearch.Click

		Dim s As String = Me.txtSearchCriteria.Text
		Try
			If s = String.Empty Then
				Me.DPBindingSource.Filter = Nothing
				LoadPrevJobAndPIFilter()
			Else
				Me.DPBindingSource.Filter = "Station LIKE '*" & s & "*'"
				CommonSiteDGVBackColor()
				ViewSelectColor()
			End If

		Catch ex As Exception
			Me.DPBindingSource.Filter = Nothing
		End Try

	End Sub


	Private Sub txtSearchCriteria_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchCriteria.TextChanged

		If Me.txtSearchCriteria.Text = String.Empty Then
			Me.DPBindingSource.Filter = Nothing
			LoadPrevJobAndPIFilter()

		End If

	End Sub

	''' <summary>
	''' Disable the select button (check mark) when tab for posts is displayed. 
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks></remarks>
	Private Sub tabNonPayItems_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabNonPayItems.SelectedIndexChanged
		If Me.tabNonPayItems.SelectedTab Is Me.tbpWoodSteelPosts Then
			Me.btnSelect.Enabled = False
			Me.btnQtyValid.Enabled = False
			Me.btnModifyQty.Enabled = False
		Else
			Me.btnSelect.Enabled = True
			Me.btnQtyValid.Enabled = True
			Me.btnModifyQty.Enabled = True
		End If
	End Sub


	Private Sub btnAddGrRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddGrRun.Click

		Try

			Dim q As Double
			Dim sta As String = CType(Me.dgvDP.CurrentRow.Cells.Item(3).Value, String)
			Dim notes As String = Me.txtRunNotes.Text
			Dim run As String = Me.txtRunID.Text

			If IsNumeric(Me.txtRunQty.Text) Then
				q = CDbl(Me.txtRunQty.Text)
			Else
				MessageBox.Show(q.ToString)
				Exit Sub

			End If


			Dim x As Integer = Me.TblGuardRailDailyProductionsTableAdapter.Insert(My.Settings.ae_CurrentJob, sta, run, q, notes, My.Settings.ae_WorkingDate, My.Settings.ae_UserID)

			If x > 0 Then MessageBox.Show(x.ToString & " Record(s) added.", "Add GR Run")

			Me.TblGuardRailDailyProductionsTableAdapter.Fill(Me.ActionEntryDataSet.tblGuardRailDailyProductions)

			UpdateRoutine()


		Catch ex As Exception
			MessageBox.Show(ex.Message, "btnAddGrRun_Click()")

		End Try


	End Sub

	Private Sub btnGrSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrSave.Click


		Try
			Me.dgvGuardRailProductions.EndEdit()
			Me.TblGuardRailDailyProductionsBindingSource.EndEdit()
			UpdateDB()

			UpdateRoutine()



		Catch ex As Exception

		End Try
	End Sub

	Private Sub SumGuardRailQty()

		Try
			Dim x As Double = 0
			Dim s As String

			For Each row As DataGridViewRow In Me.dgvGuardRailProductions.Rows
				x += CDbl(row.Cells.Item(4).Value)
			Next

			s = x.ToString & " feet installed to date."

			Me.lblGuardRailRunTotal.Text = s

		Catch ex As Exception
			MessageBox.Show(ex.Message)

		End Try


	End Sub




#End Region











#Region " Misc - Not Used"

	Public Sub test()
		'this formats all cells in column 0 excluding the newrow
		'If e.ColumnIndex = 0 AndAlso e.RowIndex <> QryDP1DataGridView.NewRowIndex Then
		'	'e.Value = CDec(e.Value).ToString("f2")

		'	e.FormattingApplied = True
		'End If

		'Dim BoldRow As New DataGridViewCellStyle With {.Font = New System.Drawing.Font("Verdana", 8.0!, FontStyle.Bold)}
		'Me.QryDPDataGridView.Rows(rowindex).DefaultCellStyle = BoldRow



		'***********************************************************************************************
		'	\\Vitals:
		'***********************************************************************************************
		'****************All Code, Logic, Concepts And DBMS Developed For And Owned By:****************'
		'	Action Traffic Maintenance, Inc.
		'	Michigan Highway Signs, Inc.
		'	Jeff King......:  Lead Software Engineer/DBMS Manager
		'	Luke McClain...:  Software Developer/Hardware Technician
		'	Michael Peake..:  Systems Consultant/End User-Administrative
		'	Paul Roth......:  Systems Consultant/End User-Administrative
		'***********************************************************************************************
		'	\\Keys:
		'***********************************************************************************************
		'	Purpose....:  Type Here
		'	Input......:  Type Here
		'	Output.....:  Type Here
		'	Issues.....:  -Type Here
		'				  -Type Here
		'				  -Type Here
		'				  -Type Here
		'***********************************************************************************************













		'Dim Pt As New Point()

		'Pt.X = Rect.Location.X + (Rect.Width - HeaderCheckBox.Width) \ 2 + 1
		'Pt.Y = Rect.Location.Y + (Rect.Height - HeaderCheckBox.Height) \ 2 + 1

















	End Sub


	Private Sub StuffThatDontWork()



		'....  This Coding Concept cannot be used to handle this event
		'....  The DrawItem Event Fires EACH TIME the DataRepeaterItem 
		'....  Scrolls into view.  Must look for a more suitable event
		'....  To handle.

		''Try
		''	If prevSite = Nothing Then prevSite = CType(Me.drpJobDP.DataSource, DataTable).Rows.Item(0).Item("site").ToString

		''	' Alternate the back color.
		''	If String.Compare(prevSite, e.DataRepeaterItem.Controls("lblSite").ToString) > 0 Then
		''		' String.Compare Function Returns 1 (True)
		''	Else
		''		' String.Compare Function Returns 0 (False)
		''		Select Case e.DataRepeaterItem.BackColor
		''			Case Color.AliceBlue
		''				e.DataRepeaterItem.BackColor = Color.Blue
		''				MessageBox.Show(e.DataRepeaterItem.BackColor.ToString, "Orig. Color:  AliceBlue")
		''			Case Color.Blue
		''				e.DataRepeaterItem.BackColor = Color.AliceBlue
		''				MessageBox.Show(e.DataRepeaterItem.BackColor.ToString, "Orig. Color:  Blue")
		''		End Select
		''	End If
		''	prevSite = e.DataRepeaterItem.Controls(lblSite.Text).ToString
		''Catch ex As Exception
		''	AE_mdiMain.ToolStripStatusLabel.Text = "Ex Msg drpJobDP_DrawItem():  " & ex.Message
		''End Try



		''  This would be great if this was the current DataRepeaterItem's CheckBox.CheckChanged Event.
		''  In its current state this would not fire because the CheckBox is not part of the BindinSource
		''  When initialized, it will never be checked, unless its default .Checked Property is set to True.
		''  Of course if used in another Event, we cannot refer to same EventArgs.
		'Try
		'	Dim c As Decimal
		'	Dim cPrev As Decimal
		'	Dim nud As NumericUpDown
		'	If DirectCast(e.DataRepeaterItem.Controls("ckbEdit"), CheckBox).Checked Then
		'		cPrev = CDec(DirectCast(e.DataRepeaterItem.Controls("nudPQty"), NumericUpDown).Value)
		'		c = CDec(e.DataRepeaterItem.Controls("lblCQty").Text)
		'		nud = DirectCast(e.DataRepeaterItem.Controls("nudPQty"), NumericUpDown)
		'		nud.Value = c
		'	End If
		'Catch ex As Exception
		'	MessageBox.Show(ex.Message)
		'End Try





		'Typically, check box cell values are intended either for storage, like any other data, or for performing bulk operations.

		'If you want to respond immediately when users click a check box cell, you can handle the DataGridView.CellContentClick event, 
		'but this event occurs before the cell value is updated. If you need the new value at the time of the click, one option is to 
		'calculate what the expected value will be based on the current value. 

		'Another approach is to commit the change immediately, and handle the DataGridView.CellValueChanged event to respond to it. 

		'To commit the change when the cell is clicked, you must handle the DataGridView.CurrentCellDirtyStateChanged event. 
		'In the handler, if the current cell is a check box cell, call the DataGridView.CommitEdit method and pass in the Commit value.




	End Sub


	Public Class bRows
		'Private BoldedRows As New List(Of DataGridViewRow)

		'Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
		'	Me.qry.Rows(e.RowIndex).DefaultCellStyle = New DataGridViewCellStyle With {.Font = New Drawing.Font("Verdana", 8.0!, FontStyle.Bold)}
		'	Me.BoldedRows.Add(Me.DataGridView1.Rows(e.RowIndex))
		'End Sub

		'Public Sub ResetBoldedRows()
		'	For Each BoldRow As DataGridViewRow In Me.BoldedRows
		'		Me.DataGridView1.Rows(Me.DataGridView1.Rows.IndexOf(BoldRow)).DefaultCellStyle = Me.DataGridView1.RowsDefaultCellStyle
		'	Next
		'	Me.BoldedRows.Clear()
		'End Sub

		'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
		'	ResetBoldedRows()
		'End Subf
	End Class











#End Region





	
	
End Class


