Imports MySql.Data.MySqlClient
Public Class course_form
    Private myconnection As New connectiondb
    Dim dr As MySqlDataReader
    Private selectedCourseID As Integer

    Private Sub backcoursebtn_Click(sender As Object, e As EventArgs) Handles backcoursebtn.Click

        Form1.Show()
        Me.Hide()

    End Sub


    Private Sub Course_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
    End Sub
    Private Sub savee()

        If String.IsNullOrEmpty(course.Text) OrElse String.IsNullOrEmpty(course_description.Text) Then
            MsgBox("Course name and description cannot be empty. Please provide valid values.")
            Return
        End If

        myconnection.open()
        Try
            Using con As MySqlConnection = myconnection.con

                Dim checkDuplicateQuery As String = "SELECT COUNT(*) FROM course WHERE course = @course AND course_description = @course_description"
                Using cmdCheckDuplicate As New MySqlCommand(checkDuplicateQuery, con)
                    cmdCheckDuplicate.Parameters.AddWithValue("@course", course.Text)
                    cmdCheckDuplicate.Parameters.AddWithValue("@course_description", course_description.Text)
                    Dim duplicateCount As Integer = Convert.ToInt32(cmdCheckDuplicate.ExecuteScalar())

                    If duplicateCount > 0 Then

                        MsgBox("Course name already exists. Please choose a different name.")
                        Return
                    End If
                End Using


                Using cmdInsert As New MySqlCommand()
                    cmdInsert.Connection = con
                    cmdInsert.CommandText = "INSERT INTO course (`course`, `course_description` ) VALUES (@course, @course_description )"
                    cmdInsert.Parameters.AddWithValue("@course", course.Text)
                    cmdInsert.Parameters.AddWithValue("@course_description", course_description.Text)
                    cmdInsert.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Successfully Added!")

            myconnection.Close()
        Catch ex As Exception
            MsgBox("An error occurred while saving data.")
        Finally
            myconnection.Close()
        End Try
    End Sub

    Private Sub edit()
        If Not String.IsNullOrEmpty(course.Text) AndAlso selectedCourseID <> -1 Then
            myconnection.open()
            Try
                Using con As MySqlConnection = myconnection.con

                    Dim checkDuplicateQuery As String = "SELECT COUNT(*) FROM course WHERE course = @course AND course_id <> @selectedCourseID"
                    Using cmdCheckDuplicate As New MySqlCommand(checkDuplicateQuery, con)
                        cmdCheckDuplicate.Parameters.AddWithValue("@course", course.Text)
                        cmdCheckDuplicate.Parameters.AddWithValue("@selectedCourseID", selectedCourseID)
                        Dim duplicateCount As Integer = Convert.ToInt32(cmdCheckDuplicate.ExecuteScalar())

                        If duplicateCount > 0 Then
                            MsgBox("Course name already exists. Please choose a different name.")
                            Return
                        End If
                    End Using

                    Using cmdUpdate As New MySqlCommand()
                        cmdUpdate.Connection = con
                        cmdUpdate.CommandText = "UPDATE course SET course = @course, course_description = @course_description WHERE course_id = @selectedCourseID"
                        cmdUpdate.Parameters.Clear()
                        cmdUpdate.Parameters.AddWithValue("@course", course.Text)
                        cmdUpdate.Parameters.AddWithValue("@course_description", course_description.Text)
                        cmdUpdate.Parameters.AddWithValue("@selectedCourseID", selectedCourseID)
                        cmdUpdate.ExecuteNonQuery()
                    End Using
                End Using

                MsgBox("Successfully Updated!")

                myconnection.Close()
            Catch ex As Exception
                MsgBox("An error occurred while updating data.")
            End Try
        Else
            MsgBox("Please select a course from the DataGridView and provide a valid course name to update.")
        End If
    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        savee()
        LoadData()
        course.Clear()
        course_description.Clear()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles course.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles course_description.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Private Sub LoadData()
        myconnection.open()
        Try
            DataGridView1.Rows.Clear()
            Using con As MySqlConnection = myconnection.con
                Using cmd As New MySqlCommand("SELECT * FROM course ORDER BY course", con)
                    Dim dr As MySqlDataReader = cmd.ExecuteReader()

                    While dr.Read()
                        DataGridView1.Rows.Add(dr("course_id"), dr("course"), dr("course_description"))
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

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub





    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then

            Dim selectedCourse As String = DataGridView1.Rows(e.RowIndex).Cells("coursecode").Value?.ToString()
            Dim selectedCourseDesc As String = DataGridView1.Rows(e.RowIndex).Cells("coursedescription").Value?.ToString()
            Dim selectedCourseIDValue As Integer


            course.Text = selectedCourse
            course_description.Text = selectedCourseDesc

            If Integer.TryParse(DataGridView1.Rows(e.RowIndex).Cells("course_id").Value.ToString(), selectedCourseIDValue) Then
                selectedCourseID = selectedCourseIDValue
            Else
                selectedCourseID = -1
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        edit()
        LoadData()
        course.Clear()
        course_description.Clear()
    End Sub

End Class