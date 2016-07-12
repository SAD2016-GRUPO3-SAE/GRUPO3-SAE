<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDISAE
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarDeEmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentasPorCobrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Location = New System.Drawing.Point(0, 354)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel1.Size = New System.Drawing.Size(908, 76)
        Me.Panel1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.VentasToolStripMenuItem, Me.CuentasPorCobrarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(908, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambiarDeEmpresaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'CambiarDeEmpresaToolStripMenuItem
        '
        Me.CambiarDeEmpresaToolStripMenuItem.Name = "CambiarDeEmpresaToolStripMenuItem"
        Me.CambiarDeEmpresaToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.CambiarDeEmpresaToolStripMenuItem.Text = "Cambiar de Empresa"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'CuentasPorCobrarToolStripMenuItem
        '
        Me.CuentasPorCobrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearCuentaToolStripMenuItem, Me.EditarCuentaToolStripMenuItem, Me.EliminarCuentaToolStripMenuItem, Me.BuscarCuentaToolStripMenuItem})
        Me.CuentasPorCobrarToolStripMenuItem.Name = "CuentasPorCobrarToolStripMenuItem"
        Me.CuentasPorCobrarToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.CuentasPorCobrarToolStripMenuItem.Text = "Cuentas por Cobrar"
        '
        'CrearCuentaToolStripMenuItem
        '
        Me.CrearCuentaToolStripMenuItem.Name = "CrearCuentaToolStripMenuItem"
        Me.CrearCuentaToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.CrearCuentaToolStripMenuItem.Text = "Crear cuenta"
        '
        'EditarCuentaToolStripMenuItem
        '
        Me.EditarCuentaToolStripMenuItem.Name = "EditarCuentaToolStripMenuItem"
        Me.EditarCuentaToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.EditarCuentaToolStripMenuItem.Text = "Editar Cuenta"
        '
        'EliminarCuentaToolStripMenuItem
        '
        Me.EliminarCuentaToolStripMenuItem.Name = "EliminarCuentaToolStripMenuItem"
        Me.EliminarCuentaToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.EliminarCuentaToolStripMenuItem.Text = "Eliminar Cuenta"
        '
        'BuscarCuentaToolStripMenuItem
        '
        Me.BuscarCuentaToolStripMenuItem.Name = "BuscarCuentaToolStripMenuItem"
        Me.BuscarCuentaToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.BuscarCuentaToolStripMenuItem.Text = "Buscar Cuenta"
        '
        'MDISAE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 429)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MDISAE"
        Me.Text = "SAE - Sistema de Administración Empresarial"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuentasPorCobrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarCuentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearCuentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarCuentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarCuentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CambiarDeEmpresaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
