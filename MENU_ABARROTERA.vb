Public Class MENU_ABARROTERA
    Dim dato, datos As DialogResult
    Dim ventas_contado, ventas_credito, comision_pagar_contado, total_comision, comision_pagar_credito, clave_vendedor, total_contado, total_credito, comision_pagar_total, comision_pagar_contado_total, comision_pagar_credito_total As Double

    Private Sub cb_clave_vendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cb_clave_vendedor.KeyPress
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

    Dim trabajadores(30, 4) As Double
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub


    'SOFTWARE DE NAJERA CASTRO JUAN PABLO'

    'PARA QUE NO SE PERMITAN LETRAS EN EL NOTA DE VENTA'
    Private Sub txt_nota_de_venta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nota_de_venta.KeyPress
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

    'PARA LIMPIAR DATOS'
    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        lbl_ventas_contado.Text = " __________"
        lbl_ventas_credito.Text = "__________"
        txt_nota_de_venta.Text = " "
        txt_importe_venta.Text = " "
        cb_clave_vendedor.Text = "SELEC CLAVE"
        cb_tipo_de_pago.Text = "SELEC PAGO"


    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        If Val(txt_nota_de_venta.Text) = 0 Or cb_tipo_de_pago.Text <> "CONTADO" And cb_tipo_de_pago.Text <> "CREDITO" Or Val(txt_importe_venta.Text) = 0 Or Val(cb_clave_vendedor.Text) = 0 Then
            datos = MessageBox.Show("INSERTE CORRECTAMENTE LOS DATOS", "dato", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            clave_vendedor = Val(cb_clave_vendedor.Text)

            If cb_tipo_de_pago.Text = "CONTADO" Then
                ventas_contado = Val(txt_importe_venta.Text)
                comision_pagar_contado = ventas_contado * 0.02
                total_contado = total_contado + ventas_contado
                comision_pagar_contado_total = comision_pagar_contado_total + comision_pagar_contado

            ElseIf cb_tipo_de_pago.Text = "CREDITO" Then
                ventas_credito = Val(txt_importe_venta.Text)
                comision_pagar_credito = ventas_credito * 0.015
                total_credito = total_credito + ventas_credito
                comision_pagar_credito_total = comision_pagar_credito_total + comision_pagar_credito

            End If
            'ACUMULADOS
            total_comision = comision_pagar_credito_total + comision_pagar_contado_total

            trabajadores(clave_vendedor, 1) = clave_vendedor
            trabajadores(clave_vendedor, 2) = trabajadores(clave_vendedor, 2) + ventas_contado
            trabajadores(clave_vendedor, 3) = trabajadores(clave_vendedor, 3) + ventas_credito
            trabajadores(clave_vendedor, 4) = trabajadores(clave_vendedor, 4) + comision_pagar_contado + comision_pagar_credito

            'FORMATS
            lbl_total_comision.Text = Format(total_comision, "$##,#0.00")
            lbl_total_credito.Text = Format(total_credito, "$##,#0.00")
            lbl_totral_contado.Text = Format(total_contado, "$##,#0.00")
            lbl_ventas_credito.Text = Format(ventas_credito, "$##,#0.00")
            lbl_ventas_contado.Text = Format(ventas_contado, "$##,#0.00")

            dgv_abarrotera_trabajadores.Rows.Clear()
            For clave_vendedor = 1 To 30
                If trabajadores(clave_vendedor, 4) > 0 Then
                    dgv_abarrotera_trabajadores.Rows.Add(trabajadores(clave_vendedor, 1), Format((trabajadores(clave_vendedor, 2)), "$##,#0.00"), Format((trabajadores(clave_vendedor, 3)), "$##,#0.00"), Format((trabajadores(clave_vendedor, 4)), "$##,#0.00"))


                    comision_pagar_credito = 0
                    comision_pagar_contado = 0
                    ventas_contado = 0
                    ventas_credito = 0
                End If
            Next
        End If
    End Sub
End Class