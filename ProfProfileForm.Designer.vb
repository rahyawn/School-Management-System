<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfProfileForm
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
        DesignPanel = New Panel()
        Label25 = New Label()
        cbSUB = New ComboBox()
        SubjectLbl = New Label()
        cbStudentID = New ComboBox()
        SemesterLbl = New Label()
        cbSEC = New ComboBox()
        ProfAccInfoMessageLbl = New Label()
        BackgroundPanel = New Panel()
        SectionCodeTextBox = New TextBox()
        Label31 = New Label()
        SubjectCodeTextBox = New TextBox()
        Label30 = New Label()
        Label28 = New Label()
        StudentIDTextBox = New TextBox()
        PopulateButton = New Button()
        EditButton = New Button()
        DataGridView1 = New DataGridView()
        exitbtn = New Button()
        DesignPanel.SuspendLayout()
        BackgroundPanel.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        DesignPanel.Location = New Point(12, 12)
        DesignPanel.Name = "DesignPanel"
        DesignPanel.Size = New Size(1229, 131)
        DesignPanel.TabIndex = 0
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
        ' BackgroundPanel
        ' 
        BackgroundPanel.BackColor = Color.LightSteelBlue
        BackgroundPanel.Controls.Add(exitbtn)
        BackgroundPanel.Controls.Add(SectionCodeTextBox)
        BackgroundPanel.Controls.Add(Label31)
        BackgroundPanel.Controls.Add(SubjectCodeTextBox)
        BackgroundPanel.Controls.Add(Label30)
        BackgroundPanel.Controls.Add(Label28)
        BackgroundPanel.Controls.Add(StudentIDTextBox)
        BackgroundPanel.Controls.Add(PopulateButton)
        BackgroundPanel.Controls.Add(EditButton)
        BackgroundPanel.Controls.Add(DataGridView1)
        BackgroundPanel.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BackgroundPanel.ForeColor = Color.MidnightBlue
        BackgroundPanel.Location = New Point(12, 149)
        BackgroundPanel.Name = "BackgroundPanel"
        BackgroundPanel.Size = New Size(1229, 348)
        BackgroundPanel.TabIndex = 1
        ' 
        ' SectionCodeTextBox
        ' 
        SectionCodeTextBox.Enabled = False
        SectionCodeTextBox.Font = New Font("Tahoma", 10.2F, FontStyle.Bold)
        SectionCodeTextBox.Location = New Point(828, 288)
        SectionCodeTextBox.Multiline = True
        SectionCodeTextBox.Name = "SectionCodeTextBox"
        SectionCodeTextBox.ReadOnly = True
        SectionCodeTextBox.Size = New Size(234, 27)
        SectionCodeTextBox.TabIndex = 184
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.BackColor = Color.Transparent
        Label31.Font = New Font("Tahoma", 7.8F, FontStyle.Bold)
        Label31.ForeColor = SystemColors.ActiveCaptionText
        Label31.Location = New Point(831, 268)
        Label31.Name = "Label31"
        Label31.Size = New Size(91, 16)
        Label31.TabIndex = 183
        Label31.Text = "Section Code"
        ' 
        ' SubjectCodeTextBox
        ' 
        SubjectCodeTextBox.Enabled = False
        SubjectCodeTextBox.Font = New Font("Tahoma", 10.2F, FontStyle.Bold)
        SubjectCodeTextBox.ForeColor = Color.Black
        SubjectCodeTextBox.Location = New Point(573, 288)
        SubjectCodeTextBox.MaxLength = 35
        SubjectCodeTextBox.Multiline = True
        SubjectCodeTextBox.Name = "SubjectCodeTextBox"
        SubjectCodeTextBox.ReadOnly = True
        SubjectCodeTextBox.Size = New Size(234, 27)
        SubjectCodeTextBox.TabIndex = 181
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Font = New Font("Tahoma", 7.8F, FontStyle.Bold)
        Label30.ForeColor = Color.Black
        Label30.Location = New Point(577, 269)
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
        Label28.Location = New Point(314, 269)
        Label28.Name = "Label28"
        Label28.Size = New Size(77, 16)
        Label28.TabIndex = 178
        Label28.Text = "Student ID"
        ' 
        ' StudentIDTextBox
        ' 
        StudentIDTextBox.Enabled = False
        StudentIDTextBox.Font = New Font("Tahoma", 10.2F, FontStyle.Bold)
        StudentIDTextBox.ForeColor = Color.Black
        StudentIDTextBox.Location = New Point(310, 288)
        StudentIDTextBox.MaxLength = 8
        StudentIDTextBox.Multiline = True
        StudentIDTextBox.Name = "StudentIDTextBox"
        StudentIDTextBox.ReadOnly = True
        StudentIDTextBox.Size = New Size(233, 27)
        StudentIDTextBox.TabIndex = 179
        ' 
        ' PopulateButton
        ' 
        PopulateButton.BackColor = Color.GhostWhite
        PopulateButton.Font = New Font("Tahoma", 7.8F, FontStyle.Bold)
        PopulateButton.Location = New Point(34, 102)
        PopulateButton.Name = "PopulateButton"
        PopulateButton.Size = New Size(136, 40)
        PopulateButton.TabIndex = 175
        PopulateButton.Text = "Populate"
        PopulateButton.UseVisualStyleBackColor = False
        ' 
        ' EditButton
        ' 
        EditButton.Font = New Font("Tahoma", 7.8F, FontStyle.Bold)
        EditButton.Location = New Point(32, 58)
        EditButton.Name = "EditButton"
        EditButton.Size = New Size(137, 38)
        EditButton.TabIndex = 16
        EditButton.Text = "Edit"
        EditButton.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(198, 48)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(985, 205)
        DataGridView1.TabIndex = 11
        ' 
        ' exitbtn
        ' 
        exitbtn.BackColor = Color.LightCoral
        exitbtn.Location = New Point(34, 187)
        exitbtn.Name = "exitbtn"
        exitbtn.Size = New Size(135, 42)
        exitbtn.TabIndex = 169
        exitbtn.Text = "Exit"
        exitbtn.UseVisualStyleBackColor = False
        ' 
        ' ProfProfileForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1244, 496)
        Controls.Add(BackgroundPanel)
        Controls.Add(DesignPanel)
        Name = "ProfProfileForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ProfProfileForm"
        DesignPanel.ResumeLayout(False)
        DesignPanel.PerformLayout()
        BackgroundPanel.ResumeLayout(False)
        BackgroundPanel.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DesignPanel As Panel
    Friend WithEvents BackgroundPanel As Panel
    Friend WithEvents ProfAccInfoMessageLbl As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cancelbtn As Button
    Friend WithEvents savebtn As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents resetBtn As Button
    Friend WithEvents PopulateButton As Button
    Friend WithEvents btnSEARC As Button
    Friend WithEvents txtSEARC As TextBox
    Friend WithEvents showGradeBtn As Button
    Friend WithEvents exitbtn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents cbSUB As ComboBox
    Friend WithEvents SubjectLbl As Label
    Friend WithEvents cbSEM As ComboBox
    Friend WithEvents SemesterLbl As Label
    Friend WithEvents cbSEC As ComboBox
    Friend WithEvents Label28 As Label
    Friend WithEvents StudentIDTextBox As TextBox
    Friend WithEvents SubjectCodeTextBox As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents SectionCodeTextBox As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents cbExams As ComboBox
    Friend WithEvents cbStudentID As ComboBox
    Friend WithEvents Button1 As Button
End Class
