Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1

Public Class subject

    Private myconnection As New connectiondb
    Dim dr As MySqlDataReader
    Private Sub backsubjectbtn_Click(sender As Object, e As EventArgs) Handles backsubjectbtn.Click


        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub subject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        CRS()
        room()
        Label5.Parent = PictureBox1
        Label5.BackColor = Color.Transparent
        Label20.Parent = PictureBox1
        Label20.BackColor = Color.Transparent
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue

        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox3.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox4.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox5.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox6.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox7.DropDownStyle = ComboBoxStyle.DropDownList
        combounit.DropDownStyle = ComboBoxStyle.DropDownList
        xection.DropDownStyle = ComboBoxStyle.DropDownList


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Private Sub LoadData()
        myconnection.open()
        Try
            DataGridView1.Rows.Clear()
            Using con As MySqlConnection = myconnection.con
                Using cmd As New MySqlCommand("SELECT * FROM subject ORDER BY subject_code", con)
                    Dim dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        DataGridView1.Rows.Add(dr("subject_code"), dr("subject_description"), dr("units"), dr("section"), dr("day"), dr("time"), dr("room"), dr("course"), dr("semester"))
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
    Private Sub savee()

        Try
                ' Check if any of the required fields is blank
                If String.IsNullOrWhiteSpace(ComboBox1.Text) OrElse
                   String.IsNullOrWhiteSpace(combobox.Text) OrElse
                   String.IsNullOrWhiteSpace(textbox.Text) OrElse
                   String.IsNullOrWhiteSpace(combounit.Text) OrElse
                   String.IsNullOrWhiteSpace(ComboBox2.Text) OrElse
                   String.IsNullOrWhiteSpace(ComboBox4.Text) OrElse
                   String.IsNullOrWhiteSpace(ComboBox3.Text) OrElse
                   String.IsNullOrWhiteSpace(xection.Text) OrElse
                   String.IsNullOrWhiteSpace(ComboBox7.Text) OrElse
                   String.IsNullOrWhiteSpace(ComboBox6.Text) OrElse
                   String.IsNullOrWhiteSpace(ComboBox5.Text) Then
                    MsgBox("Please fill in all the required fields.")
                    Return ' Exit the function without further processing
                End If
                Using con As New MySqlConnection(myconnection.con.ConnectionString)
                con.Open()

                Dim conflictDetails As String = GetConflictDetails(con)
                If String.IsNullOrEmpty(conflictDetails) Then
                    Using cmd As New MySqlCommand()
                        cmd.Connection = con
                        cmd.CommandText = "INSERT INTO subject (`course`,`subject_code`,`subject_description` , `units`,`academicYr`,`yrLvl`,`semester`,`section`,`day`, `time`,`room`) VALUES (@ComboBox1, @combobox,@textbox,@combounit,@ComboBox2,@ComboBox4,@ComboBox3,@xection, @ComboBox7,@ComboBox6,@ComboBox5)"
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@ComboBox1", ComboBox1.Text)
                        cmd.Parameters.AddWithValue("@combobox", combobox.Text)
                        cmd.Parameters.AddWithValue("@textbox", textbox.Text)
                        cmd.Parameters.AddWithValue("@combounit", combounit.Text)
                        cmd.Parameters.AddWithValue("@ComboBox2", ComboBox2.Text)
                        cmd.Parameters.AddWithValue("@ComboBox4", ComboBox4.Text)
                        cmd.Parameters.AddWithValue("@ComboBox3", ComboBox3.Text)
                        cmd.Parameters.AddWithValue("@ComboBox7", ComboBox7.Text)
                        cmd.Parameters.AddWithValue("@ComboBox6", ComboBox6.Text)
                        cmd.Parameters.AddWithValue("@ComboBox5", ComboBox5.Text)
                        cmd.Parameters.AddWithValue("@xection", xection.Text)
                        cmd.ExecuteNonQuery()
                        MsgBox("Successfully Added!")
                    End Using
                Else
                    MsgBox($"Conflict detected. Your subject conflicts with {conflictDetails}. Please choose a different day, time, or room.")
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Function GetConflictDetails(con As MySqlConnection) As String
        ' Extract start and end times from the input time string
        Dim inputTime As String() = ComboBox6.Text.Split({" - "}, StringSplitOptions.RemoveEmptyEntries)
        Dim startTime As DateTime
        Dim endTime As DateTime

        If DateTime.TryParse(inputTime(0), startTime) AndAlso DateTime.TryParse(inputTime(1), endTime) Then
            ' Modify the query to handle time conflicts
            Dim query As String = "SELECT * FROM subject WHERE day = @day AND room = @room AND " &
                              "((@startTime < ADDTIME(TIME_FORMAT(time, '%H:%i'), '03:00:00') AND @endTime > TIME_FORMAT(time, '%H:%i')) OR " &
                              "(@startTime >= TIME_FORMAT(time, '%H:%i') AND @startTime < ADDTIME(TIME_FORMAT(time, '%H:%i'), '03:00:00')))"

            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@day", ComboBox7.Text)
                cmd.Parameters.AddWithValue("@startTime", startTime.ToString("HH:mm"))
                cmd.Parameters.AddWithValue("@endTime", endTime.ToString("HH:mm"))
                cmd.Parameters.AddWithValue("@room", ComboBox5.Text)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        reader.Read()
                        Dim subjectCode As String = reader("subject_code").ToString()
                        Dim subjectDescription As String = reader("subject_description").ToString()
                        Dim time As String = reader("time").ToString()
                        Dim room As String = reader("room").ToString()
                        Return $"Subject code {subjectCode} ({subjectDescription}) has a time conflict at {time} in room {room}."
                    End If
                End Using
            End Using
        Else
            Return "Invalid time format."
        End If

        Return String.Empty
    End Function










    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        savee()
        LoadData()


        textbox.Clear()

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub subject_code_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub subject_description_TextChanged(sender As Object, e As EventArgs) Handles textbox.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub



    Private Sub CRS()
        myconnection.open()
        Try
            Using con As MySqlConnection = myconnection.con
                Dim query As String = "SELECT  course FROM course"

                Using cmd As New MySqlCommand(query, con)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()

                        If reader.HasRows Then
                            ComboBox1.Items.Clear()

                            While reader.Read()
                                Dim course As String = reader("course").ToString()


                                ComboBox1.Items.Add(course)
                            End While
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub room()
        myconnection.open()
        Try
            Using con As MySqlConnection = myconnection.con
                Dim query As String = "SELECT room FROM room"

                Using cmd As New MySqlCommand(query, con)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()

                        If reader.HasRows Then
                            ComboBox5.Items.Clear()

                            While reader.Read()
                                Dim room As String = reader("room").ToString()


                                ComboBox5.Items.Add(room)
                            End While
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub





    Private Sub UpdateDataGridView()

        combobox.SelectedIndex = -1
        combobox.Items.Clear()
        textbox.Text = ""
        combounit.SelectedIndex = -1
        xection.SelectedIndex = -1
        ComboBox7.SelectedIndex = -1
        ComboBox6.SelectedIndex = -1
        ComboBox5.SelectedIndex = -1

        If ComboBox1.SelectedIndex <> -1 AndAlso
       ComboBox2.SelectedIndex <> -1 AndAlso
       ComboBox3.SelectedIndex <> -1 AndAlso
       ComboBox4.SelectedIndex <> -1 Then
            Try


                Dim selectedCourse As String = ComboBox1.SelectedItem.ToString()
                Dim selectedSemester As String = ComboBox3.SelectedItem.ToString()
                Dim selectedAcademicYr As String = ComboBox2.SelectedItem.ToString()
                Dim selectedYrLvl As String = ComboBox4.SelectedItem.ToString()


                Dim text1 As String = ComboBox1.Text
                Dim text2 As String = ComboBox3.Text
                Dim text3 As String = ComboBox2.Text
                Dim text4 As String = ComboBox4.Text

                label20.Text = text4 & "-" & text1 & " " & text2 & " " & text3 & " Subject Offerings "

                Using con As MySqlConnection = myconnection.con
                    con.Open()


                    Dim query As String = "SELECT course, subject_code, subject_description, semester, units, section, day, time, room FROM subject " &
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
                                Dim subject_code As String = reader("subject_code").ToString()
                                Dim subject_description As String = reader("subject_description").ToString()
                                Dim units As String = reader("units").ToString()
                                Dim course As String = reader("course").ToString()
                                Dim semester As String = reader("semester").ToString()
                                Dim Section As String = reader("section").ToString()
                                Dim day As String = reader("day").ToString()
                                Dim time As String = reader("time").ToString()
                                Dim room As String = reader("room").ToString()


                                DataGridView1.Rows.Add(subject_code, subject_description, units, Section, day, time, room, course, semester)

                                combobox.Items.Add(subject_code)
                            End While




                        End Using
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub ClearControls()

        combobox.SelectedIndex = -1
        textbox.Text = ""
        combounit.SelectedIndex = -1
        xection.SelectedIndex = -1
        ComboBox7.SelectedIndex = -1
        ComboBox6.SelectedIndex = -1
        ComboBox5.SelectedIndex = -1
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        UpdateDataGridView()

        ClearControls()



    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        UpdateDataGridView()

        ClearControls()

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        UpdateDataGridView()

        ClearControls()

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        UpdateDataGridView()

        ClearControls()

    End Sub



    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles label12.Click

    End Sub

    Private Sub combobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox.SelectedIndexChanged
        If combobox.SelectedIndex <> -1 Then
            Dim selectedSubjectCode As String = combobox.SelectedItem.ToString()
            Dim selectedSemester As String = ComboBox3.SelectedItem.ToString()
            Dim selectedAcademicYr As String = ComboBox2.SelectedItem.ToString()
            Dim selectedYrLvl As String = ComboBox4.SelectedItem.ToString()

            Try
                Using con As MySqlConnection = myconnection.con
                    con.Open()

                    Dim query As String = "SELECT subject_description, section,units, section, day, time, room FROM subject " &
                                         "WHERE subject_code = @subject_code AND semester = @semester AND academicYr = @academicYr AND yrLvl = @yrLvl"

                    Using cmd As New MySqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@subject_code", selectedSubjectCode)
                        cmd.Parameters.AddWithValue("@semester", selectedSemester)
                        cmd.Parameters.AddWithValue("@academicYr", selectedAcademicYr)
                        cmd.Parameters.AddWithValue("@yrLvl", selectedYrLvl)

                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                textbox.Text = reader("subject_description").ToString()
                                xection.Text = reader("section").ToString()
                                combounit.Text = reader("units").ToString()
                                ComboBox7.SelectedItem = reader("day").ToString()
                                ComboBox6.SelectedItem = reader("time").ToString()
                                ComboBox5.Text = reader("room").ToString()
                            End If
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub xection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles xection.SelectedIndexChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class