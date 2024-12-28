Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class FormPengaturan
    Public Shared Instance As FormPengaturan
    Dim selectedRowName As String
    Sub tampilpaketPromo()
        Try
            connect()

            DA = New MySqlDataAdapter("SELECT * FROM tb_daftarpaket WHERE jenis_paket='PAKET'", Koneksi)
            DT = New DataTable
            DA.Fill(DT)
            DataGridView2.Rows.Clear()

            For i = 0 To DT.Rows.Count - 1
                DataGridView2.Rows.Add(DT.Rows(i).Item(1))
                DataGridView2.Rows(i).Cells(1).Value = DT.Rows(i).Item(3)
                DataGridView2.Rows(i).Cells(2).Value = DT.Rows(i).Item(10)
                DataGridView2.Rows(i).Cells(3).Value = DT.Rows(i).Item(8)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            disconnect()
        End Try
    End Sub

    Sub tampilpaketDurasi()
        Try
            connect()

            DA = New MySqlDataAdapter("SELECT * FROM tb_daftarpaket WHERE jenis_paket='DURASI'", Koneksi)
            DT = New DataTable
            DA.Fill(DT)
            DataGridView4.Rows.Clear()

            For i = 0 To DT.Rows.Count - 1
                DataGridView4.Rows.Add(DT.Rows(i).Item(1))
                DataGridView4.Rows(i).Cells(1).Value = DT.Rows(i).Item(4)
                DataGridView4.Rows(i).Cells(2).Value = DT.Rows(i).Item(5)
                DataGridView4.Rows(i).Cells(3).Value = DT.Rows(i).Item(6)
                DataGridView4.Rows(i).Cells(4).Value = DT.Rows(i).Item(7)
                DataGridView4.Rows(i).Cells(5).Value = DT.Rows(i).Item(8)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            disconnect()
        End Try

    End Sub

    Sub tampilpaketLos()
        connect()

        DA = New MySqlDataAdapter("SELECT * FROM tb_daftarpaket WHERE jenis_paket='LOSTIME'", Koneksi)
        DT = New DataTable
        DA.Fill(DT)
        DataGridView3.Rows.Clear()

        For i = 0 To DT.Rows.Count - 1
            DataGridView3.Rows.Add(DT.Rows(i).Item(1))
            DataGridView3.Rows(i).Cells(1).Value = DT.Rows(i).Item(4)
            DataGridView3.Rows(i).Cells(2).Value = DT.Rows(i).Item(5)
            DataGridView3.Rows(i).Cells(3).Value = DT.Rows(i).Item(6)
            DataGridView3.Rows(i).Cells(4).Value = DT.Rows(i).Item(7)
            DataGridView3.Rows(i).Cells(5).Value = DT.Rows(i).Item(8)
        Next

        disconnect()
    End Sub

    Sub tampilUser()
        connect()

        DA = New MySqlDataAdapter("SELECT * FROM tb_shift", Koneksi)
        DT = New DataTable
        DA.Fill(DT)
        DataGridView1.Rows.Clear()

        For i = 0 To DT.Rows.Count - 1
            DataGridView1.Rows.Add(DT.Rows(i).Item(0))
            DataGridView1.Rows(i).Cells(1).Value = DT.Rows(i).Item(1)
        Next

        disconnect()
    End Sub

    Private Sub btnTambahPromo_Click(sender As Object, e As EventArgs) Handles btnTambahPromo.Click
        FormAddPaket.Show()
    End Sub

    Private Sub btnTambahLos_Click(sender As Object, e As EventArgs) Handles btnTambahLos.Click
        FormAddLosTime.Show()
    End Sub

    Private Sub btnTambahDurasi_Click(sender As Object, e As EventArgs) Handles btnTambahDurasi.Click
        FormAddDurasi.Show()
    End Sub

    Private Sub FormPengaturan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Instance = Me
        tampilpaketDurasi()
        tampilpaketLos()
        tampilpaketPromo()
        tampilUser()
        btnHapusDurasi.Enabled = False
        btnHapusLos.Enabled = False
        btnHapusPromo.Enabled = False
        btnHapusUser.Enabled = False
    End Sub

    Public Sub RefreshData()
        tampilpaketDurasi()
        tampilpaketLos()
        tampilpaketPromo()
        tampilUser()
        btnHapusUser.Enabled = False
        btnHapusDurasi.Enabled = False
        btnHapusLos.Enabled = False
        btnHapusPromo.Enabled = False
        MessageBox.Show("Data Berhasil Diinput")
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        If e.RowIndex >= 0 Then
            btnHapusPromo.Enabled = True
            selectedRowName = CType(DataGridView2.Rows(e.RowIndex).Cells(0).Value, String)
        End If


    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        If e.RowIndex >= 0 Then
            btnHapusLos.Enabled = True
            selectedRowName = CType(DataGridView3.Rows(e.RowIndex).Cells(0).Value, String)
        End If
    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick
        If e.RowIndex >= 0 Then
            btnHapusDurasi.Enabled = True
            selectedRowName = CType(DataGridView4.Rows(e.RowIndex).Cells(0).Value, String)
        End If
    End Sub

    Private Sub btnHapusPromo_Click(sender As Object, e As EventArgs) Handles btnHapusPromo.Click
        If selectedRowName <> "" Then
            For Each row As DataGridViewRow In DataGridView2.Rows
                If CType(row.Cells(0).Value, String) = selectedRowName Then
                    DataGridView2.Rows.Remove(row)
                    Exit For
                End If
            Next

            Try
                connect()
                CMD = New MySqlCommand("DELETE FROM tb_daftarpaket WHERE nama_paket = @nama_paket", Koneksi)
                CMD.Parameters.AddWithValue("@nama_paket", selectedRowName)
                CMD.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                disconnect()
            End Try
            selectedRowName = ""
        Else
            MessageBox.Show("Data yang dipilih tidak ada", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnHapusLos_Click(sender As Object, e As EventArgs) Handles btnHapusLos.Click
        If selectedRowName <> "" Then
            For Each row As DataGridViewRow In DataGridView3.Rows
                If CType(row.Cells(0).Value, String) = selectedRowName Then
                    DataGridView3.Rows.Remove(row)
                    Exit For
                End If
            Next

            Try
                connect()
                CMD = New MySqlCommand("DELETE FROM tb_daftarpaket WHERE nama_paket = @nama_paket", Koneksi)
                CMD.Parameters.AddWithValue("@nama_paket", selectedRowName)
                CMD.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                disconnect()
            End Try
            selectedRowName = ""
        Else
            MessageBox.Show("Data yang dipilih tidak ada", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnHapusDurasi_Click(sender As Object, e As EventArgs) Handles btnHapusDurasi.Click
        If selectedRowName <> "" Then
            For Each row As DataGridViewRow In DataGridView4.Rows
                If CType(row.Cells(0).Value, String) = selectedRowName Then
                    DataGridView4.Rows.Remove(row)
                    Exit For
                End If
            Next

            Try
                connect()
                CMD = New MySqlCommand("DELETE FROM tb_daftarpaket WHERE nama_paket = @nama_paket", Koneksi)
                CMD.Parameters.AddWithValue("@nama_paket", selectedRowName)
                CMD.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                disconnect()
            End Try
            selectedRowName = ""
        Else
            MessageBox.Show("Data yang dipilih tidak ada", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnTambahUser_Click(sender As Object, e As EventArgs) Handles btnTambahUser.Click
        FormAddUser.Show()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            btnHapusUser.Enabled = True
            selectedRowName = CType(DataGridView1.Rows(e.RowIndex).Cells(0).Value, String)
        End If
    End Sub

    Private Sub btnHapusUser_Click(sender As Object, e As EventArgs) Handles btnHapusUser.Click
        If selectedRowName <> "" Then
            For Each row As DataGridViewRow In DataGridView1.Rows
                If CType(row.Cells(0).Value, String) = selectedRowName Then
                    DataGridView1.Rows.Remove(row)
                    Exit For
                End If
            Next

            Try
                connect()
                CMD = New MySqlCommand("DELETE FROM tb_shift WHERE nama = @nama", Koneksi)
                CMD.Parameters.AddWithValue("@nama", selectedRowName)
                CMD.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                disconnect()
            End Try
            selectedRowName = ""
        Else
            MessageBox.Show("Data yang dipilih tidak ada", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class