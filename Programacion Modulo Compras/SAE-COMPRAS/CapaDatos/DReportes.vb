Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class DReportes

	Public Sub New()
	End Sub

	Public Function MostrarTop10Proveedores(parFechaInicial__1 As [String], parFechaFinal__2 As [String]) As DataTable
		Dim TablaDatos As New DataTable("Reportes.Top10Proveedor")
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Reportes.Top10Proveedor"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParFechaInicial__3 As New SqlParameter()
			ParFechaInicial__3.ParameterName = "@FechaInicial"
			ParFechaInicial__3.SqlDbType = SqlDbType.VarChar
			ParFechaInicial__3.Value = parFechaInicial__1
			SqlComando.Parameters.Add(ParFechaInicial__3)

			Dim ParFechaFinal__4 As New SqlParameter()
			ParFechaFinal__4.ParameterName = "@FechaFinal"
			ParFechaFinal__4.SqlDbType = SqlDbType.VarChar
			ParFechaFinal__4.Value = parFechaFinal__2
			SqlComando.Parameters.Add(ParFechaFinal__4)

			SqlComando.ExecuteNonQuery()

			Dim SqlAdaptadorDatos As New SqlDataAdapter(SqlComando)
			SqlAdaptadorDatos.Fill(TablaDatos)

		Catch ex As Exception
			TablaDatos = Nothing
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado Reportes.Top10Proveedores. " & ex.Message, ex)
		Finally

			SqlConexion.Close()
		End Try

		Return TablaDatos
	End Function

	Public Function MostrarTop10Empleados(parFechaInicial__1 As [String], parFechaFinal__2 As [String]) As DataTable
		Dim TablaDatos As New DataTable("Reportes.Top10Empleados")
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Reportes.Top10Empleados"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParFechaInicial__3 As New SqlParameter()
			ParFechaInicial__3.ParameterName = "@FechaInicial"
			ParFechaInicial__3.SqlDbType = SqlDbType.VarChar
			ParFechaInicial__3.Value = parFechaInicial__1
			SqlComando.Parameters.Add(ParFechaInicial__3)

			Dim ParFechaFinal__4 As New SqlParameter()
			ParFechaFinal__4.ParameterName = "@FechaFinal"
			ParFechaFinal__4.SqlDbType = SqlDbType.VarChar
			ParFechaFinal__4.Value = parFechaFinal__2
			SqlComando.Parameters.Add(ParFechaFinal__4)

			SqlComando.ExecuteNonQuery()

			Dim SqlAdaptadorDatos As New SqlDataAdapter(SqlComando)
			SqlAdaptadorDatos.Fill(TablaDatos)

		Catch ex As Exception
			TablaDatos = Nothing
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado Reportes.Top10Empleados. " & ex.Message, ex)
		Finally

			SqlConexion.Close()
		End Try

		Return TablaDatos
	End Function

	Public Function MostrarTop10Productos(parFechaInicial__1 As [String], parFechaFinal__2 As [String]) As DataTable
		Dim TablaDatos As New DataTable("Reportes.Top10Productos")
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Reportes.Top10Productos"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParFechaInicial__3 As New SqlParameter()
			ParFechaInicial__3.ParameterName = "@FechaInicial"
			ParFechaInicial__3.SqlDbType = SqlDbType.VarChar
			ParFechaInicial__3.Value = parFechaInicial__1
			SqlComando.Parameters.Add(ParFechaInicial__3)

			Dim ParFechaFinal__4 As New SqlParameter()
			ParFechaFinal__4.ParameterName = "@FechaFinal"
			ParFechaFinal__4.SqlDbType = SqlDbType.VarChar
			ParFechaFinal__4.Value = parFechaFinal__2
			SqlComando.Parameters.Add(ParFechaFinal__4)

			SqlComando.ExecuteNonQuery()

			Dim SqlAdaptadorDatos As New SqlDataAdapter(SqlComando)
			SqlAdaptadorDatos.Fill(TablaDatos)

		Catch ex As Exception
			TablaDatos = Nothing
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado Reportes.Top10Productos. " & ex.Message, ex)
		Finally

			SqlConexion.Close()
		End Try

		Return TablaDatos
	End Function

	Public Function MostrarHistorialProveedor(parFechaInicial__1 As [String], parFechaFinal__2 As [String], parProveedor__3 As [String]) As DataTable
		Dim TablaDatos As New DataTable("Reportes.HistorialProveedor")
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Reportes.HistorialProveedor"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParFechaInicial__4 As New SqlParameter()
			ParFechaInicial__4.ParameterName = "@FechaInicial"
			ParFechaInicial__4.SqlDbType = SqlDbType.VarChar
			ParFechaInicial__4.Value = parFechaInicial__1
			SqlComando.Parameters.Add(ParFechaInicial__4)

			Dim ParFechaFinal__5 As New SqlParameter()
			ParFechaFinal__5.ParameterName = "@FechaFinal"
			ParFechaFinal__5.SqlDbType = SqlDbType.VarChar
			ParFechaFinal__5.Value = parFechaFinal__2
			SqlComando.Parameters.Add(ParFechaFinal__5)

			Dim ParProveedor__6 As New SqlParameter()
			ParProveedor__6.ParameterName = "@Proveedor"
			ParProveedor__6.SqlDbType = SqlDbType.VarChar
			ParProveedor__6.Value = parProveedor__3
			SqlComando.Parameters.Add(ParProveedor__6)

			SqlComando.ExecuteNonQuery()

			Dim SqlAdaptadorDatos As New SqlDataAdapter(SqlComando)
			SqlAdaptadorDatos.Fill(TablaDatos)

		Catch ex As Exception
			TablaDatos = Nothing
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado Reportes.HistorialProveedor. " & ex.Message, ex)
		Finally

			SqlConexion.Close()
		End Try

		Return TablaDatos
	End Function

	Public Function MostrarHistorialEmpleado(parFechaInicial__1 As [String], parFechaFinal__2 As [String], parEmpleado__3 As [String]) As DataTable
		Dim TablaDatos As New DataTable("Reportes.HistorialEmpleado")
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Reportes.HistorialEmpleado"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParFechaInicial__4 As New SqlParameter()
			ParFechaInicial__4.ParameterName = "@FechaInicial"
			ParFechaInicial__4.SqlDbType = SqlDbType.VarChar
			ParFechaInicial__4.Value = parFechaInicial__1
			SqlComando.Parameters.Add(ParFechaInicial__4)

			Dim ParFechaFinal__5 As New SqlParameter()
			ParFechaFinal__5.ParameterName = "@FechaFinal"
			ParFechaFinal__5.SqlDbType = SqlDbType.VarChar
			ParFechaFinal__5.Value = parFechaFinal__2
			SqlComando.Parameters.Add(ParFechaFinal__5)

			Dim ParEmpleado__6 As New SqlParameter()
			ParEmpleado__6.ParameterName = "@Empleado"
			ParEmpleado__6.SqlDbType = SqlDbType.VarChar
			ParEmpleado__6.Value = parEmpleado__3
			SqlComando.Parameters.Add(ParEmpleado__6)

			SqlComando.ExecuteNonQuery()

			Dim SqlAdaptadorDatos As New SqlDataAdapter(SqlComando)
			SqlAdaptadorDatos.Fill(TablaDatos)

		Catch ex As Exception
			TablaDatos = Nothing
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado Reportes.HistorialEmpleado. " & ex.Message, ex)
		Finally

			SqlConexion.Close()
		End Try

		Return TablaDatos
	End Function

	Public Function MostrarHistorialProducto(parFechaInicial__1 As [String], parFechaFinal__2 As [String], parProducto__3 As [String]) As DataTable
		Dim TablaDatos As New DataTable("Reportes.HistorialProducto")
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Reportes.HistorialProducto"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParFechaInicial__4 As New SqlParameter()
			ParFechaInicial__4.ParameterName = "@FechaInicial"
			ParFechaInicial__4.SqlDbType = SqlDbType.VarChar
			ParFechaInicial__4.Value = parFechaInicial__1
			SqlComando.Parameters.Add(ParFechaInicial__4)

			Dim ParFechaFinal__5 As New SqlParameter()
			ParFechaFinal__5.ParameterName = "@FechaFinal"
			ParFechaFinal__5.SqlDbType = SqlDbType.VarChar
			ParFechaFinal__5.Value = parFechaFinal__2
			SqlComando.Parameters.Add(ParFechaFinal__5)

			Dim ParProducto__6 As New SqlParameter()
			ParProducto__6.ParameterName = "@Producto"
			ParProducto__6.SqlDbType = SqlDbType.VarChar
			ParProducto__6.Value = parProducto__3
			SqlComando.Parameters.Add(ParProducto__6)

			SqlComando.ExecuteNonQuery()

			Dim SqlAdaptadorDatos As New SqlDataAdapter(SqlComando)
			SqlAdaptadorDatos.Fill(TablaDatos)

		Catch ex As Exception
			TablaDatos = Nothing
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado Reportes.HistorialProducto. " & ex.Message, ex)
		Finally

			SqlConexion.Close()
		End Try

		Return TablaDatos
	End Function
End Class
