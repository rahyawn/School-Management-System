Imports System.Data
Imports System.Data.Common
Imports MySql.Data.MySqlClient

Public Class SemestralForm
    Dim cmd As New MySqlCommand()
    Dim dt As New DataTable()
    Dim da As New MySqlDataAdapter()
    Dim str As String = ""
    Dim result As String = ""
    Dim x As Integer = 0
    Dim con As New MySqlConnection("server=localhost; user=root; database=imvbnet_proj")
    Dim dv As DataView = Nothing
    Dim Midtermgrade As Double = 0.0
    Dim Finalgrade As Double = 0.0
    Dim average As Double = 0.0
    Dim SemGWA As String = ""

    Private Sub Semestral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXTmid.Text = midterm_avg
        txtFin.Text = final_avg
        Midtermgrade = Val(TXTmid.Text)
        TXTmid.Text = Midtermgrade.ToString("F2")
        Finalgrade = Val(txtFin.Text)
        txtFin.Text = Finalgrade.ToString("F2")
        CalculateSemestralGrade(Midtermgrade, Finalgrade)


        LoadComboBoxes()
    End Sub
    Private Function isFieldsEmpty() As Boolean
        Dim bool As Boolean = False
        bool = Not String.IsNullOrEmpty(StudentIDTxtBox.Text) And
           Not String.IsNullOrEmpty(Sub_txt.Text) And
           Not String.IsNullOrEmpty(sectionTxtBox.Text)
        Return bool
    End Function


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
    SA.section_code AS 'Section',
    MG.midterm_grade AS 'Midterm Grade',
    FG.final_grade AS 'Final Grade'
FROM 
    section_assign SA 
