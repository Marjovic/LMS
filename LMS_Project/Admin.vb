Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Admin
    ' Connection string - same as login form
    Private connectionString As String = "Server=localhost;Database=db_alejado;Uid=root;Password=Sheamar@442211;"

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the form title with current user info
        Me.Text = $"Admin Dashboard - Welcome {login.CurrentUsername}"

        ' Set date picker default value
        dtpDateOfBirth.Value = DateTime.Now.AddYears(-18)

        ' Load user data
        LoadUserData()

        ' Display welcome message
        MessageBox.Show($"Welcome to Admin Dashboard!" & vbCrLf &
                       $"User: {login.CurrentUsername}" & vbCrLf &
                       $"Role: {login.CurrentUserRoleName}", "Admin Dashboard Loaded")
    End Sub

    Private Sub btnAddInstructor_Click(sender As Object, e As EventArgs) Handles btnAddInstructor.Click
        ' Validate input
        If String.IsNullOrWhiteSpace(txtInstructorFirstName.Text) OrElse
           String.IsNullOrWhiteSpace(txtInstructorLastName.Text) OrElse
           String.IsNullOrWhiteSpace(txtInstructorUsername.Text) Then
            MessageBox.Show("Please fill in all required fields (First Name, Last Name, Username).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Start transaction for both inserts
                Using transaction As MySqlTransaction = connection.BeginTransaction()
                    Try
                        ' Step 1: Insert into Users table with role_id = 2 (Teacher)
                        Dim userQuery As String = "INSERT INTO Users (username, password_hash, role_id) VALUES (@username, SHA2(@password, 256), 2)"

                        Dim userId As Integer
                        Using userCommand As New MySqlCommand(userQuery, connection, transaction)
                            userCommand.Parameters.AddWithValue("@username", txtInstructorUsername.Text.Trim())
                            userCommand.Parameters.AddWithValue("@password", "temp123") ' Default password

                            userCommand.ExecuteNonQuery()
                        End Using

                        ' Get the inserted user ID using LAST_INSERT_ID()
                        Using idCommand As New MySqlCommand("SELECT LAST_INSERT_ID()", connection, transaction)
                            userId = Convert.ToInt32(idCommand.ExecuteScalar())
                        End Using

                        ' Step 2: Insert into Instructors table
                        Dim instructorQuery As String = "INSERT INTO Instructors (user_id, first_name, last_name, department) VALUES (@user_id, @first_name, @last_name, @department)"

                        Using instructorCommand As New MySqlCommand(instructorQuery, connection, transaction)
                            instructorCommand.Parameters.AddWithValue("@user_id", userId)
                            instructorCommand.Parameters.AddWithValue("@first_name", txtInstructorFirstName.Text.Trim())
                            instructorCommand.Parameters.AddWithValue("@last_name", txtInstructorLastName.Text.Trim())
                            instructorCommand.Parameters.AddWithValue("@department", If(String.IsNullOrWhiteSpace(txtInstructorDepartment.Text), DBNull.Value, txtInstructorDepartment.Text.Trim()))

                            instructorCommand.ExecuteNonQuery()
                        End Using

                        ' Commit transaction
                        transaction.Commit()

                        MessageBox.Show($"Instructor added successfully!" & vbCrLf &
                                      $"Username: {txtInstructorUsername.Text}" & vbCrLf &
                                      $"Default Password: temp123" & vbCrLf &
                                      $"User ID: {userId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Clear form
                        ClearAddInstructorForm()

                        ' Refresh data
                        LoadUserData()

                    Catch ex As Exception
                        transaction.Rollback()
                        Throw ex
                    End Try
                End Using
            End Using

        Catch ex As MySqlException
            If ex.Number = 1062 Then ' Duplicate entry error
                MessageBox.Show("Username already exists. Please choose a different username.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show($"Database error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error adding instructor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        ' Validate input
        If String.IsNullOrWhiteSpace(txtStudentFirstName.Text) OrElse
           String.IsNullOrWhiteSpace(txtStudentLastName.Text) OrElse
           String.IsNullOrWhiteSpace(txtStudentUsername.Text) Then
            MessageBox.Show("Please fill in all required fields (First Name, Last Name, Username).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Start transaction for both inserts
                Using transaction As MySqlTransaction = connection.BeginTransaction()
                    Try
                        ' Step 1: Insert into Users table with role_id = 3 (Student)
                        Dim userQuery As String = "INSERT INTO Users (username, password_hash, role_id) VALUES (@username, SHA2(@password, 256), 3)"

                        Dim userId As Integer
                        Using userCommand As New MySqlCommand(userQuery, connection, transaction)
                            userCommand.Parameters.AddWithValue("@username", txtStudentUsername.Text.Trim())
                            userCommand.Parameters.AddWithValue("@password", "temp123") ' Default password

                            userCommand.ExecuteNonQuery()
                        End Using

                        ' Get the inserted user ID using LAST_INSERT_ID()
                        Using idCommand As New MySqlCommand("SELECT LAST_INSERT_ID()", connection, transaction)
                            userId = Convert.ToInt32(idCommand.ExecuteScalar())
                        End Using

                        ' Step 2: Insert into Students table
                        Dim studentQuery As String = "INSERT INTO Students (user_id, first_name, last_name, date_of_birth) VALUES (@user_id, @first_name, @last_name, @date_of_birth)"

                        Using studentCommand As New MySqlCommand(studentQuery, connection, transaction)
                            studentCommand.Parameters.AddWithValue("@user_id", userId)
                            studentCommand.Parameters.AddWithValue("@first_name", txtStudentFirstName.Text.Trim())
                            studentCommand.Parameters.AddWithValue("@last_name", txtStudentLastName.Text.Trim())
                            studentCommand.Parameters.AddWithValue("@date_of_birth", dtpDateOfBirth.Value.Date)

                            studentCommand.ExecuteNonQuery()
                        End Using

                        ' Commit transaction
                        transaction.Commit()

                        MessageBox.Show($"Student added successfully!" & vbCrLf &
                                      $"Username: {txtStudentUsername.Text}" & vbCrLf &
                                      $"Default Password: temp123" & vbCrLf &
                                      $"User ID: {userId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Clear form
                        ClearAddStudentForm()

                        ' Refresh data
                        LoadUserData()

                    Catch ex As Exception
                        transaction.Rollback()
                        Throw ex
                    End Try
                End Using
            End Using

        Catch ex As MySqlException
            If ex.Number = 1062 Then ' Duplicate entry error
                MessageBox.Show("Username already exists. Please choose a different username.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show($"Database error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error adding student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRefreshUsers_Click(sender As Object, e As EventArgs) Handles btnRefreshUsers.Click
        LoadUserData()
        MessageBox.Show("Data refreshed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        If cmbSelectUser.SelectedValue Is Nothing OrElse String.IsNullOrWhiteSpace(txtNewPassword.Text) Then
            MessageBox.Show("Please select a user and enter a new password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show($"Are you sure you want to reset password for user: {cmbSelectUser.Text}?",
                                                   "Confirm Password Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()

                    Dim query As String = "UPDATE Users SET password_hash = SHA2(@password, 256) WHERE user_id = @user_id"

                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@password", txtNewPassword.Text)
                        command.Parameters.AddWithValue("@user_id", cmbSelectUser.SelectedValue)

                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Password reset successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtNewPassword.Clear()
                        Else
                            MessageBox.Show("Failed to reset password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show($"Error resetting password: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnGeneratePassword_Click(sender As Object, e As EventArgs) Handles btnGeneratePassword.Click
        txtNewPassword.Text = GenerateSecurePassword()
        MessageBox.Show("Secure password generated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LoadUserData()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Load Users with Role Names
                Dim usersQuery As String = "SELECT u.user_id as 'User ID', u.username as 'Username', r.role_name as 'Role' FROM Users u INNER JOIN Roles r ON u.role_id = r.role_id ORDER BY u.user_id"
                Using usersAdapter As New MySqlDataAdapter(usersQuery, connection)
                    Dim usersTable As New DataTable()
                    usersAdapter.Fill(usersTable)
                    dgvUsers.DataSource = usersTable
                End Using

                ' Load Instructors with User Information
                Dim instructorsQuery As String = "SELECT i.instructor_id as 'Instructor ID', u.username as 'Username', i.first_name as 'First Name', i.last_name as 'Last Name', i.department as 'Department' FROM Instructors i INNER JOIN Users u ON i.user_id = u.user_id ORDER BY i.instructor_id"
                Using instructorsAdapter As New MySqlDataAdapter(instructorsQuery, connection)
                    Dim instructorsTable As New DataTable()
                    instructorsAdapter.Fill(instructorsTable)
                    dgvInstructors.DataSource = instructorsTable
                End Using

                ' Load Students with User Information
                Dim studentsQuery As String = "SELECT s.student_id as 'Student ID', u.username as 'Username', s.first_name as 'First Name', s.last_name as 'Last Name', s.date_of_birth as 'Date of Birth' FROM Students s INNER JOIN Users u ON s.user_id = u.user_id ORDER BY s.student_id"
                Using studentsAdapter As New MySqlDataAdapter(studentsQuery, connection)
                    Dim studentsTable As New DataTable()
                    studentsAdapter.Fill(studentsTable)
                    dgvStudents.DataSource = studentsTable
                End Using

                ' Load users for password reset combo box
                Dim comboQuery As String = "SELECT u.user_id, CONCAT(u.username, ' - ', r.role_name) as display_name FROM Users u INNER JOIN Roles r ON u.role_id = r.role_id ORDER BY u.username"
                Using comboAdapter As New MySqlDataAdapter(comboQuery, connection)
                    Dim comboTable As New DataTable()
                    comboAdapter.Fill(comboTable)
                    cmbSelectUser.DataSource = comboTable
                    cmbSelectUser.DisplayMember = "display_name"
                    cmbSelectUser.ValueMember = "user_id"
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearAddInstructorForm()
        txtInstructorFirstName.Clear()
        txtInstructorLastName.Clear()
        txtInstructorUsername.Clear()
        txtInstructorDepartment.Clear()
    End Sub

    Private Sub ClearAddStudentForm()
        txtStudentFirstName.Clear()
        txtStudentLastName.Clear()
        txtStudentUsername.Clear()
        dtpDateOfBirth.Value = DateTime.Now.AddYears(-18)
    End Sub

    Private Function GenerateSecurePassword() As String
        Const chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*"
        Dim random As New Random()
        Dim password As New StringBuilder()

        For i As Integer = 0 To 11 ' 12 character password
            password.Append(chars(random.Next(chars.Length)))
        Next

        Return password.ToString()
    End Function

    Private Sub Admin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Clear user session when admin form is closed
        login.ClearUserSession()

        ' Show login form again
        Dim loginForm As New login()
        loginForm.Show()
    End Sub

    Private Sub dtpDateOfBirth_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateOfBirth.ValueChanged

    End Sub

    Private Sub lblInstructorInstructions_Click(sender As Object, e As EventArgs) Handles lblInstructorInstructions.Click

    End Sub

    Private Sub lblNewPassword_Click(sender As Object, e As EventArgs) Handles lblNewPassword.Click

    End Sub
End Class