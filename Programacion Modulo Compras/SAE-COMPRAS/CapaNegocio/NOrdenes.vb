Imports System.Collections.Generic
Imports System.Data
Imports CapaDatos
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class NOrdenes
	Public Shared Function MostrarOrdenesPendientes(parNumeroPagina As Integer, parRegistrosPorPagina As Integer) As DataTable
		Return New DOrdenes().MostrarOrdenesPendientes(parNumeroPagina, parRegistrosPorPagina)
	End Function

	Public Shared Function MostrarOrdenesEntregados(parNumeroPagina As Integer, parRegistrosPorPagina As Integer) As DataTable
		Return New DOrdenes().MostrarOrdenesEntregados(parNumeroPagina, parRegistrosPorPagina)
	End Function

	Public Shared Function TamañoOrdenesPendientes(parRegistrosPorPagina As Integer) As Integer
		Return New DOrdenes().TamañoOrdenesPendientes(parRegistrosPorPagina)
	End Function

	Public Shared Function TamañoOrdenesEntregados(parRegistrosPorPagina As Integer) As Integer
		Return New DOrdenes().TamañoOrdenesEntregados(parRegistrosPorPagina)
	End Function

	Public Shared Function BuscarOrdenPendiente(parOrden_Buscado As [String]) As DataTable
		Dim ordenes As New DOrdenes()
		ordenes.Orden_Buscado = parOrden_Buscado

		Return ordenes.BuscarOrdenPendiente(ordenes)
	End Function

	Public Shared Function BuscarOrdenEntregado(parOrden_Buscado As [String]) As DataTable
		Dim ordenes As New DOrdenes()
		ordenes.Orden_Buscado = parOrden_Buscado

		Return ordenes.BuscarOrdenEntregado(ordenes)
	End Function

	Public Shared Function Eliminar(parId_Orden As Integer) As [String]
		Dim ordenes As New DOrdenes()
		ordenes.Id_Orden = parId_Orden

		Return ordenes.Eliminar(ordenes)
	End Function

	Public Shared Function Insertar(parNombre_Proveedor As [String], parNombre_Transporte As [String], parNombre_Empleado As [String], parFecha_Ordenado As [String], parFecha_Requerido As [String], parCosto_Envio As Decimal) As [String]
		Dim ordenes As New DOrdenes()
		ordenes.Nombre_Proveedor = parNombre_Proveedor
		ordenes.Nombre_Transporte = parNombre_Transporte
		ordenes.Nombre_Empleado = parNombre_Empleado
		ordenes.Fecha_Ordenado = parFecha_Ordenado
		ordenes.Fecha_Requerido = parFecha_Requerido
		ordenes.Costo_Envio = parCosto_Envio

		Return ordenes.Insertar(ordenes)
	End Function

	Public Shared Function Editar(parIdOrden As Integer, parNombre_Proveedor As [String], parNombre_Transporte As [String], parNombre_Empleado As [String], parFecha_Ordenado As [String], parFecha_Requerido As [String], _
		parFecha_Entregado As [String], parCosto_Envio As Decimal) As [String]
		Dim ordenes As New DOrdenes()
		ordenes.Id_Orden = parIdOrden
		ordenes.Nombre_Proveedor = parNombre_Proveedor
		ordenes.Nombre_Transporte = parNombre_Transporte
		ordenes.Nombre_Empleado = parNombre_Empleado
		ordenes.Fecha_Ordenado = parFecha_Ordenado
		ordenes.Fecha_Requerido = parFecha_Requerido
		ordenes.Fecha_Entregado = parFecha_Entregado
		ordenes.Costo_Envio = parCosto_Envio

		Return ordenes.Editar(ordenes)
	End Function

	Public Shared Function MarcarEntregadoPendiente(parIdOrden As Integer, parFecha_Entregado As [String]) As [String]
		Dim ordenes As New DOrdenes()
		ordenes.Id_Orden = parIdOrden
		ordenes.Fecha_Entregado = parFecha_Entregado

		Return ordenes.MarcarEntregadoPendiente(ordenes)
	End Function
End Class
