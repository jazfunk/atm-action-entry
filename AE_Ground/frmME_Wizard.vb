Option Strict On
Option Explicit On

Imports System.Data.OleDb


Public Class frmME_Wizard


	Private InventoryString As String

	' Declared for Property Values
	Private _Job As String
	Private _Station As String
	Private _pID As Integer
	Private _Qty As Double
	Private _LocationNotes As String
	Private _ME_Insert As Boolean

	Public Property JobNumber() As String
		Get
			Return _Job
		End Get
		Set(ByVal value As String)
			_Job = value
		End Set
	End Property

	Public Property StationNumber() As String
		Get
			Return _Station
		End Get
		Set(ByVal value As String)
			_Station = value
		End Set
	End Property

	Public Property PayItemID() As Integer
		Get
			Return _pID
		End Get
		Set(ByVal value As Integer)
			_pID = value
		End Set
	End Property

	Public Property EnteredQty() As Double
		Get
			Return _Qty
		End Get
		Set(ByVal value As Double)
			_Qty = value
		End Set
	End Property
	Public Property StationNotes() As String
		Get
			Return _LocationNotes
		End Get
		Set(ByVal value As String)
			_LocationNotes = value
		End Set
	End Property
	'Public Property ME_Insert() As Boolean
	'	Get
	'		Return _ME_Insert
	'	End Get
	'	Set(ByVal value As Boolean)
	'		_ME_Insert = value
	'	End Set
	'End Property





	Public Sub New()

		' This call is required by the Windows Form Designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

		'If Not My.Settings.ae_CurrentJob Is Nothing Then
		'	Me.JobNumber = My.Settings.ae_CurrentJob
		'End If

	End Sub

	Public Sub New(ByVal jn As String, ByVal jd As String)

		' This call is required by the Windows Form Designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

		Me.lblJobNum.Text = jn
		Me.lblJobDescription.Text = jd

		Me.QryPayItemsByJobTableAdapter.Fill(Me.ActionEntryDataSet.qryPayItemsByJob, jn)


	End Sub



	Private Sub BuildInventoryString(ByVal sender As Object, ByVal e As ActiproSoftware.Wizard.WizardPageCancelEventArgs) _
		Handles wzdME_JobNumber.NextButtonClick, _
		wzdME_Site.NextButtonClick, _
		wzdME_Items.NextButtonClick, _
		wzdME_Quantity.NextButtonClick, _
		wzdME_Notes.NextButtonClick 

		Dim wBname As String = CType(sender, ActiproSoftware.Wizard.WizardPage).Name

		Select Case wBname
			Case "wzdME_JobNumber"
				Me.JobNumber = Me.lblJobNum.Text
				InventoryString = Me.JobNumber
			Case "wzdME_Site"
				If Me.txtSetSite.Text = String.Empty Then
					e.Cancel = True
					MessageBox.Show("You must designate a valid station number.", "Invalid or No Station Number Entered")
				Else
					Me.StationNumber = Me.txtSetSite.Text
					Me.lblStation1.Text = Me.StationNumber
					Me.lblStation2.Text = Me.StationNumber
					InventoryString = String.Format("{0} / {1}", Me.JobNumber, Me.StationNumber)
				End If
			Case "wzdME_Items"
				Me.PayItemID = CInt(Me.cmbJobPayItems.SelectedValue)
				InventoryString = String.Format("{0} / {1} / {2}", Me.JobNumber, Me.StationNumber, Me.cmbJobPayItems.Text)
			Case "wzdME_Quantity"
				InventoryString &= InventoryString & " " & Me.lblUnitOfMeasure.Text
				Try
					Me.EnteredQty = CDbl(Me.txtME_PQty.Text)
					InventoryString = String.Format("{0} / {1} / {2} / {3}", Me.JobNumber, Me.StationNumber, Me.cmbJobPayItems.Text, Me.EnteredQty.ToString)
				Catch ex As Exception
					e.Cancel = True
					MessageBox.Show("You must enter a valid number for the item quantity", "Invalid Quantity Entered")
				End Try
			Case "wzdME_Notes"
				Me.StationNotes = Me.rtxtNotes.Text

		End Select

		'InventoryString = String.Format("{0} / {1} / {2} / {3}", Me.JobNumber, Me.StationNumber, Me.cmbJobPayItems.Text, Me.EnteredQty.ToString)

		Me.lblInventory1.Text = InventoryString
		Me.lblInventory2.Text = InventoryString
		Me.lblInventory3.Text = InventoryString
		Me.lblInventory4.Text = InventoryString
	End Sub

	Private Sub SubmitME(ByVal sender As Object, ByVal e As System.EventArgs) Handles wzdME_Finish.FinishButtonClick

		'Try
		'	Dim x As Integer = Me.TblDailyProductionsTableAdapter1.Insert(Me.JobNumber, _
		'	 Me.StationNumber, _
		'	 0, Me.PayItemID, _
		'	 Me.EnteredQty, _
		'	 0, _
		'	 Nothing, _
		'	 Nothing, _
		'	 Nothing, _
		'	 Me.StationNotes, _
		'	 My.Settings.ae_UserID, _
		'	 My.Settings.ae_WorkingDate, _
		'	 Nothing)

		'	'If x > 0 Then
		'	'	Me.ME_Insert = True
		'	'Else
		'	'	Me.ME_Insert = False
		'	'End If

		'	MessageBox.Show("Item Entered Successfully!")
		'Catch ex As Exception
		'	MessageBox.Show(ex.Message, "SubmitME")
		'End Try

		Me.DialogResult = Windows.Forms.DialogResult.OK



	End Sub


	
	Private Sub frmME_Wizard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

	End Sub
End Class