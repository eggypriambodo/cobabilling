Public Class FormBilling
    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnOpenTable_Click(sender As Object, e As EventArgs) Handles btnOpenLos.Click
        FormOpenTable.Show()
    End Sub

    Private Sub FormBilling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerSaatIni.Enabled = True
    End Sub

    Private Sub TimerSaatIni_Tick(sender As Object, e As EventArgs) Handles TimerSaatIni.Tick
        LabelTimerSaatIni.Text = Date.Now.ToString("dd/MMM/yyyy HH:mm:ss")
    End Sub
End Class