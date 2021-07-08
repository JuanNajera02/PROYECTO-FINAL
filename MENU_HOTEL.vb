Public Class MENU_HOTEL
    Dim nota As Integer
    Dim construccion(15, 12) As Double
    Dim num_piso, num_habitacion, importe, total, suma_piso As Double

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Dim importe_caro, piso_caro, promedio As Double
    Dim importe_barato As Double = 900000000000
    Private Sub btn_resultados_Click(sender As Object, e As EventArgs) Handles btn_resultados.Click
        dgv_1.Rows.Clear()
        dgv_2.Rows.Clear()
        For pisos = 1 To 15
            For habitacion = 1 To 12
                If construccion(pisos, habitacion) > 0 Then


                    dgv_1.Rows.Add(pisos, habitacion, Format(construccion(pisos, habitacion), "$##,##0.00"))
                End If
            Next
        Next
        For pisos = 1 To 15
            For habitacion = 1 To 12
                suma_piso = suma_piso + construccion(pisos, habitacion)
                If suma_piso > piso_caro Then
                    piso_caro = suma_piso
                End If
            Next

            If suma_piso > 0 Then

                dgv_2.Rows.Add(pisos, Format(suma_piso, "$##,##0.00"))
                suma_piso = 0
                End If
            Next
            promedio = total / nota
        lbl_promedioxhora.Text = Format(promedio, "$##,##0.00")
        lbl_piso_mas_caro.Text = Format(piso_caro, "$##,##0.00")
    End Sub


    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        If txt_importe.Text = "" Or cb_habitacion.Text = "" Or cb_piso.Text = "" Then
            MessageBox.Show("INSERTE CORRECTAMENTE LOS DATOS", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            num_habitacion = cb_habitacion.Text
            num_piso = cb_piso.Text

            importe = txt_importe.Text
            nota = nota + 1
            construccion(num_piso, num_habitacion) = construccion(num_piso, num_habitacion) + importe
            total = total + importe

            If importe > importe_caro Then
                importe_caro = importe
            End If

            If importe <= importe_barato Then
                importe_barato = importe
            End If

            lbl_suma_total.Text = Format(total, "$##,##0.00")
            lbl_hab_mas_barata.Text = Format(importe_barato, "$##,##0.00")
            lbl_hab_mas_cara.Text = Format(importe_caro, "$##,##0.00")
            lbl_nota.Text = nota
        End If
    End Sub
End Class