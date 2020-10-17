Public Class FrmPaciente
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim Posicion As Integer
    Dim accion As String = " nuevo"
    Private Sub FrmPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Posicion = 0
        obtenerDatos()

    End Sub

    Sub obtenerDatos()
        dataTable = objConexion.obtenerDatos().Tables("Paciente")

        mostrarDatos()
    End Sub

    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(Posicion).ItemArray(0).ToString
            txtCodigoPaciente.Text = dataTable.Rows(Posicion).ItemArray(1).ToString()
            txtNombrePaciente.Text = dataTable.Rows(Posicion).ItemArray(2).ToString()
            txtApellidoPaciente.Text = dataTable.Rows(Posicion).ItemArray(3).ToString()
            txtNacimientoPaciente.Text = dataTable.Rows(Posicion).ItemArray(4).ToString()
            txtEdadPaciente.Text = dataTable.Rows(Posicion).ItemArray(5).ToString()
            txtSexoPaciente.Text = dataTable.Rows(Posicion).ItemArray(6).ToString()
            txtDuiPaciente.Text = dataTable.Rows(Posicion).ItemArray(7).ToString()
            txtSangrePaciente.Text = dataTable.Rows(Posicion).ItemArray(8).ToString()
            txtEmailPaciente.Text = dataTable.Rows(Posicion).ItemArray(9).ToString()
            txtDireccionPaciente.Text = dataTable.Rows(Posicion).ItemArray(10).ToString()
            txtAlergicoPaciente.Text = dataTable.Rows(Posicion).ItemArray(11).ToString()
            txtExamenesPaciente.Text = dataTable.Rows(Posicion).ItemArray(12).ToString()

            lblRegistrosPaciente.Text = Posicion + 1 & "  de  " & dataTable.Rows.Count
        Else
            limpiarDatosPaciente()
            MessageBox.Show("No hay Registro que mostrar", "Registro de Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    Private Sub btnPrimeroCliente_Click(sender As Object, e As EventArgs) Handles btnPrimeroCliente.Click
        Posicion = 0
        mostrarDatos()
    End Sub

    Private Sub btnSiguienteCliente_Click(sender As Object, e As EventArgs) Handles btnSiguienteCliente.Click
        If Posicion < dataTable.Rows.Count - 1 Then
            Posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAnteriorCliente_Click(sender As Object, e As EventArgs) Handles btnAnteriorCliente.Click
        If Posicion > 0 Then
            Posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Registro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUltimoCliente_Click(sender As Object, e As EventArgs) Handles btnUltimoCliente.Click
        Posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub

    Private Sub btnAgregarPaciente_Click(sender As Object, e As EventArgs) Handles btnAgregarPaciente.Click
        If btnAgregarPaciente.Text = "Nuevo" Then 'Nuevo
            btnAgregarPaciente.Text = "Guardar"
            btnModificarPaciente.Text = "Cancelar"
            accion = "nuevo"

            HabDescontroles(False)
            limpiarDatosPaciente()
        Else 'Guardar
            Dim msg = objConexion.mantenimientoDatosPaciente(New String() {
                Me.Tag, txtCodigoPaciente.Text, txtNombrePaciente.Text, txtApellidoPaciente.Text, txtNacimientoPaciente.Text, txtEdadPaciente.Text, txtSexoPaciente.Text, txtDuiPaciente.Text, txtSangrePaciente.Text, txtEmailPaciente.Text, txtDireccionPaciente.Text, txtAlergicoPaciente.Text, txtExamenesPaciente.Text
            }, accion)

            obtenerDatos()
            HabDescontroles(True)
            btnAgregarPaciente.Text = "Nuevo"
            btnModificarPaciente.Text = "Modificar"

            MessageBox.Show(msg, "Registro de Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbDatos.Enabled = Not estado
        grbNavegacion.Enabled = estado
        btnEliminarPaciente.Enabled = estado
        btnBuscarPaciente.Enabled = estado
    End Sub

    Private Sub limpiarDatosPaciente()
        txtCodigoPaciente.Text = ""
        txtNombrePaciente.Text = ""
        txtApellidoPaciente.Text = ""
        txtNacimientoPaciente.Text = ""
        txtEdadPaciente.Text = ""
        txtSexoPaciente.Text = ""
        txtDuiPaciente.Text = ""
        txtSangrePaciente.Text = ""
        txtEmailPaciente.Text = ""
        txtDireccionPaciente.Text = ""
        txtAlergicoPaciente.Text = ""
        txtExamenesPaciente.Text = ""

    End Sub

    Private Sub btnModificarPaciente_Click(sender As Object, e As EventArgs) Handles btnModificarPaciente.Click
        If btnModificarPaciente.Text = "Modificar" Then 'Modificar
            btnAgregarPaciente.Text = "Guardar"
            btnModificarPaciente.Text = "Cancelar"
            accion = "modificar"
            HabDescontroles(False)
        Else 'Cancelar
            obtenerDatos()

            HabDescontroles(True)
            btnAgregarPaciente.Text = "Nuevo"
            btnModificarPaciente.Text = "Modificar"
        End If
    End Sub

    Private Sub btnEliminarPaciente_Click(sender As Object, e As EventArgs) Handles btnEliminarPaciente.Click
        If (MessageBox.Show("Estas Seguro de borrar a " + txtNombrePaciente.Text, "Registro de Paciente",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            objConexion.mantenimientoDatosPaciente(New String() {Me.Tag}, "eliminar")
            If Posicion > 0 Then
                Posicion -= 1
            End If
            obtenerDatos()
        End If
    End Sub

    Private Sub btnBuscarPaciente_Click(sender As Object, e As EventArgs) Handles btnBuscarPaciente.Click
        Dim objBuscarPaciente As New FrmBuscarPaciente
        objBuscarPaciente.ShowDialog()
    End Sub

    Private Sub FrmPaciente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SistemaClinico.frmPaciente = Nothing
    End Sub
End Class