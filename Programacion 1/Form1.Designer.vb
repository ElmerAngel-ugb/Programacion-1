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
        Me.Cbxsalida.Items.AddRange(New Object() {"Dólar estadounidense", "Quetzal", "Colón Salvadoreño", "Colón costarricense", "Lempira ", "Balboa", "Peso Mexicano", "Córdoba nicaraguense", "Euro", "Sol (peruano)"})
        Me.Cbxsalida.Location = New System.Drawing.Point(82, 202)
        Me.Cbxsalida.Name = "Cbxsalida"
        Me.Cbxsalida.Size = New System.Drawing.Size(147, 24)
        Me.Cbxsalida.TabIndex = 1
        '
        'Cbxentrada
        '
        Me.Cbxentrada.FormattingEnabled = True
        Me.Cbxentrada.Items.AddRange(New Object() {"Dólar estadounidense", "Quetzal", "Colón Salvadoreño", "Colón costarricense", "Lempira ", "Balboa", "Peso Mexicano", "Córdoba nicaraguense", "Euro", "Sol (peruano)"})
        Me.Cbxentrada.Location = New System.Drawing.Point(83, 134)
        Me.Cbxentrada.Name = "Cbxentrada"
        Me.Cbxentrada.Size = New System.Drawing.Size(147, 24)
        Me.Cbxentrada.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(27, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 36)
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
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label5.Location = New System.Drawing.Point(329, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 36)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Longitud"
        '
        'cbxentrada1
        '
        Me.cbxentrada1.FormattingEnabled = True
        Me.cbxentrada1.Items.AddRange(New Object() {"Milímetro", "Centímetro", "Metro", "Kilómetros", "Pulgadas ", "Pie ", "Yarda ", "Milla", "Decámetro", "Decímetro"})
        Me.cbxentrada1.Location = New System.Drawing.Point(399, 134)
        Me.cbxentrada1.Name = "cbxentrada1"
        Me.cbxentrada1.Size = New System.Drawing.Size(147, 24)
        Me.cbxentrada1.TabIndex = 9
        '
        'cbxsalida1
        '
        Me.cbxsalida1.FormattingEnabled = True
        Me.cbxsalida1.Items.AddRange(New Object() {"Milímetro", "Centímetro", "Metro", "Kilómetros", "Pulgadas ", "Pie ", "Yarda ", "Milla", "Decámetro", "Decímetro"})
        Me.cbxsalida1.Location = New System.Drawing.Point(398, 202)
        Me.cbxsalida1.Name = "cbxsalida1"
        Me.cbxsalida1.Size = New System.Drawing.Size(147, 24)
        Me.cbxsalida1.TabIndex = 8
        '
        'Btnlongitud1
        '
        Me.Btnlongitud1.Location = New System.Drawing.Point(422, 261)
        Me.Btnlongitud1.Name = "Btnlongitud1"
        Me.Btnlongitud1.Size = New System.Drawing.Size(123, 34)
        Me.Btnlongitud1.TabIndex = 7
        Me.Btnlongitud1.Text = "Longitud"
        Me.Btnlongitud1.UseVisualStyleBackColor = True
        '
        'lblnum
        '
        Me.lblnum.AutoSize = True
        Me.lblnum.Location = New System.Drawing.Point(628, 239)
        Me.lblnum.Name = "lblnum"
        Me.lblnum.Size = New System.Drawing.Size(20, 17)
        Me.lblnum.TabIndex = 14
        Me.lblnum.Text = "..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 558)
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
End Class
