Public Class frmListadeproveedores
    Private Sub frmListadeproveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'sistemaclinicodbDataSet.proveedormedicamentos' Puede moverla o quitarla según sea necesario.
        Me.proveedormedicamentosTableAdapter.Fill(Me.sistemaclinicodbDataSet.proveedormedicamentos)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub frmListadeproveedores_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SistemaClinico.frmListadeproveedores = Nothing
    End Sub
End Class