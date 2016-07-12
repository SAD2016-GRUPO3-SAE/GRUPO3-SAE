Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class DOrdenes
	Public Property Id_Orden() As Integer
		Get
			Return m_Id_Orden
		End Get
		Set
			m_Id_Orden = Value
		End Set
	End Property
	Private m_Id_Orden As Integer
	Public Property Nombre_Proveedor() As [String]
		Get
			Return m_Nombre_Proveedor
		End Get
		Set
			m_Nombre_Proveedor = Value
		End Set
	End Property
	Private m_Nombre_Proveedor As [String]
	Public Property Nombre_Transporte() As [String]
		Get
			Return m_Nombre_Transporte
		End Get
		Set
			m_Nombre_Transporte = Value
		End Set
	End Property
	Private m_Nombre_Transporte As [String]
	Public Property Nombre_Empleado() As [String]
		Get
			Return m_Nombre_Empleado
		End Get
		Set
			m_Nombre_Empleado = Value
		End Set
	End Property
	Private m_Nombre_Empleado As [String]
	Public Property Fecha_Ordenado() As [String]
		Get
			Return m_Fecha_Ordenado
		End Get
		Set
			m_Fecha_Ordenado = Value
		End Set
	End Property
	Private m_Fecha_Ordenado As [String]
	Public Property Fecha_Requerido() As [String]
		Get
			Return m_Fecha_Requerido
		End Get
		Set
			m_Fecha_Requerido = Value
		End Set
	End Property
	Private m_Fecha_Requerido As [String]
	Public Property Fecha_Entregado() As [String]
		Get
			Return m_Fecha_Entregado
		End Get
		Set
			m_Fecha_Entregado = Value
		End Set
	End Property
	Private m_Fecha_Entregado As [String]
	Public Property Costo_Envio() As Decimal
		Get
			Return m_Costo_Envio
		End Get
		Set
			m_Costo_Envio = Value
		End Set
	End Property
	Private m_Costo_Envio As Decimal
	Public Property Orden_Buscado() As [String]
		Get
			Return m_Orden_Buscado
		End Get
		Set
			m_Orden_Buscado = Value
		End Set
	End Property
	Private m_Orden_Buscado As [String]


	Public Sub New()
	End Sub

	Public Sub New(parId_Orden As Integer, parNombre_Proveedor As [String], parNombre_Transporte As [String], parNombre_Empleado As [String], parFecha_Ordenado As [String], parFecha_Requerido As [String], _
		parFecha_Entregado As [String], parCosto_Envio As Decimal, parOrden_Buscado As [String])
		Me.Id_Orden = parId_Orden
		Me.Nombre_Proveedor = parNombre_Proveedor
		Me.Nombre_Transporte = parNombre_Transporte
		Me.Nombre_Empleado = parNombre_Empleado
		Me.Fecha_Ordenado = parFecha_Ordenado
		Me.Fecha_Requerido = parFecha_Requerido
		Me.Fecha_Entregado = parFecha_Entregado
		Me.Costo_Envio = parCosto_Envio
		Me.Orden_Buscado = parOrden_Buscado
	End Sub

	Public Function MostrarOrdenesPendientes(parNumeroPagina__1 As Integer, parRegistrosPorPagina__2 As Integer) As DataTable
		Dim TablaDatos As New DataTable("Compras.v_Ordenes")
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Compras.MostrarOrdenesPendientes"
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
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado Compras.MostrarOrdenesPendientes. " & ex.Message, ex)
		Finally

			SqlConexion.Close()
		End Try

		Return TablaDatos
	End Function

	Public Function MostrarOrdenesEntregados(parNumeroPagina__1 As Integer, parRegistrosPorPagina__2 As Integer) As DataTable
		Dim TablaDatos As New DataTable("Compras.v_Ordenes")
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Compras.MostrarOrdenesEntregados"
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
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado Compras.MostrarOrdenesEntregados. " & ex.Message, ex)
		Finally

			SqlConexion.Close()
		End Try

		Return TablaDatos
	End Function

	Public Function TamañoOrdenesPendientes(parRegistrosPorPagina__1 As Integer) As Integer
		Dim SqlConexion As New SqlConnection()
		Dim totalPaginas As Integer = 1

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Compras.TamañoOrdenesPendientes"
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
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado Compras.TamañoOrdenesPendientes. " & ex.Message, ex)
		Finally

			SqlConexion.Close()
		End Try

		Return totalPaginas
	End Function

	Public Function TamañoOrdenesEntregados(parRegistrosPorPagina__1 As Integer) As Integer
		Dim SqlConexion As New SqlConnection()
		Dim totalPaginas As Integer = 1

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Compras.TamañoOrdenesEntregados"
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
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado Compras.TamañoOrdenesEntregados. " & ex.Message, ex)
		Finally

			SqlConexion.Close()
		End Try

		Return totalPaginas
	End Function

	Public Function BuscarOrdenPendiente(parOrdenes As DOrdenes) As DataTable
		Dim TablaDatos As New DataTable("Compras.v_Ordenes")
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Compras.BuscarOrdenPendiente"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParNombre_Buscado As New SqlParameter()
			ParNombre_Buscado.ParameterName = "@Orden_Buscado"
			ParNombre_Buscado.SqlDbType = SqlDbType.VarChar
			ParNombre_Buscado.Size = parOrdenes.Orden_Buscado.Length
			ParNombre_Buscado.Value = parOrdenes.Orden_Buscado
			SqlComando.Parameters.Add(ParNombre_Buscado)

			Dim SqlAdaptadorDatos As New SqlDataAdapter(SqlComando)
			SqlAdaptadorDatos.Fill(TablaDatos)

		Catch ex As Exception
			TablaDatos = Nothing
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado Compras.BuscarOrdenPendiente. " & ex.Message, ex)
		Finally

			If SqlConexion.State = ConnectionState.Open Then
				SqlConexion.Close()
			End If
		End Try

		Return TablaDatos
	End Function

	Public Function BuscarOrdenEntregado(parOrdenes As DOrdenes) As DataTable
		Dim TablaDatos As New DataTable("Compras.v_Ordenes")
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Compras.BuscarOrdenEntregado"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParNombre_Buscado As New SqlParameter()
			ParNombre_Buscado.ParameterName = "@Orden_Buscado"
			ParNombre_Buscado.SqlDbType = SqlDbType.VarChar
			ParNombre_Buscado.Size = parOrdenes.Orden_Buscado.Length
			ParNombre_Buscado.Value = parOrdenes.Orden_Buscado
			SqlComando.Parameters.Add(ParNombre_Buscado)

			Dim SqlAdaptadorDatos As New SqlDataAdapter(SqlComando)
			SqlAdaptadorDatos.Fill(TablaDatos)

		Catch ex As Exception
			TablaDatos = Nothing
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado Compras.BuscarOrdenEntregado. " & ex.Message, ex)
		Finally

			If SqlConexion.State = ConnectionState.Open Then
				SqlConexion.Close()
			End If
		End Try

		Return TablaDatos
	End Function

	Public Function Insertar(parOrdenes As DOrdenes) As String
		Dim Respuesta As String = ""
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Compras.InsertarOrden"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParNombre_Proveedor As New SqlParameter()
			ParNombre_Proveedor.ParameterName = "@Nombre_Proveedor"
			ParNombre_Proveedor.SqlDbType = SqlDbType.VarChar
			ParNombre_Proveedor.Size = parOrdenes.Nombre_Proveedor.Length
			ParNombre_Proveedor.Value = parOrdenes.Nombre_Proveedor
			SqlComando.Parameters.Add(ParNombre_Proveedor)

			Dim ParNombre_Transporte As New SqlParameter()
			ParNombre_Transporte.ParameterName = "@Nombre_Transporte"
			ParNombre_Transporte.SqlDbType = SqlDbType.VarChar
			ParNombre_Transporte.Size = parOrdenes.Nombre_Transporte.Length
			ParNombre_Transporte.Value = parOrdenes.Nombre_Transporte
			SqlComando.Parameters.Add(ParNombre_Transporte)

			Dim ParNombre_Empleado As New SqlParameter()
			ParNombre_Empleado.ParameterName = "@Nombre_Empleado"
			ParNombre_Empleado.SqlDbType = SqlDbType.VarChar
			ParNombre_Empleado.Size = parOrdenes.Nombre_Empleado.Length
			ParNombre_Empleado.Value = parOrdenes.Nombre_Empleado
			SqlComando.Parameters.Add(ParNombre_Empleado)

			Dim ParFecha_Ordenado As New SqlParameter()
			ParFecha_Ordenado.ParameterName = "@Fecha_Ordenado"
			ParFecha_Ordenado.SqlDbType = SqlDbType.DateTime
			ParFecha_Ordenado.Value = parOrdenes.Fecha_Ordenado
			SqlComando.Parameters.Add(ParFecha_Ordenado)

			Dim ParFecha_Requerido As New SqlParameter()
			ParFecha_Requerido.ParameterName = "@Fecha_Requerido"
			ParFecha_Requerido.SqlDbType = SqlDbType.DateTime
			ParFecha_Requerido.Value = parOrdenes.Fecha_Requerido
			SqlComando.Parameters.Add(ParFecha_Requerido)

			Dim ParCosto_Envio As New SqlParameter()
			ParCosto_Envio.ParameterName = "@Costo_Envio"
			ParCosto_Envio.SqlDbType = SqlDbType.Money
			ParCosto_Envio.Value = parOrdenes.Costo_Envio
			SqlComando.Parameters.Add(ParCosto_Envio)

			SqlComando.ExecuteNonQuery()
			Respuesta = "Y"

		Catch ex As SqlException
			If ex.Number = 8152 Then
				Respuesta = "Has introducido demasiados caracteres en uno de los campos"
			ElseIf ex.Number = 547 Then
				Respuesta = "La Fecha Requerido tiene que ser posterior a la Fecha Ordeando"
			ElseIf ex.Number = 515 Then
				Respuesta = "No puedes dejar los campos Proveedor, Transportista, Empleado o Fecha Ordenado vacíos"
			ElseIf ex.Number = 50000 Then
				Respuesta = "Debes ingresar un Proveedor, Empleado o Transportista existente"
			Else
				Respuesta = "Error al intentar ejecutar el procedimiento almacenado Compras.InsertarOrden. " & ex.Message
			End If
		Finally

			If SqlConexion.State = ConnectionState.Open Then
				SqlConexion.Close()
			End If
		End Try

		Return Respuesta
	End Function

	Public Function Eliminar(parOrdenes As DOrdenes) As String
		Dim Respuesta As String = ""
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Compras.EliminarOrden"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParId_Orden As New SqlParameter()
			ParId_Orden.ParameterName = "@Id_Orden"
			ParId_Orden.SqlDbType = SqlDbType.Int
			ParId_Orden.Value = parOrdenes.Id_Orden
			SqlComando.Parameters.Add(ParId_Orden)

			SqlComando.ExecuteNonQuery()
			Respuesta = "Y"

		Catch ex As Exception
			Respuesta = "Error al intentar ejecutar el procedimiento almacenado Compras.EliminarOrden. " & ex.Message
		Finally

			If SqlConexion.State = ConnectionState.Open Then
				SqlConexion.Close()
			End If
		End Try

		Return Respuesta
	End Function

	Public Function Editar(parOrdenes As DOrdenes) As String
		Dim Respuesta As String = ""
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Compras.EditarOrden"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParId_Orden As New SqlParameter()
			ParId_Orden.ParameterName = "@Id_Orden"
			ParId_Orden.SqlDbType = SqlDbType.Int
			ParId_Orden.Value = parOrdenes.Id_Orden
			SqlComando.Parameters.Add(ParId_Orden)

			Dim ParNombre_Proveedor As New SqlParameter()
			ParNombre_Proveedor.ParameterName = "@Nombre_Proveedor"
			ParNombre_Proveedor.SqlDbType = SqlDbType.VarChar
			ParNombre_Proveedor.Size = parOrdenes.Nombre_Proveedor.Length
			ParNombre_Proveedor.Value = parOrdenes.Nombre_Proveedor
			SqlComando.Parameters.Add(ParNombre_Proveedor)

			Dim ParNombre_Transporte As New SqlParameter()
			ParNombre_Transporte.ParameterName = "@Nombre_Transporte"
			ParNombre_Transporte.SqlDbType = SqlDbType.VarChar
			ParNombre_Transporte.Size = parOrdenes.Nombre_Transporte.Length
			ParNombre_Transporte.Value = parOrdenes.Nombre_Transporte
			SqlComando.Parameters.Add(ParNombre_Transporte)

			Dim ParNombre_Empleado As New SqlParameter()
			ParNombre_Empleado.ParameterName = "@Nombre_Empleado"
			ParNombre_Empleado.SqlDbType = SqlDbType.VarChar
			ParNombre_Empleado.Size = parOrdenes.Nombre_Empleado.Length
			ParNombre_Empleado.Value = parOrdenes.Nombre_Empleado
			SqlComando.Parameters.Add(ParNombre_Empleado)

			Dim ParFecha_Ordenado As New SqlParameter()
			ParFecha_Ordenado.ParameterName = "@Fecha_Ordenado"
			ParFecha_Ordenado.SqlDbType = SqlDbType.DateTime
			ParFecha_Ordenado.Value = parOrdenes.Fecha_Ordenado
			SqlComando.Parameters.Add(ParFecha_Ordenado)

			Dim ParFecha_Requerido As New SqlParameter()
			ParFecha_Requerido.ParameterName = "@Fecha_Requerido"
			ParFecha_Requerido.SqlDbType = SqlDbType.DateTime
			ParFecha_Requerido.Value = parOrdenes.Fecha_Requerido
			SqlComando.Parameters.Add(ParFecha_Requerido)

			Dim ParFecha_Entregado As New SqlParameter()
			ParFecha_Entregado.ParameterName = "@Fecha_Entregado"
			ParFecha_Entregado.SqlDbType = SqlDbType.DateTime
			ParFecha_Entregado.Value = parOrdenes.Fecha_Entregado
			SqlComando.Parameters.Add(ParFecha_Entregado)

			Dim ParCosto_Envio As New SqlParameter()
			ParCosto_Envio.ParameterName = "@Costo_Envio"
			ParCosto_Envio.SqlDbType = SqlDbType.Money
			ParCosto_Envio.Value = parOrdenes.Costo_Envio
			SqlComando.Parameters.Add(ParCosto_Envio)

			SqlComando.ExecuteNonQuery()
			Respuesta = "Y"

		Catch ex As SqlException
			If ex.Number = 8152 Then
				Respuesta = "Has introducido demasiados caracteres en uno de los campos"
			ElseIf ex.Number = 547 Then
				Respuesta = "La Fecha Requerido o la Fecha Entregado tienen que ser posteriores a la Fecha Ordeando"
			ElseIf ex.Number = 515 Then
				Respuesta = "No puedes dejar los campos Proveedor, Transportista, Empleado o Fecha Ordenado vacíos"
			ElseIf ex.Number = 50000 Then
				Respuesta = "Debes ingresar un Proveedor, Empleado o Transportista existente"
			Else
				Respuesta = "Error al intentar ejecutar el procedimiento almacenado Compras.EditarOrden. " & ex.Message
			End If
		Finally

			If SqlConexion.State = ConnectionState.Open Then
				SqlConexion.Close()
			End If
		End Try

		Return Respuesta
	End Function

	Public Function MarcarEntregadoPendiente(parOrdenes As DOrdenes) As String
		Dim Respuesta As String = ""
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "Compras.MarcarEntregadoPendiente"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParId_Orden As New SqlParameter()
			ParId_Orden.ParameterName = "@Id_Orden"
			ParId_Orden.SqlDbType = SqlDbType.Int
			ParId_Orden.Value = parOrdenes.Id_Orden
			SqlComando.Parameters.Add(ParId_Orden)

			Dim ParFecha_Entregado As New SqlParameter()
			ParFecha_Entregado.ParameterName = "@Fecha_Entregado"
			ParFecha_Entregado.SqlDbType = SqlDbType.DateTime
			ParFecha_Entregado.Value = parOrdenes.Fecha_Entregado
			SqlComando.Parameters.Add(ParFecha_Entregado)

			SqlComando.ExecuteNonQuery()
			Respuesta = "Y"

		Catch ex As SqlException
			If ex.Number = 8152 Then
				Respuesta = "Has introducido demasiados caracteres en uno de los campos"
			ElseIf ex.Number = 547 Then
				Respuesta = "La Fecha Requerido o la Fecha Entregado tienen que ser posteriores a la Fecha Ordeando"
			ElseIf ex.Number = 515 Then
				Respuesta = "No puedes dejar campos vacíos"
			Else
				Respuesta = "Error al intentar ejecutar el procedimiento almacenado Compras.MarcarEntregadoPendiente. " & ex.Message
			End If
		Finally

			If SqlConexion.State = ConnectionState.Open Then
				SqlConexion.Close()
			End If
		End Try

		Return Respuesta
	End Function
End Class
