Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
        Timer2.Start()
        Timer2.Interval = 10 * Len(TextBox2.Text)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim pass As New Random
        Dim n As Integer = pass.Next(0, 253)
        TextBox1.Text = ListBox1.Items.Item(n)
        Label2.Text = TextBox1.Text
        TextBox3.Text = Math.Truncate(1000 / n)
        Label7.Text = TextBox3.Text
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ProgressBar1.Value += 1
        Label8.Text = ProgressBar1.Value.ToString & "%"
        TextBox2.Enabled = False
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            Timer2.Stop()
            TextBox2.Enabled = True
            Label2.Text = TextBox1.Text
            ProgressBar1.Value = 0
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer3.Start()
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Label5.Text = TextBox2.Text
    End Sub
End Class
