Imports System.Math
Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim r As New Random
        Dim s As New Random
        Dim t As New Random
        Dim u As New Random
        Dim v As New Random
        Dim a As Integer = r.Next(-2, 10)
        Dim b As Integer = s.Next(0, 10)
        Dim c As Integer = t.Next(-2, 0)
        Dim d As Integer = u.Next(1, 9)
       
        If TextBox3.Text >= 100 Or TextBox3.Text < 0 Then
            TextBox3.Text = 50
        End If
        If TextBox5.Text >= 359 Or TextBox5.Text < 0 Then
            TextBox5.Text = 180
        End If
        Select Case IEEERemainder(d, 2)
            Case 1
                TextBox1.Text += a / 10
                TextBox2.Text += a / 10
                TextBox3.Text += b
                TextBox4.Text += a / 10
                TextBox5.Text += b
            Case 0
                TextBox1.Text -= a / 10
                TextBox2.Text -= a / 10
                TextBox3.Text -= b
                TextBox4.Text -= a / 10
                TextBox5.Text -= b
        End Select
    End Sub
End Class
