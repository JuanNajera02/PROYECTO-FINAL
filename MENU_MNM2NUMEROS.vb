Public Class MENU_MNM2NUMEROS
    Dim resultado As Double
    Dim a, b As Integer
    Dim mcd, mcm As Integer



    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        txt_mcd.Text = ""
        txt_mnm.Text = ""
        txt_numero1.Text = ""
        txt_numero2.Text = ""
        txt_numero1.Focus()
    End Sub

    Private Sub MENU_MNM2NUMEROS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_numero1.Focus()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub txt_numero1_keypress(sender As Object, e As KeyPressEventArgs) Handles txt_numero1.KeyPress
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

    Private Sub txt_numero2_keypress(sender As Object, e As KeyPressEventArgs) Handles txt_numero2.KeyPress
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

    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular_mcd.Click
        If txt_numero1.Text = "" Or txt_numero2.Text = "" Then
            MessageBox.Show("INSERTE CORRECTAMENTE LOS DATOS", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            a = txt_numero1.Text
            b = txt_numero2.Text
            mcd = getMCD(a, b)
            txt_mcd.Text = "MCD(" & a & "," & b & "): " & mcd

            mcm = getMCD(a, b)
            mcm = (a * b) / mcm
            txt_mnm.Text = "MCM(" & a & "," & b & "): " & mcm
        End If
    End Sub

    Private Function getMCD(a As Integer, b As Integer) As Integer
        Dim r As Integer = a Mod b
        If r = 0 Then
            Return b
        Else
            Return getMCD(b, r)
        End If
    End Function





End Class

