<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Schedule
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
        dgvSchedule = New DataGridView()
        Label1 = New Label()
        CType(dgvSchedule, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvSchedule
        ' 
        dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSchedule.Location = New Point(154, 150)
        dgvSchedule.Name = "dgvSchedule"
        dgvSchedule.RowHeadersWidth = 51
        dgvSchedule.Size = New Size(756, 348)
        dgvSchedule.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 24F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(324, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(375, 48)
        Label1.TabIndex = 1
        Label1.Text = "Student Schedule"
        ' 
        ' Schedule
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 582)
        ControlBox = False
        Controls.Add(Label1)
        Controls.Add(dgvSchedule)
        Name = "Schedule"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Schedule"
        CType(dgvSchedule, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvSchedule As DataGridView
    Friend WithEvents Label1 As Label
End Class
