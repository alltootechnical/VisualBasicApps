Imports System.Math
Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Automatic.Checked = True Then
            Month_A.Text = DateAndTime.Now.Month
            Day_A.Text = DateAndTime.Now.Day
            Year_A.Text = DateAndTime.Now.Year
            Hour_A.Text = DateAndTime.Now.Hour
            Min_A.Text = DateAndTime.Now.Minute
            Sec_A.Text = DateAndTime.Now.Second
            MS_A.Text = DateAndTime.Now.Millisecond
        Else
            Hour_A.Text = DateAndTime.Now.Hour
            Min_A.Text = DateAndTime.Now.Minute
            Sec_A.Text = DateAndTime.Now.Second
            MS_A.Text = DateAndTime.Now.Millisecond
        End If


        Dim txtDate1 As Date = CType(Month_A.Text & "/" & Day_A.Text & "/" & Year_A.Text & " " & Hour_A.Text & ":" & Min_A.Text & ":" & Sec_A.Text & "." & MS_A.Text, Date)
        Dim txtDate2 As Date = CType(Month_B.Text & "/" & Day_B.Text & "/" & Year_B.Text & " " & Hour_B.Text & ":" & Min_B.Text & ":" & Sec_B.Text & "." & MS_B.Text, Date)
        Dim MyDifference As TimeSpan

        MyDifference = txtDate2.Subtract(txtDate1) ' find the number of days apart
        Dim NewYears As Double = TextBox2.Text

        TextBox1.Text = FormatNumber(NewYears / 365.25, 0)
        TextBox5.Text = FormatNumber((MyDifference.TotalSeconds), 0)
        TextBox4.Text = FormatNumber((MyDifference.TotalMinutes), 0)
        TextBox3.Text = FormatNumber((MyDifference.TotalHours), 0)
        TextBox2.Text = FormatNumber((MyDifference.TotalDays), 0)
        TextBox6.Text = FormatNumber((MyDifference.TotalMilliseconds), 0)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Label1.ForeColor = Color.Green
        Label1.Text = "Running !"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Enabled = False
        Label1.ForeColor = Color.Red
        Label1.Text = "Stopped !"
    End Sub

End Class
