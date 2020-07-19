Option Strict On
Option Explicit On

Imports System.IO
Imports System.Xml.Serialization
Imports System.Data.OleDb
Imports AE_Ground.clsAE_Utilities





Public Class frmAE_InputBox




#Region " Initialization"

	Public Sub New()

		' This call is required by the Windows Form Designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

	End Sub

	Public Sub New(ByVal originalNote As String)

		' This call is required by the Windows Form Designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		Me.OrigNote = originalNote
		Me.txtNotes.Text = Me.OrigNote


		Me.txtNotes.Focus()


	End Sub

	Public Sub New(ByVal originalNote As String, ByVal displayName As String)

		' This call is required by the Windows Form Designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		Me.OrigNote = originalNote
		Me.DisplayName = displayName
		Me.txtNotes.Text = Me.OrigNote
		Me.Text = Me.Text & " - " & Me.DisplayName


	End Sub

#End Region


#Region " Database Communication"




#End Region


#Region " Properties"



	Private _origNote As String
	Public Property OrigNote() As String
		Get
			Return _origNote
		End Get
		Set(ByVal value As String)
			_origNote = value
		End Set
	End Property



	Private _newNote As String
	Public Property NewNote() As String
		Get
			Return _newNote
		End Get
		Set(ByVal value As String)
			_newNote = value
		End Set
	End Property


	Private _displayName As String
	Public Property DisplayName() As String
		Get
			Return _displayName
		End Get
		Set(ByVal value As String)
			_displayName = value
		End Set
	End Property





#End Region


#Region " Class-Level Declarations"




#End Region


#Region " Methods & Functions"




#End Region


#Region " Event Handlers"

	Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

		Me.NewNote = Me.txtNotes.Text
		Me.DialogResult = Windows.Forms.DialogResult.OK
		Me.Close()

	End Sub

	Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
		Me.DialogResult = Windows.Forms.DialogResult.Cancel
		Me.Close()

	End Sub

#End Region





End Class