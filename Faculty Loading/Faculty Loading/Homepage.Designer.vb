<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Homepage
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
        Facultyloading = New Label()
        btnlogin = New Button()
        PictureBox2 = New PictureBox()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        PictureBox3 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        PictureBox1.Image = My.Resources.Resources.cmilogo_removebg_preview
        PictureBox1.Location = New Point(126, 136)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(258, 202)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Facultyloading
        ' 
        Facultyloading.Anchor = AnchorStyles.None
        Facultyloading.AutoSize = True
        Facultyloading.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Facultyloading.Font = New Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Facultyloading.Location = New Point(439, 198)
        Facultyloading.Name = "Facultyloading"
        Facultyloading.Size = New Size(491, 140)
        Facultyloading.TabIndex = 1
        Facultyloading.Text = "Faculty Loading" & vbCrLf & "       System"
        ' 
        ' btnlogin
        ' 
        btnlogin.Anchor = AnchorStyles.None
        btnlogin.BackColor = Color.Blue
        btnlogin.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point)
        btnlogin.ForeColor = Color.White
        btnlogin.Location = New Point(502, 429)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(347, 73)
        btnlogin.TabIndex = 2
        btnlogin.Text = "Login"
        btnlogin.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.cmicmicmi
        PictureBox2.Location = New Point(-3, -19)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(2000, 1060)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.None
        GroupBox1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        GroupBox1.Location = New Point(390, 158)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(540, 434)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.None
        GroupBox2.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        GroupBox2.Controls.Add(PictureBox3)
        GroupBox2.Location = New Point(81, 50)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(902, 659)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.None
        PictureBox3.Image = My.Resources.Resources.png_clipart_abstract_background_material_color_trend_thumbnail_removebg_preview
        PictureBox3.Location = New Point(-9, 0)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(594, 659)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' Homepage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnablePreventFocusChange
        CausesValidation = False
        ClientSize = New Size(1182, 753)
        Controls.Add(btnlogin)
        Controls.Add(Facultyloading)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox2)
        Controls.Add(PictureBox2)
        Name = "Homepage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Home page"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Facultyloading As Label
    Friend WithEvents btnlogin As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
