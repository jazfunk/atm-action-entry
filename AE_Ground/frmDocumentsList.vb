Option Strict On
Option Explicit On

Imports System.IO
Imports System.Xml.Serialization
Imports System.Data.OleDb
Imports AE_Ground.clsAE_Utilities





Public Class frmDocumentsList






	Private Sub frmDocumentsList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

		' make a reference to a directory
		Dim di As New IO.DirectoryInfo(My.Settings.aeDocumentsPath)
		Dim diar1 As IO.FileInfo() = di.GetFiles()
		Dim dra As IO.FileInfo

		'list the names of all files in the specified directory
		For Each dra In diar1
			ListBox1.Items.Add(dra)
		Next

	End Sub



	Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
		Dim fullPath = Path.Combine((My.Settings.aeDocumentsPath), ListBox1.SelectedItem.ToString())
		System.Diagnostics.Process.Start(fullPath)
	End Sub
End Class