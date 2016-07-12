Imports System.Data.SqlClient

Public Class CrearUsuario
    Dim conexion As New SqlConnection
    Dim comando As New SqlCommand

    Private Sub CrearUsuario(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion.ConnectionString = "Data Source=XAVI-RUIZ\SQLEXPRESS;Initial Catalog=ERP_SAE;Integrated Security=True"
        conexion.Open()
        comando.Connection = conexion
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bt_cancelar.Click
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_crear.Click

        Try
            comando.CommandText = "insert into tbl_sae_proyecto (id_usuario,usuario,contraseña) Values ('','" & TextBox1.Text & "','" & TextBox2.Text & "' )"
            comando.ExecuteNonQuery()
            TextBox1.Clear()
            TextBox2.Clear()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CrearUsuario_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        conexion.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class