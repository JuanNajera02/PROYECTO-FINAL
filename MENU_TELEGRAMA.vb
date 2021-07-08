Public Class MENU_TELEGRAMA
    Dim pagar, total_pagar As Double
    Dim total_palabras As Integer
    'software de najera castro juan pablo'
    'calculo a pagar'
    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        If Val(lbl_palabras_escritas.Text) <= 30 Then
            pagar = 25
        Else
            pagar = 25 + ((Val(lbl_palabras_escritas.Text) - 30) * 0.5)
        End If

        total_pagar = total_pagar + pagar
        total_palabras = total_palabras + Val(lbl_palabras_escritas.Text)



        'formats'
        lbl_pagar.Text = Format(pagar, "$ ##,##0.00")
        lbl_total_palabras.Text = total_palabras

        lbl_total_pagar.Text = Format(total_pagar, "$ ##,##0.00")



    End Sub
    'limpieza de datos'
    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        lbl_palabras_escritas.Text = "____________"
        lbl_pagar.Text = "____________"
        rtb_telegrama.Clear()
        rtb_telegrama.Focus()


    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub rtb_telegrama_TextChanged(sender As Object, e As EventArgs) Handles rtb_telegrama.TextChanged
        Dim numero_palabras As Integer
        Dim palabras As String

        For i = 1 To rtb_telegrama.Text.Length
            palabras = Mid(rtb_telegrama.Text, i, 1)

            If palabras = " " Then
                numero_palabras = numero_palabras + 1
            End If
        Next
        'acumulacion de palabras'
        lbl_palabras_escritas.Text = numero_palabras + 1
    End Sub
End Class
