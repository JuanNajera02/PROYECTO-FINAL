
Imports System.IO
Public Class MENU_CHEQUE

    Dim lane As String
    Dim datos_txt() As String
    Dim rfc, nombre_cheque, fecha_cheque As String

    Dim total_kilos_entregados, total_kilos_descontados, total_kilos_pagados, total_importe_subtotal, total_importe_impuestos, total_neto_pagar As Double

    Private Sub btn_cheque_Click(sender As Object, e As EventArgs) Handles btn_cheque.Click
        lbl_cantidad_total.Text = Format(total_neto_pagar, "$##,#0.00")
        lbl_fecha.Text = fecha_cheque
        lbl_nombre_cheque.Text = nombre_cheque
        lbl_cantidad_letra.Text = UCase(EnLetras(Math.Round(total_neto_pagar, 2)))
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click

        total_kilos_entregados = 0
        total_kilos_descontados = 0
        total_kilos_pagados = 0
        total_importe_impuestos = 0
        total_importe_subtotal = 0
        total_neto_pagar = 0
        txt_rfc.Text = ""
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
        Beep()

    End Sub

    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        Dim leer_archivo As New StreamReader("C:\padron\cosechas.txt")
        If txt_rfc.TextLength = 12 Or txt_rfc.TextLength = 13 Then
            rfc = UCase(txt_rfc.Text)
            Do
                lane = leer_archivo.ReadLine()
                datos_txt = Split(lane, ",")



                If datos_txt(0) = rfc Then


                    fecha_cheque = datos_txt(1)
                    nombre_cheque = datos_txt(2)
                    total_kilos_entregados = total_kilos_entregados + datos_txt(3)
                    total_kilos_descontados = total_kilos_descontados + datos_txt(4)
                    total_kilos_pagados = total_kilos_pagados + datos_txt(5)
                    total_importe_subtotal = total_importe_subtotal + datos_txt(6)
                    total_importe_impuestos = total_importe_impuestos + datos_txt(7)
                    total_neto_pagar = total_neto_pagar + datos_txt(8)

                    Format(total_neto_pagar, "$##,##0.00")
                End If

            Loop Until lane = ""

            dgv_barrido_datos.Rows.Clear()
            dgv_barrido_datos.Rows.Add(fecha_cheque, nombre_cheque, total_kilos_entregados, total_kilos_descontados, total_kilos_pagados, Format(total_importe_subtotal, "$##,##0.00"), Format(total_importe_impuestos, "$##,##0.00"), Format(total_neto_pagar, "$##,##0.00"))





        End If
        leer_archivo.Close()
    End Sub

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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
