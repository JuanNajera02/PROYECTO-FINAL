Public Class MENU_CALCULADORA
    Dim operacion As String
    Dim valor1 As Nullable(Of Double) = Nothing
    Dim valor2 As Nullable(Of Double) = Nothing
    Dim operador As Boolean
    Private Sub btn_0_Click(sender As Object, e As EventArgs) Handles btn_0.Click
        evaluacion_para_Concatenar()
        txt_resultado.Text &= "0"
    End Sub

    Private Sub btn_punto_Click(sender As Object, e As EventArgs) Handles btn_punto.Click
        evaluacion_para_Concatenar()
        If InStr(txt_resultado.Text, ".", CompareMethod.Text) = 0 Then
            txt_resultado.Text &= "."
        End If
    End Sub

    Private Sub btn_X_Click(sender As Object, e As EventArgs) Handles btn_X.Click
        haz_operacion()
        operacion = "*"
    End Sub

    Private Sub btn_dividir_Click(sender As Object, e As EventArgs) Handles btn_dividir.Click
        haz_operacion()
        operacion = "/"
    End Sub

    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        evaluacion_para_Concatenar()
        txt_resultado.Text &= "1"
    End Sub

    Private Sub btn_2_Click(sender As Object, e As EventArgs) Handles btn_2.Click
        evaluacion_para_Concatenar()
        txt_resultado.Text &= "2"
    End Sub

    Private Sub btn_3_Click(sender As Object, e As EventArgs) Handles btn_3.Click
        evaluacion_para_Concatenar()
        txt_resultado.Text &= "3"
    End Sub

    Private Sub btn_mas_Click(sender As Object, e As EventArgs) Handles btn_mas.Click
        haz_operacion()
        operacion = "+"
    End Sub

    Private Sub btn_4_Click(sender As Object, e As EventArgs) Handles btn_4.Click
        evaluacion_para_Concatenar()
        txt_resultado.Text &= "4"
    End Sub

    Private Sub btn_5_Click(sender As Object, e As EventArgs) Handles btn_5.Click
        evaluacion_para_Concatenar()
        txt_resultado.Text &= "5"
    End Sub

    Private Sub btn_6_Click(sender As Object, e As EventArgs) Handles btn_6.Click
        evaluacion_para_Concatenar()
        txt_resultado.Text &= "6"
    End Sub

    Private Sub btn_menos_Click(sender As Object, e As EventArgs) Handles btn_menos.Click
        haz_operacion()
        operacion = "-"
    End Sub

    Private Sub btn_7_Click(sender As Object, e As EventArgs) Handles btn_7.Click
        evaluacion_para_Concatenar()
        txt_resultado.Text &= "7"
    End Sub

    Private Sub bnt_8_Click(sender As Object, e As EventArgs) Handles bnt_8.Click
        evaluacion_para_Concatenar()
        txt_resultado.Text &= "8"
    End Sub

    Private Sub btn_9_Click(sender As Object, e As EventArgs) Handles btn_9.Click
        evaluacion_para_Concatenar()
        txt_resultado.Text &= "9"
    End Sub

    Private Sub btn_C_Click(sender As Object, e As EventArgs) Handles btn_C.Click
        txt_resultado.Text = "0"
        valor2 = Nothing
        valor1 = Nothing
    End Sub

    Private Sub btn_igual_Click(sender As Object, e As EventArgs) Handles btn_igual.Click
        haz_operacion()
        operacion = ""
    End Sub



    Public Sub haz_operacion()
        operador = True
        valor2 = Val(txt_resultado.Text)
        If valor1 IsNot Nothing Then
            Select Case operacion
                Case "+"
                    valor1 = valor1 + valor2
                Case "-"
                    valor1 -= valor2
                Case "*"
                    valor1 *= valor2
                Case = "/"
                    valor1 /= valor2
            End Select
            txt_resultado.Text = valor1
        Else
            valor1 = valor2
        End If
    End Sub

    Public Sub evaluacion_para_Concatenar()
        If operador = True Then
            txt_resultado.Text = ""
            operador = False
        ElseIf txt_resultado.Text = "0" Then
            txt_resultado.Text = ""
        End If
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class