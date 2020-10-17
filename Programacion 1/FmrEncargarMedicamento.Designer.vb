<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FmrEncargarMedicamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmrEncargarMedicamento))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tmpIdMedicamento = New System.Windows.Forms.TextBox()
        Me.bsMedicamentos = New System.Windows.Forms.BindingSource(Me.components)
        Me.Form_DSEntregarmedicamentos = New Programacion_1.dsEntregarmedicamentos()
        Me.tmpIdPaciente = New System.Windows.Forms.TextBox()
        Me.bsPaciente = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtCantidadDeseada = New System.Windows.Forms.MaskedTextBox()
        Me.bsEntregarmedicamento = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtNombrePaciente = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtIdMedicamento = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCantidadDisponible = New System.Windows.Forms.TextBox()
        Me.txtNombreMedicamento = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtPaciente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.navEntregarmedicamentos = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtBuscar = New System.Windows.Forms.ToolStripTextBox()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.btnRemoveFilter = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtBuscarmedicamento = New System.Windows.Forms.ToolStripTextBox()
        Me.btnBuscarMedicamento = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtBuscarPaciente = New System.Windows.Forms.ToolStripTextBox()
        Me.btnBuscarPaciente = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Encargar_medicamentoTableAdapter = New Programacion_1.dsEntregarmedicamentosTableAdapters.encargar_medicamentoTableAdapter()
        Me.MedicamentoTableAdapter = New Programacion_1.dsEntregarmedicamentosTableAdapters.medicamentoTableAdapter()
        Me.PacienteTableAdapter = New Programacion_1.dsEntregarmedicamentosTableAdapters.pacienteTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.bsMedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Form_DSEntregarmedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsEntregarmedicamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.navEntregarmedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.navEntregarmedicamentos.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tmpIdMedicamento)
        Me.GroupBox1.Controls.Add(Me.tmpIdPaciente)
        Me.GroupBox1.Controls.Add(Me.txtCantidadDeseada)
        Me.GroupBox1.Controls.Add(Me.txtNombrePaciente)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtIdMedicamento)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.txtPrecio)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.txtCantidadDisponible)
        Me.GroupBox1.Controls.Add(Me.txtNombreMedicamento)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.txtPaciente)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(713, 471)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'tmpIdMedicamento
        '
        Me.tmpIdMedicamento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsMedicamentos, "idmedicamento", True))
        Me.tmpIdMedicamento.Location = New System.Drawing.Point(353, 97)
        Me.tmpIdMedicamento.Name = "tmpIdMedicamento"
        Me.tmpIdMedicamento.Size = New System.Drawing.Size(0, 22)
        Me.tmpIdMedicamento.TabIndex = 22
        '
        'bsMedicamentos
        '
        Me.bsMedicamentos.AllowNew = False
        Me.bsMedicamentos.DataMember = "medicamento"
        Me.bsMedicamentos.DataSource = Me.Form_DSEntregarmedicamentos
        '
        'Form_DSEntregarmedicamentos
        '
        Me.Form_DSEntregarmedicamentos.DataSetName = "dsEntregarmedicamentos"
        Me.Form_DSEntregarmedicamentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tmpIdPaciente
        '
        Me.tmpIdPaciente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPaciente, "idpaciente", True))
        Me.tmpIdPaciente.Location = New System.Drawing.Point(353, 21)
        Me.tmpIdPaciente.Name = "tmpIdPaciente"
        Me.tmpIdPaciente.Size = New System.Drawing.Size(0, 22)
        Me.tmpIdPaciente.TabIndex = 21
        '
        'bsPaciente
        '
        Me.bsPaciente.AllowNew = False
        Me.bsPaciente.DataMember = "paciente"
        Me.bsPaciente.DataSource = Me.Form_DSEntregarmedicamentos
        '
        'txtCantidadDeseada
        '
        Me.txtCantidadDeseada.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEntregarmedicamento, "cantidad_deseada", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"))
        Me.txtCantidadDeseada.Location = New System.Drawing.Point(213, 358)
        Me.txtCantidadDeseada.Name = "txtCantidadDeseada"
        Me.txtCantidadDeseada.Size = New System.Drawing.Size(100, 22)
        Me.txtCantidadDeseada.TabIndex = 20
        Me.txtCantidadDeseada.ValidatingType = GetType(Date)
        '
        'bsEntregarmedicamento
        '
        Me.bsEntregarmedicamento.DataMember = "encargar_medicamento"
        Me.bsEntregarmedicamento.DataSource = Me.Form_DSEntregarmedicamentos
        '
        'txtNombrePaciente
        '
        Me.txtNombrePaciente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPaciente, "nombre", True))
        Me.txtNombrePaciente.Location = New System.Drawing.Point(214, 59)
        Me.txtNombrePaciente.Name = "txtNombrePaciente"
        Me.txtNombrePaciente.ReadOnly = True
        Me.txtNombrePaciente.Size = New System.Drawing.Size(391, 22)
        Me.txtNombrePaciente.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(29, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(168, 18)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Nombre del paciente:"
        '
        'txtIdMedicamento
        '
        Me.txtIdMedicamento.AcceptsTab = True
        Me.txtIdMedicamento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEntregarmedicamento, "idmedicamento", True))
        Me.txtIdMedicamento.Location = New System.Drawing.Point(213, 131)
        Me.txtIdMedicamento.Name = "txtIdMedicamento"
        Me.txtIdMedicamento.ReadOnly = True
        Me.txtIdMedicamento.Size = New System.Drawing.Size(100, 22)
        Me.txtIdMedicamento.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(26, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 18)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "IDmedicamento:"
        '
        'txtTotal
        '
        Me.txtTotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEntregarmedicamento, "total", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"))
        Me.txtTotal.Location = New System.Drawing.Point(213, 402)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(87, 22)
        Me.txtTotal.TabIndex = 15
        '
        'txtPrecio
        '
        Me.txtPrecio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsMedicamentos, "precio", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"))
        Me.txtPrecio.Location = New System.Drawing.Point(213, 316)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.ReadOnly = True
        Me.txtPrecio.Size = New System.Drawing.Size(101, 22)
        Me.txtPrecio.TabIndex = 13
        '
        'txtDescripcion
        '
        Me.txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsMedicamentos, "descripcion", True))
        Me.txtDescripcion.Location = New System.Drawing.Point(213, 241)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(277, 69)
        Me.txtDescripcion.TabIndex = 12
        '
        'txtCantidadDisponible
        '
        Me.txtCantidadDisponible.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsMedicamentos, "cantidad_disponible", True))
        Me.txtCantidadDisponible.Location = New System.Drawing.Point(213, 206)
        Me.txtCantidadDisponible.Name = "txtCantidadDisponible"
        Me.txtCantidadDisponible.ReadOnly = True
        Me.txtCantidadDisponible.Size = New System.Drawing.Size(88, 22)
        Me.txtCantidadDisponible.TabIndex = 11
        '
        'txtNombreMedicamento
        '
        Me.txtNombreMedicamento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsMedicamentos, "nombre_medicamento", True))
        Me.txtNombreMedicamento.Location = New System.Drawing.Point(213, 168)
        Me.txtNombreMedicamento.Name = "txtNombreMedicamento"
        Me.txtNombreMedicamento.ReadOnly = True
        Me.txtNombreMedicamento.Size = New System.Drawing.Size(134, 22)
        Me.txtNombreMedicamento.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsMedicamentos, "idmedicamento", True))
        Me.TextBox2.Location = New System.Drawing.Point(213, 97)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(134, 22)
        Me.TextBox2.TabIndex = 9
        '
        'txtPaciente
        '
        Me.txtPaciente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEntregarmedicamento, "idpaciente", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N0"))
        Me.txtPaciente.Location = New System.Drawing.Point(213, 21)
        Me.txtPaciente.Name = "txtPaciente"
        Me.txtPaciente.ReadOnly = True
        Me.txtPaciente.Size = New System.Drawing.Size(134, 22)
        Me.txtPaciente.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 401)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Total:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 358)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Cantidad deseada:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 315)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Precio:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Descripcion:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cantidad disponible:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Codigo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código del paciente:"
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
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'navEntregarmedicamentos
        '
        Me.navEntregarmedicamentos.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.navEntregarmedicamentos.BindingSource = Me.bsEntregarmedicamento
        Me.navEntregarmedicamentos.CountItem = Me.BindingNavigatorCountItem
        Me.navEntregarmedicamentos.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.navEntregarmedicamentos.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.navEntregarmedicamentos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator1, Me.btnGuardar, Me.ToolStripSeparator5, Me.btnCancelar, Me.ToolStripSeparator6, Me.txtBuscar, Me.btnBuscar, Me.btnRemoveFilter, Me.ToolStripSeparator3, Me.txtBuscarmedicamento, Me.btnBuscarMedicamento, Me.ToolStripSeparator4, Me.txtBuscarPaciente, Me.btnBuscarPaciente, Me.ToolStripSeparator2})
        Me.navEntregarmedicamentos.Location = New System.Drawing.Point(0, 0)
        Me.navEntregarmedicamentos.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.navEntregarmedicamentos.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.navEntregarmedicamentos.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.navEntregarmedicamentos.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.navEntregarmedicamentos.Name = "navEntregarmedicamentos"
        Me.navEntregarmedicamentos.PositionItem = Me.BindingNavigatorPositionItem
        Me.navEntregarmedicamentos.Size = New System.Drawing.Size(898, 27)
        Me.navEntregarmedicamentos.TabIndex = 17
        Me.navEntregarmedicamentos.Text = "BindingNavigator1"
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
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
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 27)
        '
        'btnCancelar
        '
        Me.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCancelar.Image = Global.Programacion_1.My.Resources.Resources.Cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(29, 28)
        Me.btnCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 27)
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(100, 27)
        Me.txtBuscar.Text = "Buscar."
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
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'txtBuscarmedicamento
        '
        Me.txtBuscarmedicamento.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBuscarmedicamento.Name = "txtBuscarmedicamento"
        Me.txtBuscarmedicamento.Size = New System.Drawing.Size(100, 27)
        Me.txtBuscarmedicamento.Text = "Inserte código de medicina"
        '
        'btnBuscarMedicamento
        '
        Me.btnBuscarMedicamento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBuscarMedicamento.Image = Global.Programacion_1.My.Resources.Recursos.Medicine
        Me.btnBuscarMedicamento.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscarMedicamento.Name = "btnBuscarMedicamento"
        Me.btnBuscarMedicamento.Size = New System.Drawing.Size(29, 24)
        Me.btnBuscarMedicamento.Text = "Buscar medicamento"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 27)
        '
        'txtBuscarPaciente
        '
        Me.txtBuscarPaciente.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBuscarPaciente.Name = "txtBuscarPaciente"
        Me.txtBuscarPaciente.Size = New System.Drawing.Size(100, 27)
        Me.txtBuscarPaciente.Text = "Inserte Id de paciente"
        '
        'btnBuscarPaciente
        '
        Me.btnBuscarPaciente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBuscarPaciente.Image = Global.Programacion_1.My.Resources.Recursos.Patients
        Me.btnBuscarPaciente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscarPaciente.Name = "btnBuscarPaciente"
        Me.btnBuscarPaciente.Size = New System.Drawing.Size(29, 24)
        Me.btnBuscarPaciente.Text = "ID de paciente"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'Encargar_medicamentoTableAdapter
        '
        Me.Encargar_medicamentoTableAdapter.ClearBeforeFill = True
        '
        'MedicamentoTableAdapter
        '
        Me.MedicamentoTableAdapter.ClearBeforeFill = True
        '
        'PacienteTableAdapter
        '
        Me.PacienteTableAdapter.ClearBeforeFill = True
        '
        'FmrEncargarMedicamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 523)
        Me.Controls.Add(Me.navEntregarmedicamentos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FmrEncargarMedicamento"
        Me.Text = "Encargar_medicamento"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.bsMedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Form_DSEntregarmedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsEntregarmedicamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.navEntregarmedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.navEntregarmedicamentos.ResumeLayout(False)
        Me.navEntregarmedicamentos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtCantidadDisponible As TextBox
    Friend WithEvents txtNombreMedicamento As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtPaciente As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Form_DSEntregarmedicamentos As dsEntregarmedicamentos
    Friend WithEvents bsEntregarmedicamento As BindingSource
    Friend WithEvents Encargar_medicamentoTableAdapter As dsEntregarmedicamentosTableAdapters.encargar_medicamentoTableAdapter
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents navEntregarmedicamentos As BindingNavigator
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents txtBuscar As ToolStripTextBox
    Friend WithEvents btnBuscar As ToolStripButton
    Friend WithEvents btnRemoveFilter As ToolStripButton
    Friend WithEvents bsMedicamentos As BindingSource
    Friend WithEvents bsPaciente As BindingSource
    Friend WithEvents MedicamentoTableAdapter As dsEntregarmedicamentosTableAdapters.medicamentoTableAdapter
    Friend WithEvents PacienteTableAdapter As dsEntregarmedicamentosTableAdapters.pacienteTableAdapter
    Friend WithEvents txtIdMedicamento As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNombrePaciente As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents txtBuscarmedicamento As ToolStripTextBox
    Friend WithEvents btnBuscarMedicamento As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents txtBuscarPaciente As ToolStripTextBox
    Friend WithEvents btnBuscarPaciente As ToolStripButton
    Friend WithEvents txtCantidadDeseada As MaskedTextBox
    Friend WithEvents tmpIdMedicamento As TextBox
    Friend WithEvents tmpIdPaciente As TextBox
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents btnCancelar As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
End Class
