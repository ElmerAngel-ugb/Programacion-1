Public Class fmrListadePacientes
    Private Sub fmrListadePacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dsPersonal.paciente' Puede moverla o quitarla según sea necesario.
        Me.pacienteTableAdapter.Fill(Me.dsPersonal.paciente)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub fmrListadePacientes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SistemaClinico.fmrListadePacientes = Nothing
    End Sub
End Class