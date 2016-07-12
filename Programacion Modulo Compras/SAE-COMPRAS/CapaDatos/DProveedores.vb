Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class DProveedores
	Public Property Id_Proveedor() As Integer
		Get
			Return m_Id_Proveedor
		End Get
		Set
			m_Id_Proveedor = Value
		End Set
	End Property
	Private m_Id_Proveedor As Integer
	Public Property Nombre_Proveedor() As [String]
		Get
			Return m_Nombre_Proveedor
		End Get
		Set
			m_Nombre_Proveedor = Value
		End Set
	End Property
	Private m_Nombre_Proveedor As [String]
	Public Property Nombre_Contacto() As [String]
		Get
			Return m_Nombre_Contacto
		End Get
		Set
			m_Nombre_Contacto = Value
		End Set
	End Property
	Private m_Nombre_Contacto As [String]
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
	Public Property Fax() As [String]
		Get
			Return m_Fax
		End Get
		Set
			m_Fax = Value
		End Set
	End Property
	Private m_Fax As [String]
	Public Property Email() As [String]
		Get
			Return m_Email
		End Get
		Set
			m_Email = Value
		End Set
	End Property
	Private m_Email As [String]
	Public Property Nombre_Proveedor_Buscado() As [String]
		Get
			Return m_Nombre_Proveedor_Buscado
		End Get
		Set
			m_Nombre_Proveedor_Buscado = Value
		End Set
	End Property
	Private m_Nombre_Proveedor_Buscado As [String]


	Public Sub New()
	End Sub

	Public Sub New(parId_Proveedor As Integer, parNombre_Proveedor As [String], parNombre_Contacto As [String], parDireccion As [String], parCiudad As [String], parRegion As [String], _
		parPais As [String], parTelefono As [String], parFax As [String], parEmail As [String], parNombre_Proveedor_Buscado As [String])
		Me.Id_Proveedor = parId_Proveedor
		Me.Nombre_Proveedor = parNombre_Proveedor
		Me.Nombre_Contacto = parNombre_Contacto
		Me.Direccion = parDireccion
		Me.Ciudad = parCiudad
		Me.Region = parRegion
		Me.Pais = parPais
		Me.Telefono = parTelefono
		Me.Fax = parFax
		Me.Email = parEmail
		Me.Nombre_Proveedor_Buscado = parNombre_Proveedor_Buscado
	End Sub

	Public Function ListaProveedores() As DataTable
		Dim TablaDatos As New DataTable("Compras.Proveedor")
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Compras.ListaProveedor"
			SqlComando.CommandType = CommandType.StoredProcedure

			SqlComando.ExecuteNonQuery()

			Dim SqlAdaptadorDatos As New SqlDataAdapter(SqlComando)
			SqlAdaptadorDatos.Fill(TablaDatos)

		Catch ex As Exception
			TablaDatos = Nothing
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado ListaProveedor. " & ex.Message, ex)
		Finally

			SqlConexion.Close()
		End Try

		Return TablaDatos
	End Function

	Public Function Mostrar(parNumeroPagina__1 As Integer, parRegistrosPorPagina__2 As Integer) As DataTable
		Dim TablaDatos As New DataTable("Compras.Proveedor")
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Compras.MostrarProveedor"
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
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado Compras.MostrarProveedores. " & ex.Message, ex)
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
			SqlComando.CommandText = "Compras.TamañoProveedor"
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
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado Compras.TamañoProveedores. " & ex.Message, ex)
		Finally

			SqlConexion.Close()
		End Try

		Return totalPaginas
	End Function

	Public Function Buscar(parProveedores As DProveedores) As DataTable
		Dim TablaDatos As New DataTable("Compras.Proveedor")
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Compras.BuscarProveedor"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParNombre_Proveedor_Buscado As New SqlParameter()
			ParNombre_Proveedor_Buscado.ParameterName = "@NombreProveedorBuscado"
			ParNombre_Proveedor_Buscado.SqlDbType = SqlDbType.VarChar
			ParNombre_Proveedor_Buscado.Size = parProveedores.Nombre_Proveedor_Buscado.Length
			ParNombre_Proveedor_Buscado.Value = parProveedores.Nombre_Proveedor_Buscado
			SqlComando.Parameters.Add(ParNombre_Proveedor_Buscado)

			Dim SqlAdaptadorDatos As New SqlDataAdapter(SqlComando)
			SqlAdaptadorDatos.Fill(TablaDatos)

		Catch ex As Exception
			TablaDatos = Nothing
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado Compras.BuscarProveedor. " & ex.Message, ex)
		Finally

			If SqlConexion.State = ConnectionState.Open Then
				SqlConexion.Close()
			End If
		End Try

		Return TablaDatos
	End Function

	Public Function Insertar(parProveedores As DProveedores) As String
		Dim Respuesta As String = ""
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Compras.InsertarProveedor"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParNombre_Proveedor As New SqlParameter()
			ParNombre_Proveedor.ParameterName = "@Nombre_Proveedor"
			ParNombre_Proveedor.SqlDbType = SqlDbType.VarChar
			ParNombre_Proveedor.Size = parProveedores.Nombre_Proveedor.Length
			ParNombre_Proveedor.Value = parProveedores.Nombre_Proveedor
			SqlComando.Parameters.Add(ParNombre_Proveedor)

			Dim ParNombre_Contacto As New SqlParameter()
			ParNombre_Contacto.ParameterName = "@Nombre_Contacto"
			ParNombre_Contacto.SqlDbType = SqlDbType.VarChar
			ParNombre_Contacto.Size = parProveedores.Nombre_Contacto.Length
			ParNombre_Contacto.Value = parProveedores.Nombre_Contacto
			SqlComando.Parameters.Add(ParNombre_Contacto)

			Dim ParDireccion As New SqlParameter()
			ParDireccion.ParameterName = "@Direccion"
			ParDireccion.SqlDbType = SqlDbType.VarChar
			ParDireccion.Size = parProveedores.Direccion.Length
			ParDireccion.Value = parProveedores.Direccion
			SqlComando.Parameters.Add(ParDireccion)

			Dim ParCiudad As New SqlParameter()
			ParCiudad.ParameterName = "@Ciudad"
			ParCiudad.SqlDbType = SqlDbType.VarChar
			ParCiudad.Size = parProveedores.Ciudad.Length
			ParCiudad.Value = parProveedores.Ciudad
			SqlComando.Parameters.Add(ParCiudad)

			Dim ParRegion As New SqlParameter()
			ParRegion.ParameterName = "@Region"
			ParRegion.SqlDbType = SqlDbType.VarChar
			ParRegion.Size = parProveedores.Region.Length
			ParRegion.Value = parProveedores.Region
			SqlComando.Parameters.Add(ParRegion)

			Dim ParPais As New SqlParameter()
			ParPais.ParameterName = "@Pais"
			ParPais.SqlDbType = SqlDbType.VarChar
			ParPais.Size = parProveedores.Pais.Length
			ParPais.Value = parProveedores.Pais
			SqlComando.Parameters.Add(ParPais)

			Dim ParTelefono As New SqlParameter()
			ParTelefono.ParameterName = "@Telefono"
			ParTelefono.SqlDbType = SqlDbType.VarChar
			ParTelefono.Size = parProveedores.Telefono.Length
			ParTelefono.Value = parProveedores.Telefono
			SqlComando.Parameters.Add(ParTelefono)

			Dim ParFax As New SqlParameter()
			ParFax.ParameterName = "@Fax"
			ParFax.SqlDbType = SqlDbType.VarChar
			ParFax.Size = parProveedores.Fax.Length
			ParFax.Value = parProveedores.Fax
			SqlComando.Parameters.Add(ParFax)

			Dim ParEmail As New SqlParameter()
			ParEmail.ParameterName = "@Email"
			ParEmail.SqlDbType = SqlDbType.VarChar
			ParEmail.Size = parProveedores.Email.Length
			ParEmail.Value = parProveedores.Email
			SqlComando.Parameters.Add(ParEmail)

			SqlComando.ExecuteNonQuery()
			Respuesta = "Y"

		Catch ex As SqlException
			If ex.Number = 8152 Then
				Respuesta = "Has introducido demasiados caracteres en uno de los campos"
			ElseIf ex.Number = 2627 Then
				Respuesta = "Ya existe un cliente con ese Nombre"
			ElseIf ex.Number = 515 Then
				Respuesta = "Sólo puedes dejar vacíos los campos Nombre de Contacto, Región, País, Teléfono, Fax y Email"
			Else
				Respuesta = "Error al intentar ejecutar el procedimiento almacenado Compras.InsertarProveedor. " & ex.Message
			End If
		Finally

			If SqlConexion.State = ConnectionState.Open Then
				SqlConexion.Close()
			End If
		End Try

		Return Respuesta
	End Function

	Public Function Eliminar(parProveedores As DProveedores) As String
		Dim Respuesta As String = ""
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Compras.EliminarProveedor"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParId_Proveedor As New SqlParameter()
			ParId_Proveedor.ParameterName = "@Id_Proveedor"
			ParId_Proveedor.SqlDbType = SqlDbType.Int
			ParId_Proveedor.Value = parProveedores.Id_Proveedor
			SqlComando.Parameters.Add(ParId_Proveedor)

			SqlComando.ExecuteNonQuery()
			Respuesta = "Y"

		Catch ex As SqlException
			If ex.Number = 547 Then
				Respuesta = "No puedes eliminar un cliente que cuenta con uno o varios Pedidos. Debes eliminar o actualizar sus Pedidos antes de eliminar el cliente."
			Else

				Respuesta = "Error al intentar ejecutar el procedimiento almacenado Compras.EliminarProveedor. " & ex.Message
			End If
		Finally

			If SqlConexion.State = ConnectionState.Open Then
				SqlConexion.Close()
			End If
		End Try

		Return Respuesta
	End Function

	Public Function Editar(parProveedores As DProveedores) As String
		Dim Respuesta As String = ""
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Compras.EditarProveedor"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParId_Proveedor As New SqlParameter()
			ParId_Proveedor.ParameterName = "@Id_Proveedor"
			ParId_Proveedor.SqlDbType = SqlDbType.Int
			ParId_Proveedor.Value = parProveedores.Id_Proveedor
			SqlComando.Parameters.Add(ParId_Proveedor)

			Dim ParNombre_Proveedor As New SqlParameter()
			ParNombre_Proveedor.ParameterName = "@Nombre_Proveedor"
			ParNombre_Proveedor.SqlDbType = SqlDbType.VarChar
			ParNombre_Proveedor.Size = parProveedores.Nombre_Proveedor.Length
			ParNombre_Proveedor.Value = parProveedores.Nombre_Proveedor
			SqlComando.Parameters.Add(ParNombre_Proveedor)

			Dim ParNombre_Contacto As New SqlParameter()
			ParNombre_Contacto.ParameterName = "@Nombre_Contacto"
			ParNombre_Contacto.SqlDbType = SqlDbType.VarChar
			ParNombre_Contacto.Size = parProveedores.Nombre_Contacto.Length
			ParNombre_Contacto.Value = parProveedores.Nombre_Contacto
			SqlComando.Parameters.Add(ParNombre_Contacto)

			Dim ParDireccion As New SqlParameter()
			ParDireccion.ParameterName = "@Direccion"
			ParDireccion.SqlDbType = SqlDbType.VarChar
			ParDireccion.Size = parProveedores.Direccion.Length
			ParDireccion.Value = parProveedores.Direccion
			SqlComando.Parameters.Add(ParDireccion)

			Dim ParCiudad As New SqlParameter()
			ParCiudad.ParameterName = "@Ciudad"
			ParCiudad.SqlDbType = SqlDbType.VarChar
			ParCiudad.Size = parProveedores.Ciudad.Length
			ParCiudad.Value = parProveedores.Ciudad
			SqlComando.Parameters.Add(ParCiudad)

			Dim ParRegion As New SqlParameter()
			ParRegion.ParameterName = "@Region"
			ParRegion.SqlDbType = SqlDbType.VarChar
			ParRegion.Size = parProveedores.Region.Length
			ParRegion.Value = parProveedores.Region
			SqlComando.Parameters.Add(ParRegion)

			Dim ParPais As New SqlParameter()
			ParPais.ParameterName = "@Pais"
			ParPais.SqlDbType = SqlDbType.VarChar
			ParPais.Size = parProveedores.Pais.Length
			ParPais.Value = parProveedores.Pais
			SqlComando.Parameters.Add(ParPais)

			Dim ParTelefono As New SqlParameter()
			ParTelefono.ParameterName = "@Telefono"
			ParTelefono.SqlDbType = SqlDbType.VarChar
			ParTelefono.Size = parProveedores.Telefono.Length
			ParTelefono.Value = parProveedores.Telefono
			SqlComando.Parameters.Add(ParTelefono)

			Dim ParFax As New SqlParameter()
			ParFax.ParameterName = "@Fax"
			ParFax.SqlDbType = SqlDbType.VarChar
			ParFax.Size = parProveedores.Fax.Length
			ParFax.Value = parProveedores.Fax
			SqlComando.Parameters.Add(ParFax)

			Dim ParEmail As New SqlParameter()
			ParEmail.ParameterName = "@Email"
			ParEmail.SqlDbType = SqlDbType.VarChar
			ParEmail.Size = parProveedores.Email.Length
			ParEmail.Value = parProveedores.Email
			SqlComando.Parameters.Add(ParEmail)

			SqlComando.ExecuteNonQuery()
			Respuesta = "Y"

		Catch ex As SqlException
			If ex.Number = 8152 Then
				Respuesta = "Has introducido demasiados caracteres en uno de los campos."
			ElseIf ex.Number = 2627 Then
				Respuesta = "Ya existe un cliente con ese Nombre"
			ElseIf ex.Number = 515 Then
				Respuesta = "Sólo puedes dejar vacíos los campos Nombre de Contacto, Región, País, Teléfono, Fax y Email"
			Else
				Respuesta = "Error al intentar ejecutar el procedimiento almacenado Compras.EditarProveedor. " & ex.Message
			End If
		Finally

			If SqlConexion.State = ConnectionState.Open Then
				SqlConexion.Close()
			End If
		End Try

		Return Respuesta
	End Function
End Class
