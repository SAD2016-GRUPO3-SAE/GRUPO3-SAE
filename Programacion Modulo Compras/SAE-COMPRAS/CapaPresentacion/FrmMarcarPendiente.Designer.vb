Partial Class FrmMarcarPendiente
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
		Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.buttonCancelar = New System.Windows.Forms.Button()
		Me.buttonAceptar = New System.Windows.Forms.Button()
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
		Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F))
		Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F))
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
		' tableLayoutPanel1
		' 
		Me.tableLayoutPanel1.ColumnCount = 2
		Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 202F))
		Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 201F))
		Me.tableLayoutPanel1.Controls.Add(Me.buttonCancelar, 1, 0)
		Me.tableLayoutPanel1.Controls.Add(Me.buttonAceptar, 0, 0)
		Me.tableLayoutPanel1.Location = New System.Drawing.Point(80, 116)
		Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
		Me.tableLayoutPanel1.RowCount = 1
		Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
		Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F))
		Me.tableLayoutPanel1.Size = New System.Drawing.Size(403, 36)
		Me.tableLayoutPanel1.TabIndex = 2
		' 
		' buttonCancelar
		' 
		Me.buttonCancelar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.buttonCancelar.BackColor = System.Drawing.Color.Orange
		Me.buttonCancelar.Font = New System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.buttonCancelar.Location = New System.Drawing.Point(202, 0)
		Me.buttonCancelar.Margin = New System.Windows.Forms.Padding(0)
		Me.buttonCancelar.Name = "buttonCancelar"
		Me.buttonCancelar.Size = New System.Drawing.Size(201, 36)
		Me.buttonCancelar.TabIndex = 1
		Me.buttonCancelar.Text = "Cancelar"
		Me.buttonCancelar.UseVisualStyleBackColor = False
		AddHandler Me.buttonCancelar.Click, New System.EventHandler(AddressOf Me.buttonCancelar_Click)
		' 
		' buttonAceptar
		' 
		Me.buttonAceptar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonAceptar.BackColor = System.Drawing.Color.Orange
		Me.buttonAceptar.Font = New System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.buttonAceptar.Location = New System.Drawing.Point(0, 0)
		Me.buttonAceptar.Margin = New System.Windows.Forms.Padding(0)
		Me.buttonAceptar.Name = "buttonAceptar"
		Me.buttonAceptar.Size = New System.Drawing.Size(202, 36)
		Me.buttonAceptar.TabIndex = 0
		Me.buttonAceptar.Text = "Aceptar"
		Me.buttonAceptar.UseVisualStyleBackColor = False
		AddHandler Me.buttonAceptar.Click, New System.EventHandler(AddressOf Me.buttonAceptar_Click)
		' 
		' panel1
		' 
		Me.panel1.BackgroundImage = Global.CapaPresentacion.Properties.Resources.pendiente
		Me.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.panel1.Location = New System.Drawing.Point(2, 2)
		Me.panel1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(76, 75)
		Me.panel1.TabIndex = 1
		' 
		' FrmMarcarPendiente
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(486, 155)
		Me.Controls.Add(Me.tableLayoutPanel1)
		Me.Controls.Add(Me.panel1)
		Me.Controls.Add(Me.tableLayoutPanel2)
		Me.MaximizeBox = False
		Me.MaximumSize = New System.Drawing.Size(502, 194)
		Me.MinimizeBox = False
		Me.MinimumSize = New System.Drawing.Size(502, 194)
		Me.Name = "FrmMarcarPendiente"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Marcar Pedido Entregado como Pendiente"
		Me.tableLayoutPanel2.ResumeLayout(False)
		Me.tableLayoutPanel2.PerformLayout()
		Me.tableLayoutPanel1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private panel1 As System.Windows.Forms.Panel
	Private tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
	Private labelNombre As System.Windows.Forms.Label
	Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Private buttonCancelar As System.Windows.Forms.Button
	Private buttonAceptar As System.Windows.Forms.Button

End Class
