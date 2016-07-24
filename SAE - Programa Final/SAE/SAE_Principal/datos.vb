Public Class datos
    Dim usuario As String
    Dim password As String
    Public Property nomusuario()
        Get
            Return usuario
        End Get
        Set(ByVal value)
            usuario = value
        End Set
    End Property
    Public Property passusuario()
        Get
            Return password
        End Get
        Set(ByVal value)
            password = value
        End Set
    End Property
    Public Sub New(ByVal usuario As String, ByVal password As String)
        nomusuario = usuario
        passusuario = password
    End Sub
    Public Sub New()
    End Sub
End Class
