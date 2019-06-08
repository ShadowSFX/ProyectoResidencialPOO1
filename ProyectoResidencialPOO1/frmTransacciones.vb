Public Class frmTransacciones
    Dim sModo As String = "B"

    Dim objAdminBotones As AdministradorBotones

    Private Sub frmTransacciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objAdminBotones = New AdministradorBotones(btnAgregar, BtnModificar, btnEliminar, BtnGuardar, btnCancelar)
        objAdminBotones.CambiarEstados(sModo)

        Dim sConsulta As String = String.Format("SELECT * FROM tipostransacciones")
        Dim dt As DataTable = New DataTable()
        dt.Load(BDAdmin.getInstance.EjecutarConsulta(sConsulta))
        cbbTransaccion.DataSource = dt
        cbbTransaccion.ValueMember = "codtipotransaccion"
        cbbTransaccion.DisplayMember = "descripcion"
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        sModo = "C"
        objAdminBotones.CambiarEstados(sModo)
        LimpiarTextBoxes()
        mtbFecha.Select()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        sModo = "M"
        objAdminBotones.CambiarEstados(sModo)
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim sConsulta As String

        Dim fec As String = (Date.ParseExact(mtbFecha.Text, "dd/MM/yyyy", Globalization.CultureInfo.InvariantCulture)).ToString("yyyyMMdd")

        If sModo = "C" Then 'creando registro nuevo

            sConsulta = String.Format("SELECT count(*) as total FROM transacciones WHERE serie = '{0}' and numdocumento = {1}", txtSerie.Text, txtNumDoc.Text)
            Using Lector As DataTableReader = BDAdmin.getInstance.EjecutarConsulta(sConsulta)
                If Lector.Read Then
                    If CInt(Lector("total")) = 1 Then
                        MessageBox.Show("Ya existe una transacción con la serie y número de documento ingresado.")
                        Return
                    End If
                End If
            End Using


            sConsulta = String.Format("INSERT INTO transacciones (`codasesor`, `codcliente`, `codvivienda`, `fecha`, `serie`, `numdocumento`, `valor`, `codtipotransaccion`)
                                        VALUES ('{0}', '{1}', '{2}', {3},'{4}', '{5}', {6}, '{7}')", txtCodAsesor.Text, txtCodCliente.Text, txtCodVivienda.Text,
                                        fec, txtSerie.Text, txtNumDoc.Text, Double.Parse(txtValor.Text), cbbTransaccion.SelectedValue.ToString())

        Else ' Modificando

            sConsulta = String.Format("UPDATE transacciones SET `codasesor`='{0}', `codcliente`='{1}', `codvivienda`='{2}', `fecha`={3}, `valor`='{4}', `codtipotransaccion`='{5}' WHERE serie ='{6}' and numdocumento = {7}",
                                txtCodAsesor.Text, txtCodCliente.Text, txtCodVivienda.Text, fec, Double.Parse(txtValor.Text), cbbTransaccion.SelectedValue.ToString(), txtSerie.Text, txtNumDoc.Text)

        End If

        If BDAdmin.getInstance.EjecutarComando(sConsulta) = 1 Then

            'cambiando estado de la vivienda
            Dim sCodEstado As String = (Integer.Parse(cbbTransaccion.SelectedValue.ToString()) + 1).ToString()
            sConsulta = String.Format("UPDATE viviendas SET `codestado_vivienda` = '{0}' WHERE codvivienda = '{1}'", sCodEstado, txtCodVivienda.Text)

            If BDAdmin.getInstance.EjecutarComando(sConsulta) = 1 Then
                MessageBox.Show("Registro guardado.")

                sModo = "B"
                objAdminBotones.CambiarEstados(sModo)
                LimpiarTextBoxes()
            Else
                MessageBox.Show("No se pudo modificar el estado de la vivienda.")
            End If
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

    Private Sub txtSerie_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSerie.KeyDown, txtNumDoc.KeyDown
        If e.KeyCode = Keys.Return And sModo = "B" Then
            Try
                Dim sConsulta As String = String.Format("SELECT 
		                                                    transacciones.fecha,
		                                                    transacciones.codasesor, CONCAT(asesores.nombres,' ', asesores.apellidos) as nombres, 
		                                                    transacciones.codcliente, CONCAT(clientes.nombres,' ', clientes.apellidos) as nombrecliente,  
		                                                    codvivienda, codtipotransaccion, valor 
                                                        FROM transacciones
                                                        INNER JOIN asesores on asesores.codasesor = transacciones.codasesor
                                                        INNER JOIN clientes on clientes.codcliente = transacciones.codcliente
                                                        WHERE serie = '{0}' and numdocumento = '{1}'", txtSerie.Text, txtNumDoc.Text)

                Using Lector As DataTableReader = BDAdmin.getInstance.EjecutarConsulta(sConsulta)
                    While Lector.Read
                        mtbFecha.Text = CDate(Lector("fecha"))
                        txtCodAsesor.Text = CStr(Lector("codasesor"))
                        txtNombreAsesor.Text = CStr(Lector("nombres"))
                        txtCodCliente.Text = CStr(Lector("codcliente"))
                        txtNombreCliente.Text = CStr(Lector("nombrecliente"))
                        txtCodVivienda.Text = CStr(Lector("codvivienda"))
                        txtValor.Text = CStr(Lector("valor"))
                        cbbTransaccion.SelectedValue = CStr(Lector("codtipotransaccion"))
                    End While
                End Using

                If txtCodAsesor.Text = "" Then
                    MessageBox.Show("No se encontró la transacción con serie y número de documento ingresado.")
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

        'Borrando transacción
        Dim sConsulta As String = String.Format("DELETE FROM transacciones WHERE serie = '{0}' and numdocumento = '{1}'", txtSerie.Text, txtNumDoc.Text)
        If BDAdmin.getInstance.EjecutarComando(sConsulta) = 1 Then

            'Regresando estado de vivienda al normal
            sConsulta = String.Format("UPDATE viviendas SET `codestado_vivienda` = '{0}' WHERE codvivienda = '{1}'", "1", txtCodVivienda.Text)

            If BDAdmin.getInstance.EjecutarComando(sConsulta) = 1 Then

            End If

            MessageBox.Show("Transaccion eliminada satisfactoriamente.")
            LimpiarTextBoxes()
        Else
            MessageBox.Show("No se pudo eliminar la transacción.")
        End If
    End Sub

    Private Sub LimpiarTextBoxes()
        mtbFecha.Text = ""
        txtSerie.Text = ""
        txtNumDoc.Text = ""
        txtCodAsesor.Text = ""
        txtNombreAsesor.Text = ""
        txtCodCliente.Text = ""
        txtNombreCliente.Text = ""
        txtCodVivienda.Text = ""
        txtValor.Text = ""
    End Sub

    Private Sub txtCodAsesor_Leave(sender As Object, e As EventArgs) Handles txtCodAsesor.Leave
        If sModo <> "B" Then
            Try
                Dim sConsulta As String = String.Format("SELECT CONCAT(asesores.nombres,' ', asesores.apellidos) as nombre FROM asesores WHERE codasesor = '{0}'", txtCodAsesor.Text)

                Using Lector As DataTableReader = BDAdmin.getInstance.EjecutarConsulta(sConsulta)
                    While Lector.Read
                        txtNombreAsesor.Text = CStr(Lector("nombre"))
                    End While
                End Using

                If txtNombreAsesor.Text = "" Then
                    MessageBox.Show("No existe un asesor con el código ingresado.")
                    txtCodAsesor.Text = ""
                End If

            Catch ex As MySql.Data.MySqlClient.MySqlException
                MessageBox.Show(ex.Message)
            Catch ex2 As Exception
                MessageBox.Show(ex2.Message)
            End Try
        End If
    End Sub

    Private Sub txtCodCliente_Leave(sender As Object, e As EventArgs) Handles txtCodCliente.Leave
        If sModo <> "B" Then
            Try
                Dim sConsulta As String = String.Format("SELECT CONCAT(clientes.nombres,' ', clientes.apellidos) as nombre FROM clientes WHERE codcliente = '{0}'", txtCodCliente.Text)

                Using Lector As DataTableReader = BDAdmin.getInstance.EjecutarConsulta(sConsulta)
                    While Lector.Read
                        txtNombreCliente.Text = CStr(Lector("nombre"))
                    End While
                End Using

                If txtNombreCliente.Text = "" Then
                    MessageBox.Show("No existe un cliente con el código.")
                    txtCodCliente.Text = ""
                End If

            Catch ex As MySql.Data.MySqlClient.MySqlException
                MessageBox.Show(ex.Message)
            Catch ex2 As Exception
                MessageBox.Show(ex2.Message)
            End Try
        End If
    End Sub
End Class