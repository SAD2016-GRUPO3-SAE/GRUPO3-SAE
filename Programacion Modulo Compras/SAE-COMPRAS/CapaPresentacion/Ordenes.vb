Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports CapaNegocio
Imports System.Data.SqlClient

Public Partial Class Ordenes
	Inherits Form
	Private numeroPaginaPedidosPendientes As Integer = 1
	Private numeroPaginaPedidosEntegados As Integer = 1
	Private registrosPorPagina As Integer = 25
	Private cantidadPaginasPedidosPendientes As Integer
	Private cantidadPaginasPedidosEntregados As Integer

	Private esPendiente As Integer = 1

	Public Sub New()
		InitializeComponent()
		Mostrar()
	End Sub

	Private Sub tabControlPedidos_Selected(sender As Object, e As TabControlEventArgs)
		If tabControlPedidos.SelectedTab Is tabControlPedidos.TabPages("tabPagePendientes") Then
			esPendiente = 1
			Mostrar()
		ElseIf tabControlPedidos.SelectedTab Is tabControlPedidos.TabPages("tabPageEntregados") Then
			esPendiente = 0
			Mostrar()
		End If
	End Sub

	Public Sub Mostrar()
		Try
			If esPendiente = 1 Then
				Me.Dock = DockStyle.Fill
				Me.dataGridViewPedidosPendientes.DataSource = NOrdenes.MostrarOrdenesPendientes(numeroPaginaPedidosPendientes, registrosPorPagina)
				Me.dataGridViewPedidosPendientes.Columns(1).Visible = False
				Me.dataGridViewPedidosPendientes.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
				Me.dataGridViewPedidosPendientes.Columns(8).DefaultCellStyle.Format = "0.00## $"
				cantidadPaginasPedidosPendientes = NOrdenes.TamañoOrdenesPendientes(registrosPorPagina)
				Me.labelPagina.Text = [String].Format("Página {0} de {1}", numeroPaginaPedidosPendientes, cantidadPaginasPedidosPendientes)

			ElseIf esPendiente = 0 Then
				Me.Dock = DockStyle.Fill
				Me.dataGridViewPedidosEntregados.DataSource = NOrdenes.MostrarOrdenesEntregados(numeroPaginaPedidosEntegados, registrosPorPagina)
				Me.dataGridViewPedidosEntregados.Columns(1).Visible = False
				Me.dataGridViewPedidosEntregados.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
				Me.dataGridViewPedidosEntregados.Columns(8).DefaultCellStyle.Format = "0.00## $"
				cantidadPaginasPedidosEntregados = NOrdenes.TamañoOrdenesEntregados(registrosPorPagina)
				Me.labelPagina.Text = [String].Format("Página {0} de {1}", numeroPaginaPedidosEntegados, cantidadPaginasPedidosEntregados)
			End If

		Catch ex As Exception
			MensajeError(ex.Message)
		End Try
	End Sub

	Public Sub Buscar()
		Try
			If esPendiente = 1 Then
				Me.dataGridViewPedidosPendientes.DataSource = NOrdenes.BuscarOrdenPendiente(Me.textBoxBuscarNombre.Text)
			Else
				Me.dataGridViewPedidosEntregados.DataSource = NOrdenes.BuscarOrdenEntregado(Me.textBoxBuscarNombre.Text)
			End If
		Catch ex As Exception
			MensajeError(ex.Message)
		End Try
	End Sub

	Public Sub Refrescar()
		If esPendiente = 1 Then
			Me.numeroPaginaPedidosPendientes = 1
		ElseIf esPendiente = 0 Then
			Me.numeroPaginaPedidosEntegados = 1
		End If

		Me.Mostrar()
		Me.textBoxBuscarNombre.Text = [String].Empty
	End Sub

	Public Sub Mensaje(mensaje__1 As [String])
		Me.labelMensajes.Text = mensaje__1
	End Sub

	Public Sub LimpiarMensaje()
		Me.labelMensajes.Text = [String].Empty
	End Sub

	Public Sub MensajeError(mensaje As String)
		MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
	End Sub

	Public Function ObtenerSeleccionPedidos() As DataGridViewRow
		Dim filaSeleccionada As DataGridViewRow = Nothing

		If esPendiente = 1 Then
			filaSeleccionada = Me.dataGridViewPedidosPendientes.Rows(Me.dataGridViewPedidosPendientes.CurrentRow.Index)

		ElseIf esPendiente = 0 Then
			filaSeleccionada = Me.dataGridViewPedidosEntregados.Rows(Me.dataGridViewPedidosEntregados.CurrentRow.Index)
		End If

		Return filaSeleccionada
	End Function

	Private Sub textBoxBuscarNombre_TextChanged(sender As Object, e As EventArgs)
		If Me.textBoxBuscarNombre.Text = [String].Empty Then
			If esPendiente = 1 Then
				Me.numeroPaginaPedidosPendientes = 1
			ElseIf esPendiente = 0 Then
				Me.numeroPaginaPedidosEntegados = 1
			End If

			Me.Mostrar()
			Me.tableLayoutPanelPaginacion.Show()
		Else
			Me.Buscar()
			Me.tableLayoutPanelPaginacion.Hide()
		End If
	End Sub

	Private Sub buttonRefrescar_Click(sender As Object, e As EventArgs)
		Me.Refrescar()
		Me.LimpiarMensaje()
	End Sub

	Private Sub buttonEditar_Click(sender As Object, e As EventArgs)
		Try
			If esPendiente = 1 Then
				If Me.dataGridViewPedidosPendientes.Rows.Count > 0 Then
					Dim editarPedidoPendiente As New FrmEditarOrdenPendiente(Me)
					editarPedidoPendiente.ShowDialog()
				Else
					MensajeError("Debes seleccionar una fila para editar")
				End If

			ElseIf esPendiente = 0 Then
				If Me.dataGridViewPedidosEntregados.Rows.Count > 0 Then
					Dim editarPedidoEntregado As New FrmEditarOrdenEntregado(Me)
					editarPedidoEntregado.ShowDialog()
				Else
					MensajeError("Debes seleccionar una fila para editar")
				End If
			End If

		Catch ex As Exception
			MensajeError(ex.Message)
		End Try
	End Sub

	Private Sub Eliminar()
		Dim confirmacion As DialogResult = MessageBox.Show("¿Seguro deseas eliminar esta Orden?", "Eliminar Orden", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

		If confirmacion = DialogResult.OK Then
			Dim mensaje__1 As [String] = NOrdenes.Eliminar(Convert.ToInt32(ObtenerSeleccionPedidos().Cells("ID").Value))
			If mensaje__1 = "Y" Then
				Mensaje([String].Format("El Pedido {0} de {1} ha sido ELIMINADO", Convert.ToString(ObtenerSeleccionPedidos().Cells("CÓDIGO").Value), Convert.ToString(ObtenerSeleccionPedidos().Cells("CLIENTE").Value)))
				Refrescar()
			Else
				MensajeError(mensaje__1)
				Refrescar()
			End If
		End If
	End Sub

	Private Sub buttonEliminar_Click(sender As Object, e As EventArgs)
		Try
			If esPendiente = 1 Then
				If Me.dataGridViewPedidosPendientes.Rows.Count > 0 Then
					Me.Eliminar()
				Else
					MensajeError("Debes seleccionar una fila para eliminar")
				End If
			ElseIf esPendiente = 0 Then
				If Me.dataGridViewPedidosEntregados.Rows.Count > 0 Then
					Me.Eliminar()
				Else
					MensajeError("Debes seleccionar una fila para eliminar")
				End If
			End If

		Catch ex As Exception
			MensajeError(ex.Message)
		End Try
	End Sub

	Private Sub buttonAgregar_Click(sender As Object, e As EventArgs)
		Try
			Dim nuevoPedido As New FrmAgregarNuevaOrden(Me)
			nuevoPedido.ShowDialog()
		Catch ex As Exception
			MensajeError(ex.Message)
		End Try
	End Sub

	Private Sub dataGridViewPedidosPendientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
		Dim senderGrid = DirectCast(sender, DataGridView)

		If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
			Try
				Dim pedidoDetalles As New FrmoOrdenPendienteDetalles(Me)
				pedidoDetalles.ShowDialog()
			Catch ex As Exception
				MensajeError(ex.Message)
			End Try
		End If
	End Sub

	Private Sub dataGridViewPedidosEntregados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
		Dim senderGrid = DirectCast(sender, DataGridView)

		If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
			Try
				Dim pedidoEntregadoDetalles As New FrmOrdenEntregadoDetalles(Me)
				pedidoEntregadoDetalles.ShowDialog()
			Catch ex As Exception
				MensajeError(ex.Message)
			End Try
		End If
	End Sub

	Private Sub buttonMarcarEntregado_Click(sender As Object, e As EventArgs)
		Try
			If esPendiente = 1 Then
				If Me.dataGridViewPedidosPendientes.Rows.Count > 0 Then
					Dim marcarEntregado As New FrmMarcarEntregado(Me)
					marcarEntregado.ShowDialog()
				Else
					MensajeError("Debes seleccionar una fila para marcar como Entregado")
				End If

			ElseIf esPendiente = 0 Then
				If Me.dataGridViewPedidosEntregados.Rows.Count > 0 Then
					Dim marcarPendiente As New FrmMarcarPendiente(Me)
					marcarPendiente.ShowDialog()
				Else
					MensajeError("Debes seleccionar una fila para marcar como Pendiente")
				End If
			End If

		Catch ex As Exception
			MensajeError(ex.Message)
		End Try

	End Sub

	Private Sub buttonAnterior_Click(sender As Object, e As EventArgs)
		If numeroPaginaPedidosPendientes > 1 AndAlso esPendiente = 1 Then
			numeroPaginaPedidosPendientes = numeroPaginaPedidosPendientes - 1
			Mostrar()
		ElseIf numeroPaginaPedidosEntegados > 1 AndAlso esPendiente = 0 Then
			numeroPaginaPedidosEntegados = numeroPaginaPedidosEntegados - 1
			Mostrar()
		End If
	End Sub

	Private Sub buttonSiguiente_Click(sender As Object, e As EventArgs)
		If numeroPaginaPedidosPendientes < cantidadPaginasPedidosPendientes AndAlso esPendiente = 1 Then
			numeroPaginaPedidosPendientes = numeroPaginaPedidosPendientes + 1
			Mostrar()
		ElseIf numeroPaginaPedidosEntegados < cantidadPaginasPedidosEntregados AndAlso esPendiente = 0 Then
			numeroPaginaPedidosEntegados = numeroPaginaPedidosEntegados + 1
			Mostrar()
		End If
	End Sub

End Class
