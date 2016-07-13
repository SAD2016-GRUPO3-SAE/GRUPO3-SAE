Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports CapaPresentacion

NotInheritable Class Program
	Private Sub New()
	End Sub
	''' &lt;summary&gt;
	''' The main entry point for the application.
	''' &lt;/summary&gt;
	<STAThread> _
	Friend Shared Sub Main()
		Application.EnableVisualStyles()
		Application.SetCompatibleTextRenderingDefault(False)
		Try
            Application.Run(New FrmInicio())
        Catch ex As Exception
			MessageBox.Show("La aplicación se cerrará. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
		End Try
	End Sub
End Class
