Imports System.Data
Imports MySql.Data.MySqlClient

Public Class FINAL_GRADE
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable
    Dim da As New MySqlDataAdapter
    Dim str, result As String
    Dim x As Integer
    Dim con As New MySqlConnection("server=localhost; user=root; database=imvbnet_proj")
    Dim dv As DataView
    Dim selectedStudent As DataRow

    Private Sub ProfProfileForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Disable the Populate button initially
        PopulateButton1.Enabled = False
        ' Load distinct values into comboboxes
        LoadComboboxValues()
    End Sub


    Private Sub FINAL_GRADE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Existing initialization code...

        ' Make the DataGridView read-only
        DataGridView1.ReadOnly = True

        ' Prevent user from adding new rows
        DataGridView1.AllowUserToAddRows = False

        ' Prevent user from deleting rows
        DataGridView1.AllowUserToDeleteRows = False

        ' Disable row header selection (optional)
        DataGridView1.RowHeadersVisible = False

        ' Ensure the selection mode prevents cell editing
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub


    Private Sub LoadComboboxValues()
        Try
            ' Open the database connection
            con.Open()

            ' Populate Section Combobox
            Dim sectionQuery As String = "SELECT DISTINCT section_code FROM final"
            cmd = New MySqlCommand(sectionQuery, con)
            Dim sectionReader As MySqlDataReader = cmd.ExecuteReader()
            While sectionReader.Read()
                cbSEC1.Items.Add(sectionReader("section_code").ToString())
            End While
            sectionReader.Close()

            ' Populate Semester Combobox
            Dim studentQuery As String = "SELECT DISTINCT student_id FROM final"
            cmd = New MySqlCommand(studentQuery, con)
            Dim studentReader As MySqlDataReader = cmd.ExecuteReader()
            While studentReader.Read()
                cbSTUD1.Items.Add(studentReader("student_id").ToString())
            End While
            studentReader.Close()

            ' Populate Subject Combobox
            Dim subjectQuery As String = "SELECT DISTINCT subject_code FROM final"
            cmd = New MySqlCommand(subjectQuery, con)
            Dim subjectReader As MySqlDataReader = cmd.ExecuteReader()
            While subjectReader.Read()
                cbSUB1.Items.Add(subjectReader("subject_code").ToString())
            End While
            subjectReader.Close()

            ' Close the database connection
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading combobox values: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub PopulateButton_Click(sender As Object, e As EventArgs) Handles PopulateButton1.Click
        Try
            ' Open the database connection
            con.Open()
            ' Construct the SQL query to retrieve the data from the final table
            Dim query As String = "SELECT * FROM final WHERE section_code = @Section AND student_id = @Student AND subject_code = @Subject;"
            cmd = New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Section", If(cbSEC1.SelectedItem, String.Empty))
            cmd.Parameters.AddWithValue("@Student", If(cbSTUD1.SelectedItem, String.Empty))
            cmd.Parameters.AddWithValue("@Subject", If(cbSUB1.SelectedItem, String.Empty))
            ' Execute the query and populate the DataTable
            da = New MySqlDataAdapter(cmd)
            dt.Clear()
            da.Fill(dt)
            ' Check if DataTable is populated
            If dt.Rows.Count = 0 Then
                MessageBox.Show("No data found.")
            Else
                DataGridView1.DataSource = dt
            End If
        Catch ex As Exception
            MessageBox.Show("Error populating data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the database connection
            con.Close()
        End Try
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Check if the clicked row is a valid data row (not header or empty row)
        If e.RowIndex >= 0 AndAlso e.RowIndex < DataGridView1.Rows.Count Then
            ' Additional check to ensure the row is not empty
            Dim currentRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            If Not currentRow.IsNewRow Then
                Try
                    ' Safely get the data bound item
                    Dim rowView As DataRowView = TryCast(currentRow.DataBoundItem, DataRowView)
                    If rowView IsNot Nothing Then
                        selectedStudent = rowView.Row

                        ' Populate the textboxes with the values from the selected row
                        StudentIDTextBox1.Text = selectedStudent("student_id").ToString()
                        SubjectCodeTextBox1.Text = selectedStudent("subject_code").ToString()
                        SectionCodeTextBox1.Text = selectedStudent("section_code").ToString()

                        ' Set the TextBoxes to be read-only
                        StudentIDTextBox1.ReadOnly = True
                        SubjectCodeTextBox1.ReadOnly = True
                        SectionCodeTextBox1.ReadOnly = True
                    Else
                        ' Clear the selected student if no valid row is selected
                        selectedStudent = Nothing
                        ClearTextBoxes()
                    End If
                Catch ex As Exception
                    ' Handle any unexpected errors
                    MessageBox.Show("Error selecting row: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    selectedStudent = Nothing
                    ClearTextBoxes()
                End Try
            End If
        End If
    End Sub

    ' Helper method to clear text boxes
    Private Sub ClearTextBoxes()
        StudentIDTextBox1.Clear()
        SubjectCodeTextBox1.Clear()
        SectionCodeTextBox1.Clear()
        StudentIDTextBox1.ReadOnly = False
        SubjectCodeTextBox1.ReadOnly = False
        SectionCodeTextBox1.ReadOnly = False
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton1.Click
        ' Check if a student has been selected
        If selectedStudent IsNot Nothing Then
            ' Open the PROFPROFILE_UPDATE form
            Dim profupdateProfileUpdateForm As New PROF_UPDATE_FINALS()
            profupdateProfileUpdateForm.PopulateStudentData(selectedStudent)
            profupdateProfileUpdateForm.ShowDialog()
        Else
            MessageBox.Show("Please select a student first.")
        End If
    End Sub


    Private Sub cbSEC1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSEC1.SelectedIndexChanged
        CheckFields()
    End Sub

    Private Sub cbSTU1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSTUD1.SelectedIndexChanged
        CheckFields()
    End Sub

    Private Sub cbSUB1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSUB1.SelectedIndexChanged
        CheckFields()
    End Sub

    Private Sub cbSTUD1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSTUD1.SelectedIndexChanged
        CheckFields()
    End Sub

    Private Sub CheckFields()
        If cbSEC1.SelectedIndex <> -1 AndAlso cbSTUD1.SelectedIndex <> -1 AndAlso cbSUB1.SelectedIndex <> -1 Then
            PopulateButton1.Enabled = True
        Else
            PopulateButton1.Enabled = False
        End If
    End Sub

    Private Function CheckIfStudentExists(studentID As String) As Boolean
        Try
            ' Open the database connection
            con.Open()
            ' Construct the SQL query to check if the student exists in the final table
            Dim query As String = "SELECT DISTINCT student_id FROM final WHERE student_id = @studentID;"
            cmd = New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@studentID", studentID)
            ' Execute the query and check if any rows are returned
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            Dim exists As Boolean = reader.HasRows
            ' Close the reader and the database connection
            reader.Close()
            con.Close()
            ' Return whether the student exists
            Return exists
        Catch ex As Exception
            MessageBox.Show("Error checking student existence: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            Return False
        End Try
    End Function

    Private Sub BackgroundPanel_Paint(sender As Object, e As PaintEventArgs) Handles BackgroundPanel.Paint

    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub showGradeBtn1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub exitbtn_Click(sender As Object, e As EventArgs) Handles exitbtn.Click

    End Sub
End Class
