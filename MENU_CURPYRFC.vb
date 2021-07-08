Public Class MENU_CURPYRFC
    Dim datos As DialogResult
    Dim apellido_1, curp, rfc As String
    Dim longitud_ap1 As Integer
    Dim nombre, nombres, apellido_2 As String
    Dim n_random As String = "0123456789"
    Dim n_a_random As String = "0123456789A"
    Dim n3 As String
    Dim rand As New Random
    Dim n1, num1_curp, num2_curp, n2, num3_rfc As String

    Private Sub txt_año_TextChanged(sender As Object, e As EventArgs) Handles txt_año.TextChanged

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_entidad_federativa.Text = "SINALOA"
        cb_dia.Text = "SELEC"
        cb_mes.Text = "SELEC"

    End Sub
    'software de najera castro juan pablo
    Private Sub btn_curp_Click(sender As Object, e As EventArgs) Handles btn_curp.Click
        If txt_apellido1.TextLength = 0 Or txt_nombres.TextLength = 0 Or txt_año.TextLength = 0 Or Val(cb_dia.Text) = 0 Or Val(cb_mes.Text) = 0 Then
            datos = MessageBox.Show("INSERTE CORRECTAMENTE LOS DATOS", "dato", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            apellido_1 = UCase(txt_apellido1.Text)
            apellido_2 = UCase(txt_apellido2.Text)
            nombres = UCase(txt_nombres.Text)

            '1 y 2 // es la primera letra del primer apellido y la primera vocal '
            curp = Mid(apellido_1, 1, 1)
            longitud_ap1 = apellido_1.Length
            For p_letra = 2 To longitud_ap1 ' un cilo for desde la letra 2 hasta el total de letras del primer apellido para buscar la primera vocal'
                If Mid(apellido_1, p_letra, 1) = "A" Or Mid(apellido_1, p_letra, 1) = "E" Or Mid(apellido_1, p_letra, 1) = "I" Or Mid(apellido_1, p_letra, 1) = "O" Or Mid(apellido_1, p_letra, 1) = "U" Then
                    curp = curp & Mid(apellido_1, p_letra, 1)
                    Exit For
                End If
            Next
            '3 // es la primer letra del segundo apellido o si no tiene se pone una "X"'
            If txt_apellido2.TextLength <> 0 Then
                curp = curp & UCase(Mid(txt_apellido2.Text, 1, 1))
            Else
                curp = curp & "X"
            End If
            '4 // primer letra de el primer nombre pero si tiene dos nombre, sera la primer letra del segundo nombre
            If txt_nombres.Text.Contains(" ") Then
                For i = 1 To txt_nombres.Text.Length
                    nombre = Mid(txt_nombres.Text, i, 1)

                    If nombre = " " Then
                        i = i + 1
                        nombre = i
                        Exit For
                    End If

                Next
                curp = curp & UCase(Mid(txt_nombres.Text, nombre, 1))
            Else

                curp = curp & UCase(Mid(txt_nombres.Text, 1, 1))
            End If
            '5 y 6 // año
            curp = curp & (Mid(txt_año.Text, 3, 2))

            '7 y 8 // mes
            curp = curp & cb_mes.Text

            '9 y 10 // dia 
            curp = curp & cb_dia.Text

            '11 // hombre o mujer

            If rb_hombre.Checked Then
                curp = curp & "H"
            Else
                curp = curp & "M"
            End If
            ' 12 y 13 // estado
            Select Case cb_entidad_federativa.Text
                Case "AGUASCALIENTES"
                    curp = curp & "AS"
                Case "BAJA CALIFORNIA"
                    curp = curp & "BC"
                Case "BAJA CALIFORNIA SUR"
                    curp = curp & "BS"
                Case "CAMPECHE"
                    curp = curp & "CC"
                Case "COAHUILA"
                    curp = curp & "CL"
                Case "COLIMA"
                    curp = curp & "CM"
                Case "CHIAPAS"
                    curp = curp & "CS"
                Case "CHIHUAHUA"
                    curp = curp & "CH"
                Case "DISTRITO FEDERAL"
                    curp = curp & "DF"
                Case "DURANGO"
                    curp = curp & "DG"
                Case "GUANAJUATO"
                    curp = curp & "GT"
                Case "GUERRERO"
                    curp = curp & "GR"
                Case "HIDALGO"
                    curp = curp & "HG"
                Case "JALISCO"
                    curp = curp & "JC"
                Case "MEXICO"
                    curp = curp & "MC"
                Case "MICHOACAN"
                    curp = curp & "MN"
                Case "MORELOS"
                    curp = curp & "MS"
                Case "NAYARIT"
                    curp = curp & "NT"
                Case "NUEVO LEON"
                    curp = curp & "NL"
                Case "OAXACA"
                    curp = curp & "OC"
                Case "PUEBLA"
                    curp = curp & "PL"
                Case "QUERETARO"
                    curp = curp & "QT"
                Case "QUINTANA ROO"
                    curp = curp & "QR"
                Case "SAN LUIS POTOSI"
                    curp = curp & "SP"
                Case "SINALOA"
                    curp = curp & "SL"
                Case "SONORA"
                    curp = curp & "SR"
                Case "TABASCO"
                    curp = curp & "TC"
                Case "TAMAULIPAS"
                    curp = curp & "TS"
                Case "TLAXCALA"
                    curp = curp & "TL"
                Case "VERACRUZ"
                    curp = curp & "VZ"
                Case "YUCATAN"
                    curp = curp & "YN"
                Case "ZACATECAS"
                    curp = curp & "ZS"
            End Select
            '14, 15 y 16 // primer consonante ap1 ap2 y name
            For p_letra = 2 To longitud_ap1
                If Mid(apellido_1, p_letra, 1) <> "A" And Mid(apellido_1, p_letra, 1) <> "E" And Mid(apellido_1, p_letra, 1) <> "I" And Mid(apellido_1, p_letra, 1) <> "O" And Mid(apellido_1, p_letra, 1) <> "U" Then
                    curp = curp & Mid(apellido_1, p_letra, 1)
                    Exit For
                End If
            Next
            '15
            If txt_apellido2.TextLength <> 0 Then

                For p_letra = 2 To txt_apellido2.TextLength
                    If Mid(apellido_2, p_letra, 1) <> "A" And Mid(apellido_2, p_letra, 1) <> "E" And Mid(apellido_2, p_letra, 1) <> "I" And Mid(apellido_2, p_letra, 1) <> "O" And Mid(apellido_2, p_letra, 1) <> "U" Then
                        curp = curp & Mid(apellido_2, p_letra, 1)
                        Exit For
                    End If
                Next

            Else
                curp = curp & "X"
            End If
            '16
            For p_letra = 2 To txt_nombres.TextLength
                If Mid(nombres, p_letra, 1) <> "A" And Mid(nombres, p_letra, 1) <> "E" And Mid(nombres, p_letra, 1) <> "I" And Mid(nombres, p_letra, 1) <> "O" And Mid(nombres, p_letra, 1) <> "U" Then
                    curp = curp & Mid(nombres, p_letra, 1)
                    Exit For
                End If
            Next
            ' 17 y 18 num random

            n1 = rand.Next(0, 10)
            num1_curp = n_random.Substring(n1, 1)

            curp = curp & num1_curp

            n2 = rand.Next(0, 10)
            num2_curp = n_random.Substring(n2, 1)

            curp = curp & num2_curp
            '///////////////////////////////////////////////////////////////////////////////////////////////// RFC

            '1 y 2 // es la primera letra del primer apellido y la primera vocal '
            rfc = Mid(apellido_1, 1, 1)

            For p_letra = 2 To longitud_ap1 ' un cilo for desde la letra 2 hasta el total de letras del primer apellido para buscar la primera vocal'
                If Mid(apellido_1, p_letra, 1) = "A" Or Mid(apellido_1, p_letra, 1) = "E" Or Mid(apellido_1, p_letra, 1) = "I" Or Mid(apellido_1, p_letra, 1) = "O" Or Mid(apellido_1, p_letra, 1) = "U" Then
                    rfc = rfc & Mid(apellido_1, p_letra, 1)
                    Exit For
                End If
            Next
            '3 // es la primer letra del segundo apellido o si no tiene se pone una "X"'
            If txt_apellido2.TextLength <> 0 Then
                rfc = rfc & UCase(Mid(txt_apellido2.Text, 1, 1))
            Else
                rfc = rfc & "X"
            End If
            '4 // primer letra de el primer nombre pero si tiene dos nombre, sera la primer letra del segundo nombre
            If txt_nombres.Text.Contains(" ") Then
                For i = 1 To txt_nombres.Text.Length
                    nombre = Mid(txt_nombres.Text, i, 1)

                    If nombre = " " Then
                        i = i + 1
                        nombre = i
                        Exit For
                    End If

                Next
                rfc = rfc & UCase(Mid(txt_nombres.Text, nombre, 1))
            Else

                rfc = rfc & UCase(Mid(txt_nombres.Text, 1, 1))
            End If
            '5 y 6 // año
            rfc = rfc & (Mid(txt_año.Text, 3, 2))

            '7 y 8 // mes
            rfc = rfc & cb_mes.Text

            '9 y 10 // dia 
            rfc = rfc & cb_dia.Text

            n1 = rand.Next(0, 10)
            num1_curp = n_random.Substring(n1, 1)

            rfc = rfc & num1_curp

            n2 = rand.Next(0, 10)
            num2_curp = n_random.Substring(n2, 1)

            rfc = rfc & num2_curp

            n3 = rand.Next(0, 11)
            num3_rfc = n_a_random.Substring(n3, 1)

            rfc = rfc & num3_rfc





            lbl_rfc.Text = rfc ' rfc '

            lbl_curp.Text = curp ' curp '




        End If
    End Sub

    Private Sub txt_apellido1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_apellido1.KeyPress
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

    Private Sub txt_nombres_keypress(sender As Object, e As KeyPressEventArgs) Handles txt_nombres.KeyPress
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
        txt_apellido1.Text = " "
        txt_apellido2.Text = " "
        txt_año.Text = " "
        txt_nombres.Text = " "
        lbl_curp.Text = "____________________________"
        lbl_rfc.Text = "____________________________"
        cb_entidad_federativa.Text = "SINALOA"
    End Sub



    Private Sub txt_año_keypress(sender As Object, e As KeyPressEventArgs) Handles txt_año.KeyPress
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
End Class
