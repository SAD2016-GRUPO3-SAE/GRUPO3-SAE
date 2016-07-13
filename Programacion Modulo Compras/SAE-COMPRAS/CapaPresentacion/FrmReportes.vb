Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports CapaNegocio

Public Partial Class FrmReportes
	Inherits Form
	Private esCliente As Integer = 1
	Private esEmpleado As Integer = 0
	Private esProducto As Integer = 0

	Public Sub New()
		InitializeComponent()
		Me.dateTimePickerDesde.Value = DateTime.Now.AddDays(-365)
		Me.dateTimePickerHasta.Value = DateTime.Now
	End Sub

	Public Sub CargarComboBox()
		If esCliente = 1 Then
			Me.comboBox.DataSource = NProveedores.ListaProveedores()

		ElseIf esEmpleado = 1 Then
			Me.comboBox.DataSource = NEmpleados.ListaEmpleados()

		ElseIf esProducto = 1 Then
			Me.comboBox.DataSource = NProductos.ListaProductos()
		End If

		Me.comboBox.ValueMember = "ID"
		Me.comboBox.DisplayMember = "NOMBRE"
	End Sub

	Public Sub CargarGraficos()
		For Each series As var In chartTorta.Series
			series.Points.Clear()
		Next

		For Each series As var In chartHistorial.Series
			series.Points.Clear()
		Next

		If esCliente = 1 Then
			Me.labelR.Text = "LOS 10 MEJORES PROVEEDORES"
			Me.chartHistorial.DataSource = NReportes.MostrarHistorialProveedor(Me.dateTimePickerDesde.Value.ToString("yyyyMMdd"), Me.dateTimePickerHasta.Value.ToString("yyyyMMdd"), Me.comboBox.Text)

			Me.chartHistorial.Series("MONTO").YValueMembers = "MONTO"
			Me.chartHistorial.Series("MONTO").YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
			Me.chartHistorial.ChartAreas("ChartArea1").AxisY.Title = "SALDO $"

			Me.dataGridView.DataSource = NReportes.MostrarTop10Proveedores(Me.dateTimePickerDesde.Value.ToString("yyyyMMdd"), Me.dateTimePickerHasta.Value.ToString("yyyyMMdd"))

			Me.dataGridView.Columns(2).DefaultCellStyle.Format = "0.00#### $"

			Me.chartTorta.Series("Series1").XValueMember = "PROVEEDOR"
			Me.chartTorta.Series("Series1").YValueMembers = "SALDO"

			Me.chartTorta.DataSource = NReportes.MostrarTop10Proveedores(Me.dateTimePickerDesde.Value.ToString("yyyyMMdd"), Me.dateTimePickerHasta.Value.ToString("yyyyMMdd"))

		ElseIf esEmpleado = 1 Then
			Me.labelR.Text = "LOS 10 MEJORES EMPLEADOS"
			Me.chartHistorial.DataSource = NReportes.MostrarHistorialEmpleado(Me.dateTimePickerDesde.Value.ToString("yyyyMMdd"), Me.dateTimePickerHasta.Value.ToString("yyyyMMdd"), Me.comboBox.Text)

			Me.chartHistorial.Series("MONTO").YValueMembers = "MONTO"
			Me.chartHistorial.Series("MONTO").YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
			Me.chartHistorial.ChartAreas("ChartArea1").AxisY.Title = "SALDO $"

			Me.dataGridView.DataSource = NReportes.MostrarTop10Empleados(Me.dateTimePickerDesde.Value.ToString("yyyyMMdd"), Me.dateTimePickerHasta.Value.ToString("yyyyMMdd"))

			Me.dataGridView.Columns(2).DefaultCellStyle.Format = "0.00#### $"

			Me.chartTorta.Series("Series1").XValueMember = "EMPLEADO"
			Me.chartTorta.Series("Series1").YValueMembers = "SALDO"

			Me.chartTorta.DataSource = NReportes.MostrarTop10Empleados(Me.dateTimePickerDesde.Value.ToString("yyyyMMdd"), Me.dateTimePickerHasta.Value.ToString("yyyyMMdd"))

		ElseIf esProducto = 1 Then
			Me.labelR.Text = "LOS 10 MEJORES PRODUCTOS"
			Me.chartHistorial.DataSource = NReportes.MostrarHistorialProducto(Me.dateTimePickerDesde.Value.ToString("yyyyMMdd"), Me.dateTimePickerHasta.Value.ToString("yyyyMMdd"), Me.comboBox.Text)

			Me.chartHistorial.Series("MONTO").YValueMembers = "CANTIDAD"
			Me.chartHistorial.Series("MONTO").YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
			Me.chartHistorial.ChartAreas("ChartArea1").AxisY.Title = "CANTIDAD"

			Me.dataGridView.DataSource = NReportes.MostrarTop10Productos(Me.dateTimePickerDesde.Value.ToString("yyyyMMdd"), Me.dateTimePickerHasta.Value.ToString("yyyyMMdd"))

			Me.chartTorta.Series("Series1").XValueMember = "PRODUCTO"
			Me.chartTorta.Series("Series1").YValueMembers = "CANTIDAD"

			Me.chartTorta.DataSource = NReportes.MostrarTop10Productos(Me.dateTimePickerDesde.Value.ToString("yyyyMMdd"), Me.dateTimePickerHasta.Value.ToString("yyyyMMdd"))
		End If

		Me.dataGridView.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
		Me.dataGridView.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
		Me.dataGridView.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
		Me.dataGridView.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable

		chartTorta.Series(0)("PieLabelStyle") = "Outside"
		chartTorta.ChartAreas(0).Area3DStyle.Enable3D = True
		chartTorta.ChartAreas(0).Area3DStyle.Inclination = 0
		chartTorta.ChartAreas(0).Area3DStyle.Rotation = 0
		Me.chartTorta.Series(0).LegendText = "#PERCENT{P2}"
	End Sub

	Private Sub buttonGenerarReporte_Click(sender As Object, e As EventArgs)
		Try
			CargarGraficos()
		Catch ex As Exception
			MensajeError(ex.Message)
		End Try
	End Sub

	Private Sub FrmReportes_Load(sender As Object, e As EventArgs)
		Try
			CargarComboBox()
			CargarGraficos()
		Catch ex As Exception
			MensajeError(ex.Message)
		End Try
	End Sub

	Private Sub MensajeError(mensaje As String)
		MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
	End Sub

	Private Sub dataGridView_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs)
		Me.dataGridView.Rows(e.RowIndex).Cells(0).Value = (e.RowIndex + 1).ToString()
	End Sub

	Private Sub buttonRClientes_Click(sender As Object, e As EventArgs)
		esCliente = 1
		esEmpleado = 0
		esProducto = 0

		Try
			CargarComboBox()
			CargarGraficos()
		Catch ex As Exception
			MensajeError(ex.Message)
		End Try
	End Sub

	Private Sub buttonREmpleados_Click(sender As Object, e As EventArgs)
		esEmpleado = 1
		esCliente = 0
		esProducto = 0

		Try
			CargarComboBox()
			CargarGraficos()
		Catch ex As Exception
			MensajeError(ex.Message)
		End Try
	End Sub

	Private Sub buttonRProductos_Click(sender As Object, e As EventArgs)
		esProducto = 1
		esEmpleado = 0
		esCliente = 0

		Try
			CargarComboBox()
			CargarGraficos()
		Catch ex As Exception
			MensajeError(ex.Message)
		End Try
	End Sub

End Class
