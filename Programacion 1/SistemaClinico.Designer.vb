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
        Me.CategoriasDeMedicinaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagosPendientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarPacienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroDePersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroDeAcompañanteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarraDeEliminacionDeDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarDatosDelPacienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDePacientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDePersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeMedicamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeAcompañantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicamentoPorCategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistorialDeMedicamentoSolicitadoPorCodigoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuPrincipal
        '
        Me.mnuPrincipal.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OperacionesToolStripMenuItem, Me.MantenimientoToolStripMenuItem, Me.BarraDeEliminacionDeDatosToolStripMenuItem, Me.InformesToolStripMenuItem})
        Me.mnuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mnuPrincipal.Name = "mnuPrincipal"
        Me.mnuPrincipal.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.mnuPrincipal.Size = New System.Drawing.Size(800, 28)
        Me.mnuPrincipal.TabIndex = 1
        '
        'OperacionesToolStripMenuItem
        '
        Me.OperacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EncargarMedicamentoToolStripMenuItem, Me.PagarToolStripMenuItem, Me.CategoriasDeMedicinaToolStripMenuItem, Me.PagosPendientesToolStripMenuItem})
        Me.OperacionesToolStripMenuItem.Name = "OperacionesToolStripMenuItem"
        Me.OperacionesToolStripMenuItem.Size = New System.Drawing.Size(106, 24)
        Me.OperacionesToolStripMenuItem.Text = "Operaciones"
        '
        'EncargarMedicamentoToolStripMenuItem
        '
        Me.EncargarMedicamentoToolStripMenuItem.Name = "EncargarMedicamentoToolStripMenuItem"
        Me.EncargarMedicamentoToolStripMenuItem.Size = New System.Drawing.Size(249, 26)
        Me.EncargarMedicamentoToolStripMenuItem.Text = "Encargar Medicamento"
        '
        'PagarToolStripMenuItem
        '
        Me.PagarToolStripMenuItem.Name = "PagarToolStripMenuItem"
        Me.PagarToolStripMenuItem.Size = New System.Drawing.Size(249, 26)
        Me.PagarToolStripMenuItem.Text = "Pagar"
        '
        'CategoriasDeMedicinaToolStripMenuItem
        '
        Me.CategoriasDeMedicinaToolStripMenuItem.Name = "CategoriasDeMedicinaToolStripMenuItem"
        Me.CategoriasDeMedicinaToolStripMenuItem.Size = New System.Drawing.Size(249, 26)
        Me.CategoriasDeMedicinaToolStripMenuItem.Text = "Categorias de medicina"
        '
        'PagosPendientesToolStripMenuItem
        '
        Me.PagosPendientesToolStripMenuItem.Name = "PagosPendientesToolStripMenuItem"
        Me.PagosPendientesToolStripMenuItem.Size = New System.Drawing.Size(249, 26)
        Me.PagosPendientesToolStripMenuItem.Text = "Pagos Pendientes"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PacienteToolStripMenuItem, Me.RegistrarPacienteToolStripMenuItem, Me.RegistroDePersonalToolStripMenuItem, Me.MedicamentoToolStripMenuItem, Me.ToolStripMenuItem1, Me.RegistroDeAcompañanteToolStripMenuItem})
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(124, 24)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        '
        'PacienteToolStripMenuItem
        '
        Me.PacienteToolStripMenuItem.Name = "PacienteToolStripMenuItem"
        Me.PacienteToolStripMenuItem.Size = New System.Drawing.Size(263, 26)
        Me.PacienteToolStripMenuItem.Text = "Paciente"
        '
        'RegistrarPacienteToolStripMenuItem
        '
        Me.RegistrarPacienteToolStripMenuItem.Name = "RegistrarPacienteToolStripMenuItem"
        Me.RegistrarPacienteToolStripMenuItem.Size = New System.Drawing.Size(263, 26)
        Me.RegistrarPacienteToolStripMenuItem.Text = "Buscar Paciente"
        '
        'RegistroDePersonalToolStripMenuItem
        '
        Me.RegistroDePersonalToolStripMenuItem.Name = "RegistroDePersonalToolStripMenuItem"
        Me.RegistroDePersonalToolStripMenuItem.Size = New System.Drawing.Size(263, 26)
        Me.RegistroDePersonalToolStripMenuItem.Text = "Registro de personal"
        '
        'MedicamentoToolStripMenuItem
        '
        Me.MedicamentoToolStripMenuItem.Name = "MedicamentoToolStripMenuItem"
        Me.MedicamentoToolStripMenuItem.Size = New System.Drawing.Size(263, 26)
        Me.MedicamentoToolStripMenuItem.Text = "Medicamento"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(263, 26)
        Me.ToolStripMenuItem1.Text = "Formas de Pago"
        '
        'RegistroDeAcompañanteToolStripMenuItem
        '
        Me.RegistroDeAcompañanteToolStripMenuItem.Name = "RegistroDeAcompañanteToolStripMenuItem"
        Me.RegistroDeAcompañanteToolStripMenuItem.Size = New System.Drawing.Size(263, 26)
        Me.RegistroDeAcompañanteToolStripMenuItem.Text = "Registro de acompañante"
        '
        'BarraDeEliminacionDeDatosToolStripMenuItem
        '
        Me.BarraDeEliminacionDeDatosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarDatosDelPacienteToolStripMenuItem})
        Me.BarraDeEliminacionDeDatosToolStripMenuItem.Name = "BarraDeEliminacionDeDatosToolStripMenuItem"
        Me.BarraDeEliminacionDeDatosToolStripMenuItem.Size = New System.Drawing.Size(224, 24)
        Me.BarraDeEliminacionDeDatosToolStripMenuItem.Text = "Barra de eliminacion de Datos"
        '
        'EliminarDatosDelPacienteToolStripMenuItem
        '
        Me.EliminarDatosDelPacienteToolStripMenuItem.Name = "EliminarDatosDelPacienteToolStripMenuItem"
        Me.EliminarDatosDelPacienteToolStripMenuItem.Size = New System.Drawing.Size(273, 26)
        Me.EliminarDatosDelPacienteToolStripMenuItem.Text = "Eliminar Datos del Paciente"
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadoDePacientesToolStripMenuItem, Me.ListadoDePersonalToolStripMenuItem, Me.ListadoDeMedicamentosToolStripMenuItem, Me.ListadoDeAcompañantesToolStripMenuItem, Me.MedicamentoPorCategoriaToolStripMenuItem, Me.HistorialDeMedicamentoSolicitadoPorCodigoToolStripMenuItem, Me.ListadoDeProveedoresToolStripMenuItem})
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(81, 24)
        Me.InformesToolStripMenuItem.Text = "Informes"
        '
        'ListadoDePacientesToolStripMenuItem
        '
        Me.ListadoDePacientesToolStripMenuItem.Name = "ListadoDePacientesToolStripMenuItem"
        Me.ListadoDePacientesToolStripMenuItem.Size = New System.Drawing.Size(412, 26)
        Me.ListadoDePacientesToolStripMenuItem.Text = "Listado de pacientes"
        '
        'ListadoDePersonalToolStripMenuItem
        '
        Me.ListadoDePersonalToolStripMenuItem.Name = "ListadoDePersonalToolStripMenuItem"
        Me.ListadoDePersonalToolStripMenuItem.Size = New System.Drawing.Size(412, 26)
        Me.ListadoDePersonalToolStripMenuItem.Text = "Listado de personal "
        '
        'ListadoDeMedicamentosToolStripMenuItem
        '
        Me.ListadoDeMedicamentosToolStripMenuItem.Name = "ListadoDeMedicamentosToolStripMenuItem"
        Me.ListadoDeMedicamentosToolStripMenuItem.Size = New System.Drawing.Size(412, 26)
        Me.ListadoDeMedicamentosToolStripMenuItem.Text = "Listado de medicamentos "
        '
        'ListadoDeAcompañantesToolStripMenuItem
        '
        Me.ListadoDeAcompañantesToolStripMenuItem.Name = "ListadoDeAcompañantesToolStripMenuItem"
        Me.ListadoDeAcompañantesToolStripMenuItem.Size = New System.Drawing.Size(412, 26)
        Me.ListadoDeAcompañantesToolStripMenuItem.Text = "Listado de acompañantes"
        '
        'MedicamentoPorCategoriaToolStripMenuItem
        '
        Me.MedicamentoPorCategoriaToolStripMenuItem.Name = "MedicamentoPorCategoriaToolStripMenuItem"
        Me.MedicamentoPorCategoriaToolStripMenuItem.Size = New System.Drawing.Size(412, 26)
        Me.MedicamentoPorCategoriaToolStripMenuItem.Text = "Lis.Medicamento por categoria"
        '
        'HistorialDeMedicamentoSolicitadoPorCodigoToolStripMenuItem
        '
        Me.HistorialDeMedicamentoSolicitadoPorCodigoToolStripMenuItem.Name = "HistorialDeMedicamentoSolicitadoPorCodigoToolStripMenuItem"
        Me.HistorialDeMedicamentoSolicitadoPorCodigoToolStripMenuItem.Size = New System.Drawing.Size(412, 26)
        Me.HistorialDeMedicamentoSolicitadoPorCodigoToolStripMenuItem.Text = "Historial de Medicamento solicitado por codigo"
        '
        'ListadoDeProveedoresToolStripMenuItem
        '
        Me.ListadoDeProveedoresToolStripMenuItem.Name = "ListadoDeProveedoresToolStripMenuItem"
        Me.ListadoDeProveedoresToolStripMenuItem.Size = New System.Drawing.Size(412, 26)
        Me.ListadoDeProveedoresToolStripMenuItem.Text = "Listado de proveedores "
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
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
    Friend WithEvents CategoriasDeMedicinaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarraDeEliminacionDeDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarDatosDelPacienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InformesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDePacientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDePersonalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeMedicamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeAcompañantesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedicamentoPorCategoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistorialDeMedicamentoSolicitadoPorCodigoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagosPendientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroDeAcompañanteToolStripMenuItem As ToolStripMenuItem
End Class
