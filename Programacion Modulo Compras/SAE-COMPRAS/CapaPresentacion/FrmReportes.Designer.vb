Partial Class FrmReportes
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Windows Form Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Dim chartArea1 As New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim legend1 As New System.Windows.Forms.DataVisualization.Charting.Legend()
		Dim series1 As New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim dataGridViewCellStyle1 As New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle2 As New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle3 As New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle4 As New System.Windows.Forms.DataGridViewCellStyle()
		Dim chartArea2 As New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim series2 As New System.Windows.Forms.DataVisualization.Charting.Series()
		Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.buttonRProductos = New System.Windows.Forms.Button()
		Me.buttonREmpleados = New System.Windows.Forms.Button()
		Me.buttonRClientes = New System.Windows.Forms.Button()
		Me.tableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
		Me.comboBox = New System.Windows.Forms.ComboBox()
		Me.buttonGenerarReporte = New System.Windows.Forms.Button()
		Me.tableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
		Me.dateTimePickerDesde = New System.Windows.Forms.DateTimePicker()
		Me.labelDesde = New System.Windows.Forms.Label()
		Me.tableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
		Me.labelHasta = New System.Windows.Forms.Label()
		Me.dateTimePickerHasta = New System.Windows.Forms.DateTimePicker()
		Me.tableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
		Me.tableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
		Me.tableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
		Me.chartTorta = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.tableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
		Me.dataGridView = New System.Windows.Forms.DataGridView()
		Me.Ranking = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.labelR = New System.Windows.Forms.Label()
		Me.chartHistorial = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.tableLayoutPanel1.SuspendLayout()
		Me.tableLayoutPanel2.SuspendLayout()
		Me.tableLayoutPanel5.SuspendLayout()
		Me.tableLayoutPanel6.SuspendLayout()
		Me.tableLayoutPanel7.SuspendLayout()
		Me.tableLayoutPanel3.SuspendLayout()
		Me.tableLayoutPanel4.SuspendLayout()
		Me.tableLayoutPanel8.SuspendLayout()
		DirectCast(Me.chartTorta, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.tableLayoutPanel9.SuspendLayout()
		DirectCast(Me.dataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.chartHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		' 
		' tableLayoutPanel1
		' 
		Me.tableLayoutPanel1.ColumnCount = 1
		Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanel1.Controls.Add(Me.tableLayoutPanel2, 0, 0)
		Me.tableLayoutPanel1.Controls.Add(Me.tableLayoutPanel3, 0, 1)
		Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
		Me.tableLayoutPanel1.RowCount = 2
		Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.76702F))
		Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.23298F))
		Me.tableLayoutPanel1.Size = New System.Drawing.Size(984, 661)
		Me.tableLayoutPanel1.TabIndex = 0
		' 
		' tableLayoutPanel2
		' 
		Me.tableLayoutPanel2.ColumnCount = 5
		Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F))
		Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F))
		Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F))
		Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.959785F))
		Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.04021F))
		Me.tableLayoutPanel2.Controls.Add(Me.buttonRProductos, 2, 0)
		Me.tableLayoutPanel2.Controls.Add(Me.buttonREmpleados, 1, 0)
		Me.tableLayoutPanel2.Controls.Add(Me.buttonRClientes, 0, 0)
		Me.tableLayoutPanel2.Controls.Add(Me.tableLayoutPanel5, 4, 0)
		Me.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
		Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
		Me.tableLayoutPanel2.RowCount = 1
		Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
		Me.tableLayoutPanel2.Size = New System.Drawing.Size(978, 85)
		Me.tableLayoutPanel2.TabIndex = 0
		' 
		' buttonRProductos
		' 
		Me.buttonRProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonRProductos.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.buttonRProductos.Image = Global.CapaPresentacion.Properties.Resources.productos
		Me.buttonRProductos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.buttonRProductos.Location = New System.Drawing.Point(156, 0)
		Me.buttonRProductos.Margin = New System.Windows.Forms.Padding(0)
		Me.buttonRProductos.Name = "buttonRProductos"
		Me.buttonRProductos.Size = New System.Drawing.Size(76, 85)
		Me.buttonRProductos.TabIndex = 2
		Me.buttonRProductos.Text = "Productos"
		Me.buttonRProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.buttonRProductos.UseVisualStyleBackColor = False
		AddHandler Me.buttonRProductos.Click, New System.EventHandler(AddressOf Me.buttonRProductos_Click)
		' 
		' buttonREmpleados
		' 
		Me.buttonREmpleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonREmpleados.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.buttonREmpleados.Image = Global.CapaPresentacion.Properties.Resources.empleados
		Me.buttonREmpleados.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.buttonREmpleados.Location = New System.Drawing.Point(78, 0)
		Me.buttonREmpleados.Margin = New System.Windows.Forms.Padding(0)
		Me.buttonREmpleados.Name = "buttonREmpleados"
		Me.buttonREmpleados.Size = New System.Drawing.Size(78, 85)
		Me.buttonREmpleados.TabIndex = 1
		Me.buttonREmpleados.Text = "Empleados"
		Me.buttonREmpleados.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.buttonREmpleados.UseVisualStyleBackColor = False
		AddHandler Me.buttonREmpleados.Click, New System.EventHandler(AddressOf Me.buttonREmpleados_Click)
		' 
		' buttonRClientes
		' 
		Me.buttonRClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonRClientes.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.buttonRClientes.Image = Global.CapaPresentacion.Properties.Resources.clientes
		Me.buttonRClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.buttonRClientes.Location = New System.Drawing.Point(0, 0)
		Me.buttonRClientes.Margin = New System.Windows.Forms.Padding(0)
		Me.buttonRClientes.Name = "buttonRClientes"
		Me.buttonRClientes.Size = New System.Drawing.Size(78, 85)
		Me.buttonRClientes.TabIndex = 0
		Me.buttonRClientes.Text = "Clientes"
		Me.buttonRClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.buttonRClientes.UseVisualStyleBackColor = False
		AddHandler Me.buttonRClientes.Click, New System.EventHandler(AddressOf Me.buttonRClientes_Click)
		' 
		' tableLayoutPanel5
		' 
		Me.tableLayoutPanel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tableLayoutPanel5.ColumnCount = 2
		Me.tableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.77841F))
		Me.tableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.22159F))
		Me.tableLayoutPanel5.Controls.Add(Me.comboBox, 0, 1)
		Me.tableLayoutPanel5.Controls.Add(Me.buttonGenerarReporte, 1, 1)
		Me.tableLayoutPanel5.Controls.Add(Me.tableLayoutPanel6, 0, 0)
		Me.tableLayoutPanel5.Controls.Add(Me.tableLayoutPanel7, 1, 0)
		Me.tableLayoutPanel5.Location = New System.Drawing.Point(271, 3)
		Me.tableLayoutPanel5.Name = "tableLayoutPanel5"
		Me.tableLayoutPanel5.RowCount = 2
		Me.tableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.36709F))
		Me.tableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.63291F))
		Me.tableLayoutPanel5.Size = New System.Drawing.Size(704, 79)
		Me.tableLayoutPanel5.TabIndex = 3
		' 
		' comboBox
		' 
		Me.comboBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBox.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.comboBox.FormattingEnabled = True
		Me.comboBox.Location = New System.Drawing.Point(3, 41)
		Me.comboBox.Name = "comboBox"
		Me.comboBox.Size = New System.Drawing.Size(443, 34)
		Me.comboBox.TabIndex = 5
		' 
		' buttonGenerarReporte
		' 
		Me.buttonGenerarReporte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonGenerarReporte.BackColor = System.Drawing.Color.Orange
		Me.buttonGenerarReporte.Font = New System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.buttonGenerarReporte.Location = New System.Drawing.Point(452, 40)
		Me.buttonGenerarReporte.Margin = New System.Windows.Forms.Padding(3, 2, 3, 3)
		Me.buttonGenerarReporte.Name = "buttonGenerarReporte"
		Me.buttonGenerarReporte.Size = New System.Drawing.Size(249, 36)
		Me.buttonGenerarReporte.TabIndex = 6
		Me.buttonGenerarReporte.Text = "Generar Reporte"
		Me.buttonGenerarReporte.UseVisualStyleBackColor = False
		AddHandler Me.buttonGenerarReporte.Click, New System.EventHandler(AddressOf Me.buttonGenerarReporte_Click)
		' 
		' tableLayoutPanel6
		' 
		Me.tableLayoutPanel6.ColumnCount = 2
		Me.tableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.59821F))
		Me.tableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.40179F))
		Me.tableLayoutPanel6.Controls.Add(Me.dateTimePickerDesde, 1, 0)
		Me.tableLayoutPanel6.Controls.Add(Me.labelDesde, 0, 0)
		Me.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tableLayoutPanel6.Location = New System.Drawing.Point(0, 0)
		Me.tableLayoutPanel6.Margin = New System.Windows.Forms.Padding(0)
		Me.tableLayoutPanel6.Name = "tableLayoutPanel6"
		Me.tableLayoutPanel6.RowCount = 1
		Me.tableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanel6.Size = New System.Drawing.Size(449, 38)
		Me.tableLayoutPanel6.TabIndex = 3
		' 
		' dateTimePickerDesde
		' 
		Me.dateTimePickerDesde.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.dateTimePickerDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.dateTimePickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dateTimePickerDesde.Location = New System.Drawing.Point(270, 3)
		Me.dateTimePickerDesde.Name = "dateTimePickerDesde"
		Me.dateTimePickerDesde.Size = New System.Drawing.Size(176, 31)
		Me.dateTimePickerDesde.TabIndex = 3
		Me.dateTimePickerDesde.Value = New System.DateTime(2014, 7, 8, 0, 0, 0, _
			0)
		' 
		' labelDesde
		' 
		Me.labelDesde.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.labelDesde.AutoSize = True
		Me.labelDesde.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelDesde.Location = New System.Drawing.Point(190, 6)
		Me.labelDesde.Name = "labelDesde"
		Me.labelDesde.Size = New System.Drawing.Size(74, 26)
		Me.labelDesde.TabIndex = 3
		Me.labelDesde.Text = "Desde:"
		' 
		' tableLayoutPanel7
		' 
		Me.tableLayoutPanel7.ColumnCount = 2
		Me.tableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.6F))
		Me.tableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.4F))
		Me.tableLayoutPanel7.Controls.Add(Me.labelHasta, 0, 0)
		Me.tableLayoutPanel7.Controls.Add(Me.dateTimePickerHasta, 1, 0)
		Me.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tableLayoutPanel7.Location = New System.Drawing.Point(449, 0)
		Me.tableLayoutPanel7.Margin = New System.Windows.Forms.Padding(0)
		Me.tableLayoutPanel7.Name = "tableLayoutPanel7"
		Me.tableLayoutPanel7.RowCount = 1
		Me.tableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanel7.Size = New System.Drawing.Size(255, 38)
		Me.tableLayoutPanel7.TabIndex = 5
		' 
		' labelHasta
		' 
		Me.labelHasta.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelHasta.AutoSize = True
		Me.labelHasta.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelHasta.Location = New System.Drawing.Point(3, 6)
		Me.labelHasta.Name = "labelHasta"
		Me.labelHasta.Size = New System.Drawing.Size(68, 26)
		Me.labelHasta.TabIndex = 4
		Me.labelHasta.Text = "Hasta:"
		' 
		' dateTimePickerHasta
		' 
		Me.dateTimePickerHasta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.dateTimePickerHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.dateTimePickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dateTimePickerHasta.Location = New System.Drawing.Point(78, 3)
		Me.dateTimePickerHasta.Name = "dateTimePickerHasta"
		Me.dateTimePickerHasta.Size = New System.Drawing.Size(174, 31)
		Me.dateTimePickerHasta.TabIndex = 4
		' 
		' tableLayoutPanel3
		' 
		Me.tableLayoutPanel3.ColumnCount = 1
		Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanel3.Controls.Add(Me.tableLayoutPanel4, 0, 1)
		Me.tableLayoutPanel3.Controls.Add(Me.chartHistorial, 0, 0)
		Me.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tableLayoutPanel3.Location = New System.Drawing.Point(3, 94)
		Me.tableLayoutPanel3.Name = "tableLayoutPanel3"
		Me.tableLayoutPanel3.RowCount = 2
		Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 336F))
		Me.tableLayoutPanel3.Size = New System.Drawing.Size(978, 564)
		Me.tableLayoutPanel3.TabIndex = 1
		' 
		' tableLayoutPanel4
		' 
		Me.tableLayoutPanel4.ColumnCount = 2
		Me.tableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.21473F))
		Me.tableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.78527F))
		Me.tableLayoutPanel4.Controls.Add(Me.tableLayoutPanel8, 0, 0)
		Me.tableLayoutPanel4.Controls.Add(Me.tableLayoutPanel9, 1, 0)
		Me.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tableLayoutPanel4.Location = New System.Drawing.Point(0, 228)
		Me.tableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
		Me.tableLayoutPanel4.Name = "tableLayoutPanel4"
		Me.tableLayoutPanel4.RowCount = 1
		Me.tableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanel4.Size = New System.Drawing.Size(978, 336)
		Me.tableLayoutPanel4.TabIndex = 1
		' 
		' tableLayoutPanel8
		' 
		Me.tableLayoutPanel8.ColumnCount = 1
		Me.tableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
		Me.tableLayoutPanel8.Controls.Add(Me.chartTorta, 0, 0)
		Me.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tableLayoutPanel8.Location = New System.Drawing.Point(3, 3)
		Me.tableLayoutPanel8.Name = "tableLayoutPanel8"
		Me.tableLayoutPanel8.RowCount = 1
		Me.tableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
		Me.tableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 330F))
		Me.tableLayoutPanel8.Size = New System.Drawing.Size(534, 330)
		Me.tableLayoutPanel8.TabIndex = 1
		' 
		' chartTorta
		' 
		chartArea1.Area3DStyle.Inclination = 50
		chartArea1.Area3DStyle.IsRightAngleAxes = False
		chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.None
		chartArea1.Name = "ChartArea1"
		Me.chartTorta.ChartAreas.Add(chartArea1)
		Me.chartTorta.Dock = System.Windows.Forms.DockStyle.Fill
		legend1.AutoFitMinFontSize = 10
		legend1.Name = "Legend1"
		legend1.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.chartTorta.Legends.Add(legend1)
		Me.chartTorta.Location = New System.Drawing.Point(0, 0)
		Me.chartTorta.Margin = New System.Windows.Forms.Padding(0)
		Me.chartTorta.Name = "chartTorta"
		Me.chartTorta.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
		series1.ChartArea = "ChartArea1"
		series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
		series1.Legend = "Legend1"
		series1.Name = "Series1"
		series1.SmartLabelStyle.Enabled = False
		series1.XValueMember = "CLIENTE"
		series1.YValueMembers = "SALDO"
		Me.chartTorta.Series.Add(series1)
		Me.chartTorta.Size = New System.Drawing.Size(534, 330)
		Me.chartTorta.TabIndex = 0
		Me.chartTorta.Text = "chart1"
		' 
		' tableLayoutPanel9
		' 
		Me.tableLayoutPanel9.ColumnCount = 1
		Me.tableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanel9.Controls.Add(Me.dataGridView, 0, 1)
		Me.tableLayoutPanel9.Controls.Add(Me.labelR, 0, 0)
		Me.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tableLayoutPanel9.Location = New System.Drawing.Point(543, 3)
		Me.tableLayoutPanel9.Name = "tableLayoutPanel9"
		Me.tableLayoutPanel9.RowCount = 2
		Me.tableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.41096F))
		Me.tableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.58904F))
		Me.tableLayoutPanel9.Size = New System.Drawing.Size(432, 330)
		Me.tableLayoutPanel9.TabIndex = 2
		' 
		' dataGridView
		' 
		Me.dataGridView.AllowUserToAddRows = False
		Me.dataGridView.AllowUserToDeleteRows = False
		Me.dataGridView.AllowUserToResizeRows = False
		dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue
		dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop
		dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue
		dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control
		Me.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1
		Me.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
		Me.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
		Me.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
		Me.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
		Me.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonShadow
		dataGridViewCellStyle2.Font = New System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold)
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
		Me.dataGridView.ColumnHeadersHeight = 50
		Me.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
		Me.dataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ranking})
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
		dataGridViewCellStyle3.Font = New System.Drawing.Font("Candara", 15F)
		dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Desktop
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dataGridView.DefaultCellStyle = dataGridViewCellStyle3
		Me.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill
		Me.dataGridView.EnableHeadersVisualStyles = False
		Me.dataGridView.Location = New System.Drawing.Point(0, 50)
		Me.dataGridView.Margin = New System.Windows.Forms.Padding(0)
		Me.dataGridView.MultiSelect = False
		Me.dataGridView.Name = "dataGridView"
		Me.dataGridView.[ReadOnly] = True
		Me.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
		dataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
		Me.dataGridView.RowHeadersVisible = False
		Me.dataGridView.RowTemplate.[ReadOnly] = True
		Me.dataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dataGridView.ShowCellErrors = False
		Me.dataGridView.ShowCellToolTips = False
		Me.dataGridView.ShowEditingIcon = False
		Me.dataGridView.ShowRowErrors = False
		Me.dataGridView.Size = New System.Drawing.Size(432, 280)
		Me.dataGridView.TabIndex = 7
		AddHandler Me.dataGridView.RowPrePaint, New System.Windows.Forms.DataGridViewRowPrePaintEventHandler(AddressOf Me.dataGridView_RowPrePaint)
		' 
		' Ranking
		' 
		Me.Ranking.HeaderText = ""
		Me.Ranking.Name = "Ranking"
		Me.Ranking.[ReadOnly] = True
		Me.Ranking.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
		Me.Ranking.Width = 5
		' 
		' labelR
		' 
		Me.labelR.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelR.AutoSize = True
		Me.labelR.Font = New System.Drawing.Font("Candara", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelR.ForeColor = System.Drawing.SystemColors.ButtonShadow
		Me.labelR.Location = New System.Drawing.Point(3, 6)
		Me.labelR.Name = "labelR"
		Me.labelR.Size = New System.Drawing.Size(80, 38)
		Me.labelR.TabIndex = 5
		Me.labelR.Text = "NNN"
		' 
		' chartHistorial
		' 
		Me.chartHistorial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		chartArea2.AxisX.Interval = 1.0
		chartArea2.AxisX.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Straight
		chartArea2.AxisX.ScaleBreakStyle.CollapsibleSpaceThreshold = 10
		chartArea2.AxisX.ScaleBreakStyle.Enabled = True
		chartArea2.AxisX.Title = "MES / AÑO"
		chartArea2.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		chartArea2.AxisY.Title = "MONTO $"
		chartArea2.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		chartArea2.Name = "ChartArea1"
		Me.chartHistorial.ChartAreas.Add(chartArea2)
		Me.chartHistorial.Location = New System.Drawing.Point(3, 3)
		Me.chartHistorial.Name = "chartHistorial"
		Me.chartHistorial.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel
		series2.ChartArea = "ChartArea1"
		series2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		series2.IsValueShownAsLabel = True
		series2.LabelBackColor = System.Drawing.Color.FromArgb(CInt(CByte(224)), CInt(CByte(224)), CInt(CByte(224)))
		series2.LabelBorderColor = System.Drawing.Color.FromArgb(CInt(CByte(224)), CInt(CByte(224)), CInt(CByte(224)))
		series2.Name = "MONTO"
		series2.XValueMember = "PERIODO"
		series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[String]
		series2.YValueMembers = "MONTO"
		series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
		Me.chartHistorial.Series.Add(series2)
		Me.chartHistorial.Size = New System.Drawing.Size(972, 222)
		Me.chartHistorial.TabIndex = 2
		Me.chartHistorial.Text = "chart1"
		' 
		' FrmReportes
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(992, 673)
		Me.Controls.Add(Me.tableLayoutPanel1)
		Me.MaximizeBox = False
		Me.MaximumSize = New System.Drawing.Size(1000, 700)
		Me.MinimumSize = New System.Drawing.Size(1000, 700)
		Me.Name = "FrmReportes"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Administración de Reportes"
		AddHandler Me.Load, New System.EventHandler(AddressOf Me.FrmReportes_Load)
		Me.tableLayoutPanel1.ResumeLayout(False)
		Me.tableLayoutPanel2.ResumeLayout(False)
		Me.tableLayoutPanel5.ResumeLayout(False)
		Me.tableLayoutPanel6.ResumeLayout(False)
		Me.tableLayoutPanel6.PerformLayout()
		Me.tableLayoutPanel7.ResumeLayout(False)
		Me.tableLayoutPanel7.PerformLayout()
		Me.tableLayoutPanel3.ResumeLayout(False)
		Me.tableLayoutPanel4.ResumeLayout(False)
		Me.tableLayoutPanel8.ResumeLayout(False)
		DirectCast(Me.chartTorta, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tableLayoutPanel9.ResumeLayout(False)
		Me.tableLayoutPanel9.PerformLayout()
		DirectCast(Me.dataGridView, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.chartHistorial, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Private tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
	Private tableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
	Private tableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
	Private buttonRProductos As System.Windows.Forms.Button
	Private buttonREmpleados As System.Windows.Forms.Button
	Private buttonRClientes As System.Windows.Forms.Button
	Private tableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
	Private comboBox As System.Windows.Forms.ComboBox
	Private buttonGenerarReporte As System.Windows.Forms.Button
	Private dateTimePickerDesde As System.Windows.Forms.DateTimePicker
	Private dateTimePickerHasta As System.Windows.Forms.DateTimePicker
	Private tableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
	Private labelDesde As System.Windows.Forms.Label
	Private tableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
	Private labelHasta As System.Windows.Forms.Label
	Private chartTorta As System.Windows.Forms.DataVisualization.Charting.Chart
	Private chartHistorial As System.Windows.Forms.DataVisualization.Charting.Chart
	Private tableLayoutPanel8 As System.Windows.Forms.TableLayoutPanel
	Private labelR As System.Windows.Forms.Label
	Private tableLayoutPanel9 As System.Windows.Forms.TableLayoutPanel
	Private dataGridView As System.Windows.Forms.DataGridView
	Private Ranking As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
