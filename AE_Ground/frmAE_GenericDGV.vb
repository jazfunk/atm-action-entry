Option Strict On
Option Explicit On

Imports System.IO
Imports System.Xml.Serialization
Imports System.Data.OleDb
Imports AE_Ground.clsAE_Utilities




Public Class frmAE_GenericDGV





	Public Sub New(ByVal dv As DataView)

		' This call is required by the Windows Form Designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.


		Me._data_View = dv


	End Sub


	Private _data_View As DataView
	Public Property Data_View() As DataView
		Get
			Return _data_View
		End Get
		Set(ByVal value As DataView)
			_data_View = value
		End Set
	End Property



	Private Sub frmAE_GenericDGV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

		Me.dgvGenericList.DataSource = Me.Data_View

	End Sub
End Class