Imports MySql.Data.MySqlClient

Public Class Change_Password
    ' Variables
    Private user_id As String
    Private sec_answer As String
    Private question_num As String
    Private done As Boolean = False

    ' Global variables
    Private userEmail As String
    Private securityAnswers As New Dictionary(Of Integer, String)
    Private isEmailValid As Boolean = False
    Private areAnswersValid As Boolean = False
    Private isPasswordValid As Boolean = False

    ' Constants for validation
    Private Const MIN_PASSWORD_LENGTH As Integer = 8

    Private Sub proceedIDBtn_Click(sender As Object, e As EventArgs) Handles proceedIDBtn.Click
        ValidateIDInput()
    End Sub

    Private Function IsValidID(accountID As String) As Boolean
        Using con As New MySqlConnection("Server=localhost;Database=imvbnet_proj;User ID=root;Pooling=true")
            Dim str As String = "SELECT COUNT(*) FROM user_account WHERE account_id = @accountID"
            Using cmd As New MySqlCommand(str, con)
                cmd.Parameters.AddWithValue("@accountID", IDTxtBox.Text)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0 ' Return true if the ID is found in the database
            End Using
        End Using
    End Function

    Private Sub ValidateIDInput()
        Dim accountID As String = IDTxtBox.Text

        ' Check if the ID field is not empty
        If String.IsNullOrWhiteSpace(accountID) Then
            MessageBox.Show("The ID field is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If IsValidID(accountID) Then
            ' ID is valid, proceed to the next step
            allowTabSwitch = True
            TabControl1.SelectedIndex = 1 ' Move to the current password tab
        Else
            MessageBox.Show("Invalid ID. Please try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Get the provided answer from the user
        Dim providedAnswer As String = TextBox2.Text

        ' Check if the provided answer matches the one in the database
        If IsSecurityAnswerValid(IDTxtBox.Text, providedAnswer) Then
            ' Proceed to the next tab
            allowTabSwitch = True
            TabControl1.SelectedIndex = 2
        Else
            MsgBox("Security answer did not match. Please try again.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Function IsSecurityAnswerValid(accountID As String, providedAnswer As String) As Boolean
        Dim isValid As Boolean = False

        ' Database connection and query
        Using con As New MySqlConnection("Server=localhost;Database=imvbnetupdated;User ID=root;Pooling=true")
            Try
                con.Open()
                Dim query As String = "SELECT answer FROM user_account WHERE account_id = @accountID"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@accountID", accountID)

                    ' Execute the query and get the answer from the database
                    Dim dbAnswer As Object = cmd.ExecuteScalar()
                    If dbAnswer IsNot Nothing Then
                        ' Compare the provided answer with the one in the database
                        isValid = String.Equals(dbAnswer.ToString(), providedAnswer, StringComparison.OrdinalIgnoreCase)
                    End If
                End Using
            Catch ex As Exception
                MsgBox("An error occurred while validating the security answer: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
            End Try
        End Using

        Return isValid
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim newPassword As String = txtPassword.Text
        Dim confirmPassword As String = txtConfirmPassword.Text

        ' Validate the new password
        If ValidatePassword(newPassword, confirmPassword) Then
            ' Display a confirmation dialog
            Dim msgResult As DialogResult = MessageBox.Show("Are you sure you want to change the password?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If msgResult = DialogResult.Yes Then
                ' Update the password in the database
                UpdatePassword(txtEmail.Text, newPassword)
                MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close() ' Optionally close the form after successful update
            End If
        End If
    End Sub

    Private Function ValidatePassword(newPassword As String, confirmPassword As String) As Boolean
        ' Check if both textboxes are not empty
        If String.IsNullOrWhiteSpace(newPassword) OrElse String.IsNullOrWhiteSpace(confirmPassword) Then
            MessageBox.Show("Both Password and Confirm Password fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Check if passwords match
        If newPassword = confirmPassword Then
            ' Implement your password complexity validation here
            ' Return True if the password is valid, False otherwise
            Return True
        Else
            MessageBox.Show("Passwords do not match. Please try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
    End Function

    Private Sub UpdatePassword(email As String, newPassword As String)
        Try
            Using con As New MySqlConnection("Server=localhost;Database=imvbnetupdated;User ID=root;Pooling=true")
                con.Open()
                Dim str As String = "UPDATE user_account SET password = @newPassword WHERE account_name = @account_name"

                Using cmd As New MySqlCommand(str, con)
                    cmd.Parameters.AddWithValue("@newPassword", newPassword)
                    cmd.Parameters.AddWithValue("@account_name", email)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Failed to update password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private allowTabSwitch As Boolean = False
    Private Sub TabControl1_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles TabControl1.Selecting
        If allowTabSwitch Then
            e.Cancel = False
            allowTabSwitch = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Change_Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class