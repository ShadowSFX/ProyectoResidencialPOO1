﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Btneliminar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtSalario = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtCargo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtcodEmpresa = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtNrc = New System.Windows.Forms.TextBox()
        Me.txtfecnac = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDui = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNit = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.BtnModificar)
        Me.GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.GroupBox1.Controls.Add(Me.Btneliminar)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 53)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(595, 80)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(475, 23)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 28)
        Me.btnCancelar.TabIndex = 22
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(341, 20)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 29)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "|"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(19, 23)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(100, 28)
        Me.btnAgregar.TabIndex = 18
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(124, 23)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(100, 28)
        Me.BtnModificar.TabIndex = 19
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(367, 23)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(100, 28)
        Me.BtnGuardar.TabIndex = 21
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'Btneliminar
        '
        Me.Btneliminar.Location = New System.Drawing.Point(232, 23)
        Me.Btneliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.Btneliminar.Name = "Btneliminar"
        Me.Btneliminar.Size = New System.Drawing.Size(100, 28)
        Me.Btneliminar.TabIndex = 20
        Me.Btneliminar.Text = "Eliminar"
        Me.Btneliminar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtSalario)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.TxtCargo)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.TxtcodEmpresa)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TxtNrc)
        Me.GroupBox2.Controls.Add(Me.txtfecnac)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtCodCliente)
        Me.GroupBox2.Controls.Add(Me.txtNombres)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtApellidos)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtDireccion)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtDui)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtNit)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtTelefono)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 144)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(596, 398)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información General"
        '
        'TxtSalario
        '
        Me.TxtSalario.Location = New System.Drawing.Point(108, 376)
        Me.TxtSalario.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSalario.MaxLength = 5
        Me.TxtSalario.Name = "TxtSalario"
        Me.TxtSalario.Size = New System.Drawing.Size(132, 22)
        Me.TxtSalario.TabIndex = 29
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(29, 376)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 17)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Salario"
        '
        'TxtCargo
        '
        Me.TxtCargo.Location = New System.Drawing.Point(108, 340)
        Me.TxtCargo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCargo.MaxLength = 30
        Me.TxtCargo.Name = "TxtCargo"
        Me.TxtCargo.Size = New System.Drawing.Size(132, 22)
        Me.TxtCargo.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(29, 343)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 17)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Cargo"
        '
        'TxtcodEmpresa
        '
        Me.TxtcodEmpresa.Location = New System.Drawing.Point(164, 300)
        Me.TxtcodEmpresa.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtcodEmpresa.MaxLength = 10
        Me.TxtcodEmpresa.Name = "TxtcodEmpresa"
        Me.TxtcodEmpresa.Size = New System.Drawing.Size(132, 22)
        Me.TxtcodEmpresa.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 303)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(132, 17)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Código de Empresa"
        '
        'TxtNrc
        '
        Me.TxtNrc.Location = New System.Drawing.Point(108, 268)
        Me.TxtNrc.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNrc.MaxLength = 10
        Me.TxtNrc.Name = "TxtNrc"
        Me.TxtNrc.Size = New System.Drawing.Size(132, 22)
        Me.TxtNrc.TabIndex = 23
        '
        'txtfecnac
        '
        Me.txtfecnac.Location = New System.Drawing.Point(164, 227)
        Me.txtfecnac.Margin = New System.Windows.Forms.Padding(4)
        Me.txtfecnac.Mask = "00-00-0000"
        Me.txtfecnac.Name = "txtfecnac"
        Me.txtfecnac.Size = New System.Drawing.Size(132, 22)
        Me.txtfecnac.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(29, 268)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 17)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "NRC"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 227)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 17)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Fecha de nacimiento"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 163)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 17)
        Me.Label9.TabIndex = 18
        '
        'txtCodCliente
        '
        Me.txtCodCliente.Location = New System.Drawing.Point(108, 30)
        Me.txtCodCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodCliente.MaxLength = 5
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.Size = New System.Drawing.Size(132, 22)
        Me.txtCodCliente.TabIndex = 0
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(108, 62)
        Me.txtNombres.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombres.MaxLength = 30
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(132, 22)
        Me.txtNombres.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 191)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "NIT"
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(340, 65)
        Me.txtApellidos.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApellidos.MaxLength = 25
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(132, 22)
        Me.txtApellidos.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 163)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "DUI"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(108, 94)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDireccion.MaxLength = 80
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(132, 22)
        Me.txtDireccion.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 129)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Teléfono"
        '
        'txtDui
        '
        Me.txtDui.Location = New System.Drawing.Point(108, 160)
        Me.txtDui.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDui.MaxLength = 10
        Me.txtDui.Name = "txtDui"
        Me.txtDui.Size = New System.Drawing.Size(132, 22)
        Me.txtDui.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 97)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Dirección"
        '
        'txtNit
        '
        Me.txtNit.Location = New System.Drawing.Point(108, 189)
        Me.txtNit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNit.Mask = "0000-000000-000-0"
        Me.txtNit.Name = "txtNit"
        Me.txtNit.Size = New System.Drawing.Size(132, 22)
        Me.txtNit.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(267, 65)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Apellidos"
        '
        'txtTelefono
        '
        Me.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTelefono.Location = New System.Drawing.Point(108, 124)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelefono.Mask = "0000-0000"
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(132, 22)
        Me.txtTelefono.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nombres"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Código"
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTitulo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Teal
        Me.lblTitulo.Location = New System.Drawing.Point(7, 11)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(608, 38)
        Me.lblTitulo.TabIndex = 30
        Me.lblTitulo.Text = "MAESTRO DE CLIENTES"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 555)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmClientes"
        Me.Text = "FrmClientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Btneliminar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtCodCliente As TextBox
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDui As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNit As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTelefono As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtfecnac As MaskedTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtNrc As TextBox
    Friend WithEvents TxtSalario As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtCargo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtcodEmpresa As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lblTitulo As Label
End Class
