<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadeproveedores
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.sistemaclinicodbDataSet = New Programacion_1.sistemaclinicodbDataSet()
        Me.proveedormedicamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.proveedormedicamentosTableAdapter = New Programacion_1.sistemaclinicodbDataSetTableAdapters.proveedormedicamentosTableAdapter()
        CType(Me.sistemaclinicodbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.proveedormedicamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "dslistaProveedormedica"
        ReportDataSource1.Value = Me.proveedormedicamentosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Programacion_1.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(33, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(829, 558)
        Me.ReportViewer1.TabIndex = 0
        '
        'sistemaclinicodbDataSet
        '
        Me.sistemaclinicodbDataSet.DataSetName = "sistemaclinicodbDataSet"
        Me.sistemaclinicodbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'proveedormedicamentosBindingSource
        '
        Me.proveedormedicamentosBindingSource.DataMember = "proveedormedicamentos"
        Me.proveedormedicamentosBindingSource.DataSource = Me.sistemaclinicodbDataSet
        '
        'proveedormedicamentosTableAdapter
        '
        Me.proveedormedicamentosTableAdapter.ClearBeforeFill = True
        '
        'frmListadeproveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 611)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmListadeproveedores"
        Me.Text = "Lista de proveedores"
        CType(Me.sistemaclinicodbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.proveedormedicamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents proveedormedicamentosBindingSource As BindingSource
    Friend WithEvents sistemaclinicodbDataSet As sistemaclinicodbDataSet
    Friend WithEvents proveedormedicamentosTableAdapter As sistemaclinicodbDataSetTableAdapters.proveedormedicamentosTableAdapter
End Class
