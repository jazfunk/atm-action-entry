Option Strict On
Option Explicit On

Imports System.IO
Imports System.Xml.Serialization
Imports System.Data.OleDb
Imports AE_Ground.clsAE_Utilities




Public Class frmExposureDeclaration

	Public Sub New()

		' This call is required by the Windows Form Designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

	End Sub


	Public Sub New(ByVal crewList As BindingSource, ByVal jobNum As String, ByVal declDate As Date)

		' This call is required by the Windows Form Designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

		' Set Properties
		Me.JobNumber = jobNum
		Me.ExposureDate = declDate

		' Set CheckedListBoxes DataSource
		With Me.chklstCrew_SE
			.DataSource = crewList
			.DisplayMember = "displayName"
		End With

		With Me.chklstCrew_AM
			.DataSource = crewList
			.DisplayMember = "displayName"
		End With

		Me.ResponseDeclared = False



	End Sub



#Region " Properties"


	''' <summary>
	''' Date of Exposure
	''' </summary>
	''' <remarks></remarks>
	Private _exposureDate As Date
	Public Property ExposureDate() As Date
		Get
			Return _exposureDate
		End Get
		Set(ByVal value As Date)
			_exposureDate = value
		End Set
	End Property

	''' <summary>
	''' ATM Job Number
	''' </summary>
	''' <remarks></remarks>
	Private _jobNum As String
	Public Property JobNumber() As String
		Get
			Return _jobNum
		End Get
		Set(ByVal value As String)
			_jobNum = value
		End Set
	End Property


	Private _ResponseDeclared As Boolean
	Public Property ResponseDeclared() As Boolean
		Get
			Return _ResponseDeclared
		End Get
		Set(ByVal value As Boolean)
			_ResponseDeclared = value
		End Set
	End Property



	''' <summary>
	''' Silica Exposure Response
	''' </summary>
	''' <remarks>A Yes or No answer must be entered.</remarks>
	Private _seResponse As Boolean
	Public Property SeResponse() As Boolean
		Get
			Return _seResponse
		End Get
		Set(ByVal value As Boolean)
			_seResponse = value
		End Set
	End Property



	''' <summary>
	''' 100 Air-Mile Exemption Response
	''' </summary>
	''' <remarks>A Yes or No answer must be entered.</remarks>
	Private _amResponse As Boolean
	Public Property AmResponse() As Boolean
		Get
			Return _amResponse
		End Get
		Set(ByVal value As Boolean)
			_amResponse = value
		End Set
	End Property


	''' <summary>
	''' Gets/Sets whether XML file has been created
	''' </summary>
	''' <remarks></remarks>
	Private _DataFileCreated As Boolean
	Public Property DataFileCreated() As Boolean
		Get
			Return _DataFileCreated
		End Get
		Set(ByVal value As Boolean)
			_DataFileCreated = value
		End Set
	End Property







#End Region


#Region " Class-Level Declarations"

	Dim se_100AirMileTBL As DataTable


#End Region


