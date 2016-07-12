Partial Class FrmAgregarNuevoEmpleado
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
		Me.labelApellido = New System.Windows.Forms.Label()
		Me.textBoxNombre = New System.Windows.Forms.TextBox()
		Me.textBoxApellido = New System.Windows.Forms.TextBox()
		Me.textBoxDireccion = New System.Windows.Forms.TextBox()
		Me.textBoxCiudad = New System.Windows.Forms.TextBox()
		Me.textBoxRegion = New System.Windows.Forms.TextBox()
		Me.textBoxPais = New System.Windows.Forms.TextBox()
		Me.textBoxTelefono = New System.Windows.Forms.TextBox()
		Me.labelNombre = New System.Windows.Forms.Label()
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
		Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.91753F))
		Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.08247F))
		Me.tableLayoutPanel1.Controls.Add(Me.tableLayoutPanel2, 1, 0)
		Me.tableLayoutPanel1.Controls.Add(Me.panel1, 0, 0)
		Me.tableLayoutPanel1.Location = New System.Drawing.Point(2, 2)
		Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
		Me.tableLayoutPanel1.RowCount = 1
		Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanel1.Size = New System.Drawing.Size(582, 273)
		Me.tableLayoutPanel1.TabIndex = 0
		' 
		' tableLayoutPanel2
		' 
		Me.tableLayoutPanel2.ColumnCount = 2
		Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.77079F))
		Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.22921F))
		Me.tableLayoutPanel2.Controls.Add(Me.labelTelefono, 0, 6)
		Me.tableLayoutPanel2.Controls.Add(Me.labelPais, 0, 5)
		Me.tableLayoutPanel2.Controls.Add(Me.labelRegion, 0, 4)
		Me.tableLayoutPanel2.Controls.Add(Me.labelCiudad, 0, 3)
		Me.tableLayoutPanel2.Controls.Add(Me.labelDireccion, 0, 2)
		Me.tableLayoutPanel2.Controls.Add(Me.labelApellido, 0, 1)
		Me.tableLayoutPanel2.Controls.Add(Me.textBoxNombre, 1, 0)
		Me.tableLayoutPanel2.Controls.Add(Me.textBoxApellido, 1, 1)
		Me.tableLayoutPanel2.Controls.Add(Me.textBoxDireccion, 1, 2)
		Me.tableLayoutPanel2.Controls.Add(Me.textBoxCiudad, 1, 3)
		Me.tableLayoutPanel2.Controls.Add(Me.textBoxRegion, 1, 4)
		Me.tableLayoutPanel2.Controls.Add(Me.textBoxPais, 1, 5)
		Me.tableLayoutPanel2.Controls.Add(Me.textBoxTelefono, 1, 6)
		Me.tableLayoutPanel2.Controls.Add(Me.labelNombre, 0, 0)
		Me.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tableLayoutPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.tableLayoutPanel2.Location = New System.Drawing.Point(84, 3)
		Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
		Me.tableLayoutPanel2.RowCount = 7
		Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F))
		Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F))
		Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F))
		Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F))
		Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F))
		Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F))
		Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F))
		Me.tableLayoutPanel2.Size = New System.Drawing.Size(495, 267)
		Me.tableLayoutPanel2.TabIndex = 0
		' 
		' labelTelefono
		' 
		Me.labelTelefono.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelTelefono.AutoSize = True
		Me.labelTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelTelefono.ImageAlign = System.Drawing.ContentAlignment.TopCenter
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
		Me.labelPais.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.labelPais.Location = New System.Drawing.Point(3, 197)
		Me.labelPais.Name = "labelPais"
		Me.labelPais.Size = New System.Drawing.Size(180, 24)
		Me.labelPais.TabIndex = 12
		Me.labelPais.Text = "País (GUA - Default):"
		' 
		' labelRegion
		' 
		Me.labelRegion.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelRegion.AutoSize = True
		Me.labelRegion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelRegion.ImageAlign = System.Drawing.ContentAlignment.TopCenter
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
		Me.labelCiudad.ImageAlign = System.Drawing.ContentAlignment.TopCenter
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
		Me.labelDireccion.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.labelDireccion.Location = New System.Drawing.Point(3, 83)
		Me.labelDireccion.Name = "labelDireccion"
		Me.labelDireccion.Size = New System.Drawing.Size(95, 24)
		Me.labelDireccion.TabIndex = 9
		Me.labelDireccion.Text = "Dirección:"
		' 
		' labelApellido
		' 
		Me.labelApellido.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelApellido.AutoSize = True
		Me.labelApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelApellido.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.labelApellido.Location = New System.Drawing.Point(3, 45)
		Me.labelApellido.Name = "labelApellido"
		Me.labelApellido.Size = New System.Drawing.Size(84, 24)
		Me.labelApellido.TabIndex = 8
		Me.labelApellido.Text = "Apellido:"
		' 
		' textBoxNombre
		' 
		Me.textBoxNombre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxNombre.BackColor = System.Drawing.Color.White
		Me.textBoxNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxNombre.Location = New System.Drawing.Point(204, 3)
		Me.textBoxNombre.MaxLength = 50
		Me.textBoxNombre.Name = "textBoxNombre"
		Me.textBoxNombre.Size = New System.Drawing.Size(288, 29)
		Me.textBoxNombre.TabIndex = 0
		' 
		' textBoxApellido
		' 
		Me.textBoxApellido.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxApellido.BackColor = System.Drawing.Color.White
		Me.textBoxApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxApellido.Location = New System.Drawing.Point(204, 41)
		Me.textBoxApellido.MaxLength = 50
		Me.textBoxApellido.Name = "textBoxApellido"
		Me.textBoxApellido.Size = New System.Drawing.Size(288, 29)
		Me.textBoxApellido.TabIndex = 1
		' 
		' textBoxDireccion
		' 
		Me.textBoxDireccion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxDireccion.BackColor = System.Drawing.Color.White
		Me.textBoxDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxDireccion.Location = New System.Drawing.Point(204, 79)
		Me.textBoxDireccion.MaxLength = 50
		Me.textBoxDireccion.Name = "textBoxDireccion"
		Me.textBoxDireccion.Size = New System.Drawing.Size(288, 29)
		Me.textBoxDireccion.TabIndex = 2
		' 
		' textBoxCiudad
		' 
		Me.textBoxCiudad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxCiudad.BackColor = System.Drawing.Color.White
		Me.textBoxCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxCiudad.Location = New System.Drawing.Point(204, 117)
		Me.textBoxCiudad.MaxLength = 50
		Me.textBoxCiudad.Name = "textBoxCiudad"
		Me.textBoxCiudad.Size = New System.Drawing.Size(288, 29)
		Me.textBoxCiudad.TabIndex = 3
		' 
		' textBoxRegion
		' 
		Me.textBoxRegion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxRegion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxRegion.Location = New System.Drawing.Point(204, 155)
		Me.textBoxRegion.MaxLength = 50
		Me.textBoxRegion.Name = "textBoxRegion"
		Me.textBoxRegion.Size = New System.Drawing.Size(288, 29)
		Me.textBoxRegion.TabIndex = 4
		' 
		' textBoxPais
		' 
		Me.textBoxPais.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxPais.Location = New System.Drawing.Point(204, 193)
		Me.textBoxPais.MaxLength = 50
		Me.textBoxPais.Name = "textBoxPais"
		Me.textBoxPais.Size = New System.Drawing.Size(288, 29)
		Me.textBoxPais.TabIndex = 5
		' 
		' textBoxTelefono
		' 
		Me.textBoxTelefono.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxTelefono.Location = New System.Drawing.Point(204, 231)
		Me.textBoxTelefono.MaxLength = 50
		Me.textBoxTelefono.Name = "textBoxTelefono"
		Me.textBoxTelefono.Size = New System.Drawing.Size(288, 29)
		Me.textBoxTelefono.TabIndex = 6
		' 
		' labelNombre
		' 
		Me.labelNombre.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelNombre.AutoSize = True
		Me.labelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelNombre.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.labelNombre.Location = New System.Drawing.Point(3, 7)
		Me.labelNombre.Name = "labelNombre"
		Me.labelNombre.Size = New System.Drawing.Size(84, 24)
		Me.labelNombre.TabIndex = 7
		Me.labelNombre.Text = "Nombre:"
		' 
		' panel1
		' 
		Me.panel1.BackgroundImage = Global.CapaPresentacion.Properties.Resources.empleados
		Me.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.panel1.Location = New System.Drawing.Point(3, 6)
		Me.panel1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(75, 75)
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
		Me.tableLayoutPanel3.Location = New System.Drawing.Point(88, 277)
		Me.tableLayoutPanel3.Name = "tableLayoutPanel3"
		Me.tableLayoutPanel3.RowCount = 1
		Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
		Me.tableLayoutPanel3.Size = New System.Drawing.Size(496, 39)
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
		' FrmAgregarNuevoEmpleado
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(592, 333)
		Me.Controls.Add(Me.tableLayoutPanel3)
		Me.Controls.Add(Me.tableLayoutPanel1)
		Me.MaximizeBox = False
		Me.MaximumSize = New System.Drawing.Size(600, 360)
		Me.MinimizeBox = False
		Me.MinimumSize = New System.Drawing.Size(600, 360)
		Me.Name = "FrmAgregarNuevoEmpleado"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Agregar Nuevo Empleado"
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
	Private labelApellido As System.Windows.Forms.Label
	Private textBoxNombre As System.Windows.Forms.TextBox
	Private textBoxApellido As System.Windows.Forms.TextBox
	Private textBoxDireccion As System.Windows.Forms.TextBox
	Private textBoxCiudad As System.Windows.Forms.TextBox
	Private textBoxRegion As System.Windows.Forms.TextBox
	Private textBoxPais As System.Windows.Forms.TextBox
	Private textBoxTelefono As System.Windows.Forms.TextBox
	Private labelNombre As System.Windows.Forms.Label
	Private panel1 As System.Windows.Forms.Panel
	Private tableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
	Private buttonGuardar As System.Windows.Forms.Button
	Private buttonCancelar As System.Windows.Forms.Button

End Class
