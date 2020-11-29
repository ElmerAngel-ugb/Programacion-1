Public Class FmrEncargarMedicamento
    Dim btnGuardarFuepresionado As Boolean = False
    Dim btnRemoveFilterFuepresionado As Boolean = False
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Form_DSEntregarmedicamentos.paciente' Puede moverla o quitarla según sea necesario.
        Me.PacienteTableAdapter.Fill(Me.Form_DSEntregarmedicamentos.paciente)
        'TODO: esta línea de código carga datos en la tabla 'Form_DSEntregarmedicamentos.paciente' Puede moverla o quitarla según sea necesario.
        Me.PacienteTableAdapter.Fill(Me.Form_DSEntregarmedicamentos.paciente)
        'TODO: esta línea de código carga datos en la tabla 'Form_DSEntregarmedicamentos.paciente' Puede moverla o quitarla según sea necesario.
        'Me.PacienteTableAdapter.Fill(Me.Form_DSEntregarmedicamentos.paciente)
        'TODO: esta línea de código carga datos en la tabla 'Form_DSEntregarmedicamentos.medicamento' Puede moverla o quitarla según sea necesario.
        'Me.MedicamentoTableAdapter.Fill(Me.Form_DSEntregarmedicamentos.medicamento)
        'TODO: esta línea de código carga datos en la tabla 'Form_DSEntregarmedicamentos.encargar_medicamento' Puede moverla o quitarla según sea necesario.
        Me.Encargar_medicamentoTableAdapter.Fill(Me.Form_DSEntregarmedicamentos.encargar_medicamento)
        actualizarinfomaciondelPaciente(txtPaciente.Text.Trim)
        actualizarinformaciondelMedicamentoPorId(txtIdMedicamento.Text.Trim)
        actualizarTotal()
    End Sub

    Private Sub btnBuscarPaciente_Click(sender As Object, e As EventArgs) Handles btnBuscarPaciente.Click
        btnGuardarFuepresionado = False
        btnRemoveFilterFuepresionado = False
        bsPaciente.Filter = "codigo='" & txtBuscarPaciente.Text.Trim & "'"
        bsPaciente.Sort = "codigo ASC"
        Me.PacienteTableAdapter.Fill(Form_DSEntregarmedicamentos.paciente)
        Me.txtPaciente.Text = Me.tmpIdPaciente.Text
        actualizarinfomaciondelPaciente(Me.txtPaciente.Text.Trim)
    End Sub

    Private Sub txtBuscarmedicamento_Click(sender As Object, e As EventArgs) Handles txtBuscarmedicamento.Click
        Me.txtBuscarmedicamento.SelectAll()
    End Sub

    Private Sub FmrEnacargarMedicamento_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SistemaClinico.fmrEncargarMedicamento = Nothing
    End Sub

    Private Sub btnBuscarMedicamento_Click(sender As Object, e As EventArgs) Handles btnBuscarMedicamento.Click
        btnGuardarFuepresionado = False
        btnRemoveFilterFuepresionado = False
        actualizarinformaciondelMedicamento(Me.txtBuscarmedicamento.Text.Trim)
        actualizarTotal()
    End Sub

    Private Sub actualizarTotal()
        If String.IsNullOrEmpty(Me.txtPrecio.Text.Trim) Then
            Me.txtPrecio.Text = 0
        End If
        If String.IsNullOrEmpty(Me.txtCantidadDeseada.Text.Trim) Then
            Me.txtCantidadDeseada.Text = 0
        End If
        Dim total As Double = 0
        Dim precio As Double = 0
        Dim cantidadDeseada As Double = 0
        Try
            precio = Double.Parse(Me.txtPrecio.Text)
        Catch ex As Exception

        End Try

        Try
            cantidadDeseada = Double.Parse(Me.txtCantidadDeseada.Text)
        Catch ex As Exception

        End Try
        total = precio * cantidadDeseada
        Me.txtTotal.Text = total
    End Sub

    Private Sub txtCantidadDeseada_TextChanged(sender As Object, e As EventArgs) Handles txtCantidadDeseada.TextChanged
        actualizarTotal()
    End Sub

    Private Sub txtBuscarPaciente_Click(sender As Object, e As EventArgs) Handles txtBuscarPaciente.Click
        Me.txtBuscarPaciente.SelectAll()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        btnGuardarFuepresionado = True
        btnRemoveFilterFuepresionado = False
        If Not existenciasDisponibles() Then
            MsgBox("la cantidad de medicamentos solicitada no está disponible intente con una menor ", MsgBoxStyle.Critical, "Error")
            Return
        End If
        Try
            Me.Validate()
            Me.bsEntregarmedicamento.EndEdit()
            Me.Encargar_medicamentoTableAdapter.Update(Form_DSEntregarmedicamentos)
            Me.Encargar_medicamentoTableAdapter.Fill(Form_DSEntregarmedicamentos.encargar_medicamento)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtBuscar_Click(sender As Object, e As EventArgs) Handles txtBuscar.Click
        Me.txtBuscar.SelectAll()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        btnGuardarFuepresionado = False
        btnRemoveFilterFuepresionado = False
        Try
            bsEntregarmedicamento.Filter = "id_encargarmedicamento='" & Me.txtBuscar.Text.Trim & "'"
            bsEntregarmedicamento.Sort = "id_encargarmedicamento ASC"
            Me.Encargar_medicamentoTableAdapter.Fill(Form_DSEntregarmedicamentos.encargar_medicamento)
            actualizarinfomaciondelPaciente(txtPaciente.Text.Trim)
            actualizarinformaciondelMedicamentoPorId(Me.txtIdMedicamento.Text.Trim)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try


    End Sub

    Private Sub btnRemoveFilter_Click(sender As Object, e As EventArgs) Handles btnRemoveFilter.Click
        btnGuardarFuepresionado = False
        btnRemoveFilterFuepresionado = True
        Try
            Me.bsEntregarmedicamento.Filter = ""
            Me.Encargar_medicamentoTableAdapter.Fill(Form_DSEntregarmedicamentos.encargar_medicamento)
            Me.txtBuscar.Text = "Escriba un codigo"
            actualizarinfomaciondelPaciente(txtPaciente.Text.Trim)
            actualizarinformaciondelMedicamentoPorId(Me.txtIdMedicamento.Text.Trim)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub navEntregarmedicamentos_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles navEntregarmedicamentos.ItemClicked
        btnGuardarFuepresionado = False
        navEntregarmedicamentos.DeleteItem = BindingNavigatorDeleteItem
        navEntregarmedicamentos.MoveFirstItem = BindingNavigatorMoveFirstItem
        navEntregarmedicamentos.MoveLastItem = BindingNavigatorMoveLastItem
        navEntregarmedicamentos.MoveNextItem = BindingNavigatorMoveNextItem
        navEntregarmedicamentos.MovePreviousItem = BindingNavigatorMovePreviousItem
        If e.ClickedItem Is navEntregarmedicamentos.DeleteItem Then
            If MsgBox("¿Desea elimar el registro?", vbQuestion + vbYesNo) = vbNo Then
                navEntregarmedicamentos.DeleteItem = Nothing
                MsgBox("Acción Cancelada", 64, "")
            End If
        ElseIf e.ClickedItem Is navEntregarmedicamentos.MoveFirstItem Or e.ClickedItem Is navEntregarmedicamentos.MoveLastItem Or e.ClickedItem Is navEntregarmedicamentos.MoveNextItem Or e.ClickedItem Is navEntregarmedicamentos.MovePreviousItem Then
            If String.IsNullOrEmpty(Me.txtIdMedicamento.Text.Trim()) Or String.IsNullOrEmpty(Me.txtPaciente.Text.Trim()) Or Not existenciasDisponibles() Then
                navEntregarmedicamentos.MoveFirstItem = Nothing
                navEntregarmedicamentos.MoveLastItem = Nothing
                navEntregarmedicamentos.MoveNextItem = Nothing
                navEntregarmedicamentos.MovePreviousItem = Nothing
            End If
            If String.IsNullOrEmpty(Me.txtIdMedicamento.Text.Trim()) Then
                MsgBox("El id del medicamento no puede quedar vacio", MsgBoxStyle.Critical, "Error")
            ElseIf String.IsNullOrEmpty(Me.txtPaciente.Text.Trim()) Then
                MsgBox("El id del paciente no puede quedar vacio", MsgBoxStyle.Critical, "Error")
            ElseIf Not existenciasDisponibles() Then
                MsgBox("la cantidad de medicamentos solicitada no está disponible intente con una menor ", MsgBoxStyle.Critical, "Error")
            End If
        End If
    End Sub

    Private Sub actualizarinfomaciondelPaciente(idPaciente As String)
        Dim id As Integer = -1
        Try
            id = Integer.Parse(idPaciente)
        Catch ex As Exception
            idPaciente = "0"
        End Try
        Try
            bsPaciente.Filter = "idPaciente='" & idPaciente & "'"
            bsPaciente.Sort = "idPaciente ASC"
            Me.PacienteTableAdapter.Fill(Form_DSEntregarmedicamentos.paciente)
            Me.txtPaciente.Text = Me.tmpIdPaciente.Text
        Catch ex As Exception
            bsPaciente.Filter = "idPaciente='0'"
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub actualizarinformaciondelMedicamento(codigoMedicamento As String)
        Try
            Me.txtTotal.Text = 0
            bsMedicamentos.Filter = "codigo='" & codigoMedicamento & "'"
            bsMedicamentos.Sort = "idmedicamento ASC"
            Me.MedicamentoTableAdapter.Fill(Form_DSEntregarmedicamentos.medicamento)
            actualizarTotal()
            Me.txtIdMedicamento.Text = Me.tmpIdMedicamento.Text
        Catch ex As Exception
            bsMedicamentos.Filter = "codigo=''"
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub actualizarinformaciondelMedicamentoPorId(idmedicamento As String)
        Dim id As Integer = -1
        Try
            id = Integer.Parse(idmedicamento)
        Catch ex As Exception
            idmedicamento = "0"
        End Try
        Try
            Me.txtTotal.Text = 0
            bsMedicamentos.Filter = "idmedicamento='" & idmedicamento & "'"
            bsMedicamentos.Sort = "idmedicamento ASC"
            Me.MedicamentoTableAdapter.Fill(Form_DSEntregarmedicamentos.medicamento)
            actualizarTotal()
        Catch ex As Exception
            bsMedicamentos.Filter = "idmedicamento=''"
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub bsEntregarmedicamento_PositionChanged(sender As Object, e As EventArgs) Handles bsEntregarmedicamento.PositionChanged
        If btnGuardarFuepresionado Or btnRemoveFilterFuepresionado Then
            Return
        End If
        actualizarinfomaciondelPaciente(Me.txtPaciente.Text.Trim())
        actualizarinformaciondelMedicamentoPorId(Me.txtIdMedicamento.Text.Trim())

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Try
            Me.bsEntregarmedicamento.CancelEdit()
            actualizarinfomaciondelPaciente(Me.txtPaciente.Text.Trim)
            actualizarinformaciondelMedicamentoPorId(Me.txtIdMedicamento.Text.Trim)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtCantidadDeseada_Leave(sender As Object, e As EventArgs) Handles txtCantidadDeseada.Leave
        If Not existenciasDisponibles() Then
            MsgBox("la cantidad de medicamentos solicitada no está disponible intente con una menor", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Function existenciasDisponibles() As Boolean
        Dim cantidadDeseada As Double = 0
        Dim cantidadDisponible As Double = 0
        Try
            cantidadDeseada = Double.Parse(Me.txtCantidadDeseada.Text)
            cantidadDisponible = Double.Parse(Me.txtCantidadDisponible.Text)
        Catch ex As Exception
        End Try
        Return cantidadDisponible >= cantidadDeseada
    End Function

    Private Sub txtCantidadDeseada_Click(sender As Object, e As EventArgs) Handles txtCantidadDeseada.Click
        Me.txtCantidadDeseada.SelectAll()
    End Sub
End Class