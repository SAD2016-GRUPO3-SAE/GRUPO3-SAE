<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearUsuario
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.usuario = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.nomuno = New System.Windows.Forms.TextBox()
        Me.nomdos = New System.Windows.Forms.TextBox()
        Me.apeuno = New System.Windows.Forms.TextBox()
        Me.apedos = New System.Windows.Forms.TextBox()
        Me.dir = New System.Windows.Forms.TextBox()
        Me.tel = New System.Windows.Forms.TextBox()
        Me.mail = New System.Windows.Forms.TextBox()
        Me.bt_crear = New System.Windows.Forms.Button()
        Me.bt_cancelar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Primer Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Segundo Nombre:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Primer Apellido:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Segundo Apellido:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(60, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Dirección:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(63, 234)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Teléfono:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 260)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Correo electrónico:"
        '
        'usuario
        '
        Me.usuario.Location = New System.Drawing.Point(147, 34)
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(100, 20)
        Me.usuario.TabIndex = 9
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(147, 63)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(100, 20)
        Me.password.TabIndex = 10
        '
        'nomuno
        '
        Me.nomuno.Location = New System.Drawing.Point(147, 101)
        Me.nomuno.Name = "nomuno"
        Me.nomuno.Size = New System.Drawing.Size(100, 20)
        Me.nomuno.TabIndex = 11
        '
        'nomdos
        '
        Me.nomdos.Location = New System.Drawing.Point(147, 127)
        Me.nomdos.Name = "nomdos"
        Me.nomdos.Size = New System.Drawing.Size(100, 20)
        Me.nomdos.TabIndex = 12
        '
        'apeuno
        '
        Me.apeuno.Location = New System.Drawing.Point(147, 153)
        Me.apeuno.Name = "apeuno"
        Me.apeuno.Size = New System.Drawing.Size(100, 20)
        Me.apeuno.TabIndex = 13
        '
        'apedos
        '
        Me.apedos.Location = New System.Drawing.Point(147, 179)
        Me.apedos.Name = "apedos"
        Me.apedos.Size = New System.Drawing.Size(100, 20)
        Me.apedos.TabIndex = 14
        '
        'dir
        '
        Me.dir.Location = New System.Drawing.Point(147, 205)
        Me.dir.Name = "dir"
        Me.dir.Size = New System.Drawing.Size(100, 20)
        Me.dir.TabIndex = 15
        '
        'tel
        '
        Me.tel.Location = New System.Drawing.Point(147, 231)
        Me.tel.Name = "tel"
        Me.tel.Size = New System.Drawing.Size(100, 20)
        Me.tel.TabIndex = 16
        '
        'mail
        '
        Me.mail.Location = New System.Drawing.Point(147, 257)
        Me.mail.Name = "mail"
        Me.mail.Size = New System.Drawing.Size(100, 20)
        Me.mail.TabIndex = 17
        '
        'bt_crear
        '
        Me.bt_crear.Location = New System.Drawing.Point(147, 292)
        Me.bt_crear.Name = "bt_crear"
        Me.bt_crear.Size = New System.Drawing.Size(75, 23)
        Me.bt_crear.TabIndex = 18
        Me.bt_crear.Text = "Crear"
        Me.bt_crear.UseVisualStyleBackColor = True
        '
        'bt_cancelar
        '
        Me.bt_cancelar.Location = New System.Drawing.Point(228, 292)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.bt_cancelar.TabIndex = 19
        Me.bt_cancelar.Text = "Cancelar"
        Me.bt_cancelar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SAE_Principal.My.Resources.Resources.contactbook
        Me.PictureBox1.Location = New System.Drawing.Point(308, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(227, 214)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'CrearUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 343)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bt_cancelar)
        Me.Controls.Add(Me.bt_crear)
        Me.Controls.Add(Me.mail)
        Me.Controls.Add(Me.tel)
        Me.Controls.Add(Me.dir)
        Me.Controls.Add(Me.apedos)
        Me.Controls.Add(Me.apeuno)
        Me.Controls.Add(Me.nomdos)
        Me.Controls.Add(Me.nomuno)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.usuario)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CrearUsuario"
        Me.Text = "CrearUsuario"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents usuario As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents nomuno As TextBox
    Friend WithEvents nomdos As TextBox
    Friend WithEvents apeuno As TextBox
    Friend WithEvents apedos As TextBox
    Friend WithEvents dir As TextBox
    Friend WithEvents tel As TextBox
    Friend WithEvents mail As TextBox
    Friend WithEvents bt_crear As Button
    Friend WithEvents bt_cancelar As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
