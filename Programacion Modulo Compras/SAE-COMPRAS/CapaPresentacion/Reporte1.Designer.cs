namespace CapaPresentacion
{
    partial class Reporte1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte1));
            this.dBSAEFINALDataSet = new CapaPresentacion.DBSAEFINALDataSet();
            this.v_Productos_NombreCategoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_Productos_NombreCategoriasTableAdapter = new CapaPresentacion.DBSAEFINALDataSetTableAdapters.v_Productos_NombreCategoriasTableAdapter();
            this.tableAdapterManager = new CapaPresentacion.DBSAEFINALDataSetTableAdapters.TableAdapterManager();
            this.v_Productos_NombreCategoriasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.v_Productos_NombreCategoriasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.v_Productos_NombreCategoriasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dBSAEFINALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_Productos_NombreCategoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_Productos_NombreCategoriasBindingNavigator)).BeginInit();
            this.v_Productos_NombreCategoriasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_Productos_NombreCategoriasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dBSAEFINALDataSet
            // 
            this.dBSAEFINALDataSet.DataSetName = "DBSAEFINALDataSet";
            this.dBSAEFINALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_Productos_NombreCategoriasBindingSource
            // 
            this.v_Productos_NombreCategoriasBindingSource.DataMember = "v_Productos_NombreCategorias";
            this.v_Productos_NombreCategoriasBindingSource.DataSource = this.dBSAEFINALDataSet;
            // 
            // v_Productos_NombreCategoriasTableAdapter
            // 
            this.v_Productos_NombreCategoriasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriasTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.FechasLookupTableAdapter = null;
            this.tableAdapterManager.OrdenDetallesTableAdapter = null;
            this.tableAdapterManager.OrdenesTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.ProveedorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CapaPresentacion.DBSAEFINALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // v_Productos_NombreCategoriasBindingNavigator
            // 
            this.v_Productos_NombreCategoriasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.v_Productos_NombreCategoriasBindingNavigator.BindingSource = this.v_Productos_NombreCategoriasBindingSource;
            this.v_Productos_NombreCategoriasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.v_Productos_NombreCategoriasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.v_Productos_NombreCategoriasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.v_Productos_NombreCategoriasBindingNavigatorSaveItem});
            this.v_Productos_NombreCategoriasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.v_Productos_NombreCategoriasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.v_Productos_NombreCategoriasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.v_Productos_NombreCategoriasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.v_Productos_NombreCategoriasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.v_Productos_NombreCategoriasBindingNavigator.Name = "v_Productos_NombreCategoriasBindingNavigator";
            this.v_Productos_NombreCategoriasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.v_Productos_NombreCategoriasBindingNavigator.Size = new System.Drawing.Size(647, 25);
            this.v_Productos_NombreCategoriasBindingNavigator.TabIndex = 0;
            this.v_Productos_NombreCategoriasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // v_Productos_NombreCategoriasBindingNavigatorSaveItem
            // 
            this.v_Productos_NombreCategoriasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.v_Productos_NombreCategoriasBindingNavigatorSaveItem.Enabled = false;
            this.v_Productos_NombreCategoriasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("v_Productos_NombreCategoriasBindingNavigatorSaveItem.Image")));
            this.v_Productos_NombreCategoriasBindingNavigatorSaveItem.Name = "v_Productos_NombreCategoriasBindingNavigatorSaveItem";
            this.v_Productos_NombreCategoriasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
            this.v_Productos_NombreCategoriasBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // v_Productos_NombreCategoriasDataGridView
            // 
            this.v_Productos_NombreCategoriasDataGridView.AutoGenerateColumns = false;
            this.v_Productos_NombreCategoriasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.v_Productos_NombreCategoriasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.v_Productos_NombreCategoriasDataGridView.DataSource = this.v_Productos_NombreCategoriasBindingSource;
            this.v_Productos_NombreCategoriasDataGridView.Location = new System.Drawing.Point(0, 143);
            this.v_Productos_NombreCategoriasDataGridView.Name = "v_Productos_NombreCategoriasDataGridView";
            this.v_Productos_NombreCategoriasDataGridView.Size = new System.Drawing.Size(646, 220);
            this.v_Productos_NombreCategoriasDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CÓDIGO";
            this.dataGridViewTextBoxColumn2.HeaderText = "CÓDIGO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NOMBRE";
            this.dataGridViewTextBoxColumn3.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CATEGORÍA";
            this.dataGridViewTextBoxColumn4.HeaderText = "CATEGORÍA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PRECIO";
            this.dataGridViewTextBoxColumn5.HeaderText = "PRECIO";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DETALLES DEL PRODUCTO";
            this.dataGridViewTextBoxColumn6.HeaderText = "DETALLES DEL PRODUCTO";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "COMPRAS A PROVEEDOR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.contact;
            this.pictureBox1.Location = new System.Drawing.Point(17, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Reporte1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 364);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.v_Productos_NombreCategoriasDataGridView);
            this.Controls.Add(this.v_Productos_NombreCategoriasBindingNavigator);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reporte1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Compras a Proveedor";
            this.Load += new System.EventHandler(this.Reporte1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBSAEFINALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_Productos_NombreCategoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_Productos_NombreCategoriasBindingNavigator)).EndInit();
            this.v_Productos_NombreCategoriasBindingNavigator.ResumeLayout(false);
            this.v_Productos_NombreCategoriasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_Productos_NombreCategoriasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBSAEFINALDataSet dBSAEFINALDataSet;
        private System.Windows.Forms.BindingSource v_Productos_NombreCategoriasBindingSource;
        private DBSAEFINALDataSetTableAdapters.v_Productos_NombreCategoriasTableAdapter v_Productos_NombreCategoriasTableAdapter;
        private DBSAEFINALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator v_Productos_NombreCategoriasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton v_Productos_NombreCategoriasBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView v_Productos_NombreCategoriasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}