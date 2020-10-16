Public Class Form1
    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'form_DSMedicamentos.medicamento' Puede moverla o quitarla según sea necesario.
        Me.MedicamentoTableAdapter.Fill(Me.form_DSMedicamentos.medicamento)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.MedicamentoTableAdapter.FillBy(Me.form_DSMedicamentos.medicamento)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub bnMedicamentos_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.bsMedicamentos.EndEdit()
        Me.MedicamentoTableAdapter.Update(form_DSMedicamentos)
        Me.MedicamentoTableAdapter.Fill(form_DSMedicamentos.medicamento)
    End Sub

    Private Sub navMedicamentos_RefreshItems(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtBuscar_Click(sender As Object, e As EventArgs)
        Me.txtBuscar.SelectAll()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        bsMedicamentos.Filter = "codigo='" & Me.txtBuscar.Text.Trim & "'"
        bsMedicamentos.Sort = "idmedicamento ASC"
        Me.MedicamentoTableAdapter.Fill(form_DSMedicamentos.medicamento)
    End Sub

    Private Sub btnRemoveFilter_Click_1(sender As Object, e As EventArgs) Handles btnRemoveFilter.Click
        bsMedicamentos.Filter = ""
        Me.MedicamentoTableAdapter.Fill(form_DSMedicamentos.medicamento)
        Me.txtBuscar.Text = "Escriba un codigo"
    End Sub
    Private Sub navMedicamentos_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)
        navMedicamentos.DeleteItem = BindingNavigatorDeleteItem
        If e.ClickedItem Is navMedicamentos.DeleteItem Then
            If MsgBox("¿Desea elimar el registro?", vbQuestion + vbYesNo) = vbNo Then
                navMedicamentos.DeleteItem = Nothing
                MsgBox("Acción Cancelada", 64, "")
            End If
        End If
    End Sub
End Class



