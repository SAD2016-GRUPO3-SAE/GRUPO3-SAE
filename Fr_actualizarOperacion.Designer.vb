<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fr_actualizarOperacion
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txDescripcion = New System.Windows.Forms.TextBox()
        Me.txNombre = New System.Windows.Forms.TextBox()
        Me.txClave = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btActualizar = New System.Windows.Forms.Button()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdoperacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpedescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblsaeoperacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaeCpPDataSet4 = New Proyecto_sae.saeCpPDataSet4()
        Me.Tbl_sae_operacionTableAdapter = New Proyecto_sae.saeCpPDataSet4TableAdapters.tbl_sae_operacionTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblsaeoperacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaeCpPDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clave De Operacion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre de la Operacion:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txDescripcion)
        Me.GroupBox1.Controls.Add(Me.txNombre)
        Me.GroupBox1.Controls.Add(Me.txClave)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(497, 159)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'txDescripcion
        '
        Me.txDescripcion.Location = New System.Drawing.Point(196, 104)
        Me.txDescripcion.Name = "txDescripcion"
        Me.txDescripcion.Size = New System.Drawing.Size(193, 20)
        Me.txDescripcion.TabIndex = 5
        '
        'txNombre
        '
        Me.txNombre.Location = New System.Drawing.Point(196, 62)
        Me.txNombre.Name = "txNombre"
        Me.txNombre.Size = New System.Drawing.Size(193, 20)
        Me.txNombre.TabIndex = 4
        '
        'txClave
        '
        Me.txClave.Location = New System.Drawing.Point(196, 23)
        Me.txClave.Name = "txClave"
        Me.txClave.Size = New System.Drawing.Size(193, 20)
        Me.txClave.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descripcion:"
        '
        'btActualizar
        '
        Me.btActualizar.Location = New System.Drawing.Point(64, 246)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(151, 23)
        Me.btActualizar.TabIndex = 3
        Me.btActualizar.Text = "Actualizar"
        Me.btActualizar.UseVisualStyleBackColor = True
        '
        'btSalir
        '
        Me.btSalir.Location = New System.Drawing.Point(280, 246)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(151, 23)
        Me.btSalir.TabIndex = 4
        Me.btSalir.Text = "Salir"
        Me.btSalir.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdoperacionDataGridViewTextBoxColumn, Me.OpenombreDataGridViewTextBoxColumn, Me.OpedescripcionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblsaeoperacionBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(589, 85)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(412, 150)
        Me.DataGridView1.TabIndex = 5
        '
        'IdoperacionDataGridViewTextBoxColumn
        '
        Me.IdoperacionDataGridViewTextBoxColumn.DataPropertyName = "id_operacion"
        Me.IdoperacionDataGridViewTextBoxColumn.HeaderText = "Clave"
        Me.IdoperacionDataGridViewTextBoxColumn.Name = "IdoperacionDataGridViewTextBoxColumn"
        Me.IdoperacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OpenombreDataGridViewTextBoxColumn
        '
        Me.OpenombreDataGridViewTextBoxColumn.DataPropertyName = "ope_nombre"
        Me.OpenombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.OpenombreDataGridViewTextBoxColumn.Name = "OpenombreDataGridViewTextBoxColumn"
        '
        'OpedescripcionDataGridViewTextBoxColumn
        '
        Me.OpedescripcionDataGridViewTextBoxColumn.DataPropertyName = "ope_descripcion"
        Me.OpedescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.OpedescripcionDataGridViewTextBoxColumn.Name = "OpedescripcionDataGridViewTextBoxColumn"
        '
        'TblsaeoperacionBindingSource
        '
        Me.TblsaeoperacionBindingSource.DataMember = "tbl_sae_operacion"
        Me.TblsaeoperacionBindingSource.DataSource = Me.SaeCpPDataSet4
        '
        'SaeCpPDataSet4
        '
        Me.SaeCpPDataSet4.DataSetName = "saeCpPDataSet4"
        Me.SaeCpPDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_sae_operacionTableAdapter
        '
        Me.Tbl_sae_operacionTableAdapter.ClearBeforeFill = True
        '
        'Fr_actualizarOperacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 344)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.btActualizar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Fr_actualizarOperacion"
        Me.Text = "Actualizar Operacion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblsaeoperacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaeCpPDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txDescripcion As TextBox
    Friend WithEvents txNombre As TextBox
    Friend WithEvents txClave As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btActualizar As Button
    Friend WithEvents btSalir As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SaeCpPDataSet4 As saeCpPDataSet4
    Friend WithEvents TblsaeoperacionBindingSource As BindingSource
    Friend WithEvents Tbl_sae_operacionTableAdapter As saeCpPDataSet4TableAdapters.tbl_sae_operacionTableAdapter
    Friend WithEvents IdoperacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OpenombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OpedescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
