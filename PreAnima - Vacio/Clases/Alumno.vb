Public Class Alumno

    Private _ci As Integer
    Private _nombre As String
    Private _fNacimiento As Date
    Private _liceoActual As String

    Sub New(_ci As Integer, _nombre As String, fNacimiento As Date, _liceoActual As String)
        Ci = _ci
        Nombre = _nombre
        fNacimiento = _fNacimiento
        liceoActual = _liceoActual
    End Sub
    Sub New()

    End Sub

    Public Property Ci As Integer

        Get
            Return _ci
        End Get
        Set(value As Integer)
            _ci = value
        End Set

    End Property
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property FechaNacimiento As Date
        Get
            Return _fNacimiento
        End Get
        Set(value As Date)
            _fNacimiento = value
        End Set

    End Property

    Public Property liceoActual As String
        Get
            Return _liceoActual
        End Get
        Set(value As String)
            _liceoActual = value
        End Set
    End Property
End Class