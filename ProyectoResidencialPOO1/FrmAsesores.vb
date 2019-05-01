Public Class FrmAsesores
    Dim DBConn As Conector

    Private Sub FrmAsesores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConn = New Conector()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If DBConn.BuscarRegistro("asesores", "codasesor", txtCodAsesor.Text) = 1 Then
            MessageBox.Show("Ya existe un asesor con el código ingresado")
        Else
            Dim sConsulta As String = String.Format("INSERT INTO asesores (`codasesor`, `nombres`, `apellidos`, `direccion`, `telefono`, `dui`, `nit`) " &
                                                    "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", txtCodAsesor.Text, txtNombres.Text,
                                                    txtApellidos.Text, txtDireccion.Text, txtTelefono.Text, txtDui.Text, txtNit.Text)

            If DBConn.EjecutarConsulta(sConsulta) = 1 Then
                MessageBox.Show("Registro agregado satisfactoriamente.")
            Else
                MessageBox.Show("No se pudo agregar el registro.")
            End If
        End If
    End Sub
End Class