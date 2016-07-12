Public Class fr_eliminarActualizaProveedor


    Dim conexion As Conexion = New Conexion()
    Private Sub fr_eliminarActualizaProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SaeCpPDataSet3.tbl_sae_proveedor' Puede moverla o quitarla según sea necesario.
        Me.Tbl_sae_proveedorTableAdapter1.Fill(Me.SaeCpPDataSet3.tbl_sae_proveedor)
        'TODO: esta línea de código carga datos en la tabla 'SaeCpPDataSet1.tbl_sae_proveedor' Puede moverla o quitarla según sea necesario.
        Me.Tbl_sae_proveedorTableAdapter.Fill(Me.SaeCpPDataSet1.tbl_sae_proveedor)

    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        If (conexion.Eliminar("tbl_sae_proveedor", "id_proveedor= " + txIdPro.Text)) Then
            MessageBox.Show("Datos Eliminados Correctamente")
            'MostrarDatos()
        Else
            MessageBox.Show("Error al eliminar")
        End If
        MostrarDatos()
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs)
        Dim nuevo As fr_buscarProveedor = New fr_buscarProveedor()
        nuevo.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim dgv As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

        txIdPro.Text = dgv.Cells(0).Value.ToString()
        txNombre.Text = dgv.Cells(1).Value.ToString()
        txDireccion.Text = dgv.Cells(2).Value.ToString()
        txTelefono.Text = dgv.Cells(3).Value.ToString()
        txCorre.Text = dgv.Cells(4).Value.ToString()

    End Sub

    Private Sub btActualizar_Click(sender As Object, e As EventArgs) Handles btActualizar.Click
        Dim actualizar As String = "pro_nombre = '" + txNombre.Text + "', pro_direccion ='" + txDireccion.Text + "', pro_telefono ='" + txTelefono.Text + "',pro_correo ='" + txCorre.Text + "'"
        If (conexion.Actualizar("tbl_sae_proveedor", actualizar, "id_proveedor= " + txIdPro.Text)) Then
            MessageBox.Show("Actualizacion exitosa")
            '  MostrarDatos()

        Else
            MessageBox.Show("Error")
        End If
        ' MostrarDatos()
    End Sub

    Public Sub MostrarDatos()
        conexion.Consulta("select * from tbl_sae_proveedor ", "tbl_sae_proveedor  ")
        DataGridView1.DataSource = conexion.ds.Tables("tbl_sae_proveedor")
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        'Dim nuevo As Form1 = New Form1()
        Dim nuevo As fr_eliminarActualizaProveedor = New fr_eliminarActualizaProveedor()
        nuevo.Show()

    End Sub

    Private Sub butSalir_Click(sender As Object, e As EventArgs) Handles butSalir.Click
        Close()

    End Sub
End Class