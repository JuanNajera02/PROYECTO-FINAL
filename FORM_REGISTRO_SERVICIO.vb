Imports System.IO

Public Class FORM_REGISTRO_SERVICIO
    Dim cadena As String
    Dim ARCHIVO As System.IO.StreamWriter
    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        If txt_matricula.TextLength = 0 Or cb_tipopago.Text = "" Then
            MessageBox.Show("HAY ESPACIOS EN BLANCO, FAVOR DE LLENARLOS TODOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            cadena = txt_matricula.Text & ","
            If rb_compacto1.Checked Then
                cadena = cadena & "auto compacto-lavado exterior"
            ElseIf rb_compacto2.Checked Then
                cadena = cadena & "auto compacto-lavado exterior+aspirado"
            ElseIf rb_compacto3.Checked Then
                cadena = cadena & "auto compacto-lavado exterior+aspirado+encerado"
            ElseIf rb_suv1.Checked Then
                cadena = cadena & "auto suv-lavado exterior"
            ElseIf rb_suv2.Checked Then
                cadena = cadena & "auto suv-lavado exterior+aspirado"
            ElseIf rb_suv3.Checked Then
                cadena = cadena & "auto suv-lavado exterior+aspirado+encerado"
            ElseIf rb_pickup1.Checked Then
                cadena = cadena & "auto pickup-lavado exterior"
            ElseIf rb_pickup2.Checked Then
                cadena = cadena & "auto pickup-lavado exterior+aspirado"
            ElseIf rb_pickup3.Checked Then
                cadena = cadena & "auto pickup-lavado exterior+aspirado+encerado"
            ElseIf rb_otros1.Checked Then
                cadena = cadena & "auto otros-lavado exterior"
            ElseIf rb_otros2.Checked Then
                cadena = cadena & "auto otros-lavado exterior+aspirado"
            ElseIf rb_otros3.Checked Then
                cadena = cadena & "auto otros-lavado exterior+aspirado+encerado"
            End If
            cadena = cadena & "," & cb_tipopago.Text

            ARCHIVO.WriteLine(cadena)
            ARCHIVO.Flush()
        End If
    End Sub

    Private Sub FORM_REGISTRO_SERVICIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_tipopago.DropDownStyle = ComboBoxStyle.DropDownList
        ARCHIVO = My.Computer.FileSystem.OpenTextFileWriter("C:\padron\registro_servicios.txt", True)
        txt_matricula.Focus()
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        txt_matricula.Text = ""
        txt_matricula.Focus()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        ARCHIVO.Close()
        Me.Close()
    End Sub
End Class