Partial Class FrmEditarOrdenEntregado
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
		Dim dataGridViewCellStyle6 As New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle3 As New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle4 As New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle5 As New System.Windows.Forms.DataGridViewCellStyle()
		Me.tableLayoutPanelGeneral = New System.Windows.Forms.TableLayoutPanel()
		Me.tableLayoutPanelLeft = New System.Windows.Forms.TableLayoutPanel()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.dataGridViewOrigen = New System.Windows.Forms.DataGridView()
		Me.tableLayoutPanelCentral = New System.Windows.Forms.TableLayoutPanel()
		Me.tableLayoutPanelTop = New System.Windows.Forms.TableLayoutPanel()
		Me.dateTimePickerFechaOrdenado = New System.Windows.Forms.DateTimePicker()
		Me.labelSubTitulo = New System.Windows.Forms.Label()
		Me.labelCliente = New System.Windows.Forms.Label()
		Me.labelTransporte = New System.Windows.Forms.Label()
		Me.labelResponsable = New System.Windows.Forms.Label()
		Me.comboBoxTransportes = New System.Windows.Forms.ComboBox()
		Me.comboBoxEmpleados = New System.Windows.Forms.ComboBox()
		Me.labelFechaOrdenado = New System.Windows.Forms.Label()
		Me.labelFechaEntregado = New System.Windows.Forms.Label()
		Me.labelCostoEnvio = New System.Windows.Forms.Label()
		Me.tableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
		Me.textBoxCostoEnvio = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.tableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
		Me.dateTimePickerFechaEntregado = New System.Windows.Forms.DateTimePicker()
		Me.comboBoxClientes = New System.Windows.Forms.ComboBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.labelNumeroPedido = New System.Windows.Forms.Label()
		Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.labelSubTitulo2 = New System.Windows.Forms.Label()
		Me.tableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
		Me.textBoxDescuento = New System.Windows.Forms.TextBox()
		Me.labelCantidad = New System.Windows.Forms.Label()
		Me.labelDescuento = New System.Windows.Forms.Label()
		Me.buttonAgregarProducto = New System.Windows.Forms.Button()
		Me.buttonEliminarProducto = New System.Windows.Forms.Button()
		Me.tableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
		Me.textBoxPrecio = New System.Windows.Forms.TextBox()
		Me.labelPrecio = New System.Windows.Forms.Label()
		Me.labelPeso = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.textBoxCantidad = New System.Windows.Forms.TextBox()
		Me.tableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
		Me.labelProducto = New System.Windows.Forms.Label()
		Me.comboBoxProductos = New System.Windows.Forms.ComboBox()
		Me.tableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
		Me.buttonGuardar = New System.Windows.Forms.Button()
		Me.buttonCancelar = New System.Windows.Forms.Button()
		Me.dataGridViewProductos = New System.Windows.Forms.DataGridView()
		Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.toolTipAgregarProducto = New System.Windows.Forms.ToolTip(Me.components)
		Me.toolTipEliminarProducto = New System.Windows.Forms.ToolTip(Me.components)
		Me.tableLayoutPanelGeneral.SuspendLayout()
		Me.tableLayoutPanelLeft.SuspendLayout()
		DirectCast(Me.dataGridViewOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.tableLayoutPanelCentral.SuspendLayout()
		Me.tableLayoutPanelTop.SuspendLayout()
		Me.tableLayoutPanel7.SuspendLayout()
		Me.tableLayoutPanel8.SuspendLayout()
		Me.tableLayoutPanel1.SuspendLayout()
		Me.tableLayoutPanel2.SuspendLayout()
		Me.tableLayoutPanel3.SuspendLayout()
		Me.tableLayoutPanel6.SuspendLayout()
		Me.tableLayoutPanel4.SuspendLayout()
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
		Me.tableLayoutPanelLeft.Controls.Add(Me.dataGridViewOrigen, 0, 1)
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
		' dataGridViewOrigen
		' 
		Me.dataGridViewOrigen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridViewOrigen.Location = New System.Drawing.Point(3, 85)
		Me.dataGridViewOrigen.Name = "dataGridViewOrigen"
		Me.dataGridViewOrigen.Size = New System.Drawing.Size(70, 119)
		Me.dataGridViewOrigen.TabIndex = 5
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
		Me.tableLayoutPanelTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.98565F))
		Me.tableLayoutPanelTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.46099F))
		Me.tableLayoutPanelTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.04019F))
		Me.tableLayoutPanelTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.71395F))
		Me.tableLayoutPanelTop.Controls.Add(Me.dateTimePickerFechaOrdenado, 3, 1)
		Me.tableLayoutPanelTop.Controls.Add(Me.labelSubTitulo, 0, 0)
		Me.tableLayoutPanelTop.Controls.Add(Me.labelCliente, 0, 1)
		Me.tableLayoutPanelTop.Controls.Add(Me.labelTransporte, 0, 2)
		Me.tableLayoutPanelTop.Controls.Add(Me.labelResponsable, 0, 3)
		Me.tableLayoutPanelTop.Controls.Add(Me.comboBoxTransportes, 1, 2)
		Me.tableLayoutPanelTop.Controls.Add(Me.comboBoxEmpleados, 1, 3)
		Me.tableLayoutPanelTop.Controls.Add(Me.labelFechaOrdenado, 2, 1)
		Me.tableLayoutPanelTop.Controls.Add(Me.labelFechaEntregado, 2, 2)
		Me.tableLayoutPanelTop.Controls.Add(Me.labelCostoEnvio, 2, 3)
		Me.tableLayoutPanelTop.Controls.Add(Me.tableLayoutPanel7, 3, 3)
		Me.tableLayoutPanelTop.Controls.Add(Me.tableLayoutPanel8, 3, 2)
		Me.tableLayoutPanelTop.Controls.Add(Me.comboBoxClientes, 1, 1)
		Me.tableLayoutPanelTop.Controls.Add(Me.label3, 2, 0)
		Me.tableLayoutPanelTop.Controls.Add(Me.labelNumeroPedido, 3, 0)
		Me.tableLayoutPanelTop.Location = New System.Drawing.Point(0, 0)
		Me.tableLayoutPanelTop.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
		Me.tableLayoutPanelTop.Name = "tableLayoutPanelTop"
		Me.tableLayoutPanelTop.RowCount = 4
		Me.tableLayoutPanelTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.97727F))
		Me.tableLayoutPanelTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.86364F))
		Me.tableLayoutPanelTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.2236F))
		Me.tableLayoutPanelTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.60248F))
		Me.tableLayoutPanelTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F))
		Me.tableLayoutPanelTop.Size = New System.Drawing.Size(846, 161)
		Me.tableLayoutPanelTop.TabIndex = 0
		' 
		' dateTimePickerFechaOrdenado
		' 
		Me.dateTimePickerFechaOrdenado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.dateTimePickerFechaOrdenado.CalendarFont = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.dateTimePickerFechaOrdenado.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
		Me.dateTimePickerFechaOrdenado.Font = New System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.dateTimePickerFechaOrdenado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dateTimePickerFechaOrdenado.Location = New System.Drawing.Point(622, 49)
		Me.dateTimePickerFechaOrdenado.MinDate = New System.DateTime(2000, 1, 1, 0, 0, 0, _
			0)
		Me.dateTimePickerFechaOrdenado.Name = "dateTimePickerFechaOrdenado"
		Me.dateTimePickerFechaOrdenado.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.dateTimePickerFechaOrdenado.Size = New System.Drawing.Size(221, 32)
		Me.dateTimePickerFechaOrdenado.TabIndex = 11
		Me.dateTimePickerFechaOrdenado.Value = New System.DateTime(2015, 5, 29, 22, 43, 35, _
			0)
		' 
		' labelSubTitulo
		' 
		Me.labelSubTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelSubTitulo.AutoSize = True
		Me.labelSubTitulo.Font = New System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelSubTitulo.ForeColor = System.Drawing.SystemColors.Desktop
		Me.labelSubTitulo.Location = New System.Drawing.Point(3, 2)
		Me.labelSubTitulo.Name = "labelSubTitulo"
		Me.labelSubTitulo.Size = New System.Drawing.Size(122, 42)
		Me.labelSubTitulo.TabIndex = 0
		Me.labelSubTitulo.Text = "DATOS"
		' 
		' labelCliente
		' 
		Me.labelCliente.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelCliente.AutoSize = True
		Me.labelCliente.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelCliente.Location = New System.Drawing.Point(6, 52)
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
		Me.labelTransporte.Location = New System.Drawing.Point(6, 90)
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
		Me.labelResponsable.Location = New System.Drawing.Point(6, 128)
		Me.labelResponsable.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
		Me.labelResponsable.Name = "labelResponsable"
		Me.labelResponsable.Size = New System.Drawing.Size(133, 26)
		Me.labelResponsable.TabIndex = 3
		Me.labelResponsable.Text = "Responsable:"
		' 
		' comboBoxTransportes
		' 
		Me.comboBoxTransportes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.comboBoxTransportes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBoxTransportes.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.comboBoxTransportes.FormattingEnabled = True
		Me.comboBoxTransportes.Location = New System.Drawing.Point(146, 87)
		Me.comboBoxTransportes.Name = "comboBoxTransportes"
		Me.comboBoxTransportes.Size = New System.Drawing.Size(293, 34)
		Me.comboBoxTransportes.TabIndex = 5
		' 
		' comboBoxEmpleados
		' 
		Me.comboBoxEmpleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.comboBoxEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBoxEmpleados.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.comboBoxEmpleados.FormattingEnabled = True
		Me.comboBoxEmpleados.Location = New System.Drawing.Point(146, 125)
		Me.comboBoxEmpleados.Name = "comboBoxEmpleados"
		Me.comboBoxEmpleados.Size = New System.Drawing.Size(293, 34)
		Me.comboBoxEmpleados.TabIndex = 6
		' 
		' labelFechaOrdenado
		' 
		Me.labelFechaOrdenado.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelFechaOrdenado.AutoSize = True
		Me.labelFechaOrdenado.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelFechaOrdenado.Location = New System.Drawing.Point(445, 52)
		Me.labelFechaOrdenado.Name = "labelFechaOrdenado"
		Me.labelFechaOrdenado.Size = New System.Drawing.Size(166, 26)
		Me.labelFechaOrdenado.TabIndex = 7
		Me.labelFechaOrdenado.Text = "Fecha Ordenado:"
		' 
		' labelFechaEntregado
		' 
		Me.labelFechaEntregado.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelFechaEntregado.AutoSize = True
		Me.labelFechaEntregado.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelFechaEntregado.Location = New System.Drawing.Point(445, 90)
		Me.labelFechaEntregado.Name = "labelFechaEntregado"
		Me.labelFechaEntregado.Size = New System.Drawing.Size(170, 26)
		Me.labelFechaEntregado.TabIndex = 8
		Me.labelFechaEntregado.Text = "Fecha Entregado:"
		' 
		' labelCostoEnvio
		' 
		Me.labelCostoEnvio.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelCostoEnvio.AutoSize = True
		Me.labelCostoEnvio.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelCostoEnvio.Location = New System.Drawing.Point(445, 128)
		Me.labelCostoEnvio.Name = "labelCostoEnvio"
		Me.labelCostoEnvio.Size = New System.Drawing.Size(153, 26)
		Me.labelCostoEnvio.TabIndex = 9
		Me.labelCostoEnvio.Text = "Costo de Envío:"
		' 
		' tableLayoutPanel7
		' 
		Me.tableLayoutPanel7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tableLayoutPanel7.ColumnCount = 2
		Me.tableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.27642F))
		Me.tableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.72358F))
		Me.tableLayoutPanel7.Controls.Add(Me.textBoxCostoEnvio, 0, 0)
		Me.tableLayoutPanel7.Controls.Add(Me.label1, 1, 0)
		Me.tableLayoutPanel7.Location = New System.Drawing.Point(619, 122)
		Me.tableLayoutPanel7.Margin = New System.Windows.Forms.Padding(0)
		Me.tableLayoutPanel7.Name = "tableLayoutPanel7"
		Me.tableLayoutPanel7.RowCount = 1
		Me.tableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanel7.Size = New System.Drawing.Size(227, 39)
		Me.tableLayoutPanel7.TabIndex = 13
		' 
		' textBoxCostoEnvio
		' 
		Me.textBoxCostoEnvio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxCostoEnvio.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxCostoEnvio.Location = New System.Drawing.Point(3, 3)
		Me.textBoxCostoEnvio.MaxLength = 10
		Me.textBoxCostoEnvio.Name = "textBoxCostoEnvio"
		Me.textBoxCostoEnvio.Size = New System.Drawing.Size(89, 33)
		Me.textBoxCostoEnvio.TabIndex = 12
		Me.textBoxCostoEnvio.Text = "0"
		Me.textBoxCostoEnvio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		AddHandler Me.textBoxCostoEnvio.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.textBoxCostoEnvio_KeyPress)
		' 
		' label1
		' 
		Me.label1.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.label1.AutoSize = True
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label1.Location = New System.Drawing.Point(98, 7)
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
		Me.tableLayoutPanel8.Controls.Add(Me.dateTimePickerFechaEntregado, 0, 0)
		Me.tableLayoutPanel8.Location = New System.Drawing.Point(619, 84)
		Me.tableLayoutPanel8.Margin = New System.Windows.Forms.Padding(0)
		Me.tableLayoutPanel8.Name = "tableLayoutPanel8"
		Me.tableLayoutPanel8.RowCount = 1
		Me.tableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanel8.Size = New System.Drawing.Size(227, 38)
		Me.tableLayoutPanel8.TabIndex = 12
		' 
		' dateTimePickerFechaEntregado
		' 
		Me.dateTimePickerFechaEntregado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.dateTimePickerFechaEntregado.CalendarFont = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.dateTimePickerFechaEntregado.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
		Me.dateTimePickerFechaEntregado.Font = New System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.dateTimePickerFechaEntregado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dateTimePickerFechaEntregado.Location = New System.Drawing.Point(3, 3)
		Me.dateTimePickerFechaEntregado.MinDate = New System.DateTime(2015, 5, 29, 22, 43, 23, _
			0)
		Me.dateTimePickerFechaEntregado.Name = "dateTimePickerFechaEntregado"
		Me.dateTimePickerFechaEntregado.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.dateTimePickerFechaEntregado.Size = New System.Drawing.Size(221, 32)
		Me.dateTimePickerFechaEntregado.TabIndex = 12
		Me.dateTimePickerFechaEntregado.Value = New System.DateTime(2015, 5, 29, 22, 43, 35, _
			0)
		' 
		' comboBoxClientes
		' 
		Me.comboBoxClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.comboBoxClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBoxClientes.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.comboBoxClientes.FormattingEnabled = True
		Me.comboBoxClientes.Location = New System.Drawing.Point(146, 49)
		Me.comboBoxClientes.Name = "comboBoxClientes"
		Me.comboBoxClientes.Size = New System.Drawing.Size(293, 34)
		Me.comboBoxClientes.TabIndex = 4
		' 
		' label3
		' 
		Me.label3.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.label3.AutoSize = True
		Me.label3.Font = New System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label3.ForeColor = System.Drawing.SystemColors.Desktop
		Me.label3.Location = New System.Drawing.Point(480, 2)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(136, 42)
		Me.label3.TabIndex = 15
		Me.label3.Text = "ORDEN:"
		' 
		' labelNumeroPedido
		' 
		Me.labelNumeroPedido.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelNumeroPedido.AutoSize = True
		Me.labelNumeroPedido.Font = New System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelNumeroPedido.ForeColor = System.Drawing.SystemColors.Desktop
		Me.labelNumeroPedido.Location = New System.Drawing.Point(622, 2)
		Me.labelNumeroPedido.Name = "labelNumeroPedido"
		Me.labelNumeroPedido.Size = New System.Drawing.Size(87, 42)
		Me.labelNumeroPedido.TabIndex = 16
		Me.labelNumeroPedido.Text = "NNN"
		' 
		' tableLayoutPanel1
		' 
		Me.tableLayoutPanel1.ColumnCount = 1
		Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
		Me.tableLayoutPanel1.Controls.Add(Me.tableLayoutPanel2, 0, 0)
		Me.tableLayoutPanel1.Controls.Add(Me.tableLayoutPanel5, 0, 2)
		Me.tableLayoutPanel1.Controls.Add(Me.dataGridViewProductos, 0, 1)
		Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 164)
		Me.tableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
		Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
		Me.tableLayoutPanel1.RowCount = 3
		Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.72065F))
		Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.17004F))
		Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.924949F))
		Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F))
		Me.tableLayoutPanel1.Size = New System.Drawing.Size(846, 494)
		Me.tableLayoutPanel1.TabIndex = 1
		' 
		' tableLayoutPanel2
		' 
		Me.tableLayoutPanel2.ColumnCount = 1
		Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanel2.Controls.Add(Me.labelSubTitulo2, 0, 0)
		Me.tableLayoutPanel2.Controls.Add(Me.tableLayoutPanel3, 0, 2)
		Me.tableLayoutPanel2.Controls.Add(Me.tableLayoutPanel4, 0, 1)
		Me.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tableLayoutPanel2.Location = New System.Drawing.Point(0, 3)
		Me.tableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
		Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
		Me.tableLayoutPanel2.RowCount = 3
		Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.88462F))
		Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.11538F))
		Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F))
		Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F))
		Me.tableLayoutPanel2.Size = New System.Drawing.Size(846, 129)
		Me.tableLayoutPanel2.TabIndex = 0
		' 
		' labelSubTitulo2
		' 
		Me.labelSubTitulo2.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelSubTitulo2.AutoSize = True
		Me.labelSubTitulo2.Font = New System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelSubTitulo2.ForeColor = System.Drawing.SystemColors.Desktop
		Me.labelSubTitulo2.Location = New System.Drawing.Point(3, 1)
		Me.labelSubTitulo2.Name = "labelSubTitulo2"
		Me.labelSubTitulo2.Size = New System.Drawing.Size(207, 42)
		Me.labelSubTitulo2.TabIndex = 2
		Me.labelSubTitulo2.Text = "PRODUCTOS"
		' 
		' tableLayoutPanel3
		' 
		Me.tableLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tableLayoutPanel3.ColumnCount = 10
		Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.94313F))
		Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.00948F))
		Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.03791F))
		Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.50237F))
		Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.57346F))
		Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.00474F))
		Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.85782F))
		Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.8584817F))
		Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.50237F))
		Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.50237F))
		Me.tableLayoutPanel3.Controls.Add(Me.textBoxDescuento, 5, 0)
		Me.tableLayoutPanel3.Controls.Add(Me.labelCantidad, 0, 0)
		Me.tableLayoutPanel3.Controls.Add(Me.labelDescuento, 4, 0)
		Me.tableLayoutPanel3.Controls.Add(Me.buttonAgregarProducto, 9, 0)
		Me.tableLayoutPanel3.Controls.Add(Me.buttonEliminarProducto, 8, 0)
		Me.tableLayoutPanel3.Controls.Add(Me.tableLayoutPanel6, 2, 0)
		Me.tableLayoutPanel3.Controls.Add(Me.labelPeso, 3, 0)
		Me.tableLayoutPanel3.Controls.Add(Me.label2, 6, 0)
		Me.tableLayoutPanel3.Controls.Add(Me.textBoxCantidad, 1, 0)
		Me.tableLayoutPanel3.Location = New System.Drawing.Point(0, 85)
		Me.tableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0, 0, 2, 0)
		Me.tableLayoutPanel3.Name = "tableLayoutPanel3"
		Me.tableLayoutPanel3.RowCount = 1
		Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
		Me.tableLayoutPanel3.Size = New System.Drawing.Size(844, 40)
		Me.tableLayoutPanel3.TabIndex = 2
		' 
		' textBoxDescuento
		' 
		Me.textBoxDescuento.BackColor = System.Drawing.Color.White
		Me.textBoxDescuento.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxDescuento.Location = New System.Drawing.Point(645, 3)
		Me.textBoxDescuento.MaxLength = 6
		Me.textBoxDescuento.Name = "textBoxDescuento"
		Me.textBoxDescuento.Size = New System.Drawing.Size(70, 33)
		Me.textBoxDescuento.TabIndex = 8
		Me.textBoxDescuento.Text = "0"
		Me.textBoxDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		AddHandler Me.textBoxDescuento.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.textBoxDescuento_KeyPress)
		' 
		' labelCantidad
		' 
		Me.labelCantidad.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelCantidad.AutoSize = True
		Me.labelCantidad.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelCantidad.Location = New System.Drawing.Point(6, 7)
		Me.labelCantidad.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
		Me.labelCantidad.Name = "labelCantidad"
		Me.labelCantidad.Size = New System.Drawing.Size(98, 26)
		Me.labelCantidad.TabIndex = 3
		Me.labelCantidad.Text = "Cantidad:"
		' 
		' labelDescuento
		' 
		Me.labelDescuento.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelDescuento.AutoSize = True
		Me.labelDescuento.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelDescuento.Location = New System.Drawing.Point(525, 7)
		Me.labelDescuento.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
		Me.labelDescuento.Name = "labelDescuento"
		Me.labelDescuento.Size = New System.Drawing.Size(114, 26)
		Me.labelDescuento.TabIndex = 5
		Me.labelDescuento.Text = "Descuento:"
		' 
		' buttonAgregarProducto
		' 
		Me.buttonAgregarProducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonAgregarProducto.BackgroundImage = Global.CapaPresentacion.Properties.Resources.agregar_producto
		Me.buttonAgregarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.buttonAgregarProducto.Location = New System.Drawing.Point(804, 0)
		Me.buttonAgregarProducto.Margin = New System.Windows.Forms.Padding(0)
		Me.buttonAgregarProducto.Name = "buttonAgregarProducto"
		Me.buttonAgregarProducto.Size = New System.Drawing.Size(40, 40)
		Me.buttonAgregarProducto.TabIndex = 10
		Me.toolTipAgregarProducto.SetToolTip(Me.buttonAgregarProducto, "Agregar Producto a la Lista")
		Me.buttonAgregarProducto.UseVisualStyleBackColor = True
		AddHandler Me.buttonAgregarProducto.Click, New System.EventHandler(AddressOf Me.buttonAgregarProducto_Click)
		' 
		' buttonEliminarProducto
		' 
		Me.buttonEliminarProducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonEliminarProducto.BackgroundImage = Global.CapaPresentacion.Properties.Resources.eliminar_producto
		Me.buttonEliminarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.buttonEliminarProducto.Location = New System.Drawing.Point(766, 0)
		Me.buttonEliminarProducto.Margin = New System.Windows.Forms.Padding(0)
		Me.buttonEliminarProducto.Name = "buttonEliminarProducto"
		Me.buttonEliminarProducto.Size = New System.Drawing.Size(38, 40)
		Me.buttonEliminarProducto.TabIndex = 9
		Me.toolTipEliminarProducto.SetToolTip(Me.buttonEliminarProducto, "Eliminar Producto seleccionado")
		Me.buttonEliminarProducto.UseVisualStyleBackColor = True
		AddHandler Me.buttonEliminarProducto.Click, New System.EventHandler(AddressOf Me.buttonEliminarProducto_Click)
		' 
		' tableLayoutPanel6
		' 
		Me.tableLayoutPanel6.ColumnCount = 2
		Me.tableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.31551F))
		Me.tableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.68449F))
		Me.tableLayoutPanel6.Controls.Add(Me.textBoxPrecio, 1, 0)
		Me.tableLayoutPanel6.Controls.Add(Me.labelPrecio, 0, 0)
		Me.tableLayoutPanel6.Location = New System.Drawing.Point(295, 0)
		Me.tableLayoutPanel6.Margin = New System.Windows.Forms.Padding(0)
		Me.tableLayoutPanel6.Name = "tableLayoutPanel6"
		Me.tableLayoutPanel6.RowCount = 1
		Me.tableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanel6.Size = New System.Drawing.Size(186, 40)
		Me.tableLayoutPanel6.TabIndex = 7
		' 
		' textBoxPrecio
		' 
		Me.textBoxPrecio.BackColor = System.Drawing.Color.White
		Me.textBoxPrecio.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxPrecio.Location = New System.Drawing.Point(83, 3)
		Me.textBoxPrecio.MaxLength = 10
		Me.textBoxPrecio.Name = "textBoxPrecio"
		Me.textBoxPrecio.Size = New System.Drawing.Size(100, 33)
		Me.textBoxPrecio.TabIndex = 7
		Me.textBoxPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		AddHandler Me.textBoxPrecio.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.textBoxPrecio_KeyPress)
		' 
		' labelPrecio
		' 
		Me.labelPrecio.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelPrecio.AutoSize = True
		Me.labelPrecio.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelPrecio.Location = New System.Drawing.Point(3, 7)
		Me.labelPrecio.Name = "labelPrecio"
		Me.labelPrecio.Size = New System.Drawing.Size(74, 26)
		Me.labelPrecio.TabIndex = 8
		Me.labelPrecio.Text = "Precio:"
		' 
		' labelPeso
		' 
		Me.labelPeso.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.labelPeso.AutoSize = True
		Me.labelPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelPeso.Location = New System.Drawing.Point(486, 7)
		Me.labelPeso.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
		Me.labelPeso.Name = "labelPeso"
		Me.labelPeso.Size = New System.Drawing.Size(25, 25)
		Me.labelPeso.TabIndex = 13
		Me.labelPeso.Text = "$"
		' 
		' label2
		' 
		Me.label2.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.label2.AutoSize = True
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label2.Location = New System.Drawing.Point(721, 7)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(32, 25)
		Me.label2.TabIndex = 14
		Me.label2.Text = "%"
		' 
		' textBoxCantidad
		' 
		Me.textBoxCantidad.BackColor = System.Drawing.Color.White
		Me.textBoxCantidad.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxCantidad.Location = New System.Drawing.Point(146, 3)
		Me.textBoxCantidad.MaxLength = 10
		Me.textBoxCantidad.Name = "textBoxCantidad"
		Me.textBoxCantidad.Size = New System.Drawing.Size(111, 33)
		Me.textBoxCantidad.TabIndex = 6
		Me.textBoxCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		AddHandler Me.textBoxCantidad.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.textBoxCantidad_KeyPress)
		' 
		' tableLayoutPanel4
		' 
		Me.tableLayoutPanel4.ColumnCount = 2
		Me.tableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.98565F))
		Me.tableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.01435F))
		Me.tableLayoutPanel4.Controls.Add(Me.labelProducto, 0, 0)
		Me.tableLayoutPanel4.Controls.Add(Me.comboBoxProductos, 1, 0)
		Me.tableLayoutPanel4.Location = New System.Drawing.Point(0, 45)
		Me.tableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
		Me.tableLayoutPanel4.Name = "tableLayoutPanel4"
		Me.tableLayoutPanel4.RowCount = 1
		Me.tableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanel4.Size = New System.Drawing.Size(846, 40)
		Me.tableLayoutPanel4.TabIndex = 1
		' 
		' labelProducto
		' 
		Me.labelProducto.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelProducto.AutoSize = True
		Me.labelProducto.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelProducto.Location = New System.Drawing.Point(6, 7)
		Me.labelProducto.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
		Me.labelProducto.Name = "labelProducto"
		Me.labelProducto.Size = New System.Drawing.Size(101, 26)
		Me.labelProducto.TabIndex = 2
		Me.labelProducto.Text = "Producto:"
		' 
		' comboBoxProductos
		' 
		Me.comboBoxProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBoxProductos.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.comboBoxProductos.FormattingEnabled = True
		Me.comboBoxProductos.Location = New System.Drawing.Point(146, 3)
		Me.comboBoxProductos.Name = "comboBoxProductos"
		Me.comboBoxProductos.Size = New System.Drawing.Size(697, 34)
		Me.comboBoxProductos.TabIndex = 5
		AddHandler Me.comboBoxProductos.SelectedValueChanged, New System.EventHandler(AddressOf Me.comboBoxProductos_SelectedValueChanged)
		' 
		' tableLayoutPanel5
		' 
		Me.tableLayoutPanel5.ColumnCount = 4
		Me.tableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F))
		Me.tableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F))
		Me.tableLayoutPanel5.Controls.Add(Me.buttonGuardar, 1, 0)
		Me.tableLayoutPanel5.Controls.Add(Me.buttonCancelar, 2, 0)
		Me.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.tableLayoutPanel5.Location = New System.Drawing.Point(3, 455)
		Me.tableLayoutPanel5.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
		Me.tableLayoutPanel5.Name = "tableLayoutPanel5"
		Me.tableLayoutPanel5.RowCount = 1
		Me.tableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
		Me.tableLayoutPanel5.Size = New System.Drawing.Size(840, 39)
		Me.tableLayoutPanel5.TabIndex = 2
		' 
		' buttonGuardar
		' 
		Me.buttonGuardar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonGuardar.BackColor = System.Drawing.Color.LightSkyBlue
		Me.buttonGuardar.Font = New System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.buttonGuardar.Location = New System.Drawing.Point(200, 0)
		Me.buttonGuardar.Margin = New System.Windows.Forms.Padding(0, 0, 5, 0)
		Me.buttonGuardar.Name = "buttonGuardar"
		Me.buttonGuardar.Size = New System.Drawing.Size(215, 39)
		Me.buttonGuardar.TabIndex = 0
		Me.buttonGuardar.Text = "Guardar"
		Me.buttonGuardar.UseVisualStyleBackColor = False
		AddHandler Me.buttonGuardar.Click, New System.EventHandler(AddressOf Me.buttonGuardar_Click)
		' 
		' buttonCancelar
		' 
		Me.buttonCancelar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonCancelar.BackColor = System.Drawing.Color.LightSkyBlue
		Me.buttonCancelar.Font = New System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.buttonCancelar.Location = New System.Drawing.Point(425, 0)
		Me.buttonCancelar.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
		Me.buttonCancelar.Name = "buttonCancelar"
		Me.buttonCancelar.Size = New System.Drawing.Size(215, 39)
		Me.buttonCancelar.TabIndex = 1
		Me.buttonCancelar.Text = "Cancelar"
		Me.buttonCancelar.UseVisualStyleBackColor = False
		AddHandler Me.buttonCancelar.Click, New System.EventHandler(AddressOf Me.buttonCancelar_Click)
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
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dataGridViewProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
		Me.dataGridViewProductos.ColumnHeadersHeight = 35
		Me.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
		Me.dataGridViewProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numero, Me.producto, Me.cantidad, Me.precio, Me.descuento})
		dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
		dataGridViewCellStyle6.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Desktop
		dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DodgerBlue
		dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Control
		dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dataGridViewProductos.DefaultCellStyle = dataGridViewCellStyle6
		Me.dataGridViewProductos.EnableHeadersVisualStyles = False
		Me.dataGridViewProductos.Location = New System.Drawing.Point(12, 135)
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
		Me.dataGridViewProductos.Size = New System.Drawing.Size(831, 311)
		Me.dataGridViewProductos.TabIndex = 4
		AddHandler Me.dataGridViewProductos.RowPrePaint, New System.Windows.Forms.DataGridViewRowPrePaintEventHandler(AddressOf Me.dataGridViewProductos_RowPrePaint)
		' 
		' numero
		' 
		Me.numero.HeaderText = ""
		Me.numero.Name = "numero"
		Me.numero.[ReadOnly] = True
		Me.numero.Width = 17
		' 
		' producto
		' 
		Me.producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.producto.HeaderText = "PRODUCTO"
		Me.producto.Name = "producto"
		Me.producto.[ReadOnly] = True
		Me.producto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
		' 
		' cantidad
		' 
		Me.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
		Me.cantidad.DefaultCellStyle = dataGridViewCellStyle3
		Me.cantidad.HeaderText = "CANT."
		Me.cantidad.Name = "cantidad"
		Me.cantidad.[ReadOnly] = True
		Me.cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
		Me.cantidad.Width = 75
		' 
		' precio
		' 
		Me.precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
		dataGridViewCellStyle4.NullValue = "0"
		Me.precio.DefaultCellStyle = dataGridViewCellStyle4
		Me.precio.HeaderText = "PRECIO"
		Me.precio.Name = "precio"
		Me.precio.[ReadOnly] = True
		Me.precio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
		Me.precio.Width = 105
		' 
		' descuento
		' 
		Me.descuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
		dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
		Me.descuento.DefaultCellStyle = dataGridViewCellStyle5
		Me.descuento.HeaderText = "DESC."
		Me.descuento.Name = "descuento"
		Me.descuento.[ReadOnly] = True
		Me.descuento.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.descuento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
		Me.descuento.Width = 95
		' 
		' FrmEditarOrdenEntregado
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(942, 673)
		Me.Controls.Add(Me.tableLayoutPanelGeneral)
		Me.MaximizeBox = False
		Me.MaximumSize = New System.Drawing.Size(950, 700)
		Me.MinimizeBox = False
		Me.MinimumSize = New System.Drawing.Size(950, 700)
		Me.Name = "FrmEditarOrdenEntregado"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Editar Orden Entregada"
		Me.tableLayoutPanelGeneral.ResumeLayout(False)
		Me.tableLayoutPanelLeft.ResumeLayout(False)
		DirectCast(Me.dataGridViewOrigen, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tableLayoutPanelCentral.ResumeLayout(False)
		Me.tableLayoutPanelTop.ResumeLayout(False)
		Me.tableLayoutPanelTop.PerformLayout()
		Me.tableLayoutPanel7.ResumeLayout(False)
		Me.tableLayoutPanel7.PerformLayout()
		Me.tableLayoutPanel8.ResumeLayout(False)
		Me.tableLayoutPanel1.ResumeLayout(False)
		Me.tableLayoutPanel2.ResumeLayout(False)
		Me.tableLayoutPanel2.PerformLayout()
		Me.tableLayoutPanel3.ResumeLayout(False)
		Me.tableLayoutPanel3.PerformLayout()
		Me.tableLayoutPanel6.ResumeLayout(False)
		Me.tableLayoutPanel6.PerformLayout()
		Me.tableLayoutPanel4.ResumeLayout(False)
		Me.tableLayoutPanel4.PerformLayout()
		Me.tableLayoutPanel5.ResumeLayout(False)
		DirectCast(Me.dataGridViewProductos, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private tableLayoutPanelGeneral As System.Windows.Forms.TableLayoutPanel
	Private tableLayoutPanelLeft As System.Windows.Forms.TableLayoutPanel
	Private panel1 As System.Windows.Forms.Panel
	Private tableLayoutPanelCentral As System.Windows.Forms.TableLayoutPanel
	Private tableLayoutPanelTop As System.Windows.Forms.TableLayoutPanel
	Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Private tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
	Private labelSubTitulo As System.Windows.Forms.Label
	Private labelCliente As System.Windows.Forms.Label
	Private labelTransporte As System.Windows.Forms.Label
	Private labelResponsable As System.Windows.Forms.Label
	Private comboBoxClientes As System.Windows.Forms.ComboBox
	Private comboBoxTransportes As System.Windows.Forms.ComboBox
	Private comboBoxEmpleados As System.Windows.Forms.ComboBox
	Private labelFechaOrdenado As System.Windows.Forms.Label
	Private labelFechaEntregado As System.Windows.Forms.Label
	Private labelCostoEnvio As System.Windows.Forms.Label
	Private labelSubTitulo2 As System.Windows.Forms.Label
	Private tableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
	Private textBoxCostoEnvio As System.Windows.Forms.TextBox
	Private labelProducto As System.Windows.Forms.Label
	Private comboBoxProductos As System.Windows.Forms.ComboBox
	Private tableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
	Private buttonGuardar As System.Windows.Forms.Button
	Private buttonCancelar As System.Windows.Forms.Button
	Private toolTipAgregarProducto As System.Windows.Forms.ToolTip
	Private toolTipEliminarProducto As System.Windows.Forms.ToolTip
	Private tableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
	Private label1 As System.Windows.Forms.Label
	Private tableLayoutPanel8 As System.Windows.Forms.TableLayoutPanel
	Private label3 As System.Windows.Forms.Label
	Private labelNumeroPedido As System.Windows.Forms.Label
	Private dataGridViewProductos As System.Windows.Forms.DataGridView
	Private numero As System.Windows.Forms.DataGridViewTextBoxColumn
	Private producto As System.Windows.Forms.DataGridViewTextBoxColumn
	Private cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
	Private precio As System.Windows.Forms.DataGridViewTextBoxColumn
	Private descuento As System.Windows.Forms.DataGridViewTextBoxColumn
	Private dataGridViewOrigen As System.Windows.Forms.DataGridView
	Private tableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
	Private textBoxDescuento As System.Windows.Forms.TextBox
	Private labelCantidad As System.Windows.Forms.Label
	Private labelDescuento As System.Windows.Forms.Label
	Private buttonAgregarProducto As System.Windows.Forms.Button
	Private buttonEliminarProducto As System.Windows.Forms.Button
	Private tableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
	Private textBoxPrecio As System.Windows.Forms.TextBox
	Private labelPrecio As System.Windows.Forms.Label
	Private labelPeso As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private textBoxCantidad As System.Windows.Forms.TextBox
	Private dateTimePickerFechaOrdenado As System.Windows.Forms.DateTimePicker
	Private dateTimePickerFechaEntregado As System.Windows.Forms.DateTimePicker


End Class
