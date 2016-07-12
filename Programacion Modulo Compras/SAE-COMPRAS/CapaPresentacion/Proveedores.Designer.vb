Partial Class Proveedores
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
		Dim dataGridViewCellStyle3 As New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle4 As New System.Windows.Forms.DataGridViewCellStyle()
		Me.tableLayoutPanelGeneral = New System.Windows.Forms.TableLayoutPanel()
		Me.tableLayoutPanelTop = New System.Windows.Forms.TableLayoutPanel()
		Me.labelTitulo = New System.Windows.Forms.Label()
		Me.buttonAgregar = New System.Windows.Forms.Button()
		Me.buttonEliminar = New System.Windows.Forms.Button()
		Me.buttonEditar = New System.Windows.Forms.Button()
		Me.groupBoxBuscar = New System.Windows.Forms.GroupBox()
		Me.tableLayoutPanelBuscar = New System.Windows.Forms.TableLayoutPanel()
		Me.labelNombre = New System.Windows.Forms.Label()
		Me.buttonRefrescar = New System.Windows.Forms.Button()
		Me.textBoxBuscarNombre = New System.Windows.Forms.TextBox()
		Me.dataGridViewClientes = New System.Windows.Forms.DataGridView()
		Me.tableLayoutPanelBottom = New System.Windows.Forms.TableLayoutPanel()
		Me.tableLayoutPanelPaginacion = New System.Windows.Forms.TableLayoutPanel()
		Me.buttonSiguiente = New System.Windows.Forms.Button()
		Me.buttonAnterior = New System.Windows.Forms.Button()
		Me.labelPagina = New System.Windows.Forms.Label()
		Me.labelMensajes = New System.Windows.Forms.Label()
		Me.tableLayoutPanelGeneral.SuspendLayout()
		Me.tableLayoutPanelTop.SuspendLayout()
		Me.groupBoxBuscar.SuspendLayout()
		Me.tableLayoutPanelBuscar.SuspendLayout()
		DirectCast(Me.dataGridViewClientes, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.tableLayoutPanelBottom.SuspendLayout()
		Me.tableLayoutPanelPaginacion.SuspendLayout()
		Me.SuspendLayout()
		' 
		' tableLayoutPanelGeneral
		' 
		Me.tableLayoutPanelGeneral.ColumnCount = 1
		Me.tableLayoutPanelGeneral.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
		Me.tableLayoutPanelGeneral.Controls.Add(Me.tableLayoutPanelTop, 0, 0)
		Me.tableLayoutPanelGeneral.Controls.Add(Me.dataGridViewClientes, 0, 1)
		Me.tableLayoutPanelGeneral.Controls.Add(Me.tableLayoutPanelBottom, 0, 2)
		Me.tableLayoutPanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tableLayoutPanelGeneral.Location = New System.Drawing.Point(0, 0)
		Me.tableLayoutPanelGeneral.Name = "tableLayoutPanelGeneral"
		Me.tableLayoutPanelGeneral.RowCount = 3
		Me.tableLayoutPanelGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F))
		Me.tableLayoutPanelGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
		Me.tableLayoutPanelGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F))
		Me.tableLayoutPanelGeneral.Size = New System.Drawing.Size(848, 353)
		Me.tableLayoutPanelGeneral.TabIndex = 0
		' 
		' tableLayoutPanelTop
		' 
		Me.tableLayoutPanelTop.ColumnCount = 6
		Me.tableLayoutPanelTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 409F))
		Me.tableLayoutPanelTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
		Me.tableLayoutPanelTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F))
		Me.tableLayoutPanelTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F))
		Me.tableLayoutPanelTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F))
		Me.tableLayoutPanelTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F))
		Me.tableLayoutPanelTop.Controls.Add(Me.labelTitulo, 0, 0)
		Me.tableLayoutPanelTop.Controls.Add(Me.buttonAgregar, 5, 0)
		Me.tableLayoutPanelTop.Controls.Add(Me.buttonEliminar, 4, 0)
		Me.tableLayoutPanelTop.Controls.Add(Me.buttonEditar, 3, 0)
		Me.tableLayoutPanelTop.Controls.Add(Me.groupBoxBuscar, 2, 0)
		Me.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Top
		Me.tableLayoutPanelTop.Location = New System.Drawing.Point(3, 3)
		Me.tableLayoutPanelTop.Name = "tableLayoutPanelTop"
		Me.tableLayoutPanelTop.RowCount = 1
		Me.tableLayoutPanelTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
		Me.tableLayoutPanelTop.Size = New System.Drawing.Size(842, 89)
		Me.tableLayoutPanelTop.TabIndex = 0
		' 
		' labelTitulo
		' 
		Me.labelTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelTitulo.AutoSize = True
		Me.labelTitulo.Font = New System.Drawing.Font("Candara", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelTitulo.ForeColor = System.Drawing.SystemColors.Desktop
		Me.labelTitulo.Location = New System.Drawing.Point(0, 12)
		Me.labelTitulo.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
		Me.labelTitulo.Name = "labelTitulo"
		Me.labelTitulo.Size = New System.Drawing.Size(372, 64)
		Me.labelTitulo.TabIndex = 0
		Me.labelTitulo.Text = "PROVEEDORES"
		' 
		' buttonAgregar
		' 
		Me.buttonAgregar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonAgregar.BackColor = System.Drawing.SystemColors.Window
		Me.buttonAgregar.Font = New System.Drawing.Font("Candara", 9.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.buttonAgregar.Image = Global.CapaPresentacion.Properties.Resources.agregar
		Me.buttonAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.buttonAgregar.Location = New System.Drawing.Point(775, 8)
		Me.buttonAgregar.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
		Me.buttonAgregar.Name = "buttonAgregar"
		Me.buttonAgregar.Size = New System.Drawing.Size(64, 78)
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
		Me.buttonEliminar.Location = New System.Drawing.Point(705, 8)
		Me.buttonEliminar.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
		Me.buttonEliminar.Name = "buttonEliminar"
		Me.buttonEliminar.Size = New System.Drawing.Size(64, 78)
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
		Me.buttonEditar.Location = New System.Drawing.Point(635, 8)
		Me.buttonEditar.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
		Me.buttonEditar.Name = "buttonEditar"
		Me.buttonEditar.Size = New System.Drawing.Size(64, 78)
		Me.buttonEditar.TabIndex = 3
		Me.buttonEditar.Text = "Editar"
		Me.buttonEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.buttonEditar.UseVisualStyleBackColor = False
		AddHandler Me.buttonEditar.Click, New System.EventHandler(AddressOf Me.buttonEditar_Click)
		' 
		' groupBoxBuscar
		' 
		Me.groupBoxBuscar.Controls.Add(Me.tableLayoutPanelBuscar)
		Me.groupBoxBuscar.Dock = System.Windows.Forms.DockStyle.Fill
		Me.groupBoxBuscar.Font = New System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold)
		Me.groupBoxBuscar.Location = New System.Drawing.Point(420, 1)
		Me.groupBoxBuscar.Margin = New System.Windows.Forms.Padding(3, 1, 3, 4)
		Me.groupBoxBuscar.Name = "groupBoxBuscar"
		Me.groupBoxBuscar.Size = New System.Drawing.Size(209, 84)
		Me.groupBoxBuscar.TabIndex = 4
		Me.groupBoxBuscar.TabStop = False
		Me.groupBoxBuscar.Text = "Buscar Proveedor"
		' 
		' tableLayoutPanelBuscar
		' 
		Me.tableLayoutPanelBuscar.BackColor = System.Drawing.Color.Transparent
		Me.tableLayoutPanelBuscar.ColumnCount = 2
		Me.tableLayoutPanelBuscar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.30612F))
		Me.tableLayoutPanelBuscar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.69388F))
		Me.tableLayoutPanelBuscar.Controls.Add(Me.labelNombre, 0, 0)
		Me.tableLayoutPanelBuscar.Controls.Add(Me.buttonRefrescar, 1, 1)
		Me.tableLayoutPanelBuscar.Controls.Add(Me.textBoxBuscarNombre, 1, 0)
		Me.tableLayoutPanelBuscar.Location = New System.Drawing.Point(0, 21)
		Me.tableLayoutPanelBuscar.Name = "tableLayoutPanelBuscar"
		Me.tableLayoutPanelBuscar.RowCount = 2
		Me.tableLayoutPanelBuscar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanelBuscar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanelBuscar.Size = New System.Drawing.Size(209, 54)
		Me.tableLayoutPanelBuscar.TabIndex = 0
		' 
		' labelNombre
		' 
		Me.labelNombre.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.labelNombre.AutoSize = True
		Me.labelNombre.Location = New System.Drawing.Point(9, 5)
		Me.labelNombre.Margin = New System.Windows.Forms.Padding(0)
		Me.labelNombre.Name = "labelNombre"
		Me.labelNombre.Size = New System.Drawing.Size(75, 17)
		Me.labelNombre.TabIndex = 0
		Me.labelNombre.Text = "Proveedor:"
		' 
		' buttonRefrescar
		' 
		Me.buttonRefrescar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonRefrescar.BackColor = System.Drawing.Color.LightSkyBlue
		Me.buttonRefrescar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.buttonRefrescar.Location = New System.Drawing.Point(86, 27)
		Me.buttonRefrescar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.buttonRefrescar.Name = "buttonRefrescar"
		Me.buttonRefrescar.Size = New System.Drawing.Size(121, 27)
		Me.buttonRefrescar.TabIndex = 3
		Me.buttonRefrescar.Text = "Refrescar"
		Me.buttonRefrescar.UseVisualStyleBackColor = False
		AddHandler Me.buttonRefrescar.Click, New System.EventHandler(AddressOf Me.buttonRefrescar_Click)
		' 
		' textBoxBuscarNombre
		' 
		Me.textBoxBuscarNombre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxBuscarNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxBuscarNombre.Location = New System.Drawing.Point(87, 3)
		Me.textBoxBuscarNombre.Name = "textBoxBuscarNombre"
		Me.textBoxBuscarNombre.Size = New System.Drawing.Size(119, 22)
		Me.textBoxBuscarNombre.TabIndex = 1
		AddHandler Me.textBoxBuscarNombre.TextChanged, New System.EventHandler(AddressOf Me.textBoxBuscarNombre_TextChanged)
		' 
		' dataGridViewClientes
		' 
		Me.dataGridViewClientes.AllowUserToAddRows = False
		Me.dataGridViewClientes.AllowUserToDeleteRows = False
		Me.dataGridViewClientes.AllowUserToOrderColumns = True
		Me.dataGridViewClientes.AllowUserToResizeRows = False
		dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue
		dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop
		dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue
		dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control
		Me.dataGridViewClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1
		Me.dataGridViewClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
		Me.dataGridViewClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
		Me.dataGridViewClientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
		Me.dataGridViewClientes.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dataGridViewClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
		Me.dataGridViewClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonShadow
		dataGridViewCellStyle2.Font = New System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold)
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dataGridViewClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
		Me.dataGridViewClientes.ColumnHeadersHeight = 50
		Me.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
		dataGridViewCellStyle3.Font = New System.Drawing.Font("Candara", 15F)
		dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Desktop
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dataGridViewClientes.DefaultCellStyle = dataGridViewCellStyle3
		Me.dataGridViewClientes.Dock = System.Windows.Forms.DockStyle.Fill
		Me.dataGridViewClientes.EnableHeadersVisualStyles = False
		Me.dataGridViewClientes.Location = New System.Drawing.Point(13, 98)
		Me.dataGridViewClientes.Margin = New System.Windows.Forms.Padding(13, 3, 7, 3)
		Me.dataGridViewClientes.MultiSelect = False
		Me.dataGridViewClientes.Name = "dataGridViewClientes"
		Me.dataGridViewClientes.[ReadOnly] = True
		Me.dataGridViewClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
		dataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dataGridViewClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
		Me.dataGridViewClientes.RowHeadersVisible = False
		Me.dataGridViewClientes.RowTemplate.[ReadOnly] = True
		Me.dataGridViewClientes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dataGridViewClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dataGridViewClientes.ShowCellErrors = False
		Me.dataGridViewClientes.ShowCellToolTips = False
		Me.dataGridViewClientes.ShowEditingIcon = False
		Me.dataGridViewClientes.ShowRowErrors = False
		Me.dataGridViewClientes.Size = New System.Drawing.Size(828, 208)
		Me.dataGridViewClientes.TabIndex = 2
		' 
		' tableLayoutPanelBottom
		' 
		Me.tableLayoutPanelBottom.ColumnCount = 2
		Me.tableLayoutPanelBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.52239F))
		Me.tableLayoutPanelBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.47761F))
		Me.tableLayoutPanelBottom.Controls.Add(Me.tableLayoutPanelPaginacion, 1, 0)
		Me.tableLayoutPanelBottom.Controls.Add(Me.labelMensajes, 0, 0)
		Me.tableLayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tableLayoutPanelBottom.Location = New System.Drawing.Point(3, 312)
		Me.tableLayoutPanelBottom.Name = "tableLayoutPanelBottom"
		Me.tableLayoutPanelBottom.RowCount = 1
		Me.tableLayoutPanelBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanelBottom.Size = New System.Drawing.Size(842, 38)
		Me.tableLayoutPanelBottom.TabIndex = 3
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
		Me.tableLayoutPanelPaginacion.ForeColor = System.Drawing.SystemColors.Desktop
		Me.tableLayoutPanelPaginacion.Location = New System.Drawing.Point(470, 3)
		Me.tableLayoutPanelPaginacion.Name = "tableLayoutPanelPaginacion"
		Me.tableLayoutPanelPaginacion.RowCount = 1
		Me.tableLayoutPanelPaginacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
		Me.tableLayoutPanelPaginacion.Size = New System.Drawing.Size(369, 32)
		Me.tableLayoutPanelPaginacion.TabIndex = 2
		' 
		' buttonSiguiente
		' 
		Me.buttonSiguiente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonSiguiente.BackColor = System.Drawing.Color.LightSkyBlue
		Me.buttonSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.buttonSiguiente.Location = New System.Drawing.Point(272, 0)
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
		Me.buttonAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.buttonAnterior.Location = New System.Drawing.Point(167, 0)
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
		Me.labelPagina.Location = New System.Drawing.Point(64, 6)
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
		Me.labelMensajes.ForeColor = System.Drawing.SystemColors.Desktop
		Me.labelMensajes.Location = New System.Drawing.Point(3, 9)
		Me.labelMensajes.Name = "labelMensajes"
		Me.labelMensajes.Size = New System.Drawing.Size(453, 19)
		Me.labelMensajes.TabIndex = 3
		Me.labelMensajes.Text = "Bienvenido al Sistema de Compras. Este será su Área de Mensajes"
		Me.labelMensajes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		' 
		' Proveedores
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.tableLayoutPanelGeneral)
		Me.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
		Me.Name = "Proveedores"
		Me.Size = New System.Drawing.Size(848, 353)
		Me.tableLayoutPanelGeneral.ResumeLayout(False)
		Me.tableLayoutPanelTop.ResumeLayout(False)
		Me.tableLayoutPanelTop.PerformLayout()
		Me.groupBoxBuscar.ResumeLayout(False)
		Me.tableLayoutPanelBuscar.ResumeLayout(False)
		Me.tableLayoutPanelBuscar.PerformLayout()
		DirectCast(Me.dataGridViewClientes, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tableLayoutPanelBottom.ResumeLayout(False)
		Me.tableLayoutPanelBottom.PerformLayout()
		Me.tableLayoutPanelPaginacion.ResumeLayout(False)
		Me.tableLayoutPanelPaginacion.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private tableLayoutPanelGeneral As System.Windows.Forms.TableLayoutPanel
	Private tableLayoutPanelTop As System.Windows.Forms.TableLayoutPanel
	Private labelTitulo As System.Windows.Forms.Label
	Private buttonAgregar As System.Windows.Forms.Button
	Private buttonEliminar As System.Windows.Forms.Button
	Private buttonEditar As System.Windows.Forms.Button
	Private groupBoxBuscar As System.Windows.Forms.GroupBox
	Private tableLayoutPanelBuscar As System.Windows.Forms.TableLayoutPanel
	Private labelNombre As System.Windows.Forms.Label
	Private textBoxBuscarNombre As System.Windows.Forms.TextBox
	Private dataGridViewClientes As System.Windows.Forms.DataGridView
	Private tableLayoutPanelBottom As System.Windows.Forms.TableLayoutPanel
	Private tableLayoutPanelPaginacion As System.Windows.Forms.TableLayoutPanel
	Private buttonSiguiente As System.Windows.Forms.Button
	Private buttonAnterior As System.Windows.Forms.Button
	Private labelPagina As System.Windows.Forms.Label
	Private labelMensajes As System.Windows.Forms.Label
	Private buttonRefrescar As System.Windows.Forms.Button
End Class
