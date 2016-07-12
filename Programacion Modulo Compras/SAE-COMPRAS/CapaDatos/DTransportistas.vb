Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class DTransportistas
	Public Property Id_Transportista() As Integer
		Get
			Return m_Id_Transportista
		End Get
		Set
			m_Id_Transportista = Value
		End Set
	End Property
	Private m_Id_Transportista As Integer
	Public Property Nombre_Empresa() As [String]
		Get
			Return m_Nombre_Empresa
		End Get
		Set
			m_Nombre_Empresa = Value
		End Set
	End Property
	Private m_Nombre_Empresa As [String]
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
	Public Property Nombre_Buscado() As [String]
		Get
			Return m_Nombre_Buscado
		End Get
		Set
			m_Nombre_Buscado = Value
		End Set
	End Property
	Private m_Nombre_Buscado As [String]


	Public Sub New()
	End Sub

	Public Sub New(parId_Transportista As Integer, parNombre_Empresa As [String], parDireccion As [String], parCiudad As [String], parRegion As [String], parPais As [String], _
		parTelefono As [String], parNombre_Buscado As [String])
		Me.Id_Transportista = parId_Transportista
		Me.Nombre_Empresa = parNombre_Empresa
		Me.Direccion = parDireccion
		Me.Ciudad = parCiudad
		Me.Region = parRegion
		Me.Pais = parPais
		Me.Telefono = parTelefono
		Me.Nombre_Buscado = parNombre_Buscado
	End Sub

	Public Function ListaTransportistas() As DataTable
		Dim TablaDatos As New DataTable("Compras.Transportistas")
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Compras.ListaTransportistas"
			SqlComando.CommandType = CommandType.StoredProcedure

			SqlComando.ExecuteNonQuery()

			Dim SqlAdaptadorDatos As New SqlDataAdapter(SqlComando)
			SqlAdaptadorDatos.Fill(TablaDatos)

		Catch ex As Exception
			TablaDatos = Nothing
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado Compras.ListaTransportistas. " & ex.Message, ex)
		Finally

			SqlConexion.Close()
		End Try

		Return TablaDatos
	End Function

	Public Function Mostrar(parNumeroPagina__1 As Integer, parRegistrosPorPagina__2 As Integer) As DataTable
		Dim TablaDatos As New DataTable("Compras.Transportistas")
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Compras.MostrarTransportistas"
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
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado Compras.MostrarTransportistas. " & ex.Message, ex)
		Finally

			SqlConexion.Close()
		End Try

		Return TablaDatos
	End Function

	Public Function Tamaño(parRegistrosPorPagina__1 As Integer) As Integer
		Dim totalPaginas As Integer = 1
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Compras.TamañoTransportistas"
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
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado Compras.TamañoTransportistas. " & ex.Message, ex)
		Finally

			SqlConexion.Close()
		End Try

		Return totalPaginas
	End Function

	Public Function Buscar(parTransportistas As DTransportistas) As DataTable
		Dim TablaDatos As New DataTable("Compras.BuscarTransportista")
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Compras.BuscarTransportista"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParNombre_Buscado As New SqlParameter()
			ParNombre_Buscado.ParameterName = "@NombreBuscado"
			ParNombre_Buscado.SqlDbType = SqlDbType.VarChar
			ParNombre_Buscado.Size = parTransportistas.Nombre_Buscado.Length
			ParNombre_Buscado.Value = parTransportistas.Nombre_Buscado
			SqlComando.Parameters.Add(ParNombre_Buscado)

			Dim SqlAdaptadorDatos As New SqlDataAdapter(SqlComando)
			SqlAdaptadorDatos.Fill(TablaDatos)

		Catch ex As Exception
			TablaDatos = Nothing
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado Compras.BuscarTransportistas. " & ex.Message, ex)
		Finally

			If SqlConexion.State = ConnectionState.Open Then
				SqlConexion.Close()
			End If
		End Try

		Return TablaDatos
	End Function

	Public Function Insertar(parTransportistas As DTransportistas) As String
		Dim Respuesta As String = ""
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Compras.InsertarTransportista"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParNombre_Empresa As New SqlParameter()
			ParNombre_Empresa.ParameterName = "@Nombre_Empresa"
			ParNombre_Empresa.SqlDbType = SqlDbType.VarChar
			ParNombre_Empresa.Size = parTransportistas.Nombre_Empresa.Length
			ParNombre_Empresa.Value = parTransportistas.Nombre_Empresa
			SqlComando.Parameters.Add(ParNombre_Empresa)

			Dim ParDireccion As New SqlParameter()
			ParDireccion.ParameterName = "@Direccion"
			ParDireccion.SqlDbType = SqlDbType.VarChar
			ParDireccion.Size = parTransportistas.Direccion.Length
			ParDireccion.Value = parTransportistas.Direccion
			SqlComando.Parameters.Add(ParDireccion)

			Dim ParCiudad As New SqlParameter()
			ParCiudad.ParameterName = "@Ciudad"
			ParCiudad.SqlDbType = SqlDbType.VarChar
			ParCiudad.Size = parTransportistas.Ciudad.Length
			ParCiudad.Value = parTransportistas.Ciudad
			SqlComando.Parameters.Add(ParCiudad)

			Dim ParRegion As New SqlParameter()
			ParRegion.ParameterName = "@Region"
			ParRegion.SqlDbType = SqlDbType.VarChar
			ParRegion.Size = parTransportistas.Region.Length
			ParRegion.Value = parTransportistas.Region
			SqlComando.Parameters.Add(ParRegion)

			Dim ParPais As New SqlParameter()
			ParPais.ParameterName = "@Pais"
			ParPais.SqlDbType = SqlDbType.VarChar
			ParPais.Size = parTransportistas.Pais.Length
			ParPais.Value = parTransportistas.Pais
			SqlComando.Parameters.Add(ParPais)

			Dim ParTelefono As New SqlParameter()
			ParTelefono.ParameterName = "@Telefono"
			ParTelefono.SqlDbType = SqlDbType.VarChar
			ParTelefono.Size = parTransportistas.Telefono.Length
			ParTelefono.Value = parTransportistas.Telefono
			SqlComando.Parameters.Add(ParTelefono)

			SqlComando.ExecuteNonQuery()
			Respuesta = "Y"

		Catch ex As SqlException
			If ex.Number = 8152 Then
				Respuesta = "Has introducido demasiados caracteres en uno de los campos"
			ElseIf ex.Number = 2627 Then
				Respuesta = "Ya existe un transportista con ese Nombre"
			ElseIf ex.Number = 515 Then
				Respuesta = "Sólo puedes dejar vacíos los campos Región, País y Teléfono"
			Else
				Respuesta = "Error al intentar ejecutar el procedimiento almacenado Compras.InsertarTransportista. " & ex.Message
			End If
		Finally

			If SqlConexion.State = ConnectionState.Open Then
				SqlConexion.Close()
			End If
		End Try

		Return Respuesta
	End Function

	Public Function Eliminar(parTransportistas As DTransportistas) As String
		Dim Respuesta As String = ""
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Compras.EliminarTransportista"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParId_Transportista As New SqlParameter()
			ParId_Transportista.ParameterName = "@Id_Transportista"
			ParId_Transportista.SqlDbType = SqlDbType.Int
			ParId_Transportista.Value = parTransportistas.Id_Transportista
			SqlComando.Parameters.Add(ParId_Transportista)

			SqlComando.ExecuteNonQuery()
			Respuesta = "Y"

		Catch ex As SqlException
			If ex.Number = 547 Then
				Respuesta = "No puedes eliminar un transportista responsable de uno o varios Pedidos. Debes designar un nuevo responsable para los Pedidos de este transportista antes de eliminarlo."
			Else

				Respuesta = "Error al intentar ejecutar el procedimiento almacenado Compras.EliminarTransportista. " & ex.Message
			End If
		Finally

			If SqlConexion.State = ConnectionState.Open Then
				SqlConexion.Close()
			End If
		End Try

		Return Respuesta
	End Function

	Public Function Editar(parTransportistas As DTransportistas) As String
		Dim Respuesta As String = ""
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Compras.EditarTransportista"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParId_Transportista As New SqlParameter()
			ParId_Transportista.ParameterName = "@Id_Transportista"
			ParId_Transportista.SqlDbType = SqlDbType.Int
			ParId_Transportista.Value = parTransportistas.Id_Transportista
			SqlComando.Parameters.Add(ParId_Transportista)

			Dim ParNombre_Empresa As New SqlParameter()
			ParNombre_Empresa.ParameterName = "@Nombre_Empresa"
			ParNombre_Empresa.SqlDbType = SqlDbType.VarChar
			ParNombre_Empresa.Size = parTransportistas.Nombre_Empresa.Length
			ParNombre_Empresa.Value = parTransportistas.Nombre_Empresa
			SqlComando.Parameters.Add(ParNombre_Empresa)

			Dim ParDireccion As New SqlParameter()
			ParDireccion.ParameterName = "@Direccion"
			ParDireccion.SqlDbType = SqlDbType.VarChar
			ParDireccion.Size = parTransportistas.Direccion.Length
			ParDireccion.Value = parTransportistas.Direccion
			SqlComando.Parameters.Add(ParDireccion)

			Dim ParCiudad As New SqlParameter()
			ParCiudad.ParameterName = "@Ciudad"
			ParCiudad.SqlDbType = SqlDbType.VarChar
			ParCiudad.Size = parTransportistas.Ciudad.Length
			ParCiudad.Value = parTransportistas.Ciudad
			SqlComando.Parameters.Add(ParCiudad)

			Dim ParRegion As New SqlParameter()
			ParRegion.ParameterName = "@Region"
			ParRegion.SqlDbType = SqlDbType.VarChar
			ParRegion.Size = parTransportistas.Region.Length
			ParRegion.Value = parTransportistas.Region
			SqlComando.Parameters.Add(ParRegion)

			Dim ParPais As New SqlParameter()
			ParPais.ParameterName = "@Pais"
			ParPais.SqlDbType = SqlDbType.VarChar
			ParPais.Size = parTransportistas.Pais.Length
			ParPais.Value = parTransportistas.Pais
			SqlComando.Parameters.Add(ParPais)

			Dim ParTelefono As New SqlParameter()
			ParTelefono.ParameterName = "@Telefono"
			ParTelefono.SqlDbType = SqlDbType.VarChar
			ParTelefono.Size = parTransportistas.Telefono.Length
			ParTelefono.Value = parTransportistas.Telefono
			SqlComando.Parameters.Add(ParTelefono)

			SqlComando.ExecuteNonQuery()
			Respuesta = "Y"

		Catch ex As SqlException
			If ex.Number = 8152 Then
				Respuesta = "Has introducido demasiados caracteres en uno de los campos"
			ElseIf ex.Number = 2627 Then
				Respuesta = "Ya existe un transportista con ese Nombre"
			ElseIf ex.Number = 515 Then
				Respuesta = "Sólo puedes dejar vacíos los campos Región, País y Teléfono"
			Else
				Respuesta = "Error al intentar ejecutar el procedimiento almacenado Compras.EditarTransportista. " & ex.Message
			End If
		Finally

			If SqlConexion.State = ConnectionState.Open Then
				SqlConexion.Close()
			End If
		End Try

		Return Respuesta
	End Function
End Class
