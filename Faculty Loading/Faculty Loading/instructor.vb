Imports K4os.Compression.LZ4.Streams
Imports MySql.Data.MySqlClient
Public Class instructor
    Private myconnection As New connectiondb
    Dim gender As String
    Dim dr As MySqlDataReader
    Private selectedInstructorID As Integer
    Private Sub instructor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles Radfemale.CheckedChanged
        gender = "Female"
    End Sub

    Private Sub Radmale_CheckedChanged(sender As Object, e As EventArgs) Handles Radmale.CheckedChanged
        gender = "Male"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        savee()
        LoadData()

        last_name.Clear()
        first_name.Clear()
        middle_name.Clear()
        Dept.Clear()
        Radmale.Checked = False
        Radfemale.Checked = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles last_name.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub LoadData()
        myconnection.open()
        Try
            DataGridView1.Rows.Clear()
            Using con As MySqlConnection = myconnection.con
                Using cmd As New MySqlCommand("SELECT * FROM instructor ORDER BY last_name", con)
                    Dim dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        Dim instructorID As Integer = dr("instructor_id")
                        Dim lastName As String = dr("last_name")
                        Dim firstName As String = dr("first_name")
                        Dim middleName As String = dr("middle_name")
                        Dim gender As String = dr("gender")
                        Dim department As String = dr("department")


                        ' Add the retrieved data to the DataGridView
                        DataGridView1.Rows.Add(instructorID, lastName, firstName, middleName, gender, department)
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
        ' Check if the input fields are not blank
        If String.IsNullOrEmpty(last_name.Text) OrElse String.IsNullOrEmpty(first_name.Text) OrElse String.IsNullOrEmpty(middle_name.Text) Then
            MsgBox("Please provide values for Last Name, First Name, and Middle Name.")
            Return
        End If

        myconnection.open()
        Try
            Using con As MySqlConnection = myconnection.con
                ' Check if the new instructor already exists
                Dim checkDuplicateQuery As String = "SELECT COUNT(*) FROM instructor WHERE last_name = @last_name AND first_name = @first_name AND middle_name = @middle_name"
                Using cmdCheckDuplicate As New MySqlCommand(checkDuplicateQuery, con)
                    cmdCheckDuplicate.Parameters.AddWithValue("@last_name", last_name.Text)
                    cmdCheckDuplicate.Parameters.AddWithValue("@first_name", first_name.Text)
                    cmdCheckDuplicate.Parameters.AddWithValue("@middle_name", middle_name.Text)
                    Dim duplicateCount As Integer = Convert.ToInt32(cmdCheckDuplicate.ExecuteScalar())

                    If duplicateCount > 0 Then
                        ' Instructor already exists, show a message
                        MsgBox("Instructor already exists. Please provide a different set of names.")
                        Return
                    End If
                End Using

                Using cmdInsert As New MySqlCommand()
                    cmdInsert.Connection = con
                    cmdInsert.CommandText = "INSERT INTO instructor (`last_name`, `first_name`, `middle_name`, `gender`, `department`) VALUES (@last_name, @first_name, @middle_name, @gender, @department)"
                    cmdInsert.Parameters.AddWithValue("@last_name", last_name.Text)
                    cmdInsert.Parameters.AddWithValue("@first_name", first_name.Text)
                    cmdInsert.Parameters.AddWithValue("@middle_name", middle_name.Text)
                    cmdInsert.Parameters.AddWithValue("@gender", gender)
                    cmdInsert.Parameters.AddWithValue("@department", Dept.Text)
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
        ' Check if the input fields are not blank
        If String.IsNullOrEmpty(last_name.Text) OrElse String.IsNullOrEmpty(first_name.Text) OrElse String.IsNullOrEmpty(middle_name.Text) Then
            MsgBox("Please provide values for Last Name, First Name, and Middle Name.")
            Return
        End If

        myconnection.open()
        Try
            Using con As MySqlConnection = myconnection.con
                ' Check if the new instructor name already exists excluding the current record
                Dim checkDuplicateQuery As String = "SELECT COUNT(*) FROM instructor WHERE last_name = @last_name AND first_name = @first_name AND middle_name = @middle_name AND instructor_id <> @selectedInstructorID"
                Using cmdCheckDuplicate As New MySqlCommand(checkDuplicateQuery, con)
                    cmdCheckDuplicate.Parameters.AddWithValue("@last_name", last_name.Text)
                    cmdCheckDuplicate.Parameters.AddWithValue("@first_name", first_name.Text)
                    cmdCheckDuplicate.Parameters.AddWithValue("@middle_name", middle_name.Text)
                    cmdCheckDuplicate.Parameters.AddWithValue("@selectedInstructorID", selectedInstructorID)

                    Dim duplicateCount As Integer = Convert.ToInt32(cmdCheckDuplicate.ExecuteScalar())

                    If duplicateCount > 0 Then
                        ' Instructor name already exists, show a message
                        MsgBox("Instructor name already exists. Please provide a different set of names.")
                        Return
                    End If
                End Using

                ' Update the instructor data
                Dim updateQuery As String = "UPDATE instructor SET last_name = @last_name, first_name = @first_name, middle_name = @middle_name, gender = @gender, department = @department WHERE instructor_id = @selectedInstructorID"
                Using cmdUpdate As New MySqlCommand(updateQuery, con)
                    cmdUpdate.Parameters.AddWithValue("@last_name", last_name.Text)
                    cmdUpdate.Parameters.AddWithValue("@first_name", first_name.Text)
                    cmdUpdate.Parameters.AddWithValue("@middle_name", middle_name.Text)
                    cmdUpdate.Parameters.AddWithValue("@gender", gender)
                    cmdUpdate.Parameters.AddWithValue("@department", Dept.Text)
                    cmdUpdate.Parameters.AddWithValue("@selectedInstructorID", selectedInstructorID)

                    cmdUpdate.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Successfully Updated!")

            myconnection.Close()
        Catch ex As Exception
            MsgBox($"An error occurred while updating data. {ex.Message}")
        Finally
            myconnection.Close()
        End Try
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub first_name_TextChanged(sender As Object, e As EventArgs) Handles first_name.TextChanged

    End Sub

    Private Sub middle_name_TextChanged(sender As Object, e As EventArgs) Handles middle_name.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        edit()
        LoadData()
        last_name.Clear()
        first_name.Clear()
        middle_name.Clear()
        Dept.Clear()
        Radmale.Checked = False
        Radfemale.Checked = False
    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then
            ' Get the values from the selected row
            Dim selectedLastName As String = DataGridView1.Rows(e.RowIndex).Cells("lastname").Value?.ToString()
            Dim selectedFirstName As String = DataGridView1.Rows(e.RowIndex).Cells("firstname").Value?.ToString()
            Dim selectedMiddleName As String = DataGridView1.Rows(e.RowIndex).Cells("middlename").Value?.ToString()
            Dim selectedDepartment As String = DataGridView1.Rows(e.RowIndex).Cells("Department").Value?.ToString()
            Dim selectedGender As String ' You need to retrieve the gender from your data; modify this line based on your actual column name.

            ' Retrieve the gender column value from your DataGridView; replace "gender" with your actual column name.
            selectedGender = DataGridView1.Rows(e.RowIndex).Cells("instructor_gen").Value?.ToString()

            ' Set the values to the TextBoxes and other controls
            last_name.Text = selectedLastName
            first_name.Text = selectedFirstName
            middle_name.Text = selectedMiddleName
            Dept.Text = selectedDepartment

            ' Set the gender based on the retrieved value
            If selectedGender = "Male" Then
                Radmale.Checked = True
                Radfemale.Checked = False
            ElseIf selectedGender = "Female" Then
                Radmale.Checked = False
                Radfemale.Checked = True
            Else
                Radmale.Checked = False
                Radfemale.Checked = False
            End If

            ' Set the selectedInstructorID
            Dim selectedInstructorIDValue As Integer
            If Integer.TryParse(DataGridView1.Rows(e.RowIndex).Cells("instructor_id").Value?.ToString(), selectedInstructorIDValue) Then
                selectedInstructorID = selectedInstructorIDValue
            Else
                selectedInstructorID = -1
            End If
        End If
    End Sub

End Class

