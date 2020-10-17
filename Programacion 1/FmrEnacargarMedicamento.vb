Public Class FmrEnacargarMedicamento
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Form_DSEntregarmedicamentos.paciente' Puede moverla o quitarla según sea necesario.
        'Me.PacienteTableAdapter.Fill(Me.Form_DSEntregarmedicamentos.paciente)
        'TODO: esta línea de código carga datos en la tabla 'Form_DSEntregarmedicamentos.medicamento' Puede moverla o quitarla según sea necesario.
        'Me.MedicamentoTableAdapter.Fill(Me.Form_DSEntregarmedicamentos.medicamento)
        'TODO: esta línea de código carga datos en la tabla 'Form_DSEntregarmedicamentos.encargar_medicamento' Puede moverla o quitarla según sea necesario.
        Me.Encargar_medicamentoTableAdapter.Fill(Me.Form_DSEntregarmedicamentos.encargar_medicamento)
        Me.txtIdMedicamento.Text = ""
        Me.txtPaciente.Text = ""
    End Sub

    Private Sub bsEntregarmedicamento_CurrentChanged(sender As Object, e As EventArgs) Handles bsEntregarmedicamento.CurrentChanged

    End Sub

    Private Sub btnBuscarPaciente_Click(sender As Object, e As EventArgs) Handles btnBuscarPaciente.Click
        Try
            bsPaciente.Filter = "idPaciente='" & Me.txtBuscarPaciente.Text.Trim & "'"
            bsPaciente.Sort = "idPaciente ASC"
        Catch ex As Exception
            bsPaciente.Filter = "idPaciente='0'"
        End Try
        Me.PacienteTableAdapter.Fill(Form_DSEntregarmedicamentos.paciente)
        Me.txtPaciente.Text = Me.tmpIdPaciente.Text
    End Sub

    Private Sub txtBuscarmedicamento_Click(sender As Object, e As EventArgs) Handles txtBuscarmedicamento.Click
        Me.txtBuscarmedicamento.SelectAll()
    End Sub

    Private Sub FmrEnacargarMedicamento_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SistemaClinico.fmrEncargarMedicamento = Nothing
    End Sub

    Private Sub btnBuscarMedicamento_Click(sender As Object, e As EventArgs) Handles btnBuscarMedicamento.Click
        Me.txtTotal.Text = 0
        bsMedicamentos.Filter = "codigo='" & Me.txtBuscarmedicamento.Text.Trim & "'"
        bsMedicamentos.Sort = "idmedicamento ASC"
        Me.MedicamentoTableAdapter.Fill(Form_DSEntregarmedicamentos.medicamento)
        actualizarTotal()
        Me.txtIdMedicamento.Text = Me.tmpIdMedicamento.Text
    End Sub

    Private Sub actualizarTotal()
        If String.IsNullOrEmpty(Me.txtPrecio.Text.Trim) Then
            Me.txtPrecio.Text = 0
        End If
        If String.IsNullOrEmpty(Me.txtCantidadDeseada.Text.Trim) Then
            Me.txtCantidadDeseada.Text = 0

        End If
        Dim total As Double = 0
        Dim precio As Double = 0
        Dim cantidadDeseada As Double = 0
        Try
            precio = Double.Parse(Me.txtPrecio.Text)
        Catch ex As Exception

        End Try

        Try
            cantidadDeseada = Double.Parse(Me.txtCantidadDeseada.Text)
        Catch ex As Exception

        End Try
        total = precio * cantidadDeseada
        Me.txtTotal.Text = total
    End Sub

    Private Sub txtCantidadDeseada_TextChanged(sender As Object, e As EventArgs) Handles txtCantidadDeseada.TextChanged
        actualizarTotal()
    End Sub

    Private Sub txtBuscarPaciente_Click(sender As Object, e As EventArgs) Handles txtBuscarPaciente.Click
        Me.txtBuscarPaciente.SelectAll()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Me.Validate()
        Me.bsEntregarmedicamento.EndEdit()
        Me.Encargar_medicamentoTableAdapter.Update(Form_DSEntregarmedicamentos)
        Me.Encargar_medicamentoTableAdapter.Fill(Form_DSEntregarmedicamentos.encargar_medicamento)
    End Sub

    Private Sub txtBuscar_Click(sender As Object, e As EventArgs) Handles txtBuscar.Click
        Me.txtBuscar.SelectAll()
    End Sub
End Class