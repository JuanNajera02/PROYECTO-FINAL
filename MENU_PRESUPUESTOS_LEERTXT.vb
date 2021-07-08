
Imports System.IO
Public Class menu_presupuestos_leertxt
    Dim leer_archivo As New StreamReader("C:\padron\municipios.txt", True)
    Dim lane As String
    Dim sinaloa(18, 6, 12) As Integer
    Dim num_municipio, num_mes, num_rubro, importe As String
    Dim porcentaje, porcentaje2 As Double
    Dim total_pagar As Integer
    'PROGRAMA DE NAJERA CASTRO JUAN PABLO
    'SOFTWARE 101 VESPERTINO 
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
        leer_archivo.Close()
        Beep()

    End Sub

    Private Sub btn_consulta1_Click(sender As Object, e As EventArgs) Handles btn_mostrar_resultados.Click
        'PARA MOSTRAR EL PRIMER RECUADRO

        dgv_datos_1.Rows.Clear()
        For municipio = 1 To 18
            For rubro = 1 To 6
                For mes = 1 To 12
                    '´PARA EL PRIMER RECUADRO ESTOS SON LOS CALCULAS USADOS
                    If sinaloa(municipio, rubro, mes) <> 0 Then
                        sinaloa(municipio, rubro, 0) = sinaloa(municipio, rubro, 0) + sinaloa(municipio, rubro, mes)
                    End If
                Next
                If sinaloa(municipio, rubro, 0) <> 0 Then

                    dgv_datos_1.Rows.Add(municipio, rubro, Format(sinaloa(municipio, rubro, 0), "$###,###0.00"))
                End If
            Next
        Next

        'PARA QUE SE MUESTRE EL SEGUDNO RECUADRO
        dgv_datos_2.Rows.Clear()
        For municipio = 1 To 18
            For rubro = 1 To 6
                For mes = 1 To 12

                    If sinaloa(municipio, rubro, mes) <> 0 Then
                        sinaloa(municipio, 0, 0) = sinaloa(municipio, 0, 0) + sinaloa(municipio, rubro, mes)
                    End If
                Next
            Next


            If sinaloa(municipio, 0, 0) <> 0 Then
                total_pagar = total_pagar + sinaloa(municipio, 0, 0)
                porcentaje = sinaloa(municipio, 0, 0) / 10000


                dgv_datos_2.Rows.Add(municipio, porcentaje, Format((sinaloa(municipio, 0, 0)), "$##,###0.00"))

            End If
        Next

        'PARA MOSTRAR EL TERCER RECUADRO CALCULOS USADOS

        dgv_datos_3.Rows.Clear()
        For municipio = 1 To 18
            For rubro = 1 To 6
                For mes = 1 To 12
                    If sinaloa(municipio, rubro, mes) <> 0 Then
                        sinaloa(0, 0, mes) = sinaloa(0, 0, mes) + sinaloa(municipio, rubro, mes)

                    End If

                Next
            Next
        Next
        For mes = 1 To 12
            If sinaloa(0, 0, mes) <> 0 Then
                porcentaje2 = sinaloa(0, 0, mes) / 10000

                dgv_datos_3.Rows.Add(mes, porcentaje2, Format(sinaloa(0, 0, mes), "$##,###0.00"))
            End If
        Next

        'PARA MOSTRAR EL CUARTO RECUADRO CALCULOS USADOS

        dgv_datos_4.Rows.Clear()
        For municipio = 1 To 18
            For rubro = 1 To 6
                For mes = 1 To 12


                    If sinaloa(municipio, rubro, mes) <> 0 Then
                        sinaloa(0, rubro, mes) = sinaloa(0, rubro, mes) + sinaloa(municipio, rubro, mes)


                        dgv_datos_4.Rows.Add(municipio, rubro, mes, Format(sinaloa(0, rubro, mes), "$##,###0.00"))
                    End If
                Next
            Next
        Next


        lbl_total1.Text = Format(total_pagar, "$##,###0.00")
        lbl_total2.Text = Format(total_pagar, "$##,###0.00")
        lbl_total3.Text = Format(total_pagar, "$##,###0.00")
        lbl_total4.Text = Format(total_pagar, "$##,###0.00")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Do
            lane = leer_archivo.ReadLine()
            If Not lane Is Nothing Then
                num_municipio = Mid(lane, 1, 2)
                num_mes = Mid(lane, 3, 2)
                num_rubro = Mid(lane, 5, 2)
                importe = Mid(lane, 7, 8)

                sinaloa(Val(num_municipio), Val(num_rubro), Val(num_mes)) =
sinaloa(Val(num_municipio), Val(num_rubro), Val(num_mes)) + importe

            End If

        Loop Until lane Is Nothing
        leer_archivo.Close()

    End Sub
End Class
