Imports System.Collections.Generic
Imports System.Data
Imports CapaDatos
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class NEmpleados
	Public Shared Function ListaEmpleados() As DataTable
		Return New DEmpleados().ListaEmpleados()
	End Function

	Public Shared Function Mostrar(parNumeroPagina As Integer, parRegistrosPorPagina As Integer) As DataTable
		Return New DEmpleados().Mostrar(parNumeroPagina, parRegistrosPorPagina)
	End Function

	Public Shared Function Tamaño(parRegistrosPorPagina As Integer) As Integer
		Return New DEmpleados().Tamaño(parRegistrosPorPagina)
	End Function


	Public Shared Function Buscar(parApellido_Buscado As [String]) As DataTable
		Dim empleados As New DEmpleados()
		empleados.Apellido_Buscado = parApellido_Buscado

		Return empleados.Buscar(empleados)
	End Function

	Public Shared Function Eliminar(parId_Empleado As Integer) As [String]
		Dim empleado As New DEmpleados()
		empleado.Id_Empleado = parId_Empleado

		Return empleado.Eliminar(empleado)
	End Function

	Public Shared Function Insertar(parNombre_Empleado As [String], parApellido_Empleado As [String], parDireccion As [String], parCiudad As [String], parRegion As [String], parPais As [String], _
		parTelefono As [String]) As [String]
		Dim empleado As New DEmpleados()
		empleado.Nombre_Empleado = parNombre_Empleado
		empleado.Apellido_Empleado = parApellido_Empleado
		empleado.Direccion = parDireccion
		empleado.Ciudad = parCiudad
		empleado.Region = parRegion
		empleado.Pais = parPais
		empleado.Telefono = parTelefono

		Return empleado.Insertar(empleado)
	End Function

	Public Shared Function Editar(parId_Empleado As Integer, parNombre_Empleado As [String], parApellido_Empleado As [String], parDireccion As [String], parCiudad As [String], parRegion As [String], _
		parPais As [String], parTelefono As [String]) As [String]
		Dim empleado As New DEmpleados()
		empleado.Id_Empleado = parId_Empleado
		empleado.Nombre_Empleado = parNombre_Empleado
		empleado.Apellido_Empleado = parApellido_Empleado
		empleado.Direccion = parDireccion
		empleado.Ciudad = parCiudad
		empleado.Region = parRegion
		empleado.Pais = parPais
		empleado.Telefono = parTelefono

		Return empleado.Editar(empleado)
	End Function
End Class
