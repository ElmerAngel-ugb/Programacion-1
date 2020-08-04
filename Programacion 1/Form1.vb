Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Dim es una palabra reservada para declara una variable
        Dim num1, num2, respuesta As Double
        num1 = txtnum1.Text
        num2 = txtnum2.Text
        If optSuma.Checked Then
            lblrespuesta.Text = num1 + num2
        End If

        If optResta.Checked Then
            lblrespuesta.Text = num1 - num2
        End If

        If optMultiplicacion.Checked Then
            lblrespuesta.Text = num1 * num2
        End If

        If optDivision.Checked Then
            lblrespuesta.Text = num1 / num2
        End If

        If optPortsentaje.Checked Then
            lblrespuesta.Text = num1 * num2 / 100
        End If

        If optExponenciacion.Checked Then
            lblrespuesta.Text = num1 ^ num2
        End If

        If optMod.Checked Then
            lblrespuesta.Text = num1 Mod num2
        End If
    End Sub
End Class
