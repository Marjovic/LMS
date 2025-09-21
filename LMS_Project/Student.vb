Public Class Student
    Private Sub Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the form title with current user info
        Me.Text = $"Student Dashboard - Welcome {login.CurrentUsername}"

        ' Display welcome message
        MessageBox.Show($"Welcome to Student Dashboard!" & vbCrLf &
                       $"User: {login.CurrentUsername}" & vbCrLf &
                       $"Role: {login.CurrentUserRoleName}", "Student Dashboard Loaded")
    End Sub

    Private Sub Student_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Clear user session when student form is closed
        login.ClearUserSession()

        ' Show login form again
        Dim loginForm As New login()
        loginForm.Show()
    End Sub
End Class