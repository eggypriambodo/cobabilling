Imports MySql.Data.MySqlClient

Public Class FormTransaksi

    Public Sub tampilTransaksi()
        Try
            connect()
            DA = New MySqlDataAdapter("SELECT * FROM tb_transaksi", Koneksi)
            DT = New DataTable
            DA.Fill(DT)
            DataGridView1.Rows.Clear()

            For i = 0 To DT.Rows.Count - 1
                DataGridView1.Rows.Add(DT.Rows(i).Item(0))
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
End Class