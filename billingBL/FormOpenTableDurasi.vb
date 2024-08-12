Imports MySql.Data.MySqlClient
Public Class FormOpenTableDurasi
    Private Form As FormBilling

    Sub tampilmeja()
        Try
            connect()
            DA = New MySqlDataAdapter("SELECT * FROM tb_meja WHERE status='kosong'", Koneksi)
            DT = New DataTable
            DA.Fill(DT)
            For i = 0 To DT.Rows.Count - 1
                dropdownPilihTable.Items.Add(DT.Rows(i).Item(1))
            Next
            dropdownPilihTable.Text = DT.Rows(0).Item(1)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            disconnect()

        End Try
    End Sub
    Sub tampilpaket()
        Try
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
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            disconnect()
        End Try

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

    Sub inputOrder()
        Dim mulai As DateTime = DateTime.Now
        Dim mulaiString As String = mulai.ToString("HH:mm:ss")
        'Dim durasi As TimeSpan = New TimeSpan(Convert.ToInt32(textboxDurasiMain.Text), 0, 0)
        Dim selesai As DateTime = mulai.AddHours(Convert.ToDouble(textboxDurasiMain.Text))
        Dim selesaiString As String = selesai.ToString("HH:mm:ss")
        Dim harga As Integer = 0
        Dim selisihmulaiInt As Integer = 0
        Dim selisihselesaiInt As Integer = 0
        Dim hargaSiang As Integer = 0
        Dim hargaMalam As Integer = 0
        Dim akhirWaktuSiangString As String = labelAkhirHargaSiang.Text
        Dim akhirWaktuSiang As DateTime = DateTime.Parse(akhirWaktuSiangString)
        Dim akhirWaktuMalamString As String = labelAkhirHargaMalam.Text
        Dim akhirWaktuMalam As DateTime = DateTime.Parse(akhirWaktuMalamString)

        If mulai.Hour >= akhirWaktuMalam.Hour AndAlso mulai.Hour < akhirWaktuSiang.Hour Then
            If selesai.Hour >= akhirWaktuSiang.Hour Then
                Dim bataswaktu As New TimeSpan(akhirWaktuSiang.Hour, 0, 0)
                Dim waktumulai As TimeSpan = TimeSpan.Parse(mulaiString)
                Dim selisihmulai As TimeSpan = bataswaktu - waktumulai
                selisihmulaiInt = selisihmulai.TotalMinutes
                hargaSiang = Integer.Parse(labelHargaSiang.Text)
                Dim hargaSelisihMulai As Integer = (hargaSiang / 60) * selisihmulaiInt

                Dim waktuselesai As TimeSpan = TimeSpan.Parse(selesaiString)
                Dim selisihselesai As TimeSpan = waktuselesai - bataswaktu
                selisihselesaiInt = selisihselesai.TotalMinutes
                hargaMalam = Integer.Parse(labelisihargamalam.Text)
                Dim hargaSelisihSelesai As Integer = (hargaMalam / 60) * selisihselesaiInt

                harga = hargaSelisihMulai + hargaSelisihSelesai
            ElseIf selesai.Hour < akhirWaktuSiang.Hour Then
                hargaSiang = Integer.Parse(labelHargaSiang.Text)
                Dim durasiMain As Integer = Integer.Parse(textboxDurasiMain.Text)
                selisihmulaiInt = durasiMain * 60
                harga = hargaSiang * durasiMain
            End If
        ElseIf mulai.Hour >= akhirWaktuSiang.Hour OrElse mulai.Hour < akhirWaktuMalam.Hour Then
            hargaMalam = Integer.Parse(labelisihargamalam.Text)
            Dim durasiMain As Integer = Integer.Parse(textboxDurasiMain.Text)
            selisihselesaiInt = durasiMain * 60
            harga = hargaMalam * durasiMain
        End If
        Console.WriteLine("Harga: " & harga)
        Try
            connect()
            CMD = New MySqlCommand("INSERT INTO tb_detailbilling (no_order, nama_tamu, paket, no_meja, mulai, selesai, durasi, harga, disc_table, durasi_siang, durasi_malam, harga_siang, harga_malam) VALUES ('" & LabelNoOrder.Text & "', '" & textboxNamaTamu.Text & "', '" & labelPaket.Text & "', '" & dropdownPilihTable.Text & "', '" & mulaiString & "', '" & selesaiString & "', '" & Convert.ToInt32(textboxDurasiMain.Text) & "', '" & harga & "', '" & Convert.ToInt32(labelDiskonDurasi.Text) & "', '" & selisihmulaiInt & "', '" & selisihselesaiInt & "', '" & hargaSiang & "', '" & hargaMalam & "')", Koneksi)
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            disconnect()
        End Try
    End Sub

    Sub updateMeja()
        Try
            connect()
            CMD = New MySqlCommand("UPDATE tb_meja SET status='isi' WHERE nama_meja='" & dropdownPilihTable.Text & "'", Koneksi)
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            disconnect()
        End Try
    End Sub

    Private Sub btnFixOrder_Click(sender As Object, e As EventArgs) Handles btnFixOrder.Click
        If ValidateInputs() Then
            inputOrder()
            updateMeja()
            FormBilling.Instance.ubahStatusMeja()
            Close()
        Else
            MessageBox.Show("Pastikan semua kolom terisi dengan benar!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub


    Private Sub FormOpenTableDurasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilmeja()
        tampilpaket()
        getNoOrder()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim akhirSiangString As String = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
        Dim akhirMalamString As String = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
        labelPaket.Text = CType(DataGridView1.Rows(e.RowIndex).Cells(0).Value, String)
        labelHargaSiang.Text = CType(DataGridView1.Rows(e.RowIndex).Cells(1).Value, String)
        labelisihargamalam.Text = CType(DataGridView1.Rows(e.RowIndex).Cells(2).Value, String)
        labelAkhirHargaSiang.Text = akhirSiangString
        labelAkhirHargaMalam.Text = akhirMalamString
        labelDiskonDurasi.Text = CType(DataGridView1.Rows(e.RowIndex).Cells(5).Value, String)
    End Sub

    Private Function ValidateTextBox(textBox As TextBox) As Boolean
        If String.IsNullOrWhiteSpace(textBox.Text) Then
            Return False
        End If
        Return True
    End Function

    Private Function ValidateInputs() As Boolean
        Dim allInputsValid As Boolean = True

        ' Validasi setiap TextBox
        allInputsValid = allInputsValid And ValidateTextBox(textboxNamaTamu)
        allInputsValid = allInputsValid And ValidateTextBox(textboxDurasiMain)
        allInputsValid = allInputsValid And dropdownPilihTable.Text <> ""
        allInputsValid = allInputsValid And labelPaket.Text <> "-;-;-"

        Return allInputsValid
    End Function

End Class