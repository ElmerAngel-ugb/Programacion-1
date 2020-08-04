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
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblrespuesta = New System.Windows.Forms.Label()
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.txtnum2 = New System.Windows.Forms.TextBox()
        Me.optSuma = New System.Windows.Forms.RadioButton()
        Me.optResta = New System.Windows.Forms.RadioButton()
        Me.optMultiplicacion = New System.Windows.Forms.RadioButton()
        Me.optDivision = New System.Windows.Forms.RadioButton()
        Me.optPortsentaje = New System.Windows.Forms.RadioButton()
        Me.optExponenciacion = New System.Windows.Forms.RadioButton()
        Me.optMod = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(291, 288)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(117, 38)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(144, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "num1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(460, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "num2"
        '
        'lblrespuesta
        '
        Me.lblrespuesta.AutoSize = True
        Me.lblrespuesta.Location = New System.Drawing.Point(660, 76)
        Me.lblrespuesta.Name = "lblrespuesta"
        Me.lblrespuesta.Size = New System.Drawing.Size(92, 17)
        Me.lblrespuesta.TabIndex = 3
        Me.lblrespuesta.Text = "Respuesta¿?"
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(183, 76)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(100, 22)
        Me.txtnum1.TabIndex = 4
        '
        'txtnum2
        '
        Me.txtnum2.Location = New System.Drawing.Point(498, 75)
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(100, 22)
        Me.txtnum2.TabIndex = 5
        '
        'optSuma
        '
        Me.optSuma.AutoSize = True
        Me.optSuma.Location = New System.Drawing.Point(328, 76)
        Me.optSuma.Name = "optSuma"
        Me.optSuma.Size = New System.Drawing.Size(37, 21)
        Me.optSuma.TabIndex = 6
        Me.optSuma.TabStop = True
        Me.optSuma.Text = "+"
        Me.optSuma.UseVisualStyleBackColor = True
        '
        'optResta
        '
        Me.optResta.AutoSize = True
        Me.optResta.Location = New System.Drawing.Point(328, 104)
        Me.optResta.Name = "optResta"
        Me.optResta.Size = New System.Drawing.Size(34, 21)
        Me.optResta.TabIndex = 7
        Me.optResta.TabStop = True
        Me.optResta.Text = "-"
        Me.optResta.UseVisualStyleBackColor = True
        '
        'optMultiplicacion
        '
        Me.optMultiplicacion.AutoSize = True
        Me.optMultiplicacion.Location = New System.Drawing.Point(328, 132)
        Me.optMultiplicacion.Name = "optMultiplicacion"
        Me.optMultiplicacion.Size = New System.Drawing.Size(34, 21)
        Me.optMultiplicacion.TabIndex = 8
        Me.optMultiplicacion.TabStop = True
        Me.optMultiplicacion.Text = "*"
        Me.optMultiplicacion.UseVisualStyleBackColor = True
        '
        'optDivision
        '
        Me.optDivision.AutoSize = True
        Me.optDivision.Location = New System.Drawing.Point(328, 160)
        Me.optDivision.Name = "optDivision"
        Me.optDivision.Size = New System.Drawing.Size(33, 21)
        Me.optDivision.TabIndex = 9
        Me.optDivision.TabStop = True
        Me.optDivision.Text = "/"
        Me.optDivision.UseVisualStyleBackColor = True
        '
        'optPortsentaje
        '
        Me.optPortsentaje.AutoSize = True
        Me.optPortsentaje.Location = New System.Drawing.Point(328, 188)
        Me.optPortsentaje.Name = "optPortsentaje"
        Me.optPortsentaje.Size = New System.Drawing.Size(109, 21)
        Me.optPortsentaje.TabIndex = 10
        Me.optPortsentaje.TabStop = True
        Me.optPortsentaje.Text = "Porsentaje%"
        Me.optPortsentaje.UseVisualStyleBackColor = True
        '
        'optExponenciacion
        '
        Me.optExponenciacion.AutoSize = True
        Me.optExponenciacion.Location = New System.Drawing.Point(328, 216)
        Me.optExponenciacion.Name = "optExponenciacion"
        Me.optExponenciacion.Size = New System.Drawing.Size(36, 21)
        Me.optExponenciacion.TabIndex = 11
        Me.optExponenciacion.TabStop = True
        Me.optExponenciacion.Text = "^"
        Me.optExponenciacion.UseVisualStyleBackColor = True
        '
        'optMod
        '
        Me.optMod.AutoSize = True
        Me.optMod.Location = New System.Drawing.Point(328, 244)
        Me.optMod.Name = "optMod"
        Me.optMod.Size = New System.Drawing.Size(81, 21)
        Me.optMod.TabIndex = 12
        Me.optMod.TabStop = True
        Me.optMod.Text = "Residuo"
        Me.optMod.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.optMod)
        Me.Controls.Add(Me.optExponenciacion)
        Me.Controls.Add(Me.optPortsentaje)
        Me.Controls.Add(Me.optDivision)
        Me.Controls.Add(Me.optMultiplicacion)
        Me.Controls.Add(Me.optResta)
        Me.Controls.Add(Me.optSuma)
        Me.Controls.Add(Me.txtnum2)
        Me.Controls.Add(Me.txtnum1)
        Me.Controls.Add(Me.lblrespuesta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalcular)
        Me.Name = "Form1"
        Me.Text = "Calculadora Basica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalcular As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblrespuesta As Label
    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents txtnum2 As TextBox
    Friend WithEvents optSuma As RadioButton
    Friend WithEvents optResta As RadioButton
    Friend WithEvents optMultiplicacion As RadioButton
    Friend WithEvents optDivision As RadioButton
    Friend WithEvents optPortsentaje As RadioButton
    Friend WithEvents optExponenciacion As RadioButton
    Friend WithEvents optMod As RadioButton
End Class
