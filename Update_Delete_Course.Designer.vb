<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Update_Delete_Course
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
        txtSearch = New TextBox()
        Label5 = New Label()
        txtProfessorID = New TextBox()
        Label4 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        cmbSubjectCode = New ComboBox()
        btnExit = New Button()
        dgvCourse = New DataGridView()
        btnRefresh = New Button()
        btnProceed = New Button()
        CType(dgvCourse, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(655, 487)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(190, 27)
        txtSearch.TabIndex = 30
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(851, 487)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 20)
        Label5.TabIndex = 29
        Label5.Text = "Search"
        ' 
        ' txtProfessorID
        ' 
        txtProfessorID.Location = New Point(97, 528)
        txtProfessorID.Name = "txtProfessorID"
        txtProfessorID.Size = New Size(179, 27)
        txtProfessorID.TabIndex = 28
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(299, 531)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 20)
        Label4.TabIndex = 27
        Label4.Text = "SubjectID"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sylfaen", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(87, 480)
        Label1.Name = "Label1"
        Label1.Size = New Size(281, 19)
        Label1.TabIndex = 26
        Label1.Text = "Add SubjectID to proceed in Delete/Update"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(840, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 20)
        Label3.TabIndex = 25
        Label3.Text = "Subject Code"
        ' 
        ' cmbSubjectCode
        ' 
        cmbSubjectCode.FormattingEnabled = True
        cmbSubjectCode.Items.AddRange(New Object() {"CAS", "CBA", "CCS", "CIHM", "COE", "COED", "COE", "CON"})
        cmbSubjectCode.Location = New Point(670, 29)
        cmbSubjectCode.Name = "cmbSubjectCode"
        cmbSubjectCode.Size = New Size(151, 28)
        cmbSubjectCode.TabIndex = 24
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(374, 579)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(94, 29)
        btnExit.TabIndex = 23
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' dgvCourse
        ' 
        dgvCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCourse.Location = New Point(87, 76)
        dgvCourse.Name = "dgvCourse"
        dgvCourse.RowHeadersWidth = 51
        dgvCourse.Size = New Size(940, 389)
        dgvCourse.TabIndex = 22
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(37, 16)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(137, 41)
        btnRefresh.TabIndex = 21
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnProceed
        ' 
        btnProceed.Location = New Point(116, 579)
        btnProceed.Name = "btnProceed"
        btnProceed.Size = New Size(94, 29)
        btnProceed.TabIndex = 20
        btnProceed.Text = "Proceed"
        btnProceed.UseVisualStyleBackColor = True
        ' 
        ' UPDATE_DELETE_COURSE
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1065, 624)
        ControlBox = False
        Controls.Add(txtSearch)
        Controls.Add(Label5)
        Controls.Add(txtProfessorID)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(cmbSubjectCode)
        Controls.Add(btnExit)
        Controls.Add(dgvCourse)
        Controls.Add(btnRefresh)
        Controls.Add(btnProceed)
        Name = "UPDATE_DELETE_COURSE"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Update_Delete_Course"
        CType(dgvCourse, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents cmbSectionCodee As ComboBox
    Friend WithEvents lblSectionCode As Label
    Friend WithEvents txtProfessorID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtMiddleInitial As TextBox
    Friend WithEvents txtSuffix As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents ExtensionNameLbl As Label
    Friend WithEvents MidNameLbl As Label
    Friend WithEvents GivenNameLbl As Label
    Friend WithEvents SurnameLbl As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbSubjectCode As ComboBox
    Friend WithEvents dgvCourse As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnProceed As Button
End Class
