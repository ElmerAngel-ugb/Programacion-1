Public Class frmCegorias_Medicamentosvb
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "nuevo"
    Private Sub frmCegorias_Medicamentosvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        Obtenerdato()

    End Sub
    Sub Obtenerdato()
         dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("Idproductos")}
        dataTable = objConexion.Obtenerdato().Tables("productos")


        cboCategoriaMedicamento.DataSource = objConexion.Obtenerdato().Tables("categorias").DefaultView()
        cboCategoriaMedicamento.DisplayMember = "categoria"
        cboCategoriaMedicamento.ValueMember = "categorias.idCategoria"

        cboCategoriaMedicamento.AutoCompleteMode = AutoCompleteMode.Suggest
        cboCategoriaMedicamento.AutoCompleteSource = AutoCompleteSource.ListItems
        mostrarDatos()
    End Sub
    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString()

            cboCategoriaMedicamento.SelectedValue = dataTable.Rows(posicion).ItemArray(1).ToString()
            txtCodigoMedicamento.Text = dataTable.Rows(posicion).ItemArray(2).ToString()
            txtNombre.Text = dataTable.Rows(posicion).ItemArray(3).ToString()
            txtDescrpcionMedicamento.Text = dataTable.Rows(posicion).ItemArray(4).ToString()
            txtLaboratorioMedicamento.Text = dataTable.Rows(posicion).ItemArray(5).ToString()
            txtCantidadMedicamento.Text = dataTable.Rows(posicion).ItemArray(6).ToString()


            lblUbicacionRegistrodePersonal.Text = posicion + 1 & "de" & dataTable.Rows.Count
        Else
            limpiarDatosProductos()
            MessageBox.Show("No hay Registro que mostrar", "Categoria Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub
    Private Sub limpiarDatosProductos()
        txtCodigoMedicamento.Text = ""
        txtNombre.Text = ""
        txtDescrpcionMedicamento.Text = ""
        txtLaboratorioMedicamento.Text = ""
        txtCantidadMedicamento.Text = ""
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
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Medicamentos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAnteriorRegistrodePersonal_Click(sender As Object, e As EventArgs) Handles btnAnteriorRegistrodePersonal.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Categorias medicamentos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUltimoRegistrodePersonal_Click(sender As Object, e As EventArgs) Handles btnUltimoRegistrodePersonal.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub
    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbMedicamentosCategoria.Enabled = Not estado
        grbRNavegarRegistrodePersonal.Enabled = estado
        btnEliminarRegistrodePersonal.Enabled = estado
        btnBuscarRegistrodePersonal.Enabled = estado
    End Sub

    Private Sub btnNuevoMedicamento_Click(sender As Object, e As EventArgs) Handles btnNuevoMedicamento.Click
        If btnNuevoMedicamento.Text = "Nuevo" Then 'Nuevo
            btnNuevoMedicamento.Text = "Guardar"
            btnModificarMedicaamento.Text = "Cancelar"
            accion = "nuevo"
            HabDescontroles(False)
            limpiarDatosProductos()
        Else 'Guardar
            Dim msg = objConexion.mantenimientoDatosProductos(New String() {
             Me.Tag, cboCategoriaMedicamento.SelectedValue, txtCodigoMedicamento.Text, txtNombre.Text, txtDescrpcionMedicamento.Text, txtLaboratorioMedicamento.Text, txtCantidadMedicamento.Text
            }, accion)

            MessageBox.Show(msg, "Categorias medicamentos", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Obtenerdato()
            HabDescontroles(True)
            btnNuevoMedicamento.Text = "Nuevo"
            btnModificarMedicaamento.Text = "Modificar"

        End If
    End Sub
    Private Sub btnModificarMedicaamento_Click(sender As Object, e As EventArgs) Handles btnModificarMedicaamento.Click
        If btnModificarMedicaamento.Text = "Modificar" Then 'Modificar
            btnNuevoMedicamento.Text = "Guardar"
            btnModificarMedicaamento.Text = "Cancelar"
            accion = "modificar"
            HabDescontroles(False)
        Else 'Cancelar
            Obtenerdato()

            HabDescontroles(True)
            btnNuevoMedicamento.Text = "Nuevo"
            btnModificarMedicaamento.Text = "Modificar"
        End If
    End Sub

    Private Sub btnEliminarRegistrodePersonal_Click(sender As Object, e As EventArgs) Handles btnEliminarRegistrodePersonal.Click
        If MessageBox.Show("Esta seguro de eliminar " & txtDescrpcionMedicamento.Text, "Registro de Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            Dim msg = objConexion.mantenimientoDatosProductos(New String() {Me.Tag}, "eliminar")
            If msg IsNot "error" Then
                If posicion > 0 Then
                    posicion -= 1
                End If
                Obtenerdato()
                mostrarDatos()
            End If
        End If

    End Sub

    Private Sub btnBuscarRegistrodePersonal_Click(sender As Object, e As EventArgs) Handles btnBuscarRegistrodePersonal.Click

    End Sub
End Class