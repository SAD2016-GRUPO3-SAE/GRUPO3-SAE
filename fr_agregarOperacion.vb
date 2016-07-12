Public Class fr_agregarOperacion

    Dim conexion As Conexion = New Conexion()
    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click

    End Sub

    Private Sub btIngresa_Click(sender As Object, e As EventArgs) Handles btIngresa.Click
        Dim agregar As String = "  insert into tbl_sae_operacion values ('" + txOperacion.Text + "','" + txDescripcion.Text + "')"

        If (conexion.Insertar(agregar)) Then
            MessageBox.Show("datos Agregados Correctamente")
        Else
            MessageBox.Show("error al agregar Datos")
        End If
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Close()

    End Sub
End Class