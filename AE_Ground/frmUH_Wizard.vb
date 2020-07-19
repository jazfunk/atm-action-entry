Option Strict On
Option Explicit On

Imports System.Data.OleDb
Imports AE_Ground.clsAE_Utilities

Public Class frmUH_Wizard

	Private _JobNumber As String
	Private _JobDescription As String
	Private _StationNumber As String
	Private _PhysicalStation As String
	Private _IncidentTime As Date
	Private _UtyType As String
	Private _Responder As String
	Private _Inspector As String
	Private _Witnesses As String
	Private _iNotes As String
	Private _WasUtyStaked As Boolean
	Private _WasOthersStaked As Boolean
	Private _WhatOtherUtyStaked As String

#Region "Properties"


	Public Property JobNumber() As String
		Get
			Return _JobNumber
		End Get
		Set(ByVal value As String)
			_JobNumber = value
		End Set
	End Property


	Public Property JobDescription() As String
		Get
			Return _JobDescription
		End Get
		Set(ByVal value As String)
			_JobDescription = value
		End Set
	End Property

	Public Property StationNumber() As String
		Get
			Return _StationNumber
		End Get
		Set(ByVal value As String)
			_StationNumber = value
		End Set
	End Property
	Public Property PhysicalLocation() As String
		Get
			Return _PhysicalStation
		End Get
		Set(ByVal value As String)
			_PhysicalStation = value
		End Set
	End Property
	Public Property IncidentTime() As Date
		Get
			Return _IncidentTime
		End Get
		Set(ByVal value As Date)
			_IncidentTime = value
		End Set
	End Property
	Public Property UtyType() As String
		Get
			Return _UtyType
		End Get
		Set(ByVal value As String)
			_UtyType = value
		End Set
	End Property
	Public Property WasUtyStaked() As Boolean
		Get
			Return _WasUtyStaked
		End Get
		Set(ByVal value As Boolean)
			_WasUtyStaked = value
		End Set
	End Property
	Public Property WasOthersStaked() As Boolean
		Get
			Return _WasOthersStaked
		End Get
		Set(ByVal value As Boolean)
			_WasOthersStaked = value
		End Set
	End Property
	Public Property WhatOtherUtyStaked() As String
		Get
			Return _WhatOtherUtyStaked
		End Get
		Set(ByVal value As String)
			_WhatOtherUtyStaked = value
		End Set
	End Property
	Public Property Responder() As String
		Get
			Return _Responder
		End Get
		Set(ByVal value As String)
			_Responder = value
		End Set
	End Property
	Public Property Inspector() As String
		Get
			Return _Inspector
		End Get
		Set(ByVal value As String)
			_Inspector = value
		End Set
	End Property
	Public Property Witnesses() As String
		Get
			Return _Witnesses
		End Get
		Set(ByVal value As String)
			_Witnesses = value
		End Set
	End Property
	Public Property iNotes() As String
		Get
			Return _iNotes
		End Get
		Set(ByVal value As String)
			_iNotes = value
		End Set
	End Property
