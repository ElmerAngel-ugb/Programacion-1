<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRecetaMedica
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
        Me.btnModificarRegistrodePersonal = New System.Windows.Forms.Button()
        Me.btnNuevoRegistrodePersonal = New System.Windows.Forms.Button()
        Me.grbRNavegarRegistrodePersonal = New System.Windows.Forms.GroupBox()
        Me.lblUbicacionRegistrodePersonal = New System.Windows.Forms.Label()
        Me.btnUltimoRegistrodePersonal = New System.Windows.Forms.Button()
        Me.btnSuienteRegistrodePersonal = New System.Windows.Forms.Button()
        Me.btnAnteriorRegistrodePersonal = New System.Windows.Forms.Button()
        Me.btnPrimerRegistrodePersonal = New System.Windows.Forms.Button()
        Me.grbReceta = New System.Windows.Forms.GroupBox()
        Me.txtmedico = New System.Windows.Forms.TextBox()
        Me.txtpaciente = New System.Windows.Forms.TextBox()
        Me.lblNombrePaciente = New System.Windows.Forms.Label()
        Me.txtDosis = New System.Windows.Forms.TextBox()
        Me.lblDosis = New System.Windows.Forms.Label()
        Me.txtfechadeemision = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lblfechadeemision = New System.Windows.Forms.Label()
        Me.lblDescripcionPaciente = New System.Windows.Forms.Label()
        Me.lblmedico = New System.Windows.Forms.Label()
        Me.grbEditarRegistrodePersonal.SuspendLayout()
        Me.grbRNavegarRegistrodePersonal.SuspendLayout()
        Me.grbReceta.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbEditarRegistrodePersonal
        '
        Me.grbEditarRegistrodePersonal.Controls.Add(Me.btnBuscarRegistrodePersonal)
        Me.grbEditarRegistrodePersonal.Controls.Add(Me.btnEliminarRegistrodePersonal)
        Me.grbEditarRegistrodePersonal.Controls.Add(Me.btnModificarRegistrodePersonal)
        Me.grbEditarRegistrodePersonal.Controls.Add(Me.btnNuevoRegistrodePersonal)
        Me.grbEditarRegistrodePersonal.Location = New System.Drawing.Point(238, 344)
        Me.grbEditarRegistrodePersonal.Name = "grbEditarRegistrodePersonal"
        Me.grbEditarRegistrodePersonal.Size = New System.Drawing.Size(281, 100)
        Me.grbEditarRegistrodePersonal.TabIndex = 11
        Me.grbEditarRegistrodePersonal.TabStop = False
        Me.grbEditarRegistrodePersonal.Text = "EditarRegistro"
        '
        'btnBuscarRegistrodePersonal
        '
        Me.btnBuscarRegistrodePersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarRegistrodePersonal.Location = New System.Drawing.Point(209, 40)
        Me.btnBuscarRegistrodePersonal.Name = "btnBuscarRegistrodePersonal"
        Me.btnBuscarRegistrodePersonal.Size = New System.Drawing.Size(66, 32)
        Me.btnBuscarRegistrodePersonal.TabIndex = 7
        Me.btnBuscarRegistrodePersonal.Text = "Buscar"
        Me.btnBuscarRegistrodePersonal.UseVisualStyleBackColor = True
        '
        'btnEliminarRegistrodePersonal
        '
        Me.btnEliminarRegistrodePersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarRegistrodePersonal.Location = New System.Drawing.Point(133, 40)
        Me.btnEliminarRegistrodePersonal.Name = "btnEliminarRegistrodePersonal"
        Me.btnEliminarRegistrodePersonal.Size = New System.Drawing.Size(79, 32)
        Me.btnEliminarRegistrodePersonal.TabIndex = 6
        Me.btnEliminarRegistrodePersonal.Text = "Eliminar"
        Me.btnEliminarRegistrodePersonal.UseVisualStyleBackColor = True
        '
        'btnModificarRegistrodePersonal
        '
        Me.btnModificarRegistrodePersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarRegistrodePersonal.Location = New System.Drawing.Point(64, 40)
        Me.btnModificarRegistrodePersonal.Name = "btnModificarRegistrodePersonal"
        Me.btnModificarRegistrodePersonal.Size = New System.Drawing.Size(71, 32)
        Me.btnModificarRegistrodePersonal.TabIndex = 5
        Me.btnModificarRegistrodePersonal.Text = "Modificar"
        Me.btnModificarRegistrodePersonal.UseVisualStyleBackColor = True
        '
        'btnNuevoRegistrodePersonal
        '
        Me.btnNuevoRegistrodePersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoRegistrodePersonal.Location = New System.Drawing.Point(9, 40)
        Me.btnNuevoRegistrodePersonal.Name = "btnNuevoRegistrodePersonal"
        Me.btnNuevoRegistrodePersonal.Size = New System.Drawing.Size(57, 32)
        Me.btnNuevoRegistrodePersonal.TabIndex = 4
        Me.btnNuevoRegistrodePersonal.Text = "Nuevo"
        Me.btnNuevoRegistrodePersonal.UseVisualStyleBackColor = True
        '
        'grbRNavegarRegistrodePersonal
        '
        Me.grbRNavegarRegistrodePersonal.Controls.Add(Me.lblUbicacionRegistrodePersonal)
        Me.grbRNavegarRegistrodePersonal.Controls.Add(Me.btnUltimoRegistrodePersonal)
        Me.grbRNavegarRegistrodePersonal.Controls.Add(Me.btnSuienteRegistrodePersonal)
        Me.grbRNavegarRegistrodePersonal.Controls.Add(Me.btnAnteriorRegistrodePersonal)
        Me.grbRNavegarRegistrodePersonal.Controls.Add(Me.btnPrimerRegistrodePersonal)
        Me.grbRNavegarRegistrodePersonal.Location = New System.Drawing.Point(22, 344)
        Me.grbRNavegarRegistrodePersonal.Name = "grbRNavegarRegistrodePersonal"
        Me.grbRNavegarRegistrodePersonal.Size = New System.Drawing.Size(217, 100)
        Me.grbRNavegarRegistrodePersonal.TabIndex = 10
        Me.grbRNavegarRegistrodePersonal.TabStop = False
        Me.grbRNavegarRegistrodePersonal.Text = "Navegar Registro"
        '
        'lblUbicacionRegistrodePersonal
        '
        Me.lblUbicacionRegistrodePersonal.AutoSize = True
        Me.lblUbicacionRegistrodePersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUbicacionRegistrodePersonal.Location = New System.Drawing.Point(87, 48)
        Me.lblUbicacionRegistrodePersonal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUbicacionRegistrodePersonal.Name = "lblUbicacionRegistrodePersonal"
        Me.lblUbicacionRegistrodePersonal.Size = New System.Drawing.Size(47, 15)
        Me.lblUbicacionRegistrodePersonal.TabIndex = 4
        Me.lblUbicacionRegistrodePersonal.Text = "0 de n"
        '
        'btnUltimoRegistrodePersonal
        '
        Me.btnUltimoRegistrodePersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoRegistrodePersonal.Location = New System.Drawing.Point(182, 40)
        Me.btnUltimoRegistrodePersonal.Name = "btnUltimoRegistrodePersonal"
        Me.btnUltimoRegistrodePersonal.Size = New System.Drawing.Size(35, 32)
        Me.btnUltimoRegistrodePersonal.TabIndex = 3
        Me.btnUltimoRegistrodePersonal.Text = ">Ⅰ"
        Me.btnUltimoRegistrodePersonal.UseVisualStyleBackColor = True
        '
        'btnSuienteRegistrodePersonal
        '
        Me.btnSuienteRegistrodePersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuienteRegistrodePersonal.Location = New System.Drawing.Point(154, 40)
        Me.btnSuienteRegistrodePersonal.Name = "btnSuienteRegistrodePersonal"
        Me.btnSuienteRegistrodePersonal.Size = New System.Drawing.Size(35, 32)
        Me.btnSuienteRegistrodePersonal.TabIndex = 2
        Me.btnSuienteRegistrodePersonal.Text = ">"
        Me.btnSuienteRegistrodePersonal.UseVisualStyleBackColor = True
        '
        'btnAnteriorRegistrodePersonal
        '
        Me.btnAnteriorRegistrodePersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorRegistrodePersonal.Location = New System.Drawing.Point(39, 41)
        Me.btnAnteriorRegistrodePersonal.Name = "btnAnteriorRegistrodePersonal"
        Me.btnAnteriorRegistrodePersonal.Size = New System.Drawing.Size(32, 32)
        Me.btnAnteriorRegistrodePersonal.TabIndex = 1
        Me.btnAnteriorRegistrodePersonal.Text = "<"
        Me.btnAnteriorRegistrodePersonal.UseVisualStyleBackColor = True
        '
        'btnPrimerRegistrodePersonal
        '
        Me.btnPrimerRegistrodePersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimerRegistrodePersonal.Location = New System.Drawing.Point(7, 41)
        Me.btnPrimerRegistrodePersonal.Name = "btnPrimerRegistrodePersonal"
        Me.btnPrimerRegistrodePersonal.Size = New System.Drawing.Size(35, 32)
        Me.btnPrimerRegistrodePersonal.TabIndex = 0
        Me.btnPrimerRegistrodePersonal.Text = "ⅼ<"
        Me.btnPrimerRegistrodePersonal.UseVisualStyleBackColor = True
        '
        'grbReceta
        '
        Me.grbReceta.Controls.Add(Me.txtmedico)
        Me.grbReceta.Controls.Add(Me.txtpaciente)
        Me.grbReceta.Controls.Add(Me.lblNombrePaciente)
        Me.grbReceta.Controls.Add(Me.txtDosis)
        Me.grbReceta.Controls.Add(Me.lblDosis)
        Me.grbReceta.Controls.Add(Me.txtfechadeemision)
        Me.grbReceta.Controls.Add(Me.txtDescripcion)
        Me.grbReceta.Controls.Add(Me.lblfechadeemision)
        Me.grbReceta.Controls.Add(Me.lblDescripcionPaciente)
        Me.grbReceta.Controls.Add(Me.lblmedico)
        Me.grbReceta.Location = New System.Drawing.Point(22, 11)
        Me.grbReceta.Margin = New System.Windows.Forms.Padding(2)
        Me.grbReceta.Name = "grbReceta"
        Me.grbReceta.Padding = New System.Windows.Forms.Padding(2)
        Me.grbReceta.Size = New System.Drawing.Size(522, 328)
        Me.grbReceta.TabIndex = 9
        Me.grbReceta.TabStop = False
        Me.grbReceta.Text = "Recetamedica "
        '
        'txtmedico
        '
        Me.txtmedico.Location = New System.Drawing.Point(154, 26)
        Me.txtmedico.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmedico.Name = "txtmedico"
        Me.txtmedico.Size = New System.Drawing.Size(128, 20)
        Me.txtmedico.TabIndex = 22
        '
        'txtpaciente
        '
        Me.txtpaciente.Location = New System.Drawing.Point(154, 57)
        Me.txtpaciente.Margin = New System.Windows.Forms.Padding(2)
        Me.txtpaciente.Name = "txtpaciente"
        Me.txtpaciente.Size = New System.Drawing.Size(258, 20)
        Me.txtpaciente.TabIndex = 21
        '
        'lblNombrePaciente
        '
        Me.lblNombrePaciente.AutoSize = True
        Me.lblNombrePaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombrePaciente.Location = New System.Drawing.Point(80, 57)
        Me.lblNombrePaciente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombrePaciente.Name = "lblNombrePaciente"
        Me.lblNombrePaciente.Size = New System.Drawing.Size(67, 15)
        Me.lblNombrePaciente.TabIndex = 18
        Me.lblNombrePaciente.Text = "Paciente:"
        '
        'txtDosis
        '
        Me.txtDosis.AcceptsTab = True
        Me.txtDosis.Location = New System.Drawing.Point(154, 202)
        Me.txtDosis.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDosis.Multiline = True
        Me.txtDosis.Name = "txtDosis"
        Me.txtDosis.Size = New System.Drawing.Size(356, 56)
        Me.txtDosis.TabIndex = 17
        '
        'lblDosis
        '
        Me.lblDosis.AutoSize = True
        Me.lblDosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDosis.Location = New System.Drawing.Point(80, 202)
        Me.lblDosis.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDosis.Name = "lblDosis"
        Me.lblDosis.Size = New System.Drawing.Size(47, 15)
        Me.lblDosis.TabIndex = 16
        Me.lblDosis.Text = "Dosis:"
        '
        'txtfechadeemision
        '
        Me.txtfechadeemision.Location = New System.Drawing.Point(154, 273)
        Me.txtfechadeemision.Margin = New System.Windows.Forms.Padding(2)
        Me.txtfechadeemision.Name = "txtfechadeemision"
        Me.txtfechadeemision.Size = New System.Drawing.Size(258, 20)
        Me.txtfechadeemision.TabIndex = 10
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(154, 94)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(356, 94)
        Me.txtDescripcion.TabIndex = 9
        '
        'lblfechadeemision
        '
        Me.lblfechadeemision.AutoSize = True
        Me.lblfechadeemision.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfechadeemision.Location = New System.Drawing.Point(17, 274)
        Me.lblfechadeemision.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblfechadeemision.Name = "lblfechadeemision"
        Me.lblfechadeemision.Size = New System.Drawing.Size(125, 15)
        Me.lblfechadeemision.TabIndex = 2
        Me.lblfechadeemision.Text = "Fecha de emision:"
        '
        'lblDescripcionPaciente
        '
        Me.lblDescripcionPaciente.AutoSize = True
        Me.lblDescripcionPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionPaciente.Location = New System.Drawing.Point(63, 100)
        Me.lblDescripcionPaciente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDescripcionPaciente.Name = "lblDescripcionPaciente"
        Me.lblDescripcionPaciente.Size = New System.Drawing.Size(87, 15)
        Me.lblDescripcionPaciente.TabIndex = 1
        Me.lblDescripcionPaciente.Text = "Descripcion:"
        '
        'lblmedico
        '
        Me.lblmedico.AutoSize = True
        Me.lblmedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmedico.Location = New System.Drawing.Point(80, 27)
        Me.lblmedico.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblmedico.Name = "lblmedico"
        Me.lblmedico.Size = New System.Drawing.Size(58, 15)
        Me.lblmedico.TabIndex = 0
        Me.lblmedico.Text = "Medico:"
        '
        'FrmRecetaMedica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 460)
        Me.Controls.Add(Me.grbEditarRegistrodePersonal)
        Me.Controls.Add(Me.grbRNavegarRegistrodePersonal)
        Me.Controls.Add(Me.grbReceta)
        Me.Name = "FrmRecetaMedica"
        Me.Text = "FrmRecetaMedica"
        Me.grbEditarRegistrodePersonal.ResumeLayout(False)
        Me.grbRNavegarRegistrodePersonal.ResumeLayout(False)
        Me.grbRNavegarRegistrodePersonal.PerformLayout()
        Me.grbReceta.ResumeLayout(False)
        Me.grbReceta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbEditarRegistrodePersonal As GroupBox
    Friend WithEvents btnBuscarRegistrodePersonal As Button
    Friend WithEvents btnEliminarRegistrodePersonal As Button
    Friend WithEvents btnModificarRegistrodePersonal As Button
    Friend WithEvents btnNuevoRegistrodePersonal As Button
    Friend WithEvents grbRNavegarRegistrodePersonal As GroupBox
    Friend WithEvents lblUbicacionRegistrodePersonal As Label
    Friend WithEvents btnUltimoRegistrodePersonal As Button
    Friend WithEvents btnSuienteRegistrodePersonal As Button
    Friend WithEvents btnAnteriorRegistrodePersonal As Button
    Friend WithEvents btnPrimerRegistrodePersonal As Button
    Friend WithEvents grbReceta As GroupBox
    Friend WithEvents txtmedico As TextBox
    Friend WithEvents txtpaciente As TextBox
    Friend WithEvents lblNombrePaciente As Label
    Friend WithEvents txtDosis As TextBox
    Friend WithEvents lblDosis As Label
    Friend WithEvents txtfechadeemision As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lblfechadeemision As Label
    Friend WithEvents lblDescripcionPaciente As Label
    Friend WithEvents lblmedico As Label
End Class
