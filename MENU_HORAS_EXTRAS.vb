Public Class MENU_HORAS_EXTRAS
    Dim sueldo_bruto, sueldo_neto As Double
    Dim horas_extras As Integer
    Dim horas_triples As Integer
    Dim impuestos As Double
    Dim horas_laboradas As Integer

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        lbl_impuestos.Text = "_________"
        lbl_sueldo_bruto.Text = "_________"
        lbl_sueldo_neto.Text = "_________"
        txt_horas_laboradas.Text = ""
        txt_pago_por_hora.Text = ""
        txt_horas_laboradas.Focus()
    End Sub

    Private Sub MENU_HORAS_EXTRAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_horas_laboradas.Focus()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub txt_horas_laboradas_keypress(sender As Object, e As KeyPressEventArgs) Handles txt_horas_laboradas.KeyPress
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

    Private Sub txt_pago_por_hora_keypress(sender As Object, e As KeyPressEventArgs) Handles txt_pago_por_hora.KeyPress
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


    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        If txt_horas_laboradas.Text = "" Or txt_pago_por_hora.Text = "" Then
            MessageBox.Show("INSERTE CORRECTAMENTE LOS DATOS", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            horas_laboradas = txt_horas_laboradas.Text
            If horas_laboradas < 49 Then
                sueldo_bruto = Val(txt_pago_por_hora.Text) * Val(txt_horas_laboradas.Text)
            Else
                horas_extras = horas_laboradas - 48
                If horas_extras > 9 Then
                    horas_triples = horas_extras - 9
                    sueldo_bruto = (Val(txt_pago_por_hora.Text) * 48) + (9 * Val(txt_pago_por_hora.Text) * 2) + (horas_triples * Val(txt_pago_por_hora.Text) * 3)
                Else
                    sueldo_bruto = (Val(txt_pago_por_hora.Text) * 48) + (horas_extras * Val(txt_pago_por_hora.Text) * 2)
                End If
            End If
            impuestos = sueldo_bruto * 7.6 / 100
            sueldo_neto = sueldo_bruto - impuestos

            lbl_sueldo_bruto.Text = Format(sueldo_bruto, "$##,##0.00")
            lbl_sueldo_neto.Text = Format(sueldo_neto, "$##,##0.00")
            lbl_impuestos.Text = Format(impuestos, "$##,##0.00")
        End If
    End Sub
End Class