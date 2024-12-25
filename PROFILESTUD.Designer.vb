<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PROFILESTUD
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
        BackgroundPanel = New Panel()
        btnSched = New Button()
        btnExit = New Button()
        dgvPRO = New DataGridView()
        DesignPanel = New Panel()
        ProfAccInfoMessageLbl = New Label()
        BackgroundPanel.SuspendLayout()
        CType(dgvPRO, ComponentModel.ISupportInitialize).BeginInit()
        DesignPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' BackgroundPanel
        ' 
        BackgroundPanel.BackColor = Color.LightSteelBlue
        BackgroundPanel.Controls.Add(btnSched)
        BackgroundPanel.Controls.Add(btnExit)
        BackgroundPanel.Controls.Add(dgvPRO)
        BackgroundPanel.Font = New Font("Tahoma", 7.8F, FontStyle.Bold)
        BackgroundPanel.ForeColor = Color.MidnightBlue
        BackgroundPanel.Location = New Point(0, 140)
        BackgroundPanel.Name = "BackgroundPanel"
        BackgroundPanel.Size = New Size(1229, 348)
        BackgroundPanel.TabIndex = 3
        ' 
        ' btnSched
        ' 
        btnSched.Location = New Point(42, 87)
        btnSched.Name = "btnSched"
        btnSched.Size = New Size(136, 40)
        btnSched.TabIndex = 177
        btnSched.Text = "Schedule"
        btnSched.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(42, 142)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(136, 40)
        btnExit.TabIndex = 176
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' dgvPRO
        ' 
        dgvPRO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPRO.Location = New Point(203, 69)
        dgvPRO.Name = "dgvPRO"
        dgvPRO.RowHeadersWidth = 51
        dgvPRO.Size = New Size(906, 205)
        dgvPRO.TabIndex = 11
        ' 
        ' DesignPanel
        ' 
        DesignPanel.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        DesignPanel.Controls.Add(ProfAccInfoMessageLbl)
        DesignPanel.Font = New Font("Tahoma", 7.8F, FontStyle.Bold)
        DesignPanel.Location = New Point(0, 3)
        DesignPanel.Name = "DesignPanel"
        DesignPanel.Size = New Size(1229, 131)
        DesignPanel.TabIndex = 2
        ' 
        ' ProfAccInfoMessageLbl
        ' 
        ProfAccInfoMessageLbl.AutoSize = True
        ProfAccInfoMessageLbl.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        ProfAccInfoMessageLbl.Font = New Font("Tahoma", 9.0F, FontStyle.Bold)
        ProfAccInfoMessageLbl.ForeColor = Color.Gold
        ProfAccInfoMessageLbl.Location = New Point(15, 18)
        ProfAccInfoMessageLbl.Name = "ProfAccInfoMessageLbl"
        ProfAccInfoMessageLbl.Size = New Size(275, 18)
        ProfAccInfoMessageLbl.TabIndex = 1
        ProfAccInfoMessageLbl.Text = "STUDENT ACCOUNT INFORMATION"
        ' 
        ' PROFILESTUD
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1194, 598)
        Controls.Add(BackgroundPanel)
        Controls.Add(DesignPanel)
        Name = "PROFILESTUD"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PROFILESTUD"
        BackgroundPanel.ResumeLayout(False)
        CType(dgvPRO, ComponentModel.ISupportInitialize).EndInit()
        DesignPanel.ResumeLayout(False)
        DesignPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents BackgroundPanel As Panel
    Friend WithEvents dgvPRO As DataGridView
    Friend WithEvents DesignPanel As Panel
    Friend WithEvents ProfAccInfoMessageLbl As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSched As Button
End Class
