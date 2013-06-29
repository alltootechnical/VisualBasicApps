Public Class Form1

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        TextBox2.Text = Len(TextBox1.Text)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim m As New Random
        Dim int As Integer = m.Next(0, 99)

        TextBox5.Text = ProgressBar2.Value.ToString
        ProgressBar2.Value = Math.Truncate(100 / Len(TextBox3.Text))

        TextBox6.Text = ProgressBar1.Value.ToString

        TextBox7.Text = ProgressBar3.Value.ToString
        ProgressBar3.Value = Len(TextBox3.Text)

        ProgressBar1.Value += 1
        
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            ProgressBar1.Value = 0
            ProgressBar6.Value += 1
            TextBox13.Text = ProgressBar6.Value.ToString
            If ProgressBar6.Value = 50 Then
                Timer1.Stop()
                Timer2.Stop()
                Timer3.Stop()
                Timer4.Stop()
                MsgBox("Your password way too strong!!!", MsgBoxStyle.YesNo)
                If MsgBoxResult.Yes = True Then
                    End
                ElseIf MsgBoxResult.No = True Then
                    Timer1.Start()
                    Timer2.Start()
                    Timer3.Start()
                    Timer4.Start()
                End If
            End If
            If ListBox1.Items.Contains(TextBox1.Text) = True Then
                CheckBox2.Checked = True
            Else
                CheckBox2.Checked = False
            End If
            TextBox4.Text = "Complete. The password is " & TextBox1.Text & "."
            If Len(TextBox1.Text) < 4 Then
                TextBox8.Text = "Very Weak"
            ElseIf Len(TextBox1.Text) < 8 Then
                TextBox8.Text = "Weak"
            ElseIf Len(TextBox1.Text) = 8 Then
                TextBox8.Text = "Good"
            ElseIf Len(TextBox1.Text) > 8 Then
                TextBox8.Text = "Strong"
            ElseIf Len(TextBox1.Text) >= 14 Then
                TextBox8.Text = "Very Strong"
            End If
        End If

        If TextBox1.Text = TextBox3.Text And TextBox3.Text = TextBox1.Text Then
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            Timer4.Stop()
            If ListBox1.Items.Contains(TextBox1.Text) = True Then
                CheckBox2.Checked = True
            Else
                CheckBox2.Checked = False
            End If
            If ProgressBar1.Value = 100 Then
                TextBox4.Text = "Complete. The password is " & TextBox1.Text & "."
                MsgBox("Complete. The password is " & TextBox1.Text & ".")
                Timer1.Stop()
                Timer2.Stop()
                Timer3.Stop()
                Timer4.Stop()
                If Len(TextBox1.Text) < 4 Then
                    TextBox8.Text = "Very Weak"
                ElseIf Len(TextBox1.Text) < 8 Then
                    TextBox8.Text = "Weak"
                ElseIf Len(TextBox1.Text) = 8 Then
                    TextBox8.Text = "Good"
                ElseIf Len(TextBox1.Text) > 8 Then
                    TextBox8.Text = "Strong"
                ElseIf Len(TextBox1.Text) >= 14 Then
                    TextBox8.Text = "Very Strong"
                End If
            End If
        End If

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim n As New Random
        Dim int As Integer = n.Next(1, 578)
        TextBox3.Text = ListBox1.Items.Item(int)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
        Timer4.Start()
        ListBox1.Items.Add(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ProgressBar1.Value = 0
        ProgressBar2.Value = 0
        ProgressBar3.Value = 0
        ProgressBar4.Value = 0
        ProgressBar5.Value = 0
        ProgressBar6.Value = 0
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox13.Clear()
        TextBox1.Focus()
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()
        TextBox4.Text = "Idle."

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox1.UseSystemPasswordChar = False
        Else
            TextBox1.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        TextBox11.Text = TimeOfDay.Second

    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged
        ProgressBar5.Value += 1
        If ProgressBar5.Value = 59 Then
            ProgressBar4.Value += 1
            ProgressBar5.Value = 0
        Else
            ProgressBar5.Value += 0.5
        End If

        TextBox10.Text = ProgressBar5.Value.ToString & " s"
        TextBox9.Text = ProgressBar4.Value.ToString & " m"

    End Sub

    Private Sub ExportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToolStripMenuItem.Click
        Dim pass As New System.IO.StreamWriter("C:\Users\" & Environment.UserName & "\Documents\passwd.txt")
        pass.Write(TextBox8.Text)
        pass.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If ProgressBar1.Value < 100 Then
            TextBox4.Text = "Looking through " & (ListBox1.Items.Count + ProgressBar3.Value.ToString) & " possible passwords..."
        End If
    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        Timer1.Interval = 10 * TrackBar1.Value
    End Sub
End Class
