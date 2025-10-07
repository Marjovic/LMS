Imports MySql.Data.MySqlClient

Public Class StudentDashboard
    ' Connection string - same as login form
    Private connectionString As String = "Server=localhost;Database=db_alejado;Uid=root;Password=Sheamar@442211;"
    Private currentStudentId As Integer = 0

    Private Sub Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the form title with current user info
        Me.Text = $"Student Dashboard - Welcome {login.CurrentUsername}"

        ' Get current student's student_id
        GetCurrentStudentId()

        ' Load initial data
        LoadGradeSummary()
        LoadCourseAverages()

        ' Display welcome message
        MessageBox.Show($"Welcome to Student Dashboard!" & vbCrLf &
                       $"User: {login.CurrentUsername}" & vbCrLf &
                       $"Role: {login.CurrentUserRoleName}", "Student Dashboard Loaded")
    End Sub

    Private Sub GetCurrentStudentId()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT student_id FROM Students s INNER JOIN Users u ON s.user_id = u.user_id WHERE u.username = @username"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@username", login.CurrentUsername)
                    Dim result = command.ExecuteScalar()
                    If result IsNot Nothing Then
                        currentStudentId = Convert.ToInt32(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error getting student ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadGradeSummary()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Create the view if it doesn't exist
                CreateStudentGradeSummaryView(connection)

                ' Load data from the view for current student
                Dim query As String = "SELECT course_code as 'Course Code', course_name as 'Course Name', type_name as 'Assignment Type', grade as 'Grade', date_recorded as 'Date Recorded' FROM StudentGradeSummary WHERE user_id = @user_id ORDER BY course_code, type_name, date_recorded DESC"

                Using adapter As New MySqlDataAdapter(query, connection)
                    adapter.SelectCommand.Parameters.AddWithValue("@user_id", login.CurrentUserId)
                    Dim gradeTable As New DataTable()
                    adapter.Fill(gradeTable)
                    dgvGradeSummary.DataSource = gradeTable
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading grade summary: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CreateStudentGradeSummaryView(connection As MySqlConnection)
        Try
            ' Drop view if exists and create new one
            Dim dropViewQuery As String = "DROP VIEW IF EXISTS StudentGradeSummary"
            Using dropCommand As New MySqlCommand(dropViewQuery, connection)
                dropCommand.ExecuteNonQuery()
            End Using

            ' Create the view
            Dim createViewQuery As String = "CREATE VIEW StudentGradeSummary AS " &
                "SELECT " &
                "    s.user_id, " &
                "    stu.student_id, " &
                "    c.course_code, " &
                "    c.course_name, " &
                "    at.type_name, " &
                "    g.grade, " &
                "    g.date_recorded " &
                "FROM Grades g " &
                "INNER JOIN Students stu ON g.student_id = stu.student_id " &
                "INNER JOIN Users s ON stu.user_id = s.user_id " &
                "INNER JOIN Courses c ON g.course_id = c.course_id " &
                "INNER JOIN AssignmentTypes at ON g.type_id = at.type_id"

            Using createCommand As New MySqlCommand(createViewQuery, connection)
                createCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            ' View creation might fail if it already exists or permissions issue
            ' This is acceptable as the view might already exist
        End Try
    End Sub

    Private Sub LoadCourseAverages()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Calculate course averages for the current student
                Dim query As String = "SELECT " &
                    "c.course_code as 'Course Code', " &
                    "c.course_name as 'Course Name', " &
                    "COUNT(g.grade) as 'Total Assignments', " &
                    "ROUND(AVG(g.grade), 2) as 'Course Average', " &
                    "CASE " &
                        "WHEN AVG(g.grade) >= 90 THEN 'A' " &
                        "WHEN AVG(g.grade) >= 80 THEN 'B' " &
                        "WHEN AVG(g.grade) >= 70 THEN 'C' " &
                        "WHEN AVG(g.grade) >= 60 THEN 'D' " &
                        "ELSE 'F' " &
                    "END as 'Letter Grade' " &
                    "FROM Grades g " &
                    "INNER JOIN Students stu ON g.student_id = stu.student_id " &
                    "INNER JOIN Users u ON stu.user_id = u.user_id " &
                    "INNER JOIN Courses c ON g.course_id = c.course_id " &
                    "WHERE u.user_id = @user_id " &
                    "GROUP BY c.course_id, c.course_code, c.course_name " &
                    "ORDER BY c.course_code"

                Using adapter As New MySqlDataAdapter(query, connection)
                    adapter.SelectCommand.Parameters.AddWithValue("@user_id", login.CurrentUserId)
                    Dim averageTable As New DataTable()
                    adapter.Fill(averageTable)
                    dgvCourseAverages.DataSource = averageTable
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading course averages: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRefreshGrades_Click(sender As Object, e As EventArgs) Handles btnRefreshGrades.Click
        LoadGradeSummary()
        MessageBox.Show("Grade data refreshed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnRefreshAverages_Click(sender As Object, e As EventArgs) Handles btnRefreshAverages.Click
        LoadCourseAverages()
        MessageBox.Show("Course average data refreshed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Student_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Clear user session when student form is closed
        login.ClearUserSession()

        ' Show login form again
        Dim loginForm As New login()
        loginForm.Show()
    End Sub
End Class