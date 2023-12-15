<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        room_id = New DataGridViewTextBoxColumn()
        roomno = New DataGridViewTextBoxColumn()
        GroupBox1 = New GroupBox()
        Label7 = New Label()
        Button2 = New Button()
        PictureBox2 = New PictureBox()
        Button1 = New Button()
        Label2 = New Label()
        room = New TextBox()
        backroombtn = New Button()
        ImageList1 = New ImageList(components)
        PictureBox1 = New PictureBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label1.Location = New Point(939, 152)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 51)
        Label1.TabIndex = 6
        Label1.Text = "Room" & vbCrLf
        Label1.UseMnemonic = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.Anchor = AnchorStyles.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {room_id, roomno})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.Location = New Point(939, 230)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(453, 586)
        DataGridView1.TabIndex = 7
        ' 
        ' room_id
        ' 
        room_id.HeaderText = "Room_ID"
        room_id.MinimumWidth = 6
        room_id.Name = "room_id"
        room_id.Visible = False
        room_id.Width = 125
        ' 
        ' roomno
        ' 
        roomno.HeaderText = "Room No."
        roomno.MinimumWidth = 6
        roomno.Name = "roomno"
        roomno.ReadOnly = True
        roomno.Width = 400
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top
        GroupBox1.BackColor = Color.Gold
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(PictureBox2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(room)
        GroupBox1.Location = New Point(-4, -7)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(395, 1062)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.Blue
        Label7.ImageAlign = ContentAlignment.TopRight
        Label7.Location = New Point(44, 293)
        Label7.Margin = New Padding(6, 0, 6, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(320, 92)
        Label7.TabIndex = 22
        Label7.Text = "Faculty Loading" & vbCrLf & "       System"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Button2.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(213, 802)
        Button2.Name = "Button2"
        Button2.Size = New Size(111, 37)
        Button2.TabIndex = 5
        Button2.Text = "Edit"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.cmilogo_removebg_preview__2_
        PictureBox2.Location = New Point(73, 77)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(264, 198)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 21
        PictureBox2.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Blue
        Button1.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(56, 802)
        Button1.Name = "Button1"
        Button1.Size = New Size(111, 37)
        Button1.TabIndex = 4
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(56, 625)
        Label2.Name = "Label2"
        Label2.Size = New Size(123, 33)
        Label2.TabIndex = 2
        Label2.Text = "Room No."
        ' 
        ' room
        ' 
        room.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        room.Location = New Point(56, 659)
        room.Name = "room"
        room.Size = New Size(268, 34)
        room.TabIndex = 0
        ' 
        ' backroombtn
        ' 
        backroombtn.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        backroombtn.Location = New Point(12, 12)
        backroombtn.Name = "backroombtn"
        backroombtn.Size = New Size(97, 35)
        backroombtn.TabIndex = 8
        backroombtn.Text = "Back"
        backroombtn.UseVisualStyleBackColor = True
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth8Bit
        ImageList1.ImageSize = New Size(16, 16)
        ImageList1.TransparentColor = Color.Transparent
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.cmicmicmi1
        PictureBox1.Location = New Point(-4, -7)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1942, 1063)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 1055)
        Controls.Add(backroombtn)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ROOM"
        WindowState = FormWindowState.Maximized
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents room As TextBox
    Friend WithEvents backroombtn As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents room_id As DataGridViewTextBoxColumn
    Friend WithEvents roomno As DataGridViewTextBoxColumn
End Class
