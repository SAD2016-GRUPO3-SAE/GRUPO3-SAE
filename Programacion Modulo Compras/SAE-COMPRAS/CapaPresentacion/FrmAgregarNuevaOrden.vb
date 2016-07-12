Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports CapaNegocio
Imports System.Globalization

Public Partial Class FrmAgregarNuevaOrden
	Inherits Form
	Private _owner As Ordenes

	Public Sub New()
		InitializeComponent()
	End Sub

	Public Sub New(owner As Ordenes)
		_owner = owner
		InitializeComponent()

		CargarClientes()
		CargarTransportistas()
		CargarEmpleados()
		CargarProductos()
		Me.dateTimePickerFechaOrdenado.Value = DateTime.Now
		Me.dateTimePickerFechaRequerido.Value = DateTime.Now
	End Sub

	Public Sub CargarClientes()
		Me.comboBoxClientes.DataSource = NProveedores.ListaProveedores()
		Me.comboBoxClientes.ValueMember = "ID"
		Me.comboBoxClientes.DisplayMember = "NOMBRE"
	End Sub

	Public Sub CargarTransportistas()
		Me.comboBoxTransportes.DataSource = NTransportistas.ListaTransportistas()
		Me.comboBoxTransportes.ValueMember = "ID"
		Me.comboBoxTransportes.DisplayMember = "NOMBRE"
	End Sub

	Public Sub CargarEmpleados()
		Me.comboBoxEmpleados.DataSource = NEmpleados.ListaEmpleados()
		Me.comboBoxEmpleados.ValueMember = "ID"
		Me.comboBoxEmpleados.DisplayMember = "NOMBRE"
	End Sub

	Public Sub CargarProductos()
		Me.comboBoxProductos.DataSource = NProductos.ListaProductos()
		Me.comboBoxProductos.ValueMember = "ID"
		Me.comboBoxProductos.DisplayMember = "NOMBRE"
	End Sub

	Private Sub MensajeError(mensaje As String)
		MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
	End Sub

	Public Function ObtenerSeleccion() As DataGridViewRow
		Dim filaSeleccionada As DataGridViewRow = Me.dataGridViewProductos.Rows(Me.dataGridViewProductos.CurrentRow.Index)
		Return filaSeleccionada
	End Function

	Private Sub buttonAgregarProducto_Click(sender As Object, e As EventArgs)
		Try
			Dim bandera As Integer = 0

			For fila As Integer = 0 To dataGridViewProductos.Rows.Count - 1
				If dataGridViewProductos.Rows(fila).Cells("producto").Value.ToString() = Me.comboBoxProductos.Text Then
					bandera = 1
				End If
			Next

			If bandera = 1 Then
				MensajeError("Este producto ya fue ingresado")
			Else

				If [String].IsNullOrWhiteSpace(Me.textBoxCantidad.Text) OrElse ([String].IsNullOrWhiteSpace(Me.textBoxPrecio.Text)) OrElse ([String].IsNullOrWhiteSpace(Me.textBoxDescuento.Text)) Then
					MensajeError("No puedes dejar vacíos los campos Cantidad, Precio o Descuento")

				ElseIf Convert.ToInt32(Me.textBoxCantidad.Text) = 0 Then
					MensajeError("La Cantidad no puede ser igual a 0")

				ElseIf Convert.ToDecimal(Me.textBoxPrecio.Text) = 0 Then
					MensajeError("El Precio no puede ser igual a 0")

				ElseIf Convert.ToDecimal(Me.textBoxDescuento.Text) > 100 Then
					MensajeError("El Descuento no puede ser mayor al 100%")
				Else

					Me.dataGridViewProductos.Rows.Add("", Me.comboBoxProductos.Text, Me.textBoxCantidad.Text, Convert.ToDecimal(Me.textBoxPrecio.Text).ToString("0.00## $"), Convert.ToDecimal(Me.textBoxDescuento.Text).ToString("0.00## '%'"))
					Me.comboBoxProductos.Text = [String].Empty
					Me.textBoxCantidad.Text = [String].Empty
					Me.textBoxDescuento.Text = "0"
				End If
			End If

		Catch ex As Exception
			MensajeError("Los valores ingresados son incorrectos. " & ex.Message)
		End Try

	End Sub

	Private Sub buttonEliminarProducto_Click(sender As Object, e As EventArgs)
		If Convert.ToInt32(dataGridViewProductos.Rows.Count) > 0 Then
			Me.dataGridViewProductos.Rows.Remove(Me.dataGridViewProductos.Rows(Me.dataGridViewProductos.CurrentRow.Index))
		Else

			MensajeError("Debes seleccionar una fila para eliminar")
		End If
	End Sub

	Private Sub dataGridViewProductos_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs)
		Me.dataGridViewProductos.Rows(e.RowIndex).Cells(0).Value = (e.RowIndex + 1).ToString()
	End Sub

	Private Sub textBoxCostoEnvio_KeyPress(sender As Object, e As KeyPressEventArgs)
		If (e.KeyChar < 48 OrElse e.KeyChar > 57) AndAlso (e.KeyChar <> 8 AndAlso e.KeyChar <> ","C) Then
			e.Handled = True
		Else
			e.Handled = False
		End If
	End Sub

	Private Sub textBoxPrecio_KeyPress(sender As Object, e As KeyPressEventArgs)
		If (e.KeyChar < 48 OrElse e.KeyChar > 57) AndAlso (e.KeyChar <> 8 AndAlso e.KeyChar <> ","C) Then
			e.Handled = True
		Else
			e.Handled = False
		End If
	End Sub

	Private Sub textBoxCantidad_KeyPress(sender As Object, e As KeyPressEventArgs)
		If (e.KeyChar < 48 OrElse e.KeyChar > 57) AndAlso (e.KeyChar <> 8) Then
			e.Handled = True
		Else
			e.Handled = False
		End If
	End Sub

	Private Sub textBoxDescuento_KeyPress(sender As Object, e As KeyPressEventArgs)
		If (e.KeyChar < 48 OrElse e.KeyChar > 57) AndAlso (e.KeyChar <> 8 AndAlso e.KeyChar <> ","C) Then
			e.Handled = True
		Else
			e.Handled = False
		End If
	End Sub

	Private Sub comboBoxProductos_SelectedValueChanged(sender As Object, e As EventArgs)
		Try
			If Me.comboBoxProductos.SelectedIndex <> -1 Then
				If Me.comboBoxProductos.SelectedValue.ToString() <> "System.Data.DataRowView" Then
					Me.textBoxPrecio.Text = (NProductos.PrecioProducto(Convert.ToInt32(Me.comboBoxProductos.SelectedValue.ToString()))).ToString("0.00##")
				End If
			End If
		Catch ex As Exception
			MensajeError(ex.Message)
		End Try
	End Sub

	Private Sub checkBoxSinFecha_CheckedChanged(sender As Object, e As EventArgs)
		If Me.checkBoxSinFecha.Checked Then
			Me.dateTimePickerFechaRequerido.Hide()
		Else
			Me.dateTimePickerFechaRequerido.Show()
		End If
	End Sub

	Private Sub buttonGuardar_Click(sender As Object, e As EventArgs)
		Dim mensaje As [String] = ""
		Dim fecha_requerido As [String] = ""

		Try
			If Me.textBoxCostoEnvio.Text = [String].Empty Then
				Me.textBoxCostoEnvio.Text = "0"
			End If

			If Me.checkBoxSinFecha.Checked Then
				fecha_requerido = Nothing
			Else

				fecha_requerido = Me.dateTimePickerFechaRequerido.Value.ToString("dd/MM/yyyy")
			End If

			If Me.dataGridViewProductos.Rows.Count > 0 Then
				mensaje = NOrdenes.Insertar(Me.comboBoxClientes.Text, Me.comboBoxTransportes.Text, Me.comboBoxEmpleados.Text, Me.dateTimePickerFechaOrdenado.Value.ToString("dd/MM/yyyy"), fecha_requerido, Convert.ToDecimal(Me.textBoxCostoEnvio.Text))

				If mensaje = "Y" Then
					For fila As Integer = 0 To dataGridViewProductos.Rows.Count - 1
						mensaje = NOrdenDetalles.Insertar(dataGridViewProductos.Rows(fila).Cells("producto").Value.ToString(), Convert.ToInt32(dataGridViewProductos.Rows(fila).Cells("cantidad").Value.ToString()), Convert.ToDecimal(dataGridViewProductos.Rows(fila).Cells("precio").Value.ToString().Replace("$", "")), Convert.ToDecimal(dataGridViewProductos.Rows(fila).Cells("descuento").Value.ToString().Replace("%", "")))
					Next
					If mensaje = "Y" Then
						Me._owner.Mensaje([String].Format("El Pedido para {0} ha sido AGREGADO", Me.comboBoxClientes.Text))
						Me._owner.Refrescar()
						Me.Close()
					Else
						MensajeError([String].Format("El Pedido para {0} ha sido agregado pero ocurrió un problema al agregar los productos. " & mensaje, Me.comboBoxClientes.Text))
					End If
				Else

					MensajeError(mensaje)

				End If
			Else
				MensajeError("Debes añadir algún producto al pedido")
			End If
		Catch ex As Exception
			MensajeError(ex.Message)
		End Try
	End Sub

	Private Sub buttonCancelar_Click(sender As Object, e As EventArgs)
		Me.Close()
	End Sub

End Class
