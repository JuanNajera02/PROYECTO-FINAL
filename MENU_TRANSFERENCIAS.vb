Public Class MENU_TRANSFERENCIAS
    Dim datos As DialogResult
    Dim total_transferencias As Integer
    Dim total_dinero As Double
    Dim banco(127) As Double
    Dim emisor(127) As Double
    Dim clabe_banco As Integer


    'SOFTWARE DE NAJERA CASTRO JUAN PABLO
    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        If txt_clabe_banco.TextLength <> 18 And Val(txt_importe.Text) <= 0 And cb_banco_emisor.Text <> "BANAMEX" And cb_banco_emisor.Text <> "BANCA SERFIN, S.A." And cb_banco_emisor.Text <> "BANCOMER, S.A." And cb_banco_emisor.Text <> "SANTANDER MEXICANO, S.A." And cb_banco_emisor.Text <> "BANCO NACIONAL DEL EJERCITO Y FUERZA AEREA Y ARMADA, S.N.C." And cb_banco_emisor.Text <> "BANCO DEL BAJIO, S.A." And cb_banco_emisor.Text <> "BANCO INBURSA, S.A." And cb_banco_emisor.Text <> "SCOTIABANK, S.A." And cb_banco_emisor.Text <> "HSBC" And cb_banco_emisor.Text <> "AZTECA" Then
            datos = MessageBox.Show("INSERTE CORRECTAMENTE LOS DATOS", "dato", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'ACUMULADOS
            total_transferencias = total_transferencias + 1
            total_dinero = total_dinero + Val(txt_importe.Text)
            'LLAMANDO A LA FUNCTION
            num_banco(clabe_banco)
            'DINERO RECIBIDO POR EL BANCO

            'DETERMINAR BANCO POR MEDIO DE LA CLABE BANCARIO Y USANDO LA FUNCION 
            If clabe_banco = "002" Then
                emisor(2) = emisor(2) + Val(txt_importe.Text)

            ElseIf clabe_banco = "003" Then
                emisor(3) = emisor(3) + Val(txt_importe.Text)
            ElseIf clabe_banco = "012" Then
                emisor(12) = emisor(12) + Val(txt_importe.Text)
            ElseIf clabe_banco = "014" Then
                emisor(14) = emisor(14) + Val(txt_importe.Text)
            ElseIf clabe_banco = "019" Then
                emisor(19) = emisor(19) + Val(txt_importe.Text)
            ElseIf clabe_banco = "030" Then
                emisor(30) = emisor(30) + Val(txt_importe.Text)
            ElseIf clabe_banco = "036" Then
                emisor(36) = emisor(36) + Val(txt_importe.Text)
            ElseIf clabe_banco = "044" Then
                emisor(44) = emisor(44) + Val(txt_importe.Text)
            ElseIf clabe_banco = "119" Then
                emisor(119) = emisor(119) + Val(txt_importe.Text)
            ElseIf clabe_banco = "127" Then
                emisor(127) = emisor(127) + Val(txt_importe.Text)

            End If


            'DINERO ENVIADO POR EL BANCO
            Select Case cb_banco_emisor.Text

                Case "BANAMEX"
                    banco(2) = banco(2) + Val(txt_importe.Text)
                Case "BANCA SERFIN, S.A."
                    banco(3) = banco(3) + Val(txt_importe.Text)
                Case "BANCOMER, S.A."
                    banco(12) = banco(12) + Val(txt_importe.Text)
                Case "SANTANDER MEXICANO, S.A."
                    banco(14) = banco(14) + Val(txt_importe.Text)
                Case "BANCO NACIONAL DEL EJERCITO Y FUERZA AEREA Y ARMADA, S.N.C."
                    banco(19) = banco(19) + Val(txt_importe.Text)
                Case "BANCO DEL BAJIO, S.A."
                    banco(30) = banco(30) + Val(txt_importe.Text)
                Case "BANCO INBURSA, S.A."
                    banco(36) = banco(36) + Val(txt_importe.Text)
                Case "SCOTIABANK, S.A."
                    banco(44) = banco(44) + Val(txt_importe.Text)
                Case "HSBC"
                    banco(119) = banco(119) + Val(txt_importe.Text)
                Case "AZTECA"
                    banco(127) = banco(127) + Val(txt_importe.Text)

            End Select

            lbl_total_transferido.Text = Format(total_dinero, "$##,#0.00")
            lbl_total_transferencias.Text = total_transferencias

            'BARRIDO DE DATOS

            dgv_barrido_banco.Rows.Clear()
            For bancos = 1 To 127
                If banco(bancos) <> 0 Or
                 emisor(bancos) <> 0 Then
                    dgv_barrido_banco.Rows.Add(bancos, Format(banco(bancos), "$##,#0.00"), Format(emisor(bancos), "$##,#0.00"))

                End If

            Next

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_banco_emisor.Text = "BANCO ..."
    End Sub

    Private Sub txt_clabe_banco_keypress(sender As Object, e As KeyPressEventArgs) Handles txt_clabe_banco.KeyPress
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

    'FUNCTION
    Public Function num_banco(clabe As Integer) As Integer

        clabe_banco = Mid(txt_clabe_banco.Text, 1, 3)

        Return clabe_banco
    End Function

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        Call limpiar()
    End Sub


    Private Sub limpiar()
        txt_clabe_banco.Clear()
        txt_importe.Clear()
        cb_banco_emisor.Text = "BANCO ..."
    End Sub
    Private Sub txt_importe_keypress(sender As Object, e As KeyPressEventArgs) Handles txt_importe.KeyPress
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
