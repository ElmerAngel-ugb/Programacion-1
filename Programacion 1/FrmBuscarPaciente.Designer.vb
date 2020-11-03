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
        Me.btnCancelarPacientes = New System.Windows.Forms.Button()
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
        Me.btnCancelarPaciente.Location = New System.Drawing.Point(1325, 379)
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
        Me.btnSeleccionarPaciente.Location = New System.Drawing.Point(731, 379)
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
        Me.grdBuscarPaciente.Location = New System.Drawing.Point(10, 48)
        Me.grdBuscarPaciente.Margin = New System.Windows.Forms.Padding(1)
        Me.grdBuscarPaciente.Name = "grdBuscarPaciente"
        Me.grdBuscarPaciente.ReadOnly = True
        Me.grdBuscarPaciente.RowHeadersWidth = 102
        Me.grdBuscarPaciente.RowTemplate.Height = 40
        Me.grdBuscarPaciente.Size = New System.Drawing.Size(1142, 318)
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
        Me.txtBuscarPaciente.Size = New System.Drawing.Size(1087, 20)
        Me.txtBuscarPaciente.TabIndex = 5
        '
        'btnCancelarPacientes
        '
        Me.btnCancelarPacientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarPacientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarPacientes.Location = New System.Drawing.Point(983, 379)
        Me.btnCancelarPacientes.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCancelarPacientes.Name = "btnCancelarPacientes"
        Me.btnCancelarPacientes.Size = New System.Drawing.Size(169, 33)
        Me.btnCancelarPacientes.TabIndex = 10
        Me.btnCancelarPacientes.Text = "Cancelar"
        Me.btnCancelarPacientes.UseVisualStyleBackColor = True
        '
        'IdPaciente
        '
        Me.IdPaciente.DataPropertyName = "IdPaciente"
        Me.IdPaciente.HeaderText = "ID"
        Me.IdPaciente.MinimumWidth = 6
        Me.IdPaciente.Name = "IdPaciente"
        Me.IdPaciente.ReadOnly = True
        Me.IdPaciente.Visible = False
        Me.IdPaciente.Width = 125
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "Codigo"
        Me.Codigo.HeaderText = "CODIGO"
        Me.Codigo.MinimumWidth = 6
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 125
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "NOMBRE"
        Me.Nombre.MinimumWidth = 6
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 125
        '
        'Apellido
        '
        Me.Apellido.DataPropertyName = "Apellido"
        Me.Apellido.HeaderText = "APELLIDO"
        Me.Apellido.MinimumWidth = 6
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        Me.Apellido.Width = 125
        '
        'Fecha_Nacimiento
        '
        Me.Fecha_Nacimiento.DataPropertyName = "Fecha_Nacimiento"
        Me.Fecha_Nacimiento.HeaderText = "FECHA_NACIMIENTO"
        Me.Fecha_Nacimiento.MinimumWidth = 6
        Me.Fecha_Nacimiento.Name = "Fecha_Nacimiento"
        Me.Fecha_Nacimiento.ReadOnly = True
        Me.Fecha_Nacimiento.Width = 135
        '
        'Edad
        '
        Me.Edad.DataPropertyName = "Edad"
        Me.Edad.HeaderText = "EDAD"
        Me.Edad.MinimumWidth = 6
        Me.Edad.Name = "Edad"
        Me.Edad.ReadOnly = True
        Me.Edad.Width = 125
        '
        'Sexo
        '
        Me.Sexo.DataPropertyName = "Sexo"
        Me.Sexo.HeaderText = "SEXO"
        Me.Sexo.MinimumWidth = 6
        Me.Sexo.Name = "Sexo"
        Me.Sexo.ReadOnly = True
        Me.Sexo.Width = 125
        '
        'DUI_NIT
        '
        Me.DUI_NIT.DataPropertyName = "DUI_NIT"
        Me.DUI_NIT.HeaderText = "DUI_NIT"
        Me.DUI_NIT.MinimumWidth = 6
        Me.DUI_NIT.Name = "DUI_NIT"
        Me.DUI_NIT.ReadOnly = True
        Me.DUI_NIT.Width = 125
        '
        'Tipo_Sangre
        '
        Me.Tipo_Sangre.DataPropertyName = "Tipo_Sangre"
        Me.Tipo_Sangre.HeaderText = "TIPO_SANGRE"
        Me.Tipo_Sangre.MinimumWidth = 6
        Me.Tipo_Sangre.Name = "Tipo_Sangre"
        Me.Tipo_Sangre.ReadOnly = True
        Me.Tipo_Sangre.Width = 125
        '
        'Email
        '
        Me.Email.DataPropertyName = "Email"
        Me.Email.HeaderText = "EMAIL"
        Me.Email.MinimumWidth = 6
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        Me.Email.Width = 125
        '
        'Direccion
        '
        Me.Direccion.DataPropertyName = "Direccion"
        Me.Direccion.HeaderText = "DIRECCION"
        Me.Direccion.MinimumWidth = 6
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        Me.Direccion.Width = 125
        '
        'Alergico
        '
        Me.Alergico.DataPropertyName = "Alergico"
        Me.Alergico.HeaderText = "ALERGICO"
        Me.Alergico.MinimumWidth = 6
        Me.Alergico.Name = "Alergico"
        Me.Alergico.ReadOnly = True
        Me.Alergico.Width = 125
        '
        'Examenes_Realizados
        '
        Me.Examenes_Realizados.DataPropertyName = "Examenes_Realizados"
        Me.Examenes_Realizados.HeaderText = "EXAMENES_REALIZADOS"
        Me.Examenes_Realizados.MinimumWidth = 6
        Me.Examenes_Realizados.Name = "Examenes_Realizados"
        Me.Examenes_Realizados.ReadOnly = True
        Me.Examenes_Realizados.Width = 150
        '
        'FrmBuscarPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(1162, 422)
        Me.Controls.Add(Me.btnCancelarPacientes)
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
    Friend WithEvents btnCancelarPacientes As Button
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
