
Imports System.IO
Public Class MENU_PRESUPUESTOS
    Dim ARCHIVO As System.IO.StreamWriter
    Dim cadena As String
    'PROGRAMA DE NAJERA CASTRO JUAN PABLO
    'SOFTWARE 101 VESPERTINO
    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        If cb_mes.Text = " " Or cb_municipio.Text = " " Or cb_rubro.Text = " " Or txt_importe.TextLength = 0 Or txt_importe.Text.Contains(".") Then
            MessageBox.Show("INSERTE CORRECTAMENTE LOS DATOS", "dato", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Format(txt_importe.Text, "####0")
            cadena = cb_municipio.Text & cb_mes.Text & cb_rubro.Text
            If txt_importe.TextLength = 6 Then
                cadena = cadena & "00"
            Else
                cadena = cadena & "000"
            End If
            cadena = cadena & txt_importe.Text

            ARCHIVO.WriteLine(cadena)
            ARCHIVO.Flush()
            lb_datos.Items.Add(cadena)

        End If
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Close()
        Beep()
        Beep()
        Me.Close()
        ARCHIVO.Close()
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ARCHIVO = My.Computer.FileSystem.OpenTextFileWriter("C:\padron\municipios.txt", True)
        cb_municipio.Focus()
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        txt_importe.Text = ""
        cb_municipio.Focus()
    End Sub
End Class
