<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegistro_Acompañante
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRegistro_Acompañante))
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnBuscarRegistro = New System.Windows.Forms.Button()
        Me.btnEliminarRegistro = New System.Windows.Forms.Button()
        Me.btnModificarRegistro = New System.Windows.Forms.Button()
        Me.btnAgregarRegistro = New System.Windows.Forms.Button()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistrosRegistro = New System.Windows.Forms.Label()
        Me.btnUltimoRegistro = New System.Windows.Forms.Button()
        Me.btnSiguienteRegistro = New System.Windows.Forms.Button()
        Me.btnAnteriorRegistro = New System.Windows.Forms.Button()
        Me.btnPrimeroRegistro = New System.Windows.Forms.Button()
        Me.grbDatosRegistro = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTipo_SangreRegsitro = New System.Windows.Forms.Label()
        Me.txtTipo_SangreRegistro = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDireccionPaciente = New System.Windows.Forms.TextBox()
        Me.lblApellidoRegsitro = New System.Windows.Forms.Label()
        Me.txtApellidoRegistro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTelefonoAcompnante = New System.Windows.Forms.TextBox()
        Me.lblSexoAcompanante = New System.Windows.Forms.Label()
        Me.txtSexoAcompanante = New System.Windows.Forms.TextBox()
        Me.lblSexoRegsitro = New System.Windows.Forms.Label()
        Me.txtSexoRegistro = New System.Windows.Forms.TextBox()
        Me.lblFecha_NacimientoRegsitro = New System.Windows.Forms.Label()
        Me.txtNacimientoRegistro = New System.Windows.Forms.TextBox()
        Me.lblEmailCliente = New System.Windows.Forms.Label()
        Me.txtEmailPaciente = New System.Windows.Forms.TextBox()
        Me.lblTelefonoCliente = New System.Windows.Forms.Label()
        Me.txtEdadPaciente = New System.Windows.Forms.TextBox()
        Me.lblNombreRegsitro = New System.Windows.Forms.Label()
        Me.txtNombreRegistro = New System.Windows.Forms.TextBox()
        Me.txtCodigoRegistro = New System.Windows.Forms.TextBox()
        Me.lblCodigoRegistro = New System.Windows.Forms.Label()
        Me.txtCodigoAcompanante = New System.Windows.Forms.TextBox()
        Me.lblCodigoAcompanante = New System.Windows.Forms.Label()
        Me.grbEdicion.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.grbDatosRegistro.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbEdicion
        '
        Me.grbEdicion.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grbEdicion.Controls.Add(Me.btnBuscarRegistro)
        Me.grbEdicion.Controls.Add(Me.btnEliminarRegistro)
        Me.grbEdicion.Controls.Add(Me.btnModificarRegistro)
        Me.grbEdicion.Controls.Add(Me.btnAgregarRegistro)
        Me.grbEdicion.Location = New System.Drawing.Point(711, 477)
        Me.grbEdicion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Size = New System.Drawing.Size(310, 86)
        Me.grbEdicion.TabIndex = 14
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscarRegistro
        '
        Me.btnBuscarRegistro.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarRegistro.Location = New System.Drawing.Point(237, 19)
        Me.btnBuscarRegistro.Margin = New System.Windows.Forms.Padding(1)
        Me.btnBuscarRegistro.Name = "btnBuscarRegistro"
        Me.btnBuscarRegistro.Size = New System.Drawing.Size(71, 39)
        Me.btnBuscarRegistro.TabIndex = 8
        Me.btnBuscarRegistro.Text = "Buscar"
        Me.btnBuscarRegistro.UseVisualStyleBackColor = True
        '
        'btnEliminarRegistro
        '
        Me.btnEliminarRegistro.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarRegistro.Location = New System.Drawing.Point(158, 19)
        Me.btnEliminarRegistro.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEliminarRegistro.Name = "btnEliminarRegistro"
        Me.btnEliminarRegistro.Size = New System.Drawing.Size(80, 39)
        Me.btnEliminarRegistro.TabIndex = 7
        Me.btnEliminarRegistro.Text = "Eliminar"
        Me.btnEliminarRegistro.UseVisualStyleBackColor = True
        '
        'btnModificarRegistro
        '
        Me.btnModificarRegistro.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarRegistro.Location = New System.Drawing.Point(69, 19)
        Me.btnModificarRegistro.Margin = New System.Windows.Forms.Padding(1)
        Me.btnModificarRegistro.Name = "btnModificarRegistro"
        Me.btnModificarRegistro.Size = New System.Drawing.Size(90, 39)
        Me.btnModificarRegistro.TabIndex = 6
        Me.btnModificarRegistro.Text = "Modificar"
        Me.btnModificarRegistro.UseVisualStyleBackColor = True
        '
        'btnAgregarRegistro
        '
        Me.btnAgregarRegistro.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarRegistro.Location = New System.Drawing.Point(2, 19)
        Me.btnAgregarRegistro.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAgregarRegistro.Name = "btnAgregarRegistro"
        Me.btnAgregarRegistro.Size = New System.Drawing.Size(68, 39)
        Me.btnAgregarRegistro.TabIndex = 5
        Me.btnAgregarRegistro.Text = "Nuevo"
        Me.btnAgregarRegistro.UseVisualStyleBackColor = True
        '
        'grbNavegacion
        '
        Me.grbNavegacion.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grbNavegacion.Controls.Add(Me.lblRegistrosRegistro)
        Me.grbNavegacion.Controls.Add(Me.btnUltimoRegistro)
        Me.grbNavegacion.Controls.Add(Me.btnSiguienteRegistro)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriorRegistro)
        Me.grbNavegacion.Controls.Add(Me.btnPrimeroRegistro)
        Me.grbNavegacion.Location = New System.Drawing.Point(10, 477)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Size = New System.Drawing.Size(275, 86)
        Me.grbNavegacion.TabIndex = 13
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblRegistrosRegistro
        '
        Me.lblRegistrosRegistro.AutoSize = True
        Me.lblRegistrosRegistro.Location = New System.Drawing.Point(86, 34)
        Me.lblRegistrosRegistro.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblRegistrosRegistro.Name = "lblRegistrosRegistro"
        Me.lblRegistrosRegistro.Size = New System.Drawing.Size(36, 13)
        Me.lblRegistrosRegistro.TabIndex = 4
        Me.lblRegistrosRegistro.Text = "x de n"
        '
        'btnUltimoRegistro
        '
        Me.btnUltimoRegistro.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoRegistro.Location = New System.Drawing.Point(226, 19)
        Me.btnUltimoRegistro.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUltimoRegistro.Name = "btnUltimoRegistro"
        Me.btnUltimoRegistro.Size = New System.Drawing.Size(44, 39)
        Me.btnUltimoRegistro.TabIndex = 3
        Me.btnUltimoRegistro.Text = ">|"
        Me.btnUltimoRegistro.UseVisualStyleBackColor = True
        '
        'btnSiguienteRegistro
        '
        Me.btnSiguienteRegistro.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteRegistro.Location = New System.Drawing.Point(187, 19)
        Me.btnSiguienteRegistro.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSiguienteRegistro.Name = "btnSiguienteRegistro"
        Me.btnSiguienteRegistro.Size = New System.Drawing.Size(41, 39)
        Me.btnSiguienteRegistro.TabIndex = 2
        Me.btnSiguienteRegistro.Text = ">"
        Me.btnSiguienteRegistro.UseVisualStyleBackColor = True
        '
        'btnAnteriorRegistro
        '
        Me.btnAnteriorRegistro.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorRegistro.Location = New System.Drawing.Point(42, 19)
        Me.btnAnteriorRegistro.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAnteriorRegistro.Name = "btnAnteriorRegistro"
        Me.btnAnteriorRegistro.Size = New System.Drawing.Size(41, 39)
        Me.btnAnteriorRegistro.TabIndex = 1
        Me.btnAnteriorRegistro.Text = "<"
        Me.btnAnteriorRegistro.UseVisualStyleBackColor = True
        '
        'btnPrimeroRegistro
        '
        Me.btnPrimeroRegistro.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeroRegistro.Location = New System.Drawing.Point(2, 19)
        Me.btnPrimeroRegistro.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPrimeroRegistro.Name = "btnPrimeroRegistro"
        Me.btnPrimeroRegistro.Size = New System.Drawing.Size(41, 39)
        Me.btnPrimeroRegistro.TabIndex = 0
        Me.btnPrimeroRegistro.Text = "|<"
        Me.btnPrimeroRegistro.UseVisualStyleBackColor = True
        '
        'grbDatosRegistro
        '
        Me.grbDatosRegistro.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grbDatosRegistro.Controls.Add(Me.txtCodigoAcompanante)
        Me.grbDatosRegistro.Controls.Add(Me.lblCodigoAcompanante)
        Me.grbDatosRegistro.Controls.Add(Me.Label11)
        Me.grbDatosRegistro.Controls.Add(Me.Label10)
        Me.grbDatosRegistro.Controls.Add(Me.lblTipo_SangreRegsitro)
        Me.grbDatosRegistro.Controls.Add(Me.txtTipo_SangreRegistro)
        Me.grbDatosRegistro.Controls.Add(Me.Label8)
        Me.grbDatosRegistro.Controls.Add(Me.TextBox1)
        Me.grbDatosRegistro.Controls.Add(Me.Label9)
        Me.grbDatosRegistro.Controls.Add(Me.TextBox2)
        Me.grbDatosRegistro.Controls.Add(Me.Button1)
        Me.grbDatosRegistro.Controls.Add(Me.PictureBox1)
        Me.grbDatosRegistro.Controls.Add(Me.Label7)
        Me.grbDatosRegistro.Controls.Add(Me.txtDireccionPaciente)
        Me.grbDatosRegistro.Controls.Add(Me.lblApellidoRegsitro)
        Me.grbDatosRegistro.Controls.Add(Me.txtApellidoRegistro)
        Me.grbDatosRegistro.Controls.Add(Me.Label4)
        Me.grbDatosRegistro.Controls.Add(Me.txtTelefonoAcompnante)
        Me.grbDatosRegistro.Controls.Add(Me.lblSexoAcompanante)
        Me.grbDatosRegistro.Controls.Add(Me.txtSexoAcompanante)
        Me.grbDatosRegistro.Controls.Add(Me.lblSexoRegsitro)
        Me.grbDatosRegistro.Controls.Add(Me.txtSexoRegistro)
        Me.grbDatosRegistro.Controls.Add(Me.lblFecha_NacimientoRegsitro)
        Me.grbDatosRegistro.Controls.Add(Me.txtNacimientoRegistro)
        Me.grbDatosRegistro.Controls.Add(Me.lblEmailCliente)
        Me.grbDatosRegistro.Controls.Add(Me.txtEmailPaciente)
        Me.grbDatosRegistro.Controls.Add(Me.lblTelefonoCliente)
        Me.grbDatosRegistro.Controls.Add(Me.txtEdadPaciente)
        Me.grbDatosRegistro.Controls.Add(Me.lblNombreRegsitro)
        Me.grbDatosRegistro.Controls.Add(Me.txtNombreRegistro)
        Me.grbDatosRegistro.Controls.Add(Me.txtCodigoRegistro)
        Me.grbDatosRegistro.Controls.Add(Me.lblCodigoRegistro)
        Me.grbDatosRegistro.Enabled = False
        Me.grbDatosRegistro.Location = New System.Drawing.Point(10, 10)
        Me.grbDatosRegistro.Margin = New System.Windows.Forms.Padding(1)
        Me.grbDatosRegistro.Name = "grbDatosRegistro"
        Me.grbDatosRegistro.Padding = New System.Windows.Forms.Padding(1)
        Me.grbDatosRegistro.Size = New System.Drawing.Size(1011, 465)
        Me.grbDatosRegistro.TabIndex = 10
        Me.grbDatosRegistro.TabStop = False
        Me.grbDatosRegistro.Text = "Datos del Paciente y Acompañante"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Algerian", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(653, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(207, 30)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Acompañante"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Algerian", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(73, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 30)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Paciente"
        '
        'lblTipo_SangreRegsitro
        '
        Me.lblTipo_SangreRegsitro.AutoSize = True
        Me.lblTipo_SangreRegsitro.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo_SangreRegsitro.Location = New System.Drawing.Point(95, 298)
        Me.lblTipo_SangreRegsitro.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblTipo_SangreRegsitro.Name = "lblTipo_SangreRegsitro"
        Me.lblTipo_SangreRegsitro.Size = New System.Drawing.Size(107, 16)
        Me.lblTipo_SangreRegsitro.TabIndex = 34
        Me.lblTipo_SangreRegsitro.Text = "Tipo de sangre:"
        '
        'txtTipo_SangreRegistro
        '
        Me.txtTipo_SangreRegistro.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipo_SangreRegistro.Location = New System.Drawing.Point(204, 298)
        Me.txtTipo_SangreRegistro.Margin = New System.Windows.Forms.Padding(1)
        Me.txtTipo_SangreRegistro.Name = "txtTipo_SangreRegistro"
        Me.txtTipo_SangreRegistro.Size = New System.Drawing.Size(203, 22)
        Me.txtTipo_SangreRegistro.TabIndex = 33
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(555, 148)
        Me.Label8.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 16)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Apellido:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(622, 148)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(267, 22)
        Me.TextBox1.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(551, 104)
        Me.Label9.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 16)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "NOMBRE:"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(621, 101)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(1)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(264, 22)
        Me.TextBox2.TabIndex = 29
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(42, 256)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 23)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(18, 78)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 169)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(541, 397)
        Me.Label7.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Direccion:"
        '
        'txtDireccionPaciente
        '
        Me.txtDireccionPaciente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccionPaciente.Location = New System.Drawing.Point(615, 394)
        Me.txtDireccionPaciente.Margin = New System.Windows.Forms.Padding(1)
        Me.txtDireccionPaciente.Multiline = True
        Me.txtDireccionPaciente.Name = "txtDireccionPaciente"
        Me.txtDireccionPaciente.Size = New System.Drawing.Size(380, 55)
        Me.txtDireccionPaciente.TabIndex = 23
        '
        'lblApellidoRegsitro
        '
        Me.lblApellidoRegsitro.AutoSize = True
        Me.lblApellidoRegsitro.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidoRegsitro.Location = New System.Drawing.Point(147, 204)
        Me.lblApellidoRegsitro.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblApellidoRegsitro.Name = "lblApellidoRegsitro"
        Me.lblApellidoRegsitro.Size = New System.Drawing.Size(65, 16)
        Me.lblApellidoRegsitro.TabIndex = 22
        Me.lblApellidoRegsitro.Text = "Apellido:"
        '
        'txtApellidoRegistro
        '
        Me.txtApellidoRegistro.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoRegistro.Location = New System.Drawing.Point(217, 204)
        Me.txtApellidoRegistro.Margin = New System.Windows.Forms.Padding(1)
        Me.txtApellidoRegistro.Name = "txtApellidoRegistro"
        Me.txtApellidoRegistro.Size = New System.Drawing.Size(273, 22)
        Me.txtApellidoRegistro.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(546, 295)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Telefono:"
        '
        'txtTelefonoAcompnante
        '
        Me.txtTelefonoAcompnante.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoAcompnante.Location = New System.Drawing.Point(615, 295)
        Me.txtTelefonoAcompnante.Margin = New System.Windows.Forms.Padding(1)
        Me.txtTelefonoAcompnante.Name = "txtTelefonoAcompnante"
        Me.txtTelefonoAcompnante.Size = New System.Drawing.Size(149, 22)
        Me.txtTelefonoAcompnante.TabIndex = 17
        '
        'lblSexoAcompanante
        '
        Me.lblSexoAcompanante.AutoSize = True
        Me.lblSexoAcompanante.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexoAcompanante.Location = New System.Drawing.Point(555, 245)
        Me.lblSexoAcompanante.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblSexoAcompanante.Name = "lblSexoAcompanante"
        Me.lblSexoAcompanante.Size = New System.Drawing.Size(45, 16)
        Me.lblSexoAcompanante.TabIndex = 16
        Me.lblSexoAcompanante.Text = "Sexo:"
        '
        'txtSexoAcompanante
        '
        Me.txtSexoAcompanante.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSexoAcompanante.Location = New System.Drawing.Point(615, 245)
        Me.txtSexoAcompanante.Margin = New System.Windows.Forms.Padding(1)
        Me.txtSexoAcompanante.Name = "txtSexoAcompanante"
        Me.txtSexoAcompanante.Size = New System.Drawing.Size(156, 22)
        Me.txtSexoAcompanante.TabIndex = 15
        '
        'lblSexoRegsitro
        '
        Me.lblSexoRegsitro.AutoSize = True
        Me.lblSexoRegsitro.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexoRegsitro.Location = New System.Drawing.Point(148, 256)
        Me.lblSexoRegsitro.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblSexoRegsitro.Name = "lblSexoRegsitro"
        Me.lblSexoRegsitro.Size = New System.Drawing.Size(45, 16)
        Me.lblSexoRegsitro.TabIndex = 14
        Me.lblSexoRegsitro.Text = "Sexo:"
        '
        'txtSexoRegistro
        '
        Me.txtSexoRegistro.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSexoRegistro.Location = New System.Drawing.Point(204, 256)
        Me.txtSexoRegistro.Margin = New System.Windows.Forms.Padding(1)
        Me.txtSexoRegistro.Name = "txtSexoRegistro"
        Me.txtSexoRegistro.Size = New System.Drawing.Size(203, 22)
        Me.txtSexoRegistro.TabIndex = 13
        '
        'lblFecha_NacimientoRegsitro
        '
        Me.lblFecha_NacimientoRegsitro.AutoSize = True
        Me.lblFecha_NacimientoRegsitro.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha_NacimientoRegsitro.Location = New System.Drawing.Point(15, 340)
        Me.lblFecha_NacimientoRegsitro.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblFecha_NacimientoRegsitro.Name = "lblFecha_NacimientoRegsitro"
        Me.lblFecha_NacimientoRegsitro.Size = New System.Drawing.Size(147, 16)
        Me.lblFecha_NacimientoRegsitro.TabIndex = 12
        Me.lblFecha_NacimientoRegsitro.Text = "Fecha de Nacimiento:"
        '
        'txtNacimientoRegistro
        '
        Me.txtNacimientoRegistro.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNacimientoRegistro.Location = New System.Drawing.Point(164, 340)
        Me.txtNacimientoRegistro.Margin = New System.Windows.Forms.Padding(1)
        Me.txtNacimientoRegistro.Name = "txtNacimientoRegistro"
        Me.txtNacimientoRegistro.Size = New System.Drawing.Size(243, 22)
        Me.txtNacimientoRegistro.TabIndex = 11
        '
        'lblEmailCliente
        '
        Me.lblEmailCliente.AutoSize = True
        Me.lblEmailCliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailCliente.Location = New System.Drawing.Point(561, 346)
        Me.lblEmailCliente.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblEmailCliente.Name = "lblEmailCliente"
        Me.lblEmailCliente.Size = New System.Drawing.Size(52, 16)
        Me.lblEmailCliente.TabIndex = 10
        Me.lblEmailCliente.Text = "EMAIL:"
        '
        'txtEmailPaciente
        '
        Me.txtEmailPaciente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailPaciente.Location = New System.Drawing.Point(615, 346)
        Me.txtEmailPaciente.Margin = New System.Windows.Forms.Padding(1)
        Me.txtEmailPaciente.Name = "txtEmailPaciente"
        Me.txtEmailPaciente.Size = New System.Drawing.Size(280, 22)
        Me.txtEmailPaciente.TabIndex = 9
        '
        'lblTelefonoCliente
        '
        Me.lblTelefonoCliente.AutoSize = True
        Me.lblTelefonoCliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoCliente.Location = New System.Drawing.Point(569, 195)
        Me.lblTelefonoCliente.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblTelefonoCliente.Name = "lblTelefonoCliente"
        Me.lblTelefonoCliente.Size = New System.Drawing.Size(44, 16)
        Me.lblTelefonoCliente.TabIndex = 8
        Me.lblTelefonoCliente.Text = "Edad:"
        '
        'txtEdadPaciente
        '
        Me.txtEdadPaciente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdadPaciente.Location = New System.Drawing.Point(625, 192)
        Me.txtEdadPaciente.Margin = New System.Windows.Forms.Padding(1)
        Me.txtEdadPaciente.Name = "txtEdadPaciente"
        Me.txtEdadPaciente.Size = New System.Drawing.Size(159, 22)
        Me.txtEdadPaciente.TabIndex = 7
        '
        'lblNombreRegsitro
        '
        Me.lblNombreRegsitro.AutoSize = True
        Me.lblNombreRegsitro.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreRegsitro.Location = New System.Drawing.Point(147, 153)
        Me.lblNombreRegsitro.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblNombreRegsitro.Name = "lblNombreRegsitro"
        Me.lblNombreRegsitro.Size = New System.Drawing.Size(68, 16)
        Me.lblNombreRegsitro.TabIndex = 4
        Me.lblNombreRegsitro.Text = "NOMBRE:"
        '
        'txtNombreRegistro
        '
        Me.txtNombreRegistro.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreRegistro.Location = New System.Drawing.Point(217, 153)
        Me.txtNombreRegistro.Margin = New System.Windows.Forms.Padding(1)
        Me.txtNombreRegistro.Name = "txtNombreRegistro"
        Me.txtNombreRegistro.Size = New System.Drawing.Size(273, 22)
        Me.txtNombreRegistro.TabIndex = 3
        '
        'txtCodigoRegistro
        '
        Me.txtCodigoRegistro.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoRegistro.Location = New System.Drawing.Point(217, 98)
        Me.txtCodigoRegistro.Margin = New System.Windows.Forms.Padding(1)
        Me.txtCodigoRegistro.Name = "txtCodigoRegistro"
        Me.txtCodigoRegistro.Size = New System.Drawing.Size(105, 22)
        Me.txtCodigoRegistro.TabIndex = 1
        '
        'lblCodigoRegistro
        '
        Me.lblCodigoRegistro.AutoSize = True
        Me.lblCodigoRegistro.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoRegistro.Location = New System.Drawing.Point(148, 104)
        Me.lblCodigoRegistro.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblCodigoRegistro.Name = "lblCodigoRegistro"
        Me.lblCodigoRegistro.Size = New System.Drawing.Size(64, 16)
        Me.lblCodigoRegistro.TabIndex = 0
        Me.lblCodigoRegistro.Text = "CODIGO:"
        '
        'txtCodigoAcompanante
        '
        Me.txtCodigoAcompanante.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoAcompanante.Location = New System.Drawing.Point(624, 58)
        Me.txtCodigoAcompanante.Margin = New System.Windows.Forms.Padding(1)
        Me.txtCodigoAcompanante.Name = "txtCodigoAcompanante"
        Me.txtCodigoAcompanante.Size = New System.Drawing.Size(105, 22)
        Me.txtCodigoAcompanante.TabIndex = 38
        '
        'lblCodigoAcompanante
        '
        Me.lblCodigoAcompanante.AutoSize = True
        Me.lblCodigoAcompanante.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoAcompanante.Location = New System.Drawing.Point(555, 64)
        Me.lblCodigoAcompanante.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblCodigoAcompanante.Name = "lblCodigoAcompanante"
        Me.lblCodigoAcompanante.Size = New System.Drawing.Size(64, 16)
        Me.lblCodigoAcompanante.TabIndex = 37
        Me.lblCodigoAcompanante.Text = "CODIGO:"
        '
        'FormRegistro_Acompañante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(1031, 576)
        Me.Controls.Add(Me.grbDatosRegistro)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormRegistro_Acompañante"
        Me.Text = "FormRegistro_Acompañante"
        Me.grbEdicion.ResumeLayout(False)
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.grbDatosRegistro.ResumeLayout(False)
        Me.grbDatosRegistro.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnBuscarRegistro As Button
    Friend WithEvents btnEliminarRegistro As Button
    Friend WithEvents btnModificarRegistro As Button
    Friend WithEvents btnAgregarRegistro As Button
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblRegistrosRegistro As Label
    Friend WithEvents btnUltimoRegistro As Button
    Friend WithEvents btnSiguienteRegistro As Button
    Friend WithEvents btnAnteriorRegistro As Button
    Friend WithEvents btnPrimeroRegistro As Button
    Friend WithEvents grbDatosRegistro As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDireccionPaciente As TextBox
    Friend WithEvents lblApellidoRegsitro As Label
    Friend WithEvents txtApellidoRegistro As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTelefonoAcompnante As TextBox
    Friend WithEvents lblSexoAcompanante As Label
    Friend WithEvents txtSexoAcompanante As TextBox
    Friend WithEvents lblSexoRegsitro As Label
    Friend WithEvents txtSexoRegistro As TextBox
    Friend WithEvents lblFecha_NacimientoRegsitro As Label
    Friend WithEvents txtNacimientoRegistro As TextBox
    Friend WithEvents lblEmailCliente As Label
    Friend WithEvents txtEmailPaciente As TextBox
    Friend WithEvents lblTelefonoCliente As Label
    Friend WithEvents txtEdadPaciente As TextBox
    Friend WithEvents lblNombreRegsitro As Label
    Friend WithEvents txtNombreRegistro As TextBox
    Friend WithEvents txtCodigoRegistro As TextBox
    Friend WithEvents lblCodigoRegistro As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblTipo_SangreRegsitro As Label
    Friend WithEvents txtTipo_SangreRegistro As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCodigoAcompanante As TextBox
    Friend WithEvents lblCodigoAcompanante As Label
End Class
