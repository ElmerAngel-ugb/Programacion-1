Public Class FrmBuscarEmpleadosvb
    Dim objConexion As New db_conexion
    Public _idC As Integer
    Private Sub btnSeleccionarEmpleado_Click(sender As Object, e As EventArgs) Handles btnSeleccionarEmpleado.Click
        seleccionarEmpleado()

    End Sub

    Private Sub FrmBuscarEmpleadosvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grbBuscarEmpleado.DataSource = objConexion.Btenerdatos().Tables("registrodepersonal").DefaultView
    End Sub

    Private Sub txtBuscarEmpleado_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscarEmpleado.KeyUp
        filtrarDatosEmpleado(txtBuscarEmpleado.Text)
        If e.KeyCode = 13 Then
            seleccionarEmpleado()
        End If
    End Sub
    Private Sub seleccionarEmpleado()
        _idC = grbBuscarEmpleado.CurrentRow.Cells("idresgistrodepersonal").Value.ToString()
        Close()
    End Sub
    Private Sub filtrarDatosEmpleado(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grbBuscarEmpleado.DataSource
        bs.Filter = "codigo like '%" & valor & "%' or  nombre like '%" & valor & "%'"
        grbBuscarEmpleado.DataSource = bs
    End Sub

    Private Sub btnCancelarSeleccion_Click(sender As Object, e As EventArgs) Handles btnCancelarSeleccion.Click
        _idC = 0
        Close()
    End Sub

End Class