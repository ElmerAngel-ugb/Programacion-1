<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmrListaPersonal
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
        Me.registrodepersonalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsPersonal = New Programacion_1.dsPersonal()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.registrodepersonalTableAdapter = New Programacion_1.dsPersonalTableAdapters.registrodepersonalTableAdapter()
        CType(Me.registrodepersonalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'registrodepersonalBindingSource
        '
        Me.registrodepersonalBindingSource.DataMember = "registrodepersonal"
        Me.registrodepersonalBindingSource.DataSource = Me.dsPersonal
        '
        'dsPersonal
        '
        Me.dsPersonal.DataSetName = "dsPersonal"
        Me.dsPersonal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "dsListadepersonal"
        ReportDataSource1.Value = Me.registrodepersonalBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Programacion_1.ifmPersonal.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(16, 15)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1282, 742)
        Me.ReportViewer1.TabIndex = 0
        '
        'registrodepersonalTableAdapter
        '
        Me.registrodepersonalTableAdapter.ClearBeforeFill = True
        '
        'fmrListaPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1315, 772)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "fmrListaPersonal"
        Me.Text = "Lista de Personal"
        CType(Me.registrodepersonalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents registrodepersonalBindingSource As BindingSource
    Friend WithEvents dsPersonal As dsPersonal
    Friend WithEvents registrodepersonalTableAdapter As dsPersonalTableAdapters.registrodepersonalTableAdapter
End Class
