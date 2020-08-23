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
        ElseIf Cbxentrada.Text = "Dolar estadounidense" And Cbxsalida.Text = "Colon salvadoreño" Then
            Lblr.Text = Val(TxtCodigo.Text) * 8.75
            lblnum1.Text = "Colon salvadoreño"
        ElseIf Cbxentrada.Text = "Dolar estadounidense" And Cbxsalida.Text = "Colon costarricense" Then
            Lblr.Text = Val(TxtCodigo.Text) * 595.4
            lblnum1.Text = "Colon costarricense"
        ElseIf Cbxentrada.Text = "Dolar estadounidense" And Cbxsalida.Text = "Lempira" Then
            Lblr.Text = Val(TxtCodigo.Text) * 24.66
            lblnum1.Text = "Lempira"
        ElseIf Cbxentrada.Text = "Dolar estadounidense" And Cbxsalida.Text = "Balboa" Then
            Lblr.Text = Val(TxtCodigo.Text) * 1.0
            lblnum1.Text = "Balboa"
        ElseIf Cbxentrada.Text = "Dolar estadounidense" And Cbxsalida.Text = "Peso Mexicano" Then
            Lblr.Text = Val(TxtCodigo.Text) * 21.98
            lblnum1.Text = "Peso mexicano"
        ElseIf Cbxentrada.Text = "Dolar estadounidense" And Cbxsalida.Text = "Cordoba nicaraguense" Then
            Lblr.Text = Val(TxtCodigo.Text) * 34.84
            lblnum1.Text = "Cordoba nicaraguense"
        ElseIf Cbxentrada.Text = "Dolar estadounidense" And Cbxsalida.Text = "Euro" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.85
            lblnum1.Text = "Euro"
        ElseIf Cbxentrada.Text = "Dolar estadounidense" And Cbxsalida.Text = "Sol (peruano)" Then
            Lblr.Text = Val(TxtCodigo.Text) * 3.58
            lblnum1.Text = "Sol (peruano)"
        ElseIf Cbxentrada.Text = "Quetzal" And Cbxsalida.Text = "Dólar estadounidense" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.3
            lblnum1.Text = "Dolar estadounidense"
        ElseIf Cbxentrada.Text = "Quetzal" And Cbxsalida.Text = "Colon salvadoreño" Then
            Lblr.Text = Val(TxtCodigo.Text) * 1.14
            lblnum1.Text = "Colon salvadoreño"
        ElseIf Cbxentrada.Text = "Quetzal" And Cbxsalida.Text = "Colon costarricense" Then
            Lblr.Text = Val(TxtCodigo.Text) * 77.32
            lblnum1.Text = "Colon costarricense"
        ElseIf Cbxentrada.Text = "Quetzal" And Cbxsalida.Text = "Lempira" Then
            Lblr.Text = Val(TxtCodigo.Text) * 3.2
            lblnum1.Text = "Lempira"
        ElseIf Cbxentrada.Text = "Quetzal" And Cbxsalida.Text = "Balboa" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.13
            lblnum1.Text = "Balboa"
        ElseIf Cbxentrada.Text = "Quetzal" And Cbxsalida.Text = "Peso Mexicano" Then
            Lblr.Text = Val(TxtCodigo.Text) * 2.85
            lblnum1.Text = "Peso mexicano"
        ElseIf Cbxentrada.Text = "Quetzal" And Cbxsalida.Text = "Cordoba nicaraguense" Then
            Lblr.Text = Val(TxtCodigo.Text) * 4.52
            lblnum1.Text = "Cordoba"
        ElseIf Cbxentrada.Text = "Quetzal" And Cbxsalida.Text = "Euro" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.11
            lblnum1.Text = "Euro"
        ElseIf Cbxentrada.Text = "Quetzal" And Cbxsalida.Text = "Sol (peruano)" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.46
            lblnum1.Text = "Sol (peruano)"
        ElseIf Cbxentrada.Text = "Colon salvadoreño" And Cbxsalida.Text = "Dólar estadounidense" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.11
            lblnum1.Text = "Dolar estadounidense"
        ElseIf Cbxentrada.Text = "Colon salvadoreño" And Cbxsalida.Text = "Quetzal" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.88
            lblnum1.Text = "Quetzal"
        ElseIf Cbxentrada.Text = "Colon salvadoreño" And Cbxsalida.Text = "Colon costarricense" Then
            Lblr.Text = Val(TxtCodigo.Text) * 68.05
            lblnum1.Text = "Colon costarricense"
        ElseIf Cbxentrada.Text = "Colon salvadoreño" And Cbxsalida.Text = "Lempira" Then
            Lblr.Text = Val(TxtCodigo.Text) * 2.82
            lblnum1.Text = "Lempira"
        ElseIf Cbxentrada.Text = "Colon salvadoreño" And Cbxsalida.Text = "Balboa" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.11
            lblnum1.Text = "Balboa"
        ElseIf Cbxentrada.Text = "Colon salvadoreño" And Cbxsalida.Text = "Peso Mexicano" Then
            Lblr.Text = Val(TxtCodigo.Text) * 2.51
            lblnum1.Text = "Peso Mexicano"
        ElseIf Cbxentrada.Text = "Colon salvadoreño" And Cbxsalida.Text = "Cordoba nicaraguense" Then
            Lblr.Text = Val(TxtCodigo.Text) * 3.98
            lblnum1.Text = "Cordoba nicaraguense"
        ElseIf Cbxentrada.Text = "Colon salvadoreño" And Cbxsalida.Text = "Euro" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.097
            lblnum1.Text = "Euro"
        ElseIf Cbxentrada.Text = "Colon salvadoreño" And Cbxsalida.Text = "Sol (peruano)" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.41
            lblnum1.Text = "Sol (peruano)"
        ElseIf Cbxentrada.Text = "Colon costarricense" And Cbxsalida.Text = "Dólar estadounidense" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.0017
            lblnum1.Text = "Dolar estadounidense"
        ElseIf Cbxentrada.Text = "Colon costarricense" And Cbxsalida.Text = "Quetzal" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.013
            lblnum1.Text = "Quetzal"
        ElseIf Cbxentrada.Text = "Colon costarricense" And Cbxsalida.Text = "Colon salvadoreño" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.015
            lblnum1.Text = "Colon salvadoreño"
        ElseIf Cbxentrada.Text = "Colon costarricense" And Cbxsalida.Text = "Lempira" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.041
            lblnum1.Text = "Lempira"
        ElseIf Cbxentrada.Text = "Colon costarricense" And Cbxsalida.Text = "Balboa" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.0017
            lblnum1.Text = "Balboa"
        ElseIf Cbxentrada.Text = "Colon costarricense" And Cbxsalida.Text = "Peso Mexicano" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.037
            lblnum1.Text = "Peso Mexicano"
        ElseIf Cbxentrada.Text = "Colon costarricense" And Cbxsalida.Text = "Cordoba nicaraguense" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.059
            lblnum1.Text = "Cordoba nicaraguense"
        ElseIf Cbxentrada.Text = "Colon costarricense" And Cbxsalida.Text = "Euro" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.0014
            lblnum1.Text = "Euro"
        ElseIf Cbxentrada.Text = "Colon costarricense" And Cbxsalida.Text = "Sol (peruano)" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.006
            lblnum1.Text = "Sol (peruano)"
        ElseIf Cbxentrada.Text = "Lempira" And Cbxsalida.Text = "Dólar estadounidense" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.041
            lblnum1.Text = "Dolar estadounidense"
        ElseIf Cbxentrada.Text = "Lempira" And Cbxsalida.Text = "Quetzal" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.31
            lblnum1.Text = "Quetzal"
        ElseIf Cbxentrada.Text = "Lempira" And Cbxsalida.Text = "Colon salvadoreño" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.36
            lblnum1.Text = "Colon salvadoreño"
        ElseIf Cbxentrada.Text = "Lempira" And Cbxsalida.Text = "Colon costarricense" Then
            Lblr.Text = Val(TxtCodigo.Text) * 24.15
            lblnum1.Text = "Colon costarricense"
        ElseIf Cbxentrada.Text = "Lempira" And Cbxsalida.Text = "Balboa" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.041
            lblnum1.Text = "Balboa"
        ElseIf Cbxentrada.Text = "Lempira" And Cbxsalida.Text = "Peso Mexicano" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.89
            lblnum1.Text = "Peso Mexicano"
        ElseIf Cbxentrada.Text = "Lempira" And Cbxsalida.Text = "Cordoba nicaraguense" Then
            Lblr.Text = Val(TxtCodigo.Text) * 1.41
            lblnum1.Text = "Cordoba nicaraguense"
        ElseIf Cbxentrada.Text = "Lempira" And Cbxsalida.Text = "Euro" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.34
            lblnum1.Text = "Euro"
        ElseIf Cbxentrada.Text = "Lempira" And Cbxsalida.Text = "Sol (peruano)" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.15
            lblnum1.Text = "Sol (peruano)"
        ElseIf Cbxentrada.Text = "Balboa" And Cbxsalida.Text = "Dólar estadounidense" Then
            Lblr.Text = Val(TxtCodigo.Text) * 1.0
            lblnum1.Text = "Dolar estadounidense"
        ElseIf Cbxentrada.Text = "Balboa" And Cbxsalida.Text = "Quetzal" Then
            Lblr.Text = Val(TxtCodigo.Text) * 7.7
            lblnum1.Text = "Quetzal"
        ElseIf Cbxentrada.Text = "Balboa" And Cbxsalida.Text = "Colon salvadoreño" Then
            Lblr.Text = Val(TxtCodigo.Text) * 8.75
            lblnum1.Text = "Colon salvadoreño"
        ElseIf Cbxentrada.Text = "Balboa" And Cbxsalida.Text = "Colon costarricense" Then
            Lblr.Text = Val(TxtCodigo.Text) * 595.37
            lblnum1.Text = "Colon costarricense"
        ElseIf Cbxentrada.Text = "Balboa" And Cbxsalida.Text = "Lempira" Then
            Lblr.Text = Val(TxtCodigo.Text) * 24.6
            lblnum1.Text = "Lempira"
        ElseIf Cbxentrada.Text = "Balboa" And Cbxsalida.Text = "Peso Mexicano" Then
            Lblr.Text = Val(TxtCodigo.Text) * 21.98
            lblnum1.Text = "Peso Mexicano"
        ElseIf Cbxentrada.Text = "Balboa" And Cbxsalida.Text = "Cordoba nicaraguense" Then
            Lblr.Text = Val(TxtCodigo.Text) * 34.84
            lblnum1.Text = "Cordoba nicaraguense"
        ElseIf Cbxentrada.Text = "Balboa" And Cbxsalida.Text = "Euro" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.85
            lblnum1.Text = "Euro"
        ElseIf Cbxentrada.Text = "Balboa" And Cbxsalida.Text = "Sol (peruano)" Then
            Lblr.Text = Val(TxtCodigo.Text) * 3.58
            lblnum1.Text = "Sol (peruano)"
        ElseIf Cbxentrada.Text = "Peso Mexicano" And Cbxsalida.Text = "Dólar estadounidense" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.046
            lblnum1.Text = "Dolar estadounidense"
        ElseIf Cbxentrada.Text = "Peso Mexicano" And Cbxsalida.Text = "Quetzal" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.35
            lblnum1.Text = "Quetzal"
        ElseIf Cbxentrada.Text = "Peso Mexicano" And Cbxsalida.Text = "Colon salvadoreño" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.4
            lblnum1.Text = "Colon salvadoreño"
        ElseIf Cbxentrada.Text = "Peso Mexicano" And Cbxsalida.Text = "Colon costarricense" Then
            Lblr.Text = Val(TxtCodigo.Text) * 27.09
            lblnum1.Text = "Colon costarricense"
        ElseIf Cbxentrada.Text = "Peso Mexicano" And Cbxsalida.Text = "Lempira" Then
            Lblr.Text = Val(TxtCodigo.Text) * 1.12
            lblnum1.Text = "Lempira"
        ElseIf Cbxentrada.Text = "Peso Mexicano" And Cbxsalida.Text = "Balboa" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.046
            lblnum1.Text = "Balboa"
        ElseIf Cbxentrada.Text = "Peso Mexicano" And Cbxsalida.Text = "Cordoba nicaraguense" Then
            Lblr.Text = Val(TxtCodigo.Text) * 1.59
            lblnum1.Text = "Cordoba nicaraguense"
        ElseIf Cbxentrada.Text = "Peso Mexicano" And Cbxsalida.Text = "Euro" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.039
            lblnum1.Text = "Euro"
        ElseIf Cbxentrada.Text = "Peso Mexicano" And Cbxsalida.Text = "Sol (peruano)" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.16
            lblnum1.Text = "Sol (peruano)"
        ElseIf Cbxentrada.Text = "Cordoba nicaraguense" And Cbxsalida.Text = "Dólar estadounidense" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.029
            lblnum1.Text = "Dolar estadounidense"
        ElseIf Cbxentrada.Text = "Cordoba nicaraguense" And Cbxsalida.Text = "Quetzal" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.22
            lblnum1.Text = "Quetzal"
        ElseIf Cbxentrada.Text = "Cordoba nicaraguense" And Cbxsalida.Text = "Colon salvadoreño" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.25
            lblnum1.Text = "Colon salvadoreño"
        ElseIf Cbxentrada.Text = "Cordoba nicaraguense" And Cbxsalida.Text = "Colon costarricense" Then
            Lblr.Text = Val(TxtCodigo.Text) * 17.09
            lblnum1.Text = "Colon costarricense"
        ElseIf Cbxentrada.Text = "Cordoba nicaraguense" And Cbxsalida.Text = "Lempira" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.71
            lblnum1.Text = "Lempira"
        ElseIf Cbxentrada.Text = "Cordoba nicaraguense" And Cbxsalida.Text = "Balboa" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.029
            lblnum1.Text = "Balboa"
        ElseIf Cbxentrada.Text = "Cordoba nicaraguense" And Cbxsalida.Text = "Peso Mexicano" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.63
            lblnum1.Text = "Peso Mexicano"
        ElseIf Cbxentrada.Text = "Cordoba nicaraguense" And Cbxsalida.Text = "Euro" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.024
            lblnum1.Text = "Euro"
        ElseIf Cbxentrada.Text = "Cordoba nicaraguense" And Cbxsalida.Text = "Sol (peruano)" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.1
            lblnum1.Text = "Sol (peruano)"
        ElseIf Cbxentrada.Text = "Euro" And Cbxsalida.Text = "Dólar estadounidense" Then
            Lblr.Text = Val(TxtCodigo.Text) * 1.18
            lblnum1.Text = "Dolar estadounidense"
        ElseIf Cbxentrada.Text = "Euro" And Cbxsalida.Text = "Quetzal" Then
            Lblr.Text = Val(TxtCodigo.Text) * 9.09
            lblnum1.Text = "Quetzal"
        ElseIf Cbxentrada.Text = "Euro" And Cbxsalida.Text = "Colon salvadreño" Then
            Lblr.Text = Val(TxtCodigo.Text) * 10.33
            lblnum1.Text = "Colon salvadoreño"
        ElseIf Cbxentrada.Text = "Euro" And Cbxsalida.Text = "Colon costarricense" Then
            Lblr.Text = Val(TxtCodigo.Text) * 702.28
            lblnum1.Text = "Colon costarricense"
        ElseIf Cbxentrada.Text = "Euro" And Cbxsalida.Text = "Lempira" Then
            Lblr.Text = Val(TxtCodigo.Text) * 29.09
            lblnum1.Text = "Lempira"
        ElseIf Cbxentrada.Text = "Euro" And Cbxsalida.Text = "Balboa" Then
            Lblr.Text = Val(TxtCodigo.Text) * 1.18
            lblnum1.Text = "Balboa"
        ElseIf Cbxentrada.Text = "Euro" And Cbxsalida.Text = "Peso Mexicano" Then
            Lblr.Text = Val(TxtCodigo.Text) * 25.92
            lblnum1.Text = "Peso Mexicano"
        ElseIf Cbxentrada.Text = "Euro" And Cbxsalida.Text = "Cordoba nicaraguense" Then
            Lblr.Text = Val(TxtCodigo.Text) * 41.1
            lblnum1.Text = "Cordoba nicaraguense"
        ElseIf Cbxentrada.Text = "Euro" And Cbxsalida.Text = "Sol (peruano)" Then
            Lblr.Text = Val(TxtCodigo.Text) * 4.22
            lblnum1.Text = "Sol (peruano)"
        ElseIf Cbxentrada.Text = "Sol (peruano)" And Cbxsalida.Text = "Dólar estadounidense" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.28
            lblnum1.Text = "Dolar estadounidense"
        ElseIf Cbxentrada.Text = "Sol (peruano)" And Cbxsalida.Text = "Quetzal" Then
            Lblr.Text = Val(TxtCodigo.Text) * 2.15
            lblnum1.Text = "Quetzal"
        ElseIf Cbxentrada.Text = "Sol (peruano)" And Cbxsalida.Text = "Colon salvadoreño" Then
            Lblr.Text = Val(TxtCodigo.Text) * 2.45
            lblnum1.Text = "Colon salvadoreño"
        ElseIf Cbxentrada.Text = "Sol (peruano)" And Cbxsalida.Text = "Colon costarricense" Then
            Lblr.Text = Val(TxtCodigo.Text) * 166.41
            lblnum1.Text = "Colon costarricense"
        ElseIf Cbxentrada.Text = "Sol (peruano)" And Cbxsalida.Text = "Lempira" Then
            Lblr.Text = Val(TxtCodigo.Text) * 6.89
            lblnum1.Text = "Lempira"
        ElseIf Cbxentrada.Text = "Sol (peruano)" And Cbxsalida.Text = "Balboa" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.28
            lblnum1.Text = "Balboa"
        ElseIf Cbxentrada.Text = "Sol (peruano)" And Cbxsalida.Text = "Peso Mexicano" Then
            Lblr.Text = Val(TxtCodigo.Text) * 6.14
            lblnum1.Text = "Peso Mexicano"
        ElseIf Cbxentrada.Text = "Sol (peruano)" And Cbxsalida.Text = "Cordoba nicaraguense" Then
            Lblr.Text = Val(TxtCodigo.Text) * 9.74
            lblnum1.Text = "Cordoba nicaraguense"
        ElseIf Cbxentrada.Text = "Sol (peruano)" And Cbxsalida.Text = "Euro" Then
            Lblr.Text = Val(TxtCodigo.Text) * 0.24
            lblnum1.Text = "Euro"
        End If

    End Sub

    Private Sub BtnMasa_Click(sender As Object, e As EventArgs) Handles BtnMasa.Click
        If Cbxentrada7.Text = "Tonelada" And Cbxsalida7.Text = "Tonelada" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text)
            Lblnum7.Text = "T"
        ElseIf Cbxentrada7.Text = "Tonelada" And Cbxsalida7.Text = "Kilogramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 1000
            Lblnum7.Text = "Kg"
        ElseIf Cbxentrada7.Text = "Tonelada" And Cbxsalida7.Text = "Gramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 1000000
            Lblnum7.Text = "g"
        ElseIf Cbxentrada7.Text = "Tonelada" And Cbxsalida7.Text = "Miligramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 1000000000
            Lblnum7.Text = "Mg"
        ElseIf Cbxentrada7.Text = "Tonelada" And Cbxsalida7.Text = "Microgramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 1000000000000
            Lblnum7.Text = "ug"
        ElseIf Cbxentrada7.Text = "Tonelada" And Cbxsalida7.Text = "Tonelada Larga" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 1.016
            Lblnum7.Text = "Lt"
        ElseIf Cbxentrada7.Text = "Tonelada" And Cbxsalida7.Text = "Tonelada corta" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 1.102
            Lblnum7.Text = "St"
        ElseIf Cbxentrada7.Text = "Tonelada" And Cbxsalida7.Text = "Stone" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 157
            Lblnum7.Text = "st"
        ElseIf Cbxentrada7.Text = "Tonelada" And Cbxsalida7.Text = "Libra" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 2205
            Lblnum7.Text = "lb"
        ElseIf Cbxentrada7.Text = "Tonelada" And Cbxsalida7.Text = "Onza" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 35274
            Lblnum7.Text = "oz"
        ElseIf Cbxentrada7.Text = "Kilogramo" And Cbxsalida7.Text = "Kilogramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text)
            Lblnum7.Text = "kg"
        ElseIf Cbxentrada7.Text = "Kilogramo" And Cbxsalida7.Text = "Tonelada" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 1000
            Lblnum7.Text = "t"
        ElseIf Cbxentrada7.Text = "Kilogramo" And Cbxsalida7.Text = "Gramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 1000
            Lblnum7.Text = "g"
        ElseIf Cbxentrada7.Text = "Kilogramo" And Cbxsalida7.Text = "Miligramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 1000000.0
            Lblnum7.Text = "mg"
        ElseIf Cbxentrada7.Text = "Kilogramo" And Cbxsalida7.Text = "Microgramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 1000000000.0
            Lblnum7.Text = "ug"
        ElseIf Cbxentrada7.Text = "Kilogramo" And Cbxsalida7.Text = "Tonelada Larga" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 1016
            Lblnum7.Text = "Lt"
        ElseIf Cbxentrada7.Text = "Kilogramo" And Cbxsalida7.Text = "Tonelada corta" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 907
            Lblnum7.Text = "St"
        ElseIf Cbxentrada7.Text = "Kilogramo" And Cbxsalida7.Text = "Stone" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 6.35
            Lblnum7.Text = "st"
        ElseIf Cbxentrada7.Text = "Kilogramo" And Cbxsalida7.Text = "Libra" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 2.205
            Lblnum7.Text = "lb"
        ElseIf Cbxentrada7.Text = "Kilogramo" And Cbxsalida7.Text = "Onza" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 35.274
            Lblnum7.Text = "oz"

        ElseIf Cbxentrada7.Text = "Gramo" And Cbxsalida7.Text = "Gramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text)
            Lblnum7.Text = "g"
        ElseIf Cbxentrada7.Text = "Gramo" And Cbxsalida7.Text = "Tonelada" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 1000000.0
            Lblnum7.Text = "T"
        ElseIf Cbxentrada7.Text = "Gramo" And Cbxsalida7.Text = "Kilogramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 1000
            Lblnum7.Text = "kg"
        ElseIf Cbxentrada7.Text = "Gramo" And Cbxsalida7.Text = "Miligramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 1000
            Lblnum7.Text = "ml"
        ElseIf Cbxentrada7.Text = "Gramo" And Cbxsalida7.Text = "Microgramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 1000000.0
            Lblnum7.Text = "ug"
        ElseIf Cbxentrada7.Text = "Gramo" And Cbxsalida7.Text = "Tonelada Larga" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 1016000.0
            Lblnum7.Text = "Lt"
        ElseIf Cbxentrada7.Text = "Gramo" And Cbxsalida7.Text = "Tonelada corta" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 907185
            Lblnum7.Text = "St"
        ElseIf Cbxentrada7.Text = "Gramo" And Cbxsalida7.Text = "Stone" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 6350
            Lblnum7.Text = "st"
        ElseIf Cbxentrada7.Text = "Gramo" And Cbxsalida7.Text = "Libra" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 454
            Lblnum7.Text = "lb"
        ElseIf Cbxentrada7.Text = "Gramo" And Cbxsalida7.Text = "Onza" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 28.35
            Lblnum7.Text = "oz"
        ElseIf Cbxentrada7.Text = "Miligramo" And Cbxsalida7.Text = "Miligramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text)
            Lblnum7.Text = "mg"
        ElseIf Cbxentrada7.Text = "Miligramo" And Cbxsalida7.Text = "Tonelada" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 1000000000.0
            Lblnum7.Text = "T"
        ElseIf Cbxentrada7.Text = "Miligramo" And Cbxsalida7.Text = "Kilogramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 1000000.0
            Lblnum7.Text = "kg"
        ElseIf Cbxentrada7.Text = "Miligramo" And Cbxsalida7.Text = "Gramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 1000
            Lblnum7.Text = "g"
        ElseIf Cbxentrada7.Text = "Miligramo" And Cbxsalida7.Text = "Microgramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 1000
            Lblnum7.Text = "ug"
        ElseIf Cbxentrada7.Text = "Miligramo" And Cbxsalida7.Text = "Tonelada Larga" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 1016000000.0
            Lblnum7.Text = "Lt"
        ElseIf Cbxentrada7.Text = "Miligramo" And Cbxsalida7.Text = "Tonelada corta" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 907200000.0
            Lblnum7.Text = "St"
        ElseIf Cbxentrada7.Text = "Miligramo" And Cbxsalida7.Text = "Stone" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 6350000.0
            Lblnum7.Text = "st"
        ElseIf Cbxentrada7.Text = "Miligramo" And Cbxsalida7.Text = "Libra" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 453592
            Lblnum7.Text = "lb"
        ElseIf Cbxentrada7.Text = "Miligramo" And Cbxsalida7.Text = "Onza" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 28350
            Lblnum7.Text = "oz"

        ElseIf Cbxentrada7.Text = "Microgramo" And Cbxsalida7.Text = "Microgramo " Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text)
            Lblnum7.Text = "ug"
        ElseIf Cbxentrada7.Text = "Microgramo" And Cbxsalida7.Text = "Tonelada" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 1000000000000.0
            Lblnum7.Text = "T"
        ElseIf Cbxentrada7.Text = "Microgramo" And Cbxsalida7.Text = "Kilogramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 1000000000.0
            Lblnum7.Text = "kg"
        ElseIf Cbxentrada7.Text = "Microgramo" And Cbxsalida7.Text = "Gramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 1000000.0
            Lblnum7.Text = "g"
        ElseIf Cbxentrada7.Text = "Microgramo" And Cbxsalida7.Text = "Miligramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 1000
            Lblnum7.Text = "mg"
        ElseIf Cbxentrada7.Text = "Microgramo" And Cbxsalida7.Text = "Tonelada Larga" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 1016000000000.0
            Lblnum7.Text = "Lt"
        ElseIf Cbxentrada7.Text = "Microgramo" And Cbxsalida7.Text = "Tonelada corta" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 907200000000.0
            Lblnum7.Text = "St"
        ElseIf Cbxentrada7.Text = "Microgramo" And Cbxsalida7.Text = "Stone" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 6350000000.0
            Lblnum7.Text = "st"
        ElseIf Cbxentrada7.Text = "Microgramo" And Cbxsalida7.Text = "Libra" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 453600000.0
            Lblnum7.Text = "libra"
        ElseIf Cbxentrada7.Text = "Microgramo" And Cbxsalida7.Text = "Onza" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 28350000.0
            Lblnum7.Text = "oz"

        ElseIf Cbxentrada7.Text = "Tonelada Larga" And Cbxsalida7.Text = "Tonelada Larga" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text)
            Lblnum7.Text = "Lt"
        ElseIf Cbxentrada7.Text = "Tonelada Larga" And Cbxsalida7.Text = "Tonelada" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 1.016
            Lblnum7.Text = "T"
        ElseIf Cbxentrada7.Text = "Tonelada Larga" And Cbxsalida7.Text = "Kilogramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 1016
            Lblnum7.Text = "kg"
        ElseIf Cbxentrada7.Text = "Tonelada Larga" And Cbxsalida7.Text = "Gramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 1016000.0
            Lblnum7.Text = "g"
        ElseIf Cbxentrada7.Text = "Tonelada Larga" And Cbxsalida7.Text = "Miligramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 1016000000.0
            Lblnum7.Text = "mg"
        ElseIf Cbxentrada7.Text = "Tonelada Larga" And Cbxsalida7.Text = "Microgramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 1016000000000.0
            Lblnum7.Text = "ug"
        ElseIf Cbxentrada7.Text = "Tonelada Larga" And Cbxsalida7.Text = "Tonelada corta" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 1.12
            Lblnum7.Text = "St"
        ElseIf Cbxentrada7.Text = "Tonelada Larga" And Cbxsalida7.Text = "Stone" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 160
            Lblnum7.Text = "st"
        ElseIf Cbxentrada7.Text = "Tonelada Larga" And Cbxsalida7.Text = "Libra" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 2240
            Lblnum7.Text = "lb"
        ElseIf Cbxentrada7.Text = "Tonelada Larga" And Cbxsalida7.Text = "Onza" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 35840
            Lblnum7.Text = "oz"

        ElseIf Cbxentrada7.Text = "Tonelada corta" And Cbxsalida7.Text = "Tonelada corta" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text)
            Lblnum7.Text = "St"
        ElseIf Cbxentrada7.Text = "Tonelada corta" And Cbxsalida7.Text = "Tonelada" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 1.102
            Lblnum7.Text = "T"
        ElseIf Cbxentrada7.Text = "Tonelada corta" And Cbxsalida7.Text = "Kilogramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 907
            Lblnum7.Text = "kg"
        ElseIf Cbxentrada7.Text = "Tonelada corta" And Cbxsalida7.Text = "Gramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 907185
            Lblnum7.Text = "g"
        ElseIf Cbxentrada7.Text = "Tonelada corta" And Cbxsalida7.Text = "Miligramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 907200000000.0
            Lblnum7.Text = "mg"
        ElseIf Cbxentrada7.Text = "Tonelada corta" And Cbxsalida7.Text = "Microgramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 907120000000.0
            Lblnum7.Text = "ug"
        ElseIf Cbxentrada7.Text = "Tonelada corta" And Cbxsalida7.Text = "Tonelada Larga" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 1.12
            Lblnum7.Text = "Lt"
        ElseIf Cbxentrada7.Text = "Tonelada corta" And Cbxsalida7.Text = "Stone" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 143
            Lblnum7.Text = "st"
        ElseIf Cbxentrada7.Text = "Tonelada corta" And Cbxsalida7.Text = "Libra" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 2000
            Lblnum7.Text = "lb"
        ElseIf Cbxentrada7.Text = "Tonelada corta" And Cbxsalida7.Text = "Onza" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 32000
            Lblnum7.Text = "oz"

        ElseIf Cbxentrada7.Text = "Stone" And Cbxsalida7.Text = "Tonelada" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 157
            Lblnum7.Text = "T"
        ElseIf Cbxentrada7.Text = "Stone" And Cbxsalida7.Text = "kilogramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 6.35
            Lblnum7.Text = "kg"
        ElseIf Cbxentrada7.Text = "Stone" And Cbxsalida7.Text = "Gramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 6350
            Lblnum7.Text = "g"
        ElseIf Cbxentrada7.Text = "Stone" And Cbxsalida7.Text = "Miligramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 6350000.0
            Lblnum7.Text = "mg"
        ElseIf Cbxentrada7.Text = "Stone" And Cbxsalida7.Text = "Microgramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 6350000000.0
            Lblnum7.Text = "ug"
        ElseIf Cbxentrada7.Text = "Stone" And Cbxsalida7.Text = "Tonelada Larga" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 160
            Lblnum7.Text = "Lt"
        ElseIf Cbxentrada7.Text = "Stone" And Cbxsalida7.Text = "Tonelada corta" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 143
            Lblnum7.Text = "St"
        ElseIf Cbxentrada7.Text = "Stone" And Cbxsalida7.Text = "Libra" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 14
            Lblnum7.Text = "lb"
        ElseIf Cbxentrada7.Text = "Stone" And Cbxsalida7.Text = "Onza" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 224
            Lblnum7.Text = "oz"

        ElseIf Cbxentrada7.Text = "Onza" And Cbxsalida7.Text = "Onza" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text)
            Lblnum7.Text = "oz"
        ElseIf Cbxentrada7.Text = "Onza" And Cbxsalida7.Text = "Tonelada" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 35274
            Lblnum7.Text = "T"
        ElseIf Cbxentrada7.Text = "Onza" And Cbxsalida7.Text = "Kilogramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 35.274
            Lblnum7.Text = "kg"
        ElseIf Cbxentrada7.Text = "Onza" And Cbxsalida7.Text = "Gramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 28.35
            Lblnum7.Text = "g"
        ElseIf Cbxentrada7.Text = "Onza" And Cbxsalida7.Text = "Miligramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 28350
            Lblnum7.Text = "mg"
        ElseIf Cbxentrada7.Text = "Onza" And Cbxsalida7.Text = "Microgramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 28350000.0
            Lblnum7.Text = "ug"
        ElseIf Cbxentrada7.Text = "Onza" And Cbxsalida7.Text = "Tonelada Larga" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 35840
            Lblnum7.Text = "Lt"
        ElseIf Cbxentrada7.Text = "Onza" And Cbxsalida7.Text = "Tonelada corta" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 32000
            Lblnum7.Text = "St"
        ElseIf Cbxentrada7.Text = "Onza" And Cbxsalida7.Text = "Stone" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 224
            Lblnum7.Text = "st"
        ElseIf Cbxentrada7.Text = "Onza" And Cbxsalida7.Text = "Libra" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 16
            Lblnum7.Text = "lb"
        ElseIf Cbxentrada7.Text = "Libra" And Cbxsalida7.Text = "Libra" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text)
            Lblnum7.Text = "lb"
        ElseIf Cbxentrada7.Text = "Libra" And Cbxsalida7.Text = "Tonelada" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 2205
            Lblnum7.Text = "T"
        ElseIf Cbxentrada7.Text = "Libra" And Cbxsalida7.Text = "Kilogramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 2.205
            Lblnum7.Text = "kg"
        ElseIf Cbxentrada7.Text = "Libra" And Cbxsalida7.Text = "Gramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 454
            Lblnum7.Text = "g"
        ElseIf Cbxentrada7.Text = "Libra" And Cbxsalida7.Text = "Miligramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 453592
            Lblnum7.Text = "mg"
        ElseIf Cbxentrada7.Text = "Libra" And Cbxsalida7.Text = "Microgramo" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 453600000.0
            Lblnum7.Text = "ug"
        ElseIf Cbxentrada7.Text = "Libra" And Cbxsalida7.Text = "Tonelada Larga" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 2240
            Lblnum7.Text = "Lt"
        ElseIf Cbxentrada7.Text = "Libra" And Cbxsalida7.Text = "Tonelada corta" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 2000
            Lblnum7.Text = "St"
        ElseIf Cbxentrada7.Text = "Libra" And Cbxsalida7.Text = "Stone" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) / 14
            Lblnum7.Text = "st"
        ElseIf Cbxentrada7.Text = "Libra" And Cbxsalida7.Text = "Onza" Then
            Lblrespuesta7.Text = Val(Txtcodigo7.Text) * 16
            Lblnum7.Text = "oz"
        End If

    End Sub

    Private Sub Btnvolumen_Click(sender As Object, e As EventArgs) Handles Btnvolumen.Click
        If cbxentrada5.Text = "Litros" And cbxsalida5.Text = "Litros" Then

        ElseIf cbxentrada5.Text = "Litros" And cbxsalida5.Text = "Mililitros" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 1000
            lblnum5.Text = "Mililitros"
        ElseIf cbxentrada5.Text = "Litros" And cbxsalida5.Text = "Galón Imperial" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 4.546
            lblnum5.Text = "Galón Imperial"
        ElseIf cbxentrada5.Text = "Litros" And cbxsalida5.Text = "Cucharada estadounidense" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 67.628
            lblnum5.Text = "Cucharada estadounidense"
        ElseIf cbxentrada5.Text = "Litros" And cbxsalida5.Text = "Pinta estadounidense" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 2.113
            lblnum5.Text = "Pinta estadounidense"
        ElseIf cbxentrada5.Text = "Litros" And cbxsalida5.Text = "Onza liquida imperial" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 35.195
            lblnum5.Text = "Onza liquida I"
        ElseIf cbxentrada5.Text = "Litros" And cbxsalida5.Text = "Galón estadounidense" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 3.785
            lblnum5.Text = "Galón estadounidense"
        ElseIf cbxentrada5.Text = "Litros" And cbxsalida5.Text = "Metro cubico" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 1000
            lblnum5.Text = "Metro cubico"
        ElseIf cbxentrada5.Text = "Litros" And cbxsalida5.Text = "Pie Cubico" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 28.317
            lblnum5.Text = "Pie cubico"
        ElseIf cbxentrada5.Text = "Litros" And cbxsalida5.Text = "Pulgada Cubica" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 61.024
            lblnum5.Text = "Pulgada cubica"
        ElseIf cbxentrada5.Text = "Mililitros" And cbxsalida5.Text = "Litros" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 1000
            lblnum5.Text = "L"
        ElseIf cbxentrada5.Text = "Mililitros" And cbxsalida5.Text = "Mililitros" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text)
            lblnum5.Text = "Mll"
        ElseIf cbxentrada5.Text = "Mililitros" And cbxsalida5.Text = "Galón Imperial" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 4546
            lblnum5.Text = "Gi"
        ElseIf cbxentrada5.Text = "Mililitros" And cbxsalida5.Text = "Cucharada estadounidense" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 14.787
            lblnum5.Text = "Ce"
        ElseIf cbxentrada5.Text = "Mililitros" And cbxsalida5.Text = "Pinta estadounidense" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 473
            lblnum5.Text = "Pe"
        ElseIf cbxentrada5.Text = "Mililitros" And cbxsalida5.Text = "Onza liquida imperial" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 29.574
            lblnum5.Text = "Oli"
        ElseIf cbxentrada5.Text = "Mililitros" And cbxsalida5.Text = "Galón estadounidense" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 3785
            lblnum5.Text = "G e"
        ElseIf cbxentrada5.Text = "Mililitros" And cbxsalida5.Text = "Metro cubico" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 1000000.0
            lblnum5.Text = "M c"
        ElseIf cbxentrada5.Text = "Mililitros" And cbxsalida5.Text = "Pie cúbico" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 28317
            lblnum5.Text = "P c"
        ElseIf cbxentrada5.Text = "Mililitros" And cbxsalida5.Text = "Pulgada cúbica" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 16.387
            lblnum5.Text = "Pulg C"
        ElseIf cbxentrada5.Text = "Galón Imperial" And cbxsalida5.Text = "Litros" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 4.546
            lblnum5.Text = "L"
        ElseIf cbxentrada5.Text = "Galón Imperial" And cbxsalida5.Text = "Mililitros" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 4546
            lblnum5.Text = "Mll"
        ElseIf cbxentrada5.Text = "Galón Imperial" And cbxsalida5.Text = "Galón Imperial" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text)
            lblnum5.Text = "G i"
        ElseIf cbxentrada5.Text = "Galón Imperial" And cbxsalida5.Text = "Cucharada estadounidense" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 307
            lblnum5.Text = "C e"
        ElseIf cbxentrada5.Text = "Galón Imperial" And cbxsalida5.Text = "Pinta estadounidense" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 9.608
            lblnum5.Text = "P e"
        ElseIf cbxentrada5.Text = "Galón Imperial" And cbxsalida5.Text = "Onza liquida imperial " Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 160
            lblnum5.Text = "O l i"
        ElseIf cbxentrada5.Text = "Galón Imperial" And cbxsalida5.Text = "Galón estadounidense" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 1.201
            lblnum5.Text = "G e"
        ElseIf cbxentrada5.Text = "Galón Imperial" And cbxsalida5.Text = "Metro cubico" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 220
            lblnum5.Text = "M c"
        ElseIf cbxentrada5.Text = "Galón Imperial" And cbxsalida5.Text = "Pie cúbico" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 6.229
            lblnum5.Text = "P c"
        ElseIf cbxentrada5.Text = "Galón Imperial" And cbxsalida5.Text = "Pulgada cúbica" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 277
            lblnum5.Text = "Pulg c"


        ElseIf cbxentrada5.Text = "Cucharada estadounidense" And cbxsalida5.Text = "Litros" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 67.628
            lblnum5.Text = "L"
        ElseIf cbxentrada5.Text = "Cucharada estadounidense" And cbxsalida5.Text = "Mililitros" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 14.787
            lblnum5.Text = "Mll"
        ElseIf cbxentrada5.Text = "Cucharada estadounidense" And cbxsalida5.Text = "Galón Imperial" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 307
            lblnum5.Text = "G i"
        ElseIf cbxentrada5.Text = "Cucharada estadounidense" And cbxsalida5.Text = "Cucharada estadounidense" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text)
            lblnum5.Text = "C e"
        ElseIf cbxentrada5.Text = "Cucharada estadounidense" And cbxsalida5.Text = "Pinta estadounidense" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 32
            lblnum5.Text = "P e"
        ElseIf cbxentrada5.Text = "Cucharada estadounidense" And cbxsalida5.Text = "Onza liquida imperial " Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 1.922
            lblnum5.Text = "O l i"
        ElseIf cbxentrada5.Text = "Cucharada estadounidense" And cbxsalida5.Text = "Galón estadounidense" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 256
            lblnum5.Text = "G e"
        ElseIf cbxentrada5.Text = "Cucharada estadounidense" And cbxsalida5.Text = "Metro cubico" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 67628
            lblnum5.Text = "M`c"
        ElseIf cbxentrada5.Text = "Cucharada estadounidense" And cbxsalida5.Text = "Pie cúbico" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 1915
            lblnum5.Text = "P c"
        ElseIf cbxentrada5.Text = "Cucharada estadounidense" And cbxsalida5.Text = "Pulgada cúbica" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 1.108
            lblnum5.Text = "Pulg c"
        ElseIf cbxentrada5.Text = "Pinta estadounidense" And cbxsalida5.Text = "Litros" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 2.113
            lblnum5.Text = "L"
        ElseIf cbxentrada5.Text = "Pinta estadounidense" And cbxsalida5.Text = "Mililitros" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 473
            lblnum5.Text = "Mll"
        ElseIf cbxentrada5.Text = "Pinta estadounidense" And cbxsalida5.Text = "Galón Imperial" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 9.608
            lblnum5.Text = "G i"
        ElseIf cbxentrada5.Text = "Pinta estadounidense" And cbxsalida5.Text = "Cucharada estadounidense" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 32
            lblnum5.Text = "C e"
        ElseIf cbxentrada5.Text = "Pinta estadounidense" And cbxsalida5.Text = "Pinta estadounidense" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text)
            lblnum5.Text = "P e"
        ElseIf cbxentrada5.Text = "Pinta estadounidense" And cbxsalida5.Text = "Onza liquida imperial " Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 16.653
            lblnum5.Text = "O l i"
        ElseIf cbxentrada5.Text = "Pinta estadounidense" And cbxsalida5.Text = "Galón estadounidense" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 8
            lblnum5.Text = "G e"
        ElseIf cbxentrada5.Text = "Pinta estadounidense" And cbxsalida5.Text = "Metro cubico" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 2113
            lblnum5.Text = "M c"
        ElseIf cbxentrada5.Text = "Pinta estadounidense" And cbxsalida5.Text = "Pie cúbico" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 59.844
            lblnum5.Text = "P c"
        ElseIf cbxentrada5.Text = "Pinta estadounidense" And cbxsalida5.Text = "Pulgada cúbica" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 28.875
            lblnum5.Text = "Pulg c"
        ElseIf cbxentrada5.Text = "Onza liquida imperial " And cbxsalida5.Text = "Litros" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 35.195
            lblnum5.Text = "L"
        ElseIf cbxentrada5.Text = "Onza liquida imperial " And cbxsalida5.Text = "Mililitros" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 28.413
            lblnum5.Text = "Mll"
        ElseIf cbxentrada5.Text = "Onza liquida imperial " And cbxsalida5.Text = "Galón Imperial" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 160
            lblnum5.Text = "G i"
        ElseIf cbxentrada5.Text = "Onza liquida imperial " And cbxsalida5.Text = "Cucharada estadounidense" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 1.922
            lblnum5.Text = "C e"
        ElseIf cbxentrada5.Text = "Onza liquida imperial " And cbxsalida5.Text = "Pinta estadounidense" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 16.653
            lblnum5.Text = "P e"
        ElseIf cbxentrada5.Text = "Onza liquida imperial " And cbxsalida5.Text = "Onza liquida imperial " Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 16.653
            lblnum5.Text = "O l i"
        ElseIf cbxentrada5.Text = "Onza liquida imperial " And cbxsalida5.Text = "Galón estadounidense" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 8
            lblnum5.Text = "G e"
        ElseIf cbxentrada5.Text = "Onza liquida imperial " And cbxsalida5.Text = "Metro cubico" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 2113
            lblnum5.Text = "M c"
        ElseIf cbxentrada5.Text = "Onza liquida imperial " And cbxsalida5.Text = "Pie cúbico" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 59.844
            lblnum5.Text = "P c"
        ElseIf cbxentrada5.Text = "Onza liquida imperial " And cbxsalida5.Text = "Pulgada cúbica" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 28.875
            lblnum5.Text = "Pulg c"
        ElseIf cbxentrada5.Text = "Galón estadounidense" And cbxsalida5.Text = "Litros" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 3.785
            lblnum5.Text = "L"
        ElseIf cbxentrada5.Text = "Galón estadounidense" And cbxsalida5.Text = "Mililitros" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 3785
            lblnum5.Text = "Mll"
        ElseIf cbxentrada5.Text = "Galón estadounidense" And cbxsalida5.Text = "Galón Imperial" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 1.201
            lblnum5.Text = "G i"
        ElseIf cbxentrada5.Text = "Galón estadounidense" And cbxsalida5.Text = "Cucharada estadounidense" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 256
            lblnum5.Text = "C e"
        ElseIf cbxentrada5.Text = "Galón estadounidense" And cbxsalida5.Text = "Pinta estadounidense" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 8
            lblnum5.Text = "P e"
        ElseIf cbxentrada5.Text = "Galón estadounidense" And cbxsalida5.Text = "Onza liquida imperial " Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 133
            lblnum5.Text = "P c"
        ElseIf cbxentrada5.Text = "Galón estadounidense" And cbxsalida5.Text = "Galón estadounidense" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text)
            lblnum5.Text = "Mll"
        ElseIf cbxentrada5.Text = "Galón estadounidense" And cbxsalida5.Text = "Metro cubico" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 264
            lblnum5.Text = "C e"
        ElseIf cbxentrada5.Text = "Galón estadounidense" And cbxsalida5.Text = "Pie cúbico" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 7.481
            lblnum5.Text = "G e"
        ElseIf cbxentrada5.Text = "Galón estadounidense" And cbxsalida5.Text = "Pulgada cúbica" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 231
            lblnum5.Text = "Pulg c"
        ElseIf cbxentrada5.Text = "Metro cubico" And cbxsalida5.Text = "Litros" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 1000
            lblnum5.Text = "L"
        ElseIf cbxentrada5.Text = "Metro cubico" And cbxsalida5.Text = "Mililitros" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 1000000.0
            lblnum5.Text = "Mll"
        ElseIf cbxentrada5.Text = "Metro cubico" And cbxsalida5.Text = "Galón Imperial" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 220
            lblnum5.Text = "M c"
        ElseIf cbxentrada5.Text = "Metro cubico" And cbxsalida5.Text = "Cucharada estadounidense" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 67628
            lblnum5.Text = "C e"
        ElseIf cbxentrada5.Text = "Metro cubico" And cbxsalida5.Text = "Pinta estadounidense" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 2113
            lblnum5.Text = "P e"
        ElseIf cbxentrada5.Text = "Metro cubico" And cbxsalida5.Text = "Onza liquida imperial " Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 35195
            lblnum5.Text = "O l i"
        ElseIf cbxentrada5.Text = "Metro cubico" And cbxsalida5.Text = "Galón estadounidense" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 264
            lblnum5.Text = "G e"
        ElseIf cbxentrada5.Text = "Metro cubico" And cbxsalida5.Text = "Metro cubico" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text)
            lblnum5.Text = "M c"
        ElseIf cbxentrada5.Text = "Metro cubico" And cbxsalida5.Text = "Pie cúbico" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 35.315
            lblnum5.Text = "P c"
        ElseIf cbxentrada5.Text = "Metro cubico" And cbxsalida5.Text = "Pulgada cúbica" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 61024
            lblnum5.Text = "Pulg c"

        ElseIf cbxentrada5.Text = "Pie cúbico" And cbxsalida5.Text = "Litros" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 1000
            lblnum5.Text = "L"
        ElseIf cbxentrada5.Text = "Pie cúbico" And cbxsalida5.Text = "Mililitros" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 1000000.0
            lblnum5.Text = "Mll"
        ElseIf cbxentrada5.Text = "Pie cúbico" And cbxsalida5.Text = "Galón Imperial" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 220
            lblnum5.Text = "G i"
        ElseIf cbxentrada5.Text = "Pie cúbico" And cbxsalida5.Text = "Cucharada estadounidense" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 67628
            lblnum5.Text = "C e"
        ElseIf cbxentrada5.Text = "Pie cúbico" And cbxsalida5.Text = "Pinta estadounidense" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 2113
            lblnum5.Text = "P e"
        ElseIf cbxentrada5.Text = "Pie cúbico" And cbxsalida5.Text = "Onza liquida imperial " Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 35195
            lblnum5.Text = "O l i"
        ElseIf cbxentrada5.Text = "Pie cúbico" And cbxsalida5.Text = "Galón estadounidense" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 264
            lblnum5.Text = "G e"
        ElseIf cbxentrada5.Text = "Pie cúbico" And cbxsalida5.Text = "Metro cubico" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 264
            lblnum5.Text = "M c"
        ElseIf cbxentrada5.Text = "Pie cúbico" And cbxsalida5.Text = "Pie cúbico" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text)
            lblnum5.Text = "P c"
        ElseIf cbxentrada5.Text = "Pie cúbico" And cbxsalida5.Text = "Pulgada cúbica" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 231
            lblnum5.Text = "Pulg c"

        ElseIf cbxentrada5.Text = "Pulgada cúbica" And cbxsalida5.Text = "Litros" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 61.024
            lblnum5.Text = "L"
        ElseIf cbxentrada5.Text = "Pulgada cúbica" And cbxsalida5.Text = "Mililitros" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 16.387
            lblnum5.Text = "Mll"
        ElseIf cbxentrada5.Text = "Pulgada cúbica" And cbxsalida5.Text = "Galón Imperial" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 277
            lblnum5.Text = "G i"
        ElseIf cbxentrada5.Text = "Pulgada cúbica" And cbxsalida5.Text = "Cucharada estadounidense" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) * 1.108
            lblnum5.Text = "C e"
        ElseIf cbxentrada5.Text = "Pulgada cúbica" And cbxsalida5.Text = "Pinta estadounidense" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 28.875
            lblnum5.Text = "P e"
        ElseIf cbxentrada5.Text = "Pulgada cúbica" And cbxsalida5.Text = "Onza liquida imperial " Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 1.734
            lblnum5.Text = "O l i"
        ElseIf cbxentrada5.Text = "Pulgada cúbica" And cbxsalida5.Text = "Galón estadounidense" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 231
            lblnum5.Text = "G e"
        ElseIf cbxentrada5.Text = "Pulgada cúbica" And cbxsalida5.Text = "Metro cubico" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 61024
            lblnum5.Text = "M c"
        ElseIf cbxentrada5.Text = "Pulgada cúbica" And cbxsalida5.Text = "Pie cúbico" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text) / 1728
            lblnum5.Text = "P c"
        ElseIf cbxentrada5.Text = "Pulgada cúbica" And cbxsalida5.Text = "Pulgada cúbica" Then
            lblrespuesta5.Text = Val(Txtcódigo5.Text)
            lblnum5.Text = "P C"
        End If
    End Sub
End Class
