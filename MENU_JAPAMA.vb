Public Class MENU_JAPAMA
    Private Sub btn_calculo_Click(sender As Object, e As EventArgs) Handles btn_calculo.Click
        'software de najera castro juan pablo '
        'la siguiente linea valida si el tipo de usuario es residencial'
        If cbox_usuario.Text = "DOMESTICO" Then
            lbl_importe_agua.Text = Math.Round(Val(txt_mts_consumo.Text) * Val(txt_precio_residencial.Text), 2)
            lbl_cuota_bomberos.Text = 2
            lbl_cuota_saneamiento.Text = Math.Round(Val(lbl_importe_agua.Text), 2) * 0.1
            lbl_importe_drenaje.Text = Math.Round(Val(lbl_importe_agua.Text), 2) * 0.2
            lbl_iva.Text = Math.Round(Val(lbl_importe_drenaje.Text) + Val(lbl_cuota_saneamiento.Text), 2) * 0.16
            lbl_total.Text = Math.Round(Val(lbl_importe_agua.Text) + Val(lbl_cuota_bomberos.Text) + Val(lbl_cuota_saneamiento.Text) + Val(lbl_importe_drenaje.Text) + Val(lbl_iva.Text), 2)
            lbl_domesticos.Text = Val(lbl_domesticos.Text) + 1
            label_bomberos_comercial.Text = Val(label_bomberos_comercial.Text) + lbl_cuota_bomberos.Text
        Else
            lbl_importe_agua.Text = Math.Round(Val(txt_mts_consumo.Text) * Val(txt_precio_comercial.Text), 2)
            lbl_cuota_bomberos.Text = 5
            lbl_cuota_saneamiento.Text = Math.Round(Val(lbl_importe_agua.Text), 2) * 0.25
            lbl_importe_drenaje.Text = Math.Round(Val(lbl_importe_agua.Text), 2) * 0.2
            lbl_iva.Text = Math.Round(Val(lbl_importe_agua.Text) + Val(lbl_importe_drenaje.Text) + Val(lbl_cuota_saneamiento.Text), 2) * 0.16
            lbl_total.Text = Math.Round(Val(lbl_importe_agua.Text) + Val(lbl_cuota_bomberos.Text) + Val(lbl_cuota_saneamiento.Text) + Val(lbl_importe_drenaje.Text) + Val(lbl_iva.Text), 2)
            lbl_residenciales.Text = Val(lbl_residenciales.Text) + 1
            label_bomberos_residenciales.Text = Val(label_bomberos_residenciales.Text) + lbl_cuota_bomberos.Text

        End If
        'para acumular los pagos'
        Select Case cbox_pago.Text
            Case "EFECTIVO"
                lbl_efectivo.Text = Math.Round(Val(lbl_efectivo.Text) + Val(lbl_total.Text), 2)
            Case "CHEQUE"
                lbl_cheque.Text = Math.Round(Val(lbl_cheque.Text) + Val(lbl_total.Text), 2)
            Case "TARJETA"
                lbl_tarjeta.Text = Math.Round(Val(lbl_tarjeta.Text) + Val(lbl_total.Text), 2)

        End Select
        'acumulaciones de los totales'
        lbl_suma_total.Text = Math.Round(Val(lbl_efectivo.Text) + Val(lbl_cheque.Text) + Val(lbl_tarjeta.Text), 2)
        label_total_bombeross.Text = Math.Round(Val(label_bomberos_comercial.Text) + Val(label_bomberos_residenciales.Text), 2)
        total_saneamiento.Text = Math.Round(Val(total_saneamiento.Text) + Val(lbl_cuota_saneamiento.Text), 2)
        total_agua.Text = Math.Round(Val(total_agua.Text) + Val(lbl_importe_agua.Text), 2)
        total_drenaje.Text = Math.Round(Val(total_drenaje.Text) + Val(lbl_importe_drenaje.Text), 2)
        total_mt3.Text = Math.Round(Val(total_mt3.Text) + Val(txt_mts_consumo.Text), 2)
        total_iva.Text = Math.Round(Val(total_iva.Text) + Val(lbl_iva.Text), 2)
    End Sub
    'para salir del programa por un boton'
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
    'para vaciar los datos de 1 programa'
    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        txt_mts_consumo.Text = ""
        lbl_importe_agua.Text = "________"
        txt_mts_consumo.Focus()
        lbl_importe_drenaje.Text = "________"
        lbl_cuota_saneamiento.Text = "________"
        lbl_cuota_bomberos.Text = "________"
        lbl_iva.Text = "________"
        lbl_total.Text = "________"

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbox_usuario.Text = "RESIDENCIAL"
        cbox_pago.Text = "EFECTIVO"
    End Sub
    ' para vaciar los dsatos de enteros totales '
    Private Sub btn_totales_Click(sender As Object, e As EventArgs) Handles btn_totales.Click
        lbl_domesticos.Text = "_____"
        lbl_residenciales.Text = "_____"
        lbl_efectivo.Text = "_____"
        lbl_tarjeta.Text = "_____"
        lbl_cheque.Text = "_____"
        lbl_suma_total.Text = "_____"
        label_bomberos_residenciales.Text = "______"
        label_bomberos_comercial.Text = "______"
        label_total_bombeross.Text = "______"
        total_agua.Text = "______"
        total_drenaje.Text = "______"
        total_mt3.Text = "______"
        total_saneamiento.Text = "______"
        total_iva.Text = "______"
    End Sub

End Class
