Imports System.Drawing.Printing
Imports System.Runtime.CompilerServices

Public Class FormDetailTable

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer


    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        changelongpaper()
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub

    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        FormBilling.Instance.UbahStatusTableCheckout()
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

        e.Graphics.DrawString("Tanggal : " & Date.Now.ToString("dd MMM yyyy HH:mm:ss"), f10, Brushes.Black, 5, 100)
        e.Graphics.DrawString("No. Order : " & labelNoOrder.Text, f10, Brushes.Black, 5, 115)

    End Sub
End Class