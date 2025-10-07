<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TeacherDashboard
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
        btnRefreshCourses = New Button()
        dgvCourseOverview = New DataGridView()
        lblCourseOverviewTitle = New Label()
        TabPage2 = New TabPage()
        btnUpdateGrade = New Button()
        txtGradeValue = New TextBox()
        lblGradeValue = New Label()
        cmbStudents = New ComboBox()
        lblSelectStudent = New Label()
        cmbAssignmentTypes = New ComboBox()
        lblAssignmentType = New Label()
        cmbCourses = New ComboBox()
        lblSelectCourse = New Label()
        lblGradeManagementTitle = New Label()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(dgvCourseOverview, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1200, 800)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(btnRefreshCourses)
        TabPage1.Controls.Add(dgvCourseOverview)
        TabPage1.Controls.Add(lblCourseOverviewTitle)
        TabPage1.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabPage1.Location = New Point(4, 32)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1192, 764)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Course Overview"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' btnRefreshCourses
        ' 
        btnRefreshCourses.BackColor = Color.LightCyan
        btnRefreshCourses.Font = New Font("Times New Roman", 14.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRefreshCourses.Location = New Point(1030, 15)
        btnRefreshCourses.Name = "btnRefreshCourses"
        btnRefreshCourses.Size = New Size(140, 35)
        btnRefreshCourses.TabIndex = 2
        btnRefreshCourses.Text = "Refresh Data"
        btnRefreshCourses.UseVisualStyleBackColor = False
        ' 
        ' dgvCourseOverview
        ' 
        dgvCourseOverview.AllowUserToAddRows = False
        dgvCourseOverview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCourseOverview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCourseOverview.Font = New Font("Times New Roman", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dgvCourseOverview.Location = New Point(30, 70)
        dgvCourseOverview.Name = "dgvCourseOverview"
        dgvCourseOverview.ReadOnly = True
        dgvCourseOverview.Size = New Size(1140, 680)
        dgvCourseOverview.TabIndex = 1
        ' 
        ' lblCourseOverviewTitle
        ' 
        lblCourseOverviewTitle.AutoSize = True
        lblCourseOverviewTitle.Font = New Font("Times New Roman", 20.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCourseOverviewTitle.Location = New Point(30, 15)
        lblCourseOverviewTitle.Name = "lblCourseOverviewTitle"
        lblCourseOverviewTitle.Size = New Size(273, 31)
        lblCourseOverviewTitle.TabIndex = 0
        lblCourseOverviewTitle.Text = "My Courses Overview"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(btnUpdateGrade)
        TabPage2.Controls.Add(txtGradeValue)
        TabPage2.Controls.Add(lblGradeValue)
        TabPage2.Controls.Add(cmbStudents)
        TabPage2.Controls.Add(lblSelectStudent)
        TabPage2.Controls.Add(cmbAssignmentTypes)
        TabPage2.Controls.Add(lblAssignmentType)
        TabPage2.Controls.Add(cmbCourses)
        TabPage2.Controls.Add(lblSelectCourse)
        TabPage2.Controls.Add(lblGradeManagementTitle)
        TabPage2.Font = New Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabPage2.Location = New Point(4, 32)
        TabPage2.Name = "TabPage2"
        TabPage2.Size = New Size(1192, 764)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Grade Management"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' btnUpdateGrade
        ' 
        btnUpdateGrade.BackColor = Color.LightBlue
        btnUpdateGrade.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUpdateGrade.Location = New Point(30, 491)
        btnUpdateGrade.Name = "btnUpdateGrade"
        btnUpdateGrade.Size = New Size(350, 45)
        btnUpdateGrade.TabIndex = 9
        btnUpdateGrade.Text = "Update Grade"
        btnUpdateGrade.UseVisualStyleBackColor = False
        ' 
        ' txtGradeValue
        ' 
        txtGradeValue.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtGradeValue.Location = New Point(30, 405)
        txtGradeValue.Name = "txtGradeValue"
        txtGradeValue.Size = New Size(431, 32)
        txtGradeValue.TabIndex = 8
        ' 
        ' lblGradeValue
        ' 
        lblGradeValue.AutoSize = True
        lblGradeValue.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblGradeValue.Location = New Point(30, 377)
        lblGradeValue.Name = "lblGradeValue"
        lblGradeValue.Size = New Size(137, 25)
        lblGradeValue.TabIndex = 7
        lblGradeValue.Text = "Grade (0-100)"
        ' 
        ' cmbStudents
        ' 
        cmbStudents.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStudents.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbStudents.FormattingEnabled = True
        cmbStudents.Location = New Point(27, 298)
        cmbStudents.Name = "cmbStudents"
        cmbStudents.Size = New Size(434, 31)
        cmbStudents.TabIndex = 6
        ' 
        ' lblSelectStudent
        ' 
        lblSelectStudent.AutoSize = True
        lblSelectStudent.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSelectStudent.Location = New Point(24, 270)
        lblSelectStudent.Name = "lblSelectStudent"
        lblSelectStudent.Size = New Size(138, 25)
        lblSelectStudent.TabIndex = 5
        lblSelectStudent.Text = "Select Student"
        ' 
        ' cmbAssignmentTypes
        ' 
        cmbAssignmentTypes.DropDownStyle = ComboBoxStyle.DropDownList
        cmbAssignmentTypes.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbAssignmentTypes.FormattingEnabled = True
        cmbAssignmentTypes.Location = New Point(30, 202)
        cmbAssignmentTypes.Name = "cmbAssignmentTypes"
        cmbAssignmentTypes.Size = New Size(431, 31)
        cmbAssignmentTypes.TabIndex = 4
        ' 
        ' lblAssignmentType
        ' 
        lblAssignmentType.AutoSize = True
        lblAssignmentType.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAssignmentType.Location = New Point(27, 165)
        lblAssignmentType.Name = "lblAssignmentType"
        lblAssignmentType.Size = New Size(164, 25)
        lblAssignmentType.TabIndex = 3
        lblAssignmentType.Text = "Assignment Type"
        ' 
        ' cmbCourses
        ' 
        cmbCourses.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCourses.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbCourses.FormattingEnabled = True
        cmbCourses.Location = New Point(27, 97)
        cmbCourses.Name = "cmbCourses"
        cmbCourses.Size = New Size(431, 31)
        cmbCourses.TabIndex = 2
        ' 
        ' lblSelectCourse
        ' 
        lblSelectCourse.AutoSize = True
        lblSelectCourse.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSelectCourse.Location = New Point(27, 69)
        lblSelectCourse.Name = "lblSelectCourse"
        lblSelectCourse.Size = New Size(135, 25)
        lblSelectCourse.TabIndex = 1
        lblSelectCourse.Text = "Select Course"
        ' 
        ' lblGradeManagementTitle
        ' 
        lblGradeManagementTitle.AutoSize = True
        lblGradeManagementTitle.Font = New Font("Times New Roman", 20.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGradeManagementTitle.Location = New Point(8, 17)
        lblGradeManagementTitle.Name = "lblGradeManagementTitle"
        lblGradeManagementTitle.Size = New Size(246, 31)
        lblGradeManagementTitle.TabIndex = 0
        lblGradeManagementTitle.Text = "Grade Management"
        ' 
        ' TeacherDashboard
        ' 
        AutoScaleDimensions = New SizeF(12.0F, 23.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1200, 800)
        Controls.Add(TabControl1)
        Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "TeacherDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Teacher Dashboard"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(dgvCourseOverview, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lblCourseOverviewTitle As Label
    Friend WithEvents dgvCourseOverview As DataGridView
    Friend WithEvents btnRefreshCourses As Button
    Friend WithEvents lblGradeManagementTitle As Label
    Friend WithEvents lblSelectCourse As Label
    Friend WithEvents cmbCourses As ComboBox
    Friend WithEvents lblAssignmentType As Label
    Friend WithEvents cmbAssignmentTypes As ComboBox
    Friend WithEvents lblSelectStudent As Label
    Friend WithEvents cmbStudents As ComboBox
    Friend WithEvents lblGradeValue As Label
    Friend WithEvents txtGradeValue As TextBox
    Friend WithEvents btnUpdateGrade As Button
End Class
