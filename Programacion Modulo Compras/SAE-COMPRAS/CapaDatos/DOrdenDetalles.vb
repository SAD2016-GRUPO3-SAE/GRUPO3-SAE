Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class DOrdenDetalles
	Public Property Id_Orden() As Integer
		Get
			Return m_Id_Orden
		End Get
		Set
			m_Id_Orden = Value
		End Set
	End Property
	Private m_Id_Orden As Integer
	Public Property Nombre_Producto() As [String]
		Get
			Return m_Nombre_Producto
		End Get
		Set
			m_Nombre_Producto = Value
		End Set
	End Property
	Private m_Nombre_Producto As [String]
	Public Property Cantidad() As Integer
		Get
			Return m_Cantidad
		End Get
		Set
			m_Cantidad = Value
		End Set
	End Property
	Private m_Cantidad As Integer
	Public Property Precio_Unitario() As Decimal
		Get
			Return m_Precio_Unitario
		End Get
		Set
			m_Precio_Unitario = Value
		End Set
	End Property
	Private m_Precio_Unitario As Decimal
	Public Property Descuento() As Decimal
		Get
			Return m_Descuento
		End Get
		Set
			m_Descuento = Value
		End Set
	End Property
	Private m_Descuento As Decimal


	Public Sub New()
	End Sub

	Public Sub New(parId_Orden As Integer, parNombre_Producto As [String], parCantidad As Integer, parPrecio_Unitario As Decimal, parDescuento As Decimal)
		Me.Id_Orden = parId_Orden
		Me.Nombre_Producto = parNombre_Producto
		Me.Cantidad = parCantidad
		Me.Precio_Unitario = parPrecio_Unitario
		Me.Descuento = parDescuento
	End Sub

	Public Function MostrarOrdenDetalles(parIdOrden__1 As Integer) As DataTable
		Dim TablaDatos As New DataTable("Compras.OrdenDetalles")
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Compras.MostrarOrdenDetalles"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParIdOrden__2 As New SqlParameter()
			ParIdOrden__2.ParameterName = "@Id_Orden"
			ParIdOrden__2.SqlDbType = SqlDbType.Int
			ParIdOrden__2.Value = parIdOrden__1
			SqlComando.Parameters.Add(ParIdOrden__2)

			SqlComando.ExecuteNonQuery()

			Dim SqlAdaptadorDatos As New SqlDataAdapter(SqlComando)
			SqlAdaptadorDatos.Fill(TablaDatos)

		Catch ex As Exception
			TablaDatos = Nothing
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado Compras.MostrarOrdenDetalles. " & ex.Message, ex)
		Finally

			SqlConexion.Close()
		End Try

		Return TablaDatos
	End Function

	Public Function Insertar(parOrdenDetalles As DOrdenDetalles) As String
		Dim Respuesta As String = ""
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Compras.InsertarOrdenDetalles"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParNombre_Producto As New SqlParameter()
			ParNombre_Producto.ParameterName = "@Nombre_Producto"
			ParNombre_Producto.SqlDbType = SqlDbType.VarChar
			ParNombre_Producto.Size = parOrdenDetalles.Nombre_Producto.Length
			ParNombre_Producto.Value = parOrdenDetalles.Nombre_Producto
			SqlComando.Parameters.Add(ParNombre_Producto)

			Dim ParCantidad As New SqlParameter()
			ParCantidad.ParameterName = "@Cantidad"
			ParCantidad.SqlDbType = SqlDbType.Int
			ParCantidad.Value = parOrdenDetalles.Cantidad
			SqlComando.Parameters.Add(ParCantidad)

			Dim ParPrecioUnitario As New SqlParameter()
			ParPrecioUnitario.ParameterName = "@Precio_Unitario"
			ParPrecioUnitario.SqlDbType = SqlDbType.Money
			ParPrecioUnitario.Value = parOrdenDetalles.Precio_Unitario
			SqlComando.Parameters.Add(ParPrecioUnitario)

			Dim ParDescuento As New SqlParameter()
			ParDescuento.ParameterName = "@Descuento"
			ParDescuento.SqlDbType = SqlDbType.[Decimal]
			ParDescuento.Value = parOrdenDetalles.Descuento
			SqlComando.Parameters.Add(ParDescuento)

			SqlComando.ExecuteNonQuery()
			Respuesta = "Y"

		Catch ex As SqlException
			If ex.Number = 8152 Then
				Respuesta = "Has introducido demasiados caracteres en uno de los campos"
			ElseIf ex.Number = 515 Then
				Respuesta = "No puedes dejar campos vacíos"
			ElseIf ex.Number = 2627 Then
				Respuesta = "No puedes insertar más de una vez el mismo producto en un pedido. Si quieres agregar más de un mismo producto simplemente modifica la cantidad del mismo."
			ElseIf ex.Number = 50000 Then
				Respuesta = "Ingresa un producto existente. Si el producto no existe deberás primero crearlo"
			Else
				Respuesta = "Error al intentar ejecutar el procedimiento almacenado Compras.InsertarOrdenDetalles. " & ex.Message
			End If
		Finally

			If SqlConexion.State = ConnectionState.Open Then
				SqlConexion.Close()
			End If
		End Try

		Return Respuesta
	End Function

	Public Function Editar(parOrdenDetalles As DOrdenDetalles) As String
		Dim Respuesta As String = ""
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Compras.EditarOrdenDetalles"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParId_Orden As New SqlParameter()
			ParId_Orden.ParameterName = "@Id_Orden"
			ParId_Orden.SqlDbType = SqlDbType.Int
			ParId_Orden.Value = parOrdenDetalles.Id_Orden
			SqlComando.Parameters.Add(ParId_Orden)

			Dim ParNombre_Producto As New SqlParameter()
			ParNombre_Producto.ParameterName = "@Nombre_Producto"
			ParNombre_Producto.SqlDbType = SqlDbType.VarChar
			ParNombre_Producto.Size = parOrdenDetalles.Nombre_Producto.Length
			ParNombre_Producto.Value = parOrdenDetalles.Nombre_Producto
			SqlComando.Parameters.Add(ParNombre_Producto)

			Dim ParCantidad As New SqlParameter()
			ParCantidad.ParameterName = "@Cantidad"
			ParCantidad.SqlDbType = SqlDbType.Int
			ParCantidad.Value = parOrdenDetalles.Cantidad
			SqlComando.Parameters.Add(ParCantidad)

			Dim ParPrecioUnitario As New SqlParameter()
			ParPrecioUnitario.ParameterName = "@Precio_Unitario"
			ParPrecioUnitario.SqlDbType = SqlDbType.Money
			ParPrecioUnitario.Value = parOrdenDetalles.Precio_Unitario
			SqlComando.Parameters.Add(ParPrecioUnitario)

			Dim ParDescuento As New SqlParameter()
			ParDescuento.ParameterName = "@Descuento"
			ParDescuento.SqlDbType = SqlDbType.[Decimal]
			ParDescuento.Value = parOrdenDetalles.Descuento
			SqlComando.Parameters.Add(ParDescuento)

			SqlComando.ExecuteNonQuery()
			Respuesta = "Y"

		Catch ex As SqlException
			If ex.Number = 8152 Then
				Respuesta = "Has introducido demasiados caracteres en uno de los campos"
			ElseIf ex.Number = 515 Then
				Respuesta = "No puedes dejar campos vacíos"
			ElseIf ex.Number = 2627 Then
				Respuesta = "No puedes insertar más de una vez el mismo producto en un pedido. Si quieres agregar más de un mismo producto simplemente modifica la cantidad del mismo."
			ElseIf ex.Number = 50000 Then
				Respuesta = "Ingresa un producto existente. Si el p oducto no existe deberás primero crearlo"
			Else
				Respuesta = "Error al intentar ejecutar el procedimiento almacenado Compras.EditarOrdenDetalles. " & ex.Message
			End If
		Finally

			If SqlConexion.State = ConnectionState.Open Then
				SqlConexion.Close()
			End If
		End Try

		Return Respuesta
	End Function
End Class
