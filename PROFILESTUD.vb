Imports MySql.Data.MySqlClient

Public Class PROFILESTUD
    Private loggedInStudentID As String
    Private WithEvents btnSchedule As Button

    Public Sub New(studentID As String)
        InitializeComponent()
        loggedInStudentID = studentID

        ' Set DataGridView properties to make it read-only
        dgvPRO.ReadOnly = True
        dgvPRO.AllowUserToAddRows = False
        dgvPRO.AllowUserToDeleteRows = False

        ' Initialize and configure the Schedule button
        btnSchedule = New Button()
        btnSchedule.Text = "View Schedule"
        btnSchedule.Location = New Point(20, 20)  ' Adjust location as needed
        btnSchedule.Size = New Size(120, 30)      ' Adjust size as needed
        Me.Controls.Add(btnSchedule)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim changepass_window As New Change_Password
        changepass_window.MdiParent = MdiParent
        changepass_window.Show()
        Close()
    End Sub

    ' Schedule button click handler
    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click

    End Sub

    Private Sub dgvPRO_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPRO.CellContentClick
    End Sub

    Private Sub LoadSemesterData()
        Try
            Using conn As New MySqlConnection("server=localhost; user=root; database=imvbnet_proj")
                conn.Open()
                Dim query As String = "SELECT * FROM vsemester WHERE student_id = @studentID"
                Dim da As New MySqlDataAdapter(query, conn)
                da.SelectCommand.Parameters.AddWithValue("@studentID", loggedInStudentID)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvPRO.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading semester data: " & ex.Message)
        End Try
    End Sub

    Private Sub PROFILESTUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvPRO.DataSource = Nothing
        LoadSemesterData()
    End Sub

    Private Sub BackgroundPanel_Paint(sender As Object, e As PaintEventArgs) Handles BackgroundPanel.Paint
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            MDI.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnSched.Click
        Try
            Dim scheduleForm As New Schedule(loggedInStudentID)
            scheduleForm.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Error opening schedule: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
