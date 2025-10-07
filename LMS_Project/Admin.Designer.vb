<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        btnAddUser = New Button()
        txtPassword = New TextBox()
        lblPassword = New Label()
        cmbRole = New ComboBox()
        lblRole = New Label()
        txtUsername = New TextBox()
        lblUsername = New Label()
        txtLastName = New TextBox()
        lblLastName = New Label()
        txtFirstName = New TextBox()
        lblFirstName = New Label()
        lblAddUserTitle = New Label()
        TabPage2 = New TabPage()
        dgvStudents = New DataGridView()
        lblStudents = New Label()
        dgvInstructors = New DataGridView()
        lblInstructors = New Label()
        dgvUsers = New DataGridView()
        lblUsers = New Label()
        btnRefreshUsers = New Button()
        btnViewDetails = New Button()
        lblUserDetails = New Label()
        txtUserDetails = New TextBox()
        cmbSelectUserDetails = New ComboBox()
        lblSelectUserDetails = New Label()
        lblUserDetailsTitle = New Label()
        TabPage3 = New TabPage()
        btnResetPassword = New Button()
        txtNewPassword = New TextBox()
        lblNewPassword = New Label()
        cmbSelectUserReset = New ComboBox()
        lblSelectUserReset = New Label()
        lblPasswordResetTitle = New Label()
        TabPage4 = New TabPage()
        btnDeleteAssignmentType = New Button()
        btnEditAssignmentType = New Button()
        btnAddAssignmentType = New Button()
        txtAssignmentTypeName = New TextBox()
        lblAssignmentTypeName = New Label()
        dgvAssignmentTypes = New DataGridView()
        lblAssignmentTypesTitle = New Label()
        TabPage5 = New TabPage()
        btnRefreshGrades = New Button()
        dgvSystemGrades = New DataGridView()
        lblSystemGradesTitle = New Label()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvInstructors, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvUsers, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        TabPage4.SuspendLayout()
        CType(dgvAssignmentTypes, ComponentModel.ISupportInitialize).BeginInit()
        TabPage5.SuspendLayout()
        CType(dgvSystemGrades, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Controls.Add(TabPage5)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1200, 800)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(btnAddUser)
        TabPage1.Controls.Add(txtPassword)
        TabPage1.Controls.Add(lblPassword)
        TabPage1.Controls.Add(cmbRole)
        TabPage1.Controls.Add(lblRole)
        TabPage1.Controls.Add(txtUsername)
        TabPage1.Controls.Add(lblUsername)
        TabPage1.Controls.Add(txtLastName)
        TabPage1.Controls.Add(lblLastName)
        TabPage1.Controls.Add(txtFirstName)
        TabPage1.Controls.Add(lblFirstName)
        TabPage1.Controls.Add(lblAddUserTitle)
        TabPage1.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        TabPage1.Location = New Point(4, 32)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1192, 764)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Add User"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' btnAddUser
        ' 
        btnAddUser.BackColor = Color.LightBlue
        btnAddUser.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        btnAddUser.Location = New Point(256, 562)
        btnAddUser.Name = "btnAddUser"
        btnAddUser.Size = New Size(124, 35)
        btnAddUser.TabIndex = 11
        btnAddUser.Text = "Add User"
        btnAddUser.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        txtPassword.Location = New Point(30, 481)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(350, 32)
        txtPassword.TabIndex = 10
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        lblPassword.Location = New Point(30, 442)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(96, 25)
        lblPassword.TabIndex = 9
        lblPassword.Text = "Password"
        ' 
        ' cmbRole
        ' 
        cmbRole.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRole.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        cmbRole.FormattingEnabled = True
        cmbRole.Location = New Point(30, 381)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(350, 31)
        cmbRole.TabIndex = 8
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        lblRole.Location = New Point(30, 343)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(53, 25)
        lblRole.TabIndex = 7
        lblRole.Text = "Role"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        txtUsername.Location = New Point(30, 284)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(350, 32)
        txtUsername.TabIndex = 6
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        lblUsername.Location = New Point(30, 245)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(99, 25)
        lblUsername.TabIndex = 5
        lblUsername.Text = "Username"
        ' 
        ' txtLastName
        ' 
        txtLastName.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        txtLastName.Location = New Point(30, 190)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(350, 32)
        txtLastName.TabIndex = 4
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        lblLastName.Location = New Point(30, 162)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(107, 25)
        lblLastName.TabIndex = 3
        lblLastName.Text = "Last Name"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        txtFirstName.Location = New Point(30, 102)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(350, 32)
        txtFirstName.TabIndex = 2
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        lblFirstName.Location = New Point(30, 70)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(110, 25)
        lblFirstName.TabIndex = 1
        lblFirstName.Text = "First Name"
        ' 
        ' lblAddUserTitle
        ' 
        lblAddUserTitle.AutoSize = True
        lblAddUserTitle.Font = New Font("Times New Roman", 20.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        lblAddUserTitle.Location = New Point(18, 17)
        lblAddUserTitle.Name = "lblAddUserTitle"
        lblAddUserTitle.Size = New Size(183, 31)
        lblAddUserTitle.TabIndex = 0
        lblAddUserTitle.Text = "Add New User"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(dgvStudents)
        TabPage2.Controls.Add(lblStudents)
        TabPage2.Controls.Add(dgvInstructors)
        TabPage2.Controls.Add(lblInstructors)
        TabPage2.Controls.Add(dgvUsers)
        TabPage2.Controls.Add(lblUsers)
        TabPage2.Controls.Add(btnRefreshUsers)
        TabPage2.Controls.Add(btnViewDetails)
        TabPage2.Controls.Add(lblUserDetails)
        TabPage2.Controls.Add(txtUserDetails)
        TabPage2.Controls.Add(cmbSelectUserDetails)
        TabPage2.Controls.Add(lblSelectUserDetails)
        TabPage2.Controls.Add(lblUserDetailsTitle)
        TabPage2.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        TabPage2.Location = New Point(4, 32)
        TabPage2.Name = "TabPage2"
        TabPage2.Size = New Size(1192, 764)
        TabPage2.TabIndex = 1
        TabPage2.Text = "User Management"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' dgvStudents
        ' 
        dgvStudents.AllowUserToAddRows = False
        dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStudents.Font = New Font("Times New Roman", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        dgvStudents.Location = New Point(650, 465)
        dgvStudents.Name = "dgvStudents"
        dgvStudents.ReadOnly = True
        dgvStudents.Size = New Size(520, 150)
        dgvStudents.TabIndex = 12
        ' 
        ' lblStudents
        ' 
        lblStudents.AutoSize = True
        lblStudents.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        lblStudents.Location = New Point(650, 435)
        lblStudents.Name = "lblStudents"
        lblStudents.Size = New Size(87, 25)
        lblStudents.TabIndex = 11
        lblStudents.Text = "Students"
        ' 
        ' dgvInstructors
        ' 
        dgvInstructors.AllowUserToAddRows = False
        dgvInstructors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvInstructors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvInstructors.Font = New Font("Times New Roman", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        dgvInstructors.Location = New Point(650, 275)
        dgvInstructors.Name = "dgvInstructors"
        dgvInstructors.ReadOnly = True
        dgvInstructors.Size = New Size(520, 150)
        dgvInstructors.TabIndex = 10
        ' 
        ' lblInstructors
        ' 
        lblInstructors.AutoSize = True
        lblInstructors.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        lblInstructors.Location = New Point(650, 245)
        lblInstructors.Name = "lblInstructors"
        lblInstructors.Size = New Size(104, 25)
        lblInstructors.TabIndex = 9
        lblInstructors.Text = "Instructors"
        ' 
        ' dgvUsers
        ' 
        dgvUsers.AllowUserToAddRows = False
        dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvUsers.Font = New Font("Times New Roman", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        dgvUsers.Location = New Point(650, 85)
        dgvUsers.Name = "dgvUsers"
        dgvUsers.ReadOnly = True
        dgvUsers.Size = New Size(520, 150)
        dgvUsers.TabIndex = 8
        ' 
        ' lblUsers
        ' 
        lblUsers.AutoSize = True
        lblUsers.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        lblUsers.Location = New Point(650, 55)
        lblUsers.Name = "lblUsers"
        lblUsers.Size = New Size(96, 25)
        lblUsers.TabIndex = 7
        lblUsers.Text = "All Users"
        ' 
        ' btnRefreshUsers
        ' 
        btnRefreshUsers.BackColor = Color.LightCyan
        btnRefreshUsers.Font = New Font("Times New Roman", 14.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        btnRefreshUsers.Location = New Point(1030, 15)
        btnRefreshUsers.Name = "btnRefreshUsers"
        btnRefreshUsers.Size = New Size(140, 35)
        btnRefreshUsers.TabIndex = 6
        btnRefreshUsers.Text = "Refresh Data"
        btnRefreshUsers.UseVisualStyleBackColor = False
        ' 
        ' btnViewDetails
        ' 
        btnViewDetails.BackColor = Color.LightGreen
        btnViewDetails.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        btnViewDetails.Location = New Point(243, 147)
        btnViewDetails.Name = "btnViewDetails"
        btnViewDetails.Size = New Size(137, 40)
        btnViewDetails.TabIndex = 5
        btnViewDetails.Text = "View Details"
        btnViewDetails.UseVisualStyleBackColor = False
        ' 
        ' lblUserDetails
        ' 
        lblUserDetails.AutoSize = True
        lblUserDetails.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        lblUserDetails.Location = New Point(30, 200)
        lblUserDetails.Name = "lblUserDetails"
        lblUserDetails.Size = New Size(122, 25)
        lblUserDetails.TabIndex = 4
        lblUserDetails.Text = "User Details"
        ' 
        ' txtUserDetails
        ' 
        txtUserDetails.Font = New Font("Courier New", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        txtUserDetails.Location = New Point(30, 230)
        txtUserDetails.Multiline = True
        txtUserDetails.Name = "txtUserDetails"
        txtUserDetails.ReadOnly = True
        txtUserDetails.ScrollBars = ScrollBars.Vertical
        txtUserDetails.Size = New Size(600, 435)
        txtUserDetails.TabIndex = 3
        ' 
        ' cmbSelectUserDetails
        ' 
        cmbSelectUserDetails.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSelectUserDetails.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        cmbSelectUserDetails.FormattingEnabled = True
        cmbSelectUserDetails.Location = New Point(30, 95)
        cmbSelectUserDetails.Name = "cmbSelectUserDetails"
        cmbSelectUserDetails.Size = New Size(350, 31)
        cmbSelectUserDetails.TabIndex = 2
        ' 
        ' lblSelectUserDetails
        ' 
        lblSelectUserDetails.AutoSize = True
        lblSelectUserDetails.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        lblSelectUserDetails.Location = New Point(30, 67)
        lblSelectUserDetails.Name = "lblSelectUserDetails"
        lblSelectUserDetails.Size = New Size(113, 25)
        lblSelectUserDetails.TabIndex = 1
        lblSelectUserDetails.Text = "Select User"
        ' 
        ' lblUserDetailsTitle
        ' 
        lblUserDetailsTitle.AutoSize = True
        lblUserDetailsTitle.Font = New Font("Times New Roman", 20.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        lblUserDetailsTitle.Location = New Point(8, 15)
        lblUserDetailsTitle.Name = "lblUserDetailsTitle"
        lblUserDetailsTitle.Size = New Size(300, 31)
        lblUserDetailsTitle.TabIndex = 0
        lblUserDetailsTitle.Text = "User Management Panel"
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(btnResetPassword)
        TabPage3.Controls.Add(txtNewPassword)
        TabPage3.Controls.Add(lblNewPassword)
        TabPage3.Controls.Add(cmbSelectUserReset)
        TabPage3.Controls.Add(lblSelectUserReset)
        TabPage3.Controls.Add(lblPasswordResetTitle)
        TabPage3.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        TabPage3.Location = New Point(4, 32)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(1192, 764)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Password Reset"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' btnResetPassword
        ' 
        btnResetPassword.BackColor = Color.LightBlue
        btnResetPassword.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        btnResetPassword.Location = New Point(209, 295)
        btnResetPassword.Name = "btnResetPassword"
        btnResetPassword.Size = New Size(171, 45)
        btnResetPassword.TabIndex = 5
        btnResetPassword.Text = "Reset Password"
        btnResetPassword.UseVisualStyleBackColor = False
        ' 
        ' txtNewPassword
        ' 
        txtNewPassword.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        txtNewPassword.Location = New Point(30, 228)
        txtNewPassword.Name = "txtNewPassword"
        txtNewPassword.PasswordChar = "*"c
        txtNewPassword.Size = New Size(350, 32)
        txtNewPassword.TabIndex = 4
        ' 
        ' lblNewPassword
        ' 
        lblNewPassword.AutoSize = True
        lblNewPassword.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        lblNewPassword.Location = New Point(30, 189)
        lblNewPassword.Name = "lblNewPassword"
        lblNewPassword.Size = New Size(143, 25)
        lblNewPassword.TabIndex = 3
        lblNewPassword.Text = "New Password"
        ' 
        ' cmbSelectUserReset
        ' 
        cmbSelectUserReset.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSelectUserReset.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        cmbSelectUserReset.FormattingEnabled = True
        cmbSelectUserReset.Location = New Point(30, 110)
        cmbSelectUserReset.Name = "cmbSelectUserReset"
        cmbSelectUserReset.Size = New Size(350, 31)
        cmbSelectUserReset.TabIndex = 2
        ' 
        ' lblSelectUserReset
        ' 
        lblSelectUserReset.AutoSize = True
        lblSelectUserReset.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        lblSelectUserReset.Location = New Point(30, 80)
        lblSelectUserReset.Name = "lblSelectUserReset"
        lblSelectUserReset.Size = New Size(113, 25)
        lblSelectUserReset.TabIndex = 1
        lblSelectUserReset.Text = "Select User"
        ' 
        ' lblPasswordResetTitle
        ' 
        lblPasswordResetTitle.AutoSize = True
        lblPasswordResetTitle.Font = New Font("Times New Roman", 20.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        lblPasswordResetTitle.Location = New Point(19, 19)
        lblPasswordResetTitle.Name = "lblPasswordResetTitle"
        lblPasswordResetTitle.Size = New Size(257, 31)
        lblPasswordResetTitle.TabIndex = 0
        lblPasswordResetTitle.Text = "Password Reset Tool"
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(btnDeleteAssignmentType)
        TabPage4.Controls.Add(btnEditAssignmentType)
        TabPage4.Controls.Add(btnAddAssignmentType)
        TabPage4.Controls.Add(txtAssignmentTypeName)
        TabPage4.Controls.Add(lblAssignmentTypeName)
        TabPage4.Controls.Add(dgvAssignmentTypes)
        TabPage4.Controls.Add(lblAssignmentTypesTitle)
        TabPage4.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        TabPage4.Location = New Point(4, 32)
        TabPage4.Name = "TabPage4"
        TabPage4.Size = New Size(1192, 764)
        TabPage4.TabIndex = 3
        TabPage4.Text = "Assignment Types"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteAssignmentType
        ' 
        btnDeleteAssignmentType.BackColor = Color.LightCoral
        btnDeleteAssignmentType.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        btnDeleteAssignmentType.Location = New Point(30, 295)
        btnDeleteAssignmentType.Name = "btnDeleteAssignmentType"
        btnDeleteAssignmentType.Size = New Size(350, 45)
        btnDeleteAssignmentType.TabIndex = 6
        btnDeleteAssignmentType.Text = "Delete Assignment Type"
        btnDeleteAssignmentType.UseVisualStyleBackColor = False
        ' 
        ' btnEditAssignmentType
        ' 
        btnEditAssignmentType.BackColor = Color.LightGreen
        btnEditAssignmentType.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        btnEditAssignmentType.Location = New Point(30, 240)
        btnEditAssignmentType.Name = "btnEditAssignmentType"
        btnEditAssignmentType.Size = New Size(350, 45)
        btnEditAssignmentType.TabIndex = 5
        btnEditAssignmentType.Text = "Edit Assignment Type"
        btnEditAssignmentType.UseVisualStyleBackColor = False
        ' 
        ' btnAddAssignmentType
        ' 
        btnAddAssignmentType.BackColor = Color.LightBlue
        btnAddAssignmentType.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        btnAddAssignmentType.Location = New Point(30, 185)
        btnAddAssignmentType.Name = "btnAddAssignmentType"
        btnAddAssignmentType.Size = New Size(350, 45)
        btnAddAssignmentType.TabIndex = 4
        btnAddAssignmentType.Text = "Add Assignment Type"
        btnAddAssignmentType.UseVisualStyleBackColor = False
        ' 
        ' txtAssignmentTypeName
        ' 
        txtAssignmentTypeName.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        txtAssignmentTypeName.Location = New Point(30, 123)
        txtAssignmentTypeName.Name = "txtAssignmentTypeName"
        txtAssignmentTypeName.Size = New Size(350, 32)
        txtAssignmentTypeName.TabIndex = 3
        ' 
        ' lblAssignmentTypeName
        ' 
        lblAssignmentTypeName.AutoSize = True
        lblAssignmentTypeName.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        lblAssignmentTypeName.Location = New Point(30, 83)
        lblAssignmentTypeName.Name = "lblAssignmentTypeName"
        lblAssignmentTypeName.Size = New Size(222, 25)
        lblAssignmentTypeName.TabIndex = 2
        lblAssignmentTypeName.Text = "Assignment Type Name"
        ' 
        ' dgvAssignmentTypes
        ' 
        dgvAssignmentTypes.AllowUserToAddRows = False
        dgvAssignmentTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAssignmentTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAssignmentTypes.Font = New Font("Times New Roman", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        dgvAssignmentTypes.Location = New Point(30, 400)
        dgvAssignmentTypes.Name = "dgvAssignmentTypes"
        dgvAssignmentTypes.ReadOnly = True
        dgvAssignmentTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAssignmentTypes.Size = New Size(1140, 350)
        dgvAssignmentTypes.TabIndex = 1
        ' 
        ' lblAssignmentTypesTitle
        ' 
        lblAssignmentTypesTitle.AutoSize = True
        lblAssignmentTypesTitle.Font = New Font("Times New Roman", 20.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        lblAssignmentTypesTitle.Location = New Point(17, 18)
        lblAssignmentTypesTitle.Name = "lblAssignmentTypesTitle"
        lblAssignmentTypesTitle.Size = New Size(335, 31)
        lblAssignmentTypesTitle.TabIndex = 0
        lblAssignmentTypesTitle.Text = "Assignment Types Manager"
        ' 
        ' TabPage5
        ' 
        TabPage5.Controls.Add(btnRefreshGrades)
        TabPage5.Controls.Add(dgvSystemGrades)
        TabPage5.Controls.Add(lblSystemGradesTitle)
        TabPage5.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        TabPage5.Location = New Point(4, 32)
        TabPage5.Name = "TabPage5"
        TabPage5.Size = New Size(1192, 764)
        TabPage5.TabIndex = 4
        TabPage5.Text = "System Grades"
        TabPage5.UseVisualStyleBackColor = True
        ' 
        ' btnRefreshGrades
        ' 
        btnRefreshGrades.BackColor = Color.LightCyan
        btnRefreshGrades.Font = New Font("Times New Roman", 14.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        btnRefreshGrades.Location = New Point(1030, 15)
        btnRefreshGrades.Name = "btnRefreshGrades"
        btnRefreshGrades.Size = New Size(140, 35)
        btnRefreshGrades.TabIndex = 2
        btnRefreshGrades.Text = "Refresh Data"
        btnRefreshGrades.UseVisualStyleBackColor = False
        ' 
        ' dgvSystemGrades
        ' 
        dgvSystemGrades.AllowUserToAddRows = False
        dgvSystemGrades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSystemGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSystemGrades.Font = New Font("Times New Roman", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        dgvSystemGrades.Location = New Point(30, 70)
        dgvSystemGrades.Name = "dgvSystemGrades"
        dgvSystemGrades.ReadOnly = True
        dgvSystemGrades.Size = New Size(1140, 680)
        dgvSystemGrades.TabIndex = 1
        ' 
        ' lblSystemGradesTitle
        ' 
        lblSystemGradesTitle.AutoSize = True
        lblSystemGradesTitle.Font = New Font("Times New Roman", 20.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        lblSystemGradesTitle.Location = New Point(30, 15)
        lblSystemGradesTitle.Name = "lblSystemGradesTitle"
        lblSystemGradesTitle.Size = New Size(307, 31)
        lblSystemGradesTitle.TabIndex = 0
        lblSystemGradesTitle.Text = "System Grades Overview"
        ' 
        ' Admin
        ' 
        AutoScaleDimensions = New SizeF(12.0F, 23.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1200, 800)
        Controls.Add(TabControl1)
        Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        Name = "Admin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin Dashboard"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvInstructors, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvUsers, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        TabPage4.ResumeLayout(False)
        TabPage4.PerformLayout()
        CType(dgvAssignmentTypes, ComponentModel.ISupportInitialize).EndInit()
        TabPage5.ResumeLayout(False)
        TabPage5.PerformLayout()
        CType(dgvSystemGrades, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents lblAddUserTitle As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents lblRole As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnAddUser As Button
    Friend WithEvents lblUserInstructions As Label
    Friend WithEvents lblUserDetailsTitle As Label
    Friend WithEvents lblSelectUserDetails As Label
    Friend WithEvents cmbSelectUserDetails As ComboBox
    Friend WithEvents txtUserDetails As TextBox
    Friend WithEvents lblUserDetails As Label
    Friend WithEvents btnViewDetails As Button
    Friend WithEvents btnRefreshUsers As Button
    Friend WithEvents lblUsers As Label
    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents lblInstructors As Label
    Friend WithEvents dgvInstructors As DataGridView
    Friend WithEvents lblStudents As Label
    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents lblPasswordResetTitle As Label
    Friend WithEvents lblSelectUserReset As Label
    Friend WithEvents cmbSelectUserReset As ComboBox
    Friend WithEvents lblNewPassword As Label
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents btnResetPassword As Button
    Friend WithEvents btnGeneratePassword As Button
    Friend WithEvents lblAssignmentTypesTitle As Label
    Friend WithEvents dgvAssignmentTypes As DataGridView
    Friend WithEvents lblAssignmentTypeName As Label
    Friend WithEvents txtAssignmentTypeName As TextBox
    Friend WithEvents btnAddAssignmentType As Button
    Friend WithEvents btnEditAssignmentType As Button
    Friend WithEvents btnDeleteAssignmentType As Button
    Friend WithEvents lblSystemGradesTitle As Label
    Friend WithEvents dgvSystemGrades As DataGridView
    Friend WithEvents btnRefreshGrades As Button
End Class
