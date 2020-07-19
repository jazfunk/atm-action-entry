Option Strict On
Option Explicit On

Imports System.IO
Imports System.Xml.Serialization
Imports System.Data.OleDb
Imports AE_Ground.clsAE_Utilities



Public Class Form1

	Public prevSite As String

	Private latitude As Double = 0
	Private longitude As Double = 0


	Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

		btn_ShowMap.Enabled = False







		'Me.PropertyGrid1.SelectedObject = My.Settings


		'Dim set1 As New DataSet()

		'' Some xml data to populate the DataSet with.
		'Dim musicXml As String = "<?xml version='1.0' encoding='UTF-8'?>" & _
		' "<music>" & _
		' "<recording><artist>Coldplay</artist><cd>X&amp;Y</cd></recording>" & _
		' "<recording><artist>Dave Matthews</artist><cd>Under the Table and Dreaming</cd></recording>" & _
		' "<recording><artist>Dave Matthews</artist><cd>Live at Red Rocks</cd></recording>" & _
		' "<recording><artist>Natalie Merchant</artist><cd>Tigerlily</cd></recording>" & _
		' "<recording><artist>U2</artist><cd>How to Dismantle an Atomic Bomb</cd></recording>" & _
		' "</music>"

		'' Read the xml.
		'Dim reader As New StringReader(musicXml)
		'set1.ReadXml(reader)

		'' Get a DataView of the table contained in the dataset.
		'Dim tables As DataTableCollection = set1.Tables
		'Dim view1 As New DataView(tables(0))

		'' Create a DataGridView control and add it to the form.
		'Dim datagridview1 As New DataGridView()
		'datagridview1.AutoGenerateColumns = True
		'Me.Controls.Add(datagridview1)

		'' Create a BindingSource and set its DataSource property to
		'' the DataView.
		'Dim source1 As New BindingSource()
		'source1.DataSource = view1

		'' Set the data source for the DataGridView.
		'datagridview1.DataSource = source1

		' '' The Filter string can include Boolean expressions.
		''source1.Filter = "artist = 'Dave Matthews' OR cd = 'Tigerlily'"



	End Sub

	Dim googleQuery As String

	Private Sub TextBoxes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
	   Handles tb_Latitude.TextChanged, tb_Longitude.TextChanged

		If tb_Latitude.Text.Trim <> "" AndAlso tb_Longitude.Text.Trim <> "" Then
			btn_ShowMap.Enabled = True
			'googleQuery = _
			'  "http://maps.google.com/maps?q=" & latitude.ToString & "%2C" & longitude.ToString
		Else
			btn_ShowMap.Enabled = False
		End If

	End Sub

	Private Sub tb_Latitude_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_Latitude.Leave

		If Not Double.TryParse(tb_Latitude.Text, latitude) Then
			MessageBox.Show("The entry for latitude is invalid. Please re-enter", _
							"Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)

			With tb_Latitude
				.SelectAll()
				.Focus()
			End With

			btn_ShowMap.Enabled = False
		End If

	End Sub

	Private Sub tb_Longitude_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_Longitude.Leave

		If Not Double.TryParse(tb_Longitude.Text, longitude) Then
			MessageBox.Show("The entry for longitude is invalid. Please re-enter", _
							"Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)

			With tb_Longitude
				.SelectAll()
				.Focus()
			End With

			btn_ShowMap.Enabled = False
		End If

	End Sub

	Private Sub btn_ShowMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ShowMap.Click

		googleQuery = _
		"http://maps.google.com/maps?q=" & latitude.ToString & "%2C" & longitude.ToString

		Try
			Me.LinkLabel1.Text = googleQuery
			'WebBrowser1.Navigate(googleQuery)



		Catch ex As Exception
			MessageBox.Show("An error occured:" & vbCrLf & vbCrLf & ex.Message, _
				"Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try

	End Sub


	
	
	Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
		WebBrowser1.Navigate(Me.txtURL.Text)

	End Sub

	Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
		WebBrowser1.Stop()

	End Sub

	Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
		WebBrowser1.Refresh()

	End Sub

	Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
		WebBrowser1.GoForward()

	End Sub

	Private Sub btnForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForward.Click
		WebBrowser1.GoBack()

	End Sub

	Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
		Me.txtURL.Text = WebBrowser1.Url.ToString
		Me.Text = WebBrowser1.DocumentTitle & " | ActionEntry"

	End Sub

	Private Sub WebBrowser1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged
		ProgressBar1.Maximum = CInt(e.MaximumProgress)
		ProgressBar1.Value = CInt(e.CurrentProgress)
		Me.StatusText.Text = WebBrowser1.StatusText



	End Sub

	Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

		System.Diagnostics.Process.Start(Me.LinkLabel1.Text)
	End Sub
End Class
