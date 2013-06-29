<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Automatic = New System.Windows.Forms.CheckBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Month_A = New System.Windows.Forms.TextBox
        Me.Day_A = New System.Windows.Forms.TextBox
        Me.Year_A = New System.Windows.Forms.TextBox
        Me.Hour_A = New System.Windows.Forms.TextBox
        Me.Min_A = New System.Windows.Forms.TextBox
        Me.Sec_A = New System.Windows.Forms.TextBox
        Me.MS_A = New System.Windows.Forms.TextBox
        Me.Month_B = New System.Windows.Forms.TextBox
        Me.Day_B = New System.Windows.Forms.TextBox
        Me.Year_B = New System.Windows.Forms.TextBox
        Me.Hour_B = New System.Windows.Forms.TextBox
        Me.Min_B = New System.Windows.Forms.TextBox
        Me.Sec_B = New System.Windows.Forms.TextBox
        Me.MS_B = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(7, 379)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(150, 379)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Stop"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(88, 383)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Idle"
        '
        'Timer1
        '
        '
        'Automatic
        '
        Me.Automatic.AutoSize = True
        Me.Automatic.Checked = True
        Me.Automatic.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Automatic.Location = New System.Drawing.Point(157, 22)
        Me.Automatic.Name = "Automatic"
        Me.Automatic.Size = New System.Drawing.Size(52, 19)
        Me.Automatic.TabIndex = 3
        Me.Automatic.Text = "Auto"
        Me.Automatic.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(83, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(113, 23)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "0"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(83, 46)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(113, 23)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Text = "0"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(83, 72)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(113, 23)
        Me.TextBox3.TabIndex = 4
        Me.TextBox3.Text = "0"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(83, 98)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(113, 23)
        Me.TextBox4.TabIndex = 4
        Me.TextBox4.Text = "0"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(83, 124)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(113, 23)
        Me.TextBox5.TabIndex = 4
        Me.TextBox5.Text = "0"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(83, 150)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(113, 23)
        Me.TextBox6.TabIndex = 4
        Me.TextBox6.Text = "0"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Years"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Days"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Hours"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Minutes"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 15)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Seconds"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "1/1000 Sec"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 186)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(215, 182)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Total"
        '
        'Month_A
        '
        Me.Month_A.Location = New System.Drawing.Point(23, 18)
        Me.Month_A.Name = "Month_A"
        Me.Month_A.Size = New System.Drawing.Size(39, 23)
        Me.Month_A.TabIndex = 9
        '
        'Day_A
        '
        Me.Day_A.Location = New System.Drawing.Point(68, 18)
        Me.Day_A.Name = "Day_A"
        Me.Day_A.Size = New System.Drawing.Size(39, 23)
        Me.Day_A.TabIndex = 9
        '
        'Year_A
        '
        Me.Year_A.Location = New System.Drawing.Point(112, 18)
        Me.Year_A.Name = "Year_A"
        Me.Year_A.Size = New System.Drawing.Size(39, 23)
        Me.Year_A.TabIndex = 9
        '
        'Hour_A
        '
        Me.Hour_A.Location = New System.Drawing.Point(23, 44)
        Me.Hour_A.Name = "Hour_A"
        Me.Hour_A.Size = New System.Drawing.Size(39, 23)
        Me.Hour_A.TabIndex = 9
        '
        'Min_A
        '
        Me.Min_A.Location = New System.Drawing.Point(68, 44)
        Me.Min_A.Name = "Min_A"
        Me.Min_A.Size = New System.Drawing.Size(39, 23)
        Me.Min_A.TabIndex = 9
        '
        'Sec_A
        '
        Me.Sec_A.Location = New System.Drawing.Point(112, 44)
        Me.Sec_A.Name = "Sec_A"
        Me.Sec_A.Size = New System.Drawing.Size(39, 23)
        Me.Sec_A.TabIndex = 9
        '
        'MS_A
        '
        Me.MS_A.Location = New System.Drawing.Point(157, 44)
        Me.MS_A.Name = "MS_A"
        Me.MS_A.Size = New System.Drawing.Size(39, 23)
        Me.MS_A.TabIndex = 9
        '
        'Month_B
        '
        Me.Month_B.Location = New System.Drawing.Point(23, 19)
        Me.Month_B.Name = "Month_B"
        Me.Month_B.Size = New System.Drawing.Size(39, 23)
        Me.Month_B.TabIndex = 9
        Me.Month_B.Text = "2"
        '
        'Day_B
        '
        Me.Day_B.Location = New System.Drawing.Point(68, 19)
        Me.Day_B.Name = "Day_B"
        Me.Day_B.Size = New System.Drawing.Size(39, 23)
        Me.Day_B.TabIndex = 9
        Me.Day_B.Text = "17"
        '
        'Year_B
        '
        Me.Year_B.Location = New System.Drawing.Point(112, 19)
        Me.Year_B.Name = "Year_B"
        Me.Year_B.Size = New System.Drawing.Size(39, 23)
        Me.Year_B.TabIndex = 9
        Me.Year_B.Text = "2013"
        '
        'Hour_B
        '
        Me.Hour_B.Location = New System.Drawing.Point(23, 45)
        Me.Hour_B.Name = "Hour_B"
        Me.Hour_B.Size = New System.Drawing.Size(39, 23)
        Me.Hour_B.TabIndex = 9
        Me.Hour_B.Text = "0"
        '
        'Min_B
        '
        Me.Min_B.Location = New System.Drawing.Point(68, 45)
        Me.Min_B.Name = "Min_B"
        Me.Min_B.Size = New System.Drawing.Size(39, 23)
        Me.Min_B.TabIndex = 9
        Me.Min_B.Text = "0"
        '
        'Sec_B
        '
        Me.Sec_B.Location = New System.Drawing.Point(113, 45)
        Me.Sec_B.Name = "Sec_B"
        Me.Sec_B.Size = New System.Drawing.Size(39, 23)
        Me.Sec_B.TabIndex = 9
        Me.Sec_B.Text = "0"
        '
        'MS_B
        '
        Me.MS_B.Location = New System.Drawing.Point(157, 45)
        Me.MS_B.Name = "MS_B"
        Me.MS_B.Size = New System.Drawing.Size(39, 23)
        Me.MS_B.TabIndex = 9
        Me.MS_B.Text = "0"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MS_A)
        Me.GroupBox2.Controls.Add(Me.Sec_A)
        Me.GroupBox2.Controls.Add(Me.Min_A)
        Me.GroupBox2.Controls.Add(Me.Hour_A)
        Me.GroupBox2.Controls.Add(Me.Year_A)
        Me.GroupBox2.Controls.Add(Me.Day_A)
        Me.GroupBox2.Controls.Add(Me.Month_A)
        Me.GroupBox2.Controls.Add(Me.Automatic)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(215, 78)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "From Date and Time:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.MS_B)
        Me.GroupBox3.Controls.Add(Me.Sec_B)
        Me.GroupBox3.Controls.Add(Me.Min_B)
        Me.GroupBox3.Controls.Add(Me.Hour_B)
        Me.GroupBox3.Controls.Add(Me.Year_B)
        Me.GroupBox3.Controls.Add(Me.Day_B)
        Me.GroupBox3.Controls.Add(Me.Month_B)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 96)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(214, 84)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "To Date and Time"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 413)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Time Machine"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Automatic As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Month_A As System.Windows.Forms.TextBox
    Friend WithEvents Day_A As System.Windows.Forms.TextBox
    Friend WithEvents Year_A As System.Windows.Forms.TextBox
    Friend WithEvents Hour_A As System.Windows.Forms.TextBox
    Friend WithEvents Min_A As System.Windows.Forms.TextBox
    Friend WithEvents Sec_A As System.Windows.Forms.TextBox
    Friend WithEvents MS_A As System.Windows.Forms.TextBox
    Friend WithEvents Month_B As System.Windows.Forms.TextBox
    Friend WithEvents Day_B As System.Windows.Forms.TextBox
    Friend WithEvents Year_B As System.Windows.Forms.TextBox
    Friend WithEvents Hour_B As System.Windows.Forms.TextBox
    Friend WithEvents Min_B As System.Windows.Forms.TextBox
    Friend WithEvents Sec_B As System.Windows.Forms.TextBox
    Friend WithEvents MS_B As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox

End Class
