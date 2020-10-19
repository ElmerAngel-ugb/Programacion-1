<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBuscarEmpleadosvb
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
        Me.txtBuscarEmpleado = New System.Windows.Forms.TextBox()
        Me.lblBucarEmpleado = New System.Windows.Forms.Label()
        Me.grbBuscarEmpleado = New System.Windows.Forms.DataGridView()
        Me.btnSeleccionarEmpleado = New System.Windows.Forms.Button()
        Me.idregistrodepersonal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCancelarSeleccion = New System.Windows.Forms.Button()
        CType(Me.grbBuscarEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscarEmpleado
        '
        Me.txtBuscarEmpleado.Location = New System.Drawing.Point(100, 13)
        Me.txtBuscarEmpleado.Name = "txtBuscarEmpleado"
        Me.txtBuscarEmpleado.Size = New System.Drawing.Size(628, 20)
        Me.txtBuscarEmpleado.TabIndex = 0
        '
        'lblBucarEmpleado
        '
        Me.lblBucarEmpleado.AutoSize = True
        Me.lblBucarEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBucarEmpleado.Location = New System.Drawing.Point(34, 14)
        Me.lblBucarEmpleado.Name = "lblBucarEmpleado"
        Me.lblBucarEmpleado.Size = New System.Drawing.Size(60, 16)
        Me.lblBucarEmpleado.TabIndex = 1
        Me.lblBucarEmpleado.Text = "Buscar:"
        '
        'grbBuscarEmpleado
        '
        Me.grbBuscarEmpleado.AllowUserToAddRows = False
        Me.grbBuscarEmpleado.AllowUserToDeleteRows = False
        Me.grbBuscarEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grbBuscarEmpleado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idregistrodepersonal, Me.codigo, Me.nombre, Me.direccion, Me.telefono, Me.email, Me.cargo, Me.horario})
        Me.grbBuscarEmpleado.Location = New System.Drawing.Point(37, 39)
        Me.grbBuscarEmpleado.Name = "grbBuscarEmpleado"
        Me.grbBuscarEmpleado.ReadOnly = True
        Me.grbBuscarEmpleado.Size = New System.Drawing.Size(991, 375)
        Me.grbBuscarEmpleado.TabIndex = 2
        '
        'btnSeleccionarEmpleado
        '
        Me.btnSeleccionarEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarEmpleado.Location = New System.Drawing.Point(743, 429)
        Me.btnSeleccionarEmpleado.Name = "btnSeleccionarEmpleado"
        Me.btnSeleccionarEmpleado.Size = New System.Drawing.Size(165, 33)
        Me.btnSeleccionarEmpleado.TabIndex = 3
        Me.btnSeleccionarEmpleado.Text = "Seleccionar"
        Me.btnSeleccionarEmpleado.UseVisualStyleBackColor = True
        '
        'idregistrodepersonal
        '
        Me.idregistrodepersonal.DataPropertyName = "Idregistrodepersonal"
        Me.idregistrodepersonal.HeaderText = "ID"
        Me.idregistrodepersonal.Name = "idregistrodepersonal"
        Me.idregistrodepersonal.ReadOnly = True
        Me.idregistrodepersonal.Visible = False
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "codigo"
        Me.codigo.HeaderText = "CODIGO"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Width = 55
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "NOMBRE"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 200
        '
        'direccion
        '
        Me.direccion.DataPropertyName = "direccion"
        Me.direccion.HeaderText = "DIRECCION"
        Me.direccion.Name = "direccion"
        Me.direccion.ReadOnly = True
        Me.direccion.Width = 150
        '
        'telefono
        '
        Me.telefono.DataPropertyName = "telefono"
        Me.telefono.HeaderText = "TELEFONO"
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        Me.telefono.Width = 120
        '
        'email
        '
        Me.email.DataPropertyName = "email"
        Me.email.HeaderText = "EMAIL"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        Me.email.Width = 140
        '
        'cargo
        '
        Me.cargo.DataPropertyName = "cargo"
        Me.cargo.HeaderText = "CARGO"
        Me.cargo.Name = "cargo"
        Me.cargo.ReadOnly = True
        '
        'horario
        '
        Me.horario.DataPropertyName = "horario"
        Me.horario.HeaderText = "HORARIO"
        Me.horario.Name = "horario"
        Me.horario.ReadOnly = True
        Me.horario.Width = 200
        '
        'btnCancelarSeleccion
        '
        Me.btnCancelarSeleccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarSeleccion.Location = New System.Drawing.Point(917, 429)
        Me.btnCancelarSeleccion.Name = "btnCancelarSeleccion"
        Me.btnCancelarSeleccion.Size = New System.Drawing.Size(113, 33)
        Me.btnCancelarSeleccion.TabIndex = 4
        Me.btnCancelarSeleccion.Text = "Cancelar "
        Me.btnCancelarSeleccion.UseVisualStyleBackColor = True
        '
        'FrmBuscarEmpleadosvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 478)
        Me.Controls.Add(Me.btnCancelarSeleccion)
        Me.Controls.Add(Me.btnSeleccionarEmpleado)
        Me.Controls.Add(Me.grbBuscarEmpleado)
        Me.Controls.Add(Me.lblBucarEmpleado)
        Me.Controls.Add(Me.txtBuscarEmpleado)
        Me.Name = "FrmBuscarEmpleadosvb"
        Me.Text = "Buqueda de registro de Empleadosvb"
        CType(Me.grbBuscarEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBuscarEmpleado As TextBox
    Friend WithEvents lblBucarEmpleado As Label
    Friend WithEvents grbBuscarEmpleado As DataGridView
    Friend WithEvents btnSeleccionarEmpleado As Button
    Friend WithEvents idregistrodepersonal As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents cargo As DataGridViewTextBoxColumn
    Friend WithEvents horario As DataGridViewTextBoxColumn
    Friend WithEvents btnCancelarSeleccion As Button
End Class
