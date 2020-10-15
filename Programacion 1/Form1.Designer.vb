<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
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
        Me.form_DSMedicamentos = New Programacion_1.dsMedicamentos()
        Me.bsMedicamentos = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedicamentoTableAdapter = New Programacion_1.dsMedicamentosTableAdapters.medicamentoTableAdapter()
        Me.navMedicamentos = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.form_DSMedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsMedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.navMedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.navMedicamentos.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.navMedicamentos)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
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
        Me.GroupBox1.Location = New System.Drawing.Point(22, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(967, 533)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Medicamentos."
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnbuscar)
        Me.GroupBox3.Controls.Add(Me.btneliminar)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.btnnuevo)
        Me.GroupBox3.Location = New System.Drawing.Point(466, 458)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(465, 69)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Editar."
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnbuscar.Location = New System.Drawing.Point(314, 23)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(84, 37)
        Me.btnbuscar.TabIndex = 26
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'btneliminar
        '
        Me.btneliminar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btneliminar.Location = New System.Drawing.Point(216, 26)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(92, 37)
        Me.btneliminar.TabIndex = 26
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(105, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 37)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Modificar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnnuevo.Location = New System.Drawing.Point(15, 26)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(84, 37)
        Me.btnnuevo.TabIndex = 0
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'txtdescripcion
        '
        Me.txtdescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsMedicamentos, "descripcion", True))
        Me.txtdescripcion.Location = New System.Drawing.Point(242, 322)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(388, 108)
        Me.txtdescripcion.TabIndex = 23
        '
        'lbldescripcion
        '
        Me.lbldescripcion.AutoSize = True
        Me.lbldescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescripcion.Location = New System.Drawing.Point(120, 341)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(116, 20)
        Me.lbldescripcion.TabIndex = 22
        Me.lbldescripcion.Text = "Descripcion:"
        '
        'txtprecio
        '
        Me.txtprecio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsMedicamentos, "precio", True))
        Me.txtprecio.Location = New System.Drawing.Point(195, 280)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(146, 27)
        Me.txtprecio.TabIndex = 21
        '
        'lblprecio
        '
        Me.lblprecio.AutoSize = True
        Me.lblprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprecio.Location = New System.Drawing.Point(120, 280)
        Me.lblprecio.Name = "lblprecio"
        Me.lblprecio.Size = New System.Drawing.Size(69, 20)
        Me.lblprecio.TabIndex = 20
        Me.lblprecio.Text = "Precio:"
        '
        'txtcantidad
        '
        Me.txtcantidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsMedicamentos, "cantidad_disponible", True))
        Me.txtcantidad.Location = New System.Drawing.Point(268, 227)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(146, 27)
        Me.txtcantidad.TabIndex = 19
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcantidad.Location = New System.Drawing.Point(97, 234)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(149, 20)
        Me.lblcantidad.TabIndex = 18
        Me.lblcantidad.Text = "Cant_disponible:"
        '
        'txtmedicamento
        '
        Me.txtmedicamento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsMedicamentos, "nombre_medicamento", True))
        Me.txtmedicamento.Location = New System.Drawing.Point(253, 170)
        Me.txtmedicamento.Name = "txtmedicamento"
        Me.txtmedicamento.Size = New System.Drawing.Size(219, 27)
        Me.txtmedicamento.TabIndex = 17
        '
        'lblnommedicamento
        '
        Me.lblnommedicamento.AutoSize = True
        Me.lblnommedicamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnommedicamento.Location = New System.Drawing.Point(120, 170)
        Me.lblnommedicamento.Name = "lblnommedicamento"
        Me.lblnommedicamento.Size = New System.Drawing.Size(126, 20)
        Me.lblnommedicamento.TabIndex = 16
        Me.lblnommedicamento.Text = "Medicamento:"
        '
        'txtcodigo
        '
        Me.txtcodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsMedicamentos, "codigo", True))
        Me.txtcodigo.Location = New System.Drawing.Point(201, 129)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(146, 27)
        Me.txtcodigo.TabIndex = 15
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodigo.Location = New System.Drawing.Point(121, 129)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(73, 20)
        Me.lblcodigo.TabIndex = 14
        Me.lblcodigo.Text = "Codigo:"
        '
        'txtidmedicamento
        '
        Me.txtidmedicamento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsMedicamentos, "idmedicamento", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N0"))
        Me.txtidmedicamento.Location = New System.Drawing.Point(267, 80)
        Me.txtidmedicamento.Name = "txtidmedicamento"
        Me.txtidmedicamento.Size = New System.Drawing.Size(131, 27)
        Me.txtidmedicamento.TabIndex = 13
        '
        'lblmedicamento
        '
        Me.lblmedicamento.AutoSize = True
        Me.lblmedicamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmedicamento.Location = New System.Drawing.Point(120, 80)
        Me.lblmedicamento.Name = "lblmedicamento"
        Me.lblmedicamento.Size = New System.Drawing.Size(141, 20)
        Me.lblmedicamento.TabIndex = 12
        Me.lblmedicamento.Text = "idmedicamento:"
        '
        'form_DSMedicamentos
        '
        Me.form_DSMedicamentos.DataSetName = "form_dsMedicamentos"
        Me.form_DSMedicamentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bsMedicamentos
        '
        Me.bsMedicamentos.AllowNew = True
        Me.bsMedicamentos.DataMember = "medicamento"
        Me.bsMedicamentos.DataSource = Me.form_DSMedicamentos
        '
        'MedicamentoTableAdapter
        '
        Me.MedicamentoTableAdapter.ClearBeforeFill = True
        '
        'navMedicamentos
        '
        Me.navMedicamentos.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.navMedicamentos.BindingSource = Me.bsMedicamentos
        Me.navMedicamentos.CountItem = Me.BindingNavigatorCountItem
        Me.navMedicamentos.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.navMedicamentos.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.navMedicamentos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ToolStripButton1})
        Me.navMedicamentos.Location = New System.Drawing.Point(3, 23)
        Me.navMedicamentos.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.navMedicamentos.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.navMedicamentos.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.navMedicamentos.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.navMedicamentos.Name = "navMedicamentos"
        Me.navMedicamentos.PositionItem = Me.BindingNavigatorPositionItem
        Me.navMedicamentos.Size = New System.Drawing.Size(961, 27)
        Me.navMedicamentos.TabIndex = 26
        Me.navMedicamentos.Text = "navMedicamentos"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 557)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Medicamentos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.form_DSMedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsMedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.navMedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.navMedicamentos.ResumeLayout(False)
        Me.navMedicamentos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnnuevo As Button
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
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
