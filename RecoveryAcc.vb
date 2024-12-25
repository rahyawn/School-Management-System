Imports System.Configuration
Imports System.IO.Pipelines
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common
Imports Windows.Win32.System

Public Class RecoveryAcc
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

    Private Sub accname_Click(sender As Object, e As EventArgs) Handles btn_step1proceed.Click
        ValidateEmailInput()
    End Sub
    Private Function DoesUsernameMatchID(accountID As String, email As String) As Boolean
        Using con As New MySqlConnection("Server=localhost;Database=imvbnet_proj;User ID=root;Pooling=true")
            con.Open()
            Dim query As String = "SELECT COUNT(*) FROM user_account WHERE account_id = @accountID AND account_name = @accountName"
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@accountID", accountID)
                cmd.Parameters.AddWithValue("@accountName", email)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0 ' Return true if the username/email matches the ID
            End Using
        End Using
    End Function


    Private Function IsValidEmail(email As String) As Boolean
        Dim emailPattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        Return System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern)
    End Function

    Private Sub ValidateEmailInput()
        Dim accountID As String = IDTxtBox.Text
        Dim email As String = txtEmail.Text

        ' Check if both fields are not empty
        If String.IsNullOrWhiteSpace(accountID) OrElse String.IsNullOrWhiteSpace(email) Then
            MessageBox.Show("Both ID and Email fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate the IDs and match username/email
        If IsValidID(accountID) Then
            If DoesUsernameMatchID(accountID, email) Then
                ' Both are valid, proceed to the next step
                allowTabSwitch = True
                TabControl1.SelectedIndex = 2 ' Move to the email validation tab
            Else
                MessageBox.Show("Your username/email does not match your ID. Please try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Invalid ID. Please try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    ' Database interaction methods (implement these according to your database structure)
    Private Function CheckEmailInDatabase(ByVal email As String) As Boolean
        Using con As New MySqlConnection("Server=localhost;Database=imvbnetupdated;User ID=root;Pooling=true")
            con.Open()
            Dim str As String = "SELECT COUNT(*) FROM user_account WHERE account_name = @email"
            Using cmd As New MySqlCommand(str, con)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0 ' Return true if the email is found in the database
            End Using
        End Using
    End Function

    Private Function VerifySecurityAnswers(ByVal email As String, ByVal answers As Dictionary(Of Integer, String)) As Boolean
        ' TODO: Implement database verification of security answers
        Return True
    End Function

    Private Function SaveNewPassword(ByVal email As String, ByVal password As String) As Boolean
        ' TODO: Implement password saving to database
        Return True
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim password As String = txtPassword.Text
        Dim confirmPassword As String = txtConfirmPassword.Text

        ' Check if both textboxes are not empty
        If String.IsNullOrWhiteSpace(password) OrElse String.IsNullOrWhiteSpace(confirmPassword) Then
            MessageBox.Show("Both Password and Confirm Password fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if passwords match
        If password = confirmPassword Then
            Try
                Using con As New MySqlConnection("Server=localhost;Database=imvbnetupdated;User ID=root;Pooling=true")
                    con.Open()
                    Dim str As String = "UPDATE user_account SET password = @newPassword WHERE account_name = @account_name"

                    Using cmd As New MySqlCommand(str, con)
                        cmd.Parameters.AddWithValue("@newPassword", password)
                        cmd.Parameters.AddWithValue("@account_name", txtEmail.Text)

                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Close() ' Optionally close the form after successful update
                        Else
                            MessageBox.Show("Failed to update password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Passwords do not match. Please try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub
    Private allowTabSwitch As Boolean = False
    Private Sub TabControl1_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles TabControl1.Selecting
        ' Add your condition here
        ' For example, to prevent tab switching based on a condition:
        ' If Not ConditionMet Then
        '     e.Cancel = True
        ' End If

        ' Example: Always prevent switching
        If allowTabSwitch Then
            e.Cancel = False
            allowTabSwitch = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Get the user input
        Dim providedAnswer As String = TextBox2.Text

        ' Check if the provided answer matches the one in the database
        If IsSecurityAnswerValid(IDTxtBox.Text, providedAnswer) Then
            allowTabSwitch = True
            TabControl1.SelectedIndex = 3 ' Proceed to the next tab
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        allowTabSwitch = True
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        allowTabSwitch = True
        TabControl1.SelectedIndex = 2
    End Sub

    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected
        If TabControl1.SelectedIndex = 2 Then
            Dim accountID As String = IDTxtBox.Text ' Assume this is the logged-in user's account ID
            Dim questionNo As Integer = 0
            Dim securityQuestion As String = ""

            Using con As New MySqlConnection("Server=localhost;Database=imvbnetupdated;User ID=root;Pooling=true")
                Try
                    con.Open()

                    ' Step 1: Fetch question_no from user_account table
                    Dim query1 As String = "SELECT question_no FROM user_account WHERE account_id = @accountID"
                    Using cmd1 As New MySqlCommand(query1, con)
                        cmd1.Parameters.AddWithValue("@accountID", accountID)
                        Dim result As Object = cmd1.ExecuteScalar()
                        If result IsNot Nothing Then
                            questionNo = Convert.ToInt32(result)
                        Else
                            MessageBox.Show("User's security question not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return
                        End If
                    End Using

                    ' Step 2: Fetch the question text from question table
                    Dim query2 As String = "SELECT questions FROM question WHERE question_no = @questionNo"
                    Using cmd2 As New MySqlCommand(query2, con)
                        cmd2.Parameters.AddWithValue("@questionNo", questionNo)
                        Dim result As Object = cmd2.ExecuteScalar()
                        If result IsNot Nothing Then
                            securityQuestion = result.ToString()
                        Else
                            MessageBox.Show("Security question not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return
                        End If
                    End Using

                    ' Step 3: Display the fetched question in the label
                    question.Text = securityQuestion

                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End If
    End Sub


    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim msgExit As DialogResult = MessageBox.Show("Do you want to EXIT?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If msgExit.Equals(DialogResult.Yes) Then
            Me.Close()
        End If
    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ValidateIDInput()
        Dim accountID As String = IDTxtBox.Text


        ' Check if both ID fields are not empty
        If String.IsNullOrWhiteSpace(accountID) OrElse String.IsNullOrWhiteSpace(accountID) Then
            MessageBox.Show("Both Student ID and Professor ID fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate the IDs against the database
        If IsValidID(accountID) Then
            ' IDs are valid, proceed to the next step
            allowTabSwitch = True
            TabControl1.SelectedIndex = 1 ' Move to the email validation tab
        Else
            MessageBox.Show("Invalid Student ID or Professor ID. Please try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function IsValidID(accountID As String) As Boolean
        ' Implement your own logic to validate the Student ID and Professor ID
        ' against your database
        Using con As New MySqlConnection("Server=localhost;Database=imvbnetupdated;User ID=root;Pooling=true")
            con.Open()
            Dim str As String = "SELECT COUNT(*) FROM user_account WHERE account_id = @accountID"
            Using cmd As New MySqlCommand(str, con)
                cmd.Parameters.AddWithValue("@accountID", IDTxtBox.Text)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0 ' Return true if both IDs are found in the database
            End Using
        End Using
    End Function

    Private Sub proceedIDBtn_Click(sender As Object, e As EventArgs) Handles proceedIDBtn.Click
        ValidateIDInput()
    End Sub

    Private Sub question_Click(sender As Object, e As EventArgs) Handles question.Click

    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click

    End Sub
End Class