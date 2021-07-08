Public Class MENU_MANUAL
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub MENU_MANUAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxAcroPDF1.LoadFile("C:\padron\MANUAL.pdf")
    End Sub
End Class