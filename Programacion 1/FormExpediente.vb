Public Class FormExpediente
    Private Sub FormExpediente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SdExpediente.Pediatra' Puede moverla o quitarla según sea necesario.
        Me.PediatraTableAdapter.FillPediatra(Me.SdExpediente.Pediatra)
        'TODO: esta línea de código carga datos en la tabla 'SdExpediente.Acompanante' Puede moverla o quitarla según sea necesario.
        Me.AcompananteTableAdapter.FillAcompanante(Me.SdExpediente.Acompanante)
        'TODO: esta línea de código carga datos en la tabla 'SdExpediente.Registro' Puede moverla o quitarla según sea necesario.
        Me.RegistroTableAdapter.FillRegistro(Me.SdExpediente.Registro)
        'TODO: esta línea de código carga datos en la tabla 'SdExpediente.medicamento' Puede moverla o quitarla según sea necesario.
        Me.MedicamentoTableAdapter.Fillmedicamento(Me.SdExpediente.medicamento)
        'TODO: esta línea de código carga datos en la tabla 'SdExpediente.Receta' Puede moverla o quitarla según sea necesario.
        Me.RecetaTableAdapter.FillReceta(Me.SdExpediente.Receta)
        'TODO: esta línea de código carga datos en la tabla 'SdExpediente.Diagnostico' Puede moverla o quitarla según sea necesario.
        Me.DiagnosticoTableAdapter.FillDiagnostico(Me.SdExpediente.Diagnostico)
        'TODO: esta línea de código carga datos en la tabla 'SdExpediente.Expediente' Puede moverla o quitarla según sea necesario.
        Me.ExpedienteTableAdapter.FillExpediente(Me.SdExpediente.Expediente)
        'TODO: esta línea de código carga datos en la tabla 'SdExpediente.Expediente' Puede moverla o quitarla según sea necesario.
        Me.ExpedienteTableAdapter.FillExpediente(Me.SdExpediente.Expediente)

    End Sub

    Private Sub ExpedienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ExpedienteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ExpedienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SdExpediente)

    End Sub
End Class