Imports MySql.Data.MySqlClient

Public Class Conector

    Dim sCadenaConexion As String = "server=localhost;userid=root;password=root;database=residencial"
    Dim MySQLConn As MySqlConnection

    Public Function BuscarRegistro(sNomTabla As String, sNomCampo As String, sValor As String)

        Try
            Using MySQLConn As MySqlConnection = New MySqlConnection(sCadenaConexion)
                MySQLConn.Open()
                Dim sConsulta As String = String.Format("SELECT COUNT(*) as 'total' FROM {0} WHERE {1} = '{2}'", sNomTabla, sNomCampo, sValor)
                Using comando As MySqlCommand = New MySqlCommand(sConsulta, MySQLConn)
                    Using Lector As MySqlDataReader = comando.ExecuteReader
                        While Lector.Read
                            Return CInt(Lector("total"))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Catch ex2 As Exception
            MessageBox.Show(ex2.Message)
        End Try

        Return 0
    End Function

    Public Function EjecutarConsulta(sConsulta As String)
        Try
            Using MySQLConn As MySqlConnection = New MySqlConnection(sCadenaConexion)
                MySQLConn.Open()

                Dim comando As MySqlCommand = New MySqlCommand(sConsulta, MySQLConn)
                comando.ExecuteNonQuery()

                Return 1
            End Using
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try

        Return 0
    End Function

End Class
