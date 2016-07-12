<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fr_PagosAbonos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.txCredito = New System.Windows.Forms.TextBox()
        Me.txDebito = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdia = New System.Windows.Forms.TextBox()
        Me.txNombre = New System.Windows.Forms.TextBox()
        Me.txIdProveedor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPagosAbonos = New System.Windows.Forms.Button()
        Me.btNotasCredito = New System.Windows.Forms.Button()
        Me.btNotasDebito = New System.Windows.Forms.Button()
        Me.btAnulacion = New System.Windows.Forms.Button()
        Me.btEstadoCuenta = New System.Windows.Forms.Button()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btBuscar)
        Me.GroupBox1.Controls.Add(Me.txtSaldo)
        Me.GroupBox1.Controls.Add(Me.txCredito)
        Me.GroupBox1.Controls.Add(Me.txDebito)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtdia)
        Me.GroupBox1.Controls.Add(Me.txNombre)
        Me.GroupBox1.Controls.Add(Me.txIdProveedor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(686, 261)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Creditos Acumulados"
        '
        'btBuscar
        '
        Me.btBuscar.Location = New System.Drawing.Point(309, 21)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(160, 23)
        Me.btBuscar.TabIndex = 12
        Me.btBuscar.Text = "Buscar"
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'txtSaldo
        '
        Me.txtSaldo.Location = New System.Drawing.Point(403, 208)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(144, 20)
        Me.txtSaldo.TabIndex = 11
        '
        'txCredito
        '
        Me.txCredito.Location = New System.Drawing.Point(205, 208)
        Me.txCredito.Name = "txCredito"
        Me.txCredito.Size = New System.Drawing.Size(144, 20)
        Me.txCredito.TabIndex = 10
        '
        'txDebito
        '
        Me.txDebito.Location = New System.Drawing.Point(27, 208)
        Me.txDebito.Name = "txDebito"
        Me.txDebito.Size = New System.Drawing.Size(144, 20)
        Me.txDebito.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(435, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Saldo Actual:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(213, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Datos de la Cuenta:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Debitos Acumulados:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Datos de la Cuenta:"
        '
        'txtdia
        '
        Me.txtdia.Location = New System.Drawing.Point(529, 72)
        Me.txtdia.Name = "txtdia"
        Me.txtdia.Size = New System.Drawing.Size(144, 20)
        Me.txtdia.TabIndex = 4
        '
        'txNombre
        '
        Me.txNombre.Location = New System.Drawing.Point(142, 69)
        Me.txNombre.Name = "txNombre"
        Me.txNombre.Size = New System.Drawing.Size(253, 20)
        Me.txNombre.TabIndex = 4
        '
        'txIdProveedor
        '
        Me.txIdProveedor.Location = New System.Drawing.Point(142, 24)
        Me.txIdProveedor.Name = "txIdProveedor"
        Me.txIdProveedor.Size = New System.Drawing.Size(144, 20)
        Me.txIdProveedor.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(431, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dias de Credito"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clave del Proveedor"
        '
        'btnPagosAbonos
        '
        Me.btnPagosAbonos.Location = New System.Drawing.Point(34, 376)
        Me.btnPagosAbonos.Name = "btnPagosAbonos"
        Me.btnPagosAbonos.Size = New System.Drawing.Size(94, 78)
        Me.btnPagosAbonos.TabIndex = 1
        Me.btnPagosAbonos.Text = "Pagos o Abonos"
        Me.btnPagosAbonos.UseVisualStyleBackColor = True
        '
        'btNotasCredito
        '
        Me.btNotasCredito.Location = New System.Drawing.Point(134, 376)
        Me.btNotasCredito.Name = "btNotasCredito"
        Me.btNotasCredito.Size = New System.Drawing.Size(94, 78)
        Me.btNotasCredito.TabIndex = 2
        Me.btNotasCredito.Text = "Notas de Credito"
        Me.btNotasCredito.UseVisualStyleBackColor = True
        '
        'btNotasDebito
        '
        Me.btNotasDebito.Location = New System.Drawing.Point(234, 376)
        Me.btNotasDebito.Name = "btNotasDebito"
        Me.btNotasDebito.Size = New System.Drawing.Size(94, 78)
        Me.btNotasDebito.TabIndex = 3
        Me.btNotasDebito.Text = "Notas de Debito"
        Me.btNotasDebito.UseVisualStyleBackColor = True
        '
        'btAnulacion
        '
        Me.btAnulacion.Location = New System.Drawing.Point(334, 376)
        Me.btAnulacion.Name = "btAnulacion"
        Me.btAnulacion.Size = New System.Drawing.Size(94, 78)
        Me.btAnulacion.TabIndex = 4
        Me.btAnulacion.Text = "Anulaciones"
        Me.btAnulacion.UseVisualStyleBackColor = True
        '
        'btEstadoCuenta
        '
        Me.btEstadoCuenta.Location = New System.Drawing.Point(436, 376)
        Me.btEstadoCuenta.Name = "btEstadoCuenta"
        Me.btEstadoCuenta.Size = New System.Drawing.Size(94, 78)
        Me.btEstadoCuenta.TabIndex = 5
        Me.btEstadoCuenta.Text = "Estado de la Cuenta"
        Me.btEstadoCuenta.UseVisualStyleBackColor = True
        '
        'btSalir
        '
        Me.btSalir.Location = New System.Drawing.Point(536, 376)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(94, 78)
        Me.btSalir.TabIndex = 7
        Me.btSalir.Text = "Salir"
        Me.btSalir.UseVisualStyleBackColor = True
        '
        'fr_PagosAbonos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 526)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.btEstadoCuenta)
        Me.Controls.Add(Me.btAnulacion)
        Me.Controls.Add(Me.btNotasDebito)
        Me.Controls.Add(Me.btNotasCredito)
        Me.Controls.Add(Me.btnPagosAbonos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "fr_PagosAbonos"
        Me.Text = "Pagos y/o Abonos a Proveedores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btBuscar As Button
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents txCredito As TextBox
    Friend WithEvents txDebito As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtdia As TextBox
    Friend WithEvents txNombre As TextBox
    Friend WithEvents txIdProveedor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPagosAbonos As Button
    Friend WithEvents btNotasCredito As Button
    Friend WithEvents btNotasDebito As Button
    Friend WithEvents btAnulacion As Button
    Friend WithEvents btEstadoCuenta As Button
    Friend WithEvents btSalir As Button
End Class
