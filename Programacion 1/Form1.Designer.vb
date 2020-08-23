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
        Me.Label3.Location = New System.Drawing.Point(726, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 38)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Masa"
        '
        'Cbxentrada7
        '
        Me.Cbxentrada7.FormattingEnabled = True
        Me.Cbxentrada7.Items.AddRange(New Object() {"Tonelada", "Kilogramo", "Miligramo", "Microgramo", "Tonelada Larga", "Tonelada corta", "Stone", "Libra", "Onza"})
        Me.Cbxentrada7.Location = New System.Drawing.Point(732, 124)
        Me.Cbxentrada7.Name = "Cbxentrada7"
        Me.Cbxentrada7.Size = New System.Drawing.Size(163, 24)
        Me.Cbxentrada7.TabIndex = 17
        '
        'Cbxsalida7
        '
        Me.Cbxsalida7.FormattingEnabled = True
        Me.Cbxsalida7.Items.AddRange(New Object() {"Tonelada", "Kilogramo", "Miligramo", "Microgramo", "Tonelada Larga", "Tonelada corta", "Stone", "Libra", "Onza"})
        Me.Cbxsalida7.Location = New System.Drawing.Point(732, 202)
        Me.Cbxsalida7.Name = "Cbxsalida7"
        Me.Cbxsalida7.Size = New System.Drawing.Size(163, 24)
        Me.Cbxsalida7.TabIndex = 18
        '
        'Txtcodigo7
        '
        Me.Txtcodigo7.Location = New System.Drawing.Point(732, 78)
        Me.Txtcodigo7.Name = "Txtcodigo7"
        Me.Txtcodigo7.Size = New System.Drawing.Size(163, 22)
        Me.Txtcodigo7.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(688, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 24)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "A"
        '
        'Lblrespuesta7
        '
        Me.Lblrespuesta7.AutoSize = True
        Me.Lblrespuesta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Lblrespuesta7.Location = New System.Drawing.Point(872, 240)
        Me.Lblrespuesta7.Name = "Lblrespuesta7"
        Me.Lblrespuesta7.Size = New System.Drawing.Size(109, 24)
        Me.Lblrespuesta7.TabIndex = 21
        Me.Lblrespuesta7.Text = "Respuesta?"
        '
        'Lblnum7
        '
        Me.Lblnum7.AutoSize = True
        Me.Lblnum7.Location = New System.Drawing.Point(955, 261)
        Me.Lblnum7.Name = "Lblnum7"
        Me.Lblnum7.Size = New System.Drawing.Size(28, 17)
        Me.Lblnum7.TabIndex = 22
        Me.Lblnum7.Text = "....."
        '
        'BtnMasa
        '
        Me.BtnMasa.Location = New System.Drawing.Point(715, 261)
        Me.BtnMasa.Name = "BtnMasa"
        Me.BtnMasa.Size = New System.Drawing.Size(106, 33)
        Me.BtnMasa.TabIndex = 23
        Me.BtnMasa.Text = "Masa"
        Me.BtnMasa.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1233, 558)
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
End Class
