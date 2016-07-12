Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class DRestauracion
	Public Function GenerarBackUp() As [String]
		Dim Respuesta As [String] = ""
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnMaster
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "dbo.GenerarBackUp"
			SqlComando.CommandType = CommandType.StoredProcedure

			SqlComando.ExecuteNonQuery()
			Respuesta = "Y"

		Catch ex As Exception
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado dbo.GenerarBackUp. " & ex.Message, ex)
		Finally

			SqlConexion.Close()
		End Try

		Return Respuesta
	End Function

	Public Function RestaurarBackUp(parNombreArchivo__1 As [String]) As [String]
		Dim Respuesta As [String] = ""
		Dim SqlConexion As New SqlConnection()

		Try
			SqlConexion.ConnectionString = DConexion.CnMaster
			SqlConexion.Open()

			Dim SqlComando As New SqlCommand()
			SqlComando.Connection = SqlConexion
			SqlComando.CommandText = "dbo.RestaurarBackUp"
			SqlComando.CommandType = CommandType.StoredProcedure

			Dim ParNombreArchivo__2 As New SqlParameter()
			ParNombreArchivo__2.ParameterName = "@NombreArchivo"
			ParNombreArchivo__2.SqlDbType = SqlDbType.VarChar
			ParNombreArchivo__2.Size = parNombreArchivo__1.Length
			ParNombreArchivo__2.Value = parNombreArchivo__1
			SqlComando.Parameters.Add(ParNombreArchivo__2)

			SqlComando.ExecuteNonQuery()
			Respuesta = "Y"

		Catch ex As Exception
			Throw New Exception("Error al intentar ejecutar el procedimiento almacenado dbo.RestaurarBackUp. " & ex.Message, ex)
		Finally

			SqlConexion.Close()
		End Try

		Return Respuesta
	End Function
End Class
