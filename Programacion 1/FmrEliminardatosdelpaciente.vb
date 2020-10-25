Public Class FmrEliminardatosdelpaciente
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim Posicion As Integer
    Dim accion As String = " nuevo"
    Private Sub txtBuscaridPaciente_Click(sender As Object, e As EventArgs) Handles txtBuscaridPaciente.Click
        Me.txtBuscaridPaciente.SelectAll()
    End Sub

    Private Sub btnEliminarPaciente_Click(sender As Object, e As EventArgs) Handles btnEliminarPaciente.Click
        If (MessageBox.Show("¿Estas seguro de borrar este registro?", "Registro Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            objConexion.mantenimientoDatosPaciente(New String() {Me.Tag}, "eliminar")
            If Posicion > 0 Then
                Posicion -= 1
            End If
            BtenerDatos()
        End If
    End Sub
    Private Sub BtenerDatos()
        dataTable = objConexion.obtenerDatos().Tables("paciente")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("IdPaciente")}

        mostrarDatosPacientes()
    End Sub
    Sub mostrarDatosPacientes()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(Posicion).ItemArray(0).ToString()
            txtidPaciente.Text = dataTable.Rows(Posicion).ItemArray(1).ToString()
            TextNombredelPaciente.Text = dataTable.Rows(Posicion).ItemArray(2).ToString()

        Else
            MessageBox.Show("No hay registros que mostrar", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub BtnBuscaridPaciente_Click(sender As Object, e As EventArgs) Handles btnBuscaridPaciente.Click
        Dim objBuscaridPaciente As New FrmBuscarPaciente
        objBuscaridPaciente.ShowDialog()
        If objBuscaridPaciente._idC > 0 Then
            Posicion = dataTable.Rows.IndexOf(dataTable.Rows.Find(objBuscaridPaciente._idC))
            mostrarDatosPacientes()
        End If
    End Sub

    Private Sub FmrEliminardatosdelpaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtenerDatos()
    End Sub

End Class