Imports MySql.Data.MySqlClient

Public Class FormAddUser
    Private previousForm As FormPengaturan
    Private Sub btnTambahUser_Click(sender As Object, e As EventArgs) Handles btnTambahUser.Click
        If ValidateInputs() Then
            tambahUser()
            Close()
            previousForm.Instance.RefreshData()
        Else
            MessageBox.Show("Pastikan semua kolom terisi dengan benar!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        Dim allInputsValid As Boolean = True

        ' Validasi setiap TextBox
        allInputsValid = allInputsValid And ValidateTextBox(tbNamaUser)
        allInputsValid = allInputsValid And ValidateTextBox(tbPasswordUser)

        Return allInputsValid
    End Function

    Private Function ValidateTextBox(textBox As TextBox) As Boolean
        If String.IsNullOrWhiteSpace(textBox.Text) Then
            Return False
        End If
        Return True
    End Function

    Sub tambahUser()
        Try
            connect()
            CMD = New MySqlCommand("INSERT INTO tb_shift (nama, pass, status) VALUES (@nama, @pass, 'off')", Koneksi)
            ' Ganti @value1, @value2, @value3 dengan nama kolom yang sesuai
            CMD.Parameters.AddWithValue("@nama", tbNamaUser.Text)
            CMD.Parameters.AddWithValue("@pass", tbPasswordUser.Text)
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            disconnect()

        End Try
    End Sub


End Class