Imports MySql.Data.MySqlClient
Public Class FormOpenTableDurasi

    Sub tampilmeja()
        connect()

        DA = New MySqlDataAdapter("SELECT * FROM tb_meja", Koneksi)
        DT = New DataTable
        DA.Fill(DT)
        For i = 0 To DT.Rows.Count - 1
            dropdownPilihTable.Items.Add(DT.Rows(i).Item(1))
        Next
        dropdownPilihTable.Text = DT.Rows(0).Item(1)

        disconnect()
    End Sub
    Sub tampilpaket()
        connect()

        DA = New MySqlDataAdapter("SELECT * FROM tb_daftarpaket WHERE jenis_paket='DURASI'", Koneksi)
        DT = New DataTable
        DA.Fill(DT)
        DataGridView1.Rows.Clear()

        For i = 0 To DT.Rows.Count - 1
            DataGridView1.Rows.Add(DT.Rows(i).Item(1))
            DataGridView1.Rows(i).Cells(1).Value = DT.Rows(i).Item(4)
            DataGridView1.Rows(i).Cells(2).Value = DT.Rows(i).Item(5)
            DataGridView1.Rows(i).Cells(3).Value = DT.Rows(i).Item(6)
            DataGridView1.Rows(i).Cells(4).Value = DT.Rows(i).Item(7)
            DataGridView1.Rows(i).Cells(5).Value = DT.Rows(i).Item(8)
            DataGridView1.Rows(i).Cells(6).Value = DT.Rows(i).Item(9)
        Next

        disconnect()
    End Sub

    Sub getNoOrder()
        Dim random As New Random()
        Dim angkaAcak As Integer = random.Next(100000, 1000000)
        Dim angkaAcakString As String = angkaAcak.ToString()

        Dim sekarang As DateTime = DateTime.Now
        Dim tanggal As String = sekarang.ToString("yyyyMMdd")

        Dim noOrder As String = tanggal & angkaAcakString

        LabelNoOrder.Text = noOrder
    End Sub

    Private Sub btnFixOrder_Click(sender As Object, e As EventArgs) Handles btnFixOrder.Click
        Close()

    End Sub

    Private Sub FormOpenTableDurasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilmeja()
        tampilpaket()
        getNoOrder()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim timeAkhirHargaSiang As String = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
        Dim timeAkhirHargaMalam As String = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()
        labelPaket.Text = CType(DataGridView1.Rows(e.RowIndex).Cells(0).Value, String)
        labelHargaSiang.Text = CType(DataGridView1.Rows(e.RowIndex).Cells(1).Value, String)
        labelisihargamalam.Text = CType(DataGridView1.Rows(e.RowIndex).Cells(2).Value, String)
        labelAkhirHargaSiang.Text = timeAkhirHargaSiang
        labelAkhirHargaMalam.Text = timeAkhirHargaMalam
    End Sub
End Class