Public Class fr_agregarCuenta
    Dim conexion As Conexion = New Conexion()



    Private Sub fr_agregarCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SaeCpPDataSet10.tbl_sae_proveedor' Puede moverla o quitarla según sea necesario.
        Me.Tbl_sae_proveedorTableAdapter1.Fill(Me.SaeCpPDataSet10.tbl_sae_proveedor)
        'TODO: esta línea de código carga datos en la tabla 'SaeCpPDataSet.tbl_sae_proveedor' Puede moverla o quitarla según sea necesario.
        Me.Tbl_sae_proveedorTableAdapter.Fill(Me.SaeCpPDataSet.tbl_sae_proveedor)

    End Sub

    Private Sub btIngresar_Click(sender As Object, e As EventArgs) Handles btIngresar.Click
        Dim agregar As String = " insert into tbl_sae_cuenta values  ('" + txdias.Text + "','" + txDebito.Text + "','" + txCredito.Text + "','" + txSaldo.Text + "','" +
                                 ComboBox1.Text + "')"

        If (conexion.Insertar(agregar)) Then
            MessageBox.Show("Datos Agregados Correctamente")
        Else
            MessageBox.Show("Error al agregar")
        End If
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Close()

    End Sub
End Class