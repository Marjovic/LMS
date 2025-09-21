<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        username_box = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        password_box = New TextBox()
        Label3 = New Label()
        login_button = New Button()
        btnTogglePassword = New Button()
        SuspendLayout()
        ' 
        ' username_box
        ' 
        username_box.Location = New Point(75, 143)
        username_box.Name = "username_box"
        username_box.Size = New Size(289, 29)
        username_box.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(75, 119)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 21)
        Label1.TabIndex = 1
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(75, 215)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 21)
        Label2.TabIndex = 2
        Label2.Text = "Password"
        ' 
        ' password_box
        ' 
        password_box.Location = New Point(75, 239)
        password_box.Name = "password_box"
        password_box.Size = New Size(289, 29)
        password_box.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(75, 60)
        Label3.Name = "Label3"
        Label3.Size = New Size(289, 27)
        Label3.TabIndex = 4
        Label3.Text = "Please enter your credentials"
        ' 
        ' login_button
        ' 
        login_button.Location = New Point(271, 326)
        login_button.Name = "login_button"
        login_button.Size = New Size(93, 29)
        login_button.TabIndex = 5
        login_button.Text = "Login"
        login_button.UseVisualStyleBackColor = True
        ' 
        ' btnTogglePassword
        ' 
        btnTogglePassword.BackColor = SystemColors.Window
        btnTogglePassword.FlatStyle = FlatStyle.Flat
        btnTogglePassword.Font = New Font("Times New Roman", 10.0F, FontStyle.Bold)
        btnTogglePassword.ForeColor = SystemColors.WindowText
        btnTogglePassword.Location = New Point(370, 239)
        btnTogglePassword.Name = "btnTogglePassword"
        btnTogglePassword.Size = New Size(35, 29)
        btnTogglePassword.TabIndex = 6
        btnTogglePassword.Text = "👁"
        btnTogglePassword.UseVisualStyleBackColor = False
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 21.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1143, 630)
        Controls.Add(btnTogglePassword)
        Controls.Add(login_button)
        Controls.Add(Label3)
        Controls.Add(password_box)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(username_box)
        Font = New Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = SystemColors.Desktop
        Margin = New Padding(4)
        Name = "login"
        Text = "MGOD LMS"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents username_box As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents password_box As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents login_button As Button
    Friend WithEvents btnTogglePassword As Button

End Class
