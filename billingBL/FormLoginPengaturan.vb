Imports MySql.Data.MySqlClient

Public Class FormLoginPengaturan
    Private Sub FormLoginPengaturan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPass.PasswordChar = "●"c ' Set karakter untuk menyembunyikan password
    End Sub

    ' Fungsi validasi login
    Private Function ValidateLogin(username As String, password As String) As Boolean
        Try
            connect() ' Gunakan fungsi connect() dari ModuleDB

            ' Query untuk memeriksa username dan password
            Dim query As String = "SELECT COUNT(*) FROM tb_admin WHERE username = @username AND password = @password"
            CMD = New MySqlCommand(query, Koneksi)
            CMD.Parameters.AddWithValue("@username", username)
            CMD.Parameters.AddWithValue("@password", password)

            ' Eksekusi query dan periksa hasilnya
            Dim result As Integer = Convert.ToInt32(CMD.ExecuteScalar())
            Return result > 0
        Catch ex As Exception
            MsgBox("Error validating login: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        Finally
            ' Pastikan reader dan command dibersihkan
            If DR IsNot Nothing AndAlso Not DR.IsClosed Then DR.Close()
            CMD?.Dispose()
            disconnect() ' Gunakan fungsi disconnect() dari ModuleDB
        End Try
    End Function

    ' Event Klik Tombol Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUser.Text
        Dim password As String = txtPass.Text

        ' Validasi input kosong
        If username = "Username" OrElse password = "Password" OrElse username = "" OrElse password = "" Then
            MsgBox("Please enter your username and password.", MsgBoxStyle.Exclamation, "Warning")
            Return
        End If

        ' Validasi login
        If ValidateLogin(username, password) Then
            MsgBox("Login success", MsgBoxStyle.Information, "Information")

            Me.Hide() ' Gunakan Me.Hide agar aplikasi tidak tertutup
        Else
            MsgBox("Username or password is incorrect", MsgBoxStyle.Critical, "Error")
        End If
    End Sub


    ' KeyPress event untuk login saat menekan Enter
    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnLogin.PerformClick()
        End If
    End Sub
End Class