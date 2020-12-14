<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmImprimirPago
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DsPagar = New Programacion_1.dsPagar()
        Me.bsPagar = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagarTableAdapter = New Programacion_1.dsPagarTableAdapters.PagarTableAdapter()
        Me.bsencargar_medicamento = New System.Windows.Forms.BindingSource(Me.components)
        Me.Encargar_medicamentoTableAdapter = New Programacion_1.dsPagarTableAdapters.encargar_medicamentoTableAdapter()
        Me.bsPaciente = New System.Windows.Forms.BindingSource(Me.components)
        Me.PacienteTableAdapter = New Programacion_1.dsPagarTableAdapters.pacienteTableAdapter()
        Me.bsFormadePago = New System.Windows.Forms.BindingSource(Me.components)
        Me.FormadePagoTableAdapter = New Programacion_1.dsPagarTableAdapters.FormadePagoTableAdapter()
        CType(Me.DsPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsencargar_medicamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsFormadePago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "encargar_medicamento"
        ReportDataSource1.Value = Me.bsencargar_medicamento
        ReportDataSource2.Name = "paciente"
        ReportDataSource2.Value = Me.bsPaciente
        ReportDataSource3.Name = "Pagar"
        ReportDataSource3.Value = Me.bsPagar
        ReportDataSource4.Name = "FormasdePago"
        ReportDataSource4.Value = Me.bsFormadePago
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Programacion_1.ImprimirPago.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(776, 426)
        Me.ReportViewer1.TabIndex = 0
        '
        'DsPagar
        '
        Me.DsPagar.DataSetName = "dsPagar"
        Me.DsPagar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bsPagar
        '
        Me.bsPagar.DataMember = "Pagar"
        Me.bsPagar.DataSource = Me.DsPagar
        '
        'PagarTableAdapter
        '
        Me.PagarTableAdapter.ClearBeforeFill = True
        '
        'bsencargar_medicamento
        '
        Me.bsencargar_medicamento.DataMember = "encargar_medicamento"
        Me.bsencargar_medicamento.DataSource = Me.DsPagar
        '
        'Encargar_medicamentoTableAdapter
        '
        Me.Encargar_medicamentoTableAdapter.ClearBeforeFill = True
        '
        'bsPaciente
        '
        Me.bsPaciente.DataMember = "paciente"
        Me.bsPaciente.DataSource = Me.DsPagar
        '
        'PacienteTableAdapter
        '
        Me.PacienteTableAdapter.ClearBeforeFill = True
        '
        'bsFormadePago
        '
        Me.bsFormadePago.DataMember = "FormadePago"
        Me.bsFormadePago.DataSource = Me.DsPagar
        '
        'FormadePagoTableAdapter
        '
        Me.FormadePagoTableAdapter.ClearBeforeFill = True
        '
        'FrmImprimirPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmImprimirPago"
        Me.Text = "ImprimirPago"
        CType(Me.DsPagar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPagar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsencargar_medicamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsFormadePago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DsPagar As dsPagar
    Friend WithEvents bsPagar As BindingSource
    Friend WithEvents PagarTableAdapter As dsPagarTableAdapters.PagarTableAdapter
    Friend WithEvents bsencargar_medicamento As BindingSource
    Friend WithEvents Encargar_medicamentoTableAdapter As dsPagarTableAdapters.encargar_medicamentoTableAdapter
    Friend WithEvents bsPaciente As BindingSource
    Friend WithEvents PacienteTableAdapter As dsPagarTableAdapters.pacienteTableAdapter
    Friend WithEvents bsFormadePago As BindingSource
    Friend WithEvents FormadePagoTableAdapter As dsPagarTableAdapters.FormadePagoTableAdapter
End Class
