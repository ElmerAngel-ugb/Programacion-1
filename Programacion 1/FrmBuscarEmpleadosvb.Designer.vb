<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarEmpleadosvb
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
        Me.btnCancelarSeleccion = New System.Windows.Forms.Button()
        Me.btnSeleccionarEmpleado = New System.Windows.Forms.Button()
        Me.grbBuscarEmpleado = New System.Windows.Forms.DataGridView()
        Me.idregistrodepersonal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblBucarEmpleado = New System.Windows.Forms.Label()
        Me.txtBuscarEmpleado = New System.Windows.Forms.TextBox()
        CType(Me.grbBuscarEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelarSeleccion
        '
        Me.btnCancelarSeleccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarSeleccion.Location = New System.Drawing.Point(902, 428)
        Me.btnCancelarSeleccion.Name = "btnCancelarSeleccion"
        Me.btnCancelarSeleccion.Size = New System.Drawing.Size(113, 33)
        Me.btnCancelarSeleccion.TabIndex = 9
        Me.btnCancelarSeleccion.Text = "Cancelar "
        Me.btnCancelarSeleccion.UseVisualStyleBackColor = True
        '
        'btnSeleccionarEmpleado
        '
        Me.btnSeleccionarEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarEmpleado.Location = New System.Drawing.Point(728, 428)
        Me.btnSeleccionarEmpleado.Name = "btnSeleccionarEmpleado"
        Me.btnSeleccionarEmpleado.Size = New System.Drawing.Size(165, 33)
        Me.btnSeleccionarEmpleado.TabIndex = 8
        Me.btnSeleccionarEmpleado.Text = "Seleccionar"
        Me.btnSeleccionarEmpleado.UseVisualStyleBackColor = True
        '
        'grbBuscarEmpleado
        '
        Me.grbBuscarEmpleado.AllowUserToAddRows = False
        Me.grbBuscarEmpleado.AllowUserToDeleteRows = False
        Me.grbBuscarEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grbBuscarEmpleado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idregistrodepersonal, Me.codigo, Me.nombre, Me.direccion, Me.telefono, Me.email, Me.cargo, Me.horario})
        Me.grbBuscarEmpleado.Location = New System.Drawing.Point(17, 38)
        Me.grbBuscarEmpleado.Name = "grbBuscarEmpleado"
        Me.grbBuscarEmpleado.ReadOnly = True
        Me.grbBuscarEmpleado.Size = New System.Drawing.Size(991, 375)
        Me.grbBuscarEmpleado.TabIndex = 7
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
        'lblBucarEmpleado
        '
        Me.lblBucarEmpleado.AutoSize = True
        Me.lblBucarEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBucarEmpleado.Location = New System.Drawing.Point(19, 13)
        Me.lblBucarEmpleado.Name = "lblBucarEmpleado"
        Me.lblBucarEmpleado.Size = New System.Drawing.Size(60, 16)
        Me.lblBucarEmpleado.TabIndex = 6
        Me.lblBucarEmpleado.Text = "Buscar:"
        '
        'txtBuscarEmpleado
        '
        Me.txtBuscarEmpleado.Location = New System.Drawing.Point(85, 12)
        Me.txtBuscarEmpleado.Name = "txtBuscarEmpleado"
        Me.txtBuscarEmpleado.Size = New System.Drawing.Size(628, 20)
        Me.txtBuscarEmpleado.TabIndex = 5
        '
        'FrmBuscarEmpleadosvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 497)
        Me.Controls.Add(Me.btnCancelarSeleccion)
        Me.Controls.Add(Me.btnSeleccionarEmpleado)
        Me.Controls.Add(Me.grbBuscarEmpleado)
        Me.Controls.Add(Me.lblBucarEmpleado)
        Me.Controls.Add(Me.txtBuscarEmpleado)
        Me.Name = "FrmBuscarEmpleadosvb"
        Me.Text = "FrmBuscarEmpleadosvb"
        CType(Me.grbBuscarEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelarSeleccion As Button
    Friend WithEvents btnSeleccionarEmpleado As Button
    Friend WithEvents grbBuscarEmpleado As DataGridView
    Friend WithEvents idregistrodepersonal As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents cargo As DataGridViewTextBoxColumn
    Friend WithEvents horario As DataGridViewTextBoxColumn
    Friend WithEvents lblBucarEmpleado As Label
    Friend WithEvents txtBuscarEmpleado As TextBox
End Class
