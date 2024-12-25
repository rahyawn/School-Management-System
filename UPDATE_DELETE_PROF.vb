Imports MySql.Data.MySqlClient

Public Class UPDATE_DELETE_PROF
    Private connectionString As String = "server=localhost;user=root;password=;database=imvbnet_proj;port=3306;"
    Private connection As MySqlConnection
    Private dataAdapter As MySqlDataAdapter
    Private dataTable As New DataTable()

    Private Sub UPDATE_DELETE_PROF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDept_code()
        LoadAllProfessors()

        ' Add event handler for DataGridView row click
        AddHandler dgvPROF.CellClick, AddressOf DataGridView1_CellClick
    End Sub

    ' Method to handle DataGridView cell click
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgvPROF.Rows(e.RowIndex)
            If selectedRow.Cells("professor_id").Value IsNot Nothing Then
                txtProfessorID.Text = selectedRow.Cells("professor_id").Value.ToString()
            End If
        End If
    End Sub

    Private Sub LoadDept_code()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT DISTINCT dept_code FROM professor"
                Dim cmd As New MySqlCommand(query, conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                cmbdept_code.Items.Clear()
                cmbdept_code.Items.Add("All")

                While reader.Read()
                    cmbdept_code.Items.Add(reader("dept_code").ToString())
                End While
            End Using
            cmbdept_code.SelectedIndex = 0 ' Select "All" by default
        Catch ex As Exception
            MessageBox.Show("Error loading department codes: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadAllProfessors()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT professor_id, last_name, first_name, middle_initial, suffix, dept_code FROM professor"

                dataAdapter = New MySqlDataAdapter(query, conn)
                dataTable.Clear()
                dataAdapter.Fill(dataTable)
                dgvPROF.DataSource = dataTable
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading professors: " & ex.Message)
        End Try
    End Sub

    Private Sub cmbdept_code_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdept_code.SelectedIndexChanged
        If cmbdept_code.SelectedItem Is Nothing Then Return

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String

                If cmbdept_code.SelectedItem.ToString = "All" Then
                    query = "SELECT professor_id, last_name, first_name, middle_initial, suffix, dept_code FROM professor"
                Else
                    query = "SELECT professor_id, last_name, first_name, middle_initial, suffix, dept_code FROM professor WHERE dept_code = @department"
                End If

                dataAdapter = New MySqlDataAdapter(query, conn)
                If cmbdept_code.SelectedItem.ToString <> "All" Then
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@department", cmbdept_code.SelectedItem.ToString)
                End If

                dataTable.Clear()
                dataAdapter.Fill(dataTable)
                dgvPROF.DataSource = dataTable
            End Using
        Catch ex As Exception
            MessageBox.Show("Error filtering professors: " & ex.Message)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim searchText As String = txtSearch.Text.Trim()
            Dim filterExpression As String = String.Format("professor_id LIKE '%{0}%' OR last_name LIKE '%{0}%' OR first_name LIKE '%{0}%'", searchText)
            DirectCast(dgvPROF.DataSource, DataTable).DefaultView.RowFilter = filterExpression
        Catch ex As Exception
            MessageBox.Show("Error searching: " & ex.Message)
        End Try
    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        If String.IsNullOrEmpty(txtProfessorID.Text) Then
            MessageBox.Show("Please enter a Professor ID")
            Return
        End If

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT * FROM professor WHERE professor_id = @professorId"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@professorId", txtProfessorID.Text)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim updateForm As New Prof_up_de()
                    updateForm.LoadProfessorData(txtProfessorID.Text)
                    updateForm.ShowDialog()

                    ' Refresh the DataGridView after returning from Prof_up_de form
                    LoadAllProfessors()
                Else
                    MessageBox.Show("Professor ID not found")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading professor data: " & ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadAllProfessors()
        txtProfessorID.Clear()
        txtSearch.Clear()
        cmbdept_code.SelectedIndex = 0
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MessageBox.Show("Are you sure you want to exit?", "Confirm Exit",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class