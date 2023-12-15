<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Loginform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        loginbtn = New Button()
        CheckBox1 = New CheckBox()
        PictureBox2 = New PictureBox()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        PictureBox3 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        PictureBox1.Image = My.Resources.Resources.cmilogo_removebg_preview__2_
        PictureBox1.Location = New Point(22, 53)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(258, 202)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Label1.Font = New Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(42, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(491, 140)
        Label1.TabIndex = 2
        Label1.Text = "Faculty Loading" & vbCrLf & "       System"
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.None
        TextBox1.Font = New Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(32, 263)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Username"
        TextBox1.Size = New Size(501, 45)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.None
        TextBox2.Font = New Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(32, 353)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Password"
        TextBox2.Size = New Size(501, 45)
        TextBox2.TabIndex = 4
        TextBox2.UseSystemPasswordChar = True
        ' 
        ' loginbtn
        ' 
        loginbtn.Anchor = AnchorStyles.None
        loginbtn.BackColor = Color.Blue
        loginbtn.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        loginbtn.ForeColor = Color.White
        loginbtn.Location = New Point(32, 454)
        loginbtn.Name = "loginbtn"
        loginbtn.Size = New Size(501, 59)
        loginbtn.TabIndex = 5
        loginbtn.Text = "LOGIN"
        loginbtn.UseVisualStyleBackColor = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.Anchor = AnchorStyles.None
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(32, 404)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(105, 24)
        CheckBox1.TabIndex = 6
        CheckBox1.Text = "Show/Hide"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.cmicmicmi
        PictureBox2.Location = New Point(-13, -7)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(2000, 1060)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.None
        GroupBox1.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(GroupBox2)
        GroupBox1.Controls.Add(PictureBox3)
        GroupBox1.Location = New Point(452, 181)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(902, 659)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.None
        GroupBox2.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        GroupBox2.Controls.Add(loginbtn)
        GroupBox2.Controls.Add(CheckBox1)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(TextBox1)
        GroupBox2.Controls.Add(TextBox2)
        GroupBox2.Location = New Point(286, 26)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(564, 586)
        GroupBox2.TabIndex = 9
        GroupBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.png_clipart_abstract_background_material_color_trend_thumbnail_removebg_preview
        PictureBox3.Location = New Point(0, 0)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(567, 659)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 9
        PictureBox3.TabStop = False
        ' 
        ' Loginform
        ' 
        AcceptButton = loginbtn
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 1014)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox2)
        Name = "Loginform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login Form"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents loginbtn As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
