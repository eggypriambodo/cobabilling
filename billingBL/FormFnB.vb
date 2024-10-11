﻿Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.IO
Imports Windows.Win32.UI.Input

Public Class FormFnB
    Private WithEvents pan As Panel
    Private WithEvents pan_top As Panel
    Private WithEvents nama_fnb As Label
    Private WithEvents harga_fnb As Label
    Private WithEvents image_fnb As CirclePicturBox

    Private Sub FormFnB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        labDate.Text = Date.Now.ToString("yyyy-MMMM-dd")
        getNoOrder()
        Load_Foods()
    End Sub

    Sub Load_Foods()
        FlowLayoutPanel1.Controls.Clear()
        FlowLayoutPanel1.AutoScroll = True
        Try
            conn.Open()
            CMD = New MySqlCommand("SELECT `image_fnb`, `nama_fnb`, `harga_fnb` FROM `tb_fnb`", conn)
            DR = CMD.ExecuteReader
            While DR.Read
                LoadControls()
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub getNoOrder()
        Dim random As New Random()

        Dim sekarang As DateTime = DateTime.Now
        Dim tanggal As String = sekarang.ToString("ddMMyyyyHHmmss")

        Dim noOrder As String = tanggal

        tbNoOrder.Text = noOrder
    End Sub

    Private Sub LoadControls()
        Dim len As Long = DR.GetBytes(0, 0, Nothing, 0, 0)
        Dim array(CInt(len)) As Byte
        DR.GetBytes(0, 0, array, 0, CInt(len))


        pan = New Panel
        With pan
            .Width = 150
            .Height = 180
            .BackColor = Color.FromArgb(30, 144, 255)
            .Tag = DR.Item("nama_fnb")
        End With

        pan_top = New Panel
        With pan_top
            .Width = 150
            .Height = 10
            .BackColor = Color.FromArgb(30, 144, 255)
            .Dock = DockStyle.Top
            .Tag = DR.Item("nama_fnb")
        End With

        image_fnb = New CirclePicturBox
        With image_fnb
            .Height = 115
            .BackgroundImageLayout = ImageLayout.Stretch
            .Dock = DockStyle.Top
            .Tag = DR.Item("nama_fnb")
        End With

        nama_fnb = New Label
        With nama_fnb
            .ForeColor = Color.White
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Top
            .Tag = DR.Item("nama_fnb").ToString
        End With

        harga_fnb = New Label
        With harga_fnb
            .ForeColor = Color.White
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Top
            .Tag = DR.Item("nama_fnb").ToString
        End With

        Dim ms As New System.IO.MemoryStream(array)
        Dim bitmap As New System.Drawing.Bitmap(ms)
        image_fnb.BackgroundImage = bitmap

        nama_fnb.Text = " Nama Menu  : " & DR.Item("nama_fnb").ToString
        harga_fnb.Text = " Harga              : Rp " & DR.Item("harga_fnb").ToString

        pan.Controls.Add(harga_fnb)
        pan.Controls.Add(nama_fnb)
        pan.Controls.Add(image_fnb)


        pan.Controls.Add(pan_top)
        FlowLayoutPanel1.Controls.Add(pan)

        AddHandler nama_fnb.Click, AddressOf Selectimg_Click
        AddHandler harga_fnb.Click, AddressOf Selectimg_Click
        AddHandler image_fnb.Click, AddressOf Selectimg_Click
        AddHandler pan.Click, AddressOf Selectimg_Click
    End Sub

    Public Sub Selectimg_Click(sender As Object, e As EventArgs)
        conn.Open()
        Try
            CMD = New MySqlCommand("SELECT `nama_fnb`, `harga_fnb` FROM `tb_fnb` WHERE `nama_fnb` like '" & sender.tag.ToString & "%' ", conn)
            DR = CMD.ExecuteReader
            While DR.Read
                Dim exist As Boolean = False, numrow As Integer = 0, numtext As Integer
                For Each itm As DataGridViewRow In DataGridView1.Rows
                    If itm.Cells(1).Value IsNot Nothing Then
                        If itm.Cells(1).Value.ToString = DR.Item("nama_fnb") Then
                            exist = True
                            numrow = itm.Index
                            numtext = CInt(itm.Cells(3).Value)
                            Exit For
                        End If
                    End If
                Next
                If exist = False Then
                    Dim price As Decimal = DR("harga_fnb")
                    Dim subtotalprice As Double
                    subtotalprice = price * 1
                    DataGridView1.Rows.Add(DataGridView1.Rows.Count, DR.Item("nama_fnb"), DR.Item("harga_fnb"), 1, subtotalprice)

                Else
                    DataGridView1.Rows(numrow).Cells(3).Value = CInt("1") + numtext
                    DataGridView1.Rows(numrow).Cells(4).Value = DataGridView1.Rows(numrow).Cells(2).Value * DataGridView1.Rows(numrow).Cells(3).Value
                End If

            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        DR.Dispose()
        conn.Close()

    End Sub

    Sub Load_Menus()
        FlowLayoutPanel1.Controls.Clear()
        FlowLayoutPanel1.AutoScroll = True
        Try
            conn.Open()
            CMD = New MySqlCommand("SELECT `image_fnb`, `nama_fnb`, `harga_fnb` FROM `tb_fnb`", conn)
            DR = CMD.ExecuteReader
            While DR.Read
                LoadControls()
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btnManageMenu_Click(sender As Object, e As EventArgs) Handles btnManageMenu.Click
        FormAddMenu.Show()
    End Sub

    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        FormPrintBillFNB.ShowDialog()
    End Sub

    '================================================PRINT BILL==========================================

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
        rowcount1 = DataGridView1.RowCount
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
        e.Graphics.DrawString(tbNoOrder.Text & "                                          " & Date.Now.ToString("dd/MM/yyyy"), f10, Brushes.Black, 5, 100)
        e.Graphics.DrawString("Nama Tamu : " & tbNamaTamu.Text, f10, Brushes.Black, 5, 140)

        ' Print Column Headers
        e.Graphics.DrawString("Item", f10, Brushes.Black, 5, 180)
        e.Graphics.DrawString("Qty", f10, Brushes.Black, 150, 180)
        e.Graphics.DrawString("Price", f10, Brushes.Black, 200, 180)
        e.Graphics.DrawString(line, f10, Brushes.Black, 0, 200)

        ' Print DataGridView Rows (Column5, Column1, Column2, Column3, Column4)
        Dim yPos As Integer = 220
        For Each row As DataGridViewRow In DataGridView1.Rows
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
        e.Graphics.DrawString("Subtotal : " & labSubtotal.Text, f10, Brushes.Black, 5, yPos)
        yPos += 15
        e.Graphics.DrawString("PPn : " & labPPN.Text & "%", f10, Brushes.Black, 5, yPos)
        yPos += 15
        e.Graphics.DrawString("Total : " & labTotal.Text, f10, Brushes.Black, 5, yPos)
        yPos += 15
        e.Graphics.DrawString(line, f10, Brushes.Black, 0, yPos)

    End Sub
End Class


