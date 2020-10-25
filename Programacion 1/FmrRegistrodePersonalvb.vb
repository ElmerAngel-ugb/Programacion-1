Public Class FmrRegistrodePersonalvb
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "nuevo"
    Private Sub FmrRegistrodePersonalvb_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SistemaClinico.fmrRegistroPersonal = Nothing
    End Sub

    Private Sub FmrRegistrodePersonalvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        BtenerDatos()
    End Sub
    Sub BtenerDatos()
        dataTable = objConexion.Btenerdatos().Tables("registrodepersonal")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("Idregistrodepersonal")}
        mostrarDatos()
    End Sub

    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString()
            txtCodigoPersonal.Text = dataTable.Rows(posicion).ItemArray(1).ToString()
            txtNombrePersonal.Text = dataTable.Rows(posicion).ItemArray(2).ToString()
            txtDireccionPersonal.Text = dataTable.Rows(posicion).ItemArray(3).ToString()
            txtTelefonoPersonal.Text = dataTable.Rows(posicion).ItemArray(4).ToString()
            txtEmailPersonal.Text = dataTable.Rows(posicion).ItemArray(5).ToString()
            txtCargoPersonal.Text = dataTable.Rows(posicion).ItemArray(6).ToString()
            txtHorarioPersonal.Text = dataTable.Rows(posicion).ItemArray(7).ToString()

            lblUbicacionRegistrodePersonal.Text = posicion + 1 & "de" & dataTable.Rows.Count
        Else
            limpiarDatosRegistrodePersonal()
            MessageBox.Show("No hay Registro que mostrar", "Registro de Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub btnPrimerRegistrodePersonal_Click(sender As Object, e As EventArgs) Handles btnPrimerRegistrodePersonal.Click
        posicion = 0
        mostrarDatos()
    End Sub

    Private Sub btnSuienteRegistrodePersonal_Click(sender As Object, e As EventArgs) Handles btnSuienteRegistrodePersonal.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAnteriorRegistrodePersonal_Click(sender As Object, e As EventArgs) Handles btnAnteriorRegistrodePersonal.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Registro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUltimoRegistrodePersonal_Click(sender As Object, e As EventArgs) Handles btnUltimoRegistrodePersonal.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub

    Private Sub btnNuevoRegistrodePersonal_Click(sender As Object, e As EventArgs) Handles btnNuevoRegistrodePersonal.Click
        If btnNuevoRegistrodePersonal.Text = "Nuevo" Then 'Nuevo
            btnNuevoRegistrodePersonal.Text = "Guardar"
            btnModificarRegistrodePersonal.Text = "Cancelar"
            accion = "nuevo"
            HabDescontroles(False)
            limpiarDatosRegistrodePersonal()
        Else 'Guardar
            Dim msg = objConexion.mantenimientoDatosRegistrodePersonal(New String() {
             Me.Tag, txtCodigoPersonal.Text, txtNombrePersonal.Text, txtDireccionPersonal.Text, txtTelefonoPersonal.Text, txtEmailPersonal.Text, txtCargoPersonal.Text, txtHorarioPersonal.Text
            }, accion)

            MessageBox.Show(msg, "Registro de Personal", MessageBoxButtons.OK, MessageBoxIcon.Information)

            BtenerDatos()
            HabDescontroles(True)
            btnNuevoRegistrodePersonal.Text = "Nuevo"
            btnModificarRegistrodePersonal.Text = "Modificar"


        End If
    End Sub
    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbRegistroPersonal.Enabled = Not estado
        grbRNavegarRegistrodePersonal.Enabled = estado
        btnEliminarRegistrodePersonal.Enabled = estado
        btnBuscarRegistrodePersonal.Enabled = estado
    End Sub
    Private Sub limpiarDatosRegistrodePersonal()
        txtCodigoPersonal.Text = ""
        txtNombrePersonal.Text = ""
        txtDireccionPersonal.Text = ""
        txtTelefonoPersonal.Text = ""
        txtEmailPersonal.Text = ""
        txtCargoPersonal.Text = ""
        txtHorarioPersonal.Text = ""
    End Sub

    Private Sub btnModificarRegistrodePersonal_Click(sender As Object, e As EventArgs) Handles btnModificarRegistrodePersonal.Click
        If btnModificarRegistrodePersonal.Text = "Modificar" Then 'Modificar
            btnNuevoRegistrodePersonal.Text = "Guardar"
            btnModificarRegistrodePersonal.Text = "Cancelar"
            accion = "modificar"
            HabDescontroles(False)
        Else 'Cancelar
            BtenerDatos()

            HabDescontroles(True)
            btnNuevoRegistrodePersonal.Text = "Nuevo"
            btnModificarRegistrodePersonal.Text = "Modificar"
        End If
    End Sub

    Private Sub btnEliminarRegistrodePersonal_Click(sender As Object, e As EventArgs) Handles btnEliminarRegistrodePersonal.Click
        If (MessageBox.Show("Estas Seguro de borrar a " + txtNombrePersonal.Text, "Registro de Personal",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            objConexion.mantenimientoDatosRegistrodePersonal(New String() {Me.Tag}, "eliminar")
            If posicion > 0 Then
                posicion -= 1
            End If
            BtenerDatos()
        End If
    End Sub

    Private Sub btnBuscarRegistrodePersonal_Click(sender As Object, e As EventArgs) Handles btnBuscarRegistrodePersonal.Click

        Dim objBuscarEmpleados As New FrmBuscarEmpleadosvb
        objBuscarEmpleados.ShowDialog()
        If objBuscarEmpleados._idC > 0 Then
            posicion = dataTable.Rows.IndexOf(dataTable.Rows.Find(objBuscarEmpleados._idC))
            mostrarDatos()
        End If
    End Sub

End Class