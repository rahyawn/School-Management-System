Imports MySql.Data.MySqlClient

Public Class PROFPROFILE_UPDATE
    Private selectedStudent As DataRow

    Public Sub PopulateStudentData(student As DataRow)
        ' Populate the form fields with the selected student data
        StudentIDTextBox.Text = student("student_id").ToString()
        SubjectCodeTextBox.Text = student("subject_code").ToString()
        SectionCodeTextBox.Text = student("section_code").ToString()

        ' Populate the remaining textboxes
        txtQuiz1Score.Text = student("Q1_score").ToString()
        txtQuiz1Items.Text = student("Q1_item").ToString()
        txtQuiz2Score.Text = student("Q2_score").ToString()
        txtQuiz2Items.Text = student("Q2_item").ToString()
        txtQuiz3Score.Text = student("Q3_score").ToString()
        txtQuiz3Items.Text = student("Q3_item").ToString()
        txtQuiz4Score.Text = student("Q4_score").ToString()
        txtQuiz4Items.Text = student("Q4_item").ToString()
        txtLab1Score.Text = student("LAB1_score").ToString()
        txtLab2Score.Text = student("LAB2_score").ToString()
        txtLab3Score.Text = student("LAB3_score").ToString()
        txtLab4Score.Text = student("LAB4_score").ToString()
        txtMidtermExamScore.Text = student("mid_exam_score").ToString()
        txtMidtermExamItem.Text = student("mid_exam_item").ToString()
        txtAttendancePercentage.Text = student("no_of_absences").ToString()
        txtRecitation.Text = student("recitation").ToString()
        txtCaseStudy.Text = student("case_study").ToString()

        selectedStudent = student
    End Sub

    ' Add these methods for percentage calculations
    Private Function CalculatePercentage(score As Decimal, items As Integer) As Decimal
        If items = 0 Then
            Return 0
        End If
        Return Math.Round((score / items) * 100, 2)
    End Function

    ' Validate that score does not exceed total items
    Private Function ValidateScore(score As Decimal, items As Integer) As Boolean
        Return score <= items
    End Function

    ' Modify Save button click to include confirmation prompt
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim response As DialogResult = MessageBox.Show("Are you sure you want to save the changes?", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = DialogResult.No Then
            Return
        End If

        Try
            ' Validate all quiz scores and items
            Dim quizValidations = {
                New With {.Score = txtQuiz1Score, .Items = txtQuiz1Items},
                New With {.Score = txtQuiz2Score, .Items = txtQuiz2Items},
                New With {.Score = txtQuiz3Score, .Items = txtQuiz3Items},
                New With {.Score = txtQuiz4Score, .Items = txtQuiz4Items}
            }

            Dim labValidations = {
                New With {.Score = txtLab1Score, .Items = Nothing},
                New With {.Score = txtLab2Score, .Items = Nothing},
                New With {.Score = txtLab3Score, .Items = Nothing},
                New With {.Score = txtLab4Score, .Items = Nothing}
            }

            ' Perform comprehensive validation
            Dim validationPassed As Boolean = True

            ' Validate Quiz Scores
            For Each quizItem In quizValidations
                Dim score As Decimal = Convert.ToDecimal(quizItem.Score.Text)
                Dim items As Integer = Convert.ToInt32(quizItem.Items.Text)

                If Not ValidateScore(score, items) Then
                    MessageBox.Show($"Score for {quizItem.Score.Name} cannot exceed total items.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    validationPassed = False
                    Exit For
                End If
            Next

            ' If validation fails, exit method
            If Not validationPassed Then
                Return
            End If

            ' Confirm before saving
            Dim response2 As DialogResult = MessageBox.Show("All entries Correct?", "Compute", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If response2 = DialogResult.Yes Then
                ' Calculate Quiz Percentage
                Dim totalQuizScore As Decimal = 0
                Dim totalQuizItems As Integer = 0
                For Each quizItem In quizValidations
                    totalQuizScore += Convert.ToDecimal(quizItem.Score.Text)
                    totalQuizItems += Convert.ToInt32(quizItem.Items.Text)
                Next
                Dim quizPercentage As Decimal = CalculatePercentage(totalQuizScore, totalQuizItems)
                txtQuizPercentage.Text = quizPercentage.ToString("F2")

                ' Calculate Lab Percentage (assuming no items for lab scores)
                Dim labScores() As Decimal = {
                    Convert.ToDecimal(txtLab1Score.Text),
                    Convert.ToDecimal(txtLab2Score.Text),
                    Convert.ToDecimal(txtLab3Score.Text),
                    Convert.ToDecimal(txtLab4Score.Text)
                }
                Dim labPercentage As Decimal = labScores.Average()
                txtLabPercentage.Text = labPercentage.ToString("F2")

                ' Midterm Exam Percentage Calculation
                Dim midtermScore As Decimal = Convert.ToDecimal(txtMidtermExamScore.Text)
                Dim midtermItems As Integer = Convert.ToInt32(txtMidtermExamItem.Text)
                Dim midtermPercentage As Decimal = CalculatePercentage(midtermScore, midtermItems)
                txtMidtermExamPercentage.Text = midtermPercentage.ToString("F2")

                ' Calculate Final Grade
                Dim attendance As Decimal = Convert.ToDecimal(txtAttendancePercentage.Text)
                Dim quizzes As Decimal = quizPercentage
                Dim labExercises As Decimal = labPercentage
                Dim midtermExam As Decimal = midtermPercentage
                Dim caseStudy As Decimal = Convert.ToDecimal(txtCaseStudy.Text)
                Dim recitation As Decimal = Convert.ToDecimal(txtRecitation.Text)

                Dim average As Decimal = (attendance * 0.05) +
                                     (quizzes * 0.15) +
                                     (labExercises * 0.2) +
                                     (midtermExam * 0.3) +
                                     (caseStudy * 0.2) +
                                     (recitation * 0.1)

                txtMidtermGrade.Text = average.ToString("F2")

                ' Set Remarks
                If average >= 74.6 Then
                    txtRemarks.Text = "PASSED"
                ElseIf average >= 70 AndAlso average <= 74.5 Then
                    txtRemarks.Text = "FAILED"
                Else
                    txtRemarks.Text = "DROPPED"
                End If

                ' Proceed with database update
                Using conn As New MySqlConnection("server=localhost; user=root; database=imvbnet_proj")
                    conn.Open()

                    Dim updateQuery As String = "UPDATE midterm SET " &
                    "Q1_score = @Q1Score, Q1_item = @Q1Item, " &
                    "Q2_score = @Q2Score, Q2_item = @Q2Item, " &
                    "Q3_score = @Q3Score, Q3_item = @Q3Item, " &
                    "Q4_score = @Q4Score, Q4_item = @Q4Item, " &
                    "LAB1_score = @Lab1Score, LAB2_score = @Lab2Score, " &
                    "LAB3_score = @Lab3Score, LAB4_score = @Lab4Score, " &
                    "mid_exam_score = @MidExamScore, mid_exam_item = @MidExamItem, " &
                    "no_of_absences = @Attendance, " &
                    "case_study = @CaseStudy, " &
                    "recitation = @Recitation " &
                    "WHERE student_id = @StudentID AND subject_code = @SubjectCode AND section_code = @SectionCode"

                    Using cmd As New MySqlCommand(updateQuery, conn)
                        ' Add parameters
                        cmd.Parameters.AddWithValue("@Q1Score", Convert.ToDecimal(txtQuiz1Score.Text))
                        cmd.Parameters.AddWithValue("@Q1Item", Convert.ToInt32(txtQuiz1Items.Text))
                        cmd.Parameters.AddWithValue("@Q2Score", Convert.ToDecimal(txtQuiz2Score.Text))
                        cmd.Parameters.AddWithValue("@Q2Item", Convert.ToInt32(txtQuiz2Items.Text))
                        cmd.Parameters.AddWithValue("@Q3Score", Convert.ToDecimal(txtQuiz3Score.Text))
                        cmd.Parameters.AddWithValue("@Q3Item", Convert.ToInt32(txtQuiz3Items.Text))
                        cmd.Parameters.AddWithValue("@Q4Score", Convert.ToDecimal(txtQuiz4Score.Text))
                        cmd.Parameters.AddWithValue("@Q4Item", Convert.ToInt32(txtQuiz4Items.Text))
                        cmd.Parameters.AddWithValue("@Lab1Score", Convert.ToDecimal(txtLab1Score.Text))
                        cmd.Parameters.AddWithValue("@Lab2Score", Convert.ToDecimal(txtLab2Score.Text))
                        cmd.Parameters.AddWithValue("@Lab3Score", Convert.ToDecimal(txtLab3Score.Text))
                        cmd.Parameters.AddWithValue("@Lab4Score", Convert.ToDecimal(txtLab4Score.Text))
                        cmd.Parameters.AddWithValue("@MidExamScore", Convert.ToDecimal(txtMidtermExamScore.Text))
                        cmd.Parameters.AddWithValue("@MidExamItem", Convert.ToInt32(txtMidtermExamItem.Text))
                        cmd.Parameters.AddWithValue("@Attendance", Convert.ToDecimal(txtAttendancePercentage.Text))
                        cmd.Parameters.AddWithValue("@CaseStudy", Convert.ToDecimal(txtCaseStudy.Text))
                        cmd.Parameters.AddWithValue("@Recitation", Convert.ToDecimal(txtRecitation.Text))
                        cmd.Parameters.AddWithValue("@StudentID", StudentIDTextBox.Text)
                        cmd.Parameters.AddWithValue("@SubjectCode", SubjectCodeTextBox.Text)
                        cmd.Parameters.AddWithValue("@SectionCode", SectionCodeTextBox.Text)

                        ' Execute the update
                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("No records were updated.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using
                End Using
            End If
        Catch ex As FormatException
            MessageBox.Show("Please enter valid numeric values for all score fields.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error updating record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Modify Clear button click to include confirmation prompt
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim response As DialogResult = MessageBox.Show("Are you sure you want to clear all fields? This action cannot be undone.", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If response = DialogResult.No Then
            Return
        End If

        ' Clear all the textboxes
        txtQuiz1Score.Clear()
        txtQuiz1Items.Clear()
        txtQuiz2Score.Clear()
        txtQuiz2Items.Clear()
        txtQuiz3Score.Clear()
        txtQuiz3Items.Clear()
        txtQuiz4Score.Clear()
        txtQuiz4Items.Clear()
        txtLab1Score.Clear()
        txtLab2Score.Clear()
        txtLab3Score.Clear()
        txtLab4Score.Clear()
        txtMidtermExamScore.Clear()
        txtMidtermExamItem.Clear()
        txtAttendancePercentage.Clear()
        txtRecitation.Clear()
        txtCaseStudy.Clear()
        txtQuizPercentage.Clear()
        txtLabPercentage.Clear()
        txtMidtermExamPercentage.Clear()
        txtMidtermGrade.Clear()
        txtRemarks.Clear()
    End Sub

    ' Modify Exit button click to include confirmation prompt
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim response As DialogResult = MessageBox.Show("Are you sure you want to exit? Any unsaved changes will be lost.", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If response = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
