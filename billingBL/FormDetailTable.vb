Imports System.Drawing.Printing
Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports MySql.Data.MySqlClient

Public Class FormDetailTable

    Public Shared Instance As FormDetailTable
    Private Form As FormBilling

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer
    Dim grandTotal As Integer = 0
    Dim metodePembayaran As String = ""
    Dim hargaSiang As Integer = 0
    Dim hargaMalam As Integer = 0
    Dim durasiSiang As Integer = 0
    Dim durasiMalam As Integer = 0
    Dim currentMeja As String


    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        changelongpaper()
        PD.Print()
    End Sub

    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        If Not (rbtnCash.Checked Or rbtnDebit.Checked Or rbtnQRIS.Checked Or rbtnTransfer.Checked) Then
            MessageBox.Show("Metode Pembayaran Harus Diisi", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            FormBilling.Instance.UbahStatusTableCheckout(currentMeja, metodePembayaran)
            MessageBox.Show("Pembayaran berhasil, meja telah kosong kembali.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Sub changelongpaper()
        Dim rowcount1 As Integer
        Dim rowcount2 As Integer
        longpaper = 0
        rowcount1 = TableLayoutPanel1.RowCount
        rowcount2 = TableLayoutPanel2.RowCount
        longpaper = (rowcount1 + rowcount2) * 15
        longpaper = longpaper + 500
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As EventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 57 * 3.77953, longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub FormDetailTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Instance = Me
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Calibri", 6, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f12 As New Font("Calibri", 12, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim paperwidth As Integer = 57 * 3.77953

        Dim adjustment As Single = 12 ' Kurangi nilai untuk menghilangkan kelebihan margin
        Dim centerX As Single = (paperwidth / 2) - adjustment

        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "__________________________________________________________________________________________________________________"


        e.Graphics.DrawString("TRIPLE F", f14, Brushes.Black, centerX, 10, center)
        e.Graphics.DrawString("POOL N COFFEE", f14, Brushes.Black, centerX, 30, center)
        e.Graphics.DrawString("Jl. Terusan Danau Kerinci Jl. Sawojajar II No.1E-23", f8, Brushes.Black, centerX, 60, center)
        e.Graphics.DrawString("Kec. Pakis, Kabupaten Malang, Jawa Timur", f8, Brushes.Black, centerX, 70, center)
        e.Graphics.DrawString("65154", f8, Brushes.Black, centerX, 80, center)
        e.Graphics.DrawString(line, f10, Brushes.Black, 0, 90)

        e.Graphics.DrawString(labelJenisPaket.Text & "                                     " & Date.Now.ToString("dd/MM/yyyy"), f10, Brushes.Black, 5, 115)
        e.Graphics.DrawString("No. Order : " & labelNoOrder.Text, f10, Brushes.Black, 5, 150)
        e.Graphics.DrawString("Nama Tamu : " & tbNamaTamu.Text, f10, Brushes.Black, 5, 165)
        e.Graphics.DrawString("Paket : " & labelPaket.Text, f10, Brushes.Black, 5, 180)
        e.Graphics.DrawString("No. Meja : " & labelNoTable.Text, f10, Brushes.Black, 5, 195)
        e.Graphics.DrawString("Waktu Mulai : " & labelWaktuMulai.Text, f10, Brushes.Black, 5, 210)
        e.Graphics.DrawString("Waktu Selesai : " & labelWaktuSelesai.Text, f10, Brushes.Black, 5, 225)
        e.Graphics.DrawString("Durasi : " & durasiSiang + durasiMalam & " menit", f10, Brushes.Black, 5, 240)
        If labelJenisPaket.Text <> "DURASI" AndAlso labelJenisPaket.Text <> "LOSTIME" Then
            e.Graphics.DrawString("TABLE CHARGES STANDART", f10, Brushes.Black, 5, 260)
            e.Graphics.DrawString("0 menit X Rp. " & Format(0, "0.00"), f10, Brushes.Black, 5, 275)
            e.Graphics.DrawString("                                                     " & Format(0, "0"), f10, Brushes.Black, 7, 275)
            e.Graphics.DrawString("0 menit X Rp. " & Format(0, "0.00"), f10, Brushes.Black, 5, 290)
            e.Graphics.DrawString("                                                     " & Format(0, "0"), f10, Brushes.Black, 7, 290)
        Else
            e.Graphics.DrawString("TABLE CHARGES STANDART", f10, Brushes.Black, 5, 260)
            e.Graphics.DrawString(durasiSiang & " menit X Rp. " & Format(hargaSiang / 60, "0.00"), f10, Brushes.Black, 5, 275)
            e.Graphics.DrawString("                                                     " & Format((hargaSiang / 60) * durasiSiang, "0"), f10, Brushes.Black, 5, 275)
            e.Graphics.DrawString(durasiMalam & " menit X Rp. " & Format(hargaMalam / 60, "0.00"), f10, Brushes.Black, 5, 290)
            e.Graphics.DrawString("                                                     " & Format((hargaMalam / 60) * durasiMalam, "0"), f10, Brushes.Black, 5, 290)
        End If

        e.Graphics.DrawString(line, f10, Brushes.Black, 0, 310)

        e.Graphics.DrawString("Metode Pembayaran :" & metodePembayaran, f10, Brushes.Black, 5, 325)
        e.Graphics.DrawString("Subtotal : " & labelSubtotalTable.Text, f10, Brushes.Black, 5, 340)
        e.Graphics.DrawString("Diskon : " & labelDiskonTable.Text & "%", f10, Brushes.Black, 5, 355)
        e.Graphics.DrawString("Total : " & labelTotalTable.Text, f10, Brushes.Black, 5, 370)
        e.Graphics.DrawString("Tax Service : " & labelTaxService.Text, f10, Brushes.Black, 5, 385)
        e.Graphics.DrawString("PPn : " & labelPPn.Text, f10, Brushes.Black, 5, 400)
        e.Graphics.DrawString("Grand Total : " & tboxGrandTotal.Text, f10, Brushes.Black, 5, 415)
        e.Graphics.DrawString(line, f10, Brushes.Black, 0, 435)

    End Sub

    Public Sub ambilData(meja As String)

        Try
            connect()

            DA = New MySqlDataAdapter("SELECT * FROM tb_detailbilling WHERE no_meja = '" & meja & "'", Koneksi)
            DT = New DataTable
            DA.Fill(DT)

            For i = 0 To DT.Rows.Count - 1
                currentMeja = meja
                Dim subtotal As Integer = DT.Rows(i).Item(7)
                Dim total As Integer = subtotal - (subtotal * (DT.Rows(i).Item(8) / 100))
                Dim taxservice As Integer = total * 0.05
                Dim ppn As Integer = total * 0.1
                grandTotal = total + taxservice + ppn


                labelTanggal.Text = Date.Now.ToString("dd MMM yyyy HH:mm:ss")
                labelNoOrder.Text = DT.Rows(i).Item(0)
                labelPaket.Text = DT.Rows(i).Item(2)
                labelJenisPaket.Text = DT.Rows(i).Item(14)
                labelWaktuMulai.Text = DT.Rows(i).Item(4)
                labelWaktuSelesai.Text = DT.Rows(i).Item(5)
                labelNoTable.Text = DT.Rows(i).Item(3)
                labelSubtotalTable.Text = "Rp. " & subtotal
                labelDiskonTable.Text = DT.Rows(i).Item(8)
                labelTotalTable.Text = "Rp. " & total
                labelTaxService.Text = "Rp. " & taxservice
                labelPPn.Text = "Rp. " & ppn
                tboxGrandTotal.Text = "Rp. " & FormatNumber(grandTotal, 0, TriState.True, TriState.False, TriState.True)
                tbNamaTamu.Text = DT.Rows(i).Item(1)
                durasiSiang = DT.Rows(i).Item(9)
                durasiMalam = DT.Rows(i).Item(10)
                hargaSiang = DT.Rows(i).Item(11)
                hargaMalam = DT.Rows(i).Item(12)
                labelDuration.Text = durasiSiang + durasiMalam & " Menit"
            Next

            DA = New MySqlDataAdapter("SELECT * FROM tb_meja WHERE nama_meja = '" & meja & "'", Koneksi)
            DT = New DataTable
            DA.Fill(DT)

            For i = 0 To DT.Rows.Count - 1
                If (DT.Rows(i).Item("status") = "isi") Then
                    disableButton()
                Else
                    enableButton()
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            disconnect()
        End Try

    End Sub

    Public Sub PindahMeja(mejaBaru As String, mejaLama As String)
        Try
            connect()

            ' Ambil data dari meja saat ini
            DA = New MySqlDataAdapter("SELECT * FROM tb_detailbilling WHERE no_meja = '" & mejaLama & "'", Koneksi)
            DT = New DataTable
            DA.Fill(DT)

            ' Hapus data dari meja saat ini setelah dipindahkan
            Dim deleteCmd As New MySqlCommand("DELETE FROM tb_detailbilling WHERE no_meja = @no_meja", Koneksi)
            deleteCmd.Parameters.AddWithValue("@no_meja", mejaLama)
            deleteCmd.ExecuteNonQuery()

            ' Masukkan data ke meja baru
            For Each row As DataRow In DT.Rows
                Dim cmd As New MySqlCommand("INSERT INTO tb_detailbilling (no_order, no_meja, nama_tamu, paket, mulai, selesai, durasi, harga, disc_table, durasi_siang, durasi_malam, harga_siang, harga_malam, status_bayar, jenis_paket) VALUES (@no_order, @no_meja, @nama_tamu, @paket, @waktu_mulai, @waktu_selesai, @duration, @subtotal, @disc_table, @durasi_siang, @durasi_malam, @harga_siang, @harga_malam, @status_bayar, @jenis_paket)", Koneksi)

                cmd.Parameters.AddWithValue("@no_order", row("no_order"))
                cmd.Parameters.AddWithValue("@no_meja", mejaBaru)
                cmd.Parameters.AddWithValue("@nama_tamu", row("nama_tamu"))
                cmd.Parameters.AddWithValue("@paket", row("paket"))
                cmd.Parameters.AddWithValue("@waktu_mulai", row("mulai"))
                cmd.Parameters.AddWithValue("@waktu_selesai", row("selesai"))
                cmd.Parameters.AddWithValue("@duration", row("durasi"))
                cmd.Parameters.AddWithValue("@subtotal", row("harga"))
                cmd.Parameters.AddWithValue("@disc_table", row("disc_table"))
                cmd.Parameters.AddWithValue("@durasi_siang", row("durasi_siang"))
                cmd.Parameters.AddWithValue("@durasi_malam", row("durasi_malam"))
                cmd.Parameters.AddWithValue("@harga_siang", row("harga_siang"))
                cmd.Parameters.AddWithValue("@harga_malam", row("harga_malam"))
                cmd.Parameters.AddWithValue("@status_bayar", row("status_bayar"))
                cmd.Parameters.AddWithValue("@jenis_paket", row("jenis_paket"))

                cmd.ExecuteNonQuery()
            Next


            Dim updateStatusMejaKosongCmd As New MySqlCommand("UPDATE tb_meja SET status='kosong' WHERE nama_meja= @no_meja", Koneksi)
            updateStatusMejaKosongCmd.Parameters.AddWithValue("@no_meja", mejaLama)
            updateStatusMejaKosongCmd.ExecuteNonQuery()

            Dim updateStatusMejaIsiCmd As New MySqlCommand("UPDATE tb_meja SET status='isi' WHERE nama_meja= @no_meja", Koneksi)
            updateStatusMejaIsiCmd.Parameters.AddWithValue("@no_meja", mejaBaru)
            updateStatusMejaIsiCmd.ExecuteNonQuery()

            MessageBox.Show("Data berhasil dipindahkan ke " & mejaBaru, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            disconnect()
        End Try
    End Sub


    Public Sub ubahTombolBayardanCetak()

    End Sub


    Private Sub HitungKembalian()
        Dim uangKembalian As Integer
        Dim uangDiterima As Integer = FormatNumber(uangDiterima, 0, TriState.True, TriState.False, TriState.True)


        If Integer.TryParse(tbUangDiterima.Text, uangDiterima) Then

            If uangDiterima >= grandTotal Then
                uangKembalian = uangDiterima - grandTotal
                tbUangKembalian.Text = FormatNumber(uangKembalian, 0, TriState.True, TriState.False, TriState.True)
            Else
                tbUangKembalian.Text = "Uang Kurang"
            End If
        Else
            tbUangKembalian.Text = "Input Tidak Valid"
        End If
    End Sub

    Private Sub tbUangDiterima_TextChanged(sender As Object, e As EventArgs) Handles tbUangDiterima.TextChanged

        If tbUangDiterima.Text = "" Then
            tbUangKembalian.Text = "0"
        Else
            tbUangDiterima.Text = tbUangDiterima.Text
        End If
        HitungKembalian()
    End Sub

    Private Function FormatCurrency(ByVal nilai As Decimal) As String
        Return nilai.ToString("N0", CultureInfo.CreateSpecificCulture("id-ID"))
    End Function
    Private Sub rbtnQRIS_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnQRIS.CheckedChanged
        tbUangDiterima.Enabled = False
        tbUangDiterima.Text = grandTotal
        tbUangKembalian.Text = "0"
        metodePembayaran = "QRIS"


    End Sub

    Private Sub rbtnDebit_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnDebit.CheckedChanged
        tbUangDiterima.Enabled = False
        tbUangDiterima.Text = grandTotal
        tbUangKembalian.Text = "0"
        metodePembayaran = "Debit"
    End Sub

    Private Sub rbtnTransfer_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnTransfer.CheckedChanged
        tbUangDiterima.Enabled = False
        tbUangDiterima.Text = grandTotal
        tbUangKembalian.Text = "0"
        metodePembayaran = "Transfer"
    End Sub

    Private Sub rbtnCash_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnCash.CheckedChanged
        tbUangDiterima.Enabled = True
        tbUangKembalian.Text = "0"
        tbUangDiterima.Text = 0
        metodePembayaran = "Cash"
    End Sub

    Public Sub disableButton()
        btnBayar.Enabled = False
        btnCetak.Enabled = False
    End Sub

    Public Sub enableButton()
        btnBayar.Enabled = True
        btnCetak.Enabled = True
    End Sub
End Class