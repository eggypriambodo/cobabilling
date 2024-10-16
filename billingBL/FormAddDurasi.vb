Imports MySql.Data.MySqlClient

Public Class FormAddDurasi
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
        allInputsValid = allInputsValid And ValidateTextBox(tbHargaSiang)
        allInputsValid = allInputsValid And ValidateTextBox(tbHargaMalam)
        allInputsValid = allInputsValid And cbAkhirSiang.Text <> ""
        allInputsValid = allInputsValid And cbAkhirMalam.Text <> ""
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
        Dim akhir_siang As TimeSpan
        Dim akhir_malam As TimeSpan
        If cbAkhirSiang.Text = "24" Then
            akhir_siang = TimeSpan.FromHours(0)

        Else
            akhir_siang = TimeSpan.FromHours(Convert.ToDouble(cbAkhirSiang.Text))
        End If

        If cbAkhirMalam.Text = "24" Then
            akhir_malam = TimeSpan.FromHours(0)

        Else
            akhir_malam = TimeSpan.FromHours(Convert.ToDouble(cbAkhirMalam.Text))
        End If

        Try
            connect()

            CMD = New MySqlCommand("INSERT INTO tb_daftarpaket (nama_paket, jenis_paket, harga_siang, harga_malam, akhir_siang, akhir_malam, disc_table) VALUES (@nama_paket, 'DURASI', @harga_siang, @harga_malam, @akhir_siang, @akhir_malam, @disc_table)", Koneksi)
            ' Ganti @value1, @value2, @value3 dengan nama kolom yang sesuai
            CMD.Parameters.AddWithValue("@nama_paket", tbNamaPaket.Text)
            CMD.Parameters.AddWithValue("@harga_siang", Convert.ToInt32(tbHargaSiang.Text))
            CMD.Parameters.AddWithValue("@harga_malam", Convert.ToInt32(tbHargaMalam.Text))
            CMD.Parameters.AddWithValue("@akhir_siang", akhir_siang)
            CMD.Parameters.AddWithValue("@akhir_malam", akhir_malam)
            CMD.Parameters.AddWithValue("@disc_table", Convert.ToInt32(tbDiscTable.Text))
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message + "Ini Error")
        Finally

            disconnect()
        End Try
    End Sub

    Sub loadJamAkhirSiang()
        cbAkhirSiang.Items.Clear()
        For i = 0 To 23
            cbAkhirSiang.Items.Add(i + 1)
        Next
    End Sub

    Sub loadJamAkhirMalam()
        cbAkhirMalam.Items.Clear()
        For i = 0 To 23
            cbAkhirMalam.Items.Add(i + 1)
        Next
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

    Private Sub FormAddDurasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadJamAkhirSiang()
        loadJamAkhirMalam()
        tampilpaket()
    End Sub


End Class