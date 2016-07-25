Imports System.Data.SqlClient

Module comandodb
    Public conectar As New SqlConnection("Data Source=168.234.74.21;Initial Catalog=SAEDB;User ID=db3admin;Password=db3admin$")
    Public consulta As New SqlCommand
    Public datos As New DataSet
    Public variable As SqlDataReader
    Public data As DataTable
    Public fechahoy As Date = Date.Today
    Public fechaformat As String = fechahoy.ToString("YYYY/MM/DD")
    Public idusuario As Integer = 0
End Module

'Clase que guarda los comandos para la base de datos