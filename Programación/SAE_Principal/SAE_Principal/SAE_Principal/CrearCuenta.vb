Imports System.Data.SqlClient
'powtoon - para video

Public Class CrearCuenta
    Dim Dt As DataTable
    Dim Dt2 As DataTable
    Dim Dt3 As DataTable
    Dim Da As New SqlDataAdapter
    Dim Cmd As New SqlCommand
    Dim index_socio_actual As Integer
    Dim index_saldo_inicio As Integer

    Private Sub CrearCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        socio_negocio_box.SelectedIndex = -1
        NoFactura.SelectedIndex = -1
        index_socio_actual = -10
        Try
            Dim cmd As New SqlCommand("select * from dbo.tbl_sae_socio_negocio", conectar)
            'Dim cas As Integer
            conectar.Open()
            'cas = cmd.ExecuteNonQuery
            Da.SelectCommand = cmd
            Dt = New DataTable
            Da.Fill(Dt)
            With socio_negocio_box
                .DataSource = Dt
                .DisplayMember = "sng_nombre"
                .ValueMember = "id_socio_negocio"
            End With
            conectar.Close()
            'MsgBox("Los datos se guardaron con exito")

            Dim cmd2 As New SqlCommand("select * from dbo.tbl_sae_encabezado_factura where id_socio_negocio = '" & socio_negocio_box.SelectedValue.ToString & "'", conectar)
            conectar.Open()
            Da.SelectCommand = cmd2
            Dt2 = New DataTable
            Da.Fill(Dt2)
            With NoFactura
                .DataSource = Dt2
                .DisplayMember = "ecf_nofactura"
                .ValueMember = "id_encabezadof"
            End With
            saldo_inicial.Text = CStr(Dt2.Rows(0)("ecf_total_f"))
            iva.Text = CStr(Dt2.Rows(0)("ecf_iva"))

            conectar.Close()

            'saldo_inicial.Text = ("select * from dbo.tbl_sae_encabezado_factura where id_socio_negocio = '" & socio_negocio_box.SelectedValue.ToString & "'", conectar)
            conectar.Close()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If String.IsNullOrEmpty(identificador.Text) Or
                String.IsNullOrEmpty(socio_negocio_box.Text) Then
            MsgBox("Los campos estan vacios")
        Else
            Try
                ' Dim fecha_inicio As Date
                ' Dim fecha_vencimiento As Date
                saldo_inicial.Text = socio_negocio_box.SelectedValue.ToString()
                If String.IsNullOrEmpty(socio_negocio_box.Text) Then
                    saldo_inicial.Text = socio_negocio_box.SelectedValue.ToString()
                Else
                    MsgBox("No existe el cliente")
                End If

                Dim cmd As New SqlCommand("insert into tbl_sae_cuentaporcobrar (cpc_identificador, cpc_fecha_inicio, cpc_num_cuotas, cpc_periodo, cpc_fecha_vencimiento, id_socio_negocio, cpc_credito) values ('" & identificador.Text & "','" & fecha_inicio.Value & "','" & NoCuotas.Text & "','" & periodo.Text & "','" & fecha_vencimiento.Value & "','" & socio_negocio_box.SelectedValue.ToString & "'," & total_credito.Text & ")", conectar)
                Dim cmd2 As New SqlCommand("select SCOPE_IDENTITY()", conectar)

                Dim cas As Integer
                conectar.Open()
                cas = cmd.ExecuteNonQuery
                Dim idCta As Integer
                idCta = cmd2.ExecuteScalar
                Dim creationDate As New Date
                Dim queryStringInsert As String
                queryStringInsert = "insert into dbo.tbl_sae_saldo (id_cuenta, sld_descripcion,sld_saldo, sld__fecha) values  (" & idCta.ToString & ",'" & descripcion.Text & "'," & total_credito.Text & ", GETDATE())"
                System.Console.WriteLine(queryStringInsert)
                Dim cmd3 As New SqlCommand(queryStringInsert, conectar)
                If cas > 0 Then
                    cmd3.ExecuteNonQuery()
                End If

                conectar.Close()
                MsgBox("Los datos se guardaron con exito")
                identificador.Clear()
                NoCuotas.Items.Clear()
                periodo.Items.Clear()
                '                MsgBox("numero cuenta " & idCta)

            Catch ex As Exception
                MsgBox("Los datos no se han podido Guardar")
                identificador.Clear()
                NoCuotas.Items.Clear()
                periodo.Items.Clear()
            End Try
        End If
    End Sub

    Private Sub socio_negocio_box_SelectedIndexChanged(sender As Object, e As EventArgs) Handles socio_negocio_box.SelectedIndexChanged
        If index_socio_actual = -10 Then
            index_socio_actual = socio_negocio_box.SelectedIndex
        ElseIf index_socio_actual <> socio_negocio_box.SelectedIndex Then
            index_socio_actual = socio_negocio_box.SelectedIndex
            Dim cmd2 As New SqlCommand("select * from dbo.tbl_sae_encabezado_factura where id_socio_negocio = '" & socio_negocio_box.SelectedValue.ToString & "'", conectar)
            conectar.Open()
            Da.SelectCommand = cmd2
            Dt2 = New DataTable
            Da.Fill(Dt2)
            With NoFactura
                .DataSource = Dt2
                .DisplayMember = "ecf_nofactura"
                .ValueMember = "id_encabezadof"
            End With
            conectar.Close()
        End If
    End Sub

    Private Sub NoFactura_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NoFactura.SelectedIndexChanged
        If index_socio_actual = -10 Then

        ElseIf NoFactura.SelectedIndex <> -1 Then
            Dim conectar2 As New SqlConnection("Data Source=168.234.74.21;Initial Catalog=SAEDB;User ID=db3admin;Password=db3admin$")
            '  System.Console.WriteLine("select * from dbo.tbl_sae_encabezado_factura where id_encabezadof= " & NoFactura.SelectedValue.ToString() & "")
            Dim queryString As New String("select * from dbo.tbl_sae_encabezado_factura where id_encabezadof= " & NoFactura.SelectedValue.ToString() & "")
            If queryString.Contains("System.Data.DataRowView") Then

            Else
                Dim cmd2 As New SqlCommand(queryString, conectar2)
                conectar2.Open()
                Da.SelectCommand = cmd2
                Dim Dt4 As New DataTable
                Da.Fill(Dt4)
                iva.Text = Dt4.Rows.Item(0).Item("ecf_iva")
                saldo_inicial.Text = Dt4.Rows.Item(0).Item("ecf_total_f")
                total_credito.Text = Dt4.Rows.Item(0).Item("ecf_total_f")
                conectar2.Close()
            End If
        End If

    End Sub

    Private Sub total_credito_TextChanged(sender As Object, e As EventArgs) Handles Abono.TextChanged
        Dim temporal As Double
        Dim abonoNum As Double
        Try
            abonoNum = Double.Parse(Abono.Text)
            temporal = Double.Parse(saldo_inicial.Text)
            temporal -= abonoNum
            total_credito.Text = temporal.ToString
        Catch ex As Exception

        End Try



    End Sub

    Private Sub Calcular_Vencimiento()
        'Dim fechaInicio As Date
        'Dim fechaFin As Date
        Dim numeroDias As Integer

        Select Case periodo.SelectedIndex
            Case 0 : numeroDias = 15
            Case 1 : numeroDias = 30
            Case Else : numeroDias = 1
        End Select

        Select Case NoCuotas.SelectedIndex
            Case 0 : numeroDias *= 3
            Case 1 : numeroDias *= 6
            Case 2 : numeroDias *= 12
            Case Else
                numeroDias *= 1
        End Select
        fecha_vencimiento.Value = fecha_inicio.Value.AddDays(numeroDias)

    End Sub

    Private Sub fecha_inicio_ValueChanged(sender As Object, e As EventArgs) Handles fecha_inicio.ValueChanged
        Calcular_Vencimiento()
    End Sub

    Private Sub NoCuotas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NoCuotas.SelectedIndexChanged
        If index_socio_actual = -10 Then
        Else
            Calcular_Vencimiento()
        End If
    End Sub

    Private Sub periodo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles periodo.SelectedIndexChanged
        If index_socio_actual = -10 Then
        Else
            Calcular_Vencimiento()
        End If
    End Sub
End Class