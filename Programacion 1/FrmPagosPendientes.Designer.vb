<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPagosPendientes
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PagosPendientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPagospendientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPagospendientes = New Programacion_1.dsPagospendientes()
        Me.PagosPendientesTableAdapter = New Programacion_1.dsPagospendientesTableAdapters.PagosPendientesTableAdapter()
        Me.btnAcciom = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.IdPagar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostodecitaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostodeingresoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreFormaPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalapagarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagosPendientesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosPendientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPagospendientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPagospendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.btnAcciom, Me.IdPagar, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.CostodecitaDataGridViewTextBoxColumn, Me.CostodeingresoDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.NombreFormaPagoDataGridViewTextBoxColumn, Me.TotalapagarDataGridViewTextBoxColumn, Me.PagosPendientesDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PagosPendientesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1195, 538)
        Me.DataGridView1.TabIndex = 0
        '
        'PagosPendientesBindingSource
        '
        Me.PagosPendientesBindingSource.DataMember = "PagosPendientes"
        Me.PagosPendientesBindingSource.DataSource = Me.DsPagospendientesBindingSource
        '
        'DsPagospendientesBindingSource
        '
        Me.DsPagospendientesBindingSource.DataSource = Me.DsPagospendientes
        Me.DsPagospendientesBindingSource.Position = 0
        '
        'DsPagospendientes
        '
        Me.DsPagospendientes.DataSetName = "dsPagospendientes"
        Me.DsPagospendientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PagosPendientesTableAdapter
        '
        Me.PagosPendientesTableAdapter.ClearBeforeFill = True
        '
        'btnAcciom
        '
        Me.btnAcciom.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAcciom.HeaderText = "Acción"
        Me.btnAcciom.MinimumWidth = 6
        Me.btnAcciom.Name = "btnAcciom"
        Me.btnAcciom.Text = "Pagar"
        Me.btnAcciom.UseColumnTextForButtonValue = True
        Me.btnAcciom.Width = 136
        '
        'IdPagar
        '
        Me.IdPagar.DataPropertyName = "Idpagar"
        Me.IdPagar.HeaderText = "IdPagar"
        Me.IdPagar.MinimumWidth = 6
        Me.IdPagar.Name = "IdPagar"
        Me.IdPagar.Width = 6
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.Width = 125
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        Me.ApellidoDataGridViewTextBoxColumn.Width = 125
        '
        'CostodecitaDataGridViewTextBoxColumn
        '
        Me.CostodecitaDataGridViewTextBoxColumn.DataPropertyName = "costo_de_cita"
        Me.CostodecitaDataGridViewTextBoxColumn.HeaderText = "costo_de_cita"
        Me.CostodecitaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CostodecitaDataGridViewTextBoxColumn.Name = "CostodecitaDataGridViewTextBoxColumn"
        Me.CostodecitaDataGridViewTextBoxColumn.Width = 125
        '
        'CostodeingresoDataGridViewTextBoxColumn
        '
        Me.CostodeingresoDataGridViewTextBoxColumn.DataPropertyName = "costo_de_ingreso"
        Me.CostodeingresoDataGridViewTextBoxColumn.HeaderText = "costo_de_ingreso"
        Me.CostodeingresoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CostodeingresoDataGridViewTextBoxColumn.Name = "CostodeingresoDataGridViewTextBoxColumn"
        Me.CostodeingresoDataGridViewTextBoxColumn.Width = 125
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "total"
        Me.TotalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.Width = 125
        '
        'NombreFormaPagoDataGridViewTextBoxColumn
        '
        Me.NombreFormaPagoDataGridViewTextBoxColumn.DataPropertyName = "nombreFormaPago"
        Me.NombreFormaPagoDataGridViewTextBoxColumn.HeaderText = "nombreFormaPago"
        Me.NombreFormaPagoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreFormaPagoDataGridViewTextBoxColumn.Name = "NombreFormaPagoDataGridViewTextBoxColumn"
        Me.NombreFormaPagoDataGridViewTextBoxColumn.Width = 125
        '
        'TotalapagarDataGridViewTextBoxColumn
        '
        Me.TotalapagarDataGridViewTextBoxColumn.DataPropertyName = "Total_a_pagar"
        Me.TotalapagarDataGridViewTextBoxColumn.HeaderText = "Total_a_pagar"
        Me.TotalapagarDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalapagarDataGridViewTextBoxColumn.Name = "TotalapagarDataGridViewTextBoxColumn"
        Me.TotalapagarDataGridViewTextBoxColumn.Width = 125
        '
        'PagosPendientesDataGridViewTextBoxColumn
        '
        Me.PagosPendientesDataGridViewTextBoxColumn.DataPropertyName = "PagosPendientes"
        Me.PagosPendientesDataGridViewTextBoxColumn.HeaderText = "PagosPendientes"
        Me.PagosPendientesDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PagosPendientesDataGridViewTextBoxColumn.Name = "PagosPendientesDataGridViewTextBoxColumn"
        Me.PagosPendientesDataGridViewTextBoxColumn.Width = 125
        '
        'FrmPagosPendientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 552)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmPagosPendientes"
        Me.Text = "PagosPendientes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosPendientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPagospendientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPagospendientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DsPagospendientesBindingSource As BindingSource
    Friend WithEvents DsPagospendientes As dsPagospendientes
    Friend WithEvents PagosPendientesBindingSource As BindingSource
    Friend WithEvents PagosPendientesTableAdapter As dsPagospendientesTableAdapters.PagosPendientesTableAdapter
    Friend WithEvents btnAcciom As DataGridViewButtonColumn
    Friend WithEvents IdPagar As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostodecitaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostodeingresoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreFormaPagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalapagarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PagosPendientesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
