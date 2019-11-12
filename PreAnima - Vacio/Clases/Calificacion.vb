Public Class Calificacion
    Dim _id_taller As Integer
    Dim _ci As Integer
    Dim _calificacion As String

    Public Sub New()
    End Sub

    Sub New(_id As Integer, _ci As Integer, calificacion As String)

        Id_taller = Id_taller
        Ci = Ci
        calificacion = _calificacion

    End Sub
    Public Property Calificacion As String

        Get
            Return _calificacion
        End Get
        Set(value As String)
            _calificacion = value
        End Set

    End Property

    Public Property Ci As Integer

        Get
            Return _ci
        End Get
        Set(value As Integer)
            _ci = value
        End Set

    End Property

    Public Property Id_taller As Integer

        Get
            Return _id_taller
        End Get
        Set(value As Integer)
            _id_taller = value
        End Set

    End Property

End Class
