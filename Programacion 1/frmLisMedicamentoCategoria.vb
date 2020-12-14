Public Class frmLisMedicamentoCategoria
    Private Sub frmLisMedicamentoCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'sistemaclinicodbDataSet.categorias' Puede moverla o quitarla según sea necesario.
        Me.categoriasTableAdapter.Fill(Me.sistemaclinicodbDataSet.categorias)
        'TODO: esta línea de código carga datos en la tabla 'sistemaclinicodbDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.productosTableAdapter.Fill(Me.sistemaclinicodbDataSet.productos)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub frmLisMedicamentoCategoria_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SistemaClinico.frmLisMedicamentoCategoria = Nothing
    End Sub
End Class