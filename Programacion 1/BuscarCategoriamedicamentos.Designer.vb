<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarCategoriamedicamentos
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
        Me.grbBuscarCategoriaMedicamentos = New System.Windows.Forms.DataGridView()
        Me.idregistrodepersonal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.laboratorio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblBucarEmpleado = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        CType(Me.grbBuscarCategoriaMedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(689, 419)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(120, 33)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.Text = "Cancelar "
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionar.Location = New System.Drawing.Point(518, 419)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(165, 33)
        Me.btnSeleccionar.TabIndex = 13
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'grbBuscarCategoriaMedicamentos
        '
        Me.grbBuscarCategoriaMedicamentos.AllowUserToAddRows = False
        Me.grbBuscarCategoriaMedicamentos.AllowUserToDeleteRows = False
        Me.grbBuscarCategoriaMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grbBuscarCategoriaMedicamentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idregistrodepersonal, Me.codigo, Me.nombre, Me.descripcion, Me.laboratorio, Me.cantidad})
        Me.grbBuscarCategoriaMedicamentos.Location = New System.Drawing.Point(76, 38)
        Me.grbBuscarCategoriaMedicamentos.Name = "grbBuscarCategoriaMedicamentos"
        Me.grbBuscarCategoriaMedicamentos.ReadOnly = True
        Me.grbBuscarCategoriaMedicamentos.Size = New System.Drawing.Size(733, 375)
        Me.grbBuscarCategoriaMedicamentos.TabIndex = 12
        '
        'idregistrodepersonal
        '
        Me.idregistrodepersonal.DataPropertyName = "Idproducto"
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
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "DESCRIPCION"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 150
        '
        'laboratorio
        '
        Me.laboratorio.DataPropertyName = "laboratorio)"
        Me.laboratorio.HeaderText = "LABORATORIO"
        Me.laboratorio.Name = "laboratorio"
        Me.laboratorio.ReadOnly = True
        Me.laboratorio.Width = 175
        '
        'cantidad
        '
        Me.cantidad.DataPropertyName = "cantidad"
        Me.cantidad.HeaderText = "CANTIDAD"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'lblBucarEmpleado
        '
        Me.lblBucarEmpleado.AutoSize = True
        Me.lblBucarEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBucarEmpleado.Location = New System.Drawing.Point(10, 13)
        Me.lblBucarEmpleado.Name = "lblBucarEmpleado"
        Me.lblBucarEmpleado.Size = New System.Drawing.Size(60, 16)
        Me.lblBucarEmpleado.TabIndex = 11
        Me.lblBucarEmpleado.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(76, 12)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(628, 20)
        Me.txtBuscar.TabIndex = 10
        '
        'BuscarCategoriamedicamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 477)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.grbBuscarCategoriaMedicamentos)
        Me.Controls.Add(Me.lblBucarEmpleado)
        Me.Controls.Add(Me.txtBuscar)
        Me.Name = "BuscarCategoriamedicamentos"
        Me.Text = "Categoria Medicamentos"
        CType(Me.grbBuscarCategoriaMedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnSeleccionar As Button
    Friend WithEvents grbBuscarCategoriaMedicamentos As DataGridView
    Friend WithEvents idregistrodepersonal As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents laboratorio As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents lblBucarEmpleado As Label
    Friend WithEvents txtBuscar As TextBox
End Class
