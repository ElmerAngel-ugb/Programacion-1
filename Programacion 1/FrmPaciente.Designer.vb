<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPaciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPaciente))
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnBuscarPaciente = New System.Windows.Forms.Button()
        Me.btnEliminarPaciente = New System.Windows.Forms.Button()
        Me.btnModificarPaciente = New System.Windows.Forms.Button()
        Me.btnAgregarPaciente = New System.Windows.Forms.Button()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistrosPaciente = New System.Windows.Forms.Label()
        Me.btnUltimoCliente = New System.Windows.Forms.Button()
        Me.btnSiguienteCliente = New System.Windows.Forms.Button()
        Me.btnAnteriorCliente = New System.Windows.Forms.Button()
        Me.btnPrimeroCliente = New System.Windows.Forms.Button()
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDireccionPaciente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtApellidoPaciente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtExamenesPaciente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSangrePaciente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDuiPaciente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSexoPaciente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNacimientoPaciente = New System.Windows.Forms.TextBox()
        Me.lblEmailCliente = New System.Windows.Forms.Label()
        Me.txtEmailPaciente = New System.Windows.Forms.TextBox()
        Me.lblTelefonoCliente = New System.Windows.Forms.Label()
        Me.txtEdadPaciente = New System.Windows.Forms.TextBox()
        Me.lblDireccionCliente = New System.Windows.Forms.Label()
        Me.txtAlergicoPaciente = New System.Windows.Forms.TextBox()
        Me.lblNombreCliente = New System.Windows.Forms.Label()
        Me.txtNombrePaciente = New System.Windows.Forms.TextBox()
        Me.txtCodigoPaciente = New System.Windows.Forms.TextBox()
        Me.lblCodigoCliente = New System.Windows.Forms.Label()
        Me.grbEdicion.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.grbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbEdicion
        '
        Me.grbEdicion.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.grbEdicion.Controls.Add(Me.btnBuscarPaciente)
        Me.grbEdicion.Controls.Add(Me.btnEliminarPaciente)
        Me.grbEdicion.Controls.Add(Me.btnModificarPaciente)
        Me.grbEdicion.Controls.Add(Me.btnAgregarPaciente)
        Me.grbEdicion.Location = New System.Drawing.Point(287, 590)
        Me.grbEdicion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Size = New System.Drawing.Size(310, 86)
        Me.grbEdicion.TabIndex = 11
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscarPaciente
        '
        Me.btnBuscarPaciente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarPaciente.Location = New System.Drawing.Point(237, 19)
        Me.btnBuscarPaciente.Margin = New System.Windows.Forms.Padding(1)
        Me.btnBuscarPaciente.Name = "btnBuscarPaciente"
        Me.btnBuscarPaciente.Size = New System.Drawing.Size(71, 39)
        Me.btnBuscarPaciente.TabIndex = 8
        Me.btnBuscarPaciente.Text = "Buscar"
        Me.btnBuscarPaciente.UseVisualStyleBackColor = True
        '
        'btnEliminarPaciente
        '
        Me.btnEliminarPaciente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarPaciente.Location = New System.Drawing.Point(158, 19)
        Me.btnEliminarPaciente.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEliminarPaciente.Name = "btnEliminarPaciente"
        Me.btnEliminarPaciente.Size = New System.Drawing.Size(80, 39)
        Me.btnEliminarPaciente.TabIndex = 7
        Me.btnEliminarPaciente.Text = "Eliminar"
        Me.btnEliminarPaciente.UseVisualStyleBackColor = True
        '
        'btnModificarPaciente
        '
        Me.btnModificarPaciente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarPaciente.Location = New System.Drawing.Point(69, 19)
        Me.btnModificarPaciente.Margin = New System.Windows.Forms.Padding(1)
        Me.btnModificarPaciente.Name = "btnModificarPaciente"
        Me.btnModificarPaciente.Size = New System.Drawing.Size(90, 39)
        Me.btnModificarPaciente.TabIndex = 6
        Me.btnModificarPaciente.Text = "Modificar"
        Me.btnModificarPaciente.UseVisualStyleBackColor = True
        '
        'btnAgregarPaciente
        '
        Me.btnAgregarPaciente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarPaciente.Location = New System.Drawing.Point(2, 19)
        Me.btnAgregarPaciente.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAgregarPaciente.Name = "btnAgregarPaciente"
        Me.btnAgregarPaciente.Size = New System.Drawing.Size(68, 39)
        Me.btnAgregarPaciente.TabIndex = 5
        Me.btnAgregarPaciente.Text = "Nuevo"
        Me.btnAgregarPaciente.UseVisualStyleBackColor = True
        '
        'grbNavegacion
        '
        Me.grbNavegacion.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.grbNavegacion.Controls.Add(Me.lblRegistrosPaciente)
        Me.grbNavegacion.Controls.Add(Me.btnUltimoCliente)
        Me.grbNavegacion.Controls.Add(Me.btnSiguienteCliente)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriorCliente)
        Me.grbNavegacion.Controls.Add(Me.btnPrimeroCliente)
        Me.grbNavegacion.Location = New System.Drawing.Point(10, 590)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Size = New System.Drawing.Size(275, 86)
        Me.grbNavegacion.TabIndex = 10
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblRegistrosPaciente
        '
        Me.lblRegistrosPaciente.AutoSize = True
        Me.lblRegistrosPaciente.Location = New System.Drawing.Point(86, 34)
        Me.lblRegistrosPaciente.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblRegistrosPaciente.Name = "lblRegistrosPaciente"
        Me.lblRegistrosPaciente.Size = New System.Drawing.Size(36, 13)
        Me.lblRegistrosPaciente.TabIndex = 4
        Me.lblRegistrosPaciente.Text = "x de n"
        '
        'btnUltimoCliente
        '
        Me.btnUltimoCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoCliente.Location = New System.Drawing.Point(226, 19)
        Me.btnUltimoCliente.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUltimoCliente.Name = "btnUltimoCliente"
        Me.btnUltimoCliente.Size = New System.Drawing.Size(44, 39)
        Me.btnUltimoCliente.TabIndex = 3
        Me.btnUltimoCliente.Text = ">|"
        Me.btnUltimoCliente.UseVisualStyleBackColor = True
        '
        'btnSiguienteCliente
        '
        Me.btnSiguienteCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteCliente.Location = New System.Drawing.Point(187, 19)
        Me.btnSiguienteCliente.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSiguienteCliente.Name = "btnSiguienteCliente"
        Me.btnSiguienteCliente.Size = New System.Drawing.Size(41, 39)
        Me.btnSiguienteCliente.TabIndex = 2
        Me.btnSiguienteCliente.Text = ">"
        Me.btnSiguienteCliente.UseVisualStyleBackColor = True
        '
        'btnAnteriorCliente
        '
        Me.btnAnteriorCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorCliente.Location = New System.Drawing.Point(42, 19)
        Me.btnAnteriorCliente.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAnteriorCliente.Name = "btnAnteriorCliente"
        Me.btnAnteriorCliente.Size = New System.Drawing.Size(41, 39)
        Me.btnAnteriorCliente.TabIndex = 1
        Me.btnAnteriorCliente.Text = "<"
        Me.btnAnteriorCliente.UseVisualStyleBackColor = True
        '
        'btnPrimeroCliente
        '
        Me.btnPrimeroCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeroCliente.Location = New System.Drawing.Point(2, 19)
        Me.btnPrimeroCliente.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPrimeroCliente.Name = "btnPrimeroCliente"
        Me.btnPrimeroCliente.Size = New System.Drawing.Size(41, 39)
        Me.btnPrimeroCliente.TabIndex = 0
        Me.btnPrimeroCliente.Text = "|<"
        Me.btnPrimeroCliente.UseVisualStyleBackColor = True
        '
        'grbDatos
        '
        Me.grbDatos.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.grbDatos.Controls.Add(Me.Label7)
        Me.grbDatos.Controls.Add(Me.txtDireccionPaciente)
        Me.grbDatos.Controls.Add(Me.Label6)
        Me.grbDatos.Controls.Add(Me.txtApellidoPaciente)
        Me.grbDatos.Controls.Add(Me.Label5)
        Me.grbDatos.Controls.Add(Me.txtExamenesPaciente)
        Me.grbDatos.Controls.Add(Me.Label4)
        Me.grbDatos.Controls.Add(Me.txtSangrePaciente)
        Me.grbDatos.Controls.Add(Me.Label3)
        Me.grbDatos.Controls.Add(Me.txtDuiPaciente)
        Me.grbDatos.Controls.Add(Me.Label2)
        Me.grbDatos.Controls.Add(Me.txtSexoPaciente)
        Me.grbDatos.Controls.Add(Me.Label1)
        Me.grbDatos.Controls.Add(Me.txtNacimientoPaciente)
        Me.grbDatos.Controls.Add(Me.lblEmailCliente)
        Me.grbDatos.Controls.Add(Me.txtEmailPaciente)
        Me.grbDatos.Controls.Add(Me.lblTelefonoCliente)
        Me.grbDatos.Controls.Add(Me.txtEdadPaciente)
        Me.grbDatos.Controls.Add(Me.lblDireccionCliente)
        Me.grbDatos.Controls.Add(Me.txtAlergicoPaciente)
        Me.grbDatos.Controls.Add(Me.lblNombreCliente)
        Me.grbDatos.Controls.Add(Me.txtNombrePaciente)
        Me.grbDatos.Controls.Add(Me.txtCodigoPaciente)
        Me.grbDatos.Controls.Add(Me.lblCodigoCliente)
        Me.grbDatos.Enabled = False
        Me.grbDatos.Location = New System.Drawing.Point(10, 10)
        Me.grbDatos.Margin = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Padding = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Size = New System.Drawing.Size(587, 578)
        Me.grbDatos.TabIndex = 9
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos del Paciente"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 374)
        Me.Label7.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 17)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Direccion:"
        '
        'txtDireccionPaciente
        '
        Me.txtDireccionPaciente.Location = New System.Drawing.Point(103, 357)
        Me.txtDireccionPaciente.Margin = New System.Windows.Forms.Padding(1)
        Me.txtDireccionPaciente.Multiline = True
        Me.txtDireccionPaciente.Name = "txtDireccionPaciente"
        Me.txtDireccionPaciente.Size = New System.Drawing.Size(333, 53)
        Me.txtDireccionPaciente.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 119)
        Me.Label6.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 17)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Apellido:"
        '
        'txtApellidoPaciente
        '
        Me.txtApellidoPaciente.Location = New System.Drawing.Point(126, 119)
        Me.txtApellidoPaciente.Margin = New System.Windows.Forms.Padding(1)
        Me.txtApellidoPaciente.Name = "txtApellidoPaciente"
        Me.txtApellidoPaciente.Size = New System.Drawing.Size(333, 20)
        Me.txtApellidoPaciente.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 529)
        Me.Label5.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(243, 17)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Examenes y pruebas realizadas:"
        '
        'txtExamenesPaciente
        '
        Me.txtExamenesPaciente.Location = New System.Drawing.Point(262, 501)
        Me.txtExamenesPaciente.Margin = New System.Windows.Forms.Padding(1)
        Me.txtExamenesPaciente.Multiline = True
        Me.txtExamenesPaciente.Name = "txtExamenesPaciente"
        Me.txtExamenesPaciente.Size = New System.Drawing.Size(258, 67)
        Me.txtExamenesPaciente.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(274, 253)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 17)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Tipo de Sangre:"
        '
        'txtSangrePaciente
        '
        Me.txtSangrePaciente.Location = New System.Drawing.Point(401, 253)
        Me.txtSangrePaciente.Margin = New System.Windows.Forms.Padding(1)
        Me.txtSangrePaciente.Name = "txtSangrePaciente"
        Me.txtSangrePaciente.Size = New System.Drawing.Size(139, 20)
        Me.txtSangrePaciente.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 254)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "DUI/NIT:"
        '
        'txtDuiPaciente
        '
        Me.txtDuiPaciente.Location = New System.Drawing.Point(95, 253)
        Me.txtDuiPaciente.Margin = New System.Windows.Forms.Padding(1)
        Me.txtDuiPaciente.Name = "txtDuiPaciente"
        Me.txtDuiPaciente.Size = New System.Drawing.Size(156, 20)
        Me.txtDuiPaciente.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(284, 199)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Sexo:"
        '
        'txtSexoPaciente
        '
        Me.txtSexoPaciente.Location = New System.Drawing.Point(344, 199)
        Me.txtSexoPaciente.Margin = New System.Windows.Forms.Padding(1)
        Me.txtSexoPaciente.Name = "txtSexoPaciente"
        Me.txtSexoPaciente.Size = New System.Drawing.Size(159, 20)
        Me.txtSexoPaciente.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 157)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Fecha de Nacimiento:"
        '
        'txtNacimientoPaciente
        '
        Me.txtNacimientoPaciente.Location = New System.Drawing.Point(187, 154)
        Me.txtNacimientoPaciente.Margin = New System.Windows.Forms.Padding(1)
        Me.txtNacimientoPaciente.Name = "txtNacimientoPaciente"
        Me.txtNacimientoPaciente.Size = New System.Drawing.Size(333, 20)
        Me.txtNacimientoPaciente.TabIndex = 11
        '
        'lblEmailCliente
        '
        Me.lblEmailCliente.AutoSize = True
        Me.lblEmailCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailCliente.Location = New System.Drawing.Point(20, 309)
        Me.lblEmailCliente.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblEmailCliente.Name = "lblEmailCliente"
        Me.lblEmailCliente.Size = New System.Drawing.Size(58, 17)
        Me.lblEmailCliente.TabIndex = 10
        Me.lblEmailCliente.Text = "EMAIL:"
        '
        'txtEmailPaciente
        '
        Me.txtEmailPaciente.Location = New System.Drawing.Point(92, 309)
        Me.txtEmailPaciente.Margin = New System.Windows.Forms.Padding(1)
        Me.txtEmailPaciente.Name = "txtEmailPaciente"
        Me.txtEmailPaciente.Size = New System.Drawing.Size(333, 20)
        Me.txtEmailPaciente.TabIndex = 9
        '
        'lblTelefonoCliente
        '
        Me.lblTelefonoCliente.AutoSize = True
        Me.lblTelefonoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoCliente.Location = New System.Drawing.Point(28, 208)
        Me.lblTelefonoCliente.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblTelefonoCliente.Name = "lblTelefonoCliente"
        Me.lblTelefonoCliente.Size = New System.Drawing.Size(50, 17)
        Me.lblTelefonoCliente.TabIndex = 8
        Me.lblTelefonoCliente.Text = "Edad:"
        '
        'txtEdadPaciente
        '
        Me.txtEdadPaciente.Location = New System.Drawing.Point(92, 208)
        Me.txtEdadPaciente.Margin = New System.Windows.Forms.Padding(1)
        Me.txtEdadPaciente.Name = "txtEdadPaciente"
        Me.txtEdadPaciente.Size = New System.Drawing.Size(159, 20)
        Me.txtEdadPaciente.TabIndex = 7
        '
        'lblDireccionCliente
        '
        Me.lblDireccionCliente.AutoSize = True
        Me.lblDireccionCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionCliente.Location = New System.Drawing.Point(15, 451)
        Me.lblDireccionCliente.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblDireccionCliente.Name = "lblDireccionCliente"
        Me.lblDireccionCliente.Size = New System.Drawing.Size(86, 17)
        Me.lblDireccionCliente.TabIndex = 6
        Me.lblDireccionCliente.Text = "Alergico a:"
        '
        'txtAlergicoPaciente
        '
        Me.txtAlergicoPaciente.Location = New System.Drawing.Point(126, 428)
        Me.txtAlergicoPaciente.Margin = New System.Windows.Forms.Padding(1)
        Me.txtAlergicoPaciente.Multiline = True
        Me.txtAlergicoPaciente.Name = "txtAlergicoPaciente"
        Me.txtAlergicoPaciente.Size = New System.Drawing.Size(317, 55)
        Me.txtAlergicoPaciente.TabIndex = 5
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCliente.Location = New System.Drawing.Point(15, 75)
        Me.lblNombreCliente.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(79, 17)
        Me.lblNombreCliente.TabIndex = 4
        Me.lblNombreCliente.Text = "NOMBRE:"
        '
        'txtNombrePaciente
        '
        Me.txtNombrePaciente.Location = New System.Drawing.Point(126, 75)
        Me.txtNombrePaciente.Margin = New System.Windows.Forms.Padding(1)
        Me.txtNombrePaciente.Name = "txtNombrePaciente"
        Me.txtNombrePaciente.Size = New System.Drawing.Size(333, 20)
        Me.txtNombrePaciente.TabIndex = 3
        '
        'txtCodigoPaciente
        '
        Me.txtCodigoPaciente.Location = New System.Drawing.Point(121, 36)
        Me.txtCodigoPaciente.Margin = New System.Windows.Forms.Padding(1)
        Me.txtCodigoPaciente.Name = "txtCodigoPaciente"
        Me.txtCodigoPaciente.Size = New System.Drawing.Size(95, 20)
        Me.txtCodigoPaciente.TabIndex = 1
        '
        'lblCodigoCliente
        '
        Me.lblCodigoCliente.AutoSize = True
        Me.lblCodigoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoCliente.Location = New System.Drawing.Point(15, 35)
        Me.lblCodigoCliente.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblCodigoCliente.Name = "lblCodigoCliente"
        Me.lblCodigoCliente.Size = New System.Drawing.Size(74, 17)
        Me.lblCodigoCliente.TabIndex = 0
        Me.lblCodigoCliente.Text = "CODIGO:"
        '
        'FrmPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(609, 686)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPaciente"
        Me.Text = "Registro de Paciente"
        Me.grbEdicion.ResumeLayout(False)
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnBuscarPaciente As Button
    Friend WithEvents btnEliminarPaciente As Button
    Friend WithEvents btnModificarPaciente As Button
    Friend WithEvents btnAgregarPaciente As Button
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblRegistrosPaciente As Label
    Friend WithEvents btnUltimoCliente As Button
    Friend WithEvents btnSiguienteCliente As Button
    Friend WithEvents btnAnteriorCliente As Button
    Friend WithEvents btnPrimeroCliente As Button
    Friend WithEvents grbDatos As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDireccionPaciente As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtApellidoPaciente As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtExamenesPaciente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSangrePaciente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDuiPaciente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSexoPaciente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNacimientoPaciente As TextBox
    Friend WithEvents lblEmailCliente As Label
    Friend WithEvents txtEmailPaciente As TextBox
    Friend WithEvents lblTelefonoCliente As Label
    Friend WithEvents txtEdadPaciente As TextBox
    Friend WithEvents lblDireccionCliente As Label
    Friend WithEvents txtAlergicoPaciente As TextBox
    Friend WithEvents lblNombreCliente As Label
    Friend WithEvents txtNombrePaciente As TextBox
    Friend WithEvents txtCodigoPaciente As TextBox
    Friend WithEvents lblCodigoCliente As Label
End Class
