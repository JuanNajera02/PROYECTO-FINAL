Public Class FROM_INICIO
    Dim usuario, contraseña As String

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub



    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        usuario = txt_usuario.Text
        contraseña = txt_contraseña.Text
        If (usuario = "carwash") And (contraseña = "carwash123") Then
            FORM_MENU_CARWASH.Show()

        Else
            MsgBox("USUARIO O CONTRASEÑA INCORRECTOS, PORFAVOR VERIFIQUE")
        End If
        txt_contraseña.Text = ""
        txt_usuario.Text = ""
    End Sub
End Class
