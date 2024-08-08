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
    Dim metodePembayaran As String


    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        changelongpaper()
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub

    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click

        FormBilling.Instance.UbahStatusTableCheckout()
        MessageBox.Show("Pembayaran berhasil, meja telah kosong kembali.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        pagesetup.PaperSize = New PaperSize("Custom", 250, longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub FormDetailTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Instance = Me
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f12 As New Font("Calibri", 12, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2

        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "__________________________________________________________________________________________________________________"


        e.Graphics.DrawString("XYZ BILLIARD", f14, Brushes.Black, centermargin, 10, center)
        e.Graphics.DrawString("Jl. Raya Kedung Baruk No. 1", f10, Brushes.Black, centermargin, 30, center)
        e.Graphics.DrawString("Surabaya", f10, Brushes.Black, centermargin, 45, center)
        e.Graphics.DrawString("Telp. 031-1234567", f10, Brushes.Black, centermargin, 60, center)
        e.Graphics.DrawString(line, f10, Brushes.Black, 0, 75)

        e.Graphics.DrawString(labelNoTable.Text & "                                             " & Date.Now.ToString("dd/MM/yyyy"), f10, Brushes.Black, 5, 100)
        e.Graphics.DrawString("No. Order : " & labelNoOrder.Text, f10, Brushes.Black, 5, 125)
        e.Graphics.DrawString("Nama Tamu : " & tbNamaTamu.Text, f10, Brushes.Black, 5, 140)
        e.Graphics.DrawString("Paket : " & labelPaket.Text, f10, Brushes.Black, 5, 155)
        e.Graphics.DrawString("No. Meja : " & labelNoTable.Text, f10, Brushes.Black, 5, 170)
        e.Graphics.DrawString("Waktu Mulai : " & labelWaktuMulai.Text, f10, Brushes.Black, 5, 185)
        e.Graphics.DrawString("Waktu Selesai : " & labelWaktuSelesai.Text, f10, Brushes.Black, 5, 200)
        e.Graphics.DrawString("Durasi : " & labelDuration.Text, f10, Brushes.Black, 5, 215)
        e.Graphics.DrawString(line, f10, Brushes.Black, 0, 230)

        e.Graphics.DrawString("Metode Pembayaran :" & metodePembayaran, f10, Brushes.Black, 5, 250)
        e.Graphics.DrawString("Subtotal : " & labelSubtotalTable.Text, f10, Brushes.Black, 5, 265)
        e.Graphics.DrawString("Diskon : " & labelDiskonTable.Text & "%", f10, Brushes.Black, 5, 280)
        e.Graphics.DrawString("Total : " & labelTotalTable.Text, f10, Brushes.Black, 5, 295)
        e.Graphics.DrawString("Tax Service : " & labelTaxService.Text, f10, Brushes.Black, 5, 310)
        e.Graphics.DrawString("PPn : " & labelPPn.Text, f10, Brushes.Black, 5, 325)
        e.Graphics.DrawString("Grand Total : " & tboxGrandTotal.Text, f10, Brushes.Black, 5, 340)
        e.Graphics.DrawString(line, f10, Brushes.Black, 0, 360)

    End Sub

    Public Sub ambilData(meja As String)

        Try
            connect()

            DA = New MySqlDataAdapter("SELECT * FROM tb_detailbilling WHERE no_meja = '" & meja & "'", Koneksi)
            DT = New DataTable
            DA.Fill(DT)

            For i = 0 To DT.Rows.Count - 1

                Dim subtotal As Integer = DT.Rows(i).Item(7)
                Dim total As Integer = subtotal - (subtotal * DT.Rows(i).Item(8))
                Dim taxservice As Integer = total * 0.05
                Dim ppn As Integer = total * 0.1
                grandTotal = total + taxservice + ppn


                labelTanggal.Text = Date.Now.ToString("dd MMM yyyy HH:mm:ss")
                labelNoOrder.Text = DT.Rows(i).Item(0)
                labelPaket.Text = DT.Rows(i).Item(2)
                labelNoTable.Text = DT.Rows(i).Item(3)
                labelWaktuMulai.Text = DT.Rows(i).Item(4)
                labelWaktuSelesai.Text = DT.Rows(i).Item(5)
                labelDuration.Text = DT.Rows(i).Item(6) & "Jam"
                labelSubtotalTable.Text = "Rp. " & subtotal
                labelDiskonTable.Text = DT.Rows(i).Item(8)
                labelTotalTable.Text = "Rp. " & total
                labelTaxService.Text = "Rp. " & taxservice
                labelPPn.Text = "Rp. " & ppn
                tboxGrandTotal.Text = "Rp. " & FormatNumber(grandTotal, 0, TriState.True, TriState.False, TriState.True)
                tbNamaTamu.Text = DT.Rows(i).Item(1)

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            disconnect()
        End Try

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
End Class