Public Class FrmFormasdePago
    Private Sub FrmMantenimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsFormaPago.FormadePago' Puede moverla o quitarla según sea necesario.
        Me.FormadePagoTableAdapter.Fill(Me.Form_DsFormaPago.FormadePago)

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            Me.Validate()
            Me.bsFormaPago.EndEdit()
            Me.FormadePagoTableAdapter.Update(Form_DsFormaPago)
            Me.FormadePagoTableAdapter.Fill(Form_DsFormaPago.FormadePago)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            bsFormaPago.Filter = "idFormaPago='" & Me.txtBuscar.Text.Trim & "'"
            bsFormaPago.Sort = "idFormaPago ASC"
            Me.FormadePagoTableAdapter.Fill(Form_DsFormaPago.FormadePago)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnRemoveFilter_Click(sender As Object, e As EventArgs) Handles btnRemoveFilter.Click

        Try
            bsFormaPago.Filter = ""
            Me.FormadePagoTableAdapter.Fill(Form_DsFormaPago.FormadePago)
            Me.txtBuscar.Text = "Escriba un codigo"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            Me.bsFormaPago.CancelEdit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub FrmMantenimiento_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SistemaClinico.frmFormasdePago = Nothing
    End Sub

    Private Sub txtBuscar_Click(sender As Object, e As EventArgs) Handles txtBuscar.Click
        Me.txtBuscar.SelectAll()
    End Sub

    Private Sub txtFormaPago_Click(sender As Object, e As EventArgs) Handles txtFormaPago.Click
        Me.txtFormaPago.SelectAll()
    End Sub

    Private Sub NavFormasdePago_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles NavFormasdePago.ItemClicked
        NavFormasdePago.DeleteItem = BindingNavigatorDeleteItem
        If e.ClickedItem Is NavFormasdePago.DeleteItem Then
            If MsgBox("¿Desea elimar el registro?", vbQuestion + vbYesNo) = vbNo Then
                NavFormasdePago.DeleteItem = Nothing
                MsgBox("Acción Cancelada", 64, "")
            End If
        End If
    End Sub
End Class