Imports System.Collections.Generic
Imports System.Data
Imports CapaDatos
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class NCategorias
	Public Shared Function ListaCategorias() As DataTable
		Return New DCategorias().ListaCategorias()
	End Function

	Public Shared Function Mostrar(parNumeroPagina As Integer, parRegistrosPorPagina As Integer) As DataTable
		Return New DCategorias().Mostrar(parNumeroPagina, parRegistrosPorPagina)
	End Function

	Public Shared Function Tamaño(parRegistrosPorPagina As Integer) As Integer
		Return New DCategorias().Tamaño(parRegistrosPorPagina)
	End Function


	Public Shared Function Buscar(parNombre_Buscado As [String]) As DataTable
		Dim categorias As New DCategorias()
		categorias.Nombre_Buscado = parNombre_Buscado

		Return categorias.Buscar(categorias)
	End Function

	Public Shared Function Eliminar(parId_Categoria As Integer) As [String]
		Dim categorias As New DCategorias()
		categorias.Id_Categoria = parId_Categoria

		Return categorias.Eliminar(categorias)
	End Function

	Public Shared Function Insertar(parNombre_Categoria As [String], parDescripcion As [String]) As [String]
		Dim categorias As New DCategorias()
		categorias.Nombre_Categoria = parNombre_Categoria
		categorias.Descripcion = parDescripcion

		Return categorias.Insertar(categorias)
	End Function

	Public Shared Function Editar(parId_Categoria As Integer, parNombre_Categoria As [String], parDescripcion As [String]) As [String]
		Dim categorias As New DCategorias()
		categorias.Id_Categoria = parId_Categoria
		categorias.Nombre_Categoria = parNombre_Categoria
		categorias.Descripcion = parDescripcion

		Return categorias.Editar(categorias)
	End Function
End Class
