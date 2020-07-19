Option Strict On
Option Explicit On

Imports System.IO
Imports System.Xml.Serialization
Imports System.Data.OleDb
Imports AE_Ground.clsAE_Utilities
Imports System.Text.RegularExpressions




Public Class frmActionMail


#Region " Class Level Declarations"


	' Cloud (DataSync)
	Dim amBS As BindingSource
	Dim amDS As DataSet
	Dim amDS1 As DataSet
	Dim amDS2 As DataSet
	Dim amDT As DataTable

	Dim messageDS As DataSet
	Dim messageDT As DataTable
	'Dim amDT As DataTable

	Dim userDct As Dictionary(Of Integer, String)
	Dim userNamesByID As Dictionary(Of Integer, String)
	
	Dim newAMlist As New List(Of clsActionMessage)

	Dim amSubject As String
	Dim amMessage As String

	' New Action Messages
	Dim newAMs As Integer



#End Region


#Region " Properties"


#End Region


#Region " Methods & Functions"

	Public Function GetDataSetFromDataSync(ByVal DataSyncToClean As String) As DataSet

		Dim cleanDS As DataSet
		Try
			cleanDS = New DataSet(DataSyncToClean)
			cleanDS.ReadXml(My.Settings.am_InBox & DataSyncToClean)
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
				Dim tDs As New TempDS
				tDs.TheDataSet = GetDataSetFromDataSync(Path.GetFileName(f))
				MasterDataSet.Merge(tDs.TheDataSet, True)
			Next

			Return MasterDataSet

		Catch ex As Exception
			MessageBox.Show(ex.Message, "MergeAllDataSets()")

			Return Nothing

		End Try



	End Function

	Private Sub ViewAllMessages()
		Try
			'Dim aMessages() As String = System.IO.Directory.GetFiles(My.Settings.am_InBox)
			'Dim x As Integer = aMessages.Count
			'MessageBox.Show(x.ToString & " Messages in am_InBox")

			amDS = MergeAllDataSets(My.Settings.am_InBox)
			CreateAmList(amDS.Tables("tblActionMessages"))

		Catch ex As Exception
			MessageBox.Show(ex.Message, "ViewAllMessages()")
		End Try
	End Sub

	Private Sub CreateUserDictionary()


		Try
			Dim id As Integer
			Dim fullName As String
			Dim dgv As DataGridView = Me.TblUsersDataGridView
			Dim dgvr As DataGridViewRow
			userDct = New Dictionary(Of Integer, String)

			For Each dgvr In dgv.Rows
				id = CInt(dgvr.Cells.Item(0).Value)
				fullName = CType(dgvr.Cells.Item(3).Value, String) & " " & CType(dgvr.Cells.Item(4).Value, String)
				userDct.Add(id, fullName)
				Me.dgvUserList.Rows.Add(id, fullName, False)
			Next

			'' Easier way to get dictionary from Typed DataTable.  Not really used right now
			'' But I spent so much time trying to get this to work that I'm leaving here for
			'' future reference.
			'Dim myDt As ActionEntryDataSet.tblUsersDataTable = Me.ActionEntryDataSet.tblUsers
			'userNamesByID = myDt.ToDictionary(Function(row) row.ID, Function(row) row.firstName & " " & row.lastName)

		

		Catch ex As Exception
			MessageBox.Show(ex.Message, "CreateUserDictionary()")
		End Try

	End Sub

	''' <summary>
	''' STILL USING THIS METHOD but no longer using the Generic AmList.  
	''' Didn't want to change the name of this method.
	''' </summary>
	''' <param name="dt"></param>
	''' <remarks></remarks>
	Private Sub CreateAmList(ByVal dt As DataTable)

		Try
			' Clear Previous List
			newAMlist.Clear()

			' Create DataTable to Populate with Modified Data
			amDT = New DataTable
			With amDT
				.Columns.Add("amToID", GetType(Integer))
				.Columns.Add("amToName", GetType(String))
				.Columns.Add("amFromID", GetType(Integer))
				.Columns.Add("amFromName", GetType(String))
				.Columns.Add("amSubj", GetType(String))
				.Columns.Add("amDate", GetType(Date))
				.Columns.Add("amMessage", GetType(String))
			End With


			' Itereate each DataRow in given DataTable and build new row to add
			' to amDT
			If Not (dt Is Nothing) Then
				For Each row As DataRow In dt.Rows
					Dim amRow As DataRow = amDT.NewRow()
					amRow("amToID") = CInt(row.Item(1))
					amRow("amToName") = userDct(CInt(row.Item(1)))
					amRow("amFromID") = CInt(row.Item(2))
					amRow("amFromName") = userDct(CInt(row.Item(2)))
					amRow("amSubj") = CType(row.Item(3), String)
					amRow("amDate") = Format(CDate(row.Item(4)), "MM/dd/yyyy h:mm tt")
					amRow("amMessage") = CType(row.Item(5), String)

					amDT.Rows.Add(amRow)

				Next

				amDT.DefaultView.Sort = "amDate DESC"


			End If


			'RemoveHandler dgvActionMessages.SelectionChanged, AddressOf dgvActionMessages_SelectionChanged
			With Me.dgvActionMessages

				.DataSource = Nothing
				If Not (amDT Is Nothing) Then
					.DataSource = amDT
				End If


				.Columns("amToID").Visible = False
				.Columns("amToName").Visible = False
				.Columns("amFromID").Visible = False

				.Columns("amFromName").HeaderText = "From"
				.Columns("amFromName").ReadOnly = True
				.Columns("amFromName").FillWeight = 20

				.Columns("amSubj").HeaderText = "Subject"
				.Columns("amSubj").ReadOnly = True
				.Columns("amSubj").FillWeight = 20

				.Columns("amDate").HeaderText = "Date"
				.Columns("amDate").ReadOnly = True
				.Columns("amDate").FillWeight = 20

				.Columns("amMessage").HeaderText = "Message"
				.Columns("amMessage").ReadOnly = True
				.Columns("amMessage").FillWeight = 40

			End With
			'AddHandler dgvActionMessages.SelectionChanged, AddressOf dgvActionMessages_SelectionChanged

		Catch ex As Exception
			MessageBox.Show(ex.Message, "CreateAmList()")
		End Try

	End Sub



	' This method not used, the code was added to another method
	Private Sub SendMail()


		'For Each row As DataGridViewRow In Me.dgvUserList.Rows
		'	If CBool(row.Cells.Item(2).Value) Then
		'		messageDT = Me.DsAE_DataSync.Tables("tblActionMessages")
		'		Dim newDate As Date = Now

		'		'Create the new row
		'		Dim newRow As DataRow = messageDT.NewRow
		'		Dim toID As Integer = CInt(row.Cells.Item(0).Value)

		'		'Add some data to it
		'		newRow("ID") = 0
		'		newRow("amTO") = toID
		'		newRow("amFROM") = My.Settings.ae_UserID
		'		newRow("amSUBJECT") = Me.txtSUBJECT.Text.Trim
		'		newRow("amDATE") = newDate
		'		newRow("amMESSAGE") = Me.RichTextBox1.Text.Trim


		'		'Add it to the table
		'		messageDT.Rows.Add(newRow)

		'		Dim fn As String = "am_" & toID.ToString & "_" & My.Settings.ae_UserID.ToString & "_" & newDate.ToString("MM.dd.yyyy.HH.mm.ss") & ".xml"
		'		'MessageBox.Show(fn)

		'		WriteDataSync(messageDT, fn)

		'		Dim files() As String = Directory.GetFiles(My.Settings.am_OutBox)
		'		For Each f As String In files
		'			amXmlUpload(f)
		'		Next

		'		messageDT.Rows.Clear()

		'		' Uncheck all checkboxes
		'		For Each r As DataGridViewRow In Me.dgvUserList.Rows
		'			If CBool(r.Cells.Item(2).Value) Then
		'				r.Cells.Item(2).Value = False
		'			End If
		'		Next

		'	End If
		'Next

		'MessageBox.Show("Message Sent")


	End Sub

	Private Sub SetProgressBar(ByVal AnimationSpeed As Integer, ByVal DisplayMessage As String)

		AE_mdiMain.ToolStripProgressBar1.MarqueeAnimationSpeed = AnimationSpeed
		AE_mdiMain.ToolStripStatusLabel1.Text = DisplayMessage

	End Sub


