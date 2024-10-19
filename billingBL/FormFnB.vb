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
        Dim random As New Random()

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
                    LoadControls(DR) ' Pass the DataReader to LoadControls
                End While
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close() ' Ensure the connection is closed in case of an error
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



    Sub Get_grandTotal()
        Dim grandtotal As Double = 0
        Try
            For i As Double = 0 To DataGridView1.Rows.Count() - 1 Step +1
                grandtotal = grandtotal + Convert.ToDouble(DataGridView1.Rows(i).Cells(4).Value)

            Next
            labSubtotal.Text = "Rp. " + FormatNumber(grandtotal, 0, TriState.True, TriState.False, TriState.True)
            Dim ppn As Double = grandtotal * 0.11
            grandtotal = grandtotal + ppn
            labTotal.Text = "Rp. " + FormatNumber(grandtotal, 0, TriState.True, TriState.False, TriState.True)
            labGrandTotal.Text = "Rp. " + FormatNumber(grandtotal, 0, TriState.True, TriState.False, TriState.True)
            labPPN.Text = "Rp. " + FormatNumber(ppn, 0, TriState.True, TriState.False, TriState.True)
        Catch ex As Exception

        End Try

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
        If MsgBox("Are You Sure Order Conform ?", vbQuestion + vbYesNo) = vbYes Then
            If tbUangDiterima.Text = String.Empty Then
                MsgBox("Please Enter Receive Amount !", vbExclamation)
                Return
            ElseIf tbUangKembalian.Text < 0 Then
                MsgBox("Uang Diterima Kurang !" & vbNewLine & tbUangDiterima.Text & " Rp.", MsgBoxStyle.Exclamation)
                Return
            ElseIf Not (rbtnCash.Checked Or rbtnDebit.Checked Or rbtnQris.Checked Or rbtnTransfer.Checked) Then
                MsgBox("Metode Pembayaran Harus Diisi", MsgBoxStyle.Exclamation)
            Else
                Try
                    Dim tanggal_transaksi As String = Date.Now.ToString("yyyy-MM-dd")
                    conn.Open()
                    CMD = New MySqlCommand("INSERT INTO tb_fnb_transaksi(no_order, nama_menu, harga_menu, qty_menu, subtotal, nama_tamu, tanggal_transaksi, metode_pembayaran) VALUES (@no_order,@nama_menu,@harga_menu,@qty_menu,@subtotal,@nama_tamu,@tanggal_transaksi,@metode_pembayaran)", conn)
                    For j As Integer = 0 To DataGridView1.Rows.Count - 1 Step +1
                        CMD.Parameters.Clear()
                        CMD.Parameters.AddWithValue("@no_order", tbNoOrder.Text)
                        CMD.Parameters.AddWithValue("@nama_menu", DataGridView1.Rows(j).Cells(1).Value)
                        CMD.Parameters.AddWithValue("@harga_menu", DataGridView1.Rows(j).Cells(2).Value)
                        CMD.Parameters.AddWithValue("@qty_menu", DataGridView1.Rows(j).Cells(3).Value)
                        CMD.Parameters.AddWithValue("@subtotal", DataGridView1.Rows(j).Cells(4).Value)
                        CMD.Parameters.AddWithValue("@nama_tamu", tbNamaTamu.Text)
                        CMD.Parameters.AddWithValue("@tanggal_transaksi", tanggal_transaksi)
                        CMD.Parameters.AddWithValue("@metode_pembayaran", metodePembayaran)
                        i = CMD.ExecuteNonQuery
                    Next
                    If i > 0 Then
                        If MsgBox("Print Bill ?", vbQuestion + vbYesNo) = vbYes Then
                            changelongpaper()
                            PPD.Document = PD
                            PPD.ShowDialog()
                        End If
                        new_order()
                    Else
                        MsgBox("Warning : Some Failure !", vbExclamation)
                    End If
                Catch ex As Exception

                End Try
                conn.Close()
            End If
        Else
            Return
        End If
    End Sub

    '================================================PRINT BILL==========================================



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
        Try
            Dim grandtotal As Double = 0
            For i As Double = 0 To DataGridView1.Rows.Count() - 1 Step +1
                grandtotal = grandtotal + DataGridView1.Rows(i).Cells(4).Value

            Next
            Dim ppn As Integer = grandtotal * 0.11
            grandtotal = grandtotal + ppn
            tbUangKembalian.Text = tbUangDiterima.Text - Format(CDec(grandtotal), "#,##0.00")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        new_order()
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        FlowLayoutPanel1.Controls.Clear()
        FlowLayoutPanel1.AutoScroll = True
        Try
            conn.Open()

            ' Use parameterized query for safety and correctness
            CMD = New MySqlCommand("SELECT `image_fnb`, `nama_fnb`, `harga_fnb` FROM `tb_fnb` WHERE `nama_fnb` LIKE @search", conn)
            CMD.Parameters.AddWithValue("@search", "%" & tbSearch.Text & "%") ' Use parameter to prevent SQL injection

            Using DR As MySqlDataReader = CMD.ExecuteReader()
                While DR.Read()
                    LoadControls(DR) ' Pass the DataReader to LoadControls
                End While
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close() ' Ensure the connection is closed in case of an error
        End Try
    End Sub


End Class


