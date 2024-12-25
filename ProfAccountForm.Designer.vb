<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfAccountForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProfAccountForm))
        ProfAccMenuStrip = New MenuStrip()
        AccountToolStripMenuItem = New ToolStripMenuItem()
        ProfileToolStripMenuItem = New ToolStripMenuItem()
        FinalGradeToolStripMenuItem = New ToolStripMenuItem()
        GradesToolStripMenuItem = New ToolStripMenuItem()
        MidtermToolStripMenuItem = New ToolStripMenuItem()
        FinalsToolStripMenuItem = New ToolStripMenuItem()
        SemesterToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        LogOutToolStripMenuItem = New ToolStripMenuItem()
        ProfAccMenuStrip.SuspendLayout()
        SuspendLayout()
        ' 
        ' ProfAccMenuStrip
        ' 
        ProfAccMenuStrip.ImageScalingSize = New Size(20, 20)
        ProfAccMenuStrip.Items.AddRange(New ToolStripItem() {AccountToolStripMenuItem, GradesToolStripMenuItem, ExitToolStripMenuItem})
        ProfAccMenuStrip.Location = New Point(0, 0)
        ProfAccMenuStrip.Name = "ProfAccMenuStrip"
        ProfAccMenuStrip.Size = New Size(1162, 28)
        ProfAccMenuStrip.TabIndex = 0
        ProfAccMenuStrip.Text = "ProfAccMenuStrip"
        ' 
        ' AccountToolStripMenuItem
        ' 
        AccountToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ProfileToolStripMenuItem, FinalGradeToolStripMenuItem})
        AccountToolStripMenuItem.Image = CType(resources.GetObject("AccountToolStripMenuItem.Image"), Image)
        AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        AccountToolStripMenuItem.Size = New Size(97, 24)
        AccountToolStripMenuItem.Text = "Account"
        ' 
        ' ProfileToolStripMenuItem
        ' 
        ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        ProfileToolStripMenuItem.Size = New Size(224, 26)
        ProfileToolStripMenuItem.Text = "Midterm Grade"
        ' 
        ' FinalGradeToolStripMenuItem
        ' 
        FinalGradeToolStripMenuItem.Name = "FinalGradeToolStripMenuItem"
        FinalGradeToolStripMenuItem.Size = New Size(224, 26)
        FinalGradeToolStripMenuItem.Text = "Final Grade"
        ' 
        ' GradesToolStripMenuItem
        ' 
        GradesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {MidtermToolStripMenuItem, FinalsToolStripMenuItem, SemesterToolStripMenuItem})
        GradesToolStripMenuItem.Image = CType(resources.GetObject("GradesToolStripMenuItem.Image"), Image)
        GradesToolStripMenuItem.Name = "GradesToolStripMenuItem"
        GradesToolStripMenuItem.Size = New Size(89, 24)
        GradesToolStripMenuItem.Text = "Grades"
        ' 
        ' MidtermToolStripMenuItem
        ' 
        MidtermToolStripMenuItem.Name = "MidtermToolStripMenuItem"
        MidtermToolStripMenuItem.Size = New Size(153, 26)
        MidtermToolStripMenuItem.Text = "Midterm"
        ' 
        ' FinalsToolStripMenuItem
        ' 
        FinalsToolStripMenuItem.Name = "FinalsToolStripMenuItem"
        FinalsToolStripMenuItem.Size = New Size(153, 26)
        FinalsToolStripMenuItem.Text = "Finals"
        ' 
        ' SemesterToolStripMenuItem
        ' 
        SemesterToolStripMenuItem.Name = "SemesterToolStripMenuItem"
        SemesterToolStripMenuItem.Size = New Size(153, 26)
        SemesterToolStripMenuItem.Text = "Semester"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LogOutToolStripMenuItem})
        ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), Image)
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(67, 24)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' LogOutToolStripMenuItem
        ' 
        LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        LogOutToolStripMenuItem.Size = New Size(145, 26)
        LogOutToolStripMenuItem.Text = "Log Out"
        ' 
        ' ProfAccountForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1162, 892)
        Controls.Add(ProfAccMenuStrip)
        MainMenuStrip = ProfAccMenuStrip
        Name = "ProfAccountForm"
        Text = "Professor Account Form"
        WindowState = FormWindowState.Maximized
        ProfAccMenuStrip.ResumeLayout(False)
        ProfAccMenuStrip.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProfAccMenuStrip As MenuStrip
    Friend WithEvents AccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GradesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MidtermToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FinalsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SemesterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FinalGradeToolStripMenuItem As ToolStripMenuItem
End Class
