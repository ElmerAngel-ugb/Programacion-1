Partial Class dsEntregarmedicamentos
    Partial Public Class medicamentoDataTable
        Private Sub medicamentoDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.idmedicamentoColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class
End Class
