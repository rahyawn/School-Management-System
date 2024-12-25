Imports MySql.Data.MySqlClient

Public Class Prof_up_de
    Private connectionString As String = "server=localhost;user=root;password=;database=imvbnet_proj;"
    Private connection As MySqlConnection
    Private dataAdapter As MySqlDataAdapter
    Private dataTable As New DataTable()

    Private isEditMode As Boolean = False
    Private isDeleteMode As Boolean = False
    Private originalProfessorData As New Dictionary(Of String, String)

    Private Sub UPDATE_DELETE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisableEditControls()
        LoadDept_code()
    End Sub

    Private Sub LoadDept_code()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT DISTINCT dept_code FROM professor"
                Dim cmd As New MySqlCommand(query, conn)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                cmbdept_code.Items.Clear()
                While reader.Read()
                    cmbdept_code.Items.Add(reader("dept_code").ToString())
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading department codes: " & ex.Message)
        End Try
    End Sub

    Private Sub DisableEditControls()
        txtLastName.ReadOnly = True
        txtFirstName.ReadOnly = True
        txtMiddleInitial.ReadOnly = True
        txtSuffix.ReadOnly = True
        cmbdept_code.Enabled = False

        btnSave.Enabled = False
        btnCancel.Enabled = False

        btnUpdate.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Sub EnableEditControls()
        txtLastName.ReadOnly = False
        txtFirstName.ReadOnly = False
        txtMiddleInitial.ReadOnly = False
        txtSuffix.ReadOnly = False
        cmbdept_code.Enabled = True

        btnSave.Enabled = True
        btnCancel.Enabled = True

        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Public Sub LoadProfessorData(professorId As String)
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT * FROM professor WHERE professor_id = @professorId"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@professorId", professorId)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    originalProfessorData.Clear()
                    originalProfessorData("professor_id") = reader("professor_id").ToString()
                    originalProfessorData("last_name") = reader("last_name").ToString()
                    originalProfessorData("first_name") = reader("first_name").ToString()
                    originalProfessorData("middle_initial") = reader("middle_initial").ToString()
                    originalProfessorData("suffix") = reader("suffix").ToString()
                    originalProfessorData("dept_code") = reader("dept_code").ToString()

                    txtprofessor_id.Text = reader("professor_id").ToString()
                    txtLastName.Text = reader("last_name").ToString()
                    txtFirstName.Text = reader("first_name").ToString()
                    txtMiddleInitial.Text = reader("middle_initial").ToString()
                    txtSuffix.Text = reader("suffix").ToString()
                    cmbdept_code.SelectedItem = reader("dept_code").ToString()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading professor data: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrEmpty(txtprofessor_id.Text) Then
            MessageBox.Show("Please enter a Professor ID")
            Return
        End If

        isEditMode = True
        isDeleteMode = False
        EnableEditControls()
        LoadProfessorData(txtprofessor_id.Text)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrEmpty(txtprofessor_id.Text) Then
            MessageBox.Show("Please enter a Professor ID")
            Return
        End If

        isDeleteMode = True
        isEditMode = False

        Dim confirmDelete = MessageBox.Show("Are you sure you want to delete this professor?" &
                                          vbCrLf & "Click 'Yes' to confirm or 'No' to abort.",
                                          "Confirm Delete",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning)

        If confirmDelete = DialogResult.Yes Then
            DeleteProfessorData()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If isEditMode Then
            UpdateProfessorData()
        End If
    End Sub

    Private Sub UpdateProfessorData()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "UPDATE professor SET " &
                                      "last_name = @lastName, " &
                                      "first_name = @firstName, " &
                                      "middle_initial = @middleInitial, " &
                                      "suffix = @suffix, " &
                                      "dept_code = @deptCode " &
                                      "WHERE professor_id = @professorId"

                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@lastName", txtLastName.Text)
                cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text)
                cmd.Parameters.AddWithValue("@middleInitial", txtMiddleInitial.Text)
                cmd.Parameters.AddWithValue("@suffix", txtSuffix.Text)
                cmd.Parameters.AddWithValue("@deptCode", cmbdept_code.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@professorId", txtprofessor_id.Text)

                cmd.ExecuteNonQuery()

                MessageBox.Show("Professor data updated successfully.")
                isEditMode = False
                DisableEditControls()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating professor data: " & ex.Message)
        End Try
    End Sub

    Private Sub DeleteProfessorData()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "DELETE FROM professor WHERE professor_id = @professorId"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@professorId", txtprofessor_id.Text)

                cmd.ExecuteNonQuery()

                MessageBox.Show("Professor deleted successfully.")
                ClearForm()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting professor data: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If isEditMode Then
            RestoreOriginalData()
        End If

        isEditMode = False
        isDeleteMode = False
        DisableEditControls()
    End Sub

    Private Sub RestoreOriginalData()
        If originalProfessorData.Count > 0 Then
            txtLastName.Text = originalProfessorData("last_name")
            txtFirstName.Text = originalProfessorData("first_name")
            txtMiddleInitial.Text = originalProfessorData("middle_initial")
            txtSuffix.Text = originalProfessorData("suffix")
            cmbdept_code.SelectedItem = originalProfessorData("dept_code")
        End If
    End Sub

    Private Sub ClearForm()
        txtprofessor_id.Clear()
        txtLastName.Clear()
        txtFirstName.Clear()
        txtMiddleInitial.Clear()
        txtSuffix.Clear()
        cmbdept_code.SelectedIndex = -1
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class