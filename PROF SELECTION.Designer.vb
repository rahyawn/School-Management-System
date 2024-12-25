<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PROF_SELECTION
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PROF_SELECTION))
        Label2 = New Label()
        Label6 = New Label()
        txtRightLastName = New TextBox()
        txtRightFirstName = New TextBox()
        txtRightMiddleInitial = New TextBox()
        txtRightProffesorID = New TextBox()
        ExtensionNameLbl = New Label()
        MidNameLbl = New Label()
        GivenNameLbl = New Label()
        SurnameLbl = New Label()
        btnExit = New Button()
        btnSave = New Button()
        txtRightSuffix = New TextBox()
        btnClear = New Button()
        cmbRightDepartmentCode = New ComboBox()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Tahoma", 10.8F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(303, 311)
        Label2.Name = "Label2"
        Label2.Size = New Size(169, 22)
        Label2.TabIndex = 187
        Label2.Text = "Department Code"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Tahoma", 10.8F, FontStyle.Bold)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(26, 311)
        Label6.Name = "Label6"
        Label6.Size = New Size(63, 22)
        Label6.TabIndex = 212
        Label6.Text = "Suffix"
        ' 
        ' txtRightLastName
        ' 
        txtRightLastName.ForeColor = Color.Black
        txtRightLastName.Location = New Point(303, 177)
        txtRightLastName.Name = "txtRightLastName"
        txtRightLastName.Size = New Size(226, 27)
        txtRightLastName.TabIndex = 208
        ' 
        ' txtRightFirstName
        ' 
        txtRightFirstName.ForeColor = Color.Black
        txtRightFirstName.Location = New Point(26, 257)
        txtRightFirstName.Name = "txtRightFirstName"
        txtRightFirstName.Size = New Size(226, 27)
        txtRightFirstName.TabIndex = 207
        ' 
        ' txtRightMiddleInitial
        ' 
        txtRightMiddleInitial.ForeColor = Color.Black
        txtRightMiddleInitial.Location = New Point(303, 257)
        txtRightMiddleInitial.Name = "txtRightMiddleInitial"
        txtRightMiddleInitial.Size = New Size(226, 27)
        txtRightMiddleInitial.TabIndex = 206
        ' 
        ' txtRightProffesorID
        ' 
        txtRightProffesorID.ForeColor = Color.Black
        txtRightProffesorID.Location = New Point(26, 177)
        txtRightProffesorID.Name = "txtRightProffesorID"
        txtRightProffesorID.Size = New Size(226, 27)
        txtRightProffesorID.TabIndex = 205
        ' 
        ' ExtensionNameLbl
        ' 
        ExtensionNameLbl.AutoSize = True
        ExtensionNameLbl.BackColor = Color.Transparent
        ExtensionNameLbl.Font = New Font("Tahoma", 10.8F, FontStyle.Bold)
        ExtensionNameLbl.ForeColor = Color.White
        ExtensionNameLbl.Location = New Point(303, 232)
        ExtensionNameLbl.Name = "ExtensionNameLbl"
        ExtensionNameLbl.Size = New Size(128, 22)
        ExtensionNameLbl.TabIndex = 204
        ExtensionNameLbl.Text = "Middle Initial"
        ' 
        ' MidNameLbl
        ' 
        MidNameLbl.AutoSize = True
        MidNameLbl.BackColor = Color.Transparent
        MidNameLbl.Font = New Font("Tahoma", 10.8F, FontStyle.Bold)
        MidNameLbl.ForeColor = Color.White
        MidNameLbl.Location = New Point(26, 232)
        MidNameLbl.Name = "MidNameLbl"
        MidNameLbl.Size = New Size(107, 22)
        MidNameLbl.TabIndex = 203
        MidNameLbl.Text = "First Name"
        ' 
        ' GivenNameLbl
        ' 
        GivenNameLbl.AutoSize = True
        GivenNameLbl.BackColor = Color.Transparent
        GivenNameLbl.Font = New Font("Tahoma", 10.8F, FontStyle.Bold)
        GivenNameLbl.ForeColor = Color.White
        GivenNameLbl.Location = New Point(303, 152)
        GivenNameLbl.Name = "GivenNameLbl"
        GivenNameLbl.Size = New Size(105, 22)
        GivenNameLbl.TabIndex = 202
        GivenNameLbl.Text = "Last Name"
        ' 
        ' SurnameLbl
        ' 
        SurnameLbl.AutoSize = True
        SurnameLbl.BackColor = Color.Transparent
        SurnameLbl.Font = New Font("Tahoma", 10.8F, FontStyle.Bold)
        SurnameLbl.ForeColor = Color.White
        SurnameLbl.Location = New Point(26, 152)
        SurnameLbl.Name = "SurnameLbl"
        SurnameLbl.Size = New Size(124, 22)
        SurnameLbl.TabIndex = 201
        SurnameLbl.Text = "Professor ID"
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(414, 533)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(128, 29)
        btnExit.TabIndex = 221
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(280, 533)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(128, 29)
        btnSave.TabIndex = 220
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' txtRightSuffix
        ' 
        txtRightSuffix.Location = New Point(26, 336)
        txtRightSuffix.Name = "txtRightSuffix"
        txtRightSuffix.Size = New Size(226, 27)
        txtRightSuffix.TabIndex = 222
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(104, 533)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(128, 29)
        btnClear.TabIndex = 225
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' cmbRightDepartmentCode
        ' 
        cmbRightDepartmentCode.FormattingEnabled = True
        cmbRightDepartmentCode.Items.AddRange(New Object() {"CAS", "CBA", "CCS", "CIHM", "COE", "COed", "CON"})
        cmbRightDepartmentCode.Location = New Point(303, 334)
        cmbRightDepartmentCode.Name = "cmbRightDepartmentCode"
        cmbRightDepartmentCode.Size = New Size(226, 28)
        cmbRightDepartmentCode.TabIndex = 226
        ' 
        ' PROF_SELECTION
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1189, 591)
        Controls.Add(cmbRightDepartmentCode)
        Controls.Add(btnClear)
        Controls.Add(txtRightSuffix)
        Controls.Add(btnExit)
        Controls.Add(btnSave)
        Controls.Add(Label6)
        Controls.Add(txtRightLastName)
        Controls.Add(txtRightFirstName)
        Controls.Add(txtRightMiddleInitial)
        Controls.Add(txtRightProffesorID)
        Controls.Add(ExtensionNameLbl)
        Controls.Add(MidNameLbl)
        Controls.Add(GivenNameLbl)
        Controls.Add(SurnameLbl)
        Controls.Add(Label2)
        DoubleBuffered = True
        Name = "PROF_SELECTION"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PROF_SELECTION"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRightLastName As TextBox
    Friend WithEvents txtRightFirstName As TextBox
    Friend WithEvents txtRightMiddleInitial As TextBox
    Friend WithEvents txtRightProffesorID As TextBox
    Friend WithEvents ExtensionNameLbl As Label
    Friend WithEvents MidNameLbl As Label
    Friend WithEvents GivenNameLbl As Label
    Friend WithEvents SurnameLbl As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtRightSuffix As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents cmbRightDepartmentCode As ComboBox
End Class
