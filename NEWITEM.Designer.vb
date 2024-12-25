<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NEWITEM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NEWITEM))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        txtProfessorID = New TextBox()
        txtSubjectCode = New TextBox()
        txtDay = New TextBox()
        txtTime = New TextBox()
        txtSubjectName = New TextBox()
        btnExit = New Button()
        btnCancel = New Button()
        btnSave = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        cmbSectionCode = New ComboBox()
        cmbDepartmentCode = New ComboBox()
        cmbProgramCode = New ComboBox()
        cmbSemester = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Tahoma", 10.2F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(54, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 21)
        Label1.TabIndex = 0
        Label1.Text = "Professor ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Tahoma", 10.2F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(54, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 21)
        Label2.TabIndex = 1
        Label2.Text = "Subject Code"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Tahoma", 10.2F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(55, 184)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 21)
        Label3.TabIndex = 2
        Label3.Text = "Section Code"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Tahoma", 10.2F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(55, 248)
        Label4.Name = "Label4"
        Label4.Size = New Size(141, 21)
        Label4.TabIndex = 3
        Label4.Text = "Department Code"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Tahoma", 10.2F)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(55, 311)
        Label5.Name = "Label5"
        Label5.Size = New Size(39, 21)
        Label5.TabIndex = 4
        Label5.Text = "Day"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Tahoma", 10.2F)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(335, 82)
        Label6.Name = "Label6"
        Label6.Size = New Size(47, 21)
        Label6.TabIndex = 5
        Label6.Text = "Time"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Tahoma", 10.2F)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(335, 148)
        Label7.Name = "Label7"
        Label7.Size = New Size(113, 21)
        Label7.TabIndex = 6
        Label7.Text = "Subject Name"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Tahoma", 10.2F)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(335, 213)
        Label8.Name = "Label8"
        Label8.Size = New Size(114, 21)
        Label8.TabIndex = 7
        Label8.Text = "Program Code"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Tahoma", 10.2F)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(335, 279)
        Label9.Name = "Label9"
        Label9.Size = New Size(80, 21)
        Label9.TabIndex = 8
        Label9.Text = "Semester"
        ' 
        ' txtProfessorID
        ' 
        txtProfessorID.Font = New Font("Tahoma", 10.2F)
        txtProfessorID.Location = New Point(83, 73)
        txtProfessorID.Name = "txtProfessorID"
        txtProfessorID.Size = New Size(229, 28)
        txtProfessorID.TabIndex = 9
        ' 
        ' txtSubjectCode
        ' 
        txtSubjectCode.Font = New Font("Tahoma", 10.2F)
        txtSubjectCode.Location = New Point(83, 137)
        txtSubjectCode.Name = "txtSubjectCode"
        txtSubjectCode.Size = New Size(229, 28)
        txtSubjectCode.TabIndex = 10
        ' 
        ' txtDay
        ' 
        txtDay.Font = New Font("Tahoma", 10.2F)
        txtDay.Location = New Point(83, 335)
        txtDay.Name = "txtDay"
        txtDay.Size = New Size(229, 28)
        txtDay.TabIndex = 13
        ' 
        ' txtTime
        ' 
        txtTime.Font = New Font("Tahoma", 10.2F)
        txtTime.Location = New Point(363, 106)
        txtTime.Name = "txtTime"
        txtTime.Size = New Size(229, 28)
        txtTime.TabIndex = 14
        ' 
        ' txtSubjectName
        ' 
        txtSubjectName.Font = New Font("Tahoma", 10.2F)
        txtSubjectName.Location = New Point(363, 172)
        txtSubjectName.Name = "txtSubjectName"
        txtSubjectName.Size = New Size(229, 28)
        txtSubjectName.TabIndex = 15
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Tahoma", 10.2F)
        btnExit.Location = New Point(484, 527)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(151, 29)
        btnExit.TabIndex = 251
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Font = New Font("Tahoma", 10.2F)
        btnCancel.Location = New Point(303, 506)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(151, 29)
        btnCancel.TabIndex = 250
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Tahoma", 10.2F)
        btnSave.Location = New Point(124, 543)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(151, 29)
        btnSave.TabIndex = 249
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Tahoma", 10.2F)
        btnDelete.Location = New Point(303, 541)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(151, 32)
        btnDelete.TabIndex = 248
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Tahoma", 10.2F)
        btnUpdate.Location = New Point(124, 506)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(151, 32)
        btnUpdate.TabIndex = 247
        btnUpdate.Text = "UPDATE"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' cmbSectionCode
        ' 
        cmbSectionCode.Font = New Font("Tahoma", 10.2F)
        cmbSectionCode.FormattingEnabled = True
        cmbSectionCode.Location = New Point(83, 208)
        cmbSectionCode.Name = "cmbSectionCode"
        cmbSectionCode.Size = New Size(229, 29)
        cmbSectionCode.TabIndex = 252
        ' 
        ' cmbDepartmentCode
        ' 
        cmbDepartmentCode.Font = New Font("Tahoma", 10.2F)
        cmbDepartmentCode.FormattingEnabled = True
        cmbDepartmentCode.Location = New Point(83, 272)
        cmbDepartmentCode.Name = "cmbDepartmentCode"
        cmbDepartmentCode.Size = New Size(229, 29)
        cmbDepartmentCode.TabIndex = 253
        ' 
        ' cmbProgramCode
        ' 
        cmbProgramCode.Font = New Font("Tahoma", 10.2F)
        cmbProgramCode.FormattingEnabled = True
        cmbProgramCode.Location = New Point(363, 237)
        cmbProgramCode.Name = "cmbProgramCode"
        cmbProgramCode.Size = New Size(229, 29)
        cmbProgramCode.TabIndex = 254
        ' 
        ' cmbSemester
        ' 
        cmbSemester.Font = New Font("Tahoma", 10.2F)
        cmbSemester.FormattingEnabled = True
        cmbSemester.Location = New Point(363, 303)
        cmbSemester.Name = "cmbSemester"
        cmbSemester.Size = New Size(229, 29)
        cmbSemester.TabIndex = 255
        ' 
        ' NEWITEM
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1053, 616)
        Controls.Add(cmbSemester)
        Controls.Add(cmbProgramCode)
        Controls.Add(cmbDepartmentCode)
        Controls.Add(cmbSectionCode)
        Controls.Add(btnExit)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(txtSubjectName)
        Controls.Add(txtTime)
        Controls.Add(txtDay)
        Controls.Add(txtSubjectCode)
        Controls.Add(txtProfessorID)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
        Name = "NEWITEM"
        StartPosition = FormStartPosition.CenterScreen
        Text = "NEWITEM"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtProfessorID As TextBox
    Friend WithEvents txtSubjectCode As TextBox
    Friend WithEvents txtSectionCode As TextBox
    Friend WithEvents txtDepartmentCode As TextBox
    Friend WithEvents txtDay As TextBox
    Friend WithEvents txtTime As TextBox
    Friend WithEvents txtSubjectName As TextBox
    Friend WithEvents txtProgramCode As TextBox
    Friend WithEvents txtSemester As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents cmbSectionCode As ComboBox
    Friend WithEvents cmbDepartmentCode As ComboBox
    Friend WithEvents cmbProgramCode As ComboBox
    Friend WithEvents cmbSemester As ComboBox
End Class
