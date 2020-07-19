Option Strict On
Option Explicit On


Imports System.IO
Imports System.Xml.Serialization
Imports System.Data.OleDb
Imports System.Text
Imports System.Net





Public Class clsAE_DailyProductions

	Public Sub New()



	End Sub

	' 0 - foreman		Integer
	' 1 - entryDate		Date/Time
	' 2 - displayName	String
	' 3 - ID			Integer
	' 4 - dpID			Integer
	' 5 - jobNum		String
	' 6 - site			String
	' 7 - payItemID		Integer
	' 8 - code			String
	' 9 - description	String
	'10 - dpQty			Double
	'11 - siteNotes		String


	Public Sub New(ByVal fID As Integer, _
		  ByVal eDate As Date, _
		  ByVal dName As String, _
		  ByVal aeID As Integer, _
		  ByVal atmID As integer, _
		  ByVal job As String, _
		  ByVal station As String, _
		  ByVal pID As Integer, _
		  ByVal pCode As String, _
		  ByVal pDesc As String, _
		  ByVal qty As Double, _
		  ByVal sNotes As String)


		Me._foreman = fID
		Me._entryDate = eDate
		Me._displayName = dName
		Me._ID = aeID
		Me._dpID = atmID
		Me._jobNum = job
		Me._site = station
		Me._payItemID = pID
		Me._code = pCode
		Me._description = pDesc
		Me._dpQty = qty
		Me._siteNotes = sNotes


	End Sub

#Region " Class-Level Declarations"


	Private _foreman As Integer
	Private _entryDate As Date
	Private _displayName As String
	Private _ID As Integer
	Private _dpID As Integer
	Private _jobNum As String
	Private _site As String
	Private _payItemID As Integer
	Private _code As String
	Private _description As String
	Private _dpQty As Double
	Private _siteNotes As String


#End Region



#Region " Properties"

	' 0 - foreman		Integer
	' 1 - entryDate		Date/Time
	' 2 - displayName	String
	' 3 - ID			Integer
	' 4 - dpID			Integer
	' 5 - jobNum		String
	' 6 - site			String
	' 7 - payItemID		Integer
	' 8 - code			String
	' 9 - description	String
	'10 - dpQty			Double
	'11 - siteNotes		String


	' 0
	Public Property Foreman() As Integer
		Get
			Return _foreman
		End Get
		Set(ByVal value As Integer)
			_foreman = value
		End Set
	End Property


	' 1
	Public Property EntryDate() As Date
		Get
			Return _entryDate
		End Get
		Set(ByVal value As Date)
			_entryDate = value
		End Set
	End Property


	' 2
	Public Property DisplayName() As String
		Get
			Return _displayName
		End Get
		Set(ByVal value As String)
			_displayName = value
		End Set
	End Property


	' 3
	Public Property ID() As Integer
		Get
			Return _ID
		End Get
		Set(ByVal value As Integer)
			_ID = value
		End Set
	End Property


	' 4
	Public Property dpID() As Integer
		Get
			Return _dpID
		End Get
		Set(ByVal value As Integer)
			_dpID = value
		End Set
	End Property


	' 5
	Public Property jobNum() As String
		Get
			Return _jobNum
		End Get
		Set(ByVal value As String)
			_jobNum = value
		End Set
	End Property


	' 6
	Public Property Site() As String
		Get
			Return _site
		End Get
		Set(ByVal value As String)
			_site = value
		End Set
	End Property


	' 7
	Public Property PayItemID() As Integer
		Get
			Return _payItemID
		End Get
		Set(ByVal value As Integer)
			_payItemID = value
		End Set
	End Property


	' 8
	Public Property Code() As String
		Get
			Return _code
		End Get
		Set(ByVal value As String)
			_code = value
		End Set
	End Property


	' 9
	Public Property Description() As String
		Get
			Return _description
		End Get
		Set(ByVal value As String)
			_description = value
		End Set
	End Property


	' 10
	Public Property DpQty() As Double
		Get
			Return _dpQty
		End Get
		Set(ByVal value As Double)
			_dpQty = value
		End Set
	End Property


	' 11
	Public Property SiteNotes() As String
		Get
			Return _siteNotes
		End Get
		Set(ByVal value As String)
			_siteNotes = value
		End Set
	End Property




#End Region













End Class
