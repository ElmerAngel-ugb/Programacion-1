Public Class frmBuscarReceta
    Dim objConexion As New db_conexion
    Public _idC As Integer
    Private Sub btnSeleccionarEmpleado_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        seleccionarEmpleado()

    End Sub

    Private Sub FrmBuscarEmpleadosvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grbBuscar.DataSource = objConexion.Btenerdatos().Tables("receta").DefaultView
    End Sub

    Private Sub txtBuscarEmpleado_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyUp
        filtrarDatosEmpleado(txtBuscar.Text)
        If e.KeyCode = 13 Then
            seleccionarEmpleado()
        End If
    End Sub
    Private Sub seleccionarEmpleado()
        _idC = grbBuscar.CurrentRow.Cells("Idreceta").Value.ToString()
        Close()
    End Sub
    Private Sub filtrarDatosEmpleado(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grbBuscar.DataSource
        bs.Filter = "medico '%" & valor & "%' or paciente like '%" & valor & "%'"
        grbBuscar.DataSource = bs
    End Sub

    Private Sub btnCancelarSeleccion_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        _idC = 0
        Close()
    End Sub

End Class