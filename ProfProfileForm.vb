Imports System.Data
Imports MySql.Data.MySqlClient

Public Class ProfProfileForm
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
        PopulateButton.Enabled = False
        ' Load distinct values into comboboxes
        LoadComboboxValues()
    End Sub

    Private Sub LoadComboboxValues()
        Try
            ' Open the database connection
            con.Open()

            ' Populate Section Combobox
            Dim sectionQuery As String = "SELECT DISTINCT section_code FROM midterm"
            cmd = New MySqlCommand(sectionQuery, con)
            Dim sectionReader As MySqlDataReader = cmd.ExecuteReader()
            While sectionReader.Read()
                cbSEC.Items.Add(sectionReader("section_code").ToString())
            End While
            sectionReader.Close()

            ' Populate Semester Combobox
            Dim studentQuery As String = "SELECT DISTINCT student_id FROM midterm"
            cmd = New MySqlCommand(studentQuery, con)
            Dim studentReader As MySqlDataReader = cmd.ExecuteReader()
            While studentReader.Read()
                cbStudentID.Items.Add(studentReader("student_id").ToString())
            End While
            studentReader.Close()

            ' Populate Subject Combobox
            Dim subjectQuery As String = "SELECT DISTINCT subject_code FROM midterm"
            cmd = New MySqlCommand(subjectQuery, con)
            Dim subjectReader As MySqlDataReader = cmd.ExecuteReader()
            While subjectReader.Read()
                cbSUB.Items.Add(subjectReader("subject_code").ToString())
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

    Private Sub PopulateButton_Click(sender As Object, e As EventArgs) Handles PopulateButton.Click
        Try
            ' Open the database connection
            con.Open()
            ' Construct the SQL query to retrieve the data from the midterm table
            Dim query As String = "SELECT * FROM midterm WHERE section_code = @Section AND student_id = @Student AND subject_code = @Subject;"
            cmd = New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Section", cbSEC.SelectedItem)
            cmd.Parameters.AddWithValue("@Student", cbStudentID.SelectedItem)
            cmd.Parameters.AddWithValue("@Subject", cbSUB.SelectedItem)
            ' Execute the query and populate the DataTable
            da = New MySqlDataAdapter(cmd)
            dt.Clear()
            da.Fill(dt)
            ' Debug: Print the number of rows in the DataTable
            MessageBox.Show("Number of rows: " & dt.Rows.Count.ToString())
            ' Bind the DataTable to the DataGridView
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error populating data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the database connection
            con.Close()
        End Try
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Get the selected row
        If e.RowIndex >= 0 Then
            selectedStudent = CType(CType(DataGridView1.Rows(e.RowIndex).DataBoundItem, DataRowView).Row, DataRow)
            ' Populate the textboxes with the values from the selected row
            StudentIDTextBox.Text = selectedStudent("student_id").ToString()
            SubjectCodeTextBox.Text = selectedStudent("subject_code").ToString()
            SectionCodeTextBox.Text = selectedStudent("section_code").ToString()
            ' Set the TextBoxes to be read-only
            StudentIDTextBox.ReadOnly = True
            SubjectCodeTextBox.ReadOnly = True
            SectionCodeTextBox.ReadOnly = True
        End If
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        ' Check if a student has been selected
        If selectedStudent IsNot Nothing Then
            ' Open the PROFPROFILE_UPDATE form
            Dim profProfileUpdateForm As New PROFPROFILE_UPDATE()
            profProfileUpdateForm.PopulateStudentData(selectedStudent)
            profProfileUpdateForm.ShowDialog()
        Else
            MessageBox.Show("Please select a student first.")
        End If
    End Sub


    Private Sub cbSEC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSEC.SelectedIndexChanged
        CheckFields()
    End Sub

    Private Sub cbSEM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSEM.SelectedIndexChanged
        CheckFields()
    End Sub

    Private Sub cbSUB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSUB.SelectedIndexChanged
        CheckFields()
    End Sub

    Private Sub cbStudentID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStudentID.SelectedIndexChanged
        CheckFields()
    End Sub

    Private Sub CheckFields()
        If cbSEC.SelectedIndex <> -1 AndAlso cbStudentID.SelectedIndex <> -1 AndAlso cbSUB.SelectedIndex <> -1 Then
            PopulateButton.Enabled = True
        Else
            PopulateButton.Enabled = False
        End If
    End Sub

    Private Function CheckIfStudentExists(studentID As String) As Boolean
        Try
            ' Open the database connection
            con.Open()
            ' Construct the SQL query to check if the student exists in the midterm table
            Dim query As String = "SELECT DISTINCT student_id FROM midterm WHERE student_id = @studentID;"
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

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click

    End Sub


    Private Sub showGradeBtn_Click(sender As Object, e As EventArgs) Handles showGradeBtn.Click

    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub exitbtn_Click(sender As Object, e As EventArgs) Handles exitbtn.Click

    End Sub
End Class
