<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaintForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Color2Button = New System.Windows.Forms.Button
        Me.FontButton = New System.Windows.Forms.Button
        Me.TextDrawTextBox = New System.Windows.Forms.TextBox
        Me.PenWidthGroupBox = New System.Windows.Forms.GroupBox
        Me.P3RadioButton = New System.Windows.Forms.RadioButton
        Me.P2RadioButton = New System.Windows.Forms.RadioButton
        Me.P1RadioButton = New System.Windows.Forms.RadioButton
        Me.ShapeGroupBox = New System.Windows.Forms.GroupBox
        Me.EraserRadioButton = New System.Windows.Forms.RadioButton
        Me.ParallelepipedRadioButton = New System.Windows.Forms.RadioButton
        Me.TextRadioButton = New System.Windows.Forms.RadioButton
        Me.FillRadioButton = New System.Windows.Forms.RadioButton
        Me.GradientRectAngleRadioButton = New System.Windows.Forms.RadioButton
        Me.RectangleRadioButton = New System.Windows.Forms.RadioButton
        Me.MultiAngleRadioButton = New System.Windows.Forms.RadioButton
        Me.TriangleRadioButton = New System.Windows.Forms.RadioButton
        Me.ArcRadioButton = New System.Windows.Forms.RadioButton
        Me.CircleRadioButton = New System.Windows.Forms.RadioButton
        Me.LineRadioButton = New System.Windows.Forms.RadioButton
        Me.ColorButton = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.M1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.M2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.M3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.M4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.S1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.S2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.S3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.S4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PenWidthGroupBox.SuspendLayout()
        Me.ShapeGroupBox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Color2Button
        '
        Me.Color2Button.FlatAppearance.BorderSize = 0
        Me.Color2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Color2Button.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Color2Button.Location = New System.Drawing.Point(77, 36)
        Me.Color2Button.Name = "Color2Button"
        Me.Color2Button.Size = New System.Drawing.Size(70, 51)
        Me.Color2Button.TabIndex = 24
        Me.Color2Button.Text = "Color2"
        Me.Color2Button.UseVisualStyleBackColor = True
        '
        'FontButton
        '
        Me.FontButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FontButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FontButton.Location = New System.Drawing.Point(153, 37)
        Me.FontButton.Name = "FontButton"
        Me.FontButton.Size = New System.Drawing.Size(248, 52)
        Me.FontButton.TabIndex = 23
        Me.FontButton.Text = "Font"
        Me.FontButton.UseVisualStyleBackColor = True
        Me.FontButton.Visible = False
        '
        'TextDrawTextBox
        '
        Me.TextDrawTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextDrawTextBox.Location = New System.Drawing.Point(6, 475)
        Me.TextDrawTextBox.Multiline = True
        Me.TextDrawTextBox.Name = "TextDrawTextBox"
        Me.TextDrawTextBox.Size = New System.Drawing.Size(104, 68)
        Me.TextDrawTextBox.TabIndex = 22
        Me.TextDrawTextBox.Text = "Insert text here"
        Me.TextDrawTextBox.Visible = False
        '
        'PenWidthGroupBox
        '
        Me.PenWidthGroupBox.Controls.Add(Me.P3RadioButton)
        Me.PenWidthGroupBox.Controls.Add(Me.P2RadioButton)
        Me.PenWidthGroupBox.Controls.Add(Me.P1RadioButton)
        Me.PenWidthGroupBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PenWidthGroupBox.Location = New System.Drawing.Point(6, 376)
        Me.PenWidthGroupBox.Name = "PenWidthGroupBox"
        Me.PenWidthGroupBox.Size = New System.Drawing.Size(131, 93)
        Me.PenWidthGroupBox.TabIndex = 19
        Me.PenWidthGroupBox.TabStop = False
        Me.PenWidthGroupBox.Text = "Pens"
        '
        'P3RadioButton
        '
        Me.P3RadioButton.AutoSize = True
        Me.P3RadioButton.Location = New System.Drawing.Point(7, 67)
        Me.P3RadioButton.Name = "P3RadioButton"
        Me.P3RadioButton.Size = New System.Drawing.Size(54, 19)
        Me.P3RadioButton.TabIndex = 2
        Me.P3RadioButton.Text = "Pen 3"
        Me.P3RadioButton.UseVisualStyleBackColor = True
        '
        'P2RadioButton
        '
        Me.P2RadioButton.AutoSize = True
        Me.P2RadioButton.Location = New System.Drawing.Point(7, 44)
        Me.P2RadioButton.Name = "P2RadioButton"
        Me.P2RadioButton.Size = New System.Drawing.Size(54, 19)
        Me.P2RadioButton.TabIndex = 1
        Me.P2RadioButton.Text = "Pen 2"
        Me.P2RadioButton.UseVisualStyleBackColor = True
        '
        'P1RadioButton
        '
        Me.P1RadioButton.AutoSize = True
        Me.P1RadioButton.Checked = True
        Me.P1RadioButton.Location = New System.Drawing.Point(7, 21)
        Me.P1RadioButton.Name = "P1RadioButton"
        Me.P1RadioButton.Size = New System.Drawing.Size(54, 19)
        Me.P1RadioButton.TabIndex = 0
        Me.P1RadioButton.TabStop = True
        Me.P1RadioButton.Text = "Pen 1"
        Me.P1RadioButton.UseVisualStyleBackColor = True
        '
        'ShapeGroupBox
        '
        Me.ShapeGroupBox.Controls.Add(Me.EraserRadioButton)
        Me.ShapeGroupBox.Controls.Add(Me.ParallelepipedRadioButton)
        Me.ShapeGroupBox.Controls.Add(Me.TextRadioButton)
        Me.ShapeGroupBox.Controls.Add(Me.FillRadioButton)
        Me.ShapeGroupBox.Controls.Add(Me.GradientRectAngleRadioButton)
        Me.ShapeGroupBox.Controls.Add(Me.RectangleRadioButton)
        Me.ShapeGroupBox.Controls.Add(Me.MultiAngleRadioButton)
        Me.ShapeGroupBox.Controls.Add(Me.TriangleRadioButton)
        Me.ShapeGroupBox.Controls.Add(Me.ArcRadioButton)
        Me.ShapeGroupBox.Controls.Add(Me.CircleRadioButton)
        Me.ShapeGroupBox.Controls.Add(Me.LineRadioButton)
        Me.ShapeGroupBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShapeGroupBox.Location = New System.Drawing.Point(6, 94)
        Me.ShapeGroupBox.Name = "ShapeGroupBox"
        Me.ShapeGroupBox.Size = New System.Drawing.Size(141, 276)
        Me.ShapeGroupBox.TabIndex = 17
        Me.ShapeGroupBox.TabStop = False
        Me.ShapeGroupBox.Text = "Shape"
        '
        'EraserRadioButton
        '
        Me.EraserRadioButton.AutoSize = True
        Me.EraserRadioButton.Location = New System.Drawing.Point(7, 19)
        Me.EraserRadioButton.Name = "EraserRadioButton"
        Me.EraserRadioButton.Size = New System.Drawing.Size(56, 19)
        Me.EraserRadioButton.TabIndex = 0
        Me.EraserRadioButton.Text = "Eraser"
        Me.EraserRadioButton.UseVisualStyleBackColor = True
        '
        'ParallelepipedRadioButton
        '
        Me.ParallelepipedRadioButton.AutoSize = True
        Me.ParallelepipedRadioButton.Location = New System.Drawing.Point(7, 216)
        Me.ParallelepipedRadioButton.Name = "ParallelepipedRadioButton"
        Me.ParallelepipedRadioButton.Size = New System.Drawing.Size(99, 19)
        Me.ParallelepipedRadioButton.TabIndex = 10
        Me.ParallelepipedRadioButton.Text = "Parallelepiped"
        Me.ParallelepipedRadioButton.UseVisualStyleBackColor = True
        '
        'TextRadioButton
        '
        Me.TextRadioButton.AutoSize = True
        Me.TextRadioButton.Location = New System.Drawing.Point(6, 239)
        Me.TextRadioButton.Name = "TextRadioButton"
        Me.TextRadioButton.Size = New System.Drawing.Size(47, 19)
        Me.TextRadioButton.TabIndex = 9
        Me.TextRadioButton.Text = "Text"
        Me.TextRadioButton.UseVisualStyleBackColor = True
        '
        'FillRadioButton
        '
        Me.FillRadioButton.AutoSize = True
        Me.FillRadioButton.Location = New System.Drawing.Point(7, 195)
        Me.FillRadioButton.Name = "FillRadioButton"
        Me.FillRadioButton.Size = New System.Drawing.Size(40, 19)
        Me.FillRadioButton.TabIndex = 8
        Me.FillRadioButton.Text = "Fill"
        Me.FillRadioButton.UseVisualStyleBackColor = True
        '
        'GradientRectAngleRadioButton
        '
        Me.GradientRectAngleRadioButton.AutoSize = True
        Me.GradientRectAngleRadioButton.Location = New System.Drawing.Point(7, 82)
        Me.GradientRectAngleRadioButton.Name = "GradientRectAngleRadioButton"
        Me.GradientRectAngleRadioButton.Size = New System.Drawing.Size(122, 19)
        Me.GradientRectAngleRadioButton.TabIndex = 3
        Me.GradientRectAngleRadioButton.Text = "GradientRectangle"
        Me.GradientRectAngleRadioButton.UseVisualStyleBackColor = True
        '
        'RectangleRadioButton
        '
        Me.RectangleRadioButton.AutoSize = True
        Me.RectangleRadioButton.Location = New System.Drawing.Point(7, 61)
        Me.RectangleRadioButton.Name = "RectangleRadioButton"
        Me.RectangleRadioButton.Size = New System.Drawing.Size(77, 19)
        Me.RectangleRadioButton.TabIndex = 2
        Me.RectangleRadioButton.Text = "Rectangle"
        Me.RectangleRadioButton.UseVisualStyleBackColor = True
        '
        'MultiAngleRadioButton
        '
        Me.MultiAngleRadioButton.AutoSize = True
        Me.MultiAngleRadioButton.Location = New System.Drawing.Point(7, 172)
        Me.MultiAngleRadioButton.Name = "MultiAngleRadioButton"
        Me.MultiAngleRadioButton.Size = New System.Drawing.Size(84, 19)
        Me.MultiAngleRadioButton.TabIndex = 7
        Me.MultiAngleRadioButton.Text = "MultiAngle"
        Me.MultiAngleRadioButton.UseVisualStyleBackColor = True
        '
        'TriangleRadioButton
        '
        Me.TriangleRadioButton.AutoSize = True
        Me.TriangleRadioButton.Location = New System.Drawing.Point(7, 103)
        Me.TriangleRadioButton.Name = "TriangleRadioButton"
        Me.TriangleRadioButton.Size = New System.Drawing.Size(68, 19)
        Me.TriangleRadioButton.TabIndex = 4
        Me.TriangleRadioButton.Text = "Triangle"
        Me.TriangleRadioButton.UseVisualStyleBackColor = True
        '
        'ArcRadioButton
        '
        Me.ArcRadioButton.AutoSize = True
        Me.ArcRadioButton.Location = New System.Drawing.Point(7, 149)
        Me.ArcRadioButton.Name = "ArcRadioButton"
        Me.ArcRadioButton.Size = New System.Drawing.Size(43, 19)
        Me.ArcRadioButton.TabIndex = 6
        Me.ArcRadioButton.Text = "Arc"
        Me.ArcRadioButton.UseVisualStyleBackColor = True
        '
        'CircleRadioButton
        '
        Me.CircleRadioButton.AutoSize = True
        Me.CircleRadioButton.Location = New System.Drawing.Point(7, 126)
        Me.CircleRadioButton.Name = "CircleRadioButton"
        Me.CircleRadioButton.Size = New System.Drawing.Size(55, 19)
        Me.CircleRadioButton.TabIndex = 5
        Me.CircleRadioButton.Text = "Circle"
        Me.CircleRadioButton.UseVisualStyleBackColor = True
        '
        'LineRadioButton
        '
        Me.LineRadioButton.AutoSize = True
        Me.LineRadioButton.Checked = True
        Me.LineRadioButton.Location = New System.Drawing.Point(7, 38)
        Me.LineRadioButton.Name = "LineRadioButton"
        Me.LineRadioButton.Size = New System.Drawing.Size(47, 19)
        Me.LineRadioButton.TabIndex = 1
        Me.LineRadioButton.TabStop = True
        Me.LineRadioButton.Text = "Line"
        Me.LineRadioButton.UseVisualStyleBackColor = True
        '
        'ColorButton
        '
        Me.ColorButton.FlatAppearance.BorderSize = 0
        Me.ColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ColorButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorButton.Location = New System.Drawing.Point(-1, 36)
        Me.ColorButton.Name = "ColorButton"
        Me.ColorButton.Size = New System.Drawing.Size(70, 51)
        Me.ColorButton.TabIndex = 20
        Me.ColorButton.Text = "Color"
        Me.ColorButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(181, 94)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(501, 501)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ImageToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(722, 24)
        Me.MenuStrip1.TabIndex = 25
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.NewToolStripMenuItem, Me.ToolStripMenuItem2, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(111, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(111, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ImageToolStripMenuItem
        '
        Me.ImageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.M1ToolStripMenuItem, Me.M2ToolStripMenuItem, Me.M3ToolStripMenuItem, Me.M4ToolStripMenuItem, Me.ToolStripMenuItem3, Me.S1ToolStripMenuItem, Me.S2ToolStripMenuItem, Me.S3ToolStripMenuItem, Me.S4ToolStripMenuItem})
        Me.ImageToolStripMenuItem.Name = "ImageToolStripMenuItem"
        Me.ImageToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.ImageToolStripMenuItem.Text = "Image"
        '
        'M1ToolStripMenuItem
        '
        Me.M1ToolStripMenuItem.Name = "M1ToolStripMenuItem"
        Me.M1ToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.M1ToolStripMenuItem.Text = "M1"
        '
        'M2ToolStripMenuItem
        '
        Me.M2ToolStripMenuItem.Name = "M2ToolStripMenuItem"
        Me.M2ToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.M2ToolStripMenuItem.Text = "M2"
        '
        'M3ToolStripMenuItem
        '
        Me.M3ToolStripMenuItem.Name = "M3ToolStripMenuItem"
        Me.M3ToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.M3ToolStripMenuItem.Text = "M3"
        '
        'M4ToolStripMenuItem
        '
        Me.M4ToolStripMenuItem.Name = "M4ToolStripMenuItem"
        Me.M4ToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.M4ToolStripMenuItem.Text = "M4"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(88, 6)
        '
        'S1ToolStripMenuItem
        '
        Me.S1ToolStripMenuItem.Name = "S1ToolStripMenuItem"
        Me.S1ToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.S1ToolStripMenuItem.Text = "S1"
        '
        'S2ToolStripMenuItem
        '
        Me.S2ToolStripMenuItem.Name = "S2ToolStripMenuItem"
        Me.S2ToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.S2ToolStripMenuItem.Text = "S2"
        '
        'S3ToolStripMenuItem
        '
        Me.S3ToolStripMenuItem.Name = "S3ToolStripMenuItem"
        Me.S3ToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.S3ToolStripMenuItem.Text = "S3"
        '
        'S4ToolStripMenuItem
        '
        Me.S4ToolStripMenuItem.Name = "S4ToolStripMenuItem"
        Me.S4ToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.S4ToolStripMenuItem.Text = "S4"
        '
        'PaintForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 648)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Color2Button)
        Me.Controls.Add(Me.FontButton)
        Me.Controls.Add(Me.TextDrawTextBox)
        Me.Controls.Add(Me.PenWidthGroupBox)
        Me.Controls.Add(Me.ShapeGroupBox)
        Me.Controls.Add(Me.ColorButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "PaintForm"
        Me.Text = "PaintForm"
        Me.PenWidthGroupBox.ResumeLayout(False)
        Me.PenWidthGroupBox.PerformLayout()
        Me.ShapeGroupBox.ResumeLayout(False)
        Me.ShapeGroupBox.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Color2Button As System.Windows.Forms.Button
    Friend WithEvents FontButton As System.Windows.Forms.Button
    Friend WithEvents TextDrawTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PenWidthGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents P3RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents P2RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents P1RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ShapeGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents EraserRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ParallelepipedRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents TextRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents FillRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GradientRectAngleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents RectangleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents MultiAngleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents TriangleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ArcRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CircleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents LineRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ColorButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents S1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents S2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents S3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents S4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
