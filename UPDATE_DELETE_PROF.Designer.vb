<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UPDATE_DELETE_PROF
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
        txtSearch = New TextBox()
        Label5 = New Label()
        txtProfessorID = New TextBox()
        Label4 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        btnExit = New Button()
        dgvPROF = New DataGridView()
        btnRefresh = New Button()
        btnProceed = New Button()
        cmbdept_code = New ComboBox()
        CType(dgvPROF, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(686, 544)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(190, 27)
        txtSearch.TabIndex = 41
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(882, 544)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 20)
        Label5.TabIndex = 40
        Label5.Text = "Search"
        ' 
        ' txtProfessorID
        ' 
        txtProfessorID.Location = New Point(128, 585)
        txtProfessorID.Name = "txtProfessorID"
        txtProfessorID.Size = New Size(179, 27)
        txtProfessorID.TabIndex = 39
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(330, 588)
        Label4.Name = "Label4"
        Label4.Size = New Size(107, 20)
        Label4.TabIndex = 38
        Label4.Text = "PROFESSOR ID"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sylfaen", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(118, 537)
        Label1.Name = "Label1"
        Label1.Size = New Size(281, 19)
        Label1.TabIndex = 37
        Label1.Text = "Add SubjectID to proceed in Delete/Update"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(871, 89)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 20)
        Label3.TabIndex = 36
        Label3.Text = "Department Code"
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(405, 636)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(94, 29)
        btnExit.TabIndex = 34
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' dgvPROF
        ' 
        dgvPROF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPROF.Location = New Point(118, 133)
        dgvPROF.Name = "dgvPROF"
        dgvPROF.RowHeadersWidth = 51
        dgvPROF.Size = New Size(940, 389)
        dgvPROF.TabIndex = 33
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(68, 73)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(137, 41)
        btnRefresh.TabIndex = 32
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnProceed
        ' 
        btnProceed.Location = New Point(147, 636)
        btnProceed.Name = "btnProceed"
        btnProceed.Size = New Size(94, 29)
        btnProceed.TabIndex = 31
        btnProceed.Text = "Proceed"
        btnProceed.UseVisualStyleBackColor = True
        ' 
        ' cmbdept_code
        ' 
        cmbdept_code.FormattingEnabled = True
        cmbdept_code.Items.AddRange(New Object() {"CAS", "CBA", "CCS", "CIHM", "COE", "COed", "CON"})
        cmbdept_code.Location = New Point(639, 89)
        cmbdept_code.Name = "cmbdept_code"
        cmbdept_code.Size = New Size(226, 28)
        cmbdept_code.TabIndex = 227
        ' 
        ' UPDATE_DELETE_PROF
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1126, 739)
        ControlBox = False
        Controls.Add(cmbdept_code)
        Controls.Add(txtSearch)
        Controls.Add(Label5)
        Controls.Add(txtProfessorID)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(btnExit)
        Controls.Add(dgvPROF)
        Controls.Add(btnRefresh)
        Controls.Add(btnProceed)
        Name = "UPDATE_DELETE_PROF"
        StartPosition = FormStartPosition.CenterScreen
        Text = "UPDATE_DELETE_PROF"
        CType(dgvPROF, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtProfessorID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents dgvPROF As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnProceed As Button
    Friend WithEvents cmbdept_code As ComboBox
End Class
