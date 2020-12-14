<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.encargar_medicamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.sistemaclinicodbDataSet = New Programacion_1.sistemaclinicodbDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.encargar_medicamentoTableAdapter = New Programacion_1.sistemaclinicodbDataSetTableAdapters.encargar_medicamentoTableAdapter()
        CType(Me.encargar_medicamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sistemaclinicodbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'encargar_medicamentoBindingSource
        '
        Me.encargar_medicamentoBindingSource.DataMember = "encargar_medicamento"
        Me.encargar_medicamentoBindingSource.DataSource = Me.sistemaclinicodbDataSet
        '
        'sistemaclinicodbDataSet
        '
        Me.sistemaclinicodbDataSet.DataSetName = "sistemaclinicodbDataSet"
        Me.sistemaclinicodbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "dshistoMedicamento"
        ReportDataSource1.Value = Me.encargar_medicamentoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Programacion_1.ifmHistorialdeMedi.Solicitado.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(16, 15)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1058, 710)
        Me.ReportViewer1.TabIndex = 0
        '
        'encargar_medicamentoTableAdapter
        '
        Me.encargar_medicamentoTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 740)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Historial de medicamentos solicitados "
        CType(Me.encargar_medicamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sistemaclinicodbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents encargar_medicamentoBindingSource As BindingSource
    Friend WithEvents sistemaclinicodbDataSet As sistemaclinicodbDataSet
    Friend WithEvents encargar_medicamentoTableAdapter As sistemaclinicodbDataSetTableAdapters.encargar_medicamentoTableAdapter
End Class
