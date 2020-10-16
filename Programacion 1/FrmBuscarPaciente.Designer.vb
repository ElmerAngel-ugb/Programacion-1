<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBuscarPaciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBuscarPaciente))
        Me.btnCancelarPaciente = New System.Windows.Forms.Button()
        Me.btnSeleccionarPaciente = New System.Windows.Forms.Button()
        Me.grdBuscarPaciente = New System.Windows.Forms.DataGridView()
        Me.lblBuscarCliente = New System.Windows.Forms.Label()
        Me.txtBuscarPaciente = New System.Windows.Forms.TextBox()
        Me.IdPaciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_Nacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DUI_NIT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo_Sangre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Alergico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Examenes_Realizados = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grdBuscarPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelarPaciente
        '
        Me.btnCancelarPaciente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarPaciente.Location = New System.Drawing.Point(1191, 435)
        Me.btnCancelarPaciente.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCancelarPaciente.Name = "btnCancelarPaciente"
        Me.btnCancelarPaciente.Size = New System.Drawing.Size(120, 33)
        Me.btnCancelarPaciente.TabIndex = 9
        Me.btnCancelarPaciente.Text = "Cancelar"
        Me.btnCancelarPaciente.UseVisualStyleBackColor = True
        '
        'btnSeleccionarPaciente
        '
        Me.btnSeleccionarPaciente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionarPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarPaciente.Location = New System.Drawing.Point(943, 435)
        Me.btnSeleccionarPaciente.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSeleccionarPaciente.Name = "btnSeleccionarPaciente"
        Me.btnSeleccionarPaciente.Size = New System.Drawing.Size(236, 33)
        Me.btnSeleccionarPaciente.TabIndex = 8
        Me.btnSeleccionarPaciente.Text = "Seleccionar Cliente"
        Me.btnSeleccionarPaciente.UseVisualStyleBackColor = True
        '
        'grdBuscarPaciente
        '
        Me.grdBuscarPaciente.AllowUserToAddRows = False
        Me.grdBuscarPaciente.AllowUserToDeleteRows = False
        Me.grdBuscarPaciente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdBuscarPaciente.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.grdBuscarPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBuscarPaciente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPaciente, Me.Codigo, Me.Nombre, Me.Apellido, Me.Fecha_Nacimiento, Me.Edad, Me.Sexo, Me.DUI_NIT, Me.Tipo_Sangre, Me.Email, Me.Direccion, Me.Alergico, Me.Examenes_Realizados})
        Me.grdBuscarPaciente.Location = New System.Drawing.Point(13, 42)
        Me.grdBuscarPaciente.Margin = New System.Windows.Forms.Padding(1)
        Me.grdBuscarPaciente.Name = "grdBuscarPaciente"
        Me.grdBuscarPaciente.ReadOnly = True
        Me.grdBuscarPaciente.RowHeadersWidth = 102
        Me.grdBuscarPaciente.RowTemplate.Height = 40
        Me.grdBuscarPaciente.Size = New System.Drawing.Size(1354, 374)
        Me.grdBuscarPaciente.TabIndex = 7
        '
        'lblBuscarCliente
        '
        Me.lblBuscarCliente.AutoSize = True
        Me.lblBuscarCliente.Location = New System.Drawing.Point(10, 9)
        Me.lblBuscarCliente.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblBuscarCliente.Name = "lblBuscarCliente"
        Me.lblBuscarCliente.Size = New System.Drawing.Size(54, 13)
        Me.lblBuscarCliente.TabIndex = 6
        Me.lblBuscarCliente.Text = "BUSCAR:"
        '
        'txtBuscarPaciente
        '
        Me.txtBuscarPaciente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarPaciente.Location = New System.Drawing.Point(65, 9)
        Me.txtBuscarPaciente.Margin = New System.Windows.Forms.Padding(1)
        Me.txtBuscarPaciente.Name = "txtBuscarPaciente"
        Me.txtBuscarPaciente.Size = New System.Drawing.Size(1273, 20)
        Me.txtBuscarPaciente.TabIndex = 5
        '
        'IdPaciente
        '
        Me.IdPaciente.HeaderText = "ID"
        Me.IdPaciente.Name = "IdPaciente"
        Me.IdPaciente.ReadOnly = True
        Me.IdPaciente.Visible = False
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "CODIGO"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "NOMBRE"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "APELLIDO"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        '
        'Fecha_Nacimiento
        '
        Me.Fecha_Nacimiento.HeaderText = "FECHA_NACIMIENTO"
        Me.Fecha_Nacimiento.Name = "Fecha_Nacimiento"
        Me.Fecha_Nacimiento.ReadOnly = True
        Me.Fecha_Nacimiento.Width = 135
        '
        'Edad
        '
        Me.Edad.HeaderText = "EDAD"
        Me.Edad.Name = "Edad"
        Me.Edad.ReadOnly = True
        '
        'Sexo
        '
        Me.Sexo.HeaderText = "SEXO"
        Me.Sexo.Name = "Sexo"
        Me.Sexo.ReadOnly = True
        '
        'DUI_NIT
        '
        Me.DUI_NIT.HeaderText = "DUI_NIT"
        Me.DUI_NIT.Name = "DUI_NIT"
        Me.DUI_NIT.ReadOnly = True
        '
        'Tipo_Sangre
        '
        Me.Tipo_Sangre.HeaderText = "TIPO_SANGRE"
        Me.Tipo_Sangre.Name = "Tipo_Sangre"
        Me.Tipo_Sangre.ReadOnly = True
        '
        'Email
        '
        Me.Email.HeaderText = "EMAIL"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        '
        'Direccion
        '
        Me.Direccion.HeaderText = "DIRECCION"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        '
        'Alergico
        '
        Me.Alergico.HeaderText = "ALERGICO"
        Me.Alergico.Name = "Alergico"
        Me.Alergico.ReadOnly = True
        '
        'Examenes_Realizados
        '
        Me.Examenes_Realizados.HeaderText = "EXAMENES_REALIZADOS"
        Me.Examenes_Realizados.Name = "Examenes_Realizados"
        Me.Examenes_Realizados.ReadOnly = True
        Me.Examenes_Realizados.Width = 150
        '
        'FrmBuscarPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(1370, 478)
        Me.Controls.Add(Me.btnCancelarPaciente)
        Me.Controls.Add(Me.btnSeleccionarPaciente)
        Me.Controls.Add(Me.grdBuscarPaciente)
        Me.Controls.Add(Me.lblBuscarCliente)
        Me.Controls.Add(Me.txtBuscarPaciente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmBuscarPaciente"
        Me.Text = "FrmBuscarPaciente"
        CType(Me.grdBuscarPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelarPaciente As Button
    Friend WithEvents btnSeleccionarPaciente As Button
    Friend WithEvents grdBuscarPaciente As DataGridView
    Friend WithEvents lblBuscarCliente As Label
    Friend WithEvents txtBuscarPaciente As TextBox
    Friend WithEvents IdPaciente As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_Nacimiento As DataGridViewTextBoxColumn
    Friend WithEvents Edad As DataGridViewTextBoxColumn
    Friend WithEvents Sexo As DataGridViewTextBoxColumn
    Friend WithEvents DUI_NIT As DataGridViewTextBoxColumn
    Friend WithEvents Tipo_Sangre As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents Alergico As DataGridViewTextBoxColumn
    Friend WithEvents Examenes_Realizados As DataGridViewTextBoxColumn
End Class
