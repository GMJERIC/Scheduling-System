Imports System.Text
Imports MySql.Data.MySqlClient
Public Class Form2


    Private myconnection As New connectiondb
    Dim dr As MySqlDataReader
    Private selectedRoomID As Integer
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub backroombtn_Click(sender As Object, e As EventArgs) Handles backroombtn.Click

        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles room.TextChanged

    End Sub


    Private Sub LoadData()
        myconnection.open()
        Try
            DataGridView1.Rows.Clear()
            Using con As MySqlConnection = myconnection.con
                Using cmd As New MySqlCommand("SELECT * FROM room ORDER BY room", con)
                    Dim dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        DataGridView1.Rows.Add(dr("room_id"), dr("room"))
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
        If Not String.IsNullOrEmpty(room.Text) Then
            myconnection.open()
            Try
                Using con As MySqlConnection = myconnection.con

                    Dim checkDuplicateQuery As String = "SELECT COUNT(*) FROM room WHERE room = @room"
                    Using cmdCheckDuplicate As New MySqlCommand(checkDuplicateQuery, con)
                        cmdCheckDuplicate.Parameters.AddWithValue("@room", room.Text)
                        Dim duplicateCount As Integer = Convert.ToInt32(cmdCheckDuplicate.ExecuteScalar())

                        If duplicateCount > 0 Then

                            MsgBox("Room name already exists.")
                            Return
                        End If
                    End Using


                    Using cmdInsert As New MySqlCommand()
                        cmdInsert.Connection = con
                        cmdInsert.CommandText = "INSERT INTO room (`room`) VALUES (@room)"
                        cmdInsert.Parameters.Clear()
                        cmdInsert.Parameters.AddWithValue("@room", room.Text)
                        cmdInsert.ExecuteNonQuery()
                    End Using
                End Using

                MsgBox("Successfully Added!")
                myconnection.Close()
            Catch ex As Exception
                MsgBox("An error occurred while saving data.")
            End Try
        Else
            MsgBox("Room name cannot be empty. Please provide a valid room.")
        End If
    End Sub

    Private Sub edit()
        If Not String.IsNullOrEmpty(room.Text) AndAlso selectedRoomID <> -1 Then
            myconnection.open()
            Try
                Using con As MySqlConnection = myconnection.con

                    Dim checkDuplicateQuery As String = "SELECT COUNT(*) FROM room WHERE room = @room AND room_id <> @selectedRoomID"
                    Using cmdCheckDuplicate As New MySqlCommand(checkDuplicateQuery, con)
                        cmdCheckDuplicate.Parameters.AddWithValue("@room", room.Text)
                        cmdCheckDuplicate.Parameters.AddWithValue("@selectedRoomID", selectedRoomID)
                        Dim duplicateCount As Integer = Convert.ToInt32(cmdCheckDuplicate.ExecuteScalar())

                        If duplicateCount > 0 Then

                            MsgBox("Room name already exists. Please choose a different name.")
                            Return
                        End If
                    End Using

                    Using cmdUpdate As New MySqlCommand()
                        cmdUpdate.Connection = con
                        cmdUpdate.CommandText = "UPDATE room SET room = @room WHERE room_id = @selectedRoomID"
                        cmdUpdate.Parameters.Clear()
                        cmdUpdate.Parameters.AddWithValue("@room", room.Text)
                        cmdUpdate.Parameters.AddWithValue("@selectedRoomID", selectedRoomID)
                        cmdUpdate.ExecuteNonQuery()
                    End Using
                End Using

                MsgBox("Successfully Updated!")

                myconnection.Close()
            Catch ex As Exception
                MsgBox("An error occurred while updating data.")
            End Try
        Else
            MsgBox("Please select a room from the DataGridView and provide a valid room name to update.")
        End If
    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        savee()
        LoadData()

        room.Clear()
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub





    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        edit()
        LoadData()
        room.Clear()


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then

            Dim selectedRoomName As String = DataGridView1.Rows(e.RowIndex).Cells("roomno").Value?.ToString()



            room.Text = selectedRoomName

            Dim roomIDValue As Integer
            If Integer.TryParse(DataGridView1.Rows(e.RowIndex).Cells("room_id").Value.ToString(), roomIDValue) Then
                selectedRoomID = roomIDValue
            Else
                selectedRoomID = -1
            End If
        End If
    End Sub

End Class