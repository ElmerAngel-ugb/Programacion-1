<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarReceta
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
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.grbBuscar = New System.Windows.Forms.DataGridView()
        Me.lblBucarEmpleado = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.idreceta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.medico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_emsion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grbBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(685, 418)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(120, 33)
        Me.btnCancelar.TabIndex = 19
        Me.btnCancelar.Text = "Cancelar "
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionar.Location = New System.Drawing.Point(514, 418)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(165, 33)
        Me.btnSeleccionar.TabIndex = 18
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'grbBuscar
        '
        Me.grbBuscar.AllowUserToAddRows = False
        Me.grbBuscar.AllowUserToDeleteRows = False
        Me.grbBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grbBuscar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idreceta, Me.medico, Me.paciente, Me.descripcion, Me.fecha_emsion})
        Me.grbBuscar.Location = New System.Drawing.Point(72, 37)
        Me.grbBuscar.Name = "grbBuscar"
        Me.grbBuscar.ReadOnly = True
        Me.grbBuscar.Size = New System.Drawing.Size(733, 375)
        Me.grbBuscar.TabIndex = 17
        '
        'lblBucarEmpleado
        '
        Me.lblBucarEmpleado.AutoSize = True
        Me.lblBucarEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBucarEmpleado.Location = New System.Drawing.Point(6, 12)
        Me.lblBucarEmpleado.Name = "lblBucarEmpleado"
        Me.lblBucarEmpleado.Size = New System.Drawing.Size(60, 16)
        Me.lblBucarEmpleado.TabIndex = 16
        Me.lblBucarEmpleado.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(72, 11)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(628, 20)
        Me.txtBuscar.TabIndex = 15
        '
        'idreceta
        '
        Me.idreceta.DataPropertyName = "Idreceta"
        Me.idreceta.HeaderText = "ID"
        Me.idreceta.Name = "idreceta"
        Me.idreceta.ReadOnly = True
        Me.idreceta.Visible = False
        '
        'medico
        '
        Me.medico.DataPropertyName = "medico"
        Me.medico.HeaderText = "Medico"
        Me.medico.Name = "medico"
        Me.medico.ReadOnly = True
        Me.medico.Width = 200
        '
        'paciente
        '
        Me.paciente.DataPropertyName = "paciendo"
        Me.paciente.HeaderText = "PACIENTE"
        Me.paciente.Name = "paciente"
        Me.paciente.ReadOnly = True
        Me.paciente.Width = 175
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "DESCRIPCION"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 150
        '
        'fecha_emsion
        '
        Me.fecha_emsion.DataPropertyName = "fecha_emision "
        Me.fecha_emsion.HeaderText = "FECHA"
        Me.fecha_emsion.Name = "fecha_emsion"
        Me.fecha_emsion.ReadOnly = True
        Me.fecha_emsion.Width = 170
        '
        'frmBuscarReceta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 456)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.grbBuscar)
        Me.Controls.Add(Me.lblBucarEmpleado)
        Me.Controls.Add(Me.txtBuscar)
        Me.Name = "frmBuscarReceta"
        Me.Text = "frmBuscarReceta"
        CType(Me.grbBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnSeleccionar As Button
    Friend WithEvents grbBuscar As DataGridView
    Friend WithEvents lblBucarEmpleado As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents idreceta As DataGridViewTextBoxColumn
    Friend WithEvents medico As DataGridViewTextBoxColumn
    Friend WithEvents paciente As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents fecha_emsion As DataGridViewTextBoxColumn
End Class