JOIN Student S ON S.student_id = SA.student_id 
JOIN subject_assign SBA ON SA.section_code = SBA.section_code 
JOIN Subject SB ON SBA.subject_code = SB.subject_code 
JOIN Professor P ON P.professor_id = SBA.professor_id
LEFT JOIN Midterm_gw MG ON MG.student_id = SA.student_id AND MG.subject_code = SBA.subject_code
LEFT JOIN Final_gw FG ON FG.student_id = SA.student_id AND FG.subject_code = SBA.subject_code;"

    Sub populateBtn_Click(sender As Object, e As EventArgs)
        pop()
    End Sub

    Private Sub btnPopulate_Click(sender As Object, e As EventArgs) Handles btnPopulate.Click
        ' Validate input
        If String.IsNullOrWhiteSpace(cbSEC.Text) Then
            MessageBox.Show("Please select a Section.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            sectionTxtBox.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(cbSEM.Text) Then
            MessageBox.Show("Please select a Semester.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbSEM.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(cbSUB.Text) Then
            MessageBox.Show("Please enter a Subject.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Sub_txt.Focus()
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
        dgvFinals.DataSource = dt
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

                ' Populate the midterm and final grade textboxes
                Dim studentID As String = selectedRow.Cells("Student ID").Value.ToString()
                Dim subjectCode As String = selectedRow.Cells("Subject Code").Value.ToString()
                Dim sectionCode As String = selectedRow.Cells("Section").Value.ToString()
                PopulateMidtermAndFinalGrades(studentID, subjectCode, sectionCode)
            Catch ex As Exception
                MessageBox.Show("Error retrieving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim response = MessageBox.Show("Check if all information is correct. Once you save it, it cannot be changed", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = DialogResult.Yes Then
            Try
                SaveToSemestral()
                MessageBox.Show("All information has been saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error saving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub CalculateSemestralGrade(ByVal midterm_grade As Double, ByVal final_grade As Double)
        ' Calculate the weighted average
        average = (midterm_grade + final_grade) / 2

        ' Default values for remarks
        SemGWA = "N/A"
        RemarksScoreLbl.Text = "NO GRADE"
        RemarksScoreLbl.BackColor = Color.Gray
        RemarksScoreLbl.ForeColor = Color.White
        RemarksScoreLbl.Visible = True

        ' Determine the grade and remarks based on the average
        If average >= 98 Then
            SemGWA = "1.00"
            RemarksScoreLbl.Text = "PASSED"
            RemarksScoreLbl.BackColor = Color.Green
            RemarksScoreLbl.ForeColor = Color.White
        ElseIf average >= 96 Then
            SemGWA = "1.25"
            RemarksScoreLbl.Text = "PASSED"
            RemarksScoreLbl.BackColor = Color.Green
            RemarksScoreLbl.ForeColor = Color.White
        ElseIf average >= 92 Then
            SemGWA = "1.50"
            RemarksScoreLbl.Text = "PASSED"
            RemarksScoreLbl.BackColor = Color.Green
            RemarksScoreLbl.ForeColor = Color.White
        ElseIf average >= 89 Then
            SemGWA = "1.75"
            RemarksScoreLbl.Text = "PASSED"
            RemarksScoreLbl.BackColor = Color.Green
            RemarksScoreLbl.ForeColor = Color.White
        ElseIf average >= 86 Then
            SemGWA = "2.00"
            RemarksScoreLbl.Text = "PASSED"
            RemarksScoreLbl.BackColor = Color.Green
            RemarksScoreLbl.ForeColor = Color.White
        ElseIf average >= 83 Then
            SemGWA = "2.25"
            RemarksScoreLbl.Text = "PASSED"
            RemarksScoreLbl.BackColor = Color.Green
            RemarksScoreLbl.ForeColor = Color.White
        ElseIf average >= 80 Then
            SemGWA = "2.50"
            RemarksScoreLbl.Text = "PASSED"
            RemarksScoreLbl.BackColor = Color.Green
            RemarksScoreLbl.ForeColor = Color.White
        ElseIf average >= 78 Then
            SemGWA = "2.75"
            RemarksScoreLbl.Text = "PASSED"
            RemarksScoreLbl.BackColor = Color.Green
            RemarksScoreLbl.ForeColor = Color.White
        ElseIf average >= 75 Then
            SemGWA = "3.00"
            RemarksScoreLbl.Text = "PASSED"
            RemarksScoreLbl.BackColor = Color.Green
            RemarksScoreLbl.ForeColor = Color.White
        ElseIf average <= 74.5 And average >= 70 Then
            SemGWA = "5.00"
            RemarksScoreLbl.Text = "FAILED"
            RemarksScoreLbl.BackColor = Color.Red
            RemarksScoreLbl.ForeColor = Color.White
        Else
            SemGWA = "Dropped"
            RemarksScoreLbl.Text = "FAILED"
            RemarksScoreLbl.BackColor = Color.Red
            RemarksScoreLbl.ForeColor = Color.White
        End If

        ' Update the semestral grade textbox
        txtSem.Text = SemGWA
        txtSem.Show()
    End Sub


    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Dim msgExit = MessageBox.Show("Do you want to EXIT?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If msgExit.Equals(DialogResult.Yes) Then
            Close()
        End If
    End Sub

    Private Sub PopulateMidtermAndFinalGrades(studentID As String, subjectCode As String, sectionCode As String)
        Try
            con.Open()

            ' Retrieve the midterm grade
            Dim midtermQuery As String = "SELECT midterm_grade 
                                         FROM midterm_gw
                                         WHERE student_id = @student_id 
                                           AND subject_code = @subject_code
                                           AND section_code = @section_code"
            Using midtermCmd As New MySqlCommand(midtermQuery, con)
                midtermCmd.Parameters.AddWithValue("@student_id", studentID)
                midtermCmd.Parameters.AddWithValue("@subject_code", subjectCode)
                midtermCmd.Parameters.AddWithValue("@section_code", sectionCode)
                Midtermgrade = CDbl(midtermCmd.ExecuteScalar())
                TXTmid.Text = Midtermgrade.ToString("F2")
            End Using

            ' Retrieve the final grade
            Dim finalQuery As String = "SELECT final_grade
                                        FROM final_gw
                                        WHERE student_id = @student_id
                                          AND subject_code = @subject_code
                                          AND section_code = @section_code"
            Using finalCmd As New MySqlCommand(finalQuery, con)
                finalCmd.Parameters.AddWithValue("@student_id", studentID)
                finalCmd.Parameters.AddWithValue("@subject_code", subjectCode)
                finalCmd.Parameters.AddWithValue("@section_code", sectionCode)
                Finalgrade = CDbl(finalCmd.ExecuteScalar())
                txtFin.Text = Finalgrade.ToString("F2")
            End Using

            ' Calculate the semestral grade
            CalculateSemestralGrade(Midtermgrade, Finalgrade)
        Catch ex As Exception
            MessageBox.Show("Error retrieving midterm and final grades: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub showGradeBtn_Click(sender As Object, e As EventArgs) Handles showGradeBtn.Click
        ' Clear previous values
        Midtermgrade = 0.0
        Finalgrade = 0.0
        TXTmid.Text = "0.00"
        txtFin.Text = "0.00"
        txtSem.Text = ""
        RemarksScoreLbl.Visible = False

        ' Validate that all required fields are filled
        If String.IsNullOrWhiteSpace(StudentIDTxtBox.Text) OrElse
       String.IsNullOrWhiteSpace(Sub_txt.Text) OrElse
       String.IsNullOrWhiteSpace(sectionTxtBox.Text) Then
            MessageBox.Show("Please fill in Student ID, Subject, and Section.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            ' Open the connection
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If


            ' Retrieve Midterm Grade
            Dim midtermQuery As String = "SELECT midterm_grade 
                                   FROM Midterm_gw 
                                   WHERE student_id = @student_id 
                                   AND subject_code = @subject_code 
                                   AND section_code = @section_code"

            Using midtermCmd As New MySqlCommand(midtermQuery, con)
                midtermCmd.Parameters.AddWithValue("@student_id", StudentIDTxtBox.Text.Trim())
                midtermCmd.Parameters.AddWithValue("@subject_code", Sub_txt.Text.Trim())
                midtermCmd.Parameters.AddWithValue("@section_code", sectionTxtBox.Text.Trim())

                ' Execute and get the midterm grade
                Dim midtermResult As Object = midtermCmd.ExecuteScalar()

                If midtermResult IsNot Nothing AndAlso Not Convert.IsDBNull(midtermResult) Then
                    Midtermgrade = Convert.ToDouble(midtermResult)
                    TXTmid.Text = Midtermgrade.ToString("F2")
                End If
            End Using

            ' Retrieve Final Grade
            Dim finalQuery As String = "SELECT final_grade 
                                 FROM Final_gw 
                                 WHERE student_id = @student_id 
                                 AND subject_code = @subject_code 
                                 AND section_code = @section_code"

            Using finalCmd As New MySqlCommand(finalQuery, con)
                finalCmd.Parameters.AddWithValue("@student_id", StudentIDTxtBox.Text.Trim())
                finalCmd.Parameters.AddWithValue("@subject_code", Sub_txt.Text.Trim())
                finalCmd.Parameters.AddWithValue("@section_code", sectionTxtBox.Text.Trim())

                ' Execute and get the final grade
                Dim finalResult As Object = finalCmd.ExecuteScalar()

                If finalResult IsNot Nothing AndAlso Not Convert.IsDBNull(finalResult) Then
                    Finalgrade = Convert.ToDouble(finalResult)
                    txtFin.Text = Finalgrade.ToString("F2")
                End If
            End Using

            ' Check if either grade was found
            If Midtermgrade = 0.0 AndAlso Finalgrade = 0.0 Then
                MessageBox.Show("No grades found for this student.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' Calculate Semestral Grade
                CalculateSemestralGrade(Midtermgrade, Finalgrade)
            End If

        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error retrieving grades: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure connection is closed
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
    Private Sub SaveToSemestral()
        Try
            Using con As New MySqlConnection("server=localhost; user=root; database=imvbnet_proj")
                con.Open()

                Dim query As String = "INSERT INTO semester (student_id, subject_code, section_code, " &
                        "midterm_grade, final_grade, semestral_grade, remarks) " &
                        "VALUES (@student_id, @subject_code, @section_code, " &
                        "@midterm_grade, @final_grade, @semestral_grade, @remarks)"

                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@student_id", StudentIDTxtBox.Text)
                    cmd.Parameters.AddWithValue("@subject_code", Sub_txt.Text)
                    cmd.Parameters.AddWithValue("@section_code", sectionTxtBox.Text)
                    cmd.Parameters.AddWithValue("@midterm_grade", Decimal.Parse(TXTmid.Text))
                    cmd.Parameters.AddWithValue("@final_grade", Decimal.Parse(txtFin.Text))
                    cmd.Parameters.AddWithValue("@semestral_grade", Decimal.Parse(txtSem.Text))
                    cmd.Parameters.AddWithValue("@remarks", RemarksScoreLbl.Text)

                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving to final_gw: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub sectionTxtBox_TextChanged(sender As Object, e As EventArgs) Handles sectionTxtBox.TextChanged

    End Sub

    Private Sub Sub_txt_TextChanged(sender As Object, e As EventArgs) Handles Sub_txt.TextChanged

    End Sub

    Private Sub dgvFinals_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFinals.CellContentClick

    End Sub
End Class