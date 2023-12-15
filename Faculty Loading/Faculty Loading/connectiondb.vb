Imports MySql.Data.MySqlClient
Module Module1
    Public con As New MySqlConnection("Server=localhost; user=root; password=; database=scheduling")
    Public cmd As MySqlCommand
    Public Class connectiondb

        Public Function open() As MySqlConnection
            Try
                con.Open()

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
        End Function
        Public Function Close() As MySqlConnection
            Try
                con.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
        End Function

    End Class
End Module