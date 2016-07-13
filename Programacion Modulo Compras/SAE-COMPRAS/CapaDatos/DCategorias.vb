Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class DCategorias
	Public Property Id_Categoria() As Integer
		Get
			Return m_Id_Categoria
		End Get
		Set
			m_Id_Categoria = Value
		End Set
	End Property
	Private m_Id_Categoria As Integer
	Public Property Nombre_Categoria() As [String]
		Get
			Return m_Nombre_Categoria
		End Get
		Set
			m_Nombre_Categoria = Value
		End Set
	End Property
	Private m_Nombre_Categoria As [String]
	Public Property Descripcion() As [String]
		Get
			Return m_Descripcion
		End Get
		Set
			m_Descripcion = Value
		End Set
	End Property
	Private m_Descripcion As [String]
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

	Public Sub New(parId_Categoria As Integer, parNombre_Categoria As [String], parDescripcion As [String], parNombre_Categoria_Buscado As [String])
		Me.Id_Categoria = parId_Categoria
		Me.Nombre_Categoria = parNombre_Categoria
		Me.Descripcion = parDescripcion
		Me.Nombre_Buscado = parNombre_Categoria_Buscado
	End Sub

	Public Function ListaCategorias() As DataTable
		Dim TablaDatos As New DataTable("Produccion.Categorias")
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Produccion.ListaCategorias"
			SqlComando.CommandType = CommandType.StoredProcedure

			SqlComando.ExecuteNonQuery()

			Dim SqlAdaptadorDatos As New SqlDataAdapter(SqlComando)
			SqlAdaptadorDatos.Fill(TablaDatos)

		Catch ex As Exception
			TablaDatos = Nothing
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado Produccion.ListaCategorias. " & ex.Message, ex)
		Finally

			SqlConexion.Close()
		End Try

		Return TablaDatos
	End Function

	Public Function Mostrar(parNumeroPagina__1 As Integer, parRegistrosPorPagina__2 As Integer) As DataTable
		Dim TablaDatos As New DataTable("Produccion.Categorias")
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Produccion.MostrarCategorias"
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
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado Produccion.MostrarCategorias. " & ex.Message, ex)
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
			SqlComando.CommandText = "Produccion.TamañoCategorias"
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
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado Produccion.TamañoCategorias. " & ex.Message, ex)
		Finally

			SqlConexion.Close()
		End Try

		Return totalPaginas
	End Function

	Public Function Buscar(parCategorias As DCategorias) As DataTable
		Dim TablaDatos As New DataTable("Produccion.Categorias")
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Produccion.BuscarCategoria"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParNombre_Buscado As New SqlParameter()
			ParNombre_Buscado.ParameterName = "@NombreBuscado"
			ParNombre_Buscado.SqlDbType = SqlDbType.VarChar
			ParNombre_Buscado.Size = parCategorias.Nombre_Buscado.Length
			ParNombre_Buscado.Value = parCategorias.Nombre_Buscado
			SqlComando.Parameters.Add(ParNombre_Buscado)

			Dim SqlAdaptadorDatos As New SqlDataAdapter(SqlComando)
			SqlAdaptadorDatos.Fill(TablaDatos)

		Catch ex As Exception
			TablaDatos = Nothing
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado Produccion.BuscarCategoria. " & ex.Message, ex)
		Finally

			If SqlConexion.State = ConnectionState.Open Then
				SqlConexion.Close()
			End If
		End Try

		Return TablaDatos
	End Function

	Public Function Insertar(parCategorias As DCategorias) As String
		Dim Respuesta As String = ""
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Produccion.InsertarCategoria"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParNombre_Categoria As New SqlParameter()
			ParNombre_Categoria.ParameterName = "@Nombre_Categoria"
			ParNombre_Categoria.SqlDbType = SqlDbType.VarChar
			ParNombre_Categoria.Size = parCategorias.Nombre_Categoria.Length
			ParNombre_Categoria.Value = parCategorias.Nombre_Categoria
			SqlComando.Parameters.Add(ParNombre_Categoria)

			Dim ParDescripcion As New SqlParameter()
			ParDescripcion.ParameterName = "@Descripcion"
			ParDescripcion.SqlDbType = SqlDbType.VarChar
			ParDescripcion.Size = parCategorias.Descripcion.Length
			ParDescripcion.Value = parCategorias.Descripcion
			SqlComando.Parameters.Add(ParDescripcion)

			SqlComando.ExecuteNonQuery()
			Respuesta = "Y"

		Catch ex As SqlException
			If ex.Number = 8152 Then
				Respuesta = "Has introducido demasiados caracteres en uno de los campos."
			ElseIf ex.Number = 2627 Then
				Respuesta = "Ya existe una categoría con ese Nombre."
			ElseIf ex.Number = 515 Then
				Respuesta = "No puedes dejar el campo Nombre vacío."
			Else
				Respuesta = "Error al intentar ejecutar el procedimiento almacenado Produccion.InsertarCategoria. " & ex.Message
			End If
		Finally

			If SqlConexion.State = ConnectionState.Open Then
				SqlConexion.Close()
			End If
		End Try

		Return Respuesta
	End Function

	Public Function Eliminar(parCategorias As DCategorias) As String
		Dim Respuesta As String = ""
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Produccion.EliminarCategoria"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParId_Categoria As New SqlParameter()
			ParId_Categoria.ParameterName = "@Id_Categoria"
			ParId_Categoria.SqlDbType = SqlDbType.Int
			ParId_Categoria.Value = parCategorias.Id_Categoria
			SqlComando.Parameters.Add(ParId_Categoria)

			SqlComando.ExecuteNonQuery()
			Respuesta = "Y"

		Catch ex As SqlException
			If ex.Number = 547 Then
				Respuesta = "No puedes eliminar una categoría que cuenta con Productos. Debes eliminar o actualizar sus Productos antes de eliminar la categoría."
			Else

				Respuesta = "Error al intentar ejecutar el procedimiento almacenado Produccion.EliminarCategoria. " & ex.Message
			End If
		Finally

			If SqlConexion.State = ConnectionState.Open Then
				SqlConexion.Close()
			End If
		End Try

		Return Respuesta
	End Function

	Public Function Editar(parCategorias As DCategorias) As String
		Dim Respuesta As String = ""
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Produccion.EditarCategoria"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParId_Categoria As New SqlParameter()
			ParId_Categoria.ParameterName = "@Id_Categoria"
			ParId_Categoria.SqlDbType = SqlDbType.Int
			ParId_Categoria.Value = parCategorias.Id_Categoria
			SqlComando.Parameters.Add(ParId_Categoria)

			Dim ParNombre_Categoria As New SqlParameter()
			ParNombre_Categoria.ParameterName = "@Nombre_Categoria"
			ParNombre_Categoria.SqlDbType = SqlDbType.VarChar
			ParNombre_Categoria.Size = parCategorias.Nombre_Categoria.Length
			ParNombre_Categoria.Value = parCategorias.Nombre_Categoria
			SqlComando.Parameters.Add(ParNombre_Categoria)

			Dim ParDescripcion As New SqlParameter()
			ParDescripcion.ParameterName = "@Descripcion"
			ParDescripcion.SqlDbType = SqlDbType.VarChar
			ParDescripcion.Size = parCategorias.Descripcion.Length
			ParDescripcion.Value = parCategorias.Descripcion
			SqlComando.Parameters.Add(ParDescripcion)

			SqlComando.ExecuteNonQuery()
			Respuesta = "Y"

		Catch ex As SqlException
			If ex.Number = 8152 Then
				Respuesta = "Has introducido demasiados caracteres en uno de los campos."
			ElseIf ex.Number = 2627 Then
				Respuesta = "Ya existe una categoría con ese Nombre."
			ElseIf ex.Number = 515 Then
				Respuesta = "No puedes dejar el campo Nombre vacío."
			Else
				Respuesta = "Error al intentar ejecutar el procedimiento almacenado Produccion.EditarCategoria. " & ex.Message
			End If
		Finally

			If SqlConexion.State = ConnectionState.Open Then
				SqlConexion.Close()
			End If
		End Try

		Return Respuesta
	End Function
End Class
