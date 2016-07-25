namespace CapaPresentacion
{
    partial class Reporte2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte2));
            this.dBSAEFINALDataSet = new CapaPresentacion.DBSAEFINALDataSet();
            this.mostrarProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mostrarProveedorTableAdapter = new CapaPresentacion.DBSAEFINALDataSetTableAdapters.MostrarProveedorTableAdapter();
            this.tableAdapterManager = new CapaPresentacion.DBSAEFINALDataSetTableAdapters.TableAdapterManager();
            this.mostrarProveedorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mostrarProveedorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.numeroPaginaToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.numeroPaginaToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.registrosPorPaginaToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.registrosPorPaginaToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mostrarProveedorDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dBSAEFINALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarProveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarProveedorBindingNavigator)).BeginInit();
            this.mostrarProveedorBindingNavigator.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarProveedorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dBSAEFINALDataSet
            // 
            this.dBSAEFINALDataSet.DataSetName = "DBSAEFINALDataSet";
            this.dBSAEFINALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mostrarProveedorBindingSource
            // 
            this.mostrarProveedorBindingSource.DataMember = "MostrarProveedor";
            this.mostrarProveedorBindingSource.DataSource = this.dBSAEFINALDataSet;
            // 
            // mostrarProveedorTableAdapter
            // 
            this.mostrarProveedorTableAdapter.ClearBeforeFill = true;
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
            // mostrarProveedorBindingNavigator
            // 
            this.mostrarProveedorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mostrarProveedorBindingNavigator.BindingSource = this.mostrarProveedorBindingSource;
            this.mostrarProveedorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mostrarProveedorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mostrarProveedorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.mostrarProveedorBindingNavigatorSaveItem});
            this.mostrarProveedorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mostrarProveedorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mostrarProveedorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mostrarProveedorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mostrarProveedorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mostrarProveedorBindingNavigator.Name = "mostrarProveedorBindingNavigator";
            this.mostrarProveedorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mostrarProveedorBindingNavigator.Size = new System.Drawing.Size(796, 25);
            this.mostrarProveedorBindingNavigator.TabIndex = 0;
            this.mostrarProveedorBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // mostrarProveedorBindingNavigatorSaveItem
            // 
            this.mostrarProveedorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mostrarProveedorBindingNavigatorSaveItem.Enabled = false;
            this.mostrarProveedorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mostrarProveedorBindingNavigatorSaveItem.Image")));
            this.mostrarProveedorBindingNavigatorSaveItem.Name = "mostrarProveedorBindingNavigatorSaveItem";
            this.mostrarProveedorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.mostrarProveedorBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numeroPaginaToolStripLabel,
            this.numeroPaginaToolStripTextBox,
            this.registrosPorPaginaToolStripLabel,
            this.registrosPorPaginaToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(796, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // numeroPaginaToolStripLabel
            // 
            this.numeroPaginaToolStripLabel.Name = "numeroPaginaToolStripLabel";
            this.numeroPaginaToolStripLabel.Size = new System.Drawing.Size(90, 22);
            this.numeroPaginaToolStripLabel.Text = "NumeroPagina:";
            // 
            // numeroPaginaToolStripTextBox
            // 
            this.numeroPaginaToolStripTextBox.Name = "numeroPaginaToolStripTextBox";
            this.numeroPaginaToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // registrosPorPaginaToolStripLabel
            // 
            this.registrosPorPaginaToolStripLabel.Name = "registrosPorPaginaToolStripLabel";
            this.registrosPorPaginaToolStripLabel.Size = new System.Drawing.Size(112, 22);
            this.registrosPorPaginaToolStripLabel.Text = "RegistrosPorPagina:";
            // 
            // registrosPorPaginaToolStripTextBox
            // 
            this.registrosPorPaginaToolStripTextBox.Name = "registrosPorPaginaToolStripTextBox";
            this.registrosPorPaginaToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // mostrarProveedorDataGridView
            // 
            this.mostrarProveedorDataGridView.AutoGenerateColumns = false;
            this.mostrarProveedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mostrarProveedorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.mostrarProveedorDataGridView.DataSource = this.mostrarProveedorBindingSource;
            this.mostrarProveedorDataGridView.Location = new System.Drawing.Point(23, 148);
            this.mostrarProveedorDataGridView.Name = "mostrarProveedorDataGridView";
            this.mostrarProveedorDataGridView.Size = new System.Drawing.Size(761, 220);
            this.mostrarProveedorDataGridView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Listado de Socios Proveedor";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "proveedor";
            this.dataGridViewTextBoxColumn3.HeaderText = "proveedor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DIRECCIÓN";
            this.dataGridViewTextBoxColumn4.HeaderText = "DIRECCIÓN";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NIT";
            this.dataGridViewTextBoxColumn5.HeaderText = "NIT";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TELÉFONO";
            this.dataGridViewTextBoxColumn6.HeaderText = "TELÉFONO";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "EMAIL";
            this.dataGridViewTextBoxColumn7.HeaderText = "EMAIL";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Reporte2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 380);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mostrarProveedorDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.mostrarProveedorBindingNavigator);
            this.Name = "Reporte2";
            this.Text = "Reporte2";
            ((System.ComponentModel.ISupportInitialize)(this.dBSAEFINALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarProveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarProveedorBindingNavigator)).EndInit();
            this.mostrarProveedorBindingNavigator.ResumeLayout(false);
            this.mostrarProveedorBindingNavigator.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarProveedorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBSAEFINALDataSet dBSAEFINALDataSet;
        private System.Windows.Forms.BindingSource mostrarProveedorBindingSource;
        private DBSAEFINALDataSetTableAdapters.MostrarProveedorTableAdapter mostrarProveedorTableAdapter;
        private DBSAEFINALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mostrarProveedorBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton mostrarProveedorBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel numeroPaginaToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox numeroPaginaToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel registrosPorPaginaToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox registrosPorPaginaToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView mostrarProveedorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label1;
    }
}