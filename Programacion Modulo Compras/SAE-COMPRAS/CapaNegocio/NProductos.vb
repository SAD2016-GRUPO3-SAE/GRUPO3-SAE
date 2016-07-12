Imports System.Collections.Generic
Imports System.Data
Imports CapaDatos
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class NProductos
	Public Shared Function ListaProductos() As DataTable
		Return New DProductos().ListaProductos()
	End Function

	Public Shared Function PrecioProducto(parIdProducto As Integer) As Decimal
		Return New DProductos().PrecioProducto(parIdProducto)
	End Function

	Public Shared Function Mostrar(parNumeroPagina As Integer, parRegistrosPorPagina As Integer) As DataTable
		Return New DProductos().Mostrar(parNumeroPagina, parRegistrosPorPagina)
	End Function

	Public Shared Function Tamaño(parRegistrosPorPagina As Integer) As Integer
		Return New DProductos().Tamaño(parRegistrosPorPagina)
	End Function


	Public Shared Function Buscar(parNombre_Buscado As [String]) As DataTable
		Dim productos As New DProductos()
		productos.Nombre_Buscado = parNombre_Buscado

		Return productos.Buscar(productos)
	End Function

	Public Shared Function Eliminar(parId_Producto As Integer) As [String]
		Dim productos As New DProductos()
		productos.Id_Producto = parId_Producto

		Return productos.Eliminar(productos)
	End Function

	Public Shared Function Insertar(parNombre_Producto As [String], parNombre_Categoria As [String], parPrecio_Unitario As Decimal, parDetalles As [String]) As [String]
		Dim productos As New DProductos()
		productos.Nombre_Producto = parNombre_Producto
		productos.Nombre_Categoria = parNombre_Categoria
		productos.Precio_Unitario = parPrecio_Unitario
		productos.Detalles = parDetalles

		Return productos.Insertar(productos)
	End Function

	Public Shared Function Editar(parId_Producto As Integer, parNombre_Producto As [String], parNombre_Categoria As [String], parPrecio_Unitario As Decimal, parDetalles As [String]) As [String]
		Dim productos As New DProductos()
		productos.Id_Producto = parId_Producto
		productos.Nombre_Producto = parNombre_Producto
		productos.Nombre_Categoria = parNombre_Categoria
		productos.Precio_Unitario = parPrecio_Unitario
		productos.Detalles = parDetalles

		Return productos.Editar(productos)
	End Function
End Class
