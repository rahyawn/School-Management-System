<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Subject_Assign
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Subject_Assign))
        Label1 = New Label()
        Label2 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        Label11 = New Label()
        txtProfessorID = New TextBox()
        btnClear = New Button()
        btnExit = New Button()
        btnSave = New Button()
        btnAdd = New Button()
        Label23 = New Label()
        Label24 = New Label()
        txtDay = New TextBox()
        txtTime = New TextBox()
        cmbDepartmentCode = New ComboBox()
        cmbSectionCode = New ComboBox()
        cmbSubjectCode = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Tahoma", 10.2F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(141, 207)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 21)
        Label1.TabIndex = 54
        Label1.Text = "Professor ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Tahoma", 10.2F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(768, 573)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 21)
        Label2.TabIndex = 55
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Tahoma", 10.2F)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(141, 283)
        Label6.Name = "Label6"
        Label6.Size = New Size(141, 21)
        Label6.TabIndex = 59
        Label6.Text = "Department Code"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Tahoma", 10.2F)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(141, 371)
        Label8.Name = "Label8"
        Label8.Size = New Size(107, 21)
        Label8.TabIndex = 61
        Label8.Text = "Subject Code"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Tahoma", 10.2F)
        Label11.ForeColor = Color.White
        Label11.Location = New Point(141, 457)
        Label11.Name = "Label11"
        Label11.Size = New Size(106, 21)
        Label11.TabIndex = 64
        Label11.Text = "Section Code"
        ' 
        ' txtProfessorID
        ' 
        txtProfessorID.BackColor = SystemColors.ControlDark
        txtProfessorID.Location = New Point(141, 231)
        txtProfessorID.Name = "txtProfessorID"
        txtProfessorID.Size = New Size(259, 27)
        txtProfessorID.TabIndex = 65
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(511, 495)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(160, 29)
        btnClear.TabIndex = 230
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(521, 424)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(140, 29)
        btnExit.TabIndex = 229
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(521, 389)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(140, 29)
        btnSave.TabIndex = 228
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(521, 556)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(140, 29)
        btnAdd.TabIndex = 227
        btnAdd.Text = "ADD"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.BackColor = Color.Transparent
        Label23.Font = New Font("Tahoma", 10.2F)
        Label23.ForeColor = Color.White
        Label23.Location = New Point(141, 533)
        Label23.Name = "Label23"
        Label23.Size = New Size(39, 21)
        Label23.TabIndex = 233
        Label23.Text = "Day"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.BackColor = Color.Transparent
        Label24.Font = New Font("Tahoma", 10.2F)
        Label24.ForeColor = Color.White
        Label24.Location = New Point(141, 607)
        Label24.Name = "Label24"
        Label24.Size = New Size(47, 21)
        Label24.TabIndex = 234
        Label24.Text = "Time"
        ' 
        ' txtDay
        ' 
        txtDay.BackColor = Color.DarkGray
        txtDay.Font = New Font("Tahoma", 10.2F)
        txtDay.Location = New Point(141, 557)
        txtDay.Name = "txtDay"
        txtDay.Size = New Size(260, 28)
        txtDay.TabIndex = 235
        ' 
        ' txtTime
        ' 
        txtTime.BackColor = Color.DarkGray
        txtTime.Font = New Font("Tahoma", 10.2F)
        txtTime.Location = New Point(141, 631)
        txtTime.Name = "txtTime"
        txtTime.Size = New Size(260, 28)
        txtTime.TabIndex = 236
        ' 
        ' cmbDepartmentCode
        ' 
        cmbDepartmentCode.BackColor = Color.DimGray
        cmbDepartmentCode.FormattingEnabled = True
        cmbDepartmentCode.Items.AddRange(New Object() {"CAS", "CBA", "CCS", "CIHM", "COE", "COed", "CON"})
        cmbDepartmentCode.Location = New Point(141, 307)
        cmbDepartmentCode.Name = "cmbDepartmentCode"
        cmbDepartmentCode.Size = New Size(260, 28)
        cmbDepartmentCode.TabIndex = 237
        ' 
        ' cmbSectionCode
        ' 
        cmbSectionCode.BackColor = Color.DarkGray
        cmbSectionCode.FormattingEnabled = True
        cmbSectionCode.Items.AddRange(New Object() {"BSIT1A", "BSIT1B", "BSIT1C", "BSIT1D", "BSIT1E", "BSIT2A", "BSIT2B", "BSIT2C", "BSIT2D", "BSIT2E", "BSIT3A", "BSIT3B", "BSIT3C", "BSIT3D", "BSIT3E", "BSIT4A", "BSIT4B", "BSIT4C", "BSIT4D", "BSIT4E", "BSCS1A", "BSCS2A", "BSCS3A", "BSCS4A"})
        cmbSectionCode.Location = New Point(141, 481)
        cmbSectionCode.Name = "cmbSectionCode"
        cmbSectionCode.Size = New Size(260, 28)
        cmbSectionCode.TabIndex = 238
        ' 
        ' cmbSubjectCode
        ' 
        cmbSubjectCode.BackColor = Color.DarkGray
        cmbSubjectCode.FormattingEnabled = True
        cmbSubjectCode.Location = New Point(141, 395)
        cmbSubjectCode.Name = "cmbSubjectCode"
        cmbSubjectCode.Size = New Size(259, 28)
        cmbSubjectCode.TabIndex = 239
        ' 
        ' Subject_Assign
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1247, 842)
        ControlBox = False
        Controls.Add(cmbSubjectCode)
        Controls.Add(cmbSectionCode)
        Controls.Add(cmbDepartmentCode)
        Controls.Add(txtTime)
        Controls.Add(txtDay)
        Controls.Add(Label24)
        Controls.Add(Label23)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnSave)
        Controls.Add(txtProfessorID)
        Controls.Add(btnAdd)
        Controls.Add(Label11)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
        Name = "Subject_Assign"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Subject_Assign"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtProfessorID As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents txtDay As TextBox
    Friend WithEvents txtTime As TextBox
    Friend WithEvents cmbDepartmentCode As ComboBox
    Friend WithEvents cmbSectionCode As ComboBox
    Friend WithEvents cmbSubjectCode As ComboBox
End Class
