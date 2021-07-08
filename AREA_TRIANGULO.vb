
Public Class AREA_TRIANGULO


    Private Sub boton_calcular_Click(sender As Object, e As EventArgs) Handles boton_calcular.Click
        lbl_area.Text = (txt_base.Text * txt_altura.Text) / 2
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        txt_base.Text = ""
        txt_altura.Text = ""
        lbl_area.Text = "____________"
    End Sub

    Private Sub boton_salir_Click(sender As Object, e As EventArgs) Handles boton_salir.Click
        Me.Close()
    End Sub
End Class
