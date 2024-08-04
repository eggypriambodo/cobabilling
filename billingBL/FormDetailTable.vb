Public Class FormDetailTable
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

    End Sub

    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        FormBilling.Instance.UbahStatusTableCheckout()
    End Sub
End Class