#Region " Methods & Functions"

	''' <summary>
	''' Create DataTable structure
	''' This method does not populate table with Data
	''' </summary>
	''' <remarks></remarks>
	Private Sub MakeDataTable()

		Try

			' Create a DataTable. 
			se_100AirMileTBL = New DataTable("tblSilica_AirMile")
			'"tblSilica_AirMile"

			' foremanID
			Dim colfID As DataColumn = New DataColumn
			colfID.DataType = System.Type.GetType("System.Int32")
			colfID.AllowDBNull = False
			colfID.Caption = "foremanID"
			colfID.ColumnName = "foremanID"

			' Add the columns to the table. 
			se_100AirMileTBL.Columns.Add(colfID)	  ' ForemanID

			' UserID
			Dim colID As DataColumn = New DataColumn
			colID.DataType = System.Type.GetType("System.Int32")
			colID.AllowDBNull = False
			colID.Caption = "UserID"
			colID.ColumnName = "UserID"

			' Add the columns to the table. 
			se_100AirMileTBL.Columns.Add(colID)	  ' UserID

			' DisplayName
			Dim colDisplayName As DataColumn = New DataColumn
			colDisplayName.DataType = System.Type.GetType("System.String")
			colDisplayName.AllowDBNull = False
			colDisplayName.Caption = "Display Name"
			colDisplayName.ColumnName = "DisplayName"
			
			' Add the columns to the table. 
			se_100AirMileTBL.Columns.Add(colDisplayName)   ' DisplayName

			' Job 
			Dim colJob As DataColumn = New DataColumn
			colJob.DataType = System.Type.GetType("System.String")
			colJob.AllowDBNull = False
			colJob.Caption = "Job#"
			colJob.ColumnName = "atmJob"
			
			' Add the columns to the table. 
			se_100AirMileTBL.Columns.Add(colJob)	' Job Number

			' entryDate
			Dim colDate As DataColumn = New DataColumn
			colDate.DataType = System.Type.GetType("System.DateTime")
			colDate.AllowDBNull = False
			colDate.Caption = "Exposure Date"
			colDate.ColumnName = "expDate"

			' Add the columns to the table. 
			se_100AirMileTBL.Columns.Add(colDate)	' Date

			' SilicaExposure
			Dim colExpType As DataColumn = New DataColumn
			colExpType.DataType = System.Type.GetType("System.String")
			colExpType.AllowDBNull = False
			colExpType.Caption = "Exposure Type"
			colExpType.ColumnName = "expType"

			' Add the columns to the table. 
			se_100AirMileTBL.Columns.Add(colExpType)	' SilicaExposure

			' Yes/No
			Dim colYN As DataColumn = New DataColumn
			colYN.DataType = System.Type.GetType("System.Boolean")
			colYN.AllowDBNull = False
			colYN.Caption = "Yes/No"
			colYN.ColumnName = "expYN"
		
			' Add the columns to the table. 
			se_100AirMileTBL.Columns.Add(colYN)	' 100 Air-Mile

		Catch ex As Exception
			MessageBox.Show(ex.Message, "MakeDateTable()")

		End Try

	End Sub

	''' <summary>
	''' Fill DataTable with Exposure Declarations
	''' </summary>
	''' <param name="userName">DisplayName for employee</param>
	''' <param name="JobNum">ATM Job Number</param>
	''' <param name="expDate">Date of Exposure</param>
	''' <param name="expType">Type of Exposure</param>
	''' <param name="expYN">Yes or No</param>
	''' <remarks></remarks>
	Private Sub FillTBL(ByVal foremanID As Integer, _
	  ByVal userID As Integer, _
	  ByVal userName As String, _
	  ByVal JobNum As String, _
	  ByVal expDate As Date, _
	  ByVal expType As String, _
	  ByVal expYN As Boolean)


		' 0     foremanID foremanID
		' 1     userID	  UserID
		' 2     userName  DisplayName
		' 3     JobNum    ATM Job Number 
		' 4     expDate	  Date Exposed
		' 5     expType	  Exposure Type
		' 6     expYN	  Exposure; Yes or No

		' The .NewRow() Method creates a new DataRow 
		' with the same Schema as the DataTable
		Dim r As DataRow = se_100AirMileTBL.NewRow

		' Populate DataRow with variables (Incoming Overloads)
		' then add the DataRow() to the DataTable
		Try
			r(0) = foremanID
			r(1) = userID
			r(2) = userName
			r(3) = JobNum
			r(4) = expDate
			r(5) = expType
			r(6) = expYN

			' Add DataRow() to the DataTable
			se_100AirMileTBL.Rows.Add(r)

		Catch ex As Exception

			MessageBox.Show(ex.Message & vbCrLf & _
			 ex.ToString, "FillTBL()")

		End Try

	End Sub

	''' <summary>
	''' Add rows for each checked crew-member to DataTable and Call BindControls() Method
	''' </summary>
	''' <remarks></remarks>
	Private Sub ValidateAddExposureType()

		Try
			' 0     foremanID
			' 0     UserID
			' 1     DisplayName
			' 2     JobNum    ATM Job Number 
			' 3     expDate	  Date Exposed
			' 4     expType	  Exposure Type
			' 5     expYN	  Exposure; Yes or No

			Dim seCrewSelected As Boolean = False
			Dim amCrewSelected As Boolean = False

			Me.DataFileCreated = False

			' Validate Yes Selection and Crew Selection

			' Validate Silica YES Selection
			If rbo_SE_Yes.Checked And Me.chklstCrew_SE.CheckedItems.Count <= 0 Then
				' Exposure answeres YES, but no crewmember checked
				seCrewSelected = False
			Else
				' Do nothing.  Continue
				seCrewSelected = True
			End If

			' Validate 100 Air-Mile YES Selection
			If rbo_100AirMile_Yes.Checked And Me.chklstCrew_AM.CheckedItems.Count <= 0 Then
				' Exposure answeres YES, but no crewmember checked
				amCrewSelected = False
			Else
				' Do nothing.  Continue
				amCrewSelected = True
			End If

			' Check Crew Selected variables
			If Not seCrewSelected Or Not amCrewSelected Then
				MessageBox.Show("You must select as least one crew member who has been exposed.", "Select Crew Member(s)")
				Exit Sub
			End If


			' Begin Adding Records
			If ResponseDeclared Then

				' Silicia
				For j As Integer = 0 To Me.chklstCrew_SE.Items.Count - 1
					Dim r As DataRowView = CType(Me.chklstCrew_SE.Items(j), DataRowView)
					Dim yn As Boolean = Me.rbo_SE_Yes.Checked
					Dim exp As Boolean = False

					If yn Then
						' Exposure answered YES
						If Me.chklstCrew_SE.GetItemChecked(j) Then
							' Item Checked
							exp = True
						Else
							' Item Not Checked
							exp = False
						End If
					Else
						' Exposure answered NO
						exp = False
					End If
					FillTBL(My.Settings.ae_UserID, CInt(r.Item(0)), r.Item(1).ToString, Me.JobNumber, Me.ExposureDate, "Silica", exp)
				Next

				' 100 Air-Mile
				For j As Integer = 0 To Me.chklstCrew_AM.Items.Count - 1
					Dim r As DataRowView = CType(Me.chklstCrew_AM.Items(j), DataRowView)
					Dim yn As Boolean = Me.rbo_100AirMile_Yes.Checked
					Dim exp As Boolean = False

					If yn Then
						' Exposure answered YES
						If Me.chklstCrew_AM.GetItemChecked(j) Then
							' Item Checked
							exp = True
						Else
							' Item Not Checked
							exp = False
						End If
					Else
						' Exposure answered NO
						exp = False
					End If
					FillTBL(My.Settings.ae_UserID, CInt(r.Item(0)), r.Item(1).ToString, Me.JobNumber, Me.ExposureDate, "100 A-M", exp)
				Next

				'' Remove before final publish
				'' No need for user to view this DataTable
				'BindControls()

				' Create XML file
				CreatDataFile()

				If Me.DataFileCreated Then
					Me.DialogResult = Windows.Forms.DialogResult.OK
					Me.Close()
				Else
					Me.DialogResult = Windows.Forms.DialogResult.Retry
					MessageBox.Show("Unknown Error.  Try Again." & vbCrLf & "ValidateAddExposureType()", "Unkown Error")
				End If

			Else
				MessageBox.Show("You must give a response." & vbCrLf & _
				 "Silica Exposure Answered:  " & SeResponse.ToString & vbCrLf & _
				 "100 Air-Mile Exemption Answered:  " & AmResponse.ToString, "No Response Given")
			End If

		Catch ex As Exception
			MessageBox.Show(ex.Message, "ValidateSilicaExposure()")

		End Try

	End Sub

	''' <summary>
	''' Legacy Method - still used
	''' Select/Deselect rows in CheckedListBox
	''' </summary>
	''' <param name="CheckIt">Check/Uncheck</param>
	''' <param name="se_am">Selicia or Air-Mile</param>
	''' <remarks></remarks>
	Private Sub SetCheckedItems(ByVal CheckIt As Boolean, ByVal se_am As String)

		Select Case se_am
			Case "se"
				For i As Integer = 0 To Me.chklstCrew_SE.Items.Count - 1
					Me.chklstCrew_SE.SetItemChecked(i, CheckIt)
				Next

			Case "am"
				For j As Integer = 0 To Me.chklstCrew_AM.Items.Count - 1
					Me.chklstCrew_AM.SetItemChecked(j, CheckIt)
				Next
		End Select


	End Sub

	''' <summary>
	''' Validate/Build Filename and Write XML File
	''' </summary>
	''' <remarks></remarks>
	Private Sub CreatDataFile()

		' Build the file name with the prefix passed
		Dim filename As String = BuildXmlName("exp", Me.JobNumber, Me.ExposureDate.ToString("MM-dd-yyyy"))

		'Create xml File
		WriteDataSync(Me.se_100AirMileTBL, filename)

		Me.DataFileCreated = True

		''if the file is located in the warehouse
		''which means that it has already been submitted then the file will not be created
		'If Not File.Exists(My.Settings.expDeclWarehousePath & filename) Then

		'	'Create xml File
		'	WriteDataSync(Me.se_100AirMileTBL, filename)

		'Else
		'	MessageBox.Show("Exposure Declaration for this day and this job has already been submitted.", "Already Submitted")

		'End If


	End Sub




#End Region


#Region " Event Handlers"

	Private Sub frmExposureDeclaration_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

		If Not Me.ResponseDeclared Then
			MessageBox.Show("You must declare a response.", "No Response Given")
			e.Cancel = True
		Else
			e.Cancel = False
		End If

	End Sub

	Private Sub frmExposureDeclaration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

		' Instantiate New DataTable Object
		MakeDataTable()

	End Sub

	Private Sub frmExposureDeclarations_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Shown

		Try
			' Remove Handler Event at Startup
			RemoveHandler rbo_SE_Yes.CheckedChanged, AddressOf rbo_SE_Yes_CheckedChanged
			Me.rbo_100AirMile_No.Checked = False
			Me.rbo_100AirMile_Yes.Checked = False
			Me.rbo_SE_No.Checked = False
			Me.rbo_SE_Yes.Checked = False
			''SetCheckedItems(False, "se")
			''SetCheckedItems(False, "am")
			AddHandler rbo_SE_Yes.CheckedChanged, AddressOf rbo_SE_Yes_CheckedChanged

			Me.ResponseDeclared = False
			Me.SeResponse = False
			Me.AmResponse = False

			Me.chklstCrew_SE.Enabled = False
			Me.chklstCrew_AM.Enabled = False



		Catch ex As Exception
			MessageBox.Show(ex.Message, "frmExposureDeclaration_Shown()")

		End Try

	End Sub



	Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

		Me.Close()

	End Sub

	Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

		ValidateAddExposureType()

	End Sub

	''' <summary>
	''' Set Response Properties and enable/disable Crew List.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks></remarks>
	Private Sub rbo_SE_Yes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
	 rbo_SE_Yes.CheckedChanged, _
	 rbo_SE_No.CheckedChanged, _
	 rbo_100AirMile_Yes.CheckedChanged, _
	 rbo_100AirMile_No.CheckedChanged


		Try
			Dim changeState As Boolean = False
			Dim changeType As String = String.Empty
			Dim rbo As RadioButton = DirectCast(sender, RadioButton)
		
			Select Case rbo.Name

				Case "rbo_SE_Yes"

					Me.SeResponse = True
					Me.chklstCrew_SE.Enabled = True

				Case "rbo_SE_No"

					' Set Crew List CheckedItems to False
					changeState = False
					changeType = "se"
					SetCheckedItems(changeState, changeType)

					Me.SeResponse = True
					Me.chklstCrew_SE.Enabled = False

				Case "rbo_100AirMile_Yes"

					Me.AmResponse = True
					Me.chklstCrew_AM.Enabled = True

				Case "rbo_100AirMile_No"

					' Set Crew List CheckedItems to False
					changeState = False
					changeType = "am"
					SetCheckedItems(changeState, changeType)

					Me.AmResponse = True
					Me.chklstCrew_AM.Enabled = False

			End Select

			If Me.SeResponse And Me.AmResponse Then
				ResponseDeclared = True
				Me.btnCancel.Enabled = False
			Else
				ResponseDeclared = False
			End If


		Catch ex As Exception
			MessageBox.Show(ex.Message, "rbo_SE_Yes_CheckedChanged()")

		End Try

	End Sub


	Private Sub llblSE_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblSE.LinkClicked
		Try
			Dim fullPath = Path.Combine((My.Settings.aeDocumentsPath), "ATM Silica Policy.pdf")
			System.Diagnostics.Process.Start(fullPath)

		Catch ex As Exception
			MessageBox.Show(ex.Message, "llblSE_LinkClicked()")
		End Try
	End Sub



#End Region









End Class