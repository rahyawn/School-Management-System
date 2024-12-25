<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class STUDENT_SELECTION
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(STUDENT_SELECTION))
        txtFirstName = New TextBox()
        txtMiddleInitial = New TextBox()
        txtSuffix = New TextBox()
        txtLastName = New TextBox()
        ExtensionNameLbl = New Label()
        MidNameLbl = New Label()
        GivenNameLbl = New Label()
        SurnameLbl = New Label()
        Label1 = New Label()
        btnExit = New Button()
        btnSave = New Button()
        btnClear = New Button()
        txtStudentID = New TextBox()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' txtFirstName
        ' 
        txtFirstName.ForeColor = Color.Black
        txtFirstName.Location = New Point(290, 341)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(226, 27)
        txtFirstName.TabIndex = 193
        ' 
        ' txtMiddleInitial
        ' 
        txtMiddleInitial.ForeColor = Color.Black
        txtMiddleInitial.Location = New Point(290, 386)
        txtMiddleInitial.Name = "txtMiddleInitial"
        txtMiddleInitial.Size = New Size(226, 27)
        txtMiddleInitial.TabIndex = 192
        ' 
        ' txtSuffix
        ' 
        txtSuffix.ForeColor = Color.Black
        txtSuffix.Location = New Point(290, 429)
        txtSuffix.Name = "txtSuffix"
        txtSuffix.Size = New Size(226, 27)
        txtSuffix.TabIndex = 191
        ' 
        ' txtLastName
        ' 
        txtLastName.ForeColor = Color.Black
        txtLastName.Location = New Point(290, 299)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(226, 27)
        txtLastName.TabIndex = 190
        ' 
        ' ExtensionNameLbl
        ' 
        ExtensionNameLbl.AutoSize = True
        ExtensionNameLbl.BackColor = Color.Transparent
        ExtensionNameLbl.Font = New Font("Tahoma", 10.2F, FontStyle.Bold)
        ExtensionNameLbl.ForeColor = Color.White
        ExtensionNameLbl.Location = New Point(127, 429)
        ExtensionNameLbl.Name = "ExtensionNameLbl"
        ExtensionNameLbl.Size = New Size(61, 21)
        ExtensionNameLbl.TabIndex = 189
        ExtensionNameLbl.Text = "Suffix"
        ' 
        ' MidNameLbl
        ' 
        MidNameLbl.AutoSize = True
        MidNameLbl.BackColor = Color.Transparent
        MidNameLbl.Font = New Font("Tahoma", 10.2F, FontStyle.Bold)
        MidNameLbl.ForeColor = Color.White
        MidNameLbl.Location = New Point(127, 387)
        MidNameLbl.Name = "MidNameLbl"
        MidNameLbl.Size = New Size(123, 21)
        MidNameLbl.TabIndex = 188
        MidNameLbl.Text = "Middle Initial"
        ' 
        ' GivenNameLbl
        ' 
        GivenNameLbl.AutoSize = True
        GivenNameLbl.BackColor = Color.Transparent
        GivenNameLbl.Font = New Font("Tahoma", 10.2F, FontStyle.Bold)
        GivenNameLbl.ForeColor = Color.White
        GivenNameLbl.Location = New Point(127, 341)
        GivenNameLbl.Name = "GivenNameLbl"
        GivenNameLbl.Size = New Size(102, 21)
        GivenNameLbl.TabIndex = 187
        GivenNameLbl.Text = "First Name"
        ' 
        ' SurnameLbl
        ' 
        SurnameLbl.AutoSize = True
        SurnameLbl.BackColor = Color.Transparent
        SurnameLbl.Font = New Font("Tahoma", 10.2F, FontStyle.Bold)
        SurnameLbl.ForeColor = Color.White
        SurnameLbl.Location = New Point(127, 304)
        SurnameLbl.Name = "SurnameLbl"
        SurnameLbl.Size = New Size(100, 21)
        SurnameLbl.TabIndex = 186
        SurnameLbl.Text = "Last Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(222, 179)
        Label1.Name = "Label1"
        Label1.Size = New Size(254, 36)
        Label1.TabIndex = 194
        Label1.Text = "STUDENT NAME"
        ' 
        ' btnExit
        ' 
        btnExit.ForeColor = Color.Black
        btnExit.Location = New Point(371, 587)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(145, 29)
        btnExit.TabIndex = 220
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.ForeColor = Color.Black
        btnSave.Location = New Point(371, 528)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(145, 29)
        btnSave.TabIndex = 219
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(133, 556)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(161, 35)
        btnClear.TabIndex = 226
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Location = New Point(290, 255)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(226, 27)
        txtStudentID.TabIndex = 228
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Tahoma", 10.8F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(127, 256)
        Label5.Name = "Label5"
        Label5.Size = New Size(109, 22)
        Label5.TabIndex = 227
        Label5.Text = "Student ID"
        ' 
        ' STUDENT_SELECTION
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1189, 667)
        Controls.Add(txtStudentID)
        Controls.Add(Label5)
        Controls.Add(btnClear)
        Controls.Add(btnExit)
        Controls.Add(btnSave)
        Controls.Add(Label1)
        Controls.Add(txtFirstName)
        Controls.Add(txtMiddleInitial)
        Controls.Add(txtSuffix)
        Controls.Add(txtLastName)
        Controls.Add(ExtensionNameLbl)
        Controls.Add(MidNameLbl)
        Controls.Add(GivenNameLbl)
        Controls.Add(SurnameLbl)
        DoubleBuffered = True
        Name = "STUDENT_SELECTION"
        StartPosition = FormStartPosition.CenterScreen
        Text = "STUDENT SELECTION"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtMiddleInitial As TextBox
    Friend WithEvents txtSuffix As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents ExtensionNameLbl As Label
    Friend WithEvents MidNameLbl As Label
    Friend WithEvents GivenNameLbl As Label
    Friend WithEvents SurnameLbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Label5 As Label
End Class
