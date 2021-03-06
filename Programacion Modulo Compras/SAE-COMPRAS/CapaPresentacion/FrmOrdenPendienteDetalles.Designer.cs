﻿namespace CapaPresentacion
{
    partial class FrmOrdenPendienteDetalles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelFechaOrdenado = new System.Windows.Forms.Label();
            this.textBoxFechaOrdenado = new System.Windows.Forms.TextBox();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.labelPedido = new System.Windows.Forms.Label();
            this.labelNumeroPedido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFechaRequerido = new System.Windows.Forms.TextBox();
            this.labelFechaRequerido = new System.Windows.Forms.Label();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.toolTipAgregarProducto = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEliminarProducto = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEditarProducto = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCliente
            // 
            this.labelCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(-107, 286);
            this.labelCliente.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(66, 15);
            this.labelCliente.TabIndex = 20;
            this.labelCliente.Text = "Proveedor:";
            // 
            // labelFechaOrdenado
            // 
            this.labelFechaOrdenado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFechaOrdenado.AutoSize = true;
            this.labelFechaOrdenado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaOrdenado.Location = new System.Drawing.Point(338, 158);
            this.labelFechaOrdenado.Name = "labelFechaOrdenado";
            this.labelFechaOrdenado.Size = new System.Drawing.Size(102, 15);
            this.labelFechaOrdenado.TabIndex = 21;
            this.labelFechaOrdenado.Text = "Fecha Ordenado:";
            // 
            // textBoxFechaOrdenado
            // 
            this.textBoxFechaOrdenado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFechaOrdenado.BackColor = System.Drawing.Color.White;
            this.textBoxFechaOrdenado.Enabled = false;
            this.textBoxFechaOrdenado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFechaOrdenado.Location = new System.Drawing.Point(466, 158);
            this.textBoxFechaOrdenado.Name = "textBoxFechaOrdenado";
            this.textBoxFechaOrdenado.ReadOnly = true;
            this.textBoxFechaOrdenado.Size = new System.Drawing.Size(118, 21);
            this.textBoxFechaOrdenado.TabIndex = 22;
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCliente.BackColor = System.Drawing.Color.White;
            this.textBoxCliente.Enabled = false;
            this.textBoxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCliente.Location = new System.Drawing.Point(171, 186);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.ReadOnly = true;
            this.textBoxCliente.Size = new System.Drawing.Size(116, 21);
            this.textBoxCliente.TabIndex = 23;
            // 
            // labelPedido
            // 
            this.labelPedido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPedido.AutoSize = true;
            this.labelPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPedido.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelPedido.Location = new System.Drawing.Point(40, 131);
            this.labelPedido.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelPedido.Name = "labelPedido";
            this.labelPedido.Size = new System.Drawing.Size(112, 29);
            this.labelPedido.TabIndex = 24;
            this.labelPedido.Text = "ORDEN:";
            // 
            // labelNumeroPedido
            // 
            this.labelNumeroPedido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelNumeroPedido.AutoSize = true;
            this.labelNumeroPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroPedido.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelNumeroPedido.Location = new System.Drawing.Point(188, 131);
            this.labelNumeroPedido.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelNumeroPedido.Name = "labelNumeroPedido";
            this.labelNumeroPedido.Size = new System.Drawing.Size(70, 29);
            this.labelNumeroPedido.TabIndex = 25;
            this.labelNumeroPedido.Text = "NNN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Detalle de Orden";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.setting;
            this.pictureBox1.Location = new System.Drawing.Point(36, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 14);
            this.label3.TabIndex = 29;
            this.label3.Text = "Socio Proveedor:";
            // 
            // textBoxFechaRequerido
            // 
            this.textBoxFechaRequerido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFechaRequerido.BackColor = System.Drawing.Color.White;
            this.textBoxFechaRequerido.Enabled = false;
            this.textBoxFechaRequerido.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFechaRequerido.Location = new System.Drawing.Point(466, 188);
            this.textBoxFechaRequerido.Name = "textBoxFechaRequerido";
            this.textBoxFechaRequerido.ReadOnly = true;
            this.textBoxFechaRequerido.Size = new System.Drawing.Size(118, 22);
            this.textBoxFechaRequerido.TabIndex = 30;
            // 
            // labelFechaRequerido
            // 
            this.labelFechaRequerido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFechaRequerido.AutoSize = true;
            this.labelFechaRequerido.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaRequerido.Location = new System.Drawing.Point(338, 196);
            this.labelFechaRequerido.Name = "labelFechaRequerido";
            this.labelFechaRequerido.Size = new System.Drawing.Size(96, 14);
            this.labelFechaRequerido.TabIndex = 31;
            this.labelFechaRequerido.Text = "Fecha Requerido:";
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.AllowUserToAddRows = false;
            this.dataGridViewProductos.AllowUserToDeleteRows = false;
            this.dataGridViewProductos.AllowUserToOrderColumns = true;
            this.dataGridViewProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.dataGridViewProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewProductos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProductos.ColumnHeadersHeight = 30;
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProductos.EnableHeadersVisualStyles = false;
            this.dataGridViewProductos.Location = new System.Drawing.Point(21, 233);
            this.dataGridViewProductos.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.dataGridViewProductos.MultiSelect = false;
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.ReadOnly = true;
            this.dataGridViewProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewProductos.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewProductos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewProductos.RowTemplate.ReadOnly = true;
            this.dataGridViewProductos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductos.ShowCellErrors = false;
            this.dataGridViewProductos.ShowCellToolTips = false;
            this.dataGridViewProductos.ShowEditingIcon = false;
            this.dataGridViewProductos.ShowRowErrors = false;
            this.dataGridViewProductos.Size = new System.Drawing.Size(569, 238);
            this.dataGridViewProductos.TabIndex = 32;
            // 
            // numero
            // 
            this.numero.HeaderText = "";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Width = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 477);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 74);
            this.panel1.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(283, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Salir";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::CapaPresentacion.Properties.Resources.close2;
            this.pictureBox6.Location = new System.Drawing.Point(273, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(53, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // FrmOrdenPendienteDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 552);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.textBoxFechaRequerido);
            this.Controls.Add(this.labelFechaRequerido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.labelFechaOrdenado);
            this.Controls.Add(this.textBoxFechaOrdenado);
            this.Controls.Add(this.textBoxCliente);
            this.Controls.Add(this.labelPedido);
            this.Controls.Add(this.labelNumeroPedido);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOrdenPendienteDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de Orden de Compra";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelFechaOrdenado;
        private System.Windows.Forms.TextBox textBoxFechaOrdenado;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.Label labelPedido;
        private System.Windows.Forms.Label labelNumeroPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFechaRequerido;
        private System.Windows.Forms.Label labelFechaRequerido;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ToolTip toolTipAgregarProducto;
        private System.Windows.Forms.ToolTip toolTipEliminarProducto;
        private System.Windows.Forms.ToolTip toolTipEditarProducto;
    }
}