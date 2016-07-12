Imports System.Data.SqlClient
Public Class Form1
    Private Sub BOTONOK_Click(sender As System.Object, e As System.EventArgs) Handles BOTONOK.Click
        Try
            Dim dts As New datos
            Dim func As New funciones
            dts.nomusuario = UsernameTextBox.Text
            dts.passusuario = PasswordTextBox.Text
            If func.Validar(dts) = True Then
                Me.Hide()
                MDISAE.Show()
            ElseIf func.Validar(dts) = False And UsernameTextBox.Text.Length = 0 And PasswordTextBox.Text.Length = 0 Then
                MessageBox.Show("Todos los campos estan vacios",
        "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UsernameTextBox.Clear()
                PasswordTextBox.Clear()
                UsernameTextBox.Focus()
            ElseIf func.Validar(dts) = False And UsernameTextBox.Text.Length = 0 Or PasswordTextBox.Text.Length = 0 Then
                MessageBox.Show("Debes completar todos los campos",
        "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UsernameTextBox.Clear()
                PasswordTextBox.Clear()
                UsernameTextBox.Focus()
            Else
                MessageBox.Show("Error verifique su Username y Password",
        "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                UsernameTextBox.Clear()
                PasswordTextBox.Clear()
                UsernameTextBox.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BOTONCANCEL_Click(sender As Object, e As EventArgs) Handles BOTONCANCEL.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CrearUsuario.Show()
    End Sub
End Class
