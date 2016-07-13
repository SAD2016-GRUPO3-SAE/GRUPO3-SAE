Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports CapaNegocio
Imports System.IO

Public Partial Class FrmInicio
	Inherits Form
	Private empleados As Empleados
	Private transporte As Transporte
	Private proveedores As Proveedores
	Private categorias As Categorias
	Private productos As Productos
	Private ordenes As Ordenes
	Private reportes As FrmReportes

	Public Sub New()
		Dim mensaje As [String] = NConexion.ChequearConexion()
		If mensaje = "Y" Then
			InitializeComponent()
			Iniciar()
		Else
			MessageBox.Show("El Sistema de Compras no se puede iniciar ya que existió un error al conectarse con la Base de Datos. " & mensaje, "Error al iniciar el Sistema de Compras", MessageBoxButtons.OK, MessageBoxIcon.[Error])
			Me.Dispose()
		End If
	End Sub

	Public Sub Iniciar()
		' ordenes = new Ordenes();
		' this.panelContenedor.Controls.Clear();
		' this.panelContenedor.Controls.Add(ordenes);
	End Sub

	'private void buttonEmpleados_Click(object sender, EventArgs e)
'        {
'            if (empleados == null)
'            {
'                empleados = new Empleados();
'                this.panelContenedor.Controls.Clear();
'                this.panelContenedor.Controls.Add(empleados);
'            }
'            else
'            {
'                this.panelContenedor.Controls.Clear();
'                this.panelContenedor.Controls.Add(empleados);
'            }
'        }
'
'        private void buttonTransporte_Click(object sender, EventArgs e)
'        {
'            if (transporte == null)
'            {
'                transporte = new Transporte();
'                this.panelContenedor.Controls.Clear();
'                this.panelContenedor.Controls.Add(transporte);
'            }
'            else
'            {
'                this.panelContenedor.Controls.Clear();
'                this.panelContenedor.Controls.Add(transporte);
'            }
'        }
'
'        private void buttonClientes_Click(object sender, EventArgs e)
'        {
'            if (proveedores == null)
'            {
'                proveedores = new Proveedores();
'                this.panelContenedor.Controls.Clear();
'                this.panelContenedor.Controls.Add(proveedores);
'            }
'            else
'            {
'                this.panelContenedor.Controls.Clear();
'                this.panelContenedor.Controls.Add(proveedores);
'            }
'        }
'
'        private void buttonCategorias_Click(object sender, EventArgs e)
'        {
'            if (categorias == null)
'            {
'                categorias = new Categorias();
'                this.panelContenedor.Controls.Clear();
'                this.panelContenedor.Controls.Add(categorias);
'            }
'            else
'            {
'                this.panelContenedor.Controls.Clear();
'                this.panelContenedor.Controls.Add(categorias);
'            }
'        }
'
'        private void buttonProductos_Click(object sender, EventArgs e)
'        {
'            if (productos == null)
'            {
'                productos = new Productos();
'                this.panelContenedor.Controls.Clear();
'                this.panelContenedor.Controls.Add(productos);
'            }
'            else
'            {
'                this.panelContenedor.Controls.Clear();
'                this.panelContenedor.Controls.Add(productos);
'            }
'        }
'
'        private void buttonPedidos_Click(object sender, EventArgs e)
'        {
'            if (ordenes == null)
'            {
'                ordenes = new Ordenes();
'                this.panelContenedor.Controls.Clear();
'                this.panelContenedor.Controls.Add(ordenes);
'            }
'            else
'            {
'                this.panelContenedor.Controls.Clear();
'                this.panelContenedor.Controls.Add(ordenes);
'            }
'        }
'
'        private void buttonReportes_Click(object sender, EventArgs e)
'        {
'            try
'            {
'                FrmReportes administracionReportes = new FrmReportes();
'                administracionReportes.ShowDialog();
'            }
'
'            catch (Exception ex)
'            {
'                MensajeError(ex.Message);
'            }
'        }


	Public Sub MensajeError(mensaje As String)
		MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
	End Sub


	Private Sub salirToolStripMenuItem_Click(sender As Object, e As EventArgs)
		Me.Close()
	End Sub


	Private Sub salirToolStripMenuItem1_Click(sender As Object, e As EventArgs)
		Me.Close()
	End Sub

	Private Sub ordenesDeCompraToolStripMenuItem_Click(sender As Object, e As EventArgs)
		' if (ordenes == null)
