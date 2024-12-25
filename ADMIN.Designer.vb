<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ADMIN))
        MenuStrip1 = New MenuStrip()
        AdminStudToolStripMenuItem = New ToolStripMenuItem()
        ProfessorMenuItem = New ToolStripMenuItem()
        StudentSelectionToolStripMenuItem = New ToolStripMenuItem()
        SectionAssignToolStripMenuItem = New ToolStripMenuItem()
        UpdateToolStripMenuItem = New ToolStripMenuItem()
        AdminProfToolStripMenuItem = New ToolStripMenuItem()
        ProfSelectionToolStripMenuItem = New ToolStripMenuItem()
        UpdateDeleteProfToolStripMenuItem = New ToolStripMenuItem()
        CourseToolStripMenuItem = New ToolStripMenuItem()
        CourseSelectionToolStripMenuItem = New ToolStripMenuItem()
        SubjectAssignToolStripMenuItem = New ToolStripMenuItem()
        UpdateDeleteCourseToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {AdminStudToolStripMenuItem, AdminProfToolStripMenuItem, CourseToolStripMenuItem, ExitToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1582, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' AdminStudToolStripMenuItem
        ' 
        AdminStudToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ProfessorMenuItem, StudentSelectionToolStripMenuItem, SectionAssignToolStripMenuItem, UpdateToolStripMenuItem})
        AdminStudToolStripMenuItem.Name = "AdminStudToolStripMenuItem"
        AdminStudToolStripMenuItem.Size = New Size(77, 24)
        AdminStudToolStripMenuItem.Text = "Account"
        ' 
        ' ProfessorMenuItem
        ' 
        ProfessorMenuItem.Name = "ProfessorMenuItem"
        ProfessorMenuItem.Size = New Size(224, 26)
        ProfessorMenuItem.Text = "User Account"
        ' 
        ' StudentSelectionToolStripMenuItem
        ' 
        StudentSelectionToolStripMenuItem.Name = "StudentSelectionToolStripMenuItem"
        StudentSelectionToolStripMenuItem.Size = New Size(224, 26)
        StudentSelectionToolStripMenuItem.Text = "Student Selection"
        ' 
        ' SectionAssignToolStripMenuItem
        ' 
        SectionAssignToolStripMenuItem.Name = "SectionAssignToolStripMenuItem"
        SectionAssignToolStripMenuItem.Size = New Size(224, 26)
        SectionAssignToolStripMenuItem.Text = " Section Assign"
        ' 
        ' UpdateToolStripMenuItem
        ' 
        UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        UpdateToolStripMenuItem.Size = New Size(224, 26)
        UpdateToolStripMenuItem.Text = "Update-Delete"
        ' 
        ' AdminProfToolStripMenuItem
        ' 
        AdminProfToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ProfSelectionToolStripMenuItem, UpdateDeleteProfToolStripMenuItem})
        AdminProfToolStripMenuItem.Name = "AdminProfToolStripMenuItem"
        AdminProfToolStripMenuItem.Size = New Size(84, 24)
        AdminProfToolStripMenuItem.Text = "Professor"
        ' 
        ' ProfSelectionToolStripMenuItem
        ' 
        ProfSelectionToolStripMenuItem.Name = "ProfSelectionToolStripMenuItem"
        ProfSelectionToolStripMenuItem.Size = New Size(224, 26)
        ProfSelectionToolStripMenuItem.Text = "Prof Selection"
        ' 
        ' UpdateDeleteProfToolStripMenuItem
        ' 
        UpdateDeleteProfToolStripMenuItem.Name = "UpdateDeleteProfToolStripMenuItem"
        UpdateDeleteProfToolStripMenuItem.Size = New Size(224, 26)
        UpdateDeleteProfToolStripMenuItem.Text = "Update_Delete_Prof"
        ' 
        ' CourseToolStripMenuItem
        ' 
        CourseToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CourseSelectionToolStripMenuItem, SubjectAssignToolStripMenuItem, UpdateDeleteCourseToolStripMenuItem})
        CourseToolStripMenuItem.Name = "CourseToolStripMenuItem"
        CourseToolStripMenuItem.Size = New Size(68, 24)
        CourseToolStripMenuItem.Text = "Course"
        ' 
        ' CourseSelectionToolStripMenuItem
        ' 
        CourseSelectionToolStripMenuItem.Name = "CourseSelectionToolStripMenuItem"
        CourseSelectionToolStripMenuItem.Size = New Size(242, 26)
        CourseSelectionToolStripMenuItem.Text = "Course Selection"
        ' 
        ' SubjectAssignToolStripMenuItem
        ' 
        SubjectAssignToolStripMenuItem.Name = "SubjectAssignToolStripMenuItem"
        SubjectAssignToolStripMenuItem.Size = New Size(242, 26)
        SubjectAssignToolStripMenuItem.Text = "SubjectAssign"
        ' 
        ' UpdateDeleteCourseToolStripMenuItem
        ' 
        UpdateDeleteCourseToolStripMenuItem.Name = "UpdateDeleteCourseToolStripMenuItem"
        UpdateDeleteCourseToolStripMenuItem.Size = New Size(242, 26)
        UpdateDeleteCourseToolStripMenuItem.Text = "Update_Delete_Course"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LogoutToolStripMenuItem})
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(70, 24)
        ExitToolStripMenuItem.Text = "Logout"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(116, 26)
        LogoutToolStripMenuItem.Text = "Exit"
        ' 
        ' ADMIN
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1582, 853)
        Controls.Add(MenuStrip1)
        DoubleBuffered = True
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "ADMIN"
        Text = "ADMIN"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdminStudToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminProfToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CourseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentSelectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfSelectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CourseSelectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SectionAssignToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubjectAssignToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateDeleteCourseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateDeleteProfToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfessorMenuItem As ToolStripMenuItem
End Class
