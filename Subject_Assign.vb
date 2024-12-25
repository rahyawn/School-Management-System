Imports MySql.Data.MySqlClient

Public Class Subject_Assign
    Private connectionString As String = "server=localhost;user=root;password=;database=imvbnet_proj;port=3306;"
    Private connection As MySqlConnection

    Private Sub AdminProf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection(connectionString)
        PopulateComboBoxes()
    End Sub

    Private Sub PopulateComboBoxes()
        Try
            If connection.State <> ConnectionState.Open Then
                connection.Open()
            End If

            ' Populate Department Code ComboBox
            cmbDepartmentCode.Items.Clear()
            Dim deptQuery As String = "SELECT DISTINCT dept_code FROM department"
            Using cmdDept As New MySqlCommand(deptQuery, connection)
                Using reader As MySqlDataReader = cmdDept.ExecuteReader()
                    While reader.Read()
                        cmbDepartmentCode.Items.Add(reader("dept_code").ToString())
                    End While
                End Using
            End Using

            ' Populate Subject Code ComboBox
            cmbSubjectCode.Items.Clear()
            Dim subjectQuery As String = "SELECT DISTINCT subject_code FROM subject"
            Using cmdSubject As New MySqlCommand(subjectQuery, connection)
                Using reader As MySqlDataReader = cmdSubject.ExecuteReader()
                    While reader.Read()
                        cmbSubjectCode.Items.Add(reader("subject_code").ToString())
                    End While
                End Using
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not ValidateInputs() Then
            Return
        End If

        ' Add your logic for the ADD button here
        MessageBox.Show("Record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not ValidateInputs() Then
            Return
        End If

        Try
            If connection.State <> ConnectionState.Open Then
                connection.Open()
            End If

            ' Check if the subjects table exists
            Dim checkTableQuery As String = "SHOW TABLES LIKE 'subject'"
            Dim cmdCheckTable As New MySqlCommand(checkTableQuery, connection)
            Dim tableExists As Object = cmdCheckTable.ExecuteScalar()

            If tableExists Is Nothing Then
                MessageBox.Show("The 'subjects' table does not exist in the database. Please go to Course Selection to add the subject first.", "Table Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Check if the subject code exists
            Dim subjectCode As String = cmbSubjectCode.Text.Trim()
            Dim checkQuery As String = "SELECT COUNT(*) FROM subject WHERE subject_code = @subject_code"

            Dim cmdCheck As New MySqlCommand(checkQuery, connection)
            cmdCheck.Parameters.AddWithValue("@subject_code", subjectCode)

            Dim subjectCount As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())

            If subjectCount = 0 Then
                MessageBox.Show("The selected subject code does not exist in the database. Please go to Course Selection to add the subject first.", "Subject Code Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Insert the record
            Dim query As String = "INSERT INTO subject_assign (professor_id, subject_code, section_code, dept_code, day, time) " &
                                "VALUES (@professor_id, @subject_code, @section_code, @dept_code, @day, @time)"

            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@professor_id", txtProfessorID.Text.Trim())
                cmd.Parameters.AddWithValue("@subject_code", subjectCode)
                cmd.Parameters.AddWithValue("@section_code", cmbSectionCode.Text.Trim())
                cmd.Parameters.AddWithValue("@dept_code", cmbDepartmentCode.Text.Trim())
                cmd.Parameters.AddWithValue("@day", txtDay.Text.Trim())
                cmd.Parameters.AddWithValue("@time", txtTime.Text.Trim())

                cmd.ExecuteNonQuery()
                MessageBox.Show("Professor schedule saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearFields()
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(txtProfessorID.Text) OrElse
           String.IsNullOrWhiteSpace(cmbSubjectCode.Text) OrElse
           String.IsNullOrWhiteSpace(cmbSectionCode.Text) OrElse
           String.IsNullOrWhiteSpace(cmbDepartmentCode.Text) OrElse
           String.IsNullOrWhiteSpace(txtDay.Text) OrElse
           String.IsNullOrWhiteSpace(txtTime.Text) Then
            MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtProfessorID.Clear()
        cmbSubjectCode.SelectedIndex = -1
        cmbSectionCode.SelectedIndex = -1
        cmbDepartmentCode.SelectedIndex = -1
        txtDay.Clear()
        txtTime.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub AdminProf_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    Private Sub cmbDepartmentCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartmentCode.SelectedIndexChanged
        ' Add any specific logic needed when department code changes
    End Sub

    Private Sub cmbSubjectCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSubjectCode.SelectedIndexChanged

    End Sub
End Class