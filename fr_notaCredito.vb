Public Class fr_notaCredito
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nuevo As fr_buscarOperacion = New fr_buscarOperacion()
        nuevo.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nuevo As fr_buscarOperacion = New fr_buscarOperacion()
        nuevo.Show()
    End Sub
End Class