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
        Me.btnMediaAritmetica = New System.Windows.Forms.Button()
        Me.grdEstadistica = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbltotalf1 = New System.Windows.Forms.Label()
        Me.lblRespuestaMedia = New System.Windows.Forms.Label()
        Me.lbltotalx1xf1 = New System.Windows.Forms.Label()
        Me.lblRespuestaVarianza = New System.Windows.Forms.Label()
        Me.lbltotalx21xf1 = New System.Windows.Forms.Label()
        Me.lblRespuestaDesvTipica = New System.Windows.Forms.Label()
        Me.txtserie = New System.Windows.Forms.TextBox()
        CType(Me.grdEstadistica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMediaAritmetica
        '
        Me.btnMediaAritmetica.Location = New System.Drawing.Point(52, 400)
        Me.btnMediaAritmetica.Name = "btnMediaAritmetica"
        Me.btnMediaAritmetica.Size = New System.Drawing.Size(172, 38)
        Me.btnMediaAritmetica.TabIndex = 0
        Me.btnMediaAritmetica.Text = "Calculos estadisticos"
        Me.btnMediaAritmetica.UseVisualStyleBackColor = True
        '
        'grdEstadistica
        '
        Me.grdEstadistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdEstadistica.Location = New System.Drawing.Point(297, 37)
        Me.grdEstadistica.Name = "grdEstadistica"
        Me.grdEstadistica.RowHeadersWidth = 51
        Me.grdEstadistica.RowTemplate.Height = 24
        Me.grdEstadistica.Size = New System.Drawing.Size(491, 367)
        Me.grdEstadistica.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Serie:"
        '
        'lbltotalf1
        '
        Me.lbltotalf1.AutoSize = True
        Me.lbltotalf1.Location = New System.Drawing.Point(13, 80)
        Me.lbltotalf1.Name = "lbltotalf1"
        Me.lbltotalf1.Size = New System.Drawing.Size(50, 17)
        Me.lbltotalf1.TabIndex = 3
        Me.lbltotalf1.Text = "Media:"
        '
        'lblRespuestaMedia
        '
        Me.lblRespuestaMedia.AutoSize = True
        Me.lblRespuestaMedia.Location = New System.Drawing.Point(122, 80)
        Me.lblRespuestaMedia.Name = "lblRespuestaMedia"
        Me.lblRespuestaMedia.Size = New System.Drawing.Size(16, 17)
        Me.lblRespuestaMedia.TabIndex = 4
        Me.lblRespuestaMedia.Text = "?"
        '
        'lbltotalx1xf1
        '
        Me.lbltotalx1xf1.AutoSize = True
        Me.lbltotalx1xf1.Location = New System.Drawing.Point(13, 146)
        Me.lbltotalx1xf1.Name = "lbltotalx1xf1"
        Me.lbltotalx1xf1.Size = New System.Drawing.Size(68, 17)
        Me.lbltotalx1xf1.TabIndex = 5
        Me.lbltotalx1xf1.Text = "Varianza:"
        '
        'lblRespuestaVarianza
        '
        Me.lblRespuestaVarianza.AutoSize = True
        Me.lblRespuestaVarianza.Location = New System.Drawing.Point(122, 146)
        Me.lblRespuestaVarianza.Name = "lblRespuestaVarianza"
        Me.lblRespuestaVarianza.Size = New System.Drawing.Size(16, 17)
        Me.lblRespuestaVarianza.TabIndex = 6
        Me.lblRespuestaVarianza.Text = "?"
        '
        'lbltotalx21xf1
        '
        Me.lbltotalx21xf1.AutoSize = True
        Me.lbltotalx21xf1.Location = New System.Drawing.Point(13, 207)
        Me.lbltotalx21xf1.Name = "lbltotalx21xf1"
        Me.lbltotalx21xf1.Size = New System.Drawing.Size(90, 17)
        Me.lbltotalx21xf1.TabIndex = 7
        Me.lbltotalx21xf1.Text = "Desv. Tipica:"
        '
        'lblRespuestaDesvTipica
        '
        Me.lblRespuestaDesvTipica.AutoSize = True
        Me.lblRespuestaDesvTipica.Location = New System.Drawing.Point(122, 207)
        Me.lblRespuestaDesvTipica.Name = "lblRespuestaDesvTipica"
        Me.lblRespuestaDesvTipica.Size = New System.Drawing.Size(16, 17)
        Me.lblRespuestaDesvTipica.TabIndex = 8
        Me.lblRespuestaDesvTipica.Text = "?"
        '
        'txtserie
        '
        Me.txtserie.Location = New System.Drawing.Point(71, 18)
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(210, 22)
        Me.txtserie.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtserie)
        Me.Controls.Add(Me.lblRespuestaDesvTipica)
        Me.Controls.Add(Me.lbltotalx21xf1)
        Me.Controls.Add(Me.lblRespuestaVarianza)
        Me.Controls.Add(Me.lbltotalx1xf1)
        Me.Controls.Add(Me.lblRespuestaMedia)
        Me.Controls.Add(Me.lbltotalf1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdEstadistica)
        Me.Controls.Add(Me.btnMediaAritmetica)
        Me.Name = "Form1"
        Me.Text = "Calculadora Basica"
        CType(Me.grdEstadistica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMediaAritmetica As Button
    Friend WithEvents grdEstadistica As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lbltotalf1 As Label
    Friend WithEvents lblRespuestaMedia As Label
    Friend WithEvents lbltotalx1xf1 As Label
    Friend WithEvents lblRespuestaVarianza As Label
    Friend WithEvents lbltotalx21xf1 As Label
    Friend WithEvents lblRespuestaDesvTipica As Label
    Friend WithEvents txtserie As TextBox
End Class
