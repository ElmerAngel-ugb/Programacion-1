Public Class FrmBuscarPaciente
    Dim objConexion As New db_conexion
    Public _idC As Integer

    Private Sub btnSeleccionarPaciente_Click(sender As Object, e As EventArgs) Handles btnSeleccionarPaciente.Click
        seleccionarPaciente()
    End Sub

    Private Sub txtBuscarPaciente_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarPaciente.TextChanged
        grdBuscarPaciente.DataSource = objConexion.obtenerDatos().Tables("Paciente").DefaultView
    End Sub
    Private Sub txtBuscarPaciente_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscarPaciente.KeyUp
        filtrarDatosPaciente(txtBuscarPaciente.Text)
        If e.KeyCode = 13 Then
            seleccionarPaciente()
        End If
    End Sub
    Private Sub seleccionarPaciente()
        _idC = grdBuscarPaciente.CurrentRow.Cells("IdPaciente").Value.ToString()
        Close()
    End Sub
    Private Sub filtrarDatosPaciente(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grdBuscarPaciente.DataSource
        bs.Filter = "codigo like '%" & valor & "%' or  nombre like '%" & valor & "%'"
        grdBuscarPaciente.DataSource = bs
    End Sub

    Private Sub btnCancelarPaciente_Click(sender As Object, e As EventArgs) Handles btnCancelarPaciente.Click
        _idC = 0
        Close()
    End Sub

    Private Sub FrmBuscarPaciente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SistemaClinico.frmBuscarPaciente = Nothing
    End Sub

    Private Sub FrmBuscarPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class