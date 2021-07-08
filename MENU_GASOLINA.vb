Public Class MENU_GASOLINA
    Dim importe, importe_diesel, importe_magna, importe_premium, total_tarjeta, total_efectivo, total_cheque, total_ventas, total_importe As Double
    'software de NAJERA CASTRO JUAN PABLO'
    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        If rb_magna.Checked Then
            importe = (Val(presio_magna.Text) * Val(litros_vendidos.Text))
            lbl_litros_magna.Text = (Val(litros_vendidos.Text) + Val(lbl_litros_magna.Text))
            importe_magna = (Val(lbl_litros_magna.Text) * Val(presio_magna.Text))

        ElseIf rb_premium.Checked Then
            importe = (Val(presio_premium.Text) * Val(litros_vendidos.Text))
            lbl_litros_premium.Text = (Val(litros_vendidos.Text) + Val(lbl_litros_premium.Text))
            importe_premium = (Val(lbl_litros_premium.Text) * Val(presio_premium.Text))

        Else
            importe = (Val(presio_diesel.Text) * Val(litros_vendidos.Text))
            lbl_litros_diesel.Text = (Val(litros_vendidos.Text) + Val(lbl_litros_diesel.Text))
            importe_diesel = (Val(lbl_litros_diesel.Text) * Val(presio_diesel.Text))

        End If
        'format'
        lbl_importe.Text = Format(importe, "$##,#0.00")
        lbl_importe_diesel.Text = Format(importe_diesel, "$##,#0.00")
        lbl_importe_magna.Text = Format(importe_magna, "$##,#0.00")
        lbl_importe_premium.Text = Format(importe_premium, "$##,#0.00")

        'acumuladores'
        If rb_efectivo.Checked Then
            total_efectivo = importe + total_efectivo
        ElseIf rb_tarjeta_de_credito.Checked Then
            total_tarjeta = importe + total_tarjeta
        Else
            total_cheque = importe + total_cheque

        End If
        lbl_total_cheque.Text = Format(total_cheque, "$##,#0.00")
        lbl_total_efectivo.Text = Format(total_efectivo, "$##,#0.00")
        lbl_total_tarjeta.Text = Format(total_tarjeta, "$##,#0.00")

        total_ventas = total_cheque + total_efectivo + total_tarjeta
        lbl_total_litros.Text = (Val(lbl_litros_diesel.Text) + Val(lbl_litros_magna.Text) + Val(lbl_litros_premium.Text))
        total_importe = importe_diesel + importe_magna + importe_premium




        lbl_total_ventas.Text = Format(total_ventas, "$##,#0.00")

        lbl_total_importe.Text = Format(total_importe, "$##,#0.00")

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        litros_vendidos.Text = ""
        litros_vendidos.Focus()
        lbl_importe.Text = "______________"
        'me parecio una practica muy Buena que me ayudo a reforzar todo lo que hemos visto en esto y espero que sigamos trabajando de esta forma’
    End Sub
End Class
