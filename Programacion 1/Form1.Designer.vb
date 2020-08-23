<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BtnMoneda = New System.Windows.Forms.Button()
        Me.Cbxsalida = New System.Windows.Forms.ComboBox()
        Me.Cbxentrada = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Lblr = New System.Windows.Forms.Label()
        Me.lblrespuesta1 = New System.Windows.Forms.Label()
        Me.Txtcódigo1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxentrada1 = New System.Windows.Forms.ComboBox()
        Me.cbxsalida1 = New System.Windows.Forms.ComboBox()
        Me.Btnlongitud1 = New System.Windows.Forms.Button()
        Me.lblnum = New System.Windows.Forms.Label()
        Me.lblnum1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cbxentrada7 = New System.Windows.Forms.ComboBox()
        Me.Cbxsalida7 = New System.Windows.Forms.ComboBox()
        Me.Txtcodigo7 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Lblrespuesta7 = New System.Windows.Forms.Label()
        Me.Lblnum7 = New System.Windows.Forms.Label()
        Me.BtnMasa = New System.Windows.Forms.Button()
        Me.Btnvolumen = New System.Windows.Forms.Button()
        Me.lblnum5 = New System.Windows.Forms.Label()
        Me.lblrespuesta5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txtcódigo5 = New System.Windows.Forms.TextBox()
        Me.cbxsalida5 = New System.Windows.Forms.ComboBox()
        Me.cbxentrada5 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnTiempo = New System.Windows.Forms.Button()
        Me.Lblnum2 = New System.Windows.Forms.Label()
        Me.Lblrespuesta2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtcodigo2 = New System.Windows.Forms.TextBox()
        Me.cbxsalida2 = New System.Windows.Forms.ComboBox()
        Me.cbxentrada2 = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Btnalmacenamiento = New System.Windows.Forms.Button()
        Me.lblnum8 = New System.Windows.Forms.Label()
        Me.lblr8 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtcodigo1 = New System.Windows.Forms.TextBox()
        Me.cbxsalida8 = New System.Windows.Forms.ComboBox()
        Me.cbxentrada8 = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnMoneda
        '
        Me.BtnMoneda.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BtnMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMoneda.Location = New System.Drawing.Point(83, 261)
        Me.BtnMoneda.Name = "BtnMoneda"
        Me.BtnMoneda.Size = New System.Drawing.Size(123, 34)
        Me.BtnMoneda.TabIndex = 0
        Me.BtnMoneda.Text = "Moneda"
        Me.BtnMoneda.UseVisualStyleBackColor = False
        '
        'Cbxsalida
        '
        Me.Cbxsalida.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Cbxsalida.FormattingEnabled = True
        Me.Cbxsalida.Items.AddRange(New Object() {"Dólar estadounidense", "Quetzal", "Colon salvadoreño", "Colon costarricense", "Lempira", "Balboa", "Peso Mexicano", "Cordoba nicaraguense", "Euro", "Sol (peruano)"})
        Me.Cbxsalida.Location = New System.Drawing.Point(82, 202)
        Me.Cbxsalida.Name = "Cbxsalida"
        Me.Cbxsalida.Size = New System.Drawing.Size(147, 24)
        Me.Cbxsalida.TabIndex = 1
        '
        'Cbxentrada
        '
        Me.Cbxentrada.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Cbxentrada.FormattingEnabled = True
        Me.Cbxentrada.Items.AddRange(New Object() {"Dolar estadounidense", "Quetzal", "Colon salvadoreño", "Colon costarricense", "Lempira", "Balboa", "Peso Mexicano", "Cordoba nicaraguense", "Euro", "Sol (peruano)"})
        Me.Cbxentrada.Location = New System.Drawing.Point(83, 134)
        Me.Cbxentrada.Name = "Cbxentrada"
        Me.Cbxentrada.Size = New System.Drawing.Size(147, 24)
        Me.Cbxentrada.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 36)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Moneda"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label2.Location = New System.Drawing.Point(49, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 29)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "A"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TxtCodigo.Location = New System.Drawing.Point(83, 78)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(147, 22)
        Me.TxtCodigo.TabIndex = 5
        '
        'Lblr
        '
        Me.Lblr.AutoSize = True
        Me.Lblr.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Lblr.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Lblr.Location = New System.Drawing.Point(161, 229)
        Me.Lblr.Name = "Lblr"
        Me.Lblr.Size = New System.Drawing.Size(140, 29)
        Me.Lblr.TabIndex = 6
        Me.Lblr.Text = "Respuesta?"
        '
        'lblrespuesta1
        '
        Me.lblrespuesta1.AutoSize = True
        Me.lblrespuesta1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblrespuesta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblrespuesta1.Location = New System.Drawing.Point(493, 229)
        Me.lblrespuesta1.Name = "lblrespuesta1"
        Me.lblrespuesta1.Size = New System.Drawing.Size(140, 29)
        Me.lblrespuesta1.TabIndex = 13
        Me.lblrespuesta1.Text = "Respuesta?"
        '
        'Txtcódigo1
        '
        Me.Txtcódigo1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Txtcódigo1.Location = New System.Drawing.Point(399, 78)
        Me.Txtcódigo1.Name = "Txtcódigo1"
        Me.Txtcódigo1.Size = New System.Drawing.Size(147, 22)
        Me.Txtcódigo1.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label4.Location = New System.Drawing.Point(367, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 29)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "A"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(329, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 36)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Longitud"
        '
        'cbxentrada1
        '
        Me.cbxentrada1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.cbxentrada1.FormattingEnabled = True
        Me.cbxentrada1.Items.AddRange(New Object() {"Milímetro", "Centímetro", "Metro", "Kilometros", "Pulgadas", "Pie", "Yarda", "Milla", "Decámetro", "Decímetro"})
        Me.cbxentrada1.Location = New System.Drawing.Point(398, 134)
        Me.cbxentrada1.Name = "cbxentrada1"
        Me.cbxentrada1.Size = New System.Drawing.Size(147, 24)
        Me.cbxentrada1.TabIndex = 9
        '
        'cbxsalida1
        '
        Me.cbxsalida1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.cbxsalida1.FormattingEnabled = True
        Me.cbxsalida1.Items.AddRange(New Object() {"Milímetro", "Centímetro", "Metro", "Kilometros", "Pulgadas", "Pie", "Yarda", "Milla", "Decámetro", "Decímetro"})
        Me.cbxsalida1.Location = New System.Drawing.Point(398, 202)
        Me.cbxsalida1.Name = "cbxsalida1"
        Me.cbxsalida1.Size = New System.Drawing.Size(147, 24)
        Me.cbxsalida1.TabIndex = 8
        '
        'Btnlongitud1
        '
        Me.Btnlongitud1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Btnlongitud1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnlongitud1.Location = New System.Drawing.Point(423, 261)
        Me.Btnlongitud1.Name = "Btnlongitud1"
        Me.Btnlongitud1.Size = New System.Drawing.Size(123, 34)
        Me.Btnlongitud1.TabIndex = 7
        Me.Btnlongitud1.Text = "Longitud"
        Me.Btnlongitud1.UseVisualStyleBackColor = False
        '
        'lblnum
        '
        Me.lblnum.AutoSize = True
        Me.lblnum.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblnum.Location = New System.Drawing.Point(635, 261)
        Me.lblnum.Name = "lblnum"
        Me.lblnum.Size = New System.Drawing.Size(20, 17)
        Me.lblnum.TabIndex = 14
        Me.lblnum.Text = "..."
        '
        'lblnum1
        '
        Me.lblnum1.AutoSize = True
        Me.lblnum1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblnum1.Location = New System.Drawing.Point(272, 270)
        Me.lblnum1.Name = "lblnum1"
        Me.lblnum1.Size = New System.Drawing.Size(20, 17)
        Me.lblnum1.TabIndex = 15
        Me.lblnum1.Text = "..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(785, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 38)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Masa"
        '
        'Cbxentrada7
        '
        Me.Cbxentrada7.BackColor = System.Drawing.SystemColors.Highlight
        Me.Cbxentrada7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cbxentrada7.FormattingEnabled = True
        Me.Cbxentrada7.Items.AddRange(New Object() {"Tonelada", "Kilogramo", "Miligramo", "Microgramo", "Tonelada Larga", "Tonelada corta", "Stone", "Libra", "Onza"})
        Me.Cbxentrada7.Location = New System.Drawing.Point(774, 118)
        Me.Cbxentrada7.Name = "Cbxentrada7"
        Me.Cbxentrada7.Size = New System.Drawing.Size(163, 24)
        Me.Cbxentrada7.TabIndex = 17
        '
        'Cbxsalida7
        '
        Me.Cbxsalida7.BackColor = System.Drawing.SystemColors.Highlight
        Me.Cbxsalida7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cbxsalida7.FormattingEnabled = True
        Me.Cbxsalida7.Items.AddRange(New Object() {"Tonelada", "Kilogramo", "Miligramo", "Microgramo", "Tonelada Larga", "Tonelada corta", "Stone", "Libra", "Onza"})
        Me.Cbxsalida7.Location = New System.Drawing.Point(774, 196)
        Me.Cbxsalida7.Name = "Cbxsalida7"
        Me.Cbxsalida7.Size = New System.Drawing.Size(163, 24)
        Me.Cbxsalida7.TabIndex = 18
        '
        'Txtcodigo7
        '
        Me.Txtcodigo7.BackColor = System.Drawing.SystemColors.Highlight
        Me.Txtcodigo7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Txtcodigo7.Location = New System.Drawing.Point(774, 72)
        Me.Txtcodigo7.Name = "Txtcodigo7"
        Me.Txtcodigo7.Size = New System.Drawing.Size(163, 22)
        Me.Txtcodigo7.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(730, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 24)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "A"
        '
        'Lblrespuesta7
        '
        Me.Lblrespuesta7.AutoSize = True
        Me.Lblrespuesta7.BackColor = System.Drawing.SystemColors.Highlight
        Me.Lblrespuesta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Lblrespuesta7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Lblrespuesta7.Location = New System.Drawing.Point(914, 234)
        Me.Lblrespuesta7.Name = "Lblrespuesta7"
        Me.Lblrespuesta7.Size = New System.Drawing.Size(109, 24)
        Me.Lblrespuesta7.TabIndex = 21
        Me.Lblrespuesta7.Text = "Respuesta?"
        '
        'Lblnum7
        '
        Me.Lblnum7.AutoSize = True
        Me.Lblnum7.BackColor = System.Drawing.SystemColors.Highlight
        Me.Lblnum7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Lblnum7.Location = New System.Drawing.Point(997, 255)
        Me.Lblnum7.Name = "Lblnum7"
        Me.Lblnum7.Size = New System.Drawing.Size(28, 17)
        Me.Lblnum7.TabIndex = 22
        Me.Lblnum7.Text = "....."
        '
        'BtnMasa
        '
        Me.BtnMasa.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnMasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMasa.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnMasa.Location = New System.Drawing.Point(757, 255)
        Me.BtnMasa.Name = "BtnMasa"
        Me.BtnMasa.Size = New System.Drawing.Size(106, 33)
        Me.BtnMasa.TabIndex = 23
        Me.BtnMasa.Text = "Masa"
        Me.BtnMasa.UseVisualStyleBackColor = False
        '
        'Btnvolumen
        '
        Me.Btnvolumen.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Btnvolumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnvolumen.Location = New System.Drawing.Point(66, 544)
        Me.Btnvolumen.Name = "Btnvolumen"
        Me.Btnvolumen.Size = New System.Drawing.Size(106, 33)
        Me.Btnvolumen.TabIndex = 31
        Me.Btnvolumen.Text = "Volumen"
        Me.Btnvolumen.UseVisualStyleBackColor = False
        '
        'lblnum5
        '
        Me.lblnum5.AutoSize = True
        Me.lblnum5.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblnum5.Location = New System.Drawing.Point(306, 544)
        Me.lblnum5.Name = "lblnum5"
        Me.lblnum5.Size = New System.Drawing.Size(28, 17)
        Me.lblnum5.TabIndex = 30
        Me.lblnum5.Text = "....."
        '
        'lblrespuesta5
        '
        Me.lblrespuesta5.AutoSize = True
        Me.lblrespuesta5.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblrespuesta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblrespuesta5.Location = New System.Drawing.Point(223, 523)
        Me.lblrespuesta5.Name = "lblrespuesta5"
        Me.lblrespuesta5.Size = New System.Drawing.Size(109, 24)
        Me.lblrespuesta5.TabIndex = 29
        Me.lblrespuesta5.Text = "Respuesta?"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(39, 456)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 24)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "A"
        '
        'Txtcódigo5
        '
        Me.Txtcódigo5.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Txtcódigo5.Location = New System.Drawing.Point(83, 361)
        Me.Txtcódigo5.Name = "Txtcódigo5"
        Me.Txtcódigo5.Size = New System.Drawing.Size(163, 22)
        Me.Txtcódigo5.TabIndex = 27
        '
        'cbxsalida5
        '
        Me.cbxsalida5.BackColor = System.Drawing.SystemColors.ControlDark
        Me.cbxsalida5.FormattingEnabled = True
        Me.cbxsalida5.Items.AddRange(New Object() {"Litros", "Mililitros", "Cucharada estadounidense", "Onza liquida imperial", "Pinta estadounidense", "Metro cubico", "Pulgada cúbica", "Pie cúbico", "Galón estadounidense", "Galón Imperial"})
        Me.cbxsalida5.Location = New System.Drawing.Point(83, 485)
        Me.cbxsalida5.Name = "cbxsalida5"
        Me.cbxsalida5.Size = New System.Drawing.Size(163, 24)
        Me.cbxsalida5.TabIndex = 26
        '
        'cbxentrada5
        '
        Me.cbxentrada5.BackColor = System.Drawing.SystemColors.ControlDark
        Me.cbxentrada5.FormattingEnabled = True
        Me.cbxentrada5.Items.AddRange(New Object() {"Litros", "Mililitros", "Cucharada estadounidense", "Onza liquida imperial", "Pinta estadounidense", "Metro cubico", "Pulgada cúbica", "Pie cúbico", "Galón estadounidense", "Galón Imperial"})
        Me.cbxentrada5.Location = New System.Drawing.Point(83, 407)
        Me.cbxentrada5.Name = "cbxentrada5"
        Me.cbxentrada5.Size = New System.Drawing.Size(163, 24)
        Me.cbxentrada5.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label10.Font = New System.Drawing.Font("Microsoft JhengHei UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(77, 322)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(149, 38)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Volumen"
        '
        'BtnTiempo
        '
        Me.BtnTiempo.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnTiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTiempo.Location = New System.Drawing.Point(395, 556)
        Me.BtnTiempo.Name = "BtnTiempo"
        Me.BtnTiempo.Size = New System.Drawing.Size(106, 33)
        Me.BtnTiempo.TabIndex = 39
        Me.BtnTiempo.Text = "Tiempo"
        Me.BtnTiempo.UseVisualStyleBackColor = False
        '
        'Lblnum2
        '
        Me.Lblnum2.AutoSize = True
        Me.Lblnum2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Lblnum2.Location = New System.Drawing.Point(655, 566)
        Me.Lblnum2.Name = "Lblnum2"
        Me.Lblnum2.Size = New System.Drawing.Size(28, 17)
        Me.Lblnum2.TabIndex = 38
        Me.Lblnum2.Text = "....."
        '
        'Lblrespuesta2
        '
        Me.Lblrespuesta2.AutoSize = True
        Me.Lblrespuesta2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Lblrespuesta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Lblrespuesta2.Location = New System.Drawing.Point(572, 545)
        Me.Lblrespuesta2.Name = "Lblrespuesta2"
        Me.Lblrespuesta2.Size = New System.Drawing.Size(109, 24)
        Me.Lblrespuesta2.TabIndex = 37
        Me.Lblrespuesta2.Text = "Respuesta?"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(368, 468)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 24)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "A"
        '
        'txtcodigo2
        '
        Me.txtcodigo2.BackColor = System.Drawing.SystemColors.Highlight
        Me.txtcodigo2.Location = New System.Drawing.Point(412, 373)
        Me.txtcodigo2.Name = "txtcodigo2"
        Me.txtcodigo2.Size = New System.Drawing.Size(163, 22)
        Me.txtcodigo2.TabIndex = 35
        '
        'cbxsalida2
        '
        Me.cbxsalida2.BackColor = System.Drawing.SystemColors.Highlight
        Me.cbxsalida2.FormattingEnabled = True
        Me.cbxsalida2.Items.AddRange(New Object() {"Nanosegundos", "Microsegundos", "Milisegundos", "Segundos", "Minutos", "Horas", "Días", "Semanas", "Mes ", "Año natural"})
        Me.cbxsalida2.Location = New System.Drawing.Point(412, 497)
        Me.cbxsalida2.Name = "cbxsalida2"
        Me.cbxsalida2.Size = New System.Drawing.Size(163, 24)
        Me.cbxsalida2.TabIndex = 34
        '
        'cbxentrada2
        '
        Me.cbxentrada2.BackColor = System.Drawing.SystemColors.Highlight
        Me.cbxentrada2.FormattingEnabled = True
        Me.cbxentrada2.Items.AddRange(New Object() {"Nanosegundos", "Microsegundos", "Milisegundos", "Segundos", "Minutos", "Horas", "Días", "Semanas", "Mes ", "Año natural"})
        Me.cbxentrada2.Location = New System.Drawing.Point(412, 419)
        Me.cbxentrada2.Name = "cbxentrada2"
        Me.cbxentrada2.Size = New System.Drawing.Size(163, 24)
        Me.cbxentrada2.TabIndex = 33
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label14.Font = New System.Drawing.Font("Microsoft JhengHei UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(406, 334)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(127, 38)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Tiempo"
        '
        'Btnalmacenamiento
        '
        Me.Btnalmacenamiento.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Btnalmacenamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnalmacenamiento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btnalmacenamiento.Location = New System.Drawing.Point(774, 544)
        Me.Btnalmacenamiento.Name = "Btnalmacenamiento"
        Me.Btnalmacenamiento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btnalmacenamiento.Size = New System.Drawing.Size(106, 33)
        Me.Btnalmacenamiento.TabIndex = 47
        Me.Btnalmacenamiento.Text = "Almacenamiento"
        Me.Btnalmacenamiento.UseVisualStyleBackColor = False
        '
        'lblnum8
        '
        Me.lblnum8.AutoSize = True
        Me.lblnum8.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblnum8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblnum8.Location = New System.Drawing.Point(1014, 544)
        Me.lblnum8.Name = "lblnum8"
        Me.lblnum8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblnum8.Size = New System.Drawing.Size(28, 17)
        Me.lblnum8.TabIndex = 46
        Me.lblnum8.Text = "....."
        '
        'lblr8
        '
        Me.lblr8.AutoSize = True
        Me.lblr8.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblr8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblr8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblr8.Location = New System.Drawing.Point(931, 523)
        Me.lblr8.Name = "lblr8"
        Me.lblr8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblr8.Size = New System.Drawing.Size(109, 24)
        Me.lblr8.TabIndex = 45
        Me.lblr8.Text = "Respuesta?"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label17.Location = New System.Drawing.Point(770, 444)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(24, 24)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "A"
        '
        'txtcodigo1
        '
        Me.txtcodigo1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtcodigo1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtcodigo1.Location = New System.Drawing.Point(791, 363)
        Me.txtcodigo1.Name = "txtcodigo1"
        Me.txtcodigo1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtcodigo1.Size = New System.Drawing.Size(163, 22)
        Me.txtcodigo1.TabIndex = 43
        '
        'cbxsalida8
        '
        Me.cbxsalida8.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cbxsalida8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbxsalida8.FormattingEnabled = True
        Me.cbxsalida8.Items.AddRange(New Object() {"Kilobyte", "Megabyte", "Gigabyte", "Terabyte", "Petabyte", "Exabyte", "Zettabyte", "Yottabyte", "Bit", "Kibibit"})
        Me.cbxsalida8.Location = New System.Drawing.Point(791, 485)
        Me.cbxsalida8.Name = "cbxsalida8"
        Me.cbxsalida8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbxsalida8.Size = New System.Drawing.Size(163, 24)
        Me.cbxsalida8.TabIndex = 42
        '
        'cbxentrada8
        '
        Me.cbxentrada8.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cbxentrada8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbxentrada8.FormattingEnabled = True
        Me.cbxentrada8.Items.AddRange(New Object() {"Kilobyte", "Megabyte", "Gigabyte", "Terabyte", "Petabyte", "Exabyte", "Zettabyte", "Yottabyte", "Bit", "Kibibit"})
        Me.cbxentrada8.Location = New System.Drawing.Point(791, 407)
        Me.cbxentrada8.Name = "cbxentrada8"
        Me.cbxentrada8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbxentrada8.Size = New System.Drawing.Size(163, 24)
        Me.cbxentrada8.TabIndex = 41
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label18.Font = New System.Drawing.Font("Microsoft JhengHei UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(785, 322)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(265, 38)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "Almacenamiento"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1288, 689)
        Me.Controls.Add(Me.Btnalmacenamiento)
        Me.Controls.Add(Me.lblnum8)
        Me.Controls.Add(Me.lblr8)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtcodigo1)
        Me.Controls.Add(Me.cbxsalida8)
        Me.Controls.Add(Me.cbxentrada8)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.BtnTiempo)
        Me.Controls.Add(Me.Lblnum2)
        Me.Controls.Add(Me.Lblrespuesta2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtcodigo2)
        Me.Controls.Add(Me.cbxsalida2)
        Me.Controls.Add(Me.cbxentrada2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Btnvolumen)
        Me.Controls.Add(Me.lblnum5)
        Me.Controls.Add(Me.lblrespuesta5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Txtcódigo5)
        Me.Controls.Add(Me.cbxsalida5)
        Me.Controls.Add(Me.cbxentrada5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BtnMasa)
        Me.Controls.Add(Me.Lblnum7)
        Me.Controls.Add(Me.Lblrespuesta7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Txtcodigo7)
        Me.Controls.Add(Me.Cbxsalida7)
        Me.Controls.Add(Me.Cbxentrada7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblnum1)
        Me.Controls.Add(Me.lblnum)
        Me.Controls.Add(Me.lblrespuesta1)
        Me.Controls.Add(Me.Txtcódigo1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbxentrada1)
        Me.Controls.Add(Me.cbxsalida1)
        Me.Controls.Add(Me.Btnlongitud1)
        Me.Controls.Add(Me.Lblr)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cbxentrada)
        Me.Controls.Add(Me.Cbxsalida)
        Me.Controls.Add(Me.BtnMoneda)
        Me.Name = "Form1"
        Me.Text = "Conversores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnMoneda As Button
    Friend WithEvents Cbxsalida As ComboBox
    Friend WithEvents Cbxentrada As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents Lblr As Label
    Friend WithEvents lblrespuesta1 As Label
    Friend WithEvents Txtcódigo1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbxentrada1 As ComboBox
    Friend WithEvents cbxsalida1 As ComboBox
    Friend WithEvents Btnlongitud1 As Button
    Friend WithEvents lblnum As Label
    Friend WithEvents lblnum1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Cbxentrada7 As ComboBox
    Friend WithEvents Cbxsalida7 As ComboBox
    Friend WithEvents Txtcodigo7 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Lblrespuesta7 As Label
    Friend WithEvents Lblnum7 As Label
    Friend WithEvents BtnMasa As Button
    Friend WithEvents Btnvolumen As Button
    Friend WithEvents lblnum5 As Label
    Friend WithEvents lblrespuesta5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Txtcódigo5 As TextBox
    Friend WithEvents cbxsalida5 As ComboBox
    Friend WithEvents cbxentrada5 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnTiempo As Button
    Friend WithEvents Lblnum2 As Label
    Friend WithEvents Lblrespuesta2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtcodigo2 As TextBox
    Friend WithEvents cbxsalida2 As ComboBox
    Friend WithEvents cbxentrada2 As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Btnalmacenamiento As Button
    Friend WithEvents lblnum8 As Label
    Friend WithEvents lblr8 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtcodigo1 As TextBox
    Friend WithEvents cbxsalida8 As ComboBox
    Friend WithEvents cbxentrada8 As ComboBox
    Friend WithEvents Label18 As Label
End Class
