Imports MySql.Data.MySqlClient
Public Class FormAddPaket
    Private previousForm As FormPengaturan
    Private Sub btnTambahPaket_Click(sender As Object, e As EventArgs) Handles btnTambahPaket.Click
        If ValidateInputs() Then
            tambahPaket()
            Close()
            previousForm.Instance.RefreshData()
        Else
            MessageBox.Show("Pastikan semua kolom terisi dengan benar!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        Dim allInputsValid As Boolean = True

        ' Validasi setiap TextBox
        allInputsValid = allInputsValid And ValidateTextBox(tbNamaPaket)
        allInputsValid = allInputsValid And ValidateTextBox(tbHarga)
        allInputsValid = allInputsValid And ValidateTextBox(tbDurasi)
        allInputsValid = allInputsValid And ValidateTextBox(tbDiscTable)

        Return allInputsValid
    End Function

    Private Function ValidateTextBox(textBox As TextBox) As Boolean
        If String.IsNullOrWhiteSpace(textBox.Text) Then
            Return False
        End If
        Return True
    End Function

    Sub tambahPaket()
        Try
            connect()
            CMD = New MySqlCommand("INSERT INTO tb_daftarpaket (nama_paket, jenis_paket, harga_paket, durasi, disc_table) VALUES (@nama_paket, 'PAKET', @harga_paket, @durasi, @disc_table)", Koneksi)
            ' Ganti @value1, @value2, @value3 dengan nama kolom yang sesuai
            CMD.Parameters.AddWithValue("@nama_paket", tbNamaPaket.Text)
            CMD.Parameters.AddWithValue("@harga_paket", Convert.ToInt32(tbHarga.Text))
            CMD.Parameters.AddWithValue("@durasi", Convert.ToInt32(tbDurasi.Text))
            CMD.Parameters.AddWithValue("@disc_table", Convert.ToInt32(tbDiscTable.Text))
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            disconnect()

        End Try
    End Sub

    Sub tampilpaket()
        Try
            connect()

            DA = New MySqlDataAdapter("SELECT * FROM tb_daftarpaket WHERE jenis_paket='PAKET'", Koneksi)
            DT = New DataTable
            DA.Fill(DT)
            DataGridView1.Rows.Clear()

            For i = 0 To DT.Rows.Count - 1
                DataGridView1.Rows.Add(DT.Rows(i).Item(1))
                DataGridView1.Rows(i).Cells(1).Value = DT.Rows(i).Item(3)
                DataGridView1.Rows(i).Cells(2).Value = DT.Rows(i).Item(10)
                DataGridView1.Rows(i).Cells(3).Value = DT.Rows(i).Item(8)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            disconnect()
        End Try
    End Sub

    Private Sub FormAddPaket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilpaket()
    End Sub
End Class