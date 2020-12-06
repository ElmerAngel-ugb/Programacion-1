Public Class FormRegistro_Acompañante
    Dim objConexion As New db_conexion()
    Dim dataTables As New DataTable
    Dim Posicion As Integer
    Dim accion As String = " new"
    Private Sub FormRegistro_Acompañante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Posicion = 0

        Xtenerdatos()
    End Sub

    Sub Xtenerdatos()
        dataTables = objConexion.Xtenerdatos().Tables("Registro")
        dataTables.PrimaryKey = New DataColumn() {dataTables.Columns("Id_Registro")}

        mostrarDatos()
    End Sub

    Sub mostrarDatos()
        If dataTables.Rows.Count > 0 Then
            Me.Tag = dataTables.Rows(Posicion).ItemArray(0).ToString
            txtCodigoRegistro.Text = dataTables.Rows(Posicion).ItemArray(1).ToString()
            txtNombreRegistro.Text = dataTables.Rows(Posicion).ItemArray(2).ToString()
            txtApellidoRegistro.Text = dataTables.Rows(Posicion).ItemArray(3).ToString()
            txtSexoRegistro.Text = dataTables.Rows(Posicion).ItemArray(4).ToString()
            txtTipo_SangreRegistro.Text = dataTables.Rows(Posicion).ItemArray(5).ToString()
            txtNacimientoRegistro.Text = dataTables.Rows(Posicion).ItemArray(6).ToString()

            txtCodigoAcompanante.Text = dataTables.Rows(Posicion).ItemArray(8).ToString()
            TextBox2.Text = dataTables.Rows(Posicion).ItemArray(9).ToString()
            TextBox1.Text = dataTables.Rows(Posicion).ItemArray(10).ToString()
            txtEdadPaciente.Text = dataTables.Rows(Posicion).ItemArray(11).ToString()
            txtSexoAcompanante.Text = dataTables.Rows(Posicion).ItemArray(12).ToString()
            txtTelefonoAcompnante.Text = dataTables.Rows(Posicion).ItemArray(13).ToString()
            txtEmailPaciente.Text = dataTables.Rows(Posicion).ItemArray(14).ToString()
            txtDireccionPaciente.Text = dataTables.Rows(Posicion).ItemArray(15).ToString()


            lblRegistrosRegistro.Text = Posicion + 1 & "  de  " & dataTables.Rows.Count
        Else
            limpiarDatosRegistro()
            MessageBox.Show("No hay Registro que mostrar", "Registro de Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnPrimeroRegistro_Click(sender As Object, e As EventArgs) Handles btnPrimeroRegistro.Click
        Posicion = 0
        mostrarDatos()
    End Sub

    Private Sub btnSiguienteRegistro_Click(sender As Object, e As EventArgs) Handles btnSiguienteRegistro.Click
        If Posicion < dataTables.Rows.Count - 1 Then
            Posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAnteriorRegistro_Click(sender As Object, e As EventArgs) Handles btnAnteriorRegistro.Click
        If Posicion > 0 Then
            Posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Registro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUltimoRegistro_Click(sender As Object, e As EventArgs) Handles btnUltimoRegistro.Click
        Posicion = dataTables.Rows.Count - 1
        mostrarDatos()
    End Sub

    Private Sub btnAgregarRegistro_Click(sender As Object, e As EventArgs) Handles btnAgregarRegistro.Click
        If btnAgregarRegistro.Text = "Nuevo" Then 'Nuevo
            btnAgregarRegistro.Text = "Guardar"
            btnModificarRegistro.Text = "Cancelar"
            accion = "nuevo"

            HabDescontroles(False)
            limpiarDatosRegistro()
        Else 'Guardar
            Dim msg = objConexion.mantenimientoDatosRegistro(New String() {
                Me.Tag, txtCodigoRegistro.Text, txtNombreRegistro.Text, txtApellidoRegistro.Text, txtSexoRegistro.Text, txtTipo_SangreRegistro.Text, txtNacimientoRegistro.Text, txtCodigoAcompanante.Text,
            TextBox2.Text, TextBox1.Text, txtEdadPaciente.Text, txtSexoAcompanante.Text, txtTelefonoAcompnante.Text, txtEmailPaciente.Text, txtDireccionPaciente.Text
            }, accion)

            Xtenerdatos()
            HabDescontroles(True)
            btnAgregarRegistro.Text = "Nuevo"
            btnModificarRegistro.Text = "Modificar"

            MessageBox.Show(msg, "Registro de Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbDatosRegistro.Enabled = Not estado
        grbNavegacion.Enabled = estado
        btnEliminarRegistro.Enabled = estado
        btnBuscarRegistro.Enabled = estado
    End Sub
    Private Sub limpiarDatosRegistro()

        txtCodigoRegistro.Text = ""
        txtNombreRegistro.Text = ""
        txtApellidoRegistro.Text = ""
        txtSexoRegistro.Text = ""
        txtTipo_SangreRegistro.Text = ""
        txtNacimientoRegistro.Text = ""

        txtCodigoAcompanante.Text = ""
        TextBox2.Text = ""
        TextBox1.Text = ""
        txtEdadPaciente.Text = ""
        txtSexoAcompanante.Text = ""
        txtTelefonoAcompnante.Text = ""
        txtEmailPaciente.Text = ""
        txtDireccionPaciente.Text = ""

    End Sub

    Private Sub btnModificarRegistro_Click(sender As Object, e As EventArgs) Handles btnModificarRegistro.Click
        If btnModificarRegistro.Text = "Modificar" Then 'Modificar
            btnAgregarRegistro.Text = "Guardar"
            btnModificarRegistro.Text = "Cancelar"
            accion = "modificar"
            HabDescontroles(False)
        Else 'Cancelar
            Xtenerdatos()

            HabDescontroles(True)
            btnAgregarRegistro.Text = "Nuevo"
            btnModificarRegistro.Text = "Modificar"
        End If
    End Sub

    Private Sub btnEliminarRegistro_Click(sender As Object, e As EventArgs) Handles btnEliminarRegistro.Click
        If (MessageBox.Show("Estas Seguro de borrar a " + txtNombreRegistro.Text, "Registro de Paciente",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            objConexion.mantenimientoDatosRegistro(New String() {Me.Tag}, "eliminar")
            If Posicion > 0 Then
                Posicion -= 1
            End If
            Xtenerdatos()
        End If
    End Sub
End Class