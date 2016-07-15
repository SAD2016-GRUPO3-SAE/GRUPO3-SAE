Public Class MDISAE
    Private Sub MDISAE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Fondo As New FondoSAE
        Fondo.MdiParent = Me
        Fondo.Dock = DockStyle.Fill
        Fondo.Show()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub BuscarCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CuentasPorCobrarToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CatalogoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatalogoToolStripMenuItem.Click

    End Sub

    Private Sub CrearCuentaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CrearCuentaToolStripMenuItem1.Click
        CrearCuenta.Show()
    End Sub

    Private Sub BuscarCuentaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BuscarCuentaToolStripMenuItem1.Click
        BuscarCuenta.Show()
    End Sub

    Private Sub EditarCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CrearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearToolStripMenuItem.Click
        CrearUsuario.Show()
    End Sub
End Class