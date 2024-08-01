Public Class Loginpage
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub txtUser_GotFocus(sender As Object, e As EventArgs) Handles txtUser.GotFocus
        If txtUser.Text = "Username" Then
            txtUser.Text = ""
            txtUser.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtUser_LostFocus(sender As Object, e As EventArgs) Handles txtUser.LostFocus
        If txtUser.Text = "" Then
            txtUser.Text = "Username"
            txtUser.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtPass_GotFocus(sender As Object, e As EventArgs) Handles txtPass.GotFocus
        If txtPass.Text = "Password" Then
            txtPass.Text = ""
            txtPass.PasswordChar = "●"
            txtPass.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPass_lostFocus(sender As Object, e As EventArgs) Handles txtPass.LostFocus
        If txtPass.Text = "" Then
            txtPass.Text = "Password"
            txtPass.PasswordChar = "●"
            txtPass.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String
        Dim password As String
        username = txtUser.Text
        password = txtPass.Text
        If username.Equals("admin") And password.Equals("admin123") Then
            MessageBox.Show("login success", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dashboard.Show()
            Me.Hide()
        Else
            MessageBox.Show("username / password is incorrect", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim username As String
            Dim password As String
            username = txtUser.Text
            password = txtPass.Text
            If username.Equals("admin") And password.Equals("admin123") Then
                MessageBox.Show("login success", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dashboard.Show()
                Me.Hide()
            Else
                MessageBox.Show("username / password is incorrect", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub Loginpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
    End Sub
End Class
