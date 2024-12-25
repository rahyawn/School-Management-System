Imports MySql.Data.MySqlClient

Public Class NEWITEM
    Private connectionString As String = "server=localhost;user=root;password=;database=imvbnet_proj;port=3306;"
    Private connection As MySqlConnection
    Private dataAdapter As MySqlDataAdapter
    Private dataTable As New DataTable()

    ' Track edit and delete states
    Private isEditMode As Boolean = False
    Private isDeleteMode As Boolean = False
    Private originalSubjectData As New Dictionary(Of String, String)

    ' Form result to communicate back to the parent form
    Public DialogResult1 As DialogResult = DialogResult.Cancel

    Private Sub NEWITEM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisableEditControls()
        PopulateComboBoxes()
    End Sub

    Private Sub DisableEditControls()
        ' Disable text boxes and comboboxes
        txtSubjectCode.ReadOnly = True
        txtSubjectName.ReadOnly = True
        txtProfessorID.ReadOnly = True
        cmbSectionCode.Enabled = False
        cmbDepartmentCode.Enabled = False
        cmbProgramCode.Enabled = False
        cmbSemester.Enabled = False
        txtDay.ReadOnly = True
        txtTime.ReadOnly = True

        ' Hide/Disable specific buttons
        btnSave.Enabled = False
        btnCancel.Enabled = False

        ' Show main action buttons
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Sub EnableEditControls()
        ' Enable text boxes and comboboxes except subject code
        txtSubjectCode.ReadOnly = True  ' Keep subject code readonly
        txtSubjectName.ReadOnly = False
        txtProfessorID.ReadOnly = False
        cmbSectionCode.Enabled = True
        cmbDepartmentCode.Enabled = True
        cmbProgramCode.Enabled = True
        cmbSemester.Enabled = True
        txtDay.ReadOnly = False
        txtTime.ReadOnly = False

        ' Show save and cancel buttons
        btnSave.Enabled = True
        btnCancel.Enabled = True

        ' Disable main action buttons during editing
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Public Sub LoadSubjectData(subjectCode As String)
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                ' Modified query to get program_code and semester from subject table
                Dim query As String = "SELECT s.subject_code, s.subject_name, s.program_code, s.semester, " &
                                    "sa.professor_id, sa.section_code, sa.dept_code, sa.day, sa.time " &
                                    "FROM subject s " &
                                    "LEFT JOIN subject_assign sa ON s.subject_code = sa.subject_code " &
                                    "WHERE s.subject_code = @subjectCode"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@subjectCode", subjectCode)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    ' Store original data
                    originalSubjectData.Clear()
                    originalSubjectData("subject_code") = reader("subject_code").ToString()
                    originalSubjectData("subject_name") = reader("subject_name").ToString()
                    originalSubjectData("professor_id") = reader("professor_id").ToString()
                    originalSubjectData("section_code") = reader("section_code").ToString()
                    originalSubjectData("dept_code") = reader("dept_code").ToString()
                    originalSubjectData("day") = reader("day").ToString()
                    originalSubjectData("time") = reader("time").ToString()
                    originalSubjectData("program_code") = reader("program_code").ToString()
                    originalSubjectData("semester") = reader("semester").ToString()

                    ' Display data in controls
                    txtSubjectCode.Text = reader("subject_code").ToString()
                    txtSubjectName.Text = reader("subject_name").ToString()
                    txtProfessorID.Text = reader("professor_id").ToString()
                    cmbSectionCode.Text = reader("section_code").ToString()
                    cmbDepartmentCode.Text = reader("dept_code").ToString()
                    txtDay.Text = reader("day").ToString()
                    txtTime.Text = reader("time").ToString()
                    cmbProgramCode.Text = reader("program_code").ToString()
                    cmbSemester.Text = reader("semester").ToString()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading subject data: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrEmpty(txtSubjectCode.Text) Then
            MessageBox.Show("Please select a subject first")
            Return
        End If

        isEditMode = True
        isDeleteMode = False
        EnableEditControls()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrEmpty(txtSubjectCode.Text) Then
            MessageBox.Show("Please select a subject first")
            Return
        End If
        isDeleteMode = True
        isEditMode = False
        Dim confirmDelete = MessageBox.Show("Are you sure you want to delete this subject?" &
                                       Environment.NewLine & "This will remove all related assignments." &
                                       Environment.NewLine & "Click 'OK' to confirm or 'Cancel' to abort.",
                                       "Confirm Delete",
                                       MessageBoxButtons.OKCancel,
                                       MessageBoxIcon.Warning)
        If confirmDelete = DialogResult.OK Then
            DeleteSubjectData()
        Else
            isDeleteMode = False
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If ValidateInput() = False Then
            Return
        End If

        If isEditMode Then
            UpdateSubjectData()
        End If
    End Sub

    Private Function ValidateInput() As Boolean
        If String.IsNullOrWhiteSpace(txtSubjectName.Text) Then
            MessageBox.Show("Subject Name is required")
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtProfessorID.Text) Then
            MessageBox.Show("Professor ID is required")
            Return False
        End If

        If String.IsNullOrWhiteSpace(cmbProgramCode.Text) Then
            MessageBox.Show("Program Code is required")
            Return False
        End If

        If String.IsNullOrWhiteSpace(cmbSemester.Text) Then
            MessageBox.Show("Semester is required")
            Return False
        End If

        Return True
    End Function

    Private Sub UpdateSubjectData()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Using transaction As MySqlTransaction = conn.BeginTransaction()
                    Try
                        ' Update subject table
                        Dim subjectQuery As String = "UPDATE subject SET " &
                                               "subject_name = @subjectName, " &
                                               "program_code = @programCode, " &
                                               "semester = @semester " &
                                               "WHERE subject_code = @subjectCode"
                        Dim subjectCmd As New MySqlCommand(subjectQuery, conn, transaction)
                        With subjectCmd.Parameters
                            .AddWithValue("@subjectName", txtSubjectName.Text)
                            .AddWithValue("@programCode", cmbProgramCode.Text)
                            .AddWithValue("@semester", cmbSemester.Text)
                            .AddWithValue("@subjectCode", txtSubjectCode.Text)
                        End With

                        Dim subjectRowsAffected As Integer = subjectCmd.ExecuteNonQuery()

                        ' Update subject_assign table
                        Dim assignQuery As String = "UPDATE subject_assign SET " &
                                              "professor_id = @professorId, " &
                                              "section_code = @sectionCode, " &
                                              "dept_code = @deptCode, " &
                                              "day = @day, " &
                                              "time = @time " &
                                              "WHERE subject_code = @subjectCode"
                        Dim assignCmd As New MySqlCommand(assignQuery, conn, transaction)
                        With assignCmd.Parameters
                            .AddWithValue("@professorId", txtProfessorID.Text)
                            .AddWithValue("@sectionCode", cmbSectionCode.Text)
                            .AddWithValue("@deptCode", cmbDepartmentCode.Text)
                            .AddWithValue("@day", txtDay.Text)
                            .AddWithValue("@time", txtTime.Text)
                            .AddWithValue("@subjectCode", txtSubjectCode.Text)
                        End With

                        Dim assignRowsAffected As Integer = assignCmd.ExecuteNonQuery()

                        ' Check if any changes were made
                        If subjectRowsAffected > 0 OrElse assignRowsAffected > 0 Then
                            transaction.Commit()
                            MessageBox.Show("Subject data updated successfully")
                            DialogResult = DialogResult.OK
                            isEditMode = False
                            DisableEditControls()
                        Else
                            transaction.Rollback()
                            MessageBox.Show("No changes were made.")
                        End If

                    Catch ex As Exception
                        transaction.Rollback()
                        Throw
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating subject: " & ex.Message)
        End Try
    End Sub
    Private Sub DeleteSubjectData()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Using transaction As MySqlTransaction = conn.BeginTransaction()
                    Try
                        ' Delete from subject_assign first
                        Dim assignQuery As String = "DELETE FROM subject_assign WHERE subject_code = @subjectCode"
                        Dim assignCmd As New MySqlCommand(assignQuery, conn, transaction)
                        assignCmd.Parameters.AddWithValue("@subjectCode", txtSubjectCode.Text)
                        assignCmd.ExecuteNonQuery()

                        ' Then delete from subject table
                        Dim subjectQuery As String = "DELETE FROM subject WHERE subject_code = @subjectCode"
                        Dim subjectCmd As New MySqlCommand(subjectQuery, conn, transaction)
                        subjectCmd.Parameters.AddWithValue("@subjectCode", txtSubjectCode.Text)
                        subjectCmd.ExecuteNonQuery()

                        transaction.Commit()
                        MessageBox.Show("Subject deleted successfully")

                        DialogResult = DialogResult.OK
                        isDeleteMode = False
                        Me.Close()
                    Catch ex As Exception
                        transaction.Rollback()
                        Throw
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting subject: " & ex.Message)
        End Try
    End Sub

    Private Sub PopulateComboBoxes()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' Populate Section Code ComboBox
                Dim sectionQuery As String = "SELECT DISTINCT section_code FROM section ORDER BY section_code"
                Using cmd As New MySqlCommand(sectionQuery, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        cmbSectionCode.Items.Clear()
                        While reader.Read()
                            cmbSectionCode.Items.Add(reader("section_code").ToString())
                        End While
                    End Using
                End Using

                ' Populate Department Code ComboBox
                Dim departmentQuery As String = "SELECT DISTINCT dept_code FROM department ORDER BY dept_code"
                Using cmd As New MySqlCommand(departmentQuery, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        cmbDepartmentCode.Items.Clear()
                        While reader.Read()
                            cmbDepartmentCode.Items.Add(reader("dept_code").ToString())
                        End While
                    End Using
                End Using

                ' Populate Program Code ComboBox
                Dim programQuery As String = "SELECT DISTINCT program_code FROM program ORDER BY program_code"
                Using cmd As New MySqlCommand(programQuery, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        cmbProgramCode.Items.Clear()
                        While reader.Read()
                            cmbProgramCode.Items.Add(reader("program_code").ToString())
                        End While
                    End Using
                End Using

                ' Populate Semester ComboBox
                cmbSemester.Items.Clear()
                cmbSemester.Items.AddRange({"1st", "2nd", "Summer"})
            End Using
        Catch ex As Exception
            MessageBox.Show("Error populating combo boxes: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If isEditMode Then
            RestoreOriginalData()
        End If

        isEditMode = False
        isDeleteMode = False
        DisableEditControls()
    End Sub

    Private Sub RestoreOriginalData()
        If originalSubjectData.Count > 0 Then
            txtSubjectCode.Text = originalSubjectData("subject_code")
            txtSubjectName.Text = originalSubjectData("subject_name")
            txtProfessorID.Text = originalSubjectData("professor_id")
            cmbSectionCode.Text = originalSubjectData("section_code")
            cmbDepartmentCode.Text = originalSubjectData("dept_code")
            txtDay.Text = originalSubjectData("day")
            txtTime.Text = originalSubjectData("time")
            cmbProgramCode.Text = originalSubjectData("program_code")
            cmbSemester.Text = originalSubjectData("semester")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class