


Imports System.IO
Public Class MENU_ALUMNOS
    Dim cadena As String
    Dim deportes As String
    Dim ARCHIVO As System.IO.StreamWriter
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cb_dia.Text = "SELECT"
        cb_grado.Text = "1ERO"
        cb_mes.Text = "SELECT"
        txt_nombre.Focus()
        ARCHIVO = My.Computer.FileSystem.OpenTextFileWriter("C:\padron\alumnos.txt", True)
    End Sub

    Private Sub btn_registrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_registrar.Click
        If cb_grado.Text <> "1ERO" And cb_grado.Text <> "2DO" And cb_grado.Text <> "3ERO" And cb_grado.Text <> "4TO" And cb_grado.Text <> "5TO" Or txt_apellido1.TextLength = 0 Or txt_nombre.TextLength = 0 Or Val(txt_año.Text) = 0 Or txt_grupo.TextLength = 0 Or Val(cb_mes.Text) <= 0 Or Val(cb_dia.Text) <= 0 Then
            MessageBox.Show("INSERTE CORRECTAMENTE LOS DATOS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            lbl_fecha.Text = Date.Now
            cadena = UCase(txt_nombre.Text) & "," & UCase(txt_apellido1.Text)

            If txt_apellido2.TextLength = 0 Then
                cadena = cadena
            Else
                cadena = cadena & "," & UCase(txt_apellido2.Text)
            End If

            If rb_civil.Checked Then
                cadena = cadena & "," & "CIVIL" & ","
            ElseIf rb_geodesia.Checked Then
                cadena = cadena & "," & "CIVIL" & ","
            ElseIf rb_procesos.Checked Then
                cadena = cadena & "," & "CIVIL" & ","
            ElseIf rb_software.Checked Then
                cadena = cadena & "," & "CIVIL" & ","
            End If

            If cb_grado.Text = "1ERO" Then
                cadena = cadena & "1" & ","
            ElseIf cb_grado.Text = "2DO" Then
                cadena = cadena & "2" & ","
            ElseIf cb_grado.Text = "3ERO" Then
                cadena = cadena & "3" & ","
            ElseIf cb_grado.Text = "4TO" Then
                cadena = cadena & "4" & ","
            ElseIf cb_grado.Text = "5TO" Then
                cadena = cadena & "5" & ","

            End If

            cadena = cadena & txt_grupo.Text & ","

            cadena = cadena & cb_dia.Text & cb_mes.Text & txt_año.Text & ","


            If chb_soccer.Checked Then
                deportes = "S"
            Else
                deportes = "N"
            End If

            If chb_beis.Checked Then
                deportes = deportes & "S"
            Else
                deportes = deportes & "N"
            End If

            If chb_basket.Checked Then
                deportes = deportes & "S"
            Else
                deportes = deportes & "N"
            End If

            If chb_voleibol.Checked Then
                deportes = deportes & "S"
            Else
                deportes = deportes & "N"
            End If

            If chb_natacion.Checked Then
                deportes = deportes & "S"
            Else
                deportes = deportes & "N"
            End If

            If chb_ciclismo.Checked Then
                deportes = deportes & "S"
            Else
                deportes = deportes & "N"
            End If

            If chb_box.Checked Then
                deportes = deportes & "S"
            Else
                deportes = deportes & "N"
            End If

            If chb_tenis.Checked Then
                deportes = deportes & "S"
            Else
                deportes = deportes & "N"
            End If

            If chb_otros.Checked Then
                deportes = deportes & "S"
            Else
                deportes = deportes & "N"
            End If

            cadena = cadena & "," & deportes

            ARCHIVO.WriteLine(cadena)
            ARCHIVO.Flush()
            lb_alumnos.Items.Add(cadena)

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

    Private Sub txt_grupo_keypress(sender As Object, e As KeyPressEventArgs) Handles txt_grupo.KeyPress
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

    Private Sub cb_dia_keypress(sender As Object, e As KeyPressEventArgs) Handles cb_dia.KeyPress
        If Char.IsNumber(e.KeyChar) Then
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If


    End Sub

    Private Sub cb_mes_keypress(sender As Object, e As KeyPressEventArgs) Handles cb_mes.KeyPress
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

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        txt_nombre.Focus()
        txt_apellido1.Text = ""
        txt_apellido2.Text = ""
        txt_año.Text = ""
        txt_nombre.Text = ""
        txt_grupo.Text = ""
        lbl_fecha.Text = "__________"
        cb_dia.Text = "SELECT"
        cb_grado.Text = "1ERO"
        cb_mes.Text = "SELECT"
        chb_basket.Checked = False
        chb_beis.Checked = False
        chb_box.Checked = False
        chb_ciclismo.Checked = False
        chb_natacion.Checked = False
        chb_otros.Checked = False
        chb_soccer.Checked = False
        chb_tenis.Checked = False
        chb_voleibol.Checked = False
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
        Beep()
        Beep()
        ARCHIVO.Close()

    End Sub
End Class
