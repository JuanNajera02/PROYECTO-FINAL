Public Class MENU_JORNALEROS
    Dim datos As DialogResult
    Dim curp
    Dim total_hombres, total_trabajadores, total_mujeres, total_menores, total_casados, total_solteros, total_divorciados, total_viudos, total_otros, entidades_federativas(32) As Integer
    Dim porcentaje_hombres, porcentaje_mujeres, porcentaje_menores, porcentaje(32) As Double


    Private Sub txt_apellido2_keypress(sender As Object, e As KeyPressEventArgs) Handles txt_apellido2.KeyPress
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

    Private Sub txt_apellido1_keypress(sender As Object, e As KeyPressEventArgs) Handles txt_apellido1.KeyPress
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


    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        txt_apellido1.Text = ""
        txt_apellido2.Text = ""
        txt_curp.Text = ""
        txt_nombre.Text = ""
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
    'software de najera castro juan pablo'
    Dim contador_jornaleros As Integer



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_estado_civil.Text = "SELECCIONA"
    End Sub

    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        If txt_apellido1.TextLength = 0 And txt_curp.TextLength = 0 And txt_nombre.TextLength = 0 And cb_estado_civil.Text <> "CASADO" Or cb_estado_civil.Text <> "SOLTERO" Or cb_estado_civil.Text <> "DIVORCIADO" Or cb_estado_civil.Text <> "VIUDO" Or cb_estado_civil.Text <> "OTROS" Then
            datos = MessageBox.Show("INSERTE CORRECTAMENTE LOS DATOS", "dato", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            curp = txt_curp.Text
            contador_jornaleros = contador_jornaleros + 1


            If Mid(curp, 11, 1) = "H" Then
                total_hombres = total_hombres + 1

            Else
                total_mujeres = total_mujeres + 1

            End If
            total_trabajadores = total_mujeres + total_hombres
            porcentaje_hombres = (total_hombres / total_trabajadores) * 100
            porcentaje_mujeres = (total_mujeres / total_trabajadores) * 100

            For i = 5 To 5


                If Val(Mid(curp, i, 1)) = 0 Then
                    If Val(Mid(curp, 6, 1)) >= 4 Then
                        total_menores = total_menores + 1
                    End If
                End If
            Next

            porcentaje_menores = (total_menores / total_trabajadores) * 100

            Select Case cb_estado_civil.Text
                Case "CASADO"
                    total_casados = total_casados + 1
                Case "SOLTERO"
                    total_solteros = total_solteros + 1
                Case "DIVORCIADO"
                    total_divorciados = total_divorciados + 1
                Case "VIUDO"
                    total_viudos = total_viudos + 1
                Case "OTROS"
                    total_otros = total_otros + 1
            End Select




            Select Case Mid(curp, 12, 2)

                Case "AS"
                    entidades_federativas(1) = entidades_federativas(1) + 1
                    porcentaje(1) = entidades_federativas(1) / contador_jornaleros
                Case "BC"
                    entidades_federativas(2) = entidades_federativas(2) + 1
                    porcentaje(2) = entidades_federativas(2) / contador_jornaleros
                Case "BS"
                    entidades_federativas(3) = entidades_federativas(3) + 1
                    porcentaje(3) = entidades_federativas(3) / contador_jornaleros
                Case "CC"
                    entidades_federativas(4) = entidades_federativas(4) + 1
                    porcentaje(4) = entidades_federativas(4) / contador_jornaleros
                Case "CL"
                    entidades_federativas(5) = entidades_federativas(5) + 1
                    porcentaje(5) = entidades_federativas(5) / contador_jornaleros
                Case "CM"
                    entidades_federativas(6) = entidades_federativas(6) + 1
                    porcentaje(6) = entidades_federativas(6) / contador_jornaleros
                Case "CS"
                    entidades_federativas(7) = entidades_federativas(7) + 1
                    porcentaje(7) = entidades_federativas(7) / contador_jornaleros
                Case "CH"
                    entidades_federativas(8) = entidades_federativas(8) + 1
                    porcentaje(8) = entidades_federativas(8) / contador_jornaleros
                Case "DF"
                    entidades_federativas(9) = entidades_federativas(9) + 1
                    porcentaje(9) = entidades_federativas(9) / contador_jornaleros
                Case "DG"
                    entidades_federativas(10) = entidades_federativas(10) + 1
                    porcentaje(10) = entidades_federativas(10) / contador_jornaleros
                Case "GT"
                    entidades_federativas(11) = entidades_federativas(11) + 1
                    porcentaje(11) = entidades_federativas(11) / contador_jornaleros
                Case "GR"
                    entidades_federativas(12) = entidades_federativas(12) + 1
                    porcentaje(12) = entidades_federativas(12) / contador_jornaleros
                Case "HG"
                    entidades_federativas(13) = entidades_federativas(13) + 1
                    porcentaje(13) = entidades_federativas(13) / contador_jornaleros
                Case "JC"
                    entidades_federativas(14) = entidades_federativas(14) + 1
                    porcentaje(14) = entidades_federativas(14) / contador_jornaleros
                Case "MC"
                    entidades_federativas(15) = entidades_federativas(15) + 1
                    porcentaje(15) = entidades_federativas(15) / contador_jornaleros
                Case "MN"
                    entidades_federativas(16) = entidades_federativas(16) + 1
                    porcentaje(16) = entidades_federativas(16) / contador_jornaleros
                Case "MS"
                    entidades_federativas(17) = entidades_federativas(17) + 1
                    porcentaje(17) = entidades_federativas(17) / contador_jornaleros
                Case "NT"
                    entidades_federativas(18) = entidades_federativas(18) + 1
                    porcentaje(18) = entidades_federativas(18) / contador_jornaleros
                Case "NL"
                    entidades_federativas(19) = entidades_federativas(19) + 1
                    porcentaje(19) = entidades_federativas(19) / contador_jornaleros
                Case "OC"
                    entidades_federativas(20) = entidades_federativas(20) + 1
                    porcentaje(20) = entidades_federativas(20) / contador_jornaleros
                Case "PL"
                    entidades_federativas(21) = entidades_federativas(21) + 1
                    porcentaje(21) = entidades_federativas(21) / contador_jornaleros
                Case "QT"
                    entidades_federativas(22) = entidades_federativas(22) + 1
                    porcentaje(22) = entidades_federativas(22) / contador_jornaleros
                Case "QR"
                    entidades_federativas(23) = entidades_federativas(23) + 1
                    porcentaje(23) = entidades_federativas(23) / contador_jornaleros
                Case "SP"
                    entidades_federativas(24) = entidades_federativas(24) + 1
                    porcentaje(24) = entidades_federativas(24) / contador_jornaleros
                Case "SL"
                    entidades_federativas(25) = entidades_federativas(25) + 1
                    porcentaje(25) = entidades_federativas(25) / contador_jornaleros
                Case "SR"
                    entidades_federativas(26) = entidades_federativas(26) + 1
                    porcentaje(26) = entidades_federativas(26) / contador_jornaleros
                Case "TC"
                    entidades_federativas(27) = entidades_federativas(27) + 1
                    porcentaje(27) = entidades_federativas(27) / contador_jornaleros
                Case "TS"
                    entidades_federativas(28) = entidades_federativas(28) + 1
                    porcentaje(28) = entidades_federativas(28) / contador_jornaleros
                Case "TL"
                    entidades_federativas(29) = entidades_federativas(29) + 1
                    porcentaje(29) = entidades_federativas(29) / contador_jornaleros
                Case "VZ"
                    entidades_federativas(30) = entidades_federativas(30) + 1
                    porcentaje(30) = entidades_federativas(30) / contador_jornaleros
                Case "YN"
                    entidades_federativas(31) = entidades_federativas(31) + 1
                    porcentaje(31) = entidades_federativas(31) / contador_jornaleros
                Case "ZS"
                    entidades_federativas(32) = entidades_federativas(32) + 1
                    porcentaje(32) = entidades_federativas(32) / contador_jornaleros
            End Select

            lbl_total_solteros.Text = total_solteros
            lbl_total_casados.Text = total_casados
            lbl_total_divorsiados.Text = total_divorciados
            lbl_total_viudos.Text = total_viudos
            lbl_total_otros.Text = total_otros

            Format(porcentaje_menores, "##0.0%")
            Format(porcentaje_mujeres, "##0.0%")
            Format(porcentaje_hombres, "##0.0%")

            lbl_total_hombres.Text = total_hombres
            lbl_total_mujeres.Text = total_mujeres
            lbl_menores_edad.Text = total_menores
            lbl_total_trabajadores.Text = total_trabajadores
            lbl_total_porciento.Text = "100.0 %"
            lbl_porcentaje_hombre.Text = porcentaje_hombres
            lbl_porcentaje_mujeres.Text = porcentaje_mujeres
            lbl_porcentaje_menores.Text = porcentaje_menores

            dgv_barrido_datos.Rows.Clear()
            For estados = 1 To 32
                If entidades_federativas(estados) <> 0 Then
                    porcentaje(estados) = entidades_federativas(estados) / contador_jornaleros
                    dgv_barrido_datos.Rows.Add(estados, entidades_federativas(estados), porcentaje(estados).ToString("0.0%"))



                End If


            Next
            dgv_barrido_datos.Rows.Add("TOTALES", contador_jornaleros, "100.00%")
        End If
    End Sub
End Class
