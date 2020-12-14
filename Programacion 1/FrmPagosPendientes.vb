Imports System.Data.SqlClient

Public Class FrmPagosPendientes
    Dim objConexion As New db_conexion()
    Private Sub PagosPendientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsPagospendientes.PagosPendientes' Puede moverla o quitarla según sea necesario.
        Me.PagosPendientesTableAdapter.Fill(Me.DsPagospendientes.PagosPendientes)
        'TODO: esta línea de código carga datos en la tabla 'DsPagar1.FormadePago' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'DsPagar1.paciente' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'DsPagar1.encargar_medicamento' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'DsPagar1.Pagar' Puede moverla o quitarla según sea necesario.


    End Sub

    Private Sub FrmPagosPendientes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SistemaClinico.FrmPagosPendientes = Nothing
    End Sub

    Private Sub FrmPagosPendientes_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Me.PagosPendientes_Load(sender, e)
        PagosPendientesBindingSource.ResetBindings(False)
        DsPagospendientes.AcceptChanges()
        Me.PagosPendientesTableAdapter.Fill(Me.DsPagospendientes.PagosPendientes)
        Me.DataGridView1.Refresh()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.ColumnIndex = 0 Then
            Dim accion As String = "Modificar"
            Dim msg = objConexion.mantenimientoPagoPendiente(New String() {Me.DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString.Trim}, accion)
            MessageBox.Show(msg, "Registro de Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class