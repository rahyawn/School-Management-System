<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class COURSE_SELECTION
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(COURSE_SELECTION))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btnExit = New Button()
        btnSave = New Button()
        txtSubjectCode = New TextBox()
        txtSubjectName = New TextBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        cmbProgramCode = New ComboBox()
        Panel4 = New Panel()
        cmbSemester = New ComboBox()
        Panel5 = New Panel()
        Label7 = New Label()
        Label6 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(88, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Tahoma", 10.2F, FontStyle.Bold)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(24, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(129, 21)
        Label2.TabIndex = 1
        Label2.Text = "Subject Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Tahoma", 10.2F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(24, 43)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 21)
        Label3.TabIndex = 2
        Label3.Text = "Subject Code"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Tahoma", 10.2F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(24, 32)
        Label4.Name = "Label4"
        Label4.Size = New Size(131, 21)
        Label4.TabIndex = 3
        Label4.Text = "Program Code"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Tahoma", 10.2F, FontStyle.Bold)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(26, 39)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 21)
        Label5.TabIndex = 7
        Label5.Text = "Semester"
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(225, 39)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(163, 42)
        btnExit.TabIndex = 204
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Violet
        btnSave.Location = New Point(35, 39)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(163, 42)
        btnSave.TabIndex = 203
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' txtSubjectCode
        ' 
        txtSubjectCode.Location = New Point(178, 43)
        txtSubjectCode.Name = "txtSubjectCode"
        txtSubjectCode.Size = New Size(223, 27)
        txtSubjectCode.TabIndex = 206
        ' 
        ' txtSubjectName
        ' 
        txtSubjectName.Location = New Point(178, 39)
        txtSubjectName.Name = "txtSubjectName"
        txtSubjectName.Size = New Size(223, 27)
        txtSubjectName.TabIndex = 207
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkKhaki
        Panel1.Controls.Add(txtSubjectCode)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(40, 143)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(424, 99)
        Panel1.TabIndex = 210
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.NavajoWhite
        Panel2.Controls.Add(txtSubjectName)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(40, 250)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(424, 99)
        Panel2.TabIndex = 211
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DarkKhaki
        Panel3.Controls.Add(cmbProgramCode)
        Panel3.Controls.Add(Label4)
        Panel3.Location = New Point(40, 355)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(424, 99)
        Panel3.TabIndex = 211
        ' 
        ' cmbProgramCode
        ' 
        cmbProgramCode.FormattingEnabled = True
        cmbProgramCode.Items.AddRange(New Object() {"BSIT", "BSCS"})
        cmbProgramCode.Location = New Point(178, 30)
        cmbProgramCode.Name = "cmbProgramCode"
        cmbProgramCode.Size = New Size(223, 28)
        cmbProgramCode.TabIndex = 4
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.NavajoWhite
        Panel4.Controls.Add(cmbSemester)
        Panel4.Controls.Add(Label5)
        Panel4.Location = New Point(40, 460)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(424, 99)
        Panel4.TabIndex = 211
        ' 
        ' cmbSemester
        ' 
        cmbSemester.FormattingEnabled = True
        cmbSemester.Items.AddRange(New Object() {"1st", "2nd"})
        cmbSemester.Location = New Point(178, 37)
        cmbSemester.Name = "cmbSemester"
        cmbSemester.Size = New Size(223, 28)
        cmbSemester.TabIndex = 8
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.DarkKhaki
        Panel5.Controls.Add(Label7)
        Panel5.Controls.Add(Label6)
        Panel5.Controls.Add(btnSave)
        Panel5.Controls.Add(btnExit)
        Panel5.Location = New Point(550, 460)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(424, 99)
        Panel5.TabIndex = 212
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(266, 14)
        Label7.Name = "Label7"
        Label7.Size = New Size(83, 22)
        Label7.TabIndex = 214
        Label7.Text = "Click For:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(70, 14)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 22)
        Label6.TabIndex = 213
        Label6.Text = "Click For:"
        ' 
        ' COURSE_SELECTION
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1189, 594)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        DoubleBuffered = True
        Name = "COURSE_SELECTION"
        StartPosition = FormStartPosition.CenterScreen
        Text = "COURSE_SELECTION"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtSubjectCode As TextBox
    Friend WithEvents txtSubjectName As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbProgramCode As ComboBox
    Friend WithEvents cmbSemester As ComboBox
End Class
