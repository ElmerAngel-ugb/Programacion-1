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
        Me.lblTabla = New System.Windows.Forms.Label()
        Me.lstTabla = New System.Windows.Forms.ListBox()
        Me.txtntabla = New System.Windows.Forms.TextBox()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTabla
        '
        Me.lblTabla.AutoSize = True
        Me.lblTabla.Location = New System.Drawing.Point(122, 66)
        Me.lblTabla.Name = "lblTabla"
        Me.lblTabla.Size = New System.Drawing.Size(43, 17)
        Me.lblTabla.TabIndex = 0
        Me.lblTabla.Text = "tabla:"
        '
        'lstTabla
        '
        Me.lstTabla.FormattingEnabled = True
        Me.lstTabla.ItemHeight = 16
        Me.lstTabla.Location = New System.Drawing.Point(529, 56)
        Me.lstTabla.Name = "lstTabla"
        Me.lstTabla.Size = New System.Drawing.Size(259, 340)
        Me.lstTabla.TabIndex = 1
        '
        'txtntabla
        '
        Me.txtntabla.Location = New System.Drawing.Point(162, 66)
        Me.txtntabla.Name = "txtntabla"
        Me.txtntabla.Size = New System.Drawing.Size(117, 22)
        Me.txtntabla.TabIndex = 2
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(90, 382)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(125, 36)
        Me.btnProcesar.TabIndex = 3
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.txtntabla)
        Me.Controls.Add(Me.lstTabla)
        Me.Controls.Add(Me.lblTabla)
        Me.Name = "Form1"
        Me.Text = "Tablas de Multiplicación"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTabla As Label
    Friend WithEvents lstTabla As ListBox
    Friend WithEvents txtntabla As TextBox
    Friend WithEvents btnProcesar As Button
End Class
