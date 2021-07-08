Public Class MENU_CASE
    Dim cantidad_chocolate, cantidad_vainilla, cantidad_fresa, cantidad_total As Integer

    Private Sub MENU_CASE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_precio_por_pastel.Focus()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        cb_sabor_pastel.Text = ""
        txt_precio_por_pastel.Focus()
    End Sub

    Dim dinero_vainilla, dinero_chocolate, dinero_fresa, dinero_total, precio_por_pastel As Double

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        If txt_precio_por_pastel.Text = "" Or cb_sabor_pastel.Text = "" Then
            MessageBox.Show("INSERTE CORRECTAMENTE LOS DATOS", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            precio_por_pastel = txt_precio_por_pastel.Text

            Select Case cb_sabor_pastel.Text
                Case "CHOCOLATE"
                    dinero_chocolate = dinero_chocolate + precio_por_pastel
                    cantidad_chocolate = cantidad_chocolate + 1
                Case "VAINILLA"
                    dinero_vainilla = dinero_vainilla + precio_por_pastel
                    cantidad_vainilla = cantidad_vainilla + 1
                Case "FRESA"
                    dinero_fresa = dinero_fresa + precio_por_pastel
                    cantidad_fresa = cantidad_fresa + 1


            End Select
            dinero_total = dinero_chocolate + dinero_fresa + dinero_vainilla
            cantidad_total = cantidad_vainilla + cantidad_fresa + cantidad_chocolate

            lbl_dinero_chocolate.Text = Format(dinero_chocolate, "$##,##0.00")
            lbl_dinero_fresa.Text = Format(dinero_fresa, "$##,##0.00")
            lbl_dinero_vainilla.Text = Format(dinero_vainilla, "$##,##0.00")
            lbl_dinero_total.Text = Format(dinero_total, "$##,##0.00")

            precio_por_pastel = txt_precio_por_pastel.Text
            lbl_cantidad_chocolate.Text = cantidad_chocolate
            lbl_cantidad_fresa.Text = cantidad_fresa
            lbl_cantidad_total.Text = cantidad_total
            lbl_cantidad_vainilla.Text = cantidad_vainilla



        End If
    End Sub
End Class