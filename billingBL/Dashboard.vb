Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp
Imports MySql.Data.MySqlClient


Public Class Dashboard

    'Fields'
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form
    Private formBillingInstance As FormBilling = Nothing

    'Constructor'
    Public Sub New()
        ' This call is required by the designer.'
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.'
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 70)
        SideNavbar.Controls.Add(leftBorderBtn)
        'Form'
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub
    'Methods'
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button'
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border'
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
        End If
    End Sub
    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(51, 153, 255)
            currentBtn.ForeColor = Color.White
            currentBtn.IconColor = Color.White
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub
    Private Sub OpenChildForm(childForm As Form)
        'Open only form'
        If currentChildForm IsNot Nothing AndAlso currentChildForm IsNot formBillingInstance Then
            currentChildForm.Hide() ' Sembunyikan form sebelumnya, kecuali FormBilling
        End If
        currentChildForm = childForm
        'End'
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        If Not PanelDesktop.Controls.Contains(childForm) Then
            PanelDesktop.Controls.Add(childForm)
        End If

        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub imgboxlogo_Click(sender As Object, e As EventArgs) Handles imgboxlogo.Click
        DisableButton()
        leftBorderBtn.Visible = False
        OpenChildForm(New FormDashboard)
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ActivateButton(sender, RGBColors.color)
        OpenChildForm(New FormDashboard)
    End Sub

    Private Sub btnBilling_Click(sender As Object, e As EventArgs) Handles btnBilling.Click
        ActivateButton(sender, RGBColors.color)

        ' Gunakan singleton untuk FormBilling
        If formBillingInstance Is Nothing OrElse formBillingInstance.IsDisposed Then
            formBillingInstance = New FormBilling()
        End If

        OpenChildForm(formBillingInstance)
    End Sub

    Private Sub btnFnB_Click(sender As Object, e As EventArgs) Handles btnFnB.Click
        ActivateButton(sender, RGBColors.color)
        OpenChildForm(New FormFnB)
    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        ActivateButton(sender, RGBColors.color)
        OpenChildForm(New FormTransaksi)
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        ActivateButton(sender, RGBColors.color)
        OpenChildForm(New FormLaporan)
    End Sub

    Private Sub btnPengaturan_Click_(sender As Object, e As EventArgs) Handles btnPengaturan.Click
        ActivateButton(sender, RGBColors.color)
        ShowCustomMessageBox()
    End Sub
    Private Sub btnLaporanFnB_Click(sender As Object, e As EventArgs) Handles btnLaporanFnB.Click
        ActivateButton(sender, RGBColors.color)
        OpenChildForm(New FormLaporanFnB)
    End Sub


    'Drag Form'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelJudul_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelJudul.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Dashboard_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ActivateButton(sender, RGBColors.color)'
        OpenChildForm(New FormDashboard)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MsgBox("Are you sure Exit !", vbQuestion + vbYesNo) = vbYes Then
            End
        Else
            Return
        End If
        End
    End Sub


    Private Sub ShowCustomMessageBox()
        ' Buat Form Custom Message Box
        Dim customMessageBox As New Form With {
            .Width = 300,
            .Height = 200,
            .FormBorderStyle = FormBorderStyle.FixedDialog,
            .StartPosition = FormStartPosition.CenterScreen,
            .Text = "Login",
            .MaximizeBox = False,
            .MinimizeBox = False
        }

        ' Label Username
        Dim lblUsername As New Label With {
            .Text = "Username:",
            .Location = New Point(10, 20),
            .Width = 80
        }
        customMessageBox.Controls.Add(lblUsername)

        ' Input Username
        Dim txtUsername As New TextBox With {
            .Location = New Point(100, 20),
            .Width = 150
        }
        customMessageBox.Controls.Add(txtUsername)

        ' Label Password
        Dim lblPassword As New Label With {
            .Text = "Password:",
            .Location = New Point(10, 60),
            .Width = 80
        }
        customMessageBox.Controls.Add(lblPassword)

        ' Input Password
        Dim txtPassword As New TextBox With {
            .Location = New Point(100, 60),
            .Width = 150,
            .PasswordChar = "*"c ' Tampilkan input sebagai asteris
        }
        customMessageBox.Controls.Add(txtPassword)

        ' Tombol Login
        Dim btnLogin As New Button With {
            .Text = "Login",
            .Location = New Point(100, 100),
            .Width = 80
        }
        AddHandler btnLogin.Click, Sub(sender As Object, e As EventArgs)
                                       ' Verifikasi username dan password (opsional)
                                       Dim username = txtUsername.Text
                                       Dim password = txtPassword.Text

                                       If username = "Username" OrElse password = "Password" OrElse username = "" OrElse password = "" Then
                                           MsgBox("Please enter your username and password.", MsgBoxStyle.Exclamation, "Warning")
                                           Return
                                       End If

                                       ' Validasi login
                                       If ValidateLogin(username, password) Then
                                           MsgBox("Login success", MsgBoxStyle.Information, "Information")

                                           customMessageBox.Close()
                                           OpenChildForm(New FormPengaturan())
                                       Else
                                           MsgBox("Username or password is incorrect", MsgBoxStyle.Critical, "Error")
                                       End If


                                   End Sub
        customMessageBox.Controls.Add(btnLogin)

        ' Tampilkan Custom Message Box
        customMessageBox.ShowDialog()
    End Sub

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





End Class