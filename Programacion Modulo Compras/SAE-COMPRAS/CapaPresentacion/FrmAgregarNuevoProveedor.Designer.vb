Partial Class FrmAgregarNuevoProveedor
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
		Me.labelTelefono = New System.Windows.Forms.Label()
		Me.labelPais = New System.Windows.Forms.Label()
		Me.labelRegion = New System.Windows.Forms.Label()
		Me.labelCiudad = New System.Windows.Forms.Label()
		Me.labelDireccion = New System.Windows.Forms.Label()
		Me.labelNombreContacto = New System.Windows.Forms.Label()
		Me.textBoxNombreCliente = New System.Windows.Forms.TextBox()
		Me.textBoxNombreContacto = New System.Windows.Forms.TextBox()
		Me.textBoxDireccion = New System.Windows.Forms.TextBox()
		Me.textBoxCiudad = New System.Windows.Forms.TextBox()
		Me.textBoxRegion = New System.Windows.Forms.TextBox()
		Me.textBoxPais = New System.Windows.Forms.TextBox()
		Me.textBoxTelefono = New System.Windows.Forms.TextBox()
		Me.labelNombreCliente = New System.Windows.Forms.Label()
		Me.labelFax = New System.Windows.Forms.Label()
		Me.labelEmail = New System.Windows.Forms.Label()
		Me.textBoxFax = New System.Windows.Forms.TextBox()
		Me.textBoxEmail = New System.Windows.Forms.TextBox()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.tableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
		Me.buttonGuardar = New System.Windows.Forms.Button()
		Me.buttonCancelar = New System.Windows.Forms.Button()
		Me.tableLayoutPanel1.SuspendLayout()
		Me.tableLayoutPanel2.SuspendLayout()
		Me.tableLayoutPanel3.SuspendLayout()
		Me.SuspendLayout()
		' 
		' tableLayoutPanel1
		' 
		Me.tableLayoutPanel1.ColumnCount = 2
		Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.40823F))
		Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.59177F))
		Me.tableLayoutPanel1.Controls.Add(Me.tableLayoutPanel2, 1, 0)
		Me.tableLayoutPanel1.Controls.Add(Me.panel1, 0, 0)
		Me.tableLayoutPanel1.Location = New System.Drawing.Point(2, 2)
		Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
		Me.tableLayoutPanel1.RowCount = 1
		Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanel1.Size = New System.Drawing.Size(583, 349)
		Me.tableLayoutPanel1.TabIndex = 0
		' 
		' tableLayoutPanel2
		' 
		Me.tableLayoutPanel2.ColumnCount = 2
		Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.71255F))
		Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.28745F))
		Me.tableLayoutPanel2.Controls.Add(Me.labelTelefono, 0, 6)
		Me.tableLayoutPanel2.Controls.Add(Me.labelPais, 0, 5)
		Me.tableLayoutPanel2.Controls.Add(Me.labelRegion, 0, 4)
		Me.tableLayoutPanel2.Controls.Add(Me.labelCiudad, 0, 3)
		Me.tableLayoutPanel2.Controls.Add(Me.labelDireccion, 0, 2)
		Me.tableLayoutPanel2.Controls.Add(Me.labelNombreContacto, 0, 1)
		Me.tableLayoutPanel2.Controls.Add(Me.textBoxNombreCliente, 1, 0)
		Me.tableLayoutPanel2.Controls.Add(Me.textBoxNombreContacto, 1, 1)
		Me.tableLayoutPanel2.Controls.Add(Me.textBoxDireccion, 1, 2)
		Me.tableLayoutPanel2.Controls.Add(Me.textBoxCiudad, 1, 3)
		Me.tableLayoutPanel2.Controls.Add(Me.textBoxRegion, 1, 4)
		Me.tableLayoutPanel2.Controls.Add(Me.textBoxPais, 1, 5)
		Me.tableLayoutPanel2.Controls.Add(Me.textBoxTelefono, 1, 6)
		Me.tableLayoutPanel2.Controls.Add(Me.labelNombreCliente, 0, 0)
		Me.tableLayoutPanel2.Controls.Add(Me.labelFax, 0, 7)
		Me.tableLayoutPanel2.Controls.Add(Me.labelEmail, 0, 8)
		Me.tableLayoutPanel2.Controls.Add(Me.textBoxFax, 1, 7)
		Me.tableLayoutPanel2.Controls.Add(Me.textBoxEmail, 1, 8)
		Me.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tableLayoutPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.tableLayoutPanel2.Location = New System.Drawing.Point(86, 3)
		Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
		Me.tableLayoutPanel2.RowCount = 9
		Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F))
		Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F))
		Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F))
		Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F))
		Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F))
		Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F))
		Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F))
		Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F))
		Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F))
		Me.tableLayoutPanel2.Size = New System.Drawing.Size(494, 343)
		Me.tableLayoutPanel2.TabIndex = 0
		' 
		' labelTelefono
		' 
		Me.labelTelefono.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelTelefono.AutoSize = True
		Me.labelTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelTelefono.Location = New System.Drawing.Point(3, 235)
		Me.labelTelefono.Name = "labelTelefono"
		Me.labelTelefono.Size = New System.Drawing.Size(90, 24)
		Me.labelTelefono.TabIndex = 13
		Me.labelTelefono.Text = "Teléfono:"
		' 
		' labelPais
		' 
		Me.labelPais.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelPais.AutoSize = True
		Me.labelPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelPais.Location = New System.Drawing.Point(3, 197)
		Me.labelPais.Name = "labelPais"
		Me.labelPais.Size = New System.Drawing.Size(107, 24)
		Me.labelPais.TabIndex = 12
		Me.labelPais.Text = "País (GUA):"
		' 
		' labelRegion
		' 
		Me.labelRegion.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelRegion.AutoSize = True
		Me.labelRegion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelRegion.Location = New System.Drawing.Point(3, 159)
		Me.labelRegion.Name = "labelRegion"
		Me.labelRegion.Size = New System.Drawing.Size(76, 24)
		Me.labelRegion.TabIndex = 11
		Me.labelRegion.Text = "Región:"
		' 
		' labelCiudad
		' 
		Me.labelCiudad.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelCiudad.AutoSize = True
		Me.labelCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelCiudad.Location = New System.Drawing.Point(3, 121)
		Me.labelCiudad.Name = "labelCiudad"
		Me.labelCiudad.Size = New System.Drawing.Size(75, 24)
		Me.labelCiudad.TabIndex = 10
		Me.labelCiudad.Text = "Ciudad:"
		' 
		' labelDireccion
		' 
		Me.labelDireccion.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelDireccion.AutoSize = True
		Me.labelDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelDireccion.Location = New System.Drawing.Point(3, 83)
		Me.labelDireccion.Name = "labelDireccion"
		Me.labelDireccion.Size = New System.Drawing.Size(95, 24)
		Me.labelDireccion.TabIndex = 9
		Me.labelDireccion.Text = "Dirección:"
		' 
		' labelNombreContacto
		' 
		Me.labelNombreContacto.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelNombreContacto.AutoSize = True
		Me.labelNombreContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelNombreContacto.Location = New System.Drawing.Point(3, 45)
		Me.labelNombreContacto.Name = "labelNombreContacto"
		Me.labelNombreContacto.Size = New System.Drawing.Size(190, 24)
		Me.labelNombreContacto.TabIndex = 8
		Me.labelNombreContacto.Text = "Nombre de Contacto:"
		' 
		' textBoxNombreCliente
		' 
		Me.textBoxNombreCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxNombreCliente.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.textBoxNombreCliente.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxNombreCliente.Location = New System.Drawing.Point(214, 3)
		Me.textBoxNombreCliente.MaxLength = 50
		Me.textBoxNombreCliente.Name = "textBoxNombreCliente"
		Me.textBoxNombreCliente.Size = New System.Drawing.Size(277, 33)
		Me.textBoxNombreCliente.TabIndex = 0
		' 
		' textBoxNombreContacto
		' 
		Me.textBoxNombreContacto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxNombreContacto.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.textBoxNombreContacto.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxNombreContacto.Location = New System.Drawing.Point(214, 41)
		Me.textBoxNombreContacto.MaxLength = 50
		Me.textBoxNombreContacto.Name = "textBoxNombreContacto"
		Me.textBoxNombreContacto.Size = New System.Drawing.Size(277, 33)
		Me.textBoxNombreContacto.TabIndex = 1
		' 
		' textBoxDireccion
		' 
		Me.textBoxDireccion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxDireccion.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.textBoxDireccion.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxDireccion.Location = New System.Drawing.Point(214, 79)
		Me.textBoxDireccion.MaxLength = 50
		Me.textBoxDireccion.Name = "textBoxDireccion"
		Me.textBoxDireccion.Size = New System.Drawing.Size(277, 33)
		Me.textBoxDireccion.TabIndex = 2
		' 
		' textBoxCiudad
		' 
		Me.textBoxCiudad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxCiudad.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.textBoxCiudad.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxCiudad.Location = New System.Drawing.Point(214, 117)
		Me.textBoxCiudad.MaxLength = 50
		Me.textBoxCiudad.Name = "textBoxCiudad"
		Me.textBoxCiudad.Size = New System.Drawing.Size(277, 33)
		Me.textBoxCiudad.TabIndex = 3
		' 
		' textBoxRegion
		' 
		Me.textBoxRegion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxRegion.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.textBoxRegion.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxRegion.Location = New System.Drawing.Point(214, 155)
		Me.textBoxRegion.MaxLength = 50
		Me.textBoxRegion.Name = "textBoxRegion"
		Me.textBoxRegion.Size = New System.Drawing.Size(277, 33)
		Me.textBoxRegion.TabIndex = 4
		' 
		' textBoxPais
		' 
		Me.textBoxPais.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxPais.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.textBoxPais.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxPais.Location = New System.Drawing.Point(214, 193)
		Me.textBoxPais.MaxLength = 50
		Me.textBoxPais.Name = "textBoxPais"
		Me.textBoxPais.Size = New System.Drawing.Size(277, 33)
		Me.textBoxPais.TabIndex = 5
		' 
		' textBoxTelefono
		' 
		Me.textBoxTelefono.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxTelefono.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.textBoxTelefono.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxTelefono.Location = New System.Drawing.Point(214, 231)
		Me.textBoxTelefono.MaxLength = 50
		Me.textBoxTelefono.Name = "textBoxTelefono"
		Me.textBoxTelefono.Size = New System.Drawing.Size(277, 33)
		Me.textBoxTelefono.TabIndex = 6
		' 
		' labelNombreCliente
		' 
		Me.labelNombreCliente.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelNombreCliente.AutoSize = True
		Me.labelNombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelNombreCliente.Location = New System.Drawing.Point(3, 7)
		Me.labelNombreCliente.Name = "labelNombreCliente"
		Me.labelNombreCliente.Size = New System.Drawing.Size(204, 24)
		Me.labelNombreCliente.TabIndex = 7
		Me.labelNombreCliente.Text = "Nombre de Proveedor:"
		' 
		' labelFax
		' 
		Me.labelFax.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelFax.AutoSize = True
		Me.labelFax.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelFax.Location = New System.Drawing.Point(3, 273)
		Me.labelFax.Name = "labelFax"
		Me.labelFax.Size = New System.Drawing.Size(47, 24)
		Me.labelFax.TabIndex = 14
		Me.labelFax.Text = "Fax:"
		' 
		' labelEmail
		' 
		Me.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelEmail.AutoSize = True
		Me.labelEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelEmail.Location = New System.Drawing.Point(3, 311)
		Me.labelEmail.Name = "labelEmail"
		Me.labelEmail.Size = New System.Drawing.Size(62, 24)
		Me.labelEmail.TabIndex = 15
		Me.labelEmail.Text = "Email:"
		' 
		' textBoxFax
		' 
		Me.textBoxFax.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxFax.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.textBoxFax.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxFax.Location = New System.Drawing.Point(214, 269)
		Me.textBoxFax.MaxLength = 50
		Me.textBoxFax.Name = "textBoxFax"
		Me.textBoxFax.Size = New System.Drawing.Size(277, 33)
		Me.textBoxFax.TabIndex = 7
		' 
		' textBoxEmail
		' 
		Me.textBoxEmail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxEmail.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.textBoxEmail.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxEmail.Location = New System.Drawing.Point(214, 307)
		Me.textBoxEmail.MaxLength = 50
		Me.textBoxEmail.Name = "textBoxEmail"
		Me.textBoxEmail.Size = New System.Drawing.Size(277, 33)
		Me.textBoxEmail.TabIndex = 9
		' 
		' panel1
		' 
		Me.panel1.BackgroundImage = Global.CapaPresentacion.Properties.Resources.clientes
		Me.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.panel1.Location = New System.Drawing.Point(3, 6)
		Me.panel1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(76, 75)
		Me.panel1.TabIndex = 1
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
		Me.tableLayoutPanel3.Location = New System.Drawing.Point(88, 355)
		Me.tableLayoutPanel3.Name = "tableLayoutPanel3"
		Me.tableLayoutPanel3.RowCount = 1
		Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
		Me.tableLayoutPanel3.Size = New System.Drawing.Size(497, 39)
		Me.tableLayoutPanel3.TabIndex = 1
		' 
		' buttonGuardar
		' 
		Me.buttonGuardar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonGuardar.BackColor = System.Drawing.Color.LightSkyBlue
		Me.buttonGuardar.Font = New System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.buttonGuardar.Location = New System.Drawing.Point(28, 0)
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
		Me.buttonCancelar.Location = New System.Drawing.Point(253, 0)
		Me.buttonCancelar.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
		Me.buttonCancelar.Name = "buttonCancelar"
		Me.buttonCancelar.Size = New System.Drawing.Size(215, 39)
		Me.buttonCancelar.TabIndex = 1
		Me.buttonCancelar.Text = "Cancelar"
		Me.buttonCancelar.UseVisualStyleBackColor = False
		AddHandler Me.buttonCancelar.Click, New System.EventHandler(AddressOf Me.buttonCancelar_Click)
		' 
		' FrmAgregarNuevoProveedor
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(592, 413)
		Me.Controls.Add(Me.tableLayoutPanel3)
		Me.Controls.Add(Me.tableLayoutPanel1)
		Me.MaximumSize = New System.Drawing.Size(600, 440)
		Me.MinimizeBox = False
		Me.MinimumSize = New System.Drawing.Size(600, 440)
		Me.Name = "FrmAgregarNuevoProveedor"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Agregar Nuevo Proveedor"
		Me.tableLayoutPanel1.ResumeLayout(False)
		Me.tableLayoutPanel2.ResumeLayout(False)
		Me.tableLayoutPanel2.PerformLayout()
		Me.tableLayoutPanel3.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Private tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
	Private labelTelefono As System.Windows.Forms.Label
	Private labelPais As System.Windows.Forms.Label
	Private labelRegion As System.Windows.Forms.Label
	Private labelCiudad As System.Windows.Forms.Label
	Private labelDireccion As System.Windows.Forms.Label
	Private labelNombreContacto As System.Windows.Forms.Label
	Private textBoxNombreCliente As System.Windows.Forms.TextBox
	Private textBoxNombreContacto As System.Windows.Forms.TextBox
	Private textBoxDireccion As System.Windows.Forms.TextBox
	Private textBoxCiudad As System.Windows.Forms.TextBox
	Private textBoxRegion As System.Windows.Forms.TextBox
	Private textBoxPais As System.Windows.Forms.TextBox
	Private textBoxTelefono As System.Windows.Forms.TextBox
	Private labelNombreCliente As System.Windows.Forms.Label
	Private panel1 As System.Windows.Forms.Panel
	Private tableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
	Private buttonGuardar As System.Windows.Forms.Button
	Private buttonCancelar As System.Windows.Forms.Button
	Private labelFax As System.Windows.Forms.Label
	Private labelEmail As System.Windows.Forms.Label
	Private textBoxFax As System.Windows.Forms.TextBox
	Private textBoxEmail As System.Windows.Forms.TextBox

End Class
