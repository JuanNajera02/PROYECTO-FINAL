Imports System.IO
Public Class FORM_CLIENTES
    Dim cadena As String
    Dim ARCHIVO As System.IO.StreamWriter

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        If txt_domicilio.TextLength = 0 Or txt_telefono.Text = "" Or txt_clave.Text = "" Then
            MessageBox.Show("INSERTE CORRECTAMENTE LOS DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            cadena = cadena & txt_clave.Text & ","

            If txt_nombre.TextLength = 0 Then
                cadena = cadena & "1.publico en general" & ","
            Else
                cadena = cadena & txt_nombre.Text & ","
            End If
            cadena = cadena & txt_rfc.Text & "," & txt_email.Text & "," & txt_domicilio.Text & "," & txt_telefono.Text & "," & Date.Now




            ARCHIVO.WriteLine(cadena)
                ARCHIVO.Flush()
            End If
    End Sub

    Private Sub FORM_CLIENTES_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ARCHIVO = My.Computer.FileSystem.OpenTextFileWriter("C:\padron\catalogo_clientes.txt", True)
        txt_clave.Focus()
    End Sub

    Private Sub txt_telefono_keypress(sender As Object, e As KeyPressEventArgs) Handles txt_telefono.KeyPress
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

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
        ARCHIVO.Close()
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        txt_telefono.Text = ""
        txt_rfc.Text = ""
        txt_nombre.Text = ""
        txt_email.Text = ""
        txt_domicilio.Text = ""
        txt_clave.Text = ""
        txt_clave.Focus()
    End Sub
End Class