Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the label's background color to Transparent
        PictureBox1.Parent = GroupBox1
        PictureBox1.BackColor = Color.Transparent
        Label1.Parent = GroupBox1
        Label1.BackColor = Color.Transparent
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles instructorbtn.Click
        instructor.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles coursebtn.Click
        course_form.Show()
        Me.Hide()

    End Sub

    Private Sub subjectbtn_Click(sender As Object, e As EventArgs) Handles subjectbtn.Click
        subject.Show()
        Me.Hide()

    End Sub

    Private Sub roombtn_Click(sender As Object, e As EventArgs) Handles roombtn.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub schedbtn_Click(sender As Object, e As EventArgs) Handles schedbtn.Click
        Schedule.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label1.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class