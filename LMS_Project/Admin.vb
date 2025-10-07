Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

Public Class Admin
    ' Connection string - same as login form
    Private connectionString As String = "Server=localhost;Database=db_alejado;Uid=root;Password=Sheamar@442211;"

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the form title with current user info
        Me.Text = $"Admin Dashboard - Welcome {login.CurrentUsername}"

        ' Initialize role dropdown
        InitializeRoleDropdown()

        ' Add event handlers for input validation
        AddHandler txtFirstName.KeyPress, AddressOf ValidateNameInput
        AddHandler txtLastName.KeyPress, AddressOf ValidateNameInput
        AddHandler txtUsername.KeyPress, AddressOf ValidateUsernameInput
        AddHandler txtPassword.KeyPress, AddressOf ValidatePasswordInput
        AddHandler txtNewPassword.KeyPress, AddressOf ValidatePasswordInput

        ' Load user data and populate dropdowns
        LoadUserData()
        LoadUserDetailsDropdown()
        LoadUserResetDropdown()
        LoadAssignmentTypes()
        LoadSystemGrades()

        ' Display welcome message
        MessageBox.Show($"Welcome to Admin Dashboard!" & vbCrLf &
                       $"User: {login.CurrentUsername}" & vbCrLf &
                       $"Role: {login.CurrentUserRoleName}", "Admin Dashboard Loaded")
    End Sub

    Private Sub InitializeRoleDropdown()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT role_id, role_name FROM Roles ORDER BY role_id"
                Using adapter As New MySqlDataAdapter(query, connection)
                    Dim roleTable As New DataTable()
                    adapter.Fill(roleTable)
                    cmbRole.DataSource = roleTable
                    cmbRole.DisplayMember = "role_name"
                    cmbRole.ValueMember = "role_id"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading roles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadUserDetailsDropdown()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT u.user_id, CONCAT(u.username, ' - ', r.role_name) as display_name FROM Users u INNER JOIN Roles r ON u.role_id = r.role_id ORDER BY u.username"
                Using adapter As New MySqlDataAdapter(query, connection)
                    Dim userTable As New DataTable()
                    adapter.Fill(userTable)
                    cmbSelectUserDetails.DataSource = userTable
                    cmbSelectUserDetails.DisplayMember = "display_name"
                    cmbSelectUserDetails.ValueMember = "user_id"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading users for details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadUserResetDropdown()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                ' Load all users except the current admin for password reset
                Dim query As String = "SELECT u.user_id, CONCAT(u.username, ' - ', r.role_name) as display_name FROM Users u INNER JOIN Roles r ON u.role_id = r.role_id WHERE u.username != @current_user ORDER BY u.username"
                Using adapter As New MySqlDataAdapter(query, connection)
                    adapter.SelectCommand.Parameters.AddWithValue("@current_user", login.CurrentUsername)
                    Dim userTable As New DataTable()
                    adapter.Fill(userTable)
                    cmbSelectUserReset.DataSource = userTable
                    cmbSelectUserReset.DisplayMember = "display_name"
                    cmbSelectUserReset.ValueMember = "user_id"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading users for password reset: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Input validation methods
    Private Sub ValidateNameInput(sender As Object, e As KeyPressEventArgs)
        ' Allow only letters, spaces, backspace, and delete
        If Not (Char.IsLetter(e.KeyChar) OrElse e.KeyChar = " "c OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True
            MessageBox.Show("Names can only contain letters and spaces.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ValidateUsernameInput(sender As Object, e As KeyPressEventArgs)
        Dim textBox As TextBox = DirectCast(sender, TextBox)

        ' Allow backspace and delete
        If e.KeyChar = ControlChars.Back Then
            Return
        End If

        ' If this is the first character, it must be a letter
        If textBox.Text.Length = 0 Then
            If Not Char.IsLetter(e.KeyChar) Then
                e.Handled = True
                MessageBox.Show("Username must start with a letter.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        Else
            ' After the first character, allow letters, numbers, underscore, and @
            If Not (Char.IsLetter(e.KeyChar) OrElse Char.IsDigit(e.KeyChar) OrElse e.KeyChar = "_"c OrElse e.KeyChar = "@"c) Then
                e.Handled = True
                MessageBox.Show("Username can only contain letters, numbers, underscore, and @ (must start with a letter).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        End If
    End Sub

    Private Sub ValidatePasswordInput(sender As Object, e As KeyPressEventArgs)
        Dim textBox As TextBox = DirectCast(sender, TextBox)

        ' Allow backspace and delete
        If e.KeyChar = ControlChars.Back Then
            Return
        End If

        ' If this is the first character, it must be a letter
        If textBox.Text.Length = 0 Then
            If Not Char.IsLetter(e.KeyChar) Then
                e.Handled = True
                MessageBox.Show("Password must start with a letter.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        Else
            ' After the first character, allow letters, numbers, underscore, and @
            If Not (Char.IsLetter(e.KeyChar) OrElse Char.IsDigit(e.KeyChar) OrElse e.KeyChar = "_"c OrElse e.KeyChar = "@"c) Then
                e.Handled = True
                MessageBox.Show("Password can only contain letters, numbers, underscore, and @ (must start with a letter).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        End If
    End Sub

    Private Function IsValidInput() As Boolean
        ' Validate names contain only letters and spaces
        If Not Regex.IsMatch(txtFirstName.Text.Trim(), "^[a-zA-Z\s]+$") Then
            MessageBox.Show("First name can only contain letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFirstName.Focus()
            Return False
        End If

        If Not Regex.IsMatch(txtLastName.Text.Trim(), "^[a-zA-Z\s]+$") Then
            MessageBox.Show("Last name can only contain letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtLastName.Focus()
            Return False
        End If

        ' Validate username starts with letter, then letters, numbers, underscore, and @
        If Not Regex.IsMatch(txtUsername.Text.Trim(), "^[a-zA-Z][a-zA-Z0-9_@]*$") Then
            MessageBox.Show("Username must start with a letter and can only contain letters, numbers, underscore, and @.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()
            Return False
        End If

        ' Validate password starts with letter, then letters, numbers, underscore, and @
        If Not Regex.IsMatch(txtPassword.Text.Trim(), "^[a-zA-Z][a-zA-Z0-9_@]*$") Then
            MessageBox.Show("Password must start with a letter and can only contain letters, numbers, underscore, and @.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        ' Validate required input
        If String.IsNullOrWhiteSpace(txtFirstName.Text) OrElse
           String.IsNullOrWhiteSpace(txtLastName.Text) OrElse
           String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
           String.IsNullOrWhiteSpace(txtPassword.Text) OrElse
           cmbRole.SelectedValue Is Nothing Then
            MessageBox.Show("Please fill in all required fields (First Name, Last Name, Username, Password, Role).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate input format
        If Not IsValidInput() Then
            Return
        End If

        Dim selectedRoleId As Integer = Convert.ToInt32(cmbRole.SelectedValue)
        Dim selectedRoleName As String = cmbRole.Text

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Start transaction for both inserts
                Using transaction As MySqlTransaction = connection.BeginTransaction()
                    Try
                        ' Step 1: Insert into Users table
                        Dim userQuery As String = "INSERT INTO Users (username, password_hash, role_id) VALUES (@username, SHA2(@password, 256), @role_id)"

                        Dim userId As Integer
                        Using userCommand As New MySqlCommand(userQuery, connection, transaction)
                            userCommand.Parameters.AddWithValue("@username", txtUsername.Text.Trim())
                            userCommand.Parameters.AddWithValue("@password", txtPassword.Text.Trim()) ' Use actual password
                            userCommand.Parameters.AddWithValue("@role_id", selectedRoleId)

                            userCommand.ExecuteNonQuery()
                        End Using

                        ' Get the inserted user ID using LAST_INSERT_ID()
                        Using idCommand As New MySqlCommand("SELECT LAST_INSERT_ID()", connection, transaction)
                            userId = Convert.ToInt32(idCommand.ExecuteScalar())
                        End Using

                        ' Step 2: Insert into role-specific table
                        If selectedRoleId = 2 Then ' Teacher
                            Dim instructorQuery As String = "INSERT INTO Instructors (user_id, first_name, last_name, department) VALUES (@user_id, @first_name, @last_name, @department)"

                            Using instructorCommand As New MySqlCommand(instructorQuery, connection, transaction)
                                instructorCommand.Parameters.AddWithValue("@user_id", userId)
                                instructorCommand.Parameters.AddWithValue("@first_name", txtFirstName.Text.Trim())
                                instructorCommand.Parameters.AddWithValue("@last_name", txtLastName.Text.Trim())
                                instructorCommand.Parameters.AddWithValue("@department", DBNull.Value) ' No department field in form

                                instructorCommand.ExecuteNonQuery()
                            End Using

                        ElseIf selectedRoleId = 3 Then ' Student
                            Dim studentQuery As String = "INSERT INTO Students (user_id, first_name, last_name, date_of_birth) VALUES (@user_id, @first_name, @last_name, @date_of_birth)"

                            Using studentCommand As New MySqlCommand(studentQuery, connection, transaction)
                                studentCommand.Parameters.AddWithValue("@user_id", userId)
                                studentCommand.Parameters.AddWithValue("@first_name", txtFirstName.Text.Trim())
                                studentCommand.Parameters.AddWithValue("@last_name", txtLastName.Text.Trim())
                                studentCommand.Parameters.AddWithValue("@date_of_birth", DateTime.Now.AddYears(-18)) ' Default date

                                studentCommand.ExecuteNonQuery()
                            End Using
                        End If

                        ' Commit transaction
                        transaction.Commit()

                        MessageBox.Show($"{selectedRoleName} added successfully!" & vbCrLf &
                                      $"Username: {txtUsername.Text}" & vbCrLf &
                                      $"Password: [Securely hashed with SHA2-256]" & vbCrLf &
                                      $"User ID: {userId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Clear form
                        ClearAddUserForm()

                        ' Refresh data in User Management tab
                        LoadUserData()
                        LoadUserDetailsDropdown()

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
            MessageBox.Show($"Error adding user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRefreshUsers_Click(sender As Object, e As EventArgs) Handles btnRefreshUsers.Click
        LoadUserData()
        LoadUserDetailsDropdown()
        LoadUserResetDropdown()
        LoadAssignmentTypes()
        LoadSystemGrades()
        MessageBox.Show("All data refreshed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnViewDetails_Click(sender As Object, e As EventArgs) Handles btnViewDetails.Click
        If cmbSelectUserDetails.SelectedValue Is Nothing Then
            MessageBox.Show("Please select a user to view details.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim userId As Integer = Convert.ToInt32(cmbSelectUserDetails.SelectedValue)
            DisplayUserDetails(userId)
        Catch ex As Exception
            MessageBox.Show($"Error viewing user details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DisplayUserDetails(userId As Integer)
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim detailsText As New StringBuilder()
                detailsText.AppendLine("====== USER DETAILS ======")
                detailsText.AppendLine()

                ' Get basic user information (removed created_at since it doesn't exist)
                Dim userQuery As String = "SELECT u.user_id, u.username, u.password_hash, u.role_id, r.role_name FROM Users u INNER JOIN Roles r ON u.role_id = r.role_id WHERE u.user_id = @user_id"
                Using userCommand As New MySqlCommand(userQuery, connection)
                    userCommand.Parameters.AddWithValue("@user_id", userId)
                    Using reader As MySqlDataReader = userCommand.ExecuteReader()
                        If reader.Read() Then
                            Dim roleId As Integer = Convert.ToInt32(reader("role_id"))
                            Dim roleName As String = reader("role_name").ToString()

                            ' Display basic user information
                            detailsText.AppendLine($"User ID: {reader("user_id")}")
                            detailsText.AppendLine($"Username: {reader("username")}")
                            detailsText.AppendLine($"Role: {roleName}")
                            detailsText.AppendLine()

                            ' For Admin role - show Users table data
                            If roleId = 1 Then ' Admin
                                detailsText.AppendLine("====== ADMIN ACCOUNT DATA ======")
                                detailsText.AppendLine($"Username: {reader("username")}")
                                detailsText.AppendLine($"Password Hash: {reader("password_hash")}")
                                detailsText.AppendLine($"Role ID: {reader("role_id")}")
                                detailsText.AppendLine()
                                detailsText.AppendLine("Note: Admin accounts only have Users table data")

                            Else
                                reader.Close()

                                ' For Teacher role - show Instructors table data
                                If roleId = 2 Then ' Teacher
                                    Dim instructorQuery As String = "SELECT instructor_id, user_id, first_name, last_name, department FROM Instructors WHERE user_id = @user_id"
                                    Using instructorCommand As New MySqlCommand(instructorQuery, connection)
                                        instructorCommand.Parameters.AddWithValue("@user_id", userId)
                                        Using instructorReader As MySqlDataReader = instructorCommand.ExecuteReader()
                                            If instructorReader.Read() Then
                                                detailsText.AppendLine("====== INSTRUCTOR TABLE DATA ======")
                                                detailsText.AppendLine($"Instructor ID: {instructorReader("instructor_id")}")
                                                detailsText.AppendLine($"User ID: {instructorReader("user_id")}")
                                                detailsText.AppendLine($"First Name: {instructorReader("first_name")}")
                                                detailsText.AppendLine($"Last Name: {instructorReader("last_name")}")
                                                If Not IsDBNull(instructorReader("department")) Then
                                                    detailsText.AppendLine($"Department: {instructorReader("department")}")
                                                Else
                                                    detailsText.AppendLine("Department: NULL")
                                                End If
                                            Else
                                                detailsText.AppendLine("====== INSTRUCTOR TABLE DATA ======")
                                                detailsText.AppendLine("No instructor profile found.")
                                            End If
                                        End Using
                                    End Using

                                    ' For Student role - show Students table data
                                ElseIf roleId = 3 Then ' Student
                                    Dim studentQuery As String = "SELECT student_id, user_id, first_name, last_name, date_of_birth FROM Students WHERE user_id = @user_id"
                                    Using studentCommand As New MySqlCommand(studentQuery, connection)
                                        studentCommand.Parameters.AddWithValue("@user_id", userId)
                                        Using studentReader As MySqlDataReader = studentCommand.ExecuteReader()
                                            If studentReader.Read() Then
                                                detailsText.AppendLine("====== STUDENT TABLE DATA ======")
                                                detailsText.AppendLine($"Student ID: {studentReader("student_id")}")
                                                detailsText.AppendLine($"User ID: {studentReader("user_id")}")
                                                detailsText.AppendLine($"First Name: {studentReader("first_name")}")
                                                detailsText.AppendLine($"Last Name: {studentReader("last_name")}")
                                                If Not IsDBNull(studentReader("date_of_birth")) Then
                                                    Dim birthDate As DateTime = Convert.ToDateTime(studentReader("date_of_birth"))
                                                    detailsText.AppendLine($"Date of Birth: {birthDate:yyyy-MM-dd}")
                                                Else
                                                    detailsText.AppendLine("Date of Birth: NULL")
                                                End If
                                            Else
                                                detailsText.AppendLine("====== STUDENT TABLE DATA ======")
                                                detailsText.AppendLine("No student profile found.")
                                            End If
                                        End Using
                                    End Using
                                End If
                            End If

                            detailsText.AppendLine()
                            detailsText.AppendLine("====== DATABASE STRUCTURE INFO ======")
                            Select Case roleId
                                Case 1 ' Admin
                                    detailsText.AppendLine("Admin users only exist in the Users table")
                                    detailsText.AppendLine("Fields: user_id, username, password_hash, role_id")
                                Case 2 ' Teacher
                                    detailsText.AppendLine("Teacher data spans Users and Instructors tables")
                                    detailsText.AppendLine("Instructors table fields: instructor_id, user_id, first_name, last_name, department")
                                Case 3 ' Student
                                    detailsText.AppendLine("Student data spans Users and Students tables")
                                    detailsText.AppendLine("Students table fields: student_id, user_id, first_name, last_name, date_of_birth")
                            End Select

                        Else
                            detailsText.AppendLine("User not found.")
                        End If
                    End Using
                End Using

                ' Display the details in the text box
                txtUserDetails.Text = detailsText.ToString()

            End Using

        Catch ex As Exception
            MessageBox.Show($"Error retrieving user details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
            End Using

        Catch ex As Exception
            MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearAddUserForm()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtNewPassword.Clear()
        If cmbRole.Items.Count > 0 Then
            cmbRole.SelectedIndex = 0
        End If
    End Sub

    Private Sub Admin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Clear user session when admin form is closed
        login.ClearUserSession()

        ' Show login form again
        Dim loginForm As New login()
        loginForm.Show()
    End Sub

    Private Sub lblUsername_Click(sender As Object, e As EventArgs) Handles lblUsername.Click

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub lblUserDetailsTitle_Click(sender As Object, e As EventArgs) Handles lblUserDetailsTitle.Click

    End Sub

    Private Function GenerateSecurePassword() As String
        ' Generate password with letters, numbers, underscore, and @ (following validation rules)
        Const letters As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
        Const allChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789_@"
        Dim random As New Random()
        Dim password As New StringBuilder()

        ' First character must be a letter
        password.Append(letters(random.Next(letters.Length)))

        ' Remaining characters can be letters, numbers, underscore, or @
        For i As Integer = 1 To 11 ' Total 12 character password
            password.Append(allChars(random.Next(allChars.Length)))
        Next

        Return password.ToString()
    End Function

    ' ============= ASSIGNMENT TYPES MANAGEMENT =============

    Private Sub LoadAssignmentTypes()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT type_id as 'Type ID', type_name as 'Assignment Type Name' FROM AssignmentTypes ORDER BY type_name"
                Using adapter As New MySqlDataAdapter(query, connection)
                    Dim assignmentTable As New DataTable()
                    adapter.Fill(assignmentTable)
                    dgvAssignmentTypes.DataSource = assignmentTable
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading assignment types: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAddAssignmentType_Click(sender As Object, e As EventArgs) Handles btnAddAssignmentType.Click
        If String.IsNullOrWhiteSpace(txtAssignmentTypeName.Text) Then
            MessageBox.Show("Please enter an assignment type name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAssignmentTypeName.Focus()
            Return
        End If

        ' Validate assignment type name (letters, spaces, and some special characters)
        If Not Regex.IsMatch(txtAssignmentTypeName.Text.Trim(), "^[a-zA-Z0-9\s\-_]+$") Then
            MessageBox.Show("Assignment type name can only contain letters, numbers, spaces, hyphens, and underscores.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAssignmentTypeName.Focus()
            Return
        End If

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "INSERT INTO AssignmentTypes (type_name) VALUES (@type_name)"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@type_name", txtAssignmentTypeName.Text.Trim())
                    command.ExecuteNonQuery()
                End Using

                MessageBox.Show($"Assignment type '{txtAssignmentTypeName.Text.Trim()}' added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtAssignmentTypeName.Clear()
                LoadAssignmentTypes()
            End Using
        Catch ex As MySqlException
            If ex.Number = 1062 Then ' Duplicate entry error
                MessageBox.Show("Assignment type name already exists. Please choose a different name.", "Duplicate Name", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show($"Database error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error adding assignment type: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEditAssignmentType_Click(sender As Object, e As EventArgs) Handles btnEditAssignmentType.Click
        If dgvAssignmentTypes.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an assignment type to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtAssignmentTypeName.Text) Then
            MessageBox.Show("Please enter the new assignment type name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAssignmentTypeName.Focus()
            Return
        End If

        ' Validate assignment type name
        If Not Regex.IsMatch(txtAssignmentTypeName.Text.Trim(), "^[a-zA-Z0-9\s\-_]+$") Then
            MessageBox.Show("Assignment type name can only contain letters, numbers, spaces, hyphens, and underscores.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAssignmentTypeName.Focus()
            Return
        End If

        Dim selectedRow = dgvAssignmentTypes.SelectedRows(0)
        Dim typeId As Integer = Convert.ToInt32(selectedRow.Cells("Type ID").Value)
        Dim currentName As String = selectedRow.Cells("Assignment Type Name").Value.ToString()

        Dim result As DialogResult = MessageBox.Show($"Update assignment type:" & vbCrLf & vbCrLf &
                                                   $"Current Name: {currentName}" & vbCrLf &
                                                   $"New Name: {txtAssignmentTypeName.Text.Trim()}" & vbCrLf & vbCrLf &
                                                   "This will update the assignment type name.",
                                                   "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "UPDATE AssignmentTypes SET type_name = @type_name WHERE type_id = @type_id"
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@type_name", txtAssignmentTypeName.Text.Trim())
                        command.Parameters.AddWithValue("@type_id", typeId)
                        command.ExecuteNonQuery()
                    End Using

                    MessageBox.Show($"Assignment type updated successfully!" & vbCrLf &
                                  $"Old Name: {currentName}" & vbCrLf &
                                  $"New Name: {txtAssignmentTypeName.Text.Trim()}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtAssignmentTypeName.Clear()
                    LoadAssignmentTypes()
                End Using
            Catch ex As MySqlException
                If ex.Number = 1062 Then ' Duplicate entry error
                    MessageBox.Show("Assignment type name already exists. Please choose a different name.", "Duplicate Name", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show($"Database error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show($"Error updating assignment type: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnDeleteAssignmentType_Click(sender As Object, e As EventArgs) Handles btnDeleteAssignmentType.Click
        If dgvAssignmentTypes.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an assignment type to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRow = dgvAssignmentTypes.SelectedRows(0)
        Dim typeId As Integer = Convert.ToInt32(selectedRow.Cells("Type ID").Value)
        Dim typeName As String = selectedRow.Cells("Assignment Type Name").Value.ToString()

        ' Check if assignment type is being used in grades
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim checkQuery As String = "SELECT COUNT(*) FROM Grades WHERE type_id = @type_id"
                Using checkCommand As New MySqlCommand(checkQuery, connection)
                    checkCommand.Parameters.AddWithValue("@type_id", typeId)
                    Dim gradeCount As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

                    If gradeCount > 0 Then
                        MessageBox.Show($"Cannot delete assignment type '{typeName}' because it is being used in {gradeCount} grade record(s)." & vbCrLf & vbCrLf &
                                      "Please remove all grades associated with this assignment type first, or edit the assignment type name instead.",
                                      "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error checking assignment type usage: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete assignment type:" & vbCrLf & vbCrLf &
                                                   $"Type ID: {typeId}" & vbCrLf &
                                                   $"Name: {typeName}" & vbCrLf & vbCrLf &
                                                   "This action cannot be undone.",
                                                   "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "DELETE FROM AssignmentTypes WHERE type_id = @type_id"
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@type_id", typeId)
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show($"Assignment type '{typeName}' deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            LoadAssignmentTypes()
                        Else
                            MessageBox.Show("Failed to delete assignment type. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error deleting assignment type: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub dgvAssignmentTypes_SelectionChanged(sender As Object, e As EventArgs) Handles dgvAssignmentTypes.SelectionChanged
        ' Auto-populate text field when row is selected
        If dgvAssignmentTypes.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvAssignmentTypes.SelectedRows(0)
            txtAssignmentTypeName.Text = selectedRow.Cells("Assignment Type Name").Value.ToString()
        End If
    End Sub

    ' ============= SYSTEM GRADES MANAGEMENT =============

    Private Sub LoadSystemGrades()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT " &
                    "CONCAT(s.first_name, ' ', s.last_name) as 'Student Name', " &
                    "u.username as 'Student Username', " &
                    "c.course_code as 'Course Code', " &
                    "c.course_name as 'Course Name', " &
                    "at.type_name as 'Assignment Type', " &
                    "g.grade as 'Grade', " &
                    "g.date_recorded as 'Date Recorded' " &
                    "FROM Grades g " &
                    "INNER JOIN Students s ON g.student_id = s.student_id " &
                    "INNER JOIN Users u ON s.user_id = u.user_id " &
                    "INNER JOIN Courses c ON g.course_id = c.course_id " &
                    "INNER JOIN AssignmentTypes at ON g.type_id = at.type_id " &
                    "ORDER BY g.date_recorded DESC, s.last_name, s.first_name"

                Using adapter As New MySqlDataAdapter(query, connection)
                    Dim gradesTable As New DataTable()
                    adapter.Fill(gradesTable)
                    dgvSystemGrades.DataSource = gradesTable
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading system grades: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRefreshGrades_Click(sender As Object, e As EventArgs) Handles btnRefreshGrades.Click
        LoadSystemGrades()
        MessageBox.Show("System grades data refreshed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class