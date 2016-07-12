Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports CapaNegocio

Public Partial Class FrmEditarProveedor
	Inherits Form
	Private _owner As Proveedores
	Private Id_Proveedor As Integer

	Public Sub New()
		InitializeComponent()
	End Sub

	Public Sub New(owner As Proveedores)
		_owner = owner
		InitializeComponent()

		Me.Id_Proveedor = Convert.ToInt32(_owner.ObtenerSeleccion().Cells("ID").Value)
		Me.textBoxNombreCliente.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells("PROVEEDOR").Value)
		Me.textBoxNombreContacto.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells("CONTACTO").Value)
		Me.textBoxDireccion.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells("DIRECCIÓN").Value)
		Me.textBoxCiudad.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells("CIUDAD").Value)
		Me.textBoxRegion.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells("REGIÓN").Value)
		Me.textBoxPais.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells("PAÍS").Value)
		Me.textBoxTelefono.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells("TELÉFONO").Value)
		Me.textBoxFax.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells("FAX").Value)
		Me.textBoxEmail.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells("EMAIL").Value)
	End Sub

	Private Sub MensajeError(mensaje As String)
		MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
	End Sub

	Private Sub buttonCancelar_Click(sender As Object, e As EventArgs)
		Me.Close()
	End Sub

	Private Sub buttonGuardar_Click(sender As Object, e As EventArgs)
		Dim mensaje As [String] = NProveedores.Editar(Me.Id_Proveedor, Me.textBoxNombreCliente.Text, Me.textBoxNombreContacto.Text, Me.textBoxDireccion.Text, Me.textBoxCiudad.Text, Me.textBoxRegion.Text, _
			Me.textBoxPais.Text, Me.textBoxTelefono.Text, Me.textBoxFax.Text, Me.textBoxEmail.Text)

		If mensaje = "Y" Then
			Me._owner.Mensaje([String].Format("El Proveedor {0} ha sido EDITADO", Me.textBoxNombreCliente.Text))
			Me._owner.Refrescar()
			Me.Close()
		Else
			MensajeError(mensaje)
		End If
	End Sub

	Private Sub labelNombreCliente_Click(sender As Object, e As EventArgs)

	End Sub
End Class
