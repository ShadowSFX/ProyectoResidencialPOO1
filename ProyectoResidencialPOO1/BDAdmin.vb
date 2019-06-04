Imports MySql.Data.MySqlClient

Public Class BDAdmin

#Region "BLOQUE QUE HACE LA CLASE UN SINGLETON"

    ' -------------------------------------------- BLOQUE QUE HACE LA CLASE UN SINGLETON -------------------------------------
    ' Se crea un objeto de la clase para asignar el espacio en memoria para la clase única
    Private Shared objBDAdmin As BDAdmin

    ' El constructor tiene que ser privado para evitar instanciación de la clase desde otro lugar del sistema
    Private Sub New()
        ' cosas extra si es que se necesita
    End Sub

    ' Se expone getInstance() para obtener el objeto de la instacia
    Public Shared Function getInstance() As BDAdmin

        ' Inicializando la clase de manera peresoza
        ' para prevenir que la clase use espacio de memoria innecesariamente al no estar siendo usada
        If (objBDAdmin Is Nothing) Then
            objBDAdmin = New BDAdmin()
        End If

        Return objBDAdmin
    End Function
    '------------------------------------------ FIN DE BLOQUE QUE HACE LA CLASE UN SINGLETON ------------------------------------
#End Region

    Private sServidor As String = "localhost"
    Private sUsuario As String = "root"
    Private sClave As String = "root"
    Private sBaseDeDatos As String = "residencial"

    Private sCadenaConexion As String = String.Format("server={0};userid={1};password={2};database={3}", sServidor, sUsuario, sClave, sBaseDeDatos)
    Private MySQLConn As MySqlConnection

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

    Public Function EjecutarComando(sComando As String)
        Try
            Using MySQLConn As MySqlConnection = New MySqlConnection(sCadenaConexion)
                MySQLConn.Open()

                Dim comando As MySqlCommand = New MySqlCommand(sComando, MySQLConn)
                comando.ExecuteNonQuery()

                Return 1
            End Using
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try

        Return 0
    End Function

    Public Function EjecutarConsulta(sConsulta As String)
        Try
            Using MySQLConn As MySqlConnection = New MySqlConnection(sCadenaConexion)
                MySQLConn.Open()
                Using comando As MySqlCommand = New MySqlCommand(sConsulta, MySQLConn)
                    Using Lector As MySqlDataReader = comando.ExecuteReader
                        ' se crea un objeto de tipo datatable en donde se carga la información regresada por la consulta
                        ' y luego se regresa el objeto. No se puede mandar el datareader directamente porque al terminar de usarse
                        ' se cierra, por lo tanto da un error. Esto significa que se hace un copia de todo en memoria, por lo tanto
                        ' en ciertas circunstacias esto puede usar mucha memoria.
                        Dim dt As DataTable = New DataTable()
                        dt.Load(Lector)
                        Return dt.CreateDataReader()
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

End Class
