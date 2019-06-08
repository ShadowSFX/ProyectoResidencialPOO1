
Public Class FrmMaestroViviendas
    Dim objAdminBotones As AdministradorBotones
    Dim sModo As String = "B"


    Private Sub FrmViviendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objAdminBotones = New AdministradorBotones(btnAgregar, BtnModificar, btnEliminar, BtnGuardar, btnCancelar)
        objAdminBotones.CambiarEstados(sModo)

        Dim sConsulta As String = String.Format("SELECT codmodelo_vivienda, descripcion FROM modelos_viviendas")
        Dim dt As DataTable = New DataTable()
        dt.Load(BDAdmin.getInstance.EjecutarConsulta(sConsulta))
        cbbModelo.DataSource = dt
        cbbModelo.ValueMember = "codmodelo_vivienda"
        cbbModelo.DisplayMember = "descripcion"


        sConsulta = String.Format("SELECT codestado_vivienda, descripcion FROM estados_viviendas")
        dt = New DataTable()
        dt.Load(BDAdmin.getInstance.EjecutarConsulta(sConsulta))
        cbbEstado.DataSource = dt
        cbbEstado.ValueMember = "codestado_vivienda"
        cbbEstado.DisplayMember = "descripcion"
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
            If BDAdmin.getInstance.BuscarRegistro("viviendas", "codvivienda", cbbEstado.ValueMember) = 1 Then
                MessageBox.Show("Ya existe el código ingresado")
                Return
            Else
                sConsulta = String.Format("INSERT INTO viviendas (`codvivienda`, `codmodelo_vivienda`,`codestado_vivienda`, `precio`) " &
                                                        "VALUES ('{0}', '{1}', '{2}',{3} )", txtCod.Text, cbbModelo.SelectedValue.ToString(),
                                                        cbbEstado.SelectedValue.ToString(), txtPrecio.Text)
            End If
        Else ' Modificando
            sConsulta = String.Format("UPDATE viviendas SET `codmodelo_vivienda` = '{0}', `codestado_vivienda` = '{1}', `precio` = {2} WHERE codvivienda ={3}",
                                      cbbModelo.SelectedValue.ToString(), cbbEstado.SelectedValue.ToString(), Double.Parse(txtPrecio.Text), Integer.Parse(txtCod.Text))
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

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim sConsulta As String = String.Format("DELETE FROM viviendas WHERE codvivienda = {0}", txtCod.Text)
        If BDAdmin.getInstance.EjecutarComando(sConsulta) = 1 Then
            MessageBox.Show("Registro eliminado satisfactoriamente.")
            LimpiarTextBoxes()
        Else
            MessageBox.Show("No se pudo eliminar.")

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MessageBox.Show(cbbModelo.ValueMember)
    End Sub

    Private Sub txtCod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCod.KeyDown
        If e.KeyCode = Keys.Return And sModo = "B" Then
            Try
                Dim sConsulta As String = String.Format("SELECT * FROM viviendas WHERE codvivienda = '{0}'", txtCod.Text)

                Using Lector As DataTableReader = BDAdmin.getInstance.EjecutarConsulta(sConsulta)
                    While Lector.Read
                        cbbEstado.SelectedValue = CStr(Lector("codestado_vivienda"))
                        cbbModelo.SelectedValue = CStr(Lector("codmodelo_vivienda"))
                        txtPrecio.Text = CStr(Lector("precio"))

                    End While
                End Using

                If txtPrecio.Text = "" Then
                    MessageBox.Show("No se encontró el código ingresado.")
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
    Sub LimpiarTextBoxes()
        txtCod.Text = ""
        txtPrecio.Text = ""
    End Sub
End Class