﻿Public Class FrmPrincipal

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub MaestroDeAsesoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaestroDeAsesoresToolStripMenuItem.Click
        Dim FrmAsesores1 As FrmAsesores = New FrmAsesores()
        FrmAsesores1.MdiParent = Me
        FrmAsesores1.Show()
    End Sub

End Class
