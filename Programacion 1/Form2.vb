Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Form_DSEntregarmedicamentos.paciente' Puede moverla o quitarla según sea necesario.
        Me.PacienteTableAdapter.Fill(Me.Form_DSEntregarmedicamentos.paciente)
        'TODO: esta línea de código carga datos en la tabla 'Form_DSEntregarmedicamentos.medicamento' Puede moverla o quitarla según sea necesario.
        Me.MedicamentoTableAdapter.Fill(Me.Form_DSEntregarmedicamentos.medicamento)
        'TODO: esta línea de código carga datos en la tabla 'Form_DSEntregarmedicamentos.encargar_medicamento' Puede moverla o quitarla según sea necesario.
        Me.Encargar_medicamentoTableAdapter.Fill(Me.Form_DSEntregarmedicamentos.encargar_medicamento)

    End Sub

    Private Sub bsEntregarmedicamento_CurrentChanged(sender As Object, e As EventArgs) Handles bsEntregarmedicamento.CurrentChanged

    End Sub
End Class