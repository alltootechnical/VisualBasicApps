Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim step2 As New System.IO.StreamWriter("C:\Users\Brian Guadalupe\Documents\step2 " & TimeOfDay.Ticks / (10 ^ 7) & ".txt")
        Dim name As String = TextBox1.Text & " " & TextBox2.Text & " " & TextBox3.Text
    End Sub
End Class