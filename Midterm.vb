Imports System.Data
Imports System.Data.Common
Imports MySql.Data.MySqlClient
Public Class MidtermForm
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable
    Dim da As New MySqlDataAdapter
    Dim str, result As String
    Dim x As Integer
    Dim con As New MySqlConnection("server=localhost; user=root; database=imvbnet_proj")
    Dim dv As DataView
    Private Sub Midterm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AttendanceTxtBox.Enabled = False
        MidtermPanel.Visible = False
        GradeEquivalentPanel.Visible = False
        MidtermGradeBorderPanel.Visible = False
        MidtermGradeLbl.Visible = False
        ClearAllBtn.Visible = False
        ComputeBtn.Visible = False
        SaveBtn.Visible = False
        patongPanel.Visible = True

        ' Add this line to load the ComboBoxes
        LoadComboBoxes()
    End Sub

    Private Sub LoadComboBoxes()
        Try
            Using con As New MySqlConnection("server=localhost; user=root; database=imvbnet_proj")
                con.Open()

                ' Load Sections
                Dim sectionQuery As String = "SELECT DISTINCT section_code FROM section_assign ORDER BY section_code"
                Using cmd As New MySqlCommand(sectionQuery, con)
                    cbSEC.Items.Clear()
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            cbSEC.Items.Add(reader("section_code").ToString())
                        End While
                    End Using
                End Using

                ' Load Subjects
                Dim subjectQuery As String = "SELECT DISTINCT subject_name FROM Subject ORDER BY subject_name"
                Using cmd As New MySqlCommand(subjectQuery, con)
                    cbSUB.Items.Clear()
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            cbSUB.Items.Add(reader("subject_name").ToString())
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading ComboBox data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub cbSEC3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSEC.SelectedIndexChanged
        If cbSEC.SelectedIndex = -1 Then Exit Sub

        Try
            dt.Clear()
            Using con As New MySqlConnection("server=localhost; user=root; database=imvbnet_proj")
                con.Open()
                Dim filterQuery As String = "SELECT
                SA.student_id AS 'Student ID',
                CONCAT(S.last_name, ', ', S.first_name, ' ', S.middle_initial, ' ', S.suffix) AS 'Name',
                SBA.subject_code AS 'Subject Code',
                SB.subject_name AS 'Subject Name', 
                P.professor_id AS 'Professor ID',
                CONCAT(P.last_name, ', ', P.first_name, ' ', P.middle_initial, ' ', P.suffix) AS 'Professor Name',
                SA.section_code AS 'Section'
            FROM section_assign SA
            JOIN Student S ON S.student_id = SA.student_id
            JOIN subject_assign SBA ON SA.section_code = SBA.section_code
            JOIN Subject SB ON SBA.subject_code = SB.subject_code
            JOIN Professor P ON P.professor_id = SBA.professor_id
            WHERE SA.section_code = @section"

                Using cmd As New MySqlCommand(filterQuery, con)
                    cmd.Parameters.AddWithValue("@section", cbSEC.SelectedItem.ToString())
                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using
            dgvMIDTERM.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Error filtering by section: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbSUB3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSUB.SelectedIndexChanged
        If cbSUB.SelectedIndex = -1 Then Exit Sub

        Try
            dt.Clear()
            Using con As New MySqlConnection("server=localhost; user=root; database=imvbnet_proj")
                con.Open()
                Dim filterQuery As String = "SELECT
                SA.student_id AS 'Student ID',
                CONCAT(S.last_name, ', ', S.first_name, ' ', S.middle_initial, ' ', S.suffix) AS 'Name',
                SBA.subject_code AS 'Subject Code',
                SB.subject_name AS 'Subject Name', 
                P.professor_id AS 'Professor ID',
                CONCAT(P.last_name, ', ', P.first_name, ' ', P.middle_initial, ' ', P.suffix) AS 'Professor Name',
                SA.section_code AS 'Section'
            FROM section_assign SA
            JOIN Student S ON S.student_id = SA.student_id
            JOIN subject_assign SBA ON SA.section_code = SBA.section_code
            JOIN Subject SB ON SBA.subject_code = SB.subject_code
            JOIN Professor P ON P.professor_id = SBA.professor_id
            WHERE SB.subject_name = @subject"

                Using cmd As New MySqlCommand(filterQuery, con)
                    cmd.Parameters.AddWithValue("@subject", cbSUB.SelectedItem.ToString())
                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using
            dgvMIDTERM.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Error filtering by subject: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub FilterDataGridView()
        Try
            dt.Clear()
            Using con As New MySqlConnection("server=localhost; user=root; database=imvbnet_proj")
                con.Open()
                Dim filterQuery As String = "SELECT
                SA.student_id AS 'Student ID',
                CONCAT(S.last_name, ', ', S.first_name, ' ', S.middle_initial, ' ', S.suffix) AS 'Name',
                SBA.subject_code AS 'Subject Code',
                SB.subject_name AS 'Subject Name', 
                P.professor_id AS 'Professor ID',
                CONCAT(P.last_name, ', ', P.first_name, ' ', P.middle_initial, ' ', P.suffix) AS 'Professor Name',
                SA.section_code AS 'Section'
            FROM section_assign SA
            JOIN Student S ON S.student_id = SA.student_id
            JOIN subject_assign SBA ON SA.section_code = SBA.section_code
            JOIN Subject SB ON SBA.subject_code = SB.subject_code
            JOIN Professor P ON P.professor_id = SBA.professor_id
            WHERE 1=1"

                ' Add parameters based on selections
                If cbSEC.SelectedIndex <> -1 Then
                    filterQuery &= " AND SA.section_code = @section"
                End If
                If cbSUB.SelectedIndex <> -1 Then
                    filterQuery &= " AND SB.subject_name = @subject"
                End If

                Using cmd As New MySqlCommand(filterQuery, con)
                    ' Add parameter values if selections were made
                    If cbSEC.SelectedIndex <> -1 Then
                        cmd.Parameters.AddWithValue("@section", cbSEC.SelectedItem.ToString())
                    End If
                    If cbSUB.SelectedIndex <> -1 Then
                        cmd.Parameters.AddWithValue("@subject", cbSUB.SelectedItem.ToString())
                    End If

                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using
            dgvMIDTERM.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Error filtering data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub btnPopulate_Click(sender As Object, e As EventArgs) Handles btnPopulate.Click
        ' Validate input
        If String.IsNullOrWhiteSpace(cbSEC.Text) Then
            MessageBox.Show("Please select a Section.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbSEC.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(cbSUB.Text) Then
            MessageBox.Show("Please select a Subject.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbSUB.Focus()
            Exit Sub
        End If

        pop()
    End Sub
    Private Sub search_Click(sender As Object, e As EventArgs) Handles btnSEARC.Click
        FilterDataGridView()

    End Sub

    Private Sub resetBtn_Click(sender As Object, e As EventArgs) Handles resetBtn.Click
        StudentIDTxtBox.Text = ""
        StudentNameTxtBox.Text = ""
        cbSEC.SelectedIndex = -1
        cbSUB.SelectedIndex = -1
        FilterDataGridView()
    End Sub


    ' Ensure this is declared at the class level
    Private queryString As String = "SELECT
        SA.student_id AS 'Student ID',
        CONCAT(S.last_name, ', ', S.first_name, ' ', S.middle_initial, ' ', S.suffix) AS 'Name',
        SBA.subject_code AS 'Subject Code',
        SB.subject_name AS 'Subject Name', 
        P.professor_id AS 'Professor ID',
        CONCAT(P.last_name, ', ', P.first_name, ' ', P.middle_initial, ' ', P.suffix) AS 'Professor Name',
        SA.section_code AS 'Section'
    FROM
        section_assign SA
    JOIN
        Student S ON S.student_id = SA.student_id
    JOIN
        subject_assign SBA ON SA.section_code = SBA.section_code
    JOIN
        Subject SB ON SBA.subject_code = SB.subject_code
    JOIN
        Professor P ON P.professor_id = SBA.professor_id;"

    Private Sub pop()
        dt.Clear()

        con.Open()
        cmd.Connection = con
        cmd.CommandText = queryString ' Set the CommandText property
        da.SelectCommand = cmd
        da.Fill(dt)
        dgvMIDTERM.DataSource = dt
        con.Close()
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSEARC.TextChanged
        Try
            Dim searchText As String = txtSEARC.Text.Trim()
            Dim filterExpression As String = String.Empty

            ' Check if the search text is not empty
            If Not String.IsNullOrEmpty(searchText) Then
                ' Build the filter expression
                filterExpression &= $"[Student ID] LIKE '%{searchText}%' OR "
                filterExpression &= $"[Name] LIKE '%{searchText}%' OR "

                ' Remove the last " OR " from the filter expression
                filterExpression = filterExpression.Substring(0, filterExpression.Length - 4)

                ' Apply the filter to the DataGridView
                If TypeOf dgvMIDTERM.DataSource Is DataView Then
                    DirectCast(dgvMIDTERM.DataSource, DataView).RowFilter = filterExpression
                ElseIf TypeOf dgvMIDTERM.DataSource Is DataTable Then
                    DirectCast(dgvMIDTERM.DataSource, DataTable).DefaultView.RowFilter = filterExpression
                End If
            Else
                ' Reset the filter if the search text is empty
                DirectCast(dgvMIDTERM.DataSource, DataTable).DefaultView.RowFilter = String.Empty
            End If
        Catch ex As Exception
            MessageBox.Show("Error searching: " & ex.Message & System.Environment.NewLine & "Please check your input.")
        End Try
    End Sub



    Private Sub dgvMIDTERM_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMIDTERM.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgvMIDTERM.Rows(e.RowIndex)
            Try
                StudentIDTxtBox.Text = selectedRow.Cells("Student ID").Value.ToString()
                StudentNameTxtBox.Text = selectedRow.Cells("Name").Value.ToString()
                sectionTxtBox.Text = selectedRow.Cells("Section").Value.ToString()
                Sub_txt.Text = selectedRow.Cells("Subject Code").Value.ToString()

            Catch ex As Exception
                MessageBox.Show("Error retrieving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub





    Private Function isFieldsEmpty() As Boolean
        Dim bool As Boolean

        bool = Not String.IsNullOrEmpty(StudentIDTxtBox.Text) And
               Not String.IsNullOrEmpty(StudentNameTxtBox.Text) And
               Not String.IsNullOrEmpty(Sub_txt.Text) And
               Not (sectionTxtBox.Text) Is Nothing And
               Not (cbSEM.Text) Is Nothing And
               Not (sectionTxtBox.Text) Is Nothing


        Return bool
    End Function



    Private Function GetEmptyFieldsList() As String
        Dim emptyFields As New System.Text.StringBuilder()

        If String.IsNullOrEmpty(StudentIDTxtBox.Text) Then
            emptyFields.AppendLine("- Student ID")
        End If

        If String.IsNullOrEmpty(StudentNameTxtBox.Text) Then
            emptyFields.AppendLine("- Student Name")
        End If


        If String.IsNullOrEmpty(Sub_txt.Text) Then
            emptyFields.AppendLine("- Subject")
        End If

        If cbSEC.SelectedItem Is Nothing Then
            emptyFields.AppendLine("- Section")
        End If

        If String.IsNullOrEmpty(sectionTxtBox.Text) Then
            emptyFields.AppendLine("- Year Level")
        End If


        Return emptyFields.ToString()
    End Function



    Private Sub StudentIDTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StudentIDTxtBox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim ValidNum = "1234567890-"

            If Not ValidNum.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Only NUMBERS are Accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub AttendanceTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AttendanceTxtBox.KeyPress
        If Not Asc(e.KeyChar) = 8 Then
            Dim ValidNum = "1234567890-"

            If Not ValidNum.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Only NUMBERS are Accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If

            Dim enteredText = AttendanceTxtBox.Text & e.KeyChar.ToString
            If IsNumeric(enteredText) AndAlso Val(enteredText) > 100 Then
                MessageBox.Show("Grade cannot exceed 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ClearAllBtn_Click(sender As Object, e As EventArgs) Handles ClearAllBtn.Click
        ResetTextBoxStates()
        AttendanceTxtBox.Clear()
        QuizzesTxtBox.Clear()
        MidtermExamTxtBox.Clear()
        LabExerTxtBox.Clear()
        CaseStudyTxtbox.Clear()
        RecitTxtbox.Clear()
        MidGradePromptTxtBox.Clear()
        StudentIDTxtBox.Clear()
        StudentNameTxtBox.Clear()
        sectionTxtBox.Clear()
        cbSEC.SelectedIndex = -1
        cbSUB.SelectedIndex = -1
        Sub_txt.Clear()
        NumberOfQuizComboBox.SelectedIndex = -1
        Q1InputTxtBox.Clear()
        Q2InputTxtBox.Clear()
        Q3InputTxtBox.Clear()
        Q4InputTxtBox.Clear()
        Q1MaxTxtBox.Clear()
        Q2MaxTxtBox.Clear()
        Q3MaxTxtBox.Clear()
        Q4MaxTxtBox.Clear()
        QuizTotalScoreTxtBox.Clear()
        QuizTotalItemsTextBox.Clear()
        InputMidExamTxtBox.Clear()
        MaxMidExamTxtBox.Clear()
        RemarksScoreLbl.Visible = False
        SaveBtn.Visible = False
        AttendanceComboBox.SelectedItem = -1
        AttendanceComboBox.Text = ""
        Lab1TxtBox.Clear()
        Lab2TxtBox.Clear()
        Lab3TxtBox.Clear()
        Lab4TxtBox.Clear()
        NumberOfLabExerciseComboBox.SelectedIndex = -1
        cbSEM.SelectedIndex = -1
        patongPanel.Visible = True
    End Sub

    Private Sub ComputeBtn_Click(sender As Object, e As EventArgs) Handles ComputeBtn.Click
        Dim response As Byte
        response = MessageBox.Show("All entries Correct?", "Compute", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = DialogResult.Yes Then
            Dim attendance = Val(AttendanceTxtBox.Text) ' 5%
            Dim quizzes = Val(QuizzesTxtBox.Text) ' 15%
            Dim labExercises = Val(LabExerTxtBox.Text) ' 20%
            Dim midtermExam = Val(MidtermExamTxtBox.Text) ' 30%
            Dim caseStudy = Val(CaseStudyTxtbox.Text) ' 20%
            Dim recitation = Val(RecitTxtbox.Text) ' 10%

            Dim average = attendance * 0.05 + quizzes * 0.15 + labExercises * 0.2 + midtermExam * 0.3 + caseStudy * 0.2 + recitation * 0.1
            MidGradePromptTxtBox.Text = average.ToString("F2")
            midterm_grade = Convert.ToDecimal(average)
            midterm_avg = average
        End If
        Dim Score As Double
        Score = Val(MidGradePromptTxtBox.Text)
        If Score >= 74.6 Then
            RemarksScoreLbl.Text = "PASSED"
            RemarksScoreLbl.BackColor = Color.Green
            RemarksScoreLbl.ForeColor = Color.White
            RemarksScoreLbl.Visible = True
        ElseIf Score <= 74.5 And Score >= 70 Then
            RemarksScoreLbl.Text = "FAILED"
            RemarksScoreLbl.BackColor = Color.Red
            RemarksScoreLbl.ForeColor = Color.White
            RemarksScoreLbl.Visible = True
        Else
            RemarksScoreLbl.Text = "DROPPED"
            RemarksScoreLbl.ForeColor = Color.Red
            RemarksScoreLbl.BackColor = Color.Gainsboro
            RemarksScoreLbl.Visible = True
        End If
    End Sub

    Private Sub MidtermExamTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MidtermExamTxtBox.KeyPress
        If Not Asc(e.KeyChar) = 8 Then
            Dim ValidNum = "1234567890-"

            If Not ValidNum.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Only NUMBERS are Accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If

            Dim enteredText = MidtermExamTxtBox.Text & e.KeyChar.ToString
            If IsNumeric(enteredText) AndAlso Val(enteredText) > 100 Then
                MessageBox.Show("Grade cannot exceed 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub QuizzesTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles QuizzesTxtBox.KeyPress
        If Not Asc(e.KeyChar) = 8 Then
            Dim ValidNum = "1234567890-"

            If Not ValidNum.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Only NUMBERS are Accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If

            Dim enteredText = QuizzesTxtBox.Text & e.KeyChar.ToString
            If IsNumeric(enteredText) AndAlso Val(enteredText) > 100 Then
                MessageBox.Show("Grade cannot exceed 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub LabExerTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LabExerTxtBox.KeyPress
        If Not Asc(e.KeyChar) = 8 Then
            Dim ValidNum = "1234567890-"

            If Not ValidNum.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Only NUMBERS are Accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If

            Dim enteredText = LabExerTxtBox.Text & e.KeyChar.ToString
            If IsNumeric(enteredText) AndAlso Val(enteredText) > 100 Then
                MessageBox.Show("Grade cannot exceed 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CaseStudyTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CaseStudyTxtbox.KeyPress
        If Not Asc(e.KeyChar) = 8 Then
            Dim ValidNum = "1234567890-"

            If Not ValidNum.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Only NUMBERS are Accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If

            Dim enteredText = CaseStudyTxtbox.Text & e.KeyChar.ToString
            If IsNumeric(enteredText) AndAlso Val(enteredText) > 100 Then
                MessageBox.Show("Grade cannot exceed 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub RecitTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RecitTxtbox.KeyPress
        If Not Asc(e.KeyChar) = 8 Then
            Dim ValidNum = "1234567890-"

            If Not ValidNum.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Only NUMBERS are Accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If

            Dim enteredText = RecitTxtbox.Text & e.KeyChar.ToString
            If IsNumeric(enteredText) AndAlso Val(enteredText) > 100 Then
                MessageBox.Show("Grade cannot exceed 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub





    Private Sub SectionMidtermTxtbox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MidtermExamTxtBox_TextChanged(sender As Object, e As EventArgs) Handles MidtermExamTxtBox.TextChanged

    End Sub

    Private Sub MidtermPanel_Paint(sender As Object, e As PaintEventArgs) Handles MidtermPanel.Paint

    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Dim msgExit As DialogResult = MessageBox.Show("Do you want to EXIT?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If msgExit.Equals(DialogResult.Yes) Then
            Me.Close()
        End If
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Dim msgCancel As DialogResult = MessageBox.Show("Do you want to CANCEL?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If msgCancel.Equals(DialogResult.Yes) Then
            Me.Close()
        End If
    End Sub

    Private midterm_grade As Decimal
    Private midterm_avg As Double
    Private attendance_percentage As Decimal
    Private quiz_percentage As Decimal
    Private lab_percentage As Decimal
    Private case_study_percentage As Decimal
    Private recitation_percentage As Decimal
    Private mid_exam_percentage As Decimal

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Try
            ' Save to midterm table first
            SaveToMidterm()
            ' Then save to midterm_gw
            SaveToMidterm_gw()
            MessageBox.Show("Grades saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error saving grades: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SaveToMidterm()
        Try
            Using con As New MySqlConnection("server=localhost; user=root; database=imvbnet_proj")
                con.Open()

                ' First check if record exists
                Dim checkQuery As String = "SELECT COUNT(*) FROM midterm WHERE student_id = @student_id AND subject_code = @subject_code AND section_code = @section_code"
                Using checkCmd As New MySqlCommand(checkQuery, con)
                    checkCmd.Parameters.AddWithValue("@student_id", StudentIDTxtBox.Text)
                    checkCmd.Parameters.AddWithValue("@subject_code", Sub_txt.Text)
                    checkCmd.Parameters.AddWithValue("@section_code", sectionTxtBox.Text)

                    Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    If exists > 0 Then
                        ' Update existing record
                        Dim updateQuery As String = "UPDATE midterm SET " &
                            "no_of_absences = @absences, " &
                            "Q1_score = @q1_score, Q1_item = @q1_item, " &
                            "Q2_score = @q2_score, Q2_item = @q2_item, " &
                            "Q3_score = @q3_score, Q3_item = @q3_item, " &
                            "Q4_score = @q4_score, Q4_item = @q4_item, " &
                            "LAB1_score = @lab1, LAB2_score = @lab2, " &
                            "LAB3_score = @lab3, LAB4_score = @lab4, " &
                            "mid_exam_score = @mid_exam_score, " &
                            "mid_exam_item = @mid_exam_item, " &
                            "case_study = @case_study, " &
                            "recitation = @recitation " &
                            "WHERE student_id = @student_id AND subject_code = @subject_code AND section_code = @section_code"

                        Using cmd As New MySqlCommand(updateQuery, con)
                            AddMidtermParameters(cmd)
                            cmd.ExecuteNonQuery()
                        End Using
                    Else
                        ' Insert new record
                        Dim insertQuery As String = "INSERT INTO midterm (student_id, subject_code, section_code, " &
                            "no_of_absences, Q1_score, Q1_item, Q2_score, Q2_item, " &
                            "Q3_score, Q3_item, Q4_score, Q4_item, " &
                            "LAB1_score, LAB2_score, LAB3_score, LAB4_score, " &
                            "mid_exam_score, mid_exam_item, case_study, recitation) " &
                            "VALUES (@student_id, @subject_code, @section_code, " &
                            "@absences, @q1_score, @q1_item, @q2_score, @q2_item, " &
                            "@q3_score, @q3_item, @q4_score, @q4_item, " &
                            "@lab1, @lab2, @lab3, @lab4, " &
                            "@mid_exam_score, @mid_exam_item, @case_study, @recitation)"

                        Using cmd As New MySqlCommand(insertQuery, con)
                            AddMidtermParameters(cmd)
                            cmd.ExecuteNonQuery()
                        End Using
                    End If
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error saving to midterm: " & ex.Message)
        End Try
    End Sub

    Private Sub AddMidtermParameters(cmd As MySqlCommand)
        cmd.Parameters.AddWithValue("@student_id", StudentIDTxtBox.Text)
        cmd.Parameters.AddWithValue("@subject_code", Sub_txt.Text)
        cmd.Parameters.AddWithValue("@section_code", sectionTxtBox.Text)
        cmd.Parameters.AddWithValue("@absences", AttendanceComboBox.Text)
        cmd.Parameters.AddWithValue("@q1_score", If(String.IsNullOrEmpty(Q1InputTxtBox.Text), DBNull.Value, Convert.ToInt32(Q1InputTxtBox.Text)))
        cmd.Parameters.AddWithValue("@q1_item", If(String.IsNullOrEmpty(Q1MaxTxtBox.Text), DBNull.Value, Convert.ToInt32(Q1MaxTxtBox.Text)))
        cmd.Parameters.AddWithValue("@q2_score", If(String.IsNullOrEmpty(Q2InputTxtBox.Text), DBNull.Value, Convert.ToInt32(Q2InputTxtBox.Text)))
        cmd.Parameters.AddWithValue("@q2_item", If(String.IsNullOrEmpty(Q2MaxTxtBox.Text), DBNull.Value, Convert.ToInt32(Q2MaxTxtBox.Text)))
        cmd.Parameters.AddWithValue("@q3_score", If(String.IsNullOrEmpty(Q3InputTxtBox.Text), DBNull.Value, Convert.ToInt32(Q3InputTxtBox.Text)))
        cmd.Parameters.AddWithValue("@q3_item", If(String.IsNullOrEmpty(Q3MaxTxtBox.Text), DBNull.Value, Convert.ToInt32(Q3MaxTxtBox.Text)))
        cmd.Parameters.AddWithValue("@q4_score", If(String.IsNullOrEmpty(Q4InputTxtBox.Text), DBNull.Value, Convert.ToInt32(Q4InputTxtBox.Text)))
        cmd.Parameters.AddWithValue("@q4_item", If(String.IsNullOrEmpty(Q4MaxTxtBox.Text), DBNull.Value, Convert.ToInt32(Q4MaxTxtBox.Text)))
        cmd.Parameters.AddWithValue("@lab1", If(String.IsNullOrEmpty(Lab1TxtBox.Text), DBNull.Value, Convert.ToInt32(Lab1TxtBox.Text)))
        cmd.Parameters.AddWithValue("@lab2", If(String.IsNullOrEmpty(Lab2TxtBox.Text), DBNull.Value, Convert.ToInt32(Lab2TxtBox.Text)))
        cmd.Parameters.AddWithValue("@lab3", If(String.IsNullOrEmpty(Lab3TxtBox.Text), DBNull.Value, Convert.ToInt32(Lab3TxtBox.Text)))
        cmd.Parameters.AddWithValue("@lab4", If(String.IsNullOrEmpty(Lab4TxtBox.Text), DBNull.Value, Convert.ToInt32(Lab4TxtBox.Text)))
        cmd.Parameters.AddWithValue("@mid_exam_score", If(String.IsNullOrEmpty(InputMidExamTxtBox.Text), DBNull.Value, Convert.ToInt32(InputMidExamTxtBox.Text)))
        cmd.Parameters.AddWithValue("@mid_exam_item", If(String.IsNullOrEmpty(MaxMidExamTxtBox.Text), DBNull.Value, Convert.ToInt32(MaxMidExamTxtBox.Text)))
        cmd.Parameters.AddWithValue("@case_study", Convert.ToInt32(CaseStudyTxtbox.Text))
        cmd.Parameters.AddWithValue("@recitation", Convert.ToInt32(RecitTxtbox.Text))
    End Sub

    Private Sub SaveToMidterm_gw()
        Try
            Using con As New MySqlConnection("server=localhost; user=root; database=imvbnet_proj")
                con.Open()

                ' Check if record exists
                Dim checkQuery As String = "SELECT COUNT(*) FROM midterm_gw WHERE student_id = @student_id AND subject_code = @subject_code AND section_code = @section_code"
                Using checkCmd As New MySqlCommand(checkQuery, con)
                    checkCmd.Parameters.AddWithValue("@student_id", StudentIDTxtBox.Text)
                    checkCmd.Parameters.AddWithValue("@subject_code", Sub_txt.Text)
                    checkCmd.Parameters.AddWithValue("@section_code", sectionTxtBox.Text)

                    Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    If exists > 0 Then
                        ' Update existing record
                        Dim updateQuery As String = "UPDATE midterm_gw SET " &
                            "attendance_percentage = @attendance, " &
                            "quiz_percentage = @quiz, " &
                            "lab_percentage = @lab, " &
                            "case_study = @case_study, " &
                            "recitation = @recit, " &
                            "mid_exam_percentage = @mid_exam, " &
                            "midterm_grade = @midterm_grade, " &
                            "remarks = @remarks " &
                            "WHERE student_id = @student_id AND subject_code = @subject_code AND section_code = @section_code"

                        Using cmd As New MySqlCommand(updateQuery, con)
                            AddMidtermGWParameters(cmd)
                            cmd.ExecuteNonQuery()
                        End Using
                    Else
                        ' Insert new record
                        Dim insertQuery As String = "INSERT INTO midterm_gw (student_id, subject_code, section_code, " &
                            "attendance_percentage, quiz_percentage, lab_percentage, " &
                            "case_study, recitation, mid_exam_percentage, midterm_grade, remarks) " &
                            "VALUES (@student_id, @subject_code, @section_code, " &
                            "@attendance, @quiz, @lab, @case_study, @recit, @mid_exam, @midterm_grade, @remarks)"

                        Using cmd As New MySqlCommand(insertQuery, con)
                            AddMidtermGWParameters(cmd)
                            cmd.ExecuteNonQuery()
                        End Using
                    End If
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error saving to midterm_gw: " & ex.Message)
        End Try
    End Sub

    Private Sub AddMidtermGWParameters(cmd As MySqlCommand)
        cmd.Parameters.AddWithValue("@student_id", StudentIDTxtBox.Text)
        cmd.Parameters.AddWithValue("@subject_code", Sub_txt.Text)
        cmd.Parameters.AddWithValue("@section_code", sectionTxtBox.Text)
        cmd.Parameters.AddWithValue("@attendance", Convert.ToDecimal(AttendanceTxtBox.Text))
        cmd.Parameters.AddWithValue("@quiz", Convert.ToDecimal(QuizzesTxtBox.Text))
        cmd.Parameters.AddWithValue("@lab", Convert.ToDecimal(LabExerTxtBox.Text))
        cmd.Parameters.AddWithValue("@case_study", Convert.ToDecimal(CaseStudyTxtbox.Text))
        cmd.Parameters.AddWithValue("@recit", Convert.ToDecimal(RecitTxtbox.Text))
        cmd.Parameters.AddWithValue("@mid_exam", Convert.ToDecimal(MidtermExamTxtBox.Text))
        cmd.Parameters.AddWithValue("@midterm_grade", midterm_grade)
        cmd.Parameters.AddWithValue("@remarks", RemarksScoreLbl.Text)
    End Sub
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim response = MessageBox.Show("Check if all information is correct. Once you save it, it cannot be changed", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = DialogResult.Yes Then
            Try
                SaveToMidterm()
                SaveToMidterm_gw()

                MessageBox.Show("All information has been saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearAllBtn_Click(Nothing, Nothing) ' Clear all fields after successful save
            Catch ex As Exception
                MessageBox.Show("Error saving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    Private Sub showgradeBtn_Click(sender As Object, e As EventArgs) Handles showGradeBtn.Click

        ResetTextBoxStates()
        Dim check = isFieldsEmpty()
        If check Then
            AttendanceTxtBox.Enabled = False
            patongPanel.Visible = False
            MidtermPanel.Visible = True
            GradeEquivalentPanel.Visible = True
            MidtermGradeBorderPanel.Visible = True
            MidtermGradeLbl.Visible = True
            ClearAllBtn.Visible = True
            ComputeBtn.Visible = True
            SaveBtn.Visible = True
            Q1InputTxtBox.Enabled = False
            Q1MaxTxtBox.Enabled = False
            Q2InputTxtBox.Enabled = False
            Q2MaxTxtBox.Enabled = False
            Q3InputTxtBox.Enabled = False
            Q3MaxTxtBox.Enabled = False
            Q4InputTxtBox.Enabled = False
            Q4MaxTxtBox.Enabled = False
            LabExerTxtBox.Enabled = False
            Lab1TxtBox.Enabled = False
            Lab2TxtBox.Enabled = False
            Lab3TxtBox.Enabled = False
            Lab4TxtBox.Enabled = False

        Else
            MessageBox.Show("Fill up all the fields first:" & vbCrLf & GetEmptyFieldsList(),
                           "Information",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub patongPanel_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub AttendanceTxtBox_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Sub Calculate_Quizzes()
        Dim QuizOneScore, QuizOneItems, QuizTwoScore, QuizTwoItems As Integer
        Dim QuizThreeScore, QuizThreeItems, QuizFourScore, QuizFourItems As Integer
        Dim TotalQuizPercentage As Double = 0
        Dim QuizCount As Integer = 0
        Dim QuizInputItems As Integer = 0
        Dim QuizMaxItems As Integer = 0


        ' Handle Quiz 1
        If Not String.IsNullOrEmpty(Q1InputTxtBox.Text) AndAlso Not String.IsNullOrEmpty(Q1MaxTxtBox.Text) Then
            QuizOneScore = Convert.ToInt32(Q1InputTxtBox.Text)
            QuizOneItems = Convert.ToInt32(Q1MaxTxtBox.Text)

            If QuizOneScore > QuizOneItems Then
                MessageBox.Show("Score cannot be higher than the maximum items", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim Quiz1Percentage As Double = ((QuizOneScore / QuizOneItems) * 50) + 50
            TotalQuizPercentage += Quiz1Percentage
            QuizCount += 1
            QuizInputItems += QuizOneScore
            QuizMaxItems += QuizOneItems

        End If

        ' Handle Quiz 2
        If Not String.IsNullOrEmpty(Q2InputTxtBox.Text) AndAlso Not String.IsNullOrEmpty(Q2MaxTxtBox.Text) Then
            QuizTwoScore = Convert.ToInt32(Q2InputTxtBox.Text)
            QuizTwoItems = Convert.ToInt32(Q2MaxTxtBox.Text)

            If QuizTwoScore > QuizTwoItems Then
                MessageBox.Show("Score cannot be higher than the maximum items", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim Quiz2Percentage As Double = ((QuizTwoScore / QuizTwoItems) * 50) + 50
            TotalQuizPercentage += Quiz2Percentage
            QuizCount += 1
            QuizInputItems += QuizTwoScore
            QuizMaxItems += QuizTwoItems

        End If

        ' Handle Quiz 3
        If Not String.IsNullOrEmpty(Q3InputTxtBox.Text) AndAlso Not String.IsNullOrEmpty(Q3MaxTxtBox.Text) Then
            QuizThreeScore = Convert.ToInt32(Q3InputTxtBox.Text)
            QuizThreeItems = Convert.ToInt32(Q3MaxTxtBox.Text)

            If QuizThreeScore > QuizThreeItems Then
                MessageBox.Show("Score cannot be higher than the maximum items", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim Quiz3Percentage As Double = ((QuizThreeScore / QuizThreeItems) * 50) + 50
            TotalQuizPercentage += Quiz3Percentage
            QuizCount += 1
            QuizInputItems += QuizThreeScore
            QuizMaxItems += QuizThreeItems
        End If

        ' Handle Quiz 4
        If Not String.IsNullOrEmpty(Q4InputTxtBox.Text) AndAlso Not String.IsNullOrEmpty(Q4MaxTxtBox.Text) Then
            QuizFourScore = Convert.ToInt32(Q4InputTxtBox.Text)
            QuizFourItems = Convert.ToInt32(Q4MaxTxtBox.Text)

            If QuizFourScore > QuizFourItems Then
                MessageBox.Show("Score cannot be higher than the maximum items", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim Quiz4Percentage As Double = ((QuizFourScore / QuizFourItems) * 50) + 50
            TotalQuizPercentage += Quiz4Percentage
            QuizCount += 1
            QuizInputItems += QuizFourScore
            QuizMaxItems += QuizFourItems

        End If

        ' Check if at least one quiz was entered
        If QuizCount = 0 Then
            MessageBox.Show("Please enter at least one quiz score and its maximum value.")
            Return
        End If

        ' Display total scores and items
        QuizTotalScoreTxtBox.Text = QuizInputItems.ToString()
        QuizTotalItemsTextBox.Text = QuizMaxItems.ToString()

        ' Calculate and display percentage
        Dim QuizPercentage As Integer = (TotalQuizPercentage / QuizCount)
        QuizzesTxtBox.Text = QuizPercentage.ToString() ' Shows percentage with 2 decimal places

        ' Make textboxes visible
        QuizTotalScoreTxtBox.Show()
        QuizTotalItemsTextBox.Show()
        QuizzesTxtBox.Show()

    End Sub

    Sub Calculate_FinalExam()

        If String.IsNullOrEmpty(InputMidExamTxtBox.Text) OrElse String.IsNullOrEmpty(MaxMidExamTxtBox.Text) Then
            MessageBox.Show("Please enter score and its maximum value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim FinalInputScore, FinalMaxScore As Integer
        FinalInputScore = InputMidExamTxtBox.Text
        FinalMaxScore = MaxMidExamTxtBox.Text


        If FinalInputScore > FinalMaxScore Then
            MessageBox.Show("Score cannot be higher than the maximum items", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim MidtermExamPercentScore As Integer
        MidtermExamPercentScore = (FinalInputScore / FinalMaxScore) * 50 + 50
        MidtermExamTxtBox.Text = MidtermExamPercentScore.ToString
        MidtermExamTxtBox.Show()
    End Sub

    Private Sub QuizComputeBtn_Click(sender As Object, e As EventArgs) Handles QuizComputeBtn.Click
        Calculate_Quizzes()
    End Sub

    Private Sub FinalExamComputeBtn_Click(sender As Object, e As EventArgs) Handles FinalExamComputeBtn.Click
        Calculate_FinalExam()
    End Sub

    Private Sub UpdateQuizFields(numberOfQuizzes As Integer)
        Q1MaxTxtBox.Enabled = False
        Q1InputTxtBox.Enabled = False
        Q2MaxTxtBox.Enabled = False
        Q2InputTxtBox.Enabled = False
        Q3MaxTxtBox.Enabled = False
        Q3InputTxtBox.Enabled = False
        Q4MaxTxtBox.Enabled = False
        Q4InputTxtBox.Enabled = False

        ' Enable fields based on the selected number of quizzes
        Select Case numberOfQuizzes
            Case 1
                Q1MaxTxtBox.Enabled = True
                CheckMaxTextBox(Q1MaxTxtBox, Q1InputTxtBox)
            Case 2
                Q1MaxTxtBox.Enabled = True
                Q2MaxTxtBox.Enabled = True
                CheckMaxTextBox(Q1MaxTxtBox, Q1InputTxtBox)
                CheckMaxTextBox(Q2MaxTxtBox, Q2InputTxtBox)
            Case 3
                Q1MaxTxtBox.Enabled = True
                Q2MaxTxtBox.Enabled = True
                Q3MaxTxtBox.Enabled = True
                CheckMaxTextBox(Q1MaxTxtBox, Q1InputTxtBox)
                CheckMaxTextBox(Q2MaxTxtBox, Q2InputTxtBox)
                CheckMaxTextBox(Q3MaxTxtBox, Q3InputTxtBox)
            Case 4
                Q1MaxTxtBox.Enabled = True
                Q2MaxTxtBox.Enabled = True
                Q3MaxTxtBox.Enabled = True
                Q4MaxTxtBox.Enabled = True
                CheckMaxTextBox(Q1MaxTxtBox, Q1InputTxtBox)
                CheckMaxTextBox(Q2MaxTxtBox, Q2InputTxtBox)
                CheckMaxTextBox(Q3MaxTxtBox, Q3InputTxtBox)
                CheckMaxTextBox(Q4MaxTxtBox, Q4InputTxtBox)
        End Select
    End Sub

    ' Add this helper function to check Max TextBox values
    Private Sub CheckMaxTextBox(maxTextBox As TextBox, inputTextBox As TextBox)
        If Not String.IsNullOrEmpty(maxTextBox.Text) AndAlso IsNumeric(maxTextBox.Text) Then
            inputTextBox.Enabled = True
        Else
            inputTextBox.Enabled = False
        End If
    End Sub

    Private Sub Q1MaxTxtBox_TextChanged(sender As Object, e As EventArgs) Handles Q1MaxTxtBox.TextChanged
        CheckMaxTextBox(Q1MaxTxtBox, Q1InputTxtBox)
    End Sub

    Private Sub Q2MaxTxtBox_TextChanged(sender As Object, e As EventArgs) Handles Q2MaxTxtBox.TextChanged
        CheckMaxTextBox(Q2MaxTxtBox, Q2InputTxtBox)
    End Sub

    Private Sub Q3MaxTxtBox_TextChanged(sender As Object, e As EventArgs) Handles Q3MaxTxtBox.TextChanged
        CheckMaxTextBox(Q3MaxTxtBox, Q3InputTxtBox)
    End Sub

    Private Sub Q4MaxTxtBox_TextChanged(sender As Object, e As EventArgs) Handles Q4MaxTxtBox.TextChanged
        CheckMaxTextBox(Q4MaxTxtBox, Q4InputTxtBox)
    End Sub

    Private Sub NumberOfQuizComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NumberOfQuizComboBox.SelectedIndexChanged
        If NumberOfQuizComboBox.SelectedItem IsNot Nothing Then
            Dim numberOfQuizzes As Integer
            If Integer.TryParse(NumberOfQuizComboBox.SelectedItem.ToString, numberOfQuizzes) Then
                UpdateQuizFields(numberOfQuizzes)
            End If
        End If
    End Sub

    Private Sub AttendanceTxtBox_TextChanged_1(sender As Object, e As EventArgs) Handles AttendanceTxtBox.TextChanged

    End Sub

    Private Sub Q1InputTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Q1InputTxtBox.KeyPress
        If Not Asc(e.KeyChar) = 8 Then
            Dim ValidNum = "1234567890-"

            If Not ValidNum.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Only NUMBERS are Accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If

            Dim enteredText = Q1InputTxtBox.Text & e.KeyChar.ToString
            If IsNumeric(enteredText) AndAlso Val(enteredText) > 100 Then
                MessageBox.Show("Grade cannot exceed 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Q1MaxTxtBot_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Q1MaxTxtBox.KeyPress
        If Not Asc(e.KeyChar) = 8 Then
            Dim ValidNum = "1234567890-"

            If Not ValidNum.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Only NUMBERS are Accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If

            Dim enteredText = Q1MaxTxtBox.Text & e.KeyChar.ToString
            If IsNumeric(enteredText) AndAlso Val(enteredText) > 100 Then
                MessageBox.Show("Grade cannot exceed 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Q2InputTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Q2InputTxtBox.KeyPress
        If Not Asc(e.KeyChar) = 8 Then
            Dim ValidNum = "1234567890-"

            If Not ValidNum.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Only NUMBERS are Accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If

            Dim enteredText = Q2InputTxtBox.Text & e.KeyChar.ToString
            If IsNumeric(enteredText) AndAlso Val(enteredText) > 100 Then
                MessageBox.Show("Grade cannot exceed 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Q2MaxTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Q2MaxTxtBox.KeyPress
        If Not Asc(e.KeyChar) = 8 Then
            Dim ValidNum = "1234567890-"

            If Not ValidNum.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Only NUMBERS are Accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If

            Dim enteredText = Q2MaxTxtBox.Text & e.KeyChar.ToString
            If IsNumeric(enteredText) AndAlso Val(enteredText) > 100 Then
                MessageBox.Show("Grade cannot exceed 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub Q3InputTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Q3InputTxtBox.KeyPress
        If Not Asc(e.KeyChar) = 8 Then
            Dim ValidNum = "1234567890-"

            If Not ValidNum.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Only NUMBERS are Accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If

            Dim enteredText = Q3InputTxtBox.Text & e.KeyChar.ToString
            If IsNumeric(enteredText) AndAlso Val(enteredText) > 100 Then
                MessageBox.Show("Grade cannot exceed 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub Q3MaxTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Q3MaxTxtBox.KeyPress
        If Not Asc(e.KeyChar) = 8 Then
            Dim ValidNum = "1234567890-"

            If Not ValidNum.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Only NUMBERS are Accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If

            Dim enteredText = Q3MaxTxtBox.Text & e.KeyChar.ToString
            If IsNumeric(enteredText) AndAlso Val(enteredText) > 100 Then
                MessageBox.Show("Grade cannot exceed 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub Q4InputTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Q4InputTxtBox.KeyPress
        If Not Asc(e.KeyChar) = 8 Then
            Dim ValidNum = "1234567890-"

            If Not ValidNum.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Only NUMBERS are Accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
            Dim enteredText = Q4InputTxtBox.Text & e.KeyChar.ToString
            If IsNumeric(enteredText) AndAlso Val(enteredText) > 100 Then
                MessageBox.Show("Grade cannot exceed 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Q4MaxTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Q4MaxTxtBox.KeyPress
        If Not Asc(e.KeyChar) = 8 Then
            Dim ValidNum = "1234567890-"

            If Not ValidNum.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Only NUMBERS are Accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If

            Dim enteredText = Q4MaxTxtBox.Text & e.KeyChar.ToString
            If IsNumeric(enteredText) AndAlso Val(enteredText) > 100 Then
                MessageBox.Show("Grade cannot exceed 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub InputMidExamTxtBox_TextChanged(sender As Object, e As KeyPressEventArgs) Handles InputMidExamTxtBox.KeyPress
        If Not Asc(e.KeyChar) = 8 Then
            Dim ValidNum = "1234567890-"

            If Not ValidNum.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Only NUMBERS are Accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If

            Dim enteredText = InputMidExamTxtBox.Text & e.KeyChar.ToString
            If IsNumeric(enteredText) AndAlso Val(enteredText) > 100 Then
                MessageBox.Show("Grade cannot exceed 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub MaxMidExamTxtBox_TextChanged(sender As Object, e As KeyPressEventArgs) Handles MaxMidExamTxtBox.KeyPress
        If Not Asc(e.KeyChar) = 8 Then
            Dim ValidNum = "1234567890-"

            If Not ValidNum.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Only NUMBERS are Accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If

            Dim enteredText = MaxMidExamTxtBox.Text & e.KeyChar.ToString
            If IsNumeric(enteredText) AndAlso Val(enteredText) > 100 Then
                MessageBox.Show("Grade cannot exceed 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub AttendanceComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AttendanceComboBox.SelectedIndexChanged

        Dim absences As Integer
        If Integer.TryParse(AttendanceComboBox.SelectedItem.ToString, absences) Then

            Const totalClasses = 16


            If absences >= 10 AndAlso absences <= 16 Then

                NumberOfLabExerciseComboBox.Enabled = False
                NumberOfQuizComboBox.Enabled = False
                LabExerTxtBox.Enabled = False
                CaseStudyTxtbox.Enabled = False
                InputMidExamTxtBox.Enabled = False
                MaxMidExamTxtBox.Enabled = False
                RecitTxtbox.Enabled = False

            Else

                Dim attendancePercentage As Integer = (totalClasses - absences) / totalClasses * 100


                AttendanceTxtBox.Text = Format(attendancePercentage)
                AttendanceTxtBox.ForeColor = Color.Black
            End If
        Else
            AttendanceTxtBox.Text = "Invalid Input"
        End If
    End Sub


    Private Sub InitializeAttendanceComboBox()
        AttendanceComboBox.Items.Clear()
        For i As Integer = 1 To 16
            AttendanceComboBox.Items.Add(i.ToString())
        Next
    End Sub

    Private Sub ResetTextBoxStates()

        NumberOfLabExerciseComboBox.Enabled = True
        NumberOfQuizComboBox.Enabled = True
        CaseStudyTxtbox.Enabled = True
        InputMidExamTxtBox.Enabled = True
        MaxMidExamTxtBox.Enabled = True
        RecitTxtbox.Enabled = True
    End Sub

    Sub Calculate_LabExercises()

        Dim Exercise1, Exercise2, Exercise3, Exercise4 As Integer
        If Not String.IsNullOrEmpty(Lab1TxtBox.Text) Then
            Exercise1 = Convert.ToInt32(Lab1TxtBox.Text)

            Dim LabScore1 As Integer = (Exercise1 / 100) * 100
            LabExerTxtBox.Text = LabScore1.ToString()
            LabExerTxtBox.Show()

        End If

        If Not String.IsNullOrEmpty(Lab2TxtBox.Text) AndAlso Not String.IsNullOrEmpty(Lab1TxtBox.Text) Then
            Exercise1 = Convert.ToInt32(Lab1TxtBox.Text)
            Exercise2 = Convert.ToInt32(Lab2TxtBox.Text)

            Dim LabScore2 As Integer = (Exercise1 + Exercise2) / 2
            LabExerTxtBox.Text = LabScore2.ToString()
            LabExerTxtBox.Show()

        End If

        If Not String.IsNullOrEmpty(Lab3TxtBox.Text) Then
            Exercise3 = Convert.ToInt32(Lab3TxtBox.Text)

            Dim LabScore3 As Integer = (Exercise1 + Exercise2 + Exercise3) / 3
            LabExerTxtBox.Text = LabScore3.ToString()
            LabExerTxtBox.Show()

        End If

        If Not String.IsNullOrEmpty(Lab4TxtBox.Text) Then
            Exercise4 = Convert.ToInt32(Lab4TxtBox.Text)

            Dim LabScore4 As Integer = (Exercise1 + Exercise2 + Exercise3 + Exercise4) / 4
            LabExerTxtBox.Text = LabScore4.ToString()
            LabExerTxtBox.Show()

        End If
    End Sub

    Sub Update_LabExercises(numberOfLabExercise As Integer)
        Select Case numberOfLabExercise
            Case 1
                Lab1TxtBox.Enabled = True
            Case 2
                Lab1TxtBox.Enabled = True
                Lab2TxtBox.Enabled = True
            Case 3
                Lab1TxtBox.Enabled = True
                Lab2TxtBox.Enabled = True
                Lab3TxtBox.Enabled = True
            Case 4
                Lab1TxtBox.Enabled = True
                Lab2TxtBox.Enabled = True
                Lab3TxtBox.Enabled = True
                Lab4TxtBox.Enabled = True

        End Select
    End Sub

    Private Sub NumberOfLabExercise_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NumberOfLabExerciseComboBox.SelectedIndexChanged
        If NumberOfLabExerciseComboBox.SelectedItem IsNot Nothing Then
            Dim numberOfLabExercise As Integer
            If Integer.TryParse(NumberOfLabExerciseComboBox.SelectedItem.ToString, numberOfLabExercise) Then
                Update_LabExercises(numberOfLabExercise)
            End If
        End If
    End Sub

    Private Sub LabComputeBtn_Click(sender As Object, e As EventArgs) Handles LabComputeBtn.Click
        Calculate_LabExercises()
    End Sub

    Private Sub Lab1TxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Lab1TxtBox.KeyPress
        If Not Asc(e.KeyChar) = 8 Then
            Dim ValidNum = "1234567890-"

            If Not ValidNum.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Only NUMBERS are Accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If

            Dim enteredText = Lab1TxtBox.Text & e.KeyChar.ToString
            If IsNumeric(enteredText) AndAlso Val(enteredText) > 100 Then
                MessageBox.Show("Grade cannot exceed 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Lab2TxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Lab2TxtBox.KeyPress
        If Not Asc(e.KeyChar) = 8 Then
            Dim ValidNum = "1234567890-"

            If Not ValidNum.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Only NUMBERS are Accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If

            Dim enteredText = Lab2TxtBox.Text & e.KeyChar.ToString
            If IsNumeric(enteredText) AndAlso Val(enteredText) > 100 Then
                MessageBox.Show("Grade cannot exceed 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub Lab3TxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Lab3TxtBox.KeyPress
        If Not Asc(e.KeyChar) = 8 Then
            Dim ValidNum = "1234567890-"

            If Not ValidNum.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Only NUMBERS are Accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If

            Dim enteredText = Lab3TxtBox.Text & e.KeyChar.ToString
            If IsNumeric(enteredText) AndAlso Val(enteredText) > 100 Then
                MessageBox.Show("Grade cannot exceed 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub Lab4TxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Lab4TxtBox.KeyPress
        If Not Asc(e.KeyChar) = 8 Then
            Dim ValidNum = "1234567890-"

            If Not ValidNum.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Only NUMBERS are Accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If

            Dim enteredText = Lab4TxtBox.Text & e.KeyChar.ToString
            If IsNumeric(enteredText) AndAlso Val(enteredText) > 100 Then
                MessageBox.Show("Grade cannot exceed 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub StudentNameTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StudentNameTxtBox.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            ' Cancel the keypress event
            e.Handled = True
            ' Show error message
            MessageBox.Show("Numbers are not allowed in the name field!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' Allow control keys like backspace, delete, etc.
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            End If
        End If
    End Sub

    Private Sub cbSEC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSEC.SelectedIndexChanged
        Dim filterString As String = String.Empty


        ' Apply the filter to the DataGridView
        If TypeOf dgvMIDTERM.DataSource Is DataView Then
            DirectCast(dgvMIDTERM.DataSource, DataView).RowFilter = filterString
        ElseIf TypeOf dgvMIDTERM.DataSource Is DataTable Then
            DirectCast(dgvMIDTERM.DataSource, DataTable).DefaultView.RowFilter = filterString
        End If
    End Sub

    Private Sub cbSEM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSEM.SelectedIndexChanged

        Dim filterString As String = String.Empty

        ' Apply the filter to the DataGridView
        If TypeOf dgvMIDTERM.DataSource Is DataView Then
            DirectCast(dgvMIDTERM.DataSource, DataView).RowFilter = filterString
        ElseIf TypeOf dgvMIDTERM.DataSource Is DataTable Then
            DirectCast(dgvMIDTERM.DataSource, DataTable).DefaultView.RowFilter = filterString
        End If
    End Sub

    Private Sub cbSUB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSUB.SelectedIndexChanged
        Dim filterString As String = String.Empty

        ' Apply the filter to the DataGridView
        If TypeOf dgvMIDTERM.DataSource Is DataView Then
            DirectCast(dgvMIDTERM.DataSource, DataView).RowFilter = filterString
        ElseIf TypeOf dgvMIDTERM.DataSource Is DataTable Then
            DirectCast(dgvMIDTERM.DataSource, DataTable).DefaultView.RowFilter = filterString
        End If

    End Sub

    Private Sub patongPanel_Paint_1(sender As Object, e As PaintEventArgs) Handles patongPanel.Paint

    End Sub

    Private Sub dgvMIDTERM_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMIDTERM.CellContentClick

    End Sub
End Class