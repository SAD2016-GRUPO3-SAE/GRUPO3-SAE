namespace CapaPresentacion
{
    partial class Reporte3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte3));
            this.dBSAEFINALDataSet = new CapaPresentacion.DBSAEFINALDataSet();
            this.top10ProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.top10ProductosTableAdapter = new CapaPresentacion.DBSAEFINALDataSetTableAdapters.Top10ProductosTableAdapter();
            this.tableAdapterManager = new CapaPresentacion.DBSAEFINALDataSetTableAdapters.TableAdapterManager();
            this.top10ProductosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.top10ProductosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.fechaInicialToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.fechaInicialToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fechaFinalToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.fechaFinalToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.top10ProductosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dBSAEFINALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top10ProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top10ProductosBindingNavigator)).BeginInit();
            this.top10ProductosBindingNavigator.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.top10ProductosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dBSAEFINALDataSet
            // 
            this.dBSAEFINALDataSet.DataSetName = "DBSAEFINALDataSet";
            this.dBSAEFINALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // top10ProductosBindingSource
            // 
            this.top10ProductosBindingSource.DataMember = "Top10Productos";
            this.top10ProductosBindingSource.DataSource = this.dBSAEFINALDataSet;
            // 
            // top10ProductosTableAdapter
            // 
            this.top10ProductosTableAdapter.ClearBeforeFill = true;
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
            // top10ProductosBindingNavigator
            // 
            this.top10ProductosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.top10ProductosBindingNavigator.BindingSource = this.top10ProductosBindingSource;
            this.top10ProductosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.top10ProductosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.top10ProductosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.top10ProductosBindingNavigatorSaveItem});
            this.top10ProductosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.top10ProductosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.top10ProductosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.top10ProductosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.top10ProductosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.top10ProductosBindingNavigator.Name = "top10ProductosBindingNavigator";
            this.top10ProductosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.top10ProductosBindingNavigator.Size = new System.Drawing.Size(553, 25);
            this.top10ProductosBindingNavigator.TabIndex = 0;
            this.top10ProductosBindingNavigator.Text = "bindingNavigator1";
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
            // top10ProductosBindingNavigatorSaveItem
            // 
            this.top10ProductosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.top10ProductosBindingNavigatorSaveItem.Enabled = false;
            this.top10ProductosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("top10ProductosBindingNavigatorSaveItem.Image")));
            this.top10ProductosBindingNavigatorSaveItem.Name = "top10ProductosBindingNavigatorSaveItem";
            this.top10ProductosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
            this.top10ProductosBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fechaInicialToolStripLabel,
            this.fechaInicialToolStripTextBox,
            this.fechaFinalToolStripLabel,
            this.fechaFinalToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(553, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // fechaInicialToolStripLabel
            // 
            this.fechaInicialToolStripLabel.Name = "fechaInicialToolStripLabel";
            this.fechaInicialToolStripLabel.Size = new System.Drawing.Size(72, 22);
            this.fechaInicialToolStripLabel.Text = "FechaInicial:";
            // 
            // fechaInicialToolStripTextBox
            // 
            this.fechaInicialToolStripTextBox.Name = "fechaInicialToolStripTextBox";
            this.fechaInicialToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // fechaFinalToolStripLabel
            // 
            this.fechaFinalToolStripLabel.Name = "fechaFinalToolStripLabel";
            this.fechaFinalToolStripLabel.Size = new System.Drawing.Size(66, 15);
            this.fechaFinalToolStripLabel.Text = "FechaFinal:";
            // 
            // fechaFinalToolStripTextBox
            // 
            this.fechaFinalToolStripTextBox.Name = "fechaFinalToolStripTextBox";
            this.fechaFinalToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 19);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // top10ProductosDataGridView
            // 
            this.top10ProductosDataGridView.AutoGenerateColumns = false;
            this.top10ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.top10ProductosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.top10ProductosDataGridView.DataSource = this.top10ProductosBindingSource;
            this.top10ProductosDataGridView.Location = new System.Drawing.Point(33, 80);
            this.top10ProductosDataGridView.Name = "top10ProductosDataGridView";
            this.top10ProductosDataGridView.Size = new System.Drawing.Size(408, 141);
            this.top10ProductosDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PRODUCTO";
            this.dataGridViewTextBoxColumn1.HeaderText = "PRODUCTO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CANTIDAD";
            this.dataGridViewTextBoxColumn2.HeaderText = "CANTIDAD";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Reporte3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 367);
            this.Controls.Add(this.top10ProductosDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.top10ProductosBindingNavigator);
            this.Name = "Reporte3";
            this.Text = "Reporte3";
            ((System.ComponentModel.ISupportInitialize)(this.dBSAEFINALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top10ProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top10ProductosBindingNavigator)).EndInit();
            this.top10ProductosBindingNavigator.ResumeLayout(false);
            this.top10ProductosBindingNavigator.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.top10ProductosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBSAEFINALDataSet dBSAEFINALDataSet;
        private System.Windows.Forms.BindingSource top10ProductosBindingSource;
        private DBSAEFINALDataSetTableAdapters.Top10ProductosTableAdapter top10ProductosTableAdapter;
        private DBSAEFINALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator top10ProductosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton top10ProductosBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel fechaInicialToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox fechaInicialToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel fechaFinalToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox fechaFinalToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView top10ProductosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}