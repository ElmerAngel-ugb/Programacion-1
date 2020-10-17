Public Class FmrRegistrodePersonalvb
    Private Sub FmrRegistrodePersonalvb_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SistemaClinico.fmrRegistroPersonal = Nothing
    End Sub
End Class