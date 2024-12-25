Public Class StudentAccountForm
    Private loggedInStudentID As String

    Public Sub New(studentID As String)
        InitializeComponent()
        loggedInStudentID = studentID
    End Sub

    Private Sub StudentAccountForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True
    End Sub

    Private Sub ProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfileToolStripMenuItem.Click
        Dim ProfileWindow As New PROFILESTUD(loggedInStudentID)
        ProfileWindow.MdiParent = Me
        ProfileWindow.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            MDI.Show()
            Me.Close()
        End If
    End Sub

    Private Sub ChangePassowrdToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePassowrdToolStripMenuItem.Click
        Dim ChangeWindow As New Change_Password()
        ChangeWindow.MdiParent = Me
        ChangeWindow.Show()
    End Sub
End Class