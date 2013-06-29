Public Class Form4

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        Label40.Text = ProgressBar1.Value & "%"
        If ProgressBar1.Value = _
        ProgressBar1.Maximum Then
            Timer1.Stop()
            captcha.Show()
        End If
    End Sub
End Class