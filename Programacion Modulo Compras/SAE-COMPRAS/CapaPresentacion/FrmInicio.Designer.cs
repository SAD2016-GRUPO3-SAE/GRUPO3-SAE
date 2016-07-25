namespace CapaPresentacion
{
    partial class FrmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.tableLayoutPanelGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoSocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesDeCompraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.historialProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesPorSocioYProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesPorProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresYProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.openFileDialogRestaurarCopiaSeguridad = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanelGeneral.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelGeneral
            // 
            this.tableLayoutPanelGeneral.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tableLayoutPanelGeneral.ColumnCount = 1;
            this.tableLayoutPanelGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGeneral.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanelGeneral.Controls.Add(this.panelContenedor, 0, 2);
            this.tableLayoutPanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelGeneral.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanelGeneral.Name = "tableLayoutPanelGeneral";
            this.tableLayoutPanelGeneral.RowCount = 3;
            this.tableLayoutPanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelGeneral.Size = new System.Drawing.Size(1087, 534);
            this.tableLayoutPanelGeneral.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem1,
            this.mantenimientoComprasToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem1,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(8, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(8, 0, 3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(1076, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem1
            // 
            this.archivoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem1});
            this.archivoToolStripMenuItem1.Name = "archivoToolStripMenuItem1";
            this.archivoToolStripMenuItem1.Size = new System.Drawing.Size(58, 24);
            this.archivoToolStripMenuItem1.Text = "Archivo";
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // mantenimientoComprasToolStripMenuItem
            // 
            this.mantenimientoComprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.agregarNuevoProductoToolStripMenuItem,
            this.agregarNuevoSocioToolStripMenuItem});
            this.mantenimientoComprasToolStripMenuItem.Name = "mantenimientoComprasToolStripMenuItem";
            this.mantenimientoComprasToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.mantenimientoComprasToolStripMenuItem.Text = "Catalogo";
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.productoToolStripMenuItem.Text = "Ingresar Productos";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.proveedoresToolStripMenuItem.Text = "Ingresar  Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.categoriasToolStripMenuItem.Text = "Ingresar Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // agregarNuevoProductoToolStripMenuItem
            // 
            this.agregarNuevoProductoToolStripMenuItem.Name = "agregarNuevoProductoToolStripMenuItem";
            this.agregarNuevoProductoToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.agregarNuevoProductoToolStripMenuItem.Text = "Agregar Nuevo Producto";
            this.agregarNuevoProductoToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevoProductoToolStripMenuItem_Click);
            // 
            // agregarNuevoSocioToolStripMenuItem
            // 
            this.agregarNuevoSocioToolStripMenuItem.Name = "agregarNuevoSocioToolStripMenuItem";
            this.agregarNuevoSocioToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.agregarNuevoSocioToolStripMenuItem.Text = "Mostrar Socios Proveedores";
            this.agregarNuevoSocioToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevoSocioToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprasToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.procesosToolStripMenuItem.Text = "Procesos";
            this.procesosToolStripMenuItem.Click += new System.EventHandler(this.procesosToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenesDeCompraToolStripMenuItem1,
            this.sociosToolStripMenuItem,
            this.productosToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // ordenesDeCompraToolStripMenuItem1
            // 
            this.ordenesDeCompraToolStripMenuItem1.Name = "ordenesDeCompraToolStripMenuItem1";
            this.ordenesDeCompraToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.ordenesDeCompraToolStripMenuItem1.Text = "Ordenes de Compra";
            this.ordenesDeCompraToolStripMenuItem1.Click += new System.EventHandler(this.ordenesDeCompraToolStripMenuItem1_Click);
            // 
            // sociosToolStripMenuItem
            // 
            this.sociosToolStripMenuItem.Name = "sociosToolStripMenuItem";
            this.sociosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.sociosToolStripMenuItem.Text = "Socios";
            this.sociosToolStripMenuItem.Click += new System.EventHandler(this.sociosToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem1
            // 
            this.reportesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historialProveedoresToolStripMenuItem,
            this.reportesPorSocioYProductoToolStripMenuItem,
            this.ordenesPorProveedorToolStripMenuItem,
            this.proveedoresYProductosToolStripMenuItem});
            this.reportesToolStripMenuItem1.Name = "reportesToolStripMenuItem1";
            this.reportesToolStripMenuItem1.Size = new System.Drawing.Size(69, 24);
            this.reportesToolStripMenuItem1.Text = "Reportes";
            this.reportesToolStripMenuItem1.Click += new System.EventHandler(this.reportesToolStripMenuItem1_Click);
            // 
            // historialProveedoresToolStripMenuItem
            // 
            this.historialProveedoresToolStripMenuItem.Name = "historialProveedoresToolStripMenuItem";
            this.historialProveedoresToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.historialProveedoresToolStripMenuItem.Text = "Detalle Proveedores";
            this.historialProveedoresToolStripMenuItem.Click += new System.EventHandler(this.historialProveedoresToolStripMenuItem_Click);
            // 
            // reportesPorSocioYProductoToolStripMenuItem
            // 
            this.reportesPorSocioYProductoToolStripMenuItem.Name = "reportesPorSocioYProductoToolStripMenuItem";
            this.reportesPorSocioYProductoToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.reportesPorSocioYProductoToolStripMenuItem.Text = "Reportes Por Socio y Producto";
            this.reportesPorSocioYProductoToolStripMenuItem.Click += new System.EventHandler(this.reportesPorSocioYProductoToolStripMenuItem_Click);
            // 
            // ordenesPorProveedorToolStripMenuItem
            // 
            this.ordenesPorProveedorToolStripMenuItem.Name = "ordenesPorProveedorToolStripMenuItem";
            this.ordenesPorProveedorToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.ordenesPorProveedorToolStripMenuItem.Text = "Detalle Compras a Proveedor";
            this.ordenesPorProveedorToolStripMenuItem.Click += new System.EventHandler(this.ordenesPorProveedorToolStripMenuItem_Click);
            // 
            // proveedoresYProductosToolStripMenuItem
            // 
            this.proveedoresYProductosToolStripMenuItem.Name = "proveedoresYProductosToolStripMenuItem";
            this.proveedoresYProductosToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.proveedoresYProductosToolStripMenuItem.Text = "Proveedores y Productos";
            this.proveedoresYProductosToolStripMenuItem.Click += new System.EventHandler(this.proveedoresYProductosToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelContenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelContenedor.BackgroundImage")));
            this.panelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContenedor.Location = new System.Drawing.Point(7, 30);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1077, 501);
            this.panelContenedor.TabIndex = 1;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // openFileDialogRestaurarCopiaSeguridad
            // 
            this.openFileDialogRestaurarCopiaSeguridad.Filter = "Archivos .bak|*.bak";
            this.openFileDialogRestaurarCopiaSeguridad.InitialDirectory = "C:\\Program Files\\Microsoft SQL Server\\MSSQL12.SQLEXPRESS\\MSSQL\\Backup";
            this.openFileDialogRestaurarCopiaSeguridad.Title = "Seleccione una Copia de Seguridad para Restaurar";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1099, 546);
            this.Controls.Add(this.tableLayoutPanelGeneral);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1107, 573);
            this.Name = "FrmInicio";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAE - Sistema de Administracion Empresarial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanelGeneral.ResumeLayout(false);
            this.tableLayoutPanelGeneral.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGeneral;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialogRestaurarCopiaSeguridad;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesDeCompraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoSocioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesPorProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesPorSocioYProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresYProductosToolStripMenuItem;
    }
}