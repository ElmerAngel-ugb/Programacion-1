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
        Me.lblnumero = New System.Windows.Forms.Label()
        Me.lstejercicios = New System.Windows.Forms.ListBox()
        Me.txtnum = New System.Windows.Forms.TextBox()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.btnPrimo = New System.Windows.Forms.Button()
        Me.btnCajero = New System.Windows.Forms.Button()
        Me.btnparimpar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblnumero
        '
        Me.lblnumero.AutoSize = True
        Me.lblnumero.Location = New System.Drawing.Point(83, 107)
        Me.lblnumero.Name = "lblnumero"
        Me.lblnumero.Size = New System.Drawing.Size(62, 17)
        Me.lblnumero.TabIndex = 0
        Me.lblnumero.Text = "Numero:"
        '
        'lstejercicios
        '
        Me.lstejercicios.FormattingEnabled = True
        Me.lstejercicios.ItemHeight = 16
        Me.lstejercicios.Location = New System.Drawing.Point(529, 30)
        Me.lstejercicios.Name = "lstejercicios"
        Me.lstejercicios.Size = New System.Drawing.Size(259, 340)
        Me.lstejercicios.TabIndex = 1
        '
        'txtnum
        '
        Me.txtnum.Location = New System.Drawing.Point(151, 102)
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(117, 22)
        Me.txtnum.TabIndex = 2
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(125, 360)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(125, 36)
        Me.btnProcesar.TabIndex = 3
        Me.btnProcesar.Text = "Par o"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'btnPrimo
        '
        Me.btnPrimo.Location = New System.Drawing.Point(288, 360)
        Me.btnPrimo.Name = "btnPrimo"
        Me.btnPrimo.Size = New System.Drawing.Size(88, 36)
        Me.btnPrimo.TabIndex = 4
        Me.btnPrimo.Text = "Primo?"
        Me.btnPrimo.UseVisualStyleBackColor = True
        '
        'btnCajero
        '
        Me.btnCajero.Location = New System.Drawing.Point(398, 360)
        Me.btnCajero.Name = "btnCajero"
        Me.btnCajero.Size = New System.Drawing.Size(97, 35)
        Me.btnCajero.TabIndex = 5
        Me.btnCajero.Text = "Cajero"
        Me.btnCajero.UseVisualStyleBackColor = True
        '
        'btnparimpar
        '
        Me.btnparimpar.Location = New System.Drawing.Point(599, 390)
        Me.btnparimpar.Name = "btnparimpar"
        Me.btnparimpar.Size = New System.Drawing.Size(189, 36)
        Me.btnparimpar.TabIndex = 6
        Me.btnparimpar.Text = "Numero Pares e"
        Me.btnparimpar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnparimpar)
        Me.Controls.Add(Me.btnCajero)
        Me.Controls.Add(Me.btnPrimo)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.txtnum)
        Me.Controls.Add(Me.lstejercicios)
        Me.Controls.Add(Me.lblnumero)
        Me.Name = "Form1"
        Me.Text = "Tablas de Multiplicación"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblnumero As Label
    Friend WithEvents lstejercicios As ListBox
    Friend WithEvents txtnum As TextBox
    Friend WithEvents btnProcesar As Button
    Friend WithEvents btnPrimo As Button
    Friend WithEvents btnCajero As Button
    Friend WithEvents btnparimpar As Button
End Class
