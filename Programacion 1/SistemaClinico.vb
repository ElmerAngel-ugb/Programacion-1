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
    Public FrmPagosPendientes As FrmPagosPendientes
    Public FormRegistro_Acompañante As FormRegistro_Acompañante
    Public fmrListadePacientes As fmrListadePacientes
    Public fmrListaPersonal As fmrListaPersonal
    Public FrmListaMedicamentos As FrmListaMedicamentos
    Public frmListadodeAcompañante As frmListadodeAcompañante
    Public frmLisMedicamentoCategoria As frmLisMedicamentoCategoria
    Public Form1 As Form1
    Public frmListadeproveedores As frmListadeproveedores




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

    Private Sub ImprimirPagoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If FrmImprimirPago Is Nothing Then
            FrmImprimirPago = New FrmImprimirPago
            FrmImprimirPago.MdiParent = Me
            FrmImprimirPago.Show()
        Else
            FrmImprimirPago.Activate()
        End If
    End Sub

    Private Sub PagosPendientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosPendientesToolStripMenuItem.Click
        If FrmPagosPendientes Is Nothing Then
            FrmPagosPendientes = New FrmPagosPendientes
            FrmPagosPendientes.MdiParent = Me
            FrmPagosPendientes.Show()
        Else
            FrmPagosPendientes.Activate()
        End If
    End Sub

    Private Sub RegistroDeAcompañanteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeAcompañanteToolStripMenuItem.Click
        If FormRegistro_Acompañante Is Nothing Then
            FormRegistro_Acompañante = New FormRegistro_Acompañante
            FormRegistro_Acompañante.MdiParent = Me
            FormRegistro_Acompañante.Show()
        Else
            FormRegistro_Acompañante.Activate()
        End If
    End Sub

    Private Sub ListadoDePacientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDePacientesToolStripMenuItem.Click
        If fmrListadePacientes Is Nothing Then
            fmrListadePacientes = New fmrListadePacientes
            fmrListadePacientes.MdiParent = Me
            fmrListadePacientes.Show()
        Else
            fmrListadePacientes.Activate()
        End If
    End Sub

    Private Sub ListadoDePersonalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDePersonalToolStripMenuItem.Click
        If fmrListaPersonal Is Nothing Then
            fmrListaPersonal = New fmrListaPersonal
            fmrListaPersonal.MdiParent = Me
            fmrListaPersonal.Show()
        Else
            fmrListaPersonal.Activate()
        End If
    End Sub

    Private Sub ListadoDeMedicamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeMedicamentosToolStripMenuItem.Click
        If FrmListaMedicamentos Is Nothing Then
            FrmListaMedicamentos = New FrmListaMedicamentos
            FrmListaMedicamentos.MdiParent = Me
            FrmListaMedicamentos.Show()
        Else
            FrmListaMedicamentos.Activate()
        End If
    End Sub

    Private Sub ListadoDeAcompañantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeAcompañantesToolStripMenuItem.Click
        If frmListadodeAcompañante Is Nothing Then
            frmListadodeAcompañante = New frmListadodeAcompañante
            frmListadodeAcompañante.MdiParent = Me
            frmListadodeAcompañante.Show()
        Else
            frmListadodeAcompañante.Activate()
        End If
    End Sub

    Private Sub MedicamentoPorCategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MedicamentoPorCategoriaToolStripMenuItem.Click
        If frmLisMedicamentoCategoria Is Nothing Then
            frmLisMedicamentoCategoria = New frmLisMedicamentoCategoria
            frmLisMedicamentoCategoria.MdiParent = Me
            frmLisMedicamentoCategoria.Show()
        Else
            frmLisMedicamentoCategoria.Activate()
        End If
    End Sub

    Private Sub HistorialDeMedicamentoSolicitadoPorCodigoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialDeMedicamentoSolicitadoPorCodigoToolStripMenuItem.Click
        If Form1 Is Nothing Then
            Form1 = New Form1
            Form1.MdiParent = Me
            Form1.Show()
        Else
            Form1.Activate()
        End If
    End Sub

    Private Sub ListadoDeProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeProveedoresToolStripMenuItem.Click
        If frmListadeproveedores Is Nothing Then
            frmListadeproveedores = New frmListadeproveedores
            frmListadeproveedores.MdiParent = Me
            frmListadeproveedores.Show()
        Else
            frmListadeproveedores.Activate()
        End If
    End Sub
End Class