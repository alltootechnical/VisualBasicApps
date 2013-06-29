Public Class PaintForm
    Dim g As Graphics
    Dim startLocation As Point
    Dim endLocation As Point
    Dim TempLocation As New Point(-1, -1)
    Dim TempLocation2 As New Point(-1, -1)
    Dim NumberOfAngle As Integer = 0
    Dim drawing As Boolean = False
    Dim CurrentColor As Color = Color.Blue
    Dim CurrentColor2 As Color = Color.LightSkyBlue
    Dim LastImage As New Bitmap(501, 501)
    Dim M1 As New Bitmap(501, 501)
    Dim M2 As New Bitmap(501, 501)
    Dim M3 As New Bitmap(501, 501)
    Dim M4 As New Bitmap(501, 501)
    Dim PenWidth As Single = 1.0F
    Dim PenPoint As Pen
    Dim SavedFileAddress As String = ""
    Dim CurrentFont As Font

    Function FillRegion(ByVal X As Integer, ByVal Y As Integer, ByVal FillCol As Color) As Boolean
        If X < 0 Or X > LastImage.Width Or Y < 0 Or Y > LastImage.Height Then
            Return False

        End If

        Application.DoEvents()

        Dim points As Stack = New Stack
        points.Push(New Point(X, Y))

        Dim Pointcolor As Color = LastImage.GetPixel(X, Y)


        Do
            Dim p As Point = CType(points.Pop(), Point)

            LastImage.SetPixel(p.X, p.Y, FillCol)

            If UpPixelHaseSameColor(p.X, p.Y, Pointcolor) Then
                points.Push(New Point(p.X, p.Y - 1))
            End If

            If DownPixelHaseSameColor(p.X, p.Y, Pointcolor) Then
                points.Push(New Point(p.X, p.Y + 1))
            End If


            If RightPixelHaseSameColor(p.X, p.Y, Pointcolor) Then
                points.Push(New Point(p.X + 1, p.Y))
            End If

            If LeftPixelHaseSameColor(p.X, p.Y, Pointcolor) Then
                points.Push(New Point(p.X - 1, p.Y))
            End If

        Loop While points.Count > 0

        Return True

    End Function
    Function UpPixelHaseSameColor(ByVal X As Integer, ByVal Y As Integer, ByVal Col As Color) As Boolean
        Dim result As Boolean = False
        If (Y > 0) Then
            If (LastImage.GetPixel(X, Y - 1) = Col) Then
                result = True
            End If

        End If
        Return result

    End Function
    Function DownPixelHaseSameColor(ByVal X As Integer, ByVal Y As Integer, ByVal Col As Color) As Boolean
        Dim result As Boolean = False
        If (Y < LastImage.Height - 1) Then
            If (LastImage.GetPixel(X, Y + 1) = Col) Then
                result = True
            End If

        End If
        Return result

    End Function
    Function RightPixelHaseSameColor(ByVal X As Integer, ByVal Y As Integer, ByVal Col As Color) As Boolean
        Dim result As Boolean = False
        If (X < LastImage.Width - 1) Then
            If (LastImage.GetPixel(X + 1, Y) = Col) Then
                result = True
            End If

        End If

        Return result

    End Function
    Function LeftPixelHaseSameColor(ByVal X As Integer, ByVal Y As Integer, ByVal Col As Color) As Boolean

        Dim result As Boolean = False
        If (X > 0) Then
            If (LastImage.GetPixel(X - 1, Y) = Col) Then
                result = True
            End If
        End If


        Return result

    End Function
    Sub UpdateImage()

        g = Graphics.FromImage(LastImage)

        Me.PictureBox1.Image = LastImage

    End Sub
    Sub ReloadPen(ByVal PenWd As Single, ByVal CurColor As Color)
        PenPoint = New Pen(CurColor, PenWd)

    End Sub
    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown

    End Sub
    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If drawing = True Then
            If LineRadioButton.Checked Then
                g.DrawLine(PenPoint, startLocation.X, startLocation.Y, e.X, e.Y)
                startLocation = e.Location
                UpdateImage()

            ElseIf EraserRadioButton.Checked Then

                Dim p As New Pen(Color.White, PenWidth)

                g.DrawLine(p, startLocation.X, startLocation.Y, e.X, e.Y)
                startLocation = e.Location
                UpdateImage()

            End If

        End If
    End Sub
    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp

        If drawing Then

            If RectangleRadioButton.Checked Then

                endLocation = e.Location

                Dim s As Point

                s.X = endLocation.X - startLocation.X
                If s.X < 0 Then
                    startLocation.X = endLocation.X

                End If

                s.Y = endLocation.Y - startLocation.Y
                If s.Y < 0 Then
                    startLocation.Y = endLocation.Y

                End If

                s.X = Math.Abs(s.X)
                s.Y = Math.Abs(s.Y)
                g.DrawRectangle(PenPoint, New Rectangle(startLocation, s))

            ElseIf GradientRectAngleRadioButton.Checked Then

                endLocation = e.Location

                Dim s As Point


                If s.X < 0 Then
                    startLocation.X = endLocation.X
                ElseIf s.X = 0 Then
                    s.X = 1
                End If

                s.Y = endLocation.Y - startLocation.Y

                If s.Y < 0 Then
                    startLocation.Y = endLocation.Y
                ElseIf s.Y = 0 Then
                    s.Y = 1
                End If

                s.X = Math.Abs(s.X)
                s.Y = Math.Abs(s.Y)

                Dim b As Brush
                b = New Drawing2D.LinearGradientBrush(New Rectangle(startLocation, s), CurrentColor, CurrentColor2, Drawing2D.LinearGradientMode.BackwardDiagonal)
                g.FillRectangle(b, New Rectangle(startLocation, s))

            ElseIf CircleRadioButton.Checked Then

                endLocation = e.Location
                Dim s As Point

                s.X = endLocation.X - startLocation.X

                If s.X < 0 Then
                    startLocation.X = endLocation.X

                End If

                s.Y = endLocation.Y - startLocation.Y

                If s.Y < 0 Then
                    startLocation.Y = endLocation.Y

                End If

                s.X = Math.Abs(s.X)
                s.Y = Math.Abs(s.Y)

                If s.X > s.Y Then
                    s.Y = s.X
                Else
                    s.X = s.Y
                End If

                g.DrawEllipse(PenPoint, New Rectangle(startLocation, s))

            ElseIf ArcRadioButton.Checked Then
                endLocation = e.Location

                Dim s As Point

                s.X = endLocation.X - startLocation.X

                If s.X < 0 Then
                    startLocation.X = endLocation.X

                End If

                s.Y = endLocation.Y - startLocation.Y

                If s.Y < 0 Then
                    startLocation.Y = endLocation.Y

                End If

                s.X = Math.Abs(s.X)
                s.Y = Math.Abs(s.Y)

                If s.X > s.Y Then
                    s.Y = s.X
                Else
                    s.X = s.Y
                End If

                g.DrawArc(PenPoint, New Rectangle(startLocation, s), 0, -180)

            ElseIf ParallelepipedRadioButton.Checked Then

                endLocation = e.Location

                Dim s As Point

                s.X = endLocation.X - startLocation.X

                If s.X < 0 Then
                    Dim tmp As Integer = startLocation.X
                    startLocation.X = endLocation.X
                    endLocation.X = tmp
                End If

                s.Y = endLocation.Y - startLocation.Y

                If s.Y < 0 Then
                    Dim tmp As Integer = startLocation.Y
                    startLocation.Y = endLocation.Y
                    endLocation.Y = tmp
                End If

                s.X = Math.Abs(s.X)
                s.Y = Math.Abs(s.Y)



                Dim p(3) As Point

                p(0) = New Point(startLocation.X + s.X / 5, startLocation.Y)
                p(1) = New Point(startLocation.X + s.X, startLocation.Y)

                p(2) = New Point(endLocation.X - s.X / 5, endLocation.Y)
                p(3) = New Point(endLocation.X - s.X, endLocation.Y)

                g.DrawPolygon(PenPoint, p)

            ElseIf FillRadioButton.Checked Then
                FillRegion(e.X, e.Y, CurrentColor)

            ElseIf TextRadioButton.Checked Then
                Dim txt As String = Me.TextDrawTextBox.Text
                g.DrawString(txt, CurrentFont, New Drawing2D.HatchBrush(Drawing2D.HatchStyle.BackwardDiagonal, CurrentColor), e.X, e.Y)

            End If

        End If

        drawing = False

        UpdateImage()

    End Sub
    Private Sub PaintForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        CurrentFont = Me.Font
        FontButton.Text = CurrentFont.ToString

        Me.ColorButton.BackColor = Color.Blue
        Me.Color2Button.BackColor = Color.LightSkyBlue
        g = Graphics.FromImage(LastImage)
        g.Clear(Color.White)
        UpdateImage()
        ReloadPen(PenWidth, CurrentColor)


    End Sub
    Private Sub ColorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorButton.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            CurrentColor = ColorDialog1.Color
            Me.ColorButton.BackColor = CurrentColor
            ReloadPen(PenWidth, CurrentColor)
        End If



    End Sub
    Private Sub Color2Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Color2Button.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            CurrentColor2 = ColorDialog1.Color
            Me.Color2Button.BackColor = CurrentColor2
        End If
    End Sub
    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        ClearScreen()
    End Sub
    Sub ClearScreen()
        'LastImage = New Bitmap(501, 501)
        g = Graphics.FromImage(LastImage)
        g.Clear(Color.White)
        UpdateImage()
    End Sub
    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        If SavedFileAddress = "" Then
            SaveFileDialog1.Filter = "Bitmap File (*.bmp)|*.bmp"
            If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                SavedFileAddress = SaveFileDialog1.FileName



                LastImage.Save(SavedFileAddress)
                Me.Text = SaveFileDialog1.FileName
            End If

        Else
            LastImage.Save(SavedFileAddress)
            Me.Text = SaveFileDialog1.FileName
        End If



    End Sub
    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        SaveFileDialog1.Filter = "Bitmap File (*.bmp)|*.bmp"
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            SavedFileAddress = SaveFileDialog1.FileName

            LastImage.Save(SavedFileAddress)
            Me.Text = SaveFileDialog1.FileName
        End If
    End Sub
    Private Sub TriangleRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TriangleRadioButton.CheckedChanged
        TempLocation = New Point(-1, -1)
    End Sub
    Private Sub P1RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P1RadioButton.CheckedChanged
        PenWidth = 1.0F
        ReloadPen(PenWidth, CurrentColor)

    End Sub
    Private Sub P2RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P2RadioButton.CheckedChanged
        PenWidth = 5.0F
        ReloadPen(PenWidth, CurrentColor)
    End Sub
    Private Sub P3RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P3RadioButton.CheckedChanged
        PenWidth = 10.0F
        ReloadPen(PenWidth, CurrentColor)
    End Sub
    Private Sub M1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M1ToolStripMenuItem.Click
        M1 = LastImage.Clone()
    End Sub
    Private Sub M2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M2ToolStripMenuItem.Click
        M2 = LastImage.Clone()
    End Sub
    Private Sub M3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M3ToolStripMenuItem.Click
        M3 = LastImage.Clone()
    End Sub
    Private Sub M4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M4ToolStripMenuItem.Click
        M4 = LastImage.Clone()
    End Sub
    Private Sub S1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S1ToolStripMenuItem.Click
        LastImage = M1.Clone
        UpdateImage()
    End Sub
    Private Sub S2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S2ToolStripMenuItem.Click
        LastImage = M2.Clone
        UpdateImage()
    End Sub
    Private Sub S3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S3ToolStripMenuItem.Click
        LastImage = M3.Clone
        UpdateImage()
    End Sub
    Private Sub S4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S4ToolStripMenuItem.Click
        LastImage = M4.Clone
        UpdateImage()
    End Sub
    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        If SavedFileAddress = "" Then
            Dim result As Integer = MsgBox("Would you like to save this picture", MsgBoxStyle.YesNo)
            If result = MsgBoxResult.Yes Then
                SaveFileDialog1.Filter = "Bitmap File (*.bmp)|*.bmp"
                If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    SavedFileAddress = SaveFileDialog1.FileName

                    LastImage.Save(SavedFileAddress)
                    Me.Text = SaveFileDialog1.FileName
                End If
            End If
        End If
        g.Clear(Color.White)
        UpdateImage()
        SavedFileAddress = ""
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If SavedFileAddress = "" Then
            Dim result As Integer = MsgBox("Would you like to save the image before exiting?", MsgBoxStyle.YesNoCancel)
            If result = MsgBoxResult.Yes Then
                SaveFileDialog1.Filter = "Bitmap File (*.bmp)|*.bmp"
                If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    SavedFileAddress = SaveFileDialog1.FileName
                    LastImage.Save(SavedFileAddress)
                    Me.Text = SaveFileDialog1.FileName
                End If

            ElseIf result = MsgBoxResult.No Then
                End
            End If
        End If
    End Sub
    Private Sub TextRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextRadioButton.CheckedChanged
        If Me.TextRadioButton.Checked = True Then
            Me.TextDrawTextBox.Visible = True
            FontButton.Visible = True
        Else
            Me.TextDrawTextBox.Visible = False
            FontButton.Visible = False
        End If
    End Sub
    Private Sub FontButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontButton.Click
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            CurrentFont = FontDialog1.Font
            FontButton.Text = CurrentFont.ToString
        End If
    End Sub
    Private Sub MessageLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class