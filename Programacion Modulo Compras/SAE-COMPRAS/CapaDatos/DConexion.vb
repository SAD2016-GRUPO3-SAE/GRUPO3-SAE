Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class DConexion
	'public static String cn = "Data Source=DESKTOP-U4KBH5U\SQLEXPRESS;Initial Catalog=BDEmpresa;Integrated Security=True";
	Public Shared CnBDEmpresa As [String] = "Data Source=CARLOS_ESPINOSA\SQLEXPRESS;Initial Catalog=BDEmpresa;Integrated Security=True"
	Public Shared CnMaster As [String] = "Data Source=CARLOS_ESPINOSA\SQLEXPRESS;Initial Catalog=BDEmpresa;Integrated Security=True"

	Public Function ChequearConexion() As [String]
		Dim mensaje As [String] = ""
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnBDEmpresa
			SqlConexion.Open()
			mensaje = "Y"
		Catch ex As Exception
			mensaje = ex.Message
		Finally
			SqlConexion.Close()
		End Try

		Return mensaje
	End Function
End Class

