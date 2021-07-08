Imports System.IO

Public Class FORM_EMPLEADOS
    Dim cadena As String
    Dim ARCHIVO As System.IO.StreamWriter

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        If txt_apellido_1.TextLength = 0 Or txt_apellido_2.TextLength = 0 Or txt_año.TextLength = 0 Or txt_curp.TextLength <> 18 Or txt_domicilio.TextLength = 0 Or txt_nombre.TextLength = 0 Or txt_numero_empleado.TextLength = 0 Or txt_telefono.TextLength <> 10 Or cb_mes.Text = "" Or cb_dia.Text = "" Then
            MessageBox.Show("HAY ESPACIOS EN BLANCO, FAVOR DE LLENARLOS TODOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            cadena = cadena & txt_numero_empleado.Text & "," & txt_nombre.Text & "," & txt_apellido_1.Text & "," & txt_apellido_2.Text & "," & UCase(txt_curp.Text) & "," & cb_dia.Text & "," & cb_mes.Text & "," & txt_año.Text & "," & txt_telefono.Text & "," & txt_domicilio.Text


            ARCHIVO.WriteLine(cadena)
            ARCHIVO.Flush()
        End If
    End Sub


    Private Sub FORM_EMPLEADOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ARCHIVO = My.Computer.FileSystem.OpenTextFileWriter("C:\padron\catalogo_empleados.txt", True)
        txt_numero_empleado.Focus()
        cb_dia.DropDownStyle = ComboBoxStyle.DropDownList
        cb_mes.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub


    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
        ARCHIVO.Close()
    End Sub

    Private Sub txt_numero_empleado_keypress(sender As Object, e As KeyPressEventArgs) Handles txt_numero_empleado.KeyPress
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

    Private Sub txt_apellido_1_keypress(sender As Object, e As KeyPressEventArgs) Handles txt_apellido_1.KeyPress
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

    Private Sub txt_apellido_2_keypress(sender As Object, e As KeyPressEventArgs) Handles txt_apellido_2.KeyPress
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
        txt_curp.Text = ""
        txt_domicilio.Text = ""
        txt_nombre.Text = ""
        txt_numero_empleado.Text = ""
        txt_telefono.Text = ""
        txt_apellido_1.Text = ""
        txt_apellido_2.Text = ""
        txt_año.Text = ""
        cb_dia.Text = ""
        cb_mes.Text = ""
        txt_numero_empleado.Focus()
    End Sub
End Class