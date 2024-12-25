<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentAccountForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentAccountForm))
        StudAccMenuStrip = New MenuStrip()
        AccountToolStripMenuItem = New ToolStripMenuItem()
        ProfileToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        LogOutToolStripMenuItem = New ToolStripMenuItem()
        ChangePassowrdToolStripMenuItem = New ToolStripMenuItem()
        StudAccMenuStrip.SuspendLayout()
        SuspendLayout()
        ' 
        ' StudAccMenuStrip
        ' 
        StudAccMenuStrip.ImageScalingSize = New Size(20, 20)
        StudAccMenuStrip.Items.AddRange(New ToolStripItem() {AccountToolStripMenuItem, ExitToolStripMenuItem})
        StudAccMenuStrip.Location = New Point(0, 0)
        StudAccMenuStrip.Name = "StudAccMenuStrip"
        StudAccMenuStrip.Size = New Size(1114, 28)
        StudAccMenuStrip.TabIndex = 0
        StudAccMenuStrip.Text = "StudAccMenuStrip"
        ' 
        ' AccountToolStripMenuItem
        ' 
        AccountToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ProfileToolStripMenuItem, ChangePassowrdToolStripMenuItem})
        AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        AccountToolStripMenuItem.Size = New Size(77, 24)
        AccountToolStripMenuItem.Text = "Account"
        ' 
        ' ProfileToolStripMenuItem
        ' 
        ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        ProfileToolStripMenuItem.Size = New Size(224, 26)
        ProfileToolStripMenuItem.Text = "Profile"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LogOutToolStripMenuItem})
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(47, 24)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' LogOutToolStripMenuItem
        ' 
        LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        LogOutToolStripMenuItem.Size = New Size(145, 26)
        LogOutToolStripMenuItem.Text = "Log Out"
        ' 
        ' ChangePassowrdToolStripMenuItem
        ' 
        ChangePassowrdToolStripMenuItem.Name = "ChangePassowrdToolStripMenuItem"
        ChangePassowrdToolStripMenuItem.Size = New Size(224, 26)
        ChangePassowrdToolStripMenuItem.Text = "Change Password"
        ' 
        ' StudentAccountForm
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1114, 789)
        Controls.Add(StudAccMenuStrip)
        DoubleBuffered = True
        MainMenuStrip = StudAccMenuStrip
        Name = "StudentAccountForm"
        Text = "StudentAccountForm"
        WindowState = FormWindowState.Maximized
        StudAccMenuStrip.ResumeLayout(False)
        StudAccMenuStrip.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents StudAccMenuStrip As MenuStrip
    Friend WithEvents AccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePassowrdToolStripMenuItem As ToolStripMenuItem
End Class
