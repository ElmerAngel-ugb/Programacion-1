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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.lbldescripcion = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.lblprecio = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.txtmedicamento = New System.Windows.Forms.TextBox()
        Me.lblnommedicamento = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.txtidmedicamento = New System.Windows.Forms.TextBox()
        Me.lblmedicamento = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnnavegar1 = New System.Windows.Forms.Button()
        Me.btnnavegar2 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.lblnum1 = New System.Windows.Forms.Label()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtdescripcion)
        Me.GroupBox1.Controls.Add(Me.lbldescripcion)
        Me.GroupBox1.Controls.Add(Me.txtprecio)
        Me.GroupBox1.Controls.Add(Me.lblprecio)
        Me.GroupBox1.Controls.Add(Me.txtcantidad)
        Me.GroupBox1.Controls.Add(Me.lblcantidad)
        Me.GroupBox1.Controls.Add(Me.txtmedicamento)
        Me.GroupBox1.Controls.Add(Me.lblnommedicamento)
        Me.GroupBox1.Controls.Add(Me.txtcodigo)
        Me.GroupBox1.Controls.Add(Me.lblcodigo)
        Me.GroupBox1.Controls.Add(Me.txtidmedicamento)
        Me.GroupBox1.Controls.Add(Me.lblmedicamento)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(921, 488)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Medicamentos."
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(242, 295)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(146, 27)
        Me.txtdescripcion.TabIndex = 23
        '
        'lbldescripcion
        '
        Me.lbldescripcion.AutoSize = True
        Me.lbldescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescripcion.Location = New System.Drawing.Point(120, 295)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(116, 20)
        Me.lbldescripcion.TabIndex = 22
        Me.lbldescripcion.Text = "Descripcion:"
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(195, 234)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(146, 27)
        Me.txtprecio.TabIndex = 21
        '
        'lblprecio
        '
        Me.lblprecio.AutoSize = True
        Me.lblprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprecio.Location = New System.Drawing.Point(120, 234)
        Me.lblprecio.Name = "lblprecio"
        Me.lblprecio.Size = New System.Drawing.Size(69, 20)
        Me.lblprecio.TabIndex = 20
        Me.lblprecio.Text = "Precio:"
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(268, 181)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(146, 27)
        Me.txtcantidad.TabIndex = 19
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcantidad.Location = New System.Drawing.Point(120, 181)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(149, 20)
        Me.lblcantidad.TabIndex = 18
        Me.lblcantidad.Text = "Cant_disponible:"
        '
        'txtmedicamento
        '
        Me.txtmedicamento.Location = New System.Drawing.Point(253, 124)
        Me.txtmedicamento.Name = "txtmedicamento"
        Me.txtmedicamento.Size = New System.Drawing.Size(146, 27)
        Me.txtmedicamento.TabIndex = 17
        '
        'lblnommedicamento
        '
        Me.lblnommedicamento.AutoSize = True
        Me.lblnommedicamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnommedicamento.Location = New System.Drawing.Point(120, 124)
        Me.lblnommedicamento.Name = "lblnommedicamento"
        Me.lblnommedicamento.Size = New System.Drawing.Size(126, 20)
        Me.lblnommedicamento.TabIndex = 16
        Me.lblnommedicamento.Text = "Medicamento:"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(201, 83)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(146, 27)
        Me.txtcodigo.TabIndex = 15
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodigo.Location = New System.Drawing.Point(121, 83)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(73, 20)
        Me.lblcodigo.TabIndex = 14
        Me.lblcodigo.Text = "Codigo:"
        '
        'txtidmedicamento
        '
        Me.txtidmedicamento.Location = New System.Drawing.Point(268, 40)
        Me.txtidmedicamento.Name = "txtidmedicamento"
        Me.txtidmedicamento.Size = New System.Drawing.Size(131, 27)
        Me.txtidmedicamento.TabIndex = 13
        '
        'lblmedicamento
        '
        Me.lblmedicamento.AutoSize = True
        Me.lblmedicamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmedicamento.Location = New System.Drawing.Point(120, 40)
        Me.lblmedicamento.Name = "lblmedicamento"
        Me.lblmedicamento.Size = New System.Drawing.Size(141, 20)
        Me.lblmedicamento.TabIndex = 12
        Me.lblmedicamento.Text = "idmedicamento:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblnum1)
        Me.GroupBox2.Controls.Add(Me.btn2)
        Me.GroupBox2.Controls.Add(Me.btnnavegar2)
        Me.GroupBox2.Controls.Add(Me.btn1)
        Me.GroupBox2.Controls.Add(Me.btnnavegar1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 404)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(382, 69)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "navegar"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnbuscar)
        Me.GroupBox3.Controls.Add(Me.btneliminar)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.btnnuevo)
        Me.GroupBox3.Location = New System.Drawing.Point(439, 404)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(445, 69)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Editar."
        '
        'btnnavegar1
        '
        Me.btnnavegar1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnnavegar1.Location = New System.Drawing.Point(0, 26)
        Me.btnnavegar1.Name = "btnnavegar1"
        Me.btnnavegar1.Size = New System.Drawing.Size(65, 37)
        Me.btnnavegar1.TabIndex = 26
        Me.btnnavegar1.Text = "l<"
        Me.btnnavegar1.UseVisualStyleBackColor = False
        '
        'btnnavegar2
        '
        Me.btnnavegar2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnnavegar2.Location = New System.Drawing.Point(71, 26)
        Me.btnnavegar2.Name = "btnnavegar2"
        Me.btnnavegar2.Size = New System.Drawing.Size(65, 37)
        Me.btnnavegar2.TabIndex = 27
        Me.btnnavegar2.Text = "<"
        Me.btnnavegar2.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn2.Location = New System.Drawing.Point(307, 26)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(60, 37)
        Me.btn2.TabIndex = 29
        Me.btn2.Text = ">l"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn1.Location = New System.Drawing.Point(241, 26)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(60, 37)
        Me.btn1.TabIndex = 28
        Me.btn1.Text = ">"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'lblnum1
        '
        Me.lblnum1.AutoSize = True
        Me.lblnum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnum1.Location = New System.Drawing.Point(154, 43)
        Me.lblnum1.Name = "lblnum1"
        Me.lblnum1.Size = New System.Drawing.Size(54, 17)
        Me.lblnum1.TabIndex = 30
        Me.lblnum1.Text = "1 de n"
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnnuevo.Location = New System.Drawing.Point(15, 26)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(84, 37)
        Me.btnnuevo.TabIndex = 0
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(105, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 37)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Modificar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btneliminar
        '
        Me.btneliminar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btneliminar.Location = New System.Drawing.Point(216, 26)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(92, 37)
        Me.btneliminar.TabIndex = 26
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = False
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnbuscar.Location = New System.Drawing.Point(314, 23)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(84, 37)
        Me.btnbuscar.TabIndex = 26
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 512)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Medicamentos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblnum1 As Label
    Friend WithEvents btn2 As Button
    Friend WithEvents btnnavegar2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btnnavegar1 As Button
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents lbldescripcion As Label
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents lblprecio As Label
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents lblcantidad As Label
    Friend WithEvents txtmedicamento As TextBox
    Friend WithEvents lblnommedicamento As Label
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents lblcodigo As Label
    Friend WithEvents txtidmedicamento As TextBox
    Friend WithEvents lblmedicamento As Label
End Class
