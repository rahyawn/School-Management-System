Public Class MDI

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub



    Private Sub LogInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogInToolStripMenuItem.Click
        Dim LogInWindow As New LogInForm
        LogInWindow.MdiParent = Me
        LogInWindow.Show()
    End Sub





    Private Sub MenuStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip.ItemClicked


    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to EXIT the system?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub RegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
End Class
