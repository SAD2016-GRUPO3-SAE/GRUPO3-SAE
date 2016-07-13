Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports CapaNegocio

Public Partial Class FrmAgregarNuevoTransporte
	Inherits Form
	Private _owner As Transporte

	Public Sub New()
		InitializeComponent()
	End Sub

	Public Sub New(owner As Transporte)
		_owner = owner
		InitializeComponent()
	End Sub

	Private Sub MensajeError(mensaje As String)
		MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
	End Sub

	Private Sub buttonCancelar_Click(sender As Object, e As EventArgs)
		Me.Close()
	End Sub

	Private Sub buttonGuardar_Click(sender As Object, e As EventArgs)
		Dim mensaje As [String] = NTransportistas.Insertar(Me.textBoxNombre.Text, Me.textBoxDireccion.Text, Me.textBoxCiudad.Text, Me.textBoxRegion.Text, Me.textBoxPais.Text, Me.textBoxTelefono.Text)

		If mensaje = "Y" Then
			Me._owner.Mensaje([String].Format("El Transporte {0} ha sido AGREGADO", Me.textBoxNombre.Text))
			Me._owner.Refrescar()
			Me.Close()
		Else
			MensajeError(mensaje)
		End If
	End Sub
End Class
