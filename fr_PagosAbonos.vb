Public Class fr_PagosAbonos
    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Close()

    End Sub

    Private Sub btnPagosAbonos_Click(sender As Object, e As EventArgs) Handles btnPagosAbonos.Click
        Dim nuevo As fr_pago = New fr_pago()
        nuevo.Show()


    End Sub

    Private Sub btNotasCredito_Click(sender As Object, e As EventArgs) Handles btNotasCredito.Click
        Dim nuevo As fr_notaCredito = New fr_notaCredito()
        nuevo.Show()


    End Sub

    Private Sub btNotasDebito_Click(sender As Object, e As EventArgs) Handles btNotasDebito.Click
        Dim nuevo As fr_notaDebito = New fr_notaDebito()
        nuevo.Show()

    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim nuevo As fr_buscarProveedor = New fr_buscarProveedor()
        nuevo.Show()

    End Sub
End Class