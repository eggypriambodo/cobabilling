Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class FormBilling

    Public Shared Instance As FormBilling

    Dim durasi As Integer
    Dim waktuSelesai As TimeSpan
    Dim waktuMulai As TimeSpan
    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub


    Private Sub FormBilling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Instance = Me
        TimerSaatIni.Enabled = True
        ubahStatusMeja()
    End Sub

    Private countDownTime1, countDownTime2, countDownTime3, countDownTime4, countDownTime5, countDownTime6, countDownTime7, countDownTime8 As TimeSpan

    Public Sub ubahStatusMeja()
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

                labTimeStart1.Text = DT.Rows(i).Item(4)
                labTimeStop1.Text = DT.Rows(i).Item(5)

                Dim waktuSelesai As TimeSpan = TimeSpan.Parse(DT.Rows(i).Item(5))
                countDownTime1 = waktuSelesai
                timerTable1.Start()
            End If

            If DT.Rows(i).Item(3) = "Meja 2" Then
                statusTable2.Text = "AKTIF"
                statusTable2.BackColor = Color.Red
                btnDetail2.Enabled = True
                btnStopTable2.Enabled = True

                labTimeStart2.Text = DT.Rows(i).Item(4)
                labTimeStop2.Text = DT.Rows(i).Item(5)

                Dim waktuSelesai As TimeSpan = TimeSpan.Parse(DT.Rows(i).Item(5))
                countDownTime2 = waktuSelesai
                timerTable2.Start()
            End If

            If DT.Rows(i).Item(3) = "Meja 3" Then
                statusTable3.Text = "AKTIF"
                statusTable3.BackColor = Color.Red
                btnDetail3.Enabled = True
                btnStopTable3.Enabled = True

                labTimeStart3.Text = DT.Rows(i).Item(4)
                labTimeStop3.Text = DT.Rows(i).Item(5)

                Dim waktuSelesai As TimeSpan = TimeSpan.Parse(DT.Rows(i).Item(5))
                countDownTime3 = waktuSelesai
                timerTable3.Start()
            End If

            If DT.Rows(i).Item(3) = "Meja 4" Then
                statusTable4.Text = "AKTIF"
                statusTable4.BackColor = Color.Red
                btnDetail4.Enabled = True
                btnStopTable4.Enabled = True

                labTimeStart4.Text = DT.Rows(i).Item(4)
                labTimeStop4.Text = DT.Rows(i).Item(5)

                Dim waktuSelesai As TimeSpan = TimeSpan.Parse(DT.Rows(i).Item(5))
                countDownTime4 = waktuSelesai
                timerTable4.Start()
            End If

            If DT.Rows(i).Item(3) = "Meja 5" Then
                statusTable5.Text = "AKTIF"
                statusTable5.BackColor = Color.Red
                btnDetail5.Enabled = True
                btnStopTable5.Enabled = True

                labTimeStart5.Text = DT.Rows(i).Item(4)
                labTimeStop5.Text = DT.Rows(i).Item(5)

                Dim waktuSelesai As TimeSpan = TimeSpan.Parse(DT.Rows(i).Item(5))
                countDownTime5 = waktuSelesai
                timerTable5.Start()
            End If

            If DT.Rows(i).Item(3) = "Meja 6" Then
                statusTable6.Text = "AKTIF"
                statusTable6.BackColor = Color.Red
                btnDetail6.Enabled = True
                btnStopTable6.Enabled = True

                labTimeStart6.Text = DT.Rows(i).Item(4)
                labTimeStop6.Text = DT.Rows(i).Item(5)

                Dim waktuSelesai As TimeSpan = TimeSpan.Parse(DT.Rows(i).Item(5))
                countDownTime6 = waktuSelesai
                timerTable6.Start()
            End If

            If DT.Rows(i).Item(3) = "Meja 7" Then
                statusTable7.Text = "AKTIF"
                statusTable7.BackColor = Color.Red
                btnDetail7.Enabled = True
                btnStopTable7.Enabled = True

                labTimeStart7.Text = DT.Rows(i).Item(4)
                labTimeStop7.Text = DT.Rows(i).Item(5)

                Dim waktuSelesai As TimeSpan = TimeSpan.Parse(DT.Rows(i).Item(5))
                countDownTime7 = waktuSelesai
                timerTable7.Start()
            End If

            If DT.Rows(i).Item(3) = "Meja 8" Then
                statusTable8.Text = "AKTIF"
                statusTable8.BackColor = Color.Red
                btnDetail8.Enabled = True
                btnStopTable8.Enabled = True

                labTimeStart8.Text = DT.Rows(i).Item(4)
                labTimeStop8.Text = DT.Rows(i).Item(5)

                Dim waktuSelesai As TimeSpan = TimeSpan.Parse(DT.Rows(i).Item(5))
                countDownTime8 = waktuSelesai
                timerTable8.Start()
            End If

        Next
        disconnect()
    End Sub

    Public Sub timerTable1_Tick(sender As Object, e As EventArgs) Handles timerTable1.Tick
        Dim timeRemaining = countDownTime1 - Date.Now.TimeOfDay

        If timeRemaining < TimeSpan.Zero Then
            timeRemaining = TimeSpan.Zero
        End If

        duration1.Text = timeRemaining.ToString("hh\:mm\:ss")

        If timeRemaining = TimeSpan.Zero Then
            timerTable1.Stop()
        End If
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



    Public Sub UbahStatusTableCheckout()
        If statusTable1.Text = "CHECKOUT" Then
            statusTable1.Text = "KOSONG"
            statusTable1.BackColor = Color.Lime
            btnDetail1.Enabled = False
            btnStopTable1.Enabled = False
        End If
    End Sub

    Private Sub TimerSaatIni_Tick(sender As Object, e As EventArgs) Handles TimerSaatIni.Tick
        LabelTimerSaatIni.Text = Date.Now.ToString("dd MMM yyyy HH:mm:ss")
    End Sub

    Private Sub btnDetail1_Click(sender As Object, e As EventArgs) Handles btnDetail1.Click
        FormDetailTable.Show()
        FormDetailTable.Instance.ambilData("Meja 1")
    End Sub

    Private Sub btnOpenLos_Click(sender As Object, e As EventArgs) Handles btnOpenLos.Click
        FormOpenTableLos.Show()
    End Sub

    Private Sub btnOpenDurasi_Click(sender As Object, e As EventArgs) Handles btnOpenDurasi.Click
        FormOpenTableDurasi.Show()
    End Sub

    Private Sub btnOpenPaket_Click(sender As Object, e As EventArgs) Handles btnOpenPaket.Click
        FormOpenTablePaket.Show()
    End Sub

    Private Sub btnStopTable1_Click(sender As Object, e As EventArgs) Handles btnStopTable1.Click
        If statusTable1.Text = "AKTIF" Then
            statusTable1.Text = "CHECKOUT"
            statusTable1.BackColor = Color.LightGray
            timerTable1.Stop()
        End If
    End Sub

    Private Sub btnStopTable2_Click(sender As Object, e As EventArgs) Handles btnStopTable2.Click
        If statusTable2.Text = "AKTIF" Then
            statusTable2.Text = "CHECKOUT"
            statusTable2.BackColor = Color.LightGray
            timerTable2.Stop()
        End If
    End Sub

    Private Sub btnStopTable3_Click(sender As Object, e As EventArgs) Handles btnStopTable3.Click
        If statusTable3.Text = "AKTIF" Then
            statusTable3.Text = "CHECKOUT"
            statusTable3.BackColor = Color.LightGray
            timerTable3.Stop()
        End If
    End Sub

    Private Sub btnStopTable4_Click(sender As Object, e As EventArgs) Handles btnStopTable4.Click
        If statusTable4.Text = "AKTIF" Then
            statusTable4.Text = "CHECKOUT"
            statusTable4.BackColor = Color.LightGray
            timerTable4.Stop()
        End If
    End Sub

    Private Sub btnStopTable5_Click(sender As Object, e As EventArgs) Handles btnStopTable5.Click
        If statusTable5.Text = "AKTIF" Then
            statusTable5.Text = "CHECKOUT"
            statusTable5.BackColor = Color.LightGray
            timerTable5.Stop()
        End If
    End Sub

    Private Sub btnStopTable6_Click(sender As Object, e As EventArgs) Handles btnStopTable6.Click
        If statusTable6.Text = "AKTIF" Then
            statusTable6.Text = "CHECKOUT"
            statusTable6.BackColor = Color.LightGray
            timerTable6.Stop()
        End If
    End Sub

    Private Sub btnStopTable7_Click(sender As Object, e As EventArgs) Handles btnStopTable7.Click
        If statusTable7.Text = "AKTIF" Then
            statusTable7.Text = "CHECKOUT"
            statusTable7.BackColor = Color.LightGray
            timerTable7.Stop()
        End If
    End Sub

    Private Sub btnStopTable8_Click(sender As Object, e As EventArgs) Handles btnStopTable8.Click
        If statusTable8.Text = "AKTIF" Then
            statusTable8.Text = "CHECKOUT"
            statusTable8.BackColor = Color.LightGray
            timerTable8.Stop()
        End If
    End Sub

End Class