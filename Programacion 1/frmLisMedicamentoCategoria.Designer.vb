<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLisMedicamentoCategoria
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.sistemaclinicodbDataSet = New Programacion_1.sistemaclinicodbDataSet()
        Me.categoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.categoriasTableAdapter = New Programacion_1.sistemaclinicodbDataSetTableAdapters.categoriasTableAdapter()
        Me.productosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.productosTableAdapter = New Programacion_1.sistemaclinicodbDataSetTableAdapters.productosTableAdapter()
        CType(Me.sistemaclinicodbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.categoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "dscategoriamedicamentos"
        ReportDataSource1.Value = Me.categoriasBindingSource
        ReportDataSource2.Name = "dsmedicamentoscategoria"
        ReportDataSource2.Value = Me.productosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Programacion_1.ifmListademedicamentoscategoria.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(886, 607)
        Me.ReportViewer1.TabIndex = 0
        '
        'sistemaclinicodbDataSet
        '
        Me.sistemaclinicodbDataSet.DataSetName = "sistemaclinicodbDataSet"
        Me.sistemaclinicodbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'categoriasBindingSource
        '
        Me.categoriasBindingSource.DataMember = "categorias"
        Me.categoriasBindingSource.DataSource = Me.sistemaclinicodbDataSet
        '
        'categoriasTableAdapter
        '
        Me.categoriasTableAdapter.ClearBeforeFill = True
        '
        'productosBindingSource
        '
        Me.productosBindingSource.DataMember = "productos"
        Me.productosBindingSource.DataSource = Me.sistemaclinicodbDataSet
        '
        'productosTableAdapter
        '
        Me.productosTableAdapter.ClearBeforeFill = True
        '
        'frmLisMedicamentoCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 645)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmLisMedicamentoCategoria"
        Me.Text = "Lista de Medicamento por Categoria"
        CType(Me.sistemaclinicodbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.categoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents categoriasBindingSource As BindingSource
    Friend WithEvents sistemaclinicodbDataSet As sistemaclinicodbDataSet
    Friend WithEvents productosBindingSource As BindingSource
    Friend WithEvents categoriasTableAdapter As sistemaclinicodbDataSetTableAdapters.categoriasTableAdapter
    Friend WithEvents productosTableAdapter As sistemaclinicodbDataSetTableAdapters.productosTableAdapter
End Class
