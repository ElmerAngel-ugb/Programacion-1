Public Class SistemaClinico
    Public fmrRegistroPersonal As FmrRegistrodePersonalvb
    Public fmrMedicamento As FmrMedicamento
    Public fmrEncargarMedicamento As FmrEncargarMedicamento
    Public frmPaciente As FrmPaciente
    Public frmBuscarPaciente As FrmBuscarPaciente
    Public fmrPagar As FmrPagar
    Public frmCategoriasMedicamentos As frmCegorias_Medicamentosvb
    Public frmElmiminardatosdelpaciente As FmrEliminardatosdelpaciente
    Public frmFormasdePago As FrmFormasdePago

    Private Sub EncargarMedicamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncargarMedicamentoToolStripMenuItem.Click
        If fmrEncargarMedicamento Is Nothing Then
            fmrEncargarMedicamento = New FmrEncargarMedicamento
            fmrEncargarMedicamento.MdiParent = Me
            fmrEncargarMedicamento.Show()
        Else
            fmrEncargarMedicamento.Activate()
        End If
    End Sub

    Private Sub PacienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacienteToolStripMenuItem.Click
        If frmPaciente Is Nothing Then
            frmPaciente = New FrmPaciente
            frmPaciente.MdiParent = Me
            frmPaciente.Show()
        Else
            frmPaciente.Activate()
        End If
    End Sub

    Private Sub RegistrarPacienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarPacienteToolStripMenuItem.Click
        If frmBuscarPaciente Is Nothing Then
            frmBuscarPaciente = New FrmBuscarPaciente
            frmBuscarPaciente.MdiParent = Me
            frmBuscarPaciente.Show()
        Else
            frmBuscarPaciente.Activate()
        End If
    End Sub

    Private Sub RegistroDePersonalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDePersonalToolStripMenuItem.Click
        If fmrRegistroPersonal Is Nothing Then
            fmrRegistroPersonal = New FmrRegistrodePersonalvb
            fmrRegistroPersonal.MdiParent = Me
            fmrRegistroPersonal.Show()
        Else
            fmrRegistroPersonal.Activate()
        End If
    End Sub

    Private Sub MedicamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MedicamentoToolStripMenuItem.Click
        If fmrMedicamento Is Nothing Then
            fmrMedicamento = New FmrMedicamento
            fmrMedicamento.MdiParent = Me
            fmrMedicamento.Show()
        Else
            fmrMedicamento.Activate()
        End If
    End Sub

    Private Sub PagarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagarToolStripMenuItem.Click
        If fmrPagar Is Nothing Then
            fmrPagar = New FmrPagar
            fmrPagar.MdiParent = Me
            fmrPagar.Show()
        Else
            fmrPagar.Activate()
        End If
    End Sub

    Private Sub CategoriasDeMedicinaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriasDeMedicinaToolStripMenuItem.Click
        If frmCategoriasMedicamentos Is Nothing Then
            frmCategoriasMedicamentos = New frmCegorias_Medicamentosvb
            frmCategoriasMedicamentos.MdiParent = Me
            frmCategoriasMedicamentos.Show()
        Else
            fmrPagar.Activate()
        End If
    End Sub

    Private Sub EliminarDatosDelPacienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarDatosDelPacienteToolStripMenuItem.Click
        If frmElmiminardatosdelpaciente Is Nothing Then
            frmElmiminardatosdelpaciente = New FmrEliminardatosdelpaciente
            frmElmiminardatosdelpaciente.MdiParent = Me
            frmElmiminardatosdelpaciente.Show()
        Else
            fmrPagar.Activate()
        End If
    End Sub



    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If frmFormasdePago Is Nothing Then
            frmFormasdePago = New FrmFormasdePago
            frmFormasdePago.MdiParent = Me
            frmFormasdePago.Show()
        Else
            frmFormasdePago.Activate()
        End If
    End Sub
End Class