#End Region


#Region " Event Handlers"

	Private Sub frmActionMail_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

		e.Cancel = True
		Me.Hide()
		
	End Sub

	Private Sub frmActionMail_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged

		
	End Sub

	

	Private Sub frmActionMail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


		' Check Mail only if connected
		If InternetGetConnectedState(InternetConnectionIsConfigured, 0) = 0 Then
			'no connection
			Me.btnSendMail.Enabled = False
			Me.btnCheckMail.Enabled = False
		ElseIf InternetGetConnectedState(InternetConnectionIsConfigured, 0) = 1 Then
			'is connected
			Me.btnSendMail.Enabled = True
			Me.btnCheckMail.Enabled = True
			Me.Timer1.Start()
		End If

		Me.TblUsersTableAdapter.Fill(Me.ActionEntryDataSet.tblUsers)
		Me.TblUsersBindingSource.Filter = "groupID <> 4"

		CreateUserDictionary()

		ViewAllMessages()




	End Sub

	Private Sub btnSendMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendMail.Click

		Me.amSubject = Me.txtSUBJECT.Text
		Me.amMessage = Me.rtbMessage.Text

		SetProgressBar(25, "Sending Mail")
		Me.BackgroundWorker2.RunWorkerAsync()

	End Sub

	Private Sub btnCheckMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckMail.Click

		SetProgressBar(25, "Checking Mail")

		If Me.BackgroundWorker1.IsBusy <> True Then
			Me.BackgroundWorker1.RunWorkerAsync()
		Else
			MessageBox.Show("BackgroundWorker1.IsBusy = True" & vbCrLf & "You need to send the message again")

		End If


	End Sub



	Private Sub dgvActionMessages_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvActionMessages.SelectionChanged

		' Compile Message info for display in TextBox

		Try

			'0  '.Columns.Add("amToID")
			'1  '.Columns.Add("amToName")
			'2  '.Columns.Add("amFromID")
			'3  '.Columns.Add("amFromName")
			'4  '.Columns.Add("amSubj")
			'5  '.Columns.Add("amDate")
			'6  '.Columns.Add("amMessage")

			Dim dgv As DataGridView = DirectCast(sender, DataGridView)
			Dim fromName As String = CType(dgv.CurrentRow.Cells.Item(3).Value, String)
			Dim amSubject As String = CType(dgv.CurrentRow.Cells.Item(4).Value, String)
			Dim amDate As String = CType(dgv.CurrentRow.Cells.Item(5).Value, String)
			Dim amMessage As String = CType(dgv.CurrentRow.Cells.Item(6).Value, String)

			Dim displayMessage As String = "From:  " & fromName & vbCrLf & _
			  "Date:  " & amDate & vbCrLf & vbCrLf & _
			  "Subject:  " & amSubject & vbCrLf & vbCrLf & _
			  amMessage

			Me.rtbActionMessage.Text = displayMessage


		Catch ex As Exception
			'MessageBox.Show(ex.Message, "dgvActionMessages_SelectionChanged()")

		End Try


	End Sub



	Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork


		Try
			Dim filesToGet() As String = GetFileNameStringArrayFromFTP(My.Settings.am_FTPNewMessage)

			' Counter
			Dim x As Integer

			For Each fls As String In filesToGet
				' Split the string on the underscore character
				Dim parts As String() = Path.GetFileName(fls).Split(New Char() {"_"c})
				Dim i As Integer = CInt(parts(1))
				If i = My.Settings.ae_UserID Then
					x += 1
				End If
			Next

			'MessageBox.Show(x.ToString)

			If x >= 1 Then

				' Display number of new messages on the Home Screen Button
				frmAE_Home.btnActionMail.Text = x.ToString

				'Dim dlg As DialogResult = MessageBox.Show(x.ToString & " message(s).  Click 'OK' to download.", "New Messages", MessageBoxButtons.OKCancel)
				For Each f As String In filesToGet
					' Split the string on the underscore character
					Dim p As String() = Path.GetFileName(f).Split(New Char() {"_"c})
					Dim ix As Integer = CInt(p(1))
					If ix = My.Settings.ae_UserID Then
						amXmlDownload(f)
					End If
				Next

				'SetProgressBar(0, x.ToString & " new message(s)")


			End If

			newAMs = x

		Catch ex As Exception
			'MessageBox.Show(ex.Message, "BackgroundWorker1_DoWork()")

		End Try


	End Sub

	Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

		ViewAllMessages()

		Dim ActionLabelText As String = Nothing
		Dim ActionButtonText As String = Nothing


		If newAMs > 0 Then
			SetProgressBar(0, newAMs.ToString & " new message(s).")
			ActionLabelText = "Action Mail - (" & newAMs.ToString & ") New Message(s)"
			ActionButtonText = newAMs.ToString
		Else
			SetProgressBar(0, "No New Messages.")
			ActionLabelText = "Action Mail - No New Messages"
			ActionButtonText = Nothing
		End If

		' Loop each form, if Home screen, then loop each control
		' and find appropriate label and button and change text
		' accordingly
		For Each f As Form In AE_mdiMain.MdiChildren
			If f.Name = "frmAE_Home" Then
				Dim fHome As frmAE_Home = CType(f, frmAE_Home)
				For Each ctrl As Control In fHome.Panel3.Controls
					If TypeOf ctrl Is Button Then
						If ctrl.Name = "btnActionMail" Then
							'MessageBox.Show("found button")
							ctrl.Text = ActionButtonText
						End If
					ElseIf TypeOf ctrl Is Label Then
						If ctrl.Name = "lblActionMail" Then
							'MessageBox.Show("found label")
							ctrl.Text = ActionLabelText
						End If
					End If
				Next
			End If
		Next


	End Sub

	Private Sub BackgroundWorker2_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork

		Try
			Dim x As Integer = 0
			For Each row As DataGridViewRow In Me.dgvUserList.Rows
				If CBool(row.Cells.Item(2).Value) Then
					messageDT = Me.DsAE_DataSync.Tables("tblActionMessages")
					Dim newDate As Date = Now
					x += 1
					'Create the new row
					Dim newRow As DataRow = messageDT.NewRow
					Dim toID As Integer = CInt(row.Cells.Item(0).Value)

					'Add some data to it
					newRow("ID") = 0
					newRow("amTO") = toID
					newRow("amFROM") = My.Settings.ae_UserID
					newRow("amSUBJECT") = Me.amSubject
					newRow("amDATE") = newDate
					newRow("amMESSAGE") = Me.amMessage


					'Add it to the table
					messageDT.Rows.Add(newRow)

					' Creat FileName and DataSet
					Dim fn As String = "am_" & toID.ToString & "_" & My.Settings.ae_UserID.ToString & "_" & newDate.ToString("MM.dd.yyyy.HH.mm.ss") & ".xml"
					WriteDataSync(messageDT, fn)

					'Upload each file in OutBox
					Dim files() As String = Directory.GetFiles(My.Settings.am_OutBox)
					For Each f As String In files
						amXmlUpload(f)
					Next

					messageDT.Rows.Clear()



				End If
			Next

			If x = 0 Then MessageBox.Show("You must select at least 1 recipient.", "Select Recipient")

			' Uncheck all checkboxes
			For Each r As DataGridViewRow In Me.dgvUserList.Rows
				If CBool(r.Cells.Item(2).Value) Then
					r.Cells.Item(2).Value = False
				End If
			Next

		Catch ex As Exception

		End Try

	End Sub

	Private Sub BackgroundWorker2_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
		
		SetProgressBar(0, "Message Sent.")

	End Sub



	Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick

		' Check Mail only if connected
		If InternetGetConnectedState(InternetConnectionIsConfigured, 0) = 0 Then
			'no connection

		ElseIf InternetGetConnectedState(InternetConnectionIsConfigured, 0) = 1 Then
			'is connected
			Me.btnCheckMail_Click(Nothing, Nothing)
		End If



	End Sub






