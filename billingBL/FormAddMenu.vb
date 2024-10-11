Imports MySql.Data.MySqlClient

Public Class FormAddMenu
    Private Sub FormAddMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        DataGridView1.RowTemplate.Height = 30
        Load_fooddata()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Try
            Dim colName = DataGridView1.Columns(e.ColumnIndex).Name
            If colName = "Column2" Then
                If MsgBox("Are you sure you want to Delete this Menu?", vbYesNo + vbQuestion) = vbYes Then
                    conn.Open()
                    Dim cmd As New MySqlCommand("DELETE FROM `tb_fnb` WHERE `nama_fnb`= '" & DataGridView1.CurrentRow.Cells(1).Value & "'", conn)
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

    Sub Load_fooddata()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            CMD = New MySqlCommand("SELECT `nama_fnb`, `harga_fnb` FROM `tb_fnb`", conn)
            DR = CMD.ExecuteReader
            While DR.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count, DR.Item("nama_fnb"), DR.Item("harga_fnb"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub picFoodImg_Click(sender As Object, e As EventArgs) Handles picFoodImg.Click
        Dim pop As OpenFileDialog = New OpenFileDialog
        If pop.ShowDialog <> DialogResult.Cancel Then
            picFoodImg.Image = Image.FromFile(pop.FileName)
        End If
    End Sub

    Sub clear()
        tbNamaMenu.Clear()
        tbHargaMenu.Clear()
        picFoodImg.Image = Nothing
    End Sub

    Sub Load_cancelOrder()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            CMD = New MySqlCommand("SELECT `nama_fnb`, `harga_fnb`, `image_fnb` FROM `tb_fnb` GROUP BY nama_fnb", conn)
            DR = CMD.ExecuteReader
            While DR.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count, DR.Item("nama_fnb"), DR.Item("harga_fnb"), DR.Item("image_fnb"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btnAddMenu_Click(sender As Object, e As EventArgs) Handles btnAddMenu.Click
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `tb_fnb`(`nama_fnb`, `harga_fnb`, `image_fnb`) VALUES (@nama_fnb, @harga_fnb, @image_fnb)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@nama_fnb", tbNamaMenu.Text)
            cmd.Parameters.AddWithValue("@harga_fnb", tbHargaMenu.Text)
            Dim FileSize As New UInt32
            Dim mstream As New System.IO.MemoryStream
            picFoodImg.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim picture() As Byte = mstream.GetBuffer
            FileSize = mstream.Length
            mstream.Close()
            cmd.Parameters.AddWithValue("@image_fnb", picture)

            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New Food Save Successfully !", vbInformation, "FAST FOOD")
            Else
                MsgBox("Warning : Food Save Failed !", vbCritical, "FAST FOOD")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        clear()
        Load_fooddata()
        FormFnB.Load_Foods()
    End Sub
End Class