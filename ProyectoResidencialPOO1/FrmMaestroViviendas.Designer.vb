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
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.cbbEstado = New System.Windows.Forms.ComboBox()
        Me.cbbModelo = New System.Windows.Forms.ComboBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblEstadoviv = New System.Windows.Forms.Label()
        Me.lblModeloViv = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
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
        Me.lblTitulo.Location = New System.Drawing.Point(256, 11)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(376, 27)
        Me.lblTitulo.TabIndex = 26
        Me.lblTitulo.Text = "MAESTRO DE VIVIENDAS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(-9, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(643, 51)
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(353, 20)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 29)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "|"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(488, 23)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 28)
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
        Me.GroupBox1.Location = New System.Drawing.Point(16, 55)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(596, 69)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(245, 23)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(100, 28)
        Me.btnEliminar.TabIndex = 28
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(137, 23)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(100, 28)
        Me.BtnModificar.TabIndex = 29
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(29, 23)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(100, 28)
        Me.btnAgregar.TabIndex = 30
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(380, 23)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(100, 28)
        Me.BtnGuardar.TabIndex = 27
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCod)
        Me.GroupBox2.Controls.Add(Me.txtPrecio)
        Me.GroupBox2.Controls.Add(Me.cbbEstado)
        Me.GroupBox2.Controls.Add(Me.cbbModelo)
        Me.GroupBox2.Controls.Add(Me.lblPrecio)
        Me.GroupBox2.Controls.Add(Me.lblEstadoviv)
        Me.GroupBox2.Controls.Add(Me.lblModeloViv)
        Me.GroupBox2.Controls.Add(Me.lblCodigo)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 132)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(596, 162)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información General"
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(212, 30)
        Me.txtCod.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(159, 22)
        Me.txtCod.TabIndex = 21
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(213, 126)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(159, 22)
        Me.txtPrecio.TabIndex = 20
        '
        'cbbEstado
        '
        Me.cbbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbEstado.FormattingEnabled = True
        Me.cbbEstado.Location = New System.Drawing.Point(212, 94)
        Me.cbbEstado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbbEstado.Name = "cbbEstado"
        Me.cbbEstado.Size = New System.Drawing.Size(160, 24)
        Me.cbbEstado.TabIndex = 19
        '
        'cbbModelo
        '
        Me.cbbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbModelo.FormattingEnabled = True
        Me.cbbModelo.Location = New System.Drawing.Point(212, 62)
        Me.cbbModelo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbbModelo.Name = "cbbModelo"
        Me.cbbModelo.Size = New System.Drawing.Size(160, 24)
        Me.cbbModelo.TabIndex = 18
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(108, 129)
        Me.lblPrecio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(52, 17)
        Me.lblPrecio.TabIndex = 16
        Me.lblPrecio.Text = "Precio:"
        '
        'lblEstadoviv
        '
        Me.lblEstadoviv.AutoSize = True
        Me.lblEstadoviv.Location = New System.Drawing.Point(27, 97)
        Me.lblEstadoviv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEstadoviv.Name = "lblEstadoviv"
        Me.lblEstadoviv.Size = New System.Drawing.Size(132, 17)
        Me.lblEstadoviv.TabIndex = 14
        Me.lblEstadoviv.Text = "Estado de vivienda:"
        '
        'lblModeloViv
        '
        Me.lblModeloViv.AutoSize = True
        Me.lblModeloViv.Location = New System.Drawing.Point(27, 65)
        Me.lblModeloViv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblModeloViv.Name = "lblModeloViv"
        Me.lblModeloViv.Size = New System.Drawing.Size(134, 17)
        Me.lblModeloViv.TabIndex = 12
        Me.lblModeloViv.Text = "Modelo de vivienda:"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(107, 33)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(56, 17)
        Me.lblCodigo.TabIndex = 7
        Me.lblCodigo.Text = "Código:"
        '
        'FrmMaestroViviendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 309)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
End Class
