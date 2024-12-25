<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FINAL_GRADE
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
        SectionCodeTextBox1 = New TextBox()
        Label31 = New Label()
        SubjectCodeTextBox1 = New TextBox()
        Label30 = New Label()
        Label28 = New Label()
        StudentIDTextBox1 = New TextBox()
        PopulateButton1 = New Button()
        EditButton1 = New Button()
        DataGridView1 = New DataGridView()
        BackgroundPanel = New Panel()
        Label25 = New Label()
        cbSUB = New ComboBox()
        SubjectLbl = New Label()
        cbStudentID = New ComboBox()
        SemesterLbl = New Label()
        cbSEC = New ComboBox()
        ProfAccInfoMessageLbl = New Label()
        DesignPanel = New Panel()
        Panel1 = New Panel()
        Label1 = New Label()
        cbSUB1 = New ComboBox()
        Label2 = New Label()
        cbSTUD1 = New ComboBox()
        Label3 = New Label()
        cbSEC1 = New ComboBox()
        Label4 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        BackgroundPanel.SuspendLayout()
        DesignPanel.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' SectionCodeTextBox1
        ' 
        SectionCodeTextBox1.Enabled = False
        SectionCodeTextBox1.Font = New Font("Tahoma", 10.2F, FontStyle.Bold)
        SectionCodeTextBox1.Location = New Point(796, 276)
        SectionCodeTextBox1.Multiline = True
        SectionCodeTextBox1.Name = "SectionCodeTextBox1"
        SectionCodeTextBox1.ReadOnly = True
        SectionCodeTextBox1.Size = New Size(234, 27)
        SectionCodeTextBox1.TabIndex = 184
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.BackColor = Color.Transparent
        Label31.Font = New Font("Tahoma", 7.8F, FontStyle.Bold)
        Label31.ForeColor = SystemColors.ActiveCaptionText
        Label31.Location = New Point(799, 256)
        Label31.Name = "Label31"
        Label31.Size = New Size(91, 16)
        Label31.TabIndex = 183
        Label31.Text = "Section Code"
        ' 
        ' SubjectCodeTextBox1
        ' 
        SubjectCodeTextBox1.Enabled = False
        SubjectCodeTextBox1.Font = New Font("Tahoma", 10.2F, FontStyle.Bold)
        SubjectCodeTextBox1.ForeColor = Color.Black
        SubjectCodeTextBox1.Location = New Point(541, 276)
        SubjectCodeTextBox1.MaxLength = 35
        SubjectCodeTextBox1.Multiline = True
        SubjectCodeTextBox1.Name = "SubjectCodeTextBox1"
        SubjectCodeTextBox1.ReadOnly = True
        SubjectCodeTextBox1.Size = New Size(234, 27)
        SubjectCodeTextBox1.TabIndex = 181
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Font = New Font("Tahoma", 7.8F, FontStyle.Bold)
        Label30.ForeColor = Color.Black
        Label30.Location = New Point(545, 257)
        Label30.Name = "Label30"
        Label30.Size = New Size(92, 16)
        Label30.TabIndex = 180
        Label30.Text = "Subject Code"
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Tahoma", 7.8F, FontStyle.Bold)
        Label28.ForeColor = Color.Black
        Label28.Location = New Point(282, 257)
        Label28.Name = "Label28"
        Label28.Size = New Size(77, 16)
        Label28.TabIndex = 178
        Label28.Text = "Student ID"
        ' 
        ' StudentIDTextBox1
        ' 
        StudentIDTextBox1.Enabled = False
        StudentIDTextBox1.Font = New Font("Tahoma", 10.2F, FontStyle.Bold)
        StudentIDTextBox1.ForeColor = Color.Black
        StudentIDTextBox1.Location = New Point(278, 276)
        StudentIDTextBox1.MaxLength = 8
        StudentIDTextBox1.Multiline = True
        StudentIDTextBox1.Name = "StudentIDTextBox1"
        StudentIDTextBox1.ReadOnly = True
        StudentIDTextBox1.Size = New Size(233, 27)
        StudentIDTextBox1.TabIndex = 179
        ' 
        ' PopulateButton1
        ' 
        PopulateButton1.BackColor = Color.GhostWhite
        PopulateButton1.Font = New Font("Tahoma", 7.8F, FontStyle.Bold)
        PopulateButton1.Location = New Point(38, 155)
        PopulateButton1.Name = "PopulateButton1"
        PopulateButton1.Size = New Size(136, 40)
        PopulateButton1.TabIndex = 175
        PopulateButton1.Text = "Populate"
        PopulateButton1.UseVisualStyleBackColor = False
        ' 
        ' EditButton1
        ' 
        EditButton1.Font = New Font("Tahoma", 7.8F, FontStyle.Bold)
        EditButton1.Location = New Point(37, 101)
        EditButton1.Name = "EditButton1"
        EditButton1.Size = New Size(137, 38)
        EditButton1.TabIndex = 16
        EditButton1.Text = "Edit"
        EditButton1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(194, 29)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(985, 205)
        DataGridView1.TabIndex = 11
        ' 
        ' BackgroundPanel
        ' 
        BackgroundPanel.BackColor = Color.LightSteelBlue
        BackgroundPanel.Controls.Add(SectionCodeTextBox1)
        BackgroundPanel.Controls.Add(Label31)
        BackgroundPanel.Controls.Add(SubjectCodeTextBox1)
        BackgroundPanel.Controls.Add(Label30)
        BackgroundPanel.Controls.Add(Label28)
        BackgroundPanel.Controls.Add(StudentIDTextBox1)
        BackgroundPanel.Controls.Add(PopulateButton1)
        BackgroundPanel.Controls.Add(EditButton1)
        BackgroundPanel.Controls.Add(DataGridView1)
        BackgroundPanel.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BackgroundPanel.ForeColor = Color.MidnightBlue
        BackgroundPanel.Location = New Point(12, 139)
        BackgroundPanel.Name = "BackgroundPanel"
        BackgroundPanel.Size = New Size(1229, 348)
        BackgroundPanel.TabIndex = 171
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Segoe UI", 10.2F)
        Label25.ForeColor = Color.White
        Label25.Location = New Point(32, 59)
        Label25.Name = "Label25"
        Label25.Size = New Size(66, 23)
        Label25.TabIndex = 182
        Label25.Text = "Section"
        ' 
        ' cbSUB
        ' 
        cbSUB.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        cbSUB.FormattingEnabled = True
        cbSUB.Items.AddRange(New Object() {""})
        cbSUB.Location = New Point(592, 85)
        cbSUB.Name = "cbSUB"
        cbSUB.Size = New Size(251, 26)
        cbSUB.TabIndex = 177
        ' 
        ' SubjectLbl
        ' 
        SubjectLbl.AutoSize = True
        SubjectLbl.Font = New Font("Tahoma", 10.2F)
        SubjectLbl.ForeColor = Color.White
        SubjectLbl.Location = New Point(593, 59)
        SubjectLbl.Name = "SubjectLbl"
        SubjectLbl.Size = New Size(65, 21)
        SubjectLbl.TabIndex = 179
        SubjectLbl.Text = "Subject"
        ' 
        ' cbStudentID
        ' 
        cbStudentID.AutoCompleteCustomSource.AddRange(New String() {"1st Sem", "2nd Sem"})
        cbStudentID.AutoCompleteMode = AutoCompleteMode.Suggest
        cbStudentID.AutoCompleteSource = AutoCompleteSource.CustomSource
        cbStudentID.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        cbStudentID.FormattingEnabled = True
        cbStudentID.Location = New Point(315, 85)
        cbStudentID.Name = "cbStudentID"
        cbStudentID.Size = New Size(251, 26)
        cbStudentID.TabIndex = 181
        ' 
        ' SemesterLbl
        ' 
        SemesterLbl.AutoSize = True
        SemesterLbl.BackColor = Color.Transparent
        SemesterLbl.Font = New Font("Tahoma", 10.2F)
        SemesterLbl.ForeColor = Color.White
        SemesterLbl.Location = New Point(315, 59)
        SemesterLbl.Name = "SemesterLbl"
        SemesterLbl.Size = New Size(90, 21)
        SemesterLbl.TabIndex = 180
        SemesterLbl.Text = "Student ID"
        ' 
        ' cbSEC
        ' 
        cbSEC.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        cbSEC.FormattingEnabled = True
        cbSEC.Items.AddRange(New Object() {""})
        cbSEC.Location = New Point(34, 85)
        cbSEC.Name = "cbSEC"
        cbSEC.Size = New Size(251, 26)
        cbSEC.TabIndex = 178
        ' 
        ' ProfAccInfoMessageLbl
        ' 
        ProfAccInfoMessageLbl.AutoSize = True
        ProfAccInfoMessageLbl.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        ProfAccInfoMessageLbl.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        ProfAccInfoMessageLbl.ForeColor = Color.Gold
        ProfAccInfoMessageLbl.Location = New Point(15, 18)
        ProfAccInfoMessageLbl.Name = "ProfAccInfoMessageLbl"
        ProfAccInfoMessageLbl.Size = New Size(298, 18)
        ProfAccInfoMessageLbl.TabIndex = 1
        ProfAccInfoMessageLbl.Text = "PROFESSOR ACCOUNT INFORMATION"
        ' 
        ' DesignPanel
        ' 
        DesignPanel.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        DesignPanel.Controls.Add(Label25)
        DesignPanel.Controls.Add(cbSUB)
        DesignPanel.Controls.Add(SubjectLbl)
        DesignPanel.Controls.Add(cbStudentID)
        DesignPanel.Controls.Add(SemesterLbl)
        DesignPanel.Controls.Add(cbSEC)
        DesignPanel.Controls.Add(ProfAccInfoMessageLbl)
        DesignPanel.Location = New Point(-32, -176)
        DesignPanel.Name = "DesignPanel"
        DesignPanel.Size = New Size(1229, 131)
        DesignPanel.TabIndex = 170
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(cbSUB1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(cbSTUD1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(cbSEC1)
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(15, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1229, 131)
        Panel1.TabIndex = 174
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(32, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 23)
        Label1.TabIndex = 182
        Label1.Text = "Section"
        ' 
        ' cbSUB1
        ' 
        cbSUB1.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        cbSUB1.FormattingEnabled = True
        cbSUB1.Items.AddRange(New Object() {""})
        cbSUB1.Location = New Point(592, 85)
        cbSUB1.Name = "cbSUB1"
        cbSUB1.Size = New Size(251, 26)
        cbSUB1.TabIndex = 177
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 10.2F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(593, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 21)
        Label2.TabIndex = 179
        Label2.Text = "Subject"
        ' 
        ' cbSTUD1
        ' 
        cbSTUD1.AutoCompleteCustomSource.AddRange(New String() {"1st Sem", "2nd Sem"})
        cbSTUD1.AutoCompleteMode = AutoCompleteMode.Suggest
        cbSTUD1.AutoCompleteSource = AutoCompleteSource.CustomSource
        cbSTUD1.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        cbSTUD1.FormattingEnabled = True
        cbSTUD1.Location = New Point(315, 85)
        cbSTUD1.Name = "cbSTUD1"
        cbSTUD1.Size = New Size(251, 26)
        cbSTUD1.TabIndex = 181
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Tahoma", 10.2F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(315, 59)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 21)
        Label3.TabIndex = 180
        Label3.Text = "Student ID"
        ' 
        ' cbSEC1
        ' 
        cbSEC1.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        cbSEC1.FormattingEnabled = True
        cbSEC1.Items.AddRange(New Object() {""})
        cbSEC1.Location = New Point(34, 85)
        cbSEC1.Name = "cbSEC1"
        cbSEC1.Size = New Size(251, 26)
        cbSEC1.TabIndex = 178
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label4.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.Gold
        Label4.Location = New Point(15, 18)
        Label4.Name = "Label4"
        Label4.Size = New Size(298, 18)
        Label4.TabIndex = 1
        Label4.Text = "PROFESSOR ACCOUNT INFORMATION"
        ' 
        ' FINAL_GRADE
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1203, 486)
        Controls.Add(Panel1)
        Controls.Add(BackgroundPanel)
        Controls.Add(DesignPanel)
        Name = "FINAL_GRADE"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FINAL_GRADE"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        BackgroundPanel.ResumeLayout(False)
        BackgroundPanel.PerformLayout()
        DesignPanel.ResumeLayout(False)
        DesignPanel.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents SectionCodeTextBox1 As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents SubjectCodeTextBox1 As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents StudentIDTextBox1 As TextBox
    Friend WithEvents PopulateButton1 As Button
    Friend WithEvents EditButton1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents exitbtn As Button
    Friend WithEvents BackgroundPanel As Panel
    Friend WithEvents Label25 As Label
    Friend WithEvents cbSUB As ComboBox
    Friend WithEvents SubjectLbl As Label
    Friend WithEvents cbStudentID As ComboBox
    Friend WithEvents SemesterLbl As Label
    Friend WithEvents cbSEC As ComboBox
    Friend WithEvents ProfAccInfoMessageLbl As Label
    Friend WithEvents DesignPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cbSUB1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbSTUD1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbSEC1 As ComboBox
    Friend WithEvents Label4 As Label
End Class
