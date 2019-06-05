Public Class FrmClientes
    Dim sModo As String = "B"

    Dim objAdminBotones As AdministradorBotones
    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objAdminBotones = New AdministradorBotones(btnAgregar, BtnModificar, Btneliminar, BtnGuardar, btnCancelar)
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

        Dim sconsulta As String

        If sModo = "C" Then 'creando registro nuevo
            If BDAdmin.getInstance.BuscarRegistro("clientes", "codcliente", txtCodCliente.Text) = 1 Then
                MessageBox.Show("Ya existe un asesor con el código ingresado")
                Return
            Else
                sconsulta = String.Format("INSERT INTO clientes (`codcliente`, `nombres`, `apellidos`, `fecnac`´, `direccion`, `telefono`, `dui`, `nrc`, `nit`, `codempresa`, `cargo`, `salario`) " &
                   "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}')", txtCodCliente.Text, txtNombres.Text,
                                                    txtApellidos.Text, txtfecnac.Text, txtDireccion.Text, txtTelefono.Text, txtDui.Text, TxtNrc.Text, txtNit.Text, TxtcodEmpresa.Text, TxtCargo.Text, TxtSalario.Text)
            End If

        Else


            sconsulta = String.Format("UPDATE clientes SET `nombres` = '{0}', `apellidos` = '{1}', `fecnac` = '{2}', `direccion` = '{3}', `telefono` = '{4}', `dui` = '{5}',  `nrc` = '{6}', `nit` = '{7}', `codempresa` = '{8}', `cargo` = '{9}', `salario` = '{10}'" &
                                   " WHERE codcliente = '{11}'", txtNombres.Text, txtApellidos.Text, txtfecnac.Text, txtDireccion.Text, txtTelefono.Text, txtDui.Text, TxtNrc.Text, txtNit.Text, TxtNrc.Text, TxtcodEmpresa.Text, TxtCargo.Text, TxtSalario.Text, txtCodCliente.Text)
        End If


        If BDAdmin.getInstance.EjecutarComando(sconsulta) = 1 Then
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

    Private Sub LimpiarTextBoxes()
        txtCodCliente.Text = ""
        txtNombres.Text = ""
        txtApellidos.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtDui.Text = ""
        txtNit.Text = ""
    End Sub

    Private Sub Btneliminar_Click(sender As Object, e As EventArgs) Handles Btneliminar.Click
        Dim sConsulta As String = String.Format("DELETE FROM clientes WHERE codcliente = '{0}'", txtCodCliente.Text)
        If BDAdmin.getInstance.EjecutarComando(sConsulta) = 1 Then
            MessageBox.Show("Asesor eliminado satisfactoriamente.")
            LimpiarTextBoxes()
        Else
            MessageBox.Show("No se pudo eliminar el asesor.")
        End If
    End Sub
End Class

