Imports MySql.Data.MySqlClient

Public Class UPDATE_DELETE
    Private connectionString As String = "server=localhost;user=root;password=;database=imvbnet_proj;"
    Private connection As MySqlConnection
    Private dataAdapter As MySqlDataAdapter
    Private dataTable As New DataTable()

    ' New variables to track edit and delete states
    Private isEditMode As Boolean = False
    Private isDeleteMode As Boolean = False
    Private originalStudentData As New Dictionary(Of String, String)

    Private Sub UPDATE_DELETE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Disable editing controls initially
        DisableEditControls()
    End Sub

    Private Sub DisableEditControls()
        ' Disable text boxes and buttons
        txtLastName.ReadOnly = True
        txtFirstName.ReadOnly = True
        txtMiddleInitial.ReadOnly = True
        txtSuffix.ReadOnly = True
        cmbSectionCodee.Enabled = False

        ' Hide/Disable specific buttons
        btnSave.Enabled = False
        btnCancel.Enabled = False

        ' Show main action buttons
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Sub EnableEditControls()
        ' Enable text boxes and controls
        txtLastName.ReadOnly = False
        txtFirstName.ReadOnly = False
        txtMiddleInitial.ReadOnly = False
        txtSuffix.ReadOnly = False
        cmbSectionCodee.Enabled = True

        ' Show save and cancel buttons
        btnSave.Enabled = True
        btnCancel.Enabled = True

        ' Disable main action buttons during editing
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Public Sub LoadStudentData(studentId As String)
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT * FROM student WHERE student_id = @studentId"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@studentId", studentId)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    ' Store original data for potential cancel
                    originalStudentData.Clear()
                    originalStudentData("student_id") = reader("student_id").ToString()
                    originalStudentData("last_name") = reader("last_name").ToString()
                    originalStudentData("first_name") = reader("first_name").ToString()
                    originalStudentData("middle_initial") = reader("middle_initial").ToString()
                    originalStudentData("suffix") = reader("suffix").ToString()

                    txtStudentID.Text = reader("student_id").ToString()
                    txtLastName.Text = reader("last_name").ToString()
                    txtFirstName.Text = reader("first_name").ToString()
                    txtMiddleInitial.Text = reader("middle_initial").ToString()
                    txtSuffix.Text = reader("suffix").ToString()
                    cmbSectionCodee.SelectedItem = GetSectionCodeForStudent(studentId)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading student data: " & ex.Message)
        End Try
    End Sub

    Private Function GetSectionCodeForStudent(studentId As String) As String
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT section_code FROM section_assign WHERE student_id = @studentId"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@studentId", studentId)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Return reader("section_code").ToString()
                Else
                    Return ""
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error getting section code: " & ex.Message)
            Return ""
        End Try
    End Function

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrEmpty(txtStudentID.Text) Then
            MessageBox.Show("Please enter a Student ID")
            Return
        End If

        ' Enter edit mode
        isEditMode = True
        isDeleteMode = False
        EnableEditControls()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrEmpty(txtStudentID.Text) Then
            MessageBox.Show("Please enter a Student ID")
            Return
        End If

        ' Enter delete mode
        isDeleteMode = True
        isEditMode = False

        Dim confirmDelete = MessageBox.Show("Are you sure you want to mark this student for deletion?" &
                                            vbCrLf & "Click 'Save' to confirm or 'Cancel' to abort.",
                                            "Confirm Delete",
                                            MessageBoxButtons.OKCancel,
                                            MessageBoxIcon.Warning)

        If confirmDelete = DialogResult.OK Then
            EnableEditControls()
        Else
            isDeleteMode = False
            DisableEditControls()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If isEditMode Then
            UpdateStudentData()
            UpdateSectionCode(txtStudentID.Text, cmbSectionCodee.SelectedItem.ToString())
        ElseIf isDeleteMode Then
            DeleteStudentData()
        End If
    End Sub


    Private Sub UpdateStudentData()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "UPDATE student SET last_name = @lastName, first_name = @firstName, " &
                                     "middle_initial = @middleInitial, suffix = @suffix " &
                                     "WHERE student_id = @studentId"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@lastName", txtLastName.Text)
                cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text)
                cmd.Parameters.AddWithValue("@middleInitial", txtMiddleInitial.Text)
                cmd.Parameters.AddWithValue("@suffix", txtSuffix.Text)
                cmd.Parameters.AddWithValue("@studentId", txtStudentID.Text)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Student data updated successfully.")

                    ' Refresh DataGridView (you'll need to implement this method)
                    RefreshDataGridView()

                    isEditMode = False
                    DisableEditControls()
                Else
                    MessageBox.Show("No changes were made.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating student data: " & ex.Message)
        End Try
    End Sub

    Private Sub DeleteStudentData()
        If HasAssociatedRecords(txtStudentID.Text) Then
            Dim confirmDelete = MessageBox.Show("This student has associated records in the database. " &
                                            "All records for this student will be permanently deleted. " &
                                            "Are you sure you want to proceed?",
                                            "Confirm Student Record Deletion",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning)

            If confirmDelete = DialogResult.Yes Then
                Try
                    Using conn As New MySqlConnection(connectionString)
                        conn.Open()
                        ' Disable foreign key checks to allow delete
                        Dim cmdDisableFK As New MySqlCommand("SET FOREIGN_KEY_CHECKS = 0;", conn)
                        cmdDisableFK.ExecuteNonQuery()

                        ' Delete records from child tables first
                        DeleteChildTableRecords(conn, txtStudentID.Text)

                        ' Finally delete the student record
                        Dim queryDeleteStudent As String = "DELETE FROM student WHERE student_id = @studentId"
                        Dim cmdDeleteStudent As New MySqlCommand(queryDeleteStudent, conn)
                        cmdDeleteStudent.Parameters.AddWithValue("@studentId", txtStudentID.Text)

                        Dim rowsAffected As Integer = cmdDeleteStudent.ExecuteNonQuery()

                        ' Re-enable foreign key checks
                        Dim cmdEnableFK As New MySqlCommand("SET FOREIGN_KEY_CHECKS = 1;", conn)
                        cmdEnableFK.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Student records deleted successfully.")

                            ' Refresh DataGridView
                            RefreshDataGridView()

                            ' Clear the form
                            ClearForm()

                            ' Reset modes
                            isDeleteMode = False
                            DisableEditControls()
                        Else
                            MessageBox.Show("No student data was found to delete.")
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error during student record deletion: " & ex.Message)
                End Try
            End If
        Else
            ' No associated records, proceed with simple delete
            DeleteSimpleStudent()
        End If
    End Sub

    Private Function HasAssociatedRecords(studentId As String) As Boolean
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' Check child tables for associated records
                Dim checkQueries As String() = {
                "SELECT COUNT(*) FROM midterm WHERE student_id = @studentId",
                "SELECT COUNT(*) FROM midterm_gw WHERE student_id = @studentId",
                "SELECT COUNT(*) FROM section_assign WHERE student_id = @studentId"
            }

                For Each query In checkQueries
                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@studentId", studentId)

                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If count > 0 Then
                        Return True
                    End If
                Next
            End Using

            Return False
        Catch ex As Exception
            MessageBox.Show("Error checking associated records: " & ex.Message)
            Return False
        End Try
    End Function

    Private Sub DeleteChildTableRecords(conn As MySqlConnection, studentId As String)
        Dim deleteQueries As String() = {
        "DELETE FROM midterm WHERE student_id = @studentId",
        "DELETE FROM midterm_gw WHERE student_id = @studentId",
        "DELETE FROM section_assign WHERE student_id = @studentId"
    }

        For Each query In deleteQueries
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@studentId", studentId)
            cmd.ExecuteNonQuery()
        Next
    End Sub

    Private Sub DeleteSimpleStudent()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "DELETE FROM student WHERE student_id = @studentId"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@studentId", txtStudentID.Text)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Student deleted successfully.")

                    ' Refresh DataGridView
                    RefreshDataGridView()

                    ' Clear the form
                    ClearForm()

                    ' Reset modes
                    isDeleteMode = False
                    DisableEditControls()
                Else
                    MessageBox.Show("No student data was found to delete.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting student data: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If isEditMode Then
            ' Restore original data
            RestoreOriginalData()
        End If

        isEditMode = False
        isDeleteMode = False
        DisableEditControls()
    End Sub

    Private Sub RestoreOriginalData()
        If originalStudentData.Count > 0 Then
            txtLastName.Text = originalStudentData("last_name")
            txtFirstName.Text = originalStudentData("first_name")
            txtMiddleInitial.Text = originalStudentData("middle_initial")
            txtSuffix.Text = originalStudentData("suffix")
        End If
    End Sub

    Private Sub ClearForm()
        txtStudentID.Clear()
        txtLastName.Clear()
        txtFirstName.Clear()
        txtMiddleInitial.Clear()
        txtSuffix.Clear()
        cmbSectionCodee.SelectedIndex = -1
    End Sub

    Private Sub RefreshDataGridView()
        ' This method should be implemented to refresh the DataGridView
        ' You'll need to add the code to reload the data into the DataGridView
        ' For example:
        ' dataGridViewStudents.DataSource = GetUpdatedStudentData()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub UpdateSectionCode(studentId As String, newSectionCode As String)
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                ' Disable foreign key checks to update section_code
                Dim disableFK As String = "SET FOREIGN_KEY_CHECKS = 0;"
                Dim cmdDisableFK As New MySqlCommand(disableFK, conn)
                cmdDisableFK.ExecuteNonQuery()

                ' Update the section_code
                Dim query As String = "UPDATE section_assign SET section_code = @newSectionCode WHERE student_id = @studentId"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@newSectionCode", newSectionCode)
                cmd.Parameters.AddWithValue("@studentId", studentId)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Section code updated successfully.")

                    ' Refresh DataGridView (you'll need to implement this method)
                    RefreshDataGridView()

                Else
                    MessageBox.Show("No section code was updated.")
                End If

                ' Enable foreign key checks again
                Dim enableFK As String = "SET FOREIGN_KEY_CHECKS = 1;"
                Dim cmdEnableFK As New MySqlCommand(enableFK, conn)
                cmdEnableFK.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating section code: " & ex.Message)
        End Try
    End Sub

End Class