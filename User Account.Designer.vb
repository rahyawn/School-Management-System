<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class User_Account
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
        DataGridView1 = New DataGridView()
        btnRefresh = New Button()
        btnDelete = New Button()
        cboQuestionNo = New ComboBox()
        cboUserType = New ComboBox()
        txtAnswer = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnClear = New Button()
        btnAdd = New Button()
        txtPassword = New TextBox()
        txtEmail = New TextBox()
        txtProfessorID = New TextBox()
        Label7 = New Label()
        txtStudentID = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        txtAccountID = New TextBox()
        txtAccountID2 = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(240, 379)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(812, 304)
        DataGridView1.TabIndex = 0
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.SkyBlue
        btnRefresh.Location = New Point(111, 379)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(113, 48)
        btnRefresh.TabIndex = 1
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(12, 566)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(90, 55)
        btnDelete.TabIndex = 33
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' cboQuestionNo
        ' 
        cboQuestionNo.FormattingEnabled = True
        cboQuestionNo.Location = New Point(692, 238)
        cboQuestionNo.Name = "cboQuestionNo"
        cboQuestionNo.Size = New Size(271, 28)
        cboQuestionNo.TabIndex = 32
        ' 
        ' cboUserType
        ' 
        cboUserType.FormattingEnabled = True
        cboUserType.Location = New Point(18, 48)
        cboUserType.Name = "cboUserType"
        cboUserType.Size = New Size(259, 28)
        cboUserType.TabIndex = 31
        ' 
        ' txtAnswer
        ' 
        txtAnswer.Location = New Point(692, 301)
        txtAnswer.Multiline = True
        txtAnswer.Name = "txtAnswer"
        txtAnswer.Size = New Size(271, 34)
        txtAnswer.TabIndex = 30
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(692, 275)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 20)
        Label6.TabIndex = 29
        Label6.Text = "Answer"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(692, 215)
        Label5.Name = "Label5"
        Label5.Size = New Size(95, 20)
        Label5.TabIndex = 28
        Label5.Text = "Question No."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(18, 25)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 20)
        Label4.TabIndex = 27
        Label4.Text = "User Type"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(380, 278)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 20)
        Label3.TabIndex = 26
        Label3.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(81, 278)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 20)
        Label2.TabIndex = 25
        Label2.Text = "Email"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(379, 158)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 20)
        Label1.TabIndex = 24
        Label1.Text = "Professor ID"
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Crimson
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(111, 433)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(113, 49)
        btnClear.TabIndex = 23
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.ForestGreen
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(12, 505)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 55)
        btnAdd.TabIndex = 22
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(380, 301)
        txtPassword.Multiline = True
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(270, 34)
        txtPassword.TabIndex = 21
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(70, 301)
        txtEmail.Multiline = True
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(270, 34)
        txtEmail.TabIndex = 20
        ' 
        ' txtProfessorID
        ' 
        txtProfessorID.Location = New Point(380, 181)
        txtProfessorID.Multiline = True
        txtProfessorID.Name = "txtProfessorID"
        txtProfessorID.Size = New Size(270, 34)
        txtProfessorID.TabIndex = 19
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(70, 155)
        Label7.Name = "Label7"
        Label7.Size = New Size(79, 20)
        Label7.TabIndex = 34
        Label7.Text = "Student ID"
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Location = New Point(70, 181)
        txtStudentID.Multiline = True
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(270, 34)
        txtStudentID.TabIndex = 35
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(73, 218)
        Label8.Name = "Label8"
        Label8.Size = New Size(82, 20)
        Label8.TabIndex = 36
        Label8.Text = "Account ID"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(380, 218)
        Label9.Name = "Label9"
        Label9.Size = New Size(82, 20)
        Label9.TabIndex = 37
        Label9.Text = "Account ID"
        ' 
        ' txtAccountID
        ' 
        txtAccountID.Location = New Point(70, 241)
        txtAccountID.Multiline = True
        txtAccountID.Name = "txtAccountID"
        txtAccountID.Size = New Size(270, 34)
        txtAccountID.TabIndex = 38
        ' 
        ' txtAccountID2
        ' 
        txtAccountID2.Location = New Point(380, 241)
        txtAccountID2.Multiline = True
        txtAccountID2.Name = "txtAccountID2"
        txtAccountID2.Size = New Size(270, 34)
        txtAccountID2.TabIndex = 39
        ' 
        ' User_Account
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(1089, 708)
        Controls.Add(txtAccountID2)
        Controls.Add(txtAccountID)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(txtStudentID)
        Controls.Add(Label7)
        Controls.Add(btnDelete)
        Controls.Add(cboQuestionNo)
        Controls.Add(cboUserType)
        Controls.Add(txtAnswer)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnClear)
        Controls.Add(btnAdd)
        Controls.Add(txtPassword)
        Controls.Add(txtEmail)
        Controls.Add(txtProfessorID)
        Controls.Add(btnRefresh)
        Controls.Add(DataGridView1)
        Name = "User_Account"
        StartPosition = FormStartPosition.CenterScreen
        Text = "User_Account"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents cboQuestionNo As ComboBox
    Friend WithEvents cboUserType As ComboBox
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtProfessorID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtAccountID As TextBox
    Friend WithEvents txtAccountID2 As TextBox
End Class
