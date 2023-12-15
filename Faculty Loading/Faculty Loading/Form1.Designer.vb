<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        instructorbtn = New Button()
        coursebtn = New Button()
        subjectbtn = New Button()
        roombtn = New Button()
        schedbtn = New Button()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Left
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.cmilogo_removebg_preview__2_
        PictureBox1.Location = New Point(67, 68)
        PictureBox1.Margin = New Padding(6)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(264, 198)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' instructorbtn
        ' 
        instructorbtn.Anchor = AnchorStyles.None
        instructorbtn.BackColor = Color.Blue
        instructorbtn.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        instructorbtn.ForeColor = Color.White
        instructorbtn.Location = New Point(19, 534)
        instructorbtn.Margin = New Padding(6)
        instructorbtn.Name = "instructorbtn"
        instructorbtn.Size = New Size(347, 61)
        instructorbtn.TabIndex = 4
        instructorbtn.Text = "Instructor"
        instructorbtn.UseVisualStyleBackColor = False
        ' 
        ' coursebtn
        ' 
        coursebtn.Anchor = AnchorStyles.None
        coursebtn.BackColor = Color.Blue
        coursebtn.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        coursebtn.ForeColor = Color.White
        coursebtn.Location = New Point(19, 621)
        coursebtn.Margin = New Padding(6)
        coursebtn.Name = "coursebtn"
        coursebtn.Size = New Size(347, 61)
        coursebtn.TabIndex = 5
        coursebtn.Text = "Course"
        coursebtn.UseVisualStyleBackColor = False
        ' 
        ' subjectbtn
        ' 
        subjectbtn.Anchor = AnchorStyles.None
        subjectbtn.BackColor = Color.Blue
        subjectbtn.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        subjectbtn.ForeColor = Color.White
        subjectbtn.Location = New Point(19, 801)
        subjectbtn.Margin = New Padding(6)
        subjectbtn.Name = "subjectbtn"
        subjectbtn.Size = New Size(347, 61)
        subjectbtn.TabIndex = 6
        subjectbtn.Text = "Subject"
        subjectbtn.UseVisualStyleBackColor = False
        ' 
        ' roombtn
        ' 
        roombtn.Anchor = AnchorStyles.None
        roombtn.BackColor = Color.Blue
        roombtn.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        roombtn.ForeColor = Color.White
        roombtn.Location = New Point(19, 711)
        roombtn.Margin = New Padding(6)
        roombtn.Name = "roombtn"
        roombtn.Size = New Size(347, 61)
        roombtn.TabIndex = 7
        roombtn.Text = "Room"
        roombtn.UseVisualStyleBackColor = False
        ' 
        ' schedbtn
        ' 
        schedbtn.Anchor = AnchorStyles.None
        schedbtn.BackColor = Color.Blue
        schedbtn.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        schedbtn.ForeColor = Color.White
        schedbtn.Location = New Point(19, 893)
        schedbtn.Margin = New Padding(6)
        schedbtn.Name = "schedbtn"
        schedbtn.Size = New Size(347, 61)
        schedbtn.TabIndex = 8
        schedbtn.Text = "Schedule"
        schedbtn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Blue
        Label1.ImageAlign = ContentAlignment.TopRight
        Label1.Location = New Point(4, 292)
        Label1.Margin = New Padding(6, 0, 6, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(386, 110)
        Label1.TabIndex = 3
        Label1.Text = "Faculty Loading" & vbCrLf & "       System"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Gold
        GroupBox1.Controls.Add(schedbtn)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(subjectbtn)
        GroupBox1.Controls.Add(roombtn)
        GroupBox1.Controls.Add(instructorbtn)
        GroupBox1.Controls.Add(coursebtn)
        GroupBox1.Location = New Point(0, -40)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(395, 1103)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.cmicmicmi
        PictureBox2.Location = New Point(0, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(2000, 1061)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(15F, 37F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1445, 1055)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox2)
        Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(6)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MENU"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents instructorbtn As Button
    Friend WithEvents coursebtn As Button
    Friend WithEvents subjectbtn As Button
    Friend WithEvents roombtn As Button
    Friend WithEvents schedbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
