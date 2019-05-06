Public Class AdministradorBotones

    Dim btnAgregar As Button
    Dim btnModificar As Button
    Dim btnEliminar As Button
    Dim btnGuardar As Button
    Dim btnCancelar As Button

    Public Sub New(ByRef btnAgregar As Button, ByRef btnModificar As Button, ByRef btnEliminar As Button, ByRef btnGuardar As Button, ByRef btnCancelar As Button)
        Me.btnAgregar = btnAgregar
        Me.btnModificar = btnModificar
        Me.btnEliminar = btnEliminar
        Me.btnGuardar = btnGuardar
        Me.btnCancelar = btnCancelar
    End Sub

    Public Sub CambiarEstados(sEstado As String)
        Select Case sEstado
            Case "C", "M" ' creando o modificando
                CambiarEstadosDeBotones(0, 0, 0, 1, 1)
            Case "B" ' buscando
                CambiarEstadosDeBotones(1, 0, 0, 0, 0)
            Case "E" ' encontrado
                CambiarEstadosDeBotones(1, 1, 1, 0, 0)
            Case Else
                MessageBox.Show("Estado inexistente.")
        End Select
    End Sub

    Private Sub CambiarEstadosDeBotones(bAgregar As Boolean, bModificar As Boolean, bEliminar As Boolean, bGuardar As Boolean, bCancelar As Boolean)
        btnAgregar.Enabled = bAgregar
        btnModificar.Enabled = bModificar
        btnEliminar.Enabled = bEliminar
        btnGuardar.Enabled = bGuardar
        btnCancelar.Enabled = bCancelar
    End Sub

End Class
