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
        Me.MedicamentoBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedicamentoTableAdapter1 = New Programacion_1.sdExpedienteTableAdapters.medicamentoTableAdapter()
        Me.SdExpediente = New Programacion_1.sdExpediente()
        Me.ExpedienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExpedienteTableAdapter = New Programacion_1.sdExpedienteTableAdapters.ExpedienteTableAdapter()
        Me.TableAdapterManager = New Programacion_1.sdExpedienteTableAdapters.TableAdapterManager()
        Me.DiagnosticoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DiagnosticoTableAdapter = New Programacion_1.sdExpedienteTableAdapters.DiagnosticoTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecetaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecetaTableAdapter = New Programacion_1.sdExpedienteTableAdapters.RecetaTableAdapter()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.MedicamentoBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SdExpediente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpedienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiagnosticoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecetaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MedicamentoTableAdapter1
        '
        Me.MedicamentoTableAdapter1.ClearBeforeFill = True
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
        Me.TableAdapterManager.AcompananteTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DiagnosticoTableAdapter = Nothing
        Me.TableAdapterManager.ExpedienteTableAdapter = Me.ExpedienteTableAdapter
        Me.TableAdapterManager.medicamentoTableAdapter = Me.MedicamentoTableAdapter1
        Me.TableAdapterManager.PediatraTableAdapter = Nothing
        Me.TableAdapterManager.RecetaTableAdapter = Nothing
        Me.TableAdapterManager.RegistroTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Programacion_1.sdExpedienteTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'RecetaBindingSource
        '
        Me.RecetaBindingSource.DataMember = "FK_Receta_Diagnostico"
        Me.RecetaBindingSource.DataSource = Me.DiagnosticoBindingSource
        '
        'RecetaTableAdapter
        '
        Me.RecetaTableAdapter.ClearBeforeFill = True
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
        'MedicamentoBindingSource
        '
        Me.MedicamentoBindingSource.DataMember = "FK_medicamento_Receta"
        Me.MedicamentoBindingSource.DataSource = Me.RecetaBindingSource
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
        'FormExpediente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 574)
        Me.Name = "FormExpediente"
        Me.Text = "FormExpediente"
        CType(Me.MedicamentoBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SdExpediente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpedienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiagnosticoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecetaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MedicamentoBindingSource2 As BindingSource
    Friend WithEvents MedicamentoTableAdapter1 As sdExpedienteTableAdapters.medicamentoTableAdapter
    Friend WithEvents SdExpediente As sdExpediente
    Friend WithEvents ExpedienteBindingSource As BindingSource
    Friend WithEvents ExpedienteTableAdapter As sdExpedienteTableAdapters.ExpedienteTableAdapter
    Friend WithEvents TableAdapterManager As sdExpedienteTableAdapters.TableAdapterManager
    Friend WithEvents DiagnosticoBindingSource As BindingSource
    Friend WithEvents DiagnosticoTableAdapter As sdExpedienteTableAdapters.DiagnosticoTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents RecetaBindingSource As BindingSource
    Friend WithEvents RecetaTableAdapter As sdExpedienteTableAdapters.RecetaTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents MedicamentoBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
End Class
