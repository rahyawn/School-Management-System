Public Class ProfAccountForm
    Inherits Form ' Make sure ProfAccountForm inherits from Form

    Private Sub AccountForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True ' Set ProfAccountForm as an MDI container
    End Sub

    ' Modify the existing menu item click events
    Private Sub ProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfileToolStripMenuItem.Click
        Dim ProfileWindow As New ProfProfileForm()
        ProfileWindow.MdiParent = Me
        ProfileWindow.Show()
    End Sub

    Private Sub MidtermToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MidtermToolStripMenuItem.Click
        Dim MidtermWindow As New MidtermForm()
        MidtermWindow.MdiParent = Me
        MidtermWindow.Show()
    End Sub

    Private Sub FinalsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinalsToolStripMenuItem.Click
        MessageBox.Show("Finals menu item clicked!")
        Dim FinalsWindow As New FinalsForm()
        FinalsWindow.MdiParent = Me
        FinalsWindow.Show()
    End Sub

    Private Sub SemesterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SemesterToolStripMenuItem.Click
        Dim SemestralWindow As New SemestralForm()
        SemestralWindow.MdiParent = Me
        SemestralWindow.Show()
    End Sub

    ' Add a logout functionality
    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            MDI.Show()
            Me.Close()
        End If
    End Sub

    Private Sub AccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountToolStripMenuItem.Click
        ' Placeholder for Account menu item click event
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

    End Sub

    Private Sub FinalGradeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinalGradeToolStripMenuItem.Click
        Dim finalWindow As New FINAL_GRADE()
        finalWindow.MdiParent = Me
        finalWindow.Show()
    End Sub
End Class
