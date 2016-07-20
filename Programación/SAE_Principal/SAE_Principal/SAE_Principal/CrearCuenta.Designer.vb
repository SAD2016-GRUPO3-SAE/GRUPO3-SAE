<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CrearCuenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.socio_negocio_box = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NoCuotas = New System.Windows.Forms.ComboBox()
        Me.periodo = New System.Windows.Forms.ComboBox()
        Me.NoFactura = New System.Windows.Forms.ComboBox()
        Me.identificador = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.fecha_inicio = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.saldo_inicial = New System.Windows.Forms.TextBox()
        Me.iva = New System.Windows.Forms.TextBox()
        Me.Abono = New System.Windows.Forms.TextBox()
        Me.total_credito = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.descripcion = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.fecha_final = New System.Windows.Forms.Label()
        Me.fecha_vencimiento = New System.Windows.Forms.DateTimePicker()
        Me.TabControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Razon Social:"
        '
        'socio_negocio_box
        '
        Me.socio_negocio_box.FormattingEnabled = True
        Me.socio_negocio_box.Location = New System.Drawing.Point(167, 83)
        Me.socio_negocio_box.Name = "socio_negocio_box"
        Me.socio_negocio_box.Size = New System.Drawing.Size(121, 21)
        Me.socio_negocio_box.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(93, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Identificador:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Fecha de inicio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(78, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Numero Cuotas:"
        '
        'NoCuotas
        '
        Me.NoCuotas.FormattingEnabled = True
        Me.NoCuotas.Items.AddRange(New Object() {"3", "6", "12"})
        Me.NoCuotas.Location = New System.Drawing.Point(167, 169)
        Me.NoCuotas.Name = "NoCuotas"
        Me.NoCuotas.Size = New System.Drawing.Size(121, 21)
        Me.NoCuotas.TabIndex = 5
        '
        'periodo
        '
        Me.periodo.FormattingEnabled = True
        Me.periodo.Items.AddRange(New Object() {"QUINCENAL", "MENSUAL"})
        Me.periodo.Location = New System.Drawing.Point(167, 196)
        Me.periodo.Name = "periodo"
        Me.periodo.Size = New System.Drawing.Size(121, 21)
        Me.periodo.TabIndex = 6
        '
        'NoFactura
        '
        Me.NoFactura.FormattingEnabled = True
        Me.NoFactura.Location = New System.Drawing.Point(421, 83)
        Me.NoFactura.Name = "NoFactura"
        Me.NoFactura.Size = New System.Drawing.Size(121, 21)
        Me.NoFactura.TabIndex = 7
        '
        'identificador
        '
        Me.identificador.Location = New System.Drawing.Point(167, 112)
        Me.identificador.Name = "identificador"
        Me.identificador.Size = New System.Drawing.Size(121, 20)
        Me.identificador.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(348, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "No. Factura:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(348, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Saldo Inicial:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(387, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "IVA:"
        '
        'fecha_inicio
        '
        Me.fecha_inicio.Location = New System.Drawing.Point(167, 140)
        Me.fecha_inicio.Name = "fecha_inicio"
        Me.fecha_inicio.Size = New System.Drawing.Size(121, 20)
        Me.fecha_inicio.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(84, 199)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Tipo de Cobro:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(86, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(277, 29)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Crear Cuenta por Cobrar"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(369, 172)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Abono:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(353, 199)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Total Credito:"
        '
        'saldo_inicial
        '
        Me.saldo_inicial.Location = New System.Drawing.Point(421, 112)
        Me.saldo_inicial.Name = "saldo_inicial"
        Me.saldo_inicial.Size = New System.Drawing.Size(100, 20)
        Me.saldo_inicial.TabIndex = 19
        '
        'iva
        '
        Me.iva.Location = New System.Drawing.Point(420, 140)
        Me.iva.Name = "iva"
        Me.iva.Size = New System.Drawing.Size(100, 20)
        Me.iva.TabIndex = 20
        '
        'Abono
        '
        Me.Abono.Location = New System.Drawing.Point(421, 170)
        Me.Abono.Name = "Abono"
        Me.Abono.Size = New System.Drawing.Size(100, 20)
        Me.Abono.TabIndex = 21
        '
        'total_credito
        '
        Me.total_credito.Location = New System.Drawing.Point(420, 196)
        Me.total_credito.Name = "total_credito"
        Me.total_credito.Size = New System.Drawing.Size(100, 20)
        Me.total_credito.TabIndex = 22
        '
        'TabControl1
        '
        Me.TabControl1.AccessibleName = ""
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(2, 331)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(643, 151)
        Me.TabControl1.TabIndex = 23
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(635, 125)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Estado de Cuenta"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(635, 125)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Cuentas por Cobrar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(2, 488)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(643, 89)
        Me.Panel1.TabIndex = 24
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(437, 68)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 13)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Cancelar"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.SAE_Principal.My.Resources.Resources.close2
        Me.PictureBox4.Location = New System.Drawing.Point(428, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(64, 60)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(510, 68)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Guardar"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.SAE_Principal.My.Resources.Resources.Floppy_disk_512
        Me.PictureBox3.Location = New System.Drawing.Point(498, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(65, 60)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(591, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(27, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Salir"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SAE_Principal.My.Resources.Resources.inside
        Me.PictureBox2.Location = New System.Drawing.Point(569, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(65, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(95, 271)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Descripción:"
        '
        'descripcion
        '
        Me.descripcion.Location = New System.Drawing.Point(167, 271)
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(352, 54)
        Me.descripcion.TabIndex = 26
        Me.descripcion.Text = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SAE_Principal.My.Resources.Resources.phonebook1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'fecha_final
        '
        Me.fecha_final.AutoSize = True
        Me.fecha_final.Location = New System.Drawing.Point(46, 230)
        Me.fecha_final.Name = "fecha_final"
        Me.fecha_final.Size = New System.Drawing.Size(115, 13)
        Me.fecha_final.TabIndex = 27
        Me.fecha_final.Text = "Fecha de vencimiento:"
        '
        'fecha_vencimiento
        '
        Me.fecha_vencimiento.Location = New System.Drawing.Point(167, 230)
        Me.fecha_vencimiento.Name = "fecha_vencimiento"
        Me.fecha_vencimiento.Size = New System.Drawing.Size(121, 20)
        Me.fecha_vencimiento.TabIndex = 28
        '
        'CrearCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 579)
        Me.Controls.Add(Me.fecha_vencimiento)
        Me.Controls.Add(Me.fecha_final)
        Me.Controls.Add(Me.descripcion)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.total_credito)
        Me.Controls.Add(Me.Abono)
        Me.Controls.Add(Me.iva)
        Me.Controls.Add(Me.saldo_inicial)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.fecha_inicio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.identificador)
        Me.Controls.Add(Me.NoFactura)
        Me.Controls.Add(Me.periodo)
        Me.Controls.Add(Me.NoCuotas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.socio_negocio_box)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CrearCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Crear Cuenta"
        Me.TabControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents socio_negocio_box As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NoCuotas As ComboBox
    Friend WithEvents periodo As ComboBox
    Friend WithEvents NoFactura As ComboBox
    Friend WithEvents identificador As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents fecha_inicio As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents saldo_inicial As TextBox
    Friend WithEvents iva As TextBox
    Friend WithEvents Abono As TextBox
    Friend WithEvents total_credito As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents descripcion As RichTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents fecha_final As Label
    Friend WithEvents fecha_vencimiento As DateTimePicker
End Class
