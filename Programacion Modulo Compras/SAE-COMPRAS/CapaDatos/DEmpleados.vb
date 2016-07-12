Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class DEmpleados
	Public Property Id_Empleado() As Integer
		Get
			Return m_Id_Empleado
		End Get
		Set
			m_Id_Empleado = Value
		End Set
	End Property
	Private m_Id_Empleado As Integer
	Public Property Nombre_Empleado() As [String]
		Get
			Return m_Nombre_Empleado
		End Get
		Set
			m_Nombre_Empleado = Value
		End Set
	End Property
	Private m_Nombre_Empleado As [String]
	Public Property Apellido_Empleado() As [String]
		Get
			Return m_Apellido_Empleado
		End Get
		Set
			m_Apellido_Empleado = Value
		End Set
	End Property
	Private m_Apellido_Empleado As [String]
	Public Property Direccion() As [String]
		Get
			Return m_Direccion
		End Get
		Set
			m_Direccion = Value
		End Set
	End Property
	Private m_Direccion As [String]
	Public Property Ciudad() As [String]
		Get
			Return m_Ciudad
		End Get
		Set
			m_Ciudad = Value
		End Set
	End Property
	Private m_Ciudad As [String]
	Public Property Region() As [String]
		Get
			Return m_Region
		End Get
		Set
			m_Region = Value
		End Set
	End Property
	Private m_Region As [String]
	Public Property Pais() As [String]
		Get
			Return m_Pais
		End Get
		Set
			m_Pais = Value
		End Set
	End Property
	Private m_Pais As [String]
	Public Property Telefono() As [String]
		Get
			Return m_Telefono
		End Get
		Set
			m_Telefono = Value
		End Set
	End Property
	Private m_Telefono As [String]
	Public Property Apellido_Buscado() As [String]
		Get
			Return m_Apellido_Buscado
		End Get
		Set
			m_Apellido_Buscado = Value
		End Set
	End Property
	Private m_Apellido_Buscado As [String]


	Public Sub New()
	End Sub

	Public Sub New(parId_Empleado As Integer, parNombre_Empleado As [String], parApellido_Empleado As [String], parDireccion As [String], parCiudad As [String], parRegion As [String], _
		parPais As [String], parTelefono As [String], parApellido_Buscado As [String])
		Me.Id_Empleado = parId_Empleado
		Me.Nombre_Empleado = parNombre_Empleado
		Me.Apellido_Empleado = parApellido_Empleado
		Me.Direccion = parDireccion
		Me.Ciudad = parCiudad
		Me.Region = parRegion
		Me.Pais = parPais
		Me.Telefono = parTelefono
		Me.Apellido_Buscado = parApellido_Buscado
	End Sub

	Public Function ListaEmpleados() As DataTable
		Dim TablaDatos As New DataTable("RecursosHumanos.Empleados")
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "RecursosHumanos.ListaEmpleados"
			SqlComando.CommandType = CommandType.StoredProcedure

			SqlComando.ExecuteNonQuery()

			Dim SqlAdaptadorDatos As New SqlDataAdapter(SqlComando)
			SqlAdaptadorDatos.Fill(TablaDatos)

		Catch ex As Exception
			TablaDatos = Nothing
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado RecursosHumanos.ListaEmpleados. " & ex.Message, ex)
		Finally

			SqlConexion.Close()
		End Try

		Return TablaDatos
	End Function

	Public Function Mostrar(parNumeroPagina__1 As Integer, parRegistrosPorPagina__2 As Integer) As DataTable
		Dim TablaDatos As New DataTable("RecursosHumanos.Empleados")
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "RecursosHumanos.MostrarEmpleados"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParNumeroPagina__3 As New SqlParameter()
			ParNumeroPagina__3.ParameterName = "@NumeroPagina"
			ParNumeroPagina__3.SqlDbType = SqlDbType.Int
			ParNumeroPagina__3.Value = parNumeroPagina__1
			SqlComando.Parameters.Add(ParNumeroPagina__3)

			Dim ParRegistrosPorPagina__4 As New SqlParameter()
			ParRegistrosPorPagina__4.ParameterName = "@RegistrosPorPagina"
			ParRegistrosPorPagina__4.SqlDbType = SqlDbType.Int
			ParRegistrosPorPagina__4.Value = parRegistrosPorPagina__2
			SqlComando.Parameters.Add(ParRegistrosPorPagina__4)

			SqlComando.ExecuteNonQuery()

			Dim SqlAdaptadorDatos As New SqlDataAdapter(SqlComando)
			SqlAdaptadorDatos.Fill(TablaDatos)

		Catch ex As Exception
			TablaDatos = Nothing
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado RecursosHumanos.MostrarEmpleados. " & ex.Message, ex)
		Finally

			SqlConexion.Close()
		End Try

		Return TablaDatos
	End Function

	Public Function Tamaño(parRegistrosPorPagina__1 As Integer) As Integer
		Dim SqlConexion As New SqlConnection()
		Dim totalPaginas As Integer = 1

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "RecursosHumanos.TamañoEmpleados"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParRegistrosPorPagina__2 As New SqlParameter()
			ParRegistrosPorPagina__2.ParameterName = "@RegistrosPorPagina"
			ParRegistrosPorPagina__2.SqlDbType = SqlDbType.Int
			ParRegistrosPorPagina__2.Value = parRegistrosPorPagina__1
			SqlComando.Parameters.Add(ParRegistrosPorPagina__2)

			Dim ParTotalPaginas As New SqlParameter()
			ParTotalPaginas.ParameterName = "@TotalPaginas"
			ParTotalPaginas.SqlDbType = SqlDbType.Int
			ParTotalPaginas.Direction = ParameterDirection.Output
			SqlComando.Parameters.Add(ParTotalPaginas)
			SqlComando.ExecuteNonQuery()

			totalPaginas = CInt(SqlComando.Parameters("@TotalPaginas").Value)

		Catch ex As Exception
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado RecursosHumanos.TamañoEmpleado. " & ex.Message, ex)
		Finally

			SqlConexion.Close()
		End Try

		Return totalPaginas
	End Function

	Public Function Buscar(parEmpleados As DEmpleados) As DataTable
		Dim TablaDatos As New DataTable("RecursosHumanos.Empleados")
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "RecursosHumanos.BuscarEmpleado"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParApellido_Buscado As New SqlParameter()
			ParApellido_Buscado.ParameterName = "@ApellidoBuscado"
			ParApellido_Buscado.SqlDbType = SqlDbType.VarChar
			ParApellido_Buscado.Size = parEmpleados.Apellido_Buscado.Length
			ParApellido_Buscado.Value = parEmpleados.Apellido_Buscado
			SqlComando.Parameters.Add(ParApellido_Buscado)

			Dim SqlAdaptadorDatos As New SqlDataAdapter(SqlComando)
			SqlAdaptadorDatos.Fill(TablaDatos)

		Catch ex As Exception
			TablaDatos = Nothing
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado RecursosHumanos.BuscarEmpleado. " & ex.Message, ex)
		Finally

			If SqlConexion.State = ConnectionState.Open Then
				SqlConexion.Close()
			End If
		End Try

		Return TablaDatos
	End Function

	Public Function Insertar(parEmpleados As DEmpleados) As String
		Dim Respuesta As String = ""
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa

			SqlConexion.Open()
			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "RecursosHumanos.InsertarEmpleado"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParNombre_Empleado As New SqlParameter()
			ParNombre_Empleado.ParameterName = "@Nombre_Empleado"
			ParNombre_Empleado.SqlDbType = SqlDbType.VarChar
			ParNombre_Empleado.Size = parEmpleados.Nombre_Empleado.Length
			ParNombre_Empleado.Value = parEmpleados.Nombre_Empleado
			SqlComando.Parameters.Add(ParNombre_Empleado)

			Dim ParApellido_Empleado As New SqlParameter()
			ParApellido_Empleado.ParameterName = "@Apellido_Empleado"
			ParApellido_Empleado.SqlDbType = SqlDbType.VarChar
			ParApellido_Empleado.Size = parEmpleados.Apellido_Empleado.Length
			ParApellido_Empleado.Value = parEmpleados.Apellido_Empleado
			SqlComando.Parameters.Add(ParApellido_Empleado)

			Dim ParDireccion As New SqlParameter()
			ParDireccion.ParameterName = "@Direccion"
			ParDireccion.SqlDbType = SqlDbType.VarChar
			ParDireccion.Size = parEmpleados.Direccion.Length
			ParDireccion.Value = parEmpleados.Direccion
			SqlComando.Parameters.Add(ParDireccion)

			Dim ParCiudad As New SqlParameter()
			ParCiudad.ParameterName = "@Ciudad"
			ParCiudad.SqlDbType = SqlDbType.VarChar
			ParCiudad.Size = parEmpleados.Ciudad.Length
			ParCiudad.Value = parEmpleados.Ciudad
			SqlComando.Parameters.Add(ParCiudad)

			Dim ParRegion As New SqlParameter()
			ParRegion.ParameterName = "@Region"
			ParRegion.SqlDbType = SqlDbType.VarChar
			ParRegion.Size = parEmpleados.Region.Length
			ParRegion.Value = parEmpleados.Region
			SqlComando.Parameters.Add(ParRegion)

			Dim ParPais As New SqlParameter()
			ParPais.ParameterName = "@Pais"
			ParPais.SqlDbType = SqlDbType.VarChar
			ParPais.Size = parEmpleados.Pais.Length
			ParPais.Value = parEmpleados.Pais
			SqlComando.Parameters.Add(ParPais)

			Dim ParTelefono As New SqlParameter()
			ParTelefono.ParameterName = "@Telefono"
			ParTelefono.SqlDbType = SqlDbType.VarChar
			ParTelefono.Size = parEmpleados.Telefono.Length
			ParTelefono.Value = parEmpleados.Telefono
			SqlComando.Parameters.Add(ParTelefono)

			SqlComando.ExecuteNonQuery()
			Respuesta = "Y"

		Catch ex As SqlException
			If ex.Number = 8152 Then
				Respuesta = "Has introducido demasiados caracteres en uno de los campos"
			ElseIf ex.Number = 2627 Then
				Respuesta = "Ya existe un empleado con ese Nombre y Apellido"
			ElseIf ex.Number = 515 Then
				Respuesta = "Sólo puedes dejar vacíos los campos Región, País y Teléfono"
			Else
				Respuesta = "Error al intentar ejecutar el procedimiento almacenado RecursosHumanos.InsertarEmpleado. " & ex.Message
			End If
		Finally

			If SqlConexion.State = ConnectionState.Open Then
				SqlConexion.Close()
			End If
		End Try

		Return Respuesta
	End Function

	Public Function Eliminar(parEmpleado As DEmpleados) As String
		Dim Respuesta As String = ""
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "RecursosHumanos.EliminarEmpleado"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParId_Empleado As New SqlParameter()
			ParId_Empleado.ParameterName = "@Id_Empleado"
			ParId_Empleado.SqlDbType = SqlDbType.Int
			ParId_Empleado.Value = parEmpleado.Id_Empleado
			SqlComando.Parameters.Add(ParId_Empleado)

			SqlComando.ExecuteNonQuery()
			Respuesta = "Y"

		Catch ex As SqlException
			If ex.Number = 547 Then
				Respuesta = "No puedes eliminar un empleado responsable de uno o varios Pedidos. Debes designar un nuevo responsable para los Pedidos de este empleado antes de eliminarlo."
			Else

				Respuesta = "Error al intentar ejecutar el procedimiento almacenado RecursosHumanos.EliminarEmpleado. " & ex.Message
			End If
		Finally

			If SqlConexion.State = ConnectionState.Open Then
				SqlConexion.Close()
			End If
		End Try

		Return Respuesta
	End Function

	Public Function Editar(parEmpleados As DEmpleados) As String
		Dim Respuesta As String = ""
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "RecursosHumanos.EditarEmpleado"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParId_Empleado As New SqlParameter()
			ParId_Empleado.ParameterName = "@Id_Empleado"
			ParId_Empleado.SqlDbType = SqlDbType.Int
			ParId_Empleado.Value = parEmpleados.Id_Empleado
			SqlComando.Parameters.Add(ParId_Empleado)

			Dim ParNombre_Empleado As New SqlParameter()
			ParNombre_Empleado.ParameterName = "@Nombre_Empleado"
			ParNombre_Empleado.SqlDbType = SqlDbType.VarChar
			ParNombre_Empleado.Size = parEmpleados.Nombre_Empleado.Length
			ParNombre_Empleado.Value = parEmpleados.Nombre_Empleado
			SqlComando.Parameters.Add(ParNombre_Empleado)

			Dim ParApellido_Empleado As New SqlParameter()
			ParApellido_Empleado.ParameterName = "@Apellido_Empleado"
			ParApellido_Empleado.SqlDbType = SqlDbType.VarChar
			ParApellido_Empleado.Size = parEmpleados.Apellido_Empleado.Length
			ParApellido_Empleado.Value = parEmpleados.Apellido_Empleado
			SqlComando.Parameters.Add(ParApellido_Empleado)

			Dim ParDireccion As New SqlParameter()
			ParDireccion.ParameterName = "@Direccion"
			ParDireccion.SqlDbType = SqlDbType.VarChar
			ParDireccion.Size = parEmpleados.Direccion.Length
			ParDireccion.Value = parEmpleados.Direccion
			SqlComando.Parameters.Add(ParDireccion)

			Dim ParCiudad As New SqlParameter()
			ParCiudad.ParameterName = "@Ciudad"
			ParCiudad.SqlDbType = SqlDbType.VarChar
			ParCiudad.Size = parEmpleados.Ciudad.Length
			ParCiudad.Value = parEmpleados.Ciudad
			SqlComando.Parameters.Add(ParCiudad)

			Dim ParRegion As New SqlParameter()
			ParRegion.ParameterName = "@Region"
			ParRegion.SqlDbType = SqlDbType.VarChar
			ParRegion.Size = parEmpleados.Region.Length
			ParRegion.Value = parEmpleados.Region
			SqlComando.Parameters.Add(ParRegion)

			Dim ParPais As New SqlParameter()
			ParPais.ParameterName = "@Pais"
			ParPais.SqlDbType = SqlDbType.VarChar
			ParPais.Size = parEmpleados.Pais.Length
			ParPais.Value = parEmpleados.Pais
			SqlComando.Parameters.Add(ParPais)

			Dim ParTelefono As New SqlParameter()
			ParTelefono.ParameterName = "@Telefono"
			ParTelefono.SqlDbType = SqlDbType.VarChar
			ParTelefono.Size = parEmpleados.Telefono.Length
			ParTelefono.Value = parEmpleados.Telefono
			SqlComando.Parameters.Add(ParTelefono)

			SqlComando.ExecuteNonQuery()
			Respuesta = "Y"

		Catch ex As SqlException
			If ex.Number = 8152 Then
				Respuesta = "Has introducido demasiados caracteres en uno de los campos"
			ElseIf ex.Number = 2627 Then
				Respuesta = "Ya existe un empleado con ese Nombre y Apellido"
			ElseIf ex.Number = 515 Then
				Respuesta = "Sólo puedes dejar vacíos los campos Región, País y Teléfono"
			Else
				Respuesta = "Error al intentar ejecutar el procedimiento almacenado RecursosHumanos.EditarEmpleado. " & ex.Message
			End If
		Finally

			If SqlConexion.State = ConnectionState.Open Then
				SqlConexion.Close()
			End If
		End Try

		Return Respuesta
	End Function
End Class
