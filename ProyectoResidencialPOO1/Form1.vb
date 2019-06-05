Public Class FrmPrincipal

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub MaestroDeAsesoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaestroDeAsesoresToolStripMenuItem.Click
        Dim FrmAsesores1 As FrmAsesores = New FrmAsesores()
        FrmAsesores1.MdiParent = Me
        FrmAsesores1.Show()
    End Sub

    Private Sub MaestroDeEmpresasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaestroDeEmpresasToolStripMenuItem.Click
        Dim frmEmpresas1 As FrmEmpresas = New FrmEmpresas()
        frmEmpresas1.MdiParent = Me
        frmEmpresas1.Show()
    End Sub

    Private Sub RegistrarTransacciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarTransacciónToolStripMenuItem.Click
        Dim frmTransacciones1 As frmTransacciones = New frmTransacciones()
        frmTransacciones1.MdiParent = Me
        frmTransacciones1.Show()
    End Sub

    Private Sub MaestroDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaestroDeClientesToolStripMenuItem.Click
        Dim frmMaestroClientes1 As FrmClientes = New FrmClientes()
        frmMaestroClientes1.MdiParent = Me
        frmMaestroClientes1.Show()
    End Sub

    Private Sub MaestroDeViviendasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaestroDeViviendasToolStripMenuItem.Click
        Dim frmMaestroViviendas1 As FrmMaestroViviendas = New FrmMaestroViviendas()
        frmMaestroViviendas1.MdiParent = Me
        frmMaestroViviendas1.Show()
    End Sub
End Class
