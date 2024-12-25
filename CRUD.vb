Imports MySql.Data.MySqlClient

Public Class CRUD
    Private connectionString As String = "server=localhost;user=root;password=;database=imvbnet_proj;port=3306;"
    Private connection As MySqlConnection
    Private dataAdapter As MySqlDataAdapter
    Private dataTable As New DataTable()

    Private Sub CRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSectionCodes()
        LoadAllStudents()

        ' Add event handler for DataGridView row click
        AddHandler DataGridView1.CellClick, AddressOf DataGridView1_CellClick
    End Sub

    ' New method to handle DataGridView cell click
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        ' Check if a valid row is clicked (not header row)
        If e.RowIndex >= 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            ' Check if the student ID cell exists
            If selectedRow.Cells("student_id").Value IsNot Nothing Then
                ' Transfer the student ID to the txtStudentID textbox
                txtStudentID.Text = selectedRow.Cells("student_id").Value.ToString()
            End If
        End If
    End Sub

    Private Sub LoadSectionCodes()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT DISTINCT section_code FROM section_assign"
                Dim cmd As New MySqlCommand(query, conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                cmbSectionCode.Items.Clear()
                cmbSectionCode.Items.Add("All") ' Add "All" option

                While reader.Read()
                    cmbSectionCode.Items.Add(reader("section_code").ToString())
                End While
            End Using
            cmbSectionCode.SelectedIndex = 0 ' Select "All" by default
        Catch ex As Exception
            MessageBox.Show("Error loading section codes: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadAllStudents()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT s.student_id, s.last_name, s.first_name, s.middle_initial, " &
                                    "s.suffix, sa.section_code " &
                                    "FROM student s LEFT JOIN section_assign sa ON s.student_id = sa.student_id"

                dataAdapter = New MySqlDataAdapter(query, conn)
                dataTable.Clear()
                dataAdapter.Fill(dataTable)
                DataGridView1.DataSource = dataTable
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading students: " & ex.Message)
        End Try
    End Sub

    Private Sub cmbSectionCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSectionCode.SelectedIndexChanged
        If cmbSectionCode.SelectedItem Is Nothing Then Return

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String

                If cmbSectionCode.SelectedItem.ToString() = "All" Then
                    query = "SELECT s.student_id, s.last_name, s.first_name, s.middle_initial, " &
                           "s.suffix, sa.section_code " &
                           "FROM student s LEFT JOIN section_assign sa ON s.student_id = sa.student_id"
                Else
                    query = "SELECT s.student_id, s.last_name, s.first_name, s.middle_initial, " &
                           "s.suffix, sa.section_code " &
                           "FROM student s LEFT JOIN section_assign sa ON s.student_id = sa.student_id " &
                           "WHERE sa.section_code = @section"
                End If

                dataAdapter = New MySqlDataAdapter(query, conn)
                If cmbSectionCode.SelectedItem.ToString() <> "All" Then
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@section", cmbSectionCode.SelectedItem.ToString())
                End If

                dataTable.Clear()
                dataAdapter.Fill(dataTable)
                DataGridView1.DataSource = dataTable
            End Using
        Catch ex As Exception
            MessageBox.Show("Error filtering students: " & ex.Message)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim searchText As String = txtSearch.Text.Trim()
            Dim filterExpression As String = String.Format("student_id LIKE '%{0}%' OR last_name LIKE '%{0}%' OR first_name LIKE '%{0}%'", searchText)
            DirectCast(DataGridView1.DataSource, DataTable).DefaultView.RowFilter = filterExpression
        Catch ex As Exception
            MessageBox.Show("Error searching: " & ex.Message)
        End Try
    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        If String.IsNullOrEmpty(txtStudentID.Text) Then
            MessageBox.Show("Please enter a Student ID")
            Return
        End If

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT * FROM student WHERE student_id = @studentId"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@studentId", txtStudentID.Text)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim updateForm As New UPDATE_DELETE()
                    updateForm.LoadStudentData(txtStudentID.Text)
                    updateForm.ShowDialog()

                    ' Refresh the DataGridView after returning from UPDATE_DELETE form
                    If updateForm.DialogResult = DialogResult.OK Then
                        LoadAllStudents()
                    End If
                Else
                    MessageBox.Show("Student ID not found")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading student data: " & ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadAllStudents()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MessageBox.Show("Are you sure you want to exit?", "Confirm Exit",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class