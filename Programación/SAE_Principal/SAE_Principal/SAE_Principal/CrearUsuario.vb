Imports System.Data.SqlClient

Public Class CrearUsuario

    Private Sub CrearUsuario(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bt_cancelar.Click
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_crear.Click
        If String.IsNullOrEmpty(TextBox1.Text) Or
                String.IsNullOrEmpty(TextBox2.Text) Then
            MsgBox("Los campos estan vacios")

        Else
            Try
                Dim cmd As New SqlCommand("insert into tbl_sae_proyecto (sae_usuario, sae_contraseña) values ('" & TextBox1.Text & "','" & TextBox2.Text & "')", conectar)
                Dim cas As Integer
                conectar.Open()
                cas = cmd.ExecuteNonQuery
                conectar.Close()
                MsgBox("Los datos se guardaron con exito")
            Catch ex As Exception
                MsgBox(ex.Message)
                TextBox1.Clear()
                TextBox2.Clear()
            End Try
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class