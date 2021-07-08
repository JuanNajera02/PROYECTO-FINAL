Imports System.IO
Public Class MENU_CAPITALES
    'software de najera castro juan pablo
    'software 101 vespertino
    Dim intentos, correctos, incorrectos As Integer
    Dim califiacion As Double
    Dim ARCHIVO As System.IO.StreamReader
    Dim estado_capital As New ArrayList()
    Dim lane As String
    Dim entidad_generado_random As New Random()
    Dim entidad_generado_random_generado As Integer
    Dim linea_txt() As String
    Dim sin_repetir_numeros(32) As Integer
    Dim capital As String

    Private Sub btn_siguiente_Click(sender As Object, e As EventArgs) Handles btn_siguiente.Click
        intentos = intentos + 1

        If intentos = txt_numero_entidades.Text Then
            MessageBox.Show("JUEGO TERMINADO", "FINALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btn_reiniciar.Visible = True

            If RadioButton1.Checked And RadioButton1.Text = capital Then
                correctos = correctos + 1
            ElseIf RadioButton2.Checked And RadioButton2.Text = capital Then
                correctos = correctos + 1
            ElseIf RadioButton3.Checked And RadioButton3.Text = capital Then
                correctos = correctos + 1
            ElseIf RadioButton4.Checked And RadioButton4.Text = capital Then
                correctos = correctos + 1
            Else
                incorrectos = incorrectos + 1
            End If

            lbl_estados_adivinar.Text = txt_numero_entidades.Text
            lbl_capitales_acertadas.Text = correctos
            lbl_capitales_erroneas.Text = incorrectos

            califiacion = Val(lbl_capitales_acertadas.Text) / Val(lbl_estados_adivinar.Text) * 10



            If califiacion < 8 Then
                MessageBox.Show("COMO VA A SER POSIBLE QUE DESCONOZCAS TANTAS CAPITALES DE TU PROPOIO PAIS", "REGRESA A LA PRIMARIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("USTED SI TIENE DERECHO A SER LLAMADO MEXICANO", "VIVA MEXICO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            lbl_calificacion.Text = Format(califiacion, "###0.00")

        Else



            If RadioButton1.Checked And RadioButton1.Text = capital Then
                correctos = correctos + 1
            ElseIf RadioButton2.Checked And RadioButton2.Text = capital Then
                correctos = correctos + 1
            ElseIf RadioButton3.Checked And RadioButton3.Text = capital Then
                correctos = correctos + 1
            ElseIf RadioButton4.Checked And RadioButton4.Text = capital Then
                correctos = correctos + 1
            Else
                incorrectos = incorrectos + 1
            End If



            Do
                entidad_generado_random_generado = entidad_generado_random.Next(1, 33)
            Loop Until sin_repetir_numeros(entidad_generado_random_generado) <> 35
            lane = estado_capital(entidad_generado_random_generado)

            linea_txt = Split(lane, ",")

            lbl_estado.Text = linea_txt(0)
            RadioButton1.Text = linea_txt(1)
            RadioButton2.Text = linea_txt(2)
            RadioButton3.Text = linea_txt(3)
            RadioButton4.Text = linea_txt(4)
            capital = linea_txt(5)

            sin_repetir_numeros(entidad_generado_random_generado) = 35


            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False






        End If
    End Sub

    Private Sub btn_empezar_Click(sender As Object, e As EventArgs) Handles btn_empezar.Click


        If txt_numero_entidades.Text = "" Or Val(txt_numero_entidades.Text) < 1 Or Val(txt_numero_entidades.Text) > 32 Then
            MessageBox.Show("INGRESE UN NUMERO DE ENTIDADES VALIDO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            btn_empezar.Visible = False
            btn_siguiente.Visible = True
            Do
                entidad_generado_random_generado = entidad_generado_random.Next(1, 33)
            Loop Until sin_repetir_numeros(entidad_generado_random_generado) <> 35
            lane = estado_capital(entidad_generado_random_generado)

            linea_txt = Split(lane, ",")

            lbl_estado.Text = linea_txt(0)
            RadioButton1.Text = linea_txt(1)
            RadioButton2.Text = linea_txt(2)
            RadioButton3.Text = linea_txt(3)
            RadioButton4.Text = linea_txt(4)
            capital = linea_txt(5)

            sin_repetir_numeros(entidad_generado_random_generado) = 35




        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_siguiente.Visible = False
        btn_reiniciar.Visible = False
        ARCHIVO = My.Computer.FileSystem.OpenTextFileReader("C:\padron\estados.txt")

        Do
            lane = ARCHIVO.ReadLine()
            estado_capital.Add(lane)

        Loop Until lane = ""
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
        ARCHIVO.Close()
    End Sub

    Private Sub btn_reiniciar_Click(sender As Object, e As EventArgs) Handles btn_reiniciar.Click
        txt_numero_entidades.Text = ""
        intentos = 0
        correctos = 0
        incorrectos = 0
        califiacion = 0
        lbl_calificacion.Text = "____"
        lbl_capitales_acertadas.Text = "____"
        lbl_capitales_erroneas.Text = "____"
        lbl_estado.Text = "ESTADO"
        lbl_estados_adivinar.Text = "____"
        RadioButton1.Text = "____"
        RadioButton2.Text = "____"
        RadioButton3.Text = "____"
        RadioButton4.Text = "____"
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        txt_numero_entidades.Focus()
        btn_empezar.Visible = True
        btn_siguiente.Visible = False
        btn_reiniciar.Visible = False

    End Sub
End Class