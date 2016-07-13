Imports System.Collections.Generic
Imports System.Data
Imports CapaDatos
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class NOrdenDetalles
	Public Shared Function MostrarOrdenDetalles(parIdOrden As Integer) As DataTable
		Return New DOrdenDetalles().MostrarOrdenDetalles(parIdOrden)
	End Function

	Public Shared Function Insertar(parNombre_Producto As [String], parCantidad As Integer, parPrecio_Unitario As Decimal, parDescuento As Decimal) As [String]
		Dim ordenDetalles As New DOrdenDetalles()
		ordenDetalles.Nombre_Producto = parNombre_Producto
		ordenDetalles.Cantidad = parCantidad
		ordenDetalles.Precio_Unitario = parPrecio_Unitario
		ordenDetalles.Descuento = parDescuento

		Return ordenDetalles.Insertar(ordenDetalles)
	End Function

	Public Shared Function Editar(parIdOrden As Integer, parNombre_Producto As [String], parCantidad As Integer, parPrecio_Unitario As Decimal, parDescuento As Decimal) As [String]
		Dim ordenDetalles As New DOrdenDetalles()
		ordenDetalles.Id_Orden = parIdOrden
		ordenDetalles.Nombre_Producto = parNombre_Producto
		ordenDetalles.Cantidad = parCantidad
		ordenDetalles.Precio_Unitario = parPrecio_Unitario
		ordenDetalles.Descuento = parDescuento

		Return ordenDetalles.Editar(ordenDetalles)
	End Function

End Class
