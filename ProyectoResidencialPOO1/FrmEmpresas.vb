Public Class FrmEmpresas
    Dim sModo As String = "B"

    Dim objAdminBotones As AdministradorBotones

    Private Sub FrmAsesores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objAdminBotones = New AdministradorBotones(btnAgregar, BtnModificar, btnEliminar, BtnGuardar, btnCancelar)
        objAdminBotones.CambiarEstados(sModo)
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
            If BDAdmin.getInstance.BuscarRegistro("empresas", "codempresa", txtCodEmpresa.Text) = 1 Then
                MessageBox.Show("Ya existe una empresa con el código ingresado")
                Return
            Else
                sConsulta = String.Format("INSERT INTO empresas (`codempresa`, `nombre`, `direccion`, `telefono`, `nrc`, `nit`) " &
                                                        "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", txtCodEmpresa.Text, txtNombre.Text,
                                                        txtDireccion.Text, txtTelefono.Text, txtNRC.Text, txtNit.Text)
            End If
        Else ' Modificando
            sConsulta = String.Format("UPDATE empresas SET `nombre` = '{0}', `direccion` = '{1}', `telefono` = '{2}', `nrc` = '{3}', `nit` = '{4}' WHERE codempresa ='{5}'",
                                      txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtNRC.Text, txtNit.Text, txtCodEmpresa.Text)
        End If

        If BDAdmin.getInstance.EjecutarComando(sConsulta) = 1 Then
            If sModo = "C" Then
                MessageBox.Show("Registro agregado satisfactoriamente.")
            Else
                MessageBox.Show("Registro modificado satisfactoriamente.")
            End If

            sModo = "B"
            objAdminBotones.CambiarEstados(sModo)
            LimpiarTextBoxes()
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

    Private Sub txtCodAsesor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodEmpresa.KeyDown
        If e.KeyCode = Keys.Return And sModo = "B" Then
            Try
                Dim sConsulta As String = String.Format("SELECT * FROM empresas WHERE codempresa = '{0}'", txtCodEmpresa.Text)

                Using Lector As DataTableReader = BDAdmin.getInstance.EjecutarConsulta(sConsulta)
                    While Lector.Read
                        txtNombre.Text = CStr(Lector("nombre"))
                        txtDireccion.Text = CStr(Lector("direccion"))
                        txtTelefono.Text = CStr(Lector("telefono"))
                        txtNRC.Text = CStr(Lector("nrc"))
                        txtNit.Text = CStr(Lector("nit"))
                    End While
                End Using

                If txtNombre.Text = "" Then
                    MessageBox.Show("No se encontró la empresa con el código ingresado.")
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
        Dim sConsulta As String = String.Format("DELETE FROM empresas WHERE codempresa = '{0}'", txtCodEmpresa.Text)
        If BDAdmin.getInstance.EjecutarComando(sConsulta) = 1 Then
            MessageBox.Show("Empresa eliminada satisfactoriamente.")
            LimpiarTextBoxes()
        Else
            MessageBox.Show("No se pudo eliminar la empresa.")
        End If
    End Sub

    Private Sub LimpiarTextBoxes()
        txtCodEmpresa.Text = ""
        txtNombre.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtNRC.Text = ""
        txtNit.Text = ""
    End Sub

End Class