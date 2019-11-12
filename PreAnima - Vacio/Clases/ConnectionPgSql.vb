Public Class ConnectionPgsQL
    Public Function AbrirConexion() As Npgsql.NpgsqlConnection
        Dim conexion As Npgsql.NpgsqlConnection
        conexion = New Npgsql.NpgsqlConnection()
        Dim cadenaDeConexion As String
        cadenaDeConexion = "Server=localhost;Port=4444;User Id='postgres';Password='root';Database=preanima"
        Try
            conexion.ConnectionString = cadenaDeConexion
            conexion.Open()
        Catch ex As Exception
            conexion.Close()
            Throw ex
        End Try
        Return conexion
    End Function
End Class