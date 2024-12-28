Imports MySql.Data.MySqlClient
Imports OfficeOpenXml

Public Class FormTransaksi
    Dim totalDurasi As Integer = 0
    Public Sub tampilTransaksiBilling()
        Dim tanggal_transaksi As String = Date.Now.ToString("yyyy-MM-dd")
        Dim totalPemasukan = 0
        Try
            connect()
            DA = New MySqlDataAdapter("SELECT * FROM tb_transaksi WHERE tanggal_transaksi='" & tanggal_transaksi & "'", Koneksi)
            DT = New DataTable
            DA.Fill(DT)
            DataGridView1.Rows.Clear()

            For i = 0 To DT.Rows.Count - 1
                totalDurasi = Convert.ToInt32(DT.Rows(i).Item(9)) + Convert.ToInt32(DT.Rows(i).Item(10))
                totalPemasukan += Convert.ToInt32(DT.Rows(i).Item(7))

                Dim row As DataGridViewRow = New DataGridViewRow()
                row.CreateCells(DataGridView1)

                row.Cells(0).Value = i + 1
                row.Cells(1).Value = DT.Rows(i).Item(0)
                row.Cells(2).Value = totalDurasi
                row.Cells(3).Value = DT.Rows(i).Item(7)
                row.Cells(4).Value = DT.Rows(i).Item(11)
                row.Cells(5).Value = DT.Rows(i).Item("nama_shift")

                DataGridView1.Rows.Add(row)
            Next

            labelPemasukanBilling.Text = FormatCurrency(totalPemasukan)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try
    End Sub

    Public Sub tampilTransaksiBillingFilter(Optional metodePembayaran As String = "", Optional namaShift As String = "")
        Dim tanggal_transaksi As String = Date.Now.ToString("yyyy-MM-dd")
        Dim totalPemasukan = 0
        Dim query As String = "SELECT * FROM tb_transaksi WHERE tanggal_transaksi = @tanggal"
        Debug.WriteLine(namaShift)

        ' Add conditions for optional filters
        If metodePembayaran <> "" Then
            query &= " AND metode_pembayaran = @metodePembayaran"
        End If
        If namaShift <> "" Then
            query &= " AND nama_shift = @namaShift"
        End If

        Try
            connect()
            Dim cmd As New MySqlCommand(query, Koneksi)
            cmd.Parameters.AddWithValue("@tanggal", tanggal_transaksi)

            If metodePembayaran <> "" Then
                cmd.Parameters.AddWithValue("@metodePembayaran", metodePembayaran)
            End If
            If namaShift <> "" Then
                cmd.Parameters.AddWithValue("@namaShift", namaShift)
            End If

            DA = New MySqlDataAdapter(cmd)
            DT = New DataTable
            DA.Fill(DT)
            DataGridView1.Rows.Clear()

            For i = 0 To DT.Rows.Count - 1
                Dim totalDurasi = Convert.ToInt32(DT.Rows(i).Item(9)) + Convert.ToInt32(DT.Rows(i).Item(10))
                totalPemasukan += Convert.ToInt32(DT.Rows(i).Item(7))

                Dim row As DataGridViewRow = New DataGridViewRow()
                row.CreateCells(DataGridView1)

                row.Cells(0).Value = i + 1
                row.Cells(1).Value = DT.Rows(i).Item(0)
                row.Cells(2).Value = totalDurasi
                row.Cells(3).Value = DT.Rows(i).Item(7)
                row.Cells(4).Value = DT.Rows(i).Item(11)
                row.Cells(5).Value = DT.Rows(i).Item("nama_shift")

                DataGridView1.Rows.Add(row)
            Next

            labelPemasukanBilling.Text = FormatCurrency(totalPemasukan)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try
    End Sub

    Private Sub tampilTransaksiFnB()
        Dim tanggal_transaksi As String = Date.Now.ToString("yyyy-MM-dd")
        Dim totalPemasukan = 0
        Try

            connect()
            DA = New MySqlDataAdapter("SELECT no_order, GROUP_CONCAT(nama_menu ORDER BY nama_menu SEPARATOR ', ') AS nama_menus, GROUP_CONCAT(qty_menu ORDER BY qty_menu SEPARATOR ', ') AS qty_menus, SUM(subtotal) AS total_price, metode_pembayaran, nama_shift FROM tb_fnb_transaksi WHERE tanggal_transaksi='" & tanggal_transaksi & "' GROUP BY  no_order;", Koneksi)
            DT = New DataTable
            DA.Fill(DT)
            DataGridView2.Rows.Clear()
            Debug.WriteLine(DT)
            Debug.WriteLine(DT.Rows.Count)

            For i = 0 To DT.Rows.Count - 1
                totalPemasukan += Convert.ToInt32(DT.Rows(i).Item("total_price"))

                Dim row As DataGridViewRow = New DataGridViewRow()
                row.CreateCells(DataGridView2)

                row.Cells(0).Value = i + 1
                row.Cells(1).Value = DT.Rows(i).Item("no_order")
                row.Cells(2).Value = DT.Rows(i).Item("nama_menus")
                row.Cells(3).Value = DT.Rows(i).Item("qty_menus")
                row.Cells(4).Value = DT.Rows(i).Item("total_price")
                row.Cells(5).Value = DT.Rows(i).Item("metode_pembayaran")
                row.Cells(6).Value = DT.Rows(i).Item("nama_shift")


                DataGridView2.Rows.Add(row)


            Next

            DataGridView2.Columns(2).DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DataGridView2.Columns(2).Width = 200
            DataGridView2.Columns(3).DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DataGridView2.Columns(3).Width = 75
            DataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            labelPemasukanFnB.Text = FormatCurrency(totalPemasukan)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try
    End Sub

    Private Sub tampilTransaksiFnBFilter(Optional metodePembayaran As String = "", Optional namaShift As String = "")
        Dim tanggal_transaksi As String = Date.Now.ToString("yyyy-MM-dd")
        Dim totalPemasukan = 0
        Dim query As String = "SELECT no_order, GROUP_CONCAT(nama_menu ORDER BY nama_menu SEPARATOR ', ') AS nama_menus, " &
                          "GROUP_CONCAT(qty_menu ORDER BY qty_menu SEPARATOR ', ') AS qty_menus, SUM(subtotal) AS total_price, " &
                          "metode_pembayaran, nama_shift " &
                          "FROM tb_fnb_transaksi WHERE tanggal_transaksi = @tanggal"

        ' Add conditions for optional filters
        If metodePembayaran <> "" Then
            query &= " AND metode_pembayaran = @metodePembayaran"
        End If
        If namaShift <> "" Then
            query &= " AND nama_shift = @namaShift"
        End If

        query &= " GROUP BY no_order;"

        Try
            connect()
            Dim cmd As New MySqlCommand(query, Koneksi)
            cmd.Parameters.AddWithValue("@tanggal", tanggal_transaksi)

            If metodePembayaran <> "" Then
                cmd.Parameters.AddWithValue("@metodePembayaran", metodePembayaran)
            End If
            If namaShift <> "" Then
                cmd.Parameters.AddWithValue("@namaShift", namaShift)
            End If

            DA = New MySqlDataAdapter(cmd)
            DT = New DataTable
            DA.Fill(DT)
            DataGridView2.Rows.Clear()

            For i = 0 To DT.Rows.Count - 1
                totalPemasukan += Convert.ToInt32(DT.Rows(i).Item("total_price"))

                Dim row As DataGridViewRow = New DataGridViewRow()
                row.CreateCells(DataGridView2)

                row.Cells(0).Value = i + 1
                row.Cells(1).Value = DT.Rows(i).Item("no_order")
                row.Cells(2).Value = DT.Rows(i).Item("nama_menus")
                row.Cells(3).Value = DT.Rows(i).Item("qty_menus")
                row.Cells(4).Value = DT.Rows(i).Item("total_price")
                row.Cells(5).Value = DT.Rows(i).Item("metode_pembayaran")
                row.Cells(6).Value = DT.Rows(i).Item("nama_shift")

                DataGridView2.Rows.Add(row)
            Next

            DataGridView2.Columns(2).DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DataGridView2.Columns(2).Width = 200
            DataGridView2.Columns(3).DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DataGridView2.Columns(3).Width = 75
            DataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            labelPemasukanFnB.Text = FormatCurrency(totalPemasukan)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try
    End Sub


    Public Sub tampilFilter(jenis As String)
        If jenis = "billing" Then
            Dim selectedMetodeBayar As String = ""
            Dim selectedShiftBilling As String = ""

            ' Check selected indexes and assign values accordingly
            If ddMetodeBilling.SelectedIndex > -1 Then
                selectedMetodeBayar = ddMetodeBilling.SelectedItem.ToString()
            End If

            If ddShiftBilling.SelectedIndex > -1 Then
                selectedShiftBilling = ddShiftBilling.SelectedItem.ToString()
            End If

            ' Call the method with appropriate parameters
            tampilTransaksiBillingFilter(selectedMetodeBayar, selectedShiftBilling)
        ElseIf jenis = "fnb" Then
            Dim selectedMetodeBayar As String = ""
            Dim selectedShiftFnB As String = ""

            ' Check selected indexes and assign values accordingly
            If ddMetodeFNB.SelectedIndex > -1 Then
                selectedMetodeBayar = ddMetodeFNB.SelectedItem.ToString()
            End If

            If ddShiftFNB.SelectedIndex > -1 Then
                selectedShiftFnB = ddShiftFNB.SelectedItem.ToString()
            End If

            ' Call the method with appropriate parameters
            tampilTransaksiFnBFilter(selectedMetodeBayar, selectedShiftFnB)
        End If

    End Sub

    Public Sub tampilNamaShift()
        Dim query As String = "SELECT * FROM tb_shift"
        Try
            connect()
            Dim cmd As New MySqlCommand(query, Koneksi)
            DA = New MySqlDataAdapter(cmd)
            DT = New DataTable
            DA.Fill(DT)
            ddShiftBilling.Items.Clear()
            ddShiftFNB.Items.Clear()

            For i = 0 To DT.Rows.Count - 1
                ddShiftBilling.Items.Add(DT.Rows(i).Item("nama"))
                ddShiftFNB.Items.Add(DT.Rows(i).Item("nama"))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try
    End Sub

    Private Sub ExportDataGridViewToExcel(jenis As String)

        ExcelPackage.LicenseContext = LicenseContext.NonCommercial

        If jenis = "billing" Then
            ' Initialize SaveFileDialog
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx"  ' Set file filter to Excel files
            saveFileDialog.Title = "Save Excel File"
            saveFileDialog.FileName = "DataHarianBilling.xlsx"  ' Default filename

            ' Show the dialog and get the result
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                ' Proceed with exporting data
                Dim filePath As String = saveFileDialog.FileName

                ' Add your Excel export code here (using Microsoft.Office.Interop.Excel or EPPlus)
                ' Example with EPPlus:
                Try
                    Using package As New OfficeOpenXml.ExcelPackage()
                        Dim worksheet As OfficeOpenXml.ExcelWorksheet = package.Workbook.Worksheets.Add("Sheet1")

                        ' Export headers
                        For col As Integer = 0 To DataGridView1.Columns.Count - 1
                            worksheet.Cells(1, col + 1).Value = DataGridView1.Columns(col).HeaderText
                        Next

                        ' Export rows
                        For row As Integer = 0 To DataGridView1.Rows.Count - 1
                            For col As Integer = 0 To DataGridView1.Columns.Count - 1
                                worksheet.Cells(row + 2, col + 1).Value = DataGridView1.Rows(row).Cells(col).Value
                            Next
                        Next

                        ' Save the Excel file
                        Dim file As New IO.FileInfo(filePath)
                        package.SaveAs(file)

                        MsgBox("Data exported successfully!")
                    End Using
                Catch ex As Exception
                    MsgBox("Error exporting data: " & ex.Message)
                End Try
            End If
        ElseIf jenis = "fnb" Then
            ' Initialize SaveFileDialog
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx"  ' Set file filter to Excel files
            saveFileDialog.Title = "Save Excel File"
            saveFileDialog.FileName = "DataHarianFnB.xlsx"  ' Default filename

            ' Show the dialog and get the result
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                ' Proceed with exporting data
                Dim filePath As String = saveFileDialog.FileName

                ' Add your Excel export code here (using Microsoft.Office.Interop.Excel or EPPlus)
                ' Example with EPPlus:
                Try
                    Using package As New OfficeOpenXml.ExcelPackage()
                        Dim worksheet As OfficeOpenXml.ExcelWorksheet = package.Workbook.Worksheets.Add("Sheet1")

                        ' Export headers
                        For col As Integer = 0 To DataGridView2.Columns.Count - 1
                            worksheet.Cells(1, col + 1).Value = DataGridView2.Columns(col).HeaderText
                        Next

                        ' Export rows
                        For row As Integer = 0 To DataGridView2.Rows.Count - 1
                            For col As Integer = 0 To DataGridView2.Columns.Count - 1
                                worksheet.Cells(row + 2, col + 1).Value = DataGridView2.Rows(row).Cells(col).Value
                            Next
                        Next

                        ' Save the Excel file
                        Dim file As New IO.FileInfo(filePath)
                        package.SaveAs(file)

                        MsgBox("Data exported successfully!")
                    End Using
                Catch ex As Exception
                    MsgBox("Error exporting data: " & ex.Message)
                End Try
            End If
        End If

    End Sub

    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilTransaksiBilling()
        tampilTransaksiFnB()
        tampilNamaShift()
    End Sub

    Private Sub tpBilling_Click(sender As Object, e As EventArgs) Handles tpBilling.Click
        tampilTransaksiBilling()
    End Sub

    Private Sub tpFnB_Click(sender As Object, e As EventArgs) Handles tpFnB.Click
        tampilTransaksiFnB()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name

            If colName = "Column4" Then
                If MsgBox("Are you sure you want to print this bill?", vbYesNo + vbQuestion, "Print Bill") = vbYes Then
                    Try
                        'print bill


                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message, vbCritical, "Deletion Error")
                    Finally
                        conn.Close()  ' Ensure the connection is closed
                    End Try

                    ' Reload data after deletion
                    ' Ensure this method works correctly
                End If
            End If

        Catch ex As Exception
            conn.Close()
            MsgBox("Warning: " & ex.Message, vbCritical, "Operation Error")
        End Try
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Try
            Dim colName As String = DataGridView2.Columns(e.ColumnIndex).Name

            If colName = "Column2" Then
                If MsgBox("Are you sure you want to print this bill?", vbYesNo + vbQuestion, "Print Bill") = vbYes Then
                    Try
                        'print bill


                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message, vbCritical, "Deletion Error")
                    Finally
                        conn.Close()  ' Ensure the connection is closed
                    End Try

                    ' Reload data after deletion
                    ' Ensure this method works correctly
                End If
            End If

        Catch ex As Exception
            conn.Close()
            MsgBox("Warning: " & ex.Message, vbCritical, "Operation Error")
        End Try
    End Sub

    Private Sub btnFilterBilling_Click(sender As Object, e As EventArgs)
        tampilFilter("billing")
    End Sub

    Private Sub btnFilterFNB_Click(sender As Object, e As EventArgs) Handles btnFilterFNB.Click
        tampilFilter("fnb")
    End Sub

    Private Sub btnExportFNB_Click(sender As Object, e As EventArgs) Handles btnExportFNB.Click
        ExportDataGridViewToExcel("fnb")
    End Sub

    Private Sub btnExportBilling_Click(sender As Object, e As EventArgs)
        ExportDataGridViewToExcel("billing")
    End Sub
End Class