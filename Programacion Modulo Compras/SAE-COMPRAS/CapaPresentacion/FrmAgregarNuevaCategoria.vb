Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports CapaNegocio

Public Partial Class FrmAgregarNuevaCategoria
	Inherits Form
	Private _owner As Categorias

	Public Sub New()
		InitializeComponent()
	End Sub

	Public Sub New(owner As Categorias)
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
		Dim mensaje As [String] = NCategorias.Insertar(Me.textBoxNombre.Text, Me.textBoxDescripcion.Text)

		If mensaje = "Y" Then
			Me._owner.Mensaje([String].Format("La Categoría {0} ha sido AGREGADA", Me.textBoxNombre.Text))
			Me._owner.Refrescar()
			Me.Close()
		Else
			MensajeError(mensaje)
		End If
	End Sub
End Class
