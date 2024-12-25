<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MidtermForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MidtermForm))
        cbSEM = New ComboBox()
        SemesterLbl = New Label()
        showGradeBtn = New Button()
        SubjectLbl = New Label()
        StudentIDTxtBox = New TextBox()
        StudentIdLbl = New Label()
        MidtermPanel = New Panel()
        Panel2 = New Panel()
        QuizComputeBtn = New Button()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        QuizTotalItemsTextBox = New TextBox()
        QuizTotalScoreTxtBox = New TextBox()
        QuizPerecntLbl = New Label()
        Label4 = New Label()
        Q4MaxTxtBox = New TextBox()
        Q4InputTxtBox = New TextBox()
        Label3 = New Label()
        Q3MaxTxtBox = New TextBox()
        Q3InputTxtBox = New TextBox()
        Q4Lbl = New Label()
        Label2 = New Label()
        Q2MaxTxtBox = New TextBox()
        Q2InputTxtBox = New TextBox()
        Label1 = New Label()
        Q1MaxTxtBox = New TextBox()
        Q1InputTxtBox = New TextBox()
        Q3Lbl = New Label()
        Q2Lbl = New Label()
        Q1Lbl = New Label()
        NumQuizzesLbl = New Label()
        NumberOfQuizComboBox = New ComboBox()
        QuizzesTxtBox = New TextBox()
        QuizzesLbl = New Label()
        Panel5 = New Panel()
        Label24 = New Label()
        LabComputeBtn = New Button()
        Label18 = New Label()
        Label17 = New Label()
        Label16 = New Label()
        Label15 = New Label()
        Label14 = New Label()
        Lab4TxtBox = New TextBox()
        Lab3TxtBox = New TextBox()
        Lab2TxtBox = New TextBox()
        Lab1TxtBox = New TextBox()
        Label13 = New Label()
        NumberOfLabExerciseComboBox = New ComboBox()
        LabExerTxtBox = New TextBox()
        LabExercisesLbl = New Label()
        Panel1 = New Panel()
        Label21 = New Label()
        AttendanceComboBox = New ComboBox()
        Label12 = New Label()
        AttendanceTxtBox = New TextBox()
        AttendanceLbl = New Label()
        Panel4 = New Panel()
        Label23 = New Label()
        Label22 = New Label()
        RecitTxtbox = New TextBox()
        CaseStudyTxtbox = New TextBox()
        RecitLbl = New Label()
        CaseStudyLbl = New Label()
        Panel3 = New Panel()
        Label19 = New Label()
        MaxMidExamTxtBox = New TextBox()
        Label20 = New Label()
        MidtermExamLbl = New Label()
        FinalExamComputeBtn = New Button()
        MidtermExamTxtBox = New TextBox()
        EqualLabel = New Label()
        InputMidExamTxtBox = New TextBox()
        Overlbl = New Label()
        SaveBtn = New Button()
        MidtermGradeLbl = New Label()
        MidtermPercentLbl = New Label()
        ClearAllBtn = New Button()
        ComputeBtn = New Button()
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
        MidtermGradeBorderPanel = New Panel()
        RemarksScoreLbl = New Label()
        RemarksLbl = New Label()
        MidGradePromptTxtBox = New TextBox()
        patongPanel = New Panel()
        CancelBtn = New Button()
        ExitBtn = New Button()
        cbSUB = New ComboBox()
        cbSEC = New ComboBox()
        dgvMIDTERM = New DataGridView()
        Label25 = New Label()
        txtSEARC = New TextBox()
        btnSEARC = New Button()
        btnPopulate = New Button()
        GradingSystemLbl = New Label()
        PlpLogoPicBox = New PictureBox()
        CCSLogoPicBox = New PictureBox()
        GradeSystemPanel = New Panel()
        resetBtn = New Button()
        FullnameReminderLbl = New Label()
        StudentNameLblbox = New Label()
        StudentNameTxtBox = New TextBox()
        SectionLbl = New Label()
        sectionTxtBox = New TextBox()
        Label26 = New Label()
        Sub_txt = New TextBox()
        MidtermPanel.SuspendLayout()
        Panel2.SuspendLayout()
        Panel5.SuspendLayout()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        GradeEquivalentPanel.SuspendLayout()
        MidtermGradeBorderPanel.SuspendLayout()
        CType(dgvMIDTERM, ComponentModel.ISupportInitialize).BeginInit()
        CType(PlpLogoPicBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(CCSLogoPicBox, ComponentModel.ISupportInitialize).BeginInit()
        GradeSystemPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' cbSEM
        ' 
        cbSEM.AutoCompleteCustomSource.AddRange(New String() {"1st Sem", "2nd Sem"})
        cbSEM.AutoCompleteMode = AutoCompleteMode.Suggest
        cbSEM.AutoCompleteSource = AutoCompleteSource.CustomSource
        cbSEM.FormattingEnabled = True
        cbSEM.Items.AddRange(New Object() {"1st ", "2nd"})
        cbSEM.Location = New Point(229, 221)
        cbSEM.Name = "cbSEM"
        cbSEM.Size = New Size(195, 28)
        cbSEM.TabIndex = 30
        ' 
        ' SemesterLbl
        ' 
        SemesterLbl.AutoSize = True
        SemesterLbl.BackColor = Color.Transparent
        SemesterLbl.Font = New Font("Tahoma", 10.2F)
        SemesterLbl.ForeColor = SystemColors.ActiveCaptionText
        SemesterLbl.Location = New Point(229, 197)
        SemesterLbl.Name = "SemesterLbl"
        SemesterLbl.Size = New Size(80, 21)
        SemesterLbl.TabIndex = 29
        SemesterLbl.Text = "Semester"
        ' 
        ' showGradeBtn
        ' 
        showGradeBtn.BackColor = Color.LawnGreen
        showGradeBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        showGradeBtn.Location = New Point(368, 893)
        showGradeBtn.Name = "showGradeBtn"
        showGradeBtn.Size = New Size(201, 41)
        showGradeBtn.TabIndex = 25
        showGradeBtn.Text = "Show Compute Grades"
        showGradeBtn.UseVisualStyleBackColor = False
        ' 
        ' SubjectLbl
        ' 
        SubjectLbl.AutoSize = True
        SubjectLbl.Font = New Font("Tahoma", 10.2F)
        SubjectLbl.ForeColor = SystemColors.ActiveCaptionText
        SubjectLbl.Location = New Point(450, 197)
        SubjectLbl.Name = "SubjectLbl"
        SubjectLbl.Size = New Size(65, 21)
        SubjectLbl.TabIndex = 20
        SubjectLbl.Text = "Subject"
        ' 
        ' StudentIDTxtBox
        ' 
        StudentIDTxtBox.Enabled = False
        StudentIDTxtBox.ForeColor = Color.Black
        StudentIDTxtBox.Location = New Point(48, 760)
        StudentIDTxtBox.MaxLength = 8
        StudentIDTxtBox.Name = "StudentIDTxtBox"
        StudentIDTxtBox.ReadOnly = True
        StudentIDTxtBox.Size = New Size(233, 27)
        StudentIDTxtBox.TabIndex = 2
        ' 
        ' StudentIdLbl
        ' 
        StudentIdLbl.AutoSize = True
        StudentIdLbl.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StudentIdLbl.ForeColor = Color.Black
        StudentIdLbl.Location = New Point(47, 723)
        StudentIdLbl.Name = "StudentIdLbl"
        StudentIdLbl.Size = New Size(90, 21)
        StudentIdLbl.TabIndex = 1
        StudentIdLbl.Text = "Student ID"
        ' 
        ' MidtermPanel
        ' 
        MidtermPanel.BackColor = Color.LemonChiffon
        MidtermPanel.Controls.Add(Panel2)
        MidtermPanel.Controls.Add(Panel5)
        MidtermPanel.Controls.Add(Panel1)
        MidtermPanel.Controls.Add(Panel4)
        MidtermPanel.Controls.Add(Panel3)
        MidtermPanel.Controls.Add(SaveBtn)
        MidtermPanel.Controls.Add(MidtermGradeLbl)
        MidtermPanel.Controls.Add(MidtermPercentLbl)
        MidtermPanel.Controls.Add(ClearAllBtn)
        MidtermPanel.Controls.Add(ComputeBtn)
        MidtermPanel.Controls.Add(GradeEquivalentPanel)
        MidtermPanel.Controls.Add(MidtermGradeBorderPanel)
        MidtermPanel.Location = New Point(669, 204)
        MidtermPanel.Name = "MidtermPanel"
        MidtermPanel.Size = New Size(909, 816)
        MidtermPanel.TabIndex = 1
        MidtermPanel.Visible = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(QuizComputeBtn)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(QuizTotalItemsTextBox)
        Panel2.Controls.Add(QuizTotalScoreTxtBox)
        Panel2.Controls.Add(QuizPerecntLbl)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Q4MaxTxtBox)
        Panel2.Controls.Add(Q4InputTxtBox)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Q3MaxTxtBox)
        Panel2.Controls.Add(Q3InputTxtBox)
        Panel2.Controls.Add(Q4Lbl)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Q2MaxTxtBox)
        Panel2.Controls.Add(Q2InputTxtBox)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Q1MaxTxtBox)
        Panel2.Controls.Add(Q1InputTxtBox)
        Panel2.Controls.Add(Q3Lbl)
        Panel2.Controls.Add(Q2Lbl)
        Panel2.Controls.Add(Q1Lbl)
        Panel2.Controls.Add(NumQuizzesLbl)
        Panel2.Controls.Add(NumberOfQuizComboBox)
        Panel2.Controls.Add(QuizzesTxtBox)
        Panel2.Controls.Add(QuizzesLbl)
        Panel2.Location = New Point(14, 326)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(878, 147)
        Panel2.TabIndex = 99
        ' 
        ' QuizComputeBtn
        ' 
        QuizComputeBtn.BackColor = Color.LawnGreen
        QuizComputeBtn.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        QuizComputeBtn.Location = New Point(760, 66)
        QuizComputeBtn.Name = "QuizComputeBtn"
        QuizComputeBtn.Size = New Size(102, 27)
        QuizComputeBtn.TabIndex = 107
        QuizComputeBtn.Text = "Quiz Compute"
        QuizComputeBtn.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 8F)
        Label11.ForeColor = Color.DarkSlateGray
        Label11.Location = New Point(475, 18)
        Label11.Name = "Label11"
        Label11.Size = New Size(43, 19)
        Label11.TabIndex = 106
        Label11.Text = "Items"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 8F)
        Label10.ForeColor = Color.DarkSlateGray
        Label10.Location = New Point(288, 18)
        Label10.Name = "Label10"
        Label10.Size = New Size(43, 19)
        Label10.TabIndex = 105
        Label10.Text = "Items"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 8F)
        Label9.ForeColor = Color.DarkSlateGray
        Label9.Location = New Point(388, 18)
        Label9.Name = "Label9"
        Label9.Size = New Size(42, 19)
        Label9.TabIndex = 104
        Label9.Text = "Score"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 8F)
        Label8.ForeColor = Color.DarkSlateGray
        Label8.Location = New Point(205, 18)
        Label8.Name = "Label8"
        Label8.Size = New Size(42, 19)
        Label8.TabIndex = 103
        Label8.Text = "Score"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 8F)
        Label7.ForeColor = Color.DarkSlateGray
        Label7.Location = New Point(676, 38)
        Label7.Name = "Label7"
        Label7.Size = New Size(76, 19)
        Label7.TabIndex = 102
        Label7.Text = "Total Items"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 8F)
        Label6.ForeColor = Color.DarkSlateGray
        Label6.Location = New Point(591, 39)
        Label6.Name = "Label6"
        Label6.Size = New Size(75, 19)
        Label6.TabIndex = 101
        Label6.Text = "Total Score"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(661, 65)
        Label5.Name = "Label5"
        Label5.Size = New Size(20, 28)
        Label5.TabIndex = 100
        Label5.Text = "/"
        ' 
        ' QuizTotalItemsTextBox
        ' 
        QuizTotalItemsTextBox.Enabled = False
        QuizTotalItemsTextBox.Location = New Point(687, 66)
        QuizTotalItemsTextBox.Name = "QuizTotalItemsTextBox"
        QuizTotalItemsTextBox.Size = New Size(51, 27)
        QuizTotalItemsTextBox.TabIndex = 99
        ' 
        ' QuizTotalScoreTxtBox
        ' 
        QuizTotalScoreTxtBox.Enabled = False
        QuizTotalScoreTxtBox.Location = New Point(604, 66)
        QuizTotalScoreTxtBox.Name = "QuizTotalScoreTxtBox"
        QuizTotalScoreTxtBox.Size = New Size(51, 27)
        QuizTotalScoreTxtBox.TabIndex = 98
        ' 
        ' QuizPerecntLbl
        ' 
        QuizPerecntLbl.AutoSize = True
        QuizPerecntLbl.Font = New Font("Segoe UI", 8F)
        QuizPerecntLbl.ForeColor = Color.DarkSlateGray
        QuizPerecntLbl.Location = New Point(568, 112)
        QuizPerecntLbl.Name = "QuizPerecntLbl"
        QuizPerecntLbl.Size = New Size(108, 19)
        QuizPerecntLbl.TabIndex = 97
        QuizPerecntLbl.Text = "Quiz Percentage"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(449, 88)
        Label4.Name = "Label4"
        Label4.Size = New Size(20, 28)
        Label4.TabIndex = 96
        Label4.Text = "/"
        ' 
        ' Q4MaxTxtBox
        ' 
        Q4MaxTxtBox.Enabled = False
        Q4MaxTxtBox.Location = New Point(475, 92)
        Q4MaxTxtBox.MaxLength = 3
        Q4MaxTxtBox.Name = "Q4MaxTxtBox"
        Q4MaxTxtBox.Size = New Size(51, 27)
        Q4MaxTxtBox.TabIndex = 95
        ' 
        ' Q4InputTxtBox
        ' 
        Q4InputTxtBox.Enabled = False
        Q4InputTxtBox.Location = New Point(392, 92)
        Q4InputTxtBox.MaxLength = 3
        Q4InputTxtBox.Name = "Q4InputTxtBox"
        Q4InputTxtBox.Size = New Size(51, 27)
        Q4InputTxtBox.TabIndex = 94
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(449, 42)
        Label3.Name = "Label3"
        Label3.Size = New Size(20, 28)
        Label3.TabIndex = 93
        Label3.Text = "/"
        ' 
        ' Q3MaxTxtBox
        ' 
        Q3MaxTxtBox.Enabled = False
        Q3MaxTxtBox.Location = New Point(475, 46)
        Q3MaxTxtBox.MaxLength = 3
        Q3MaxTxtBox.Name = "Q3MaxTxtBox"
        Q3MaxTxtBox.Size = New Size(51, 27)
        Q3MaxTxtBox.TabIndex = 92
        ' 
        ' Q3InputTxtBox
        ' 
        Q3InputTxtBox.Enabled = False
        Q3InputTxtBox.Location = New Point(392, 46)
        Q3InputTxtBox.MaxLength = 3
        Q3InputTxtBox.Name = "Q3InputTxtBox"
        Q3InputTxtBox.Size = New Size(51, 27)
        Q3InputTxtBox.TabIndex = 91
        ' 
        ' Q4Lbl
        ' 
        Q4Lbl.AutoSize = True
        Q4Lbl.Location = New Point(358, 95)
        Q4Lbl.Name = "Q4Lbl"
        Q4Lbl.Size = New Size(28, 20)
        Q4Lbl.TabIndex = 90
        Q4Lbl.Text = "Q4"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(258, 91)
        Label2.Name = "Label2"
        Label2.Size = New Size(20, 28)
        Label2.TabIndex = 89
        Label2.Text = "/"
        ' 
        ' Q2MaxTxtBox
        ' 
        Q2MaxTxtBox.Enabled = False
        Q2MaxTxtBox.Location = New Point(284, 95)
        Q2MaxTxtBox.MaxLength = 3
        Q2MaxTxtBox.Name = "Q2MaxTxtBox"
        Q2MaxTxtBox.Size = New Size(51, 27)
        Q2MaxTxtBox.TabIndex = 88
        ' 
        ' Q2InputTxtBox
        ' 
        Q2InputTxtBox.Enabled = False
        Q2InputTxtBox.Location = New Point(201, 95)
        Q2InputTxtBox.MaxLength = 3
        Q2InputTxtBox.Name = "Q2InputTxtBox"
        Q2InputTxtBox.Size = New Size(51, 27)
        Q2InputTxtBox.TabIndex = 87
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(258, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(20, 28)
        Label1.TabIndex = 86
        Label1.Text = "/"
        ' 
        ' Q1MaxTxtBox
        ' 
        Q1MaxTxtBox.Enabled = False
        Q1MaxTxtBox.Location = New Point(284, 46)
        Q1MaxTxtBox.MaxLength = 3
        Q1MaxTxtBox.Name = "Q1MaxTxtBox"
        Q1MaxTxtBox.Size = New Size(51, 27)
        Q1MaxTxtBox.TabIndex = 85
        ' 
        ' Q1InputTxtBox
        ' 
        Q1InputTxtBox.Enabled = False
        Q1InputTxtBox.Location = New Point(201, 46)
        Q1InputTxtBox.MaxLength = 3
        Q1InputTxtBox.Name = "Q1InputTxtBox"
        Q1InputTxtBox.Size = New Size(51, 27)
        Q1InputTxtBox.TabIndex = 84
        ' 
        ' Q3Lbl
        ' 
        Q3Lbl.AutoSize = True
        Q3Lbl.Location = New Point(358, 46)
        Q3Lbl.Name = "Q3Lbl"
        Q3Lbl.Size = New Size(28, 20)
        Q3Lbl.TabIndex = 83
        Q3Lbl.Text = "Q3"
        ' 
        ' Q2Lbl
        ' 
        Q2Lbl.AutoSize = True
        Q2Lbl.Location = New Point(167, 95)
        Q2Lbl.Name = "Q2Lbl"
        Q2Lbl.Size = New Size(28, 20)
        Q2Lbl.TabIndex = 82
        Q2Lbl.Text = "Q2"
        ' 
        ' Q1Lbl
        ' 
        Q1Lbl.AutoSize = True
        Q1Lbl.Location = New Point(167, 49)
        Q1Lbl.Name = "Q1Lbl"
        Q1Lbl.Size = New Size(28, 20)
        Q1Lbl.TabIndex = 81
        Q1Lbl.Text = "Q1"
        ' 
        ' NumQuizzesLbl
        ' 
        NumQuizzesLbl.AutoSize = True
        NumQuizzesLbl.Font = New Font("Segoe UI", 8F)
        NumQuizzesLbl.ForeColor = Color.DarkSlateGray
        NumQuizzesLbl.Location = New Point(45, 69)
        NumQuizzesLbl.Name = "NumQuizzesLbl"
        NumQuizzesLbl.Size = New Size(97, 19)
        NumQuizzesLbl.TabIndex = 80
        NumQuizzesLbl.Text = "No. of Quizzes"
        ' 
        ' NumberOfQuizComboBox
        ' 
        NumberOfQuizComboBox.AutoCompleteCustomSource.AddRange(New String() {"1", "2", "3", "4"})
        NumberOfQuizComboBox.AutoCompleteMode = AutoCompleteMode.Suggest
        NumberOfQuizComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource
        NumberOfQuizComboBox.FormattingEnabled = True
        NumberOfQuizComboBox.Items.AddRange(New Object() {"1", "2", "3", "4"})
        NumberOfQuizComboBox.Location = New Point(54, 91)
        NumberOfQuizComboBox.Name = "NumberOfQuizComboBox"
        NumberOfQuizComboBox.Size = New Size(72, 28)
        NumberOfQuizComboBox.TabIndex = 79
        ' 
        ' QuizzesTxtBox
        ' 
        QuizzesTxtBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        QuizzesTxtBox.BackColor = Color.LightBlue
        QuizzesTxtBox.Enabled = False
        QuizzesTxtBox.Location = New Point(682, 109)
        QuizzesTxtBox.MaxLength = 3
        QuizzesTxtBox.Name = "QuizzesTxtBox"
        QuizzesTxtBox.Size = New Size(80, 27)
        QuizzesTxtBox.TabIndex = 78
        ' 
        ' QuizzesLbl
        ' 
        QuizzesLbl.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        QuizzesLbl.AutoSize = True
        QuizzesLbl.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        QuizzesLbl.Location = New Point(35, 46)
        QuizzesLbl.Name = "QuizzesLbl"
        QuizzesLbl.Size = New Size(134, 21)
        QuizzesLbl.TabIndex = 77
        QuizzesLbl.Text = "Quizzes(15%)"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Controls.Add(Label24)
        Panel5.Controls.Add(LabComputeBtn)
        Panel5.Controls.Add(Label18)
        Panel5.Controls.Add(Label17)
        Panel5.Controls.Add(Label16)
        Panel5.Controls.Add(Label15)
        Panel5.Controls.Add(Label14)
        Panel5.Controls.Add(Lab4TxtBox)
        Panel5.Controls.Add(Lab3TxtBox)
        Panel5.Controls.Add(Lab2TxtBox)
        Panel5.Controls.Add(Lab1TxtBox)
        Panel5.Controls.Add(Label13)
        Panel5.Controls.Add(NumberOfLabExerciseComboBox)
        Panel5.Controls.Add(LabExerTxtBox)
        Panel5.Controls.Add(LabExercisesLbl)
        Panel5.Location = New Point(435, 195)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(457, 125)
        Panel5.TabIndex = 100
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label24.Location = New Point(375, 64)
        Label24.Name = "Label24"
        Label24.Size = New Size(44, 23)
        Label24.TabIndex = 112
        Label24.Text = "/100"
        ' 
        ' LabComputeBtn
        ' 
        LabComputeBtn.BackColor = Color.LawnGreen
        LabComputeBtn.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabComputeBtn.Location = New Point(128, 95)
        LabComputeBtn.Name = "LabComputeBtn"
        LabComputeBtn.Size = New Size(102, 27)
        LabComputeBtn.TabIndex = 111
        LabComputeBtn.Text = "Lab Compute"
        LabComputeBtn.UseVisualStyleBackColor = False
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(236, 98)
        Label18.Name = "Label18"
        Label18.Size = New Size(19, 20)
        Label18.TabIndex = 110
        Label18.Text = "="
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(321, 36)
        Label17.Name = "Label17"
        Label17.Size = New Size(45, 20)
        Label17.TabIndex = 109
        Label17.Text = "Lab 4"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(261, 37)
        Label16.Name = "Label16"
        Label16.Size = New Size(45, 20)
        Label16.TabIndex = 108
        Label16.Text = "Lab 3"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(204, 37)
        Label15.Name = "Label15"
        Label15.Size = New Size(45, 20)
        Label15.TabIndex = 107
        Label15.Text = "Lab 2"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(147, 37)
        Label14.Name = "Label14"
        Label14.Size = New Size(45, 20)
        Label14.TabIndex = 106
        Label14.Text = "Lab 1"
        ' 
        ' Lab4TxtBox
        ' 
        Lab4TxtBox.Enabled = False
        Lab4TxtBox.Location = New Point(318, 62)
        Lab4TxtBox.MaxLength = 3
        Lab4TxtBox.Name = "Lab4TxtBox"
        Lab4TxtBox.Size = New Size(51, 27)
        Lab4TxtBox.TabIndex = 105
        ' 
        ' Lab3TxtBox
        ' 
        Lab3TxtBox.Enabled = False
        Lab3TxtBox.Location = New Point(261, 62)
        Lab3TxtBox.MaxLength = 3
        Lab3TxtBox.Name = "Lab3TxtBox"
        Lab3TxtBox.Size = New Size(51, 27)
        Lab3TxtBox.TabIndex = 104
        ' 
        ' Lab2TxtBox
        ' 
        Lab2TxtBox.Enabled = False
        Lab2TxtBox.Location = New Point(204, 62)
        Lab2TxtBox.MaxLength = 3
        Lab2TxtBox.Name = "Lab2TxtBox"
        Lab2TxtBox.Size = New Size(51, 27)
        Lab2TxtBox.TabIndex = 103
        ' 
        ' Lab1TxtBox
        ' 
        Lab1TxtBox.Enabled = False
        Lab1TxtBox.Location = New Point(147, 62)
        Lab1TxtBox.MaxLength = 3
        Lab1TxtBox.Name = "Lab1TxtBox"
        Lab1TxtBox.Size = New Size(51, 27)
        Lab1TxtBox.TabIndex = 102
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 8F)
        Label13.ForeColor = Color.DarkSlateGray
        Label13.Location = New Point(13, 41)
        Label13.Name = "Label13"
        Label13.Size = New Size(123, 19)
        Label13.TabIndex = 101
        Label13.Text = "No. of Lab Exercise"
        ' 
        ' NumberOfLabExerciseComboBox
        ' 
        NumberOfLabExerciseComboBox.AutoCompleteCustomSource.AddRange(New String() {"1", "2", "3", "4"})
        NumberOfLabExerciseComboBox.AutoCompleteMode = AutoCompleteMode.Suggest
        NumberOfLabExerciseComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource
        NumberOfLabExerciseComboBox.FormattingEnabled = True
        NumberOfLabExerciseComboBox.Items.AddRange(New Object() {"1", "2", "3", "4"})
        NumberOfLabExerciseComboBox.Location = New Point(33, 64)
        NumberOfLabExerciseComboBox.Name = "NumberOfLabExerciseComboBox"
        NumberOfLabExerciseComboBox.Size = New Size(72, 28)
        NumberOfLabExerciseComboBox.TabIndex = 100
        ' 
        ' LabExerTxtBox
        ' 
        LabExerTxtBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        LabExerTxtBox.BackColor = Color.LightBlue
        LabExerTxtBox.Enabled = False
        LabExerTxtBox.Location = New Point(261, 95)
        LabExerTxtBox.MaxLength = 3
        LabExerTxtBox.Name = "LabExerTxtBox"
        LabExerTxtBox.Size = New Size(82, 27)
        LabExerTxtBox.TabIndex = 99
        ' 
        ' LabExercisesLbl
        ' 
        LabExercisesLbl.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        LabExercisesLbl.AutoSize = True
        LabExercisesLbl.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabExercisesLbl.Location = New Point(6, 9)
        LabExercisesLbl.Name = "LabExercisesLbl"
        LabExercisesLbl.Size = New Size(251, 21)
        LabExercisesLbl.TabIndex = 98
        LabExercisesLbl.Text = "Laboratory Exercises (20%)"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label21)
        Panel1.Controls.Add(AttendanceComboBox)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(AttendanceTxtBox)
        Panel1.Controls.Add(AttendanceLbl)
        Panel1.Location = New Point(14, 81)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(412, 108)
        Panel1.TabIndex = 98
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI", 8F)
        Label21.ForeColor = Color.DarkSlateGray
        Label21.Location = New Point(180, 27)
        Label21.Name = "Label21"
        Label21.Size = New Size(107, 19)
        Label21.TabIndex = 99
        Label21.Text = "No. of Absences"
        ' 
        ' AttendanceComboBox
        ' 
        AttendanceComboBox.AutoCompleteCustomSource.AddRange(New String() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        AttendanceComboBox.AutoCompleteMode = AutoCompleteMode.Suggest
        AttendanceComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource
        AttendanceComboBox.FormattingEnabled = True
        AttendanceComboBox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        AttendanceComboBox.Location = New Point(206, 49)
        AttendanceComboBox.Name = "AttendanceComboBox"
        AttendanceComboBox.Size = New Size(56, 28)
        AttendanceComboBox.TabIndex = 98
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(268, 52)
        Label12.Name = "Label12"
        Label12.Size = New Size(19, 20)
        Label12.TabIndex = 97
        Label12.Text = "="
        ' 
        ' AttendanceTxtBox
        ' 
        AttendanceTxtBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        AttendanceTxtBox.BackColor = Color.LightBlue
        AttendanceTxtBox.Enabled = False
        AttendanceTxtBox.Location = New Point(293, 50)
        AttendanceTxtBox.MaxLength = 3
        AttendanceTxtBox.Name = "AttendanceTxtBox"
        AttendanceTxtBox.Size = New Size(47, 27)
        AttendanceTxtBox.TabIndex = 96
        ' 
        ' AttendanceLbl
        ' 
        AttendanceLbl.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        AttendanceLbl.AutoSize = True
        AttendanceLbl.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AttendanceLbl.ForeColor = SystemColors.ActiveCaptionText
        AttendanceLbl.Location = New Point(15, 50)
        AttendanceLbl.Name = "AttendanceLbl"
        AttendanceLbl.Size = New Size(160, 21)
        AttendanceLbl.TabIndex = 95
        AttendanceLbl.Text = "Attendance (5%)"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(Label23)
        Panel4.Controls.Add(Label22)
        Panel4.Controls.Add(RecitTxtbox)
        Panel4.Controls.Add(CaseStudyTxtbox)
        Panel4.Controls.Add(RecitLbl)
        Panel4.Controls.Add(CaseStudyLbl)
        Panel4.Location = New Point(14, 195)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(412, 125)
        Panel4.TabIndex = 99
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label23.Location = New Point(361, 66)
        Label23.Name = "Label23"
        Label23.Size = New Size(44, 23)
        Label23.TabIndex = 102
        Label23.Text = "/100"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(361, 32)
        Label22.Name = "Label22"
        Label22.Size = New Size(44, 23)
        Label22.TabIndex = 101
        Label22.Text = "/100"
        ' 
        ' RecitTxtbox
        ' 
        RecitTxtbox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        RecitTxtbox.BackColor = SystemColors.Window
        RecitTxtbox.Location = New Point(185, 66)
        RecitTxtbox.MaxLength = 3
        RecitTxtbox.Name = "RecitTxtbox"
        RecitTxtbox.Size = New Size(170, 27)
        RecitTxtbox.TabIndex = 100
        ' 
        ' CaseStudyTxtbox
        ' 
        CaseStudyTxtbox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        CaseStudyTxtbox.BackColor = SystemColors.Window
        CaseStudyTxtbox.Location = New Point(186, 32)
        CaseStudyTxtbox.MaxLength = 3
        CaseStudyTxtbox.Name = "CaseStudyTxtbox"
        CaseStudyTxtbox.Size = New Size(169, 27)
        CaseStudyTxtbox.TabIndex = 99
        ' 
        ' RecitLbl
        ' 
        RecitLbl.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        RecitLbl.AutoSize = True
        RecitLbl.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RecitLbl.Location = New Point(8, 68)
        RecitLbl.Name = "RecitLbl"
        RecitLbl.Size = New Size(160, 21)
        RecitLbl.TabIndex = 98
        RecitLbl.Text = "Recitation (10%)"
        ' 
        ' CaseStudyLbl
        ' 
        CaseStudyLbl.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        CaseStudyLbl.AutoSize = True
        CaseStudyLbl.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CaseStudyLbl.Location = New Point(8, 34)
        CaseStudyLbl.Name = "CaseStudyLbl"
        CaseStudyLbl.Size = New Size(168, 21)
        CaseStudyLbl.TabIndex = 97
        CaseStudyLbl.Text = "Case Study (20%)"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(Label19)
        Panel3.Controls.Add(MaxMidExamTxtBox)
        Panel3.Controls.Add(Label20)
        Panel3.Controls.Add(MidtermExamLbl)
        Panel3.Controls.Add(FinalExamComputeBtn)
        Panel3.Controls.Add(MidtermExamTxtBox)
        Panel3.Controls.Add(EqualLabel)
        Panel3.Controls.Add(InputMidExamTxtBox)
        Panel3.Controls.Add(Overlbl)
        Panel3.Location = New Point(435, 82)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(457, 107)
        Panel3.TabIndex = 98
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 8F)
        Label19.ForeColor = Color.DarkSlateGray
        Label19.Location = New Point(290, 9)
        Label19.Name = "Label19"
        Label19.Size = New Size(43, 19)
        Label19.TabIndex = 111
        Label19.Text = "Items"
        ' 
        ' MaxMidExamTxtBox
        ' 
        MaxMidExamTxtBox.Location = New Point(282, 35)
        MaxMidExamTxtBox.MaxLength = 3
        MaxMidExamTxtBox.Name = "MaxMidExamTxtBox"
        MaxMidExamTxtBox.Size = New Size(51, 27)
        MaxMidExamTxtBox.TabIndex = 106
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI", 8F)
        Label20.ForeColor = Color.DarkSlateGray
        Label20.Location = New Point(203, 9)
        Label20.Name = "Label20"
        Label20.Size = New Size(42, 19)
        Label20.TabIndex = 110
        Label20.Text = "Score"
        ' 
        ' MidtermExamLbl
        ' 
        MidtermExamLbl.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        MidtermExamLbl.AutoSize = True
        MidtermExamLbl.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MidtermExamLbl.Location = New Point(6, 37)
        MidtermExamLbl.Name = "MidtermExamLbl"
        MidtermExamLbl.Size = New Size(195, 21)
        MidtermExamLbl.TabIndex = 103
        MidtermExamLbl.Text = "Midterm Exam (30%)"
        ' 
        ' FinalExamComputeBtn
        ' 
        FinalExamComputeBtn.BackColor = Color.LawnGreen
        FinalExamComputeBtn.Font = New Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FinalExamComputeBtn.Location = New Point(318, 68)
        FinalExamComputeBtn.Name = "FinalExamComputeBtn"
        FinalExamComputeBtn.Size = New Size(123, 27)
        FinalExamComputeBtn.TabIndex = 109
        FinalExamComputeBtn.Text = "Compute Exam"
        FinalExamComputeBtn.UseVisualStyleBackColor = False
        ' 
        ' MidtermExamTxtBox
        ' 
        MidtermExamTxtBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        MidtermExamTxtBox.BackColor = Color.LightBlue
        MidtermExamTxtBox.Enabled = False
        MidtermExamTxtBox.Location = New Point(368, 35)
        MidtermExamTxtBox.MaxLength = 3
        MidtermExamTxtBox.Name = "MidtermExamTxtBox"
        MidtermExamTxtBox.Size = New Size(60, 27)
        MidtermExamTxtBox.TabIndex = 104
        ' 
        ' EqualLabel
        ' 
        EqualLabel.AutoSize = True
        EqualLabel.Location = New Point(339, 38)
        EqualLabel.Name = "EqualLabel"
        EqualLabel.Size = New Size(19, 20)
        EqualLabel.TabIndex = 108
        EqualLabel.Text = "="
        ' 
        ' InputMidExamTxtBox
        ' 
        InputMidExamTxtBox.Location = New Point(199, 35)
        InputMidExamTxtBox.MaxLength = 3
        InputMidExamTxtBox.Name = "InputMidExamTxtBox"
        InputMidExamTxtBox.Size = New Size(51, 27)
        InputMidExamTxtBox.TabIndex = 105
        ' 
        ' Overlbl
        ' 
        Overlbl.AutoSize = True
        Overlbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Overlbl.Location = New Point(256, 31)
        Overlbl.Name = "Overlbl"
        Overlbl.Size = New Size(20, 28)
        Overlbl.TabIndex = 107
        Overlbl.Text = "/"
        ' 
        ' SaveBtn
        ' 
        SaveBtn.BackColor = Color.Gold
        SaveBtn.ForeColor = Color.Black
        SaveBtn.Location = New Point(567, 591)
        SaveBtn.Name = "SaveBtn"
        SaveBtn.Size = New Size(211, 39)
        SaveBtn.TabIndex = 6
        SaveBtn.Text = "SAVE"
        SaveBtn.UseVisualStyleBackColor = False
        SaveBtn.Visible = False
        ' 
        ' MidtermGradeLbl
        ' 
        MidtermGradeLbl.AutoSize = True
        MidtermGradeLbl.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MidtermGradeLbl.Location = New Point(312, 654)
        MidtermGradeLbl.Name = "MidtermGradeLbl"
        MidtermGradeLbl.Size = New Size(220, 25)
        MidtermGradeLbl.TabIndex = 4
        MidtermGradeLbl.Text = "MIDTERM GRADE"
        MidtermGradeLbl.Visible = False
        ' 
        ' MidtermPercentLbl
        ' 
        MidtermPercentLbl.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        MidtermPercentLbl.AutoSize = True
        MidtermPercentLbl.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MidtermPercentLbl.ForeColor = Color.Black
        MidtermPercentLbl.Location = New Point(25, 34)
        MidtermPercentLbl.Name = "MidtermPercentLbl"
        MidtermPercentLbl.Size = New Size(269, 25)
        MidtermPercentLbl.TabIndex = 0
        MidtermPercentLbl.Text = "[ Midterm Grade (50%) ]"
        ' 
        ' ClearAllBtn
        ' 
        ClearAllBtn.BackColor = Color.Silver
        ClearAllBtn.Location = New Point(567, 643)
        ClearAllBtn.Name = "ClearAllBtn"
        ClearAllBtn.Size = New Size(211, 39)
        ClearAllBtn.TabIndex = 2
        ClearAllBtn.Text = "Clear All"
        ClearAllBtn.UseVisualStyleBackColor = False
        ClearAllBtn.Visible = False
        ' 
        ' ComputeBtn
        ' 
        ComputeBtn.BackColor = Color.CadetBlue
        ComputeBtn.Location = New Point(567, 540)
        ComputeBtn.Name = "ComputeBtn"
        ComputeBtn.Size = New Size(209, 45)
        ComputeBtn.TabIndex = 3
        ComputeBtn.Text = "COMPUTE"
        ComputeBtn.UseVisualStyleBackColor = False
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
        GradeEquivalentPanel.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GradeEquivalentPanel.Location = New Point(14, 486)
        GradeEquivalentPanel.Name = "GradeEquivalentPanel"
        GradeEquivalentPanel.Size = New Size(267, 307)
        GradeEquivalentPanel.TabIndex = 14
        GradeEquivalentPanel.Visible = False
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
        ' MidtermGradeBorderPanel
        ' 
        MidtermGradeBorderPanel.BackColor = Color.White
        MidtermGradeBorderPanel.BorderStyle = BorderStyle.FixedSingle
        MidtermGradeBorderPanel.Controls.Add(RemarksScoreLbl)
        MidtermGradeBorderPanel.Controls.Add(RemarksLbl)
        MidtermGradeBorderPanel.Controls.Add(MidGradePromptTxtBox)
        MidtermGradeBorderPanel.Location = New Point(307, 492)
        MidtermGradeBorderPanel.Name = "MidtermGradeBorderPanel"
        MidtermGradeBorderPanel.Size = New Size(225, 155)
        MidtermGradeBorderPanel.TabIndex = 5
        MidtermGradeBorderPanel.Visible = False
        ' 
        ' RemarksScoreLbl
        ' 
        RemarksScoreLbl.AutoSize = True
        RemarksScoreLbl.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        RemarksScoreLbl.Location = New Point(133, 104)
        RemarksScoreLbl.Name = "RemarksScoreLbl"
        RemarksScoreLbl.Size = New Size(51, 18)
        RemarksScoreLbl.TabIndex = 2
        RemarksScoreLbl.Text = "Score"
        RemarksScoreLbl.Visible = False
        ' 
        ' RemarksLbl
        ' 
        RemarksLbl.AutoSize = True
        RemarksLbl.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        RemarksLbl.Location = New Point(50, 104)
        RemarksLbl.Name = "RemarksLbl"
        RemarksLbl.Size = New Size(79, 18)
        RemarksLbl.TabIndex = 1
        RemarksLbl.Text = "Remarks:"
        ' 
        ' MidGradePromptTxtBox
        ' 
        MidGradePromptTxtBox.BorderStyle = BorderStyle.FixedSingle
        MidGradePromptTxtBox.Enabled = False
        MidGradePromptTxtBox.Location = New Point(33, 60)
        MidGradePromptTxtBox.Name = "MidGradePromptTxtBox"
        MidGradePromptTxtBox.Size = New Size(166, 27)
        MidGradePromptTxtBox.TabIndex = 0
        ' 
        ' patongPanel
        ' 
        patongPanel.Location = New Point(640, 193)
        patongPanel.Name = "patongPanel"
        patongPanel.Size = New Size(956, 846)
        patongPanel.TabIndex = 39
        ' 
        ' CancelBtn
        ' 
        CancelBtn.BackColor = Color.Silver
        CancelBtn.Location = New Point(165, 944)
        CancelBtn.Name = "CancelBtn"
        CancelBtn.Size = New Size(237, 42)
        CancelBtn.TabIndex = 7
        CancelBtn.Text = "Cancel"
        CancelBtn.UseVisualStyleBackColor = False
        ' 
        ' ExitBtn
        ' 
        ExitBtn.BackColor = Color.LightCoral
        ExitBtn.Location = New Point(405, 944)
        ExitBtn.Name = "ExitBtn"
        ExitBtn.Size = New Size(217, 42)
        ExitBtn.TabIndex = 8
        ExitBtn.Text = "Exit"
        ExitBtn.UseVisualStyleBackColor = False
        ' 
        ' cbSUB
        ' 
        cbSUB.FormattingEnabled = True
        cbSUB.Items.AddRange(New Object() {"COMP 104", "IT 201", "IT 101", "COMP 105"})
        cbSUB.Location = New Point(448, 221)
        cbSUB.Name = "cbSUB"
        cbSUB.Size = New Size(186, 28)
        cbSUB.TabIndex = 0
        ' 
        ' cbSEC
        ' 
        cbSEC.FormattingEnabled = True
        cbSEC.Items.AddRange(New Object() {"BSIT1A", "BSIT1B", "BSIT1C", "BSIT1D", "BSIT1E", "BSIT2A", "BSIT2B", "BSIT2C", "BSIT2D", "BSIT2E", "BSIT3A", "BSIT3B", "BSIT3C", "BSIT3D", "BSIT3E", "BSIT4A", "BSIT4B", "BSIT4C", "BSIT4D", "BSIT4E", "BSCS1A", "BSCS2A", "BSCS3A", "BSCS4A"})
        cbSEC.Location = New Point(20, 221)
        cbSEC.Name = "cbSEC"
        cbSEC.Size = New Size(193, 28)
        cbSEC.TabIndex = 15
        ' 
        ' dgvMIDTERM
        ' 
        dgvMIDTERM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMIDTERM.Location = New Point(19, 276)
        dgvMIDTERM.Name = "dgvMIDTERM"
        dgvMIDTERM.RowHeadersWidth = 51
        dgvMIDTERM.Size = New Size(603, 364)
        dgvMIDTERM.TabIndex = 16
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Location = New Point(20, 198)
        Label25.Name = "Label25"
        Label25.Size = New Size(58, 20)
        Label25.TabIndex = 31
        Label25.Text = "Section"
        ' 
        ' txtSEARC
        ' 
        txtSEARC.Location = New Point(213, 661)
        txtSEARC.Multiline = True
        txtSEARC.Name = "txtSEARC"
        txtSEARC.Size = New Size(246, 42)
        txtSEARC.TabIndex = 32
        ' 
        ' btnSEARC
        ' 
        btnSEARC.BackColor = Color.Cyan
        btnSEARC.Location = New Point(465, 661)
        btnSEARC.Name = "btnSEARC"
        btnSEARC.Size = New Size(104, 42)
        btnSEARC.TabIndex = 33
        btnSEARC.Text = "Search"
        btnSEARC.UseVisualStyleBackColor = False
        ' 
        ' btnPopulate
        ' 
        btnPopulate.BackColor = Color.Thistle
        btnPopulate.Location = New Point(42, 663)
        btnPopulate.Name = "btnPopulate"
        btnPopulate.Size = New Size(160, 40)
        btnPopulate.TabIndex = 34
        btnPopulate.Text = "Refresh"
        btnPopulate.UseVisualStyleBackColor = False
        ' 
        ' GradingSystemLbl
        ' 
        GradingSystemLbl.AutoSize = True
        GradingSystemLbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GradingSystemLbl.ForeColor = SystemColors.ActiveCaption
        GradingSystemLbl.Location = New Point(485, 56)
        GradingSystemLbl.Name = "GradingSystemLbl"
        GradingSystemLbl.Size = New Size(389, 45)
        GradingSystemLbl.TabIndex = 0
        GradingSystemLbl.Text = "GRADING SYSTEM"
        ' 
        ' PlpLogoPicBox
        ' 
        PlpLogoPicBox.Image = CType(resources.GetObject("PlpLogoPicBox.Image"), Image)
        PlpLogoPicBox.Location = New Point(38, 30)
        PlpLogoPicBox.Name = "PlpLogoPicBox"
        PlpLogoPicBox.Size = New Size(104, 94)
        PlpLogoPicBox.SizeMode = PictureBoxSizeMode.Zoom
        PlpLogoPicBox.TabIndex = 11
        PlpLogoPicBox.TabStop = False
        ' 
        ' CCSLogoPicBox
        ' 
        CCSLogoPicBox.Image = CType(resources.GetObject("CCSLogoPicBox.Image"), Image)
        CCSLogoPicBox.Location = New Point(1157, 56)
        CCSLogoPicBox.Name = "CCSLogoPicBox"
        CCSLogoPicBox.Size = New Size(117, 84)
        CCSLogoPicBox.SizeMode = PictureBoxSizeMode.Zoom
        CCSLogoPicBox.TabIndex = 12
        CCSLogoPicBox.TabStop = False
        ' 
        ' GradeSystemPanel
        ' 
        GradeSystemPanel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GradeSystemPanel.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        GradeSystemPanel.Controls.Add(CCSLogoPicBox)
        GradeSystemPanel.Controls.Add(PlpLogoPicBox)
        GradeSystemPanel.Controls.Add(GradingSystemLbl)
        GradeSystemPanel.Location = New Point(13, 11)
        GradeSystemPanel.Name = "GradeSystemPanel"
        GradeSystemPanel.Size = New Size(1753, 176)
        GradeSystemPanel.TabIndex = 0
        ' 
        ' resetBtn
        ' 
        resetBtn.Location = New Point(568, 663)
        resetBtn.Name = "resetBtn"
        resetBtn.Size = New Size(66, 29)
        resetBtn.TabIndex = 38
        resetBtn.Text = "reset"
        resetBtn.UseVisualStyleBackColor = True
        ' 
        ' FullnameReminderLbl
        ' 
        FullnameReminderLbl.AutoSize = True
        FullnameReminderLbl.BackColor = Color.Transparent
        FullnameReminderLbl.Font = New Font("Segoe UI", 8F)
        FullnameReminderLbl.ForeColor = Color.Black
        FullnameReminderLbl.Location = New Point(42, 867)
        FullnameReminderLbl.Name = "FullnameReminderLbl"
        FullnameReminderLbl.Size = New Size(216, 19)
        FullnameReminderLbl.TabIndex = 13
        FullnameReminderLbl.Text = "Surname, Firstname, Middle Initial"
        ' 
        ' StudentNameLblbox
        ' 
        StudentNameLblbox.AutoSize = True
        StudentNameLblbox.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StudentNameLblbox.ForeColor = Color.Black
        StudentNameLblbox.Location = New Point(47, 794)
        StudentNameLblbox.Name = "StudentNameLblbox"
        StudentNameLblbox.Size = New Size(115, 21)
        StudentNameLblbox.TabIndex = 3
        StudentNameLblbox.Text = "Student Name"
        ' 
        ' StudentNameTxtBox
        ' 
        StudentNameTxtBox.Enabled = False
        StudentNameTxtBox.ForeColor = Color.Black
        StudentNameTxtBox.Location = New Point(47, 828)
        StudentNameTxtBox.MaxLength = 35
        StudentNameTxtBox.Name = "StudentNameTxtBox"
        StudentNameTxtBox.ReadOnly = True
        StudentNameTxtBox.Size = New Size(234, 27)
        StudentNameTxtBox.TabIndex = 4
        ' 
        ' SectionLbl
        ' 
        SectionLbl.AutoSize = True
        SectionLbl.BackColor = Color.Transparent
        SectionLbl.Font = New Font("Tahoma", 10.2F)
        SectionLbl.ForeColor = SystemColors.ActiveCaptionText
        SectionLbl.Location = New Point(349, 723)
        SectionLbl.Name = "SectionLbl"
        SectionLbl.Size = New Size(66, 21)
        SectionLbl.TabIndex = 21
        SectionLbl.Text = "Classes"
        ' 
        ' sectionTxtBox
        ' 
        sectionTxtBox.Enabled = False
        sectionTxtBox.Location = New Point(349, 756)
        sectionTxtBox.Name = "sectionTxtBox"
        sectionTxtBox.ReadOnly = True
        sectionTxtBox.Size = New Size(234, 27)
        sectionTxtBox.TabIndex = 36
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Tahoma", 10.2F)
        Label26.ForeColor = SystemColors.ActiveCaptionText
        Label26.Location = New Point(350, 800)
        Label26.Name = "Label26"
        Label26.Size = New Size(65, 21)
        Label26.TabIndex = 40
        Label26.Text = "Subject"
        ' 
        ' Sub_txt
        ' 
        Sub_txt.Enabled = False
        Sub_txt.Location = New Point(350, 834)
        Sub_txt.Name = "Sub_txt"
        Sub_txt.Size = New Size(233, 27)
        Sub_txt.TabIndex = 41
        ' 
        ' MidtermForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1778, 1051)
        Controls.Add(patongPanel)
        Controls.Add(Sub_txt)
        Controls.Add(Label26)
        Controls.Add(resetBtn)
        Controls.Add(sectionTxtBox)
        Controls.Add(btnPopulate)
        Controls.Add(btnSEARC)
        Controls.Add(txtSEARC)
        Controls.Add(Label25)
        Controls.Add(showGradeBtn)
        Controls.Add(cbSUB)
        Controls.Add(SubjectLbl)
        Controls.Add(dgvMIDTERM)
        Controls.Add(cbSEM)
        Controls.Add(SemesterLbl)
        Controls.Add(cbSEC)
        Controls.Add(ExitBtn)
        Controls.Add(SectionLbl)
        Controls.Add(CancelBtn)
        Controls.Add(GradeSystemPanel)
        Controls.Add(FullnameReminderLbl)
        Controls.Add(MidtermPanel)
        Controls.Add(StudentNameTxtBox)
        Controls.Add(StudentIdLbl)
        Controls.Add(StudentNameLblbox)
        Controls.Add(StudentIDTxtBox)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "MidtermForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Midterm"
        MidtermPanel.ResumeLayout(False)
        MidtermPanel.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        GradeEquivalentPanel.ResumeLayout(False)
        GradeEquivalentPanel.PerformLayout()
        MidtermGradeBorderPanel.ResumeLayout(False)
        MidtermGradeBorderPanel.PerformLayout()
        CType(dgvMIDTERM, ComponentModel.ISupportInitialize).EndInit()
        CType(PlpLogoPicBox, ComponentModel.ISupportInitialize).EndInit()
        CType(CCSLogoPicBox, ComponentModel.ISupportInitialize).EndInit()
        GradeSystemPanel.ResumeLayout(False)
        GradeSystemPanel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents StudentIdLbl As Label
    Friend WithEvents StudentIDTxtBox As TextBox
    Friend WithEvents MidtermPanel As Panel
    Friend WithEvents ClearAllBtn As Button
    Friend WithEvents ComputeBtn As Button
    Friend WithEvents MidtermGradeLbl As Label
    Friend WithEvents MidtermGradeBorderPanel As Panel
    Friend WithEvents MidGradePromptTxtBox As TextBox
    Friend WithEvents SaveBtn As Button
    Friend WithEvents CancelBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents showGradeBtn As Button
    Friend WithEvents SubjectLbl As Label
    Friend WithEvents MidtermPercentLbl As Label
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
    Friend WithEvents RemarksScoreLbl As Label
    Friend WithEvents RemarksLbl As Label
    Friend WithEvents cbSEM As ComboBox
    Friend WithEvents SemesterLbl As Label
    Friend WithEvents cbSUB As ComboBox
    Friend WithEvents cbSEC As ComboBox
    Friend WithEvents dgvMIDTERM As DataGridView
    Friend WithEvents Label25 As Label
    Friend WithEvents txtSEARC As TextBox
    Friend WithEvents btnSEARC As Button
    Friend WithEvents btnPopulate As Button
    Friend WithEvents GradingSystemLbl As Label
    Friend WithEvents PlpLogoPicBox As PictureBox
    Friend WithEvents CCSLogoPicBox As PictureBox
    Friend WithEvents GradeSystemPanel As Panel
    Friend WithEvents resetBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents AttendanceComboBox As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents AttendanceTxtBox As TextBox
    Friend WithEvents AttendanceLbl As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label24 As Label
    Friend WithEvents LabComputeBtn As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Lab4TxtBox As TextBox
    Friend WithEvents Lab3TxtBox As TextBox
    Friend WithEvents Lab2TxtBox As TextBox
    Friend WithEvents Lab1TxtBox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents NumberOfLabExerciseComboBox As ComboBox
    Friend WithEvents LabExerTxtBox As TextBox
    Friend WithEvents LabExercisesLbl As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents RecitTxtbox As TextBox
    Friend WithEvents CaseStudyTxtbox As TextBox
    Friend WithEvents RecitLbl As Label
    Friend WithEvents CaseStudyLbl As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents QuizComputeBtn As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents QuizTotalItemsTextBox As TextBox
    Friend WithEvents QuizTotalScoreTxtBox As TextBox
    Friend WithEvents QuizPerecntLbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Q4MaxTxtBox As TextBox
    Friend WithEvents Q4InputTxtBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Q3MaxTxtBox As TextBox
    Friend WithEvents Q3InputTxtBox As TextBox
    Friend WithEvents Q4Lbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Q2MaxTxtBox As TextBox
    Friend WithEvents Q2InputTxtBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Q1MaxTxtBox As TextBox
    Friend WithEvents Q1InputTxtBox As TextBox
    Friend WithEvents Q3Lbl As Label
    Friend WithEvents Q2Lbl As Label
    Friend WithEvents Q1Lbl As Label
    Friend WithEvents NumQuizzesLbl As Label
    Friend WithEvents NumberOfQuizComboBox As ComboBox
    Friend WithEvents QuizzesTxtBox As TextBox
    Friend WithEvents QuizzesLbl As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents MaxMidExamTxtBox As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents MidtermExamLbl As Label
    Friend WithEvents FinalExamComputeBtn As Button
    Friend WithEvents MidtermExamTxtBox As TextBox
    Friend WithEvents EqualLabel As Label
    Friend WithEvents InputMidExamTxtBox As TextBox
    Friend WithEvents Overlbl As Label
    Friend WithEvents patongPanel As Panel
    Friend WithEvents FullnameReminderLbl As Label
    Friend WithEvents StudentNameLblbox As Label
    Friend WithEvents StudentNameTxtBox As TextBox
    Friend WithEvents SectionLbl As Label
    Friend WithEvents sectionTxtBox As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Sub_txt As TextBox
End Class
