<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_Assign
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student_Assign))
        BTNEXIT = New Button()
        BTNSAVE = New Button()
        BTNADD = New Button()
        ComboBox1 = New ComboBox()
        Label2 = New Label()
        Label28 = New Label()
        StudentIDTxtBox1 = New TextBox()
        Label1 = New Label()
        GivenNameTxtBox = New TextBox()
        MiddleNameTxtBox = New TextBox()
        ExtensionNameTxtBox = New TextBox()
        SurnameTxtbox = New TextBox()
        ExtensionNameLbl = New Label()
        MidNameLbl = New Label()
        GivenNameLbl = New Label()
        SurnameLbl = New Label()
        SuspendLayout()
        ' 
        ' BTNEXIT
        ' 
        BTNEXIT.Location = New Point(373, 493)
        BTNEXIT.Name = "BTNEXIT"
        BTNEXIT.Size = New Size(94, 29)
        BTNEXIT.TabIndex = 217
        BTNEXIT.Text = "EXIT"
        BTNEXIT.UseVisualStyleBackColor = True
        ' 
        ' BTNSAVE
        ' 
        BTNSAVE.Location = New Point(273, 493)
        BTNSAVE.Name = "BTNSAVE"
        BTNSAVE.Size = New Size(94, 29)
        BTNSAVE.TabIndex = 216
        BTNSAVE.Text = "SAVE"
        BTNSAVE.UseVisualStyleBackColor = True
        ' 
        ' BTNADD
        ' 
        BTNADD.Location = New Point(173, 493)
        BTNADD.Name = "BTNADD"
        BTNADD.Size = New Size(94, 29)
        BTNADD.TabIndex = 215
        BTNADD.Text = "ADD"
        BTNADD.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"BSIT - 1A", "BSIT - 1B", "BSIT - 1C", "BSIT - 1D", "BSIT - 1E", "BSIT - 2A", "BSIT - 2B", "BSIT - 2C", "BSIT - 2D", "BSIT - 2E", "BSIT - 3A", "BSIT - 3B", "BSIT - 3C", "BSIT - 3D", "BSIT - 3E", "BSIT - 4A", "BSIT - 4B", "BSIT - 4C", "BSIT - 4D", "BSIT - 4E", "BSCS - 1A", "BSCS - 1B", "BSCS - 1C", "BSCS - 1D", "BSCS - 1E"})
        ComboBox1.Location = New Point(259, 368)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(226, 28)
        ComboBox1.TabIndex = 214
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(96, 372)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 18)
        Label2.TabIndex = 213
        Label2.Text = "Section"
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.BackColor = Color.Transparent
        Label28.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        Label28.ForeColor = Color.White
        Label28.Location = New Point(96, 417)
        Label28.Name = "Label28"
        Label28.Size = New Size(88, 18)
        Label28.TabIndex = 211
        Label28.Text = "Student ID"
        ' 
        ' StudentIDTxtBox1
        ' 
        StudentIDTxtBox1.BackColor = Color.White
        StudentIDTxtBox1.Enabled = False
        StudentIDTxtBox1.Font = New Font("Tahoma", 10.2F, FontStyle.Bold)
        StudentIDTxtBox1.ForeColor = Color.Black
        StudentIDTxtBox1.Location = New Point(259, 412)
        StudentIDTxtBox1.MaxLength = 8
        StudentIDTxtBox1.Multiline = True
        StudentIDTxtBox1.Name = "StudentIDTxtBox1"
        StudentIDTxtBox1.ReadOnly = True
        StudentIDTxtBox1.Size = New Size(226, 27)
        StudentIDTxtBox1.TabIndex = 212
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(184, 142)
        Label1.Name = "Label1"
        Label1.Size = New Size(254, 36)
        Label1.TabIndex = 210
        Label1.Text = "STUDENT NAME"
        ' 
        ' GivenNameTxtBox
        ' 
        GivenNameTxtBox.ForeColor = Color.Black
        GivenNameTxtBox.Location = New Point(259, 242)
        GivenNameTxtBox.Name = "GivenNameTxtBox"
        GivenNameTxtBox.Size = New Size(226, 27)
        GivenNameTxtBox.TabIndex = 209
        ' 
        ' MiddleNameTxtBox
        ' 
        MiddleNameTxtBox.ForeColor = Color.Black
        MiddleNameTxtBox.Location = New Point(259, 288)
        MiddleNameTxtBox.Name = "MiddleNameTxtBox"
        MiddleNameTxtBox.Size = New Size(226, 27)
        MiddleNameTxtBox.TabIndex = 208
        ' 
        ' ExtensionNameTxtBox
        ' 
        ExtensionNameTxtBox.ForeColor = Color.Black
        ExtensionNameTxtBox.Location = New Point(259, 326)
        ExtensionNameTxtBox.Name = "ExtensionNameTxtBox"
        ExtensionNameTxtBox.Size = New Size(226, 27)
        ExtensionNameTxtBox.TabIndex = 207
        ' 
        ' SurnameTxtbox
        ' 
        SurnameTxtbox.ForeColor = Color.Black
        SurnameTxtbox.Location = New Point(259, 201)
        SurnameTxtbox.Name = "SurnameTxtbox"
        SurnameTxtbox.Size = New Size(226, 27)
        SurnameTxtbox.TabIndex = 206
        ' 
        ' ExtensionNameLbl
        ' 
        ExtensionNameLbl.AutoSize = True
        ExtensionNameLbl.BackColor = Color.Transparent
        ExtensionNameLbl.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        ExtensionNameLbl.ForeColor = Color.White
        ExtensionNameLbl.Location = New Point(96, 331)
        ExtensionNameLbl.Name = "ExtensionNameLbl"
        ExtensionNameLbl.Size = New Size(128, 18)
        ExtensionNameLbl.TabIndex = 205
        ExtensionNameLbl.Text = "Extension Name"
        ' 
        ' MidNameLbl
        ' 
        MidNameLbl.AutoSize = True
        MidNameLbl.BackColor = Color.Transparent
        MidNameLbl.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        MidNameLbl.ForeColor = Color.White
        MidNameLbl.Location = New Point(96, 289)
        MidNameLbl.Name = "MidNameLbl"
        MidNameLbl.Size = New Size(105, 18)
        MidNameLbl.TabIndex = 204
        MidNameLbl.Text = "Middle Name"
        ' 
        ' GivenNameLbl
        ' 
        GivenNameLbl.AutoSize = True
        GivenNameLbl.BackColor = Color.Transparent
        GivenNameLbl.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        GivenNameLbl.ForeColor = Color.White
        GivenNameLbl.Location = New Point(96, 243)
        GivenNameLbl.Name = "GivenNameLbl"
        GivenNameLbl.Size = New Size(98, 18)
        GivenNameLbl.TabIndex = 203
        GivenNameLbl.Text = "Given Name"
        ' 
        ' SurnameLbl
        ' 
        SurnameLbl.AutoSize = True
        SurnameLbl.BackColor = Color.Transparent
        SurnameLbl.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        SurnameLbl.ForeColor = Color.White
        SurnameLbl.Location = New Point(96, 206)
        SurnameLbl.Name = "SurnameLbl"
        SurnameLbl.Size = New Size(74, 18)
        SurnameLbl.TabIndex = 202
        SurnameLbl.Text = "Surname"
        ' 
        ' Student_Assign
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1018, 596)
        Controls.Add(BTNEXIT)
        Controls.Add(BTNSAVE)
        Controls.Add(BTNADD)
        Controls.Add(ComboBox1)
        Controls.Add(Label2)
        Controls.Add(Label28)
        Controls.Add(StudentIDTxtBox1)
        Controls.Add(Label1)
        Controls.Add(GivenNameTxtBox)
        Controls.Add(MiddleNameTxtBox)
        Controls.Add(ExtensionNameTxtBox)
        Controls.Add(SurnameTxtbox)
        Controls.Add(ExtensionNameLbl)
        Controls.Add(MidNameLbl)
        Controls.Add(GivenNameLbl)
        Controls.Add(SurnameLbl)
        DoubleBuffered = True
        Name = "Student_Assign"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student_Assign"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BTNEXIT As Button
    Friend WithEvents BTNSAVE As Button
    Friend WithEvents BTNADD As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents StudentIDTxtBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GivenNameTxtBox As TextBox
    Friend WithEvents MiddleNameTxtBox As TextBox
    Friend WithEvents ExtensionNameTxtBox As TextBox
    Friend WithEvents SurnameTxtbox As TextBox
    Friend WithEvents ExtensionNameLbl As Label
    Friend WithEvents MidNameLbl As Label
    Friend WithEvents GivenNameLbl As Label
    Friend WithEvents SurnameLbl As Label
End Class
