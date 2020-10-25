<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmrEliminardatosdelpaciente
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtidPaciente = New System.Windows.Forms.TextBox()
        Me.lblidPaciente = New System.Windows.Forms.Label()
        Me.txtBuscaridPaciente = New System.Windows.Forms.TextBox()
        Me.btnEliminarPaciente = New System.Windows.Forms.Button()
        Me.TextNombredelPaciente = New System.Windows.Forms.TextBox()
        Me.lblNombredelPaciente = New System.Windows.Forms.Label()
        Me.btnBuscaridPaciente = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtidPaciente)
        Me.GroupBox1.Controls.Add(Me.lblidPaciente)
        Me.GroupBox1.Controls.Add(Me.txtBuscaridPaciente)
        Me.GroupBox1.Controls.Add(Me.btnEliminarPaciente)
        Me.GroupBox1.Controls.Add(Me.TextNombredelPaciente)
        Me.GroupBox1.Controls.Add(Me.lblNombredelPaciente)
        Me.GroupBox1.Controls.Add(Me.btnBuscaridPaciente)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 426)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Eliminar "
        '
        'txtidPaciente
        '
        Me.txtidPaciente.Location = New System.Drawing.Point(222, 185)
        Me.txtidPaciente.Name = "txtidPaciente"
        Me.txtidPaciente.Size = New System.Drawing.Size(111, 26)
        Me.txtidPaciente.TabIndex = 12
        '
        'lblidPaciente
        '
        Me.lblidPaciente.AutoSize = True
        Me.lblidPaciente.Location = New System.Drawing.Point(56, 185)
        Me.lblidPaciente.Name = "lblidPaciente"
        Me.lblidPaciente.Size = New System.Drawing.Size(153, 20)
        Me.lblidPaciente.TabIndex = 11
        Me.lblidPaciente.Text = "Codigo del paciente:"
        '
        'txtBuscaridPaciente
        '
        Me.txtBuscaridPaciente.Location = New System.Drawing.Point(385, 72)
        Me.txtBuscaridPaciente.Name = "txtBuscaridPaciente"
        Me.txtBuscaridPaciente.Size = New System.Drawing.Size(141, 26)
        Me.txtBuscaridPaciente.TabIndex = 10
        Me.txtBuscaridPaciente.Text = "Buscar IdPaciente"
        '
        'btnEliminarPaciente
        '
        Me.btnEliminarPaciente.Location = New System.Drawing.Point(287, 312)
        Me.btnEliminarPaciente.Name = "btnEliminarPaciente"
        Me.btnEliminarPaciente.Size = New System.Drawing.Size(155, 43)
        Me.btnEliminarPaciente.TabIndex = 9
        Me.btnEliminarPaciente.Text = "Eliminar Paciente"
        Me.btnEliminarPaciente.UseVisualStyleBackColor = True
        '
        'TextNombredelPaciente
        '
        Me.TextNombredelPaciente.Location = New System.Drawing.Point(222, 129)
        Me.TextNombredelPaciente.Name = "TextNombredelPaciente"
        Me.TextNombredelPaciente.Size = New System.Drawing.Size(347, 26)
        Me.TextNombredelPaciente.TabIndex = 8
        '
        'lblNombredelPaciente
        '
        Me.lblNombredelPaciente.AutoSize = True
        Me.lblNombredelPaciente.Location = New System.Drawing.Point(56, 129)
        Me.lblNombredelPaciente.Name = "lblNombredelPaciente"
        Me.lblNombredelPaciente.Size = New System.Drawing.Size(160, 20)
        Me.lblNombredelPaciente.TabIndex = 7
        Me.lblNombredelPaciente.Text = "Nombre del Paciente:"
        '
        'btnBuscaridPaciente
        '
        Me.btnBuscaridPaciente.Location = New System.Drawing.Point(542, 72)
        Me.btnBuscaridPaciente.Name = "btnBuscaridPaciente"
        Me.btnBuscaridPaciente.Size = New System.Drawing.Size(171, 32)
        Me.btnBuscaridPaciente.TabIndex = 5
        Me.btnBuscaridPaciente.Text = "Buscar "
        Me.btnBuscaridPaciente.UseVisualStyleBackColor = True
        '
        'FmrEliminardatosdelpaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FmrEliminardatosdelpaciente"
        Me.Text = " Eliminar datos del paciente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtidPaciente As TextBox
    Friend WithEvents lblidPaciente As Label
    Friend WithEvents txtBuscaridPaciente As TextBox
    Friend WithEvents btnEliminarPaciente As Button
    Friend WithEvents TextNombredelPaciente As TextBox
    Friend WithEvents lblNombredelPaciente As Label
    Friend WithEvents btnBuscaridPaciente As Button
End Class
