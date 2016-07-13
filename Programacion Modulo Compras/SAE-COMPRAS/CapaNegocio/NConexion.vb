Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports CapaDatos

Public Class NConexion
	Public Shared Function ChequearConexion() As [String]
		Return New DConexion().ChequearConexion()
	End Function
End Class
