Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        Label1.Text = ProgressBar1.Value & "%"
        If ProgressBar1.Value = 75 Then
            black.Show()
            Me.TopMost = True
        End If
        If ProgressBar1.Value = _
        ProgressBar1.Maximum Then
            Timer1.Stop()
            Form2.Show()
            Me.Close()
        End If
    End Sub
End Class