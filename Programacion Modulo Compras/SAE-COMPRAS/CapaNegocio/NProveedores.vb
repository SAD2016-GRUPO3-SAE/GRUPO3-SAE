Imports System.Collections.Generic
Imports System.Data
Imports CapaDatos
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class NProveedores
	Public Shared Function ListaProveedores() As DataTable
		Return New DProveedores().ListaProveedores()
	End Function

	Public Shared Function Mostrar(parNumeroPagina As Integer, parRegistrosPorPagina As Integer) As DataTable
		Return New DProveedores().Mostrar(parNumeroPagina, parRegistrosPorPagina)
	End Function

	Public Shared Function Tamaño(parRegistrosPorPagina As Integer) As Integer
		Return New DProveedores().Tamaño(parRegistrosPorPagina)
	End Function


	Public Shared Function Buscar(parNombre_Proveedor_Buscado As [String]) As DataTable
		Dim proveedores As New DProveedores()
		proveedores.Nombre_Proveedor_Buscado = parNombre_Proveedor_Buscado

		Return proveedores.Buscar(proveedores)
	End Function

	Public Shared Function Eliminar(parId_Proveedor As Integer) As [String]
		Dim proveedores As New DProveedores()
		proveedores.Id_Proveedor = parId_Proveedor

		Return proveedores.Eliminar(proveedores)
	End Function

	Public Shared Function Insertar(parNombre_Proveedor As [String], parNombre_Contacto As [String], parDireccion As [String], parCiudad As [String], parRegion As [String], parPais As [String], _
		parTelefono As [String], parFax As [String], parEmail As [String]) As [String]
		Dim proveedores As New DProveedores()
		proveedores.Nombre_Proveedor = parNombre_Proveedor
		proveedores.Nombre_Contacto = parNombre_Contacto
		proveedores.Direccion = parDireccion
		proveedores.Ciudad = parCiudad
		proveedores.Region = parRegion
		proveedores.Pais = parPais
		proveedores.Telefono = parTelefono
		proveedores.Fax = parFax
		proveedores.Email = parEmail

		Return proveedores.Insertar(proveedores)
	End Function

	Public Shared Function Editar(parId_Proveedor As Integer, parNombre_Proveedor As [String], parNombre_Contacto As [String], parDireccion As [String], parCiudad As [String], parRegion As [String], _
		parPais As [String], parTelefono As [String], parFax As [String], parEmail As [String]) As [String]
		Dim proveedores As New DProveedores()
		proveedores.Id_Proveedor = parId_Proveedor
		proveedores.Nombre_Proveedor = parNombre_Proveedor
		proveedores.Nombre_Contacto = parNombre_Contacto
		proveedores.Direccion = parDireccion
		proveedores.Ciudad = parCiudad
		proveedores.Region = parRegion
		proveedores.Pais = parPais
		proveedores.Telefono = parTelefono
		proveedores.Fax = parFax
		proveedores.Email = parEmail

		Return proveedores.Editar(proveedores)
	End Function
End Class
