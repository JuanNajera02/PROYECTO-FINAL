Public Class MENU_FACTORIAL
    Dim i, numero, factorial As Double

    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        txt_numero.Text = ""
        txt_factorial.Text = ""
        txt_numero.Focus()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub txt_numero_keypress(sender As Object, e As KeyPressEventArgs) Handles txt_numero.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cmd_calcular_Click(sender As Object, e As EventArgs) Handles cmd_calcular.Click
        If txt_numero.Text = "" Then
            MessageBox.Show("INSERTE UN NUMERO", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else


            '   ENTRADA
            factorial = 1
            numero = Val(txt_numero.Text)

            '   PROCESO
            For i = 1 To numero
                factorial = factorial * i
            Next i

            '   SALIDA
            txt_factorial.Text = factorial
        End If
    End Sub

    Private Sub MENU_FACTORIAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_numero.Focus()
    End Sub






End Class