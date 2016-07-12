Public Class fr_buscarOperacion
    Private Sub fr_buscarOperacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SaeCpPDataSet9.tbl_sae_operacion' Puede moverla o quitarla según sea necesario.
        Me.Tbl_sae_operacionTableAdapter.Fill(Me.SaeCpPDataSet9.tbl_sae_operacion)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim dgv As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

        TextBox1.Text = dgv.Cells(0).Value.ToString()
        TextBox2.Text = dgv.Cells(1).Value.ToString()
        TextBox3.Text = dgv.Cells(2).Value.ToString()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()


    End Sub
End Class