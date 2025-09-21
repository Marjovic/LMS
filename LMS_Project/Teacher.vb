Public Class Teacher
    Private Sub Teacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the form title with current user info
        Me.Text = $"Teacher Dashboard - Welcome {login.CurrentUsername}"

        ' Display welcome message
        MessageBox.Show($"Welcome to Teacher Dashboard!" & vbCrLf &
                       $"User: {login.CurrentUsername}" & vbCrLf &
                       $"Role: {login.CurrentUserRoleName}", "Teacher Dashboard Loaded")
    End Sub

    Private Sub Teacher_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Clear user session when teacher form is closed
        login.ClearUserSession()

        ' Show login form again
        Dim loginForm As New login()
        loginForm.Show()
    End Sub
End Class