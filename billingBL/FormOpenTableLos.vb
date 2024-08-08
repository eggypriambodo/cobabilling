Imports MySql.Data.MySqlClient
Public Class FormOpenTableLos

    Sub tampilmeja()
        connect()

        DA = New MySqlDataAdapter("SELECT * FROM tb_meja WHERE status='kosong'", Koneksi)
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
            DataGridView1.Rows(i).Cells(1).Value = DT.Rows(i).Item(4)
            DataGridView1.Rows(i).Cells(2).Value = DT.Rows(i).Item(5)
            DataGridView1.Rows(i).Cells(3).Value = DT.Rows(i).Item(6)
            DataGridView1.Rows(i).Cells(4).Value = DT.Rows(i).Item(7)
            DataGridView1.Rows(i).Cells(5).Value = DT.Rows(i).Item(8)
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

        LabelNoOrderLos.Text = noOrder
    End Sub

    Sub inputOrder()
        Dim mulai As DateTime = DateTime.Now
        Dim mulaiString As String = mulai.ToString("HH:mm:ss")

        Try
            connect()
            CMD = New MySqlCommand("INSERT INTO tb_detailbilling (no_order, nama_tamu, paket, no_meja, mulai, disc_table) VALUES ('" & LabelNoOrderLos.Text & "', '" & textboxNamaTamu.Text & "', '" & labelPaketLos.Text & "', '" & dropdownPilihTable.Text & "', '" & mulaiString & "', '" & Convert.ToInt32(labelDiskonLos.Text) & "')", Koneksi)
            CMD.ExecuteNonQuery()
            disconnect()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub updateMeja()
        Try
            connect()
            CMD = New MySqlCommand("UPDATE tb_meja SET status='isi' WHERE nama_meja='" & dropdownPilihTable.Text & "'", Koneksi)
            CMD.ExecuteNonQuery()
            disconnect()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FormOpenTableLos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilmeja()
        tampilpaket()
        getNoOrder()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim akhirSiangString As String = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
        Dim akhirMalamString As String = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
        labelPaketLos.Text = CType(DataGridView1.Rows(e.RowIndex).Cells(0).Value, String)
        labelHargaSiangLos.Text = CType(DataGridView1.Rows(e.RowIndex).Cells(1).Value, String)
        labelisihargamalamLos.Text = CType(DataGridView1.Rows(e.RowIndex).Cells(2).Value, String)
        labelAkhirHargaSiangLos.Text = akhirSiangString
        labelAkhirHargaMalamLos.Text = akhirMalamString
        labelDiskonLos.Text = CType(DataGridView1.Rows(e.RowIndex).Cells(5).Value, String)
    End Sub

    Private Sub btnFixOrder_Click(sender As Object, e As EventArgs) Handles btnFixOrder.Click
        Dim allValid As Boolean = True
        allValid = TextBox_Validating(textboxNamaTamu, New System.ComponentModel.CancelEventArgs()) And allValid

        If String.IsNullOrEmpty(dropdownPilihTable.Text) Then
            MessageBox.Show("Pilih meja terlebih dahulu.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            allValid = False
        End If

        If String.IsNullOrEmpty(labelPaketLos.Text) OrElse labelPaketLos.Text = "-;-;-" Then
            MessageBox.Show("Pilih paket terlebih dahulu.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            allValid = False
        End If

        If allValid Then
            inputOrder()
            updateMeja()
            FormBilling.Instance.ubahStatusMeja()
            Close()
        End If
    End Sub

    Private Function TextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) As Boolean Handles textboxNamaTamu.Validating
        Dim textBox As TextBox = DirectCast(sender, TextBox)
        If String.IsNullOrWhiteSpace(textBox.Text) Then
            MessageBox.Show("Nama Tamu Harus Diisi", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True
            Return False
        End If
        Return True
    End Function
End Class