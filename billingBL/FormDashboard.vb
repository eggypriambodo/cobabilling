Imports System.IO
Imports System.IO.Ports
Imports System.Management
Imports System.Threading
Imports MySql.Data.MySqlClient

Public Class FormDashboard


    Shared _continue As Boolean
    Public Shared _serialPort As SerialPort
    Public Shared correctPortName As String  ' Variable to store the correct port name

    ' Method to find and initialize the correct serial port based on command
    Sub munculserial(expectedDescription As String)
        Dim foundPort As String = Nothing

        ' Use ManagementObjectSearcher to get detailed information about serial ports
        Dim searcher As New ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption LIKE '%(COM%'")
        For Each obj As ManagementObject In searcher.Get()
            Dim portName As String = obj("Caption").ToString()
            ' Check if the port description contains the expected description
            If portName.Contains(expectedDescription) Then
                ' Extract the COM port name (e.g., COM3)
                Dim comPort As String = portName.Substring(portName.LastIndexOf("(") + 1).TrimEnd(")"c)
                correctPortName = comPort
                btnToOnSerialPorts.Enabled = False
                Label1.Text = "PORT SUDAH TERSAMBUNG"
                Try
                    connect()

                Catch ex As Exception
                    MsgBox(ex.Message)

                Finally
                    disconnect()
                    Label2.Text = "DATABASE SUDAH TERSAMBUNG"
                End Try

                Exit For

            End If
        Next

    End Sub

    Public Sub tampilNamaShift()
        Dim query As String = "SELECT * FROM tb_shift"
        Try
            connect()
            Dim cmd As New MySqlCommand(query, Koneksi)
            DA = New MySqlDataAdapter(cmd)
            DT = New DataTable
            DA.Fill(DT)
            ddShift.Items.Clear()

            For i = 0 To DT.Rows.Count - 1
                ddShift.Items.Add(DT.Rows(i).Item("nama"))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try
    End Sub

    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnToOnSerialPorts.Enabled = True
        btnToOffSerialPorts.Enabled = False
        tampilNamaShift()
        btnOnShift.Enabled = False
        btnOffShift.Enabled = False
    End Sub

    Private Sub btnToOnSerialPorts_Click(sender As Object, e As EventArgs)
        '_serialPort.BaudRate = "9600"
        '_serialPort.PortName = "COM9"
        'btnToOnSerialPorts.Visible = False
        'btnToOffSerialPorts.Visible = True
        'Timer1.Enabled = True
        'If _serialPort.IsOpen = False Then
        '    '_serialPort.Open()


        'End If
    End Sub

    Private Sub btnToOffSerialPorts_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnToOnSerialPorts_Click_1(sender As Object, e As EventArgs) Handles btnToOnSerialPorts.Click
        munculserial("Prolific PL2303GT USB Serial COM Port")

    End Sub

    Private Sub ddShift_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddShift.SelectedIndexChanged
        Dim namaShift As String = ""

        Dim query As String = "SELECT * FROM tb_shift WHERE status='on'"
        Try
            connect()
            Dim cmd As New MySqlCommand(query, Koneksi)
            DA = New MySqlDataAdapter(cmd)
            DT = New DataTable
            DA.Fill(DT)

            For i = 0 To DT.Rows.Count - 1
                namaShift = DT.Rows(i).Item("nama")
            Next

            If namaShift = ddShift.SelectedItem.ToString() Then
                btnOnShift.Enabled = False
                btnOffShift.Enabled = True
            Else
                If namaShift = "" Then
                    btnOnShift.Enabled = True
                    btnOffShift.Enabled = False
                Else
                    btnOnShift.Enabled = False
                    btnOffShift.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try
    End Sub

    Public Sub ubahStatusShift(status As String, dateNow As String, nama As String)
        If status = "on" Then
            Try
                connect()
                CMD = New MySqlCommand("UPDATE tb_shift SET status='on' WHERE nama='" & nama & "'", Koneksi)
                CMD.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally

                disconnect()
            End Try

            Try
                connect()
                CMD = New MySqlCommand("INSERT INTO tb_shift_history (nama, masuk) VALUES (@nama, @masuk)", Koneksi)
                ' Ganti @value1, @value2, @value3 dengan nama kolom yang sesuai
                CMD.Parameters.AddWithValue("@nama", nama)
                CMD.Parameters.AddWithValue("@masuk", dateNow)
                CMD.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally

                disconnect()
            End Try
        Else
            Try
                connect()
                CMD = New MySqlCommand("UPDATE tb_shift SET status='off' WHERE nama='" & nama & "'", Koneksi)
                CMD.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally

                disconnect()
            End Try

            Try
                Dim query As String = "UPDATE tb_shift_history " &
                      "SET keluar = @dateNow " &
                      "WHERE nama = @nama " &
                      "ORDER BY id DESC " &
                      "LIMIT 1;"

                connect()
                Dim CMD As New MySqlCommand(query, Koneksi)
                CMD.Parameters.AddWithValue("@dateNow", dateNow)
                CMD.Parameters.AddWithValue("@nama", nama)
                CMD.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally

                disconnect()
            End Try
        End If

        tampilNamaShift()
        btnOnShift.Enabled = False
        btnOffShift.Enabled = False
    End Sub

    Private Sub btnOnShift_Click(sender As Object, e As EventArgs) Handles btnOnShift.Click
        Dim now As DateTime = DateTime.Now
        Dim namaShift As String = ""

        ' Format the date and time as a string
        Dim formattedDateTime As String = now.ToString("yyyy-MM-dd HH:mm:ss")

        namaShift = ddShift.SelectedItem.ToString()


        ShowCustomMessageBox(namaShift, formattedDateTime)

    End Sub

    Private Sub btnOffShift_Click(sender As Object, e As EventArgs) Handles btnOffShift.Click
        Dim now As DateTime = DateTime.Now
        Dim namaShift As String = ""

        ' Format the date and time as a string
        Dim formattedDateTime As String = now.ToString("yyyy-MM-dd HH:mm:ss")

        namaShift = ddShift.SelectedItem.ToString()

        ubahStatusShift("off", formattedDateTime, namaShift)
    End Sub

    Private Sub ShowCustomMessageBox(namaShift As String, formattedDateTime As String)
        ' Buat Form Custom Message Box
        Dim customMessageBox As New Form With {
            .Width = 300,
            .Height = 200,
            .FormBorderStyle = FormBorderStyle.FixedDialog,
            .StartPosition = FormStartPosition.CenterScreen,
            .Text = "Input Password Shift",
            .MaximizeBox = False,
            .MinimizeBox = False
        }

        ' Label Password
        Dim lblPassword As New Label With {
            .Text = "Password:",
            .Location = New Point(10, 20),
            .Width = 80
        }
        customMessageBox.Controls.Add(lblPassword)

        ' Input Password
        Dim txtPassword As New TextBox With {
            .Location = New Point(100, 20),
            .Width = 150,
            .PasswordChar = "*"c ' Tampilkan input sebagai asteris
        }
        customMessageBox.Controls.Add(txtPassword)

        ' Tombol Login
        Dim btnLogin As New Button With {
            .Text = "Input",
            .Location = New Point(100, 100),
            .Width = 80
        }
        AddHandler btnLogin.Click, Sub(sender As Object, e As EventArgs)
                                       ' Verifikasi username dan password (opsional)
                                       Dim password = txtPassword.Text

                                       If password = "Password" OrElse password = "" Then
                                           MsgBox("Please enter your username and password.", MsgBoxStyle.Exclamation, "Warning")
                                           Return
                                       End If

                                       ' Validasi login
                                       If ValidateLogin(namaShift, password) Then
                                           MsgBox("Berhasil mengaktifkan shift, selamat bekerja!", MsgBoxStyle.Information, "Information")
                                           ubahStatusShift("on", formattedDateTime, namaShift)
                                           customMessageBox.Close()
                                       Else
                                           MsgBox("Username or password is incorrect", MsgBoxStyle.Critical, "Error")
                                       End If


                                   End Sub
        customMessageBox.Controls.Add(btnLogin)

        ' Tampilkan Custom Message Box
        customMessageBox.ShowDialog()
    End Sub

    Private Function ValidateLogin(namaShift As String, password As String) As Boolean
        Try
            connect() ' Gunakan fungsi connect() dari ModuleDB

            ' Query untuk memeriksa username dan password
            Dim query As String = "SELECT COUNT(*) FROM tb_shift WHERE nama = @nama AND pass = @password"
            CMD = New MySqlCommand(query, Koneksi)
            CMD.Parameters.AddWithValue("@nama", namaShift)
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