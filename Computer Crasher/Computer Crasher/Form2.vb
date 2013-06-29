Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim color As New Random
        Dim text As New Random
        Me.Text = Label1.Text
        
        Select Case color.Next(1, 9)
            Case 1
                Me.BackColor = Drawing.Color.White
                Label1.ForeColor = Drawing.Color.Black
            Case 2
                Me.BackColor = Drawing.Color.Red
                Label1.ForeColor = Drawing.Color.Violet
            Case 3
                Me.BackColor = Drawing.Color.Orange
                Label1.ForeColor = Drawing.Color.Blue
            Case 4
                Me.BackColor = Drawing.Color.Yellow
                Label1.ForeColor = Drawing.Color.Green
            Case 5
                Me.BackColor = Drawing.Color.Green
                Label1.ForeColor = Drawing.Color.Yellow
            Case 6
                Me.BackColor = Drawing.Color.Blue
                Label1.ForeColor = Drawing.Color.Orange
            Case 7
                Me.BackColor = Drawing.Color.Violet
                Label1.ForeColor = Drawing.Color.Red
            Case 8
                Me.BackColor = Drawing.Color.Black
                Label1.ForeColor = Drawing.Color.White
        End Select
        Select Case text.Next(1, 11)
            Case 1
                Label1.Text = "Virus!!!"
            Case 2
                Label1.Text = "Trojan!!!"
            Case 3
                Label1.Text = "Worm!!!"
            Case 4
                Label1.Text = "Spyware!!!"
            Case 5
                Label1.Text = "PUPs!!!"
            Case 6
                Label1.Text = "Adware!!!"
            Case 7
                Label1.Text = "Trackware!!!"
            Case 8
                Label1.Text = "Malware!!!"
            Case 9
                Label1.Text = "Hacker!!!"
            Case 10
                Label1.Text = "You're Idiot!!!"
        End Select
    End Sub

    Private Sub Form2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Me.Close()
        black.Close()
        Form3.Close()
        Form4.Show()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Me.Left = MousePosition.X
        Me.Top = MousePosition.Y
    End Sub
End Class