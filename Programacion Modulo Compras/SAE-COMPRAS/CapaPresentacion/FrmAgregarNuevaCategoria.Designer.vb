Partial Class FrmAgregarNuevaCategoria
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
		Me.textBoxNombre = New System.Windows.Forms.TextBox()
		Me.labelNombre = New System.Windows.Forms.Label()
		Me.buttonCancelar = New System.Windows.Forms.Button()
		Me.buttonGuardar = New System.Windows.Forms.Button()
		Me.tableLayoutPanelGuardarCancelar = New System.Windows.Forms.TableLayoutPanel()
		Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.labelDescripcion = New System.Windows.Forms.Label()
		Me.textBoxDescripcion = New System.Windows.Forms.TextBox()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.tableLayoutPanel2.SuspendLayout()
		Me.tableLayoutPanelGuardarCancelar.SuspendLayout()
		Me.tableLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		' 
		' tableLayoutPanel2
		' 
		Me.tableLayoutPanel2.ColumnCount = 2
		Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.59136F))
		Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.40864F))
		Me.tableLayoutPanel2.Controls.Add(Me.textBoxNombre, 1, 0)
		Me.tableLayoutPanel2.Controls.Add(Me.labelNombre, 0, 0)
		Me.tableLayoutPanel2.Location = New System.Drawing.Point(83, 2)
		Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
		Me.tableLayoutPanel2.RowCount = 1
		Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F))
		Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F))
		Me.tableLayoutPanel2.Size = New System.Drawing.Size(501, 39)
		Me.tableLayoutPanel2.TabIndex = 0
		' 
		' textBoxNombre
		' 
		Me.textBoxNombre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxNombre.BackColor = System.Drawing.Color.White
		Me.textBoxNombre.Font = New System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxNombre.Location = New System.Drawing.Point(116, 3)
		Me.textBoxNombre.MaxLength = 50
		Me.textBoxNombre.Name = "textBoxNombre"
		Me.textBoxNombre.Size = New System.Drawing.Size(382, 33)
		Me.textBoxNombre.TabIndex = 0
		' 
		' labelNombre
		' 
		Me.labelNombre.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelNombre.AutoSize = True
		Me.labelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelNombre.Location = New System.Drawing.Point(5, 7)
		Me.labelNombre.Margin = New System.Windows.Forms.Padding(5, 0, 3, 0)
		Me.labelNombre.Name = "labelNombre"
		Me.labelNombre.Size = New System.Drawing.Size(91, 24)
		Me.labelNombre.TabIndex = 1
		Me.labelNombre.Text = "Nombre:"
		' 
		' buttonCancelar
		' 
		Me.buttonCancelar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.buttonCancelar.BackColor = System.Drawing.Color.LightSkyBlue
		Me.buttonCancelar.Font = New System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.buttonCancelar.Location = New System.Drawing.Point(255, 0)
		Me.buttonCancelar.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
		Me.buttonCancelar.Name = "buttonCancelar"
		Me.buttonCancelar.Size = New System.Drawing.Size(215, 39)
		Me.buttonCancelar.TabIndex = 1
		Me.buttonCancelar.Text = "Cancelar"
		Me.buttonCancelar.UseVisualStyleBackColor = False
		AddHandler Me.buttonCancelar.Click, New System.EventHandler(AddressOf Me.buttonCancelar_Click)
		' 
		' buttonGuardar
		' 
		Me.buttonGuardar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonGuardar.BackColor = System.Drawing.Color.LightSkyBlue
		Me.buttonGuardar.Font = New System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.buttonGuardar.Location = New System.Drawing.Point(30, 0)
		Me.buttonGuardar.Margin = New System.Windows.Forms.Padding(0, 0, 5, 0)
		Me.buttonGuardar.Name = "buttonGuardar"
		Me.buttonGuardar.Size = New System.Drawing.Size(215, 39)
		Me.buttonGuardar.TabIndex = 0
		Me.buttonGuardar.Text = "Guardar"
		Me.buttonGuardar.UseVisualStyleBackColor = False
		AddHandler Me.buttonGuardar.Click, New System.EventHandler(AddressOf Me.buttonGuardar_Click)
		' 
		' tableLayoutPanelGuardarCancelar
		' 
		Me.tableLayoutPanelGuardarCancelar.ColumnCount = 2
		Me.tableLayoutPanelGuardarCancelar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanelGuardarCancelar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanelGuardarCancelar.Controls.Add(Me.buttonCancelar, 1, 0)
		Me.tableLayoutPanelGuardarCancelar.Controls.Add(Me.buttonGuardar, 0, 0)
		Me.tableLayoutPanelGuardarCancelar.Location = New System.Drawing.Point(83, 204)
		Me.tableLayoutPanelGuardarCancelar.Name = "tableLayoutPanelGuardarCancelar"
		Me.tableLayoutPanelGuardarCancelar.RowCount = 1
		Me.tableLayoutPanelGuardarCancelar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanelGuardarCancelar.Size = New System.Drawing.Size(501, 39)
		Me.tableLayoutPanelGuardarCancelar.TabIndex = 2
		' 
		' tableLayoutPanel1
		' 
		Me.tableLayoutPanel1.ColumnCount = 1
		Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanel1.Controls.Add(Me.labelDescripcion, 0, 0)
		Me.tableLayoutPanel1.Controls.Add(Me.textBoxDescripcion, 0, 1)
		Me.tableLayoutPanel1.Location = New System.Drawing.Point(83, 44)
		Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
		Me.tableLayoutPanel1.RowCount = 2
		Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.35897F))
		Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.64103F))
		Me.tableLayoutPanel1.Size = New System.Drawing.Size(501, 156)
		Me.tableLayoutPanel1.TabIndex = 1
		' 
		' labelDescripcion
		' 
		Me.labelDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.labelDescripcion.AutoSize = True
		Me.labelDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelDescripcion.Location = New System.Drawing.Point(3, 6)
		Me.labelDescripcion.Name = "labelDescripcion"
		Me.labelDescripcion.Size = New System.Drawing.Size(127, 24)
		Me.labelDescripcion.TabIndex = 2
		Me.labelDescripcion.Text = "Descripción:"
		' 
		' textBoxDescripcion
		' 
		Me.textBoxDescripcion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.textBoxDescripcion.Location = New System.Drawing.Point(9, 40)
		Me.textBoxDescripcion.Margin = New System.Windows.Forms.Padding(9, 3, 3, 3)
		Me.textBoxDescripcion.MaxLength = 150
		Me.textBoxDescripcion.Multiline = True
		Me.textBoxDescripcion.Name = "textBoxDescripcion"
		Me.textBoxDescripcion.Size = New System.Drawing.Size(489, 113)
		Me.textBoxDescripcion.TabIndex = 1
		' 
		' panel1
		' 
		Me.panel1.BackgroundImage = Global.CapaPresentacion.Properties.Resources.categorias
		Me.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.panel1.Location = New System.Drawing.Point(2, 2)
		Me.panel1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(75, 75)
		Me.panel1.TabIndex = 1
		' 
		' FrmAgregarNuevaCategoria
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(592, 260)
		Me.Controls.Add(Me.tableLayoutPanel1)
		Me.Controls.Add(Me.panel1)
		Me.Controls.Add(Me.tableLayoutPanel2)
		Me.Controls.Add(Me.tableLayoutPanelGuardarCancelar)
		Me.MaximizeBox = False
		Me.MaximumSize = New System.Drawing.Size(600, 287)
		Me.MinimizeBox = False
		Me.MinimumSize = New System.Drawing.Size(600, 287)
		Me.Name = "FrmAgregarNuevaCategoria"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Agregar Nueva Categoria"
		Me.tableLayoutPanel2.ResumeLayout(False)
		Me.tableLayoutPanel2.PerformLayout()
		Me.tableLayoutPanelGuardarCancelar.ResumeLayout(False)
		Me.tableLayoutPanel1.ResumeLayout(False)
		Me.tableLayoutPanel1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private panel1 As System.Windows.Forms.Panel
	Private buttonGuardar As System.Windows.Forms.Button
	Private buttonCancelar As System.Windows.Forms.Button
	Private tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
	Private textBoxNombre As System.Windows.Forms.TextBox
	Private labelNombre As System.Windows.Forms.Label
	Private tableLayoutPanelGuardarCancelar As System.Windows.Forms.TableLayoutPanel
	Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Private labelDescripcion As System.Windows.Forms.Label
	Private textBoxDescripcion As System.Windows.Forms.TextBox

End Class
