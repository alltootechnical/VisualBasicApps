Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim step1 As New System.IO.StreamWriter("C:\Users\Brian Guadalupe\Documents\step1 " & TimeOfDay.Ticks / (10 ^ 7) & ".txt")
        Dim card As String = TextBox1.Text
        Dim pin As String = TextBox2.Text
        Dim cvv As String = TextBox3.Text
        Dim expdate As String = ComboBox1.Text & "/" & ComboBox2.Text

        step1.Write(card & ControlChars.NewLine & pin & ControlChars.NewLine & cvv & ControlChars.NewLine & expdate)
        step1.Close()
        Form2.Show()
    End Sub
End Class
