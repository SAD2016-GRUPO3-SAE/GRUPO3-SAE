Imports CapaNegocio
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Public Partial Class FrmMarcarPendiente
	Inherits Form
	Private _owner As Ordenes

	Public Sub New()
		InitializeComponent()
	End Sub

	Public Sub New(owner As Ordenes)
		Me._owner = owner
		InitializeComponent()

		Me.labelNombre.Text = [String].Format("¿Marcar el Pedido {0} entregado el {1} como Pendiente?", Me._owner.ObtenerSeleccionPedidos().Cells(2).Value.ToString(), Convert.ToDateTime(Me._owner.ObtenerSeleccionPedidos().Cells(7).Value).ToString("dd/MM/yyyy"))
	End Sub

	Private Sub buttonAceptar_Click(sender As Object, e As EventArgs)
		Dim mensaje As [String] = ""

		mensaje = NOrdenes.MarcarEntregadoPendiente(Convert.ToInt32(Me._owner.ObtenerSeleccionPedidos().Cells(1).Value), Nothing)

		If mensaje = "Y" Then
			Me._owner.Mensaje([String].Format("El Pedido {0} para {1} ha sido marcado como PENDIENTE", Me._owner.ObtenerSeleccionPedidos().Cells(2).Value.ToString(), Me._owner.ObtenerSeleccionPedidos().Cells(3).Value.ToString()))
			Me._owner.Refrescar()
			Me.Close()
		Else

			Me._owner.MensajeError(mensaje)
		End If
	End Sub

	Private Sub buttonCancelar_Click(sender As Object, e As EventArgs)
		Me.Close()
	End Sub
End Class
