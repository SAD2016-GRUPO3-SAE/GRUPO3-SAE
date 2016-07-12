<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fr_eliminarActualizaProveedor
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
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txIdPro = New System.Windows.Forms.TextBox()
        Me.txCorre = New System.Windows.Forms.TextBox()
        Me.txTelefono = New System.Windows.Forms.TextBox()
        Me.txDireccion = New System.Windows.Forms.TextBox()
        Me.txNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btActualizar = New System.Windows.Forms.Button()
        Me.TblsaeproveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaeCpPDataSet1 = New Proyecto_sae.saeCpPDataSet1()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.Tbl_sae_proveedorTableAdapter = New Proyecto_sae.saeCpPDataSet1TableAdapters.tbl_sae_proveedorTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdproveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PronombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProtelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProcorreoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblsaeproveedorBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaeCpPDataSet3 = New Proyecto_sae.saeCpPDataSet3()
        Me.Tbl_sae_proveedorTableAdapter1 = New Proyecto_sae.saeCpPDataSet3TableAdapters.tbl_sae_proveedorTableAdapter()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.butSalir = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.TblsaeproveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaeCpPDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblsaeproveedorBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaeCpPDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(43, 37)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(489, 291)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txIdPro)
        Me.TabPage1.Controls.Add(Me.txCorre)
        Me.TabPage1.Controls.Add(Me.txTelefono)
        Me.TabPage1.Controls.Add(Me.txDireccion)
        Me.TabPage1.Controls.Add(Me.txNombre)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(481, 265)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txIdPro
        '
        Me.txIdPro.Location = New System.Drawing.Point(203, 27)
        Me.txIdPro.Name = "txIdPro"
        Me.txIdPro.Size = New System.Drawing.Size(192, 20)
        Me.txIdPro.TabIndex = 11
        '
        'txCorre
        '
        Me.txCorre.Location = New System.Drawing.Point(202, 199)
        Me.txCorre.Name = "txCorre"
        Me.txCorre.Size = New System.Drawing.Size(193, 20)
        Me.txCorre.TabIndex = 9
        '
        'txTelefono
        '
        Me.txTelefono.Location = New System.Drawing.Point(202, 157)
        Me.txTelefono.Name = "txTelefono"
        Me.txTelefono.Size = New System.Drawing.Size(193, 20)
        Me.txTelefono.TabIndex = 8
        '
        'txDireccion
        '
        Me.txDireccion.Location = New System.Drawing.Point(202, 116)
        Me.txDireccion.Name = "txDireccion"
        Me.txDireccion.Size = New System.Drawing.Size(193, 20)
        Me.txDireccion.TabIndex = 7
        '
        'txNombre
        '
        Me.txNombre.Location = New System.Drawing.Point(202, 74)
        Me.txNombre.Name = "txNombre"
        Me.txNombre.Size = New System.Drawing.Size(193, 20)
        Me.txNombre.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(90, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Correo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(90, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Telefono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(90, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Direccion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clave del Proveedor:"
        '
        'btActualizar
        '
        Me.btActualizar.Location = New System.Drawing.Point(43, 350)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(143, 23)
        Me.btActualizar.TabIndex = 1
        Me.btActualizar.Text = "Actualizar"
        Me.btActualizar.UseVisualStyleBackColor = True
        '
        'TblsaeproveedorBindingSource
        '
        Me.TblsaeproveedorBindingSource.DataMember = "tbl_sae_proveedor"
        Me.TblsaeproveedorBindingSource.DataSource = Me.SaeCpPDataSet1
        '
        'SaeCpPDataSet1
        '
        Me.SaeCpPDataSet1.DataSetName = "saeCpPDataSet1"
        Me.SaeCpPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btEliminar
        '
        Me.btEliminar.Location = New System.Drawing.Point(212, 349)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(143, 23)
        Me.btEliminar.TabIndex = 1
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'Tbl_sae_proveedorTableAdapter
        '
        Me.Tbl_sae_proveedorTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdproveedorDataGridViewTextBoxColumn, Me.PronombreDataGridViewTextBoxColumn, Me.ProdireccionDataGridViewTextBoxColumn, Me.ProtelefonoDataGridViewTextBoxColumn, Me.ProcorreoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblsaeproveedorBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(565, 104)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(588, 150)
        Me.DataGridView1.TabIndex = 11
        '
        'IdproveedorDataGridViewTextBoxColumn
        '
        Me.IdproveedorDataGridViewTextBoxColumn.DataPropertyName = "id_proveedor"
        Me.IdproveedorDataGridViewTextBoxColumn.HeaderText = "Clave Proveedor"
        Me.IdproveedorDataGridViewTextBoxColumn.Name = "IdproveedorDataGridViewTextBoxColumn"
        Me.IdproveedorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PronombreDataGridViewTextBoxColumn
        '
        Me.PronombreDataGridViewTextBoxColumn.DataPropertyName = "pro_nombre"
        Me.PronombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.PronombreDataGridViewTextBoxColumn.Name = "PronombreDataGridViewTextBoxColumn"
        '
        'ProdireccionDataGridViewTextBoxColumn
        '
        Me.ProdireccionDataGridViewTextBoxColumn.DataPropertyName = "pro_direccion"
        Me.ProdireccionDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.ProdireccionDataGridViewTextBoxColumn.Name = "ProdireccionDataGridViewTextBoxColumn"
        '
        'ProtelefonoDataGridViewTextBoxColumn
        '
        Me.ProtelefonoDataGridViewTextBoxColumn.DataPropertyName = "pro_telefono"
        Me.ProtelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.ProtelefonoDataGridViewTextBoxColumn.Name = "ProtelefonoDataGridViewTextBoxColumn"
        '
        'ProcorreoDataGridViewTextBoxColumn
        '
        Me.ProcorreoDataGridViewTextBoxColumn.DataPropertyName = "pro_correo"
        Me.ProcorreoDataGridViewTextBoxColumn.HeaderText = "Correo"
        Me.ProcorreoDataGridViewTextBoxColumn.Name = "ProcorreoDataGridViewTextBoxColumn"
        '
        'TblsaeproveedorBindingSource1
        '
        Me.TblsaeproveedorBindingSource1.DataMember = "tbl_sae_proveedor"
        Me.TblsaeproveedorBindingSource1.DataSource = Me.SaeCpPDataSet3
        '
        'SaeCpPDataSet3
        '
        Me.SaeCpPDataSet3.DataSetName = "saeCpPDataSet3"
        Me.SaeCpPDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_sae_proveedorTableAdapter1
        '
        Me.Tbl_sae_proveedorTableAdapter1.ClearBeforeFill = True
        '
        'btSalir
        '
        Me.btSalir.Location = New System.Drawing.Point(385, 349)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(147, 23)
        Me.btSalir.TabIndex = 12
        Me.btSalir.Text = "Guardar El proceso"
        Me.btSalir.UseVisualStyleBackColor = True
        '
        'butSalir
        '
        Me.butSalir.Location = New System.Drawing.Point(549, 349)
        Me.butSalir.Name = "butSalir"
        Me.butSalir.Size = New System.Drawing.Size(147, 23)
        Me.butSalir.TabIndex = 13
        Me.butSalir.Text = "Salir"
        Me.butSalir.UseVisualStyleBackColor = True
        '
        'fr_eliminarActualizaProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1178, 456)
        Me.Controls.Add(Me.butSalir)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btEliminar)
        Me.Controls.Add(Me.btActualizar)
        Me.Name = "fr_eliminarActualizaProveedor"
        Me.Text = "Actualizar o Eliminar Datos del Proveedor"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.TblsaeproveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaeCpPDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblsaeproveedorBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaeCpPDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SaeCpPDataSet1 As saeCpPDataSet1
    Friend WithEvents TblsaeproveedorBindingSource As BindingSource
    Friend WithEvents Tbl_sae_proveedorTableAdapter As saeCpPDataSet1TableAdapters.tbl_sae_proveedorTableAdapter
    Friend WithEvents btActualizar As Button
    Friend WithEvents txCorre As TextBox
    Friend WithEvents txTelefono As TextBox
    Friend WithEvents txDireccion As TextBox
    Friend WithEvents txNombre As TextBox
    Friend WithEvents btEliminar As Button
    Friend WithEvents txIdPro As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SaeCpPDataSet3 As saeCpPDataSet3
    Friend WithEvents TblsaeproveedorBindingSource1 As BindingSource
    Friend WithEvents Tbl_sae_proveedorTableAdapter1 As saeCpPDataSet3TableAdapters.tbl_sae_proveedorTableAdapter
    Friend WithEvents IdproveedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PronombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProtelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProcorreoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btSalir As Button
    Friend WithEvents butSalir As Button
End Class
