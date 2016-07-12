Public Class Fr_actualizarOperacion
    Dim conexion As Conexion = New Conexion()

    Private Sub Fr_actualizarOperacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SaeCpPDataSet4.tbl_sae_operacion' Puede moverla o quitarla según sea necesario.
        Me.Tbl_sae_operacionTableAdapter.Fill(Me.SaeCpPDataSet4.tbl_sae_operacion)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim dgv As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

        txClave.Text = dgv.Cells(0).Value.ToString()
        txNombre.Text = dgv.Cells(1).Value.ToString()
        txDescripcion.Text = dgv.Cells(2).Value.ToString()

    End Sub

    Private Sub btActualizar_Click(sender As Object, e As EventArgs) Handles btActualizar.Click
        Dim actualizar As String = "ope_nombre = '" + txNombre.Text + "', ope_descripcion ='" + txDescripcion.Text + "'"
        If (conexion.Actualizar("tbl_sae_operacion", actualizar, "id_operacion= " + txClave.Text)) Then
            MessageBox.Show("actualizacion exitosa")
        Else
            MessageBox.Show("error al Actualizar")
        End If

    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Close()

    End Sub
End Class