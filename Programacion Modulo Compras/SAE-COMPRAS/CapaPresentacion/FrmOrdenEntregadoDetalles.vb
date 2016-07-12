Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports CapaNegocio

Public Partial Class FrmOrdenEntregadoDetalles
	Inherits Form
	Private _owner As Ordenes

	Public Sub New()
		InitializeComponent()
	End Sub

	Public Sub New(owner As Ordenes)
		_owner = owner

		InitializeComponent()

		Me.labelNumeroPedido.Text = _owner.ObtenerSeleccionPedidos().Cells("CÓDIGO").Value.ToString()
		Me.textBoxCliente.Text = _owner.ObtenerSeleccionPedidos().Cells("PROVEEDOR").Value.ToString()
		Me.textBoxTransporte.Text = _owner.ObtenerSeleccionPedidos().Cells("TRANSPORTE").Value.ToString()
		Me.textBoxEmpleado.Text = _owner.ObtenerSeleccionPedidos().Cells("RESPONSABLE").Value.ToString()
		Me.textBoxFechaOrdenado.Text = Convert.ToDateTime(_owner.ObtenerSeleccionPedidos().Cells("ORDENADO").Value).ToString("dd/MM/yyyy")
		Me.textBoxFechaEntregado.Text = Convert.ToDateTime(_owner.ObtenerSeleccionPedidos().Cells("ENTREGADO").Value).ToString("dd/MM/yyyy")
		

		Me.textBoxCostoEnvio.Text = Convert.ToDecimal(_owner.ObtenerSeleccionPedidos().Cells("COSTO DE ENVÍO").Value).ToString("0.00#")
		Me.dataGridViewProductos.DataSource = NOrdenDetalles.MostrarOrdenDetalles(Convert.ToInt32(_owner.ObtenerSeleccionPedidos().Cells(1).Value))
		Me.dataGridViewProductos.Columns(4).DefaultCellStyle.Format = "0.00# '$'"
		Me.dataGridViewProductos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
		Me.dataGridViewProductos.Columns(5).DefaultCellStyle.Format = "0.00# '%'"
		Me.dataGridViewProductos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
	End Sub

	Private Sub buttonSalir_Click(sender As Object, e As EventArgs)
		Me.Close()
	End Sub

	Private Sub dataGridViewProductos_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs)
		Me.dataGridViewProductos.Rows(e.RowIndex).Cells(0).Value = (e.RowIndex + 1).ToString()
	End Sub

End Class
