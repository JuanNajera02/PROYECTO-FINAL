Public Class MENU_INVERSION
    Dim inversion, interes, total, capMes, inicial, ganancia As Double

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        dgv_barrido_datos.Rows.Clear()
    End Sub

    Dim meses As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click


        inversion = Val(TextBox1.Text)
        inicial = inversion
        interes = Val(TextBox2.Text)
        meses = Val(TextBox3.Text)
        dgv_barrido_datos.Rows.Clear()

        For i = 1 To meses

            capMes = (interes / 100) * inversion
            total = inversion + capMes

            dgv_barrido_datos.Rows.Add((i), Format(inversion, "$##,##0.00"), Format(capMes, "$##,##0.00"), Format(total, "$##,##0.00"))



            ganancia = ganancia + capMes
            inversion = total
        Next

        Label4.Text = ("CAPITAL INVERTIDO..: $" & Math.Round(inicial, 2))
        Label5.Text = ("INTERESES GANADOS..: $" & Math.Round(ganancia, 2))
        Label6.Text = ("CAPITAL FINAL......: $" & Math.Round(total, 2))

    End Sub




End Class