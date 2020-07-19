Public Class Form1

    Private Sub btnUploadImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUploadImage.Click
        Dim filePath As String
        Dim dt As New DataTable("Production")

        'Dim workCol As DataColumn

        'workCol = dt.Columns.Add("JobNum", Type.GetType("System.String"))
        'workCol.AllowDBNull = False
        'workCol = dt.Columns.Add("site", Type.GetType("System.String"))
        'workCol.AllowDBNull = False
        'workCol = dt.Columns.Add("dpID", Type.GetType("System.Int64"))
        'workCol.AllowDBNull = True
        'workCol = dt.Columns.Add("payItem", Type.GetType("System.Int64"))
        'workCol.AllowDBNull = True
        'workCol = dt.Columns.Add("dpQty", Type.GetType("System.Double"))
        'workCol.AllowDBNull = True
        'workCol = dt.Columns.Add("cQty", Type.GetType("System.Double"))
        'workCol.AllowDBNull = True
        'workCol = dt.Columns.Add("signCode", Type.GetType("System.String"))
        'workCol.AllowDBNull = True
        'workCol = dt.Columns.Add("signWidth", Type.GetType("System.Double"))
        'workCol.AllowDBNull = True
        'workCol = dt.Columns.Add("signHeight", Type.GetType("System.Double"))
        'workCol.AllowDBNull = True
        'workCol = dt.Columns.Add("sptQty", Type.GetType("System.Double"))
        'workCol.AllowDBNull = True
        'workCol = dt.Columns.ADD("SiteNotes", Type.GetType("System.String"))
        'workCol.AllowDBNull = True
        'workCol = dt.Columns.Add("forman", Type.GetType("System.String"))
        'workCol.AllowDBNull = True
        'workCol = dt.Columns.Add("entryDate", Type.GetType("System.String"))
        'workCol.AllowDBNull = True

        dt.Columns.Add("JobNum", Type.GetType("System.String"))
        dt.Columns.Add("Site", Type.GetType("System.String"))
        dt.Columns.Add("dpID", Type.GetType("System.String"))
        dt.Columns.Add("payItem", Type.GetType("System.String"))
        dt.Columns.Add("dpQty", Type.GetType("System.String"))
        dt.Columns.Add("CQty", Type.GetType("System.String"))
        dt.Columns.Add("signCode", Type.GetType("System.String"))
        dt.Columns.Add("signWidth", Type.GetType("System.String"))
        dt.Columns.Add("signHeight", Type.GetType("System.String"))
        dt.Columns.Add("sptQty", Type.GetType("System.String"))
        dt.Columns.Add("SiteNotes", Type.GetType("System.String"))
        dt.Columns.Add("foreman", Type.GetType("System.String"))
        dt.Columns.Add("entryDate", Type.GetType("System.String"))



        InitializeOpenFile()
        OpenFileDialog1.ShowDialog()
        filePath = OpenFileDialog1.FileName()


        If Not filePath Is Nothing Then 'if there is a file selected
            Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(filePath)
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters(",")
                Dim currentRow As String()
                While Not MyReader.EndOfData
                    Try
                        currentRow = MyReader.ReadFields() ' reads the entire record into string array
                        'ValidateData(currentRow)
                        dt.LoadDataRow(currentRow, True) ' loads the record into datatable

                    Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                        MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                    End Try
                End While
            End Using
            DataGridView1.DataSource = dt ' fills the datagridview with records from the datatable
        End If
    End Sub

    Private Sub InitializeOpenFile()
        With OpenFileDialog1
            .Multiselect = False
            .InitialDirectory = My.Settings.InitialPath
            .Title = "Open"
            .Filter = "*.txt|*.txt;*.xml|*.xml;*.csv|*.csv"
            .FileName = Nothing
        End With
    End Sub

    Private Sub ValidateData(ByVal currentRow As String())
        Dim aStr As String
        Dim aInt As Integer
        Dim adouble As Double

        Try
            aStr = currentRow(0).ToString
            currentRow(0) = aStr
        Catch ex As Exception
            currentRow(0) = Nothing
        End Try
        Try
            aStr = currentRow(1).ToString
            currentRow(1) = aStr
        Catch ex As Exception
            currentRow(1) = Nothing
        End Try
        Try
            aInt = CInt(currentRow(2))
            currentRow(2) = aInt
        Catch ex As Exception
            currentRow(2) = Nothing
        End Try
        Try
            aInt = CInt(currentRow(3))
            currentRow(3) = aInt
        Catch ex As Exception
            currentRow(3) = Nothing
        End Try
        Try
            adouble = CDbl(currentRow(4))
            currentRow(4) = adouble
        Catch ex As Exception
            currentRow(4) = Nothing
        End Try
        Try
            adouble = CDbl(currentRow(5))
            currentRow(5) = adouble
        Catch ex As Exception
            currentRow(5) = Nothing
        End Try
        Try
            aStr = currentRow(6).ToString
            currentRow(6) = aStr
        Catch ex As Exception
            currentRow(6) = Nothing
        End Try
        Try
            adouble = CDbl(currentRow(7))
            currentRow(7) = adouble
        Catch ex As Exception
            currentRow(7) = Nothing
        End Try
        Try
            adouble = CDbl(currentRow(8))
            currentRow(8) = adouble
        Catch ex As Exception
            currentRow(8) = Nothing
        End Try
        Try
            adouble = CDbl(currentRow(9))
            currentRow(9) = adouble
        Catch ex As Exception
            currentRow(9) = Nothing
        End Try
        Try
            aStr = currentRow(10).ToString
            currentRow(10) = aStr
        Catch ex As Exception
            currentRow(10) = Nothing
        End Try
        Try
            aStr = currentRow(11).ToString
            currentRow(11) = aStr
        Catch ex As Exception
            currentRow(11) = Nothing
        End Try
        'Try
        '    aStr = currentRow(12).ToString
        '    currentRow(12) = aStr
        'Catch ex As Exception
        '    currentRow(12) = Nothing
        'End Try
    End Sub
End Class
