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

        End If

        If cbxentrada1.Text = "Centímetro" And cbxsalida1.Text = "centímetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text)
            lblnum.Text = "centímetro"
        ElseIf cbxentrada1.Text = "Centímetro" And cbxsalida1.Text = "Milímetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 0.1
            lblnum.Text = "Milímetro"
        ElseIf cbxentrada1.Text = "Centímetro" And cbxsalida1.Text = "Metro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 100
            lblnum.Text = "Metro"
        ElseIf cbxentrada1.Text = "Centímetro" And cbxsalida1.Text = "Kilometros" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 100000
            lblnum.Text = "Kilometros"

        ElseIf cbxentrada1.Text = "Centímetro" And cbxsalida1.Text = "Pulgadas" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 0.3937
            lblnum.Text = "pulgadas"
        ElseIf cbxentrada1.Text = "Centímetro" And cbxsalida1.Text = "Pie" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 0.032808
            lblnum.Text = "Pie"
        ElseIf cbxentrada1.Text = "Centímetro" And cbxsalida1.Text = "Yarda" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 0.010936
            lblnum.Text = "Yarda"
        ElseIf cbxentrada1.Text = "Centímetro" And cbxsalida1.Text = "Milla" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 0.010936
            lblnum.Text = "Milla"
        ElseIf cbxentrada1.Text = "Centímetro" And cbxsalida1.Text = "Decámetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 1000
            lblnum.Text = "Decámetro"
        ElseIf cbxentrada1.Text = "Centímetro" And cbxsalida1.Text = "Decímetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 10
            lblnum.Text = "Decímetro"
        End If
        If cbxentrada1.Text = "Metro" And cbxsalida1.Text = "Metro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text)
            lblnum.Text = "Metro"
        ElseIf cbxentrada1.Text = "Metro" And cbxsalida1.Text = "Milímetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 1000
            lblnum.Text = "Milímetro"
        ElseIf cbxentrada1.Text = "Metro" And cbxsalida1.Text = "Centímetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 100
            lblnum.Text = "Centímetro"
        ElseIf cbxentrada1.Text = "Metro" And cbxsalida1.Text = "Kilometros" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 1000
            lblnum.Text = "Kilometros"

        ElseIf cbxentrada1.Text = "Metro" And cbxsalida1.Text = "Pulgadas" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 39.3701
            lblnum.Text = "pulgadas"
        ElseIf cbxentrada1.Text = "Metro" And cbxsalida1.Text = "Pie" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 3.28084
            lblnum.Text = "Pie"
        ElseIf cbxentrada1.Text = "Metro" And cbxsalida1.Text = "Yarda" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 1.0936
            lblnum.Text = "Yarda"
        ElseIf cbxentrada1.Text = "Metro" And cbxsalida1.Text = "Milla" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 0.00062137
            lblnum.Text = "Milla"
        ElseIf cbxentrada1.Text = "Metro" And cbxsalida1.Text = "Decámetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 10
            lblnum.Text = "Decámetro"
        ElseIf cbxentrada1.Text = "Metro" And cbxsalida1.Text = "Decímetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 10
            lblnum.Text = "Decímetro"
        End If

        If cbxentrada1.Text = "Kilometros" And cbxsalida1.Text = "Kilometros" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text)
            lblnum.Text = "Kilometros"
        ElseIf cbxentrada1.Text = "Kilometros" And cbxsalida1.Text = "Milímetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 1000000.0

            lblnum.Text = "Milímetro"
        ElseIf cbxentrada1.Text = "Kilometros" And cbxsalida1.Text = "Centímetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 100000
            lblnum.Text = "Centímetro"
        ElseIf cbxentrada1.Text = "Kilometros" And cbxsalida1.Text = "Metro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 1000
            lblnum.Text = "Metros"

        ElseIf cbxentrada1.Text = "Kilometros" And cbxsalida1.Text = "Pulgadas" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 39370.1
            lblnum.Text = "pulgadas"
        ElseIf cbxentrada1.Text = "Kilometros" And cbxsalida1.Text = "Pie" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 3280.8
            lblnum.Text = "Pie"
        ElseIf cbxentrada1.Text = "Kilometros" And cbxsalida1.Text = "Yarda" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 1093.61
            lblnum.Text = "Yarda"
        ElseIf cbxentrada1.Text = "Kilometros" And cbxsalida1.Text = "Milla" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 0.62137
            lblnum.Text = "Milla"
        ElseIf cbxentrada1.Text = "Kilometros" And cbxsalida1.Text = "Decámetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 100
            lblnum.Text = "Decámetro"
        ElseIf cbxentrada1.Text = "Kilometros" And cbxsalida1.Text = "Decímetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 10000
            lblnum.Text = "Decímetro"
        End If

        If cbxentrada1.Text = "Pulgadas" And cbxsalida1.Text = "Pulgadas" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text)
            lblnum.Text = "Pulgadas"
        ElseIf cbxentrada1.Text = "Pulgadas" And cbxsalida1.Text = "Milímetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 25.4

            lblnum.Text = "Milímetro"
        ElseIf cbxentrada1.Text = "Pulgadas" And cbxsalida1.Text = "Centímetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 2.54
            lblnum.Text = "Centímetro"
        ElseIf cbxentrada1.Text = "Pulgadas" And cbxsalida1.Text = "Metro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 39.37
            lblnum.Text = "Metros"

        ElseIf cbxentrada1.Text = "Pulgadas" And cbxsalida1.Text = "Kilometros" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 39370
            lblnum.Text = "Kilometros"
        ElseIf cbxentrada1.Text = "Pulgadas" And cbxsalida1.Text = "Pie" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 12
            lblnum.Text = "Pie"
        ElseIf cbxentrada1.Text = "Pulgadas" And cbxsalida1.Text = "Yarda" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 36
            lblnum.Text = "Yarda"
        ElseIf cbxentrada1.Text = "Pulgadas" And cbxsalida1.Text = "Milla" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 63360
            lblnum.Text = "Milla"
        ElseIf cbxentrada1.Text = "Pulgadas" And cbxsalida1.Text = "Decámetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 394
            lblnum.Text = "Decámetro"
        ElseIf cbxentrada1.Text = "Pulgadas" And cbxsalida1.Text = "Decímetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 3.937
            lblnum.Text = "Decímetro"
        End If

        If cbxentrada1.Text = "Pie" And cbxsalida1.Text = "Pie" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text)
            lblnum.Text = "Pie"
        ElseIf cbxentrada1.Text = "Pie" And cbxsalida1.Text = "Milímetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 305

            lblnum.Text = "Milímetro"
        ElseIf cbxentrada1.Text = "Pie" And cbxsalida1.Text = "Centímetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 30.48
            lblnum.Text = "Centímetro"
        ElseIf cbxentrada1.Text = "Pie" And cbxsalida1.Text = "Metro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 3.281
            lblnum.Text = "Metros"

        ElseIf cbxentrada1.Text = "Pie" And cbxsalida1.Text = "Kilometros" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 3281
            lblnum.Text = "Kilometros"
        ElseIf cbxentrada1.Text = "Pie" And cbxsalida1.Text = "Pulgadas" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 12
            lblnum.Text = "Pulgada"
        ElseIf cbxentrada1.Text = "Pie" And cbxsalida1.Text = "Yarda" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 3
            lblnum.Text = "Yarda"
        ElseIf cbxentrada1.Text = "Pie" And cbxsalida1.Text = "Milla" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 5280
            lblnum.Text = "Milla"
        ElseIf cbxentrada1.Text = "Pie" And cbxsalida1.Text = "Decámetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 32.808
            lblnum.Text = "Decámetro"
        ElseIf cbxentrada1.Text = "Pie" And cbxsalida1.Text = "Decímetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 3.048
            lblnum.Text = "Decímetro"
        End If


        If cbxentrada1.Text = "Yarda" And cbxsalida1.Text = "Yarda" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text)
            lblnum.Text = "Yarda"
        ElseIf cbxentrada1.Text = "Yarda" And cbxsalida1.Text = "Milímetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 914

            lblnum.Text = "Milímetro"
        ElseIf cbxentrada1.Text = "Yarda" And cbxsalida1.Text = "Centímetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 91.44
            lblnum.Text = "Centímetro"
        ElseIf cbxentrada1.Text = "Yarda" And cbxsalida1.Text = "Metro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 1.094
            lblnum.Text = "Metros"

        ElseIf cbxentrada1.Text = "Yarda" And cbxsalida1.Text = "Kilometros" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 1094
            lblnum.Text = "Kilometros"
        ElseIf cbxentrada1.Text = "Yarda" And cbxsalida1.Text = "Pulgadas" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 36
            lblnum.Text = "Pulgada"
        ElseIf cbxentrada1.Text = "Yarda" And cbxsalida1.Text = "Pie" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 3
            lblnum.Text = "Pie"
        ElseIf cbxentrada1.Text = "Yarda" And cbxsalida1.Text = "Milla" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 1760
            lblnum.Text = "Milla"
        ElseIf cbxentrada1.Text = "Yarda" And cbxsalida1.Text = "Decámetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 10.936
            lblnum.Text = "Decámetro"
        ElseIf cbxentrada1.Text = "Yarda" And cbxsalida1.Text = "Decímetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 9.144
            lblnum.Text = "Decímetro"
        End If

        If cbxentrada1.Text = "Milla" And cbxsalida1.Text = "Milla" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text)
            lblnum.Text = "Milla"
        ElseIf cbxentrada1.Text = "Milla" And cbxsalida1.Text = "Milímetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 1609000.0
            lblnum.Text = "Milímetro"
        ElseIf cbxentrada1.Text = "Milla" And cbxsalida1.Text = "Centímetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 160934
            lblnum.Text = "Centímetro"
        ElseIf cbxentrada1.Text = "Milla" And cbxsalida1.Text = "Metro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 1609
            lblnum.Text = "Metros"

        ElseIf cbxentrada1.Text = "Milla" And cbxsalida1.Text = "Kilometros" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 1.609
            lblnum.Text = "Kilometros"
        ElseIf cbxentrada1.Text = "Milla" And cbxsalida1.Text = "Pulgadas" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 63360
            lblnum.Text = "Pulgada"
        ElseIf cbxentrada1.Text = "Milla" And cbxsalida1.Text = "Pie" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 5280
            lblnum.Text = "Pie"
        ElseIf cbxentrada1.Text = "Milla" And cbxsalida1.Text = "Yarda" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 1760
            lblnum.Text = "Yarda"
        ElseIf cbxentrada1.Text = "Milla" And cbxsalida1.Text = "Decámetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 161
            lblnum.Text = "Decámetro"
        ElseIf cbxentrada1.Text = "Milla" And cbxsalida1.Text = "Decímetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 16093
            lblnum.Text = "Decímetro"
        End If

        If cbxentrada1.Text = "Decámetro" And cbxsalida1.Text = "Decámetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text)
            lblnum.Text = "Decámetro"
        ElseIf cbxentrada1.Text = "Decámetro" And cbxsalida1.Text = "Milímetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 10000
            lblnum.Text = "Milímetro"
        ElseIf cbxentrada1.Text = "Decámetro" And cbxsalida1.Text = "Centímetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 1000
            lblnum.Text = "Centímetro"
        ElseIf cbxentrada1.Text = "Decámetro" And cbxsalida1.Text = "Metro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 10
            lblnum.Text = "Metros"

        ElseIf cbxentrada1.Text = "Decámetro" And cbxsalida1.Text = "Kilometros" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 100
            lblnum.Text = "Kilometros"
        ElseIf cbxentrada1.Text = "Decámetro" And cbxsalida1.Text = "Pulgadas" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 394
            lblnum.Text = "Pulgada"
        ElseIf cbxentrada1.Text = "Decámetro" And cbxsalida1.Text = "Pie" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 32808
            lblnum.Text = "Pie"
        ElseIf cbxentrada1.Text = "Decámetro" And cbxsalida1.Text = "Yarda" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 10.936
            lblnum.Text = "Yarda"
        ElseIf cbxentrada1.Text = "Decámetro" And cbxsalida1.Text = "Milla" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 161
            lblnum.Text = "Milla"
        ElseIf cbxentrada1.Text = "Decámetro" And cbxsalida1.Text = "Decímetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 100
            lblnum.Text = "Decímetro"
        End If

        If cbxentrada1.Text = "Decímetro" And cbxsalida1.Text = "Decímetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text)
            lblnum.Text = "Decímetro"
        ElseIf cbxentrada1.Text = "Decímetro" And cbxsalida1.Text = "Milímetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 100
            lblnum.Text = "Milímetro"
        ElseIf cbxentrada1.Text = "Decímetro" And cbxsalida1.Text = "Centímetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 10
            lblnum.Text = "Centímetro"
        ElseIf cbxentrada1.Text = "Decímetro" And cbxsalida1.Text = "Metro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 10
            lblnum.Text = "Metros"

        ElseIf cbxentrada1.Text = "Decímetro" And cbxsalida1.Text = "Kilometros" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 10000
            lblnum.Text = "Kilometros"
        ElseIf cbxentrada1.Text = "Decímetro" And cbxsalida1.Text = "Pulgadas" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) * 3.937
            lblnum.Text = "Pulgada"
        ElseIf cbxentrada1.Text = "Decímetro" And cbxsalida1.Text = "Pie" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 3.048
            lblnum.Text = "Pie"
        ElseIf cbxentrada1.Text = "Decímetro" And cbxsalida1.Text = "Yarda" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 9.144
            lblnum.Text = "Yarda"
        ElseIf cbxentrada1.Text = "Decímetro" And cbxsalida1.Text = "Milla" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 16093
            lblnum.Text = "Milla"
        ElseIf cbxentrada1.Text = "Decímetro" And cbxsalida1.Text = "Decámetro" Then
            lblrespuesta1.Text = Val(Txtcódigo1.Text) / 100
            lblnum.Text = "Decámetro"
        End If
    End Sub

    Private Sub BtnMoneda_Click(sender As Object, e As EventArgs) Handles BtnMoneda.Click

        If Cbxentrada.Text = "Dolar estadounidense" And Cbxsalida.Text = "Dolar estadounidense" Then
            Lblr.Text = Val(TxtCodigo.Text)
            lblnum.Text = "Dolar estadounidense"
        ElseIf Cbxentrada.Text = "Dolar estadounidense" And Cbxsalida.Text = "Quetzal" Then
            Lblr.Text = Val(TxtCodigo.Text) * 7.7
            lblnum1.Text = "Queztal"
        End If
    End Sub
End Class
