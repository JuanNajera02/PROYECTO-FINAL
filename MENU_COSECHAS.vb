Imports System.IO

Public Class MENU_COSECHAS
    Dim porcentaje_kg_descontados, sub_total, importe_impuestos, total_neto, total_subtotal, total_impuestos, total_general_neto, kilos_descontados As Double
    Dim fecha, fecha_hoy As String
    Dim cadena As String
    Dim ARCHIVO As System.IO.StreamWriter
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ARCHIVO = My.Computer.FileSystem.OpenTextFileWriter("C:\padron\cosechas.txt", True)
    End Sub
    'software de Najera Castro Juan Pablo'
    Private Sub btn_calcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular.Click
        If txt_clave_productor.TextLength <> 13 And txt_clave_productor.TextLength <> 12 Or txt_nombre.TextLength = 0 Or Val(txt_maiz_recibido.Text) = 0 Or Val(txt_porcentaje_humedad.Text) = 0 Or Val(txt_precio_tonelada.Text) = 0 Then

            MessageBox.Show("INSERTE CORRECTAMENTE LOS DATOS", "dato", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            lbl_fecha.Text = Date.Now
            fecha = Format(lbl_fecha.Text, "long date")
            fecha_hoy = Mid(fecha, 12, 26)

            cadena = txt_clave_productor.Text & "," & fecha_hoy & ","

            'select case para la formula de kilos descontados'
            cadena = cadena & UCase(txt_nombre.Text) & ","

            Select Case txt_porcentaje_humedad.Text
                Case <= 14
                    porcentaje_kg_descontados = 0


                Case <= 16
                    porcentaje_kg_descontados = 0.03

                Case <= 18
                    porcentaje_kg_descontados = 0.05

                Case > 18
                    porcentaje_kg_descontados = 0.07

            End Select
            cadena = cadena & txt_maiz_recibido.Text & ","
            kilos_descontados = Val(txt_maiz_recibido.Text) * Val(porcentaje_kg_descontados)
            lbl_kilos_pagados.Text = Val(txt_maiz_recibido.Text) - kilos_descontados
            sub_total = lbl_kilos_pagados.Text * txt_precio_tonelada.Text / 1000
            importe_impuestos = sub_total * 0.012
            total_neto = sub_total - importe_impuestos



            cadena = cadena & kilos_descontados & "," & lbl_kilos_pagados.Text & ","


            lbl_kilos_descontados.Text = Format(kilos_descontados, "###0.00")
            lbl_total_neto.Text = Format(total_neto, "###0.00")
            lbl_importe_impuestos.Text = Format(importe_impuestos, "###0.00")
            lbl_sub_total.Text = Format(sub_total, "###0.00")

            lbl_total_kilos_descontados.Text = Val(lbl_total_kilos_descontados.Text) + kilos_descontados
            lbl_total_kilos_pagados.Text = Val(lbl_total_kilos_pagados.Text) + Val(lbl_kilos_pagados.Text)
            total_subtotal = total_subtotal + sub_total
            total_impuestos = total_impuestos + importe_impuestos
            total_general_neto = total_general_neto + total_neto

            cadena = cadena & lbl_sub_total.Text & "," & lbl_importe_impuestos.Text & "," & lbl_total_neto.Text

            ARCHIVO.WriteLine(cadena)
            ARCHIVO.Flush()
            lb_datos.Items.Add(cadena)


            'formats'
            lbl_total_subtotal.Text = Format(total_subtotal, "###0.00")
            lbl_total_impuestos.Text = Format(total_impuestos, "###0.00")
            lbl_total_general_neto.Text = Format(total_general_neto, "###0.00")
        End If

    End Sub
    'para limpiar el foms'
    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        txt_clave_productor.Text = ""
        txt_nombre.Text = ""
        txt_maiz_recibido.Text = ""
        txt_porcentaje_humedad.Text = ""

        lbl_kilos_descontados.Text = "____________"
        lbl_kilos_pagados.Text = "____________"
        lbl_importe_impuestos.Text = "____________"
        lbl_sub_total.Text = "____________"
        lbl_total_neto.Text = "____________"

    End Sub
    ' ME PARECIO UN MUY BUEN PROGRAMA QUE HIZO QUE ME SINTIERA MAS FAMILIZARIADO CON TODO ESTO Y ESPERO QUE SIGAMOS TRABJANDO ASI, ENTENDI TODO A LA PERFECCION.'
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
        Beep()
        Beep()

        ARCHIVO.Close()
    End Sub
End Class
