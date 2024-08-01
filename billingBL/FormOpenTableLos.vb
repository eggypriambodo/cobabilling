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
    Private Sub FormOpenTableLos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilmeja()
    End Sub
End Class