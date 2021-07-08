Public Class MENU_CALIFICACIONES
    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        If txt_calificacion1.Text = "" Or txt_calificacion2.Text = "" Or txt_calificacion3.Text = "" Then
            MessageBox.Show("INSERTE CORRECTAMENTE LOS DATOS", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            txt_promedio.Text = (Val(txt_calificacion1.Text) + Val(txt_calificacion2.Text) + Val(txt_calificacion3.Text)) / 3
            If Val(txt_calificacion3.Text) < 6 Then
                MessageBox.Show("USTED ESTA REPROBADO", "REPROBADO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("USTED APROVO", "APROVADO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        txt_calificacion1.Text = ""
        txt_calificacion2.Text = ""
        txt_calificacion3.Text = ""
        txt_promedio.Text = ""
        txt_calificacion1.Focus()
    End Sub

    Private Sub MENU_CALIFICACIONES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_calificacion1.Focus()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class