Public Class frmListadodeAcompañante
    Private Sub frmListadodeAcompañante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'sistemaclinicodbDataSet.Acompanante' Puede moverla o quitarla según sea necesario.
        Me.AcompananteTableAdapter.Fill(Me.sistemaclinicodbDataSet.Acompanante)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub frmListadodeAcompañante_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SistemaClinico.frmListadodeAcompañante = Nothing
    End Sub
End Class