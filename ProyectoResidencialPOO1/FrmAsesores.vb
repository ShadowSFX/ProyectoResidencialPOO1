Public Class FrmAsesores

    Dim sModo As String = "B"

    Dim objAdminBotones As AdministradorBotones

    Private Sub FrmAsesores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objAdminBotones = New AdministradorBotones(btnAgregar, BtnModificar, btnEliminar, BtnGuardar, btnCancelar)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        sModo = "C"
        objAdminBotones.CambiarEstados(sModo)
        LimpiarTextBoxes()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        sModo = "M"
        objAdminBotones.CambiarEstados(sModo)
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim sConsulta As String

        If sModo = "C" Then 'creando registro nuevo
            If BDAdmin.getInstance.BuscarRegistro("asesores", "codasesor", txtCodAsesor.Text) = 1 Then
                MessageBox.Show("Ya existe un asesor con el código ingresado")
                Return
            Else
                sConsulta = String.Format("INSERT INTO asesores (`codasesor`, `nombres`, `apellidos`, `direccion`, `telefono`, `dui`, `nit`) " &
                                                        "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", txtCodAsesor.Text, txtNombres.Text,
                                                        txtApellidos.Text, txtDireccion.Text, txtTelefono.Text, txtDui.Text, txtNit.Text)
            End If
        Else ' Modificando
            sConsulta = String.Format("UPDATE asesores SET `nombres` = '{0}', `apellidos` = '{1}', `direccion` = '{2}', `telefono` = '{3}', `dui` = '{4}', `nit` = '{5}'",
                                      txtNombres.Text, txtApellidos.Text, txtDireccion.Text, txtTelefono.Text, txtDui.Text, txtNit.Text)
        End If

        If BDAdmin.getInstance.EjecutarComando(sConsulta) = 1 Then
            If sModo = "C" Then
                MessageBox.Show("Registro agregado satisfactoriamente.")
            Else
                MessageBox.Show("Registro modificado satisfactoriamente.")
            End If

            sModo = "B"
            objAdminBotones.CambiarEstados(sModo)
        Else
            If sModo = "C" Then
                MessageBox.Show("No se pudo agregar el registro.")
            Else
                MessageBox.Show("No se pudo modificar el registro.")
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        sModo = "B"
        objAdminBotones.CambiarEstados(sModo)
        LimpiarTextBoxes()
    End Sub

    Private Sub txtCodAsesor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodAsesor.KeyDown
        If e.KeyCode = Keys.Return Then
            Try
                Dim sConsulta As String = String.Format("SELECT * FROM asesores WHERE codasesor = '{0}'", txtCodAsesor.Text)

                Using Lector As DataTableReader = BDAdmin.getInstance.EjecutarConsulta(sConsulta)
                    While Lector.Read
                        txtNombres.Text = CStr(Lector("nombres"))
                        txtApellidos.Text = CStr(Lector("apellidos"))
                        txtDireccion.Text = CStr(Lector("direccion"))
                        txtTelefono.Text = CStr(Lector("telefono"))
                        txtDui.Text = CStr(Lector("dui"))
                        txtNit.Text = CStr(Lector("nit"))
                    End While
                End Using

                If txtNombres.Text = "" Then
                    MessageBox.Show("No se encontró un asesor con el código ingresado.")
                Else
                    objAdminBotones.CambiarEstados("E")
                End If


            Catch ex As MySql.Data.MySqlClient.MySqlException
                MessageBox.Show(ex.Message)
            Catch ex2 As Exception
                MessageBox.Show(ex2.Message)
            End Try
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim sConsulta As String = String.Format("DELETE FROM asesores WHERE codasesor = '{0}'", txtCodAsesor.Text)
        If BDAdmin.getInstance.EjecutarComando(sConsulta) = 1 Then
            MessageBox.Show("Asesor eliminado satisfactoriamente.")
            LimpiarTextBoxes()
        Else
            MessageBox.Show("No se pudo eliminar el asesor.")
        End If
    End Sub

    Private Sub LimpiarTextBoxes()
        txtCodAsesor.Text = ""
        txtNombres.Text = ""
        txtApellidos.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtDui.Text = ""
        txtNit.Text = ""
    End Sub

End Class