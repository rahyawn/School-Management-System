Imports System.Data
Imports System.Data.Common
Imports MySql.Data.MySqlClient

Public Class FinalsForm
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable
    Dim da As New MySqlDataAdapter
    Dim str, result As String
    Dim x As Integer
    Dim con As New MySqlConnection("server=localhost; user=root; database=imvbnet_proj")
    Dim dv As DataView



    Private Sub Finals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AttendanceFinalsTxtBox.Enabled = False
        FinalsPercentPanel.Visible = False
        GradeEquivalentPanel.Visible = False
        FinalGradeBorderPanel.Visible = False
        FinalGradeLbl.Visible = False
        ClearAllFinalsBtn.Visible = False
        ComputeFinalsBtn.Visible = False
        SaveBtn.Visible = False
        patongPanel.Visible = True

        LoadComboBoxes()
    End Sub


    Private Sub cbSEC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSEC.SelectedIndexChanged
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
            dgvFinals.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Error filtering by section: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbSUB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSUB.SelectedIndexChanged
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
            dgvFinals.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Error filtering by subject: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
            dgvFinals.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Error filtering data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
    Sub populateBtn_Click(sender As Object, e As EventArgs)
        pop()
    End Sub

    Private Sub btnPopulate_Click(sender As Object, e As EventArgs) Handles btnPopulate.Click
        ' Validate input
        If String.IsNullOrWhiteSpace(cbSEC.Text) Then
            MessageBox.Show("Please select a Section.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbSEC.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(cbSEM.Text) Then
            MessageBox.Show("Please select a Semester.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbSEM.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(cbSUB.Text) Then
            MessageBox.Show("Please enter a Subject.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbSUB.Focus()
            Exit Sub
        End If

        pop()
    End Sub

    Private Sub pop()
        dt.Clear()

        con.Open()
        cmd.Connection = con
        cmd.CommandText = queryString ' Set the CommandText property
        da.SelectCommand = cmd
        da.Fill(dt)
        dgvFINALs.DataSource = dt
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
                If TypeOf dgvFinals.DataSource Is DataView Then
                    DirectCast(dgvFinals.DataSource, DataView).RowFilter = filterExpression
                ElseIf TypeOf dgvFinals.DataSource Is DataTable Then
                    DirectCast(dgvFinals.DataSource, DataTable).DefaultView.RowFilter = filterExpression
                End If
            Else
                ' Reset the filter if the search text is empty
                DirectCast(dgvFinals.DataSource, DataTable).DefaultView.RowFilter = String.Empty
            End If
        Catch ex As Exception
            MessageBox.Show("Error searching: " & ex.Message & System.Environment.NewLine & "Please check your input.")
        End Try
    End Sub




    Private Sub dgvFINALS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFinals.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgvFinals.Rows(e.RowIndex)
            Try
                StudentIDTxtBox.Text = selectedRow.Cells("Student ID").Value.ToString
                Sub_txt.Text = selectedRow.Cells("Subject Code").Value.ToString
                sectionTxtBox.Text = selectedRow.Cells("Section").Value.ToString
                StudentNameTxtBox.Text = selectedRow.Cells("Name").Value.ToString()

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

        If String.IsNullOrEmpty(cbSUB.Text) Then
            emptyFields.AppendLine("- Subject")
        End If

        If cbSEC.SelectedItem Is Nothing Then
            emptyFields.AppendLine("- Section")
        End If

        Return emptyFields.ToString()
    End Function

    Private Sub AttendanceFinalsTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AttendanceFinalsTxtBox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim ValidNum = "1234567890-"

            If Not ValidNum.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Only NUMBERS are Accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If

            Dim enteredText As String = AttendanceFinalsTxtBox.Text & e.KeyChar.ToString()
            If IsNumeric(enteredText) AndAlso Val(enteredText) > 100 Then
                MessageBox.Show("Grade cannot exceed 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub QuizFinalsTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles QuizFinalsTxtBox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim ValidNum = "1234567890-"

            If Not ValidNum.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Only NUMBERS are Accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If

            Dim enteredText As String = QuizFinalsTxtBox.Text & e.KeyChar.ToString()
            If IsNumeric(enteredText) AndAlso Val(enteredText) > 100 Then
                MessageBox.Show("Grade cannot exceed 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub FinalExamTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FinalExamTxtBox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim ValidNum = "1234567890-"

            If Not ValidNum.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Only NUMBERS are Accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If

            Dim enteredText As String = FinalExamTxtBox.Text & e.KeyChar.ToString()
            If IsNumeric(enteredText) AndAlso Val(enteredText) > 100 Then
                MessageBox.Show("Grade cannot exceed 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ClearAllFinalsBtn_Click(sender As Object, e As EventArgs) Handles ClearAllFinalsBtn.Click
        ResetTextBoxStates()
        AttendanceFinalsTxtBox.Clear()
        QuizFinalsTxtBox.Clear()
        FinalExamTxtBox.Clear()
        LabExerTxtbox.Clear()
        ProjTxtbox.Clear()
        FinalGradePromptTxtBox.Clear()
        StudentIDTxtBox.Clear()
        cbSEC.SelectedIndex = -1
        cbSEM.SelectedIndex = -1
        cbSUB.SelectedIndex = -1
        NumberOfQuizComboBox.SelectedIndex = -1
        Q1InputTxtBox.Clear()
        Q2InputTxtBox.Clear()
        Q3InputTxtBox.Clear()
        Q4InputTxtBox.Clear()
        Q1MaxTxtBot.Clear()
        Q2MaxTxtBox.Clear()
        Q3MaxTxtBox.Clear()
        Q4MaxTxtBox.Clear()
        QuizTotalScoreTxtBox.Clear()
        QuizTotalItemsTextBox.Clear()
        InputFinalsExamTxtBox.Clear()
        MaxFinalExamTxtBox.Clear()
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

    Sub Calculate_FinalExam()
        If String.IsNullOrEmpty(InputFinalsExamTxtBox.Text) OrElse String.IsNullOrEmpty(MaxFinalExamTxtBox.Text) Then
            MessageBox.Show("Please enter score and its maximum value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim FinalInputScore, FinalMaxScore As Integer
        FinalInputScore = InputFinalsExamTxtBox.Text
        FinalMaxScore = MaxFinalExamTxtBox.Text

        If FinalInputScore > FinalMaxScore Then
            MessageBox.Show("Score cannot be higher than the maximum items", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim FinalExamPercentScore As Integer
        FinalExamPercentScore = (FinalInputScore / FinalMaxScore) * 50 + 50
        FinalExamTxtBox.Text = FinalExamPercentScore.ToString
        FinalExamTxtBox.Show()
    End Sub

    Private Sub ComputeFinalsBtn_Click(sender As Object, e As EventArgs) Handles ComputeFinalsBtn.Click
        Dim response As Byte
        response = MessageBox.Show("All entries Correct?", "Compute", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = DialogResult.Yes Then
            Dim attendance As Double = Val(AttendanceFinalsTxtBox.Text) ' 5%
            Dim quizzes As Double = Val(QuizFinalsTxtBox.Text) ' 15%
            Dim labExercises As Double = Val(LabExerTxtbox.Text) ' 20%
            Dim midtermExam As Double = Val(FinalExamTxtBox.Text) ' 30%
            Dim caseStudy As Double = Val(ProjTxtbox.Text) ' 20%

            ' Calculate the weighted average
            Dim Finalaverage As Double = (attendance * 0.05) + (quizzes * 0.15) + (labExercises * 0.2) + (midtermExam * 0.3) + (caseStudy * 0.2)

            FinalGradePromptTxtBox.Text = Finalaverage.ToString("F2")
            final_grade = Convert.ToDecimal(Finalaverage)
            final_avg = Finalaverage
        End If

        Dim Score As Double
        Score = Val(FinalGradePromptTxtBox.Text)

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

    Private Sub FinalGradePromptTxtBox_TextChanged(sender As Object, e As EventArgs) Handles FinalGradePromptTxtBox.TextChanged

    End Sub



    Private Sub StudentIDFinalsTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Asc(e.KeyChar) = 8 Then
            Dim ValidNum = "1234567890-"

            If Not ValidNum.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Only NUMBERS are Accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub LabExerTxtbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LabExerTxtbox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim ValidNum = "1234567890-"

            If Not ValidNum.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Only NUMBERS are Accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If

            Dim enteredText As String = LabExerTxtbox.Text & e.KeyChar.ToString()
            If IsNumeric(enteredText) AndAlso Val(enteredText) > 100 Then
                MessageBox.Show("Grade cannot exceed 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ProjTxtbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ProjTxtbox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim ValidNum = "1234567890-"

            If Not ValidNum.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Only NUMBERS are Accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If

            Dim enteredText As String = ProjTxtbox.Text & e.KeyChar.ToString()
            If IsNumeric(enteredText) AndAlso Val(enteredText) > 100 Then
                MessageBox.Show("Grade cannot exceed 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
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

    Private final_grade As Decimal
    Private final_avg As Double
    Private attendance_percentage As Decimal
    Private quiz_percentage As Decimal
    Private lab_percentage As Decimal
    Private case_study_percentage As Decimal
    Private final_exam_percentage As Decimal

    Private Sub SaveToFinal_gw()
        Try
            Using con As New MySqlConnection("server=localhost; user=root; database=imvbnet_proj")
                con.Open()

                Dim query As String = "INSERT INTO final_gw (student_id, subject_code, section_code, " &
                            "attendance_percentage, quiz_percentage, lab_percentage, " &
                            "case_study, final_exam_percentage, final_grade, remarks) " &
                            "VALUES (@student_id, @subject_code, @section_code, " &
                            "@attendance, @quiz, @lab, @case_study, @final_exam, @final_grade, @remarks)"

                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@student_id", StudentIDTxtBox.Text)
                    cmd.Parameters.AddWithValue("@subject_code", Sub_txt.Text)
                    cmd.Parameters.AddWithValue("@section_code", sectionTxtBox.Text)
                    cmd.Parameters.AddWithValue("@attendance", Convert.ToDecimal(AttendanceFinalsTxtBox.Text))
                    cmd.Parameters.AddWithValue("@quiz", Convert.ToDecimal(QuizFinalsTxtBox.Text))
                    cmd.Parameters.AddWithValue("@lab", Convert.ToDecimal(LabExerTxtbox.Text))
                    cmd.Parameters.AddWithValue("@case_study", Convert.ToDecimal(ProjTxtbox.Text))
                    cmd.Parameters.AddWithValue("@final_exam", Convert.ToDecimal(FinalExamTxtBox.Text))
                    cmd.Parameters.AddWithValue("@final_grade", final_grade)
                    cmd.Parameters.AddWithValue("@remarks", RemarksScoreLbl.Text)

                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving to final_gw: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SaveToFinal()
        Try
            Using con As New MySqlConnection("server=localhost; user=root; database=imvbnet_proj")
                con.Open()

                Dim query As String = "INSERT INTO final (student_id, subject_code, section_code, " &
                            "no_of_absences, Q1_score, Q1_item, Q2_score, Q2_item, " &
                            "Q3_score, Q3_item, Q4_score, Q4_item, " &
                            "LAB1_score, LAB2_score, LAB3_score, LAB4_score, " &
                            "final_exam_score, final_exam_item, case_study) " &
                            "VALUES (@student_id, @subject_code, @section_code, " &
                            "@absences, @q1_score, @q1_item, @q2_score, @q2_item, " &
                            "@q3_score, @q3_item, @q4_score, @q4_item, " &
                            "@lab1, @lab2, @lab3, @lab4, " &
                            "@final_exam_score, @final_exam_item, @case_study)"

                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@student_id", StudentIDTxtBox.Text)
                    cmd.Parameters.AddWithValue("@subject_code", Sub_txt.Text)
                    cmd.Parameters.AddWithValue("@section_code", sectionTxtBox.Text)
                    cmd.Parameters.AddWithValue("@absences", AttendanceComboBox.Text)
                    cmd.Parameters.AddWithValue("@q1_score", If(String.IsNullOrEmpty(Q1InputTxtBox.Text), DBNull.Value, Convert.ToInt32(Q1InputTxtBox.Text)))
                    cmd.Parameters.AddWithValue("@q1_item", If(String.IsNullOrEmpty(Q1InputTxtBox.Text), DBNull.Value, Convert.ToInt32(Q1MaxTxtBot.Text)))
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
                    cmd.Parameters.AddWithValue("@final_exam_score", If(String.IsNullOrEmpty(InputFinalsExamTxtBox.Text), DBNull.Value, Convert.ToInt32(InputFinalsExamTxtBox.Text)))
                    cmd.Parameters.AddWithValue("@final_exam_item", If(String.IsNullOrEmpty(MaxFinalExamTxtBox.Text), DBNull.Value, Convert.ToInt32(MaxFinalExamTxtBox.Text)))
                    cmd.Parameters.AddWithValue("@case_study", Convert.ToInt32(ProjTxtbox.Text))

                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving to final: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim response = MessageBox.Show("Check if all information is correct. Once you save it, it cannot be changed", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = DialogResult.Yes Then
            Try
                SaveToFinal()
                SaveToFinal_gw()

                MessageBox.Show("All information has been saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearAllFinalsBtn_Click(Nothing, Nothing) ' Clear all fields after successful save
            Catch ex As Exception
                MessageBox.Show("Error saving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub showGradeBtn_Click(sender As Object, e As EventArgs) Handles showGradeBtn.Click
        Dim check = isFieldsEmpty()

        If check Then
            ResetTextBoxStates()
            AttendanceFinalsTxtBox.Enabled = False
            patongPanel.Visible = False
            FinalsPercentPanel.Visible = True
            GradeEquivalentPanel.Visible = True
            FinalGradeBorderPanel.Visible = True
            FinalGradeLbl.Visible = True
            ClearAllFinalsBtn.Visible = True
            ComputeFinalsBtn.Visible = True
            SaveBtn.Visible = True
            Q1InputTxtBox.Enabled = False
            Q1MaxTxtBot.Enabled = False
            Q2InputTxtBox.Enabled = False
            Q2MaxTxtBox.Enabled = False
            Q3InputTxtBox.Enabled = False
            Q3MaxTxtBox.Enabled = False
            Q4InputTxtBox.Enabled = False
            Q4MaxTxtBox.Enabled = False
            LabExerTxtbox.Enabled = False
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

    Private Sub FinalExamComputeBtn_Click(sender As Object, e As EventArgs) Handles FinalExamComputeBtn.Click
        Calculate_FinalExam()
    End Sub

    Private Sub InitializeQuizFields()
        ' Disable all quiz input fields initially
        Q1InputTxtBox.Enabled = False
        Q1MaxTxtBot.Enabled = False
        Q2InputTxtBox.Enabled = False
        Q2MaxTxtBox.Enabled = False
        Q3InputTxtBox.Enabled = False
        Q3MaxTxtBox.Enabled = False
        Q4InputTxtBox.Enabled = False
        Q4MaxTxtBox.Enabled = False
    End Sub


    Private Sub UpdateQuizFields(numberOfQuizzes As Integer)
        ' First disable all textboxes
        Q1MaxTxtBot.Enabled = False
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
                Q1MaxTxtBot.Enabled = True
                CheckMaxTextBox(Q1MaxTxtBot, Q1InputTxtBox)
            Case 2
                Q1MaxTxtBot.Enabled = True
                Q2MaxTxtBox.Enabled = True
                CheckMaxTextBox(Q1MaxTxtBot, Q1InputTxtBox)
                CheckMaxTextBox(Q2MaxTxtBox, Q2InputTxtBox)
            Case 3
                Q1MaxTxtBot.Enabled = True
                Q2MaxTxtBox.Enabled = True
                Q3MaxTxtBox.Enabled = True
                CheckMaxTextBox(Q1MaxTxtBot, Q1InputTxtBox)
                CheckMaxTextBox(Q2MaxTxtBox, Q2InputTxtBox)
                CheckMaxTextBox(Q3MaxTxtBox, Q3InputTxtBox)
            Case 4
                Q1MaxTxtBot.Enabled = True
                Q2MaxTxtBox.Enabled = True
                Q3MaxTxtBox.Enabled = True
                Q4MaxTxtBox.Enabled = True
                CheckMaxTextBox(Q1MaxTxtBot, Q1InputTxtBox)
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

    Sub Calculate_Quizzes()
        Dim QuizOneScore, QuizOneItems, QuizTwoScore, QuizTwoItems As Integer
        Dim QuizThreeScore, QuizThreeItems, QuizFourScore, QuizFourItems As Integer
        Dim TotalQuizPercentage As Double = 0
        Dim QuizCount As Integer = 0
        Dim QuizInputItems As Integer = 0
        Dim QuizMaxItems As Integer = 0


        ' Handle Quiz 1
        If Not String.IsNullOrEmpty(Q1InputTxtBox.Text) AndAlso Not String.IsNullOrEmpty(Q1MaxTxtBot.Text) Then
            QuizOneScore = Convert.ToInt32(Q1InputTxtBox.Text)
            QuizOneItems = Convert.ToInt32(Q1MaxTxtBot.Text)

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
        QuizFinalsTxtBox.Text = QuizPercentage.ToString() ' Shows percentage with 2 decimal places

        ' Make textboxes visible
        QuizTotalScoreTxtBox.Show()
        QuizTotalItemsTextBox.Show()
        QuizFinalsTxtBox.Show()

    End Sub


    ' Add these event handlers for each Max TextBox
    Private Sub Q1MaxTxtBox_TextChanged(sender As Object, e As EventArgs) Handles Q1MaxTxtBot.TextChanged
        CheckMaxTextBox(Q1MaxTxtBot, Q1InputTxtBox)
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

    Private Sub Q1MaxTxtBot_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Q1MaxTxtBot.KeyPress
        If Not Asc(e.KeyChar) = 8 Then
            Dim ValidNum = "1234567890-"

            If Not ValidNum.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Only NUMBERS are Accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If

            Dim enteredText = Q1MaxTxtBot.Text & e.KeyChar.ToString
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
    Sub QuizComputeBtn_Click(sender As Object, e As EventArgs) Handles QuizComputeBtn.Click
        Calculate_Quizzes()
    End Sub

    Private Sub AttendanceComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AttendanceComboBox.SelectedIndexChanged

        Dim absences As Integer
        If Integer.TryParse(AttendanceComboBox.SelectedItem.ToString, absences) Then

            Const totalClasses = 16


            If absences >= 10 AndAlso absences <= 16 Then
                NumberOfLabExerciseComboBox.Enabled = False
                NumberOfQuizComboBox.Enabled = False
                LabExerTxtbox.Enabled = False
                ProjTxtbox.Enabled = False
                InputFinalsExamTxtBox.Enabled = False
                MaxFinalExamTxtBox.Enabled = False


            Else

                Dim attendancePercentage As Integer = (totalClasses - absences) / totalClasses * 100


                AttendanceFinalsTxtBox.Text = Format(attendancePercentage)
                AttendanceFinalsTxtBox.ForeColor = Color.Black
            End If
        Else
            AttendanceFinalsTxtBox.Text = "Invalid Input"
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
        LabExerTxtbox.Enabled = True
        ProjTxtbox.Enabled = True
        InputFinalsExamTxtBox.Enabled = True
        MaxFinalExamTxtBox.Enabled = True

    End Sub

    Sub Calculate_LabExercises()

        Dim Exercise1, Exercise2, Exercise3, Exercise4 As Integer
        If Not String.IsNullOrEmpty(Lab1TxtBox.Text) Then
            Exercise1 = Convert.ToInt32(Lab1TxtBox.Text)

            Dim LabScore1 As Integer = (Exercise1 / 100) * 100
            LabExerTxtbox.Text = LabScore1.ToString()
            LabExerTxtbox.Show()

        End If

        If Not String.IsNullOrEmpty(Lab2TxtBox.Text) AndAlso Not String.IsNullOrEmpty(Lab1TxtBox.Text) Then
            Exercise1 = Convert.ToInt32(Lab1TxtBox.Text)
            Exercise2 = Convert.ToInt32(Lab2TxtBox.Text)

            Dim LabScore2 As Integer = (Exercise1 + Exercise2) / 2
            LabExerTxtbox.Text = LabScore2.ToString()
            LabExerTxtbox.Show()

        End If

        If Not String.IsNullOrEmpty(Lab3TxtBox.Text) Then
            Exercise3 = Convert.ToInt32(Lab3TxtBox.Text)

            Dim LabScore3 As Integer = (Exercise1 + Exercise2 + Exercise3) / 3
            LabExerTxtbox.Text = LabScore3.ToString()
            LabExerTxtbox.Show()

        End If

        If Not String.IsNullOrEmpty(Lab4TxtBox.Text) Then
            Exercise4 = Convert.ToInt32(Lab4TxtBox.Text)

            Dim LabScore4 As Integer = (Exercise1 + Exercise2 + Exercise3 + Exercise4) / 4
            LabExerTxtbox.Text = LabScore4.ToString()
            LabExerTxtbox.Show()

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

    Private Sub InputFinalsExamTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles InputFinalsExamTxtBox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim ValidNum = "1234567890-"

            If Not ValidNum.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Only NUMBERS are Accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If

            Dim enteredText As String = InputFinalsExamTxtBox.Text & e.KeyChar.ToString()
            If IsNumeric(enteredText) AndAlso Val(enteredText) > 100 Then
                MessageBox.Show("Grade cannot exceed 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub MaxFinalExamTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaxFinalExamTxtBox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim ValidNum = "1234567890-"

            If Not ValidNum.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Only NUMBERS are Accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If

            Dim enteredText As String = MaxFinalExamTxtBox.Text & e.KeyChar.ToString()
            If IsNumeric(enteredText) AndAlso Val(enteredText) > 100 Then
                MessageBox.Show("Grade cannot exceed 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub StudentNameFinalsTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            ' Cancel the keypress event
            e.Handled = True
            ' Show error message
            MessageBox.Show("Numbers are not allowed in the name field!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Allow control keys like backspace, delete, etc.
        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub


    Private Sub StudentIDTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Asc(e.KeyChar) = 8 Then
            Dim ValidNum = "1234567890-"

            If Not ValidNum.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Only NUMBERS are Accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub patongPanel_Paint(sender As Object, e As PaintEventArgs) Handles patongPanel.Paint

    End Sub

    Private Sub dgvFinals_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFinals.CellContentClick

    End Sub

End Class