Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports CapaNegocio

Public Partial Class FrmEditarCategoria
	Inherits Form
	Private _owner As Categorias
	Private Id_Categoria As Integer

	Public Sub New()
		InitializeComponent()
	End Sub

	Public Sub New(owner As Categorias)
		_owner = owner
		InitializeComponent()

		Me.Id_Categoria = Convert.ToInt32(_owner.ObtenerSeleccion().Cells("ID").Value)
		Me.textBoxNombre.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells("NOMBRE").Value)
		Me.textBoxDescripcion.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells("DESCRIPCIÓN").Value)
	End Sub

	Private Sub MensajeError(mensaje As String)
		MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
	End Sub

	Private Sub buttonCancelar_Click(sender As Object, e As EventArgs)
		Me.Close()
	End Sub

	Private Sub buttonGuardar_Click(sender As Object, e As EventArgs)
		Dim mensaje As [String] = NCategorias.Editar(Me.Id_Categoria, Me.textBoxNombre.Text, Me.textBoxDescripcion.Text)

		If mensaje = "Y" Then
			Me._owner.Mensaje([String].Format("La Categoría {0} ha sido EDITADA", Me.textBoxNombre.Text))
			Me._owner.Refrescar()
			Me.Close()
		Else

			MensajeError(mensaje)
		End If
	End Sub
End Class
