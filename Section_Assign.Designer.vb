<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Section_Assign
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Section_Assign))
        btnExit1 = New Button()
        btnClear1 = New Button()
        btnSave1 = New Button()
        txtRightStudentID = New TextBox()
        lblStudent_ID = New Label()
        lblSectionCode = New Label()
        Panel1 = New Panel()
        txtSectionCode = New ComboBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnExit1
        ' 
        btnExit1.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        btnExit1.Location = New Point(181, 374)
        btnExit1.Name = "btnExit1"
        btnExit1.Size = New Size(199, 43)
        btnExit1.TabIndex = 13
        btnExit1.Text = "Exit"
        btnExit1.UseVisualStyleBackColor = True
        ' 
        ' btnClear1
        ' 
        btnClear1.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        btnClear1.Location = New Point(181, 325)
        btnClear1.Name = "btnClear1"
        btnClear1.Size = New Size(199, 43)
        btnClear1.TabIndex = 12
        btnClear1.Text = "Clear"
        btnClear1.UseVisualStyleBackColor = True
        ' 
        ' btnSave1
        ' 
        btnSave1.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        btnSave1.Location = New Point(181, 276)
        btnSave1.Name = "btnSave1"
        btnSave1.Size = New Size(199, 43)
        btnSave1.TabIndex = 11
        btnSave1.Text = "Save"
        btnSave1.UseVisualStyleBackColor = True
        ' 
        ' txtRightStudentID
        ' 
        txtRightStudentID.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        txtRightStudentID.Location = New Point(134, 216)
        txtRightStudentID.Name = "txtRightStudentID"
        txtRightStudentID.Size = New Size(286, 26)
        txtRightStudentID.TabIndex = 10
        ' 
        ' lblStudent_ID
        ' 
        lblStudent_ID.AutoSize = True
        lblStudent_ID.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        lblStudent_ID.Location = New Point(134, 195)
        lblStudent_ID.Name = "lblStudent_ID"
        lblStudent_ID.Size = New Size(84, 18)
        lblStudent_ID.TabIndex = 8
        lblStudent_ID.Text = "StudentID"
        ' 
        ' lblSectionCode
        ' 
        lblSectionCode.AutoSize = True
        lblSectionCode.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        lblSectionCode.Location = New Point(134, 119)
        lblSectionCode.Name = "lblSectionCode"
        lblSectionCode.Size = New Size(105, 18)
        lblSectionCode.TabIndex = 7
        lblSectionCode.Text = "Section Code"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Gainsboro
        Panel1.Controls.Add(txtSectionCode)
        Panel1.Controls.Add(btnExit1)
        Panel1.Controls.Add(lblSectionCode)
        Panel1.Controls.Add(btnClear1)
        Panel1.Controls.Add(lblStudent_ID)
        Panel1.Controls.Add(btnSave1)
        Panel1.Controls.Add(txtRightStudentID)
        Panel1.Location = New Point(292, 97)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(565, 492)
        Panel1.TabIndex = 14
        ' 
        ' txtSectionCode
        ' 
        txtSectionCode.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        txtSectionCode.FormattingEnabled = True
        txtSectionCode.ImeMode = ImeMode.Disable
        txtSectionCode.Items.AddRange(New Object() {"BSCS1A", "BSCS2A", "BSCS3A", "BSCS4A", "BSIT1A", "BSIT1B", "BSIT1C", "BSIT1D", "BSIT1E", "BSIT2A", "BSIT2B", "BSIT2C", "BSIT2D", "BSIT2E", "BSIT3A", "BSIT3B", "BSIT3C", "BSIT3D", "BSIT3E", "BSIT4A", "BSIT4B", "BSIT4C", "BSIT4D", "BSIT4E"})
        txtSectionCode.Location = New Point(134, 140)
        txtSectionCode.Name = "txtSectionCode"
        txtSectionCode.Size = New Size(286, 26)
        txtSectionCode.Sorted = True
        txtSectionCode.TabIndex = 14
        ' 
        ' Section_Assign
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1136, 666)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Name = "Section_Assign"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Section_Assign"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnExit1 As Button
    Friend WithEvents btnClear1 As Button
    Friend WithEvents btnSave1 As Button
    Friend WithEvents txtRightStudentID As TextBox
    Friend WithEvents lblStudent_ID As Label
    Friend WithEvents lblSectionCode As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSectionCode As ComboBox
End Class
