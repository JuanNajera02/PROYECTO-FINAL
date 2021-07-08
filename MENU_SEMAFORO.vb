Public Class FORM_SEMAFORO

    'NAJERA CASTRO JUAN PABLO
    'SOFTWARE 101 VESPERTINO

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.verde1.Visible = True
        Me.verde2.Visible = True
        Me.verde3.Visible = True
        Me.verde4.Visible = True

        Me.rojo1.Visible = True
        Me.rojo2.Visible = True
        Me.rojo3.Visible = True
        Me.rojo4.Visible = True

        Me.amarillo1.Visible = True
        Me.amarillo2.Visible = True
        Me.amarillo3.Visible = True
        Me.amarillo4.Visible = True
        semaforo() ' Invoco (mando llamar) al SUB Semaforo
    End Sub

    Private Sub semaforo()
        For i As Integer = 1 To 2000
            Me.Timer1.Start()

        Next
    End Sub
    'TIMER 1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.verde1.Visible = False
        Me.rojo1.Visible = True
        Me.rojo2.Visible = False
        Me.rojo3.Visible = False
        Me.rojo4.Visible = False
        Me.Timer1.Stop()
        Me.Timer2.Start()


    End Sub
    'TIMER 2
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.amarillo1.Visible = False
        Me.verde1.Visible = True
        Me.rojo2.Visible = False
        Me.rojo3.Visible = False
        Me.rojo4.Visible = False
        Me.Timer2.Stop()
        Me.Timer3.Start()
    End Sub
    'TIMER 3
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Me.rojo1.Visible = False
        Me.amarillo1.Visible = True
        Me.verde2.Visible = False
        Me.rojo2.Visible = True
        Me.rojo3.Visible = False
        Me.rojo4.Visible = False

        Me.Timer3.Stop()
        Me.Timer4.Start()

    End Sub
    'TIMER 4

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Me.rojo1.Visible = False

        Me.amarillo2.Visible = False
        Me.verde2.Visible = True
        Me.rojo3.Visible = False
        Me.rojo4.Visible = False

        Me.Timer4.Stop()
        Me.Timer5.Start()
    End Sub
    'TIMER 5

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Me.rojo1.Visible = False
        Me.rojo2.Visible = False
        Me.amarillo2.Visible = True
        Me.rojo3.Visible = True
        Me.verde3.Visible = False
        Me.rojo4.Visible = False

        Me.Timer5.Stop()
        Me.Timer6.Start()

    End Sub
    'TIMER 6

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Me.rojo1.Visible = False
        Me.rojo2.Visible = False
        Me.verde3.Visible = True
        Me.amarillo3.Visible = False
        Me.rojo4.Visible = False

        Me.Timer6.Stop()
        Me.Timer7.Start()

    End Sub
    'TIMER 7

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        Me.rojo1.Visible = False
        Me.rojo2.Visible = False
        Me.rojo4.Visible = True
        Me.amarillo3.Visible = True
        Me.verde4.Visible = False
        Me.rojo3.Visible = False

        Me.Timer7.Stop()
        Me.Timer8.Start()

    End Sub
    'TIMER 8

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        Me.rojo1.Visible = False
        Me.rojo2.Visible = False
        Me.rojo4.Visible = True
        Me.amarillo4.Visible = False
        Me.verde4.Visible = True
        Me.rojo3.Visible = False

        Me.Timer8.Stop()
        Me.Timer9.Start()

    End Sub
    'TIMER 9

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        Me.rojo1.Visible = True
        Me.rojo2.Visible = False
        Me.rojo4.Visible = False
        Me.amarillo4.Visible = True
        Me.verde4.Visible = True
        Me.rojo3.Visible = False
        Me.verde1.Visible = False

        Me.Timer9.Stop()
        Me.Timer1.Start()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class


