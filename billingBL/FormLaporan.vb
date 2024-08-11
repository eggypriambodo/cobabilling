Imports MySql.Data.MySqlClient

Public Class FormLaporan
    Dim totalDurasi As Integer = 0
    Dim totalPemasukan As Integer = 0
    Private Sub DisplayTransactionsByYear(selectedYear As Integer)
        Try
            connect()

            ' Query untuk mengambil semua data transaksi
            Dim query As String = "SELECT * FROM tb_transaksi"
            DA = New MySqlDataAdapter(query, Koneksi)
            DT = New DataTable
            DA.Fill(DT)


            Dim dateFormat As String = "yyyy-MM-dd"

            ' Filter data berdasarkan tahun
            Dim filteredRows = From row In DT.AsEnumerable()
                               Let transactionDate As DateTime = DateTime.ParseExact(row.Field(Of String)("tanggal_transaksi"), DateFormat, System.Globalization.CultureInfo.InvariantCulture)
                               Where transactionDate.Year = selectedYear
                               Order By transactionDate Descending ' Urutkan berdasarkan tanggal terbaru
                               Select row

            ' Mengisi DataGridView dengan data transaksi yang sudah difilter
            DataGridView1.Rows.Clear()
            For i = 0 To filteredRows.Count() - 1
                totalDurasi = Convert.ToInt32(filteredRows(i).Item(9)) + Convert.ToInt32(filteredRows(i).Item(10))
                totalPemasukan = totalPemasukan + Convert.ToInt32(filteredRows(i).Item(7))
                Dim row As DataGridViewRow = New DataGridViewRow()
                row.CreateCells(DataGridView1)
                row.Cells(0).Value = i + 1
                row.Cells(1).Value = filteredRows(i).Item(0)
                row.Cells(2).Value = totalDurasi
                row.Cells(3).Value = filteredRows(i).Item(7)
                row.Cells(4).Value = filteredRows(i).Item(11)
                row.Cells(5).Value = filteredRows(i).Item(12)

                DataGridView1.Rows.Add(row)
            Next

            labelTotalPemasukan.Text = FormatCurrency(totalPemasukan)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try
    End Sub

    Private Sub comboBoxYears_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxYears.SelectedIndexChanged
        If comboBoxYears.SelectedItem IsNot Nothing Then
            Dim selectedYear As Integer = Convert.ToInt32(comboBoxYears.SelectedItem)
            DisplayTransactionsByYear(selectedYear)
        End If
    End Sub

    Private Sub LoadYearsIntoComboBox()
        Try
            connect()

            ' Query untuk mengambil semua tahun dari tanggal transaksi
            Dim query As String = "SELECT DISTINCT YEAR(STR_TO_DATE(tanggal_transaksi, '%Y-%m-%d')) AS Tahun FROM tb_transaksi ORDER BY Tahun DESC"
            DA = New MySqlDataAdapter(query, Koneksi)
            DT = New DataTable
            DA.Fill(DT)

            ' Mengisi comboBoxYears dengan tahun-tahun
            comboBoxYears.Items.Clear()
            For Each row As DataRow In DT.Rows
                comboBoxYears.Items.Add(row("Tahun"))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try
    End Sub

    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.RowHeadersVisible = False
        LoadYearsIntoComboBox()
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles DataGridView1.SelectionChanged
        DataGridView1.ClearSelection()
    End Sub
End Class