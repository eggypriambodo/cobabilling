﻿Imports MySql.Data.MySqlClient

Public Class FormOpenTablePaket
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

    Sub getNoOrder()
        Dim random As New Random()
        Dim angkaAcak As Integer = random.Next(100000, 1000000)
        Dim angkaAcakString As String = angkaAcak.ToString()

        Dim sekarang As DateTime = DateTime.Now
        Dim tanggal As String = sekarang.ToString("yyyyMMdd")

        Dim noOrder As String = tanggal & angkaAcakString

        labelNoOrder.Text = noOrder
    End Sub

    Private Sub FormOpenTablePaket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilmeja()
        tampilpaket()
        getNoOrder()
    End Sub

    Sub inputOrder()
        Dim mulai As DateTime = DateTime.Now
        Dim mulaiString As String = mulai.ToString("HH:mm:ss")
        'Dim durasi As TimeSpan = New TimeSpan(Convert.ToInt32(textboxDurasiMain.Text), 0, 0)
        Dim selesai As DateTime = mulai.AddHours(Convert.ToDouble(labelDurasiPaket.Text))
        Dim selesaiString As String = selesai.ToString("HH:mm:ss")
        Dim harga As Integer = Integer.Parse(labelHargaPaket.Text)
        Dim durasiMain As Integer = Integer.Parse(labelDurasiPaket.Text) * 60
        Dim jenisPaket As String = "PAKET"

        Try
            connect()
            CMD = New MySqlCommand("INSERT INTO tb_detailbilling (no_order, nama_tamu, paket, no_meja, mulai, selesai, durasi, harga, disc_table, durasi_siang, jenis_paket) VALUES ('" & labelNoOrder.Text & "', '" & textboxNamaTamu.Text & "', '" & labelPaket.Text & "', '" & dropdownPilihTable.Text & "', '" & mulaiString & "', '" & selesaiString & "', '" & Convert.ToInt32(labelDurasiPaket.Text) & "', '" & harga & "', '" & Convert.ToInt32(labelDiskonPaket.Text) & "', '" & durasiMain & "', '" & jenisPaket & "')", Koneksi)
            CMD.ExecuteNonQuery()

            Dim input As String = dropdownPilihTable.Text
            Dim parts() As String = input.Split(" "c)
            Dim onMeja As String = parts(1) + "1"
            FormBilling.InitializeAndSendData(onMeja)
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        labelPaket.Text = CType(DataGridView1.Rows(e.RowIndex).Cells(0).Value, String)
        labelHargaPaket.Text = CType(DataGridView1.Rows(e.RowIndex).Cells(1).Value, String)
        labelDurasiPaket.Text = CType(DataGridView1.Rows(e.RowIndex).Cells(2).Value, String)
        labelDiskonPaket.Text = CType(DataGridView1.Rows(e.RowIndex).Cells(3).Value, String)

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
        allInputsValid = allInputsValid And dropdownPilihTable.Text <> ""
        allInputsValid = allInputsValid And labelPaket.Text <> "-;-;-"

        Return allInputsValid
    End Function
End Class