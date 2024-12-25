Imports MySql.Data.MySqlClient

Public Class UPDATE_DELETE_COURSE
    Private connectionString As String = "server=localhost;user=root;password=;database=imvbnet_proj;port=3306;"
    Private connection As MySqlConnection
    Private dataAdapter As MySqlDataAdapter
    Private dataTable As New DataTable()

    Private Sub UPDATE_DELETE_COURSE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSubjectCodes()
        LoadAllSubjects()
        ' Add event handler for DataGridView row click
        AddHandler dgvCourse.CellClick, AddressOf DataGridView1_CellClick
    End Sub

    ' Method to handle DataGridView cell click
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgvCourse.Rows(e.RowIndex)

            ' Check if cells exist and have values before accessing them
            If selectedRow.Cells("subject_code").Value IsNot Nothing Then
                txtProfessorID.Text = selectedRow.Cells("subject_code").Value.ToString()
            End If
        End If
    End Sub

    Private Sub LoadSubjectCodes()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT DISTINCT subject_code FROM subject"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        cmbSubjectCode.Items.Clear()
                        cmbSubjectCode.Items.Add("All") ' Add "All" option

                        While reader.Read()
                            Dim subjectCode = reader("subject_code").ToString()
                            cmbSubjectCode.Items.Add(subjectCode)
                        End While
                    End Using
                End Using
            End Using

            cmbSubjectCode.SelectedIndex = 0 ' Select "All" by default
        Catch ex As Exception
            MessageBox.Show("Error loading subject codes: " & ex.Message & vbCrLf & "Please check your connection.")
        End Try
    End Sub

    Private Sub LoadAllSubjects()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT s.subject_code, s.subject_name, s.program_code, s.semester, " &
                                    "sa.professor_id, sa.section_code, sa.dept_code, " &
                                    "sa.day, sa.time " &
                                    "FROM subject s " &
                                    "LEFT JOIN subject_assign sa ON s.subject_code = sa.subject_code"

                dataAdapter = New MySqlDataAdapter(query, conn)
                dataTable.Clear()
                dataAdapter.Fill(dataTable)
                dgvCourse.DataSource = dataTable

                ' Configure DataGridView columns
                ConfigureDataGridView()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading subjects: " & ex.Message & System.Environment.NewLine & "Please check your connection.")
        End Try
    End Sub

    Private Sub ConfigureDataGridView()
        ' Set up column headers and properties
        With dgvCourse
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .ReadOnly = True
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
        End With
    End Sub

    Private Sub cmbSubjectCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSubjectCode.SelectedIndexChanged
        If cmbSubjectCode.SelectedItem Is Nothing Then Return

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String

                If cmbSubjectCode.SelectedItem.ToString() = "All" Then
                    query = "SELECT s.subject_code, s.subject_name, s.program_code, s.semester, " &
                           "sa.professor_id, sa.section_code, sa.dept_code, " &
                           "sa.day, sa.time " &
                           "FROM subject s " &
                           "LEFT JOIN subject_assign sa ON s.subject_code = sa.subject_code"
                Else
                    query = "SELECT s.subject_code, s.subject_name, s.program_code, s.semester, " &
                           "sa.professor_id, sa.section_code, sa.dept_code, " &
                           "sa.day, sa.time " &
                           "FROM subject s " &
                           "LEFT JOIN subject_assign sa ON s.subject_code = sa.subject_code " &
                           "WHERE s.subject_code = @subject"
                End If

                dataAdapter = New MySqlDataAdapter(query, conn)
                If cmbSubjectCode.SelectedItem.ToString() <> "All" Then
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@subject", cmbSubjectCode.SelectedItem.ToString())
                End If

                dataTable.Clear()
                dataAdapter.Fill(dataTable)
                dgvCourse.DataSource = dataTable
            End Using
        Catch ex As Exception
            MessageBox.Show("Error filtering subjects: " & ex.Message & System.Environment.NewLine & "Please check your connection.")
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim searchText As String = txtSearch.Text.Trim()
            Dim filterExpression As String = String.Format(
                "subject_code LIKE '%{0}%' OR subject_name LIKE '%{0}%' OR " &
                "professor_id LIKE '%{0}%' OR section_code LIKE '%{0}%' OR " &
                "program_code LIKE '%{0}%' OR semester LIKE '%{0}%'",
                searchText.Replace("'", "''"))
            DirectCast(dgvCourse.DataSource, DataTable).DefaultView.RowFilter = filterExpression
        Catch ex As Exception
            MessageBox.Show("Error searching: " & ex.Message & System.Environment.NewLine & "Please check your input.")
        End Try
    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        If dgvCourse.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a subject from the list")
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvCourse.SelectedRows(0)
        If selectedRow.Cells("subject_code").Value Is Nothing Then
            MessageBox.Show("No subject code found in the selected row")
            Return
        End If

        Dim subjectCode As String = selectedRow.Cells("subject_code").Value.ToString()

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT * FROM subject WHERE subject_code = @subjectCode"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@subjectCode", subjectCode)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Create new instance of NEWITEM form
                            Dim updateForm As New NEWITEM()
                            ' Load the subject data
                            updateForm.LoadSubjectData(subjectCode)

                            ' Show the form as dialog
                            If updateForm.ShowDialog() = DialogResult.OK Then
                                ' Refresh the data after returning
                                LoadAllSubjects()
                            End If
                        Else
                            MessageBox.Show("Subject not found")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message & System.Environment.NewLine & "Please check your connection and query.")
        Catch ex As Exception
            MessageBox.Show("General error: " & ex.Message & System.Environment.NewLine & "Please check your application logic.")
        End Try
    End Sub

    Private Sub DeleteSubject()
        If dgvCourse.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a subject from the list")
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvCourse.SelectedRows(0)
        If selectedRow.Cells("subject_code").Value Is Nothing Then
            MessageBox.Show("No subject code found in the selected row")
            Return
        End If

        Dim subjectCode As String = selectedRow.Cells("subject_code").Value.ToString()

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "DELETE FROM subject WHERE subject_code = @subjectCode"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@subjectCode", subjectCode)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show($"Subject with code {subjectCode} has been deleted.")
                        LoadAllSubjects() ' Refresh the DataGridView
                    Else
                        MessageBox.Show("Subject not found.")
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message & System.Environment.NewLine & "Please check your connection and query.")
        Catch ex As Exception
            MessageBox.Show("General error: " & ex.Message & System.Environment.NewLine & "Please check your application logic.")
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadAllSubjects()
        LoadSubjectCodes()

        txtSearch.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MessageBox.Show("Are you sure you want to exit?", "Confirm Exit",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteSubject()
    End Sub

    Private Sub dgvCourse_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCourse.CellContentClick

    End Sub
End Class