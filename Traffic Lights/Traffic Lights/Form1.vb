Public Class Form1

    Private Sub dwalk_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dwalk.Tick
        Label1.ForeColor = Color.Red
        PictureBox1.ImageLocation = "C:\Users\Brian Guadalupe\Pictures\stop.png"
        Label1.Text -= 1
        If Label1.Text = 0 Then
            Label1.Text = 38
            Label1.ForeColor = Color.Green
            dwalk.Stop()
            walk.Start()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dwalk.Start()
    End Sub

    Private Sub walk_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles walk.Tick
        Label1.ForeColor = Color.Green
        PictureBox1.ImageLocation = "C:\Users\Brian Guadalupe\Pictures\walk.gif"
        Label1.Text -= 1
        If Label1.Text = 0 Then
            Label1.ForeColor = Color.Red
            Label1.Text = 66
            walk.Stop()
            dwalk2.Start()
        End If
    End Sub

    Private Sub dwalk2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dwalk2.Tick
        Label1.ForeColor = Color.Red
        PictureBox1.ImageLocation = "C:\Users\Brian Guadalupe\Pictures\stop.png"
        Label1.Text -= 1
        If Label1.Text = 0 Then
            Label1.Text = 16
            Label1.ForeColor = Color.Green
            dwalk2.Stop()
            walk2.Start()
        End If
    End Sub

    Private Sub walk2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles walk2.Tick
        Label1.ForeColor = Color.Green
        PictureBox1.ImageLocation = "C:\Users\Brian Guadalupe\Pictures\walk.gif"
        Label1.Text -= 1
        If Label1.Text = 0 Then
            Label1.Text = 99
            Label1.ForeColor = Color.Red
            walk2.Stop()
            dwalk.Start()
        End If
    End Sub
End Class
