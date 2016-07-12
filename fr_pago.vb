Public Class fr_pago
    Private Sub fr_pago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SaeCpPDataSet8.tbl_sae_comprobante' Puede moverla o quitarla según sea necesario.
        Me.Tbl_sae_comprobanteTableAdapter.Fill(Me.SaeCpPDataSet8.tbl_sae_comprobante)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()

    End Sub
End Class