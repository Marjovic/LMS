Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class TeacherDashboard
    ' Connection string - same as login form
    Private connectionString As String = "Server=localhost;Database=db_alejado;Uid=root;Password=Sheamar@442211;"
    Private currentTeacherId As Integer = 0

    Private Sub Teacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the form title with current user info
        Me.Text = $"Teacher Dashboard - Welcome {login.CurrentUsername}"

        ' Get current teacher's instructor_id
        GetCurrentTeacherId()

        ' Add input validation for grade
        AddHandler txtGradeValue.KeyPress, AddressOf ValidateGradeInput

        ' Load initial data
        LoadCourseOverview()
        LoadTeacherCourses()
        LoadAssignmentTypes()

        ' Add event handlers for dropdown changes
        AddHandler cmbCourses.SelectedIndexChanged, AddressOf OnCourseSelected

        ' Display welcome message
        MessageBox.Show($"Welcome to Teacher Dashboard!" & vbCrLf &
                       $"User: {login.CurrentUsername}" & vbCrLf &
                       $"Role: {login.CurrentUserRoleName}", "Teacher Dashboard Loaded")
    End Sub

    Private Sub GetCurrentTeacherId()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT instructor_id FROM Instructors i INNER JOIN Users u ON i.user_id = u.user_id WHERE u.username = @username"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@username", login.CurrentUsername)
                    Dim result = command.ExecuteScalar()
                    If result IsNot Nothing Then
                        currentTeacherId = Convert.ToInt32(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error getting teacher ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadCourseOverview()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Create the view if it doesn't exist
                CreateTeacherCourseOverviewView(connection)

                ' Load data from the view for current teacher
                Dim query As String = "SELECT course_code as 'Course Code', course_name as 'Course Name', type_name as 'Assignment Type', submissions as 'Submissions', ROUND(average_grade, 2) as 'Average Grade' FROM TeacherCourseOverview WHERE user_id = @user_id ORDER BY course_code, type_name"

                Using adapter As New MySqlDataAdapter(query, connection)
                    adapter.SelectCommand.Parameters.AddWithValue("@user_id", login.CurrentUserId)
                    Dim courseTable As New DataTable()
                    adapter.Fill(courseTable)
                    dgvCourseOverview.DataSource = courseTable
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading course overview: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CreateTeacherCourseOverviewView(connection As MySqlConnection)
        Try
            ' Drop view if exists and create new one
            Dim dropViewQuery As String = "DROP VIEW IF EXISTS TeacherCourseOverview"
            Using dropCommand As New MySqlCommand(dropViewQuery, connection)
                dropCommand.ExecuteNonQuery()
            End Using

            ' Create the view
            Dim createViewQuery As String = "CREATE VIEW TeacherCourseOverview AS " &
                "SELECT " &
                "    i.user_id, " &
                "    c.course_id, " &
                "    c.course_code, " &
                "    c.course_name, " &
                "    at.type_name, " &
                "    COUNT(g.grade) as submissions, " &
                "    AVG(g.grade) as average_grade " &
                "FROM Courses c " &
                "INNER JOIN Instructors i ON c.instructor_id = i.instructor_id " &
                "LEFT JOIN Grades g ON c.course_id = g.course_id " &
                "LEFT JOIN AssignmentTypes at ON g.type_id = at.type_id " &
                "GROUP BY c.course_id, at.type_id, i.user_id"

            Using createCommand As New MySqlCommand(createViewQuery, connection)
                createCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            ' View creation might fail if it already exists or permissions issue
            ' This is acceptable as the view might already exist
        End Try
    End Sub

    Private Sub LoadTeacherCourses()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT c.course_id, CONCAT(c.course_code, ' - ', c.course_name) as display_name FROM Courses c WHERE c.instructor_id = @instructor_id ORDER BY c.course_code"
                Using adapter As New MySqlDataAdapter(query, connection)
                    adapter.SelectCommand.Parameters.AddWithValue("@instructor_id", currentTeacherId)
                    Dim courseTable As New DataTable()
                    adapter.Fill(courseTable)
                    cmbCourses.DataSource = courseTable
                    cmbCourses.DisplayMember = "display_name"
                    cmbCourses.ValueMember = "course_id"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading teacher courses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadAssignmentTypes()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT type_id, type_name FROM AssignmentTypes ORDER BY type_name"
                Using adapter As New MySqlDataAdapter(query, connection)
                    Dim typeTable As New DataTable()
                    adapter.Fill(typeTable)
                    cmbAssignmentTypes.DataSource = typeTable
                    cmbAssignmentTypes.DisplayMember = "type_name"
                    cmbAssignmentTypes.ValueMember = "type_id"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading assignment types: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub OnCourseSelected(sender As Object, e As EventArgs)
        If cmbCourses.SelectedValue IsNot Nothing Then
            LoadStudentsForCourse(Convert.ToInt32(cmbCourses.SelectedValue))
        End If
    End Sub

    Private Sub LoadStudentsForCourse(courseId As Integer)
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT s.student_id, CONCAT(s.first_name, ' ', s.last_name, ' (', u.username, ')') as display_name FROM Students s INNER JOIN Users u ON s.user_id = u.user_id INNER JOIN Enrollments e ON s.student_id = e.student_id WHERE e.course_id = @course_id ORDER BY s.last_name, s.first_name"
                Using adapter As New MySqlDataAdapter(query, connection)
                    adapter.SelectCommand.Parameters.AddWithValue("@course_id", courseId)
                    Dim studentTable As New DataTable()
                    adapter.Fill(studentTable)
                    cmbStudents.DataSource = studentTable
                    cmbStudents.DisplayMember = "display_name"
                    cmbStudents.ValueMember = "student_id"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading students: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ValidateGradeInput(sender As Object, e As KeyPressEventArgs)
        ' Allow only numbers, decimal point, backspace, and delete
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = "."c OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True
            MessageBox.Show("Grade can only contain numbers and decimal point.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnUpdateGrade_Click(sender As Object, e As EventArgs) Handles btnUpdateGrade.Click
        ' Validate all required selections and inputs
        If cmbCourses.SelectedValue Is Nothing Then
            MessageBox.Show("Please select a course.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cmbAssignmentTypes.SelectedValue Is Nothing Then
            MessageBox.Show("Please select an assignment type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cmbStudents.SelectedValue Is Nothing Then
            MessageBox.Show("Please select a student.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtGradeValue.Text) Then
            MessageBox.Show("Please enter a grade value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate grade value
        Dim gradeValue As Double
        If Not Double.TryParse(txtGradeValue.Text.Trim(), gradeValue) OrElse gradeValue < 0 OrElse gradeValue > 100 Then
            MessageBox.Show("Grade must be a number between 0 and 100.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtGradeValue.Focus()
            Return
        End If

        ' Get selected values
        Dim courseId As Integer = Convert.ToInt32(cmbCourses.SelectedValue)
        Dim typeId As Integer = Convert.ToInt32(cmbAssignmentTypes.SelectedValue)
        Dim studentId As Integer = Convert.ToInt32(cmbStudents.SelectedValue)
        Dim courseName As String = cmbCourses.Text
        Dim typeName As String = cmbAssignmentTypes.Text
        Dim studentName As String = cmbStudents.Text

        ' Confirm the grade update
        Dim result As DialogResult = MessageBox.Show($"Update grade for:" & vbCrLf & vbCrLf &
                                                   $"Course: {courseName}" & vbCrLf &
                                                   $"Assignment Type: {typeName}" & vbCrLf &
                                                   $"Student: {studentName}" & vbCrLf &
                                                   $"Grade: {gradeValue}" & vbCrLf & vbCrLf &
                                                   "This will INSERT new grade or UPDATE existing grade.",
                                                   "Confirm Grade Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            UpdateStudentGrade(courseId, typeId, studentId, gradeValue, courseName, typeName, studentName)
        End If
    End Sub

    Private Sub UpdateStudentGrade(courseId As Integer, typeId As Integer, studentId As Integer, gradeValue As Double, courseName As String, typeName As String, studentName As String)
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Check if grade already exists
                Dim checkQuery As String = "SELECT grade_id FROM Grades WHERE course_id = @course_id AND type_id = @type_id AND student_id = @student_id"
                Dim existingGradeId As Object = Nothing

                Using checkCommand As New MySqlCommand(checkQuery, connection)
                    checkCommand.Parameters.AddWithValue("@course_id", courseId)
                    checkCommand.Parameters.AddWithValue("@type_id", typeId)
                    checkCommand.Parameters.AddWithValue("@student_id", studentId)
                    existingGradeId = checkCommand.ExecuteScalar()
                End Using

                Dim query As String
                Dim operation As String

                If existingGradeId IsNot Nothing Then
                    ' UPDATE existing grade
                    query = "UPDATE Grades SET grade = @grade WHERE grade_id = @grade_id"
                    operation = "updated"
                Else
                    ' INSERT new grade
                    query = "INSERT INTO Grades (course_id, type_id, student_id, grade) VALUES (@course_id, @type_id, @student_id, @grade)"
                    operation = "created"
                End If

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@grade", gradeValue)
                    command.Parameters.AddWithValue("@course_id", courseId)
                    command.Parameters.AddWithValue("@type_id", typeId)
                    command.Parameters.AddWithValue("@student_id", studentId)

                    If existingGradeId IsNot Nothing Then
                        command.Parameters.AddWithValue("@grade_id", existingGradeId)
                    End If

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show($"Grade {operation} successfully!" & vbCrLf & vbCrLf &
                                      $"Course: {courseName}" & vbCrLf &
                                      $"Assignment Type: {typeName}" & vbCrLf &
                                      $"Student: {studentName}" & vbCrLf &
                                      $"Grade: {gradeValue}",
                                      "Grade Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Clear the grade input
                        txtGradeValue.Clear()

                        ' Refresh course overview
                        LoadCourseOverview()

                    Else
                        MessageBox.Show("Failed to update grade. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show($"Error updating grade: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRefreshCourses_Click(sender As Object, e As EventArgs) Handles btnRefreshCourses.Click
        LoadCourseOverview()
        LoadTeacherCourses()
        LoadAssignmentTypes()
        MessageBox.Show("Course data refreshed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Teacher_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Clear user session when teacher form is closed
        login.ClearUserSession()

        ' Show login form again
        Dim loginForm As New login()
        loginForm.Show()
    End Sub

    Private Sub lblSelectStudent_Click(sender As Object, e As EventArgs) Handles lblSelectStudent.Click

    End Sub

    Private Sub dgvCourseOverview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCourseOverview.CellContentClick

    End Sub
End Class