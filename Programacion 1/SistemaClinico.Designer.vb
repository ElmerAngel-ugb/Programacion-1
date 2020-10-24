<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SistemaClinico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SistemaClinico))
        Me.mnuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.OperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncargarMedicamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarPacienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroDePersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuPrincipal
        '
        Me.mnuPrincipal.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OperacionesToolStripMenuItem, Me.MantenimientoToolStripMenuItem})
        Me.mnuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mnuPrincipal.Name = "mnuPrincipal"
        Me.mnuPrincipal.Size = New System.Drawing.Size(800, 28)
        Me.mnuPrincipal.TabIndex = 1
        '
        'OperacionesToolStripMenuItem
        '
        Me.OperacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EncargarMedicamentoToolStripMenuItem, Me.PagarToolStripMenuItem})
        Me.OperacionesToolStripMenuItem.Name = "OperacionesToolStripMenuItem"
        Me.OperacionesToolStripMenuItem.Size = New System.Drawing.Size(106, 24)
        Me.OperacionesToolStripMenuItem.Text = "Operaciones"
        '
        'EncargarMedicamentoToolStripMenuItem
        '
        Me.EncargarMedicamentoToolStripMenuItem.Name = "EncargarMedicamentoToolStripMenuItem"
        Me.EncargarMedicamentoToolStripMenuItem.Size = New System.Drawing.Size(246, 26)
        Me.EncargarMedicamentoToolStripMenuItem.Text = "Encargar Medicamento"
        '
        'PagarToolStripMenuItem
        '
        Me.PagarToolStripMenuItem.Name = "PagarToolStripMenuItem"
        Me.PagarToolStripMenuItem.Size = New System.Drawing.Size(246, 26)
        Me.PagarToolStripMenuItem.Text = "Pagar"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PacienteToolStripMenuItem, Me.RegistrarPacienteToolStripMenuItem, Me.RegistroDePersonalToolStripMenuItem, Me.MedicamentoToolStripMenuItem})
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(124, 24)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        '
        'PacienteToolStripMenuItem
        '
        Me.PacienteToolStripMenuItem.Name = "PacienteToolStripMenuItem"
        Me.PacienteToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.PacienteToolStripMenuItem.Text = "Paciente"
        '
        'RegistrarPacienteToolStripMenuItem
        '
        Me.RegistrarPacienteToolStripMenuItem.Name = "RegistrarPacienteToolStripMenuItem"
        Me.RegistrarPacienteToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.RegistrarPacienteToolStripMenuItem.Text = "Buscar Paciente"
        '
        'RegistroDePersonalToolStripMenuItem
        '
        Me.RegistroDePersonalToolStripMenuItem.Name = "RegistroDePersonalToolStripMenuItem"
        Me.RegistroDePersonalToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.RegistroDePersonalToolStripMenuItem.Text = "Registro de personal"
        '
        'MedicamentoToolStripMenuItem
        '
        Me.MedicamentoToolStripMenuItem.Name = "MedicamentoToolStripMenuItem"
        Me.MedicamentoToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.MedicamentoToolStripMenuItem.Text = "Medicamento"
        '
        'SistemaClinico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Programacion_1.My.Resources.Recursos.Hospital1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.mnuPrincipal)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "SistemaClinico"
        Me.Text = "SistemaClinico"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuPrincipal.ResumeLayout(False)
        Me.mnuPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuPrincipal As MenuStrip
    Friend WithEvents OperacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncargarMedicamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PacienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarPacienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroDePersonalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedicamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagarToolStripMenuItem As ToolStripMenuItem
End Class
