Public Class FormBilling

    Public Shared Instance As FormBilling

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub


    Private Sub FormBilling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Instance = Me
        TimerSaatIni.Enabled = True
        statusTable1.Text = "KOSONG"
        statusTable1.BackColor = Color.Lime



    End Sub

    Public Sub UbahStatusTableKosong()
        If statusTable1.Text = "KOSONG" Then
            statusTable1.Text = "AKTIF"
            statusTable1.BackColor = Color.Red
        End If
    End Sub

    Public Sub UbahStatusTableCheckout()
        If statusTable1.Text = "CHECKOUT" Then
            statusTable1.Text = "KOSONG"
            statusTable1.BackColor = Color.Lime
        End If
    End Sub

    Private Sub TimerSaatIni_Tick(sender As Object, e As EventArgs) Handles TimerSaatIni.Tick
        LabelTimerSaatIni.Text = Date.Now.ToString("dd/MMM/yyyy HH:mm:ss")
    End Sub

    Private Sub btnDetail1_Click(sender As Object, e As EventArgs) Handles btnDetail1.Click
        FormDetailTable.Show()
    End Sub

    Private Sub btnOpenLos_Click(sender As Object, e As EventArgs) Handles btnOpenLos.Click
        FormOpenTableLos.Show()
    End Sub

    Private Sub btnOpenDurasi_Click(sender As Object, e As EventArgs) Handles btnOpenDurasi.Click
        FormOpenTableDurasi.Show()
    End Sub

    Private Sub btnOpenPaket_Click(sender As Object, e As EventArgs) Handles btnOpenPaket.Click
        FormOpenTablePaket.Show()
    End Sub

    Private Sub btnStopTable1_Click(sender As Object, e As EventArgs) Handles btnStopTable1.Click
        If statusTable1.Text = "AKTIF" Then
            statusTable1.Text = "CHECKOUT"
            statusTable1.BackColor = Color.LightGray
        End If
    End Sub

    Public Sub UpdateOrderDetails(mulai As String, selesai As String, durasi As String)
        labTimeStart1.Text = mulai
        labTimeStop1.Text = selesai
        duration1.Text = durasi
    End Sub


End Class