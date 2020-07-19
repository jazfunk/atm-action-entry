Option Strict On
Option Explicit On

Imports System.IO
Imports System.Xml.Serialization
Imports System.Data.OleDb
Imports AE_Ground.clsAE_Utilities


Public Class frmSearchSimple



	Public Sub New()

		InitializeComponent()



	End Sub


	Private _SearchPhrase As String
	Public Property SearchPhrase() As String
		Get
			Return _SearchPhrase
		End Get
		Set(ByVal value As String)
			_SearchPhrase = value
		End Set
	End Property


	Private _SearchOn As String
	Public Property SearchOn() As String
		Get
			Return _SearchOn
		End Get
		Set(ByVal value As String)
			_SearchOn = value
		End Set
	End Property






	Private Sub frmSearchSimple_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

	End Sub

	Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

		Me.SearchPhrase = Me.TextBox1.Text.Trim


	End Sub
End Class