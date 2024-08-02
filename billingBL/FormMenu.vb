Imports MySql.Data.MySqlClient

Public Class FormMenu

    Sub tampilmenu()
        connect()

        DA = New MySqlDataAdapter("SELECT * FROM tb_fnb", Koneksi)
        DT = New DataTable
        DA.Fill(DT)
        DataGridView1.Rows.Clear()

        For i = 0 To DT.Rows.Count - 1
            DataGridView1.Rows.Add(DT.Rows(i).Item(1))
            DataGridView1.Rows(i).Cells(1).Value = DT.Rows(i).Item(3)
        Next

        disconnect()
    End Sub

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilmenu()
    End Sub

End Class