Partial Class FrmAgregarNuevoProducto
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
		Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.labelPrecioUnitario = New System.Windows.Forms.Label()
		Me.labelCategoria = New System.Windows.Forms.Label()
		Me.textBoxNombreProducto = New System.Windows.Forms.TextBox()
		Me.labelNombreProducto = New System.Windows.Forms.Label()
		Me.comboBoxCategoria = New System.Windows.Forms.ComboBox()
		Me.tableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
		Me.textBoxPrecioUnitario = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.labelDetalles = New System.Windows.Forms.Label()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.textBoxDetalles = New System.Windows.Forms.TextBox()
		Me.tableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
		Me.buttonGuardar = New System.Windows.Forms.Button()
		Me.buttonCancelar = New System.Windows.Forms.Button()
		Me.tableLayoutPanel1.SuspendLayout()
		Me.tableLayoutPanel2.SuspendLayout()
		Me.tableLayoutPanel4.SuspendLayout()
		Me.tableLayoutPanel3.SuspendLayout()
		Me.SuspendLayout()
		' 
		' tableLayoutPanel1
		' 
		Me.tableLayoutPanel1.ColumnCount = 2
		Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.82482F))
		Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.17519F))
		Me.tableLayoutPanel1.Controls.Add(Me.tableLayoutPanel2, 1, 0)
		Me.tableLayoutPanel1.Controls.Add(Me.panel1, 0, 0)
		Me.tableLayoutPanel1.Location = New System.Drawing.Point(2, 2)
		Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
		Me.tableLayoutPanel1.RowCount = 1
		Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanel1.Size = New System.Drawing.Size(685, 251)
		Me.tableLayoutPanel1.TabIndex = 1
		' 
		' tableLayoutPanel2
		' 
		Me.tableLayoutPanel2.ColumnCount = 2
		Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.74122F))
		Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.25878F))
		Me.tableLayoutPanel2.Controls.Add(Me.labelPrecioUnitario, 0, 2)
		Me.tableLayoutPanel2.Controls.Add(Me.labelCategoria, 0, 1)
		Me.tableLayoutPanel2.Controls.Add(Me.textBoxNombreProducto, 1, 0)
		Me.tableLayoutPanel2.Controls.Add(Me.labelNombreProducto, 0, 0)
		Me.tableLayoutPanel2.Controls.Add(Me.comboBoxCategoria, 1, 1)
		Me.tableLayoutPanel2.Controls.Add(Me.tableLayoutPanel4, 1, 2)
		Me.tableLayoutPanel2.Controls.Add(Me.labelDetalles, 0, 3)
		Me.tableLayoutPanel2.Location = New System.Drawing.Point(84, 3)
		Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
		Me.tableLayoutPanel2.RowCount = 4
		Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F))
		Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F))
		Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F))
		Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F))
		Me.tableLayoutPanel2.Size = New System.Drawing.Size(594, 153)
		Me.tableLayoutPanel2.TabIndex = 0
		' 
		' labelPrecioUnitario
		' 
		Me.labelPrecioUnitario.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelPrecioUnitario.AutoSize = True
		Me.labelPrecioUnitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelPrecioUnitario.Location = New System.Drawing.Point(3, 82)
		Me.labelPrecioUnitario.Name = "labelPrecioUnitario"
		Me.labelPrecioUnitario.Size = New System.Drawing.Size(159, 25)
		Me.labelPrecioUnitario.TabIndex = 9
		Me.labelPrecioUnitario.Text = "Precio Unitario:"
		' 
		' labelCategoria
		' 
		Me.labelCategoria.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelCategoria.AutoSize = True
		Me.labelCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelCategoria.Location = New System.Drawing.Point(3, 44)
		Me.labelCategoria.Name = "labelCategoria"
		Me.labelCategoria.Size = New System.Drawing.Size(111, 25)
		Me.labelCategoria.TabIndex = 8
		Me.labelCategoria.Text = "Categoría:"
		' 
		' textBoxNombreProducto
		' 
		Me.textBoxNombreProducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxNombreProducto.BackColor = System.Drawing.Color.White
		Me.textBoxNombreProducto.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxNombreProducto.Location = New System.Drawing.Point(239, 3)
		Me.textBoxNombreProducto.MaxLength = 50
		Me.textBoxNombreProducto.Name = "textBoxNombreProducto"
		Me.textBoxNombreProducto.Size = New System.Drawing.Size(352, 33)
		Me.textBoxNombreProducto.TabIndex = 0
		' 
		' labelNombreProducto
		' 
		Me.labelNombreProducto.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelNombreProducto.AutoSize = True
		Me.labelNombreProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelNombreProducto.Location = New System.Drawing.Point(3, 6)
		Me.labelNombreProducto.Name = "labelNombreProducto"
		Me.labelNombreProducto.Size = New System.Drawing.Size(215, 25)
		Me.labelNombreProducto.TabIndex = 7
		Me.labelNombreProducto.Text = "Nombre de Producto:"
		' 
		' comboBoxCategoria
		' 
		Me.comboBoxCategoria.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.comboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBoxCategoria.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.comboBoxCategoria.FormattingEnabled = True
		Me.comboBoxCategoria.Location = New System.Drawing.Point(239, 41)
		Me.comboBoxCategoria.Name = "comboBoxCategoria"
		Me.comboBoxCategoria.Size = New System.Drawing.Size(352, 34)
		Me.comboBoxCategoria.TabIndex = 1
		' 
		' tableLayoutPanel4
		' 
		Me.tableLayoutPanel4.ColumnCount = 2
		Me.tableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.68156F))
		Me.tableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.31844F))
		Me.tableLayoutPanel4.Controls.Add(Me.textBoxPrecioUnitario, 0, 0)
		Me.tableLayoutPanel4.Controls.Add(Me.label1, 1, 0)
		Me.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tableLayoutPanel4.Location = New System.Drawing.Point(236, 76)
		Me.tableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
		Me.tableLayoutPanel4.Name = "tableLayoutPanel4"
		Me.tableLayoutPanel4.RowCount = 1
		Me.tableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanel4.Size = New System.Drawing.Size(358, 38)
		Me.tableLayoutPanel4.TabIndex = 12
		' 
		' textBoxPrecioUnitario
		' 
		Me.textBoxPrecioUnitario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.textBoxPrecioUnitario.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxPrecioUnitario.Location = New System.Drawing.Point(3, 3)
		Me.textBoxPrecioUnitario.MaxLength = 10
		Me.textBoxPrecioUnitario.Name = "textBoxPrecioUnitario"
		Me.textBoxPrecioUnitario.Size = New System.Drawing.Size(110, 33)
		Me.textBoxPrecioUnitario.TabIndex = 2
		Me.textBoxPrecioUnitario.Text = "0"
		Me.textBoxPrecioUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		AddHandler Me.textBoxPrecioUnitario.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.textBoxPrecioUnitario_KeyPress)
		' 
		' label1
		' 
		Me.label1.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.label1.AutoSize = True
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label1.Location = New System.Drawing.Point(119, 6)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(25, 25)
		Me.label1.TabIndex = 3
		Me.label1.Text = "$"
		' 
		' labelDetalles
		' 
		Me.labelDetalles.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelDetalles.AutoSize = True
		Me.labelDetalles.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelDetalles.Location = New System.Drawing.Point(3, 121)
		Me.labelDetalles.Name = "labelDetalles"
		Me.labelDetalles.Size = New System.Drawing.Size(96, 25)
		Me.labelDetalles.TabIndex = 11
		Me.labelDetalles.Text = "Detalles:"
		' 
		' panel1
		' 
		Me.panel1.BackgroundImage = Global.CapaPresentacion.Properties.Resources.productos
		Me.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.panel1.Location = New System.Drawing.Point(3, 6)
		Me.panel1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(75, 75)
		Me.panel1.TabIndex = 1
		' 
		' textBoxDetalles
		' 
		Me.textBoxDetalles.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxDetalles.Location = New System.Drawing.Point(95, 160)
		Me.textBoxDetalles.MaxLength = 150
		Me.textBoxDetalles.Multiline = True
		Me.textBoxDetalles.Name = "textBoxDetalles"
		Me.textBoxDetalles.Size = New System.Drawing.Size(577, 149)
		Me.textBoxDetalles.TabIndex = 2
		' 
		' tableLayoutPanel3
		' 
		Me.tableLayoutPanel3.ColumnCount = 2
		Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanel3.Controls.Add(Me.buttonGuardar, 0, 0)
		Me.tableLayoutPanel3.Controls.Add(Me.buttonCancelar, 1, 0)
		Me.tableLayoutPanel3.Location = New System.Drawing.Point(95, 318)
		Me.tableLayoutPanel3.Name = "tableLayoutPanel3"
		Me.tableLayoutPanel3.RowCount = 1
		Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
		Me.tableLayoutPanel3.Size = New System.Drawing.Size(577, 39)
		Me.tableLayoutPanel3.TabIndex = 90
		' 
		' buttonGuardar
		' 
		Me.buttonGuardar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonGuardar.BackColor = System.Drawing.Color.LightSkyBlue
		Me.buttonGuardar.Font = New System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.buttonGuardar.ForeColor = System.Drawing.Color.Black
		Me.buttonGuardar.Location = New System.Drawing.Point(68, 0)
		Me.buttonGuardar.Margin = New System.Windows.Forms.Padding(0, 0, 5, 0)
		Me.buttonGuardar.Name = "buttonGuardar"
		Me.buttonGuardar.Size = New System.Drawing.Size(215, 39)
		Me.buttonGuardar.TabIndex = 10
		Me.buttonGuardar.Text = "Guardar"
		Me.buttonGuardar.UseVisualStyleBackColor = False
		AddHandler Me.buttonGuardar.Click, New System.EventHandler(AddressOf Me.buttonGuardar_Click)
		' 
		' buttonCancelar
		' 
		Me.buttonCancelar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.buttonCancelar.BackColor = System.Drawing.Color.LightSkyBlue
		Me.buttonCancelar.Font = New System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.buttonCancelar.ForeColor = System.Drawing.Color.Black
		Me.buttonCancelar.Location = New System.Drawing.Point(293, 0)
		Me.buttonCancelar.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
		Me.buttonCancelar.Name = "buttonCancelar"
		Me.buttonCancelar.Size = New System.Drawing.Size(215, 39)
		Me.buttonCancelar.TabIndex = 11
		Me.buttonCancelar.Text = "Cancelar"
		Me.buttonCancelar.UseVisualStyleBackColor = False
		AddHandler Me.buttonCancelar.Click, New System.EventHandler(AddressOf Me.buttonCancelar_Click)
		' 
		' FrmAgregarNuevoProducto
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(692, 373)
		Me.Controls.Add(Me.textBoxDetalles)
		Me.Controls.Add(Me.tableLayoutPanel3)
		Me.Controls.Add(Me.tableLayoutPanel1)
		Me.MaximizeBox = False
		Me.MaximumSize = New System.Drawing.Size(700, 400)
		Me.MinimizeBox = False
		Me.MinimumSize = New System.Drawing.Size(700, 400)
		Me.Name = "FrmAgregarNuevoProducto"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Agregar Nuevo Producto"
		Me.tableLayoutPanel1.ResumeLayout(False)
		Me.tableLayoutPanel2.ResumeLayout(False)
		Me.tableLayoutPanel2.PerformLayout()
		Me.tableLayoutPanel4.ResumeLayout(False)
		Me.tableLayoutPanel4.PerformLayout()
		Me.tableLayoutPanel3.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Private panel1 As System.Windows.Forms.Panel
	Private tableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
	Private buttonGuardar As System.Windows.Forms.Button
	Private buttonCancelar As System.Windows.Forms.Button
	Private tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
	Private labelNombreProducto As System.Windows.Forms.Label
	Private labelDetalles As System.Windows.Forms.Label
	Private labelPrecioUnitario As System.Windows.Forms.Label
	Private labelCategoria As System.Windows.Forms.Label
	Private textBoxNombreProducto As System.Windows.Forms.TextBox
	Private comboBoxCategoria As System.Windows.Forms.ComboBox
	Private textBoxPrecioUnitario As System.Windows.Forms.TextBox
	Private textBoxDetalles As System.Windows.Forms.TextBox
	Private tableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
	Private label1 As System.Windows.Forms.Label

End Class
