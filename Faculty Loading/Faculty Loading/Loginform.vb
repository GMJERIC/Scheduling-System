Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography


Public Class Loginform

    Private myconnection As New connectiondb
    Dim conadApter As MySqlDataAdapter
    Dim dataTable As DataTable
    Private Sub Loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Parent = PictureBox3
        PictureBox1.BackColor = Color.Transparent
    End Sub

    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = sha256.Create()
            Dim hashedBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()

            For i As Integer = 0 To hashedBytes.Length - 1
                builder.Append(hashedBytes(i).ToString("x2"))
            Next

            Return builder.ToString()
        End Using
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Dim username As String = TextBox1.Text
        Dim enteredPassword As String = TextBox2.Text
        Dim hashedPassword As String = HashPassword(enteredPassword)

        Dim query As String = "SELECT * FROM admin WHERE username = @username AND password = @password"

        myconnection.open()

        Using command As New MySqlCommand(query, myconnection.con)

            command.Parameters.AddWithValue("@username", username)
            command.Parameters.AddWithValue("@password", hashedPassword)
            conadApter = New MySqlDataAdapter(command)

            dataTable = New DataTable
            conadApter.Fill(dataTable)

            If dataTable.Rows.Count() > 0 Then
                MessageBox.Show("Login Successful")
                Me.Hide()
                Form1.Show()
            Else
                MessageBox.Show("Username and/or password are invalid")
            End If
        End Using

        myconnection.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class

Public Class connectiondb
    Public con As New MySqlConnection("Server=localhost; user=root; password=; database=scheduling")
    Public Sub open()
        Try
            con.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Close()
        Try
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class