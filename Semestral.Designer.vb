<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SemestralForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SemestralForm))
        GradingSystemPanel = New Panel()
        PlpLogoPicBox = New PictureBox()
        CCSLogoPicBox = New PictureBox()
        GradingSystemLbl = New Label()
        Sub_txt = New TextBox()
        Label26 = New Label()
        resetBtn = New Button()
        sectionTxtBox = New TextBox()
        btnPopulate = New Button()
        btnSEARC = New Button()
        txtSEARC = New TextBox()
        Label25 = New Label()
        cbSUB = New ComboBox()
        SubjectLbl = New Label()
        dgvFinals = New DataGridView()
        cbSEM = New ComboBox()
        SemesterLbl = New Label()
        cbSEC = New ComboBox()
        SectionLbl = New Label()
        FullnameReminderLbl = New Label()
        StudentNameTxtBox = New TextBox()
        StudentIdLbl = New Label()
        StudentNameLblbox = New Label()
        StudentIDTxtBox = New TextBox()
        showGradeBtn = New Button()
        ExitBtn = New Button()
        CancelBtn = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TXTmid = New TextBox()
        txtFin = New TextBox()
        txtSem = New TextBox()
        GradeEquivalentPanel = New Panel()
        Fminus = New Label()
        FLbl = New Label()
        CminusLbl = New Label()
        DminusLbl = New Label()
        Dlbl = New Label()
        BminusLbl = New Label()
        Blbl = New Label()
        Clbl = New Label()
        AminusLbl = New Label()
        Albl = New Label()
        GradeEquivalentLbl = New Label()
        SaveBtn = New Button()
        ComputeBtn = New Button()
        Label4 = New Label()
        Label5 = New Label()
        RemarksScoreLbl = New Label()
        GradingSystemPanel.SuspendLayout()
        CType(PlpLogoPicBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(CCSLogoPicBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvFinals, ComponentModel.ISupportInitialize).BeginInit()
        GradeEquivalentPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' GradingSystemPanel
        ' 
        GradingSystemPanel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GradingSystemPanel.BackColor = Color.FromArgb(0, 0, 64)
        GradingSystemPanel.Controls.Add(PlpLogoPicBox)
        GradingSystemPanel.Controls.Add(CCSLogoPicBox)
        GradingSystemPanel.Controls.Add(GradingSystemLbl)
        GradingSystemPanel.Location = New Point(12, 12)
        GradingSystemPanel.Name = "GradingSystemPanel"
        GradingSystemPanel.Size = New Size(1273, 148)
        GradingSystemPanel.TabIndex = 0
        ' 
        ' PlpLogoPicBox
        ' 
        PlpLogoPicBox.Image = CType(resources.GetObject("PlpLogoPicBox.Image"), Image)
        PlpLogoPicBox.Location = New Point(23, 31)
        PlpLogoPicBox.Name = "PlpLogoPicBox"
        PlpLogoPicBox.Size = New Size(104, 94)
        PlpLogoPicBox.SizeMode = PictureBoxSizeMode.Zoom
        PlpLogoPicBox.TabIndex = 16
        PlpLogoPicBox.TabStop = False
        ' 
        ' CCSLogoPicBox
        ' 
        CCSLogoPicBox.Image = CType(resources.GetObject("CCSLogoPicBox.Image"), Image)
        CCSLogoPicBox.Location = New Point(1078, 42)
        CCSLogoPicBox.Name = "CCSLogoPicBox"
        CCSLogoPicBox.Size = New Size(117, 84)
        CCSLogoPicBox.SizeMode = PictureBoxSizeMode.Zoom
        CCSLogoPicBox.TabIndex = 15
        CCSLogoPicBox.TabStop = False
        ' 
        ' GradingSystemLbl
        ' 
        GradingSystemLbl.AutoSize = True
        GradingSystemLbl.Font = New Font("Times New Roman", 16.2F, FontStyle.Bold)
        GradingSystemLbl.ForeColor = SystemColors.ActiveCaption
        GradingSystemLbl.Location = New Point(484, 54)
        GradingSystemLbl.Name = "GradingSystemLbl"
        GradingSystemLbl.Size = New Size(271, 32)
        GradingSystemLbl.TabIndex = 0
        GradingSystemLbl.Text = "GRADING SYSTEM"
        ' 
        ' Sub_txt
        ' 
        Sub_txt.Enabled = False
        Sub_txt.Location = New Point(272, 732)
        Sub_txt.Name = "Sub_txt"
        Sub_txt.Size = New Size(233, 27)
        Sub_txt.TabIndex = 82
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Tahoma", 10.2F)
        Label26.ForeColor = SystemColors.ActiveCaptionText
        Label26.Location = New Point(272, 698)
        Label26.Name = "Label26"
        Label26.Size = New Size(65, 21)
        Label26.TabIndex = 81
        Label26.Text = "Subject"
        ' 
        ' resetBtn
        ' 
        resetBtn.Location = New Point(565, 561)
        resetBtn.Name = "resetBtn"
        resetBtn.Size = New Size(66, 29)
        resetBtn.TabIndex = 80
        resetBtn.Text = "reset"
        resetBtn.UseVisualStyleBackColor = True
        ' 
        ' sectionTxtBox
        ' 
        sectionTxtBox.Enabled = False
        sectionTxtBox.Location = New Point(271, 654)
        sectionTxtBox.Name = "sectionTxtBox"
        sectionTxtBox.ReadOnly = True
        sectionTxtBox.Size = New Size(234, 27)
        sectionTxtBox.TabIndex = 79
        ' 
        ' btnPopulate
        ' 
        btnPopulate.BackColor = Color.Thistle
        btnPopulate.Location = New Point(39, 561)
        btnPopulate.Name = "btnPopulate"
        btnPopulate.Size = New Size(160, 40)
        btnPopulate.TabIndex = 78
        btnPopulate.Text = "Refresh"
        btnPopulate.UseVisualStyleBackColor = False
        ' 
        ' btnSEARC
        ' 
        btnSEARC.BackColor = Color.Cyan
        btnSEARC.Location = New Point(462, 559)
        btnSEARC.Name = "btnSEARC"
        btnSEARC.Size = New Size(104, 42)
        btnSEARC.TabIndex = 77
        btnSEARC.Text = "Search"
        btnSEARC.UseVisualStyleBackColor = False
        ' 
        ' txtSEARC
        ' 
        txtSEARC.Location = New Point(210, 559)
        txtSEARC.Multiline = True
        txtSEARC.Name = "txtSEARC"
        txtSEARC.Size = New Size(246, 42)
        txtSEARC.TabIndex = 76
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Location = New Point(28, 165)
        Label25.Name = "Label25"
        Label25.Size = New Size(58, 20)
        Label25.TabIndex = 75
        Label25.Text = "Section"
        ' 
        ' cbSUB
        ' 
        cbSUB.FormattingEnabled = True
        cbSUB.Items.AddRange(New Object() {"COMP 104", "IT 201", "IT 101", "COMP 105"})
        cbSUB.Location = New Point(444, 197)
        cbSUB.Name = "cbSUB"
        cbSUB.Size = New Size(186, 28)
        cbSUB.TabIndex = 63
        ' 
        ' SubjectLbl
        ' 
        SubjectLbl.AutoSize = True
        SubjectLbl.Font = New Font("Tahoma", 10.2F)
        SubjectLbl.ForeColor = SystemColors.ActiveCaptionText
        SubjectLbl.Location = New Point(444, 162)
        SubjectLbl.Name = "SubjectLbl"
        SubjectLbl.Size = New Size(65, 21)
        SubjectLbl.TabIndex = 71
        SubjectLbl.Text = "Subject"
        ' 
        ' dgvFinals
        ' 
        dgvFinals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvFinals.Location = New Point(35, 243)
        dgvFinals.Name = "dgvFinals"
        dgvFinals.RowHeadersWidth = 51
        dgvFinals.Size = New Size(603, 281)
        dgvFinals.TabIndex = 70
        ' 
        ' cbSEM
        ' 
        cbSEM.AutoCompleteCustomSource.AddRange(New String() {"1st Sem", "2nd Sem"})
        cbSEM.AutoCompleteMode = AutoCompleteMode.Suggest
        cbSEM.AutoCompleteSource = AutoCompleteSource.CustomSource
        cbSEM.FormattingEnabled = True
        cbSEM.Items.AddRange(New Object() {"1st ", "2nd"})
        cbSEM.Location = New Point(230, 197)
        cbSEM.Name = "cbSEM"
        cbSEM.Size = New Size(195, 28)
        cbSEM.TabIndex = 74
        ' 
        ' SemesterLbl
        ' 
        SemesterLbl.AutoSize = True
        SemesterLbl.BackColor = Color.Transparent
        SemesterLbl.Font = New Font("Tahoma", 10.2F)
        SemesterLbl.ForeColor = SystemColors.ActiveCaptionText
        SemesterLbl.Location = New Point(230, 162)
        SemesterLbl.Name = "SemesterLbl"
        SemesterLbl.Size = New Size(80, 21)
        SemesterLbl.TabIndex = 73
        SemesterLbl.Text = "Semester"
        ' 
        ' cbSEC
        ' 
        cbSEC.FormattingEnabled = True
        cbSEC.Items.AddRange(New Object() {"BSIT1A", "BSIT1B", "BSIT1C", "BSIT1D", "BSIT1E", "BSIT2A", "BSIT2B", "BSIT2C", "BSIT2D", "BSIT2E", "BSIT3A", "BSIT3B", "BSIT3C", "BSIT3D", "BSIT3E", "BSIT4A", "BSIT4B", "BSIT4C", "BSIT4D", "BSIT4E", "BSCS1A", "BSCS2A", "BSCS3A", "BSCS4A"})
        cbSEC.Location = New Point(28, 198)
        cbSEC.Name = "cbSEC"
        cbSEC.Size = New Size(193, 28)
        cbSEC.TabIndex = 69
        ' 
        ' SectionLbl
        ' 
        SectionLbl.AutoSize = True
        SectionLbl.BackColor = Color.Transparent
        SectionLbl.Font = New Font("Tahoma", 10.2F)
        SectionLbl.ForeColor = SystemColors.ActiveCaptionText
        SectionLbl.Location = New Point(271, 621)
        SectionLbl.Name = "SectionLbl"
        SectionLbl.Size = New Size(66, 21)
        SectionLbl.TabIndex = 72
        SectionLbl.Text = "Classes"
        ' 
        ' FullnameReminderLbl
        ' 
        FullnameReminderLbl.AutoSize = True
        FullnameReminderLbl.BackColor = Color.Transparent
        FullnameReminderLbl.Font = New Font("Segoe UI", 8F)
        FullnameReminderLbl.ForeColor = Color.Black
        FullnameReminderLbl.Location = New Point(39, 765)
        FullnameReminderLbl.Name = "FullnameReminderLbl"
        FullnameReminderLbl.Size = New Size(216, 19)
        FullnameReminderLbl.TabIndex = 68
        FullnameReminderLbl.Text = "Surname, Firstname, Middle Initial"
        ' 
        ' StudentNameTxtBox
        ' 
        StudentNameTxtBox.Enabled = False
        StudentNameTxtBox.ForeColor = Color.Black
        StudentNameTxtBox.Location = New Point(11, 727)
        StudentNameTxtBox.MaxLength = 35
        StudentNameTxtBox.Name = "StudentNameTxtBox"
        StudentNameTxtBox.ReadOnly = True
        StudentNameTxtBox.Size = New Size(234, 27)
        StudentNameTxtBox.TabIndex = 67
        ' 
        ' StudentIdLbl
        ' 
        StudentIdLbl.AutoSize = True
        StudentIdLbl.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0)
        StudentIdLbl.ForeColor = Color.Black
        StudentIdLbl.Location = New Point(11, 622)
        StudentIdLbl.Name = "StudentIdLbl"
        StudentIdLbl.Size = New Size(90, 21)
        StudentIdLbl.TabIndex = 64
        StudentIdLbl.Text = "Student ID"
        ' 
        ' StudentNameLblbox
        ' 
        StudentNameLblbox.AutoSize = True
        StudentNameLblbox.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0)
        StudentNameLblbox.ForeColor = Color.Black
        StudentNameLblbox.Location = New Point(11, 693)
        StudentNameLblbox.Name = "StudentNameLblbox"
        StudentNameLblbox.Size = New Size(115, 21)
        StudentNameLblbox.TabIndex = 66
        StudentNameLblbox.Text = "Student Name"
        ' 
        ' StudentIDTxtBox
        ' 
        StudentIDTxtBox.Enabled = False
        StudentIDTxtBox.ForeColor = Color.Black
        StudentIDTxtBox.Location = New Point(12, 659)
        StudentIDTxtBox.MaxLength = 8
        StudentIDTxtBox.Name = "StudentIDTxtBox"
        StudentIDTxtBox.ReadOnly = True
        StudentIDTxtBox.Size = New Size(233, 27)
        StudentIDTxtBox.TabIndex = 65
        ' 
        ' showGradeBtn
        ' 
        showGradeBtn.BackColor = Color.LawnGreen
        showGradeBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0)
        showGradeBtn.Location = New Point(524, 617)
        showGradeBtn.Name = "showGradeBtn"
        showGradeBtn.Size = New Size(180, 41)
        showGradeBtn.TabIndex = 85
        showGradeBtn.Text = "Show Compute Grades"
        showGradeBtn.UseVisualStyleBackColor = False
        ' 
        ' ExitBtn
        ' 
        ExitBtn.BackColor = Color.LightCoral
        ExitBtn.Location = New Point(566, 718)
        ExitBtn.Name = "ExitBtn"
        ExitBtn.Size = New Size(95, 42)
        ExitBtn.TabIndex = 84
        ExitBtn.Text = "Exit"
        ExitBtn.UseVisualStyleBackColor = False
        ' 
        ' CancelBtn
        ' 
        CancelBtn.BackColor = Color.Silver
        CancelBtn.Location = New Point(565, 659)
        CancelBtn.Name = "CancelBtn"
        CancelBtn.Size = New Size(96, 42)
        CancelBtn.TabIndex = 83
        CancelBtn.Text = "Cancel"
        CancelBtn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(735, 217)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 20)
        Label1.TabIndex = 86
        Label1.Text = "MIDTERM GRADE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(1044, 215)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 20)
        Label2.TabIndex = 87
        Label2.Text = "FINAL GRADE"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(881, 298)
        Label3.Name = "Label3"
        Label3.Size = New Size(131, 20)
        Label3.TabIndex = 88
        Label3.Text = "SEMESTER GRADE"
        ' 
        ' TXTmid
        ' 
        TXTmid.Enabled = False
        TXTmid.Location = New Point(736, 257)
        TXTmid.Name = "TXTmid"
        TXTmid.Size = New Size(125, 27)
        TXTmid.TabIndex = 89
        ' 
        ' txtFin
        ' 
        txtFin.Enabled = False
        txtFin.Location = New Point(1007, 257)
        txtFin.Name = "txtFin"
        txtFin.Size = New Size(125, 27)
        txtFin.TabIndex = 90
        ' 
        ' txtSem
        ' 
        txtSem.Enabled = False
        txtSem.Location = New Point(840, 337)
        txtSem.Multiline = True
        txtSem.Name = "txtSem"
        txtSem.Size = New Size(205, 34)
        txtSem.TabIndex = 91
        ' 
        ' GradeEquivalentPanel
        ' 
        GradeEquivalentPanel.BackColor = Color.White
        GradeEquivalentPanel.Controls.Add(Fminus)
        GradeEquivalentPanel.Controls.Add(FLbl)
        GradeEquivalentPanel.Controls.Add(CminusLbl)
        GradeEquivalentPanel.Controls.Add(DminusLbl)
        GradeEquivalentPanel.Controls.Add(Dlbl)
        GradeEquivalentPanel.Controls.Add(BminusLbl)
        GradeEquivalentPanel.Controls.Add(Blbl)
        GradeEquivalentPanel.Controls.Add(Clbl)
        GradeEquivalentPanel.Controls.Add(AminusLbl)
        GradeEquivalentPanel.Controls.Add(Albl)
        GradeEquivalentPanel.Controls.Add(GradeEquivalentLbl)
        GradeEquivalentPanel.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0)
        GradeEquivalentPanel.Location = New Point(825, 559)
        GradeEquivalentPanel.Name = "GradeEquivalentPanel"
        GradeEquivalentPanel.Size = New Size(267, 307)
        GradeEquivalentPanel.TabIndex = 92
        ' 
        ' Fminus
        ' 
        Fminus.AutoSize = True
        Fminus.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        Fminus.Location = New Point(68, 282)
        Fminus.Name = "Fminus"
        Fminus.Size = New Size(153, 17)
        Fminus.TabIndex = 6
        Fminus.Text = "(70-74.5) is equal to 5.0"
        ' 
        ' FLbl
        ' 
        FLbl.AutoSize = True
        FLbl.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        FLbl.Location = New Point(69, 261)
        FLbl.Name = "FLbl"
        FLbl.Size = New Size(142, 17)
        FLbl.TabIndex = 7
        FLbl.Text = "(75-77) is equal to 3.0"
        ' 
        ' CminusLbl
        ' 
        CminusLbl.AutoSize = True
        CminusLbl.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        CminusLbl.Location = New Point(68, 174)
        CminusLbl.Name = "CminusLbl"
        CminusLbl.Size = New Size(149, 17)
        CminusLbl.TabIndex = 7
        CminusLbl.Text = "(83-85) is equal to 2.25"
        ' 
        ' DminusLbl
        ' 
        DminusLbl.AutoSize = True
        DminusLbl.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        DminusLbl.Location = New Point(69, 232)
        DminusLbl.Name = "DminusLbl"
        DminusLbl.Size = New Size(149, 17)
        DminusLbl.TabIndex = 3
        DminusLbl.Text = "(78-79) is equal to 2.75"
        ' 
        ' Dlbl
        ' 
        Dlbl.AutoSize = True
        Dlbl.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        Dlbl.Location = New Point(69, 203)
        Dlbl.Name = "Dlbl"
        Dlbl.Size = New Size(149, 17)
        Dlbl.TabIndex = 4
        Dlbl.Text = "(80-82) is equal to 2.50"
        ' 
        ' BminusLbl
        ' 
        BminusLbl.AutoSize = True
        BminusLbl.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        BminusLbl.Location = New Point(68, 114)
        BminusLbl.Name = "BminusLbl"
        BminusLbl.Size = New Size(149, 17)
        BminusLbl.TabIndex = 14
        BminusLbl.Text = "(89-91) is equal to 1.75"
        ' 
        ' Blbl
        ' 
        Blbl.AutoSize = True
        Blbl.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        Blbl.Location = New Point(68, 87)
        Blbl.Name = "Blbl"
        Blbl.Size = New Size(149, 17)
        Blbl.TabIndex = 13
        Blbl.Text = "(92-94) is equal to 1.50"
        ' 
        ' Clbl
        ' 
        Clbl.AutoSize = True
        Clbl.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        Clbl.Location = New Point(69, 144)
        Clbl.Name = "Clbl"
        Clbl.Size = New Size(142, 17)
        Clbl.TabIndex = 5
        Clbl.Text = "(86-88) is equal to 2.0"
        ' 
        ' AminusLbl
        ' 
        AminusLbl.AutoSize = True
        AminusLbl.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        AminusLbl.Location = New Point(68, 57)
        AminusLbl.Name = "AminusLbl"
        AminusLbl.Size = New Size(149, 17)
        AminusLbl.TabIndex = 12
        AminusLbl.Text = "(95-97) is equal to 1.25"
        ' 
        ' Albl
        ' 
        Albl.AutoSize = True
        Albl.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        Albl.Location = New Point(68, 37)
        Albl.Name = "Albl"
        Albl.Size = New Size(149, 17)
        Albl.TabIndex = 11
        Albl.Text = "(98-100) is equal to 1.0"
        ' 
        ' GradeEquivalentLbl
        ' 
        GradeEquivalentLbl.AutoSize = True
        GradeEquivalentLbl.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold)
        GradeEquivalentLbl.ForeColor = Color.MidnightBlue
        GradeEquivalentLbl.Location = New Point(45, 9)
        GradeEquivalentLbl.Name = "GradeEquivalentLbl"
        GradeEquivalentLbl.Size = New Size(188, 25)
        GradeEquivalentLbl.TabIndex = 10
        GradeEquivalentLbl.Text = "Grade Equivalent"
        ' 
        ' SaveBtn
        ' 
        SaveBtn.BackColor = Color.Gold
        SaveBtn.ForeColor = Color.Black
        SaveBtn.Location = New Point(854, 490)
        SaveBtn.Name = "SaveBtn"
        SaveBtn.Size = New Size(211, 39)
        SaveBtn.TabIndex = 95
        SaveBtn.Text = "SAVE"
        SaveBtn.UseVisualStyleBackColor = False
        ' 
        ' ComputeBtn
        ' 
        ComputeBtn.BackColor = Color.CadetBlue
        ComputeBtn.Location = New Point(854, 439)
        ComputeBtn.Name = "ComputeBtn"
        ComputeBtn.Size = New Size(209, 45)
        ComputeBtn.TabIndex = 94
        ComputeBtn.Text = "COMPUTE"
        ComputeBtn.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Lucida Handwriting", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label4.Location = New Point(720, 171)
        Label4.Name = "Label4"
        Label4.Size = New Size(163, 23)
        Label4.TabIndex = 96
        Label4.Text = "MIDTERM 50%"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Lucida Handwriting", 9F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label5.Location = New Point(1044, 171)
        Label5.Name = "Label5"
        Label5.Size = New Size(104, 20)
        Label5.TabIndex = 97
        Label5.Text = "FINAL 50%"
        ' 
        ' RemarksScoreLbl
        ' 
        RemarksScoreLbl.AutoSize = True
        RemarksScoreLbl.Location = New Point(898, 386)
        RemarksScoreLbl.Name = "RemarksScoreLbl"
        RemarksScoreLbl.Size = New Size(113, 20)
        RemarksScoreLbl.TabIndex = 98
        RemarksScoreLbl.Text = "Remarks:SCORE"
        ' 
        ' SemestralForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1303, 986)
        Controls.Add(RemarksScoreLbl)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(SaveBtn)
        Controls.Add(ComputeBtn)
        Controls.Add(GradeEquivalentPanel)
        Controls.Add(txtSem)
        Controls.Add(txtFin)
        Controls.Add(TXTmid)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(showGradeBtn)
        Controls.Add(ExitBtn)
        Controls.Add(CancelBtn)
        Controls.Add(Sub_txt)
        Controls.Add(Label26)
        Controls.Add(resetBtn)
        Controls.Add(sectionTxtBox)
        Controls.Add(btnPopulate)
        Controls.Add(btnSEARC)
        Controls.Add(txtSEARC)
        Controls.Add(Label25)
        Controls.Add(cbSUB)
        Controls.Add(SubjectLbl)
        Controls.Add(dgvFinals)
        Controls.Add(cbSEM)
        Controls.Add(SemesterLbl)
        Controls.Add(cbSEC)
        Controls.Add(SectionLbl)
        Controls.Add(FullnameReminderLbl)
        Controls.Add(StudentNameTxtBox)
        Controls.Add(StudentIdLbl)
        Controls.Add(StudentNameLblbox)
        Controls.Add(StudentIDTxtBox)
        Controls.Add(GradingSystemPanel)
        Name = "SemestralForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Semestral"
        GradingSystemPanel.ResumeLayout(False)
        GradingSystemPanel.PerformLayout()
        CType(PlpLogoPicBox, ComponentModel.ISupportInitialize).EndInit()
        CType(CCSLogoPicBox, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvFinals, ComponentModel.ISupportInitialize).EndInit()
        GradeEquivalentPanel.ResumeLayout(False)
        GradeEquivalentPanel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GradingSystemPanel As Panel
    Friend WithEvents GradingSystemLbl As Label
    Friend WithEvents CCSLogoPicBox As PictureBox
    Friend WithEvents PlpLogoPicBox As PictureBox
    Friend WithEvents Sub_txt As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents resetBtn As Button
    Friend WithEvents sectionTxtBox As TextBox
    Friend WithEvents btnPopulate As Button
    Friend WithEvents btnSEARC As Button
    Friend WithEvents txtSEARC As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents cbSUB As ComboBox
    Friend WithEvents SubjectLbl As Label
    Friend WithEvents dgvFinals As DataGridView
    Friend WithEvents cbSEM As ComboBox
    Friend WithEvents SemesterLbl As Label
    Friend WithEvents cbSEC As ComboBox
    Friend WithEvents SectionLbl As Label
    Friend WithEvents FullnameReminderLbl As Label
    Friend WithEvents StudentNameTxtBox As TextBox
    Friend WithEvents StudentIdLbl As Label
    Friend WithEvents StudentNameLblbox As Label
    Friend WithEvents StudentIDTxtBox As TextBox
    Friend WithEvents showGradeBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents CancelBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTmid As TextBox
    Friend WithEvents txtFin As TextBox
    Friend WithEvents txtSem As TextBox
    Friend WithEvents GradeEquivalentPanel As Panel
    Friend WithEvents Fminus As Label
    Friend WithEvents FLbl As Label
    Friend WithEvents CminusLbl As Label
    Friend WithEvents DminusLbl As Label
    Friend WithEvents Dlbl As Label
    Friend WithEvents BminusLbl As Label
    Friend WithEvents Blbl As Label
    Friend WithEvents Clbl As Label
    Friend WithEvents AminusLbl As Label
    Friend WithEvents Albl As Label
    Friend WithEvents GradeEquivalentLbl As Label
    Friend WithEvents SaveBtn As Button
    Friend WithEvents ComputeBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RemarksScoreLbl As Label
    Friend WithEvents patongPanel As Panel
End Class
