<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmrListadePacientes
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
        Me.pacienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsPersonal = New Programacion_1.dsPersonal()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.pacienteTableAdapter = New Programacion_1.dsPersonalTableAdapters.pacienteTableAdapter()
        CType(Me.pacienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pacienteBindingSource
        '
        Me.pacienteBindingSource.DataMember = "paciente"
        Me.pacienteBindingSource.DataSource = Me.dsPersonal
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
        ReportDataSource1.Name = "dsListadepacientes"
        ReportDataSource1.Value = Me.pacienteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Programacion_1.ifmPaciente.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(28, 15)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1123, 697)
        Me.ReportViewer1.TabIndex = 0
        '
        'pacienteTableAdapter
        '
        Me.pacienteTableAdapter.ClearBeforeFill = True
        '
        'fmrListadePacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1168, 727)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "fmrListadePacientes"
        Me.Text = "Lista de Pacientes"
        CType(Me.pacienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents pacienteBindingSource As BindingSource
    Friend WithEvents dsPersonal As dsPersonal
    Friend WithEvents pacienteTableAdapter As dsPersonalTableAdapters.pacienteTableAdapter
End Class
