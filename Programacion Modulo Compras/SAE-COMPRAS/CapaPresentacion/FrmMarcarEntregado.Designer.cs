namespace CapaPresentacion
{
    partial class FrmMarcarEntregado
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.buttonHoy = new System.Windows.Forms.Button();
            this.buttonFecha = new System.Windows.Forms.Button();
            this.textBoxHoy = new System.Windows.Forms.TextBox();
            this.dateTimePickerMarcarFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "Marcar Entregada Orden ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(3, 265);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 42);
            this.panel1.TabIndex = 27;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CapaPresentacion.Properties.Resources.check1;
            this.pictureBox4.Location = new System.Drawing.Point(18, 15);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(145, 101);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // labelNombre
            // 
            this.labelNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(278, 124);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(57, 25);
            this.labelNombre.TabIndex = 33;
            this.labelNombre.Text = "NNN";
            this.labelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonHoy
            // 
            this.buttonHoy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonHoy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHoy.Location = new System.Drawing.Point(318, 192);
            this.buttonHoy.Margin = new System.Windows.Forms.Padding(0);
            this.buttonHoy.Name = "buttonHoy";
            this.buttonHoy.Size = new System.Drawing.Size(218, 26);
            this.buttonHoy.TabIndex = 45;
            this.buttonHoy.Text = "Hoy";
            this.buttonHoy.UseVisualStyleBackColor = false;
            this.buttonHoy.Click += new System.EventHandler(this.buttonHoy_Click);
            // 
            // buttonFecha
            // 
            this.buttonFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFecha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFecha.Location = new System.Drawing.Point(318, 170);
            this.buttonFecha.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFecha.Name = "buttonFecha";
            this.buttonFecha.Size = new System.Drawing.Size(218, 22);
            this.buttonFecha.TabIndex = 43;
            this.buttonFecha.Text = "Fecha";
            this.buttonFecha.UseVisualStyleBackColor = false;
            this.buttonFecha.Click += new System.EventHandler(this.buttonFecha_Click);
            // 
            // textBoxHoy
            // 
            this.textBoxHoy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHoy.Location = new System.Drawing.Point(43, 196);
            this.textBoxHoy.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHoy.Name = "textBoxHoy";
            this.textBoxHoy.ReadOnly = true;
            this.textBoxHoy.Size = new System.Drawing.Size(271, 22);
            this.textBoxHoy.TabIndex = 44;
            // 
            // dateTimePickerMarcarFecha
            // 
            this.dateTimePickerMarcarFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerMarcarFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerMarcarFecha.Location = new System.Drawing.Point(43, 170);
            this.dateTimePickerMarcarFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerMarcarFecha.Name = "dateTimePickerMarcarFecha";
            this.dateTimePickerMarcarFecha.Size = new System.Drawing.Size(271, 22);
            this.dateTimePickerMarcarFecha.TabIndex = 42;
            // 
            // FrmMarcarEntregado1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 308);
            this.Controls.Add(this.buttonHoy);
            this.Controls.Add(this.buttonFecha);
            this.Controls.Add(this.textBoxHoy);
            this.Controls.Add(this.dateTimePickerMarcarFecha);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMarcarEntregado1";
            this.Text = "Marcar Orden Entregada";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button buttonHoy;
        private System.Windows.Forms.Button buttonFecha;
        private System.Windows.Forms.TextBox textBoxHoy;
        private System.Windows.Forms.DateTimePicker dateTimePickerMarcarFecha;
    }
}