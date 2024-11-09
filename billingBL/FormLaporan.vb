Imports MySql.Data.MySqlClient
Imports OfficeOpenXml
Imports System.IO

Public Class FormLaporan
    Dim totalDurasi As Integer = 0
    Dim totalPemasukan As Integer = 0

    Private Sub DisplayTransactionByDate()
        Dim startDate As DateTime = datePickerBefore.Value.Date
        Dim endDate As DateTime = datePickerAfter.Value.Date

        Dim formattedStartDate As String = startDate.ToString("yyyy-MM-dd")
        Dim formattedEndDate As String = endDate.ToString("yyyy-MM-dd")

        Try
            connect()

            Dim query As String = "SELECT * FROM tb_transaksi WHERE STR_TO_DATE(tanggal_transaksi, '%Y-%m-%d') BETWEEN @StartDate AND @EndDate"
            Dim cmd As New MySqlCommand(query, Koneksi)

            cmd.Parameters.AddWithValue("@StartDate", formattedStartDate)
            cmd.Parameters.AddWithValue("@EndDate", formattedEndDate)

            DA = New MySqlDataAdapter(cmd)
            DT = New DataTable
            DA.Fill(DT)

            DataGridView1.Rows.Clear()
            Dim i As Integer = 0
            totalPemasukan = 0

            For Each row As DataRow In DT.Rows
                Dim totalDurasi As Integer = Convert.ToInt32(row("durasi_siang")) + Convert.ToInt32(row("durasi_malam"))
                totalPemasukan += Convert.ToInt32(row("harga"))

                Dim rows As DataGridViewRow = New DataGridViewRow()
                rows.CreateCells(DataGridView1)
                rows.Cells(0).Value = i + 1
                rows.Cells(1).Value = row("no_order")
                rows.Cells(2).Value = totalDurasi
                rows.Cells(3).Value = row("harga")
                rows.Cells(4).Value = row("metode_pembayaran")
                rows.Cells(5).Value = row("tanggal_transaksi")

                DataGridView1.Rows.Add(rows)
                i += 1
            Next

            labelTotalPemasukan.Text = FormatCurrency(totalPemasukan)

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            disconnect()
        End Try
    End Sub

    Private Sub ExportDataGridViewToExcel()

        ExcelPackage.LicenseContext = LicenseContext.NonCommercial
        ' Initialize SaveFileDialog
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx"  ' Set file filter to Excel files
        saveFileDialog.Title = "Save Excel File"
        saveFileDialog.FileName = "ExportedData.xlsx"  ' Default filename

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
    End Sub


    ' Helper method to release COM objects and free up memory
    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.RowHeadersVisible = False
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles DataGridView1.SelectionChanged
        DataGridView1.ClearSelection()
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        DisplayTransactionByDate()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ExportDataGridViewToExcel()
    End Sub
End Class