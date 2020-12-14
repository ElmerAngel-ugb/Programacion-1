Public Class FormRegistro_Acompañante
    Private Sub AcompananteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AcompananteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AcompananteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SdExpediente)

    End Sub

    Private Sub FormRegistro_Acompañante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SdExpediente.Registro' Puede moverla o quitarla según sea necesario.
        Me.RegistroTableAdapter.FillRegistro(Me.SdExpediente.Registro)
        'TODO: esta línea de código carga datos en la tabla 'SdExpediente.Acompanante' Puede moverla o quitarla según sea necesario.
        Me.AcompananteTableAdapter.FillAcompanante(Me.SdExpediente.Acompanante)

    End Sub
End Class
