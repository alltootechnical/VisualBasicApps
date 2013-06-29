Public Class FrmMain
    Dim xStart, yStart, xEnd, yEnd As Integer
    Dim Drawbitmap As Bitmap
    Dim Drawgraphics As Graphics
    Dim myPen As New Pen(Color.BlueViolet, 3)
    Dim myColor As Color = Color.Blue
    Dim myBrush As New Drawing.SolidBrush(Color.Red)
    Dim myBrushWidth As Integer
    Dim ContinuousFlag As Boolean

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Drawbitmap = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        Drawgraphics = Graphics.FromImage(Drawbitmap)
        PictureBox1.Image = Drawbitmap
        Drawgraphics.Clear(Color.White)
        myBrushWidth = 4
    End Sub

    Private Sub drawMyline()
        Try
            PictureBox1.Image = Drawbitmap
            Drawgraphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            Drawgraphics.DrawLine(myPen, xStart, yStart, xEnd, yEnd)
        Catch ex As Exception : End Try
    End Sub

    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        Try
            xStart = Control.MousePosition.X - (Me.Left + PictureBox1.Left + 4)
            yStart = Control.MousePosition.Y - (Me.Top + PictureBox1.Top + 31)
            If RadioButton1.Checked = True Then
                ContinuousFlag = True
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        Try
            If ContinuousFlag Then
                Drawgraphics.SmoothingMode = Drawing2D.SmoothingMode.None
                Drawgraphics.FillEllipse(myBrush, e.X, e.Y, myBrushWidth, myBrushWidth)
                PictureBox1.Image = Drawbitmap
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        Try
            xEnd = Control.MousePosition.X - (Me.Left + PictureBox1.Left + 4)
            yEnd = Control.MousePosition.Y - (Me.Top + PictureBox1.Top + 31)

            If RadioButton1.Checked Then
                ContinuousFlag = False
            Else
                drawMyline()
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub exitbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitbutton.Click
        End
    End Sub

    Private Sub clearbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearbutton.Click
        Try
            Drawbitmap = New Bitmap(PictureBox1.Width, PictureBox1.Height)
            Drawgraphics = Graphics.FromImage(Drawbitmap)
            PictureBox1.Image = Drawbitmap
            Drawgraphics.Clear(Color.White)
        Catch ex As Exception : End Try
    End Sub

    Private Sub savebutton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles savebutton.Click
        Dim dlg As SaveFileDialog = New SaveFileDialog()
        Try
            dlg.Title = "Save"
            dlg.Filter = "Bitmap Image (*.bmp)|*.bmp |All Files |*.*"
            If dlg.ShowDialog() = DialogResult.OK Then
                PictureBox1.Image.Save(dlg.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        myPen.Width = 1
        myBrushWidth = 2
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        myPen.Width = 3
        myBrushWidth = 4
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        myPen.Width = 6
        myBrushWidth = 7
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        myPen.Width = 10
        myBrushWidth = 12
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        myPen.Width = 15
        myBrushWidth = 17
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        myPen.Color = Color.Navy
        myBrush.Color = Color.Navy
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        myPen.Color = Color.Red
        myBrush.Color = Color.Red
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        myPen.Color = Color.Green
        myBrush.Color = Color.Green
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        myPen.Color = Color.Yellow
        myBrush.Color = Color.Yellow
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        myPen.Color = Color.OrangeRed
        myBrush.Color = Color.OrangeRed
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        myPen.Color = Color.Purple
        myBrush.Color = Color.Purple
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        myPen.Color = Color.Black
        myBrush.Color = Color.Black
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        myPen.Color = Color.White
        myPen.Color = Color.White
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        myPen.Color = Color.Gray
        myBrush.Color = Color.Gray
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        myPen.Color = Color.BlueViolet
        myBrush.Color = Color.Red
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Try
            Dim dlg As ColorDialog = New ColorDialog
            dlg.Color = myBrush.Color
            dlg.ShowDialog()
            myBrush.Color = dlg.Color
            myPen.Color = dlg.Color
        Catch ex As Exception : End Try
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        FrmAbout.ShowDialog()
    End Sub
End Class


