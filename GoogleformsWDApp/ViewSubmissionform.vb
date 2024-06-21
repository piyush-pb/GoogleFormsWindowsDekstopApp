Public Class ViewSubmissionform
    Private stopwatch As New Stopwatch()
    Private timer As New Timer()

    Private Sub ViewSubmissionform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configure the Timer
        AddHandler timer.Tick, AddressOf Timer_Tick
        timer.Interval = 1000 ' Update every second
        timer.Start()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        ' Update the Stopwatch TextBox with the elapsed time
        Stopwatch2value.Text = String.Format("{0:00}:{1:00}:{2:00}", stopwatch.Elapsed.Hours, stopwatch.Elapsed.Minutes, stopwatch.Elapsed.Seconds)
    End Sub

    Private Sub ToggleStopwatch()
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ToggleStopwatch()
    End Sub
End Class
