Imports MySql.Data.MySqlClient

Public Class FormTransaksi
    Dim totalDurasi As Integer = 0
    Public Sub tampilTransaksiBilling()
        Dim tanggal_transaksi As String = Date.Now.ToString("yyyy-MM-dd")
        Dim totalPemasukan = 0
        Try
            connect()
            DA = New MySqlDataAdapter("SELECT * FROM tb_transaksi WHERE tanggal_transaksi='" & tanggal_transaksi & "'", Koneksi)
            DT = New DataTable
            DA.Fill(DT)
            DataGridView1.Rows.Clear()

            For i = 0 To DT.Rows.Count - 1
                totalDurasi = Convert.ToInt32(DT.Rows(i).Item(9)) + Convert.ToInt32(DT.Rows(i).Item(10))
                totalPemasukan += Convert.ToInt32(DT.Rows(i).Item(7))

                Dim row As DataGridViewRow = New DataGridViewRow()
                row.CreateCells(DataGridView1)

                row.Cells(0).Value = i + 1
                row.Cells(1).Value = DT.Rows(i).Item(0)
                row.Cells(2).Value = totalDurasi
                row.Cells(3).Value = DT.Rows(i).Item(7)
                row.Cells(4).Value = DT.Rows(i).Item(11)

                DataGridView1.Rows.Add(row)
            Next

            labelPemasukanBilling.Text = FormatCurrency(totalPemasukan)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try
    End Sub

    Private Sub tampilTransaksiFnB()
        Dim tanggal_transaksi As String = Date.Now.ToString("yyyy-MM-dd")
        Dim totalPemasukan = 0
        Try

            connect()
            DA = New MySqlDataAdapter("SELECT no_order, GROUP_CONCAT(nama_menu ORDER BY nama_menu SEPARATOR ', ') AS nama_menus, GROUP_CONCAT(qty_menu ORDER BY qty_menu SEPARATOR ', ') AS qty_menus, SUM(subtotal) AS total_price, metode_pembayaran FROM tb_fnb_transaksi WHERE tanggal_transaksi='" & tanggal_transaksi & "' GROUP BY  no_order;", Koneksi)
            DT = New DataTable
            DA.Fill(DT)
            DataGridView2.Rows.Clear()
            Debug.WriteLine(DT)
            Debug.WriteLine(DT.Rows.Count)

            For i = 0 To DT.Rows.Count - 1
                totalPemasukan += Convert.ToInt32(DT.Rows(i).Item("total_price"))

                Dim row As DataGridViewRow = New DataGridViewRow()
                row.CreateCells(DataGridView2)

                row.Cells(0).Value = i + 1
                row.Cells(1).Value = DT.Rows(i).Item("no_order")
                row.Cells(2).Value = DT.Rows(i).Item("nama_menus")
                row.Cells(3).Value = DT.Rows(i).Item("qty_menus")
                row.Cells(4).Value = DT.Rows(i).Item("total_price")
                row.Cells(5).Value = DT.Rows(i).Item("metode_pembayaran")


                DataGridView2.Rows.Add(row)


            Next

            DataGridView2.Columns(2).DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DataGridView2.Columns(2).Width = 200
            DataGridView2.Columns(3).DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DataGridView2.Columns(3).Width = 75
            DataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            labelPemasukanFnB.Text = FormatCurrency(totalPemasukan)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try
    End Sub


    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilTransaksiBilling()
        tampilTransaksiFnB()
    End Sub

    Private Sub tpBilling_Click(sender As Object, e As EventArgs) Handles tpBilling.Click
        tampilTransaksiBilling()
    End Sub

    Private Sub tpFnB_Click(sender As Object, e As EventArgs) Handles tpFnB.Click
        tampilTransaksiFnB()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name

            If colName = "Column4" Then
                If MsgBox("Are you sure you want to print this bill?", vbYesNo + vbQuestion, "Print Bill") = vbYes Then
                    Try
                        'print bill


                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message, vbCritical, "Deletion Error")
                    Finally
                        conn.Close()  ' Ensure the connection is closed
                    End Try

                    ' Reload data after deletion
                    ' Ensure this method works correctly
                End If
            End If

        Catch ex As Exception
            conn.Close()
            MsgBox("Warning: " & ex.Message, vbCritical, "Operation Error")
        End Try
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Try
            Dim colName As String = DataGridView2.Columns(e.ColumnIndex).Name

            If colName = "Column2" Then
                If MsgBox("Are you sure you want to print this bill?", vbYesNo + vbQuestion, "Print Bill") = vbYes Then
                    Try
                        'print bill


                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message, vbCritical, "Deletion Error")
                    Finally
                        conn.Close()  ' Ensure the connection is closed
                    End Try

                    ' Reload data after deletion
                    ' Ensure this method works correctly
                End If
            End If

        Catch ex As Exception
            conn.Close()
            MsgBox("Warning: " & ex.Message, vbCritical, "Operation Error")
        End Try
    End Sub
End Class