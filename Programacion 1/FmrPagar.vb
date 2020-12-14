Public Class FmrPagar

    Dim btnPagarFuepresionado As Boolean = False
    Dim formLoad As Boolean = False
    Dim btnRemoveFilterFuePresionado As Boolean = False
    Public FrmImprimirPago As FrmImprimirPago

    Private Sub FmrPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formLoad = True
        Me.PagarTableAdapter.Fill(Me.Form_DsPagar.Pagar)
        Me.PacienteTableAdapter.Fill(Me.Form_DsPagar.paciente)
        Me.FormadePagoTableAdapter.Fill(Me.DsFormaPago.FormadePago)
        Me.Encargar_medicamentoTableAdapter.Fill(Me.Form_DsPagar.encargar_medicamento)
        actualizarinformaciondeencargarMedicamento(Me.txtidEncargarmedicamento.Text.Trim)
        actualizarinfomaciondelPaciente(Me.txtidPaciente.Text.Trim)
        Me.actualizarSubTotal()
        actualizarTotal()
        actualizarFormadePago()
    End Sub

    Private Sub actualizarFormadePago()
        'Throw New NotImplementedException()
    End Sub

    Private Sub btnBuscarEncargo_Click(sender As Object, e As EventArgs) Handles btnBuscarEncargo.Click
        btnPagarFuepresionado = False
        btnRemoveFilterFuePresionado = False
        formLoad = False
        txtCostoCita.Text = 10
        txtidEncargarmedicamento.Text = ""
        tmpidEncargarmedicamento.Text = ""
        actualizarinformaciondeencargarMedicamento(Me.txtBuscarEncargo.Text.Trim)
        actualizarinfomaciondelPaciente(Me.txtidPaciente.Text.Trim)
        txtidEncargarmedicamento.Text = tmpidEncargarmedicamento.Value
        txtCostoIngreso.Text = ""
    End Sub

    Private Sub bsPagar_PositionChanged(sender As Object, e As EventArgs) Handles bsPagar.PositionChanged
        If formLoad Or btnPagarFuepresionado Or btnRemoveFilterFuePresionado Then
            Return
        End If
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
        Pagar()
    End Sub
    Private Sub Pagar()
        btnPagarFuepresionado = True
        btnRemoveFilterFuePresionado = False
        formLoad = False
        txtCostoCita.Text = 10
        If String.IsNullOrEmpty(Me.txtCostoIngreso.Text.Trim) Or String.IsNullOrEmpty(Me.txtidEncargarmedicamento.Text.Trim) Or String.IsNullOrEmpty(Me.txtCostoCita.Text.Trim) Or Me.txtidEncargarmedicamento.Text.Trim = 0 Or String.IsNullOrEmpty(Me.cbxFormadePago.Text.Trim) Then
            If String.IsNullOrEmpty(Me.txtidEncargarmedicamento.Text.Trim) Or Me.txtidEncargarmedicamento.Text.Trim = 0 Then
                MsgBox("Seleccione un encargo")
            ElseIf String.IsNullOrEmpty(Me.txtCostoIngreso.Text.Trim) Then
                MsgBox("Coloque el costo del ingreso")
            ElseIf String.IsNullOrEmpty(Me.txtCostoCita.Text.Trim) Then
                MsgBox("Coloque el costo de la cita")
            ElseIf String.IsNullOrEmpty(Me.cbxFormadePago.Text.Trim) Then
                MsgBox("Seleccione una forma de pago")
            End If
            Return
        End If
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
        btnRemoveFilterFuePresionado = False
        formLoad = False
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

        ElseIf e.ClickedItem Is navPagar.AddNewItem Then
            CbPendientes.Checked = False
        ElseIf e.ClickedItem Is navPagar.MoveFirstItem Or e.ClickedItem Is navPagar.MoveLastItem Or e.ClickedItem Is navPagar.MoveNextItem Or e.ClickedItem Is navPagar.MovePreviousItem Then
            actualizarinformaciondeencargarMedicamento(Me.txtidEncargarmedicamento.Text.Trim)
            actualizarinfomaciondelPaciente(Me.txtidPaciente.Text.Trim)
            actualizarSubTotal()
            actualizarTotal()
            If String.IsNullOrEmpty(Me.txtCostoIngreso.Text.Trim()) Or String.IsNullOrEmpty(Me.txtCostoCita.Text.Trim()) Or String.IsNullOrEmpty(Me.txtCostoMedicina.Text.Trim()) Or String.IsNullOrEmpty(Me.txtidEncargarmedicamento.Text.Trim()) Or String.IsNullOrEmpty(Me.cbxFormadePago.Text.Trim()) Then
                navPagar.MoveFirstItem = Nothing
                navPagar.MoveLastItem = Nothing
                navPagar.MoveNextItem = Nothing
                navPagar.MovePreviousItem = Nothing
            End If
            If String.IsNullOrEmpty(Me.txtCostoIngreso.Text.Trim()) Then
                MsgBox("El Costode ingreso no puede quedar vacio", MsgBoxStyle.Critical, "Error")
            ElseIf String.IsNullOrEmpty(Me.txtCostoCita.Text.Trim()) Then
                MsgBox("El costo de cita no puede quedar vacio", MsgBoxStyle.Critical, "Error")
            ElseIf String.IsNullOrEmpty(Me.txtCostoMedicina.Text.Trim) Then
                MsgBox("El costo de medicina no puedo quedar vacio ", MsgBoxStyle.Critical, "Error")
                MsgBox("El costo de cita no puede quedar vacio", MsgBoxStyle.Critical, "Error")
            ElseIf String.IsNullOrEmpty(Me.txtidEncargarmedicamento.Text.Trim) Then
                MsgBox("El id encargar medicamento no puedo quedar vacio ", MsgBoxStyle.Critical, "Error")
            ElseIf String.IsNullOrEmpty(Me.cbxFormadePago.Text.Trim()) Then
                MsgBox("Seleccione una forma de pago", MsgBoxStyle.Critical, "Error")
            End If
        End If

    End Sub

    Private Sub FmrPagar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SistemaClinico.fmrPagar = Nothing

    End Sub

    Private Sub btnRemoveFilter_Click(sender As Object, e As EventArgs) Handles btnRemoveFilter.Click
        btnPagarFuepresionado = False
        btnRemoveFilterFuePresionado = True
        formLoad = False
        Try
            Me.bsPagar.Filter = ""
            Me.PagarTableAdapter.Fill(Form_DsPagar.Pagar)
            Me.txtBuscarpago.Text = "Escriba un codigo"
            actualizarinformaciondeencargarMedicamento(Me.txtidEncargarmedicamento.Text.Trim)
            actualizarinfomaciondelPaciente(Me.txtidPaciente.Text.Trim)
            Me.actualizarSubTotal()
            actualizarTotal()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnCancelarPago_Click(sender As Object, e As EventArgs) Handles btnCancelarPago.Click
        btnPagarFuepresionado = False
        btnRemoveFilterFuePresionado = False
        formLoad = False
        Me.bsPagar.CancelEdit()
        actualizarinformaciondeencargarMedicamento(Me.txtidEncargarmedicamento.Text.Trim)
        actualizarinfomaciondelPaciente(Me.txtidPaciente.Text.Trim)
        actualizarSubTotal()
        actualizarTotal()
    End Sub

    Private Sub btnBuscarPago_Click(sender As Object, e As EventArgs) Handles btnBuscarPago.Click
        btnPagarFuepresionado = False
        btnRemoveFilterFuePresionado = False
        formLoad = False
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
            Me.txtidEncargarmedicamento.Text = Me.tmpidEncargarmedicamento.Text
        Catch ex As Exception
            bsEncargar_medicamento.Filter = "id_encargarmedicamento='0'"
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Encargarmedicamento")
        End Try
    End Sub

    'Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
    'Try
    'Me.PagarTableAdapter.FillBy(Me.Form_DsPagar.Pagar)
    'ch ex As System.Exception
    ' System.Windows.Forms.MessageBox.Show(ex.Message)
    'End Try

    ' End Sub

    'Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs)
    'Try
    'Me.PagarTableAdapter.FillBy1(Me.Form_DsPagar.Pagar)
    'Catch ex As System.Exception
    ' System.Windows.Forms.MessageBox.Show(ex.Message)
    'End Try

    ' End Sub


    Private Sub btnImprimirPago_Click(sender As Object, e As EventArgs) Handles btnImprimirPago.Click
        Pagar()
        FrmImprimirPago = New FrmImprimirPago
        FrmImprimirPago.IdPagar = -1
        Try
            FrmImprimirPago.IdPagar = Integer.Parse(Me.txtPagar.Text.Trim)
        Catch ex As Exception

        End Try
        FrmImprimirPago.Show()
    End Sub
End Class