Public Class frmListadodeAcompañante
    Private Sub frmListadodeAcompañante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'sistemaclinicodbDataSet.Acompanante' Puede moverla o quitarla según sea necesario.
        Me.AcompananteTableAdapter.Fill(Me.sistemaclinicodbDataSet.Acompanante)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class