<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Schedule
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
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DataGridView1 = New DataGridView()
        Column11 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        DataGridView2 = New DataGridView()
        Column12 = New DataGridViewTextBoxColumn()
        Columndel = New DataGridViewButtonColumn()
        Columnsub = New DataGridViewTextBoxColumn()
        Columnunits = New DataGridViewTextBoxColumn()
        Columncourse = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Columnday = New DataGridViewTextBoxColumn()
        Columntime = New DataGridViewTextBoxColumn()
        Columnroom = New DataGridViewTextBoxColumn()
        ErrorProvider1 = New ErrorProvider(components)
        PictureBox3 = New PictureBox()
        savebtn = New Button()
        ExportToExcelButton = New Button()
        Label5 = New Label()
        Label6 = New Label()
        Button3 = New Button()
        Label4 = New Label()
        SaveFileDialog1 = New SaveFileDialog()
        ComboBox2 = New ComboBox()
        Label2 = New Label()
        label3 = New Label()
        ComboBox3 = New ComboBox()
        ComboBox4 = New ComboBox()
        Label7 = New Label()
        Label8 = New Label()
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        ComboBox5 = New ComboBox()
        GroupBox2 = New GroupBox()
        GroupBox1 = New GroupBox()
        Label9 = New Label()
        PictureBox2 = New PictureBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.Anchor = AnchorStyles.None
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column11, Column1, Column2, Column3, Column4, Column10, Column8, Column7, Column6, Column5})
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = SystemColors.Window
        DataGridViewCellStyle9.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle9.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle9
        DataGridView1.Location = New Point(495, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(1363, 452)
        DataGridView1.TabIndex = 6
        ' 
        ' Column11
        ' 
        Column11.HeaderText = "Subject_Id"
        Column11.MinimumWidth = 6
        Column11.Name = "Column11"
        Column11.Visible = False
        Column11.Width = 125
        ' 
        ' Column1
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Column1.DefaultCellStyle = DataGridViewCellStyle2
        Column1.HeaderText = "Subject Code"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Resizable = DataGridViewTriState.True
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Description"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Resizable = DataGridViewTriState.True
        Column2.Width = 350
        ' 
        ' Column3
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        Column3.DefaultCellStyle = DataGridViewCellStyle3
        Column3.HeaderText = "Units"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        Column4.DefaultCellStyle = DataGridViewCellStyle4
        Column4.HeaderText = "Course"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Resizable = DataGridViewTriState.True
        Column4.SortMode = DataGridViewColumnSortMode.NotSortable
        Column4.Width = 125
        ' 
        ' Column10
        ' 
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        Column10.DefaultCellStyle = DataGridViewCellStyle5
        Column10.HeaderText = "Year"
        Column10.MinimumWidth = 6
        Column10.Name = "Column10"
        Column10.Resizable = DataGridViewTriState.True
        Column10.Width = 90
        ' 
        ' Column8
        ' 
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        Column8.DefaultCellStyle = DataGridViewCellStyle6
        Column8.HeaderText = "Section"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.Resizable = DataGridViewTriState.True
        Column8.Width = 90
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Day"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.Resizable = DataGridViewTriState.True
        Column7.Width = 125
        ' 
        ' Column6
        ' 
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.TopLeft
        Column6.DefaultCellStyle = DataGridViewCellStyle7
        Column6.HeaderText = "Time"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.Resizable = DataGridViewTriState.True
        Column6.Width = 150
        ' 
        ' Column5
        ' 
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter
        Column5.DefaultCellStyle = DataGridViewCellStyle8
        Column5.HeaderText = "Room"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.Width = 125
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.Anchor = AnchorStyles.None
        DataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = SystemColors.Control
        DataGridViewCellStyle10.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle10.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = DataGridViewTriState.True
        DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {Column12, Columndel, Columnsub, Columnunits, Columncourse, Column9, Columnday, Columntime, Columnroom})
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = SystemColors.Window
        DataGridViewCellStyle11.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle11.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = DataGridViewTriState.False
        DataGridView2.DefaultCellStyle = DataGridViewCellStyle11
        DataGridView2.Location = New Point(495, 510)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.RowTemplate.Height = 29
        DataGridView2.Size = New Size(1052, 417)
        DataGridView2.TabIndex = 7
        ' 
        ' Column12
        ' 
        Column12.HeaderText = "Subject_Id"
        Column12.MinimumWidth = 6
        Column12.Name = "Column12"
        Column12.Visible = False
        Column12.Width = 125
        ' 
        ' Columndel
        ' 
        Columndel.HeaderText = "Delete"
        Columndel.MinimumWidth = 6
        Columndel.Name = "Columndel"
        Columndel.Resizable = DataGridViewTriState.True
        Columndel.SortMode = DataGridViewColumnSortMode.Automatic
        Columndel.Width = 80
        ' 
        ' Columnsub
        ' 
        Columnsub.HeaderText = "Subject"
        Columnsub.MinimumWidth = 6
        Columnsub.Name = "Columnsub"
        Columnsub.Width = 350
        ' 
        ' Columnunits
        ' 
        Columnunits.HeaderText = "Units"
        Columnunits.MinimumWidth = 6
        Columnunits.Name = "Columnunits"
        Columnunits.Width = 55
        ' 
        ' Columncourse
        ' 
        Columncourse.HeaderText = "Course"
        Columncourse.MinimumWidth = 6
        Columncourse.Name = "Columncourse"
        Columncourse.ReadOnly = True
        Columncourse.Resizable = DataGridViewTriState.True
        Columncourse.SortMode = DataGridViewColumnSortMode.NotSortable
        Columncourse.Width = 90
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "Section"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.Width = 80
        ' 
        ' Columnday
        ' 
        Columnday.HeaderText = "Day"
        Columnday.MinimumWidth = 6
        Columnday.Name = "Columnday"
        Columnday.Resizable = DataGridViewTriState.True
        Columnday.Width = 110
        ' 
        ' Columntime
        ' 
        Columntime.HeaderText = "Time"
        Columntime.MinimumWidth = 6
        Columntime.Name = "Columntime"
        Columntime.Width = 120
        ' 
        ' Columnroom
        ' 
        Columnroom.HeaderText = "Room"
        Columnroom.MinimumWidth = 6
        Columnroom.Name = "Columnroom"
        Columnroom.Width = 110
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' PictureBox3
        ' 
        ErrorProvider1.SetIconAlignment(PictureBox3, ErrorIconAlignment.BottomRight)
        PictureBox3.Image = My.Resources.Resources.cmicmicmi1
        PictureBox3.Location = New Point(-8, -6)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(2100, 1200)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 20
        PictureBox3.TabStop = False
        ' 
        ' savebtn
        ' 
        savebtn.Anchor = AnchorStyles.Right
        savebtn.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        savebtn.Font = New Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        savebtn.Location = New Point(1578, 810)
        savebtn.Name = "savebtn"
        savebtn.Size = New Size(251, 49)
        savebtn.TabIndex = 10
        savebtn.Text = "Save"
        savebtn.UseVisualStyleBackColor = False
        ' 
        ' ExportToExcelButton
        ' 
        ExportToExcelButton.Anchor = AnchorStyles.Right
        ExportToExcelButton.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        ExportToExcelButton.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ExportToExcelButton.Location = New Point(1578, 865)
        ExportToExcelButton.Name = "ExportToExcelButton"
        ExportToExcelButton.Size = New Size(251, 49)
        ExportToExcelButton.TabIndex = 11
        ExportToExcelButton.Text = "View Plot"
        ExportToExcelButton.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label5.Location = New Point(1578, 528)
        Label5.Name = "Label5"
        Label5.Size = New Size(148, 33)
        Label5.TabIndex = 12
        Label5.Text = "Total Units: "
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label6.Location = New Point(495, 467)
        Label6.Name = "Label6"
        Label6.Size = New Size(353, 40)
        Label6.TabIndex = 13
        Label6.Text = "Temporary Schedule"
        Label6.UseMnemonic = False
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(12, 22)
        Button3.Name = "Button3"
        Button3.Size = New Size(97, 35)
        Button3.TabIndex = 14
        Button3.Text = "Back"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label4.Location = New Point(58, 74)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 51)
        Label4.TabIndex = 18
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Anchor = AnchorStyles.None
        ComboBox2.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"1ST SEMESTER", "2ND SEMESTER"})
        ComboBox2.Location = New Point(10, 237)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(268, 34)
        ComboBox2.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(12, 201)
        Label2.Name = "Label2"
        Label2.Size = New Size(143, 33)
        Label2.TabIndex = 4
        Label2.Text = "Semester"
        ' 
        ' label3
        ' 
        label3.Anchor = AnchorStyles.None
        label3.AutoSize = True
        label3.Font = New Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        label3.Location = New Point(12, 293)
        label3.Name = "label3"
        label3.Size = New Size(175, 33)
        label3.TabIndex = 5
        label3.Text = "School Year"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.Anchor = AnchorStyles.None
        ComboBox3.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"2023-2024", "2024-2025", "2025-2026", "2026-2027", "2027-2028", "2028-2029", "2029-2030", "2030-2031"})
        ComboBox3.Location = New Point(10, 329)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(268, 34)
        ComboBox3.TabIndex = 2
        ' 
        ' ComboBox4
        ' 
        ComboBox4.Anchor = AnchorStyles.None
        ComboBox4.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox4.FormattingEnabled = True
        ComboBox4.Items.AddRange(New Object() {"JOBER REYES", "SUSANA TOLENTINO", "MARICRIS EUGENIO", "ALDRICH BERNARDO", "JERIC CASTILLO", "JOMEL FEDERESO", "ROBERT GALLARDO"})
        ComboBox4.Location = New Point(10, 137)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(268, 34)
        ComboBox4.TabIndex = 18
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(10, 101)
        Label7.Name = "Label7"
        Label7.Size = New Size(111, 33)
        Label7.TabIndex = 19
        Label7.Text = "Course"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.None
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(12, 389)
        Label8.Name = "Label8"
        Label8.Size = New Size(154, 33)
        Label8.TabIndex = 20
        Label8.Text = "Year Level"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.Left
        ComboBox1.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"JOBER REYES", "SUSANA TOLENTINO", "MARICRIS EUGENIO", "ALDRICH BERNARDO", "JERIC CASTILLO", "JOMEL FEDERESO", "ROBERT GALLARDO"})
        ComboBox1.Location = New Point(10, 46)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(268, 34)
        ComboBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(10, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 33)
        Label1.TabIndex = 3
        Label1.Text = "Instructor"
        ' 
        ' ComboBox5
        ' 
        ComboBox5.Anchor = AnchorStyles.None
        ComboBox5.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox5.FormattingEnabled = True
        ComboBox5.Items.AddRange(New Object() {"2023-2024", "2024-2025", "2025-2026", "2026-2027", "2027-2028", "2028-2029", "2029-2030", "2030-2031"})
        ComboBox5.Location = New Point(10, 424)
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New Size(268, 34)
        ComboBox5.TabIndex = 21
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.None
        GroupBox2.BackColor = Color.Gold
        GroupBox2.Controls.Add(ComboBox5)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(ComboBox1)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(ComboBox4)
        GroupBox2.Controls.Add(ComboBox3)
        GroupBox2.Controls.Add(label3)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(ComboBox2)
        GroupBox2.Location = New Point(44, 422)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(307, 584)
        GroupBox2.TabIndex = 17
        GroupBox2.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Gold
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(PictureBox2)
        GroupBox1.Controls.Add(GroupBox2)
        GroupBox1.Location = New Point(0, -6)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(395, 1062)
        GroupBox1.TabIndex = 21
        GroupBox1.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.None
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = Color.Blue
        Label9.ImageAlign = ContentAlignment.TopRight
        Label9.Location = New Point(44, 293)
        Label9.Margin = New Padding(6, 0, 6, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(320, 92)
        Label9.TabIndex = 23
        Label9.Text = "Faculty Loading" & vbCrLf & "       System"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.cmilogo_removebg_preview__2_
        PictureBox2.Location = New Point(67, 67)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(264, 198)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 22
        PictureBox2.TabStop = False
        ' 
        ' Schedule
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 935)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Button3)
        Controls.Add(Label5)
        Controls.Add(ExportToExcelButton)
        Controls.Add(savebtn)
        Controls.Add(DataGridView2)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox3)
        Name = "Schedule"
        StartPosition = FormStartPosition.CenterScreen
        Text = "schedule"
        WindowState = FormWindowState.Maximized
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ExportToExcelButton As Button
    Friend WithEvents savebtn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Column0 As DataGridViewButtonColumn
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Columndel As DataGridViewButtonColumn
    Friend WithEvents Columnsub As DataGridViewTextBoxColumn
    Friend WithEvents Columnunits As DataGridViewTextBoxColumn
    Friend WithEvents Columncourse As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Columnday As DataGridViewTextBoxColumn
    Friend WithEvents Columntime As DataGridViewTextBoxColumn
    Friend WithEvents Columnroom As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
