Public Class Form1

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = 1
        Timer1.Start()
        Timer2.Start()
    End Sub
    Public Function Rand(ByVal Low As Long, ByVal High As Long) As Long
        Rand = Int((High - Low + 1) * Rnd) + Low
    End Function

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        End
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim frm As New Form1
        frm.Show()
        Dim img As String
        Dim ima As New Random
        Dim x As New Random
        Dim y As New Random
        img = ima.Next(73, 106)
        Dim loc As New System.Drawing.Point(x.Next(1, 1200 - Me.Width), y.Next(1, 800 - Me.Height))
        Dim imgpath As String = "C:\Users\Brian Guadalupe\Pictures\Ads and counting\" & img & ".png"
        PictureBox1.ImageLocation = imgpath
        frm.Top = Rand(1, 800 - Me.Height)
        frm.Left = Rand(1, 1200 - Me.Width)
        Me.Top = Rand(1, 800 - Me.Height)
        Me.Left = Rand(1, 1200 - Me.Width)
        Me.Location = loc

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim img As String
        Dim ima As New Random
        img = ima.Next(73, 106)
        Dim imgpath As String = "C:\Users\Brian Guadalupe\Pictures\Ads and counting\" & img & ".png"
        PictureBox1.ImageLocation = imgpath

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer2.Start()
    End Sub

    Private Sub Form1_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dim frm As New Form1
        frm.Show()
        Dim img As String
        Dim ima As New Random
        Dim x As New Random
        Dim y As New Random
        img = ima.Next(73, 106)
        Dim imgpath As String = "C:\Users\Brian Guadalupe\Pictures\Ads and counting\" & img & ".png"
        PictureBox1.ImageLocation = imgpath
        frm.Top = Rand(1, 800 - Me.Height)
        frm.Left = Rand(1, 1200 - Me.Width)
        Me.Top = Rand(1, 800 - Me.Height)
        Me.Left = Rand(1, 1200 - Me.Width)
    End Sub
End Class
