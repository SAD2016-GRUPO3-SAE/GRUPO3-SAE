Imports System.Data.SqlClient

Public Class CrearCuenta
    Dim Dt As DataTable
    Dim Da As New SqlDataAdapter
    Dim Cmd As New SqlCommand

    Private Sub CrearCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Close()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NoCuotas.SelectedIndexChanged

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If String.IsNullOrEmpty(identificador.Text) Or
                String.IsNullOrEmpty(socio_negocio_box.Text) Then
            MsgBox("Los campos estan vacios")

        Else
            Try
                Dim fecha_inicio As Date
                Dim fecha_vencimiento As Date
                Dim cmd As New SqlCommand("insert into tbl_sae_cuentaporcobrar (cpc_identificador, cpc_fecha_inicio, cpc_num_cuotas, cpc_periodo, cpc_fecha_vencimiento, id_socio_negocio) values ('" & identificador.Text & "','" & fecha_inicio & "','" & NoCuotas.Text & "','" & periodo.Text & "','" & fecha_vencimiento & "','1')", conectar)
                'Dim cmd2 As New SqlCommand("select id_usuario from tbl_sae_usuario where id_usuario = " & sng_nombre & " ")
                Dim cas As Integer
                conectar.Open()
                cas = cmd.ExecuteNonQuery
                conectar.Close()
                MsgBox("Los datos se guardaron con exito")
                identificador.Clear()
                'fecha_inicio.ResetText()
                NoCuotas.Items.Clear()
                periodo.Items.Clear()
                'fecha_vencimiento.ResetText()
                'id_socio_negocio.Clear()
            Catch ex As Exception
                MsgBox("Los datos no se han podido Guardar")
                identificador.Clear()
                'fecha_inicio.ResetText()
                NoCuotas.Items.Clear()
                periodo.Items.Clear()
                'fecha_vencimiento.ResetText()
                'id_socio_negocio.Clear()
            End Try
        End If
    End Sub

End Class