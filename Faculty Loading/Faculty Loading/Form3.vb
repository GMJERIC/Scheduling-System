Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Form3
    Private myconnection As New connectiondb

    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim hashedBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()

            For i As Integer = 0 To hashedBytes.Length - 1
                builder.Append(hashedBytes(i).ToString("x2"))
            Next

            Return builder.ToString()
        End Using
    End Function

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text
        Dim hashedPassword As String = HashPassword(password)

        Dim query As String = "INSERT INTO admin (username, password) VALUES (@username, @password)"

        myconnection.open()
        Using command As New MySqlCommand(query, myconnection.con)
            command.Parameters.AddWithValue("@username", username)
            command.Parameters.AddWithValue("@password", hashedPassword)

            command.ExecuteNonQuery()
        End Using
        myconnection.Close()

        MessageBox.Show("Registration Successful")
    End Sub
End Class
