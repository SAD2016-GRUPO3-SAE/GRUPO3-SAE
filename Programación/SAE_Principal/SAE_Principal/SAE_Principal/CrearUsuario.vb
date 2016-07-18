Imports System.Data.SqlClient

Public Class CrearUsuario

    Private Sub CrearUsuario(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bt_cancelar.Click
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_crear.Click
        If String.IsNullOrEmpty(usuario.Text) Or
                String.IsNullOrEmpty(password.Text) Then
            MsgBox("Los campos estan vacios")

        Else
            Try
                Dim cmd As New SqlCommand("insert into tbl_sae_usuario (usu_usuario, usu_password, usu_nom_uno, usu_nom_dos, usu_ape_uno, usu_ape_dos, usu_dir, usu_tel, usu_mail) values ('" & usuario.Text & "','" & password.Text & "','" & nomuno.Text & "','" & nomdos.Text & "','" & apeuno.Text & "','" & apedos.Text & "','" & dir.Text & "','" & tel.Text & "','" & mail.Text & "')", conectar)
                Dim cas As Integer
                conectar.Open()
                cas = cmd.ExecuteNonQuery
                conectar.Close()
                MsgBox("Los datos se guardaron con exito")
                usuario.Clear()
                password.Clear()
                nomuno.Clear()
                nomdos.Clear()
                apeuno.Clear()
                apedos.Clear()
                dir.Clear()
                tel.Clear()
                mail.Clear()
            Catch ex As Exception
                MsgBox("Los datos no se han podido Guardar")
                usuario.Clear()
                password.Clear()
                nomuno.Clear()
                nomdos.Clear()
                apeuno.Clear()
                apedos.Clear()
                dir.Clear()
                tel.Clear()
                mail.Clear()
            End Try
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles usuario.TextChanged

    End Sub
End Class