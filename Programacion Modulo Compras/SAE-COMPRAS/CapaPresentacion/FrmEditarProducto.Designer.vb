Partial Class FrmEditarProducto
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
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.tableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
		Me.textBoxNombreProducto = New System.Windows.Forms.TextBox()
		Me.labelPrecioUnitario = New System.Windows.Forms.Label()
		Me.labelNombreProducto = New System.Windows.Forms.Label()
		Me.labelCategoria = New System.Windows.Forms.Label()
		Me.comboBoxCategorias = New System.Windows.Forms.ComboBox()
		Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.textBoxPrecioUnitario = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.labelDetalles = New System.Windows.Forms.Label()
		Me.tableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
		Me.buttonGuardar = New System.Windows.Forms.Button()
		Me.buttonCancelar = New System.Windows.Forms.Button()
		Me.textBoxDetalles = New System.Windows.Forms.TextBox()
		Me.tableLayoutPanel1.SuspendLayout()
		Me.tableLayoutPanel4.SuspendLayout()
		Me.tableLayoutPanel2.SuspendLayout()
		Me.tableLayoutPanel3.SuspendLayout()
		Me.SuspendLayout()
		' 
		' tableLayoutPanel1
		' 
		Me.tableLayoutPanel1.ColumnCount = 2
		Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.04112F))
		Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.95889F))
		Me.tableLayoutPanel1.Controls.Add(Me.panel1, 0, 0)
		Me.tableLayoutPanel1.Controls.Add(Me.tableLayoutPanel4, 1, 0)
		Me.tableLayoutPanel1.Location = New System.Drawing.Point(2, 2)
		Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
		Me.tableLayoutPanel1.RowCount = 1
		Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanel1.Size = New System.Drawing.Size(681, 248)
		Me.tableLayoutPanel1.TabIndex = 0
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
		' tableLayoutPanel4
		' 
		Me.tableLayoutPanel4.ColumnCount = 2
		Me.tableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.27119F))
		Me.tableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.72881F))
		Me.tableLayoutPanel4.Controls.Add(Me.textBoxNombreProducto, 1, 0)
		Me.tableLayoutPanel4.Controls.Add(Me.labelPrecioUnitario, 0, 2)
		Me.tableLayoutPanel4.Controls.Add(Me.labelNombreProducto, 0, 0)
		Me.tableLayoutPanel4.Controls.Add(Me.labelCategoria, 0, 1)
		Me.tableLayoutPanel4.Controls.Add(Me.comboBoxCategorias, 1, 1)
		Me.tableLayoutPanel4.Controls.Add(Me.tableLayoutPanel2, 1, 2)
		Me.tableLayoutPanel4.Controls.Add(Me.labelDetalles, 0, 3)
		Me.tableLayoutPanel4.Location = New System.Drawing.Point(85, 3)
		Me.tableLayoutPanel4.Name = "tableLayoutPanel4"
		Me.tableLayoutPanel4.RowCount = 4
		Me.tableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F))
		Me.tableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F))
		Me.tableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F))
		Me.tableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F))
		Me.tableLayoutPanel4.Size = New System.Drawing.Size(590, 152)
		Me.tableLayoutPanel4.TabIndex = 2
		' 
		' textBoxNombreProducto
		' 
		Me.textBoxNombreProducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxNombreProducto.BackColor = System.Drawing.Color.White
		Me.textBoxNombreProducto.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxNombreProducto.Location = New System.Drawing.Point(217, 3)
		Me.textBoxNombreProducto.MaxLength = 50
		Me.textBoxNombreProducto.Name = "textBoxNombreProducto"
		Me.textBoxNombreProducto.Size = New System.Drawing.Size(370, 33)
		Me.textBoxNombreProducto.TabIndex = 0
		' 
		' labelPrecioUnitario
		' 
		Me.labelPrecioUnitario.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelPrecioUnitario.AutoSize = True
		Me.labelPrecioUnitario.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelPrecioUnitario.Location = New System.Drawing.Point(3, 82)
		Me.labelPrecioUnitario.Name = "labelPrecioUnitario"
		Me.labelPrecioUnitario.Size = New System.Drawing.Size(153, 26)
		Me.labelPrecioUnitario.TabIndex = 9
		Me.labelPrecioUnitario.Text = "Precio Unitario:"
		' 
		' labelNombreProducto
		' 
		Me.labelNombreProducto.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelNombreProducto.AutoSize = True
		Me.labelNombreProducto.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelNombreProducto.Location = New System.Drawing.Point(3, 6)
		Me.labelNombreProducto.Name = "labelNombreProducto"
		Me.labelNombreProducto.Size = New System.Drawing.Size(208, 26)
		Me.labelNombreProducto.TabIndex = 7
		Me.labelNombreProducto.Text = "Nombre de Producto:"
		' 
		' labelCategoria
		' 
		Me.labelCategoria.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelCategoria.AutoSize = True
		Me.labelCategoria.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelCategoria.Location = New System.Drawing.Point(3, 44)
		Me.labelCategoria.Name = "labelCategoria"
		Me.labelCategoria.Size = New System.Drawing.Size(105, 26)
		Me.labelCategoria.TabIndex = 8
		Me.labelCategoria.Text = "Categoría:"
		' 
		' comboBoxCategorias
		' 
		Me.comboBoxCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBoxCategorias.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.comboBoxCategorias.FormattingEnabled = True
		Me.comboBoxCategorias.Location = New System.Drawing.Point(217, 41)
		Me.comboBoxCategorias.Name = "comboBoxCategorias"
		Me.comboBoxCategorias.Size = New System.Drawing.Size(370, 34)
		Me.comboBoxCategorias.TabIndex = 1
		' 
		' tableLayoutPanel2
		' 
		Me.tableLayoutPanel2.ColumnCount = 2
		Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.23809F))
		Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.76191F))
		Me.tableLayoutPanel2.Controls.Add(Me.textBoxPrecioUnitario, 0, 0)
		Me.tableLayoutPanel2.Controls.Add(Me.label1, 1, 0)
		Me.tableLayoutPanel2.Location = New System.Drawing.Point(214, 76)
		Me.tableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
		Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
		Me.tableLayoutPanel2.RowCount = 1
		Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanel2.Size = New System.Drawing.Size(210, 38)
		Me.tableLayoutPanel2.TabIndex = 13
		' 
		' textBoxPrecioUnitario
		' 
		Me.textBoxPrecioUnitario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.textBoxPrecioUnitario.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxPrecioUnitario.Location = New System.Drawing.Point(3, 3)
		Me.textBoxPrecioUnitario.MaxLength = 10
		Me.textBoxPrecioUnitario.Name = "textBoxPrecioUnitario"
		Me.textBoxPrecioUnitario.Size = New System.Drawing.Size(109, 33)
		Me.textBoxPrecioUnitario.TabIndex = 2
		Me.textBoxPrecioUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		AddHandler Me.textBoxPrecioUnitario.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.textBoxPrecioUnitario_KeyPress)
		' 
		' label1
		' 
		Me.label1.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.label1.AutoSize = True
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label1.Location = New System.Drawing.Point(118, 6)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(25, 25)
		Me.label1.TabIndex = 3
		Me.label1.Text = "$"
		' 
		' labelDetalles
		' 
		Me.labelDetalles.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelDetalles.AutoSize = True
		Me.labelDetalles.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelDetalles.Location = New System.Drawing.Point(3, 120)
		Me.labelDetalles.Name = "labelDetalles"
		Me.labelDetalles.Size = New System.Drawing.Size(90, 26)
		Me.labelDetalles.TabIndex = 11
		Me.labelDetalles.Text = "Detalles:"
		' 
		' tableLayoutPanel3
		' 
		Me.tableLayoutPanel3.ColumnCount = 2
		Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F))
		Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F))
		Me.tableLayoutPanel3.Controls.Add(Me.buttonGuardar, 0, 0)
		Me.tableLayoutPanel3.Controls.Add(Me.buttonCancelar, 1, 0)
		Me.tableLayoutPanel3.Location = New System.Drawing.Point(94, 317)
		Me.tableLayoutPanel3.Name = "tableLayoutPanel3"
		Me.tableLayoutPanel3.RowCount = 1
		Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
		Me.tableLayoutPanel3.Size = New System.Drawing.Size(583, 39)
		Me.tableLayoutPanel3.TabIndex = 5
		' 
		' buttonGuardar
		' 
		Me.buttonGuardar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonGuardar.BackColor = System.Drawing.Color.LightSkyBlue
		Me.buttonGuardar.Font = New System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.buttonGuardar.Location = New System.Drawing.Point(71, 0)
		Me.buttonGuardar.Margin = New System.Windows.Forms.Padding(0, 0, 5, 0)
		Me.buttonGuardar.Name = "buttonGuardar"
		Me.buttonGuardar.Size = New System.Drawing.Size(215, 39)
		Me.buttonGuardar.TabIndex = 0
		Me.buttonGuardar.Text = "Guardar"
		Me.buttonGuardar.UseVisualStyleBackColor = False
		AddHandler Me.buttonGuardar.Click, New System.EventHandler(AddressOf Me.buttonGuardar_Click)
		' 
		' buttonCancelar
		' 
		Me.buttonCancelar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.buttonCancelar.BackColor = System.Drawing.Color.LightSkyBlue
		Me.buttonCancelar.Font = New System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.buttonCancelar.Location = New System.Drawing.Point(296, 0)
		Me.buttonCancelar.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
		Me.buttonCancelar.Name = "buttonCancelar"
		Me.buttonCancelar.Size = New System.Drawing.Size(215, 39)
		Me.buttonCancelar.TabIndex = 1
		Me.buttonCancelar.Text = "Cancelar"
		Me.buttonCancelar.UseVisualStyleBackColor = False
		AddHandler Me.buttonCancelar.Click, New System.EventHandler(AddressOf Me.buttonCancelar_Click)
		' 
		' textBoxDetalles
		' 
		Me.textBoxDetalles.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxDetalles.Location = New System.Drawing.Point(94, 158)
		Me.textBoxDetalles.MaxLength = 150
		Me.textBoxDetalles.Multiline = True
		Me.textBoxDetalles.Name = "textBoxDetalles"
		Me.textBoxDetalles.Size = New System.Drawing.Size(577, 150)
		Me.textBoxDetalles.TabIndex = 3
		' 
		' FrmEditarProducto
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
		Me.Name = "FrmEditarProducto"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Editar Producto"
		Me.tableLayoutPanel1.ResumeLayout(False)
		Me.tableLayoutPanel4.ResumeLayout(False)
		Me.tableLayoutPanel4.PerformLayout()
		Me.tableLayoutPanel2.ResumeLayout(False)
		Me.tableLayoutPanel2.PerformLayout()
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
	Private labelPrecioUnitario As System.Windows.Forms.Label
	Private labelCategoria As System.Windows.Forms.Label
	Private textBoxNombreProducto As System.Windows.Forms.TextBox
	Private textBoxPrecioUnitario As System.Windows.Forms.TextBox
	Private labelNombreProducto As System.Windows.Forms.Label
	Private textBoxDetalles As System.Windows.Forms.TextBox
	Private tableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
	Private labelDetalles As System.Windows.Forms.Label
	Private comboBoxCategorias As System.Windows.Forms.ComboBox
	Private tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
	Private label1 As System.Windows.Forms.Label

End Class