#End Region

	Public Sub New(ByVal jn As String, ByVal jd As String)

		' This call is required by the Windows Form Designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

		Me.JobNumber = jn
		Me.JobDescription = jd

	End Sub

	'Cancel buttons

	Private Sub wzdUH_IncidentNotes_CancelButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles wzdUH_IncidentNotes.CancelButtonClick
		Me.Close()
	End Sub

	Private Sub wzdUH_Inspector_CancelButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles wzdUH_Inspector.CancelButtonClick
		Me.Close()
	End Sub

	Private Sub wzdUH_JobNumber_CancelButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles wzdUH_JobNumber.CancelButtonClick
		Me.Close()
	End Sub

	Private Sub wzdUH_OtherStaked_CancelButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles wzdUH_OtherStaked.CancelButtonClick
		Me.Close()
	End Sub

	Private Sub wzdUH_PicUpload_CancelButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles wzdUH_PicUpload.CancelButtonClick
		Me.Close()
	End Sub

	Private Sub wzdUH_Responder_CancelButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles wzdUH_Responder.CancelButtonClick
		Me.Close()
	End Sub

	Private Sub wzdUH_StationNumber_CancelButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles wzdUH_StationNumber.CancelButtonClick
		Me.Close()
	End Sub

	Private Sub wzdUH_Time_CancelButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles wzdUH_Time.CancelButtonClick
		Me.Close()
	End Sub

	Private Sub wzdUH_UtilityType_CancelButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles wzdUH_UtilityType.CancelButtonClick
		Me.Close()
	End Sub

	Private Sub wzdUH_Witnesses_CancelButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles wzdUH_Witnesses.CancelButtonClick
		Me.Close()
	End Sub

	'End Cancel Buttons

	Private Sub BuildString(ByVal sender As Object, ByVal e As ActiproSoftware.Wizard.WizardPageCancelEventArgs) Handles wzdUH_JobNumber.NextButtonClick, _
	 wzdUH_StationNumber.NextButtonClick, _
	 wzdUH_Time.NextButtonClick, _
	 wzdUH_UtilityType.NextButtonClick, _
	 wzdUH_OtherStaked.NextButtonClick, _
	 wzdUH_Responder.NextButtonClick, _
	 wzdUH_Inspector.NextButtonClick, _
	 wzdUH_Witnesses.NextButtonClick, _
	 wzdUH_IncidentNotes.NextButtonClick, _
	 wzdUH_PicUpload.NextButtonClick

		Dim wBname As String = CType(sender, ActiproSoftware.Wizard.WizardPage).Name
		Dim BuildStr As String = Nothing

		Select Case wBname

			Case "wzdUH_JobNumber"
				Me.JobNumber = lblJobNumber.Text
				BuildStr = lblJobNumber.Text

			Case "wzdUH_StationNumber"
				Me.StationNumber = cmbStationNumber.Text
				Me.PhysicalLocation = rtxtPhysicalLocation.Text
				BuildStr = lblJobNumber.Text & "/" & cmbStationNumber.Text
				If Me.PhysicalLocation = Nothing Then
					MessageBox.Show("No Physical Location Entered.")
					e.Cancel = True
					rtxtPhysicalLocation.Text = "N/A"
				End If
				'Fill the picture box with sign image

			Case "wzdUH_Time"
				Me.IncidentTime = Me.dtpIncident.Value
				BuildStr = lblJobNumber.Text & "/" & cmbStationNumber.Text

			Case "wzdUH_UtilityType"
				'Do something with the radio buttons in the utility staked and utilites group box
				'Add utility Type to the build Str?

				If rBtnElectric.Checked = True Then
					UtyType = "Electric"
				ElseIf rbtnGas.Checked = True Then
					UtyType = "Gas"
				ElseIf rbtnCable.Checked = True Then
					UtyType = "Cable"
				ElseIf rbtnPhone.Checked = True Then
					UtyType = "Phone"
				ElseIf rbtnFiber.Checked = True Then
					UtyType = "Fiber"
				ElseIf rbtnWater.Checked = True Then
					UtyType = "Water"
				ElseIf rbtnSewer.Checked = True Then
					UtyType = "Sewer"
				ElseIf rbtnMits.Checked = True Then
					UtyType = "Mits"
				ElseIf rbtnFreewayLighting.Checked = True Then
					UtyType = "Freeway Lighting"
				ElseIf rbtnOther.Checked = True Then
					UtyType = "Other"
				Else
					UtyType = "Other"
				End If

				If rbtnStakedYes.Checked = True Then
					WasUtyStaked = True
				ElseIf rbtnStakedNo.Checked = True Then
					WasUtyStaked = False
				End If

				BuildStr = lblJobNumber.Text & "/" & cmbStationNumber.Text & "/" & UtyType

			Case "wzdUH_OtherStaked"
				Dim OtherStakedUtyStringBuilder As New System.Text.StringBuilder

				For Each c As Control In Me.gpbOtherStaked.Controls
					If TypeOf c Is CheckBox Then
						If TryCast(c, CheckBox).Checked Then
							OtherStakedUtyStringBuilder.Append(c.Text & "_")
						End If
					End If

				Next
				If OtherStakedUtyStringBuilder.ToString = Nothing Then
					Me.WhatOtherUtyStaked = "None"
				Else
					Me.WhatOtherUtyStaked = OtherStakedUtyStringBuilder.ToString
				End If


				'' This messageBox.show method does say what the message is.
				'' 6.16.11 jk 
				'Dim Astr As String = OtherStakedUtyStringBuilder.ToString
				'MessageBox.Show(Astr)


				BuildStr = lblJobNumber.Text & "/" & cmbStationNumber.Text & "/" & UtyType

			Case "wzdUH_Responder"
				Me.Responder = rtxtResponder.Text
				If Me.Responder = Nothing Then
					MessageBox.Show("No responder reported.")
					e.Cancel = True
					rtxtResponder.Text = "N/A"
				End If
				BuildStr = lblJobNumber.Text & "/" & cmbStationNumber.Text & "/" & UtyType

			Case "wzdUH_Inspector"

				Me.Inspector = rtxtInspector.Text
				If rtxtInspector.Enabled = True And Me.Inspector = Nothing Then
					MessageBox.Show("Enter inspector information.")
					e.Cancel = True
					rtxtInspector.Text = "N/A"
				End If
				BuildStr = lblJobNumber.Text & "/" & cmbStationNumber.Text & "/" & UtyType


			Case "wzdUH_Witnesses"
				Me.Witnesses = rtxtWitnesses.Text
				BuildStr = lblJobNumber.Text & "/" & cmbStationNumber.Text & "/" & UtyType
				If Me.Witnesses = Nothing Then
					MessageBox.Show("You entered no witnesses to the issue.")
					e.Cancel = True
					rtxtWitnesses.Text = "N/A"
				End If
			Case "wzdUH_IncidentNotes"
				Dim astr As String = Nothing
				For i As Integer = 0 To lstTimeLineEvents.Items.Count - 1
					If astr = Nothing Then
						astr = lstTimeLineEvents.Items.Item(i).ToString
					Else
						astr += "," & lstTimeLineEvents.Items.Item(i).ToString
					End If
				Next

				Me.iNotes = astr
				If Me.iNotes = Nothing Then
					MessageBox.Show("You didn't enter the list of events.")
					e.Cancel = True
				End If
				BuildStr = lblJobNumber.Text & "/" & cmbStationNumber.Text & "/" & UtyType

			Case "wzdUH_PicUpload"
				BuildStr = lblJobNumber.Text & "/" & cmbStationNumber.Text & "/" & UtyType

		End Select

		lblString1.Text = BuildStr
		lblString2.Text = BuildStr
		lblString3.Text = BuildStr
		lblString4.Text = BuildStr
		lblString5.Text = BuildStr
		lblString6.Text = BuildStr
		lblString7.Text = BuildStr
		lblString8.Text = BuildStr
		lblString9.Text = BuildStr

	End Sub

	Private Sub rbtnOtherUtilitiesYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnOtherUtilitiesYes.CheckedChanged
		If rbtnOtherUtilitiesYes.Checked Then
			gpbOtherStaked.Enabled = True
		ElseIf rbtnOtherUtilitiesNo.Checked Then
			gpbOtherStaked.Enabled = False
		End If
	End Sub

	Private Sub rbtnInspectorYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnInspectorYes.CheckedChanged
		If rbtnInspectorYes.Checked = True Then
			rtxtInspector.Enabled = True
		ElseIf rbtnInspectorNo.Checked = True Then
			rtxtInspector.Enabled = False
		End If
	End Sub

	Private Sub btnTransferImages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransferImages.Click
		btnTransferImages.Enabled = False
		lblProcessing.Visible = True
		Dim i As Integer = findDrives()
		Dim numProcessed As Integer
		lblNumProcessed.Visible = False

		If i = 1 Then
			Dim filePath As String = lstDrives.Items(0).ToString
			processDirectory(filePath, numProcessed)

		ElseIf i = 0 Then
			lblNumProcessed.Text = "There are zero removable drives to use."
		ElseIf i > 1 Then
			lblNumProcessed.Text = "There are more than one removable disk. Please remove unecessary disks."
		End If
		lblNumProcessed.Visible = True
		btnTransferImages.Enabled = False
		lblProcessing.Visible = False
		lblNumProcessed.Text = "Number of images processed: " & numProcessed.ToString
	End Sub

	Function findDrives() As Integer
		Dim x As Integer = 0
		For Each drive As System.IO.DriveInfo In My.Computer.FileSystem.Drives
			If drive.DriveType = 2 Then
				lstDrives.Items.Add(drive.Name)
				x = x + 1
			End If
		Next
		Return x
	End Function

	Private Sub processDirectory(ByVal targetDirectory As String, ByRef numProcessed As Integer)
		Try
			Dim fileEntries As String() = System.IO.Directory.GetFiles(targetDirectory)
			Dim count As Integer = 0
			' Process the list of files found in the directory.
			Dim fileName As String

			For Each fileName In fileEntries
				processFile(fileName)
				count = count + 1
			Next fileName

			Dim subdirectoryEntries As String() = System.IO.Directory.GetDirectories(targetDirectory)
			' Recurse into subdirectories of this directory.
			Dim subdirectory As String

			For Each subdirectory In subdirectoryEntries
				processDirectory(subdirectory, numProcessed)
			Next subdirectory
			numProcessed += count

		Catch ex As Exception
			MessageBox.Show("Target directory does not hold a file.", "processDirectory(targetDirectory)")
		End Try



	End Sub	'ProcessDirectory

	Private Sub processFile(ByVal filePath As String)
		Try
			Dim folderDate As String = Now.ToString("MM-dd-yyyy")
			If Not filePath = Nothing Then
				'Dim dirFile As String = IO.Path.GetFileName(filePath)
				Dim ext As String = IO.Path.GetExtension(filePath)
				If ext = ".jpg" Or ext = ".png" Or ext = ".gif" Or ext = ".bmp" Or ext = ".JPG" Or ext = ".PNG" Or ext = ".GIF" Or ext = ".BMP" Then
					My.Computer.FileSystem.MoveFile(filePath, My.Settings.ae_TransferImagePath & _
					"pic_" & _
					folderDate & "\" & _
					"uh_" & _
					 My.Settings.ae_UserID & "_" & _
					 My.Settings.ae_CurrentJob & "_" & _
					 Me.StationNumber & _
					 "_" & _
					 Now.ToString("MM-dd-yyyy_hh.mm.ss.ff_tt") & ext)

				End If

			End If
		Catch ex As Exception
			MessageBox.Show(ex.Message, "FillImageList")
		End Try

	End Sub

	Private Sub frmUH_Wizard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

		Me.lblJobNumber.Text = Me.JobNumber
		Me.lblJobDescription.Text = Me.JobDescription
		Me.SiteListTableAdapter.Fill(Me.ActionEntryDataSet.SiteListTableAdapter, Me.JobNumber)
		'Try

		'Catch ex As Exception
		'	MessageBox.Show(ex.Message)
		'End Try




	End Sub

	Private Sub btnAddTimeLineEvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddTimeLineEvent.Click
		Try
			Dim currentIndex As Integer = 0
			If Integer.TryParse(Me.rtxtIncidentNotes.Text.Substring(0, 1), currentIndex) Then
				Me.lstTimeLineEvents.Items.Item(currentIndex - 1) = Me.rtxtIncidentNotes.Text
			Else
				Dim x As Integer = Me.lstTimeLineEvents.Items.Count
				Me.lstTimeLineEvents.Items.Add((x + 1).ToString & ".  " & Me.rtxtIncidentNotes.Text)

				Me.rtxtIncidentNotes.Clear()
				Me.rtxtIncidentNotes.SelectAll()

			End If

			rtxtIncidentNotes.Focus()

		Catch ex As Exception
			MessageBox.Show(ex.Message, "btnAddTimeLineEvent_Click()")

		End Try
	End Sub

	Private Sub lstTimeLineEvents_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstTimeLineEvents.DoubleClick
		Dim x As Integer = Me.lstTimeLineEvents.SelectedIndex
		Dim strArray() As String = Me.lstTimeLineEvents.SelectedItem.ToString.Split(New Char() {" "c})
		Dim strCount As Integer = Me.lstTimeLineEvents.SelectedItem.ToString.IndexOf(" ")
		Dim subStr As String = Me.lstTimeLineEvents.SelectedItem.ToString.Substring(strCount)

		Dim inputStr As String = InputBox("Enter the Event", "Modify Event", subStr)

		If Not inputStr = "" Then
			Me.lstTimeLineEvents.Items(x) = strArray(0) & " " & inputStr
		Else
			Me.lstTimeLineEvents.Items(x) = strArray(0) & subStr
		End If

	End Sub

	Private Sub wzdUH_Welcome_CancelButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles wzdUH_Welcome.CancelButtonClick
		Me.Close()
	End Sub

	Private Sub wzdUH_CancelButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles wzdUH.CancelButtonClick
		Me.Close()
	End Sub

	Private Sub wzdUH_FinishButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles wzdUH.FinishButtonClick

		'Create the filname for the utility hit xml file
		Dim fileName As String = BuildXmlName("uh", Me.JobNumber, Me.StationNumber, Now.ToString("MM-dd-yyyy hh.mm.ss tt"))

		'Create the new row
		Dim newRow As DataRow = Me.TimeReporting.Tables("atmUhDT").NewRow

		'Add some data to it
		newRow("JobNumber") = Me.JobNumber
		newRow("Site") = Me.StationNumber
		newRow("PhysicalLocation") = Me.PhysicalLocation
		newRow("Time") = Me.IncidentTime.ToString
		newRow("UtyType") = Me.UtyType
		newRow("WasItStaked") = Me.WasUtyStaked
		newRow("WhatOtherUtyStaked") = Me.WasOthersStaked
		newRow("Responder") = Me.Responder
		newRow("Inspector") = Me.Inspector
		newRow("Witnesses") = Me.Witnesses
		newRow("IncidentNotes") = Me.iNotes


		'Add it to the table
		Me.TimeReporting.Tables("atmUhDT").Rows.Add(newRow)

		'Write the xml file
		WriteDataSync(Me.TimeReporting.Tables("atmUhDT"), fileName)




		'Dim settings As New System.Xml.XmlWriterSettings()
		'settings.Indent = True


		'Using writer As System.Xml.XmlWriter = System.Xml.XmlWriter.Create(My.Settings.ae_DataSyncPath & "uh_" & _
		'																   My.Settings.ae_UserID & "_" & _
		'																   Me.JobNumber & "_" & _
		'																   Me.StationNumber & "_" & _
		'																   Now.ToString("MM-dd-yyyy_hh.mm.ss_tt") & _
		'																	".xml", settings)

		'	writer.WriteStartDocument()
		'	writer.WriteStartElement("UtilityHit")

		'	writer.WriteElementString("JobNumber", Me.JobNumber)
		'	writer.WriteElementString("Site", Me.StationNumber)
		'	writer.WriteElementString("PhysicalLocation", Me.PhysicalLocation)
		'	writer.WriteElementString("Time", Me.IncidentTime.ToString)
		'	writer.WriteElementString("UtyType", Me.UtyType)
		'	writer.WriteElementString("WasItStaked", Me.WasUtyStaked.ToString)
		'	writer.WriteElementString("WhatOtherUtyStaked", Me.WhatOtherUtyStaked)
		'	writer.WriteElementString("Responder", Me.Responder)
		'	writer.WriteElementString("Inspector", Me.Inspector)
		'	writer.WriteElementString("Witnesses", Me.Witnesses)
		'	writer.WriteElementString("IncidentNotes", Me.iNotes)

		'	writer.WriteEndElement()
		'	writer.WriteEndDocument()

		'End Using

		Me.Close()

	End Sub

End Class