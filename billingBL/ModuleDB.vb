Imports MySql.Data.MySqlClient

Module ModuleDB
    Dim constring = "Server=localhost;Database=dbpool;User=root;Password="
    Public Koneksi As New MySqlConnection(constring)

    Public DA As MySqlDataAdapter = Nothing
    Public CMD As MySqlCommand = Nothing
    Public DT As New DataTable
    Public DR As MySqlDataReader

    Public found As Boolean = False

    Public Sub connect()
        Try
            If Koneksi Is Nothing Then Koneksi.Close()
            Koneksi.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function disconnect()
        Koneksi.Close()
        Return Koneksi
    End Function
End Module
