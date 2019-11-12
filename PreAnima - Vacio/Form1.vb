Imports Npgsql
Public Class Form1
    Dim ListaAlumnos As New List(Of Alumno)
    Dim ListaTalleres As New List(Of Taller)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim cadenaComando = ("SELECT * FROM Usuario")

            Dim clasecnn = New ConnectionPgSql
            Dim conexion As New NpgsqlConnection()
            conexion = clasecnn.AbrirConexion()

            Dim cmd = New NpgsqlCommand(cadenaComando, conexion)
            Dim lector As NpgsqlDataReader
            lector = cmd.ExecuteReader()


            If lector.HasRows Then

                Dim i As Integer = 0
                While lector.Read()
                    Dim ci = (lector(0).ToString)
                    Dim nombre = (lector(1).ToString)
                    Dim fecha = (lector(2).ToString)
                    Dim liceoActual = (lector(3).ToString)

                    Dim Alumno As New Alumno(ci, nombre, fecha, liceoActual)
                    ListaAlumnos.Add(Alumno)

                    lvAlumnos.Items.Add(lector(0).ToString)

                    lvAlumnos.Items(i).SubItems.Add(lector(1).ToString)
                    i += 1
                End While
                lector.Close()
            End If

        Catch ex As Exception

        End Try
        Try
            Dim cadenaComando = ("SELECT * FROM Taller")

            Dim clasecnn = New ConnectionPgSql
            Dim conexion As New NpgsqlConnection()
            conexion = clasecnn.AbrirConexion()

            Dim cmd = New NpgsqlCommand(cadenaComando, conexion)
            Dim lector2 As NpgsqlDataReader
            lector2 = cmd.ExecuteReader()


            If lector2.HasRows Then

                Dim i As Integer = 0
                While lector2.Read()
                    Dim id = (lector2(0).ToString)
                    Dim descripcion = (lector2(1).ToString)
                    Dim fecha = Nothing


                    Dim Taller As New Taller(id, descripcion, fecha)
                    ListaTalleres.Add(Taller)

                    cbxTaller.Items.Add(lector2(1).ToString)
                    i += 1
                End While
                lector2.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim calificacion As New Calificacion()
        Dim calif As String = 0
        For Each Taller In ListaTalleres
            If cbxTaller.SelectedItem = Taller.Descripcion Then
                calificacion.Id_taller = Taller.Id
            End If
        Next
        For Each Alumno In ListaAlumnos
            If lvAlumnos.SelectedItems.Item(0).Text = Alumno.Ci Then
                calificacion.Ci = Alumno.Ci
            End If
        Next

        If RadioButton1.Checked Then
            calif = 1
        End If
        If RadioButton2.Checked Then
            calif = 2
        End If
        If RadioButton3.Checked Then
            calif = 3
        End If
        If RadioButton4.Checked Then
            calif = 4
        End If
        calificacion.Calificacion = calif
        Dim clasecnn = New ConnectionPgsQL
        Dim conexion As New Npgsql.NpgsqlConnection()
        conexion = clasecnn.AbrirConexion()
        Dim cmd = New Npgsql.NpgsqlCommand()
        cmd.Connection = conexion
        cmd.CommandText = "INSERT INTO Calificacion (id_taller, ci, Calificacion) Values(" + calificacion.Id_taller.ToString + "," + calificacion.Ci.ToString + "," + calificacion.Calificacion + ");"
        cmd.ExecuteNonQuery()


    End Sub
End Class

