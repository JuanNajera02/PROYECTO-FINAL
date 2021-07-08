Public Class ISR


    Dim rfc, datos As DialogResult
        Dim entidad_federativa(32, 3), base_gravable, isr, suma_total_isr, num_entidad, porciento As Double
        Dim estados As Integer
        Private Sub txt_nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre.KeyPress
            If Char.IsLetter(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsSeparator(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End Sub

        Private Sub txt_importe_anual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_importe_anual.KeyPress
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






        Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

        Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
            txt_rfc.Text = ""
            txt_nombre.Text = ""
            txt_importe_anual.Text = ""
            lbl_base_gravable.Text = "__________"
            lbl_isr.Text = "__________"
            txt_rfc.Focus()
            cb_entidad_federativa.Text = "SELEC ENTIDAD"
        End Sub

        Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click

            If txt_rfc.TextLength < 13 Or txt_rfc.TextLength > 13 Or Val(cb_entidad_federativa.Text) = 0 Or Val(txt_importe_anual.Text) = 0 Or txt_nombre.TextLength = 0 Then
                rfc = MessageBox.Show("INSERTE CORRECTAMENTE LOS DATOS", "datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                num_entidad = Val(cb_entidad_federativa.Text)
                lbl_porciento.Text = "100%"
                base_gravable = Val(txt_importe_anual.Text) - (Val(txt_salario_minimo.Text) * 365)

                If base_gravable <= 0 Then
                    base_gravable = 0
                End If

                isr = base_gravable * 32 / 100

                suma_total_isr = suma_total_isr + isr


                entidad_federativa(num_entidad, 1) = num_entidad
                entidad_federativa(num_entidad, 2) = entidad_federativa(num_entidad, 2) + isr



                lbl_isr.Text = Format(isr, "$##,#0")
                lbl_base_gravable.Text = Format(base_gravable, "$##,#0.00")
                lbl_suma_total_isr.Text = Format(suma_total_isr, "$##,#0.00")

                dgv_barrido_datos.Rows.Clear()
                'para el barrido de datos en la tabla' 
                For estados = 1 To 32
                    porciento = entidad_federativa(estados, 2) / suma_total_isr * 100
                    entidad_federativa(estados, 3) = porciento
                    If entidad_federativa(estados, 2) > 0 Then
                        dgv_barrido_datos.Rows.Add(entidad_federativa(estados, 1), Format((entidad_federativa(estados, 2)), "$##,##0"), Format((entidad_federativa(estados, 3)), "##0.0") & "%")







                    End If
                Next
            End If
        End Sub
    End Class


