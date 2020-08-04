Public Class Form1


    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Dim ntabla As SByte
        ntabla = txtntabla.Text


        lstTabla.Items.Clear()
        For i = 1 To 10
            lstTabla.Items.Add(ntabla.ToString() + "x" + i.ToString() + "=" + (ntabla * i).ToString())
        Next

    End Sub
End Class
