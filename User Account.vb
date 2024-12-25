Imports MySql.Data.MySqlClient

Public Class User_Account
    Private connection As MySqlConnection
    Private command As MySqlCommand
    Private reader As MySqlDataReader
    Private dataAdapter As MySqlDataAdapter
    Private dataTable As DataTable

    Private Sub User_Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize database connection
        connection = New MySqlConnection("Server=localhost;Database=imvbnet_proj;Uid=root;Pwd=;")

        ' Disable all controls initially
        DisableControls()

        ' Load user types into combo box
        cboUserType.Items.Add("student")
        cboUserType.Items.Add("professor")

        ' Load questions into combo box
        LoadQuestions()

        ' Load data grid view
        LoadUserAccounts()
    End Sub

    Private Sub LoadQuestions()
        Try
            connection.Open()
            command = New MySqlCommand("SELECT question_no, questions FROM question", connection)
            reader = command.ExecuteReader()

            While reader.Read()
                cboQuestionNo.Items.Add(reader("questions").ToString())
            End While

        Catch ex As Exception
            MessageBox.Show("Error loading questions: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub LoadUserAccounts()
        Try
            connection.Open()
            dataAdapter = New MySqlDataAdapter("SELECT * FROM user_account ORDER BY account_id", connection)
            dataTable = New DataTable()
            dataAdapter.Fill(dataTable)
            DataGridView1.DataSource = dataTable

            ' Auto-size columns for better visibility
            DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

        Catch ex As Exception
            MessageBox.Show("Error refreshing data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub DisableControls()
        txtStudentID.Enabled = False
        txtProfessorID.Enabled = False
        txtAccountID.Enabled = False
        txtAccountID2.Enabled = False
        txtEmail.Enabled = False
        txtPassword.Enabled = False
        cboQuestionNo.Enabled = False
        txtAnswer.Enabled = False
        btnAdd.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub cboUserType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUserType.SelectedIndexChanged
        Select Case cboUserType.SelectedItem.ToString().ToLower()
            Case "student"
                EnableStudentControls()
            Case "professor"
                EnableProfessorControls()
            Case "admin"
                EnableAdminControls()
        End Select
    End Sub

    Private Sub EnableStudentControls()
        txtStudentID.Enabled = True
        txtProfessorID.Enabled = False
        txtAccountID.Enabled = True
        txtAccountID2.Enabled = False
        txtEmail.Enabled = True
        txtPassword.Enabled = True
        cboQuestionNo.Enabled = True
        txtAnswer.Enabled = True
        btnAdd.Enabled = True
        btnDelete.Enabled = True

        ' Clear professor fields
        txtProfessorID.Clear()
        txtAccountID2.Clear()
    End Sub

    Private Sub EnableProfessorControls()
        txtStudentID.Enabled = False
        txtProfessorID.Enabled = True
        txtAccountID.Enabled = False
        txtAccountID2.Enabled = True
        txtEmail.Enabled = True
        txtPassword.Enabled = True
        cboQuestionNo.Enabled = True
        txtAnswer.Enabled = True
        btnAdd.Enabled = True
        btnDelete.Enabled = True

        ' Clear student fields
        txtStudentID.Clear()
        txtAccountID.Clear()
    End Sub

    Private Sub EnableAdminControls()
        txtStudentID.Enabled = False
        txtProfessorID.Enabled = False
        txtAccountID.Enabled = False
        txtAccountID2.Enabled = False
        txtEmail.Enabled = True
        txtPassword.Enabled = True
        cboQuestionNo.Enabled = True
        txtAnswer.Enabled = True
        btnAdd.Enabled = True
        btnDelete.Enabled = True

        ' Clear ID fields
        txtStudentID.Clear()
        txtProfessorID.Clear()
        txtAccountID.Clear()
        txtAccountID2.Clear()
    End Sub

    Private Sub txtStudentID_TextChanged(sender As Object, e As EventArgs) Handles txtStudentID.TextChanged
        txtAccountID.Text = txtStudentID.Text
    End Sub

    Private Sub txtProfessorID_TextChanged(sender As Object, e As EventArgs) Handles txtProfessorID.TextChanged
        txtAccountID2.Text = txtProfessorID.Text
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If ValidateInputs() Then
            Try
                connection.Open()

                ' Verify existence of account_id in the user_account table
                Dim checkAccountQuery As String = "SELECT COUNT(*) FROM user_account WHERE account_id = @account_id"
                Dim checkAccountCmd As New MySqlCommand(checkAccountQuery, connection)
                checkAccountCmd.Parameters.AddWithValue("@account_id", If(txtAccountID.Enabled, txtAccountID.Text, txtAccountID2.Text))
                Dim accountExists As Integer = Convert.ToInt32(checkAccountCmd.ExecuteScalar())

                If accountExists > 0 Then
                    MessageBox.Show("Error: Account ID already exists in the user_account table.")
                    Return
                End If

                ' Verify existence of student_id in the student table if user type is "Student"
                If cboUserType.SelectedItem.ToString() = "Student" Then
                    Dim checkStudentQuery As String = "SELECT COUNT(*) FROM student WHERE student_id = @student_id"
                    Dim checkStudentCmd As New MySqlCommand(checkStudentQuery, connection)
                    checkStudentCmd.Parameters.AddWithValue("@student_id", txtStudentID.Text)
                    Dim studentExists As Integer = Convert.ToInt32(checkStudentCmd.ExecuteScalar())

                    If studentExists = 0 Then
                        MessageBox.Show("Error: Student ID does not exist in the student table.")
                        Return
                    End If
                End If

                ' Verify existence of professor_id in the professor table if user type is "Professor"
                If cboUserType.SelectedItem.ToString() = "Professor" Then
                    Dim checkProfessorQuery As String = "SELECT COUNT(*) FROM professor WHERE professor_id = @professor_id"
                    Dim checkProfessorCmd As New MySqlCommand(checkProfessorQuery, connection)
                    checkProfessorCmd.Parameters.AddWithValue("@professor_id", txtProfessorID.Text)
                    Dim professorExists As Integer = Convert.ToInt32(checkProfessorCmd.ExecuteScalar())

                    If professorExists = 0 Then
                        MessageBox.Show("Error: Professor ID does not exist in the professor table.")
                        Return
                    End If
                End If

                ' Prepare insert query
                Dim query As String = "INSERT INTO user_account (account_id, student_id, professor_id, email, password, user_type, question_no, answer) " &
                                    "VALUES (@account_id, @student_id, @professor_id, @email, @password, @user_type, @question_no, @answer)"
                Dim cmd As New MySqlCommand(query, connection)

                ' Map account_id, student_id, professor_id
                Dim accountId As String = If(txtAccountID.Enabled, txtAccountID.Text, txtAccountID2.Text)
                Dim studentId As Object = If(txtStudentID.Enabled, txtStudentID.Text, DBNull.Value)
                Dim professorId As Object = If(txtProfessorID.Enabled, txtProfessorID.Text, DBNull.Value)

                ' Get question_no based on selected question text
                Dim selectedQuestionText = cboQuestionNo.SelectedItem.ToString()
                Dim getQuestionNoQuery = "SELECT question_no FROM question WHERE questions = @questionText"
                Dim questionNoCmd = New MySqlCommand(getQuestionNoQuery, connection)
                questionNoCmd.Parameters.AddWithValue("@questionText", selectedQuestionText)
                Dim selectedQuestionNo = questionNoCmd.ExecuteScalar().ToString()

                ' Add parameters
                cmd.Parameters.AddWithValue("@account_id", accountId)
                cmd.Parameters.AddWithValue("@student_id", studentId)
                cmd.Parameters.AddWithValue("@professor_id", professorId)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@password", txtPassword.Text)
                cmd.Parameters.AddWithValue("@user_type", cboUserType.SelectedItem.ToString)
                cmd.Parameters.AddWithValue("@question_no", selectedQuestionNo)
                cmd.Parameters.AddWithValue("@answer", txtAnswer.Text)

                ' Execute query
                cmd.ExecuteNonQuery()
                MessageBox.Show("User account added successfully!")
                ClearInputs()
                LoadUserAccounts()

            Catch ex As Exception
                MessageBox.Show("Error adding user account: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Check if a row is selected
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the account_id from the selected row
        Dim accountId As String = DataGridView1.SelectedRows(0).Cells("account_id").Value.ToString()

        ' Show confirmation dialog
        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to delete the account with ID: " & accountId & "?" & vbCrLf &
            "This action cannot be undone.",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        ' If user confirms deletion
        If result = DialogResult.Yes Then
            Try
                connection.Open()

                ' Prepare delete query
                Dim query As String = "DELETE FROM user_account WHERE account_id = @account_id"
                command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@account_id", accountId)

                ' Execute query
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Account deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Refresh the DataGridView
                    LoadUserAccounts()
                Else
                    MessageBox.Show("No account was deleted. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show("Error deleting account: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            LoadUserAccounts()
            MessageBox.Show("Data refreshed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error refreshing data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearInputs()
        txtStudentID.Clear()
        txtProfessorID.Clear()
        txtAccountID.Clear()
        txtAccountID2.Clear()
        txtEmail.Clear()
        txtPassword.Clear()
        cboQuestionNo.SelectedIndex = -1
        txtAnswer.Clear()
    End Sub

    Private Function ValidateInputs() As Boolean
        If cboUserType.SelectedIndex = -1 Then
            MessageBox.Show("Please select a user type.")
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtEmail.Text) Then
            MessageBox.Show("Please enter an email address.")
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please enter a password.")
            Return False
        End If

        If cboQuestionNo.SelectedIndex = -1 Then
            MessageBox.Show("Please select a security question.")
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtAnswer.Text) Then
            MessageBox.Show("Please enter an answer to the security question.")
            Return False
        End If

        ' If the user type is Student, check that Student ID and Account ID are provided
        If cboUserType.SelectedItem.ToString().ToLower() = "student" Then
            If String.IsNullOrWhiteSpace(txtStudentID.Text) Or String.IsNullOrWhiteSpace(txtAccountID.Text) Then
                MessageBox.Show("Please enter a valid student ID and account ID.")
                Return False
            End If
        End If

        ' If the user type is Professor, check that Professor ID and Account ID are provided
        If cboUserType.SelectedItem.ToString().ToLower() = "professor" Then
            If String.IsNullOrWhiteSpace(txtProfessorID.Text) Or String.IsNullOrWhiteSpace(txtAccountID2.Text) Then
                MessageBox.Show("Please enter a valid professor ID and account ID.")
                Return False
            End If
        End If

        Return True
    End Function
End Class

' Helper class for combo box items
Public Class ComboboxItem
    Private _text As String
    Private _value As String

    Public Sub New(text As String, value As String)
        _text = text
        _value = value
    End Sub

    Public ReadOnly Property Text As String
        Get
            Return _text
        End Get
    End Property

    Public ReadOnly Property Value As String
        Get
            Return _value
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return _text
    End Function
End Class