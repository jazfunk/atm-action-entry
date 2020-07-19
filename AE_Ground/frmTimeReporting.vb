Option Strict On
Option Explicit On

Imports System.IO
Imports System.Xml.Serialization
Imports System.Data.OleDb
Imports AE_Ground.clsAE_Utilities

Public Class frmTimeReporting

	Dim atmTimeBS As BindingSource

	Dim drag As Boolean
	Dim mousex As Integer
	Dim mousey As Integer



	Public Sub New()

		' This call is required by the Windows Form Designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

	End Sub

	Public Sub New(ByVal jobsDT As DataTable)


		' This call is required by the Windows Form Designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		Me.JobsDataTable = jobsDT


	End Sub


	Private _jobsDataTable As DataTable
	Public Property JobsDataTable() As DataTable
		Get
			Return _jobsDataTable
		End Get
		Set(ByVal value As DataTable)
			_jobsDataTable = value
		End Set
	End Property

	Private Sub frmTimeReporting_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

		' Confirm Form Closing to reduce risk of losing data.
		Dim dialogResult As DialogResult = MessageBox.Show("Are you sure  you want to exit?", "Exit?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

		Select Case dialogResult
			Case Windows.Forms.DialogResult.OK
				e.Cancel = False
			Case Else
				e.Cancel = True
		End Select

	End Sub


	Private Sub frmTimeReporting_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown

		'Dim crewBS As BindingSource = CType(Me.chklstCrew.DataSource, BindingSource)

		'Dim SE_AM100 As New frmExposureDeclaration(crewBS, Me.lblJobNumber.Text, Me.dtpDate.Value)
		'SE_AM100.MdiParent = Me.MdiParent
		'SE_AM100.Show()


	End Sub

	

	Private Sub frmTimeReporting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

		Me.lblJobNumber.Text = My.Settings.ae_CurrentJob

		' Load Users, filter out Administrative Profiles
		Me.QryUsersDisplayNamesTableAdapter.Fill(Me.ActionEntryDataSet.qryUsersDisplayNames)
		Me.QryUsersDisplayNamesBindingSource.Filter = "groupID = 3 or groupID = 4"

		FilterBS()

		Me.btnAddNotes.Enabled = False

		With Me.chklstCrew
			.DataSource = Me.QryUsersDisplayNamesBindingSource
			.DisplayMember = "displayName"
		End With

		Dim x As Integer = 24 - Today.Hour

		Me.dtpStart.MaxDate = Date.Today.AddHours(x)
		Me.dtpEnd.MaxDate = Date.Today.AddHours(x)

		Dim startHours As Integer = Me.dtpStart.Value.Hour - 7
		Dim endHours As Integer = Me.dtpEnd.Value.Hour - 15

		Me.dtpStart.Value = Me.dtpStart.Value.AddHours(-startHours)
		Me.dtpEnd.Value = Me.dtpEnd.Value.AddHours(-endHours)

		Dim startMin As Integer = Me.dtpStart.Value.Minute
		Dim endMin As Integer = Me.dtpEnd.Value.Minute

		Me.dtpStart.Value = Me.dtpStart.Value.AddMinutes(-startMin)
		Me.dtpEnd.Value = Me.dtpEnd.Value.AddMinutes(-endMin)

		If My.Settings.ae_CurrentJob = String.Empty Then
			Me.lblJobNumber.Text = "Job#"
		Else
			Me.lblJobNumber.Text = My.Settings.ae_CurrentJob

		End If

		If My.Settings.ae_WorkType = String.Empty Then
			' Do nothing,  yet.
		Else
			Select Case My.Settings.ae_WorkType
				Case "S"
					Me.rboSigns.Checked = True
				Case "G"
					Me.rboSigns.Checked = True
				Case "F"
					Me.rboFence.Checked = True
				Case "O"
					Me.rboOther.Checked = True
			End Select
		End If

		'Dim crewBS As BindingSource = CType(Me.chklstCrew.DataSource, BindingSource)

		'Dim SE_AM100 As New frmExposureDeclaration(crewBS, Me.lblJobNumber.Text, Me.dtpDate.Value)
		'SE_AM100.MdiParent = Me.MdiParent
		'SE_AM100.TopMost = True
		'SE_AM100.Show()



	End Sub

	Private Sub btnEnterTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterTime.Click
		Try

			'  Limit crew member list to avoid all users being submitted for silica/100am exposure
			If Me.QryUsersDisplayNamesBindingSource.Count > 10 Then
				MessageBox.Show("Time reporting is limited to 10 crewmembers.  You must select ONLY the crew members for which time is being submitted for." & vbCrLf & _
				   "Select crew members, then click 'Save Crew' button.", _
				   "Crew List Limit Exceeded")
				Exit Sub
			End If

			' Confirm Usre wants to enter time for the current Date.
			If Me.dtpDate.Value.Date = Today Then
				Dim result As DialogResult = MessageBox.Show("Today's date is selected.  Are you sure?", "Confirm Date Selection", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
				Select Case result
					Case Windows.Forms.DialogResult.OK
						' Continue method
					Case Windows.Forms.DialogResult.Cancel
						Exit Sub
				End Select
			End If

			Dim x As Integer = 0
			For Each item As DataRowView In Me.chklstCrew.CheckedItems
				Dim totalTime As TimeSpan = Me.dtpEnd.Value.Subtract(Me.dtpStart.Value)
				Dim tTime As String = String.Format("{0:00.00}", totalTime.TotalHours)

				If dtpStart.Value > dtpEnd.Value Then
					MessageBox.Show("Your end time is before your start time. Please correct.", "InvalidTime")
					Exit Sub
				ElseIf lblJobNumber.Text = Nothing Or Me.lblJobNumber.Text.ToUpper = "JOB#" Then
					MessageBox.Show("Job not selected, please select job.", "Select Job")
					Exit Sub
				ElseIf My.Settings.ae_WorkType = Nothing Then
					MessageBox.Show("Work Type not selected, please select appropriate work type.", "Select Work Type")
					Exit Sub
				Else
					'If Me.dtpDate.Value.Date = Today Then
					'	Dim result As DialogResult = MessageBox.Show("Today's date is selected.  Are you sure?", "Confirm Date Selection", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
					'	Select Case result
					'		Case Windows.Forms.DialogResult.OK
					'			' Continue method
					'		Case Windows.Forms.DialogResult.Cancel
					'			Exit Sub
					'	End Select
					'End If

					If (Me.dtpStart.Value.Minute = 0 Or Me.dtpStart.Value.Minute = 30) And (Me.dtpEnd.Value.Minute = 0 Or Me.dtpEnd.Value.Minute = 30) Then

						'Create the new row
						Dim newRow As DataRow = Me.TimeReporting.Tables("atmTimeDT").NewRow

						'Add some data to it
						newRow("Employee") = item(1).ToString
						newRow("JobNumber") = Me.lblJobNumber.Text & My.Settings.ae_WorkType
						newRow("Day") = Me.dtpDate.Value.ToString("MM-dd-yyyy")
						newRow("StartTime") = Me.dtpStart.Value.ToString("hh:mm tt")
						newRow("EndTime") = Me.dtpEnd.Value.ToString("hh:mm tt")
						newRow("TotalHours") = tTime
						newRow("Notes") = String.Empty
						newRow("Foreman") = My.Settings.ae_DisplayName

						'Add it to the table
						Me.TimeReporting.Tables("atmTimeDT").Rows.Add(newRow)

						' Counter
						x += 1

					Else
						MessageBox.Show("Please round to the nearest half hour.")
						Exit For
					End If
				End If

			Next

			If x < 1 Then
				Exit Sub

			End If

			atmTimeBS = New BindingSource(Me.TimeReporting, "atmTimeDT")

			With Me.dgvTime
				.DataSource = atmTimeBS
				.Columns(0).ReadOnly = False
				.Columns(0).Width = 140
				.Columns(1).ReadOnly = True
				.Columns(1).Width = 60
				.Columns(2).ReadOnly = True
				.Columns(3).ReadOnly = True
				.Columns(4).ReadOnly = True
				.Columns(5).ReadOnly = True
				.Columns(6).ReadOnly = False
				.Columns(6).Width = 150
				.Columns(7).Visible = False
			End With

			' Enable Add Notes button
			Me.btnAddNotes.Enabled = True
			Me.btnDelete.Enabled = True
			Me.btnSave.Enabled = True
			Me.btnPrev.Enabled = True
			Me.btnNext.Enabled = True

			Me.ckbSelectAll.Checked = False

			' I've disabled "Save My.Settings on Shutdown" and doing so manually
			' to hopefully resolve an error on all the netbooks (Atom processors)
			My.Settings.Save()

			''Uncheck all the boxes in the checked list box
			'While chklstCrew.CheckedIndices.Count > 0
			'	Me.chklstCrew.SetItemChecked(Me.chklstCrew.CheckedIndices(0), False)
			'End While

		Catch ex As Exception
			MessageBox.Show(ex.Message, "btnEnterTime_Click()")
		End Try



	End Sub

	Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

		If Me.dgvTime.RowCount > 0 Then
			Dim dlg As DialogResult = MessageBox.Show("OK to delete " & CType(Me.dgvTime.CurrentRow.Cells.Item(0).Value, String) & "?", "Delete Record", MessageBoxButtons.YesNo)

			Select Case dlg

				Case Windows.Forms.DialogResult.Yes
					Me.dgvTime.Rows.Remove(Me.dgvTime.CurrentRow)
				Case Windows.Forms.DialogResult.No
					' Cancel, do nothing.

			End Select
		Else
			MessageBox.Show("Nothing to Delete", "No Delete")
		End If

	End Sub


	


	Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
		If dgvTime.RowCount = 0 Then
			MessageBox.Show("You must have something to submit.", "Nothing Listed")
		Else
			Dim i As Integer = 0
			Dim day As String = Me.dgvTime.CurrentRow.Cells(2).Value.ToString
			Dim valid As Boolean = True

			For Each row As DataGridViewRow In Me.dgvTime.Rows
				If Not row.Cells.Item(2).Value.ToString = day And row.Cells.Item(2).Value.ToString = Me.dtpDate.Value.ToString("MM-dd-yyyy") Then
					row.DefaultCellStyle.BackColor = Color.Yellow
					valid = False
				End If
			Next

			If valid = True Then
				' Send CrewList BindingSource to Exposure Declaration Form
				Dim crewBS As BindingSource = CType(Me.chklstCrew.DataSource, BindingSource)
				Dim seAM As New frmExposureDeclaration(crewBS, Me.lblJobNumber.Text, Me.dtpDate.Value)

				' Show Exposure Declaration Form as a Dialog and evaluate the DialogResult.
				If seAM.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
					'MessageBox.Show("Exposure Declaration Accepted.", "Accepted")
					' Do nothing.  No longer displaying message 05.12.2018 -jk
				Else
					'MessageBox.Show("Exposure Declaration Not Accepted.", "Not Accepted")
					' Do nothing.  No longer displaying message 05.12.2018 -jk
				End If
				seAM.Dispose()

				' Build the file name with the prefix passed
				Dim filename As String = BuildXmlName("ts", Me.lblJobNumber.Text, Me.dtpDate.Value.ToString("MM-dd-yyyy"))

				' If the file is located in the warehouse
				' which means that it has already been submitted then the file will not be created
				If Not File.Exists(My.Settings.ae_WarehouseTimeSheet & filename) Then

					'Create xml File
					WriteDataSync(Me.TimeReporting.Tables("atmTimeDT"), filename)

					' Supress confirmation dialogue and close the form
					RemoveHandler Me.FormClosing, AddressOf frmTimeReporting_FormClosing
					Me.Close()
					AddHandler Me.FormClosing, AddressOf frmTimeReporting_FormClosing

				Else
					MessageBox.Show("Time for this day and this job has already been submitted.", "Already Submitted")

				End If
			Else
				MessageBox.Show("You are only allowed to submit timesheets containing one day." & vbCrLf & _
				 "Please review your timesheet and correct any issues", "Invalid Timesheet")
			End If


		End If
	End Sub

	Private Sub lblJobNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblJobNumber.Click
		Me.cmbJobNumber.Visible = True
		Me.btnOK.Visible = True
	End Sub

	'Private Sub cmbJobNumber_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbJobNumber.SelectedIndexChanged
	'	lblJobNumber.Text = cmbJobNumber.Text
	'	cmbJobNumber.Visible = False
	'End Sub

	Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click

		ShowHome(My.Settings.ae_UserID)
		Me.Close()

	End Sub

	' Form Dragging Logic

	Private Sub pnlTitleBar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlTitleBar.MouseDown

		drag = True
		mousex = Windows.Forms.Cursor.Position.X - Me.Left
		mousey = Windows.Forms.Cursor.Position.Y - Me.Top

	End Sub

	Private Sub pnlTitleBar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlTitleBar.MouseMove
		If drag Then
			Me.Top = Windows.Forms.Cursor.Position.Y - mousey
			Me.Left = Windows.Forms.Cursor.Position.X - mousex
		End If
	End Sub

	Private Sub pnlTitleBar_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlTitleBar.MouseUp
		drag = False

	End Sub

	Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click, cmbJobNumber.SelectedIndexChanged
		Me.lblJobNumber.Text = cmbJobNumber.Text
		My.Settings.ae_CurrentJob = Me.lblJobNumber.Text
		Me.cmbJobNumber.Visible = False
		My.Settings.Save()

		Me.btnOK.Visible = False
	End Sub





	Private Sub SaveEmployeeList()

		Try
			' Temp String container to concactenante filter string
			Dim strTemp As String = Nothing

			' Current record
			Dim x As Integer = 0

			' Count of Crew CheckedList Items
			Dim y As Integer = Me.chklstCrew.CheckedItems.Count

			'' Clear any previous filter
			'My.Settings.at_CrewListFilter = Nothing

			For Each row As DataRowView In Me.chklstCrew.CheckedItems
				If x = 0 Then
					' First Selection
					My.Settings.at_CrewListFilter = "displayName = '" & row.Item(1).ToString & "'"

				Else
					' Next Selection to last selection
					strTemp = My.Settings.at_CrewListFilter
					My.Settings.at_CrewListFilter = strTemp & " Or displayName = '" & row.Item(1).ToString & "'"

				End If

				' Increment counter
				x += 1

			Next


			Me.btnViewAll.Text = "View All Employees"
			Me.ckbSelectAll.Enabled = True


		Catch ex As Exception
			MessageBox.Show(ex.Message, "SaveEmployeeList()")

		End Try



	End Sub

	Private Sub FilterBS()

		If My.Settings.at_CrewListFilter = Nothing Then
			' Filter out group ID's .  3 = ATM Foreman, 4 = ATM Crew, 5 = Foreign, 6 = Inactive Users
			Me.QryUsersDisplayNamesBindingSource.Filter = "groupID = 1 or groupID = 3 or groupID = 4"
			Me.ckbSelectAll.Enabled = False
			Me.btnSaveCrew.Enabled = True
		Else
			' Filter only previously selected crew members
			Me.QryUsersDisplayNamesBindingSource.Filter = My.Settings.at_CrewListFilter
			Me.ckbSelectAll.Enabled = True
			Me.btnSaveCrew.Enabled = False
		End If

		' Set Work Type
		Select Case My.Settings.ae_WorkType
			Case "-S"
				Me.rboSigns.Checked = True
			Case "-G"
				Me.rboGuardrail.Checked = True
			Case "-F"
				Me.rboFence.Checked = True
			Case "-O"
				Me.rboOther.Checked = True
		End Select

	End Sub

	Private Sub AddNotes()

		Try
			If Me.dgvTime.RowCount > 0 Then

				Dim notes As String = Me.dgvTime.CurrentRow.Cells.Item(6).Value.ToString
				Dim dName As String = Me.dgvTime.CurrentRow.Cells.Item(0).Value.ToString
				Dim AddNote As New frmAE_InputBox(notes, dName)

				If AddNote.ShowDialog = Windows.Forms.DialogResult.OK Then
					Me.dgvTime.CurrentRow.Cells.Item(6).Value = AddNote.NewNote
				Else
					' Cancel operation

				End If
			Else
				Me.btnAddNotes.Enabled = False

			End If
		Catch ex As Exception
			MessageBox.Show(ex.Message, "AddNotes()")

		End Try
	End Sub




	Private Sub btnViewAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewAll.Click


		Try

			Dim b As Button = DirectCast(sender, Button)

			Select Case b.Text

				Case "View Crew Only"
					If Not My.Settings.at_CrewListFilter = String.Empty Then
						' Filter only previously selected crew members
						Me.QryUsersDisplayNamesBindingSource.Filter = My.Settings.at_CrewListFilter

						' Toggle Button Text 
						b.Text = "View All Employees"
						Me.ckbSelectAll.Enabled = True
						Me.btnSaveCrew.Enabled = False
					End If

				Case "View All Employees"
					' Filter out group ID's .  3 = ATM Foreman, 4 = ATM Crew, 5 = foreign, 6 = Inactive Users
					Me.QryUsersDisplayNamesBindingSource.Filter = "groupID = 3 or groupID = 4"

					If My.Settings.at_CrewListFilter = String.Empty Then
						MessageBox.Show("No Crew List Created.", "btnViewAll_Click()")

					Else
						' Toggle Button Text
						b.Text = "View Crew Only"
						Me.ckbSelectAll.Enabled = False
						Me.btnSaveCrew.Enabled = True
					End If


			End Select

			'Me.btnSaveCrew.Enabled = True

		Catch ex As Exception
			MessageBox.Show(ex.Message, "btnViewAll_Click()")

		End Try



	End Sub

	Private Sub btnSaveCrew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveCrew.Click
		SaveEmployeeList()
		FilterBS()

	End Sub

	Private Sub btnAddNotes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNotes.Click
		AddNotes()

	End Sub

	Private Sub dgvTime_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvTime.SelectionChanged

		Dim strTemp As String = "Add Notes for:"

		Dim strDelTemp As String = "Delete:"

		Try

			Dim empName As String = Me.dgvTime.CurrentRow.Cells.Item(0).Value.ToString
			Me.btnAddNotes.Text = strTemp & vbCrLf & "(" & empName & ")"
			Me.btnDelete.Text = strDelTemp & vbCrLf & "(" & empName & ")"

		Catch ex As Exception
			Me.btnAddNotes.Text = strTemp
			Me.btnDelete.Text = strDelTemp
			'MessageBox.Show("Probably don't need this message.  Delete after teseting" & vbCrLf & _
			'	ex.Message, "dgvTime_SelectionChanged()")

		End Try


	End Sub

	Private Sub dgvTime_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTime.CellContentDoubleClick

		AddNotes()


	End Sub

	Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click, btnNext.Click

		Dim b As Button = DirectCast(sender, Button)

		Select Case b.Name
			Case "btnPrev"
				Me.atmTimeBS.MovePrevious()
			Case "btnNext"
				Me.atmTimeBS.MoveNext()
		End Select

	End Sub

	Private Sub ckbSelectAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbSelectAll.CheckedChanged


		Dim ckb As CheckBox = DirectCast(sender, CheckBox)

		Select Case ckb.CheckState

			Case CheckState.Checked
				'Check all the boxes in the checked list box
				' To check all CheckedListBox Item:
				For i As Integer = 0 To chklstCrew.Items.Count - 1
					chklstCrew.SetItemChecked(i, True)
				Next

				
				ckb.Text = "Select None"

			Case CheckState.Unchecked

				'To uncheck all CheckedListBox Item:
				For i As Integer = 0 To chklstCrew.Items.Count - 1
					chklstCrew.SetItemChecked(i, False)
				Next

				ckb.Text = "Select All"
		End Select

	End Sub

	Private Sub rboSigns_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rboSigns.CheckedChanged, _
				rboGuardrail.CheckedChanged, _ 
				rboFence.CheckedChanged, _ 
				rboOther.CheckedChanged


		Try
			Dim rbo As RadioButton = DirectCast(sender, RadioButton)
			Dim workType As String = Nothing
			Select Case rbo.Name
				Case "rboSigns"
					workType = "-S"
				Case "rboGuardrail"
					workType = "-G"
				Case "rboFence"
					workType = "-F"
				Case "rboOther"
					workType = "-O"
			End Select

			My.Settings.ae_WorkType = workType

		Catch ex As Exception
			MessageBox.Show(ex.Message, "rboSigns_CheckedChanged()")

		End Try


	End Sub





	Private Sub btnDriveLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
	   btnDriveLoad.Click, _
	   btnSite.Click

		Try

			Dim btn As Button = DirectCast(sender, Button)
			Dim note As String = String.Empty
			'Dim existingNotes As String = String.Empty
			'Dim combinedNotes As String = String.Empty

			Select Case btn.Name
				Case "btnDriveLoad"
					note = "Drive/Load"
				Case "btnSite"
					note = "Site"
			End Select

			Dim row As DataGridViewRow = Me.dgvTime.CurrentRow
			row.Cells.Item(6).Value = note

			'' Retain existing notes, if any, and place inside of parenthesis.
			'' Disabled for now.  05.11.2018 - jk
			'If row.Cells.Item(6).ToString = "" Or row.Cells.Item(6).Value.ToString = String.Empty Then
			'	' Note field is empty
			'	row.Cells.Item(6).Value = note
			'Else
			'	' Note field is NOT empty
			'	existingNotes = row.Cells.Item(6).Value.ToString
			'	If existingNotes <> note Then
			'		combinedNotes = note & "(" & existingNotes & ")"
			'		row.Cells.Item(6).Value = combinedNotes
			'	End If
			'End If

			' Advance to the next record or move to first if last row is selected
			If Me.dgvTime.CurrentRow.Index = Me.dgvTime.RowCount - 1 Then
				Me.atmTimeBS.MoveFirst()
			Else
				Me.atmTimeBS.MoveNext()
			End If

		Catch ex As Exception
			MessageBox.Show("btnDriveLoad_Click()")

		End Try

	End Sub


End Class