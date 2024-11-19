Imports MySql.Data.MySqlClient

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

                DataGridView1.Rows.Add(row)
            Next

            labelPemasukanBilling.Text = FormatCurrency(totalPemasukan)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try
    End Sub

    Public Sub TampilTransaksiFnb()
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

                DataGridView1.Rows.Add(row)
            Next

            labelPemasukanBilling.Text = FormatCurrency(totalPemasukan)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try
    End Sub

    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilTransaksiBilling()
    End Sub

End Class