'            {
'                ordenes = new Ordenes();
'                this.panelContenedor.Controls.Clear();
'                this.panelContenedor.Controls.Add(ordenes);
'
'            }
'            else
'            {
'                this.panelContenedor.Controls.Clear();
'                this.panelContenedor.Controls.Add(ordenes);
'            }


		ordenes = New Ordenes()
		ordenes.Show()

	End Sub

	Private Sub productoToolStripMenuItem_Click(sender As Object, e As EventArgs)
		'if (productos == null)
'            {
'                productos = new Productos();
'                this.panelContenedor.Controls.Clear();
'                this.panelContenedor.Controls.Add(productos);
'            }
'            else
'            {
'                this.panelContenedor.Controls.Clear();
'                this.panelContenedor.Controls.Add(productos);
'            }


		productos = New Productos()
		productos.Show()
	End Sub

	Private Sub proveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs)
		'if (proveedores == null)
'            {
'                proveedores = new Proveedores();
'                this.panelContenedor.Controls.Clear();
'                this.panelContenedor.Controls.Add(proveedores);
'            }
'            else
'            {
'                this.panelContenedor.Controls.Clear();
'                this.panelContenedor.Controls.Add(proveedores);
'            }


		proveedores = New Proveedores()
		proveedores.Show()
	End Sub

	Private Sub categoriasToolStripMenuItem_Click(sender As Object, e As EventArgs)
		' if (categorias == null)
'             {
'                 categorias = new Categorias();
'                 this.panelContenedor.Controls.Clear();
'                 this.panelContenedor.Controls.Add(categorias);
'             }
'             else
'             {
'                 this.panelContenedor.Controls.Clear();
'                 this.panelContenedor.Controls.Add(categorias);
'             }


		categorias = New Categorias()
		categorias.Show()

	End Sub

	Private Sub transporteToolStripMenuItem_Click(sender As Object, e As EventArgs)
		' if (transporte == null)
'             {
'                 transporte = new Transporte();
'                 this.panelContenedor.Controls.Clear();
'                 this.panelContenedor.Controls.Add(transporte);
'             }
'             else
'             {
'                 this.panelContenedor.Controls.Clear();
'                 this.panelContenedor.Controls.Add(transporte);
'             }

		transporte = New Transporte()
		transporte.Show()
	End Sub

	Private Sub usuariosToolStripMenuItem_Click(sender As Object, e As EventArgs)
		'if (empleados == null)
'            {
'                empleados = new Empleados();
'                this.panelContenedor.Controls.Clear();
'                this.panelContenedor.Controls.Add(empleados);
'            }
'            else
'            {
'                this.panelContenedor.Controls.Clear();
'                this.panelContenedor.Controls.Add(empleados);
'            }


		empleados = New Empleados()
		empleados.Show()

	End Sub

	Private Sub reportesToolStripMenuItem_Click(sender As Object, e As EventArgs)
		'try
'            {
'                FrmReportes administracionReportes = new FrmReportes();
'                administracionReportes.ShowDialog();
'            }
'
'            catch (Exception ex)
'            {
'                MensajeError(ex.Message);
'            }


		reportes = New FrmReportes()
		reportes.Show()
	End Sub


	Private Sub reportesToolStripMenuItem1_Click(sender As Object, e As EventArgs)
		Try
			Dim administracionReportes As New FrmReportes()
			administracionReportes.ShowDialog()

		Catch ex As Exception
			MensajeError(ex.Message)
		End Try
	End Sub


End Class


