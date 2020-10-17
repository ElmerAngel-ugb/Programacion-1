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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.OperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrodelPersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarMedicamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncargarMedicamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 28)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuPrincipal
        '
        Me.mnuPrincipal.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OperacionesToolStripMenuItem})
        Me.mnuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mnuPrincipal.Name = "mnuPrincipal"
        Me.mnuPrincipal.Size = New System.Drawing.Size(800, 28)
        Me.mnuPrincipal.TabIndex = 1
        '
        'OperacionesToolStripMenuItem
        '
        Me.OperacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrodelPersonalToolStripMenuItem, Me.AgregarMedicamentoToolStripMenuItem, Me.EncargarMedicamentoToolStripMenuItem})
        Me.OperacionesToolStripMenuItem.Name = "OperacionesToolStripMenuItem"
        Me.OperacionesToolStripMenuItem.Size = New System.Drawing.Size(106, 24)
        Me.OperacionesToolStripMenuItem.Text = "Operaciones"
        '
        'RegistrodelPersonalToolStripMenuItem
        '
        Me.RegistrodelPersonalToolStripMenuItem.Name = "RegistrodelPersonalToolStripMenuItem"
        Me.RegistrodelPersonalToolStripMenuItem.Size = New System.Drawing.Size(246, 26)
        Me.RegistrodelPersonalToolStripMenuItem.Text = "Registro del Personal"
        '
        'AgregarMedicamentoToolStripMenuItem
        '
        Me.AgregarMedicamentoToolStripMenuItem.Name = "AgregarMedicamentoToolStripMenuItem"
        Me.AgregarMedicamentoToolStripMenuItem.Size = New System.Drawing.Size(246, 26)
        Me.AgregarMedicamentoToolStripMenuItem.Text = "Agregar Medicamento"
        '
        'EncargarMedicamentoToolStripMenuItem
        '
        Me.EncargarMedicamentoToolStripMenuItem.Name = "EncargarMedicamentoToolStripMenuItem"
        Me.EncargarMedicamentoToolStripMenuItem.Size = New System.Drawing.Size(246, 26)
        Me.EncargarMedicamentoToolStripMenuItem.Text = "Encargar Medicamento"
        '
        'SistemaClinico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.mnuPrincipal)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "SistemaClinico"
        Me.Text = "SistemaClinico"
        Me.mnuPrincipal.ResumeLayout(False)
        Me.mnuPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuPrincipal As MenuStrip
    Friend WithEvents OperacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrodelPersonalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarMedicamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncargarMedicamentoToolStripMenuItem As ToolStripMenuItem
End Class
