Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Configuration

Public Class funciones
    Inherits conexion
    Dim cmd As New SqlCommand
    Public Function Validar(ByVal dat As datos) As Boolean
        Try
            Conectado()
            cmd = New SqlCommand("autenticarse")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@usuario", dat.nomusuario)
            cmd.Parameters.AddWithValue("@password", dat.passusuario)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectado()
        End Try
    End Function
End Class
