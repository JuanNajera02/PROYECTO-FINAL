Public Class FORM_MENU_CARWASH
    Private Sub CatalogosDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatalogosDeClientesToolStripMenuItem.Click
        FORM_CLIENTES.Show()
    End Sub

    Private Sub CatalagosDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatalagosDeEmpleadosToolStripMenuItem.Click
        FORM_EMPLEADOS.Show()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub VentaDeServicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentaDeServicioToolStripMenuItem.Click
        FORM_REGISTRO_SERVICIO.Show()

    End Sub


End Class