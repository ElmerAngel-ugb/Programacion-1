<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FmrPagar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmrPagar))
        Me.navPagar = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.bsPagar = New System.Windows.Forms.BindingSource(Me.components)
        Me.Form_DsPagar = New Programacion_1.dsPagar()
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
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnPagar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCancelarPago = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtBuscarpago = New System.Windows.Forms.ToolStripTextBox()
        Me.btnBuscarPago = New System.Windows.Forms.ToolStripButton()
        Me.btnRemoveFilter = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtBuscarEncargo = New System.Windows.Forms.ToolStripTextBox()
        Me.btnBuscarEncargo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnImprimirPago = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNombrePaciente = New System.Windows.Forms.TextBox()
        Me.bsPaciente = New System.Windows.Forms.BindingSource(Me.components)
        Me.tmpidEncargarmedicamento = New System.Windows.Forms.NumericUpDown()
        Me.bsEncargar_medicamento = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtCostoCita = New System.Windows.Forms.TextBox()
        Me.txtidEncargarmedicamento = New System.Windows.Forms.TextBox()
        Me.txtCostoMedicina = New System.Windows.Forms.TextBox()
        Me.txtCostoIngreso = New System.Windows.Forms.TextBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.txtTotalPagar = New System.Windows.Forms.TextBox()
        Me.txtidPaciente = New System.Windows.Forms.TextBox()
        Me.txtPagar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCodigoPaciente = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtApellidoPaciente = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CbPendientes = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbxFormadePago = New System.Windows.Forms.ComboBox()
        Me.FormadePagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsFormaPago = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsFormaPago = New Programacion_1.dsFormaPago()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PacienteTableAdapter = New Programacion_1.dsPagarTableAdapters.pacienteTableAdapter()
        Me.Encargar_medicamentoTableAdapter = New Programacion_1.dsPagarTableAdapters.encargar_medicamentoTableAdapter()
        Me.PagarTableAdapter = New Programacion_1.dsPagarTableAdapters.PagarTableAdapter()
        Me.FormadePagoTableAdapter = New Programacion_1.dsFormaPagoTableAdapters.FormadePagoTableAdapter()
        CType(Me.navPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.navPagar.SuspendLayout()
        CType(Me.bsPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Form_DsPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tmpidEncargarmedicamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsEncargar_medicamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.FormadePagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsFormaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFormaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'navPagar
        '
        Me.navPagar.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.navPagar.BindingSource = Me.bsPagar
        Me.navPagar.CountItem = Me.BindingNavigatorCountItem
        Me.navPagar.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.navPagar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.navPagar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator1, Me.btnPagar, Me.ToolStripSeparator2, Me.btnCancelarPago, Me.ToolStripSeparator3, Me.txtBuscarpago, Me.btnBuscarPago, Me.btnRemoveFilter, Me.ToolStripSeparator4, Me.txtBuscarEncargo, Me.btnBuscarEncargo, Me.ToolStripSeparator5, Me.btnImprimirPago, Me.ToolStripSeparator6, Me.ToolStripSeparator7})
        Me.navPagar.Location = New System.Drawing.Point(0, 0)
        Me.navPagar.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.navPagar.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.navPagar.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.navPagar.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.navPagar.Name = "navPagar"
        Me.navPagar.PositionItem = Me.BindingNavigatorPositionItem
        Me.navPagar.Size = New System.Drawing.Size(1140, 27)
        Me.navPagar.TabIndex = 0
        Me.navPagar.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo pago"
        '
        'bsPagar
        '
        Me.bsPagar.DataMember = "Pagar"
        Me.bsPagar.DataSource = Me.Form_DsPagar
        '
        'Form_DsPagar
        '
        Me.Form_DsPagar.DataSetName = "dsPagar"
        Me.Form_DsPagar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.BindingNavigatorDeleteItem.Text = "Eliminar pago"
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'btnPagar
        '
        Me.btnPagar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPagar.Image = Global.Programacion_1.My.Resources.Recursos.Pay
        Me.btnPagar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(29, 24)
        Me.btnPagar.Text = "Pagar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'btnCancelarPago
        '
        Me.btnCancelarPago.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCancelarPago.Image = Global.Programacion_1.My.Resources.Recursos.Cancel
        Me.btnCancelarPago.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelarPago.Name = "btnCancelarPago"
        Me.btnCancelarPago.Size = New System.Drawing.Size(29, 24)
        Me.btnCancelarPago.Text = "Cancelar pago"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'txtBuscarpago
        '
        Me.txtBuscarpago.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBuscarpago.Name = "txtBuscarpago"
        Me.txtBuscarpago.Size = New System.Drawing.Size(100, 27)
        Me.txtBuscarpago.Text = "Buscar pago"
        '
        'btnBuscarPago
        '
        Me.btnBuscarPago.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBuscarPago.Image = Global.Programacion_1.My.Resources.Recursos.Search
        Me.btnBuscarPago.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscarPago.Name = "btnBuscarPago"
        Me.btnBuscarPago.Size = New System.Drawing.Size(29, 24)
        Me.btnBuscarPago.Text = "Buscar Pago"
        '
        'btnRemoveFilter
        '
        Me.btnRemoveFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRemoveFilter.Image = Global.Programacion_1.My.Resources.Recursos.remove_filter
        Me.btnRemoveFilter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRemoveFilter.Name = "btnRemoveFilter"
        Me.btnRemoveFilter.Size = New System.Drawing.Size(29, 24)
        Me.btnRemoveFilter.Text = "Volver todo"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 27)
        '
        'txtBuscarEncargo
        '
        Me.txtBuscarEncargo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBuscarEncargo.Name = "txtBuscarEncargo"
        Me.txtBuscarEncargo.ShortcutsEnabled = False
        Me.txtBuscarEncargo.Size = New System.Drawing.Size(200, 27)
        Me.txtBuscarEncargo.Text = "Buscar orden de encargo"
        '
        'btnBuscarEncargo
        '
        Me.btnBuscarEncargo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBuscarEncargo.Image = Global.Programacion_1.My.Resources.Recursos.BuscarEncargo
        Me.btnBuscarEncargo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscarEncargo.Name = "btnBuscarEncargo"
        Me.btnBuscarEncargo.Size = New System.Drawing.Size(29, 24)
        Me.btnBuscarEncargo.Text = "Buscar orden de encargo"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 27)
        '
        'btnImprimirPago
        '
        Me.btnImprimirPago.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnImprimirPago.Image = Global.Programacion_1.My.Resources.Recursos.Imprimir
        Me.btnImprimirPago.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimirPago.Name = "btnImprimirPago"
        Me.btnImprimirPago.Size = New System.Drawing.Size(29, 24)
        Me.btnImprimirPago.Text = "Imprimir"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 27)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código del paciente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Costo de cita:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Costo de medicina:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Costo de ingreso:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 356)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Sub total:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 398)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total a pagar:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(168, 18)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Nombre del paciente:"
        '
        'txtNombrePaciente
        '
        Me.txtNombrePaciente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPaciente, "Nombre", True))
        Me.txtNombrePaciente.Location = New System.Drawing.Point(210, 92)
        Me.txtNombrePaciente.Name = "txtNombrePaciente"
        Me.txtNombrePaciente.ReadOnly = True
        Me.txtNombrePaciente.Size = New System.Drawing.Size(211, 22)
        Me.txtNombrePaciente.TabIndex = 13
        '
        'bsPaciente
        '
        Me.bsPaciente.AllowNew = False
        Me.bsPaciente.DataMember = "paciente"
        Me.bsPaciente.DataSource = Me.Form_DsPagar
        '
        'tmpidEncargarmedicamento
        '
        Me.tmpidEncargarmedicamento.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.bsEncargar_medicamento, "id_encargarmedicamento", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.tmpidEncargarmedicamento.Location = New System.Drawing.Point(446, 125)
        Me.tmpidEncargarmedicamento.Name = "tmpidEncargarmedicamento"
        Me.tmpidEncargarmedicamento.Size = New System.Drawing.Size(0, 22)
        Me.tmpidEncargarmedicamento.TabIndex = 21
        '
        'bsEncargar_medicamento
        '
        Me.bsEncargar_medicamento.AllowNew = False
        Me.bsEncargar_medicamento.DataMember = "encargar_medicamento"
        Me.bsEncargar_medicamento.DataSource = Me.Form_DsPagar
        '
        'txtCostoCita
        '
        Me.txtCostoCita.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPagar, "costo_de_cita", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.txtCostoCita.Location = New System.Drawing.Point(210, 162)
        Me.txtCostoCita.Name = "txtCostoCita"
        Me.txtCostoCita.ReadOnly = True
        Me.txtCostoCita.Size = New System.Drawing.Size(211, 22)
        Me.txtCostoCita.TabIndex = 23
        Me.txtCostoCita.Text = "10"
        Me.txtCostoCita.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtidEncargarmedicamento
        '
        Me.txtidEncargarmedicamento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPagar, "id_encargarmedicamento", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N0"))
        Me.txtidEncargarmedicamento.Location = New System.Drawing.Point(316, 178)
        Me.txtidEncargarmedicamento.Name = "txtidEncargarmedicamento"
        Me.txtidEncargarmedicamento.Size = New System.Drawing.Size(0, 22)
        Me.txtidEncargarmedicamento.TabIndex = 24
        '
        'txtCostoMedicina
        '
        Me.txtCostoMedicina.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEncargar_medicamento, "total", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.txtCostoMedicina.Location = New System.Drawing.Point(210, 199)
        Me.txtCostoMedicina.Name = "txtCostoMedicina"
        Me.txtCostoMedicina.ReadOnly = True
        Me.txtCostoMedicina.Size = New System.Drawing.Size(211, 22)
        Me.txtCostoMedicina.TabIndex = 25
        Me.txtCostoMedicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCostoIngreso
        '
        Me.txtCostoIngreso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPagar, "costo_de_ingreso", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.txtCostoIngreso.Location = New System.Drawing.Point(210, 237)
        Me.txtCostoIngreso.Name = "txtCostoIngreso"
        Me.txtCostoIngreso.Size = New System.Drawing.Size(211, 22)
        Me.txtCostoIngreso.TabIndex = 26
        Me.txtCostoIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotal
        '
        Me.txtSubTotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPagar, "Sub_total", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.txtSubTotal.Location = New System.Drawing.Point(210, 356)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(211, 22)
        Me.txtSubTotal.TabIndex = 27
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalPagar
        '
        Me.txtTotalPagar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPagar, "Total_a_pagar", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.txtTotalPagar.Location = New System.Drawing.Point(210, 394)
        Me.txtTotalPagar.Name = "txtTotalPagar"
        Me.txtTotalPagar.ReadOnly = True
        Me.txtTotalPagar.Size = New System.Drawing.Size(211, 22)
        Me.txtTotalPagar.TabIndex = 28
        Me.txtTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtidPaciente
        '
        Me.txtidPaciente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEncargar_medicamento, "idpaciente", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N0"))
        Me.txtidPaciente.Location = New System.Drawing.Point(324, 50)
        Me.txtidPaciente.Name = "txtidPaciente"
        Me.txtidPaciente.ReadOnly = True
        Me.txtidPaciente.Size = New System.Drawing.Size(0, 22)
        Me.txtidPaciente.TabIndex = 29
        '
        'txtPagar
        '
        Me.txtPagar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPagar, "Idpagar", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N0"))
        Me.txtPagar.Location = New System.Drawing.Point(210, 16)
        Me.txtPagar.Name = "txtPagar"
        Me.txtPagar.ReadOnly = True
        Me.txtPagar.Size = New System.Drawing.Size(211, 22)
        Me.txtPagar.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 18)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Id Pago:"
        '
        'txtCodigoPaciente
        '
        Me.txtCodigoPaciente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPaciente, "Codigo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N0"))
        Me.txtCodigoPaciente.Location = New System.Drawing.Point(210, 54)
        Me.txtCodigoPaciente.Name = "txtCodigoPaciente"
        Me.txtCodigoPaciente.ReadOnly = True
        Me.txtCodigoPaciente.Size = New System.Drawing.Size(211, 22)
        Me.txtCodigoPaciente.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(176, 18)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Apellidos del paciente:"
        '
        'txtApellidoPaciente
        '
        Me.txtApellidoPaciente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPaciente, "Apellido", True))
        Me.txtApellidoPaciente.Location = New System.Drawing.Point(210, 129)
        Me.txtApellidoPaciente.Name = "txtApellidoPaciente"
        Me.txtApellidoPaciente.ReadOnly = True
        Me.txtApellidoPaciente.Size = New System.Drawing.Size(211, 22)
        Me.txtApellidoPaciente.TabIndex = 34
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CbPendientes)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cbxFormadePago)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtApellidoPaciente)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtCodigoPaciente)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtPagar)
        Me.GroupBox1.Controls.Add(Me.txtidPaciente)
        Me.GroupBox1.Controls.Add(Me.txtTotalPagar)
        Me.GroupBox1.Controls.Add(Me.txtSubTotal)
        Me.GroupBox1.Controls.Add(Me.txtCostoIngreso)
        Me.GroupBox1.Controls.Add(Me.txtCostoMedicina)
        Me.GroupBox1.Controls.Add(Me.txtidEncargarmedicamento)
        Me.GroupBox1.Controls.Add(Me.txtCostoCita)
        Me.GroupBox1.Controls.Add(Me.tmpidEncargarmedicamento)
        Me.GroupBox1.Controls.Add(Me.txtNombrePaciente)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(844, 445)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'CbPendientes
        '
        Me.CbPendientes.AutoSize = True
        Me.CbPendientes.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsPagar, "PagosPendientes", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N0"))
        Me.CbPendientes.Location = New System.Drawing.Point(210, 302)
        Me.CbPendientes.Name = "CbPendientes"
        Me.CbPendientes.Size = New System.Drawing.Size(131, 21)
        Me.CbPendientes.TabIndex = 38
        Me.CbPendientes.Text = "Pago Pendiente"
        Me.CbPendientes.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 302)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(149, 18)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Pagos Pendientes:"
        '
        'cbxFormadePago
        '
        Me.cbxFormadePago.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsPagar, "idFormaPago", True))
        Me.cbxFormadePago.DataSource = Me.FormadePagoBindingSource
        Me.cbxFormadePago.DisplayMember = "nombreFormaPago"
        Me.cbxFormadePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxFormadePago.FormattingEnabled = True
        Me.cbxFormadePago.Location = New System.Drawing.Point(210, 268)
        Me.cbxFormadePago.Name = "cbxFormadePago"
        Me.cbxFormadePago.Size = New System.Drawing.Size(211, 24)
        Me.cbxFormadePago.TabIndex = 36
        Me.cbxFormadePago.ValueMember = "IdFormaPago"
        '
        'FormadePagoBindingSource
        '
        Me.FormadePagoBindingSource.AllowNew = False
        Me.FormadePagoBindingSource.DataMember = "FormadePago"
        Me.FormadePagoBindingSource.DataSource = Me.bsFormaPago
        '
        'bsFormaPago
        '
        Me.bsFormaPago.DataSource = Me.DsFormaPago
        Me.bsFormaPago.Position = 0
        '
        'DsFormaPago
        '
        Me.DsFormaPago.DataSetName = "dsFormaPago"
        Me.DsFormaPago.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 268)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(138, 18)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Formas de Pago:"
        '
        'PacienteTableAdapter
        '
        Me.PacienteTableAdapter.ClearBeforeFill = True
        '
        'Encargar_medicamentoTableAdapter
        '
        Me.Encargar_medicamentoTableAdapter.ClearBeforeFill = True
        '
        'PagarTableAdapter
        '
        Me.PagarTableAdapter.ClearBeforeFill = True
        '
        'FormadePagoTableAdapter
        '
        Me.FormadePagoTableAdapter.ClearBeforeFill = True
        '
        'FmrPagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1140, 504)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.navPagar)
        Me.Name = "FmrPagar"
        Me.Text = "FmrPagar"
        CType(Me.navPagar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.navPagar.ResumeLayout(False)
        Me.navPagar.PerformLayout()
        CType(Me.bsPagar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Form_DsPagar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tmpidEncargarmedicamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsEncargar_medicamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.FormadePagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsFormaPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFormaPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents navPagar As BindingNavigator
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
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnPagar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btnCancelarPago As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents txtBuscarpago As ToolStripTextBox
    Friend WithEvents btnBuscarPago As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents btnRemoveFilter As ToolStripButton
    Friend WithEvents txtBuscarEncargo As ToolStripTextBox
    Friend WithEvents btnBuscarEncargo As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents Form_DsPagar As dsPagar
    Friend WithEvents bsPagar As BindingSource
    Friend WithEvents bsPaciente As BindingSource
    Friend WithEvents PacienteTableAdapter As dsPagarTableAdapters.pacienteTableAdapter
    Friend WithEvents bsEncargar_medicamento As BindingSource
    Friend WithEvents Encargar_medicamentoTableAdapter As dsPagarTableAdapters.encargar_medicamentoTableAdapter
    Friend WithEvents PagarTableAdapter As dsPagarTableAdapters.PagarTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNombrePaciente As TextBox
    Friend WithEvents tmpidEncargarmedicamento As NumericUpDown
    Friend WithEvents txtCostoCita As TextBox
    Friend WithEvents txtidEncargarmedicamento As TextBox
    Friend WithEvents txtCostoMedicina As TextBox
    Friend WithEvents txtCostoIngreso As TextBox
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents txtTotalPagar As TextBox
    Friend WithEvents txtidPaciente As TextBox
    Friend WithEvents txtPagar As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCodigoPaciente As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtApellidoPaciente As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbxFormadePago As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents bsFormaPago As BindingSource
    Friend WithEvents DsFormaPago As dsFormaPago
    Friend WithEvents FormadePagoBindingSource As BindingSource
    Friend WithEvents FormadePagoTableAdapter As dsFormaPagoTableAdapters.FormadePagoTableAdapter
    Friend WithEvents btnImprimirPago As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents CbPendientes As CheckBox
    Friend WithEvents Label11 As Label
End Class
