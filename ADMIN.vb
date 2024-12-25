Public Class ADMIN
    ' Declare references for child forms

    Private AdminProfWindow As Subject_Assign
    Private StudentSelectionWindow As STUDENT_SELECTION

    ' Open Admin Student Window


    ' Open Admin Professor Window
    Private Sub AdminProfToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminProfToolStripMenuItem.Click

    End Sub

    ' Open Student Selection Window
    Private Sub StudentSelectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentSelectionToolStripMenuItem.Click
        If StudentSelectionWindow Is Nothing OrElse StudentSelectionWindow.IsDisposed Then
            StudentSelectionWindow = New STUDENT_SELECTION()
            StudentSelectionWindow.MdiParent = Me
            StudentSelectionWindow.Show()
        Else
            StudentSelectionWindow.BringToFront()
        End If

    End Sub

    ' Logout Functionality
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            MDI.Show()
            Me.Close()
        End If
    End Sub

    ' Exit Application
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

    End Sub

    Private Sub ProfSelectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfSelectionToolStripMenuItem.Click
        Dim ProfSelectionWindow As New PROF_SELECTION()
        ProfSelectionWindow.MdiParent = Me
        ProfSelectionWindow.Show()
    End Sub


    Private Sub JToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SelectCourseToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CourseSelectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CourseSelectionToolStripMenuItem.Click
        Dim CourseSelectionWindow As New COURSE_SELECTION()
        CourseSelectionWindow.MdiParent = Me
        CourseSelectionWindow.Show()
    End Sub

    Private Sub ADMIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub SubjectAssignToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubjectAssignToolStripMenuItem.Click
        Dim Subject_AssignWindow As New Subject_Assign()
        Subject_AssignWindow.MdiParent = Me
        Subject_AssignWindow.Show()
    End Sub

    Private Sub SectionAssignToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SectionAssignToolStripMenuItem.Click
        Dim Section_AssignWindow As New Section_Assign()
        Section_AssignWindow.MdiParent = Me
        Section_AssignWindow.Show()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        Dim Crud_AssignWindow As New CRUD()
        Crud_AssignWindow.MdiParent = Me
        Crud_AssignWindow.Show()
    End Sub

    Private Sub UpdateDeleteCourseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateDeleteCourseToolStripMenuItem.Click
        Dim UPDATEAssignWindow As New UPDATE_DELETE_COURSE()
        UPDATEAssignWindow.MdiParent = Me
        UPDATEAssignWindow.Show()
    End Sub

    Private Sub UpdateDeleteProfToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateDeleteProfToolStripMenuItem.Click
        Dim profAssignWindow As New UPDATE_DELETE_PROF()
        profAssignWindow.MdiParent = Me
        profAssignWindow.Show()
    End Sub

    Private Sub ProfessorMenuItem_Click(sender As Object, e As EventArgs) Handles ProfessorMenuItem.Click
        Dim profAccountAssignWindow As New User_Account()
        profAccountAssignWindow.MdiParent = Me
        profAccountAssignWindow.Show()
    End Sub
End Class
