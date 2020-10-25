Public Class FmrPagar

    Dim btnPagarFuepresionado As Boolean = False
    Private Sub FmrPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Form_DsPagar.Pagar' Puede moverla o quitarla según sea necesario.
        Me.PagarTableAdapter.Fill(Me.Form_DsPagar.Pagar)
        'TODO: esta línea de código carga datos en la tabla 'DsPagar1.encargar_medicamento' Puede moverla o quitarla según sea necesario.
        Me.Encargar_medicamentoTableAdapter.Fill(Me.Form_DsPagar.encargar_medicamento)
        'TODO: esta línea de código carga datos en la tabla 'DsPagar1.paciente' Puede moverla o quitarla según sea necesario.
        Me.PacienteTableAdapter.Fill(Me.Form_DsPagar.paciente)
        'TODO: esta línea de código carga datos en la tabla 'Form_DSPagar.encargar_medicamento' Puede moverla o quitarla según sea necesario.
        Me.Encargar_medicamentoTableAdapter.Fill(Me.Form_DSPagar.encargar_medicamento)
        'TODO: esta línea de código carga datos en la tabla 'Form_DSPagar.paciente' Puede moverla o quitarla según sea necesario.
        Me.PacienteTableAdapter.Fill(Me.Form_DSPagar.paciente)
        'TODO: esta línea de código carga datos en la tabla 'Form_DSPagar.Pagar' Puede moverla o quitarla según sea necesario.
        Me.PagarTableAdapter.Fill(Me.Form_DSPagar.Pagar)
        actualizarinformaciondeencargarMedicamento(Me.txtidEncargarmedicamento.Text.Trim)
        actualizarinfomaciondelPaciente(Me.txtidPaciente.Text.Trim)
        Me.actualizarSubTotal()
        actualizarTotal()
    End Sub

    Private Sub btnBuscarEncargo_Click(sender As Object, e As EventArgs) Handles btnBuscarEncargo.Click
        btnPagarFuepresionado = False
        txtCostoCita.Text = 10
        'Try
        'bsEncargar_medicamento.Filter = "id_encargarmedicamento='" & Me.txtBuscarEncargo.Text.Trim & "'"
        'bsEncargar_medicamento.Sort = "id_encargarmedicamento ASC"
        ' Me.Encargar_medicamentoTableAdapter.Fill(Form_DsPagar.encargar_medicamento)

        ' Dim id As Integer = -1
        'Try
        'id = Integer.Parse(txtidPaciente.Text.Trim)
        'Catch ex As Exception
        'txtidPaciente.Text = "0"
        'End Try
        'bsPaciente.Filter = "idPaciente='" & Me.txtidPaciente.Text.Trim & "'"
        'bsPaciente.Sort = "idPaciente ASC"
        'Me.PacienteTableAdapter.Fill(Form_DsPagar.paciente)
        'txtidEncargarmedicamento.Text = tmpidEncargarmedicamento.Value
        'Catch ex As Exception
        'MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        'End Try
        actualizarinformaciondeencargarMedicamento(Me.txtBuscarEncargo.Text.Trim)
        actualizarinfomaciondelPaciente(Me.txtidPaciente.Text.Trim)
        txtidEncargarmedicamento.Text = tmpidEncargarmedicamento.Value
    End Sub

    Private Sub bsEncargar_medicamento_PositionChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtSubTotal_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub bsPagar_PositionChanged(sender As Object, e As EventArgs) Handles bsPagar.PositionChanged
        actualizarinformaciondeencargarMedicamento(Me.txtidEncargarmedicamento.Text.Trim)
        actualizarinfomaciondelPaciente(Me.txtidPaciente.Text.Trim)
        actualizarSubTotal()
        actualizarTotal()
    End Sub

    Private Sub actualizarSubTotal()
        Dim subTotal As Double = 0
        Dim costoCita As Double = 0
        Dim costoMedicina As Double = 0
        Try
            costoCita = Double.Parse(txtCostoCita.Text)
            costoMedicina = Double.Parse(txtCostoMedicina.Text)
        Catch ex As Exception

        End Try
        subTotal = costoCita + costoMedicina
        txtSubTotal.Text = subTotal
    End Sub


    Private Sub bsPagar_BindingComplete(sender As Object, e As BindingCompleteEventArgs)
        txtCostoCita.Text = 10
    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        btnPagarFuepresionado = True
        txtCostoCita.Text = 10
        If MsgBox("Seleccione (Si) para pagar", vbQuestion + vbYesNo) = vbNo Then
            MsgBox("Pago Cancelado", 64, "")
            bsPagar.CancelEdit()
            Return
        End If
        Try
            Me.Validate()
            Me.bsPagar.EndEdit()
            Me.PagarTableAdapter.Update(Form_DsPagar)
            Me.PagarTableAdapter.Fill(Form_DsPagar.Pagar)
            MsgBox("Pago realizado con éxito")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try



    End Sub

    Private Sub bsEncargar_medicamento_CurrentChanged(sender As Object, e As EventArgs) Handles bsEncargar_medicamento.CurrentChanged

    End Sub

    Private Sub bsPagar_AddingNew(sender As Object, e As System.ComponentModel.AddingNewEventArgs) Handles bsPagar.AddingNew
        txtCostoCita.Text = 10
    End Sub

    Private Sub txtCostoIngreso_TextChanged(sender As Object, e As EventArgs) Handles txtCostoIngreso.TextChanged
        actualizarTotal()
    End Sub

    Private Sub actualizarTotal()
        Dim subTotal As Double = 0
        Dim costoIngreso As Double = 0
        Dim total As Double = 0
        Try
            subTotal = Double.Parse(txtSubTotal.Text)
            costoIngreso = Double.Parse(txtCostoIngreso.Text)
        Catch ex As Exception

        End Try
        total = costoIngreso + subTotal
        txtTotalPagar.Text = total

    End Sub

    Private Sub txtBuscarEncargo_Click(sender As Object, e As EventArgs) Handles txtBuscarEncargo.Click
        Me.txtBuscarEncargo.SelectAll()
    End Sub

    Private Sub txtBuscarpago_Click(sender As Object, e As EventArgs) Handles txtBuscarpago.Click
        Me.txtBuscarpago.SelectAll()
    End Sub

    Private Sub navPagar_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles navPagar.ItemClicked
        btnPagarFuepresionado = False
        navPagar.DeleteItem = BindingNavigatorDeleteItem
        navPagar.MoveFirstItem = BindingNavigatorMoveFirstItem
        navPagar.MoveLastItem = BindingNavigatorMoveLastItem
        navPagar.MoveNextItem = BindingNavigatorMoveNextItem
        navPagar.MovePreviousItem = BindingNavigatorMovePreviousItem
        If e.ClickedItem Is navPagar.DeleteItem Then
            If MsgBox("¿Desea elimar el pago seleccionado?", vbQuestion + vbYesNo) = vbNo Then
                navPagar.DeleteItem = Nothing
                MsgBox("Pago Cancelado", 64, "")
            End If
        ElseIf e.ClickedItem Is navPagar.MoveFirstItem Or e.ClickedItem Is navPagar.MoveLastItem Or e.ClickedItem Is navPagar.MoveNextItem Or e.ClickedItem Is navPagar.MovePreviousItem Then
            actualizarinformaciondeencargarMedicamento(Me.txtidEncargarmedicamento.Text.Trim)
            actualizarinfomaciondelPaciente(Me.txtidPaciente.Text.Trim)
            actualizarSubTotal()
            actualizarTotal()
            If String.IsNullOrEmpty(Me.txtCostoIngreso.Text.Trim()) Or String.IsNullOrEmpty(Me.txtCostoCita.Text.Trim()) Or String.IsNullOrEmpty(Me.txtCostoMedicina.Text.Trim()) Or String.IsNullOrEmpty(Me.txtidEncargarmedicamento.Text.Trim()) Then
                navPagar.MoveFirstItem = Nothing
                navPagar.MoveLastItem = Nothing
                navPagar.MoveNextItem = Nothing
                navPagar.MovePreviousItem = Nothing
            End If
            If String.IsNullOrEmpty(Me.txtCostoIngreso.Text.Trim()) Then
                MsgBox("El Costode ingreso no puede quedar vacio", MsgBoxStyle.Critical, "Error")
            ElseIf String.IsNullOrEmpty(Me.txtCostoCita.Text.Trim()) Then
                MsgBox("El costo de cita no puede quedar vacio", MsgBoxStyle.Critical, "Error")
            ElseIf String.IsNullorEmpty(Me.txtCostoMedicina.Text.Trim) Then
                MsgBox("El costo de medicina no puedo quedar vacio ", MsgBoxStyle.Critical, "Error")
                MsgBox("El costo de cita no puede quedar vacio", MsgBoxStyle.Critical, "Error")
            ElseIf String.IsNullOrEmpty(Me.txtidEncargarmedicamento.Text.Trim) Then
                MsgBox("El id encargar medicamento no puedo quedar vacio ", MsgBoxStyle.Critical, "Error")
            End If
        End If

    End Sub

    Private Sub FmrPagar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SistemaClinico.fmrPagar = Nothing

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click

    End Sub

    Private Sub btnRemoveFilter_Click(sender As Object, e As EventArgs) Handles btnRemoveFilter.Click
        btnPagarFuepresionado = False
        Try
            Me.bsPagar.Filter = ""
            Me.PagarTableAdapter.Fill(Form_DsPagar.Pagar)
            Me.txtBuscarpago.Text = "Escriba un codigo"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnCancelarPago_Click(sender As Object, e As EventArgs) Handles btnCancelarPago.Click
        btnPagarFuepresionado = False
        Me.bsPagar.CancelEdit()
        actualizarinformaciondeencargarMedicamento(Me.txtidEncargarmedicamento.Text.Trim)
        actualizarinfomaciondelPaciente(Me.txtidPaciente.Text.Trim)
        actualizarSubTotal()
        actualizarTotal()
    End Sub

    Private Sub btnBuscarPago_Click(sender As Object, e As EventArgs) Handles btnBuscarPago.Click
        btnPagarFuepresionado = False
        Try
            bsPagar.Filter = "Idpagar='" & Me.txtBuscarpago.Text.Trim & "'"
            bsPagar.Sort = "Idpagar ASC"
            Me.PagarTableAdapter.Fill(Form_DsPagar.Pagar)
            actualizarinformaciondeencargarMedicamento(Me.txtidEncargarmedicamento.Text.Trim)
            actualizarinfomaciondelPaciente(Me.txtidPaciente.Text.Trim)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
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
            Me.PacienteTableAdapter.Fill(Form_DsPagar.paciente)
        Catch ex As Exception
            bsPaciente.Filter = "idPaciente='0'"
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub actualizarinformaciondeencargarMedicamento(id_encargarmedicamento As String)
        Dim id As Integer = -1
        Try
            id = Integer.Parse(id_encargarmedicamento)
        Catch ex As Exception
            id_encargarmedicamento = "0"
        End Try
        Try
            bsEncargar_medicamento.Filter = "id_encargarmedicamento='" & id_encargarmedicamento & "'"
            bsEncargar_medicamento.Sort = "id_encargarmedicamento ASC"
            Me.Encargar_medicamentoTableAdapter.Fill(Form_DsPagar.encargar_medicamento)
            actualizarSubTotal()
            actualizarTotal()
            'Me.txtidEncargarmedicamento.Text = Me.tmpidEncargarmedicamento.Text
        Catch ex As Exception
            bsEncargar_medicamento.Filter = "id_encargarmedicamento='0'"
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Encargarmedicamento")
        End Try
    End Sub
End Class