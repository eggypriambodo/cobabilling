Imports MySql.Data.MySqlClient
Imports System.IO
Public Class FormAddMenu
    Private Sub FormAddMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        dbconn()
        DataGridView1.RowTemplate.Height = 30
        Load_fooddata()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name

            If colName = "Column4" Then
                If MsgBox("Are you sure you want to delete this menu?", vbYesNo + vbQuestion, "Delete Menu") = vbYes Then
                    Try
                        conn.Open()
                        CMD = New MySqlCommand("DELETE FROM `tb_fnb` WHERE `nama_fnb`=@nama_fnb", conn)
                        CMD.Parameters.AddWithValue("@nama_fnb", DataGridView1.CurrentRow.Cells(1).Value)

                        Dim result As Integer = CMD.ExecuteNonQuery()

                        If result > 0 Then
                            MsgBox("Food deleted successfully!", vbInformation, "FAST FOOD")
                        Else
                            MsgBox("Warning: Food deletion failed!", vbCritical, "FAST FOOD")
                        End If

                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message, vbCritical, "Deletion Error")
                    Finally
                        conn.Close()  ' Ensure the connection is closed
                    End Try

                    ' Reload data after deletion
                    Load_fooddata()
                    FormFnB.Load_Foods()  ' Ensure this method works correctly
                End If
            End If

        Catch ex As Exception
            conn.Close()
            MsgBox("Warning: " & ex.Message, vbCritical, "Operation Error")
        End Try
    End Sub

    Sub Load_fooddata()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            CMD = New MySqlCommand("SELECT `nama_fnb`, `harga_fnb` FROM `tb_fnb`", conn)
            DR = CMD.ExecuteReader()
            While DR.Read()
                DataGridView1.Rows.Add(DataGridView1.Rows.Count, DR.Item("nama_fnb"), DR.Item("harga_fnb"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()  ' Ensure the connection is closed
        End Try
    End Sub

    Private Sub picFoodImg_Click(sender As Object, e As EventArgs) Handles picFoodImg.Click
        Dim pop As OpenFileDialog = New OpenFileDialog
        If pop.ShowDialog() <> DialogResult.Cancel Then
            picFoodImg.Image = Image.FromFile(pop.FileName)
        End If
    End Sub

    Sub clear()
        tbNamaMenu.Clear()
        tbHargaMenu.Clear()
        picFoodImg.Image = Nothing
    End Sub

    Private Sub btnAddMenu_Click(sender As Object, e As EventArgs) Handles btnAddMenu.Click
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `tb_fnb`(`nama_fnb`, `harga_fnb`, `image_fnb`) VALUES (@nama_fnb, @harga_fnb, @image_fnb)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@nama_fnb", tbNamaMenu.Text)
            cmd.Parameters.AddWithValue("@harga_fnb", tbHargaMenu.Text)

            Using mstream As New System.IO.MemoryStream()
                picFoodImg.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                cmd.Parameters.AddWithValue("@image_fnb", mstream.ToArray())  ' Save the image as byte array
            End Using

            Dim i As Integer = cmd.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("New Food saved successfully!", vbInformation, "FAST FOOD")
            Else
                MsgBox("Warning: Food save failed!", vbCritical, "FAST FOOD")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()  ' Ensure the connection is closed
            clear()  ' Clear inputs
            Load_fooddata()  ' Reload food data
            FormFnB.Load_Foods()  ' Ensure this method works correctly
        End Try
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        DataGridView1.Rows.Clear() ' Clear existing rows in the DataGridView
        Try
            conn.Open()

            ' Use parameterized query for safety and correctness
            CMD = New MySqlCommand("SELECT `nama_fnb`, `harga_fnb` FROM `tb_fnb` WHERE `nama_fnb` LIKE @search", conn)
            CMD.Parameters.AddWithValue("@search", "%" & tbSearch.Text & "%") ' Use parameter to prevent SQL injection

            Using DR As MySqlDataReader = CMD.ExecuteReader()
                While DR.Read()
                    ' Add the retrieved items to the DataGridView
                    DataGridView1.Rows.Add(DataGridView1.Rows.Count, DR.Item("nama_fnb"), DR.Item("harga_fnb"))
                End While
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close() ' Ensure the connection is closed in case of an error
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
