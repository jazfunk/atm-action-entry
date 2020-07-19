Imports System.Windows.Forms

Public Class frmAdjustQtyDialog

	Dim _PayItemCode As String
	Dim _PayItemDescription As String

	Public Sub New(ByVal inputValue As Double, ByVal pI As String, ByVal pD As String)

		InitializeComponent()

		If Not inputValue = Nothing Then
			Try
				Dim c As Decimal = CDec(inputValue)
				nudQty.Value = c

				Me._PayItemCode = pI
				Me._PayItemDescription = pD

			Catch ex As Exception
				nudQty.Value = 0
				Me._PayItemCode = "Unknown"
				Me._PayItemDescription = "Unknown"
			End Try
		End If
	End Sub

	Public ReadOnly Property ReturnQty() As Double
		Get
			Dim i As Double = CDbl(nudQty.Value)
			Return i
		End Get
	End Property

	Public Property PayItemCode() As String
		Get
			Return _PayItemCode
		End Get
		Set(ByVal value As String)
			_PayItemCode = value
		End Set
	End Property

	Public Property PayItemDescription() As String
		Get
			Return _PayItemDescription
		End Get
		Set(ByVal value As String)
			_PayItemDescription = value
		End Set
	End Property



	Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
		Me.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.Close()
	End Sub

	Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
		Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Close()
	End Sub

	Private Sub frmAdjustQtyDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		'***********************************************************************
		'Purpose: To determine min, max, increment
		'input: sCode
		'output: min, max, increment of frmAdjustQtyDialog
		'issues: using decimal for increment
		'       - still need to figure out what to do for the rest of the pay items. 
		'************************************************************************

		Me.lblPayItemDescription.Text = Me.PayItemDescription

		Select Case PayItemCode

			Case "8100200"	'Type I Removal

				'nudQty.Minimum = 1
				'nudQty.Maximum = 5
				'nudQty.Increment = 1

			Case "8100201"	'Type II Removal

				'nudQty.Minimum = 1
				'nudQty.Maximum = 15
				'nudQty.Increment = 1

			Case "8100202" 'Type III Removal

				'nudQty.Minimum = 1
				'nudQty.Maximum = 15
				'nudQty.Increment = 1

			Case "8100165fdn", "8100166fdn", "8100170fdn", "8100171fdn"	' NonPayItems (currently only w/p fdn's)

				'nudQty.Minimum = 0
				'nudQty.Maximum = 100
				'nudQty.Increment = 1

			Case Else

				'nudQty.Minimum = 1
				'nudQty.Maximum = 100
				'nudQty.Increment = 1	'D allows you to use decimal - w/o you can only use integers

		End Select
	End Sub
End Class
