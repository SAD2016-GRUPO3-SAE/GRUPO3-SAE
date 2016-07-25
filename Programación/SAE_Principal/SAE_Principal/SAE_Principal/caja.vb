Imports System.Data.SqlClient

Public Class caja

    Dim Dt As DataTable
    Dim Dt2 As DataTable
    Dim Dt3 As DataTable
    Dim Da As New SqlDataAdapter
    Dim Cmd As New SqlCommand

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Close()
    End Sub

    Private Sub caja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New SqlCommand("select * from tbl_sae_cuentaporcobrar", conectar)
        'Dim cas As Integer
        conectar.Open()
        'cas = cmd.ExecuteNonQuery
        Da.SelectCommand = cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With cpcBox
            .DataSource = Dt
            .DisplayMember = "cpc_identificador"
            .ValueMember = "id_Cuenta"
        End With
        conectar.Close()
    End Sub

    Private Sub cpcBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cpcBox.SelectedIndexChanged
        If cpcBox.SelectedIndex <> -1 Then
            Dim conectar2 As New SqlConnection("Data Source=168.234.74.21;Initial Catalog=SAEDB;User ID=db3admin;Password=db3admin$")
            '  System.Console.WriteLine("select * from dbo.tbl_sae_encabezado_factura where id_encabezadof= " & NoFactura.SelectedValue.ToString() & "")

            Dim queryString As New String("select id_cuenta, min(sld_saldo) as saldo, count(id_cuenta) as cuota from dbo.tbl_sae_saldo where id_cuenta =" & cpcBox.SelectedValue.ToString() & " Group by id_cuenta")
            If queryString.Contains("System.Data.DataRowView") Then

            Else
                Dim cmd2 As New SqlCommand(queryString, conectar2)

                conectar2.Open()
                Da.SelectCommand = cmd2
                Dim Dt4 As New DataTable
                Da.Fill(Dt4)
                numeroCuota.Text = Dt4.Rows.Item(0).Item("cuota")
                TextBox3.Text = Dt4.Rows.Item(0).Item("saldo")



                ' saldo_inicial.Text = Dt4.Rows.Item(0).Item("ecf_total_f")
                'total_credito.Text = Dt4.Rows.Item(0).Item("ecf_total_f")
                conectar2.Close()
            End If
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim queryStringInsert As String
        Dim saldoTmp As Double

        Dim queryCredito As New String("select cpc_credito from dbo.tbl_sae_cuentaporcobrar where id_cuenta =" & cpcBox.SelectedValue.ToString())
        saldoTmp = Double.Parse(TextBox3.Text)
        Dim abono As Double
        abono = Double.Parse(abonoTxt.Text)
        saldoTmp -= abono
        queryStringInsert = "insert into dbo.tbl_sae_saldo (id_cuenta, sld_descripcion,sld_saldo, sld__fecha) values  (" & cpcBox.SelectedValue.ToString() & ",'numero de Cuota " & numeroCuota.Text & "'," & saldoTmp & ", GETDATE())"
        System.Console.WriteLine(queryStringInsert)
        Dim cmd3 As New SqlCommand(queryStringInsert, conectar)
        Dim cmd4 As New SqlCommand(queryCredito, conectar)
        Dim cmd5 As New SqlCommand("select SCOPE_IDENTITY()", conectar)
        conectar.Open()

        cmd3.ExecuteNonQuery()
        Dim idSaldo As Integer
        idSaldo = cmd5.ExecuteScalar
        Dim credito As Double
        credito = cmd4.ExecuteScalar
        Dim insertAsentamiento As New String("insert into dbo.tbl_sae_asientos (asi_cuenta_cta, asi_credito, asi_debito, id_saldo) values('" & cpcBox.Text & "'," & credito & "," & abono & "," & idSaldo & ")")
        Dim cmd6 As New SqlCommand(insertAsentamiento, conectar)
        cmd6.ExecuteNonQuery()
        MessageBox.Show("Hola")

        conectar.Close()

    End Sub
End Class