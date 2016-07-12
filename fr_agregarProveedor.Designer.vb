<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fr_agregarProveedor
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txnombre = New System.Windows.Forms.TextBox()
        Me.txDireccio = New System.Windows.Forms.TextBox()
        Me.txTelefono = New System.Windows.Forms.TextBox()
        Me.txCorreo = New System.Windows.Forms.TextBox()
        Me.btIngresar = New System.Windows.Forms.Button()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ingrese el No. Telefono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ingrese la Direcciòn"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ingrese el Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ingrese Correo Electronico"
        '
        'txnombre
        '
        Me.txnombre.Location = New System.Drawing.Point(248, 98)
        Me.txnombre.Name = "txnombre"
        Me.txnombre.Size = New System.Drawing.Size(303, 20)
        Me.txnombre.TabIndex = 5
        '
        'txDireccio
        '
        Me.txDireccio.Location = New System.Drawing.Point(248, 135)
        Me.txDireccio.Name = "txDireccio"
        Me.txDireccio.Size = New System.Drawing.Size(303, 20)
        Me.txDireccio.TabIndex = 6
        '
        'txTelefono
        '
        Me.txTelefono.Location = New System.Drawing.Point(248, 176)
        Me.txTelefono.Name = "txTelefono"
        Me.txTelefono.Size = New System.Drawing.Size(303, 20)
        Me.txTelefono.TabIndex = 7
        '
        'txCorreo
        '
        Me.txCorreo.Location = New System.Drawing.Point(248, 215)
        Me.txCorreo.Name = "txCorreo"
        Me.txCorreo.Size = New System.Drawing.Size(303, 20)
        Me.txCorreo.TabIndex = 8
        '
        'btIngresar
        '
        Me.btIngresar.Location = New System.Drawing.Point(136, 288)
        Me.btIngresar.Name = "btIngresar"
        Me.btIngresar.Size = New System.Drawing.Size(180, 23)
        Me.btIngresar.TabIndex = 9
        Me.btIngresar.Text = "Ingresar Nuevo"
        Me.btIngresar.UseVisualStyleBackColor = True
        '
        'btSalir
        '
        Me.btSalir.Location = New System.Drawing.Point(419, 288)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(144, 23)
        Me.btSalir.TabIndex = 10
        Me.btSalir.Text = "Salir"
        Me.btSalir.UseVisualStyleBackColor = True
        '
        'fr_agregarProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 387)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.btIngresar)
        Me.Controls.Add(Me.txCorreo)
        Me.Controls.Add(Me.txTelefono)
        Me.Controls.Add(Me.txDireccio)
        Me.Controls.Add(Me.txnombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "fr_agregarProveedor"
        Me.Text = "Agrega Proveedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txnombre As TextBox
    Friend WithEvents txDireccio As TextBox
    Friend WithEvents txTelefono As TextBox
    Friend WithEvents txCorreo As TextBox
    Friend WithEvents btIngresar As Button
    Friend WithEvents btSalir As Button
End Class
