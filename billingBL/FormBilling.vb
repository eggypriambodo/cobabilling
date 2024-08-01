Public Class FormBilling
    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub


    Private Sub FormBilling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerSaatIni.Enabled = True
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
End Class