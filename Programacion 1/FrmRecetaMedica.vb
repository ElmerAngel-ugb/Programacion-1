Public Class FrmRecetaMedica
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "nuevo"

    Private Sub FrmRecetaMedica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        Datos()
    End Sub
    Sub Datos()
        dataTable = objConexion.Datos().Tables("receta")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("Idreceta")}
        mostrarDatos()
    End Sub
    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString()
            txtmedico.Text = dataTable.Rows(posicion).ItemArray(1).ToString()
            txtpaciente.Text = dataTable.Rows(posicion).ItemArray(2).ToString()
            txtDescripcion.Text = dataTable.Rows(posicion).ItemArray(3).ToString()
            txtDosis.Text = dataTable.Rows(posicion).ItemArray(4).ToString()
            txtfechadeemision.Text = dataTable.Rows(posicion).ItemArray(5).ToString()

            lblUbicacionRegistrodePersonal.Text = posicion + 1 & "de" & dataTable.Rows.Count
        Else
            limpiarDatosreceta()
            MessageBox.Show("No hay Registro que mostrar", "Registro de Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub
    Private Sub limpiarDatosreceta()
        txtmedico.Text = ""
        txtpaciente.Text = ""
        txtDescripcion.Text = ""
        txtDosis.Text = ""
        txtfechadeemision.Text = ""
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
            MessageBox.Show("Ya te encuentras en la ultima receta.", "Receta", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAnteriorRegistrodePersonal_Click(sender As Object, e As EventArgs) Handles btnAnteriorRegistrodePersonal.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en la ultima receta.", "Receta", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            limpiarDatosreceta()
        Else 'Guardar
            Dim msg = objConexion.mantenimientoDatosreceta(New String() {
             Me.Tag, txtmedico.Text, txtpaciente.Text, txtDescripcion.Text, txtDosis.Text, txtfechadeemision.Text
            }, accion)

            MessageBox.Show(msg, "Receta", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Datos()
            HabDescontroles(True)
            btnNuevoRegistrodePersonal.Text = "Nuevo"
            btnModificarRegistrodePersonal.Text = "Modificar"


        End If
    End Sub
    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbReceta.Enabled = Not estado
        grbRNavegarRegistrodePersonal.Enabled = estado
        btnEliminarRegistrodePersonal.Enabled = estado
        btnBuscarRegistrodePersonal.Enabled = estado
    End Sub

    Private Sub btnModificarRegistrodePersonal_Click(sender As Object, e As EventArgs) Handles btnModificarRegistrodePersonal.Click
        If btnModificarRegistrodePersonal.Text = "Modificar" Then 'Modificar
            btnNuevoRegistrodePersonal.Text = "Guardar"
            btnModificarRegistrodePersonal.Text = "Cancelar"
            accion = "modificar"
            HabDescontroles(False)
        Else 'Cancelar
            Datos()

            HabDescontroles(True)
            btnNuevoRegistrodePersonal.Text = "Nuevo"
            btnModificarRegistrodePersonal.Text = "Modificar"
        End If
    End Sub

    Private Sub btnEliminarRegistrodePersonal_Click(sender As Object, e As EventArgs) Handles btnEliminarRegistrodePersonal.Click
        If (MessageBox.Show("Estas Seguro de borrar a " + txtpaciente.Text, "Receta",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            objConexion.mantenimientoDatosreceta(New String() {Me.Tag}, "eliminar")
            If posicion > 0 Then
                posicion -= 1
            End If
            Datos()
        End If
    End Sub

    Private Sub btnBuscarRegistrodePersonal_Click(sender As Object, e As EventArgs) Handles btnBuscarRegistrodePersonal.Click
        Dim objBuscaReceta As New FrmRecetaMedica
        objBuscaReceta.ShowDialog()
        If objBuscaReceta._idC > 0 Then
            posicion = dataTable.Rows.IndexOf(dataTable.Rows.Find(objBuscaReceta._idC))
            mostrarDatos()
        End If
    End Sub
End Class