namespace CapaPresentacion
{
    partial class FrmOrdenEntregadoDetalles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.labelPedido = new System.Windows.Forms.Label();
            this.labelNumeroPedido = new System.Windows.Forms.Label();
            this.labelFechaOrdenado = new System.Windows.Forms.Label();
            this.labelFechaEntregado = new System.Windows.Forms.Label();
            this.textBoxFechaOrdenado = new System.Windows.Forms.TextBox();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.labelCliente = new System.Windows.Forms.Label();
            this.textBoxFechaEntregado = new System.Windows.Forms.TextBox();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Orden Entregada Detalle";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.setting;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-3, 452);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 74);
            this.panel1.TabIndex = 34;
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
            // labelPedido
            // 
            this.labelPedido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPedido.AutoSize = true;
            this.labelPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPedido.ForeColor = System.Drawing.Color.Black;
            this.labelPedido.Location = new System.Drawing.Point(15, 123);
            this.labelPedido.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelPedido.Name = "labelPedido";
            this.labelPedido.Size = new System.Drawing.Size(112, 29);
            this.labelPedido.TabIndex = 35;
            this.labelPedido.Text = "ORDEN:";
            // 
            // labelNumeroPedido
            // 
            this.labelNumeroPedido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelNumeroPedido.AutoSize = true;
            this.labelNumeroPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroPedido.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelNumeroPedido.Location = new System.Drawing.Point(150, 123);
            this.labelNumeroPedido.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelNumeroPedido.Name = "labelNumeroPedido";
            this.labelNumeroPedido.Size = new System.Drawing.Size(70, 29);
            this.labelNumeroPedido.TabIndex = 36;
            this.labelNumeroPedido.Text = "NNN";
            // 
            // labelFechaOrdenado
            // 
            this.labelFechaOrdenado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFechaOrdenado.AutoSize = true;
            this.labelFechaOrdenado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaOrdenado.Location = new System.Drawing.Point(320, 166);
            this.labelFechaOrdenado.Name = "labelFechaOrdenado";
            this.labelFechaOrdenado.Size = new System.Drawing.Size(102, 15);
            this.labelFechaOrdenado.TabIndex = 39;
            this.labelFechaOrdenado.Text = "Fecha Ordenado:";
            // 
            // labelFechaEntregado
            // 
            this.labelFechaEntregado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFechaEntregado.AutoSize = true;
            this.labelFechaEntregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaEntregado.Location = new System.Drawing.Point(320, 202);
            this.labelFechaEntregado.Name = "labelFechaEntregado";
            this.labelFechaEntregado.Size = new System.Drawing.Size(104, 15);
            this.labelFechaEntregado.TabIndex = 40;
            this.labelFechaEntregado.Text = "Fecha Entregado:";
            // 
            // textBoxFechaOrdenado
            // 
            this.textBoxFechaOrdenado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFechaOrdenado.BackColor = System.Drawing.Color.White;
            this.textBoxFechaOrdenado.Enabled = false;
            this.textBoxFechaOrdenado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFechaOrdenado.Location = new System.Drawing.Point(430, 163);
            this.textBoxFechaOrdenado.Name = "textBoxFechaOrdenado";
            this.textBoxFechaOrdenado.ReadOnly = true;
            this.textBoxFechaOrdenado.Size = new System.Drawing.Size(138, 21);
            this.textBoxFechaOrdenado.TabIndex = 41;
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCliente.BackColor = System.Drawing.Color.White;
            this.textBoxCliente.Enabled = false;
            this.textBoxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCliente.Location = new System.Drawing.Point(155, 166);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.ReadOnly = true;
            this.textBoxCliente.Size = new System.Drawing.Size(128, 21);
            this.textBoxCliente.TabIndex = 42;
            // 
            // labelCliente
            // 
            this.labelCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(30, 169);
            this.labelCliente.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(97, 15);
            this.labelCliente.TabIndex = 38;
            this.labelCliente.Text = "Socio Proveedor";
            // 
            // textBoxFechaEntregado
            // 
            this.textBoxFechaEntregado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFechaEntregado.BackColor = System.Drawing.Color.White;
            this.textBoxFechaEntregado.Enabled = false;
            this.textBoxFechaEntregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFechaEntregado.Location = new System.Drawing.Point(430, 196);
            this.textBoxFechaEntregado.Name = "textBoxFechaEntregado";
            this.textBoxFechaEntregado.ReadOnly = true;
            this.textBoxFechaEntregado.Size = new System.Drawing.Size(138, 21);
            this.textBoxFechaEntregado.TabIndex = 37;
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.AllowUserToAddRows = false;
            this.dataGridViewProductos.AllowUserToDeleteRows = false;
            this.dataGridViewProductos.AllowUserToOrderColumns = true;
            this.dataGridViewProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.dataGridViewProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewProductos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewProductos.ColumnHeadersHeight = 30;
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProductos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewProductos.EnableHeadersVisualStyles = false;
            this.dataGridViewProductos.Location = new System.Drawing.Point(20, 239);
            this.dataGridViewProductos.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.dataGridViewProductos.MultiSelect = false;
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.ReadOnly = true;
            this.dataGridViewProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewProductos.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewProductos.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewProductos.RowTemplate.ReadOnly = true;
            this.dataGridViewProductos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductos.ShowCellErrors = false;
            this.dataGridViewProductos.ShowCellToolTips = false;
            this.dataGridViewProductos.ShowEditingIcon = false;
            this.dataGridViewProductos.ShowRowErrors = false;
            this.dataGridViewProductos.Size = new System.Drawing.Size(556, 194);
            this.dataGridViewProductos.TabIndex = 43;
            // 
            // numero
            // 
            this.numero.HeaderText = "";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Width = 17;
            // 
            // FrmOrdenEntregadoDetalles1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 525);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.labelFechaOrdenado);
            this.Controls.Add(this.labelFechaEntregado);
            this.Controls.Add(this.textBoxFechaOrdenado);
            this.Controls.Add(this.textBoxCliente);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.textBoxFechaEntregado);
            this.Controls.Add(this.labelPedido);
            this.Controls.Add(this.labelNumeroPedido);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOrdenEntregadoDetalles1";
            this.Text = "FrmOrdenEntregadoDetalles1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label labelPedido;
        private System.Windows.Forms.Label labelNumeroPedido;
        private System.Windows.Forms.Label labelFechaOrdenado;
        private System.Windows.Forms.Label labelFechaEntregado;
        private System.Windows.Forms.TextBox textBoxFechaOrdenado;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.TextBox textBoxFechaEntregado;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
    }
}