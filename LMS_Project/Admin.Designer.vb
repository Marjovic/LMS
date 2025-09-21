<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        lblInstructorInstructions = New Label()
        btnAddInstructor = New Button()
        txtInstructorDepartment = New TextBox()
        lblInstructorDepartment = New Label()
        txtInstructorUsername = New TextBox()
        lblInstructorUsername = New Label()
        txtInstructorLastName = New TextBox()
        lblInstructorLastName = New Label()
        txtInstructorFirstName = New TextBox()
        lblInstructorFirstName = New Label()
        lblAddInstructorTitle = New Label()
        TabPage2 = New TabPage()
        lblStudentInstructions = New Label()
        btnAddStudent = New Button()
        dtpDateOfBirth = New DateTimePicker()
        lblDateOfBirth = New Label()
        txtStudentUsername = New TextBox()
        lblStudentUsername = New Label()
        txtStudentLastName = New TextBox()
        lblStudentLastName = New Label()
        txtStudentFirstName = New TextBox()
        lblStudentFirstName = New Label()
        lblAddStudentTitle = New Label()
        TabPage3 = New TabPage()
        dgvStudents = New DataGridView()
        lblStudents = New Label()
        dgvInstructors = New DataGridView()
        lblInstructors = New Label()
        dgvUsers = New DataGridView()
        lblUsers = New Label()
        btnRefreshUsers = New Button()
        lblViewUsersTitle = New Label()
        TabPage4 = New TabPage()
        lblSecurityNotice = New Label()
        btnGeneratePassword = New Button()
        btnResetPassword = New Button()
        txtNewPassword = New TextBox()
        lblNewPassword = New Label()
        cmbSelectUser = New ComboBox()
        lblSelectUser = New Label()
        lblPasswordResetTitle = New Label()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvInstructors, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvUsers, ComponentModel.ISupportInitialize).BeginInit()
        TabPage4.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1200, 800)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(lblInstructorInstructions)
        TabPage1.Controls.Add(btnAddInstructor)
        TabPage1.Controls.Add(txtInstructorDepartment)
        TabPage1.Controls.Add(lblInstructorDepartment)
        TabPage1.Controls.Add(txtInstructorUsername)
        TabPage1.Controls.Add(lblInstructorUsername)
        TabPage1.Controls.Add(txtInstructorLastName)
        TabPage1.Controls.Add(lblInstructorLastName)
        TabPage1.Controls.Add(txtInstructorFirstName)
        TabPage1.Controls.Add(lblInstructorFirstName)
        TabPage1.Controls.Add(lblAddInstructorTitle)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1192, 772)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Add Instructor"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' lblInstructorInstructions
        ' 
        lblInstructorInstructions.BackColor = Color.LightYellow
        lblInstructorInstructions.BorderStyle = BorderStyle.FixedSingle
        lblInstructorInstructions.Location = New Point(380, 70)
        lblInstructorInstructions.Name = "lblInstructorInstructions"
        lblInstructorInstructions.Size = New Size(400, 120)
        lblInstructorInstructions.TabIndex = 10
        lblInstructorInstructions.Text = resources.GetString("lblInstructorInstructions.Text")
        ' 
        ' btnAddInstructor
        ' 
        btnAddInstructor.BackColor = Color.LightBlue
        btnAddInstructor.Location = New Point(130, 215)
        btnAddInstructor.Name = "btnAddInstructor"
        btnAddInstructor.Size = New Size(120, 35)
        btnAddInstructor.TabIndex = 9
        btnAddInstructor.Text = "Add Instructor"
        btnAddInstructor.UseVisualStyleBackColor = False
        ' 
        ' txtInstructorDepartment
        ' 
        txtInstructorDepartment.Location = New Point(130, 173)
        txtInstructorDepartment.Name = "txtInstructorDepartment"
        txtInstructorDepartment.Size = New Size(200, 23)
        txtInstructorDepartment.TabIndex = 8
        ' 
        ' lblInstructorDepartment
        ' 
        lblInstructorDepartment.AutoSize = True
        lblInstructorDepartment.Location = New Point(20, 175)
        lblInstructorDepartment.Name = "lblInstructorDepartment"
        lblInstructorDepartment.Size = New Size(73, 15)
        lblInstructorDepartment.TabIndex = 7
        lblInstructorDepartment.Text = "Department:"
        ' 
        ' txtInstructorUsername
        ' 
        txtInstructorUsername.Location = New Point(130, 138)
        txtInstructorUsername.Name = "txtInstructorUsername"
        txtInstructorUsername.Size = New Size(200, 23)
        txtInstructorUsername.TabIndex = 6
        ' 
        ' lblInstructorUsername
        ' 
        lblInstructorUsername.AutoSize = True
        lblInstructorUsername.Location = New Point(20, 140)
        lblInstructorUsername.Name = "lblInstructorUsername"
        lblInstructorUsername.Size = New Size(63, 15)
        lblInstructorUsername.TabIndex = 5
        lblInstructorUsername.Text = "Username:"
        ' 
        ' txtInstructorLastName
        ' 
        txtInstructorLastName.Location = New Point(130, 103)
        txtInstructorLastName.Name = "txtInstructorLastName"
        txtInstructorLastName.Size = New Size(200, 23)
        txtInstructorLastName.TabIndex = 4
        ' 
        ' lblInstructorLastName
        ' 
        lblInstructorLastName.AutoSize = True
        lblInstructorLastName.Location = New Point(20, 105)
        lblInstructorLastName.Name = "lblInstructorLastName"
        lblInstructorLastName.Size = New Size(66, 15)
        lblInstructorLastName.TabIndex = 3
        lblInstructorLastName.Text = "Last Name:"
        ' 
        ' txtInstructorFirstName
        ' 
        txtInstructorFirstName.Location = New Point(130, 68)
        txtInstructorFirstName.Name = "txtInstructorFirstName"
        txtInstructorFirstName.Size = New Size(200, 23)
        txtInstructorFirstName.TabIndex = 2
        ' 
        ' lblInstructorFirstName
        ' 
        lblInstructorFirstName.AutoSize = True
        lblInstructorFirstName.Location = New Point(20, 70)
        lblInstructorFirstName.Name = "lblInstructorFirstName"
        lblInstructorFirstName.Size = New Size(67, 15)
        lblInstructorFirstName.TabIndex = 1
        lblInstructorFirstName.Text = "First Name:"
        ' 
        ' lblAddInstructorTitle
        ' 
        lblAddInstructorTitle.AutoSize = True
        lblAddInstructorTitle.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        lblAddInstructorTitle.Location = New Point(20, 20)
        lblAddInstructorTitle.Name = "lblAddInstructorTitle"
        lblAddInstructorTitle.Size = New Size(187, 22)
        lblAddInstructorTitle.TabIndex = 0
        lblAddInstructorTitle.Text = "Add New Instructor"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(lblStudentInstructions)
        TabPage2.Controls.Add(btnAddStudent)
        TabPage2.Controls.Add(dtpDateOfBirth)
        TabPage2.Controls.Add(lblDateOfBirth)
        TabPage2.Controls.Add(txtStudentUsername)
        TabPage2.Controls.Add(lblStudentUsername)
        TabPage2.Controls.Add(txtStudentLastName)
        TabPage2.Controls.Add(lblStudentLastName)
        TabPage2.Controls.Add(txtStudentFirstName)
        TabPage2.Controls.Add(lblStudentFirstName)
        TabPage2.Controls.Add(lblAddStudentTitle)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1192, 772)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Add Student"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' lblStudentInstructions
        ' 
        lblStudentInstructions.BackColor = Color.LightYellow
        lblStudentInstructions.BorderStyle = BorderStyle.FixedSingle
        lblStudentInstructions.Location = New Point(380, 70)
        lblStudentInstructions.Name = "lblStudentInstructions"
        lblStudentInstructions.Size = New Size(400, 120)
        lblStudentInstructions.TabIndex = 10
        lblStudentInstructions.Text = resources.GetString("lblStudentInstructions.Text")
        ' 
        ' btnAddStudent
        ' 
        btnAddStudent.BackColor = Color.LightGreen
        btnAddStudent.Location = New Point(130, 215)
        btnAddStudent.Name = "btnAddStudent"
        btnAddStudent.Size = New Size(120, 35)
        btnAddStudent.TabIndex = 9
        btnAddStudent.Text = "Add Student"
        btnAddStudent.UseVisualStyleBackColor = False
        ' 
        ' dtpDateOfBirth
        ' 
        dtpDateOfBirth.Format = DateTimePickerFormat.Short
        dtpDateOfBirth.Location = New Point(130, 173)
        dtpDateOfBirth.Name = "dtpDateOfBirth"
        dtpDateOfBirth.Size = New Size(200, 23)
        dtpDateOfBirth.TabIndex = 8
        ' 
        ' lblDateOfBirth
        ' 
        lblDateOfBirth.AutoSize = True
        lblDateOfBirth.Location = New Point(20, 175)
        lblDateOfBirth.Name = "lblDateOfBirth"
        lblDateOfBirth.Size = New Size(76, 15)
        lblDateOfBirth.TabIndex = 7
        lblDateOfBirth.Text = "Date of Birth:"
        ' 
        ' txtStudentUsername
        ' 
        txtStudentUsername.Location = New Point(130, 138)
        txtStudentUsername.Name = "txtStudentUsername"
        txtStudentUsername.Size = New Size(200, 23)
        txtStudentUsername.TabIndex = 6
        ' 
        ' lblStudentUsername
        ' 
        lblStudentUsername.AutoSize = True
        lblStudentUsername.Location = New Point(20, 140)
        lblStudentUsername.Name = "lblStudentUsername"
        lblStudentUsername.Size = New Size(63, 15)
        lblStudentUsername.TabIndex = 5
        lblStudentUsername.Text = "Username:"
        ' 
        ' txtStudentLastName
        ' 
        txtStudentLastName.Location = New Point(130, 103)
        txtStudentLastName.Name = "txtStudentLastName"
        txtStudentLastName.Size = New Size(200, 23)
        txtStudentLastName.TabIndex = 4
        ' 
        ' lblStudentLastName
        ' 
        lblStudentLastName.AutoSize = True
        lblStudentLastName.Location = New Point(20, 105)
        lblStudentLastName.Name = "lblStudentLastName"
        lblStudentLastName.Size = New Size(66, 15)
        lblStudentLastName.TabIndex = 3
        lblStudentLastName.Text = "Last Name:"
        ' 
        ' txtStudentFirstName
        ' 
        txtStudentFirstName.Location = New Point(130, 68)
        txtStudentFirstName.Name = "txtStudentFirstName"
        txtStudentFirstName.Size = New Size(200, 23)
        txtStudentFirstName.TabIndex = 2
        ' 
        ' lblStudentFirstName
        ' 
        lblStudentFirstName.AutoSize = True
        lblStudentFirstName.Location = New Point(20, 70)
        lblStudentFirstName.Name = "lblStudentFirstName"
        lblStudentFirstName.Size = New Size(67, 15)
        lblStudentFirstName.TabIndex = 1
        lblStudentFirstName.Text = "First Name:"
        ' 
        ' lblAddStudentTitle
        ' 
        lblAddStudentTitle.AutoSize = True
        lblAddStudentTitle.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        lblAddStudentTitle.Location = New Point(20, 20)
        lblAddStudentTitle.Name = "lblAddStudentTitle"
        lblAddStudentTitle.Size = New Size(168, 22)
        lblAddStudentTitle.TabIndex = 0
        lblAddStudentTitle.Text = "Add New Student"
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(dgvStudents)
        TabPage3.Controls.Add(lblStudents)
        TabPage3.Controls.Add(dgvInstructors)
        TabPage3.Controls.Add(lblInstructors)
        TabPage3.Controls.Add(dgvUsers)
        TabPage3.Controls.Add(lblUsers)
        TabPage3.Controls.Add(btnRefreshUsers)
        TabPage3.Controls.Add(lblViewUsersTitle)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(1192, 772)
        TabPage3.TabIndex = 2
        TabPage3.Text = "View Users & Data"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' dgvStudents
        ' 
        dgvStudents.AllowUserToAddRows = False
        dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStudents.Location = New Point(20, 465)
        dgvStudents.Name = "dgvStudents"
        dgvStudents.ReadOnly = True
        dgvStudents.Size = New Size(1141, 150)
        dgvStudents.TabIndex = 7
        ' 
        ' lblStudents
        ' 
        lblStudents.AutoSize = True
        lblStudents.Font = New Font("Arial", 10.0F, FontStyle.Bold)
        lblStudents.Location = New Point(20, 440)
        lblStudents.Name = "lblStudents"
        lblStudents.Size = New Size(74, 16)
        lblStudents.TabIndex = 6
        lblStudents.Text = "Students:"
        ' 
        ' dgvInstructors
        ' 
        dgvInstructors.AllowUserToAddRows = False
        dgvInstructors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvInstructors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvInstructors.Location = New Point(20, 275)
        dgvInstructors.Name = "dgvInstructors"
        dgvInstructors.ReadOnly = True
        dgvInstructors.Size = New Size(1141, 150)
        dgvInstructors.TabIndex = 5
        ' 
        ' lblInstructors
        ' 
        lblInstructors.AutoSize = True
        lblInstructors.Font = New Font("Arial", 10.0F, FontStyle.Bold)
        lblInstructors.Location = New Point(20, 250)
        lblInstructors.Name = "lblInstructors"
        lblInstructors.Size = New Size(88, 16)
        lblInstructors.TabIndex = 4
        lblInstructors.Text = "Instructors:"
        ' 
        ' dgvUsers
        ' 
        dgvUsers.AllowUserToAddRows = False
        dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvUsers.Location = New Point(20, 85)
        dgvUsers.Name = "dgvUsers"
        dgvUsers.ReadOnly = True
        dgvUsers.Size = New Size(1141, 150)
        dgvUsers.TabIndex = 3
        ' 
        ' lblUsers
        ' 
        lblUsers.AutoSize = True
        lblUsers.Font = New Font("Arial", 10.0F, FontStyle.Bold)
        lblUsers.Location = New Point(20, 60)
        lblUsers.Name = "lblUsers"
        lblUsers.Size = New Size(73, 16)
        lblUsers.TabIndex = 2
        lblUsers.Text = "All Users:"
        ' 
        ' btnRefreshUsers
        ' 
        btnRefreshUsers.BackColor = Color.LightCyan
        btnRefreshUsers.Location = New Point(1020, 18)
        btnRefreshUsers.Name = "btnRefreshUsers"
        btnRefreshUsers.Size = New Size(141, 30)
        btnRefreshUsers.TabIndex = 1
        btnRefreshUsers.Text = "Refresh Data"
        btnRefreshUsers.UseVisualStyleBackColor = False
        ' 
        ' lblViewUsersTitle
        ' 
        lblViewUsersTitle.AutoSize = True
        lblViewUsersTitle.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        lblViewUsersTitle.Location = New Point(20, 20)
        lblViewUsersTitle.Name = "lblViewUsersTitle"
        lblViewUsersTitle.Size = New Size(270, 22)
        lblViewUsersTitle.TabIndex = 0
        lblViewUsersTitle.Text = "User Management Overview"
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(lblSecurityNotice)
        TabPage4.Controls.Add(btnGeneratePassword)
        TabPage4.Controls.Add(btnResetPassword)
        TabPage4.Controls.Add(txtNewPassword)
        TabPage4.Controls.Add(lblNewPassword)
        TabPage4.Controls.Add(cmbSelectUser)
        TabPage4.Controls.Add(lblSelectUser)
        TabPage4.Controls.Add(lblPasswordResetTitle)
        TabPage4.Location = New Point(4, 24)
        TabPage4.Name = "TabPage4"
        TabPage4.Size = New Size(1192, 772)
        TabPage4.TabIndex = 3
        TabPage4.Text = "Password Reset"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' lblSecurityNotice
        ' 
        lblSecurityNotice.BackColor = Color.LightPink
        lblSecurityNotice.BorderStyle = BorderStyle.FixedSingle
        lblSecurityNotice.Location = New Point(20, 200)
        lblSecurityNotice.Name = "lblSecurityNotice"
        lblSecurityNotice.Size = New Size(400, 120)
        lblSecurityNotice.TabIndex = 7
        lblSecurityNotice.Text = resources.GetString("lblSecurityNotice.Text")
        ' 
        ' btnGeneratePassword
        ' 
        btnGeneratePassword.BackColor = Color.LightCyan
        btnGeneratePassword.Location = New Point(260, 145)
        btnGeneratePassword.Name = "btnGeneratePassword"
        btnGeneratePassword.Size = New Size(160, 35)
        btnGeneratePassword.TabIndex = 6
        btnGeneratePassword.Text = "Generate Secure Password"
        btnGeneratePassword.UseVisualStyleBackColor = False
        ' 
        ' btnResetPassword
        ' 
        btnResetPassword.BackColor = Color.Orange
        btnResetPassword.Location = New Point(130, 145)
        btnResetPassword.Name = "btnResetPassword"
        btnResetPassword.Size = New Size(120, 35)
        btnResetPassword.TabIndex = 5
        btnResetPassword.Text = "Reset Password"
        btnResetPassword.UseVisualStyleBackColor = False
        ' 
        ' txtNewPassword
        ' 
        txtNewPassword.Location = New Point(130, 103)
        txtNewPassword.Name = "txtNewPassword"
        txtNewPassword.PasswordChar = "*"c
        txtNewPassword.Size = New Size(290, 23)
        txtNewPassword.TabIndex = 4
        ' 
        ' lblNewPassword
        ' 
        lblNewPassword.AutoSize = True
        lblNewPassword.Location = New Point(20, 105)
        lblNewPassword.Name = "lblNewPassword"
        lblNewPassword.Size = New Size(87, 15)
        lblNewPassword.TabIndex = 3
        lblNewPassword.Text = "New Password:"
        ' 
        ' cmbSelectUser
        ' 
        cmbSelectUser.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSelectUser.FormattingEnabled = True
        cmbSelectUser.Location = New Point(130, 68)
        cmbSelectUser.Name = "cmbSelectUser"
        cmbSelectUser.Size = New Size(290, 23)
        cmbSelectUser.TabIndex = 2
        ' 
        ' lblSelectUser
        ' 
        lblSelectUser.AutoSize = True
        lblSelectUser.Location = New Point(20, 70)
        lblSelectUser.Name = "lblSelectUser"
        lblSelectUser.Size = New Size(67, 15)
        lblSelectUser.TabIndex = 1
        lblSelectUser.Text = "Select User:"
        ' 
        ' lblPasswordResetTitle
        ' 
        lblPasswordResetTitle.AutoSize = True
        lblPasswordResetTitle.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        lblPasswordResetTitle.Location = New Point(20, 20)
        lblPasswordResetTitle.Name = "lblPasswordResetTitle"
        lblPasswordResetTitle.Size = New Size(208, 22)
        lblPasswordResetTitle.TabIndex = 0
        lblPasswordResetTitle.Text = "Reset User Password"
        ' 
        ' Admin
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1200, 800)
        Controls.Add(TabControl1)
        Name = "Admin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin Dashboard"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvInstructors, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvUsers, ComponentModel.ISupportInitialize).EndInit()
        TabPage4.ResumeLayout(False)
        TabPage4.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents lblAddInstructorTitle As Label
    Friend WithEvents txtInstructorFirstName As TextBox
    Friend WithEvents lblInstructorFirstName As Label
    Friend WithEvents txtInstructorLastName As TextBox
    Friend WithEvents lblInstructorLastName As Label
    Friend WithEvents txtInstructorUsername As TextBox
    Friend WithEvents lblInstructorUsername As Label
    Friend WithEvents txtInstructorDepartment As TextBox
    Friend WithEvents lblInstructorDepartment As Label
    Friend WithEvents btnAddInstructor As Button
    Friend WithEvents lblInstructorInstructions As Label
    Friend WithEvents lblAddStudentTitle As Label
    Friend WithEvents txtStudentFirstName As TextBox
    Friend WithEvents lblStudentFirstName As Label
    Friend WithEvents txtStudentLastName As TextBox
    Friend WithEvents lblStudentLastName As Label
    Friend WithEvents txtStudentUsername As TextBox
    Friend WithEvents lblStudentUsername As Label
    Friend WithEvents dtpDateOfBirth As DateTimePicker
    Friend WithEvents lblDateOfBirth As Label
    Friend WithEvents btnAddStudent As Button
    Friend WithEvents lblStudentInstructions As Label
    Friend WithEvents lblViewUsersTitle As Label
    Friend WithEvents btnRefreshUsers As Button
    Friend WithEvents lblUsers As Label
    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents lblInstructors As Label
    Friend WithEvents dgvInstructors As DataGridView
    Friend WithEvents lblStudents As Label
    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents lblPasswordResetTitle As Label
    Friend WithEvents lblSelectUser As Label
    Friend WithEvents cmbSelectUser As ComboBox
    Friend WithEvents lblNewPassword As Label
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents btnResetPassword As Button
    Friend WithEvents btnGeneratePassword As Button
    Friend WithEvents lblSecurityNotice As Label
End Class
