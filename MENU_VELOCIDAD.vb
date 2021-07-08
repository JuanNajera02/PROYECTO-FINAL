Public Class MENU_VELOCIDAD
    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        If txt_distancia.Text = "" Or txt_tiempo.Text = "" Then
            MessageBox.Show("INSERTE CORRECTAMENTE LOS DATOS", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            txt_velocidad_promedio.Text = Val(txt_distancia.Text) / Val(txt_tiempo.Text) & " M/S"



        End If
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        txt_distancia.Text = ""
        txt_tiempo.Text = ""
        txt_velocidad_promedio.Text = ""
        txt_distancia.Focus()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub MENU_VELOCIDAD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_distancia.Focus()
    End Sub
End Class