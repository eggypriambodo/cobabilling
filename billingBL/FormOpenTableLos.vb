Imports MySql.Data.MySqlClient
Public Class FormOpenTableLos

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

        DA = New MySqlDataAdapter("SELECT * FROM tb_daftarpaket WHERE jenis_paket='LOSTIME'", Koneksi)
        DT = New DataTable
        DA.Fill(DT)
        DataGridView1.Rows.Clear()

        For i = 0 To DT.Rows.Count - 1
            DataGridView1.Rows.Add(DT.Rows(i).Item(1))
            DataGridView1.Rows(i).Cells(1).Value = CInt(DT.Rows(i).Item(5) / 60)
            DataGridView1.Rows(i).Cells(2).Value = DT.Rows(i).Item(8)
            DataGridView1.Rows(i).Cells(3).Value = DT.Rows(i).Item(9)
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

        labelNoOrder.Text = noOrder
    End Sub
    Private Sub FormOpenTableLos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilmeja()
        tampilpaket()
        getNoOrder()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        labelPaket.Text = CType(DataGridView1.Rows(e.RowIndex).Cells(0).Value, String)
        labelHargaMenit.Text = CType(DataGridView1.Rows(e.RowIndex).Cells(1).Value, String)
    End Sub
End Class