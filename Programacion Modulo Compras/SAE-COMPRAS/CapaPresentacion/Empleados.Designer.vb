Partial Class Empleados
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
		Me.labelApellido = New System.Windows.Forms.Label()
		Me.textBoxBuscarApellido = New System.Windows.Forms.TextBox()
		Me.buttonRefrescar = New System.Windows.Forms.Button()
		Me.dataGridViewEmpleados = New System.Windows.Forms.DataGridView()
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
		DirectCast(Me.dataGridViewEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.tableLayoutPanelBottom.SuspendLayout()
		Me.tableLayoutPanelPaginacion.SuspendLayout()
		Me.SuspendLayout()
		' 
		' tableLayoutPanelGeneral
		' 
		Me.tableLayoutPanelGeneral.ColumnCount = 1
		Me.tableLayoutPanelGeneral.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
		Me.tableLayoutPanelGeneral.Controls.Add(Me.tableLayoutPanelTop, 0, 0)
		Me.tableLayoutPanelGeneral.Controls.Add(Me.dataGridViewEmpleados, 0, 1)
		Me.tableLayoutPanelGeneral.Controls.Add(Me.tableLayoutPanelBottom, 0, 2)
		Me.tableLayoutPanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tableLayoutPanelGeneral.Location = New System.Drawing.Point(0, 0)
		Me.tableLayoutPanelGeneral.Name = "tableLayoutPanelGeneral"
		Me.tableLayoutPanelGeneral.RowCount = 3
		Me.tableLayoutPanelGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F))
		Me.tableLayoutPanelGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
		Me.tableLayoutPanelGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F))
		Me.tableLayoutPanelGeneral.Size = New System.Drawing.Size(828, 353)
		Me.tableLayoutPanelGeneral.TabIndex = 0
		' 
		' tableLayoutPanelTop
		' 
		Me.tableLayoutPanelTop.ColumnCount = 6
		Me.tableLayoutPanelTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 402F))
		Me.tableLayoutPanelTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
		Me.tableLayoutPanelTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 202F))
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
		Me.tableLayoutPanelTop.Size = New System.Drawing.Size(822, 89)
		Me.tableLayoutPanelTop.TabIndex = 0
		' 
		' labelTitulo
		' 
		Me.labelTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelTitulo.AutoSize = True
		Me.labelTitulo.BackColor = System.Drawing.SystemColors.Control
		Me.labelTitulo.Font = New System.Drawing.Font("Candara", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelTitulo.ForeColor = System.Drawing.SystemColors.Desktop
		Me.labelTitulo.Location = New System.Drawing.Point(0, 8)
		Me.labelTitulo.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
		Me.labelTitulo.Name = "labelTitulo"
		Me.labelTitulo.Size = New System.Drawing.Size(361, 73)
		Me.labelTitulo.TabIndex = 0
		Me.labelTitulo.Text = "EMPLEADOS"
		' 
		' buttonAgregar
		' 
		Me.buttonAgregar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonAgregar.BackColor = System.Drawing.SystemColors.Window
		Me.buttonAgregar.Font = New System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.buttonAgregar.Image = Global.CapaPresentacion.Properties.Resources.agregar
		Me.buttonAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.buttonAgregar.Location = New System.Drawing.Point(755, 8)
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
		Me.buttonEliminar.Font = New System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.buttonEliminar.Image = Global.CapaPresentacion.Properties.Resources.eliminar
		Me.buttonEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.buttonEliminar.Location = New System.Drawing.Point(685, 8)
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
		Me.buttonEditar.Font = New System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.buttonEditar.Image = Global.CapaPresentacion.Properties.Resources.editar
		Me.buttonEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.buttonEditar.Location = New System.Drawing.Point(615, 8)
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
		Me.groupBoxBuscar.Font = New System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.groupBoxBuscar.Location = New System.Drawing.Point(413, 1)
		Me.groupBoxBuscar.Margin = New System.Windows.Forms.Padding(3, 1, 3, 4)
		Me.groupBoxBuscar.Name = "groupBoxBuscar"
		Me.groupBoxBuscar.Size = New System.Drawing.Size(196, 84)
		Me.groupBoxBuscar.TabIndex = 4
		Me.groupBoxBuscar.TabStop = False
		Me.groupBoxBuscar.Text = "Buscar Empleado"
		' 
		' tableLayoutPanelBuscar
		' 
		Me.tableLayoutPanelBuscar.BackColor = System.Drawing.Color.Transparent
		Me.tableLayoutPanelBuscar.ColumnCount = 2
		Me.tableLayoutPanelBuscar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.7551F))
		Me.tableLayoutPanelBuscar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.2449F))
		Me.tableLayoutPanelBuscar.Controls.Add(Me.labelApellido, 0, 0)
		Me.tableLayoutPanelBuscar.Controls.Add(Me.textBoxBuscarApellido, 1, 0)
		Me.tableLayoutPanelBuscar.Controls.Add(Me.buttonRefrescar, 1, 1)
		Me.tableLayoutPanelBuscar.Location = New System.Drawing.Point(0, 21)
		Me.tableLayoutPanelBuscar.Name = "tableLayoutPanelBuscar"
		Me.tableLayoutPanelBuscar.RowCount = 2
		Me.tableLayoutPanelBuscar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanelBuscar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanelBuscar.Size = New System.Drawing.Size(196, 54)
		Me.tableLayoutPanelBuscar.TabIndex = 0
		' 
		' labelApellido
		' 
		Me.labelApellido.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.labelApellido.AutoSize = True
		Me.labelApellido.Location = New System.Drawing.Point(7, 5)
		Me.labelApellido.Name = "labelApellido"
		Me.labelApellido.Size = New System.Drawing.Size(63, 17)
		Me.labelApellido.TabIndex = 0
		Me.labelApellido.Text = "Apellido:"
		' 
		' textBoxBuscarApellido
		' 
		Me.textBoxBuscarApellido.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxBuscarApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxBuscarApellido.Location = New System.Drawing.Point(76, 3)
		Me.textBoxBuscarApellido.Name = "textBoxBuscarApellido"
		Me.textBoxBuscarApellido.Size = New System.Drawing.Size(117, 22)
		Me.textBoxBuscarApellido.TabIndex = 1
		AddHandler Me.textBoxBuscarApellido.TextChanged, New System.EventHandler(AddressOf Me.textBoxBuscarApellido_TextChanged)
		' 
		' buttonRefrescar
		' 
		Me.buttonRefrescar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonRefrescar.BackColor = System.Drawing.Color.LightSkyBlue
		Me.buttonRefrescar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.buttonRefrescar.Location = New System.Drawing.Point(75, 27)
		Me.buttonRefrescar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.buttonRefrescar.Name = "buttonRefrescar"
		Me.buttonRefrescar.Size = New System.Drawing.Size(119, 27)
		Me.buttonRefrescar.TabIndex = 3
		Me.buttonRefrescar.Text = "Refrescar"
		Me.buttonRefrescar.UseVisualStyleBackColor = False
		AddHandler Me.buttonRefrescar.Click, New System.EventHandler(AddressOf Me.buttonRefrescar_Click)
		' 
		' dataGridViewEmpleados
		' 
		Me.dataGridViewEmpleados.AllowUserToAddRows = False
		Me.dataGridViewEmpleados.AllowUserToDeleteRows = False
		Me.dataGridViewEmpleados.AllowUserToOrderColumns = True
		Me.dataGridViewEmpleados.AllowUserToResizeRows = False
		dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue
		dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop
		dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue
		dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control
		Me.dataGridViewEmpleados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1
		Me.dataGridViewEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
		Me.dataGridViewEmpleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
		Me.dataGridViewEmpleados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
		Me.dataGridViewEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dataGridViewEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
		Me.dataGridViewEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonShadow
		dataGridViewCellStyle2.Font = New System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dataGridViewEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
		Me.dataGridViewEmpleados.ColumnHeadersHeight = 50
		Me.dataGridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
		dataGridViewCellStyle3.Font = New System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Desktop
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dataGridViewEmpleados.DefaultCellStyle = dataGridViewCellStyle3
		Me.dataGridViewEmpleados.Dock = System.Windows.Forms.DockStyle.Fill
		Me.dataGridViewEmpleados.EnableHeadersVisualStyles = False
		Me.dataGridViewEmpleados.Location = New System.Drawing.Point(13, 98)
		Me.dataGridViewEmpleados.Margin = New System.Windows.Forms.Padding(13, 3, 7, 3)
		Me.dataGridViewEmpleados.MultiSelect = False
		Me.dataGridViewEmpleados.Name = "dataGridViewEmpleados"
		Me.dataGridViewEmpleados.[ReadOnly] = True
		Me.dataGridViewEmpleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
		dataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dataGridViewEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
		Me.dataGridViewEmpleados.RowHeadersVisible = False
		Me.dataGridViewEmpleados.RowTemplate.[ReadOnly] = True
		Me.dataGridViewEmpleados.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dataGridViewEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dataGridViewEmpleados.ShowCellErrors = False
		Me.dataGridViewEmpleados.ShowCellToolTips = False
		Me.dataGridViewEmpleados.ShowEditingIcon = False
		Me.dataGridViewEmpleados.ShowRowErrors = False
		Me.dataGridViewEmpleados.Size = New System.Drawing.Size(808, 208)
		Me.dataGridViewEmpleados.TabIndex = 2
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
		Me.tableLayoutPanelBottom.Size = New System.Drawing.Size(822, 38)
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
		Me.tableLayoutPanelPaginacion.Location = New System.Drawing.Point(459, 3)
		Me.tableLayoutPanelPaginacion.Name = "tableLayoutPanelPaginacion"
		Me.tableLayoutPanelPaginacion.RowCount = 1
		Me.tableLayoutPanelPaginacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
		Me.tableLayoutPanelPaginacion.Size = New System.Drawing.Size(360, 32)
		Me.tableLayoutPanelPaginacion.TabIndex = 2
		' 
		' buttonSiguiente
		' 
		Me.buttonSiguiente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonSiguiente.BackColor = System.Drawing.Color.LightSkyBlue
		Me.buttonSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.buttonSiguiente.Location = New System.Drawing.Point(263, 0)
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
		Me.buttonAnterior.Location = New System.Drawing.Point(158, 0)
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
		Me.labelPagina.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelPagina.Location = New System.Drawing.Point(57, 8)
		Me.labelPagina.Name = "labelPagina"
		Me.labelPagina.Size = New System.Drawing.Size(98, 15)
		Me.labelPagina.TabIndex = 2
		Me.labelPagina.Text = "Página X de X"
		' 
		' labelMensajes
		' 
		Me.labelMensajes.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelMensajes.AutoSize = True
		Me.labelMensajes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelMensajes.Location = New System.Drawing.Point(3, 11)
		Me.labelMensajes.Name = "labelMensajes"
		Me.labelMensajes.Size = New System.Drawing.Size(437, 15)
		Me.labelMensajes.TabIndex = 3
		Me.labelMensajes.Text = "Bienvenido al Sistema de Compras. Este será su Área de Mensajes"
		Me.labelMensajes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		' 
		' Empleados
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.tableLayoutPanelGeneral)
		Me.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
		Me.Name = "Empleados"
		Me.Size = New System.Drawing.Size(828, 353)
		Me.tableLayoutPanelGeneral.ResumeLayout(False)
		Me.tableLayoutPanelTop.ResumeLayout(False)
		Me.tableLayoutPanelTop.PerformLayout()
		Me.groupBoxBuscar.ResumeLayout(False)
		Me.tableLayoutPanelBuscar.ResumeLayout(False)
		Me.tableLayoutPanelBuscar.PerformLayout()
		DirectCast(Me.dataGridViewEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
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
	Private labelApellido As System.Windows.Forms.Label
	Private textBoxBuscarApellido As System.Windows.Forms.TextBox
	Private dataGridViewEmpleados As System.Windows.Forms.DataGridView
	Private tableLayoutPanelBottom As System.Windows.Forms.TableLayoutPanel
	Private tableLayoutPanelPaginacion As System.Windows.Forms.TableLayoutPanel
	Private buttonSiguiente As System.Windows.Forms.Button
	Private buttonAnterior As System.Windows.Forms.Button
	Private labelPagina As System.Windows.Forms.Label
	Private labelMensajes As System.Windows.Forms.Label
	Private buttonRefrescar As System.Windows.Forms.Button
End Class
