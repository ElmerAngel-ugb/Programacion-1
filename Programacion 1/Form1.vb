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

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

    End Sub

    Private Sub navMedicamentos_RefreshItems(sender As Object, e As EventArgs) Handles navMedicamentos.RefreshItems

    End Sub
End Class



