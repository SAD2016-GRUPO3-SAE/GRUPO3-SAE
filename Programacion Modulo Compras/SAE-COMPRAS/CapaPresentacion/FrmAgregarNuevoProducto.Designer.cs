namespace CapaPresentacion
{
    partial class FrmAgregarNuevoProducto
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.textBoxNombreProducto = new System.Windows.Forms.TextBox();
            this.labelNombreProducto = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.labelPrecioUnitario = new System.Windows.Forms.Label();
            this.textBoxPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDetalles = new System.Windows.Forms.Label();
            this.textBoxDetalles = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "Agregar Nuevo Producto";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CapaPresentacion.Properties.Resources.phonebook1;
            this.pictureBox4.Location = new System.Drawing.Point(12, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(97, 82);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources.inside;
            this.pictureBox3.Location = new System.Drawing.Point(466, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(84, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.Floppy_disk_5121;
            this.pictureBox2.Location = new System.Drawing.Point(365, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(3, 447);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 93);
            this.panel1.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(493, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Salir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(381, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "Guardar";
            // 
            // labelCategoria
            // 
            this.labelCategoria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.Location = new System.Drawing.Point(58, 175);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(63, 15);
            this.labelCategoria.TabIndex = 31;
            this.labelCategoria.Text = "Categoría:";
            // 
            // textBoxNombreProducto
            // 
            this.textBoxNombreProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNombreProducto.BackColor = System.Drawing.Color.White;
            this.textBoxNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreProducto.Location = new System.Drawing.Point(213, 132);
            this.textBoxNombreProducto.MaxLength = 50;
            this.textBoxNombreProducto.Name = "textBoxNombreProducto";
            this.textBoxNombreProducto.Size = new System.Drawing.Size(367, 21);
            this.textBoxNombreProducto.TabIndex = 28;
            // 
            // labelNombreProducto
            // 
            this.labelNombreProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelNombreProducto.AutoSize = true;
            this.labelNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreProducto.Location = new System.Drawing.Point(58, 135);
            this.labelNombreProducto.Name = "labelNombreProducto";
            this.labelNombreProducto.Size = new System.Drawing.Size(124, 15);
            this.labelNombreProducto.TabIndex = 30;
            this.labelNombreProducto.Text = "Nombre de Producto:";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(213, 167);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(369, 23);
            this.comboBoxCategoria.TabIndex = 29;
            // 
            // labelPrecioUnitario
            // 
            this.labelPrecioUnitario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPrecioUnitario.AutoSize = true;
            this.labelPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioUnitario.Location = new System.Drawing.Point(58, 213);
            this.labelPrecioUnitario.Name = "labelPrecioUnitario";
            this.labelPrecioUnitario.Size = new System.Drawing.Size(91, 15);
            this.labelPrecioUnitario.TabIndex = 35;
            this.labelPrecioUnitario.Text = "Precio Unitario:";
            // 
            // textBoxPrecioUnitario
            // 
            this.textBoxPrecioUnitario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecioUnitario.Location = new System.Drawing.Point(213, 204);
            this.textBoxPrecioUnitario.MaxLength = 10;
            this.textBoxPrecioUnitario.Name = "textBoxPrecioUnitario";
            this.textBoxPrecioUnitario.Size = new System.Drawing.Size(110, 21);
            this.textBoxPrecioUnitario.TabIndex = 32;
            this.textBoxPrecioUnitario.Text = "0";
            this.textBoxPrecioUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "Q";
            // 
            // labelDetalles
            // 
            this.labelDetalles.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDetalles.AutoSize = true;
            this.labelDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetalles.Location = new System.Drawing.Point(58, 250);
            this.labelDetalles.Name = "labelDetalles";
            this.labelDetalles.Size = new System.Drawing.Size(55, 15);
            this.labelDetalles.TabIndex = 36;
            this.labelDetalles.Text = "Detalles:";
            // 
            // textBoxDetalles
            // 
            this.textBoxDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDetalles.Location = new System.Drawing.Point(61, 268);
            this.textBoxDetalles.MaxLength = 150;
            this.textBoxDetalles.Multiline = true;
            this.textBoxDetalles.Name = "textBoxDetalles";
            this.textBoxDetalles.Size = new System.Drawing.Size(519, 149);
            this.textBoxDetalles.TabIndex = 33;
            this.textBoxDetalles.TextChanged += new System.EventHandler(this.textBoxDetalles_TextChanged);
            // 
            // FrmAgregarNuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 537);
            this.Controls.Add(this.labelPrecioUnitario);
            this.Controls.Add(this.textBoxPrecioUnitario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDetalles);
            this.Controls.Add(this.textBoxDetalles);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.textBoxNombreProducto);
            this.Controls.Add(this.labelNombreProducto);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAgregarNuevoProducto";
            this.Text = "Agregar Nuevo Producto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.TextBox textBoxNombreProducto;
        private System.Windows.Forms.Label labelNombreProducto;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Label labelPrecioUnitario;
        private System.Windows.Forms.TextBox textBoxPrecioUnitario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDetalles;
        private System.Windows.Forms.TextBox textBoxDetalles;
    }
}