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

Public Partial Class Productos
	Inherits Form
	Private numeroPagina As Integer = 1
	Private registrosPorPagina As Integer = 25
	Private cantidadPaginas As Integer

	Public Sub New()
		InitializeComponent()
		Mostrar()
	End Sub

	Public Sub Mostrar()
		Try
			Me.Dock = DockStyle.Fill
			Me.dataGridViewProductos.DataSource = NProductos.Mostrar(numeroPagina, registrosPorPagina)
			Me.dataGridViewProductos.Columns(0).Visible = False
			Me.dataGridViewProductos.Columns(4).DefaultCellStyle.Format = "0.00## $"
			Me.dataGridViewProductos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
			cantidadPaginas = NProductos.Tamaño(registrosPorPagina)
			Me.labelPagina.Text = [String].Format("Página {0} de {1}", numeroPagina, cantidadPaginas)
		Catch ex As Exception
			MensajeError(ex.Message)
		End Try
	End Sub

	Public Sub Buscar()
		Try
			Me.dataGridViewProductos.DataSource = NProductos.Buscar(Me.textBoxBuscarNombre.Text)
		Catch ex As Exception
			MensajeError(ex.Message)
		End Try
	End Sub

	Public Sub Refrescar()
		Me.numeroPagina = 1
		Me.Mostrar()
		Me.textBoxBuscarNombre.Text = [String].Empty
	End Sub

	Public Sub Mensaje(mensaje__1 As [String])
		Me.labelMensajes.Text = mensaje__1
	End Sub

	Public Sub LimpiarMensaje()
		Me.labelMensajes.Text = [String].Empty
	End Sub

	Private Sub MensajeError(mensaje As String)
		MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
	End Sub

	Public Function ObtenerSeleccion() As DataGridViewRow
		Dim filaSeleccionada As DataGridViewRow = Me.dataGridViewProductos.Rows(Me.dataGridViewProductos.CurrentRow.Index)
		Return filaSeleccionada
	End Function

	Private Sub textBoxBuscarNombre_TextChanged(sender As Object, e As EventArgs)
		If Me.textBoxBuscarNombre.Text = [String].Empty Then
			Me.numeroPagina = 1
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
			If Me.dataGridViewProductos.Rows.Count > 0 Then
				Dim editarProducto As New FrmEditarProducto(Me)
				editarProducto.ShowDialog()
			Else
				MensajeError("Debes seleccionar una fila para editar")
			End If
		Catch ex As Exception
			MensajeError(ex.Message)
		End Try
	End Sub

	Private Sub buttonEliminar_Click(sender As Object, e As EventArgs)
		Try
			If Me.dataGridViewProductos.Rows.Count > 0 Then
				Dim confirmacion As DialogResult = MessageBox.Show("¿Seguro deseas eliminar este producto?", "Eliminar Producto", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

				If confirmacion = DialogResult.OK Then
					Dim mensaje__1 As [String] = NProductos.Eliminar(Convert.ToInt32(ObtenerSeleccion().Cells("ID").Value))
					If mensaje__1 = "Y" Then
						Mensaje([String].Format("El Producto {0} ha sido ELIMINADO", Convert.ToString(ObtenerSeleccion().Cells("NOMBRE").Value)))
						Refrescar()
					Else
						MensajeError(mensaje__1)
						Refrescar()
					End If
				End If
			Else
				MensajeError("Debes seleccionar una fila para eliminar")

			End If
		Catch ex As Exception
			MensajeError(ex.Message)
		End Try
	End Sub

	Private Sub buttonAgregar_Click(sender As Object, e As EventArgs)
		Dim nuevoProducto As New FrmAgregarNuevoProducto(Me)
		nuevoProducto.ShowDialog()
	End Sub

	Private Sub buttonAnterior_Click(sender As Object, e As EventArgs)
		If numeroPagina > 1 Then
			numeroPagina = numeroPagina - 1
			Mostrar()
		End If
	End Sub

	Private Sub buttonSiguiente_Click(sender As Object, e As EventArgs)
		If numeroPagina < cantidadPaginas Then
			numeroPagina = numeroPagina + 1
			Mostrar()
		End If
	End Sub

End Class
