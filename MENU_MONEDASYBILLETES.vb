Public Class MENU_MONEDASYBILLETES
    Dim b500, b200, b100, b50, b20, b10, b5, b2, b1, total As Integer

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        txt_numero_empleado.Text = ""
        txt_sueldo.Text = ""
        txt_sueldo.Focus()
    End Sub
    'programa de NAJERA CASTRO JUAN PABLO
    'SOFTWARE 101 VESPERTINO LA MEJOR CARRERA

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_cheque.Click
        lbl_500cheque.Text = lbl_500.Text
        lbl_200cheque.Text = lbl_200.Text
        lbl_100cheque.Text = lbl_100.Text
        lbl_50cheque.Text = lbl_50.Text
        lbl_20cheque.Text = lbl_20.Text
        lbl_10cheque.Text = lbl_10.Text
        lbl_5cheque.Text = lbl_5.Text
        lbl_2cheque.Text = lbl_2.Text
        lbl_1cheque.Text = lbl_1.Text
        lbl_cantidad_letras.Text = UCase(EnLetras(Math.Round(total, 2)))
        lbl_cantidad.Text = Format(total, "$ ##,##0.00")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Dim importe_500, importe_200, importe_100, importe_50, importe_20, importe_10, importe_5, importe_2, importe_1 As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub txt_sueldo_keypress(sender As Object, e As KeyPressEventArgs) Handles txt_sueldo.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_numero_empleado_keypress(sender As Object, e As KeyPressEventArgs) Handles txt_numero_empleado.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        If Val(txt_numero_empleado.Text) = 0 Or Val(txt_sueldo.Text) = 0 Then
            MessageBox.Show("INSERTE CORRECTAMENTE LOS DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'para conseguir los datos
            b500 = Val(txt_sueldo.Text) Mod 500
            b200 = b500 Mod 200
            b100 = b200 Mod 100
            b50 = b100 Mod 50
            b20 = b50 Mod 20
            b10 = b20 Mod 10
            b5 = b10 Mod 5
            b2 = b5 Mod 2
            b1 = b2 Mod 1
            'para acumular
            lbl_500.Text = Val(txt_sueldo.Text) / 500 + lbl_500.Text
            lbl_200.Text = b500 / 200 + lbl_200.Text
            lbl_100.Text = b200 / 100 + lbl_100.Text
            lbl_50.Text = b100 / 50 + lbl_50.Text
            lbl_20.Text = b50 / 20 + lbl_20.Text
            lbl_10.Text = b20 / 10 + lbl_10.Text
            lbl_5.Text = b10 / 5 + lbl_5.Text
            lbl_2.Text = b5 / 2 + lbl_2.Text
            lbl_1.Text = b2 / 1 + lbl_1.Text








            'para que se muestren enteros


            lbl_500.Text = Int(lbl_500.Text)
            lbl_200.Text = Int(lbl_200.Text)
            lbl_100.Text = Int(lbl_100.Text)
            lbl_50.Text = Int(lbl_50.Text)
            lbl_20.Text = Int(lbl_20.Text)
            lbl_10.Text = Int(lbl_10.Text)
            lbl_5.Text = Int(lbl_5.Text)
            lbl_2.Text = Int(lbl_2.Text)
            lbl_1.Text = Int(lbl_1.Text)


            'para mostrar la cantidad de dinero por numero de respectivos bitelles o monedas

            importe_500 = 500 * lbl_500.Text
            importe_200 = 200 * lbl_200.Text
            importe_100 = 100 * lbl_100.Text
            importe_50 = 50 * lbl_50.Text
            importe_20 = 20 * lbl_20.Text
            importe_10 = 10 * lbl_10.Text
            importe_5 = 5 * lbl_5.Text
            importe_2 = 2 * lbl_2.Text
            importe_1 = 1 * lbl_1.Text

            total = total + Val(txt_sueldo.Text)
            lbl_empleados.Text = Val(lbl_empleados.Text) + 1

            'formatos

            lbl_importe_500.Text = Format(importe_500, "$ ##,##0.00")
            lbl_importe_200.Text = Format(importe_200, "$ ##,##0.00")
            lbl_importe_100.Text = Format(importe_100, "$ ##,##0.00")
            lbl_importe_50.Text = Format(importe_50, "$ ##,##0.00")
            lbl_importe_20.Text = Format(importe_20, "$ ##,##0.00")
            lbl_importe_10.Text = Format(importe_10, "$ ##,##0.00")
            lbl_importe_5.Text = Format(importe_5, "$ ##,##0.00")
            lbl_importe_2.Text = Format(importe_2, "$ ##,##0.00")
            lbl_importe_1.Text = Format(importe_1, "$ ##,##0.00")
            lbl_suma_importe.Text = Format(total, "$ ##,##0.00")

        End If
    End Sub
    'funcion a letras
    Public Function EnLetras(numero As String) As String

        Dim b, paso As Integer

        Dim expresion, entero, deci, flag As String



        flag = "N"

        For paso = 1 To Len(numero)

            If Mid(numero, paso, 1) = "." Then

                flag = "S"

            Else

                If flag = "N" Then

                    entero = entero + Mid(numero, paso, 1) 'Extae la parte entera del numero

                Else

                    deci = deci + Mid(numero, paso, 1) 'Extrae la parte decimal del numero

                End If

            End If

        Next paso



        If Len(deci) = 1 Then

            deci = deci & "0"

        End If



        flag = "N"

        If Val(numero) >= -999999999 And Val(numero) <= 999999999 Then 'si el numero esta dentro de 0 a 999.999.999

            For paso = Len(entero) To 1 Step -1

                b = Len(entero) - (paso - 1)

                Select Case paso

                    Case 3, 6, 9

                        Select Case Mid(entero, b, 1)

                            Case "1"

                                If Mid(entero, b + 1, 1) = "0" And Mid(entero, b + 2, 1) = "0" Then

                                    expresion = expresion & "cien "

                                Else

                                    expresion = expresion & "ciento "

                                End If

                            Case "2"

                                expresion = expresion & "doscientos "

                            Case "3"

                                expresion = expresion & "trescientos "

                            Case "4"

                                expresion = expresion & "cuatrocientos "

                            Case "5"

                                expresion = expresion & "quinientos "

                            Case "6"

                                expresion = expresion & "seiscientos "

                            Case "7"

                                expresion = expresion & "setecientos "

                            Case "8"

                                expresion = expresion & "ochocientos "

                            Case "9"

                                expresion = expresion & "novecientos "

                        End Select



                    Case 2, 5, 8

                        Select Case Mid(entero, b, 1)

                            Case "1"

                                If Mid(entero, b + 1, 1) = "0" Then

                                    flag = "S"

                                    expresion = expresion & "diez "

                                End If

                                If Mid(entero, b + 1, 1) = "1" Then

                                    flag = "S"

                                    expresion = expresion & "once "

                                End If

                                If Mid(entero, b + 1, 1) = "2" Then

                                    flag = "S"

                                    expresion = expresion & "doce "

                                End If

                                If Mid(entero, b + 1, 1) = "3" Then

                                    flag = "S"

                                    expresion = expresion & "trece "

                                End If

                                If Mid(entero, b + 1, 1) = "4" Then

                                    flag = "S"

                                    expresion = expresion & "catorce "

                                End If

                                If Mid(entero, b + 1, 1) = "5" Then

                                    flag = "S"

                                    expresion = expresion & "quince "

                                End If

                                If Mid(entero, b + 1, 1) > "5" Then

                                    flag = "N"

                                    expresion = expresion & "dieci"

                                End If



                            Case "2"

                                If Mid(entero, b + 1, 1) = "0" Then

                                    expresion = expresion & "veinte "

                                    flag = "S"

                                Else

                                    expresion = expresion & "veinti"

                                    flag = "N"

                                End If



                            Case "3"

                                If Mid(entero, b + 1, 1) = "0" Then

                                    expresion = expresion & "treinta "

                                    flag = "S"

                                Else

                                    expresion = expresion & "treinta y "

                                    flag = "N"

                                End If



                            Case "4"

                                If Mid(entero, b + 1, 1) = "0" Then

                                    expresion = expresion & "cuarenta "

                                    flag = "S"

                                Else

                                    expresion = expresion & "cuarenta y "

                                    flag = "N"

                                End If



                            Case "5"

                                If Mid(entero, b + 1, 1) = "0" Then

                                    expresion = expresion & "cincuenta "

                                    flag = "S"

                                Else

                                    expresion = expresion & "cincuenta y "

                                    flag = "N"

                                End If



                            Case "6"

                                If Mid(entero, b + 1, 1) = "0" Then

                                    expresion = expresion & "sesenta "

                                    flag = "S"

                                Else

                                    expresion = expresion & "sesenta y "

                                    flag = "N"

                                End If



                            Case "7"

                                If Mid(entero, b + 1, 1) = "0" Then

                                    expresion = expresion & "setenta "

                                    flag = "S"

                                Else

                                    expresion = expresion & "setenta y "

                                    flag = "N"

                                End If



                            Case "8"

                                If Mid(entero, b + 1, 1) = "0" Then

                                    expresion = expresion & "ochenta "

                                    flag = "S"

                                Else

                                    expresion = expresion & "ochenta y "

                                    flag = "N"

                                End If



                            Case "9"

                                If Mid(entero, b + 1, 1) = "0" Then

                                    expresion = expresion & "noventa "

                                    flag = "S"

                                Else

                                    expresion = expresion & "noventa y "

                                    flag = "N"

                                End If

                        End Select



                    Case 1, 4, 7

                        Select Case Mid(entero, b, 1)

                            Case "1"

                                If flag = "N" Then

                                    If paso = 1 Then

                                        expresion = expresion & "uno "

                                    Else

                                        expresion = expresion & "un "

                                    End If

                                End If

                            Case "2"

                                If flag = "N" Then

                                    expresion = expresion & "dos "

                                End If

                            Case "3"

                                If flag = "N" Then

                                    expresion = expresion & "tres "

                                End If

                            Case "4"

                                If flag = "N" Then

                                    expresion = expresion & "cuatro "

                                End If

                            Case "5"

                                If flag = "N" Then

                                    expresion = expresion & "cinco "

                                End If

                            Case "6"

                                If flag = "N" Then

                                    expresion = expresion & "seis "

                                End If

                            Case "7"

                                If flag = "N" Then

                                    expresion = expresion & "siete "

                                End If

                            Case "8"

                                If flag = "N" Then

                                    expresion = expresion & "ocho "

                                End If

                            Case "9"

                                If flag = "N" Then

                                    expresion = expresion & "nueve "

                                End If

                        End Select

                End Select

                If paso = 4 Then

                    If Mid(entero, 6, 1) <> "0" Or Mid(entero, 5, 1) <> "0" Or Mid(entero, 4, 1) <> "0" Or
                  (Mid(entero, 6, 1) = "0" And Mid(entero, 5, 1) = "0" And Mid(entero, 4, 1) = "0" And Len(entero) <= 6) Then




                        expresion = expresion & "mil "

                    End If

                End If

                If paso = 7 Then

                    If Len(entero) = 7 And Mid(entero, 1, 1) = "1" Then

                        expresion = expresion & "millón "

                    Else

                        expresion = expresion & "millones "

                    End If

                End If

            Next paso



            If deci <> "" Then

                If Mid(entero, 1, 1) = "-" Then 'si el numero es negativo

                    EnLetras = "menos " & expresion & "con " & deci ' & "/100"

                Else

                    EnLetras = expresion & deci & "/100" & " " ' & "/100"

                End If

            Else

                If Mid(entero, 1, 1) = "-" Then 'si el numero es negativo

                    EnLetras = "menos " & expresion

                Else

                    EnLetras = expresion

                End If

            End If

        Else 'si el numero a convertir esta fuera del rango superior e inferior

            EnLetras = ""

        End If
        EnLetras = EnLetras & "Pesos M.N."

    End Function


End Class
