Public Class BuscarCategoriamedicamentos
    Dim objConexion As New db_conexion
    Public _idC As Integer
    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        seleccionarCategoriaMedicamentos()
    End Sub
    Private Sub BuscarCategoriamedicamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grbBuscarCategoriaMedicamentos.DataSource = (objConexion.Obtenerdato).Tables("productos").DefaultView
    End Sub

    Private Sub txtBuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyUp
        FiltrarCategoriaMedicamentos(txtBuscar.Text)
        If e.KeyCode = 13 Then
            seleccionarCategoriaMedicamentos()
        End If
    End Sub
    Private Sub seleccionarCategoriaMedicamentos()
        _idC = grbBuscarCategoriaMedicamentos.CurrentRow.Cells("Idproductos").Value.ToString()
        Close()
    End Sub
    Private Sub FiltrarCategoriaMedicamentos(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grbBuscarCategoriaMedicamentos.DataSource
        bs.Filter = "categoria like '%" + valor + "%' or codigo like '%" & valor & "%' or  descripcion like '%" & valor & "%'"
        grbBuscarCategoriaMedicamentos.DataSource = bs
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        _idC = 0
        Close()
    End Sub
End Class