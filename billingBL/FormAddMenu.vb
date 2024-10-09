Imports MySql.Data.MySqlClient

Public Class FormAddMenu
    Private Sub FormAddMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Try
            Dim colName = DataGridView4.Columns(e.ColumnIndex).Name
            If colName = "Column4" Then
                If MsgBox("Are you sure you want to Delete this Order?", vbYesNo + vbQuestion) = vbYes Then
                    conn.Open()
                    Dim cmd As New MySqlCommand("DELETE FROM `tb_fnb` WHERE `nama_fnb`= '" & DataGridView4.CurrentRow.Cells(1).Value & "'", conn)
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    MsgBox("Order has been successfully Deleted.", vbInformation)
                End If
            End If
        Catch ex As Exception
            conn.Close()
            MsgBox("Warning: " & ex.Message, vbCritical)
        End Try
        Load_cancelOrder()
    End Sub

    Sub Load_cancelOrder()
        DataGridView4.Rows.Clear()
        Try
            conn.Open()
            'CMD = New MySqlCommand("SELECT `transno`, `transdate`, `transmonth`, `foodcode`, `foodname`, `price`, `qty`, `totalprice`, `grandtotal`, `nooffoods` FROM `tbl_pos` GROUP BY transno", conn)
            DR = CMD.ExecuteReader
            While DR.Read
                DataGridView4.Rows.Add(DataGridView4.Rows.Count + 1, DR.Item("transdate"), DR.Item("transno"), DR.Item("grandtotal"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
End Class