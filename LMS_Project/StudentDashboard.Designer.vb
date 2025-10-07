<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentDashboard
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
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        btnRefreshGrades = New Button()
        dgvGradeSummary = New DataGridView()
        lblGradeSummaryTitle = New Label()
        TabPage2 = New TabPage()
        btnRefreshAverages = New Button()
        dgvCourseAverages = New DataGridView()
        lblCourseAveragesTitle = New Label()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(dgvGradeSummary, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(dgvCourseAverages, ComponentModel.ISupportInitialize).BeginInit()
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
        TabPage1.Controls.Add(btnRefreshGrades)
        TabPage1.Controls.Add(dgvGradeSummary)
        TabPage1.Controls.Add(lblGradeSummaryTitle)
        TabPage1.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabPage1.Location = New Point(4, 32)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1192, 764)
        TabPage1.TabIndex = 0
        TabPage1.Text = "My Grades"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' btnRefreshGrades
        ' 
        btnRefreshGrades.BackColor = Color.LightCyan
        btnRefreshGrades.Font = New Font("Times New Roman", 14.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRefreshGrades.Location = New Point(1030, 15)
        btnRefreshGrades.Name = "btnRefreshGrades"
        btnRefreshGrades.Size = New Size(140, 35)
        btnRefreshGrades.TabIndex = 2
        btnRefreshGrades.Text = "Refresh Data"
        btnRefreshGrades.UseVisualStyleBackColor = False
        ' 
        ' dgvGradeSummary
        ' 
        dgvGradeSummary.AllowUserToAddRows = False
        dgvGradeSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvGradeSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvGradeSummary.Font = New Font("Times New Roman", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dgvGradeSummary.Location = New Point(30, 70)
        dgvGradeSummary.Name = "dgvGradeSummary"
        dgvGradeSummary.ReadOnly = True
        dgvGradeSummary.Size = New Size(1140, 680)
        dgvGradeSummary.TabIndex = 1
        ' 
        ' lblGradeSummaryTitle
        ' 
        lblGradeSummaryTitle.AutoSize = True
        lblGradeSummaryTitle.Font = New Font("Times New Roman", 20.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGradeSummaryTitle.Location = New Point(30, 15)
        lblGradeSummaryTitle.Name = "lblGradeSummaryTitle"
        lblGradeSummaryTitle.Size = New Size(222, 31)
        lblGradeSummaryTitle.TabIndex = 0
        lblGradeSummaryTitle.Text = "My Grade Report"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(btnRefreshAverages)
        TabPage2.Controls.Add(dgvCourseAverages)
        TabPage2.Controls.Add(lblCourseAveragesTitle)
        TabPage2.Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabPage2.Location = New Point(4, 32)
        TabPage2.Name = "TabPage2"
        TabPage2.Size = New Size(1192, 764)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Course Averages"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' btnRefreshAverages
        ' 
        btnRefreshAverages.BackColor = Color.LightCyan
        btnRefreshAverages.Font = New Font("Times New Roman", 14.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRefreshAverages.Location = New Point(1030, 15)
        btnRefreshAverages.Name = "btnRefreshAverages"
        btnRefreshAverages.Size = New Size(140, 35)
        btnRefreshAverages.TabIndex = 2
        btnRefreshAverages.Text = "Refresh Data"
        btnRefreshAverages.UseVisualStyleBackColor = False
        ' 
        ' dgvCourseAverages
        ' 
        dgvCourseAverages.AllowUserToAddRows = False
        dgvCourseAverages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCourseAverages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCourseAverages.Font = New Font("Times New Roman", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dgvCourseAverages.Location = New Point(30, 70)
        dgvCourseAverages.Name = "dgvCourseAverages"
        dgvCourseAverages.ReadOnly = True
        dgvCourseAverages.Size = New Size(1140, 680)
        dgvCourseAverages.TabIndex = 1
        ' 
        ' lblCourseAveragesTitle
        ' 
        lblCourseAveragesTitle.AutoSize = True
        lblCourseAveragesTitle.Font = New Font("Times New Roman", 20.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCourseAveragesTitle.Location = New Point(30, 15)
        lblCourseAveragesTitle.Name = "lblCourseAveragesTitle"
        lblCourseAveragesTitle.Size = New Size(332, 31)
        lblCourseAveragesTitle.TabIndex = 0
        lblCourseAveragesTitle.Text = "My Course Average Report"
        ' 
        ' StudentDashboard
        ' 
        AutoScaleDimensions = New SizeF(12.0F, 23.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1200, 800)
        Controls.Add(TabControl1)
        Font = New Font("Times New Roman", 16.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "StudentDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Dashboard"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(dgvGradeSummary, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(dgvCourseAverages, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lblGradeSummaryTitle As Label
    Friend WithEvents dgvGradeSummary As DataGridView
    Friend WithEvents btnRefreshGrades As Button
    Friend WithEvents lblCourseAveragesTitle As Label
    Friend WithEvents dgvCourseAverages As DataGridView
    Friend WithEvents btnRefreshAverages As Button
End Class
