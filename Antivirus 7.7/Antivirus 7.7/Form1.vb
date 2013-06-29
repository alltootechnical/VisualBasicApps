Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
        Timer4.Start()
        Timer5.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim m As New Random
        Dim p As New Random
        Dim r As New Random
        Dim n As Int32 = m.Next(1, 10)
        Dim q As Int32 = p.Next(62, 98)
        Dim s As Int32 = r.Next(11, 45)
        If ProgressBar1.Value = 25 Then
            Timer2.Interval = 100 * n
        ElseIf ProgressBar1.Value = 50 Then
            Timer2.Interval = 50 * n
        ElseIf ProgressBar1.Value = 75 Then
            Timer2.Interval = 10 * n
        End If
        If CheckedListBox1.Items.Count <= 17 And ProgressBar1.Value = s Then
            ProgressBar1.Value = q
        ElseIf CheckedListBox1.Items.Count <= 30 And ProgressBar1.Value = s Then
            ProgressBar1.Value = q
        ElseIf CheckedListBox1.Items.Count <= 75 And ProgressBar1.Value = s Then
            ProgressBar1.Value = q
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim m As New Random
        Dim n As Int32 = m.Next(1, 1566)
        Dim t As String = ListBox2.Items.Item(n)
        If Len(t) <= 5 Then
            CheckedListBox1.Items.Add(t & " - Very Low")
            TextBox2.Text += 1
        ElseIf Len(t) <= 7 Then
            CheckedListBox1.Items.Add(t & " - Low")
            TextBox3.Text += 1
        ElseIf Len(t) = 8 Then
            CheckedListBox1.Items.Add(t & " - Medium")
            TextBox4.Text += 1
        ElseIf Len(t) = 9 Then
            CheckedListBox1.Items.Add(t & " - High")
            TextBox5.Text += 1
        ElseIf Len(t) = 10 Then
            CheckedListBox1.Items.Add(t & " - Very High")
            TextBox6.Text += 1
        ElseIf Len(t) > 12 Then
            CheckedListBox1.Items.Add(t & " - Critical")
            TextBox7.Text += 1
        End If
        Timer6.Start()
        Label7.Text = TextBox7.Text & " critical, " & TextBox6.Text & " very high, " & TextBox5.Text &" high, " & TextBox4.Text & " medium, " & TextBox3.Text & " low, " & TextBox2.Text & " very low"
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Label5.Text = CheckedListBox1.CheckedItems.Count & " selected."
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub QuickToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuickToolStripMenuItem.Click
        Button1.PerformClick()
        Label2.Text = "Quick Scan"
        If ProgressBar1.Value = 23 Then
            ProgressBar1.Value = 77
        End If
    End Sub

    Private Sub FullToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FullToolStripMenuItem.Click
        Button1.PerformClick()
        Label2.Text = "Full System Scan"
        If ProgressBar1.Value = 32 Then
            ProgressBar1.Value = 77
        End If
    End Sub

    Private Sub QuarantineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuarantineToolStripMenuItem.Click
        Form2.ListBox1.Items.Add(CheckedListBox1.CheckedItems.Count)
    End Sub

    Private Sub VirusVaultToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VirusVaultToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub PauseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PauseToolStripMenuItem.Click
        ProgressBar1.Value += 0
        Timer5.Stop()
        Timer1.Stop()
    End Sub

    Private Sub StopScanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopScanToolStripMenuItem.Click
        ProgressBar1.Value = 0
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        CheckedListBox1.Items.Clear()
    End Sub

    Private Sub ThreatDatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThreatDatabaseToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        MsgBox("Files successfully deleted!", MsgBoxStyle.Information)

    End Sub

    Private Sub MoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveToolStripMenuItem.Click
        MsgBox("Files successfully moved!", MsgBoxStyle.Information)
    End Sub

    Private Sub HealToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HealToolStripMenuItem.Click
        MsgBox("Threats successfully healed!", MsgBoxStyle.Information)
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        TextBox1.Text += 17
        Label6.Text = TextBox1.Text & " scanned, " & CheckedListBox1.Items.Count & " infected"
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        ProgressBar1.Value += 1
        Label4.Text = ProgressBar1.Value.ToString & "% Complete"
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            Timer2.Stop()
            Timer4.Stop()
            Timer5.Stop()
            Timer6.Stop()
            ProgressBar1.Value = 0

        End If

    End Sub

    Private Sub RegisterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub AToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AToolStripMenuItem.Click

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("You're using the latest version!", MsgBoxStyle.Information)
    End Sub

    Private Sub RemoteScanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoteScanToolStripMenuItem.Click
        Form6.Show()
        Label2.Text = "Remote Computer Scan"
    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        CheckedListBox1.SelectedIndex = CheckedListBox1.SelectedIndex + 1
        If CheckedListBox1.SelectedIndex = CheckedListBox1.Items.Count - 20 Then
            Timer6.Stop()
            CheckedListBox1.SelectedIndex = CheckedListBox1.SelectedIndex
        Else
            Timer6.Start()
        End If
    End Sub

    Private Sub AbortToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbortToolStripMenuItem.Click
        MsgBox("Connection aborted!", MsgBoxStyle.Information)
    End Sub
End Class
