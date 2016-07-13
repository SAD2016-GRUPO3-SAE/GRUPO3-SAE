Partial Class Ordenes
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

	#Region "Component Designer generated code"

	''' <summary> 
	''' Required method for Designer support - do not modify 
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Dim dataGridViewCellStyle1 As New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle2 As New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle4 As New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle3 As New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle5 As New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle6 As New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle8 As New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle7 As New System.Windows.Forms.DataGridViewCellStyle()
		Me.tableLayoutPanelGeneral = New System.Windows.Forms.TableLayoutPanel()
		Me.tableLayoutPanelBottom = New System.Windows.Forms.TableLayoutPanel()
		Me.tableLayoutPanelPaginacion = New System.Windows.Forms.TableLayoutPanel()
		Me.buttonSiguiente = New System.Windows.Forms.Button()
		Me.buttonAnterior = New System.Windows.Forms.Button()
		Me.labelPagina = New System.Windows.Forms.Label()
		Me.labelMensajes = New System.Windows.Forms.Label()
		Me.tabControlPedidos = New System.Windows.Forms.TabControl()
		Me.tabPagePendientes = New System.Windows.Forms.TabPage()
		Me.dataGridViewPedidosPendientes = New System.Windows.Forms.DataGridView()
		Me.ver_pedidos = New System.Windows.Forms.DataGridViewButtonColumn()
		Me.tabPageEntregados = New System.Windows.Forms.TabPage()
		Me.dataGridViewPedidosEntregados = New System.Windows.Forms.DataGridView()
		Me.dataGridViewButtonColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.tableLayoutPanelTop = New System.Windows.Forms.TableLayoutPanel()
		Me.buttonAgregar = New System.Windows.Forms.Button()
		Me.buttonEliminar = New System.Windows.Forms.Button()
		Me.buttonEditar = New System.Windows.Forms.Button()
		Me.buttonMarcarEntregado = New System.Windows.Forms.Button()
		Me.groupBoxBuscar = New System.Windows.Forms.GroupBox()
		Me.tableLayoutPanelBuscar = New System.Windows.Forms.TableLayoutPanel()
		Me.labelNombre = New System.Windows.Forms.Label()
		Me.textBoxBuscarNombre = New System.Windows.Forms.TextBox()
		Me.buttonRefrescar = New System.Windows.Forms.Button()
		Me.labelTitulo = New System.Windows.Forms.Label()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.tableLayoutPanelGeneral.SuspendLayout()
		Me.tableLayoutPanelBottom.SuspendLayout()
		Me.tableLayoutPanelPaginacion.SuspendLayout()
		Me.tabControlPedidos.SuspendLayout()
		Me.tabPagePendientes.SuspendLayout()
		DirectCast(Me.dataGridViewPedidosPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.tabPageEntregados.SuspendLayout()
		DirectCast(Me.dataGridViewPedidosEntregados, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.panel1.SuspendLayout()
		Me.tableLayoutPanelTop.SuspendLayout()
		Me.groupBoxBuscar.SuspendLayout()
		Me.tableLayoutPanelBuscar.SuspendLayout()
		Me.SuspendLayout()
		' 
		' tableLayoutPanelGeneral
		' 
		Me.tableLayoutPanelGeneral.ColumnCount = 1
		Me.tableLayoutPanelGeneral.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
		Me.tableLayoutPanelGeneral.Controls.Add(Me.tableLayoutPanelBottom, 0, 2)
		Me.tableLayoutPanelGeneral.Controls.Add(Me.tabControlPedidos, 0, 1)
		Me.tableLayoutPanelGeneral.Controls.Add(Me.panel1, 0, 0)
		Me.tableLayoutPanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tableLayoutPanelGeneral.Location = New System.Drawing.Point(0, 0)
		Me.tableLayoutPanelGeneral.Name = "tableLayoutPanelGeneral"
		Me.tableLayoutPanelGeneral.RowCount = 3
		Me.tableLayoutPanelGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F))
		Me.tableLayoutPanelGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
		Me.tableLayoutPanelGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F))
		Me.tableLayoutPanelGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F))
		Me.tableLayoutPanelGeneral.Size = New System.Drawing.Size(985, 448)
		Me.tableLayoutPanelGeneral.TabIndex = 0
		' 
		' tableLayoutPanelBottom
		' 
		Me.tableLayoutPanelBottom.ColumnCount = 2
		Me.tableLayoutPanelBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.52239F))
		Me.tableLayoutPanelBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.47761F))
		Me.tableLayoutPanelBottom.Controls.Add(Me.tableLayoutPanelPaginacion, 1, 0)
		Me.tableLayoutPanelBottom.Controls.Add(Me.labelMensajes, 0, 0)
		Me.tableLayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tableLayoutPanelBottom.Location = New System.Drawing.Point(3, 407)
		Me.tableLayoutPanelBottom.Name = "tableLayoutPanelBottom"
		Me.tableLayoutPanelBottom.RowCount = 1
		Me.tableLayoutPanelBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanelBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F))
		Me.tableLayoutPanelBottom.Size = New System.Drawing.Size(979, 38)
		Me.tableLayoutPanelBottom.TabIndex = 4
		' 
		' tableLayoutPanelPaginacion
		' 
		Me.tableLayoutPanelPaginacion.ColumnCount = 3
		Me.tableLayoutPanelPaginacion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
		Me.tableLayoutPanelPaginacion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F))
		Me.tableLayoutPanelPaginacion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F))
		Me.tableLayoutPanelPaginacion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F))
		Me.tableLayoutPanelPaginacion.Controls.Add(Me.buttonSiguiente, 2, 0)
		Me.tableLayoutPanelPaginacion.Controls.Add(Me.buttonAnterior, 1, 0)
		Me.tableLayoutPanelPaginacion.Controls.Add(Me.labelPagina, 0, 0)
		Me.tableLayoutPanelPaginacion.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tableLayoutPanelPaginacion.Location = New System.Drawing.Point(546, 3)
		Me.tableLayoutPanelPaginacion.Name = "tableLayoutPanelPaginacion"
		Me.tableLayoutPanelPaginacion.RowCount = 1
		Me.tableLayoutPanelPaginacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
		Me.tableLayoutPanelPaginacion.Size = New System.Drawing.Size(430, 32)
		Me.tableLayoutPanelPaginacion.TabIndex = 2
		' 
		' buttonSiguiente
		' 
		Me.buttonSiguiente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonSiguiente.BackColor = System.Drawing.Color.LightSkyBlue
		Me.buttonSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.buttonSiguiente.Location = New System.Drawing.Point(333, 0)
		Me.buttonSiguiente.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
		Me.buttonSiguiente.Name = "buttonSiguiente"
		Me.buttonSiguiente.Size = New System.Drawing.Size(97, 32)
		Me.buttonSiguiente.TabIndex = 0
		Me.buttonSiguiente.Text = ">>"
		Me.buttonSiguiente.UseVisualStyleBackColor = False
		AddHandler Me.buttonSiguiente.Click, New System.EventHandler(AddressOf Me.buttonSiguiente_Click)
		' 
		' buttonAnterior
		' 
		Me.buttonAnterior.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonAnterior.BackColor = System.Drawing.Color.LightSkyBlue
		Me.buttonAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.buttonAnterior.Location = New System.Drawing.Point(228, 0)
		Me.buttonAnterior.Margin = New System.Windows.Forms.Padding(0, 0, 5, 0)
		Me.buttonAnterior.Name = "buttonAnterior"
		Me.buttonAnterior.Size = New System.Drawing.Size(95, 32)
		Me.buttonAnterior.TabIndex = 1
		Me.buttonAnterior.Text = "<<"
		Me.buttonAnterior.UseVisualStyleBackColor = False
		AddHandler Me.buttonAnterior.Click, New System.EventHandler(AddressOf Me.buttonAnterior_Click)
		' 
		' labelPagina
		' 
		Me.labelPagina.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.labelPagina.AutoSize = True
		Me.labelPagina.Font = New System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelPagina.Location = New System.Drawing.Point(125, 6)
		Me.labelPagina.Name = "labelPagina"
		Me.labelPagina.Size = New System.Drawing.Size(100, 19)
		Me.labelPagina.TabIndex = 2
		Me.labelPagina.Text = "Página X de X"
		' 
		' labelMensajes
		' 
		Me.labelMensajes.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelMensajes.AutoSize = True
		Me.labelMensajes.Font = New System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelMensajes.Location = New System.Drawing.Point(3, 9)
		Me.labelMensajes.Name = "labelMensajes"
		Me.labelMensajes.Size = New System.Drawing.Size(441, 19)
		Me.labelMensajes.TabIndex = 3
		Me.labelMensajes.Text = "Bienvenido al Sistema Compras... Este será su Área de Mensajes"
		Me.labelMensajes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		' 
		' tabControlPedidos
		' 
		Me.tabControlPedidos.Controls.Add(Me.tabPagePendientes)
		Me.tabControlPedidos.Controls.Add(Me.tabPageEntregados)
		Me.tabControlPedidos.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tabControlPedidos.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.tabControlPedidos.Location = New System.Drawing.Point(13, 102)
		Me.tabControlPedidos.Margin = New System.Windows.Forms.Padding(13, 3, 3, 3)
		Me.tabControlPedidos.Name = "tabControlPedidos"
		Me.tabControlPedidos.SelectedIndex = 0
		Me.tabControlPedidos.Size = New System.Drawing.Size(969, 299)
		Me.tabControlPedidos.TabIndex = 2
		AddHandler Me.tabControlPedidos.Selected, New System.Windows.Forms.TabControlEventHandler(AddressOf Me.tabControlPedidos_Selected)
		' 
		' tabPagePendientes
		' 
		Me.tabPagePendientes.Controls.Add(Me.dataGridViewPedidosPendientes)
		Me.tabPagePendientes.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold)
		Me.tabPagePendientes.Location = New System.Drawing.Point(4, 35)
		Me.tabPagePendientes.Name = "tabPagePendientes"
		Me.tabPagePendientes.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPagePendientes.Size = New System.Drawing.Size(961, 260)
		Me.tabPagePendientes.TabIndex = 0
		Me.tabPagePendientes.Text = "PENDIENTES"
		Me.tabPagePendientes.UseVisualStyleBackColor = True
		' 
		' dataGridViewPedidosPendientes
		' 
		Me.dataGridViewPedidosPendientes.AllowUserToAddRows = False
		Me.dataGridViewPedidosPendientes.AllowUserToDeleteRows = False
		Me.dataGridViewPedidosPendientes.AllowUserToOrderColumns = True
		Me.dataGridViewPedidosPendientes.AllowUserToResizeRows = False
		dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue
		dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue
		dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.dataGridViewPedidosPendientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1
		Me.dataGridViewPedidosPendientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
		Me.dataGridViewPedidosPendientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
		Me.dataGridViewPedidosPendientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
		Me.dataGridViewPedidosPendientes.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dataGridViewPedidosPendientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
		Me.dataGridViewPedidosPendientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonShadow
		dataGridViewCellStyle2.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold)
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dataGridViewPedidosPendientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
		Me.dataGridViewPedidosPendientes.ColumnHeadersHeight = 50
		Me.dataGridViewPedidosPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
		Me.dataGridViewPedidosPendientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ver_pedidos})
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
		dataGridViewCellStyle4.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold)
		dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Desktop
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Control
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dataGridViewPedidosPendientes.DefaultCellStyle = dataGridViewCellStyle4
		Me.dataGridViewPedidosPendientes.Dock = System.Windows.Forms.DockStyle.Fill
		Me.dataGridViewPedidosPendientes.EnableHeadersVisualStyles = False
		Me.dataGridViewPedidosPendientes.Location = New System.Drawing.Point(3, 3)
		Me.dataGridViewPedidosPendientes.Margin = New System.Windows.Forms.Padding(3, 3, 7, 3)
		Me.dataGridViewPedidosPendientes.MultiSelect = False
		Me.dataGridViewPedidosPendientes.Name = "dataGridViewPedidosPendientes"
		Me.dataGridViewPedidosPendientes.[ReadOnly] = True
		Me.dataGridViewPedidosPendientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		Me.dataGridViewPedidosPendientes.RowHeadersVisible = False
		Me.dataGridViewPedidosPendientes.RowTemplate.[ReadOnly] = True
		Me.dataGridViewPedidosPendientes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dataGridViewPedidosPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dataGridViewPedidosPendientes.ShowCellErrors = False
		Me.dataGridViewPedidosPendientes.ShowCellToolTips = False
		Me.dataGridViewPedidosPendientes.ShowEditingIcon = False
		Me.dataGridViewPedidosPendientes.ShowRowErrors = False
		Me.dataGridViewPedidosPendientes.Size = New System.Drawing.Size(955, 254)
		Me.dataGridViewPedidosPendientes.TabIndex = 3
		AddHandler Me.dataGridViewPedidosPendientes.CellContentClick, New System.Windows.Forms.DataGridViewCellEventHandler(AddressOf Me.dataGridViewPedidosPendientes_CellContentClick)
		' 
		' ver_pedidos
		' 
		Me.ver_pedidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		dataGridViewCellStyle3.Font = New System.Drawing.Font("Candara", 11.75F, System.Drawing.FontStyle.Bold)
		Me.ver_pedidos.DefaultCellStyle = dataGridViewCellStyle3
		Me.ver_pedidos.Frozen = True
		Me.ver_pedidos.HeaderText = ""
		Me.ver_pedidos.Name = "ver_pedidos"
		Me.ver_pedidos.[ReadOnly] = True
		Me.ver_pedidos.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.ver_pedidos.Text = "VER PEDIDO"
		Me.ver_pedidos.UseColumnTextForButtonValue = True
		Me.ver_pedidos.Width = 5
		' 
		' tabPageEntregados
		' 
		Me.tabPageEntregados.Controls.Add(Me.dataGridViewPedidosEntregados)
		Me.tabPageEntregados.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.tabPageEntregados.Location = New System.Drawing.Point(4, 35)
		Me.tabPageEntregados.Name = "tabPageEntregados"
		Me.tabPageEntregados.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPageEntregados.Size = New System.Drawing.Size(948, 169)
		Me.tabPageEntregados.TabIndex = 1
		Me.tabPageEntregados.Text = "ENTREGADOS"
		Me.tabPageEntregados.UseVisualStyleBackColor = True
		' 
		' dataGridViewPedidosEntregados
		' 
		Me.dataGridViewPedidosEntregados.AllowUserToAddRows = False
		Me.dataGridViewPedidosEntregados.AllowUserToDeleteRows = False
		Me.dataGridViewPedidosEntregados.AllowUserToOrderColumns = True
		Me.dataGridViewPedidosEntregados.AllowUserToResizeRows = False
		dataGridViewCellStyle5.BackColor = System.Drawing.Color.PowderBlue
		dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue
		dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.dataGridViewPedidosEntregados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5
		Me.dataGridViewPedidosEntregados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
		Me.dataGridViewPedidosEntregados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
		Me.dataGridViewPedidosEntregados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
		Me.dataGridViewPedidosEntregados.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dataGridViewPedidosEntregados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
		Me.dataGridViewPedidosEntregados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonShadow
		dataGridViewCellStyle6.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window
		dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dataGridViewPedidosEntregados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6
		Me.dataGridViewPedidosEntregados.ColumnHeadersHeight = 50
		Me.dataGridViewPedidosEntregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
		Me.dataGridViewPedidosEntregados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dataGridViewButtonColumn1})
		dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
		dataGridViewCellStyle8.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Desktop
		dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DodgerBlue
		dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Control
		dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dataGridViewPedidosEntregados.DefaultCellStyle = dataGridViewCellStyle8
		Me.dataGridViewPedidosEntregados.Dock = System.Windows.Forms.DockStyle.Fill
		Me.dataGridViewPedidosEntregados.EnableHeadersVisualStyles = False
		Me.dataGridViewPedidosEntregados.Location = New System.Drawing.Point(3, 3)
		Me.dataGridViewPedidosEntregados.Margin = New System.Windows.Forms.Padding(3, 3, 7, 3)
		Me.dataGridViewPedidosEntregados.MultiSelect = False
		Me.dataGridViewPedidosEntregados.Name = "dataGridViewPedidosEntregados"
		Me.dataGridViewPedidosEntregados.[ReadOnly] = True
		Me.dataGridViewPedidosEntregados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		Me.dataGridViewPedidosEntregados.RowHeadersVisible = False
		Me.dataGridViewPedidosEntregados.RowTemplate.[ReadOnly] = True
		Me.dataGridViewPedidosEntregados.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dataGridViewPedidosEntregados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dataGridViewPedidosEntregados.ShowCellErrors = False
		Me.dataGridViewPedidosEntregados.ShowCellToolTips = False
		Me.dataGridViewPedidosEntregados.ShowEditingIcon = False
		Me.dataGridViewPedidosEntregados.ShowRowErrors = False
		Me.dataGridViewPedidosEntregados.Size = New System.Drawing.Size(942, 163)
		Me.dataGridViewPedidosEntregados.TabIndex = 4
		AddHandler Me.dataGridViewPedidosEntregados.CellContentClick, New System.Windows.Forms.DataGridViewCellEventHandler(AddressOf Me.dataGridViewPedidosEntregados_CellContentClick)
		' 
		' dataGridViewButtonColumn1
		' 
		Me.dataGridViewButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
		dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		dataGridViewCellStyle7.Font = New System.Drawing.Font("Candara", 11.75F, System.Drawing.FontStyle.Bold)
		Me.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle7
		Me.dataGridViewButtonColumn1.Frozen = True
		Me.dataGridViewButtonColumn1.HeaderText = ""
		Me.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1"
		Me.dataGridViewButtonColumn1.[ReadOnly] = True
		Me.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dataGridViewButtonColumn1.Text = "VER PEDIDO"
		Me.dataGridViewButtonColumn1.UseColumnTextForButtonValue = True
		Me.dataGridViewButtonColumn1.Width = 5
		' 
		' panel1
		' 
		Me.panel1.Controls.Add(Me.tableLayoutPanelTop)
		Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.panel1.Location = New System.Drawing.Point(3, 3)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(979, 93)
		Me.panel1.TabIndex = 5
		' 
		' tableLayoutPanelTop
		' 
		Me.tableLayoutPanelTop.ColumnCount = 6
		Me.tableLayoutPanelTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 324F))
		Me.tableLayoutPanelTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
		Me.tableLayoutPanelTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 221F))
		Me.tableLayoutPanelTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F))
		Me.tableLayoutPanelTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F))
		Me.tableLayoutPanelTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F))
		Me.tableLayoutPanelTop.Controls.Add(Me.buttonAgregar, 5, 0)
		Me.tableLayoutPanelTop.Controls.Add(Me.buttonEliminar, 4, 0)
		Me.tableLayoutPanelTop.Controls.Add(Me.buttonEditar, 3, 0)
		Me.tableLayoutPanelTop.Controls.Add(Me.buttonMarcarEntregado, 2, 0)
		Me.tableLayoutPanelTop.Controls.Add(Me.groupBoxBuscar, 1, 0)
		Me.tableLayoutPanelTop.Controls.Add(Me.labelTitulo, 0, 0)
		Me.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tableLayoutPanelTop.Location = New System.Drawing.Point(0, 0)
		Me.tableLayoutPanelTop.Name = "tableLayoutPanelTop"
		Me.tableLayoutPanelTop.RowCount = 1
		Me.tableLayoutPanelTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
		Me.tableLayoutPanelTop.Size = New System.Drawing.Size(979, 93)
		Me.tableLayoutPanelTop.TabIndex = 1
		' 
		' buttonAgregar
		' 
		Me.buttonAgregar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonAgregar.BackColor = System.Drawing.SystemColors.Window
		Me.buttonAgregar.Font = New System.Drawing.Font("Candara", 9.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.buttonAgregar.Image = Global.CapaPresentacion.Properties.Resources.agregar
		Me.buttonAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.buttonAgregar.Location = New System.Drawing.Point(912, 8)
		Me.buttonAgregar.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
		Me.buttonAgregar.Name = "buttonAgregar"
		Me.buttonAgregar.Size = New System.Drawing.Size(64, 82)
		Me.buttonAgregar.TabIndex = 1
		Me.buttonAgregar.Text = "Agregar"
		Me.buttonAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.buttonAgregar.UseVisualStyleBackColor = False
		AddHandler Me.buttonAgregar.Click, New System.EventHandler(AddressOf Me.buttonAgregar_Click)
		' 
		' buttonEliminar
		' 
		Me.buttonEliminar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonEliminar.BackColor = System.Drawing.SystemColors.Window
		Me.buttonEliminar.Font = New System.Drawing.Font("Candara", 9.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.buttonEliminar.Image = Global.CapaPresentacion.Properties.Resources.eliminar
		Me.buttonEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.buttonEliminar.Location = New System.Drawing.Point(842, 8)
		Me.buttonEliminar.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
		Me.buttonEliminar.Name = "buttonEliminar"
		Me.buttonEliminar.Size = New System.Drawing.Size(64, 82)
		Me.buttonEliminar.TabIndex = 2
		Me.buttonEliminar.Text = "Eliminar"
		Me.buttonEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.buttonEliminar.UseVisualStyleBackColor = False
		AddHandler Me.buttonEliminar.Click, New System.EventHandler(AddressOf Me.buttonEliminar_Click)
		' 
		' buttonEditar
		' 
		Me.buttonEditar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonEditar.BackColor = System.Drawing.SystemColors.Window
		Me.buttonEditar.Font = New System.Drawing.Font("Candara", 9.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.buttonEditar.Image = Global.CapaPresentacion.Properties.Resources.editar
		Me.buttonEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.buttonEditar.Location = New System.Drawing.Point(772, 8)
		Me.buttonEditar.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
		Me.buttonEditar.Name = "buttonEditar"
		Me.buttonEditar.Size = New System.Drawing.Size(64, 82)
		Me.buttonEditar.TabIndex = 3
		Me.buttonEditar.Text = "Editar"
		Me.buttonEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.buttonEditar.UseVisualStyleBackColor = False
		AddHandler Me.buttonEditar.Click, New System.EventHandler(AddressOf Me.buttonEditar_Click)
		' 
		' buttonMarcarEntregado
		' 
		Me.buttonMarcarEntregado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonMarcarEntregado.BackColor = System.Drawing.SystemColors.Window
		Me.buttonMarcarEntregado.Font = New System.Drawing.Font("Candara", 9.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.buttonMarcarEntregado.Image = Global.CapaPresentacion.Properties.Resources.marcarEntregadoPendiente
		Me.buttonMarcarEntregado.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.buttonMarcarEntregado.Location = New System.Drawing.Point(551, 8)
		Me.buttonMarcarEntregado.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
		Me.buttonMarcarEntregado.Name = "buttonMarcarEntregado"
		Me.buttonMarcarEntregado.Size = New System.Drawing.Size(215, 82)
		Me.buttonMarcarEntregado.TabIndex = 5
		Me.buttonMarcarEntregado.Text = "Marcar Orden  Pendiete/Entregado"
		Me.buttonMarcarEntregado.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.buttonMarcarEntregado.UseVisualStyleBackColor = False
		AddHandler Me.buttonMarcarEntregado.Click, New System.EventHandler(AddressOf Me.buttonMarcarEntregado_Click)
		' 
		' groupBoxBuscar
		' 
		Me.groupBoxBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.groupBoxBuscar.Controls.Add(Me.tableLayoutPanelBuscar)
		Me.groupBoxBuscar.Font = New System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.groupBoxBuscar.Location = New System.Drawing.Point(341, 1)
		Me.groupBoxBuscar.Margin = New System.Windows.Forms.Padding(3, 1, 3, 4)
		Me.groupBoxBuscar.Name = "groupBoxBuscar"
		Me.groupBoxBuscar.Size = New System.Drawing.Size(204, 88)
		Me.groupBoxBuscar.TabIndex = 4
		Me.groupBoxBuscar.TabStop = False
		Me.groupBoxBuscar.Text = "Buscar Orden"
		' 
		' tableLayoutPanelBuscar
		' 
		Me.tableLayoutPanelBuscar.BackColor = System.Drawing.Color.Transparent
		Me.tableLayoutPanelBuscar.ColumnCount = 2
		Me.tableLayoutPanelBuscar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.67347F))
		Me.tableLayoutPanelBuscar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.32653F))
		Me.tableLayoutPanelBuscar.Controls.Add(Me.labelNombre, 0, 0)
		Me.tableLayoutPanelBuscar.Controls.Add(Me.textBoxBuscarNombre, 1, 0)
		Me.tableLayoutPanelBuscar.Controls.Add(Me.buttonRefrescar, 1, 1)
		Me.tableLayoutPanelBuscar.Location = New System.Drawing.Point(0, 21)
		Me.tableLayoutPanelBuscar.Name = "tableLayoutPanelBuscar"
		Me.tableLayoutPanelBuscar.RowCount = 2
		Me.tableLayoutPanelBuscar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanelBuscar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanelBuscar.Size = New System.Drawing.Size(196, 54)
		Me.tableLayoutPanelBuscar.TabIndex = 0
		' 
		' labelNombre
		' 
		Me.labelNombre.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.labelNombre.AutoSize = True
		Me.labelNombre.Location = New System.Drawing.Point(8, 5)
		Me.labelNombre.Name = "labelNombre"
		Me.labelNombre.Size = New System.Drawing.Size(55, 17)
		Me.labelNombre.TabIndex = 0
		Me.labelNombre.Text = "Código:"
		' 
		' textBoxBuscarNombre
		' 
		Me.textBoxBuscarNombre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxBuscarNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxBuscarNombre.Location = New System.Drawing.Point(69, 3)
		Me.textBoxBuscarNombre.Name = "textBoxBuscarNombre"
		Me.textBoxBuscarNombre.Size = New System.Drawing.Size(124, 22)
		Me.textBoxBuscarNombre.TabIndex = 1
		AddHandler Me.textBoxBuscarNombre.TextChanged, New System.EventHandler(AddressOf Me.textBoxBuscarNombre_TextChanged)
		' 
		' buttonRefrescar
		' 
		Me.buttonRefrescar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonRefrescar.BackColor = System.Drawing.Color.LightSkyBlue
		Me.buttonRefrescar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.buttonRefrescar.Location = New System.Drawing.Point(68, 27)
		Me.buttonRefrescar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.buttonRefrescar.Name = "buttonRefrescar"
		Me.buttonRefrescar.Size = New System.Drawing.Size(126, 27)
		Me.buttonRefrescar.TabIndex = 3
		Me.buttonRefrescar.Text = "Refrescar"
		Me.buttonRefrescar.UseVisualStyleBackColor = False
		AddHandler Me.buttonRefrescar.Click, New System.EventHandler(AddressOf Me.buttonRefrescar_Click)
		' 
		' labelTitulo
		' 
		Me.labelTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelTitulo.AutoSize = True
		Me.labelTitulo.Font = New System.Drawing.Font("Candara", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelTitulo.ForeColor = System.Drawing.Color.Black
		Me.labelTitulo.Location = New System.Drawing.Point(0, 10)
		Me.labelTitulo.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
		Me.labelTitulo.Name = "labelTitulo"
		Me.labelTitulo.Size = New System.Drawing.Size(284, 73)
		Me.labelTitulo.TabIndex = 0
		Me.labelTitulo.Text = "ORDENES"
		' 
		' panel2
		' 
		Me.panel2.BackColor = System.Drawing.Color.LightSkyBlue
		Me.panel2.Location = New System.Drawing.Point(0, 448)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(985, 34)
		Me.panel2.TabIndex = 1
		' 
		' Ordenes
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.ClientSize = New System.Drawing.Size(985, 448)
		Me.Controls.Add(Me.panel2)
		Me.Controls.Add(Me.tableLayoutPanelGeneral)
		Me.Name = "Ordenes"
		Me.Text = "Ordenes de Compra"
		Me.tableLayoutPanelGeneral.ResumeLayout(False)
		Me.tableLayoutPanelBottom.ResumeLayout(False)
		Me.tableLayoutPanelBottom.PerformLayout()
		Me.tableLayoutPanelPaginacion.ResumeLayout(False)
		Me.tableLayoutPanelPaginacion.PerformLayout()
		Me.tabControlPedidos.ResumeLayout(False)
		Me.tabPagePendientes.ResumeLayout(False)
		DirectCast(Me.dataGridViewPedidosPendientes, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tabPageEntregados.ResumeLayout(False)
		DirectCast(Me.dataGridViewPedidosEntregados, System.ComponentModel.ISupportInitialize).EndInit()
		Me.panel1.ResumeLayout(False)
		Me.tableLayoutPanelTop.ResumeLayout(False)
		Me.tableLayoutPanelTop.PerformLayout()
		Me.groupBoxBuscar.ResumeLayout(False)
		Me.tableLayoutPanelBuscar.ResumeLayout(False)
		Me.tableLayoutPanelBuscar.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private tableLayoutPanelGeneral As System.Windows.Forms.TableLayoutPanel
	Private tabControlPedidos As System.Windows.Forms.TabControl
	Private tabPagePendientes As System.Windows.Forms.TabPage
	Private tabPageEntregados As System.Windows.Forms.TabPage
	Private tableLayoutPanelBottom As System.Windows.Forms.TableLayoutPanel
	Private tableLayoutPanelPaginacion As System.Windows.Forms.TableLayoutPanel
	Private buttonSiguiente As System.Windows.Forms.Button
	Private buttonAnterior As System.Windows.Forms.Button
	Private labelPagina As System.Windows.Forms.Label
	Private labelMensajes As System.Windows.Forms.Label
	Private dataGridViewPedidosPendientes As System.Windows.Forms.DataGridView
	Private panel1 As System.Windows.Forms.Panel
	Private tableLayoutPanelTop As System.Windows.Forms.TableLayoutPanel
	Private labelTitulo As System.Windows.Forms.Label
	Private buttonAgregar As System.Windows.Forms.Button
	Private buttonEliminar As System.Windows.Forms.Button
	Private buttonEditar As System.Windows.Forms.Button
	Private groupBoxBuscar As System.Windows.Forms.GroupBox
	Private tableLayoutPanelBuscar As System.Windows.Forms.TableLayoutPanel
	Private labelNombre As System.Windows.Forms.Label
	Private textBoxBuscarNombre As System.Windows.Forms.TextBox
	Private buttonRefrescar As System.Windows.Forms.Button
	Private ver_pedidos As System.Windows.Forms.DataGridViewButtonColumn
	Private buttonMarcarEntregado As System.Windows.Forms.Button
	Private dataGridViewPedidosEntregados As System.Windows.Forms.DataGridView
	Private dataGridViewButtonColumn1 As System.Windows.Forms.DataGridViewButtonColumn
	Private panel2 As System.Windows.Forms.Panel
End Class
