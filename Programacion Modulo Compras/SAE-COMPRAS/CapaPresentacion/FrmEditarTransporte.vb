Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports CapaNegocio

Public Partial Class FrmEditarTransporte
	Inherits Form
	Private _owner As Transporte
	Private Id_Transportista As Integer

	Public Sub New()
		InitializeComponent()
	End Sub

	Public Sub New(owner As Transporte)
		_owner = owner
		InitializeComponent()

		Me.Id_Transportista = Convert.ToInt32(_owner.ObtenerSeleccion().Cells("ID").Value)
		Me.textBoxNombre.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells("NOMBRE").Value)
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
		'No importa el try ya que no hay conversiones
		Dim mensaje As [String] = NTransportistas.Editar(Me.Id_Transportista, Me.textBoxNombre.Text, Me.textBoxDireccion.Text, Me.textBoxCiudad.Text, Me.textBoxRegion.Text, Me.textBoxPais.Text, _
			Me.textBoxTelefono.Text)

		If mensaje = "Y" Then
			Me._owner.Mensaje([String].Format("El Transporte {0} ha sido EDITADO", Me.textBoxNombre.Text))
			Me._owner.Refrescar()
			Me.Close()
		Else
			MensajeError(mensaje)
		End If
	End Sub
End Class
