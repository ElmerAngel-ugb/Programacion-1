<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadodeAcompañante
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
        Me.AcompananteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.sistemaclinicodbDataSet = New Programacion_1.sistemaclinicodbDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.AcompananteTableAdapter = New Programacion_1.sistemaclinicodbDataSetTableAdapters.AcompananteTableAdapter()
        CType(Me.AcompananteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sistemaclinicodbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AcompananteBindingSource
        '
        Me.AcompananteBindingSource.DataMember = "Acompanante"
        Me.AcompananteBindingSource.DataSource = Me.sistemaclinicodbDataSet
        '
        'sistemaclinicodbDataSet
        '
        Me.sistemaclinicodbDataSet.DataSetName = "sistemaclinicodbDataSet"
        Me.sistemaclinicodbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "dslistadodeAcompañante"
        ReportDataSource1.Value = Me.AcompananteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Programacion_1.ifmListadodeAcompañantes.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(16, 15)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1101, 656)
        Me.ReportViewer1.TabIndex = 0
        '
        'AcompananteTableAdapter
        '
        Me.AcompananteTableAdapter.ClearBeforeFill = True
        '
        'frmListadodeAcompañante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1133, 686)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmListadodeAcompañante"
        Me.Text = "Listado de Acompañante"
        CType(Me.AcompananteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sistemaclinicodbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents AcompananteBindingSource As BindingSource
    Friend WithEvents sistemaclinicodbDataSet As sistemaclinicodbDataSet
    Friend WithEvents AcompananteTableAdapter As sistemaclinicodbDataSetTableAdapters.AcompananteTableAdapter
End Class
