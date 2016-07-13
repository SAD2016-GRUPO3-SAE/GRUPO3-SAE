Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports CapaNegocio

Public Partial Class FrmEditarEmpleado
	Inherits Form
	Private _owner As Empleados
	Private Id_Empleado As Integer

	Public Sub New()
		InitializeComponent()
	End Sub

	Public Sub New(owner As Empleados)
		_owner = owner
		InitializeComponent()

		Me.Id_Empleado = Convert.ToInt32(_owner.ObtenerSeleccion().Cells("ID").Value)
		Me.textBoxNombre.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells("NOMBRE").Value)
		Me.textBoxApellido.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells("APELLIDO").Value)
		Me.textBoxDireccion.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells("DIRECCIÓN").Value)
		Me.textBoxCiudad.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells("CIUDAD").Value)
		Me.textBoxRegion.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells("REGIÓN").Value)
		Me.textBoxPais.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells("PAÍS").Value)
		Me.textBoxTelefono.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells("TELÉFONO").Value)
	End Sub

	Private Sub MensajeError(mensaje As String)
		MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
	End Sub

	Private Sub buttonCancelar_Click(sender As Object, e As EventArgs)
		Me.Close()
	End Sub

	Private Sub buttonGuardar_Click(sender As Object, e As EventArgs)
		Dim mensaje As [String] = NEmpleados.Editar(Me.Id_Empleado, Me.textBoxNombre.Text, Me.textBoxApellido.Text, Me.textBoxDireccion.Text, Me.textBoxCiudad.Text, Me.textBoxRegion.Text, _
			Me.textBoxPais.Text, Me.textBoxTelefono.Text)

		If mensaje = "Y" Then
			Me._owner.Mensaje([String].Format("El Empleado {0}, {1} ha sido EDITADO", Me.textBoxApellido.Text, Me.textBoxNombre.Text))
			Me._owner.Refrescar()
			Me.Close()
		Else
			MensajeError(mensaje)
		End If
	End Sub
End Class
