Public Class Form1

    Private Sub Btnlongitud_Click(sender As Object, e As EventArgs) Handles Btnlongitud1.Click
        If cbxentrada1.Text = "Milímetro" And cbxsalida1.Text = "Milímetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text)
            lblnum.Text = "Milímetro"
        ElseIf cbxentrada1.Text = "Milímetro" And cbxsalida1.Text = "Centímetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 10
            lblnum.Text = "Centímetro"
        ElseIf cbxentrada1.Text = "Milímetro" And cbxsalida1.Text = "Metro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 1000
            lblnum.Text = "Metro"
        ElseIf cbxentrada1.Text = "Milímetro" And cbxsalida1.Text = "Kilometros" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 1000000
            lblnum.Text = "Kilómetros"
        ElseIf cbxentrada1.Text = "Milímetro" And cbxsalida1.Text = "Pulgadas" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 0.0394
            lblnum.Text = "Pulgadas"
        ElseIf cbxentrada1.Text = "Milímetro" And cbxsalida1.Text = "Pie" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 0.00328084
            lblnum.Text = "Pie"
        ElseIf cbxentrada1.Text = "Milímetro" And cbxsalida1.Text = "Yarda" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 0.00109361
            lblnum.Text = "Yarda"
        ElseIf cbxentrada1.Text = "Milímetro" And cbxsalida1.Text = "Milla" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 0.000000621371
            lblnum.Text = "Milla"
        ElseIf cbxentrada1.Text = "Milímetro" And cbxsalida1.Text = "Decámetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 0.0001
            lblnum.Text = "Decámetro"
        ElseIf cbxentrada1.Text = "Milímetro" And cbxsalida1.Text = "Decímetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 0.01
            lblnum.Text = "Decímetro"
        ElseIf cbxentrada1.Text = "centímetro" And cbxsalida1.Text = "Milímetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 0.1
            lblnum.Text = "Mlímetro"
        ElseIf cbxentrada1.Text = "centímetro" And cbxsalida1.Text = "Metro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 100
            lblnum.Text = "Mertro"
        End If
    End Sub
End Class
