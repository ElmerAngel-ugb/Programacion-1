﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnMoneda
        '
        Me.BtnMoneda.Location = New System.Drawing.Point(83, 261)
        Me.BtnMoneda.Name = "BtnMoneda"
        Me.BtnMoneda.Size = New System.Drawing.Size(123, 34)
        Me.BtnMoneda.TabIndex = 0
        Me.BtnMoneda.Text = "Moneda"
        Me.BtnMoneda.UseVisualStyleBackColor = True
        '
        'Cbxsalida
        '
        Me.Cbxsalida.FormattingEnabled = True
        Me.Cbxsalida.Items.AddRange(New Object() {"Dólar estadounidense", "Quetzal", "Colon salvadoreño", "Colon costarricense", "Lempira", "Balboa", "Peso Mexicano", "Cordoba nicaraguense", "Euro", "Sol (peruano)"})
        Me.Cbxsalida.Location = New System.Drawing.Point(82, 202)
        Me.Cbxsalida.Name = "Cbxsalida"
        Me.Cbxsalida.Size = New System.Drawing.Size(147, 24)
        Me.Cbxsalida.TabIndex = 1
        '
        'Cbxentrada
        '
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
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label2.Location = New System.Drawing.Point(49, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 29)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "A"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(83, 78)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(147, 22)
        Me.TxtCodigo.TabIndex = 5
        '
        'Lblr
        '
        Me.Lblr.AutoSize = True
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
        Me.lblrespuesta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblrespuesta1.Location = New System.Drawing.Point(493, 229)
        Me.lblrespuesta1.Name = "lblrespuesta1"
        Me.lblrespuesta1.Size = New System.Drawing.Size(140, 29)
        Me.lblrespuesta1.TabIndex = 13
        Me.lblrespuesta1.Text = "Respuesta?"
        '
        'Txtcódigo1
        '
        Me.Txtcódigo1.Location = New System.Drawing.Point(399, 78)
        Me.Txtcódigo1.Name = "Txtcódigo1"
        Me.Txtcódigo1.Size = New System.Drawing.Size(147, 22)
        Me.Txtcódigo1.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
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
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(329, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 36)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Longitud"
        '
        'cbxentrada1
        '
        Me.cbxentrada1.FormattingEnabled = True
        Me.cbxentrada1.Items.AddRange(New Object() {"Milímetro", "Centímetro", "Metro", "Kilometros", "Pulgadas", "Pie", "Yarda", "Milla", "Decámetro", "Decímetro"})
        Me.cbxentrada1.Location = New System.Drawing.Point(398, 134)
        Me.cbxentrada1.Name = "cbxentrada1"
        Me.cbxentrada1.Size = New System.Drawing.Size(147, 24)
        Me.cbxentrada1.TabIndex = 9
        '
        'cbxsalida1
        '
        Me.cbxsalida1.FormattingEnabled = True
        Me.cbxsalida1.Items.AddRange(New Object() {"Milímetro", "Centímetro", "Metro", "Kilometros", "Pulgadas", "Pie", "Yarda", "Milla", "Decámetro", "Decímetro"})
        Me.cbxsalida1.Location = New System.Drawing.Point(398, 202)
        Me.cbxsalida1.Name = "cbxsalida1"
        Me.cbxsalida1.Size = New System.Drawing.Size(147, 24)
        Me.cbxsalida1.TabIndex = 8
        '
        'Btnlongitud1
        '
        Me.Btnlongitud1.Location = New System.Drawing.Point(423, 261)
        Me.Btnlongitud1.Name = "Btnlongitud1"
        Me.Btnlongitud1.Size = New System.Drawing.Size(123, 34)
        Me.Btnlongitud1.TabIndex = 7
        Me.Btnlongitud1.Text = "Longitud"
        Me.Btnlongitud1.UseVisualStyleBackColor = True
        '
        'lblnum
        '
        Me.lblnum.AutoSize = True
        Me.lblnum.Location = New System.Drawing.Point(635, 261)
        Me.lblnum.Name = "lblnum"
        Me.lblnum.Size = New System.Drawing.Size(20, 17)
        Me.lblnum.TabIndex = 14
        Me.lblnum.Text = "..."
        '
        'lblnum1
        '
        Me.lblnum1.AutoSize = True
        Me.lblnum1.Location = New System.Drawing.Point(272, 270)
        Me.lblnum1.Name = "lblnum1"
        Me.lblnum1.Size = New System.Drawing.Size(20, 17)
        Me.lblnum1.TabIndex = 15
        Me.lblnum1.Text = "..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(785, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 38)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Masa"
        '
        'Cbxentrada7
        '
        Me.Cbxentrada7.FormattingEnabled = True
        Me.Cbxentrada7.Items.AddRange(New Object() {"Tonelada", "Kilogramo", "Miligramo", "Microgramo", "Tonelada Larga", "Tonelada corta", "Stone", "Libra", "Onza"})
        Me.Cbxentrada7.Location = New System.Drawing.Point(774, 118)
        Me.Cbxentrada7.Name = "Cbxentrada7"
        Me.Cbxentrada7.Size = New System.Drawing.Size(163, 24)
        Me.Cbxentrada7.TabIndex = 17
        '
        'Cbxsalida7
        '
        Me.Cbxsalida7.FormattingEnabled = True
        Me.Cbxsalida7.Items.AddRange(New Object() {"Tonelada", "Kilogramo", "Miligramo", "Microgramo", "Tonelada Larga", "Tonelada corta", "Stone", "Libra", "Onza"})
        Me.Cbxsalida7.Location = New System.Drawing.Point(774, 196)
        Me.Cbxsalida7.Name = "Cbxsalida7"
        Me.Cbxsalida7.Size = New System.Drawing.Size(163, 24)
        Me.Cbxsalida7.TabIndex = 18
        '
        'Txtcodigo7
        '
        Me.Txtcodigo7.Location = New System.Drawing.Point(774, 72)
        Me.Txtcodigo7.Name = "Txtcodigo7"
        Me.Txtcodigo7.Size = New System.Drawing.Size(163, 22)
        Me.Txtcodigo7.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(730, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 24)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "A"
        '
        'Lblrespuesta7
        '
        Me.Lblrespuesta7.AutoSize = True
        Me.Lblrespuesta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Lblrespuesta7.Location = New System.Drawing.Point(914, 234)
        Me.Lblrespuesta7.Name = "Lblrespuesta7"
        Me.Lblrespuesta7.Size = New System.Drawing.Size(109, 24)
        Me.Lblrespuesta7.TabIndex = 21
        Me.Lblrespuesta7.Text = "Respuesta?"
        '
        'Lblnum7
        '
        Me.Lblnum7.AutoSize = True
        Me.Lblnum7.Location = New System.Drawing.Point(997, 255)
        Me.Lblnum7.Name = "Lblnum7"
        Me.Lblnum7.Size = New System.Drawing.Size(28, 17)
        Me.Lblnum7.TabIndex = 22
        Me.Lblnum7.Text = "....."
        '
        'BtnMasa
        '
        Me.BtnMasa.Location = New System.Drawing.Point(757, 255)
        Me.BtnMasa.Name = "BtnMasa"
        Me.BtnMasa.Size = New System.Drawing.Size(106, 33)
        Me.BtnMasa.TabIndex = 23
        Me.BtnMasa.Text = "Masa"
        Me.BtnMasa.UseVisualStyleBackColor = True
        '
        'Btnvolumen
        '
        Me.Btnvolumen.Location = New System.Drawing.Point(66, 544)
        Me.Btnvolumen.Name = "Btnvolumen"
        Me.Btnvolumen.Size = New System.Drawing.Size(106, 33)
        Me.Btnvolumen.TabIndex = 31
        Me.Btnvolumen.Text = "Volumen"
        Me.Btnvolumen.UseVisualStyleBackColor = True
        '
        'lblnum5
        '
        Me.lblnum5.AutoSize = True
        Me.lblnum5.Location = New System.Drawing.Point(306, 544)
        Me.lblnum5.Name = "lblnum5"
        Me.lblnum5.Size = New System.Drawing.Size(28, 17)
        Me.lblnum5.TabIndex = 30
        Me.lblnum5.Text = "....."
        '
        'lblrespuesta5
        '
        Me.lblrespuesta5.AutoSize = True
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
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(39, 456)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 24)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "A"
        '
        'Txtcódigo5
        '
        Me.Txtcódigo5.Location = New System.Drawing.Point(83, 361)
        Me.Txtcódigo5.Name = "Txtcódigo5"
        Me.Txtcódigo5.Size = New System.Drawing.Size(163, 22)
        Me.Txtcódigo5.TabIndex = 27
        '
        'cbxsalida5
        '
        Me.cbxsalida5.FormattingEnabled = True
        Me.cbxsalida5.Items.AddRange(New Object() {"Litros", "Mililitros", "Cucharada estadounidense", "Onza liquida imperial", "Pinta estadounidense", "Metro cubico", "Pulgada cúbica", "Pie cúbico", "Galón estadounidense", "Galón Imperial"})
        Me.cbxsalida5.Location = New System.Drawing.Point(83, 485)
        Me.cbxsalida5.Name = "cbxsalida5"
        Me.cbxsalida5.Size = New System.Drawing.Size(163, 24)
        Me.cbxsalida5.TabIndex = 26
        '
        'cbxentrada5
        '
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
        Me.Label10.Font = New System.Drawing.Font("Microsoft JhengHei UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(77, 322)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(149, 38)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Volumen"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(395, 556)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 33)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "Masa"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(655, 566)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 17)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "....."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label12.Location = New System.Drawing.Point(572, 545)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 24)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Respuesta?"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(368, 468)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 24)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "A"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(412, 373)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(163, 22)
        Me.TextBox2.TabIndex = 35
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Tonelada", "Kilogramo", "Miligramo", "Microgramo", "Tonelada Larga", "Tonelada corta", "Stone", "Libra", "Onza"})
        Me.ComboBox3.Location = New System.Drawing.Point(412, 497)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(163, 24)
        Me.ComboBox3.TabIndex = 34
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"Tonelada", "Kilogramo", "Miligramo", "Microgramo", "Tonelada Larga", "Tonelada corta", "Stone", "Libra", "Onza"})
        Me.ComboBox4.Location = New System.Drawing.Point(412, 419)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(163, 24)
        Me.ComboBox4.TabIndex = 33
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft JhengHei UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(406, 334)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 38)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Masa"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(774, 544)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(106, 33)
        Me.Button3.TabIndex = 47
        Me.Button3.Text = "Masa"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(1014, 544)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(28, 17)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = "....."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label16.Location = New System.Drawing.Point(931, 523)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(109, 24)
        Me.Label16.TabIndex = 45
        Me.Label16.Text = "Respuesta?"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(747, 456)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(24, 24)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "A"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(791, 363)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(163, 22)
        Me.TextBox3.TabIndex = 43
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"Tonelada", "Kilogramo", "Miligramo", "Microgramo", "Tonelada Larga", "Tonelada corta", "Stone", "Libra", "Onza"})
        Me.ComboBox5.Location = New System.Drawing.Point(791, 485)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(163, 24)
        Me.ComboBox5.TabIndex = 42
        '
        'ComboBox6
        '
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Items.AddRange(New Object() {"Tonelada", "Kilogramo", "Miligramo", "Microgramo", "Tonelada Larga", "Tonelada corta", "Stone", "Libra", "Onza"})
        Me.ComboBox6.Location = New System.Drawing.Point(791, 407)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(163, 24)
        Me.ComboBox6.TabIndex = 41
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft JhengHei UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(785, 322)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(95, 38)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "Masa"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1288, 689)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.ComboBox6)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox4)
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
    Friend WithEvents Button2 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents Label18 As Label
End Class
