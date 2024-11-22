Imports System.Globalization
Imports System.IO.Ports
Imports MySql.Data.MySqlClient

Public Class FormBilling
    Dim portName As String = FormDashboard.correctPortName
    Dim _serialPort As SerialPort


    Public Shared Instance As FormBilling

    Dim durasi As Integer
    Dim waktuSelesai As TimeSpan
    Dim waktuMulai As TimeSpan
    Dim timeRemaining As TimeSpan

    Private Sub FormBilling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Instance = Me
        TimerSaatIni.Start()
        btnStopTable1.Enabled = False
        btnStopTable2.Enabled = False
        btnStopTable3.Enabled = False
        btnStopTable4.Enabled = False
        btnStopTable5.Enabled = False
        btnStopTable6.Enabled = False
        btnStopTable7.Enabled = False
        btnStopTable8.Enabled = False
        btnDetail1.Enabled = False
        btnDetail2.Enabled = False
        btnDetail3.Enabled = False
        btnDetail4.Enabled = False
        btnDetail5.Enabled = False
        btnDetail6.Enabled = False
        btnDetail7.Enabled = False
        btnDetail8.Enabled = False
        btnPindahMeja1.Enabled = False
        btnPindahMeja2.Enabled = False
        btnPindahMeja3.Enabled = False
        btnPindahMeja4.Enabled = False
        btnPindahMeja5.Enabled = False
        btnPindahMeja6.Enabled = False
        btnPindahMeja7.Enabled = False
        btnPindahMeja8.Enabled = False
        ubahStatusMeja()
        If _serialPort IsNot Nothing AndAlso _serialPort.IsOpen Then
            _serialPort.Close() ' Close the port if it's already open
        End If
    End Sub

    Private countDownTime1, countDownTime2, countDownTime3, countDownTime4, countDownTime5, countDownTime6, countDownTime7, countDownTime8 As TimeSpan
    Private jenisPaket1, jenisPaket2, jenisPaket3, jenisPaket4, jenisPaket5, jenisPaket6, jenisPaket7, jenisPaket8 As String
    Private namaPaket1, namaPaket2, namaPaket3, namaPaket4, namaPaket5, namaPaket6, namaPaket7, namaPaket8 As String

    '=======================================LOGIC DB=========================================================='
    Public Sub InitializeAndSendData(data As String)

        Try
            ' Initialize the SerialPort
            _serialPort = New SerialPort(portName)
            _serialPort.BaudRate = 9600
            _serialPort.DataBits = 8
            _serialPort.Parity = Parity.None
            _serialPort.StopBits = StopBits.One
            _serialPort.Handshake = Handshake.None



            ' Open the port
            _serialPort.Open()


            ' Send data if the port is open
            If _serialPort.IsOpen Then
                _serialPort.Write(data & vbCr)

            Else

            End If
        Catch ex As UnauthorizedAccessException
            MessageBox.Show("Access to COM9 is denied. Please ensure the port is not in use by another application.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the port is closed if it's open when the application exits
            If _serialPort IsNot Nothing AndAlso _serialPort.IsOpen Then
                _serialPort.Close()

            End If
        End Try
    End Sub

    Public Sub ubahStatusMeja()

        Try
            connect()

            DA = New MySqlDataAdapter("SELECT * FROM tb_detailbilling ", Koneksi)
            DT = New DataTable
            DA.Fill(DT)

            Console.WriteLine($"{DT}")

            For i = 0 To DT.Rows.Count - 1
                If DT.Rows(i).Item(3) = "Meja 1" AndAlso DT.Rows(i).Item(13) = "" OrElse DT.Rows(i).Item(3) = "Meja 1" AndAlso DT.Rows(i).Item(5) = "" Then

                    statusTable1.Text = "AKTIF"
                    statusTable1.BackColor = Color.Red
                    btnDetail1.Enabled = True
                    btnStopTable1.Enabled = True
                    btnPindahMeja1.Enabled = True
                    If DT.Rows(i).Item(14) = "LOSTIME" Then
                        jenisPaket1 = DT.Rows(i).Item(14)
                        namaPaket1 = DT.Rows(i).Item(2)
                        labTimeStart1.Text = DT.Rows(i).Item(4)
                        Dim waktuMulai As TimeSpan = TimeSpan.Parse(DT.Rows(i).Item(4))
                        countDownTime1 = waktuMulai
                    Else
                        namaPaket1 = ""
                        labTimeStart1.Text = DT.Rows(i).Item(4)
                        labTimeStop1.Text = DT.Rows(i).Item(5)
                        Dim waktuMulai As TimeSpan = TimeSpan.Parse(DT.Rows(i).Item(4))
                        Dim waktuSelesai As TimeSpan = TimeSpan.Parse(DT.Rows(i).Item(5))
                        If waktuSelesai < waktuMulai Then
                            Dim waktuTambah As New TimeSpan(24, 0, 0)
                            countDownTime1 = waktuSelesai.Add(waktuTambah)
                        Else
                            countDownTime1 = waktuSelesai
                        End If
                    End If

                    timerTable1.Start()


                ElseIf DT.Rows(i).Item(3) = "Meja 1" AndAlso DT.Rows(i).Item(13) = "checkout" Then
                    statusTable1.Text = "CHECKOUT"
                    statusTable1.BackColor = Color.LightGray
                    btnStopTable1.Enabled = False
                    btnDetail1.Enabled = True
                    btnPindahMeja1.Enabled = False
                    timerTable1.Stop()
                    If DT.Rows(i).Item(14) = "LOSTIME" Then
                        labTimeStart1.Text = DT.Rows(i).Item(4)
                    Else
                        labTimeStart1.Text = DT.Rows(i).Item(4)
                        labTimeStop1.Text = DT.Rows(i).Item(5)
                        duration1.Text = "00:00:00"
                        updateStatusBayar("Meja 1")
                    End If

                End If

                If DT.Rows(i).Item(3) = "Meja 2" AndAlso DT.Rows(i).Item(13) = "" OrElse DT.Rows(i).Item(3) = "Meja 2" AndAlso DT.Rows(i).Item(5) = "" Then
                    statusTable2.Text = "AKTIF"
                    statusTable2.BackColor = Color.Red
                    btnDetail2.Enabled = True
                    btnStopTable2.Enabled = True
                    btnPindahMeja2.Enabled = True
                    If DT.Rows(i).Item(14) = "LOSTIME" Then
                        jenisPaket2 = DT.Rows(i).Item(14)
                        namaPaket2 = DT.Rows(i).Item(2)
                        labTimeStart2.Text = DT.Rows(i).Item(4)
                        Dim waktuMulai As TimeSpan = TimeSpan.Parse(DT.Rows(i).Item(4))
                        countDownTime2 = waktuMulai
                    Else
                        namaPaket2 = ""
                        labTimeStart2.Text = DT.Rows(i).Item(4)
                        labTimeStop2.Text = DT.Rows(i).Item(5)
                        Dim waktuMulai As TimeSpan = TimeSpan.Parse(DT.Rows(i).Item(4))
                        Dim waktuSelesai As TimeSpan = TimeSpan.Parse(DT.Rows(i).Item(5))
                        If waktuSelesai < waktuMulai Then
                            Dim waktuTambah As New TimeSpan(24, 0, 0)
                            countDownTime2 = waktuSelesai.Add(waktuTambah)
                        Else
                            countDownTime2 = waktuSelesai
                        End If
                    End If

                    timerTable2.Start()


                ElseIf DT.Rows(i).Item(3) = "Meja 2" AndAlso DT.Rows(i).Item(13) = "checkout" Then
                    statusTable2.Text = "CHECKOUT"
                    statusTable2.BackColor = Color.LightGray
                    btnStopTable2.Enabled = False
                    btnDetail2.Enabled = True
                    btnPindahMeja2.Enabled = False
                    timerTable2.Stop()
                    If DT.Rows(i).Item(14) = "LOSTIME" Then
                        labTimeStart2.Text = DT.Rows(i).Item(4)
                    Else
                        labTimeStart2.Text = DT.Rows(i).Item(4)
                        labTimeStop2.Text = DT.Rows(i).Item(5)
                        duration2.Text = "00:00:00"
                        updateStatusBayar("Meja 2")
                    End If

                End If

                If DT.Rows(i).Item(3) = "Meja 3" AndAlso DT.Rows(i).Item(13) = "" OrElse DT.Rows(i).Item(3) = "Meja 3" AndAlso DT.Rows(i).Item(5) = "" Then
                    statusTable3.Text = "AKTIF"
                    statusTable3.BackColor = Color.Red
                    btnDetail3.Enabled = True
                    btnStopTable3.Enabled = True
                    btnPindahMeja3.Enabled = True
                    If DT.Rows(i).Item(14) = "LOSTIME" Then
                        jenisPaket3 = DT.Rows(i).Item(14)
                        namaPaket3 = DT.Rows(i).Item(2)
                        labTimeStart3.Text = DT.Rows(i).Item(4)
                        Dim waktuMulai As TimeSpan = TimeSpan.Parse(DT.Rows(i).Item(4))
                        countDownTime3 = waktuMulai
                    Else
                        namaPaket3 = ""
                        labTimeStart3.Text = DT.Rows(i).Item(4)
                        labTimeStop3.Text = DT.Rows(i).Item(5)
                        Dim waktuMulai As TimeSpan = TimeSpan.Parse(DT.Rows(i).Item(4))
                        Dim waktuSelesai As TimeSpan = TimeSpan.Parse(DT.Rows(i).Item(5))
                        If waktuSelesai < waktuMulai Then
                            Dim waktuTambah As New TimeSpan(24, 0, 0)
                            countDownTime3 = waktuSelesai.Add(waktuTambah)
                        Else
                            countDownTime3 = waktuSelesai
                        End If
                    End If

                    timerTable3.Start()


                ElseIf DT.Rows(i).Item(3) = "Meja 3" AndAlso DT.Rows(i).Item(13) = "checkout" Then
                    statusTable3.Text = "CHECKOUT"
                    statusTable3.BackColor = Color.LightGray
                    btnStopTable3.Enabled = False
                    btnDetail3.Enabled = True
                    btnPindahMeja3.Enabled = False
                    timerTable3.Stop()
                    If DT.Rows(i).Item(14) = "LOSTIME" Then
                        labTimeStart3.Text = DT.Rows(i).Item(4)
                    Else
                        labTimeStart3.Text = DT.Rows(i).Item(4)
                        labTimeStop3.Text = DT.Rows(i).Item(5)
                        duration3.Text = "00:00:00"
                        updateStatusBayar("Meja 3")
                    End If

                End If

                If DT.Rows(i).Item(3) = "Meja 4" AndAlso DT.Rows(i).Item(13) = "" OrElse DT.Rows(i).Item(3) = "Meja 4" AndAlso DT.Rows(i).Item(5) = "" Then
                    statusTable4.Text = "AKTIF"
                    statusTable4.BackColor = Color.Red
                    btnDetail4.Enabled = True
                    btnStopTable4.Enabled = True
                    btnPindahMeja4.Enabled = True
                    If DT.Rows(i).Item(14) = "LOSTIME" Then
                        jenisPaket4 = DT.Rows(i).Item(14)
                        namaPaket4 = DT.Rows(i).Item(2)
                        labTimeStart4.Text = DT.Rows(i).Item(4)
                        Dim waktuMulai As TimeSpan = TimeSpan.Parse(DT.Rows(i).Item(4))
                        countDownTime4 = waktuMulai
                    Else
                        namaPaket4 = ""
                        labTimeStart4.Text = DT.Rows(i).Item(4)
                        labTimeStop4.Text = DT.Rows(i).Item(5)
                        Dim waktuMulai As TimeSpan = TimeSpan.Parse(DT.Rows(i).Item(4))
                        Dim waktuSelesai As TimeSpan = TimeSpan.Parse(DT.Rows(i).Item(5))
                        If waktuSelesai < waktuMulai Then
                            Dim waktuTambah As New TimeSpan(24, 0, 0)
                            countDownTime4 = waktuSelesai.Add(waktuTambah)
                        Else
                            countDownTime4 = waktuSelesai
                        End If
                    End If

                    timerTable4.Start()

                ElseIf DT.Rows(i).Item(3) = "Meja 4" AndAlso DT.Rows(i).Item(13) = "checkout" Then
                    statusTable4.Text = "CHECKOUT"
                    statusTable4.BackColor = Color.LightGray
                    btnStopTable4.Enabled = False
                    btnDetail4.Enabled = True
                    btnPindahMeja4.Enabled = False
                    timerTable4.Stop()
                    If DT.Rows(i).Item(14) = "LOSTIME" Then
                        labTimeStart4.Text = DT.Rows(i).Item(4)
                    Else
                        labTimeStart4.Text = DT.Rows(i).Item(4)
                        labTimeStop4.Text = DT.Rows(i).Item(5)
                        duration4.Text = "00:00:00"
                        updateStatusBayar("Meja 4")
                    End If

                End If

                If DT.Rows(i).Item(3) = "Meja 5" AndAlso DT.Rows(i).Item(13) = "" OrElse DT.Rows(i).Item(3) = "Meja 5" AndAlso DT.Rows(i).Item(5) = "" Then
                    statusTable5.Text = "AKTIF"
                    statusTable5.BackColor = Color.Red
                    btnDetail5.Enabled = True
                    btnStopTable5.Enabled = True
                    btnPindahMeja5.Enabled = True
                    If DT.Rows(i).Item(14) = "LOSTIME" Then
                        jenisPaket5 = DT.Rows(i).Item(14)
                        namaPaket5 = DT.Rows(i).Item(2)
                        labTimeStart5.Text = DT.Rows(i).Item(4)
                        Dim waktuMulai As TimeSpan = TimeSpan.Parse(DT.Rows(i).Item(4))
                        countDownTime5 = waktuMulai
                    Else
                        namaPaket5 = ""
                        labTimeStart5.Text = DT.Rows(i).Item(4)
                        labTimeStop5.Text = DT.Rows(i).Item(5)
                        Dim waktuMulai As TimeSpan = TimeSpan.Parse(DT.Rows(i).Item(4))
                        Dim waktuSelesai As TimeSpan = TimeSpan.Parse(DT.Rows(i).Item(5))
                        If waktuSelesai < waktuMulai Then
                            Dim waktuTambah As New TimeSpan(24, 0, 0)
                            countDownTime5 = waktuSelesai.Add(waktuTambah)
                        Else
                            countDownTime5 = waktuSelesai
                        End If
                    End If

                    timerTable5.Start()

                ElseIf DT.Rows(i).Item(3) = "Meja 5" AndAlso DT.Rows(i).Item(13) = "checkout" Then
                    statusTable5.Text = "CHECKOUT"
                    statusTable5.BackColor = Color.LightGray
                    btnStopTable5.Enabled = False
                    btnDetail5.Enabled = True
                    btnPindahMeja5.Enabled = False
                    timerTable5.Stop()
                    If DT.Rows(i).Item(14) = "LOSTIME" Then
                        labTimeStart5.Text = DT.Rows(i).Item(4)
                    Else
                        labTimeStart5.Text = DT.Rows(i).Item(4)
                        labTimeStop5.Text = DT.Rows(i).Item(5)
                        duration5.Text = "00:00:00"
                        updateStatusBayar("Meja 5")
                    End If

                End If

                If DT.Rows(i).Item(3) = "Meja 6" AndAlso DT.Rows(i).Item(13) = "" OrElse DT.Rows(i).Item(3) = "Meja 6" AndAlso DT.Rows(i).Item(5) = "" Then
                    statusTable6.Text = "AKTIF"
                    statusTable6.BackColor = Color.Red
                    btnDetail6.Enabled = True
                    btnStopTable6.Enabled = True
                    btnPindahMeja6.Enabled = True
                    If DT.Rows(i).Item(14) = "LOSTIME" Then
                        jenisPaket6 = DT.Rows(i).Item(14)
                        namaPaket6 = DT.Rows(i).Item(2)
                        labTimeStart6.Text = DT.Rows(i).Item(4)
                        Dim waktuMulai As TimeSpan = TimeSpan.Parse(DT.Rows(i).Item(4))
                        countDownTime6 = waktuMulai
                    Else
                        namaPaket6 = ""
                        labTimeStart6.Text = DT.Rows(i).Item(4)
                        labTimeStop6.Text = DT.Rows(i).Item(5)
                        Dim waktuMulai As TimeSpan = TimeSpan.Parse(DT.Rows(i).Item(4))
                        Dim waktuSelesai As TimeSpan = TimeSpan.Parse(DT.Rows(i).Item(5))
                        If waktuSelesai < waktuMulai Then
                            Dim waktuTambah As New TimeSpan(24, 0, 0)
                            countDownTime6 = waktuSelesai.Add(waktuTambah)
                        Else
                            countDownTime6 = waktuSelesai
                        End If
                    End If

                    timerTable6.Start()


                ElseIf DT.Rows(i).Item(3) = "Meja 6" AndAlso DT.Rows(i).Item(13) = "checkout" Then
                    statusTable6.Text = "CHECKOUT"
                    statusTable6.BackColor = Color.LightGray
                    btnStopTable6.Enabled = False
                    btnDetail6.Enabled = True
                    btnPindahMeja6.Enabled = False
                    timerTable6.Stop()
                    If DT.Rows(i).Item(14) = "LOSTIME" Then
                        labTimeStart6.Text = DT.Rows(i).Item(4)
                    Else
                        labTimeStart6.Text = DT.Rows(i).Item(4)
                        labTimeStop6.Text = DT.Rows(i).Item(5)
                        duration6.Text = "00:00:00"
                        updateStatusBayar("Meja 6")
                    End If

                End If

                If DT.Rows(i).Item(3) = "Meja 7" AndAlso DT.Rows(i).Item(13) = "" OrElse DT.Rows(i).Item(3) = "Meja 7" AndAlso DT.Rows(i).Item(5) = "" Then
                    statusTable7.Text = "AKTIF"
                    statusTable7.BackColor = Color.Red
                    btnDetail7.Enabled = True
                    btnStopTable7.Enabled = True
                    btnPindahMeja7.Enabled = True
                    If DT.Rows(i).Item(14) = "LOSTIME" Then
                        jenisPaket7 = DT.Rows(i).Item(14)
                        namaPaket7 = DT.Rows(i).Item(2)
                        labTimeStart7.Text = DT.Rows(i).Item(4)
                        Dim waktuMulai As TimeSpan = TimeSpan.Parse(DT.Rows(i).Item(4))
                        countDownTime7 = waktuMulai
                    Else
                        namaPaket7 = ""
                        labTimeStart7.Text = DT.Rows(i).Item(4)
                        labTimeStop7.Text = DT.Rows(i).Item(5)
                        Dim waktuMulai As TimeSpan = TimeSpan.Parse(DT.Rows(i).Item(4))
                        Dim waktuSelesai As TimeSpan = TimeSpan.Parse(DT.Rows(i).Item(5))
                        If waktuSelesai < waktuMulai Then
                            Dim waktuTambah As New TimeSpan(24, 0, 0)
                            countDownTime7 = waktuSelesai.Add(waktuTambah)
                        Else
                            countDownTime7 = waktuSelesai
                        End If
                    End If

                    timerTable7.Start()


                ElseIf DT.Rows(i).Item(3) = "Meja 7" AndAlso DT.Rows(i).Item(13) = "checkout" Then
                    statusTable7.Text = "CHECKOUT"
                    statusTable7.BackColor = Color.LightGray
                    btnStopTable7.Enabled = False
                    btnDetail7.Enabled = True
                    btnPindahMeja7.Enabled = False
                    timerTable7.Stop()
                    If DT.Rows(i).Item(14) = "LOSTIME" Then
                        labTimeStart7.Text = DT.Rows(i).Item(4)
                    Else
                        labTimeStart7.Text = DT.Rows(i).Item(4)
                        labTimeStop7.Text = DT.Rows(i).Item(5)
                        duration7.Text = "00:00:00"
                        updateStatusBayar("Meja 7")
                    End If

                End If

                If DT.Rows(i).Item(3) = "Meja 8" AndAlso DT.Rows(i).Item(13) = "" OrElse DT.Rows(i).Item(3) = "Meja 8" AndAlso DT.Rows(i).Item(5) = "" Then
                    statusTable8.Text = "AKTIF"
                    statusTable8.BackColor = Color.Red
                    btnDetail8.Enabled = True
                    btnStopTable8.Enabled = True
                    btnPindahMeja8.Enabled = True
                    If DT.Rows(i).Item(14) = "LOSTIME" Then
                        jenisPaket8 = DT.Rows(i).Item(14)
                        namaPaket8 = DT.Rows(i).Item(2)
                        labTimeStart8.Text = DT.Rows(i).Item(4)
                        Dim waktuMulai As TimeSpan = TimeSpan.Parse(DT.Rows(i).Item(4))
                        countDownTime8 = waktuMulai
                    Else
                        namaPaket8 = ""
                        labTimeStart8.Text = DT.Rows(i).Item(4)
                        labTimeStop8.Text = DT.Rows(i).Item(5)
                        Dim waktuMulai As TimeSpan = TimeSpan.Parse(DT.Rows(i).Item(4))
                        Dim waktuSelesai As TimeSpan = TimeSpan.Parse(DT.Rows(i).Item(5))
                        If waktuSelesai < waktuMulai Then
                            Dim waktuTambah As New TimeSpan(24, 0, 0)
                            countDownTime8 = waktuSelesai.Add(waktuTambah)
                        Else
                            countDownTime8 = waktuSelesai
                        End If
                    End If

                    timerTable8.Start()

                ElseIf DT.Rows(i).Item(3) = "Meja 8" AndAlso DT.Rows(i).Item(13) = "checkout" Then
                    statusTable8.Text = "CHECKOUT"
                    statusTable8.BackColor = Color.LightGray
                    btnStopTable8.Enabled = False
                    btnDetail8.Enabled = True
                    btnPindahMeja8.Enabled = False
                    timerTable8.Stop()
                    If DT.Rows(i).Item(14) = "LOSTIME" Then
                        labTimeStart8.Text = DT.Rows(i).Item(4)
                    Else
                        labTimeStart8.Text = DT.Rows(i).Item(4)
                        labTimeStop8.Text = DT.Rows(i).Item(5)
                        duration8.Text = "00:00:00"
                        updateStatusBayar("Meja 8")
                    End If

                End If

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try
    End Sub

    Private Sub updateStopPaketLos(meja As String, waktuMulai As TimeSpan)
        Dim selesai As TimeSpan = Date.Now.TimeOfDay
        Dim selesaiString As String = selesai.ToString("hh\:mm\:ss")
        Dim mulai As TimeSpan = waktuMulai
        Dim totalWaktu As TimeSpan
        Dim totalWaktuInt As Integer = 0
        Dim selisihmulaiInt As Integer = 0
        Dim selisihselesaiInt As Integer = 0
        Dim hargaSiang As Integer = 0
        Dim hargaMalam As Integer = 0
        Dim akhirWaktuSiangString As String
        Dim akhirWaktuMalamString As String
        Dim akhirWaktuSiang As TimeSpan
        Dim akhirWaktuMalam As TimeSpan
        Dim harga As Integer = 0

        If selesai < mulai Then
            Dim selesaiNew As TimeSpan = selesai.Add(New TimeSpan(24, 0, 0))
            totalWaktu = selesaiNew - mulai
            totalWaktuInt = totalWaktu.TotalMinutes
        Else
            totalWaktu = selesai - mulai
            totalWaktuInt = totalWaktu.TotalMinutes
        End If

        Debug.WriteLine(totalWaktuInt)
        If totalWaktuInt < 60 Then
            totalWaktuInt = 60
        End If

        Try
            connect()

            DA = New MySqlDataAdapter("SELECT * FROM tb_daftarpaket WHERE jenis_paket='LOSTIME'", Koneksi)
            DT = New DataTable()
            DA.Fill(DT)

            For i = 0 To DT.Rows.Count - 1
                akhirWaktuSiangString = DT.Rows(i).Item("akhir_siang").ToString()
                akhirWaktuMalamString = DT.Rows(i).Item("akhir_malam").ToString()
                akhirWaktuSiang = TimeSpan.Parse(akhirWaktuSiangString)
                akhirWaktuMalam = TimeSpan.Parse(akhirWaktuMalamString)

                If mulai >= akhirWaktuMalam AndAlso mulai < akhirWaktuSiang Then
                    If selesai >= akhirWaktuSiang Then
                        Dim bataswaktu As New TimeSpan(akhirWaktuSiang.Hours, 0, 0)
                        Dim selisihmulai As TimeSpan = bataswaktu - mulai
                        selisihmulaiInt = selisihmulai.TotalMinutes
                        hargaSiang = Convert.ToInt32(DT.Rows(i).Item("harga_siang"))
                        Dim hargaSelisihMulai As Integer = (hargaSiang / 60) * selisihmulaiInt

                        Dim selisihselesai As TimeSpan = selesai - bataswaktu
                        selisihselesaiInt = selisihselesai.TotalMinutes
                        hargaMalam = Convert.ToInt32(DT.Rows(i).Item("harga_malam"))
                        Dim hargaSelisihSelesai As Integer = (hargaMalam / 60) * selisihselesaiInt

                        harga = hargaSelisihMulai + hargaSelisihSelesai
                    ElseIf selesai < akhirWaktuSiang Then
                        hargaSiang = Convert.ToInt32(DT.Rows(i).Item("harga_siang"))
                        harga = (hargaSiang * totalWaktuInt) / 60
                        selisihmulaiInt = totalWaktuInt
                    End If
                ElseIf mulai >= akhirWaktuSiang OrElse mulai < akhirWaktuMalam Then
                    If akhirWaktuMalam < selesai AndAlso selesai > akhirWaktuSiang Then
                        akhirWaktuMalam = akhirWaktuMalam.Add(New TimeSpan(24, 0, 0))
                    End If

                    If selesai <= akhirWaktuMalam Then
                        hargaMalam = Convert.ToInt32(DT.Rows(i).Item("harga_malam"))
                        harga = (hargaMalam * totalWaktuInt) / 60
                        selisihmulaiInt = totalWaktuInt
                    ElseIf selesai > akhirWaktuMalam Then
                        Dim bataswaktu As New TimeSpan(akhirWaktuMalam.Hours, 0, 0)

                        If bataswaktu < mulai Then
                            bataswaktu = bataswaktu.Add(New TimeSpan(24, 0, 0))
                        End If
                        Dim selisihmulai As TimeSpan = bataswaktu - mulai
                        selisihmulaiInt = selisihmulai.TotalMinutes
                        hargaMalam = Convert.ToInt32(DT.Rows(i).Item("harga_malam"))
                        Dim hargaSelisihMulai As Integer = (hargaMalam / 60) * selisihmulaiInt

                        If selesai < bataswaktu Then
                            selesai = selesai.Add(New TimeSpan(24, 0, 0))
                        End If
                        Dim selisihselesai As TimeSpan = selesai - bataswaktu
                        selisihselesaiInt = selisihselesai.TotalMinutes
                        hargaSiang = Convert.ToInt32(DT.Rows(i).Item("harga_siang"))
                        Dim hargaSelisihSelesai As Integer = (hargaSiang / 60) * selisihselesaiInt

                        harga = hargaSelisihMulai + hargaSelisihSelesai
                    End If

                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try
        If mulai >= akhirWaktuMalam AndAlso mulai < akhirWaktuSiang Then
            Try
                connect()

                CMD = New MySqlCommand("UPDATE tb_detailbilling SET selesai=@selesai, harga=@harga, durasi_siang=@durasi_siang, durasi_malam=@durasi_malam WHERE no_meja=@no_meja", Koneksi)
                CMD.Parameters.AddWithValue("@selesai", selesaiString)
                CMD.Parameters.AddWithValue("@harga", harga)
                CMD.Parameters.AddWithValue("@durasi_siang", selisihmulaiInt)
                CMD.Parameters.AddWithValue("@durasi_malam", selisihselesaiInt)
                CMD.Parameters.AddWithValue("@no_meja", meja)

                CMD.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                disconnect()
            End Try
        ElseIf mulai >= akhirWaktuSiang OrElse mulai < akhirWaktuMalam Then
            Try
                connect()

                CMD = New MySqlCommand("UPDATE tb_detailbilling SET selesai=@selesai, harga=@harga, durasi_siang=@durasi_siang, durasi_malam=@durasi_malam WHERE no_meja=@no_meja", Koneksi)
                CMD.Parameters.AddWithValue("@selesai", selesaiString)
                CMD.Parameters.AddWithValue("@harga", harga)
                CMD.Parameters.AddWithValue("@durasi_siang", selisihselesaiInt)
                CMD.Parameters.AddWithValue("@durasi_malam", selisihmulaiInt)
                CMD.Parameters.AddWithValue("@no_meja", meja)

                CMD.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                disconnect()
            End Try
        End If

    End Sub


    Sub updateStatusBayar(meja As String)
        Try
            connect()
            CMD = New MySqlCommand("UPDATE tb_detailbilling SET status_bayar='checkout' WHERE no_meja='" & meja & "'", Koneksi)
            CMD.ExecuteNonQuery()

            CMD = New MySqlCommand("UPDATE tb_meja SET status='checkout' WHERE nama_meja='" & meja & "'", Koneksi)
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try
    End Sub

    '=============================TIMER==============================================================='
    Public Sub timerTable1_Tick(sender As Object, e As EventArgs) Handles timerTable1.Tick
        If jenisPaket1 = "LOSTIME" Then
            Dim waktuSekarang As TimeSpan = Date.Now.TimeOfDay
            If waktuSekarang < countDownTime1 Then
                Dim waktuSekarangNew As TimeSpan = waktuSekarang.Add(New TimeSpan(24, 0, 0))
                timeRemaining = waktuSekarangNew - countDownTime1
            Else
                timeRemaining = Date.Now.TimeOfDay - countDownTime1
            End If
        Else
            timeRemaining = countDownTime1 - Date.Now.TimeOfDay


            If timeRemaining > New TimeSpan(1, 0, 0, 0) Then
                timeRemaining = timeRemaining.Subtract(New TimeSpan(1, 0, 0, 0))
            End If

            If timeRemaining.TotalSeconds < 1 OrElse countDownTime1 < Date.Now.TimeOfDay Then
                timeRemaining = TimeSpan.Zero
            End If

            If timeRemaining = TimeSpan.Zero Then
                timerTable1.Stop()
                InitializeAndSendData("10")
                statusTable1.Text = "CHECKOUT"
                statusTable1.BackColor = Color.LightGray
                btnStopTable1.Enabled = False
                btnPindahMeja1.Enabled = False
                updateStatusBayar("Meja 1")
            End If
        End If


        duration1.Text = timeRemaining.ToString("hh\:mm\:ss")
    End Sub

    Public Sub timerTable2_Tick(sender As Object, e As EventArgs) Handles timerTable2.Tick
        If jenisPaket2 = "LOSTIME" Then
            Dim waktuSekarang As TimeSpan = Date.Now.TimeOfDay
            If waktuSekarang < countDownTime2 Then
                Dim waktuSekarangNew As TimeSpan = waktuSekarang.Add(New TimeSpan(24, 0, 0))
                timeRemaining = waktuSekarangNew - countDownTime2
            Else
                timeRemaining = Date.Now.TimeOfDay - countDownTime2
            End If
        Else
            timeRemaining = countDownTime2 - Date.Now.TimeOfDay

            If timeRemaining > New TimeSpan(1, 0, 0, 0) Then
                timeRemaining = timeRemaining.Subtract(New TimeSpan(1, 0, 0, 0))
            End If

            If timeRemaining.TotalSeconds < 1 Then
                timeRemaining = TimeSpan.Zero
            End If

            If timeRemaining = TimeSpan.Zero Then
                timerTable2.Stop()
                InitializeAndSendData("20")
                statusTable2.Text = "CHECKOUT"
                statusTable2.BackColor = Color.LightGray
                btnStopTable2.Enabled = False
                btnPindahMeja2.Enabled = False
                updateStatusBayar("Meja 2")
            End If
        End If

        duration2.Text = timeRemaining.ToString("hh\:mm\:ss")
    End Sub

    Public Sub timerTable3_Tick(sender As Object, e As EventArgs) Handles timerTable3.Tick
        If jenisPaket3 = "LOSTIME" Then
            Dim waktuSekarang As TimeSpan = Date.Now.TimeOfDay
            If waktuSekarang < countDownTime3 Then
                Dim waktuSekarangNew As TimeSpan = waktuSekarang.Add(New TimeSpan(24, 0, 0))
                timeRemaining = waktuSekarangNew - countDownTime3
            Else
                timeRemaining = Date.Now.TimeOfDay - countDownTime3
            End If
        Else
            timeRemaining = countDownTime3 - Date.Now.TimeOfDay

            If timeRemaining > New TimeSpan(1, 0, 0, 0) Then
                timeRemaining = timeRemaining.Subtract(New TimeSpan(1, 0, 0, 0))
            End If

            If timeRemaining.TotalSeconds < 1 Then
                timeRemaining = TimeSpan.Zero
            End If

            If timeRemaining = TimeSpan.Zero Then
                timerTable3.Stop()
                InitializeAndSendData("30")
                statusTable3.Text = "CHECKOUT"
                statusTable3.BackColor = Color.LightGray
                btnStopTable3.Enabled = False
                btnPindahMeja3.Enabled = False
                updateStatusBayar("Meja 3")
            End If
        End If

        duration3.Text = timeRemaining.ToString("hh\:mm\:ss")
    End Sub

    Public Sub timerTable4_Tick(sender As Object, e As EventArgs) Handles timerTable4.Tick
        If jenisPaket4 = "LOSTIME" Then
            Dim waktuSekarang As TimeSpan = Date.Now.TimeOfDay
            If waktuSekarang < countDownTime4 Then
                Dim waktuSekarangNew As TimeSpan = waktuSekarang.Add(New TimeSpan(24, 0, 0))
                timeRemaining = waktuSekarangNew - countDownTime4
            Else
                timeRemaining = Date.Now.TimeOfDay - countDownTime4
            End If
        Else
            timeRemaining = countDownTime4 - Date.Now.TimeOfDay

            If timeRemaining > New TimeSpan(1, 0, 0, 0) Then
                timeRemaining = timeRemaining.Subtract(New TimeSpan(1, 0, 0, 0))
            End If

            If timeRemaining.TotalSeconds < 1 Then
                timeRemaining = TimeSpan.Zero
            End If

            If timeRemaining = TimeSpan.Zero Then
                timerTable4.Stop()
                InitializeAndSendData("40")
                statusTable4.Text = "CHECKOUT"
                statusTable4.BackColor = Color.LightGray
                btnStopTable4.Enabled = False
                btnPindahMeja4.Enabled = False
                updateStatusBayar("Meja 4")
            End If
        End If

        duration4.Text = timeRemaining.ToString("hh\:mm\:ss")
    End Sub

    Public Sub timerTable5_Tick(sender As Object, e As EventArgs) Handles timerTable5.Tick
        If jenisPaket5 = "LOSTIME" Then
            Dim waktuSekarang As TimeSpan = Date.Now.TimeOfDay
            If waktuSekarang < countDownTime5 Then
                Dim waktuSekarangNew As TimeSpan = waktuSekarang.Add(New TimeSpan(24, 0, 0))
                timeRemaining = waktuSekarangNew - countDownTime5
            Else
                timeRemaining = Date.Now.TimeOfDay - countDownTime5
            End If
        Else
            timeRemaining = countDownTime5 - Date.Now.TimeOfDay

            If timeRemaining > New TimeSpan(1, 0, 0, 0) Then
                timeRemaining = timeRemaining.Subtract(New TimeSpan(1, 0, 0, 0))
            End If

            If timeRemaining.TotalSeconds < 1 Then
                timeRemaining = TimeSpan.Zero
            End If

            If timeRemaining = TimeSpan.Zero Then
                timerTable5.Stop()
                InitializeAndSendData("50")
                statusTable5.Text = "CHECKOUT"
                statusTable5.BackColor = Color.LightGray
                btnStopTable5.Enabled = False
                btnPindahMeja5.Enabled = False
                updateStatusBayar("Meja 5")
            End If
        End If

        duration5.Text = timeRemaining.ToString("hh\:mm\:ss")
    End Sub

    Public Sub timerTable6_Tick(sender As Object, e As EventArgs) Handles timerTable6.Tick
        If jenisPaket6 = "LOSTIME" Then
            Dim waktuSekarang As TimeSpan = Date.Now.TimeOfDay
            If waktuSekarang < countDownTime6 Then
                Dim waktuSekarangNew As TimeSpan = waktuSekarang.Add(New TimeSpan(24, 0, 0))
                timeRemaining = waktuSekarangNew - countDownTime6
            Else
                timeRemaining = Date.Now.TimeOfDay - countDownTime6
            End If
        Else
            timeRemaining = countDownTime6 - Date.Now.TimeOfDay

            If timeRemaining > New TimeSpan(1, 0, 0, 0) Then
                timeRemaining = timeRemaining.Subtract(New TimeSpan(1, 0, 0, 0))
            End If

            If timeRemaining.TotalSeconds < 1 Then
                timeRemaining = TimeSpan.Zero
            End If

            If timeRemaining = TimeSpan.Zero Then
                timerTable6.Stop()
                InitializeAndSendData("60")
                statusTable6.Text = "CHECKOUT"
                statusTable6.BackColor = Color.LightGray
                btnStopTable6.Enabled = False
                btnPindahMeja6.Enabled = False
                updateStatusBayar("Meja 6")
            End If
        End If

        duration6.Text = timeRemaining.ToString("hh\:mm\:ss")
    End Sub

    Public Sub timerTable7_Tick(sender As Object, e As EventArgs) Handles timerTable7.Tick
        If jenisPaket7 = "LOSTIME" Then
            Dim waktuSekarang As TimeSpan = Date.Now.TimeOfDay
            If waktuSekarang < countDownTime7 Then
                Dim waktuSekarangNew As TimeSpan = waktuSekarang.Add(New TimeSpan(24, 0, 0))
                timeRemaining = waktuSekarangNew - countDownTime7
            Else
                timeRemaining = Date.Now.TimeOfDay - countDownTime7
            End If
        Else
            timeRemaining = countDownTime7 - Date.Now.TimeOfDay

            If timeRemaining > New TimeSpan(1, 0, 0, 0) Then
                timeRemaining = timeRemaining.Subtract(New TimeSpan(1, 0, 0, 0))
            End If

            If timeRemaining.TotalSeconds < 1 Then
                timeRemaining = TimeSpan.Zero
            End If

            If timeRemaining = TimeSpan.Zero Then
                timerTable7.Stop()
                InitializeAndSendData("70")
                statusTable7.Text = "CHECKOUT"
                statusTable7.BackColor = Color.LightGray
                btnStopTable7.Enabled = False
                btnPindahMeja7.Enabled = False
                updateStatusBayar("Meja 7")
            End If
        End If

        duration7.Text = timeRemaining.ToString("hh\:mm\:ss")
    End Sub

    Public Sub timerTable8_Tick(sender As Object, e As EventArgs) Handles timerTable8.Tick
        If jenisPaket8 = "LOSTIME" Then
            Dim waktuSekarang As TimeSpan = Date.Now.TimeOfDay
            If waktuSekarang < countDownTime8 Then
                Dim waktuSekarangNew As TimeSpan = waktuSekarang.Add(New TimeSpan(24, 0, 0))
                timeRemaining = waktuSekarangNew - countDownTime8
            Else
                timeRemaining = Date.Now.TimeOfDay - countDownTime8
            End If
        Else
            timeRemaining = countDownTime8 - Date.Now.TimeOfDay

            If timeRemaining > New TimeSpan(1, 0, 0, 0) Then
                timeRemaining = timeRemaining.Subtract(New TimeSpan(1, 0, 0, 0))
            End If

            If timeRemaining.TotalSeconds < 1 Then
                timeRemaining = TimeSpan.Zero
            End If

            If timeRemaining = TimeSpan.Zero Then
                timerTable8.Stop()
                InitializeAndSendData("80")
                statusTable8.Text = "CHECKOUT"
                statusTable8.BackColor = Color.LightGray
                btnStopTable8.Enabled = False
                btnPindahMeja8.Enabled = False
                updateStatusBayar("Meja 8")
            End If
        End If

        duration8.Text = timeRemaining.ToString("hh\:mm\:ss")
    End Sub




    '==========================================TF & DEL DATA UNTUK MENGOSONGKAN MEJA====================================================='
    Public Sub TransferAndDeleteData(meja As String, metodePembayaran As String)
        Dim tanggal_transaksi As String = Date.Now.ToString("yyyy-MM-dd")
        Try
            connect()

            ' Ambil data dari tb_detailbilling untuk meja yang diberikan
            DA = New MySqlDataAdapter("SELECT * FROM tb_detailbilling WHERE no_meja = '" & meja & "'", Koneksi)
            DT = New DataTable
            DA.Fill(DT)

            ' Pindahkan data ke tb_transaksi
            For Each row As DataRow In DT.Rows
                CMD = New MySqlCommand("INSERT INTO tb_transaksi (no_order, nama_tamu, paket,no_meja,mulai, selesai, durasi, harga, disc_table, metode_pembayaran, durasi_siang, durasi_malam, tanggal_transaksi) VALUES (@no_order, @nama_tamu, @paket,@no_meja, @mulai, @selesai, @durasi, @harga,@disc_table, @metode_pembayaran, @durasi_siang, @durasi_malam, @tanggal_transaksi)", Koneksi)
                ' Ganti @value1, @value2, @value3 dengan nama kolom yang sesuai
                CMD.Parameters.AddWithValue("@no_order", row("no_order"))
                CMD.Parameters.AddWithValue("@nama_tamu", row("nama_tamu"))
                CMD.Parameters.AddWithValue("@paket", row("paket"))
                CMD.Parameters.AddWithValue("@no_meja", row("no_meja"))
                CMD.Parameters.AddWithValue("@mulai", row("mulai"))
                CMD.Parameters.AddWithValue("@selesai", row("selesai"))
                CMD.Parameters.AddWithValue("@durasi", row("durasi"))
                CMD.Parameters.AddWithValue("@harga", row("harga"))
                CMD.Parameters.AddWithValue("@disc_table", row("disc_table"))
                CMD.Parameters.AddWithValue("@metode_pembayaran", metodePembayaran)
                CMD.Parameters.AddWithValue("@durasi_siang", row("durasi_siang"))
                CMD.Parameters.AddWithValue("@durasi_malam", row("durasi_malam"))
                CMD.Parameters.AddWithValue("@tanggal_transaksi", tanggal_transaksi)
                CMD.ExecuteNonQuery()
            Next

            ' Hapus data dari tb_detailbilling untuk meja yang diberikan
            CMD = New MySqlCommand("DELETE FROM tb_detailbilling WHERE no_meja = '" & meja & "'", Koneksi)
            CMD.ExecuteNonQuery()

            disconnect()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    '==========================================UBAH STATUS CHECKOUT UNTUK BUTTON BAYAR====================================================='
    Public Sub UbahStatusTableCheckout(meja As String, metodePembayaran As String)

        If meja = "Meja 1" Then
            ResetTable("Meja 1", labTimeStart1, labTimeStop1, timerTable1, statusTable1, duration1, btnDetail1, btnStopTable1, btnPindahMeja1, metodePembayaran)
        End If
        If meja = "Meja 2" Then
            ResetTable("Meja 2", labTimeStart2, labTimeStop2, timerTable2, statusTable2, duration2, btnDetail2, btnStopTable2, btnPindahMeja2, metodePembayaran)
        End If
        If meja = "Meja 3" Then
            ResetTable("Meja 3", labTimeStart3, labTimeStop3, timerTable3, statusTable3, duration3, btnDetail3, btnStopTable3, btnPindahMeja3, metodePembayaran)
        End If
        If meja = "Meja 4" Then
            ResetTable("Meja 4", labTimeStart4, labTimeStop4, timerTable4, statusTable4, duration4, btnDetail4, btnStopTable4, btnPindahMeja4, metodePembayaran)
        End If
        If meja = "Meja 5" Then
            ResetTable("Meja 5", labTimeStart5, labTimeStop5, timerTable5, statusTable5, duration5, btnDetail5, btnStopTable5, btnPindahMeja5, metodePembayaran)
        End If
        If meja = "Meja 6" Then
            ResetTable("Meja 6", labTimeStart6, labTimeStop6, timerTable6, statusTable6, duration6, btnDetail6, btnStopTable6, btnPindahMeja6, metodePembayaran)
        End If
        If meja = "Meja 7" Then
            ResetTable("Meja 7", labTimeStart7, labTimeStop7, timerTable7, statusTable7, duration7, btnDetail7, btnStopTable7, btnPindahMeja7, metodePembayaran)
        End If
        If meja = "Meja 8" Then
            ResetTable("Meja 8", labTimeStart8, labTimeStop8, timerTable8, statusTable8, duration8, btnDetail8, btnStopTable8, btnPindahMeja8, metodePembayaran)
        End If
    End Sub

    Private Sub ResetTable(meja As String, ByRef labTimeStart As Label, ByRef labTimeStop As Label, ByRef timer As Timer, ByRef statusLabel As Label, ByRef durationLabel As Label, ByRef btnDetail As Button, ByRef btnStopTable As Button, ByRef btnPindahMeja As Button, metodePembayaran As String)
        Try
            connect()
            CMD = New MySqlCommand("UPDATE tb_meja SET status='kosong' WHERE nama_meja='" & meja & "'", Koneksi)
            CMD.ExecuteNonQuery()
            disconnect()
            TransferAndDeleteData(meja, metodePembayaran)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        timer.Stop()

        labTimeStart.Text = "-;-;-"
        labTimeStop.Text = "-;-;-"
        statusLabel.Text = "KOSONG"
        statusLabel.BackColor = Color.Lime
        durationLabel.Text = "-;-;-"
        btnDetail.Enabled = False
        btnStopTable.Enabled = False
        btnPindahMeja.Enabled = False
    End Sub

    Private Sub TimerSaatIni_Tick(sender As Object, e As EventArgs) Handles TimerSaatIni.Tick
        LabelTimerSaatIni.Text = Date.Now.ToString("dd/MM/yyyy   HH:mm:ss")
    End Sub

    '==========================================Button OPEN====================================================='

    Private Sub btnOpenLos_Click(sender As Object, e As EventArgs) Handles btnOpenLos.Click
        FormOpenTableLos.Show()
    End Sub

    Private Sub btnOpenDurasi_Click(sender As Object, e As EventArgs) Handles btnOpenDurasi.Click
        FormOpenTableDurasi.Show()
    End Sub

    Private Sub btnOpenPaket_Click(sender As Object, e As EventArgs) Handles btnOpenPaket.Click
        FormOpenTablePaket.Show()
    End Sub

    '==========================================Button STOP====================================================='
    Private Sub btnStopTable1_Click(sender As Object, e As EventArgs) Handles btnStopTable1.Click
        If statusTable1.Text = "AKTIF" Then
            statusTable1.Text = "CHECKOUT"
            statusTable1.BackColor = Color.LightGray
            btnStopTable1.Enabled = False
            btnPindahMeja1.Enabled = False
            If jenisPaket1 = "LOSTIME" Then
                jenisPaket1 = ""
                updateStopPaketLos("Meja 1", countDownTime1)

            End If
            timerTable1.Stop()
            InitializeAndSendData("10")
            updateStatusBayar("Meja 1")
        End If


    End Sub

    Private Sub btnStopTable2_Click(sender As Object, e As EventArgs) Handles btnStopTable2.Click
        If statusTable2.Text = "AKTIF" Then
            statusTable2.Text = "CHECKOUT"
            statusTable2.BackColor = Color.LightGray
            btnStopTable2.Enabled = False
            btnPindahMeja2.Enabled = False
            If jenisPaket2 = "LOSTIME" Then
                jenisPaket2 = ""
                updateStopPaketLos("Meja 2", countDownTime2)
            End If
            timerTable2.Stop()
            InitializeAndSendData("20")
            updateStatusBayar("Meja 2")
        End If

    End Sub

    Private Sub btnStopTable3_Click(sender As Object, e As EventArgs) Handles btnStopTable3.Click
        If statusTable3.Text = "AKTIF" Then
            statusTable3.Text = "CHECKOUT"
            statusTable3.BackColor = Color.LightGray
            btnStopTable3.Enabled = False
            btnPindahMeja3.Enabled = False
            If jenisPaket3 = "LOSTIME" Then
                jenisPaket3 = ""
                updateStopPaketLos("Meja 3", countDownTime3)
            End If
            timerTable3.Stop()
            InitializeAndSendData("30")
            updateStatusBayar("Meja 3")
        End If

    End Sub

    Private Sub btnStopTable4_Click(sender As Object, e As EventArgs) Handles btnStopTable4.Click
        If statusTable4.Text = "AKTIF" Then
            statusTable4.Text = "CHECKOUT"
            statusTable4.BackColor = Color.LightGray
            btnStopTable4.Enabled = False
            btnPindahMeja4.Enabled = False
            If jenisPaket4 = "LOSTIME" Then
                jenisPaket4 = ""
                updateStopPaketLos("Meja 4", countDownTime4)
            End If
            timerTable4.Stop()
            InitializeAndSendData("40")
            updateStatusBayar("Meja 4")
        End If

    End Sub

    Private Sub btnStopTable5_Click(sender As Object, e As EventArgs) Handles btnStopTable5.Click
        If statusTable5.Text = "AKTIF" Then
            statusTable5.Text = "CHECKOUT"
            statusTable5.BackColor = Color.LightGray
            btnStopTable5.Enabled = False
            btnPindahMeja5.Enabled = False
            If jenisPaket5 = "LOSTIME" Then
                jenisPaket5 = ""
                updateStopPaketLos("Meja 5", countDownTime5)
            End If
            timerTable5.Stop()
            InitializeAndSendData("50")
            updateStatusBayar("Meja 5")
        End If

    End Sub

    Private Sub btnStopTable6_Click(sender As Object, e As EventArgs) Handles btnStopTable6.Click
        If statusTable6.Text = "AKTIF" Then
            statusTable6.Text = "CHECKOUT"
            statusTable6.BackColor = Color.LightGray
            btnStopTable6.Enabled = False
            btnPindahMeja6.Enabled = False
            If jenisPaket6 = "LOSTIME" Then
                jenisPaket6 = ""
                updateStopPaketLos("Meja 6", countDownTime6)
            End If
            timerTable6.Stop()
            InitializeAndSendData("60")
            updateStatusBayar("Meja 6")
        End If

    End Sub

    Private Sub btnStopTable7_Click(sender As Object, e As EventArgs) Handles btnStopTable7.Click
        If statusTable7.Text = "AKTIF" Then
            statusTable7.Text = "CHECKOUT"
            statusTable7.BackColor = Color.LightGray
            btnStopTable7.Enabled = False
            btnPindahMeja7.Enabled = False
            If jenisPaket7 = "LOSTIME" Then
                jenisPaket7 = ""
                updateStopPaketLos("Meja 7", countDownTime7)
            End If
            timerTable7.Stop()
            InitializeAndSendData("70")
            updateStatusBayar("Meja 7")
        End If

    End Sub

    Private Sub btnStopTable8_Click(sender As Object, e As EventArgs) Handles btnStopTable8.Click
        If statusTable8.Text = "AKTIF" Then
            statusTable8.Text = "CHECKOUT"
            statusTable8.BackColor = Color.LightGray
            btnStopTable8.Enabled = False
            btnPindahMeja8.Enabled = False
            If jenisPaket8 = "LOSTIME" Then
                jenisPaket8 = ""
                updateStopPaketLos("Meja 8", countDownTime8)
            End If
            timerTable8.Stop()
            InitializeAndSendData("80")
            updateStatusBayar("Meja 8")
        End If

    End Sub

    '==========================================Button DETAIL====================================================='
    Private Sub btnDetail1_Click(sender As Object, e As EventArgs) Handles btnDetail1.Click
        FormDetailTable.Show()
        FormDetailTable.Instance.ambilData("Meja 1")
    End Sub
    Private Sub btnDetail2_Click(sender As Object, e As EventArgs) Handles btnDetail2.Click
        FormDetailTable.Show()
        FormDetailTable.Instance.ambilData("Meja 2")
    End Sub

    Private Sub btnDetail3_Click(sender As Object, e As EventArgs) Handles btnDetail3.Click
        FormDetailTable.Show()
        FormDetailTable.Instance.ambilData("Meja 3")
    End Sub

    Private Sub btnDetail4_Click(sender As Object, e As EventArgs) Handles btnDetail4.Click
        FormDetailTable.Show()
        FormDetailTable.Instance.ambilData("Meja 4")
    End Sub

    Private Sub btnDetail5_Click(sender As Object, e As EventArgs) Handles btnDetail5.Click
        FormDetailTable.Show()
        FormDetailTable.Instance.ambilData("Meja 5")
    End Sub

    Private Sub btnDetail6_Click(sender As Object, e As EventArgs) Handles btnDetail6.Click
        FormDetailTable.Show()
        FormDetailTable.Instance.ambilData("Meja 6")
    End Sub

    Private Sub btnDetail7_Click(sender As Object, e As EventArgs) Handles btnDetail7.Click
        FormDetailTable.Show()
        FormDetailTable.Instance.ambilData("Meja 7")
    End Sub

    Private Sub btnDetail8_Click(sender As Object, e As EventArgs) Handles btnDetail8.Click
        FormDetailTable.Show()
        FormDetailTable.Instance.ambilData("Meja 8")
    End Sub

    Private Sub ShowCustomMessageBox(mejaLama As String, ByRef labTimeStart As Label, ByRef labTimeStop As Label, ByRef timer As Timer, ByRef statusLabel As Label, ByRef durationLabel As Label)
        ' Buat form secara dinamis
        Dim customDialog As New Form()
        customDialog.Text = "Pindah Meja"
        customDialog.FormBorderStyle = FormBorderStyle.FixedDialog
        customDialog.StartPosition = FormStartPosition.CenterScreen
        customDialog.ClientSize = New Size(250, 150)
        customDialog.MaximizeBox = False
        customDialog.MinimizeBox = False
        customDialog.ShowInTaskbar = False

        ' Label untuk deskripsi
        Dim label As New Label()
        label.Text = "Pindah Meja:"
        label.Location = New Point(10, 20)
        label.AutoSize = True
        customDialog.Controls.Add(label)

        ' ComboBox untuk pilihan meja
        Dim comboBox As New ComboBox()
        comboBox.DropDownStyle = ComboBoxStyle.DropDownList
        comboBox.Location = New Point(10, 50)
        comboBox.Width = 200

        Try
            connect()
            DA = New MySqlDataAdapter("SELECT * FROM tb_meja WHERE status='kosong'", Koneksi)
            DT = New DataTable
            DA.Fill(DT)
            For i = 0 To DT.Rows.Count - 1
                comboBox.Items.Add(DT.Rows(i).Item(1))
            Next
            comboBox.Text = DT.Rows(0).Item(1)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            disconnect()

        End Try



        comboBox.SelectedIndex = 0
        customDialog.Controls.Add(comboBox)

        ' Tombol OK
        Dim okButton As New Button()
        okButton.Text = "OK"
        okButton.DialogResult = DialogResult.OK
        okButton.Location = New Point(40, 100)
        customDialog.Controls.Add(okButton)

        ' Tombol Cancel
        Dim cancelButton As New Button()
        cancelButton.Text = "Cancel"
        cancelButton.DialogResult = DialogResult.Cancel
        cancelButton.Location = New Point(130, 100)
        customDialog.Controls.Add(cancelButton)

        ' Atur tombol OK sebagai default accept button dan Cancel sebagai cancel button
        customDialog.AcceptButton = okButton
        customDialog.CancelButton = cancelButton

        ' Tampilkan dialog dan proses hasilnya
        If customDialog.ShowDialog() = DialogResult.OK Then
            Dim selectedTable As String = comboBox.SelectedItem.ToString()
            MessageBox.Show("Meja telah dipindah ke: " & selectedTable)
            'KODE PINDAH DATA KE MEJA
            FormDetailTable.PindahMeja(mejaBaru:=selectedTable, mejaLama:=mejaLama)
            FormBilling_Load(Nothing, Nothing)
            timer.Stop()
            labTimeStart.Text = "-;-;-"
            labTimeStop.Text = "-;-;-"
            statusLabel.Text = "KOSONG"
            statusLabel.BackColor = Color.Lime
            durationLabel.Text = "-;-;-"
        Else
            MessageBox.Show("Pindah meja dibatalkan.")
        End If
    End Sub


    Private Sub btnPindahMeja1_Click(sender As Object, e As EventArgs) Handles btnPindahMeja1.Click
        ShowCustomMessageBox("Meja 1", labTimeStart1, labTimeStop1, timerTable1, statusTable1, duration1)
        InitializeAndSendData("10")
    End Sub

    Private Sub btnPindahMeja2_Click(sender As Object, e As EventArgs) Handles btnPindahMeja2.Click
        ShowCustomMessageBox("Meja 2", labTimeStart2, labTimeStop2, timerTable2, statusTable2, duration2)
        InitializeAndSendData("20")
    End Sub

    Private Sub btnPindahMeja3_Click(sender As Object, e As EventArgs) Handles btnPindahMeja3.Click
        ShowCustomMessageBox("Meja 3", labTimeStart3, labTimeStop3, timerTable3, statusTable3, duration3)
        InitializeAndSendData("30")
    End Sub

    Private Sub btnPindahMeja4_Click(sender As Object, e As EventArgs) Handles btnPindahMeja4.Click
        ShowCustomMessageBox("Meja 4", labTimeStart4, labTimeStop4, timerTable4, statusTable4, duration4)
        InitializeAndSendData("40")
    End Sub

    Private Sub btnPindahMeja5_Click(sender As Object, e As EventArgs) Handles btnPindahMeja5.Click
        ShowCustomMessageBox("Meja 5", labTimeStart5, labTimeStop5, timerTable5, statusTable5, duration5)
        InitializeAndSendData("50")
    End Sub

    Private Sub btnPindahMeja6_Click(sender As Object, e As EventArgs) Handles btnPindahMeja6.Click
        ShowCustomMessageBox("Meja 6", labTimeStart6, labTimeStop6, timerTable6, statusTable6, duration6)
        InitializeAndSendData("60")
    End Sub

    Private Sub btnPindahMeja7_Click(sender As Object, e As EventArgs) Handles btnPindahMeja7.Click
        ShowCustomMessageBox("Meja 7", labTimeStart7, labTimeStop7, timerTable7, statusTable7, duration7)
        InitializeAndSendData("70")
    End Sub

    Private Sub btnPindahMeja8_Click(sender As Object, e As EventArgs) Handles btnPindahMeja8.Click
        ShowCustomMessageBox("Meja 8", labTimeStart8, labTimeStop8, timerTable8, statusTable8, duration8)
        InitializeAndSendData("80")
    End Sub

End Class