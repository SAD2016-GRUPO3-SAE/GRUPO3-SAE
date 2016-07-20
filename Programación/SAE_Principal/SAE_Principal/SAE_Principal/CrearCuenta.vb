Imports System.Data.SqlClient

Public Class CrearCuenta
    Dim Dt As DataTable
    Dim Dt2 As DataTable
    Dim Da As New SqlDataAdapter
    Dim Cmd As New SqlCommand

    Private Sub CrearCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

            Dim cmd2 As New SqlCommand("select * from dbo.tbl_sae_encabezado_factura", conectar)
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
        Catch ex As Exception
            NoFactura.Items.Clear()
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
                Dim fecha_inicio As Date
                Dim fecha_vencimiento As Date
                saldo_inicial.Text = socio_negocio_box.SelectedValue.ToString()
                If String.IsNullOrEmpty(socio_negocio_box.Text) Then
                    saldo_inicial.Text = socio_negocio_box.SelectedValue.ToString()
                Else
                    MsgBox("No existe el cliente")
                End If
                Dim cmd As New SqlCommand("insert into tbl_sae_cuentaporcobrar (cpc_identificador, cpc_fecha_inicio, cpc_num_cuotas, cpc_periodo, cpc_fecha_vencimiento, id_socio_negocio) values ('" & identificador.Text & "','" & fecha_inicio & "','" & NoCuotas.Text & "','" & periodo.Text & "','" & fecha_vencimiento & "','" & socio_negocio_box.SelectedValue.ToString & "')", conectar)
                Dim cmd2 As New SqlCommand(" ")
                Dim cas As Integer
                conectar.Open()
                cas = cmd.ExecuteNonQuery
                conectar.Close()
                MsgBox("Los datos se guardaron con exito")
                identificador.Clear()
                NoCuotas.Items.Clear()
                periodo.Items.Clear()
            Catch ex As Exception
                MsgBox("Los datos no se han podido Guardar")
                identificador.Clear()
                NoCuotas.Items.Clear()
                periodo.Items.Clear()
            End Try
        End If
    End Sub

    Private Sub saldo_inicial_TextChanged(sender As Object, e As EventArgs) Handles saldo_inicial.TextChanged

    End Sub
End Class