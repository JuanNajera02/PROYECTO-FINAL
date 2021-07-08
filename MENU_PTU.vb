Imports System.IO
Public Class MENU_PTU
    Dim datos, dato As DialogResult
    Dim utilidades, importe, total_utilidades, sueldo_diario As Double
    Dim utilidad(50, 5)
    Dim trabajadores_utilidades As Integer
    Dim ARCHIVO As System.IO.StreamWriter
    Dim dias_trabajados As Integer
    Dim total_utilidades_empleados As Double
    Dim porcentaje As Double


    'software de najera castro juan pablo
    'software de utilidades 

    Private Sub txt_importe_utilidades_Keypress(sender As Object, e As KeyPressEventArgs) Handles txt_importe_utilidades.KeyPress
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

    Private Sub txt_nombre_completo_keypress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre_completo.KeyPress
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

    Private Sub txt_dias_trabajados_keypress(sender As Object, e As KeyPressEventArgs) Handles txt_dias_trabajados.KeyPress
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

    Private Sub txt_cuenta_bancaria_keypress(sender As Object, e As KeyPressEventArgs) Handles txt_cuenta_bancaria.KeyPress
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ARCHIVO = My.Computer.FileSystem.OpenTextFileWriter("C:\padron\cuenta_banco.txt", True)
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        txt_cuenta_bancaria.Text = " "
        txt_dias_trabajados.Text = " "
        txt_cuenta_email.Text = " "
        txt_sueldo_diario.Text = " "
        txt_nombre_completo.Text = " "

        txt_nombre_completo.Focus()


    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        ARCHIVO.Close()
        Me.Close()
        Beep()
        Beep()

    End Sub


    'barrido de datos'
    Private Sub btn_resultados_Click(sender As Object, e As EventArgs) Handles btn_resultados.Click
        For trabajadores_utilidades = 1 To 50
            porcentaje = (utilidad(trabajadores_utilidades, 5) * 100) / total_utilidades_empleados
            utilidad(trabajadores_utilidades, 2) = total_utilidades * (porcentaje / 100)

        Next

        dgv_barrido_datos.Rows.Clear()
        For trabajadores_utilidades = 1 To 50

            If utilidad(trabajadores_utilidades, 2) <> 0 Then
                ARCHIVO.WriteLine(utilidad(trabajadores_utilidades, 1) & Format((utilidad(trabajadores_utilidades, 2)), "00000000.00") & (utilidad(trabajadores_utilidades, 3)))
                ARCHIVO.Flush()
                dgv_barrido_datos.Rows.Add(utilidad(trabajadores_utilidades, 1), Format((utilidad(trabajadores_utilidades, 2)), "$ ##,##0.00"), (utilidad(trabajadores_utilidades, 3)))
            End If
        Next



    End Sub

    'para que se guarden los datos de para imprimirse luego'
    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        If txt_nombre_completo.TextLength = 0 Or Val(txt_importe_utilidades.Text) <= 0 Or Val(txt_dias_trabajados.Text) <= 0 Or Val(txt_sueldo_diario.Text) <= 0 Or txt_cuenta_bancaria.TextLength <> 8 Then
        ElseIf Not txt_cuenta_email.Text.Contains("@") Or Not txt_cuenta_email.Text.Contains(".com") Then
            datos = MessageBox.Show("INSERTE CORRECTAMENTE LOS DATOS", "dato", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            total_utilidades = Val(txt_importe_utilidades.Text)
            trabajadores_utilidades = trabajadores_utilidades + 1
            sueldo_diario = Val(txt_sueldo_diario.Text)
            dias_trabajados = Val(txt_dias_trabajados.Text)



            utilidad(trabajadores_utilidades, 1) = txt_cuenta_bancaria.Text
            utilidad(trabajadores_utilidades, 3) = txt_cuenta_email.Text
            utilidad(trabajadores_utilidades, 4) = txt_nombre_completo.Text



            If dias_trabajados < 60 Then
                utilidad(trabajadores_utilidades, 5) = 0
            Else
                utilidad(trabajadores_utilidades, 5) = dias_trabajados * sueldo_diario
                total_utilidades_empleados = total_utilidades_empleados + utilidad(trabajadores_utilidades, 5)

            End If












        End If
    End Sub
End Class
