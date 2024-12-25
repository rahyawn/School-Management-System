Imports MySql.Data.MySqlClient

Public Class Section_Assign
    Private connectionString As String = "server=localhost;user=root;password=;database=imvbnet_proj;port=3306;"
    Private connection As MySqlConnection

    Private Sub SECTION_ASSIGN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection(connectionString)

        ' Initially enable fields
        txtSectionCode.Enabled = True
        txtRightStudentID.Enabled = True

        btnSave1.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave1.Click
        ' Validate inputs
        If ValidateInputs() Then
            Try
                ' Open connection if not already open
                If connection.State <> ConnectionState.Open Then
                    connection.Open()
                End If

                ' Check if section assignment already exists
                If CheckAssignmentExists(txtSectionCode.Text.Trim(), txtRightStudentID.Text.Trim()) Then
                    MessageBox.Show("This student is already assigned to this section.", "Duplicate Assignment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                ' Verify that both section and student exist
                If Not VerifySection(txtSectionCode.Text.Trim()) Then
                    MessageBox.Show("Section does not exist.", "Invalid Section", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtSectionCode.Focus()
                    Return
                End If

                If Not VerifyStudent(txtRightStudentID.Text.Trim()) Then
                    MessageBox.Show("Student ID does not exist.", "Invalid Student", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtRightStudentID.Focus()
                    Return
                End If

                ' Insert section assignment
                InsertSectionAssignment()

                ' Clear form fields
                ClearAllFields()

                MessageBox.Show("Section assignment saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error saving section assignment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Ensure connection is closed
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End If
    End Sub

    Private Function CheckAssignmentExists(sectionCode As String, studentId As String) As Boolean
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM section_assign WHERE section_code = @section_code AND student_id = @student_id"

            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@section_code", sectionCode)
                cmd.Parameters.AddWithValue("@student_id", studentId)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    Private Function VerifySection(sectionCode As String) As Boolean
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM section WHERE section_code = @section_code"

            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@section_code", sectionCode)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    Private Function VerifyStudent(studentId As String) As Boolean
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM student WHERE student_id = @student_id"

            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@student_id", studentId)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    Private Sub InsertSectionAssignment()
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "INSERT INTO section_assign (section_code, student_id) VALUES (@section_code, @student_id)"

            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@section_code", txtSectionCode.Text.Trim())
                cmd.Parameters.AddWithValue("@student_id", txtRightStudentID.Text.Trim())
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear1.Click
        ' Reset all fields and enable input fields
        ClearAllFields()
        txtSectionCode.Enabled = True
        txtRightStudentID.Enabled = True

        btnSave1.Enabled = True
    End Sub

    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(txtSectionCode.Text) Then
            MessageBox.Show("Section_code is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSectionCode.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtRightStudentID.Text) Then
            MessageBox.Show("Student_id is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRightStudentID.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub ClearAllFields()
        ' Clear all fields
        txtSectionCode.SelectedIndex = -1
        txtRightStudentID.Clear()
    End Sub

    Private Sub SECTION_ASSIGNMENT_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
