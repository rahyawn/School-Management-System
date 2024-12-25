<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Change_Password
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Change_Password))
        TabControl1 = New TabControl()
        TabPage4 = New TabPage()
        proceedIDBtn = New Button()
        IDTxtBox = New TextBox()
        Label9 = New Label()
        Label5 = New Label()
        TabPage1 = New TabPage()
        Label4 = New Label()
        btn_step1proceed = New Button()
        txtEmail = New TextBox()
        Label2 = New Label()
        TabPage2 = New TabPage()
        Button5 = New Button()
        Button4 = New Button()
        question = New Label()
        Label3 = New Label()
        Label6 = New Label()
        TextBox2 = New TextBox()
        TabPage5 = New TabPage()
        btnProceed = New Button()
        TextBox1 = New TextBox()
        Label10 = New Label()
        TabPage3 = New TabPage()
        Button1 = New Button()
        Button6 = New Button()
        btnSave = New Button()
        Label8 = New Label()
        Label7 = New Label()
        txtConfirmPassword = New TextBox()
        txtPassword = New TextBox()
        Label1 = New Label()
        TabControl1.SuspendLayout()
        TabPage4.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage5.SuspendLayout()
        TabPage3.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage5)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(94, 101)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(901, 449)
        TabControl1.TabIndex = 1
        ' 
        ' TabPage4
        ' 
        TabPage4.BackgroundImage = CType(resources.GetObject("TabPage4.BackgroundImage"), Image)
        TabPage4.BackgroundImageLayout = ImageLayout.Stretch
        TabPage4.Controls.Add(proceedIDBtn)
        TabPage4.Controls.Add(IDTxtBox)
        TabPage4.Controls.Add(Label9)
        TabPage4.Controls.Add(Label5)
        TabPage4.Location = New Point(4, 29)
        TabPage4.Name = "TabPage4"
        TabPage4.Size = New Size(893, 416)
        TabPage4.TabIndex = 3
        TabPage4.Text = "ID Validation"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' proceedIDBtn
        ' 
        proceedIDBtn.Font = New Font("Tahoma", 10.2F)
        proceedIDBtn.ForeColor = Color.Black
        proceedIDBtn.Location = New Point(295, 175)
        proceedIDBtn.Name = "proceedIDBtn"
        proceedIDBtn.Size = New Size(149, 31)
        proceedIDBtn.TabIndex = 3
        proceedIDBtn.Text = "Proceed"
        proceedIDBtn.UseVisualStyleBackColor = True
        ' 
        ' IDTxtBox
        ' 
        IDTxtBox.BackColor = Color.DarkGray
        IDTxtBox.Font = New Font("Tahoma", 10.2F)
        IDTxtBox.ForeColor = Color.Black
        IDTxtBox.Location = New Point(244, 128)
        IDTxtBox.Name = "IDTxtBox"
        IDTxtBox.Size = New Size(249, 28)
        IDTxtBox.TabIndex = 2
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Tahoma", 16.2F, FontStyle.Bold)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(266, 68)
        Label9.Name = "Label9"
        Label9.Size = New Size(205, 34)
        Label9.TabIndex = 1
        Label9.Text = "[ StudentID ]"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 16.2F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(166, 106)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 34)
        Label5.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Transparent
        TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), Image)
        TabPage1.BackgroundImageLayout = ImageLayout.Stretch
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(btn_step1proceed)
        TabPage1.Controls.Add(txtEmail)
        TabPage1.Controls.Add(Label2)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(893, 416)
        TabPage1.TabIndex = 0
        TabPage1.Text = "1 : Email Validation"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 16.2F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(41, 152)
        Label4.Name = "Label4"
        Label4.Size = New Size(309, 34)
        Label4.TabIndex = 3
        Label4.Text = "[ Username / Email ]"
        ' 
        ' btn_step1proceed
        ' 
        btn_step1proceed.BackColor = Color.Transparent
        btn_step1proceed.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_step1proceed.Location = New Point(127, 231)
        btn_step1proceed.Name = "btn_step1proceed"
        btn_step1proceed.Size = New Size(129, 29)
        btn_step1proceed.TabIndex = 2
        btn_step1proceed.Text = "Proceed"
        btn_step1proceed.UseVisualStyleBackColor = False
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.DimGray
        txtEmail.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmail.Location = New Point(67, 199)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(251, 26)
        txtEmail.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(167, 121)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 34)
        Label2.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.Gainsboro
        TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), Image)
        TabPage2.BackgroundImageLayout = ImageLayout.Stretch
        TabPage2.Controls.Add(Button5)
        TabPage2.Controls.Add(Button4)
        TabPage2.Controls.Add(question)
        TabPage2.Controls.Add(Label3)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(TextBox2)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(893, 416)
        TabPage2.TabIndex = 1
        TabPage2.Text = "2 : Security Questions"
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        Button5.Location = New Point(89, 307)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 29)
        Button5.TabIndex = 9
        Button5.Text = "Go Back"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        Button4.Location = New Point(189, 307)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 8
        Button4.Text = "Proceed"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' question
        ' 
        question.AutoSize = True
        question.BackColor = Color.Transparent
        question.Font = New Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        question.ForeColor = Color.White
        question.Location = New Point(77, 147)
        question.Name = "question"
        question.Size = New Size(252, 22)
        question.TabIndex = 7
        question.Text = "[Security question of User]"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(77, 230)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 24)
        Label3.TabIndex = 6
        Label3.Text = "Answer:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(60, 111)
        Label6.Name = "Label6"
        Label6.Size = New Size(292, 36)
        Label6.TabIndex = 5
        Label6.Text = "Security Question:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        TextBox2.Location = New Point(74, 254)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(262, 26)
        TextBox2.TabIndex = 1
        ' 
        ' TabPage5
        ' 
        TabPage5.Controls.Add(btnProceed)
        TabPage5.Controls.Add(TextBox1)
        TabPage5.Controls.Add(Label10)
        TabPage5.Location = New Point(4, 29)
        TabPage5.Name = "TabPage5"
        TabPage5.Size = New Size(893, 416)
        TabPage5.TabIndex = 4
        TabPage5.Text = "3 : Current Password"
        TabPage5.UseVisualStyleBackColor = True
        ' 
        ' btnProceed
        ' 
        btnProceed.Location = New Point(256, 193)
        btnProceed.Name = "btnProceed"
        btnProceed.Size = New Size(94, 29)
        btnProceed.TabIndex = 2
        btnProceed.Text = "Proceed"
        btnProceed.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(193, 150)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(219, 27)
        TextBox1.TabIndex = 1
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(214, 127)
        Label10.Name = "Label10"
        Label10.Size = New Size(163, 20)
        Label10.TabIndex = 0
        Label10.Text = "Enter Current Password:"
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.LightGray
        TabPage3.BackgroundImage = CType(resources.GetObject("TabPage3.BackgroundImage"), Image)
        TabPage3.BackgroundImageLayout = ImageLayout.Stretch
        TabPage3.Controls.Add(Button1)
        TabPage3.Controls.Add(Button6)
        TabPage3.Controls.Add(btnSave)
        TabPage3.Controls.Add(Label8)
        TabPage3.Controls.Add(Label7)
        TabPage3.Controls.Add(txtConfirmPassword)
        TabPage3.Controls.Add(txtPassword)
        TabPage3.Location = New Point(4, 29)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(893, 416)
        TabPage3.TabIndex = 2
        TabPage3.Text = "4 : Change Password"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(773, 357)
        Button1.Name = "Button1"
        Button1.Size = New Size(114, 36)
        Button1.TabIndex = 8
        Button1.Text = "Exit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(338, 359)
        Button6.Name = "Button6"
        Button6.Size = New Size(113, 36)
        Button6.TabIndex = 7
        Button6.Text = "Back"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(457, 359)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(113, 34)
        btnSave.TabIndex = 4
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.Control
        Label8.Location = New Point(92, 185)
        Label8.Name = "Label8"
        Label8.Size = New Size(187, 18)
        Label8.TabIndex = 3
        Label8.Text = "Confirm New Password:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(92, 106)
        Label7.Name = "Label7"
        Label7.Size = New Size(178, 18)
        Label7.TabIndex = 2
        Label7.Text = "Create New Password:"
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Location = New Point(89, 205)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(271, 27)
        txtConfirmPassword.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(89, 126)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(271, 27)
        txtPassword.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(364, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(408, 36)
        Label1.TabIndex = 2
        Label1.Text = "Change Password Process"
        ' 
        ' Change_Password
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DimGray
        ClientSize = New Size(1088, 651)
        Controls.Add(Label1)
        Controls.Add(TabControl1)
        Name = "Change_Password"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Change Password"
        TabControl1.ResumeLayout(False)
        TabPage4.ResumeLayout(False)
        TabPage4.PerformLayout()
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage5.ResumeLayout(False)
        TabPage5.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents proceedIDBtn As Button
    Friend WithEvents IDTxtBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_step1proceed As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents question As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents btnProceed As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label10 As Label
End Class
