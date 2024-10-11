Imports System.Drawing.Printing
Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports MySql.Data.MySqlClient

Public Class FormPrintBillFNB

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer
    Dim grandTotal As Integer = 0
    Dim metodePembayaran As String
    Dim hargaMenu As Integer = 0

    Private Sub FormPrintBillFNB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        changelongpaper()
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub

    Sub changelongpaper()
        Dim rowcount1 As Integer
        longpaper = 0
        rowcount1 = FormFnB.DataGridView1.RowCount
        longpaper = rowcount1 * 15
        longpaper = longpaper + 500
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As EventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, longpaper)
        PD.DefaultPageSettings = pagesetup
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

        ' Print Header
        e.Graphics.DrawString("XYZ BILLIARD", f14, Brushes.Black, centermargin, 10, center)
        e.Graphics.DrawString("Jl. Raya Kedung Baruk No. 1", f10, Brushes.Black, centermargin, 30, center)
        e.Graphics.DrawString("Surabaya", f10, Brushes.Black, centermargin, 45, center)
        e.Graphics.DrawString("Telp. 031-1234567", f10, Brushes.Black, centermargin, 60, center)
        e.Graphics.DrawString(line, f10, Brushes.Black, 0, 75)

        ' Print Order Information
        e.Graphics.DrawString(FormFnB.tbNoOrder.Text & "                                          " & Date.Now.ToString("dd/MM/yyyy"), f10, Brushes.Black, 5, 100)
        e.Graphics.DrawString("Nama Tamu : " & FormFnB.tbNamaTamu.Text, f10, Brushes.Black, 5, 140)

        ' Print Column Headers
        e.Graphics.DrawString("Item", f10, Brushes.Black, 5, 180)
        e.Graphics.DrawString("Qty", f10, Brushes.Black, 150, 180)
        e.Graphics.DrawString("Price", f10, Brushes.Black, 200, 180)
        e.Graphics.DrawString(line, f10, Brushes.Black, 0, 200)

        ' Print DataGridView Rows (Column5, Column1, Column2, Column3, Column4)
        Dim yPos As Integer = 220
        For Each row As DataGridViewRow In FormFnB.DataGridView1.Rows
            If Not row.IsNewRow Then
                ' Retrieve values from specific columns
                Dim itemName As String = row.Cells("Column5").Value.ToString() ' Menu name (or any data in Column5)
                Dim qty As String = row.Cells("Column1").Value.ToString()     ' Quantity (or any data in Column1)
                Dim price As String = row.Cells("Column2").Value.ToString()   ' Price (or any data in Column2)
                Dim total As String = row.Cells("Column3").Value.ToString()   ' Total (or any data in Column3)
                Dim extraInfo As String = row.Cells("Column4").Value.ToString() ' Additional info (or any data in Column4)

                ' Print the row's data
                e.Graphics.DrawString(itemName, f10, Brushes.Black, 5, yPos)
                e.Graphics.DrawString(qty, f10, Brushes.Black, 150, yPos)
                e.Graphics.DrawString(price, f10, Brushes.Black, 200, yPos)

                ' Increment position for the next row
                yPos += 20
            End If
        Next

        ' Print Footer
        e.Graphics.DrawString(line, f10, Brushes.Black, 0, yPos)
        yPos += 15
        e.Graphics.DrawString("Metode Pembayaran :" & metodePembayaran, f10, Brushes.Black, 5, yPos)
        yPos += 15
        e.Graphics.DrawString("Subtotal : " & FormFnB.labSubtotal.Text, f10, Brushes.Black, 5, yPos)
        yPos += 15
        e.Graphics.DrawString("PPn : " & FormFnB.labPPN.Text & "%", f10, Brushes.Black, 5, yPos)
        yPos += 15
        e.Graphics.DrawString("Total : " & FormFnB.labTotal.Text, f10, Brushes.Black, 5, yPos)
        yPos += 15
        e.Graphics.DrawString(line, f10, Brushes.Black, 0, yPos)

    End Sub
End Class
