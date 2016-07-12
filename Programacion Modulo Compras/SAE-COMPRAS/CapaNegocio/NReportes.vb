Imports System.Collections.Generic
Imports System.Data
Imports CapaDatos
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class NReportes
	Public Shared Function MostrarTop10Proveedores(parFechaInicial As [String], parFechaFinal As [String]) As DataTable
		Return New DReportes().MostrarTop10Proveedores(parFechaInicial, parFechaFinal)
	End Function

	Public Shared Function MostrarTop10Empleados(parFechaInicial As [String], parFechaFinal As [String]) As DataTable
		Return New DReportes().MostrarTop10Empleados(parFechaInicial, parFechaFinal)
	End Function

	Public Shared Function MostrarTop10Productos(parFechaInicial As [String], parFechaFinal As [String]) As DataTable
		Return New DReportes().MostrarTop10Productos(parFechaInicial, parFechaFinal)
	End Function

	Public Shared Function MostrarHistorialProveedor(parFechaInicial As [String], parFechaFinal As [String], parProveedor As [String]) As DataTable
		Return New DReportes().MostrarHistorialProveedor(parFechaInicial, parFechaFinal, parProveedor)
	End Function

	Public Shared Function MostrarHistorialEmpleado(parFechaInicial As [String], parFechaFinal As [String], parEmpleado As [String]) As DataTable
		Return New DReportes().MostrarHistorialEmpleado(parFechaInicial, parFechaFinal, parEmpleado)
	End Function

	Public Shared Function MostrarHistorialProducto(parFechaInicial As [String], parFechaFinal As [String], parProducto As [String]) As DataTable
		Return New DReportes().MostrarHistorialProducto(parFechaInicial, parFechaFinal, parProducto)
	End Function
End Class
