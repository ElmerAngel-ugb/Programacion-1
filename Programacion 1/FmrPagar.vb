Public Class FmrPagar
    Private Sub bsPagar_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

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
        Me.actualizarSubTotal()
        actualizarTotal()
    End Sub

    Private Sub btnBuscarEncargo_Click(sender As Object, e As EventArgs) Handles btnBuscarEncargo.Click
        txtCostoCita.Text = 10
        Try
            bsEncargar_medicamento.Filter = "id_encargarmedicamento='" & Me.txtBuscarEncargo.Text.Trim & "'"
            bsEncargar_medicamento.Sort = "id_encargarmedicamento ASC"
            Me.Encargar_medicamentoTableAdapter.Fill(Form_DsPagar.encargar_medicamento)

            Dim id As Integer = -1
            Try
                id = Integer.Parse(txtidPaciente.Text.Trim)
            Catch ex As Exception
                txtidPaciente.Text = "0"
            End Try
            bsPaciente.Filter = "idPaciente='" & Me.txtidPaciente.Text.Trim & "'"
            bsPaciente.Sort = "idPaciente ASC"
            Me.PacienteTableAdapter.Fill(Form_DsPagar.paciente)
            txtidEncargarmedicamento.Text = tmpidEncargarmedicamento.Value
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        actualizarSubTotal()
        actualizarTotal()
    End Sub

    Private Sub bsEncargar_medicamento_PositionChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtSubTotal_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub bsPagar_PositionChanged(sender As Object, e As EventArgs)
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
        txtCostoCita.Text = 10
        Try
            Me.Validate()
            Me.bsPagar.EndEdit()
            Me.PagarTableAdapter.Update(Form_DSPagar)
            Me.PagarTableAdapter.Fill(Form_DSPagar.Pagar)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        If MsgBox("Seleccione (Si) para pagar", vbQuestion + vbYesNo) = vbNo Then
            navPagar.DeleteItem = Nothing
            MsgBox("Pago Cancelado", 64, "") 
        End If


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
        End If
    End Sub
End Class