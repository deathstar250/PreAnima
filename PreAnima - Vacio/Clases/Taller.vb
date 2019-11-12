Public Class Taller
    Private _id As Integer
    Private _descripcion As String
    Private _fecha As Date
    Sub New(idTaller As String, descripcionTaller As String, fechaTaller As Date)

        Id = idTaller
        Descripcion = descripcionTaller
        Fecha = fechaTaller

    End Sub

    Public Property Id As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property Fecha As String
        Get
            Return _fecha
        End Get
        Set(value As String)
            _fecha = value
        End Set
    End Property

    Sub New()

    End Sub


End Class