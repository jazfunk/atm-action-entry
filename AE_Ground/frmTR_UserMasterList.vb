Option Strict On
Option Explicit On

Imports System.IO
Imports System.Xml.Serialization
Imports System.Data
Imports System.Data.OleDb
Imports AE_Ground.clsAE_Utilities
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Net






Public Class frmTR_UserMasterList




#Region " Class-Level Declarations"




#End Region




#Region " Database Communications"




#End Region




#Region " Properties"



#End Region







#Region " Methods & Functions"




#End Region




#Region " Event Handlers"




#End Region




#Region " Unused/Junk/Misc"




#End Region













End Class






Public Class clsUser

	Public Sub New()



	End Sub


	Public Sub New(ByVal isSelected As Boolean, _
		  ByVal userID As Integer, _
		  ByVal userName As String)


		Me._userSelected = isSelected
		Me._userID = userID
		Me._userName = userName

	End Sub



	Private _userSelected As Boolean
	Public Property UserSelected() As Boolean
		Get
			Return _userSelected
		End Get
		Set(ByVal value As Boolean)
			_userSelected = value
		End Set
	End Property


	Private _userID As Integer
	Public Property UserID() As Integer
		Get
			Return _userID
		End Get
		Set(ByVal value As Integer)
			_userID = value
		End Set
	End Property


	Private _userName As String
	Public Property UserName() As String
		Get
			Return _userName
		End Get
		Set(ByVal value As String)
			_userName = value
		End Set
	End Property






End Class