<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRUD
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
        btnProceed = New Button()
        btnRefresh = New Button()
        DataGridView1 = New DataGridView()
        btnExit = New Button()
        Label1 = New Label()
        Label4 = New Label()
        txtStudentID = New TextBox()
        Label5 = New Label()
        txtSearch = New TextBox()
        cmbSectionCode = New ComboBox()
        Label3 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnProceed
        ' 
        btnProceed.Location = New Point(109, 619)
        btnProceed.Name = "btnProceed"
        btnProceed.Size = New Size(94, 29)
        btnProceed.TabIndex = 1
        btnProceed.Text = "Proceed"
        btnProceed.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(30, 56)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(137, 41)
        btnRefresh.TabIndex = 3
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(80, 116)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(940, 389)
        DataGridView1.TabIndex = 4
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(367, 619)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(94, 29)
        btnExit.TabIndex = 8
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sylfaen", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(80, 520)
        Label1.Name = "Label1"
        Label1.Size = New Size(282, 19)
        Label1.TabIndex = 15
        Label1.Text = "Add StudentID to proceed in Delete/Update"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(292, 571)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 20)
        Label4.TabIndex = 16
        Label4.Text = "StudentID"
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Location = New Point(90, 568)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(179, 27)
        txtStudentID.TabIndex = 17
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(844, 527)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 20)
        Label5.TabIndex = 18
        Label5.Text = "Search"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(648, 527)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(190, 27)
        txtSearch.TabIndex = 19
        ' 
        ' cmbSectionCode
        ' 
        cmbSectionCode.FormattingEnabled = True
        cmbSectionCode.Location = New Point(663, 69)
        cmbSectionCode.Name = "cmbSectionCode"
        cmbSectionCode.Size = New Size(151, 28)
        cmbSectionCode.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(833, 72)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 20)
        Label3.TabIndex = 13
        Label3.Text = "Section Code"
        ' 
        ' CRUD
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1133, 673)
        Controls.Add(txtSearch)
        Controls.Add(Label5)
        Controls.Add(txtStudentID)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(cmbSectionCode)
        Controls.Add(btnExit)
        Controls.Add(DataGridView1)
        Controls.Add(btnRefresh)
        Controls.Add(btnProceed)
        Name = "CRUD"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CRUD"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnProceed As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cmbSectionCode As ComboBox
    Friend WithEvents Label3 As Label
End Class
