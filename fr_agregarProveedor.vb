Public Class fr_agregarProveedor
    Dim conexion As Conexion = New Conexion()

    Private Sub btIngresar_Click(sender As Object, e As EventArgs) Handles btIngresar.Click

        Dim agregar As String = " insert into tbl_sae_proveedor values ('" + txnombre.Text + "','" + txDireccio.Text + "','" + txTelefono.Text + "','" + txCorreo.Text + "')"

        If (conexion.Insertar(agregar)) Then
            MessageBox.Show("Datos agregados Correctamente")
        Else
            MessageBox.Show("Error al Agregar datos")
        End If

    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Close()

    End Sub
End Class