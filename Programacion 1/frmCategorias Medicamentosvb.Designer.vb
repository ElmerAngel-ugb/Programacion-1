<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCegorias_Medicamentosvb
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
        Me.grbEditarRegistrodePersonal = New System.Windows.Forms.GroupBox()
        Me.btnBuscarRegistrodePersonal = New System.Windows.Forms.Button()
        Me.btnEliminarRegistrodePersonal = New System.Windows.Forms.Button()
        Me.btnModificarMedicaamento = New System.Windows.Forms.Button()
        Me.btnNuevoMedicamento = New System.Windows.Forms.Button()
        Me.grbRNavegarRegistrodePersonal = New System.Windows.Forms.GroupBox()
        Me.lblUbicacionRegistrodePersonal = New System.Windows.Forms.Label()
        Me.btnUltimoRegistrodePersonal = New System.Windows.Forms.Button()
        Me.btnSuienteRegistrodePersonal = New System.Windows.Forms.Button()
        Me.btnAnteriorRegistrodePersonal = New System.Windows.Forms.Button()
        Me.btnPrimerRegistrodePersonal = New System.Windows.Forms.Button()
        Me.grbMedicamentosCategoria = New System.Windows.Forms.GroupBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.cboCategoriaMedicamento = New System.Windows.Forms.ComboBox()
        Me.txtCodigoMedicamento = New System.Windows.Forms.TextBox()
        Me.lblCodigoMedicamento = New System.Windows.Forms.Label()
        Me.txtLaboratorioMedicamento = New System.Windows.Forms.TextBox()
        Me.lblLaboratorioMedicamento = New System.Windows.Forms.Label()
        Me.txtCantidadMedicamento = New System.Windows.Forms.TextBox()
        Me.txtDescrpcionMedicamento = New System.Windows.Forms.TextBox()
        Me.lblCantidadMedicamento = New System.Windows.Forms.Label()
        Me.lblDescripcionMedicamento = New System.Windows.Forms.Label()
        Me.lblCategoriaMedicamento = New System.Windows.Forms.Label()
        Me.grbEditarRegistrodePersonal.SuspendLayout()
        Me.grbRNavegarRegistrodePersonal.SuspendLayout()
        Me.grbMedicamentosCategoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbEditarRegistrodePersonal
        '
        Me.grbEditarRegistrodePersonal.Controls.Add(Me.btnBuscarRegistrodePersonal)
        Me.grbEditarRegistrodePersonal.Controls.Add(Me.btnEliminarRegistrodePersonal)
        Me.grbEditarRegistrodePersonal.Controls.Add(Me.btnModificarMedicaamento)
        Me.grbEditarRegistrodePersonal.Controls.Add(Me.btnNuevoMedicamento)
        Me.grbEditarRegistrodePersonal.Location = New System.Drawing.Point(313, 373)
        Me.grbEditarRegistrodePersonal.Margin = New System.Windows.Forms.Padding(4)
        Me.grbEditarRegistrodePersonal.Name = "grbEditarRegistrodePersonal"
        Me.grbEditarRegistrodePersonal.Padding = New System.Windows.Forms.Padding(4)
        Me.grbEditarRegistrodePersonal.Size = New System.Drawing.Size(413, 123)
        Me.grbEditarRegistrodePersonal.TabIndex = 10
        Me.grbEditarRegistrodePersonal.TabStop = False
        Me.grbEditarRegistrodePersonal.Text = "Editar"
        '
        'btnBuscarRegistrodePersonal
        '
        Me.btnBuscarRegistrodePersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarRegistrodePersonal.Location = New System.Drawing.Point(291, 49)
        Me.btnBuscarRegistrodePersonal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscarRegistrodePersonal.Name = "btnBuscarRegistrodePersonal"
        Me.btnBuscarRegistrodePersonal.Size = New System.Drawing.Size(88, 39)
        Me.btnBuscarRegistrodePersonal.TabIndex = 7
        Me.btnBuscarRegistrodePersonal.Text = "Buscar"
        Me.btnBuscarRegistrodePersonal.UseVisualStyleBackColor = True
        '
        'btnEliminarRegistrodePersonal
        '
        Me.btnEliminarRegistrodePersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarRegistrodePersonal.Location = New System.Drawing.Point(189, 49)
        Me.btnEliminarRegistrodePersonal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminarRegistrodePersonal.Name = "btnEliminarRegistrodePersonal"
        Me.btnEliminarRegistrodePersonal.Size = New System.Drawing.Size(105, 39)
        Me.btnEliminarRegistrodePersonal.TabIndex = 6
        Me.btnEliminarRegistrodePersonal.Text = "Eliminar"
        Me.btnEliminarRegistrodePersonal.UseVisualStyleBackColor = True
        '
        'btnModificarMedicaamento
        '
        Me.btnModificarMedicaamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarMedicaamento.Location = New System.Drawing.Point(97, 49)
        Me.btnModificarMedicaamento.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModificarMedicaamento.Name = "btnModificarMedicaamento"
        Me.btnModificarMedicaamento.Size = New System.Drawing.Size(95, 39)
        Me.btnModificarMedicaamento.TabIndex = 5
        Me.btnModificarMedicaamento.Text = "Modificar"
        Me.btnModificarMedicaamento.UseVisualStyleBackColor = True
        '
        'btnNuevoMedicamento
        '
        Me.btnNuevoMedicamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoMedicamento.Location = New System.Drawing.Point(12, 49)
        Me.btnNuevoMedicamento.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevoMedicamento.Name = "btnNuevoMedicamento"
        Me.btnNuevoMedicamento.Size = New System.Drawing.Size(92, 39)
        Me.btnNuevoMedicamento.TabIndex = 4
        Me.btnNuevoMedicamento.Text = "Nuevo"
        Me.btnNuevoMedicamento.UseVisualStyleBackColor = True
        '
        'grbRNavegarRegistrodePersonal
        '
        Me.grbRNavegarRegistrodePersonal.Controls.Add(Me.lblUbicacionRegistrodePersonal)
        Me.grbRNavegarRegistrodePersonal.Controls.Add(Me.btnUltimoRegistrodePersonal)
        Me.grbRNavegarRegistrodePersonal.Controls.Add(Me.btnSuienteRegistrodePersonal)
        Me.grbRNavegarRegistrodePersonal.Controls.Add(Me.btnAnteriorRegistrodePersonal)
        Me.grbRNavegarRegistrodePersonal.Controls.Add(Me.btnPrimerRegistrodePersonal)
        Me.grbRNavegarRegistrodePersonal.Location = New System.Drawing.Point(16, 373)
        Me.grbRNavegarRegistrodePersonal.Margin = New System.Windows.Forms.Padding(4)
        Me.grbRNavegarRegistrodePersonal.Name = "grbRNavegarRegistrodePersonal"
        Me.grbRNavegarRegistrodePersonal.Padding = New System.Windows.Forms.Padding(4)
        Me.grbRNavegarRegistrodePersonal.Size = New System.Drawing.Size(289, 123)
        Me.grbRNavegarRegistrodePersonal.TabIndex = 9
        Me.grbRNavegarRegistrodePersonal.TabStop = False
        Me.grbRNavegarRegistrodePersonal.Text = "Navegar "
        '
        'lblUbicacionRegistrodePersonal
        '
        Me.lblUbicacionRegistrodePersonal.AutoSize = True
        Me.lblUbicacionRegistrodePersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUbicacionRegistrodePersonal.Location = New System.Drawing.Point(116, 59)
        Me.lblUbicacionRegistrodePersonal.Name = "lblUbicacionRegistrodePersonal"
        Me.lblUbicacionRegistrodePersonal.Size = New System.Drawing.Size(54, 18)
        Me.lblUbicacionRegistrodePersonal.TabIndex = 4
        Me.lblUbicacionRegistrodePersonal.Text = "0 de n"
        '
        'btnUltimoRegistrodePersonal
        '
        Me.btnUltimoRegistrodePersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoRegistrodePersonal.Location = New System.Drawing.Point(243, 49)
        Me.btnUltimoRegistrodePersonal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUltimoRegistrodePersonal.Name = "btnUltimoRegistrodePersonal"
        Me.btnUltimoRegistrodePersonal.Size = New System.Drawing.Size(47, 39)
        Me.btnUltimoRegistrodePersonal.TabIndex = 3
        Me.btnUltimoRegistrodePersonal.Text = ">Ⅰ"
        Me.btnUltimoRegistrodePersonal.UseVisualStyleBackColor = True
        '
        'btnSuienteRegistrodePersonal
        '
        Me.btnSuienteRegistrodePersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuienteRegistrodePersonal.Location = New System.Drawing.Point(205, 49)
        Me.btnSuienteRegistrodePersonal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSuienteRegistrodePersonal.Name = "btnSuienteRegistrodePersonal"
        Me.btnSuienteRegistrodePersonal.Size = New System.Drawing.Size(47, 39)
        Me.btnSuienteRegistrodePersonal.TabIndex = 2
        Me.btnSuienteRegistrodePersonal.Text = ">"
        Me.btnSuienteRegistrodePersonal.UseVisualStyleBackColor = True
        '
        'btnAnteriorRegistrodePersonal
        '
        Me.btnAnteriorRegistrodePersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorRegistrodePersonal.Location = New System.Drawing.Point(52, 50)
        Me.btnAnteriorRegistrodePersonal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAnteriorRegistrodePersonal.Name = "btnAnteriorRegistrodePersonal"
        Me.btnAnteriorRegistrodePersonal.Size = New System.Drawing.Size(43, 39)
        Me.btnAnteriorRegistrodePersonal.TabIndex = 1
        Me.btnAnteriorRegistrodePersonal.Text = "<"
        Me.btnAnteriorRegistrodePersonal.UseVisualStyleBackColor = True
        '
        'btnPrimerRegistrodePersonal
        '
        Me.btnPrimerRegistrodePersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimerRegistrodePersonal.Location = New System.Drawing.Point(9, 50)
        Me.btnPrimerRegistrodePersonal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrimerRegistrodePersonal.Name = "btnPrimerRegistrodePersonal"
        Me.btnPrimerRegistrodePersonal.Size = New System.Drawing.Size(47, 39)
        Me.btnPrimerRegistrodePersonal.TabIndex = 0
        Me.btnPrimerRegistrodePersonal.Text = "ⅼ<"
        Me.btnPrimerRegistrodePersonal.UseVisualStyleBackColor = True
        '
        'grbMedicamentosCategoria
        '
        Me.grbMedicamentosCategoria.Controls.Add(Me.txtNombre)
        Me.grbMedicamentosCategoria.Controls.Add(Me.lblNombre)
        Me.grbMedicamentosCategoria.Controls.Add(Me.cboCategoriaMedicamento)
        Me.grbMedicamentosCategoria.Controls.Add(Me.txtCodigoMedicamento)
        Me.grbMedicamentosCategoria.Controls.Add(Me.lblCodigoMedicamento)
        Me.grbMedicamentosCategoria.Controls.Add(Me.txtLaboratorioMedicamento)
        Me.grbMedicamentosCategoria.Controls.Add(Me.lblLaboratorioMedicamento)
        Me.grbMedicamentosCategoria.Controls.Add(Me.txtCantidadMedicamento)
        Me.grbMedicamentosCategoria.Controls.Add(Me.txtDescrpcionMedicamento)
        Me.grbMedicamentosCategoria.Controls.Add(Me.lblCantidadMedicamento)
        Me.grbMedicamentosCategoria.Controls.Add(Me.lblDescripcionMedicamento)
        Me.grbMedicamentosCategoria.Controls.Add(Me.lblCategoriaMedicamento)
        Me.grbMedicamentosCategoria.Location = New System.Drawing.Point(15, 14)
        Me.grbMedicamentosCategoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grbMedicamentosCategoria.Name = "grbMedicamentosCategoria"
        Me.grbMedicamentosCategoria.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grbMedicamentosCategoria.Size = New System.Drawing.Size(713, 353)
        Me.grbMedicamentosCategoria.TabIndex = 8
        Me.grbMedicamentosCategoria.TabStop = False
        Me.grbMedicamentosCategoria.Text = "Categorias "
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(159, 133)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(312, 42)
        Me.txtNombre.TabIndex = 21
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(67, 134)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(73, 18)
        Me.lblNombre.TabIndex = 20
        Me.lblNombre.Text = "Nombre:"
        '
        'cboCategoriaMedicamento
        '
        Me.cboCategoriaMedicamento.FormattingEnabled = True
        Me.cboCategoriaMedicamento.Location = New System.Drawing.Point(159, 44)
        Me.cboCategoriaMedicamento.Margin = New System.Windows.Forms.Padding(4)
        Me.cboCategoriaMedicamento.Name = "cboCategoriaMedicamento"
        Me.cboCategoriaMedicamento.Size = New System.Drawing.Size(241, 24)
        Me.cboCategoriaMedicamento.TabIndex = 5
        '
        'txtCodigoMedicamento
        '
        Me.txtCodigoMedicamento.Location = New System.Drawing.Point(159, 81)
        Me.txtCodigoMedicamento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCodigoMedicamento.Name = "txtCodigoMedicamento"
        Me.txtCodigoMedicamento.Size = New System.Drawing.Size(145, 22)
        Me.txtCodigoMedicamento.TabIndex = 19
        '
        'lblCodigoMedicamento
        '
        Me.lblCodigoMedicamento.AutoSize = True
        Me.lblCodigoMedicamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoMedicamento.Location = New System.Drawing.Point(67, 82)
        Me.lblCodigoMedicamento.Name = "lblCodigoMedicamento"
        Me.lblCodigoMedicamento.Size = New System.Drawing.Size(67, 18)
        Me.lblCodigoMedicamento.TabIndex = 18
        Me.lblCodigoMedicamento.Text = "Codigo:"
        '
        'txtLaboratorioMedicamento
        '
        Me.txtLaboratorioMedicamento.AcceptsTab = True
        Me.txtLaboratorioMedicamento.Location = New System.Drawing.Point(159, 266)
        Me.txtLaboratorioMedicamento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLaboratorioMedicamento.Name = "txtLaboratorioMedicamento"
        Me.txtLaboratorioMedicamento.Size = New System.Drawing.Size(241, 22)
        Me.txtLaboratorioMedicamento.TabIndex = 17
        '
        'lblLaboratorioMedicamento
        '
        Me.lblLaboratorioMedicamento.AutoSize = True
        Me.lblLaboratorioMedicamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLaboratorioMedicamento.Location = New System.Drawing.Point(28, 266)
        Me.lblLaboratorioMedicamento.Name = "lblLaboratorioMedicamento"
        Me.lblLaboratorioMedicamento.Size = New System.Drawing.Size(100, 18)
        Me.lblLaboratorioMedicamento.TabIndex = 16
        Me.lblLaboratorioMedicamento.Text = "Laboratorio:"
        '
        'txtCantidadMedicamento
        '
        Me.txtCantidadMedicamento.Location = New System.Drawing.Point(159, 308)
        Me.txtCantidadMedicamento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCantidadMedicamento.Name = "txtCantidadMedicamento"
        Me.txtCantidadMedicamento.Size = New System.Drawing.Size(204, 22)
        Me.txtCantidadMedicamento.TabIndex = 10
        '
        'txtDescrpcionMedicamento
        '
        Me.txtDescrpcionMedicamento.Location = New System.Drawing.Point(159, 193)
        Me.txtDescrpcionMedicamento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDescrpcionMedicamento.Multiline = True
        Me.txtDescrpcionMedicamento.Name = "txtDescrpcionMedicamento"
        Me.txtDescrpcionMedicamento.Size = New System.Drawing.Size(343, 61)
        Me.txtDescrpcionMedicamento.TabIndex = 9
        '
        'lblCantidadMedicamento
        '
        Me.lblCantidadMedicamento.AutoSize = True
        Me.lblCantidadMedicamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadMedicamento.Location = New System.Drawing.Point(51, 308)
        Me.lblCantidadMedicamento.Name = "lblCantidadMedicamento"
        Me.lblCantidadMedicamento.Size = New System.Drawing.Size(79, 18)
        Me.lblCantidadMedicamento.TabIndex = 2
        Me.lblCantidadMedicamento.Text = "Cantidad:"
        '
        'lblDescripcionMedicamento
        '
        Me.lblDescripcionMedicamento.AutoSize = True
        Me.lblDescripcionMedicamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionMedicamento.Location = New System.Drawing.Point(31, 194)
        Me.lblDescripcionMedicamento.Name = "lblDescripcionMedicamento"
        Me.lblDescripcionMedicamento.Size = New System.Drawing.Size(99, 18)
        Me.lblDescripcionMedicamento.TabIndex = 1
        Me.lblDescripcionMedicamento.Text = "Descrpcion:"
        '
        'lblCategoriaMedicamento
        '
        Me.lblCategoriaMedicamento.AutoSize = True
        Me.lblCategoriaMedicamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoriaMedicamento.Location = New System.Drawing.Point(56, 44)
        Me.lblCategoriaMedicamento.Name = "lblCategoriaMedicamento"
        Me.lblCategoriaMedicamento.Size = New System.Drawing.Size(86, 18)
        Me.lblCategoriaMedicamento.TabIndex = 0
        Me.lblCategoriaMedicamento.Text = "Categoria:"
        '
        'frmCegorias_Medicamentosvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 511)
        Me.Controls.Add(Me.grbEditarRegistrodePersonal)
        Me.Controls.Add(Me.grbRNavegarRegistrodePersonal)
        Me.Controls.Add(Me.grbMedicamentosCategoria)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCegorias_Medicamentosvb"
        Me.Text = "frmCegorias_Medicamentosvb"
        Me.grbEditarRegistrodePersonal.ResumeLayout(False)
        Me.grbRNavegarRegistrodePersonal.ResumeLayout(False)
        Me.grbRNavegarRegistrodePersonal.PerformLayout()
        Me.grbMedicamentosCategoria.ResumeLayout(False)
        Me.grbMedicamentosCategoria.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbEditarRegistrodePersonal As GroupBox
    Friend WithEvents btnBuscarRegistrodePersonal As Button
    Friend WithEvents btnEliminarRegistrodePersonal As Button
    Friend WithEvents btnModificarMedicaamento As Button
    Friend WithEvents btnNuevoMedicamento As Button
    Friend WithEvents grbRNavegarRegistrodePersonal As GroupBox
    Friend WithEvents lblUbicacionRegistrodePersonal As Label
    Friend WithEvents btnUltimoRegistrodePersonal As Button
    Friend WithEvents btnSuienteRegistrodePersonal As Button
    Friend WithEvents btnAnteriorRegistrodePersonal As Button
    Friend WithEvents btnPrimerRegistrodePersonal As Button
    Friend WithEvents grbMedicamentosCategoria As GroupBox
    Friend WithEvents cboCategoriaMedicamento As ComboBox
    Friend WithEvents txtCodigoMedicamento As TextBox
    Friend WithEvents lblCodigoMedicamento As Label
    Friend WithEvents txtLaboratorioMedicamento As TextBox
    Friend WithEvents lblLaboratorioMedicamento As Label
    Friend WithEvents txtCantidadMedicamento As TextBox
    Friend WithEvents txtDescrpcionMedicamento As TextBox
    Friend WithEvents lblCantidadMedicamento As Label
    Friend WithEvents lblDescripcionMedicamento As Label
    Friend WithEvents lblCategoriaMedicamento As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
End Class
