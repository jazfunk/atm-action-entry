Option Strict On
Option Explicit On

Imports System.IO
Imports System.Xml.Serialization
Imports System.Data.OleDb
Imports AE_Ground.clsAE_Utilities
Imports System.Text.RegularExpressions


Public Class frmEmailShelia





	Private Sub frmEmailShelia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Me.TextBox1.Text = My.Settings.ae_DisplayName & " - AE Message"

	End Sub

	Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

		If Not (Me.TextBox2.Text Is Nothing) Then
			SendEmailToShelia(Me.TextBox1.Text, Me.TextBox2.Text)
			Me.Close()
		Else
			MessageBox.Show("Cannot send an empty message.")
		End If




	End Sub
End Class