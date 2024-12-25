Imports MySql.Data.MySqlClient

Public Class Schedule
    Private loggedInStudentID As String
    Private connectionString As String = "Server=localhost;Database=imvbnet_proj;User ID=root;Pooling=true"
    Private WithEvents btnBack As Button

    Public Sub New(studentID As String)
        InitializeComponent()
        loggedInStudentID = studentID

        ' Initialize and configure the Back button
        btnBack = New Button()
        btnBack.Text = "Back to Profile"
        btnBack.Location = New Point(20, 20)  ' Adjust location as needed
        btnBack.Size = New Size(120, 30)      ' Adjust size as needed
        Me.Controls.Add(btnBack)
    End Sub

    Private Sub Schedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Configure DataGridView
            dgvSchedule.ReadOnly = True
            dgvSchedule.AllowUserToAddRows = False
            dgvSchedule.AllowUserToDeleteRows = False
            dgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            LoadStudentSchedule()
        Catch ex As Exception
            MessageBox.Show("Error initializing schedule view: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadStudentSchedule()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "
                    SELECT 
                        sa.subject_code AS 'Subject',
                        sa.section_code AS 'Section',
                        sa.dept_code AS 'Department',
                        sa.day AS 'Day',
                        sa.time AS 'Time',
                        ua.account_id AS 'Professor',
                        ua.email AS 'Professor Email'
                    FROM section_assign sec
                    INNER JOIN subject_assign sa ON sec.section_code = sa.section_code
                    INNER JOIN user_account ua ON sa.professor_id = ua.professor_id
                    WHERE sec.student_id = @studentID
                    ORDER BY 
                        CASE 
                            WHEN sa.day = 'MON' THEN 1
                            WHEN sa.day = 'TUE' THEN 2
                            WHEN sa.day = 'WED' THEN 3
                            WHEN sa.day = 'THU' THEN 4
                            WHEN sa.day = 'FRI' THEN 5
                            WHEN sa.day = 'SAT' THEN 6
                            ELSE 7
                        END,
                        sa.time"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@studentID", loggedInStudentID)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    If dt.Rows.Count = 0 Then
                        MessageBox.Show("No schedule found for this semester.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    dgvSchedule.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading schedule: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Try
            ' Return to profile form
            Dim profileForm As New PROFILESTUD(loggedInStudentID)
            profileForm.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error returning to profile: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Schedule_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Dim profileForm As New PROFILESTUD(loggedInStudentID)
            profileForm.Show()
        End If
    End Sub
End Class
