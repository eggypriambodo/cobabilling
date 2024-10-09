Imports MySql.Data.MySqlClient
Imports System.IO
Imports Windows.Win32.UI.Input

Public Class FormFnB
    Private WithEvents pan As Panel
    Private WithEvents pan_top As Panel
    Private WithEvents nama_fnb As Label
    Private WithEvents harga_fnb As Label
    Private WithEvents image_fnb As CirclePicturBox

    Private Sub FormFnB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoadControls()
        Dim len As Long = DR.GetBytes(0, 0, Nothing, 0, 0)
        Dim array(CInt(len)) As Byte
        DR.GetBytes(0, 0, array, 0, CInt(len))


        pan = New Panel
        With pan
            .Width = 150
            .Height = 210
            .BackColor = Color.FromArgb(30, 144, 255)
            .Tag = DR.Item("nama_fnb")
        End With

        pan_top = New Panel
        With pan_top
            .Width = 150
            .Height = 10
            .BackColor = Color.FromArgb(30, 144, 255)
            .Dock = DockStyle.Top
            .Tag = DR.Item("nama_fnb")
        End With

        image_fnb = New CirclePicturBox
        With image_fnb
            .Height = 120
            .BackgroundImageLayout = ImageLayout.Stretch
            .Dock = DockStyle.Top
            .Tag = DR.Item("nama_fnb")
        End With

        nama_fnb = New Label
        With nama_fnb
            .ForeColor = Color.White
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Top
            .Tag = DR.Item("foodcode").ToString
        End With

        harga_fnb = New Label
        With harga_fnb
            .ForeColor = Color.White
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Top
            .Tag = DR.Item("foodcode").ToString
        End With

        Dim ms As New System.IO.MemoryStream(array)
        Dim bitmap As New System.Drawing.Bitmap(ms)
        image_fnb.BackgroundImage = bitmap

        nama_fnb.Text = " Food Name  : " & DR.Item("foodname").ToString
        harga_fnb.Text = " Price              : ₹ " & DR.Item("price").ToString

        pan.Controls.Add(harga_fnb)
        pan.Controls.Add(nama_fnb)
        pan.Controls.Add(image_fnb)


        pan.Controls.Add(pan_top)
        FlowLayoutPanel1.Controls.Add(pan)

        AddHandler nama_fnb.Click, AddressOf Selectimg_Click
        AddHandler harga_fnb.Click, AddressOf Selectimg_Click
        AddHandler image_fnb.Click, AddressOf Selectimg_Click
        AddHandler pan.Click, AddressOf Selectimg_Click
    End Sub

    Public Sub Selectimg_Click(sender As Object, e As EventArgs)
        conn.Open()
        Try
            CMD = New MySqlCommand("SELECT `nama_fnb`, `kategori_fnb`, `harga_fnb` FROM `tbl_food` WHERE `nama_fnb` like '" & sender.tag.ToString & "%' ", conn)
            DR = CMD.ExecuteReader
            While DR.Read
                Dim exist As Boolean = False, numrow As Integer = 0, numtext As Integer
                For Each itm As DataGridViewRow In DataGridView1.Rows
                    If itm.Cells(1).Value IsNot Nothing Then
                        If itm.Cells(1).Value.ToString = DR.Item("nama_fnb") Then
                            exist = True
                            numrow = itm.Index
                            numtext = CInt(itm.Cells(4).Value)
                            Exit For
                        End If
                    End If
                Next
                If exist = False Then
                    Dim price As Decimal = DR("harga_fnb")
                    Dim subtotalprice As Double
                    subtotalprice = price * 1
                    DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, DR.Item("nama_fnb"), DR.Item("harga_fnb"), 1, subtotalprice)
                Else
                    DataGridView1.Rows(numrow).Cells(4).Value = CInt("1") + numtext
                    DataGridView1.Rows(numrow).Cells(5).Value = DataGridView1.Rows(numrow).Cells(3).Value * DataGridView1.Rows(numrow).Cells(4).Value
                End If

            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        DR.Dispose()
        conn.Close()

    End Sub

    Sub Load_Menus()
        FlowLayoutPanel1.Controls.Clear()
        FlowLayoutPanel1.AutoScroll = True
        Try
            conn.Open()
            CMD = New MySqlCommand("SELECT `image_fnb`, `nama_fnb`, `harga_fnb` FROM `tb_fnb`", conn)
            DR = CMD.ExecuteReader
            While DR.Read
                LoadControls()
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

End Class