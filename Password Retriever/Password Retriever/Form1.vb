Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim n As New Random
        ProgressBar1.Value = n.Next(0, 2000)
        Label2.Text = Label1.Text - ProgressBar1.Value
        If Label1.Text = 2000 Then
            ProgressBar1.Maximum = 5000
            ProgressBar1.Value = n.Next(0, 5000)
        ElseIf Label1.Text = 5000 Then
            ProgressBar1.Maximum = 10000
            ProgressBar1.Value = n.Next(0, 10000)
        ElseIf Label1.Text = 10000 Then
            Timer1.Stop()
            Timer2.Stop()
            MsgBox("No more passwords available.")
        End If
        If ProgressBar1.Value = Label1.Text Then
            Timer1.Stop()
            Timer2.Stop()
            Select Case n.Next(1, 10)
                Case 1
                    TextBox2.Text = "$H\b;3Q={h7((r"
                    Label3.Show()
                    Label4.Hide()
                Case 2
                    TextBox2.Text = "!WB@c!neK1._b"
                    Label3.Hide()
                    Label4.Show()
                Case 3
                    TextBox2.Text = "fm@lE\Pt0Y7(^z"
                    Label3.Show()
                    Label4.Hide()
                Case 4
                    TextBox2.Text = "l7,1^y^;kVqoP2"
                    Label3.Hide()
                    Label4.Show()
                Case 5
                    TextBox2.Text = "B9D]->ad?p9]\o"
                    Label3.Show()
                    Label4.Hide()
                Case 6
                    TextBox2.Text = "Hh]1;|[[??W4[u"
                    Label3.Hide()
                    Label4.Show()
                Case 7
                    TextBox2.Text = "g&Y*.tO5D+QkJg"
                    Label3.Show()
                    Label4.Hide()
                Case 8
                    TextBox2.Text = "N+$&=8'Vi <d&C"
                    Label3.Hide()
                    Label4.Show()
                Case 9
                    TextBox2.Text = "2#4c<3@54J^4=8"
                    Label3.Show()
                    Label4.Hide()
                Case 10
                    TextBox2.Text = "+{^#0-,u48@5R."
                    Label3.Hide()
                    Label4.Show()
            End Select
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Label1.Text += 1
    End Sub
End Class
