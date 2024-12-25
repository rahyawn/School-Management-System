<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prof_up_de
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
        btnExit = New Button()
        btnCancel = New Button()
        btnSave = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        lblDeptCode = New Label()
        txtprofessor_id = New TextBox()
        Label5 = New Label()
        txtFirstName = New TextBox()
        txtMiddleInitial = New TextBox()
        txtSuffix = New TextBox()
        txtLastName = New TextBox()
        ExtensionNameLbl = New Label()
        MidNameLbl = New Label()
        GivenNameLbl = New Label()
        SurnameLbl = New Label()
        cmbdept_code = New ComboBox()
        SuspendLayout()
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(688, 453)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(94, 29)
        btnExit.TabIndex = 263
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(688, 386)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(94, 29)
        btnCancel.TabIndex = 262
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(688, 155)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 261
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(688, 316)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 32)
        btnDelete.TabIndex = 260
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(688, 118)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 32)
        btnUpdate.TabIndex = 259
        btnUpdate.Text = "UPDATE"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' lblDeptCode
        ' 
        lblDeptCode.AutoSize = True
        lblDeptCode.Font = New Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDeptCode.Location = New Point(149, 412)
        lblDeptCode.Name = "lblDeptCode"
        lblDeptCode.Size = New Size(160, 20)
        lblDeptCode.TabIndex = 257
        lblDeptCode.Text = "Department Code"
        ' 
        ' txtprofessor_id
        ' 
        txtprofessor_id.ForeColor = Color.Black
        txtprofessor_id.Location = New Point(315, 197)
        txtprofessor_id.Name = "txtprofessor_id"
        txtprofessor_id.Size = New Size(226, 27)
        txtprofessor_id.TabIndex = 256
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Tahoma", 10.8F, FontStyle.Bold)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(149, 198)
        Label5.Name = "Label5"
        Label5.Size = New Size(124, 22)
        Label5.TabIndex = 255
        Label5.Text = "Professor ID"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.ForeColor = Color.Black
        txtFirstName.Location = New Point(315, 283)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(226, 27)
        txtFirstName.TabIndex = 254
        ' 
        ' txtMiddleInitial
        ' 
        txtMiddleInitial.ForeColor = Color.Black
        txtMiddleInitial.Location = New Point(315, 328)
        txtMiddleInitial.Name = "txtMiddleInitial"
        txtMiddleInitial.Size = New Size(226, 27)
        txtMiddleInitial.TabIndex = 253
        ' 
        ' txtSuffix
        ' 
        txtSuffix.ForeColor = Color.Black
        txtSuffix.Location = New Point(315, 371)
        txtSuffix.Name = "txtSuffix"
        txtSuffix.Size = New Size(226, 27)
        txtSuffix.TabIndex = 252
        ' 
        ' txtLastName
        ' 
        txtLastName.ForeColor = Color.Black
        txtLastName.Location = New Point(315, 241)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(226, 27)
        txtLastName.TabIndex = 251
        ' 
        ' ExtensionNameLbl
        ' 
        ExtensionNameLbl.AutoSize = True
        ExtensionNameLbl.BackColor = Color.Transparent
        ExtensionNameLbl.Font = New Font("Tahoma", 10.2F, FontStyle.Bold)
        ExtensionNameLbl.ForeColor = Color.Black
        ExtensionNameLbl.Location = New Point(149, 371)
        ExtensionNameLbl.Name = "ExtensionNameLbl"
        ExtensionNameLbl.Size = New Size(61, 21)
        ExtensionNameLbl.TabIndex = 250
        ExtensionNameLbl.Text = "Suffix"
        ' 
        ' MidNameLbl
        ' 
        MidNameLbl.AutoSize = True
        MidNameLbl.BackColor = Color.Transparent
        MidNameLbl.Font = New Font("Tahoma", 10.2F, FontStyle.Bold)
        MidNameLbl.ForeColor = Color.Black
        MidNameLbl.Location = New Point(149, 329)
        MidNameLbl.Name = "MidNameLbl"
        MidNameLbl.Size = New Size(123, 21)
        MidNameLbl.TabIndex = 249
        MidNameLbl.Text = "Middle Initial"
        ' 
        ' GivenNameLbl
        ' 
        GivenNameLbl.AutoSize = True
        GivenNameLbl.BackColor = Color.Transparent
        GivenNameLbl.Font = New Font("Tahoma", 10.2F, FontStyle.Bold)
        GivenNameLbl.ForeColor = Color.Black
        GivenNameLbl.Location = New Point(149, 283)
        GivenNameLbl.Name = "GivenNameLbl"
        GivenNameLbl.Size = New Size(102, 21)
        GivenNameLbl.TabIndex = 248
        GivenNameLbl.Text = "First Name"
        ' 
        ' SurnameLbl
        ' 
        SurnameLbl.AutoSize = True
        SurnameLbl.BackColor = Color.Transparent
        SurnameLbl.Font = New Font("Tahoma", 10.2F, FontStyle.Bold)
        SurnameLbl.ForeColor = Color.Black
        SurnameLbl.Location = New Point(149, 246)
        SurnameLbl.Name = "SurnameLbl"
        SurnameLbl.Size = New Size(100, 21)
        SurnameLbl.TabIndex = 247
        SurnameLbl.Text = "Last Name"
        ' 
        ' cmbdept_code
        ' 
        cmbdept_code.FormattingEnabled = True
        cmbdept_code.Items.AddRange(New Object() {"CAS", "CBA", "CCS", "CIHM", "COE", "COed", "CON"})
        cmbdept_code.Location = New Point(315, 412)
        cmbdept_code.Name = "cmbdept_code"
        cmbdept_code.Size = New Size(226, 28)
        cmbdept_code.TabIndex = 264
        ' 
        ' Prof_up_de
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(1103, 673)
        Controls.Add(cmbdept_code)
        Controls.Add(btnExit)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(lblDeptCode)
        Controls.Add(txtprofessor_id)
        Controls.Add(Label5)
        Controls.Add(txtFirstName)
        Controls.Add(txtMiddleInitial)
        Controls.Add(txtSuffix)
        Controls.Add(txtLastName)
        Controls.Add(ExtensionNameLbl)
        Controls.Add(MidNameLbl)
        Controls.Add(GivenNameLbl)
        Controls.Add(SurnameLbl)
        Name = "Prof_up_de"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Prof_up_de"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblDeptCode As Label
    Friend WithEvents txtprofessor_id As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtMiddleInitial As TextBox
    Friend WithEvents txtSuffix As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents ExtensionNameLbl As Label
    Friend WithEvents MidNameLbl As Label
    Friend WithEvents GivenNameLbl As Label
    Friend WithEvents SurnameLbl As Label
    Friend WithEvents cmbdept_code As ComboBox
End Class
