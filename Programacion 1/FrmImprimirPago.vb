Public Class FrmImprimirPago
    Public IdPagar As Integer
    Private Sub FrmImprimirPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsPagar.FormadePago' Puede moverla o quitarla según sea necesario.
        Me.FormadePagoTableAdapter.Fill(Me.DsPagar.FormadePago)
        'TODO: esta línea de código carga datos en la tabla 'DsPagar.paciente' Puede moverla o quitarla según sea necesario.
        Me.PacienteTableAdapter.Fill(Me.DsPagar.paciente)
        'TODO: esta línea de código carga datos en la tabla 'DsPagar.encargar_medicamento' Puede moverla o quitarla según sea necesario.
        Me.Encargar_medicamentoTableAdapter.Fill(Me.DsPagar.encargar_medicamento)
        'TODO: esta línea de código carga datos en la tabla 'DsPagar.Pagar' Puede moverla o quitarla según sea necesario.
        Me.PagarTableAdapter.Fill(Me.DsPagar.Pagar)
        actualizarPago()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub actualizarPago()
        ' Me.PagarTableAdapter.Fill(DsPagar.Pagar)
        bsPagar.Filter = "Idpagar='" & Me.IdPagar & "'"
        bsPagar.Sort = "Idpagar ASC"
        Dim IdEncargarMedicamento As Integer = bsPagar.List.Item(0).Item("id_encargarmedicamento")
        Dim idFormaPago As Integer = bsPagar.List.Item(0).Item("idFormaPago")
        actualizarinformaciondeencargarMedicamento(IdEncargarMedicamento)
        actualizarFormadePago(idFormaPago)
    End Sub

    Private Sub actualizarinformaciondeencargarMedicamento(id_encargarmedicamento As Integer)
        ' Me.Encargar_medicamentoTableAdapter.Fill(DsPagar.encargar_medicamento)
        bsencargar_medicamento.Filter = "id_encargarmedicamento='" & id_encargarmedicamento & "'"
        bsencargar_medicamento.Sort = "id_encargarmedicamento ASC"
        Dim idpaciente As Integer = bsencargar_medicamento.List.Item(0).Item("idpaciente")
        actualizarinfomaciondelPaciente(idpaciente)
    End Sub
    Private Sub actualizarinfomaciondelPaciente(idPaciente As Integer)
        'Me.PacienteTableAdapter.Fill(DsPagar.paciente)
        bsPaciente.Filter = "idPaciente='" & idPaciente & "'"
        bsPaciente.Sort = "idPaciente ASC"

    End Sub
    Private Sub actualizarFormadePago(idFormaPago As Integer)
        ' Me.FormadePagoTableAdapter.Fill(DsPagar.FormadePago)
        bsFormadePago.Filter = "idFormaPago='" & idFormaPago & "'"
        bsFormadePago.Sort = "idFormaPago ASC"
    End Sub
End Class