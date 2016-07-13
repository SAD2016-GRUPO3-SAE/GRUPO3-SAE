Partial Class FrmInicio
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
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(FrmInicio))
		Me.tableLayoutPanelGeneral = New System.Windows.Forms.TableLayoutPanel()
		Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.archivoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.salirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.mantenimientoComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ordenesDeCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.productoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.proveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.categoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.usuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.transporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.reportesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.RestauracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.generarCopiaDeSeguridadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.restaurarCopiasDeSeguridadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ayudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.panelContenedor = New System.Windows.Forms.Panel()
		Me.openFileDialogRestaurarCopiaSeguridad = New System.Windows.Forms.OpenFileDialog()
		Me.tableLayoutPanelGeneral.SuspendLayout()
		Me.menuStrip1.SuspendLayout()
		Me.SuspendLayout()
		' 
		' tableLayoutPanelGeneral
		' 
		Me.tableLayoutPanelGeneral.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.tableLayoutPanelGeneral.ColumnCount = 1
		Me.tableLayoutPanelGeneral.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
		Me.tableLayoutPanelGeneral.Controls.Add(Me.menuStrip1, 0, 0)
		Me.tableLayoutPanelGeneral.Controls.Add(Me.panelContenedor, 0, 2)
		Me.tableLayoutPanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tableLayoutPanelGeneral.Location = New System.Drawing.Point(6, 6)
		Me.tableLayoutPanelGeneral.Name = "tableLayoutPanelGeneral"
		Me.tableLayoutPanelGeneral.RowCount = 3
		Me.tableLayoutPanelGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.tableLayoutPanelGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.tableLayoutPanelGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.tableLayoutPanelGeneral.Size = New System.Drawing.Size(1087, 534)
		Me.tableLayoutPanelGeneral.TabIndex = 0
		' 
		' menuStrip1
		' 
		Me.menuStrip1.BackColor = System.Drawing.Color.White
		Me.menuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.archivoToolStripMenuItem1, Me.mantenimientoComprasToolStripMenuItem, Me.reportesToolStripMenuItem1, Me.RestauracionToolStripMenuItem, Me.ayudaToolStripMenuItem})
		Me.menuStrip1.Location = New System.Drawing.Point(8, 0)
		Me.menuStrip1.Margin = New System.Windows.Forms.Padding(8, 0, 3, 3)
		Me.menuStrip1.Name = "menuStrip1"
		Me.menuStrip1.Padding = New System.Windows.Forms.Padding(0)
		Me.menuStrip1.Size = New System.Drawing.Size(1076, 24)
		Me.menuStrip1.TabIndex = 2
		Me.menuStrip1.Text = "menuStrip1"
		' 
		' archivoToolStripMenuItem1
		' 
		Me.archivoToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.salirToolStripMenuItem1})
		Me.archivoToolStripMenuItem1.Name = "archivoToolStripMenuItem1"
		Me.archivoToolStripMenuItem1.Size = New System.Drawing.Size(58, 24)
		Me.archivoToolStripMenuItem1.Text = "Archivo"
		' 
		' salirToolStripMenuItem1
		' 
		Me.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1"
		Me.salirToolStripMenuItem1.Size = New System.Drawing.Size(99, 22)
		Me.salirToolStripMenuItem1.Text = "Salir"
		AddHandler Me.salirToolStripMenuItem1.Click, New System.EventHandler(AddressOf Me.salirToolStripMenuItem1_Click)
		' 
		' mantenimientoComprasToolStripMenuItem
		' 
		Me.mantenimientoComprasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ordenesDeCompraToolStripMenuItem, Me.productoToolStripMenuItem, Me.proveedoresToolStripMenuItem, Me.categoriasToolStripMenuItem, Me.usuariosToolStripMenuItem, Me.transporteToolStripMenuItem})
		Me.mantenimientoComprasToolStripMenuItem.Name = "mantenimientoComprasToolStripMenuItem"
		Me.mantenimientoComprasToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
		Me.mantenimientoComprasToolStripMenuItem.Text = "Catalogo"
		' 
		' ordenesDeCompraToolStripMenuItem
		' 
		Me.ordenesDeCompraToolStripMenuItem.Image = Global.CapaPresentacion.Properties.Resources.pedidos
		Me.ordenesDeCompraToolStripMenuItem.Name = "ordenesDeCompraToolStripMenuItem"
		Me.ordenesDeCompraToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
		Me.ordenesDeCompraToolStripMenuItem.Text = "Ordenes de Compra"
		AddHandler Me.ordenesDeCompraToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.ordenesDeCompraToolStripMenuItem_Click)
		' 
		' productoToolStripMenuItem
		' 
		Me.productoToolStripMenuItem.Image = Global.CapaPresentacion.Properties.Resources.productos
		Me.productoToolStripMenuItem.Name = "productoToolStripMenuItem"
		Me.productoToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
		Me.productoToolStripMenuItem.Text = "Producto"
		AddHandler Me.productoToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.productoToolStripMenuItem_Click)
		' 
		' proveedoresToolStripMenuItem
		' 
		Me.proveedoresToolStripMenuItem.Image = Global.CapaPresentacion.Properties.Resources.clientes
		Me.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem"
		Me.proveedoresToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
		Me.proveedoresToolStripMenuItem.Text = "Proveedores"
		AddHandler Me.proveedoresToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.proveedoresToolStripMenuItem_Click)
		' 
		' categoriasToolStripMenuItem
		' 
		Me.categoriasToolStripMenuItem.Image = Global.CapaPresentacion.Properties.Resources.categorias
		Me.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem"
		Me.categoriasToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
		Me.categoriasToolStripMenuItem.Text = "Categorias"
		AddHandler Me.categoriasToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.categoriasToolStripMenuItem_Click)
		' 
		' usuariosToolStripMenuItem
		' 
		Me.usuariosToolStripMenuItem.Image = Global.CapaPresentacion.Properties.Resources.empleados
		Me.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem"
		Me.usuariosToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
		Me.usuariosToolStripMenuItem.Text = "Empleados"
		AddHandler Me.usuariosToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.usuariosToolStripMenuItem_Click)
		' 
		' transporteToolStripMenuItem
		' 
		Me.transporteToolStripMenuItem.Image = Global.CapaPresentacion.Properties.Resources.transporte
		Me.transporteToolStripMenuItem.Name = "transporteToolStripMenuItem"
		Me.transporteToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
		Me.transporteToolStripMenuItem.Text = "Transporte"
		AddHandler Me.transporteToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.transporteToolStripMenuItem_Click)
		' 
		' reportesToolStripMenuItem1
		' 
		Me.reportesToolStripMenuItem1.Name = "reportesToolStripMenuItem1"
		Me.reportesToolStripMenuItem1.Size = New System.Drawing.Size(69, 24)
		Me.reportesToolStripMenuItem1.Text = "Reportes"
		AddHandler Me.reportesToolStripMenuItem1.Click, New System.EventHandler(AddressOf Me.reportesToolStripMenuItem1_Click)
		' 
		' RestauracionToolStripMenuItem
		' 
		Me.RestauracionToolStripMenuItem.BackColor = System.Drawing.Color.White
		Me.RestauracionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.generarCopiaDeSeguridadToolStripMenuItem, Me.restaurarCopiasDeSeguridadToolStripMenuItem})
		Me.RestauracionToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.RestauracionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
		Me.RestauracionToolStripMenuItem.Name = "RestauracionToolStripMenuItem"
		Me.RestauracionToolStripMenuItem.Size = New System.Drawing.Size(92, 24)
		Me.RestauracionToolStripMenuItem.Text = "Restauración"
		' 

		' 
		' ayudaToolStripMenuItem
		' 
		Me.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem"
		Me.ayudaToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
		Me.ayudaToolStripMenuItem.Text = "Ayuda"
		' 
		' panelContenedor
		' 
		Me.panelContenedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelContenedor.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.panelContenedor.BackgroundImage = DirectCast(resources.GetObject("panelContenedor.BackgroundImage"), System.Drawing.Image)
		Me.panelContenedor.Location = New System.Drawing.Point(7, 30)
		Me.panelContenedor.Margin = New System.Windows.Forms.Padding(7, 3, 3, 3)
		Me.panelContenedor.Name = "panelContenedor"
		Me.panelContenedor.Size = New System.Drawing.Size(1077, 501)
		Me.panelContenedor.TabIndex = 1
		' 
		' openFileDialogRestaurarCopiaSeguridad
		' 
		Me.openFileDialogRestaurarCopiaSeguridad.Filter = "Archivos .bak|*.bak"
		Me.openFileDialogRestaurarCopiaSeguridad.InitialDirectory = "C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\Backup"
		Me.openFileDialogRestaurarCopiaSeguridad.Title = "Seleccione una Copia de Seguridad para Restaurar"
		' 
		' FrmInicio
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 15F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.ClientSize = New System.Drawing.Size(1099, 546)
		Me.Controls.Add(Me.tableLayoutPanelGeneral)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.IsMdiContainer = True
		Me.MainMenuStrip = Me.menuStrip1
		Me.MinimumSize = New System.Drawing.Size(1107, 573)
		Me.Name = "FrmInicio"
		Me.Padding = New System.Windows.Forms.Padding(6)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = ".:. Sistema SAE - Modulo Compras"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.tableLayoutPanelGeneral.ResumeLayout(False)
		Me.tableLayoutPanelGeneral.PerformLayout()
		Me.menuStrip1.ResumeLayout(False)
		Me.menuStrip1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private tableLayoutPanelGeneral As System.Windows.Forms.TableLayoutPanel
	Private panelContenedor As System.Windows.Forms.Panel
	Private menuStrip1 As System.Windows.Forms.MenuStrip
	Private RestauracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private generarCopiaDeSeguridadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private restaurarCopiasDeSeguridadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private openFileDialogRestaurarCopiaSeguridad As System.Windows.Forms.OpenFileDialog
	Private mantenimientoComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private ordenesDeCompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private productoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private proveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private categoriasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private usuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private archivoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private salirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private transporteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private ayudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private reportesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
