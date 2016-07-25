Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Configuration

Public Class conexion
    Public Shared con As New SqlConnection
    Public Shared Function Conectado()
        Try
            con = New SqlConnection("Server=168.234.74.21;Database=SAEDB;Trusted_Connection=True")
            con.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Shared Function Desconectado()
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