#End Region




















End Class




Public Class clsActionMessage


	Private _amToID As Integer
	Public Property amToID() As Integer
		Get
			Return _amToID
		End Get
		Set(ByVal value As Integer)
			_amToID = value
		End Set
	End Property


	Private _amToName As String
	Public Property amToName() As String
		Get
			Return _amToName
		End Get
		Set(ByVal value As String)
			_amToName = value
		End Set
	End Property


	Private _amFromID As Integer
	Public Property amFromID() As Integer
		Get
			Return _amFromID
		End Get
		Set(ByVal value As Integer)
			_amFromID = value
		End Set
	End Property


	Private _amFromName As String
	Public Property amFromName() As String
		Get
			Return _amFromName
		End Get
		Set(ByVal value As String)
			_amFromName = value
		End Set
	End Property


	Private _amSubj As String
	Public Property amSubj() As String
		Get
			Return _amSubj
		End Get
		Set(ByVal value As String)
			_amSubj = value
		End Set
	End Property


	Private _amDate As Date
	Public Property amDate() As Date
		Get
			Return _amDate
		End Get
		Set(ByVal value As Date)
			_amDate = value
		End Set
	End Property


	Private _amMessage As String
	Public Property amMessage() As String
		Get
			Return _amMessage
		End Get
		Set(ByVal value As String)
			_amMessage = value
		End Set
	End Property


	Private _amNew As Boolean
	Public Property amNew() As Boolean
		Get
			Return _amNew
		End Get
		Set(ByVal value As Boolean)
			_amNew = value
		End Set
	End Property











End Class


Public Class clsAMfileName




	Private _userID As Integer
	Public Property UserID() As Integer
		Get
			Return _userID
		End Get
		Set(ByVal value As Integer)
			_userID = value
		End Set
	End Property


	Private _Date As Date
	Public Property SendDate() As Date
		Get
			Return _Date
		End Get
		Set(ByVal value As Date)
			_Date = value
		End Set
	End Property




	


End Class


Public Class TempDS



	Private _TheDataSet As DataSet
	Public Property TheDataSet() As DataSet
		Get
			Return _TheDataSet
		End Get
		Set(ByVal value As DataSet)
			_TheDataSet = value
		End Set
	End Property





End Class
