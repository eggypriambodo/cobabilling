Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.IO
Imports Windows.Win32.UI.Input

Public Class FormFnB

    Public Shared Instance As FormFnB

    Private WithEvents pan As Panel
    Private WithEvents pan_top As Panel
    Private WithEvents nama_fnb As Label
    Private WithEvents harga_fnb As Label
    Private WithEvents image_fnb As CirclePicturBox

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer
    Dim metodePembayaran As String
    Dim hargaMenu As Integer = 0

    Private Sub FormFnB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        labDate.Text = Date.Now.ToString("yyyy-MMMM-dd")
        getNoOrder()
        Load_Foods()
    End Sub

    Sub getNoOrder()
        Dim sekarang As DateTime = DateTime.Now
        Dim tanggal As String = sekarang.ToString("ddMMyyyyHHmmss")
        Dim noOrder As String = tanggal
        tbNoOrder.Text = noOrder
    End Sub

    Sub Load_Foods()
        FlowLayoutPanel1.Controls.Clear()
        FlowLayoutPanel1.AutoScroll = True
        Try
            conn.Open()
            CMD = New MySqlCommand("SELECT `image_fnb`, `nama_fnb`, `harga_fnb` FROM `tb_fnb`", conn)
            Using DR As MySqlDataReader = CMD.ExecuteReader()
                While DR.Read()
                    LoadControls(DR)
                End While
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Sub LoadControls(dr As MySqlDataReader)
        ' Fetch image byte array from DataReader
        Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
        Dim array(CInt(len - 1)) As Byte  ' Fix for zero-based array indexing
        dr.GetBytes(0, 0, array, 0, CInt(len))

        ' Initialize panel to hold the controls
        Dim pan As New Panel With {
        .Width = 150,
        .Height = 180,
        .BackColor = Color.FromArgb(30, 144, 255),
        .Tag = dr.Item("nama_fnb")
    }

        ' Optional top panel
        Dim pan_top As New Panel With {
        .Width = 150,
        .Height = 10,
        .BackColor = Color.FromArgb(30, 144, 255),
        .Dock = DockStyle.Top,
        .Tag = dr.Item("nama_fnb")
    }

        ' CirclePictureBox to display the image
        Dim image_fnb As New CirclePicturBox With {
        .Height = 120,
        .SizeMode = PictureBoxSizeMode.StretchImage,  ' Set to StretchImage for proper scaling
        .Dock = DockStyle.Top,
        .Tag = dr.Item("nama_fnb").ToString
    }

        ' Labels for name and price
        Dim nama_fnb As New Label With {
        .ForeColor = Color.White,
        .Font = New Font("Segoe UI", 10, FontStyle.Bold),
        .TextAlign = ContentAlignment.MiddleCenter,
        .Dock = DockStyle.Top,
        .Tag = dr.Item("nama_fnb").ToString,
        .AutoSize = False,  ' Disable auto-sizing
        .MaximumSize = New Size(140, 0),  ' Set maximum width (with some margin)
        .Height = 40
    }

        ' Load image from byte array into MemoryStream
        If array.Length > 0 Then
            Using ms As New System.IO.MemoryStream(array)
                image_fnb.Image = New Bitmap(ms)
            End Using
        End If

        ' Set text for the name and price labels
        nama_fnb.Text = dr.Item("nama_fnb").ToString

        ' Add the controls to the panel
        pan.Controls.Add(nama_fnb)
        pan.Controls.Add(image_fnb)
        pan.Controls.Add(pan_top)

        ' Add the panel to the FlowLayoutPanel
        FlowLayoutPanel1.Controls.Add(pan)

        ' Add event handlers
        AddHandler nama_fnb.Click, AddressOf Selectimg_Click
        AddHandler image_fnb.Click, AddressOf Selectimg_Click
        AddHandler pan.Click, AddressOf Selectimg_Click
    End Sub
    Public Sub Selectimg_Click(sender As Object, e As EventArgs)
        conn.Open()
        Try
            CMD = New MySqlCommand("SELECT `nama_fnb`, `harga_fnb` FROM `tb_fnb` WHERE `nama_fnb` = @nama", conn)
            CMD.Parameters.AddWithValue("@nama", sender.tag.ToString)
            Using DR = CMD.ExecuteReader()
                While DR.Read()
                    AddToGrid(DR("nama_fnb").ToString(), CDec(DR("harga_fnb")))
                End While
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub AddToGrid(name As String, price As Decimal)
        Dim row = DataGridView1.Rows.Cast(Of DataGridViewRow)().FirstOrDefault(Function(itm) itm.Cells(1).Value?.ToString() = name)
        If row Is Nothing Then
            Dim subtotal = price
            DataGridView1.Rows.Add(DataGridView1.Rows.Count, name, price, 1, subtotal)
        Else
            Dim qty = CInt(row.Cells(3).Value) + 1
            row.Cells(3).Value = qty
            row.Cells(4).Value = qty * price
        End If
    End Sub

    Sub Get_grandTotal()
        Dim grandTotal As Double = DataGridView1.Rows.Cast(Of DataGridViewRow)().Sum(Function(row) CDbl(row.Cells(4).Value))
        Dim ppn = grandTotal * 0.11
        labSubtotal.Text = $"Rp. {FormatNumber(grandTotal, 0, TriState.True, TriState.False, TriState.True)}"
        grandTotal += ppn
        labTotal.Text = $"Rp. {FormatNumber(grandTotal, 0, TriState.True, TriState.False, TriState.True)}"
        labGrandTotal.Text = labTotal.Text
        labPPN.Text = $"Rp. {FormatNumber(ppn, 0, TriState.True, TriState.False, TriState.True)}"
    End Sub

    Function GetValueGrandTotal()
        Dim grandtotal As Double = 0
        Try
            For i As Double = 0 To DataGridView1.Rows.Count() - 1 Step +1
                grandtotal = grandtotal + Convert.ToDouble(DataGridView1.Rows(i).Cells(4).Value)

            Next
            Dim ppn As Double = grandtotal * 0.11
            grandtotal = grandtotal + ppn
        Catch ex As Exception

        End Try

        Return grandtotal
    End Function
    Sub new_order()
        Load_Foods()
        labDate.Text = Date.Now.ToString("yyyy-MMMM-dd")
        getNoOrder()
        DataGridView1.Rows.Clear()
        tbNamaTamu.Clear()
        tbUangDiterima.Clear()
        tbUangKembalian.Clear()
    End Sub

    Private Sub btnManageMenu_Click(sender As Object, e As EventArgs) Handles btnManageMenu.Click
        FormAddMenu.Show()
    End Sub

    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        If tbUangDiterima.Text = String.Empty Then
            MsgBox("Please Enter Receive Amount !", vbExclamation)
            Return
        End If

        If tbUangKembalian.Text < 0 Then
            MsgBox("Uang Diterima Kurang !" & vbNewLine & tbUangDiterima.Text & " Rp.", MsgBoxStyle.Exclamation)
            Return
        End If

        If Not (rbtnCash.Checked OrElse rbtnDebit.Checked OrElse rbtnQris.Checked OrElse rbtnTransfer.Checked) Then
            MsgBox("Metode Pembayaran Harus Diisi", MsgBoxStyle.Exclamation)
            Return
        End If

        ' Mengonversi nominal uang kembalian ke format rupiah
        Dim uangKembalian As Decimal = Decimal.Parse(tbUangKembalian.Text)
        Dim uangKembalianRupiah As String = uangKembalian.ToString("C", Globalization.CultureInfo.CreateSpecificCulture("id-ID"))

        ' Tampilkan MsgBox konfirmasi dengan uang kembalian
        If MsgBox("Konfirmasi Order? Uang Kembalian: " & uangKembalianRupiah, vbYesNo + vbQuestion, "Konfirmasi Pembayaran") = vbNo Then
            Return
        End If

        Try
            conn.Open()
            Dim tanggal_transaksi As String = Date.Now.ToString("yyyy-MM-dd")
            CMD = New MySqlCommand("INSERT INTO tb_fnb_transaksi(no_order, nama_menu, harga_menu, qty_menu, subtotal, nama_tamu, tanggal_transaksi, metode_pembayaran) VALUES (@no_order,@nama_menu,@harga_menu,@qty_menu,@subtotal,@nama_tamu,@tanggal_transaksi,@metode_pembayaran)", conn)

            For Each row As DataGridViewRow In DataGridView1.Rows
                If Not row.IsNewRow Then
                    CMD.Parameters.Clear()
                    CMD.Parameters.AddWithValue("@no_order", tbNoOrder.Text)
                    CMD.Parameters.AddWithValue("@nama_menu", row.Cells(1).Value)
                    CMD.Parameters.AddWithValue("@harga_menu", row.Cells(2).Value)
                    CMD.Parameters.AddWithValue("@qty_menu", row.Cells(3).Value)
                    CMD.Parameters.AddWithValue("@subtotal", row.Cells(4).Value)
                    CMD.Parameters.AddWithValue("@nama_tamu", tbNamaTamu.Text)
                    CMD.Parameters.AddWithValue("@tanggal_transaksi", tanggal_transaksi)
                    CMD.Parameters.AddWithValue("@metode_pembayaran", metodePembayaran)
                    CMD.ExecuteNonQuery()
                End If
            Next

            ' Konfirmasi untuk mencetak tagihan
            If MsgBox("Print Bill?", vbQuestion + vbYesNo) = vbYes Then
                changelongpaper()
                PPD.Document = PD
                PPD.ShowDialog()
            End If

        Catch ex As Exception
            MsgBox("Database Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
        new_order()
    End Sub


    '================================================PRINT BILL==========================================


    Sub changelongpaper()
        longpaper = DataGridView1.RowCount * 15 + 500
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As EventArgs) Handles PD.BeginPrint
        PD.DefaultPageSettings = New PageSettings With {
            .PaperSize = New PaperSize("Custom", 250, longpaper)
        }
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
        e.Graphics.DrawString(tbNoOrder.Text & "                      " & Date.Now.ToString("dd/MM/yyyy"), f10, Brushes.Black, 5, 100)
        e.Graphics.DrawString("Nama Tamu : " & tbNamaTamu.Text, f10, Brushes.Black, 5, 120)

        ' Print Column Headers
        e.Graphics.DrawString("Item", f10, Brushes.Black, 5, 150)
        e.Graphics.DrawString("Qty", f10, Brushes.Black, 150, 150)
        e.Graphics.DrawString("Price", f10, Brushes.Black, 200, 150)
        e.Graphics.DrawString(line, f10, Brushes.Black, 0, 155)

        ' Print DataGridView Rows (Column5, Column1, Column2, Column3, Column4)
        Dim yPos As Integer = 175
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                ' Retrieve values from specific columns
                Dim itemName As String = row.Cells("Column1").Value.ToString() ' Menu name (or any data in Column5)
                Dim qty As String = row.Cells("Column3").Value.ToString()     ' Quantity (or any data in Column1)
                Dim price As String = row.Cells("Column2").Value.ToString()   ' Price (or any data in Column2)
                Dim total As String = row.Cells("Column4").Value.ToString()   ' Total (or any data in Column3)
                Dim extraInfo As String = row.Cells("Column4").Value.ToString() ' Additional info (or any data in Column4)

                ' Print the row's data
                e.Graphics.DrawString(itemName, f10, Brushes.Black, 5, yPos)
                e.Graphics.DrawString(qty, f10, Brushes.Black, 155, yPos)
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
        e.Graphics.DrawString("PPn : " & labPPN.Text, f10, Brushes.Black, 5, yPos)
        yPos += 15
        e.Graphics.DrawString("Total : " & labTotal.Text, f10, Brushes.Black, 5, yPos)
        yPos += 15
        e.Graphics.DrawString(line, f10, Brushes.Black, 0, yPos)

    End Sub

    Private Sub rbtnQRIS_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnQris.CheckedChanged
        tbUangDiterima.Enabled = False
        tbUangKembalian.Text = "0"
        metodePembayaran = "QRIS"
        tbUangDiterima.Text = GetValueGrandTotal()
    End Sub

    Private Sub rbtnDebit_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnDebit.CheckedChanged
        tbUangDiterima.Enabled = False
        tbUangKembalian.Text = "0"
        metodePembayaran = "Debit"
        tbUangDiterima.Text = GetValueGrandTotal()
    End Sub

    Private Sub rbtnTransfer_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnTransfer.CheckedChanged
        tbUangDiterima.Enabled = False
        tbUangKembalian.Text = "0"
        metodePembayaran = "Transfer"
        tbUangDiterima.Text = GetValueGrandTotal()
    End Sub

    Private Sub rbtnCash_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnCash.CheckedChanged
        tbUangDiterima.Enabled = True
        tbUangKembalian.Text = "0"
        tbUangDiterima.Text = 0
        metodePembayaran = "Cash"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Get_grandTotal()
    End Sub

    Private Sub tbUangDiterima_TextChanged(sender As Object, e As EventArgs) Handles tbUangDiterima.TextChanged
        If String.IsNullOrWhiteSpace(tbUangDiterima.Text) Then
            tbUangKembalian.Text = "Rp. 0"
            Return
        End If

        Dim unformattedInput As String = tbUangDiterima.Text.Replace("Rp.", "").Replace(",", "").Trim()
        Dim inputAmount As Double

        If Not Double.TryParse(unformattedInput, inputAmount) Then
            tbUangDiterima.Text = "0"
            tbUangDiterima.SelectionStart = tbUangDiterima.Text.Length
            Return
        End If

        Dim grandTotal As Double = 0
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                grandTotal += Convert.ToDouble(row.Cells(4).Value)
            End If
        Next

        Dim ppn As Double = grandTotal * 0.11
        grandTotal += ppn
        Dim kembalian As Double = inputAmount - grandTotal

        If Not tbUangDiterima.Text.StartsWith("Rp.") Then
            tbUangDiterima.Text = $"Rp. {FormatNumber(inputAmount, 0, TriState.True, TriState.False, TriState.True)}"
            tbUangDiterima.SelectionStart = tbUangDiterima.Text.Length
        End If

        tbUangKembalian.Text = kembalian
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        new_order()
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        FlowLayoutPanel1.Controls.Clear()
        FlowLayoutPanel1.AutoScroll = True
        Try
            conn.Open()

            CMD = New MySqlCommand("SELECT `image_fnb`, `nama_fnb`, `harga_fnb` FROM `tb_fnb` WHERE `nama_fnb` LIKE @search", conn)
            CMD.Parameters.AddWithValue("@search", "%" & tbSearch.Text & "%")

            Using DR As MySqlDataReader = CMD.ExecuteReader()
                While DR.Read()
                    LoadControls(DR)
                End While
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


End Class


