<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaestroDeEmpresasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaestroDeAsesoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarTransacciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaestroDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaestroDeViviendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.TransaccionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1146, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaestroDeEmpresasToolStripMenuItem, Me.MaestroDeAsesoresToolStripMenuItem, Me.MaestroDeClientesToolStripMenuItem, Me.MaestroDeViviendasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'MaestroDeEmpresasToolStripMenuItem
        '
        Me.MaestroDeEmpresasToolStripMenuItem.Name = "MaestroDeEmpresasToolStripMenuItem"
        Me.MaestroDeEmpresasToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.MaestroDeEmpresasToolStripMenuItem.Text = "Maestro de empresas"
        '
        'MaestroDeAsesoresToolStripMenuItem
        '
        Me.MaestroDeAsesoresToolStripMenuItem.Name = "MaestroDeAsesoresToolStripMenuItem"
        Me.MaestroDeAsesoresToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.MaestroDeAsesoresToolStripMenuItem.Text = "Maestro de asesores"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'TransaccionesToolStripMenuItem
        '
        Me.TransaccionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarTransacciónToolStripMenuItem})
        Me.TransaccionesToolStripMenuItem.Name = "TransaccionesToolStripMenuItem"
        Me.TransaccionesToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.TransaccionesToolStripMenuItem.Text = "Transacciones"
        '
        'RegistrarTransacciónToolStripMenuItem
        '
        Me.RegistrarTransacciónToolStripMenuItem.Name = "RegistrarTransacciónToolStripMenuItem"
        Me.RegistrarTransacciónToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.RegistrarTransacciónToolStripMenuItem.Text = "Registrar transacción"
        '
        'MaestroDeClientesToolStripMenuItem
        '
        Me.MaestroDeClientesToolStripMenuItem.Name = "MaestroDeClientesToolStripMenuItem"
        Me.MaestroDeClientesToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.MaestroDeClientesToolStripMenuItem.Text = "Maestro de clientes"
        '
        'MaestroDeViviendasToolStripMenuItem
        '
        Me.MaestroDeViviendasToolStripMenuItem.Name = "MaestroDeViviendasToolStripMenuItem"
        Me.MaestroDeViviendasToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.MaestroDeViviendasToolStripMenuItem.Text = "Maestro de viviendas"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1146, 652)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmPrincipal"
        Me.Text = "Proyecto residencial POO 1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaestroDeAsesoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaestroDeEmpresasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaccionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarTransacciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaestroDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaestroDeViviendasToolStripMenuItem As ToolStripMenuItem
End Class
