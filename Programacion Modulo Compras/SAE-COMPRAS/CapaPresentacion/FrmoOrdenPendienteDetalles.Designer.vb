Partial Class FrmoOrdenPendienteDetalles
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
		Me.components = New System.ComponentModel.Container()
		Dim dataGridViewCellStyle1 As New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle2 As New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle3 As New System.Windows.Forms.DataGridViewCellStyle()
		Me.tableLayoutPanelGeneral = New System.Windows.Forms.TableLayoutPanel()
		Me.tableLayoutPanelLeft = New System.Windows.Forms.TableLayoutPanel()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.tableLayoutPanelCentral = New System.Windows.Forms.TableLayoutPanel()
		Me.tableLayoutPanelTop = New System.Windows.Forms.TableLayoutPanel()
		Me.labelCliente = New System.Windows.Forms.Label()
		Me.labelTransporte = New System.Windows.Forms.Label()
		Me.labelResponsable = New System.Windows.Forms.Label()
		Me.labelFechaOrdenado = New System.Windows.Forms.Label()
		Me.labelFechaRequerido = New System.Windows.Forms.Label()
		Me.labelCostoEnvio = New System.Windows.Forms.Label()
		Me.textBoxFechaOrdenado = New System.Windows.Forms.TextBox()
		Me.tableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
		Me.textBoxCostoEnvio = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.tableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
		Me.textBoxFechaRequerido = New System.Windows.Forms.TextBox()
		Me.textBoxCliente = New System.Windows.Forms.TextBox()
		Me.textBoxTransporte = New System.Windows.Forms.TextBox()
		Me.textBoxEmpleado = New System.Windows.Forms.TextBox()
		Me.labelPedido = New System.Windows.Forms.Label()
		Me.labelNumeroPedido = New System.Windows.Forms.Label()
		Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.tableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
		Me.buttonSalir = New System.Windows.Forms.Button()
		Me.dataGridViewProductos = New System.Windows.Forms.DataGridView()
		Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.toolTipAgregarProducto = New System.Windows.Forms.ToolTip(Me.components)
		Me.toolTipEliminarProducto = New System.Windows.Forms.ToolTip(Me.components)
		Me.toolTipEditarProducto = New System.Windows.Forms.ToolTip(Me.components)
		Me.tableLayoutPanelGeneral.SuspendLayout()
		Me.tableLayoutPanelLeft.SuspendLayout()
		Me.tableLayoutPanelCentral.SuspendLayout()
		Me.tableLayoutPanelTop.SuspendLayout()
		Me.tableLayoutPanel7.SuspendLayout()
		Me.tableLayoutPanel8.SuspendLayout()
		Me.tableLayoutPanel1.SuspendLayout()
		Me.tableLayoutPanel5.SuspendLayout()
		DirectCast(Me.dataGridViewProductos, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		' 
		' tableLayoutPanelGeneral
		' 
		Me.tableLayoutPanelGeneral.ColumnCount = 2
		Me.tableLayoutPanelGeneral.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.56531F))
		Me.tableLayoutPanelGeneral.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.43469F))
		Me.tableLayoutPanelGeneral.Controls.Add(Me.tableLayoutPanelLeft, 0, 0)
		Me.tableLayoutPanelGeneral.Controls.Add(Me.tableLayoutPanelCentral, 1, 0)
		Me.tableLayoutPanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tableLayoutPanelGeneral.Location = New System.Drawing.Point(0, 0)
		Me.tableLayoutPanelGeneral.Name = "tableLayoutPanelGeneral"
		Me.tableLayoutPanelGeneral.RowCount = 1
		Me.tableLayoutPanelGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanelGeneral.Size = New System.Drawing.Size(942, 673)
		Me.tableLayoutPanelGeneral.TabIndex = 0
		' 
		' tableLayoutPanelLeft
		' 
		Me.tableLayoutPanelLeft.ColumnCount = 1
		Me.tableLayoutPanelLeft.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanelLeft.Controls.Add(Me.panel1, 0, 0)
		Me.tableLayoutPanelLeft.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tableLayoutPanelLeft.Location = New System.Drawing.Point(3, 3)
		Me.tableLayoutPanelLeft.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
		Me.tableLayoutPanelLeft.Name = "tableLayoutPanelLeft"
		Me.tableLayoutPanelLeft.RowCount = 2
		Me.tableLayoutPanelLeft.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.36641F))
		Me.tableLayoutPanelLeft.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.63359F))
		Me.tableLayoutPanelLeft.Size = New System.Drawing.Size(77, 667)
		Me.tableLayoutPanelLeft.TabIndex = 0
		' 
		' panel1
		' 
		Me.panel1.BackgroundImage = Global.CapaPresentacion.Properties.Resources.pedidos
		Me.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.panel1.Location = New System.Drawing.Point(3, 3)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(71, 76)
		Me.panel1.TabIndex = 0
		' 
		' tableLayoutPanelCentral
		' 
		Me.tableLayoutPanelCentral.ColumnCount = 1
		Me.tableLayoutPanelCentral.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanelCentral.Controls.Add(Me.tableLayoutPanelTop, 0, 0)
		Me.tableLayoutPanelCentral.Controls.Add(Me.tableLayoutPanel1, 0, 1)
		Me.tableLayoutPanelCentral.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tableLayoutPanelCentral.Location = New System.Drawing.Point(83, 0)
		Me.tableLayoutPanelCentral.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
		Me.tableLayoutPanelCentral.Name = "tableLayoutPanelCentral"
		Me.tableLayoutPanelCentral.RowCount = 2
		Me.tableLayoutPanelCentral.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.62006F))
		Me.tableLayoutPanelCentral.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.37994F))
		Me.tableLayoutPanelCentral.Size = New System.Drawing.Size(856, 670)
		Me.tableLayoutPanelCentral.TabIndex = 1
		' 
		' tableLayoutPanelTop
		' 
		Me.tableLayoutPanelTop.ColumnCount = 4
		Me.tableLayoutPanelTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.37589F))
		Me.tableLayoutPanelTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.63357F))
		Me.tableLayoutPanelTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.80378F))
		Me.tableLayoutPanelTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.95036F))
		Me.tableLayoutPanelTop.Controls.Add(Me.labelCliente, 0, 1)
		Me.tableLayoutPanelTop.Controls.Add(Me.labelTransporte, 0, 2)
		Me.tableLayoutPanelTop.Controls.Add(Me.labelResponsable, 0, 3)
		Me.tableLayoutPanelTop.Controls.Add(Me.labelFechaOrdenado, 2, 1)
		Me.tableLayoutPanelTop.Controls.Add(Me.labelFechaRequerido, 2, 2)
		Me.tableLayoutPanelTop.Controls.Add(Me.labelCostoEnvio, 2, 3)
		Me.tableLayoutPanelTop.Controls.Add(Me.textBoxFechaOrdenado, 3, 1)
		Me.tableLayoutPanelTop.Controls.Add(Me.tableLayoutPanel7, 3, 3)
		Me.tableLayoutPanelTop.Controls.Add(Me.tableLayoutPanel8, 3, 2)
		Me.tableLayoutPanelTop.Controls.Add(Me.textBoxCliente, 1, 1)
		Me.tableLayoutPanelTop.Controls.Add(Me.textBoxTransporte, 1, 2)
		Me.tableLayoutPanelTop.Controls.Add(Me.textBoxEmpleado, 1, 3)
		Me.tableLayoutPanelTop.Controls.Add(Me.labelPedido, 0, 0)
		Me.tableLayoutPanelTop.Controls.Add(Me.labelNumeroPedido, 1, 0)
		Me.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tableLayoutPanelTop.Location = New System.Drawing.Point(0, 0)
		Me.tableLayoutPanelTop.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
		Me.tableLayoutPanelTop.Name = "tableLayoutPanelTop"
		Me.tableLayoutPanelTop.RowCount = 4
		Me.tableLayoutPanelTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.97727F))
		Me.tableLayoutPanelTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.86364F))
		Me.tableLayoutPanelTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.2236F))
		Me.tableLayoutPanelTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.60248F))
		Me.tableLayoutPanelTop.Size = New System.Drawing.Size(853, 164)
		Me.tableLayoutPanelTop.TabIndex = 0
		' 
		' labelCliente
		' 
		Me.labelCliente.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelCliente.AutoSize = True
		Me.labelCliente.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelCliente.Location = New System.Drawing.Point(6, 53)
		Me.labelCliente.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
		Me.labelCliente.Name = "labelCliente"
		Me.labelCliente.Size = New System.Drawing.Size(113, 26)
		Me.labelCliente.TabIndex = 1
		Me.labelCliente.Text = "Proveedor:"
		' 
		' labelTransporte
		' 
		Me.labelTransporte.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelTransporte.AutoSize = True
		Me.labelTransporte.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelTransporte.Location = New System.Drawing.Point(6, 91)
		Me.labelTransporte.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
		Me.labelTransporte.Name = "labelTransporte"
		Me.labelTransporte.Size = New System.Drawing.Size(117, 26)
		Me.labelTransporte.TabIndex = 2
		Me.labelTransporte.Text = "Transporte:"
		' 
		' labelResponsable
		' 
		Me.labelResponsable.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelResponsable.AutoSize = True
		Me.labelResponsable.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelResponsable.Location = New System.Drawing.Point(6, 131)
		Me.labelResponsable.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
		Me.labelResponsable.Name = "labelResponsable"
		Me.labelResponsable.Size = New System.Drawing.Size(133, 26)
		Me.labelResponsable.TabIndex = 3
		Me.labelResponsable.Text = "Responsable:"
		' 
		' labelFechaOrdenado
		' 
		Me.labelFechaOrdenado.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelFechaOrdenado.AutoSize = True
		Me.labelFechaOrdenado.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelFechaOrdenado.Location = New System.Drawing.Point(447, 53)
		Me.labelFechaOrdenado.Name = "labelFechaOrdenado"
		Me.labelFechaOrdenado.Size = New System.Drawing.Size(166, 26)
		Me.labelFechaOrdenado.TabIndex = 7
		Me.labelFechaOrdenado.Text = "Fecha Ordenado:"
		' 
		' labelFechaRequerido
		' 
		Me.labelFechaRequerido.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelFechaRequerido.AutoSize = True
		Me.labelFechaRequerido.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelFechaRequerido.Location = New System.Drawing.Point(447, 91)
		Me.labelFechaRequerido.Name = "labelFechaRequerido"
		Me.labelFechaRequerido.Size = New System.Drawing.Size(169, 26)
		Me.labelFechaRequerido.TabIndex = 8
		Me.labelFechaRequerido.Text = "Fecha Requerido:"
		' 
		' labelCostoEnvio
		' 
		Me.labelCostoEnvio.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelCostoEnvio.AutoSize = True
		Me.labelCostoEnvio.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelCostoEnvio.Location = New System.Drawing.Point(447, 131)
		Me.labelCostoEnvio.Name = "labelCostoEnvio"
		Me.labelCostoEnvio.Size = New System.Drawing.Size(153, 26)
		Me.labelCostoEnvio.TabIndex = 9
		Me.labelCostoEnvio.Text = "Costo de Envío:"
		' 
		' textBoxFechaOrdenado
		' 
		Me.textBoxFechaOrdenado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxFechaOrdenado.BackColor = System.Drawing.Color.White
		Me.textBoxFechaOrdenado.Enabled = False
		Me.textBoxFechaOrdenado.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxFechaOrdenado.Location = New System.Drawing.Point(624, 50)
		Me.textBoxFechaOrdenado.Name = "textBoxFechaOrdenado"
		Me.textBoxFechaOrdenado.[ReadOnly] = True
		Me.textBoxFechaOrdenado.Size = New System.Drawing.Size(226, 33)
		Me.textBoxFechaOrdenado.TabIndex = 11
		' 
		' tableLayoutPanel7
		' 
		Me.tableLayoutPanel7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tableLayoutPanel7.ColumnCount = 2
		Me.tableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.27642F))
		Me.tableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.72358F))
		Me.tableLayoutPanel7.Controls.Add(Me.textBoxCostoEnvio, 0, 0)
		Me.tableLayoutPanel7.Controls.Add(Me.label1, 1, 0)
		Me.tableLayoutPanel7.Location = New System.Drawing.Point(621, 124)
		Me.tableLayoutPanel7.Margin = New System.Windows.Forms.Padding(0)
		Me.tableLayoutPanel7.Name = "tableLayoutPanel7"
		Me.tableLayoutPanel7.RowCount = 1
		Me.tableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanel7.Size = New System.Drawing.Size(232, 40)
		Me.tableLayoutPanel7.TabIndex = 13
		' 
		' textBoxCostoEnvio
		' 
		Me.textBoxCostoEnvio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxCostoEnvio.BackColor = System.Drawing.Color.White
		Me.textBoxCostoEnvio.Enabled = False
		Me.textBoxCostoEnvio.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxCostoEnvio.Location = New System.Drawing.Point(3, 3)
		Me.textBoxCostoEnvio.MaxLength = 10
		Me.textBoxCostoEnvio.Name = "textBoxCostoEnvio"
		Me.textBoxCostoEnvio.[ReadOnly] = True
		Me.textBoxCostoEnvio.Size = New System.Drawing.Size(92, 33)
		Me.textBoxCostoEnvio.TabIndex = 12
		Me.textBoxCostoEnvio.Text = "0"
		Me.textBoxCostoEnvio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		' 
		' label1
		' 
		Me.label1.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.label1.AutoSize = True
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label1.Location = New System.Drawing.Point(101, 7)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(25, 25)
		Me.label1.TabIndex = 13
		Me.label1.Text = "$"
		' 
		' tableLayoutPanel8
		' 
		Me.tableLayoutPanel8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tableLayoutPanel8.ColumnCount = 1
		Me.tableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.66116F))
		Me.tableLayoutPanel8.Controls.Add(Me.textBoxFechaRequerido, 0, 0)
		Me.tableLayoutPanel8.Location = New System.Drawing.Point(621, 85)
		Me.tableLayoutPanel8.Margin = New System.Windows.Forms.Padding(0)
		Me.tableLayoutPanel8.Name = "tableLayoutPanel8"
		Me.tableLayoutPanel8.RowCount = 1
		Me.tableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanel8.Size = New System.Drawing.Size(232, 39)
		Me.tableLayoutPanel8.TabIndex = 14
		' 
		' textBoxFechaRequerido
		' 
		Me.textBoxFechaRequerido.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxFechaRequerido.BackColor = System.Drawing.Color.White
		Me.textBoxFechaRequerido.Enabled = False
		Me.textBoxFechaRequerido.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxFechaRequerido.Location = New System.Drawing.Point(3, 3)
		Me.textBoxFechaRequerido.Name = "textBoxFechaRequerido"
		Me.textBoxFechaRequerido.[ReadOnly] = True
		Me.textBoxFechaRequerido.Size = New System.Drawing.Size(226, 33)
		Me.textBoxFechaRequerido.TabIndex = 0
		' 
		' textBoxCliente
		' 
		Me.textBoxCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxCliente.BackColor = System.Drawing.Color.White
		Me.textBoxCliente.Enabled = False
		Me.textBoxCliente.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxCliente.Location = New System.Drawing.Point(151, 50)
		Me.textBoxCliente.Name = "textBoxCliente"
		Me.textBoxCliente.[ReadOnly] = True
		Me.textBoxCliente.Size = New System.Drawing.Size(290, 33)
		Me.textBoxCliente.TabIndex = 15
		' 
		' textBoxTransporte
		' 
		Me.textBoxTransporte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxTransporte.BackColor = System.Drawing.Color.White
		Me.textBoxTransporte.Enabled = False
		Me.textBoxTransporte.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxTransporte.Location = New System.Drawing.Point(151, 88)
		Me.textBoxTransporte.Name = "textBoxTransporte"
		Me.textBoxTransporte.[ReadOnly] = True
		Me.textBoxTransporte.Size = New System.Drawing.Size(290, 33)
		Me.textBoxTransporte.TabIndex = 16
		' 
		' textBoxEmpleado
		' 
		Me.textBoxEmpleado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxEmpleado.BackColor = System.Drawing.Color.White
		Me.textBoxEmpleado.Enabled = False
		Me.textBoxEmpleado.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxEmpleado.Location = New System.Drawing.Point(151, 127)
		Me.textBoxEmpleado.Name = "textBoxEmpleado"
		Me.textBoxEmpleado.[ReadOnly] = True
		Me.textBoxEmpleado.Size = New System.Drawing.Size(290, 33)
		Me.textBoxEmpleado.TabIndex = 17
		' 
		' labelPedido
		' 
		Me.labelPedido.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.labelPedido.AutoSize = True
		Me.labelPedido.Font = New System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelPedido.ForeColor = System.Drawing.SystemColors.Desktop
		Me.labelPedido.Location = New System.Drawing.Point(12, 2)
		Me.labelPedido.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
		Me.labelPedido.Name = "labelPedido"
		Me.labelPedido.Size = New System.Drawing.Size(136, 42)
		Me.labelPedido.TabIndex = 18
		Me.labelPedido.Text = "ORDEN:"
		' 
		' labelNumeroPedido
		' 
		Me.labelNumeroPedido.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelNumeroPedido.AutoSize = True
		Me.labelNumeroPedido.Font = New System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelNumeroPedido.ForeColor = System.Drawing.SystemColors.Desktop
		Me.labelNumeroPedido.Location = New System.Drawing.Point(148, 2)
		Me.labelNumeroPedido.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
		Me.labelNumeroPedido.Name = "labelNumeroPedido"
		Me.labelNumeroPedido.Size = New System.Drawing.Size(87, 42)
		Me.labelNumeroPedido.TabIndex = 19
		Me.labelNumeroPedido.Text = "NNN"
		' 
		' tableLayoutPanel1
		' 
		Me.tableLayoutPanel1.ColumnCount = 1
		Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
		Me.tableLayoutPanel1.Controls.Add(Me.tableLayoutPanel5, 0, 2)
		Me.tableLayoutPanel1.Controls.Add(Me.dataGridViewProductos, 0, 1)
		Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 164)
		Me.tableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
		Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
		Me.tableLayoutPanel1.RowCount = 3
		Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.619433F))
		Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.27126F))
		Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.906882F))
		Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F))
		Me.tableLayoutPanel1.Size = New System.Drawing.Size(853, 503)
		Me.tableLayoutPanel1.TabIndex = 1
		' 
		' tableLayoutPanel5
		' 
		Me.tableLayoutPanel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
		Me.tableLayoutPanel5.ColumnCount = 1
		Me.tableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
		Me.tableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F))
		Me.tableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F))
		Me.tableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F))
		Me.tableLayoutPanel5.Controls.Add(Me.buttonSalir, 0, 0)
		Me.tableLayoutPanel5.Location = New System.Drawing.Point(319, 460)
		Me.tableLayoutPanel5.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
		Me.tableLayoutPanel5.Name = "tableLayoutPanel5"
		Me.tableLayoutPanel5.RowCount = 1
		Me.tableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
		Me.tableLayoutPanel5.Size = New System.Drawing.Size(215, 43)
		Me.tableLayoutPanel5.TabIndex = 2
		' 
		' buttonSalir
		' 
		Me.buttonSalir.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonSalir.BackColor = System.Drawing.Color.Orange
		Me.buttonSalir.Font = New System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.buttonSalir.Location = New System.Drawing.Point(5, 0)
		Me.buttonSalir.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
		Me.buttonSalir.Name = "buttonSalir"
		Me.buttonSalir.Size = New System.Drawing.Size(210, 43)
		Me.buttonSalir.TabIndex = 1
		Me.buttonSalir.Text = "Volver"
		Me.buttonSalir.UseVisualStyleBackColor = False
		AddHandler Me.buttonSalir.Click, New System.EventHandler(AddressOf Me.buttonSalir_Click)
		' 
		' dataGridViewProductos
		' 
		Me.dataGridViewProductos.AllowUserToAddRows = False
		Me.dataGridViewProductos.AllowUserToDeleteRows = False
		Me.dataGridViewProductos.AllowUserToOrderColumns = True
		Me.dataGridViewProductos.AllowUserToResizeRows = False
		dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue
		dataGridViewCellStyle1.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop
		dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue
		dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control
		Me.dataGridViewProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1
		Me.dataGridViewProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
		Me.dataGridViewProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
		Me.dataGridViewProductos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
		Me.dataGridViewProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dataGridViewProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
		Me.dataGridViewProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonShadow
		dataGridViewCellStyle2.Font = New System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Bold)
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dataGridViewProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
		Me.dataGridViewProductos.ColumnHeadersHeight = 35
		Me.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
		Me.dataGridViewProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numero})
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
		dataGridViewCellStyle3.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Desktop
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dataGridViewProductos.DefaultCellStyle = dataGridViewCellStyle3
		Me.dataGridViewProductos.EnableHeadersVisualStyles = False
		Me.dataGridViewProductos.Location = New System.Drawing.Point(12, 11)
		Me.dataGridViewProductos.Margin = New System.Windows.Forms.Padding(12, 3, 3, 3)
		Me.dataGridViewProductos.MultiSelect = False
		Me.dataGridViewProductos.Name = "dataGridViewProductos"
		Me.dataGridViewProductos.[ReadOnly] = True
		Me.dataGridViewProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		Me.dataGridViewProductos.RowHeadersVisible = False
		Me.dataGridViewProductos.RowTemplate.[ReadOnly] = True
		Me.dataGridViewProductos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dataGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dataGridViewProductos.ShowCellErrors = False
		Me.dataGridViewProductos.ShowCellToolTips = False
		Me.dataGridViewProductos.ShowEditingIcon = False
		Me.dataGridViewProductos.ShowRowErrors = False
		Me.dataGridViewProductos.Size = New System.Drawing.Size(831, 435)
		Me.dataGridViewProductos.TabIndex = 3
		AddHandler Me.dataGridViewProductos.RowPrePaint, New System.Windows.Forms.DataGridViewRowPrePaintEventHandler(AddressOf Me.dataGridViewProductos_RowPrePaint)
		' 
		' numero
		' 
		Me.numero.HeaderText = ""
		Me.numero.Name = "numero"
		Me.numero.[ReadOnly] = True
		Me.numero.Width = 17
		' 
		' FrmoOrdenPendienteDetalles
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(942, 673)
		Me.Controls.Add(Me.tableLayoutPanelGeneral)
		Me.MaximizeBox = False
		Me.MaximumSize = New System.Drawing.Size(950, 700)
		Me.MinimizeBox = False
		Me.MinimumSize = New System.Drawing.Size(950, 700)
		Me.Name = "FrmoOrdenPendienteDetalles"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Detalles de la Orden"
		Me.tableLayoutPanelGeneral.ResumeLayout(False)
		Me.tableLayoutPanelLeft.ResumeLayout(False)
		Me.tableLayoutPanelCentral.ResumeLayout(False)
		Me.tableLayoutPanelTop.ResumeLayout(False)
		Me.tableLayoutPanelTop.PerformLayout()
		Me.tableLayoutPanel7.ResumeLayout(False)
		Me.tableLayoutPanel7.PerformLayout()
		Me.tableLayoutPanel8.ResumeLayout(False)
		Me.tableLayoutPanel8.PerformLayout()
		Me.tableLayoutPanel1.ResumeLayout(False)
		Me.tableLayoutPanel5.ResumeLayout(False)
		DirectCast(Me.dataGridViewProductos, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private tableLayoutPanelGeneral As System.Windows.Forms.TableLayoutPanel
	Private tableLayoutPanelLeft As System.Windows.Forms.TableLayoutPanel
	Private panel1 As System.Windows.Forms.Panel
	Private tableLayoutPanelCentral As System.Windows.Forms.TableLayoutPanel
	Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Private toolTipAgregarProducto As System.Windows.Forms.ToolTip
	Private toolTipEliminarProducto As System.Windows.Forms.ToolTip
	Private toolTipEditarProducto As System.Windows.Forms.ToolTip
	Private tableLayoutPanelTop As System.Windows.Forms.TableLayoutPanel
	Private labelCliente As System.Windows.Forms.Label
	Private labelTransporte As System.Windows.Forms.Label
	Private labelResponsable As System.Windows.Forms.Label
	Private labelFechaOrdenado As System.Windows.Forms.Label
	Private labelFechaRequerido As System.Windows.Forms.Label
	Private labelCostoEnvio As System.Windows.Forms.Label
	Private textBoxFechaOrdenado As System.Windows.Forms.TextBox
	Private tableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
	Private textBoxCostoEnvio As System.Windows.Forms.TextBox
	Private label1 As System.Windows.Forms.Label
	Private tableLayoutPanel8 As System.Windows.Forms.TableLayoutPanel
	Private textBoxFechaRequerido As System.Windows.Forms.TextBox
	Private textBoxCliente As System.Windows.Forms.TextBox
	Private textBoxTransporte As System.Windows.Forms.TextBox
	Private textBoxEmpleado As System.Windows.Forms.TextBox
	Private tableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
	Private buttonSalir As System.Windows.Forms.Button
	Private dataGridViewProductos As System.Windows.Forms.DataGridView
	Private numero As System.Windows.Forms.DataGridViewTextBoxColumn
	Private labelNumeroPedido As System.Windows.Forms.Label
	Private labelPedido As System.Windows.Forms.Label


End Class
