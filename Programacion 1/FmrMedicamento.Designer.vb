<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FmrMedicamento
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmrMedicamento))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.lbldescripcion = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.lblprecio = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.txtmedicamento = New System.Windows.Forms.TextBox()
        Me.lblnommedicamento = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.txtidmedicamento = New System.Windows.Forms.TextBox()
        Me.lblmedicamento = New System.Windows.Forms.Label()
        Me.navMedicamentos = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtBuscar = New System.Windows.Forms.ToolStripTextBox()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.btnRemoveFilter = New System.Windows.Forms.ToolStripButton()
        Me.bsMedicamentos = New System.Windows.Forms.BindingSource(Me.components)
        Me.form_DSMedicamentos = New Programacion_1.dsMedicamentos()
        Me.MedicamentoTableAdapter = New Programacion_1.dsMedicamentosTableAdapters.medicamentoTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.navMedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.navMedicamentos.SuspendLayout()
        CType(Me.bsMedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.form_DSMedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtdescripcion)
        Me.GroupBox1.Controls.Add(Me.lbldescripcion)
        Me.GroupBox1.Controls.Add(Me.txtprecio)
        Me.GroupBox1.Controls.Add(Me.lblprecio)
        Me.GroupBox1.Controls.Add(Me.txtcantidad)
        Me.GroupBox1.Controls.Add(Me.lblcantidad)
        Me.GroupBox1.Controls.Add(Me.txtmedicamento)
        Me.GroupBox1.Controls.Add(Me.lblnommedicamento)
        Me.GroupBox1.Controls.Add(Me.txtcodigo)
        Me.GroupBox1.Controls.Add(Me.lblcodigo)
        Me.GroupBox1.Controls.Add(Me.txtidmedicamento)
        Me.GroupBox1.Controls.Add(Me.lblmedicamento)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(693, 402)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtdescripcion
        '
        Me.txtdescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsMedicamentos, "descripcion", True))
        Me.txtdescripcion.Location = New System.Drawing.Point(278, 257)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(388, 108)
        Me.txtdescripcion.TabIndex = 23
        '
        'lbldescripcion
        '
        Me.lbldescripcion.AutoSize = True
        Me.lbldescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescripcion.Location = New System.Drawing.Point(6, 257)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(116, 20)
        Me.lbldescripcion.TabIndex = 22
        Me.lbldescripcion.Text = "Descripcion:"
        '
        'txtprecio
        '
        Me.txtprecio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsMedicamentos, "precio", True))
        Me.txtprecio.Location = New System.Drawing.Point(278, 204)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(146, 27)
        Me.txtprecio.TabIndex = 21
        '
        'lblprecio
        '
        Me.lblprecio.AutoSize = True
        Me.lblprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprecio.Location = New System.Drawing.Point(6, 204)
        Me.lblprecio.Name = "lblprecio"
        Me.lblprecio.Size = New System.Drawing.Size(69, 20)
        Me.lblprecio.TabIndex = 20
        Me.lblprecio.Text = "Precio:"
        '
        'txtcantidad
        '
        Me.txtcantidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsMedicamentos, "cantidad_disponible", True))
        Me.txtcantidad.Location = New System.Drawing.Point(279, 160)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(145, 27)
        Me.txtcantidad.TabIndex = 19
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcantidad.Location = New System.Drawing.Point(6, 160)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(180, 20)
        Me.lblcantidad.TabIndex = 18
        Me.lblcantidad.Text = "Cantidad disponible:"
        '
        'txtmedicamento
        '
        Me.txtmedicamento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsMedicamentos, "nombre_medicamento", True))
        Me.txtmedicamento.Location = New System.Drawing.Point(279, 107)
        Me.txtmedicamento.Name = "txtmedicamento"
        Me.txtmedicamento.Size = New System.Drawing.Size(387, 27)
        Me.txtmedicamento.TabIndex = 17
        '
        'lblnommedicamento
        '
        Me.lblnommedicamento.AutoSize = True
        Me.lblnommedicamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnommedicamento.Location = New System.Drawing.Point(6, 107)
        Me.lblnommedicamento.Name = "lblnommedicamento"
        Me.lblnommedicamento.Size = New System.Drawing.Size(228, 20)
        Me.lblnommedicamento.TabIndex = 16
        Me.lblnommedicamento.Text = "Nombre del Medicamento:"
        '
        'txtcodigo
        '
        Me.txtcodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsMedicamentos, "codigo", True))
        Me.txtcodigo.Location = New System.Drawing.Point(278, 59)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(220, 27)
        Me.txtcodigo.TabIndex = 15
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodigo.Location = New System.Drawing.Point(6, 59)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(73, 20)
        Me.lblcodigo.TabIndex = 14
        Me.lblcodigo.Text = "Codigo:"
        '
        'txtidmedicamento
        '
        Me.txtidmedicamento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsMedicamentos, "idmedicamento", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N0"))
        Me.txtidmedicamento.Location = New System.Drawing.Point(279, 13)
        Me.txtidmedicamento.Name = "txtidmedicamento"
        Me.txtidmedicamento.Size = New System.Drawing.Size(220, 27)
        Me.txtidmedicamento.TabIndex = 13
        '
        'lblmedicamento
        '
        Me.lblmedicamento.AutoSize = True
        Me.lblmedicamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmedicamento.Location = New System.Drawing.Point(6, 13)
        Me.lblmedicamento.Name = "lblmedicamento"
        Me.lblmedicamento.Size = New System.Drawing.Size(182, 20)
        Me.lblmedicamento.TabIndex = 12
        Me.lblmedicamento.Text = "ID del medicamento:"
        '
        'navMedicamentos
        '
        Me.navMedicamentos.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.navMedicamentos.BindingSource = Me.bsMedicamentos
        Me.navMedicamentos.CountItem = Me.BindingNavigatorCountItem
        Me.navMedicamentos.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.navMedicamentos.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.navMedicamentos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.btnGuardar, Me.ToolStripSeparator1, Me.txtBuscar, Me.btnBuscar, Me.btnRemoveFilter})
        Me.navMedicamentos.Location = New System.Drawing.Point(0, 0)
        Me.navMedicamentos.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.navMedicamentos.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.navMedicamentos.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.navMedicamentos.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.navMedicamentos.Name = "navMedicamentos"
        Me.navMedicamentos.PositionItem = Me.BindingNavigatorPositionItem
        Me.navMedicamentos.Size = New System.Drawing.Size(717, 27)
        Me.navMedicamentos.TabIndex = 27
        Me.navMedicamentos.Text = "navMedicamentos"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'btnGuardar
        '
        Me.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGuardar.Image = Global.Programacion_1.My.Resources.Recursos.Save
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(29, 24)
        Me.btnGuardar.Text = "Guardar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(200, 27)
        Me.txtBuscar.Text = "Escriba un código"
        Me.txtBuscar.ToolTipText = "Código del medicamento"
        '
        'btnBuscar
        '
        Me.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBuscar.Image = Global.Programacion_1.My.Resources.Recursos.Search
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(29, 24)
        Me.btnBuscar.Text = "Buscar"
        '
        'btnRemoveFilter
        '
        Me.btnRemoveFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRemoveFilter.Image = Global.Programacion_1.My.Resources.Recursos.remove_filter
        Me.btnRemoveFilter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRemoveFilter.Name = "btnRemoveFilter"
        Me.btnRemoveFilter.Size = New System.Drawing.Size(29, 24)
        Me.btnRemoveFilter.Text = "Mostrar todos"
        '
        'bsMedicamentos
        '
        Me.bsMedicamentos.AllowNew = True
        Me.bsMedicamentos.DataMember = "medicamento"
        Me.bsMedicamentos.DataSource = Me.form_DSMedicamentos
        Me.bsMedicamentos.Filter = ""
        Me.bsMedicamentos.Sort = ""
        '
        'form_DSMedicamentos
        '
        Me.form_DSMedicamentos.DataSetName = "form_dsMedicamentos"
        Me.form_DSMedicamentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MedicamentoTableAdapter
        '
        Me.MedicamentoTableAdapter.ClearBeforeFill = True
        '
        'FmrMedicamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 439)
        Me.Controls.Add(Me.navMedicamentos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FmrMedicamento"
        Me.Text = "Medicamentos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.navMedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.navMedicamentos.ResumeLayout(False)
        Me.navMedicamentos.PerformLayout()
        CType(Me.bsMedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.form_DSMedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents lbldescripcion As Label
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents lblprecio As Label
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents lblcantidad As Label
    Friend WithEvents txtmedicamento As TextBox
    Friend WithEvents lblnommedicamento As Label
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents lblcodigo As Label
    Friend WithEvents txtidmedicamento As TextBox
    Friend WithEvents lblmedicamento As Label
    Friend WithEvents bsMedicamentos As BindingSource
    Friend WithEvents form_DSMedicamentos As dsMedicamentos
    Friend WithEvents MedicamentoTableAdapter As dsMedicamentosTableAdapters.medicamentoTableAdapter
    Friend WithEvents navMedicamentos As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents txtBuscar As ToolStripTextBox
    Friend WithEvents btnBuscar As ToolStripButton
    Friend WithEvents btnRemoveFilter As ToolStripButton
End Class
