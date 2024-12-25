Imports MySql.Data.MySqlClient

Public Class COURSE_SELECTION
    ' Connection string for the database (no password)
    Private connectionString As String = "server=localhost;user=root;password=;database=imvbnet_proj;port=3306;"
    Private connection As MySqlConnection

    Private Sub COURSE_SELECTION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection(connectionString)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validate inputs first
        If String.IsNullOrEmpty(txtSubjectCode.Text) OrElse
       String.IsNullOrEmpty(txtSubjectName.Text) OrElse
       cmbProgramCode.SelectedIndex = -1 OrElse ' Ensure an item is selected
       cmbSemester.SelectedIndex = -1 Then ' Ensure an item is selected
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            If connection.State <> ConnectionState.Open Then
                connection.Open()
            End If

            ' SQL command to insert data
            Dim sql As String = "INSERT INTO subject (subject_code, subject_name, program_code, semester) VALUES (@subject_code, @subject_name, @program_code, @semester)"
            Using cmd As New MySqlCommand(sql, connection)
                cmd.Parameters.AddWithValue("@subject_code", txtSubjectCode.Text.Trim())
                cmd.Parameters.AddWithValue("@subject_name", txtSubjectName.Text.Trim())
                cmd.Parameters.AddWithValue("@program_code", cmbProgramCode.SelectedItem.ToString()) ' Get selected value
                cmd.Parameters.AddWithValue("@semester", cmbSemester.SelectedItem.ToString()) ' Get selected value
                cmd.ExecuteNonQuery()

                MessageBox.Show("Subject successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
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


    Private Sub ClearFields()
        txtSubjectCode.Clear()
        txtSubjectName.Clear()
        cmbProgramCode.SelectedIndex = -1 ' Deselect any item
        cmbSemester.SelectedIndex = -1 ' Deselect any item
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
