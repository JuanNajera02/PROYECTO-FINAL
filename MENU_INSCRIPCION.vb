Public Class MENU_INSCRIPCION
    Dim descuento As Double
    Dim importe_neto_pagar As Double
    Dim suma_antes_descuento_sumas, suma_antes_descuento_civil, suma_antes_descuento_geodesia, suma_antes_descuento_software, descuento_software, descuento_civil, descuento_sumas, descuento_geodesia, suma_despues_sumas, suma_despues_geodesia, suma_despues_civil, suma_despues_software As Double


    Private Sub txt_nombre_keypress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre.KeyPress
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


    Private Sub txt_pago_oficial_keypress(sender As Object, e As KeyPressEventArgs) Handles txt_pago_oficial.KeyPress
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


    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        If txt_nombre.Text = "" Or txt_pago_oficial.Text = "" Or txt_promedio.Text = "" Or cb_carrera.Text = "" Or cb_grado_escolar.Text = "" Then
            MessageBox.Show("INSERTE CORRECTAMENTE LOS DATOS", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else


            If cb_grado_escolar.Text = "1" Then

            Else
                If Val(txt_promedio.Text) > 9.0 And Val(txt_promedio.Text) <= 10 Then
                    descuento = 0.3
                ElseIf Val(txt_promedio.Text) >= 8.0 And Val(txt_promedio.Text) <= 9.0 Then
                    descuento = 0.2
                Else
                    descuento = 0
                End If

            End If
            txt_descuento.Text = descuento * Val(txt_pago_oficial.Text)
            importe_neto_pagar = Val(txt_pago_oficial.Text) - Val(txt_descuento.Text)

            If cb_carrera.Text = "CIVIL" Then
                lbl_alumnos_civil.Text = Val(lbl_alumnos_civil.Text) + 1
                suma_antes_descuento_civil = suma_antes_descuento_civil + Val(txt_pago_oficial.Text)
                descuento_civil = descuento_civil + txt_descuento.Text
                suma_despues_civil = suma_despues_civil + importe_neto_pagar

            ElseIf cb_carrera.Text = "GEODESIA" Then
                lbl_alumnos_geodesia.Text = Val(lbl_alumnos_geodesia.Text) + 1
                suma_antes_descuento_geodesia = suma_antes_descuento_geodesia + Val(txt_pago_oficial.Text)
                descuento_geodesia = descuento_geodesia + txt_descuento.Text
                suma_despues_geodesia = suma_despues_geodesia + importe_neto_pagar

            ElseIf cb_carrera.Text = "SOFTWARE" Then
                lbl_alumnos_software.Text = Val(lbl_alumnos_software.Text) + 1
                suma_antes_descuento_software = suma_antes_descuento_software + Val(txt_pago_oficial.Text)
                descuento_software = descuento_software + txt_descuento.Text
                suma_despues_software = suma_despues_software + importe_neto_pagar

            End If

            lbl_alumnos_sumas.Text = Val(lbl_alumnos_civil.Text) + Val(lbl_alumnos_geodesia.Text) + Val(lbl_alumnos_software.Text)
            suma_antes_descuento_sumas = suma_antes_descuento_civil + suma_antes_descuento_geodesia + suma_antes_descuento_software
            descuento_sumas = descuento_civil + descuento_geodesia + descuento_software
            suma_despues_sumas = suma_despues_civil + suma_despues_geodesia + suma_despues_software


            lbl_suma_antes_descuento_sumas.Text = Format(suma_antes_descuento_sumas, "$##,##0.00")
            lbl_suma_antes_descuento_civil.Text = Format(suma_antes_descuento_civil, "$##,##0.00")
            lbl_suma_antes_descuento_software.Text = Format(suma_antes_descuento_software, "$##,##0.00")
            lbl_suma_antes_descuento_geodesia.Text = Format(suma_antes_descuento_geodesia, "$##,##0.00")

            lbl_descuento_civil.Text = Format(descuento_civil, "$##,##0.00")
            lbl_descuento_software.Text = Format(descuento_software, "$##,##0.00")
            lbl_descuento_geodesia.Text = Format(descuento_geodesia, "$##,##0.00")
            lbl_descuento_sumas.Text = Format(descuento_sumas, "$##,##0.00")

            lbl_suma_despues_civil.Text = Format(suma_despues_civil, "$##,##0.00")
            lbl_suma_despues_software.Text = Format(suma_despues_software, "$##,##0.00")
            lbl_suma_despues_geodesia.Text = Format(suma_despues_geodesia, "$##,##0.00")
            lbl_suma_despues_sumas.Text = Format(suma_despues_sumas, "$##,##0.00")

        End If
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        txt_nombre.Text = ""
        txt_promedio.Text = ""
        cb_carrera.Focus()
        txt_descuento.Text = ""
    End Sub


End Class