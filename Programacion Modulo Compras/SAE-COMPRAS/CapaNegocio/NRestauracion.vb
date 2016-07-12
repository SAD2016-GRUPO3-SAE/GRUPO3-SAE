Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports CapaDatos

Public Class NRestauracion
	Public Shared Function GenerarBackUp() As [String]
		Return New DRestauracion().GenerarBackUp()
	End Function

	Public Shared Function RestaurarBackUp(parNombreArchivo As [String]) As [String]
		Return New DRestauracion().RestaurarBackUp(parNombreArchivo)
	End Function
End Class
