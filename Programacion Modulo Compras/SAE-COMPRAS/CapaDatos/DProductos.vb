Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class DProductos
	Public Property Id_Producto() As Integer
		Get
			Return m_Id_Producto
		End Get
		Set
			m_Id_Producto = Value
		End Set
	End Property
	Private m_Id_Producto As Integer
	Public Property Nombre_Producto() As [String]
		Get
			Return m_Nombre_Producto
		End Get
		Set
			m_Nombre_Producto = Value
		End Set
	End Property
	Private m_Nombre_Producto As [String]
	Public Property Nombre_Categoria() As [String]
		Get
			Return m_Nombre_Categoria
		End Get
		Set
			m_Nombre_Categoria = Value
		End Set
	End Property
	Private m_Nombre_Categoria As [String]
	Public Property Precio_Unitario() As Decimal
		Get
			Return m_Precio_Unitario
		End Get
		Set
			m_Precio_Unitario = Value
		End Set
	End Property
	Private m_Precio_Unitario As Decimal
	Public Property Detalles() As [String]
		Get
			Return m_Detalles
		End Get
		Set
			m_Detalles = Value
		End Set
	End Property
	Private m_Detalles As [String]
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

	Public Sub New(parId_Producto As Integer, parNombre_Producto As [String], parNombre_Categoria As [String], parPrecio_Unitario As Decimal, parDetalles As [String], parNombre_Buscado As [String])
		Me.Id_Producto = parId_Producto
		Me.Nombre_Producto = parNombre_Producto
		Me.Nombre_Categoria = parNombre_Categoria
		Me.Precio_Unitario = parPrecio_Unitario
		Me.Detalles = parDetalles
		Me.Nombre_Buscado = parNombre_Buscado
	End Sub

	Public Function ListaProductos() As DataTable
		Dim TablaDatos As New DataTable("Produccion.Productos")
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Produccion.ListaProductos"
			SqlComando.CommandType = CommandType.StoredProcedure

			SqlComando.ExecuteNonQuery()

			Dim SqlAdaptadorDatos As New SqlDataAdapter(SqlComando)
			SqlAdaptadorDatos.Fill(TablaDatos)

		Catch ex As Exception
			TablaDatos = Nothing
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado Produccion.ListaProductos. " & ex.Message, ex)
		Finally

			SqlConexion.Close()
		End Try

		Return TablaDatos
	End Function

	Public Function PrecioProducto(parIdBuscado__1 As Integer) As Decimal
		Dim precio As Decimal = 0
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Produccion.PrecioProducto"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParIdBuscado__2 As New SqlParameter()
			ParIdBuscado__2.ParameterName = "@IdBuscado"
			ParIdBuscado__2.SqlDbType = SqlDbType.Int
			ParIdBuscado__2.Value = parIdBuscado__1
			SqlComando.Parameters.Add(ParIdBuscado__2)

			Dim ParPrecio As New SqlParameter()
			ParPrecio.ParameterName = "@Precio"
			ParPrecio.SqlDbType = SqlDbType.Money
			ParPrecio.Direction = ParameterDirection.Output
			SqlComando.Parameters.Add(ParPrecio)

			SqlComando.ExecuteNonQuery()


			precio = Convert.ToDecimal(ParPrecio.Value.ToString())

		Catch ex As Exception
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado Produccion.PrecioProducto. " & ex.Message, ex)
		Finally

			SqlConexion.Close()
		End Try

		Return precio
	End Function

	Public Function Mostrar(parNumeroPagina__1 As Integer, parRegistrosPorPagina__2 As Integer) As DataTable
		Dim TablaDatos As New DataTable("Produccion.v_Productos_NombreCategorias")
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Produccion.MostrarProductos"
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
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado Produccion.MostrarProductos. " & ex.Message, ex)
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
			SqlComando.CommandText = "Produccion.TamañoProductos"
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
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado Produccion.TamañoProductos. " & ex.Message, ex)
		Finally

			SqlConexion.Close()
		End Try

		Return totalPaginas
	End Function

	Public Function Buscar(parProductos As DProductos) As DataTable
		Dim TablaDatos As New DataTable("Produccion.v_Productos_NombreCategorias")
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Produccion.BuscarProducto"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParNombre_Buscado As New SqlParameter()
			ParNombre_Buscado.ParameterName = "@NombreBuscado"
			ParNombre_Buscado.SqlDbType = SqlDbType.VarChar
			ParNombre_Buscado.Size = parProductos.Nombre_Buscado.Length
			ParNombre_Buscado.Value = parProductos.Nombre_Buscado
			SqlComando.Parameters.Add(ParNombre_Buscado)

			Dim SqlAdaptadorDatos As New SqlDataAdapter(SqlComando)
			SqlAdaptadorDatos.Fill(TablaDatos)

		Catch ex As Exception
			TablaDatos = Nothing
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado Produccion.BuscarProducto. " & ex.Message, ex)
		Finally

			If SqlConexion.State = ConnectionState.Open Then
				SqlConexion.Close()
			End If
		End Try

		Return TablaDatos
	End Function

	Public Function Insertar(parProductos As DProductos) As String
		Dim Respuesta As String = ""
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Produccion.InsertarProducto"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParNombre_Producto As New SqlParameter()
			ParNombre_Producto.ParameterName = "@Nombre_Producto"
			ParNombre_Producto.SqlDbType = SqlDbType.VarChar
			ParNombre_Producto.Size = parProductos.Nombre_Producto.Length
			ParNombre_Producto.Value = parProductos.Nombre_Producto
			SqlComando.Parameters.Add(ParNombre_Producto)

			Dim ParNombre_Categoria As New SqlParameter()
			ParNombre_Categoria.ParameterName = "@Nombre_Categoria"
			ParNombre_Categoria.SqlDbType = SqlDbType.VarChar
			ParNombre_Categoria.Size = parProductos.Nombre_Categoria.Length
			ParNombre_Categoria.Value = parProductos.Nombre_Categoria
			SqlComando.Parameters.Add(ParNombre_Categoria)

			Dim ParPrecio_Unitario As New SqlParameter()
			ParPrecio_Unitario.ParameterName = "@Precio_Unitario"
			ParPrecio_Unitario.SqlDbType = SqlDbType.Money
			ParPrecio_Unitario.Value = parProductos.Precio_Unitario
			SqlComando.Parameters.Add(ParPrecio_Unitario)

			Dim ParDetalles As New SqlParameter()
			ParDetalles.ParameterName = "@Detalles"
			ParDetalles.SqlDbType = SqlDbType.VarChar
			ParDetalles.Size = parProductos.Detalles.Length
			ParDetalles.Value = parProductos.Detalles
			SqlComando.Parameters.Add(ParDetalles)

			SqlComando.ExecuteNonQuery()
			Respuesta = "Y"

		Catch ex As SqlException
			If ex.Number = 8152 Then
				Respuesta = "Has introducido demasiados caracteres en uno de los campos"
			ElseIf ex.Number = 2627 Then
				Respuesta = "Ya existe un producto con ese Nombre"
			ElseIf ex.Number = 515 Then
				Respuesta = "No puedes dejar los campos Nombre y Categoría vacíos"
			ElseIf ex.Number = 50000 Then
				Respuesta = "Debes ingresar el nombre de una Categoría existente. Para ingresar una nueva Categoría, primero debes crearla."
			Else
				Respuesta = "Error al intentar ejecutar el procedimiento almacenado Produccion.InsertarProducto. " & ex.Message
			End If
		Finally

			If SqlConexion.State = ConnectionState.Open Then
				SqlConexion.Close()
			End If
		End Try

		Return Respuesta
	End Function

	Public Function Eliminar(parProductos As DProductos) As String
		Dim Respuesta As String = ""
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Produccion.EliminarProducto"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParId_Producto As New SqlParameter()
			ParId_Producto.ParameterName = "@Id_Producto"
			ParId_Producto.SqlDbType = SqlDbType.Int
			ParId_Producto.Value = parProductos.Id_Producto
			SqlComando.Parameters.Add(ParId_Producto)

			SqlComando.ExecuteNonQuery()
			Respuesta = "Y"

		Catch ex As SqlException
			If ex.Number = 547 Then
				Respuesta = "No puedes eliminar un producto presente en un Pedido. Debes eliminar o actualizar los Pedidos antes de eliminar el producto."
			Else

				Respuesta = "Error al intentar ejecutar el procedimiento almacenado Produccion.EliminarProducto. " & ex.Message
			End If
		Finally

			If SqlConexion.State = ConnectionState.Open Then
				SqlConexion.Close()
			End If
		End Try

		Return Respuesta
	End Function

	Public Function Editar(parProductos As DProductos) As String
		Dim Respuesta As String = ""
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Produccion.EditarProducto"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParId_Producto As New SqlParameter()
			ParId_Producto.ParameterName = "@Id_Producto"
			ParId_Producto.SqlDbType = SqlDbType.Int
			ParId_Producto.Value = parProductos.Id_Producto
			SqlComando.Parameters.Add(ParId_Producto)

			Dim ParNombre_Producto As New SqlParameter()
			ParNombre_Producto.ParameterName = "@Nombre_Producto"
			ParNombre_Producto.SqlDbType = SqlDbType.VarChar
			ParNombre_Producto.Size = parProductos.Nombre_Producto.Length
			ParNombre_Producto.Value = parProductos.Nombre_Producto
			SqlComando.Parameters.Add(ParNombre_Producto)

			Dim ParNombre_Categoria As New SqlParameter()
			ParNombre_Categoria.ParameterName = "@Nombre_Categoria"
			ParNombre_Categoria.SqlDbType = SqlDbType.VarChar
			ParNombre_Categoria.Size = parProductos.Nombre_Categoria.Length
			ParNombre_Categoria.Value = parProductos.Nombre_Categoria
			SqlComando.Parameters.Add(ParNombre_Categoria)

			Dim ParPrecio_Unitario As New SqlParameter()
			ParPrecio_Unitario.ParameterName = "@Precio_Unitario"
			ParPrecio_Unitario.SqlDbType = SqlDbType.Money
			ParPrecio_Unitario.Value = parProductos.Precio_Unitario
			SqlComando.Parameters.Add(ParPrecio_Unitario)

			Dim ParDetalles As New SqlParameter()
			ParDetalles.ParameterName = "@Detalles"
			ParDetalles.SqlDbType = SqlDbType.VarChar
			ParDetalles.Size = parProductos.Detalles.Length
			ParDetalles.Value = parProductos.Detalles
			SqlComando.Parameters.Add(ParDetalles)

			SqlComando.ExecuteNonQuery()
			Respuesta = "Y"

		Catch ex As SqlException
			If ex.Number = 8152 Then
				Respuesta = "Has introducido demasiados caracteres en uno de los campos"
			ElseIf ex.Number = 2627 Then
				Respuesta = "Ya existe un producto con ese Nombre"
			ElseIf ex.Number = 515 Then
				Respuesta = "No puedes dejar los campos Nombre y Categoría vacíos"
			ElseIf ex.Number = 50000 Then
				Respuesta = "Debes ingresar el nombre de una Categoría existente. Para ingresar una nueva Categoría, primero debes crearla."
			Else
				Respuesta = "Error al intentar ejecutar el procedimiento almacenado Produccion.EditarProducto. " & ex.Message
			End If
		Finally

			If SqlConexion.State = ConnectionState.Open Then
				SqlConexion.Close()
			End If
		End Try

		Return Respuesta
	End Function
End Class
