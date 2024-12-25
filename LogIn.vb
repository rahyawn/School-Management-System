Imports MySql.Data.MySqlClient

Public Class LogInForm
    Dim SuccessfullyLogged As Boolean = False

    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure ComboBox starts with placeholder text
        UserTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        UserTypeComboBox.Items.Clear()
        UserTypeComboBox.Items.Add("Select User Type")
        UserTypeComboBox.SelectedIndex = 0

        ' Set placeholder text for textboxes
        StudentIDTxtbox.Text = "Username or User ID"
        StudentIDTxtbox.ForeColor = Color.Gray

        PasswordLogInTxtBox.Text = "Password"
        PasswordLogInTxtBox.ForeColor = Color.Gray
        PasswordLogInTxtBox.UseSystemPasswordChar = False
    End Sub

    Private Sub UserTypeComboBox_Click(sender As Object, e As EventArgs) Handles UserTypeComboBox.Click
        ' Populate ComboBox only when clicked, if placeholder is the only item
        If UserTypeComboBox.Items.Count = 1 AndAlso UserTypeComboBox.Items(0).ToString() = "Select User Type" Then
            UserTypeComboBox.Items.Clear()
            UserTypeComboBox.Items.Add("Student")
            UserTypeComboBox.Items.Add("Professor")
            UserTypeComboBox.Items.Add("Admin")
        End If
    End Sub

    ' Placeholder logic for StudentIDTxtbox
    Private Sub StudentIDTxtbox_Enter(sender As Object, e As EventArgs) Handles StudentIDTxtbox.Enter
        If StudentIDTxtbox.Text = "Username or User ID" Then
            StudentIDTxtbox.Text = ""
            StudentIDTxtbox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub StudentIDTxtbox_Leave(sender As Object, e As EventArgs) Handles StudentIDTxtbox.Leave
        If String.IsNullOrWhiteSpace(StudentIDTxtbox.Text) Then
            StudentIDTxtbox.Text = "Username or User ID"
            StudentIDTxtbox.ForeColor = Color.Gray
        End If
    End Sub

    ' Placeholder logic for PasswordLogInTxtBox
    Private Sub PasswordLogInTxtBox_Enter(sender As Object, e As EventArgs) Handles PasswordLogInTxtBox.Enter
        If PasswordLogInTxtBox.Text = "Password" Then
            PasswordLogInTxtBox.Text = ""
            PasswordLogInTxtBox.ForeColor = Color.Black
            PasswordLogInTxtBox.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub PasswordLogInTxtBox_Leave(sender As Object, e As EventArgs) Handles PasswordLogInTxtBox.Leave
        If String.IsNullOrWhiteSpace(PasswordLogInTxtBox.Text) Then
            PasswordLogInTxtBox.Text = "Password"
            PasswordLogInTxtBox.ForeColor = Color.Gray
            PasswordLogInTxtBox.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub ShowPassBtnLogIn_Click(sender As Object, e As EventArgs) Handles ShowPassBtnLogIn.Click
        If PasswordLogInTxtBox.UseSystemPasswordChar = True AndAlso PasswordLogInTxtBox.Text <> "Password" Then
            PasswordLogInTxtBox.UseSystemPasswordChar = False
            ShowPassBtnLogIn.Text = "Hide"
        ElseIf PasswordLogInTxtBox.Text <> "Password" Then
            PasswordLogInTxtBox.UseSystemPasswordChar = True
            ShowPassBtnLogIn.Text = "Show"
        End If
    End Sub

    Private Sub CloseBtnLogIn_Click(sender As Object, e As EventArgs) Handles CloseBtnLogIn.Click
        Dim msg As DialogResult = MessageBox.Show("Do you want to exit?", "Warning", MessageBoxButtons.YesNo)
        If msg.Equals(DialogResult.Yes) Then
            Me.Close()
        End If
    End Sub

    Private Sub LogInBtn_Click(sender As Object, e As EventArgs) Handles LogInBtn.Click
        Dim EnteredStudentID As String = StudentIDTxtbox.Text.Trim()
        Dim EnteredPassword As String = PasswordLogInTxtBox.Text.Trim()

        ' Ensure a user type is selected
        If UserTypeComboBox.SelectedItem Is Nothing OrElse UserTypeComboBox.SelectedItem.ToString() = "Select User Type" Then
            MessageBox.Show("Please select a user type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim SelectedUserType As String = UserTypeComboBox.SelectedItem.ToString().ToLower()

        ' Check if fields are filled
        If EnteredStudentID = "Username or User ID" OrElse EnteredPassword = "Password" Then
            MessageBox.Show("Please enter both Username and Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Validate against database
        Using con As New MySqlConnection("Server=localhost;Database=imvbnet_proj;User ID=root;Pooling=true")
            con.Open()
            Dim query As String = "SELECT user_type, student_id, professor_id 
                                  FROM user_account 
                                  WHERE LOWER(account_id) = LOWER(@username) AND password = @password"
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@username", EnteredStudentID)
                cmd.Parameters.AddWithValue("@password", EnteredPassword)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim userType As String = reader("user_type").ToString().ToLower()
                        Dim loggedInStudentID As String = If(reader("student_id") IsNot DBNull.Value, reader("student_id").ToString(), String.Empty)
                        Dim loggedInProfessorID As String = If(reader("professor_id") IsNot DBNull.Value, reader("professor_id").ToString(), String.Empty)

                        If userType = SelectedUserType Then
                            MessageBox.Show("Login Successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            LoadUserForm(userType, If(userType = "student", loggedInStudentID, loggedInProfessorID))
                        Else
                            MessageBox.Show("Invalid login attempt. Please select the correct user type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("Invalid Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub LoadUserForm(userType As String, userID As String)
        Select Case userType
            Case "student"
                Dim studentAccountForm As New PROFILESTUD(userID)
                Me.Hide()
                MDI.Hide()
                studentAccountForm.Show()
            Case "professor"
                Dim accountForm As New ProfAccountForm()
                Me.Hide()
                MDI.Hide()
                accountForm.Show()
            Case "admin"
                Dim adminForm As New ADMIN()
                Me.Hide()
                MDI.Hide()
                adminForm.Show()
            Case Else
                MessageBox.Show("Invalid user type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim recoveryWindow As New RecoveryAcc()
        recoveryWindow.MdiParent = Me
        recoveryWindow.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As EventArgs)
    End Sub

    Private Sub LogInSystemPanel_Paint(sender As Object, e As PaintEventArgs) Handles LogInSystemPanel.Paint
    End Sub
End Class