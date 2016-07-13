Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports CapaNegocio

Public Partial Class FrmEditarProducto
	Inherits Form
	Private _owner As Productos
	Private Id_Producto As Integer

	Public Sub New()
		InitializeComponent()
	End Sub

	Public Sub New(owner As Productos)
		_owner = owner
		InitializeComponent()

		CargarCategorias()
		Me.Id_Producto = Convert.ToInt32(_owner.ObtenerSeleccion().Cells("ID").Value)
		Me.textBoxNombreProducto.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells("NOMBRE").Value)
		Me.comboBoxCategorias.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells("CATEGORÍA").Value)
		Me.textBoxPrecioUnitario.Text = Convert.ToDecimal(_owner.ObtenerSeleccion().Cells("PRECIO").Value).ToString("0.00##")
		Me.textBoxDetalles.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells("DETALLES DEL PRODUCTO").Value)
	End Sub

	Public Sub CargarCategorias()
		Me.comboBoxCategorias.DataSource = NCategorias.ListaCategorias()
		Me.comboBoxCategorias.ValueMember = "ID"
		Me.comboBoxCategorias.DisplayMember = "NOMBRE"
	End Sub

	Private Sub MensajeError(mensaje As String)
		MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
	End Sub

	Private Sub buttonCancelar_Click(sender As Object, e As EventArgs)
		Me.Close()
	End Sub

	Private Sub buttonGuardar_Click(sender As Object, e As EventArgs)
		Try
			'Por si alguna conversion de datos falla
			If [String].IsNullOrWhiteSpace(Me.textBoxNombreProducto.Text) OrElse [String].IsNullOrWhiteSpace(Me.comboBoxCategorias.Text) Then
				MensajeError("Los campos Nombre de Producto y Categoría son obligatorios")
			Else

				If [String].IsNullOrWhiteSpace(Me.textBoxPrecioUnitario.Text) Then
					Me.textBoxPrecioUnitario.Text = "0"
				End If

				Dim mensaje As [String] = NProductos.Editar(Me.Id_Producto, Me.textBoxNombreProducto.Text, Me.comboBoxCategorias.Text, Convert.ToDecimal(Convert.ToString(Me.textBoxPrecioUnitario.Text)), Me.textBoxDetalles.Text)

				If mensaje = "Y" Then
					Me._owner.Mensaje([String].Format("El Producto {0} ha sido EDITADO", Me.textBoxNombreProducto.Text))
					Me._owner.Refrescar()
					Me.Close()
				Else
					MensajeError(mensaje)
				End If
			End If
		Catch ex As Exception
			MensajeError("Los valores ingresados son incorrectos. " & ex.Message)
		End Try
	End Sub

	Private Sub textBoxPrecioUnitario_KeyPress(sender As Object, e As KeyPressEventArgs)
		If (e.KeyChar < 48 OrElse e.KeyChar > 57) AndAlso (e.KeyChar <> 8 AndAlso e.KeyChar <> ","C) Then
			e.Handled = True
		Else
			e.Handled = False
		End If
	End Sub

	Private Sub textBoxUnidadesStock_KeyPress(sender As Object, e As KeyPressEventArgs)
		If (e.KeyChar < 48 OrElse e.KeyChar > 57) AndAlso (e.KeyChar <> 8) Then
			e.Handled = True
		Else
			e.Handled = False
		End If
	End Sub

End Class
