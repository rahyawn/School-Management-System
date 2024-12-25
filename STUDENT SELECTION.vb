Imports MySql.Data.MySqlClient

Public Class STUDENT_SELECTION
    Private connectionString As String = "server=localhost;user=root;password=;database=imvbnet_proj;port=3306;"
    Private connection As MySqlConnection

    Private Sub STUDENT_SELECTION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection(connectionString)

        ' Initially enable student ID and name fields
        txtStudentID.Enabled = True
        txtLastName.Enabled = True
        txtFirstName.Enabled = True
        txtMiddleInitial.Enabled = True
        txtSuffix.Enabled = True

        btnSave.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validate Student ID and Name
        If ValidateStudentIDAndName() Then
            Try
                ' Open connection if not already open
                If connection.State <> ConnectionState.Open Then
                    connection.Open()
                End If

                ' Check if student ID already exists
                If CheckStudentExists(txtStudentID.Text.Trim()) Then
                    MessageBox.Show("Student ID already exists. Please use a unique Student ID.", "Duplicate Student", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtStudentID.Clear()
                    txtStudentID.Focus()
                    Return
                End If

                ' Insert student data
                InsertStudentData()

                ' Clear form fields
                ClearAllFields()

                MessageBox.Show("Student information saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error saving student information: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Ensure connection is closed
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End If
    End Sub

    Private Function CheckStudentExists(studentId As String) As Boolean
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

    Private Sub InsertStudentData()
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "INSERT INTO student (student_id, last_name, first_name, middle_initial, suffix) VALUES (@student_id, @last_name, @first_name, @middle_initial, @suffix)"

            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@student_id", txtStudentID.Text.Trim())
                cmd.Parameters.AddWithValue("@last_name", txtLastName.Text.Trim())
                cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text.Trim())
                cmd.Parameters.AddWithValue("@middle_initial", txtMiddleInitial.Text.Trim())
                cmd.Parameters.AddWithValue("@suffix", txtSuffix.Text.Trim())
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Reset all fields and enable all input fields
        ClearAllFields()
        txtStudentID.Enabled = True
        txtLastName.Enabled = True
        txtFirstName.Enabled = True
        txtMiddleInitial.Enabled = True
        txtSuffix.Enabled = True

        btnSave.Enabled = True
    End Sub

    Private Function ValidateStudentIDAndName() As Boolean
        If String.IsNullOrWhiteSpace(txtStudentID.Text) Then
            MessageBox.Show("Student ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtStudentID.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtLastName.Text) Then
            MessageBox.Show("Last Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtLastName.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtFirstName.Text) Then
            MessageBox.Show("First Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFirstName.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub ClearAllFields()
        ' Clear all fields
        txtStudentID.Clear()
        txtLastName.Clear()
        txtFirstName.Clear()
        txtMiddleInitial.Clear()
        txtSuffix.Clear()
    End Sub

    Private Sub STUDENT_SELECTION_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub
End Class