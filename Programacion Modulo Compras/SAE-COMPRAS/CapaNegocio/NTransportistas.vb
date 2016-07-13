Imports System.Collections.Generic
Imports System.Data
'Importamos para DataTable
Imports CapaDatos
'Importamos para DEmpleados
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class NTransportistas
	Public Shared Function ListaTransportistas() As DataTable
		Return New DTransportistas().ListaTransportistas()
	End Function

	Public Shared Function Mostrar(parNumeroPagina As Integer, parRegistrosPorPagina As Integer) As DataTable
		Return New DTransportistas().Mostrar(parNumeroPagina, parRegistrosPorPagina)
	End Function

	Public Shared Function Tamaño(parRegistrosPorPagina As Integer) As Integer
		Return New DTransportistas().Tamaño(parRegistrosPorPagina)
	End Function


	Public Shared Function Buscar(parNombre_Buscado As [String]) As DataTable
		Dim transportistas As New DTransportistas()
		transportistas.Nombre_Buscado = parNombre_Buscado

		Return transportistas.Buscar(transportistas)
	End Function

	Public Shared Function Eliminar(parId_Transportista As Integer) As [String]
		Dim transportistas As New DTransportistas()
		transportistas.Id_Transportista = parId_Transportista

		Return transportistas.Eliminar(transportistas)
	End Function

	Public Shared Function Insertar(parNombre_Empresa As [String], parDireccion As [String], parCiudad As [String], parRegion As [String], parPais As [String], parTelefono As [String]) As [String]
		Dim transportistas As New DTransportistas()
		transportistas.Nombre_Empresa = parNombre_Empresa
		transportistas.Direccion = parDireccion
		transportistas.Ciudad = parCiudad
		transportistas.Region = parRegion
		transportistas.Pais = parPais
		transportistas.Telefono = parTelefono

		Return transportistas.Insertar(transportistas)
	End Function

	Public Shared Function Editar(parId_Transportista As Integer, parNombre_Empresa As [String], parDireccion As [String], parCiudad As [String], parRegion As [String], parPais As [String], _
		parTelefono As [String]) As [String]
		Dim transportistas As New DTransportistas()
		transportistas.Id_Transportista = parId_Transportista
		transportistas.Nombre_Empresa = parNombre_Empresa
		transportistas.Direccion = parDireccion
		transportistas.Ciudad = parCiudad
		transportistas.Region = parRegion
		transportistas.Pais = parPais
		transportistas.Telefono = parTelefono

		Return transportistas.Editar(transportistas)
	End Function
End Class
