<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fr_agregarOperacion
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txOperacion = New System.Windows.Forms.TextBox()
        Me.btIngresa = New System.Windows.Forms.Button()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txDescripcion = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese Una Operacion:"
        '
        'txOperacion
        '
        Me.txOperacion.Location = New System.Drawing.Point(226, 81)
        Me.txOperacion.Name = "txOperacion"
        Me.txOperacion.Size = New System.Drawing.Size(280, 20)
        Me.txOperacion.TabIndex = 1
        '
        'btIngresa
        '
        Me.btIngresa.Location = New System.Drawing.Point(582, 71)
        Me.btIngresa.Name = "btIngresa"
        Me.btIngresa.Size = New System.Drawing.Size(117, 23)
        Me.btIngresa.TabIndex = 2
        Me.btIngresa.Text = "Ingresar"
        Me.btIngresa.UseVisualStyleBackColor = True
        '
        'btBuscar
        '
        Me.btBuscar.Location = New System.Drawing.Point(44, 196)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(113, 23)
        Me.btBuscar.TabIndex = 3
        Me.btBuscar.Text = "Buscar "
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'btSalir
        '
        Me.btSalir.Location = New System.Drawing.Point(582, 115)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(117, 23)
        Me.btSalir.TabIndex = 4
        Me.btSalir.Text = "Salir"
        Me.btSalir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Ingrese una descripciòn"
        '
        'txDescripcion
        '
        Me.txDescripcion.Location = New System.Drawing.Point(226, 120)
        Me.txDescripcion.Name = "txDescripcion"
        Me.txDescripcion.Size = New System.Drawing.Size(280, 20)
        Me.txDescripcion.TabIndex = 6
        '
        'fr_agregarOperacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 307)
        Me.Controls.Add(Me.txDescripcion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.btBuscar)
        Me.Controls.Add(Me.btIngresa)
        Me.Controls.Add(Me.txOperacion)
        Me.Controls.Add(Me.Label1)
        Me.Name = "fr_agregarOperacion"
        Me.Text = "Ingrese la Nueva Operacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txOperacion As TextBox
    Friend WithEvents btIngresa As Button
    Friend WithEvents btBuscar As Button
    Friend WithEvents btSalir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txDescripcion As TextBox
End Class
