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
        Me.lblinteresCompuesto = New System.Windows.Forms.Label()
        Me.lblInteresSimple = New System.Windows.Forms.Label()
        Me.txtTiempo = New System.Windows.Forms.TextBox()
        Me.lbltiempo = New System.Windows.Forms.Label()
        Me.txtinteres = New System.Windows.Forms.TextBox()
        Me.lblinteres = New System.Windows.Forms.Label()
        Me.txtcapital = New System.Windows.Forms.TextBox()
        Me.lblcapital = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblinteresCompuesto
        '
        Me.lblinteresCompuesto.AutoSize = True
        Me.lblinteresCompuesto.Location = New System.Drawing.Point(503, 197)
        Me.lblinteresCompuesto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblinteresCompuesto.Name = "lblinteresCompuesto"
        Me.lblinteresCompuesto.Size = New System.Drawing.Size(142, 17)
        Me.lblinteresCompuesto.TabIndex = 17
        Me.lblinteresCompuesto.Text = "Interes Compuesto: ?"
        '
        'lblInteresSimple
        '
        Me.lblInteresSimple.AutoSize = True
        Me.lblInteresSimple.Location = New System.Drawing.Point(180, 197)
        Me.lblInteresSimple.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInteresSimple.Name = "lblInteresSimple"
        Me.lblInteresSimple.Size = New System.Drawing.Size(113, 17)
        Me.lblInteresSimple.TabIndex = 16
        Me.lblInteresSimple.Text = "Interes Simple: ?"
        '
        'txtTiempo
        '
        Me.txtTiempo.Location = New System.Drawing.Point(598, 100)
        Me.txtTiempo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTiempo.Name = "txtTiempo"
        Me.txtTiempo.Size = New System.Drawing.Size(64, 22)
        Me.txtTiempo.TabIndex = 15
        '
        'lbltiempo
        '
        Me.lbltiempo.AutoSize = True
        Me.lbltiempo.Location = New System.Drawing.Point(485, 101)
        Me.lbltiempo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltiempo.Name = "lbltiempo"
        Me.lbltiempo.Size = New System.Drawing.Size(105, 17)
        Me.lbltiempo.TabIndex = 14
        Me.lbltiempo.Text = "Tiempo (Años):"
        '
        'txtinteres
        '
        Me.txtinteres.Location = New System.Drawing.Point(400, 98)
        Me.txtinteres.Margin = New System.Windows.Forms.Padding(4)
        Me.txtinteres.Name = "txtinteres"
        Me.txtinteres.Size = New System.Drawing.Size(72, 22)
        Me.txtinteres.TabIndex = 13
        '
        'lblinteres
        '
        Me.lblinteres.AutoSize = True
        Me.lblinteres.Location = New System.Drawing.Point(337, 103)
        Me.lblinteres.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblinteres.Name = "lblinteres"
        Me.lblinteres.Size = New System.Drawing.Size(55, 17)
        Me.lblinteres.TabIndex = 12
        Me.lblinteres.Text = "Interes:"
        '
        'txtcapital
        '
        Me.txtcapital.Location = New System.Drawing.Point(165, 98)
        Me.txtcapital.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcapital.Name = "txtcapital"
        Me.txtcapital.Size = New System.Drawing.Size(135, 22)
        Me.txtcapital.TabIndex = 11
        '
        'lblcapital
        '
        Me.lblcapital.AutoSize = True
        Me.lblcapital.Location = New System.Drawing.Point(102, 98)
        Me.lblcapital.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcapital.Name = "lblcapital"
        Me.lblcapital.Size = New System.Drawing.Size(55, 17)
        Me.lblcapital.TabIndex = 10
        Me.lblcapital.Text = "Capital:"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(296, 265)
        Me.btnCalcular.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(197, 58)
        Me.btnCalcular.TabIndex = 9
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblinteresCompuesto)
        Me.Controls.Add(Me.lblInteresSimple)
        Me.Controls.Add(Me.txtTiempo)
        Me.Controls.Add(Me.lbltiempo)
        Me.Controls.Add(Me.txtinteres)
        Me.Controls.Add(Me.lblinteres)
        Me.Controls.Add(Me.txtcapital)
        Me.Controls.Add(Me.lblcapital)
        Me.Controls.Add(Me.btnCalcular)
        Me.Name = "Form1"
        Me.Text = "Tablas de Multiplicación"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblinteresCompuesto As Label
    Friend WithEvents lblInteresSimple As Label
    Friend WithEvents txtTiempo As TextBox
    Friend WithEvents lbltiempo As Label
    Friend WithEvents txtinteres As TextBox
    Friend WithEvents lblinteres As Label
    Friend WithEvents txtcapital As TextBox
    Friend WithEvents lblcapital As Label
    Friend WithEvents btnCalcular As Button
End Class
