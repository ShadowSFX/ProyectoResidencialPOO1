Public Class FrmPrincipal

    Dim DBConn As Conector

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConn = New Conector()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        DBConn.BuscarRegistro("clientes", "codcliente", "0301000013")
    End Sub

    Private Sub MaestroDeAsesoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaestroDeAsesoresToolStripMenuItem.Click
        Dim FrmAsesores1 As FrmAsesores = New FrmAsesores()
        FrmAsesores1.MdiParent = Me
        FrmAsesores1.Show()
    End Sub
End Class
