Imports System.Security.Cryptography
Imports System.Text
Public Class register

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

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
        Dim hashedPassword As String = HashPassword(password) ' Hash the entered password

        ' Insert the username and hashed password into the database
        Dim query As String = "INSERT INTO admin (username, password) VALUES (@username, @password)"

        ' Use your connection and command objects here
        ' myconnection.Open()
        ' Using command As New MySqlCommand(query, myconnection.con)
        '     command.Parameters.AddWithValue("@username", username)
        '     command.Parameters.AddWithValue("@password", hashedPassword)
        '     ' Execute the query
        ' End Using
        ' myconnection.Close()

        ' For the sake of this example, let's assume a successful registration
        MessageBox.Show("Registration Successful")
    End Sub

    ' Add other necessary methods and events as needed


End Class
