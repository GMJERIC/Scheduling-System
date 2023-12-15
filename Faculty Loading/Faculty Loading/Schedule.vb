Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop.Excel
Imports Mysqlx
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Schedule
    Private myconnection As New connectiondb
    Dim dr As MySqlDataReader



    Private Sub Schedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        instructor()
        major()
        schoolyr()
        yearlvl()
        sem()

        Label4.Parent = PictureBox3
        Label4.BackColor = Color.Transparent
        Label5.Parent = PictureBox3
        Label5.BackColor = Color.Transparent
        Label6.Parent = PictureBox3
        Label6.BackColor = Color.Transparent


        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox3.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox4.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox5.DropDownStyle = ComboBoxStyle.DropDownList

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub





    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub







    Private Sub label3_Click(sender As Object, e As EventArgs) Handles label3.Click

    End Sub



    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub








    Private Sub instructor()
        myconnection.open()
        Try
            Using con As MySqlConnection = myconnection.con
                Dim query As String = "SELECT last_name, first_name FROM instructor ORDER BY last_name"

                Using cmd As New MySqlCommand(query, con)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()

                        If reader.HasRows Then
                            ComboBox1.Items.Clear()

                            While reader.Read()
                                Dim firstName As String = reader("last_name").ToString()
                                Dim lastName As String = reader("first_name").ToString()
                                Dim fullName As String = firstName & " " & lastName

                                ComboBox1.Items.Add(fullName)
                            End While
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub sem()
        myconnection.open()
        Try
            Using con As MySqlConnection = myconnection.con
                Dim query As String = "SELECT DISTINCT semester FROM subject"

                Using cmd As New MySqlCommand(query, con)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()

                        If reader.HasRows Then
                            ComboBox2.Items.Clear()

                            While reader.Read()
                                Dim semester As String = reader("semester").ToString()


                                ComboBox2.Items.Add(semester)
                            End While
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub schoolyr()
        myconnection.open()
        Try
            Using con As MySqlConnection = myconnection.con
                Dim query As String = "SELECT DISTINCT academicYr FROM subject"

                Using cmd As New MySqlCommand(query, con)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()

                        If reader.HasRows Then
                            ComboBox3.Items.Clear()

                            While reader.Read()
                                Dim academicYr As String = reader("academicYr").ToString()


                                ComboBox3.Items.Add(academicYr)
                            End While
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub yearlvl()
        myconnection.open()
        Try
            Using con As MySqlConnection = myconnection.con
                Dim query As String = "SELECT DISTINCT yrLvl FROM subject"

                Using cmd As New MySqlCommand(query, con)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()

                        If reader.HasRows Then
                            ComboBox5.Items.Clear()

                            While reader.Read()
                                Dim yrLvl As String = reader("yrLvl").ToString()


                                ComboBox5.Items.Add(yrLvl)
                            End While
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub



    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub


    Private Sub major()
        Try
            Using con As MySqlConnection = myconnection.con
                con.Open()
                Dim query As String = "SELECT DISTINCT course FROM course"

                Using cmd As New MySqlCommand(query, con)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            ComboBox4.Items.Clear()

                            While reader.Read()
                                Dim major As String = reader("course").ToString()
                                ComboBox4.Items.Add(major)
                            End While
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub LoadData()
        myconnection.open()
        Try
            DataGridView1.Rows.Clear()
            Using con As MySqlConnection = myconnection.con
                Using cmd As New MySqlCommand("SELECT * FROM subject ORDER BY subject_code", con)
                    Dim dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        DataGridView1.Rows.Add(dr("subject_code"), dr("subject_description"), dr("units"), dr("course"), dr("yrLvl"), dr("section"), dr("day"), dr("time"), dr("room"))
                    End While
                    dr.Close()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            myconnection.Close()
        End Try
    End Sub


    Dim totalUnits As Integer = 0

    Private disabledRows As New Dictionary(Of String, Boolean)

    Private Sub UpdateDataGridView()
        If ComboBox4.SelectedIndex <> -1 AndAlso ComboBox2.SelectedIndex <> -1 AndAlso ComboBox3.SelectedIndex <> -1 AndAlso ComboBox5.SelectedIndex <> -1 Then
            Try
                Dim selectedCourse As String = ComboBox4.SelectedItem.ToString()
                Dim selectedSemester As String = ComboBox2.SelectedItem.ToString()
                Dim selectedAcademicYr As String = ComboBox3.SelectedItem.ToString()
                Dim selectedYrLvl As String = ComboBox5.SelectedItem.ToString()

                Dim text1 As String = ComboBox1.Text
                Dim text2 As String = ComboBox2.Text
                Dim text3 As String = ComboBox3.Text

                Label6.Text = text1 & " Temporary Schedule " & text2 & " " & text3


                Using con As MySqlConnection = myconnection.con
                    con.Open()

                    Dim query As String = "SELECT subject_id, course, subject_code, subject_description, semester, units, yrLvl, section, day, time, room FROM subject " &
                                         "WHERE course = @course AND semester = @semester AND academicYr = @academicYr AND yrLvl = @yrLvl " &
                                         "ORDER BY subject_code"

                    Using cmd As New MySqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@course", selectedCourse)
                        cmd.Parameters.AddWithValue("@semester", selectedSemester)
                        cmd.Parameters.AddWithValue("@academicYr", selectedAcademicYr)
                        cmd.Parameters.AddWithValue("@yrLvl", selectedYrLvl)

                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            DataGridView1.Rows.Clear()

                            While reader.Read()
                                Dim subjectId As String = reader("subject_id").ToString()
                                Dim subjectCode As String = reader("subject_code").ToString()
                                Dim subjectDescription As String = reader("subject_description").ToString()
                                Dim units As String = reader("units").ToString()
                                Dim course As String = reader("course").ToString()
                                Dim year As String = reader("yrLvl").ToString()
                                Dim section As String = reader("section").ToString()
                                Dim day As String = reader("day").ToString()
                                Dim time As String = reader("time").ToString()
                                Dim room As String = reader("room").ToString()

                                DataGridView1.Rows.Add(subjectId, subjectCode, subjectDescription, units, course, year, section, day, time, room)


                                If Not disabledRows.ContainsKey(subjectId) Then
                                    disabledRows.Add(subjectId, False)
                                End If
                            End While
                        End Using
                    End Using
                End Using


                For Each row As DataGridViewRow In DataGridView1.Rows

                    Dim subjectId As String = If(row.Cells("Column11").Value IsNot Nothing, row.Cells("Column11").Value.ToString(), String.Empty)

                    If disabledRows.ContainsKey(subjectId) AndAlso disabledRows(subjectId) Then
                        row.ReadOnly = True
                        row.DefaultCellStyle.ForeColor = Color.Gray
                    Else
                        row.ReadOnly = False
                        row.DefaultCellStyle.ForeColor = Color.Black
                    End If
                Next
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.ColumnIndex = DataGridView1.Columns("Column1").Index AndAlso e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            Dim subjectId As String = selectedRow.Cells("Column11").Value.ToString()

            If Not disabledRows.ContainsKey(subjectId) OrElse Not disabledRows(subjectId) Then

                disabledRows(subjectId) = True
                selectedRow.ReadOnly = True
                selectedRow.DefaultCellStyle.ForeColor = Color.Gray

                Dim subjectCode As String = selectedRow.Cells("Column1").Value.ToString()
                Dim subjectDescription As String = selectedRow.Cells("Column2").Value.ToString()
                Dim units As Integer = Integer.Parse(selectedRow.Cells("Column3").Value.ToString())
                Dim subject As String = subjectCode & " - " & subjectDescription
                Dim crs As String = selectedRow.Cells("Column4").Value.ToString()
                Dim room As String = selectedRow.Cells("Column5").Value.ToString()
                Dim time As String = selectedRow.Cells("Column6").Value.ToString()
                Dim day As String = selectedRow.Cells("Column7").Value.ToString()
                Dim section As String = selectedRow.Cells("Column8").Value.ToString()
                Dim year As String = selectedRow.Cells("Column10").Value.ToString()
                Dim yrsc As String = year & " - " & section

                totalUnits += units
                Label5.Text = "Total Units: " & totalUnits.ToString()

                DataGridView2.Rows.Add(subjectId, "Delete", subject, units, crs, yrsc, day, time, room)
            End If
        End If
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        If e.ColumnIndex = DataGridView2.Columns("Columndel").Index AndAlso e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView2.Rows(e.RowIndex)
            Dim subjectId As String = selectedRow.Cells("Column12").Value.ToString()
            Dim unitsToRestore As Integer = Integer.Parse(selectedRow.Cells("Columnunits").Value.ToString())

            DataGridView2.Rows.RemoveAt(e.RowIndex)

            totalUnits -= unitsToRestore
            Label5.Text = "Total Units: " & totalUnits.ToString()

            If disabledRows.ContainsKey(subjectId) Then
                disabledRows(subjectId) = False
            End If


            UpdateDataGridView()
        End If
    End Sub


    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        UpdateDataGridView()
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        UpdateDataGridView()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        UpdateDataGridView()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        UpdateDataGridView()
    End Sub


    Private Sub ExportToExcelButton_Click(sender As Object, e As EventArgs) Handles ExportToExcelButton.Click
        ExportData()
    End Sub
    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click

        SaveDataToDatabase()
    End Sub


    Private Sub SaveDataToDatabase()
        Try
            Using con As MySqlConnection = myconnection.con
                con.Open()

                ' Save Instructor
                Dim selectedInstructor As String = ComboBox1.SelectedItem.ToString()
                Dim selectedSemester As String = ComboBox2.SelectedItem.ToString()
                Dim selectedSchoolYear As String = ComboBox3.SelectedItem.ToString()

                ' Save Subject Information
                For Each row As DataGridViewRow In DataGridView2.Rows
                    SaveSubjectToDatabase(con, selectedInstructor, selectedSemester, selectedSchoolYear, row)
                Next

                MessageBox.Show("Data saved successfully!")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving data: " & ex.Message)
        End Try
    End Sub

    Private Sub SaveSubjectToDatabase(con As MySqlConnection, fullName As String, semester As String, schoolYear As String, row As DataGridViewRow)
        Try
            Dim subjectCode As String = If(row.Cells("Columnsub").Value IsNot Nothing, row.Cells("Columnsub").Value.ToString(), String.Empty)
            Dim units As Integer = If(row.Cells("Columnunits").Value IsNot Nothing AndAlso Integer.TryParse(row.Cells("Columnunits").Value.ToString(), units), units, 0)
            Dim course As String = If(row.Cells("Columncourse").Value IsNot Nothing, row.Cells("Columncourse").Value.ToString(), String.Empty)
            Dim yearSection As String = If(row.Cells("Column9").Value IsNot Nothing, row.Cells("Column9").Value.ToString(), String.Empty)
            Dim day As String = If(row.Cells("Columnday").Value IsNot Nothing, row.Cells("Columnday").Value.ToString(), String.Empty)
            Dim time As String = If(row.Cells("Columntime").Value IsNot Nothing, row.Cells("Columntime").Value.ToString(), String.Empty)
            Dim room As String = If(row.Cells("Columnroom").Value IsNot Nothing, row.Cells("Columnroom").Value.ToString(), String.Empty)

            ' Save Subject Information along with Instructor, Semester, and School Year
            Dim subjectQuery As String = "INSERT INTO schedule (full_Name, semester, school_year, subject_code, units, course, year_section, day, time, room) VALUES (@fullName, @semester, @schoolYear, @subjectCode, @units, @course, @yearSection, @day, @time, @room)"

            Using cmdSubject As New MySqlCommand(subjectQuery, con)
                cmdSubject.Parameters.AddWithValue("@fullName", fullName)
                cmdSubject.Parameters.AddWithValue("@semester", semester)
                cmdSubject.Parameters.AddWithValue("@schoolYear", schoolYear)
                cmdSubject.Parameters.AddWithValue("@subjectCode", subjectCode)
                cmdSubject.Parameters.AddWithValue("@units", units)
                cmdSubject.Parameters.AddWithValue("@course", course)
                cmdSubject.Parameters.AddWithValue("@yearSection", yearSection)
                cmdSubject.Parameters.AddWithValue("@day", day)
                cmdSubject.Parameters.AddWithValue("@time", time)
                cmdSubject.Parameters.AddWithValue("@room", room)

                cmdSubject.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Throw New Exception("Error saving subject data: " & ex.Message)
        End Try
    End Sub










    Private Sub save()

        Dim excelApp As Microsoft.Office.Interop.Excel.Application = Nothing
        Dim excelWorkbook As Microsoft.Office.Interop.Excel.Workbook = Nothing
        Dim excelWorksheet As Microsoft.Office.Interop.Excel.Worksheet = Nothing

        Try

            excelApp = New Microsoft.Office.Interop.Excel.Application()
            excelApp.Visible = False
            excelWorkbook = excelApp.Workbooks.Add()
            excelWorksheet = TryCast(excelWorkbook.ActiveSheet, Microsoft.Office.Interop.Excel.Worksheet)



            Dim startTime As New TimeSpan(7, 30, 0)
            For timeIndex As Integer = 2 To 21
                Dim currentTime As TimeSpan = startTime.Add(New TimeSpan(0, 30 * (timeIndex - 1), 0))
                excelWorksheet.Cells(timeIndex, 1) = currentTime.ToString("hh\:mm")
                excelWorksheet.Cells(timeIndex, 2) = currentTime.Add(New TimeSpan(0, 30, 0)).ToString("hh\:mm")
            Next


            excelWorksheet.Range("A2:A21").ColumnWidth = 10
            excelWorksheet.Range("A2:A21").RowHeight = 20


            excelWorksheet.Range("B2:B21").ColumnWidth = 10
            excelWorksheet.Range("B2:B21").RowHeight = 20


            excelWorksheet.Range("A2:B21").Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
            excelWorksheet.Range("A2:B21").Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin

            excelWorksheet.Range("A2:A21").NumberFormat = "h:mm AM/PM"
            excelWorksheet.Range("B2:B21").NumberFormat = "h:mm AM/PM"

            excelWorksheet.Range("A2:A21").NumberFormat = "h:mm AM/PM"
            excelWorksheet.Range("B2:B21").NumberFormat = "h:mm AM/PM"

            Dim days() As String = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"}
            For dayIndex As Integer = 0 To days.Length - 1
                excelWorksheet.Cells(1, dayIndex + 3) = days(dayIndex)
            Next
            For dayIndex As Integer = 0 To days.Length - 1
                Dim dayCell As Microsoft.Office.Interop.Excel.Range = excelWorksheet.Cells(1, dayIndex + 3)
                dayCell.Value = days(dayIndex)


                dayCell.Interior.Color = RGB(0, 0, 255)
                dayCell.Font.Color = RGB(255, 255, 255)


                dayCell.Columns.ColumnWidth = 15
                dayCell.Rows.RowHeight = 20
                dayCell.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
                dayCell.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter

                excelWorksheet.Range("A1:I21").Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
                excelWorksheet.Range("A1:I21").Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin
            Next


            For rowIndex As Integer = 0 To DataGridView2.Rows.Count - 1
                Dim dayName As String = Convert.ToString(DataGridView2.Rows(rowIndex).Cells(6).Value)?.Trim()
                Dim timeRange As String = Convert.ToString(DataGridView2.Rows(rowIndex).Cells(7).Value)

                If Not String.IsNullOrEmpty(dayName) AndAlso Not String.IsNullOrEmpty(timeRange) Then
                    Dim times() As String = timeRange.Split("-"c)
                    If times.Length = 2 Then
                        Dim startTimeString As String = times(0).Trim()
                        Dim startTimeSpan As TimeSpan

                        If TimeSpan.TryParse(startTimeString, startTimeSpan) Then
                            Dim startHour As Integer = startTimeSpan.Hours
                            Dim startMinute As Integer = startTimeSpan.Minutes


                            If startTimeString.Contains("PM") AndAlso startHour < 12 Then
                                startHour += 12
                            End If


                            If startHour < 8 Then
                                startHour += 12
                            End If

                            Dim startExcelRow As Integer = ((startHour - 8) * 2) + If(startMinute = 30, 1, 0) + 2



                            Dim dayIndex As Integer = Array.IndexOf(days, dayName)

                            If dayIndex <> -1 Then
                                Dim excelColumn As Integer = dayIndex + 3

                                If startExcelRow < 2 Or startExcelRow > 21 Then
                                    MessageBox.Show($"Invalid start time calculation for row {rowIndex + 1}. Time: {startTimeString}")
                                End If

                                Dim mergedCell As Microsoft.Office.Interop.Excel.Range = excelWorksheet.Range(excelWorksheet.Cells(startExcelRow, excelColumn), excelWorksheet.Cells(startExcelRow + 5, excelColumn))
                                mergedCell.Merge()


                                mergedCell.Value = $"{DataGridView2.Rows(rowIndex).Cells(2).Value} - {DataGridView2.Rows(rowIndex).Cells(8).Value}"
                                mergedCell.WrapText = True
                                mergedCell.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
                                mergedCell.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter

                                mergedCell.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
                                mergedCell.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin


                                mergedCell.Font.Size = 12

                                mergedCell.Rows.RowHeight = 20
                                mergedCell.Columns.ColumnWidth = 15


                            Else
                                MessageBox.Show($"Invalid day name: {dayName}")
                            End If
                        Else
                            MessageBox.Show($"Invalid start time format: {startTimeString}")
                        End If
                    Else
                        MessageBox.Show($"Invalid time range format: {timeRange}")
                    End If
                End If
            Next

            ' Add this section to save the file
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
            saveFileDialog.FileName = "YourFileName.xlsx"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim filePath As String = saveFileDialog.FileName
                excelWorkbook.SaveAs(filePath)
                MessageBox.Show("File saved successfully!")
            End If

        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}")
        Finally

            If excelWorksheet IsNot Nothing Then Marshal.ReleaseComObject(excelWorksheet)
            If excelWorkbook IsNot Nothing Then Marshal.ReleaseComObject(excelWorkbook)
            If excelApp IsNot Nothing Then Marshal.ReleaseComObject(excelApp)
        End Try

    End Sub



    Private Sub ExportData()
        Dim excelApp As Microsoft.Office.Interop.Excel.Application = Nothing
        Dim excelWorkbook As Microsoft.Office.Interop.Excel.Workbook = Nothing
        Dim excelWorksheet As Microsoft.Office.Interop.Excel.Worksheet = Nothing

        Try

            excelApp = New Microsoft.Office.Interop.Excel.Application()
            excelApp.Visible = True
            excelWorkbook = excelApp.Workbooks.Add()
            excelWorksheet = TryCast(excelWorkbook.ActiveSheet, Microsoft.Office.Interop.Excel.Worksheet)


            Dim startTime As New TimeSpan(7, 30, 0)
            For timeIndex As Integer = 2 To 21
                Dim currentTime As TimeSpan = startTime.Add(New TimeSpan(0, 30 * (timeIndex - 1), 0))
                excelWorksheet.Cells(timeIndex, 1) = currentTime.ToString("hh\:mm")
                excelWorksheet.Cells(timeIndex, 2) = currentTime.Add(New TimeSpan(0, 30, 0)).ToString("hh\:mm")
            Next


            excelWorksheet.Range("A2:A21").ColumnWidth = 10
            excelWorksheet.Range("A2:A21").RowHeight = 20


            excelWorksheet.Range("B2:B21").ColumnWidth = 10
            excelWorksheet.Range("B2:B21").RowHeight = 20


            excelWorksheet.Range("A2:B21").Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
            excelWorksheet.Range("A2:B21").Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin

            excelWorksheet.Range("A2:A21").NumberFormat = "h:mm AM/PM"
            excelWorksheet.Range("B2:B21").NumberFormat = "h:mm AM/PM"

            excelWorksheet.Range("A2:A21").NumberFormat = "h:mm AM/PM"
            excelWorksheet.Range("B2:B21").NumberFormat = "h:mm AM/PM"

            Dim days() As String = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"}
            For dayIndex As Integer = 0 To days.Length - 1
                excelWorksheet.Cells(1, dayIndex + 3) = days(dayIndex)
            Next
            For dayIndex As Integer = 0 To days.Length - 1
                Dim dayCell As Microsoft.Office.Interop.Excel.Range = excelWorksheet.Cells(1, dayIndex + 3)
                dayCell.Value = days(dayIndex)


                dayCell.Interior.Color = RGB(0, 0, 255)
                dayCell.Font.Color = RGB(255, 255, 255)


                dayCell.Columns.ColumnWidth = 15
                dayCell.Rows.RowHeight = 20
                dayCell.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
                dayCell.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter

                excelWorksheet.Range("A1:I21").Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
                excelWorksheet.Range("A1:I21").Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin
            Next


            For rowIndex As Integer = 0 To DataGridView2.Rows.Count - 1
                Dim dayName As String = Convert.ToString(DataGridView2.Rows(rowIndex).Cells(6).Value)?.Trim()
                Dim timeRange As String = Convert.ToString(DataGridView2.Rows(rowIndex).Cells(7).Value)

                If Not String.IsNullOrEmpty(dayName) AndAlso Not String.IsNullOrEmpty(timeRange) Then
                    Dim times() As String = timeRange.Split("-"c)
                    If times.Length = 2 Then
                        Dim startTimeString As String = times(0).Trim()
                        Dim startTimeSpan As TimeSpan

                        If TimeSpan.TryParse(startTimeString, startTimeSpan) Then
                            Dim startHour As Integer = startTimeSpan.Hours
                            Dim startMinute As Integer = startTimeSpan.Minutes


                            If startTimeString.Contains("PM") AndAlso startHour < 12 Then
                                startHour += 12
                            End If


                            If startHour < 8 Then
                                startHour += 12
                            End If

                            Dim startExcelRow As Integer = ((startHour - 8) * 2) + If(startMinute = 30, 1, 0) + 2



                            Dim dayIndex As Integer = Array.IndexOf(days, dayName)

                            If dayIndex <> -1 Then
                                Dim excelColumn As Integer = dayIndex + 3

                                If startExcelRow < 2 Or startExcelRow > 21 Then
                                    MessageBox.Show($"Invalid start time calculation for row {rowIndex + 1}. Time: {startTimeString}")
                                End If

                                Dim mergedCell As Microsoft.Office.Interop.Excel.Range = excelWorksheet.Range(excelWorksheet.Cells(startExcelRow, excelColumn), excelWorksheet.Cells(startExcelRow + 5, excelColumn))
                                mergedCell.Merge()


                                mergedCell.Value = $"{DataGridView2.Rows(rowIndex).Cells(2).Value} - {DataGridView2.Rows(rowIndex).Cells(8).Value}"
                                mergedCell.WrapText = True
                                mergedCell.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
                                mergedCell.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter

                                mergedCell.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
                                mergedCell.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin


                                mergedCell.Font.Size = 12

                                mergedCell.Rows.RowHeight = 20
                                mergedCell.Columns.ColumnWidth = 15


                            Else
                                MessageBox.Show($"Invalid day name: {dayName}")
                            End If
                        Else
                            MessageBox.Show($"Invalid start time format: {startTimeString}")
                        End If
                    Else
                        MessageBox.Show($"Invalid time range format: {timeRange}")
                    End If
                End If
            Next

        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}")
        Finally

            If excelWorksheet IsNot Nothing Then Marshal.ReleaseComObject(excelWorksheet)
            If excelWorkbook IsNot Nothing Then Marshal.ReleaseComObject(excelWorkbook)
            If excelApp IsNot Nothing Then Marshal.ReleaseComObject(excelApp)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub



    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub



End Class