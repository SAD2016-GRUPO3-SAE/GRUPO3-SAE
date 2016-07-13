Partial Class FrmMarcarEntregado
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
		Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.labelNombre = New System.Windows.Forms.Label()
		Me.buttonHoy = New System.Windows.Forms.Button()
		Me.buttonFecha = New System.Windows.Forms.Button()
		Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.textBoxHoy = New System.Windows.Forms.TextBox()
		Me.dateTimePickerMarcarFecha = New System.Windows.Forms.DateTimePicker()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.tableLayoutPanel2.SuspendLayout()
		Me.tableLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		' 
		' tableLayoutPanel2
		' 
		Me.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.tableLayoutPanel2.ColumnCount = 1
		Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.59136F))
		Me.tableLayoutPanel2.Controls.Add(Me.labelNombre, 0, 0)
		Me.tableLayoutPanel2.Location = New System.Drawing.Point(80, 2)
		Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
		Me.tableLayoutPanel2.RowCount = 1
		Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F))
		Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F))
		Me.tableLayoutPanel2.Size = New System.Drawing.Size(403, 75)
		Me.tableLayoutPanel2.TabIndex = 2
		' 
		' labelNombre
		' 
		Me.labelNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.labelNombre.AutoSize = True
		Me.labelNombre.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelNombre.Location = New System.Drawing.Point(5, 24)
		Me.labelNombre.Margin = New System.Windows.Forms.Padding(5, 0, 3, 0)
		Me.labelNombre.Name = "labelNombre"
		Me.labelNombre.Size = New System.Drawing.Size(395, 26)
		Me.labelNombre.TabIndex = 1
		Me.labelNombre.Text = "NNN"
		Me.labelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		' 
		' buttonHoy
		' 
		Me.buttonHoy.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.buttonHoy.BackColor = System.Drawing.Color.LightSkyBlue
		Me.buttonHoy.Font = New System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.buttonHoy.Location = New System.Drawing.Point(188, 38)
		Me.buttonHoy.Margin = New System.Windows.Forms.Padding(0)
		Me.buttonHoy.Name = "buttonHoy"
		Me.buttonHoy.Size = New System.Drawing.Size(215, 37)
		Me.buttonHoy.TabIndex = 3
		Me.buttonHoy.Text = "Hoy"
		Me.buttonHoy.UseVisualStyleBackColor = False
		AddHandler Me.buttonHoy.Click, New System.EventHandler(AddressOf Me.buttonHoy_Click)
		' 
		' buttonFecha
		' 
		Me.buttonFecha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonFecha.BackColor = System.Drawing.Color.LightSkyBlue
		Me.buttonFecha.Font = New System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.buttonFecha.Location = New System.Drawing.Point(188, 0)
		Me.buttonFecha.Margin = New System.Windows.Forms.Padding(0)
		Me.buttonFecha.Name = "buttonFecha"
		Me.buttonFecha.Size = New System.Drawing.Size(215, 38)
		Me.buttonFecha.TabIndex = 1
		Me.buttonFecha.Text = "Fecha"
		Me.buttonFecha.UseVisualStyleBackColor = False
		AddHandler Me.buttonFecha.Click, New System.EventHandler(AddressOf Me.buttonFecha_Click)
		' 
		' tableLayoutPanel1
		' 
		Me.tableLayoutPanel1.ColumnCount = 2
		Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188F))
		Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F))
		Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F))
		Me.tableLayoutPanel1.Controls.Add(Me.buttonHoy, 1, 1)
		Me.tableLayoutPanel1.Controls.Add(Me.buttonFecha, 1, 0)
		Me.tableLayoutPanel1.Controls.Add(Me.textBoxHoy, 0, 1)
		Me.tableLayoutPanel1.Controls.Add(Me.dateTimePickerMarcarFecha, 0, 0)
		Me.tableLayoutPanel1.Location = New System.Drawing.Point(80, 79)
		Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
		Me.tableLayoutPanel1.RowCount = 2
		Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.66667F))
		Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.33333F))
		Me.tableLayoutPanel1.Size = New System.Drawing.Size(403, 75)
		Me.tableLayoutPanel1.TabIndex = 2
		' 
		' textBoxHoy
		' 
		Me.textBoxHoy.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxHoy.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxHoy.Location = New System.Drawing.Point(3, 41)
		Me.textBoxHoy.Name = "textBoxHoy"
		Me.textBoxHoy.[ReadOnly] = True
		Me.textBoxHoy.Size = New System.Drawing.Size(182, 31)
		Me.textBoxHoy.TabIndex = 2
		' 
		' dateTimePickerMarcarFecha
		' 
		Me.dateTimePickerMarcarFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.dateTimePickerMarcarFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dateTimePickerMarcarFecha.Location = New System.Drawing.Point(3, 3)
		Me.dateTimePickerMarcarFecha.Name = "dateTimePickerMarcarFecha"
		Me.dateTimePickerMarcarFecha.Size = New System.Drawing.Size(182, 31)
		Me.dateTimePickerMarcarFecha.TabIndex = 0
		' 
		' panel1
		' 
		Me.panel1.BackgroundImage = Global.CapaPresentacion.Properties.Resources.entregado
		Me.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.panel1.Location = New System.Drawing.Point(2, 2)
		Me.panel1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(76, 75)
		Me.panel1.TabIndex = 1
		' 
		' FrmMarcarEntregado
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(494, 167)
		Me.Controls.Add(Me.tableLayoutPanel1)
		Me.Controls.Add(Me.panel1)
		Me.Controls.Add(Me.tableLayoutPanel2)
		Me.MaximizeBox = False
		Me.MaximumSize = New System.Drawing.Size(502, 194)
		Me.MinimizeBox = False
		Me.MinimumSize = New System.Drawing.Size(502, 194)
		Me.Name = "FrmMarcarEntregado"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Marcar Pedido Pendiente como Entregado"
		Me.tableLayoutPanel2.ResumeLayout(False)
		Me.tableLayoutPanel2.PerformLayout()
		Me.tableLayoutPanel1.ResumeLayout(False)
		Me.tableLayoutPanel1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private panel1 As System.Windows.Forms.Panel
	Private buttonFecha As System.Windows.Forms.Button
	Private buttonHoy As System.Windows.Forms.Button
	Private tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
	Private labelNombre As System.Windows.Forms.Label
	Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Private textBoxHoy As System.Windows.Forms.TextBox
	Private dateTimePickerMarcarFecha As System.Windows.Forms.DateTimePicker

End Class
