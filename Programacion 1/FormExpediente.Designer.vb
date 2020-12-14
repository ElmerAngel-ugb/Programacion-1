<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormExpediente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormExpediente))
        Dim Numero_ExpedienteLabel As System.Windows.Forms.Label
        Dim Id_RegistroLabel As System.Windows.Forms.Label
        Dim Id_PediatraLabel As System.Windows.Forms.Label
        Dim Fecha_Hora_ExpedienteLabel As System.Windows.Forms.Label
        Dim Id_AcompananteLabel As System.Windows.Forms.Label
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SdExpediente = New Programacion_1.sdExpediente()
        Me.ExpedienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExpedienteTableAdapter = New Programacion_1.sdExpedienteTableAdapters.ExpedienteTableAdapter()
        Me.TableAdapterManager = New Programacion_1.sdExpedienteTableAdapters.TableAdapterManager()
        Me.ExpedienteBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ExpedienteBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DiagnosticoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DiagnosticoTableAdapter = New Programacion_1.sdExpedienteTableAdapters.DiagnosticoTableAdapter()
        Me.DiagnosticoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecetaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecetaTableAdapter = New Programacion_1.sdExpedienteTableAdapters.RecetaTableAdapter()
        Me.RecetaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedicamentoTableAdapter = New Programacion_1.sdExpedienteTableAdapters.medicamentoTableAdapter()
        Me.MedicamentoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Numero_ExpedienteTextBox = New System.Windows.Forms.TextBox()
        Me.Id_RegistroComboBox = New System.Windows.Forms.ComboBox()
        Me.Id_PediatraComboBox = New System.Windows.Forms.ComboBox()
        Me.Fecha_Hora_ExpedienteDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Id_AcompananteComboBox = New System.Windows.Forms.ComboBox()
        Me.RegistroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistroTableAdapter = New Programacion_1.sdExpedienteTableAdapters.RegistroTableAdapter()
        Me.AcompananteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AcompananteTableAdapter = New Programacion_1.sdExpedienteTableAdapters.AcompananteTableAdapter()
        Me.PediatraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PediatraTableAdapter = New Programacion_1.sdExpedienteTableAdapters.PediatraTableAdapter()
        Numero_ExpedienteLabel = New System.Windows.Forms.Label()
        Id_RegistroLabel = New System.Windows.Forms.Label()
        Id_PediatraLabel = New System.Windows.Forms.Label()
        Fecha_Hora_ExpedienteLabel = New System.Windows.Forms.Label()
        Id_AcompananteLabel = New System.Windows.Forms.Label()
        CType(Me.SdExpediente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpedienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpedienteBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExpedienteBindingNavigator.SuspendLayout()
        CType(Me.DiagnosticoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiagnosticoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecetaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecetaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicamentoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AcompananteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PediatraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_Diagnostico"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_Diagnostico"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Id_Expediente"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id_Expediente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Causas"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Causas"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Enfermedad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Enfermedad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Observacion"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Observacion"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Id_Receta"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Id_Receta"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "idmedicamento"
        Me.DataGridViewTextBoxColumn7.HeaderText = "idmedicamento"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Indicacion_Medicinal"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Indicacion_Medicinal"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Id_Diagnostico"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Id_Diagnostico"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "idmedicamento"
        Me.DataGridViewTextBoxColumn10.HeaderText = "idmedicamento"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "codigo"
        Me.DataGridViewTextBoxColumn11.HeaderText = "codigo"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "nombre_medicamento"
        Me.DataGridViewTextBoxColumn12.HeaderText = "nombre_medicamento"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "cantidad_disponible"
        Me.DataGridViewTextBoxColumn13.HeaderText = "cantidad_disponible"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "precio"
        Me.DataGridViewTextBoxColumn14.HeaderText = "precio"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn15.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Id_Receta"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Id_Receta"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'SdExpediente
        '
        Me.SdExpediente.DataSetName = "sdExpediente"
        Me.SdExpediente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExpedienteBindingSource
        '
        Me.ExpedienteBindingSource.DataMember = "Expediente"
        Me.ExpedienteBindingSource.DataSource = Me.SdExpediente
        '
        'ExpedienteTableAdapter
        '
        Me.ExpedienteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AcompananteTableAdapter = Me.AcompananteTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DiagnosticoTableAdapter = Me.DiagnosticoTableAdapter
        Me.TableAdapterManager.ExpedienteTableAdapter = Me.ExpedienteTableAdapter
        Me.TableAdapterManager.medicamentoTableAdapter = Me.MedicamentoTableAdapter
        Me.TableAdapterManager.PediatraTableAdapter = Me.PediatraTableAdapter
        Me.TableAdapterManager.RecetaTableAdapter = Me.RecetaTableAdapter
        Me.TableAdapterManager.RegistroTableAdapter = Me.RegistroTableAdapter
        Me.TableAdapterManager.UpdateOrder = Programacion_1.sdExpedienteTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ExpedienteBindingNavigator
        '
        Me.ExpedienteBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ExpedienteBindingNavigator.BindingSource = Me.ExpedienteBindingSource
        Me.ExpedienteBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ExpedienteBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ExpedienteBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ExpedienteBindingNavigatorSaveItem})
        Me.ExpedienteBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ExpedienteBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ExpedienteBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ExpedienteBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ExpedienteBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ExpedienteBindingNavigator.Name = "ExpedienteBindingNavigator"
        Me.ExpedienteBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ExpedienteBindingNavigator.Size = New System.Drawing.Size(861, 25)
        Me.ExpedienteBindingNavigator.TabIndex = 0
        Me.ExpedienteBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'ExpedienteBindingNavigatorSaveItem
        '
        Me.ExpedienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ExpedienteBindingNavigatorSaveItem.Image = CType(resources.GetObject("ExpedienteBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ExpedienteBindingNavigatorSaveItem.Name = "ExpedienteBindingNavigatorSaveItem"
        Me.ExpedienteBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ExpedienteBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'DiagnosticoBindingSource
        '
        Me.DiagnosticoBindingSource.DataMember = "FK_Diagnostico_Expediente"
        Me.DiagnosticoBindingSource.DataSource = Me.ExpedienteBindingSource
        '
        'DiagnosticoTableAdapter
        '
        Me.DiagnosticoTableAdapter.ClearBeforeFill = True
        '
        'DiagnosticoDataGridView
        '
        Me.DiagnosticoDataGridView.AutoGenerateColumns = False
        Me.DiagnosticoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DiagnosticoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21})
        Me.DiagnosticoDataGridView.DataSource = Me.DiagnosticoBindingSource
        Me.DiagnosticoDataGridView.Location = New System.Drawing.Point(13, 177)
        Me.DiagnosticoDataGridView.Name = "DiagnosticoDataGridView"
        Me.DiagnosticoDataGridView.Size = New System.Drawing.Size(457, 220)
        Me.DiagnosticoDataGridView.TabIndex = 12
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Id_Diagnostico"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Id_Diagnostico"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Visible = False
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Id_Expediente"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Id_Expediente"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Visible = False
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Causas"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Causas"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Width = 125
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Enfermedad"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Enfermedad"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Width = 140
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Observacion"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Observacion"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Width = 150
        '
        'RecetaBindingSource
        '
        Me.RecetaBindingSource.DataMember = "FK_Receta_Diagnostico"
        Me.RecetaBindingSource.DataSource = Me.DiagnosticoBindingSource
        '
        'RecetaTableAdapter
        '
        Me.RecetaTableAdapter.ClearBeforeFill = True
        '
        'RecetaDataGridView
        '
        Me.RecetaDataGridView.AutoGenerateColumns = False
        Me.RecetaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RecetaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25})
        Me.RecetaDataGridView.DataSource = Me.RecetaBindingSource
        Me.RecetaDataGridView.Location = New System.Drawing.Point(658, 175)
        Me.RecetaDataGridView.Name = "RecetaDataGridView"
        Me.RecetaDataGridView.Size = New System.Drawing.Size(175, 220)
        Me.RecetaDataGridView.TabIndex = 12
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Id_Receta"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Id_Receta"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.Visible = False
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "idmedicamento"
        Me.DataGridViewTextBoxColumn23.HeaderText = "idmedicamento"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Visible = False
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Indicacion_Medicinal"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Indicacion_Medicinal"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.Width = 145
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "Id_Diagnostico"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Id_Diagnostico"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.Visible = False
        '
        'MedicamentoBindingSource
        '
        Me.MedicamentoBindingSource.DataMember = "FK_medicamento_Receta"
        Me.MedicamentoBindingSource.DataSource = Me.RecetaBindingSource
        '
        'MedicamentoTableAdapter
        '
        Me.MedicamentoTableAdapter.ClearBeforeFill = True
        '
        'MedicamentoDataGridView
        '
        Me.MedicamentoDataGridView.AutoGenerateColumns = False
        Me.MedicamentoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MedicamentoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32})
        Me.MedicamentoDataGridView.DataSource = Me.MedicamentoBindingSource
        Me.MedicamentoDataGridView.Location = New System.Drawing.Point(476, 177)
        Me.MedicamentoDataGridView.Name = "MedicamentoDataGridView"
        Me.MedicamentoDataGridView.Size = New System.Drawing.Size(172, 220)
        Me.MedicamentoDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "idmedicamento"
        Me.DataGridViewTextBoxColumn26.HeaderText = "idmedicamento"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        Me.DataGridViewTextBoxColumn26.Visible = False
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "codigo"
        Me.DataGridViewTextBoxColumn27.HeaderText = "codigo"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.Visible = False
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "nombre_medicamento"
        Me.DataGridViewTextBoxColumn28.HeaderText = "nombre_medicamento"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.Width = 130
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "cantidad_disponible"
        Me.DataGridViewTextBoxColumn29.HeaderText = "cantidad_disponible"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.Visible = False
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "precio"
        Me.DataGridViewTextBoxColumn30.HeaderText = "precio"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.Visible = False
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn31.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.Visible = False
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "Id_Receta"
        Me.DataGridViewTextBoxColumn32.HeaderText = "Id_Receta"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.Visible = False
        '
        'Numero_ExpedienteLabel
        '
        Numero_ExpedienteLabel.AutoSize = True
        Numero_ExpedienteLabel.Location = New System.Drawing.Point(630, 109)
        Numero_ExpedienteLabel.Name = "Numero_ExpedienteLabel"
        Numero_ExpedienteLabel.Size = New System.Drawing.Size(103, 13)
        Numero_ExpedienteLabel.TabIndex = 15
        Numero_ExpedienteLabel.Text = "Numero Expediente:"
        '
        'Numero_ExpedienteTextBox
        '
        Me.Numero_ExpedienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExpedienteBindingSource, "Numero_Expediente", True))
        Me.Numero_ExpedienteTextBox.Location = New System.Drawing.Point(736, 106)
        Me.Numero_ExpedienteTextBox.Name = "Numero_ExpedienteTextBox"
        Me.Numero_ExpedienteTextBox.Size = New System.Drawing.Size(97, 20)
        Me.Numero_ExpedienteTextBox.TabIndex = 16
        '
        'Id_RegistroLabel
        '
        Id_RegistroLabel.AutoSize = True
        Id_RegistroLabel.Location = New System.Drawing.Point(24, 44)
        Id_RegistroLabel.Name = "Id_RegistroLabel"
        Id_RegistroLabel.Size = New System.Drawing.Size(61, 13)
        Id_RegistroLabel.TabIndex = 17
        Id_RegistroLabel.Text = "Id Registro:"
        '
        'Id_RegistroComboBox
        '
        Me.Id_RegistroComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ExpedienteBindingSource, "Id_Registro", True))
        Me.Id_RegistroComboBox.DataSource = Me.RegistroBindingSource
        Me.Id_RegistroComboBox.DisplayMember = "Nombre"
        Me.Id_RegistroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Id_RegistroComboBox.FormattingEnabled = True
        Me.Id_RegistroComboBox.Location = New System.Drawing.Point(91, 41)
        Me.Id_RegistroComboBox.Name = "Id_RegistroComboBox"
        Me.Id_RegistroComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Id_RegistroComboBox.TabIndex = 18
        Me.Id_RegistroComboBox.ValueMember = "Id_Registro"
        '
        'Id_PediatraLabel
        '
        Id_PediatraLabel.AutoSize = True
        Id_PediatraLabel.Location = New System.Drawing.Point(344, 109)
        Id_PediatraLabel.Name = "Id_PediatraLabel"
        Id_PediatraLabel.Size = New System.Drawing.Size(61, 13)
        Id_PediatraLabel.TabIndex = 19
        Id_PediatraLabel.Text = "Id Pediatra:"
        '
        'Id_PediatraComboBox
        '
        Me.Id_PediatraComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ExpedienteBindingSource, "Id_Pediatra", True))
        Me.Id_PediatraComboBox.DataSource = Me.PediatraBindingSource
        Me.Id_PediatraComboBox.DisplayMember = "Nombre"
        Me.Id_PediatraComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Id_PediatraComboBox.FormattingEnabled = True
        Me.Id_PediatraComboBox.Location = New System.Drawing.Point(411, 104)
        Me.Id_PediatraComboBox.Name = "Id_PediatraComboBox"
        Me.Id_PediatraComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Id_PediatraComboBox.TabIndex = 20
        Me.Id_PediatraComboBox.ValueMember = "Id_Pediatra"
        '
        'Fecha_Hora_ExpedienteLabel
        '
        Fecha_Hora_ExpedienteLabel.AutoSize = True
        Fecha_Hora_ExpedienteLabel.Location = New System.Drawing.Point(505, 44)
        Fecha_Hora_ExpedienteLabel.Name = "Fecha_Hora_ExpedienteLabel"
        Fecha_Hora_ExpedienteLabel.Size = New System.Drawing.Size(122, 13)
        Fecha_Hora_ExpedienteLabel.TabIndex = 21
        Fecha_Hora_ExpedienteLabel.Text = "Fecha Hora Expediente:"
        '
        'Fecha_Hora_ExpedienteDateTimePicker
        '
        Me.Fecha_Hora_ExpedienteDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ExpedienteBindingSource, "Fecha_Hora_Expediente", True))
        Me.Fecha_Hora_ExpedienteDateTimePicker.Location = New System.Drawing.Point(633, 38)
        Me.Fecha_Hora_ExpedienteDateTimePicker.Name = "Fecha_Hora_ExpedienteDateTimePicker"
        Me.Fecha_Hora_ExpedienteDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_Hora_ExpedienteDateTimePicker.TabIndex = 22
        '
        'Id_AcompananteLabel
        '
        Id_AcompananteLabel.AutoSize = True
        Id_AcompananteLabel.Location = New System.Drawing.Point(24, 106)
        Id_AcompananteLabel.Name = "Id_AcompananteLabel"
        Id_AcompananteLabel.Size = New System.Drawing.Size(88, 13)
        Id_AcompananteLabel.TabIndex = 23
        Id_AcompananteLabel.Text = "Id Acompanante:"
        '
        'Id_AcompananteComboBox
        '
        Me.Id_AcompananteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ExpedienteBindingSource, "Id_Acompanante", True))
        Me.Id_AcompananteComboBox.DataSource = Me.AcompananteBindingSource
        Me.Id_AcompananteComboBox.DisplayMember = "Nombre"
        Me.Id_AcompananteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Id_AcompananteComboBox.FormattingEnabled = True
        Me.Id_AcompananteComboBox.Location = New System.Drawing.Point(115, 101)
        Me.Id_AcompananteComboBox.Name = "Id_AcompananteComboBox"
        Me.Id_AcompananteComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Id_AcompananteComboBox.TabIndex = 24
        Me.Id_AcompananteComboBox.ValueMember = "Id_Acompanante"
        '
        'RegistroBindingSource
        '
        Me.RegistroBindingSource.DataMember = "Registro"
        Me.RegistroBindingSource.DataSource = Me.SdExpediente
        '
        'RegistroTableAdapter
        '
        Me.RegistroTableAdapter.ClearBeforeFill = True
        '
        'AcompananteBindingSource
        '
        Me.AcompananteBindingSource.DataMember = "Acompanante"
        Me.AcompananteBindingSource.DataSource = Me.SdExpediente
        '
        'AcompananteTableAdapter
        '
        Me.AcompananteTableAdapter.ClearBeforeFill = True
        '
        'PediatraBindingSource
        '
        Me.PediatraBindingSource.DataMember = "Pediatra"
        Me.PediatraBindingSource.DataSource = Me.SdExpediente
        '
        'PediatraTableAdapter
        '
        Me.PediatraTableAdapter.ClearBeforeFill = True
        '
        'FormExpediente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 433)
        Me.Controls.Add(Numero_ExpedienteLabel)
        Me.Controls.Add(Me.Numero_ExpedienteTextBox)
        Me.Controls.Add(Id_RegistroLabel)
        Me.Controls.Add(Me.Id_RegistroComboBox)
        Me.Controls.Add(Id_PediatraLabel)
        Me.Controls.Add(Me.Id_PediatraComboBox)
        Me.Controls.Add(Fecha_Hora_ExpedienteLabel)
        Me.Controls.Add(Me.Fecha_Hora_ExpedienteDateTimePicker)
        Me.Controls.Add(Id_AcompananteLabel)
        Me.Controls.Add(Me.Id_AcompananteComboBox)
        Me.Controls.Add(Me.MedicamentoDataGridView)
        Me.Controls.Add(Me.RecetaDataGridView)
        Me.Controls.Add(Me.DiagnosticoDataGridView)
        Me.Controls.Add(Me.ExpedienteBindingNavigator)
        Me.Name = "FormExpediente"
        Me.Text = "FormExpediente"
        CType(Me.SdExpediente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpedienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpedienteBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExpedienteBindingNavigator.ResumeLayout(False)
        Me.ExpedienteBindingNavigator.PerformLayout()
        CType(Me.DiagnosticoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiagnosticoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecetaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecetaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicamentoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AcompananteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PediatraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents SdExpediente As sdExpediente
    Friend WithEvents ExpedienteBindingSource As BindingSource
    Friend WithEvents ExpedienteTableAdapter As sdExpedienteTableAdapters.ExpedienteTableAdapter
    Friend WithEvents TableAdapterManager As sdExpedienteTableAdapters.TableAdapterManager
    Friend WithEvents ExpedienteBindingNavigator As BindingNavigator
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
    Friend WithEvents ExpedienteBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DiagnosticoTableAdapter As sdExpedienteTableAdapters.DiagnosticoTableAdapter
    Friend WithEvents DiagnosticoBindingSource As BindingSource
    Friend WithEvents DiagnosticoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents RecetaTableAdapter As sdExpedienteTableAdapters.RecetaTableAdapter
    Friend WithEvents RecetaBindingSource As BindingSource
    Friend WithEvents MedicamentoTableAdapter As sdExpedienteTableAdapters.medicamentoTableAdapter
    Friend WithEvents RecetaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents MedicamentoBindingSource As BindingSource
    Friend WithEvents MedicamentoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents Numero_ExpedienteTextBox As TextBox
    Friend WithEvents Id_RegistroComboBox As ComboBox
    Friend WithEvents Id_PediatraComboBox As ComboBox
    Friend WithEvents Fecha_Hora_ExpedienteDateTimePicker As DateTimePicker
    Friend WithEvents Id_AcompananteComboBox As ComboBox
    Friend WithEvents RegistroTableAdapter As sdExpedienteTableAdapters.RegistroTableAdapter
    Friend WithEvents RegistroBindingSource As BindingSource
    Friend WithEvents AcompananteTableAdapter As sdExpedienteTableAdapters.AcompananteTableAdapter
    Friend WithEvents AcompananteBindingSource As BindingSource
    Friend WithEvents PediatraTableAdapter As sdExpedienteTableAdapters.PediatraTableAdapter
    Friend WithEvents PediatraBindingSource As BindingSource
End Class
