<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnConvertir = New System.Windows.Forms.Button()
        Me.lblrespuesta = New System.Windows.Forms.Label()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.cbotipo = New System.Windows.Forms.ComboBox()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.cboa = New System.Windows.Forms.ComboBox()
        Me.cbode = New System.Windows.Forms.ComboBox()
        Me.lbla = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnConvertir
        '
        Me.btnConvertir.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvertir.Location = New System.Drawing.Point(188, 249)
        Me.btnConvertir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(229, 90)
        Me.btnConvertir.TabIndex = 24
        Me.btnConvertir.Text = "Convertir"
        Me.btnConvertir.UseVisualStyleBackColor = True
        '
        'lblrespuesta
        '
        Me.lblrespuesta.AutoSize = True
        Me.lblrespuesta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrespuesta.Location = New System.Drawing.Point(485, 283)
        Me.lblrespuesta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblrespuesta.Name = "lblrespuesta"
        Me.lblrespuesta.Size = New System.Drawing.Size(135, 24)
        Me.lblrespuesta.TabIndex = 23
        Me.lblrespuesta.Text = "Respuesta: ?"
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(480, 186)
        Me.lblcantidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(68, 17)
        Me.lblcantidad.TabIndex = 22
        Me.lblcantidad.Text = "Cantidad:"
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(557, 182)
        Me.txtcantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(132, 22)
        Me.txtcantidad.TabIndex = 21
        '
        'cbotipo
        '
        Me.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotipo.FormattingEnabled = True
        Me.cbotipo.Items.AddRange(New Object() {"Monedas", "Longitud", "Masa", "Almacenamiento", "Tiempo"})
        Me.cbotipo.Location = New System.Drawing.Point(311, 112)
        Me.cbotipo.Margin = New System.Windows.Forms.Padding(4)
        Me.cbotipo.Name = "cbotipo"
        Me.cbotipo.Size = New System.Drawing.Size(160, 24)
        Me.cbotipo.TabIndex = 20
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Location = New System.Drawing.Point(261, 116)
        Me.lbltipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(40, 17)
        Me.lbltipo.TabIndex = 19
        Me.lbltipo.Text = "Tipo:"
        '
        'cboa
        '
        Me.cboa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboa.FormattingEnabled = True
        Me.cboa.Location = New System.Drawing.Point(311, 186)
        Me.cboa.Margin = New System.Windows.Forms.Padding(4)
        Me.cboa.Name = "cboa"
        Me.cboa.Size = New System.Drawing.Size(160, 24)
        Me.cboa.TabIndex = 18
        '
        'cbode
        '
        Me.cbode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbode.FormattingEnabled = True
        Me.cbode.Location = New System.Drawing.Point(111, 186)
        Me.cbode.Margin = New System.Windows.Forms.Padding(4)
        Me.cbode.Name = "cbode"
        Me.cbode.Size = New System.Drawing.Size(160, 24)
        Me.cbode.TabIndex = 17
        '
        'lbla
        '
        Me.lbla.AutoSize = True
        Me.lbla.Location = New System.Drawing.Point(280, 189)
        Me.lbla.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbla.Name = "lbla"
        Me.lbla.Size = New System.Drawing.Size(21, 17)
        Me.lbla.TabIndex = 16
        Me.lbla.Text = "A:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnConvertir)
        Me.Controls.Add(Me.lblrespuesta)
        Me.Controls.Add(Me.lblcantidad)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.cbotipo)
        Me.Controls.Add(Me.lbltipo)
        Me.Controls.Add(Me.cboa)
        Me.Controls.Add(Me.cbode)
        Me.Controls.Add(Me.lbla)
        Me.Name = "Form1"
        Me.Text = "Calculadora Basica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConvertir As Button
    Friend WithEvents lblrespuesta As Label
    Friend WithEvents lblcantidad As Label
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents cbotipo As ComboBox
    Friend WithEvents lbltipo As Label
    Friend WithEvents cboa As ComboBox
    Friend WithEvents cbode As ComboBox
    Friend WithEvents lbla As Label
End Class
