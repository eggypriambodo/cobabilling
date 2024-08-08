Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class FormBilling

    Public Shared Instance As FormBilling

    Dim durasi As Integer
    Dim waktuSelesai As TimeSpan
    Dim waktuMulai As TimeSpan
    Dim timeRemaining As TimeSpan

    Private Sub FormBilling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Instance = Me
        TimerSaatIni.Enabled = True
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
        ubahStatusMeja()
        UbahStatusTableCheckout()
    End Sub

    Private countDownTime1, countDownTime2, countDownTime3, countDownTime4, countDownTime5, countDownTime6, countDownTime7, countDownTime8 As TimeSpan
    Private jenisPaket1, jenisPaket2, jenisPaket3, jenisPaket4, jenisPaket5, jenisPaket6, jenisPaket7, jenisPaket8 As String

    '=======================================LOGIC DB=========================================================='
    Public Sub ubahStatusMeja()
        Try
            connect()

            DA = New MySqlDataAdapter("SELECT * FROM tb_detailbilling ", Koneksi)
            DT = New DataTable
            DA.Fill(DT)

            For i = 0 To DT.Rows.Count - 1
                If DT.Rows(i).Item(3) = "Meja 1" Then

                    statusTable1.Text = "AKTIF"
                    statusTable1.BackColor = Color.Red
                    btnDetail1.Enabled = True
                    btnStopTable1.Enabled = True
                    If DT.Rows(i).Item(2) = "PAKET LOSTIME" Then
                        jenisPaket1 = "PAKET LOSTIME"
                        labTimeStart1.Text = DT.Rows(i).Item(4)
                        Dim waktuMulai As TimeSpan = TimeSpan.Parse(DT.Rows(i).Item(4))
                        countDownTime1 = waktuMulai
                    Else
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
                End If

                If DT.Rows(i).Item(3) = "Meja 2" Then
                    statusTable2.Text = "AKTIF"
                    statusTable2.BackColor = Color.Red
                    btnDetail2.Enabled = True
                    btnStopTable2.Enabled = True

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
                    timerTable2.Start()
                End If

                If DT.Rows(i).Item(3) = "Meja 3" Then
                    statusTable3.Text = "AKTIF"
                    statusTable3.BackColor = Color.Red
                    btnDetail3.Enabled = True
                    btnStopTable3.Enabled = True

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
                    timerTable3.Start()
                End If

                If DT.Rows(i).Item(3) = "Meja 4" Then
                    statusTable4.Text = "AKTIF"
                    statusTable4.BackColor = Color.Red
                    btnDetail4.Enabled = True
                    btnStopTable4.Enabled = True

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
                    timerTable4.Start()
                End If

                If DT.Rows(i).Item(3) = "Meja 5" Then
                    statusTable5.Text = "AKTIF"
                    statusTable5.BackColor = Color.Red
                    btnDetail5.Enabled = True
                    btnStopTable5.Enabled = True

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
                    timerTable5.Start()
                End If

                If DT.Rows(i).Item(3) = "Meja 6" Then
                    statusTable6.Text = "AKTIF"
                    statusTable6.BackColor = Color.Red
                    btnDetail6.Enabled = True
                    btnStopTable6.Enabled = True

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
                    timerTable6.Start()
                End If

                If DT.Rows(i).Item(3) = "Meja 7" Then
                    statusTable7.Text = "AKTIF"
                    statusTable7.BackColor = Color.Red
                    btnDetail7.Enabled = True
                    btnStopTable7.Enabled = True

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
                    timerTable7.Start()
                End If

                If DT.Rows(i).Item(3) = "Meja 8" Then
                    statusTable8.Text = "AKTIF"
                    statusTable8.BackColor = Color.Red
                    btnDetail8.Enabled = True
                    btnStopTable8.Enabled = True

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
                    timerTable8.Start()
                End If

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try
    End Sub

    Sub updateStopPaketLos(meja As String, waktuMulai As TimeSpan)
        Dim selesai As TimeSpan = Date.Now.TimeOfDay
        Dim selesaiString As String = selesai.ToString("hh\:mm\:ss")
        Dim mulai As TimeSpan = waktuMulai
        Dim totalWaktu As TimeSpan
        Dim totalWaktuInt As Integer = 0
        If selesai < mulai Then
            Dim waktuTambah As New TimeSpan(24, 0, 0)
            selesai = selesai.Add(waktuTambah)
            totalWaktu = selesai - mulai
            totalWaktuInt = totalWaktu.TotalMinutes
        Else
            totalWaktu = selesai - mulai
            totalWaktuInt = totalWaktu.TotalMinutes
        End If

        Dim harga As Integer = 0
        Try
            connect()

            DA = New MySqlDataAdapter("SELECT * FROM tb_daftarpaket WHERE jenis_paket='LOSTIME'", Koneksi)
            DT = New DataTable
            DA.Fill(DT)

            For i = 0 To DT.Rows.Count - 1
                If mulai.Hours >= 9 AndAlso mulai.Hours < 17 Then
                    If selesai.Hours >= 17 Then
                        Dim bataswaktu As New TimeSpan(17, 0, 0)
                        Dim selisihmulai As TimeSpan = bataswaktu - mulai
                        Dim selisihmulaiInt As Integer = selisihmulai.TotalMinutes
                        Dim hargaSiang As Integer = DT.Rows(i).Item(4)
                        Dim hargaSelisihMulai As Integer = (hargaSiang / 60) * selisihmulaiInt

                        Dim waktuselesai As TimeSpan = selesai
                        Dim selisihselesai As TimeSpan = waktuselesai - bataswaktu
                        Dim selisihselesaiInt As Integer = selisihselesai.TotalMinutes
                        Dim hargaMalam As Integer = DT.Rows(i).Item(5)
                        Dim hargaSelisihSelesai As Integer = (hargaMalam / 60) * selisihselesaiInt

                        harga = hargaSelisihMulai + hargaSelisihSelesai
                    ElseIf selesai.Hours < 17 Then
                        Dim hargaSiang As Integer = DT.Rows(i).Item(4) * totalWaktuInt
                        harga = hargaSiang / 60
                    End If
                ElseIf mulai.Hours >= 17 OrElse mulai.Hours < 9 Then
                    Dim hargaMalam As Integer = DT.Rows(i).Item(5) * totalWaktuInt
                    harga = hargaMalam / 60
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()

        End Try

        Try
            connect()
            CMD = New MySqlCommand("UPDATE tb_detailbilling SET selesai='" & selesaiString & "', harga='" & harga & "' WHERE no_meja='" & meja & "'", Koneksi)
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try
    End Sub

    '=============================TIMER==============================================================='
    Public Sub timerTable1_Tick(sender As Object, e As EventArgs) Handles timerTable1.Tick
        If jenisPaket1 = "PAKET LOSTIME" Then
            timeRemaining = Date.Now.TimeOfDay - countDownTime1
        Else
            timeRemaining = countDownTime1 - Date.Now.TimeOfDay

            If timeRemaining < TimeSpan.Zero Then
                timeRemaining = TimeSpan.Zero
            End If

            If timeRemaining = TimeSpan.Zero Then
                timerTable1.Stop()
                statusTable1.Text = "CHECKOUT"
                statusTable1.BackColor = Color.LightGray
                btnStopTable1.Enabled = False
            End If
        End If


        duration1.Text = timeRemaining.ToString("hh\:mm\:ss")
    End Sub

    Public Sub timerTable2_Tick(sender As Object, e As EventArgs) Handles timerTable2.Tick
        Dim timeRemaining = countDownTime2 - Date.Now.TimeOfDay

        If timeRemaining < TimeSpan.Zero Then
            timeRemaining = TimeSpan.Zero
        End If

        duration2.Text = timeRemaining.ToString("hh\:mm\:ss")

        If timeRemaining = TimeSpan.Zero Then
            timerTable2.Stop()
        End If
    End Sub

    Public Sub timerTable3_Tick(sender As Object, e As EventArgs) Handles timerTable3.Tick
        Dim timeRemaining = countDownTime3 - Date.Now.TimeOfDay

        If timeRemaining < TimeSpan.Zero Then
            timeRemaining = TimeSpan.Zero
        End If

        duration3.Text = timeRemaining.ToString("hh\:mm\:ss")

        If timeRemaining = TimeSpan.Zero Then
            timerTable3.Stop()
        End If
    End Sub

    Public Sub timerTable4_Tick(sender As Object, e As EventArgs) Handles timerTable4.Tick
        Dim timeRemaining = countDownTime4 - Date.Now.TimeOfDay

        If timeRemaining < TimeSpan.Zero Then
            timeRemaining = TimeSpan.Zero
        End If

        duration4.Text = timeRemaining.ToString("hh\:mm\:ss")

        If timeRemaining = TimeSpan.Zero Then
            timerTable4.Stop()
        End If
    End Sub

    Public Sub timerTable5_Tick(sender As Object, e As EventArgs) Handles timerTable5.Tick
        Dim timeRemaining = countDownTime5 - Date.Now.TimeOfDay

        If timeRemaining < TimeSpan.Zero Then
            timeRemaining = TimeSpan.Zero
        End If

        duration5.Text = timeRemaining.ToString("hh\:mm\:ss")

        If timeRemaining = TimeSpan.Zero Then
            timerTable5.Stop()
        End If
    End Sub

    Public Sub timerTable6_Tick(sender As Object, e As EventArgs) Handles timerTable6.Tick
        Dim timeRemaining = countDownTime6 - Date.Now.TimeOfDay

        If timeRemaining < TimeSpan.Zero Then
            timeRemaining = TimeSpan.Zero
        End If

        duration6.Text = timeRemaining.ToString("hh\:mm\:ss")

        If timeRemaining = TimeSpan.Zero Then
            timerTable6.Stop()
        End If
    End Sub

    Public Sub timerTable7_Tick(sender As Object, e As EventArgs) Handles timerTable7.Tick
        Dim timeRemaining = countDownTime7 - Date.Now.TimeOfDay

        If timeRemaining < TimeSpan.Zero Then
            timeRemaining = TimeSpan.Zero
        End If

        duration7.Text = timeRemaining.ToString("hh\:mm\:ss")

        If timeRemaining = TimeSpan.Zero Then
            timerTable7.Stop()
        End If
    End Sub

    Public Sub timerTable8_Tick(sender As Object, e As EventArgs) Handles timerTable8.Tick
        Dim timeRemaining = countDownTime8 - Date.Now.TimeOfDay

        If timeRemaining < TimeSpan.Zero Then
            timeRemaining = TimeSpan.Zero
        End If

        duration8.Text = timeRemaining.ToString("hh\:mm\:ss")

        If timeRemaining = TimeSpan.Zero Then
            timerTable8.Stop()
        End If
    End Sub


    '==========================================TF & DEL DATA UNTUK MENGOSONGKAN MEJA====================================================='
    Public Sub TransferAndDeleteData(meja As String)
        Try
            connect()

            ' Ambil data dari tb_detailbilling untuk meja yang diberikan
            DA = New MySqlDataAdapter("SELECT * FROM tb_detailbilling WHERE no_meja = '" & meja & "'", Koneksi)
            DT = New DataTable
            DA.Fill(DT)

            ' Pindahkan data ke tb_transaksi
            For Each row As DataRow In DT.Rows
                CMD = New MySqlCommand("INSERT INTO tb_transaksi (no_order, nama_tamu, paket,no_meja,mulai, selesai, durasi, harga, disc_table) VALUES (@no_order, @nama_tamu, @paket,@no_meja, @mulai, @selesai, @durasi, @harga,@disc_table)", Koneksi)
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
    Public Sub UbahStatusTableCheckout()
        If statusTable1.Text = "CHECKOUT" Then
            ResetTable("Meja 1", labTimeStart1, labTimeStop1, timerTable1, statusTable1, duration1, btnDetail1, btnStopTable1)
        End If
        If statusTable2.Text = "CHECKOUT" Then
            ResetTable("Meja 2", labTimeStart2, labTimeStop2, timerTable2, statusTable2, duration2, btnDetail2, btnStopTable2)
        End If
        If statusTable3.Text = "CHECKOUT" Then
            ResetTable("Meja 3", labTimeStart3, labTimeStop3, timerTable3, statusTable3, duration3, btnDetail3, btnStopTable3)
        End If
        If statusTable4.Text = "CHECKOUT" Then
            ResetTable("Meja 4", labTimeStart4, labTimeStop4, timerTable4, statusTable4, duration4, btnDetail4, btnStopTable4)
        End If
        If statusTable5.Text = "CHECKOUT" Then
            ResetTable("Meja 5", labTimeStart5, labTimeStop5, timerTable5, statusTable5, duration5, btnDetail5, btnStopTable5)
        End If
        If statusTable6.Text = "CHECKOUT" Then
            ResetTable("Meja 6", labTimeStart6, labTimeStop6, timerTable6, statusTable6, duration6, btnDetail6, btnStopTable6)
        End If
        If statusTable7.Text = "CHECKOUT" Then
            ResetTable("Meja 7", labTimeStart7, labTimeStop7, timerTable7, statusTable7, duration7, btnDetail7, btnStopTable7)
        End If
        If statusTable8.Text = "CHECKOUT" Then
            ResetTable("Meja 8", labTimeStart8, labTimeStop8, timerTable8, statusTable8, duration8, btnDetail8, btnStopTable8)
        End If
    End Sub

    Private Sub ResetTable(meja As String, ByRef labTimeStart As Label, ByRef labTimeStop As Label, ByRef timer As Timer, ByRef statusLabel As Label, ByRef durationLabel As Label, ByRef btnDetail As Button, ByRef btnStopTable As Button)
        Try
            connect()
            CMD = New MySqlCommand("UPDATE tb_meja SET status='kosong' WHERE nama_meja='" & meja & "'", Koneksi)
            CMD.ExecuteNonQuery()
            disconnect()
            TransferAndDeleteData(meja)
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
    End Sub

    Private Sub TimerSaatIni_Tick(sender As Object, e As EventArgs) Handles TimerSaatIni.Tick
        LabelTimerSaatIni.Text = Date.Now.ToString("dd MMM yyyy HH:mm:ss")
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
            If jenisPaket1 = "PAKET LOSTIME" Then
                jenisPaket1 = ""
                updateStopPaketLos("Meja 1", countDownTime1)
            Else
                timerTable1.Stop()
            End If
        End If

    End Sub

    Private Sub btnStopTable2_Click(sender As Object, e As EventArgs) Handles btnStopTable2.Click
        If statusTable2.Text = "AKTIF" Then
            statusTable2.Text = "CHECKOUT"
            statusTable2.BackColor = Color.LightGray
            If jenisPaket2 = "PAKET LOSTIME" Then
                jenisPaket2 = ""
                updateStopPaketLos("Meja 2", countDownTime1)
            Else
                timerTable2.Stop()
            End If
        End If

    End Sub

    Private Sub btnStopTable3_Click(sender As Object, e As EventArgs) Handles btnStopTable3.Click
        If statusTable3.Text = "AKTIF" Then
            statusTable3.Text = "CHECKOUT"
            statusTable3.BackColor = Color.LightGray
            If jenisPaket3 = "PAKET LOSTIME" Then
                jenisPaket3 = ""
                updateStopPaketLos("Meja 3", countDownTime1)
            Else
                timerTable3.Stop()
            End If
        End If

    End Sub

    Private Sub btnStopTable4_Click(sender As Object, e As EventArgs) Handles btnStopTable4.Click
        If statusTable4.Text = "AKTIF" Then
            statusTable4.Text = "CHECKOUT"
            statusTable4.BackColor = Color.LightGray
            If jenisPaket4 = "PAKET LOSTIME" Then
                jenisPaket4 = ""
                updateStopPaketLos("Meja 4", countDownTime1)
            Else
                timerTable4.Stop()
            End If
        End If

    End Sub

    Private Sub btnStopTable5_Click(sender As Object, e As EventArgs) Handles btnStopTable5.Click
        If statusTable5.Text = "AKTIF" Then
            statusTable5.Text = "CHECKOUT"
            statusTable5.BackColor = Color.LightGray
            If jenisPaket5 = "PAKET LOSTIME" Then
                jenisPaket5 = ""
                updateStopPaketLos("Meja 5", countDownTime1)
            Else
                timerTable5.Stop()
            End If
        End If

    End Sub

    Private Sub btnStopTable6_Click(sender As Object, e As EventArgs) Handles btnStopTable6.Click
        If statusTable6.Text = "AKTIF" Then
            statusTable6.Text = "CHECKOUT"
            statusTable6.BackColor = Color.LightGray
            If jenisPaket6 = "PAKET LOSTIME" Then
                jenisPaket6 = ""
                updateStopPaketLos("Meja 6", countDownTime1)
            Else
                timerTable6.Stop()
            End If
        End If

    End Sub

    Private Sub btnStopTable7_Click(sender As Object, e As EventArgs) Handles btnStopTable7.Click
        If statusTable7.Text = "AKTIF" Then
            statusTable7.Text = "CHECKOUT"
            statusTable7.BackColor = Color.LightGray
            If jenisPaket7 = "PAKET LOSTIME" Then
                jenisPaket7 = ""
                updateStopPaketLos("Meja 7", countDownTime1)
            Else
                timerTable7.Stop()
            End If
        End If

    End Sub

    Private Sub btnStopTable8_Click(sender As Object, e As EventArgs) Handles btnStopTable8.Click
        If statusTable8.Text = "AKTIF" Then
            statusTable8.Text = "CHECKOUT"
            statusTable8.BackColor = Color.LightGray
            If jenisPaket8 = "PAKET LOSTIME" Then
                jenisPaket8 = ""
                updateStopPaketLos("Meja 8", countDownTime1)
            Else
                timerTable8.Stop()
            End If
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





End Class