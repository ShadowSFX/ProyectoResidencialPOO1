<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMaestroViviendas
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.cbbEstado = New System.Windows.Forms.ComboBox()
        Me.cbbModelo = New System.Windows.Forms.ComboBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblEstadoviv = New System.Windows.Forms.Label()
        Me.lblModeloViv = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTitulo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Teal
        Me.lblTitulo.Location = New System.Drawing.Point(192, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(282, 22)
        Me.lblTitulo.TabIndex = 26
        Me.lblTitulo.Text = "MAESTRO DE VIVIENDAS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(-7, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(483, 42)
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(265, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 24)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "|"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(366, 19)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 26
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.BtnModificar)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 56)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(184, 19)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 28
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(103, 19)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 23)
        Me.BtnModificar.TabIndex = 29
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(22, 19)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 30
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(285, 19)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardar.TabIndex = 27
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.txtCod)
        Me.GroupBox2.Controls.Add(Me.txtPrecio)
        Me.GroupBox2.Controls.Add(Me.cbbEstado)
        Me.GroupBox2.Controls.Add(Me.cbbModelo)
        Me.GroupBox2.Controls.Add(Me.lblPrecio)
        Me.GroupBox2.Controls.Add(Me.lblEstadoviv)
        Me.GroupBox2.Controls.Add(Me.lblModeloViv)
        Me.GroupBox2.Controls.Add(Me.lblCodigo)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(447, 132)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información General"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(160, 102)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(120, 20)
        Me.txtPrecio.TabIndex = 20
        '
        'cbbEstado
        '
        Me.cbbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbEstado.FormattingEnabled = True
        Me.cbbEstado.Location = New System.Drawing.Point(159, 76)
        Me.cbbEstado.Name = "cbbEstado"
        Me.cbbEstado.Size = New System.Drawing.Size(121, 21)
        Me.cbbEstado.TabIndex = 19
        '
        'cbbModelo
        '
        Me.cbbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbModelo.FormattingEnabled = True
        Me.cbbModelo.Location = New System.Drawing.Point(159, 50)
        Me.cbbModelo.Name = "cbbModelo"
        Me.cbbModelo.Size = New System.Drawing.Size(121, 21)
        Me.cbbModelo.TabIndex = 18
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(81, 105)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(40, 13)
        Me.lblPrecio.TabIndex = 16
        Me.lblPrecio.Text = "Precio:"
        '
        'lblEstadoviv
        '
        Me.lblEstadoviv.AutoSize = True
        Me.lblEstadoviv.Location = New System.Drawing.Point(20, 79)
        Me.lblEstadoviv.Name = "lblEstadoviv"
        Me.lblEstadoviv.Size = New System.Drawing.Size(101, 13)
        Me.lblEstadoviv.TabIndex = 14
        Me.lblEstadoviv.Text = "Estado de vivienda:"
        '
        'lblModeloViv
        '
        Me.lblModeloViv.AutoSize = True
        Me.lblModeloViv.Location = New System.Drawing.Point(20, 53)
        Me.lblModeloViv.Name = "lblModeloViv"
        Me.lblModeloViv.Size = New System.Drawing.Size(103, 13)
        Me.lblModeloViv.TabIndex = 12
        Me.lblModeloViv.Text = "Modelo de vivienda:"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(80, 27)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lblCodigo.TabIndex = 7
        Me.lblCodigo.Text = "Código:"
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(159, 24)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(120, 20)
        Me.txtCod.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(312, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmMaestroViviendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 251)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "FrmMaestroViviendas"
        Me.Text = "Maestro de viviendas"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitulo As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblEstadoviv As Label
    Friend WithEvents lblModeloViv As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents cbbEstado As ComboBox
    Friend WithEvents cbbModelo As ComboBox
    Friend WithEvents cbbCodigo As ComboBox
    Friend WithEvents lblCodigo As Label
    Friend WithEvents txtCod As TextBox
    Friend WithEvents Button1 As Button
End Class
