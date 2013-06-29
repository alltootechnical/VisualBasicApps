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
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.Label6 = New System.Windows.Forms.Label
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.Label8 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(568, 17)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(111, 22)
        Me.TextBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(16, 248)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(389, 22)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Retrieve"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Items.AddRange(New Object() {"-------------", "12", "123", "1234", "12345", "123456", "1234567", "12345678", "123456789", "1234567890", "123123", "12321", "123321", "123abc", "123qwe", "123asd", "1234abcd", "1234qwer", "1q2w3e", "a1b2c3", "nopass", "pwned", "haxd", "blank", "admin", "Admin", "administrator", "nimda", "qwewq", "qweewq", "qwerty", "qweasd", "asdsa", "asddsa", "asdzxc", "asdfgh", "qweasdzxc", "q1w2e3", "qazwsx", "qazwsxedc", "zxcxz", "zxccxz", "zxcvb", "zxcvbn", "passwd", "password", "Password", "login", "Login", "pass", "mypass", "mypassword", "adminadmin", "root", "rootroot", "test", "testtest", "temp", "temptemp", "foofoo", "foobar", "default", "password1", "password12", "password123", "admin1", "admin12", "admin123", "pass1", "pass12", "pass123", "root123", "pw123", "abc123", "qwe123", "test123", "temp123", "mypc123", "home123", "work123", "boss123", "love123", "sample", "example", "internet", "Internet", "nopass", "nopassword", "nothing", "ihavenopass", "temporary", "manager", "business", "oracle", "lotus", "database", "backup", "owner", "computer", "server", "secret", "super", "share", "superuser", "supervisor", "office", "shadow", "system", "public", "secure", "security", "desktop", "changeme", "codename", "codeword", "nobody", "cluster", "customer", "exchange", "explorer", "campus", "money", "access", "domain", "letmein", "letitbe", "anything", "unknown", "monitor", "windows", "files", "academia", "account", "student", "freedom", "forever", "cookie", "coffee", "market", "private", "games", "killer", "controller", "intranet", "work", "home", "job", "foo", "web", "file", "sql", "aaa", "aaaa", "aaaaa", "qqq", "qqqq", "qqqqq", "xxx", "xxxx", "xxxxx", "zzz", "zzzz", "zzzzz", "12", "21", "321", "4321", "54321", "654321", "7654321", "87654321", "987654321", "0987654321", "0", "00", "000", "0000", "00000", "00000", "0000000", "00000000", "1", "11", "111", "1111", "11111", "111111", "1111111", "11111111", "2", "22", "222", "2222", "22222", "222222", "2222222", "22222222", "3", "33", "333", "3333", "33333", "333333", "3333333", "33333333", "4", "44", "444", "4444", "44444", "444444", "4444444", "44444444", "5", "55", "555", "5555", "55555", "555555", "5555555", "55555555", "6", "66", "666", "6666", "66666", "666666", "6666666", "66666666", "7", "77", "777", "7777", "77777", "777777", "7777777", "77777777", "8", "88", "888", "8888", "88888", "888888", "8888888", "88888888", "9", "99", "999", "9999", "99999", "999999", "9999999", "99999999"})
        Me.ListBox1.Location = New System.Drawing.Point(568, 43)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(102, 199)
        Me.ListBox1.TabIndex = 3
        Me.ListBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(19, 29)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(386, 23)
        Me.TextBox2.TabIndex = 4
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(16, 210)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(389, 32)
        Me.ProgressBar1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "The password is:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(251, 37)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "-------------"
        '
        'Timer2
        '
        Me.Timer2.Interval = 10
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(423, 279)
        Me.ShapeContainer1.TabIndex = 8
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(17, 146)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(268, 53)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Identifier: (user account, e-mail, IDs, etc.)"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(593, 265)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(86, 23)
        Me.TextBox3.TabIndex = 10
        Me.TextBox3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(312, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "# of Passwords:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 24)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "-------------"
        '
        'RectangleShape2
        '
        Me.RectangleShape2.Location = New System.Drawing.Point(18, 77)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(386, 43)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Identifier:"
        '
        'Timer3
        '
        Me.Timer3.Interval = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(309, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 32)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "---"
        '
        'RectangleShape3
        '
        Me.RectangleShape3.Location = New System.Drawing.Point(301, 146)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(103, 53)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(189, 220)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 15)
        Me.Label8.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 279)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Password Cracker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
