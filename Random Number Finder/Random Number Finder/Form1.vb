Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim a As Integer = TextBox1.Text
        Dim b As Integer = TextBox2.Text
        Dim c As Integer = TextBox5.Text
        Dim d As Integer = TextBox6.Text

        Dim x As New Random
        Dim a2 As Integer = x.Next(a, b)

        Dim y As New Random
        Dim b2 As Integer = y.Next(c, d)

        TextBox3.Text = a2.ToString
        TextBox4.Text = b2.ToString

        If TextBox3.Text = TextBox4.Text Then
            Timer1.Stop()
        End If

    End Sub
End Class
