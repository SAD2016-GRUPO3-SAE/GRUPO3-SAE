Imports System.Data.SqlClient

Module comandodb
    Public conectar As New SqlConnection("Server=Xavi-Ruiz\SQLEXPRESS;Database=SAEDB;Trusted_Connection=True")
    Public consulta As New SqlCommand
    Public datos As New DataSet
    Public variable As SqlDataReader
    Public data As DataTable
    Public fechahoy As Date = Date.Today
    Public fechaformat As String = fechahoy.ToString("YYYY/MM/DD")
    Public idusuario As Integer = 0
End Module

'Clase que guarda los comandos para la base de datos