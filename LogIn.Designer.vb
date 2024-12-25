<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogInForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogInForm))
        LogInSystemPanel = New Panel()
        UserTypeComboBox = New ComboBox()
        LinkLabel1 = New LinkLabel()
        PassPicturePicbox = New PictureBox()
        EmailPicturePicBox = New PictureBox()
        LogInTitleMessageLbl = New Label()
        LogInBtn = New Button()
        CloseBtnLogIn = New Button()
        PasswordLogInTxtBox = New TextBox()
        StudentIDTxtbox = New TextBox()
        CCSPicBox = New PictureBox()
        LogInSystemPanel.SuspendLayout()
        CType(PassPicturePicbox, ComponentModel.ISupportInitialize).BeginInit()
        CType(EmailPicturePicBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(CCSPicBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LogInSystemPanel
        ' 
        LogInSystemPanel.BackColor = Color.Gainsboro
        LogInSystemPanel.Controls.Add(CCSPicBox)
        LogInSystemPanel.Controls.Add(UserTypeComboBox)
        LogInSystemPanel.Controls.Add(LinkLabel1)
        LogInSystemPanel.Controls.Add(PassPicturePicbox)
        LogInSystemPanel.Controls.Add(EmailPicturePicBox)
        LogInSystemPanel.Controls.Add(LogInTitleMessageLbl)
        LogInSystemPanel.Controls.Add(LogInBtn)
        LogInSystemPanel.Controls.Add(CloseBtnLogIn)
        LogInSystemPanel.Controls.Add(PasswordLogInTxtBox)
        LogInSystemPanel.Controls.Add(StudentIDTxtbox)
        LogInSystemPanel.Location = New Point(357, -2)
        LogInSystemPanel.Name = "LogInSystemPanel"
        LogInSystemPanel.Size = New Size(665, 706)
        LogInSystemPanel.TabIndex = 0
        ' 
        ' UserTypeComboBox
        ' 
        UserTypeComboBox.FormattingEnabled = True
        UserTypeComboBox.Location = New Point(222, 359)
        UserTypeComboBox.Name = "UserTypeComboBox"
        UserTypeComboBox.Size = New Size(267, 26)
        UserTypeComboBox.TabIndex = 12
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkLabel1.Location = New Point(283, 571)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(165, 21)
        LinkLabel1.TabIndex = 2
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Forgot Password?"
        ' 
        ' PassPicturePicbox
        ' 
        PassPicturePicbox.Image = CType(resources.GetObject("PassPicturePicbox.Image"), Image)
        PassPicturePicbox.Location = New Point(160, 299)
        PassPicturePicbox.Name = "PassPicturePicbox"
        PassPicturePicbox.Size = New Size(56, 37)
        PassPicturePicbox.SizeMode = PictureBoxSizeMode.Zoom
        PassPicturePicbox.TabIndex = 8
        PassPicturePicbox.TabStop = False
        ' 
        ' EmailPicturePicBox
        ' 
        EmailPicturePicBox.Image = CType(resources.GetObject("EmailPicturePicBox.Image"), Image)
        EmailPicturePicBox.Location = New Point(160, 248)
        EmailPicturePicBox.Name = "EmailPicturePicBox"
        EmailPicturePicBox.Size = New Size(56, 37)
        EmailPicturePicBox.SizeMode = PictureBoxSizeMode.Zoom
        EmailPicturePicBox.TabIndex = 7
        EmailPicturePicBox.TabStop = False
        ' 
        ' LogInTitleMessageLbl
        ' 
        LogInTitleMessageLbl.AutoSize = True
        LogInTitleMessageLbl.BackColor = Color.Snow
        LogInTitleMessageLbl.Font = New Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LogInTitleMessageLbl.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        LogInTitleMessageLbl.Location = New Point(160, 162)
        LogInTitleMessageLbl.Name = "LogInTitleMessageLbl"
        LogInTitleMessageLbl.Size = New Size(376, 41)
        LogInTitleMessageLbl.TabIndex = 1
        LogInTitleMessageLbl.Text = "Sign-in your Account"
        ' 
        ' LogInBtn
        ' 
        LogInBtn.BackColor = Color.Gold
        LogInBtn.Location = New Point(222, 433)
        LogInBtn.Name = "LogInBtn"
        LogInBtn.Size = New Size(267, 49)
        LogInBtn.TabIndex = 6
        LogInBtn.Text = "LOG IN"
        LogInBtn.UseVisualStyleBackColor = False
        ' 
        ' CloseBtnLogIn
        ' 
        CloseBtnLogIn.BackColor = Color.SandyBrown
        CloseBtnLogIn.Location = New Point(222, 488)
        CloseBtnLogIn.Name = "CloseBtnLogIn"
        CloseBtnLogIn.Size = New Size(267, 47)
        CloseBtnLogIn.TabIndex = 5
        CloseBtnLogIn.Text = "Close"
        CloseBtnLogIn.UseVisualStyleBackColor = False
        ' 
        ' PasswordLogInTxtBox
        ' 
        PasswordLogInTxtBox.Location = New Point(222, 299)
        PasswordLogInTxtBox.MaxLength = 20
        PasswordLogInTxtBox.Multiline = True
        PasswordLogInTxtBox.Name = "PasswordLogInTxtBox"
        PasswordLogInTxtBox.Size = New Size(267, 37)
        PasswordLogInTxtBox.TabIndex = 3
        ' 
        ' StudentIDTxtbox
        ' 
        StudentIDTxtbox.Location = New Point(222, 244)
        StudentIDTxtbox.MaxLength = 20
        StudentIDTxtbox.Multiline = True
        StudentIDTxtbox.Name = "StudentIDTxtbox"
        StudentIDTxtbox.Size = New Size(267, 37)
        StudentIDTxtbox.TabIndex = 2
        ' 
        ' CCSPicBox
        ' 
        CCSPicBox.Image = CType(resources.GetObject("CCSPicBox.Image"), Image)
        CCSPicBox.Location = New Point(3, 27)
        CCSPicBox.Name = "CCSPicBox"
        CCSPicBox.Size = New Size(662, 119)
        CCSPicBox.SizeMode = PictureBoxSizeMode.Zoom
        CCSPicBox.TabIndex = 1
        CCSPicBox.TabStop = False
        ' 
        ' LogInForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1097, 703)
        ControlBox = False
        Controls.Add(LogInSystemPanel)
        Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Name = "LogInForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LogIn"
        LogInSystemPanel.ResumeLayout(False)
        LogInSystemPanel.PerformLayout()
        CType(PassPicturePicbox, ComponentModel.ISupportInitialize).EndInit()
        CType(EmailPicturePicBox, ComponentModel.ISupportInitialize).EndInit()
        CType(CCSPicBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents LogInSystemPanel As Panel
    Friend WithEvents LogInTitleMessageLbl As Label
    Friend WithEvents PasswordLogInLbl As Label
    Friend WithEvents EmailLogInLbl As Label
    Friend WithEvents LogInBtn As Button
    Friend WithEvents CloseBtnLogIn As Button
    Friend WithEvents ShowPassBtnLogIn As Button
    Friend WithEvents PasswordLogInTxtBox As TextBox
    Friend WithEvents StudentIDTxtbox As TextBox
    Friend WithEvents PassPicturePicbox As PictureBox
    Friend WithEvents EmailPicturePicBox As PictureBox
    Friend WithEvents CCSPicBox As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents UserTypeComboBox As ComboBox
End Class
