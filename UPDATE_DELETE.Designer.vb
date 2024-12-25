<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UPDATE_DELETE
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
        txtStudentID = New TextBox()
        Label5 = New Label()
        txtFirstName = New TextBox()
        txtMiddleInitial = New TextBox()
        txtSuffix = New TextBox()
        txtLastName = New TextBox()
        ExtensionNameLbl = New Label()
        MidNameLbl = New Label()
        GivenNameLbl = New Label()
        SurnameLbl = New Label()
        cmbSectionCodee = New ComboBox()
        lblSectionCode = New Label()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnSave = New Button()
        btnCancel = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' txtStudentID
        ' 
        txtStudentID.ForeColor = Color.Black
        txtStudentID.Location = New Point(247, 199)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(226, 27)
        txtStudentID.TabIndex = 239
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Tahoma", 10.8F, FontStyle.Bold)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(84, 200)
        Label5.Name = "Label5"
        Label5.Size = New Size(109, 22)
        Label5.TabIndex = 238
        Label5.Text = "Student ID"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.ForeColor = Color.Black
        txtFirstName.Location = New Point(247, 285)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(226, 27)
        txtFirstName.TabIndex = 236
        ' 
        ' txtMiddleInitial
        ' 
        txtMiddleInitial.ForeColor = Color.Black
        txtMiddleInitial.Location = New Point(247, 330)
        txtMiddleInitial.Name = "txtMiddleInitial"
        txtMiddleInitial.Size = New Size(226, 27)
        txtMiddleInitial.TabIndex = 235
        ' 
        ' txtSuffix
        ' 
        txtSuffix.ForeColor = Color.Black
        txtSuffix.Location = New Point(247, 373)
        txtSuffix.Name = "txtSuffix"
        txtSuffix.Size = New Size(226, 27)
        txtSuffix.TabIndex = 234
        ' 
        ' txtLastName
        ' 
        txtLastName.ForeColor = Color.Black
        txtLastName.Location = New Point(247, 243)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(226, 27)
        txtLastName.TabIndex = 233
        ' 
        ' ExtensionNameLbl
        ' 
        ExtensionNameLbl.AutoSize = True
        ExtensionNameLbl.BackColor = Color.Transparent
        ExtensionNameLbl.Font = New Font("Tahoma", 10.2F, FontStyle.Bold)
        ExtensionNameLbl.ForeColor = Color.Black
        ExtensionNameLbl.Location = New Point(84, 373)
        ExtensionNameLbl.Name = "ExtensionNameLbl"
        ExtensionNameLbl.Size = New Size(61, 21)
        ExtensionNameLbl.TabIndex = 232
        ExtensionNameLbl.Text = "Suffix"
        ' 
        ' MidNameLbl
        ' 
        MidNameLbl.AutoSize = True
        MidNameLbl.BackColor = Color.Transparent
        MidNameLbl.Font = New Font("Tahoma", 10.2F, FontStyle.Bold)
        MidNameLbl.ForeColor = Color.Black
        MidNameLbl.Location = New Point(84, 331)
        MidNameLbl.Name = "MidNameLbl"
        MidNameLbl.Size = New Size(123, 21)
        MidNameLbl.TabIndex = 231
        MidNameLbl.Text = "Middle Initial"
        ' 
        ' GivenNameLbl
        ' 
        GivenNameLbl.AutoSize = True
        GivenNameLbl.BackColor = Color.Transparent
        GivenNameLbl.Font = New Font("Tahoma", 10.2F, FontStyle.Bold)
        GivenNameLbl.ForeColor = Color.Black
        GivenNameLbl.Location = New Point(84, 285)
        GivenNameLbl.Name = "GivenNameLbl"
        GivenNameLbl.Size = New Size(102, 21)
        GivenNameLbl.TabIndex = 230
        GivenNameLbl.Text = "First Name"
        ' 
        ' SurnameLbl
        ' 
        SurnameLbl.AutoSize = True
        SurnameLbl.BackColor = Color.Transparent
        SurnameLbl.Font = New Font("Tahoma", 10.2F, FontStyle.Bold)
        SurnameLbl.ForeColor = Color.Black
        SurnameLbl.Location = New Point(84, 248)
        SurnameLbl.Name = "SurnameLbl"
        SurnameLbl.Size = New Size(100, 21)
        SurnameLbl.TabIndex = 229
        SurnameLbl.Text = "Last Name"
        ' 
        ' cmbSectionCodee
        ' 
        cmbSectionCodee.FormattingEnabled = True
        cmbSectionCodee.ImeMode = ImeMode.Disable
        cmbSectionCodee.Items.AddRange(New Object() {"BSCS1A", "BSCS2A", "BSCS3A", "BSCS4A", "BSIT1A", "BSIT1B", "BSIT1C", "BSIT1D", "BSIT1E", "BSIT2A", "BSIT2B", "BSIT2C", "BSIT2D", "BSIT2E", "BSIT3A", "BSIT3B", "BSIT3C", "BSIT3D", "BSIT3E", "BSIT4A", "BSIT4B", "BSIT4C", "BSIT4D", "BSIT4E"})
        cmbSectionCodee.Location = New Point(247, 419)
        cmbSectionCodee.Name = "cmbSectionCodee"
        cmbSectionCodee.Size = New Size(226, 28)
        cmbSectionCodee.Sorted = True
        cmbSectionCodee.TabIndex = 241
        ' 
        ' lblSectionCode
        ' 
        lblSectionCode.AutoSize = True
        lblSectionCode.Font = New Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSectionCode.Location = New Point(86, 422)
        lblSectionCode.Name = "lblSectionCode"
        lblSectionCode.Size = New Size(119, 20)
        lblSectionCode.TabIndex = 240
        lblSectionCode.Text = "Section Code"
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(541, 135)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 32)
        btnUpdate.TabIndex = 242
        btnUpdate.Text = "UPDATE"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(541, 399)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 32)
        btnDelete.TabIndex = 243
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(541, 172)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 244
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(541, 336)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(94, 29)
        btnCancel.TabIndex = 245
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(541, 504)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(94, 29)
        btnExit.TabIndex = 246
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' UPDATE_DELETE
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        ClientSize = New Size(1122, 674)
        Controls.Add(btnExit)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(cmbSectionCodee)
        Controls.Add(lblSectionCode)
        Controls.Add(txtStudentID)
        Controls.Add(Label5)
        Controls.Add(txtFirstName)
        Controls.Add(txtMiddleInitial)
        Controls.Add(txtSuffix)
        Controls.Add(txtLastName)
        Controls.Add(ExtensionNameLbl)
        Controls.Add(MidNameLbl)
        Controls.Add(GivenNameLbl)
        Controls.Add(SurnameLbl)
        Name = "UPDATE_DELETE"
        StartPosition = FormStartPosition.CenterScreen
        Text = "UPDATE_DELETE"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtMiddleInitial As TextBox
    Friend WithEvents txtSuffix As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents ExtensionNameLbl As Label
    Friend WithEvents MidNameLbl As Label
    Friend WithEvents GivenNameLbl As Label
    Friend WithEvents SurnameLbl As Label
    Friend WithEvents cmbSectionCodee As ComboBox
    Friend WithEvents lblSectionCode As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnExit As Button
End Class
