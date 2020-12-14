<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegistro_Acompañante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRegistro_Acompañante))
        Dim CodigoLabel1 As System.Windows.Forms.Label
        Dim NombreLabel1 As System.Windows.Forms.Label
        Dim ApellidoLabel1 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim SexoLabel1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Me.SdExpediente = New Programacion_1.sdExpediente()
        Me.AcompananteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AcompananteTableAdapter = New Programacion_1.sdExpedienteTableAdapters.AcompananteTableAdapter()
        Me.TableAdapterManager = New Programacion_1.sdExpedienteTableAdapters.TableAdapterManager()
        Me.AcompananteBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.AcompananteBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CodigoTextBox1 = New System.Windows.Forms.TextBox()
        Me.NombreTextBox1 = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SexoTextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.RegistroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistroTableAdapter = New Programacion_1.sdExpedienteTableAdapters.RegistroTableAdapter()
        Me.RegistroDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CodigoLabel1 = New System.Windows.Forms.Label()
        NombreLabel1 = New System.Windows.Forms.Label()
        ApellidoLabel1 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        SexoLabel1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.SdExpediente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AcompananteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AcompananteBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AcompananteBindingNavigator.SuspendLayout()
        CType(Me.RegistroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SdExpediente
        '
        Me.SdExpediente.DataSetName = "sdExpediente"
        Me.SdExpediente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.AcompananteTableAdapter = Me.AcompananteTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DiagnosticoTableAdapter = Nothing
        Me.TableAdapterManager.ExpedienteTableAdapter = Nothing
        Me.TableAdapterManager.medicamentoTableAdapter = Nothing
        Me.TableAdapterManager.PediatraTableAdapter = Nothing
        Me.TableAdapterManager.RecetaTableAdapter = Nothing
        Me.TableAdapterManager.RegistroTableAdapter = Me.RegistroTableAdapter
        Me.TableAdapterManager.UpdateOrder = Programacion_1.sdExpedienteTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AcompananteBindingNavigator
        '
        Me.AcompananteBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AcompananteBindingNavigator.BindingSource = Me.AcompananteBindingSource
        Me.AcompananteBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AcompananteBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AcompananteBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AcompananteBindingNavigatorSaveItem})
        Me.AcompananteBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AcompananteBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AcompananteBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AcompananteBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AcompananteBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AcompananteBindingNavigator.Name = "AcompananteBindingNavigator"
        Me.AcompananteBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AcompananteBindingNavigator.Size = New System.Drawing.Size(685, 25)
        Me.AcompananteBindingNavigator.TabIndex = 0
        Me.AcompananteBindingNavigator.Text = "BindingNavigator1"
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
        'AcompananteBindingNavigatorSaveItem
        '
        Me.AcompananteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AcompananteBindingNavigatorSaveItem.Image = CType(resources.GetObject("AcompananteBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AcompananteBindingNavigatorSaveItem.Name = "AcompananteBindingNavigatorSaveItem"
        Me.AcompananteBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.AcompananteBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CodigoLabel1
        '
        CodigoLabel1.AutoSize = True
        CodigoLabel1.Location = New System.Drawing.Point(28, 54)
        CodigoLabel1.Name = "CodigoLabel1"
        CodigoLabel1.Size = New System.Drawing.Size(43, 13)
        CodigoLabel1.TabIndex = 34
        CodigoLabel1.Text = "Codigo:"
        '
        'CodigoTextBox1
        '
        Me.CodigoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AcompananteBindingSource, "Codigo", True))
        Me.CodigoTextBox1.Location = New System.Drawing.Point(77, 54)
        Me.CodigoTextBox1.Name = "CodigoTextBox1"
        Me.CodigoTextBox1.Size = New System.Drawing.Size(70, 20)
        Me.CodigoTextBox1.TabIndex = 35
        '
        'NombreLabel1
        '
        NombreLabel1.AutoSize = True
        NombreLabel1.Location = New System.Drawing.Point(24, 103)
        NombreLabel1.Name = "NombreLabel1"
        NombreLabel1.Size = New System.Drawing.Size(47, 13)
        NombreLabel1.TabIndex = 36
        NombreLabel1.Text = "Nombre:"
        '
        'NombreTextBox1
        '
        Me.NombreTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AcompananteBindingSource, "Nombre", True))
        Me.NombreTextBox1.Location = New System.Drawing.Point(77, 96)
        Me.NombreTextBox1.Name = "NombreTextBox1"
        Me.NombreTextBox1.Size = New System.Drawing.Size(165, 20)
        Me.NombreTextBox1.TabIndex = 37
        '
        'ApellidoLabel1
        '
        ApellidoLabel1.AutoSize = True
        ApellidoLabel1.Location = New System.Drawing.Point(24, 153)
        ApellidoLabel1.Name = "ApellidoLabel1"
        ApellidoLabel1.Size = New System.Drawing.Size(47, 13)
        ApellidoLabel1.TabIndex = 38
        ApellidoLabel1.Text = "Apellido:"
        '
        'ApellidoTextBox1
        '
        Me.ApellidoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AcompananteBindingSource, "Apellido", True))
        Me.ApellidoTextBox1.Location = New System.Drawing.Point(77, 142)
        Me.ApellidoTextBox1.Name = "ApellidoTextBox1"
        Me.ApellidoTextBox1.Size = New System.Drawing.Size(165, 20)
        Me.ApellidoTextBox1.TabIndex = 39
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(414, 53)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(35, 13)
        Label1.TabIndex = 40
        Label1.Text = "Edad:"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AcompananteBindingSource, "Edad", True))
        Me.TextBox1.Location = New System.Drawing.Point(455, 50)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(72, 20)
        Me.TextBox1.TabIndex = 41
        '
        'SexoLabel1
        '
        SexoLabel1.AutoSize = True
        SexoLabel1.Location = New System.Drawing.Point(28, 200)
        SexoLabel1.Name = "SexoLabel1"
        SexoLabel1.Size = New System.Drawing.Size(34, 13)
        SexoLabel1.TabIndex = 42
        SexoLabel1.Text = "Sexo:"
        '
        'SexoTextBox1
        '
        Me.SexoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AcompananteBindingSource, "Sexo", True))
        Me.SexoTextBox1.Location = New System.Drawing.Point(68, 192)
        Me.SexoTextBox1.Name = "SexoTextBox1"
        Me.SexoTextBox1.Size = New System.Drawing.Size(130, 20)
        Me.SexoTextBox1.TabIndex = 43
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(407, 106)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(52, 13)
        Label2.TabIndex = 44
        Label2.Text = "Telefono:"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AcompananteBindingSource, "Telefono", True))
        Me.TextBox2.Location = New System.Drawing.Point(465, 103)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(107, 20)
        Me.TextBox2.TabIndex = 45
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(408, 158)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(35, 13)
        Label3.TabIndex = 46
        Label3.Text = "Email:"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AcompananteBindingSource, "Email", True))
        Me.TextBox3.Location = New System.Drawing.Point(449, 155)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(198, 20)
        Me.TextBox3.TabIndex = 47
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(407, 208)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(55, 13)
        Label4.TabIndex = 48
        Label4.Text = "Direccion:"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AcompananteBindingSource, "Direccion", True))
        Me.TextBox4.Location = New System.Drawing.Point(468, 205)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(179, 20)
        Me.TextBox4.TabIndex = 49
        '
        'RegistroBindingSource
        '
        Me.RegistroBindingSource.DataMember = "FK_Registro_Acompanante"
        Me.RegistroBindingSource.DataSource = Me.AcompananteBindingSource
        '
        'RegistroTableAdapter
        '
        Me.RegistroTableAdapter.ClearBeforeFill = True
        '
        'RegistroDataGridView
        '
        Me.RegistroDataGridView.AutoGenerateColumns = False
        Me.RegistroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RegistroDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.RegistroDataGridView.DataSource = Me.RegistroBindingSource
        Me.RegistroDataGridView.Location = New System.Drawing.Point(27, 234)
        Me.RegistroDataGridView.Name = "RegistroDataGridView"
        Me.RegistroDataGridView.Size = New System.Drawing.Size(646, 220)
        Me.RegistroDataGridView.TabIndex = 49
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_Registro"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_Registro"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Codigo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 65
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 130
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Apellido"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Apellido"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 130
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Sexo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Sexo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Tipo_Sangre"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Tipo_Sangre"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 75
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Fecha_Nacimiento"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Fecha_Nacimiento"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 110
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Id_Acompanante"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Id_Acompanante"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'FormRegistro_Acompañante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(685, 463)
        Me.Controls.Add(Me.RegistroDataGridView)
        Me.Controls.Add(CodigoLabel1)
        Me.Controls.Add(Me.CodigoTextBox1)
        Me.Controls.Add(NombreLabel1)
        Me.Controls.Add(Me.NombreTextBox1)
        Me.Controls.Add(ApellidoLabel1)
        Me.Controls.Add(Me.ApellidoTextBox1)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(SexoLabel1)
        Me.Controls.Add(Me.SexoTextBox1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.AcompananteBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormRegistro_Acompañante"
        Me.Text = "FormRegistro_Acompañante"
        CType(Me.SdExpediente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AcompananteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AcompananteBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AcompananteBindingNavigator.ResumeLayout(False)
        Me.AcompananteBindingNavigator.PerformLayout()
        CType(Me.RegistroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SdExpediente As sdExpediente
    Friend WithEvents AcompananteBindingSource As BindingSource
    Friend WithEvents AcompananteTableAdapter As sdExpedienteTableAdapters.AcompananteTableAdapter
    Friend WithEvents TableAdapterManager As sdExpedienteTableAdapters.TableAdapterManager
    Friend WithEvents AcompananteBindingNavigator As BindingNavigator
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
    Friend WithEvents AcompananteBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents RegistroTableAdapter As sdExpedienteTableAdapters.RegistroTableAdapter
    Friend WithEvents CodigoTextBox1 As TextBox
    Friend WithEvents NombreTextBox1 As TextBox
    Friend WithEvents ApellidoTextBox1 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents SexoTextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents RegistroBindingSource As BindingSource
    Friend WithEvents RegistroDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
