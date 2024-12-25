Imports MySql.Data.MySqlClient

Public Class PROF_SELECTION
    Private connectionString As String = "server=localhost;user=root;password=;database=imvbnet_proj;port=3306;"
    Private connection As MySqlConnection

    ' Keep only ONE definition of PROF_SELECTION_Load
    Private Sub PROF_SELECTION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection(connectionString)

        ' Populate the ComboBox with department codes
        Try
            If connection.State <> ConnectionState.Open Then
                connection.Open()
            End If

            ' Clear existing items to avoid duplicates
            cmbRightDepartmentCode.Items.Clear()

            ' Ensure that only distinct dept_code values are selected
            Dim query As String = "SELECT DISTINCT dept_code FROM department" ' Adjust table/column name as needed
            Using cmd As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        cmbRightDepartmentCode.Items.Add(reader("dept_code").ToString())
                    End While
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error loading department codes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    ' The rest of your code remains unchanged...
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not ValidateRightInputs() Then
            Return
        End If

        Try
            If connection.State <> ConnectionState.Open Then
                connection.Open()
            End If

            ' Query matches exactly with your database table structure
            Dim query As String = "INSERT INTO professor (professor_id, last_name, first_name, middle_initial, suffix, dept_code) " &
                                  "VALUES (@professor_id, @last_name, @first_name, @middle_initial, @suffix, @dept_code)"

            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@professor_id", txtRightProffesorID.Text.Trim())
                cmd.Parameters.AddWithValue("@last_name", txtRightLastName.Text.Trim())
                cmd.Parameters.AddWithValue("@first_name", txtRightFirstName.Text.Trim())
                cmd.Parameters.AddWithValue("@middle_initial", If(String.IsNullOrWhiteSpace(txtRightMiddleInitial.Text), DBNull.Value, txtRightMiddleInitial.Text.Trim()))
                cmd.Parameters.AddWithValue("@suffix", If(String.IsNullOrWhiteSpace(txtRightSuffix.Text), DBNull.Value, txtRightSuffix.Text.Trim()))
                cmd.Parameters.AddWithValue("@dept_code", cmbRightDepartmentCode.SelectedItem.ToString()) ' Get selected value from ComboBox

                cmd.ExecuteNonQuery()
                MessageBox.Show("Professor data saved successfully to database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Clear the right textboxes after save
                ClearRightFields()
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

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear only the right side fields
        txtRightProffesorID.Text = ""
        txtRightLastName.Text = ""
        txtRightFirstName.Text = ""
        txtRightMiddleInitial.Text = ""
        txtRightSuffix.Text = ""
        cmbRightDepartmentCode.SelectedIndex = -1 ' Reset ComboBox selection

        MessageBox.Show("Fields have been cleared!", "Clear Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Function ValidateRightInputs() As Boolean
        ' Check only required fields for right side
        If String.IsNullOrWhiteSpace(txtRightProffesorID.Text) OrElse
           String.IsNullOrWhiteSpace(txtRightLastName.Text) OrElse
           String.IsNullOrWhiteSpace(txtRightFirstName.Text) OrElse
           cmbRightDepartmentCode.SelectedIndex = -1 Then ' Ensure a department is selected
            MessageBox.Show("Professor ID, Last Name, First Name, and Department Code are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Sub ClearRightFields()
        txtRightProffesorID.Clear()
        txtRightLastName.Clear()
        txtRightFirstName.Clear()
        txtRightMiddleInitial.Clear()
        txtRightSuffix.Clear()
        cmbRightDepartmentCode.SelectedIndex = -1 ' Reset ComboBox selection
    End Sub

    Private Sub PROF_SELECTION_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    Private Sub txtRightMiddleInitial_TextChanged(sender As Object, e As EventArgs) Handles txtRightMiddleInitial.TextChanged
        ' Event handler for middle initial text changes (if needed)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' Exit the form
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRightDepartmentCode.SelectedIndexChanged
        ' Event handler for ComboBox item selection changes (if needed)
    End Sub
End Class
