Public Class splash_screen
    Private ticks As Integer
    Private Sub splash_screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Timer.Start()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If ticks = 0 Then
            conectar_banco()
            ticks = 1
            form_login.Show()
        End If
    End Sub
End Class