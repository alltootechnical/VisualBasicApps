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
        Me.components = New System.ComponentModel.Container()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.ProgressBar3 = New System.Windows.Forms.ProgressBar()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.ProgressBar4 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar5 = New System.Windows.Forms.ProgressBar()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ActionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MethodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DictonaryAttackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BruToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.ProgressBar6 = New System.Windows.Forms.ProgressBar()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(192, 23)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.UseSystemPasswordChar = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(276, 30)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(72, 23)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "0"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "11", "12", "21", "22", "33", "44", "55", "66", "77", "88", "99", "111", "123", "222", "321", "333", "444", "555", "666", "777", "888", "999", "1111", "1234", "2222", "3333", "4321", "4444", "5555", "6666", "7777", "8888", "9999", "11111", "12321", "12345", "22222", "33333", "44444", "54321", "55555", "66666", "77777", "88888", "99999", "111111", "112233", "121212", "123123", "123321", "123456", "131313", "222222", "232323", "333333", "444444", "555555", "654321", "654321", "666666", "666666", "696969", "777777", "777777", "888888", "987654", "999999", "1111111", "1234567", "2222222", "3333333", "4444444", "5555555", "6666666", "7654321", "7777777", "7777777", "8675309", "8888888", "9999999", "11111111", "12345678", "22222222", "33333333", "44444444", "55555555", "66666666", "77777777", "87654321", "88888888", "99999999", "123456789", "987654321", "1234567890", "-------------", "1234abcd", "1234qwer", "123abc", "123asd", "123qwe", "1q2w3e", "a1b2c3", "aaa", "aaaa", "aaaaa", "aaaaaa", "abc123", "abcdef", "abgrtyu", "academia", "access", "access14", "account", "action", "admin", "admin1", "admin12", "admin123", "adminadmin", "administrator", "albert", "alexis", "amanda", "amateur", "andrea", "andrew", "angela", "angels", "animal", "anthony", "anything", "apollo", "apples", "arsenal", "arthur", "asddsa", "asdfgh", "asdsa", "asdzxc", "ashley", "august", "austin", "backup", "badboy", "bailey", "banana", "barney", "baseball", "batman", "beaver", "beavis", "bigdaddy", "bigdog", "birdie", "bitches", "biteme", "blank", "blazer", "blonde", "blondes", "bond007", "bonnie", "booboo", "booger", "boomer", "boss123", "boston", "brandon", "brandy", "braves", "brazil", "bronco", "broncos", "bulldog", "business", "buster", "butter", "butthead", "calvin", "camaro", "cameron", "campus", "canada", "captain", "carlos", "carter", "casper", "changeme", "charles", "charlie", "cheese", "chelsea", "chester", "chicago", "chicken", "cluster", "cocacola", "codename", "codeword", "coffee", "college", "compaq", "computer", "controller", "cookie", "cooper", "corvette", "cowboy", "cowboys", "crystal", "customer", "dakota", "dallas", "daniel", "danielle", "database", "debbie", "default", "dennis", "desktop", "diablo", "diamond", "doctor", "doggie", "dolphin", "dolphins", "domain", "donald", "dragon", "dreams", "driver", "eagle1", "eagles", "edward", "einstein", "erotic", "example", "exchange", "explorer", "extreme", "falcon", "fender", "ferrari", "file", "files", "firebird", "fishing", "florida", "flower", "flyers", "foo", "foobar", "foofoo", "football", "forever", "freddy", "freedom", "games", "gandalf", "gateway", "gators", "gemini", "george", "giants", "ginger", "golden", "golfer", "gordon", "gregory", "guitar", "gunner", "hammer", "hannah", "hardcore", "harley", "haxd", "heather", "helpme", "hockey", "home", "home123", "hooters", "horney", "hotdog", "hunter", "hunting", "iceman", "ihavenopass", "iloveyou", "internet", "intranet", "iwantu", "jackie", "jackson", "jaguar", "jasmine", "jasper", "jennifer", "jeremy", "jessica", "job", "johnny", "johnson", "jordan", "joseph", "joshua", "junior", "justin", "killer", "knight", "ladies", "lakers", "lauren", "leather", "legend", "letitbe", "letmein", "little", "login", "london", "lotus", "love123", "lovers", "maddog", "madison", "maggie", "magnum", "manager", "marine", "market", "marlboro", "martin", "marvin", "master", "matrix", "matthew", "maverick", "maxwell", "melissa", "member", "mercedes", "merlin", "michael", "michelle", "mickey", "midnight", "miller", "mistress", "money", "monica", "monitor", "monkey", "monster", "morgan", "mother", "mountain", "muffin", "murphy", "mustang", "mypass", "mypassword", "mypc123", "naked", "nascar", "nathan", "naughty", "ncc1701", "newyork", "nicholas", "nicole", "nimda", "nipple", "nipples", "nobody", "nopass", "nopassword", "nothing", "office", "oliver", "oracle", "orange", "owner", "packers", "panther", "panties", "parker", "pass", "pass1", "pass12", "pass123", "passwd", "password", "password1", "password12", "password123", "patrick", "peaches", "peanut", "pepper", "phantom", "phoenix", "player", "please", "pookie", "porsche", "prince", "princess", "private", "public", "purple", "pussies", "pw123", "pwned", "q1w2e3", "qazwsx", "qazwsxedc", "qqq", "qqqq", "qqqqq", "qwe123", "qweasd", "qweasdzxc", "qweewq", "qwerty", "qwertyui", "qwewq", "rabbit", "rachel", "racing", "raiders", "rainbow", "ranger", "rangers", "rebecca", "redskins", "redsox", "redwings", "richard", "robert", "rocket", "root", "root123", "rootroot", "rosebud", "runner", "rush2112", "russia", "samantha", "sammy", "sample", "samson", "sandra", "saturn", "scooby", "scooter", "scorpio", "scorpion", "secret", "secure", "security", "server", "sexsex", "shadow", "shannon", "share", "shaved", "sierra", "silver", "skippy", "slayer", "smokey", "snoopy", "soccer", "sophie", "spanky", "sparky", "spider", "sql", "squirt", "srinivas", "startrek", "starwars", "steelers", "steven", "sticky", "student", "stupid", "success", "summer", "sunshine", "super", "superman", "superuser", "supervisor", "surfer", "swimming", "sydney", "system", "taylor", "temp", "temp123", "temporary", "temptemp", "tennis", "teresa", "test", "test123", "tester", "testing", "testtest", "theman", "thomas", "thunder", "thx1138", "tiffany", "tigers", "tigger", "tomcat", "topgun", "toyota", "travis", "trouble", "trustno1", "tucker", "turtle", "twitter", "united", "unknown", "vagina", "victor", "victoria", "viking", "voodoo", "voyager", "walter", "warrior", "web", "welcome", "whatever", "william", "willie", "wilson", "windows", "winner", "winston", "winter", "wizard", "work", "work123", "xavier", "xxx", "xxxx", "xxxxx", "xxxxxx", "xxxxxxxx", "yamaha", "yankee", "yankees", "yellow", "zxccxz", "zxcvb", "zxcvbn", "zxcvbnm", "zxcxz", "zzz", "zzzz", "zzzzz", "zzzzzz"})
        Me.ListBox1.Location = New System.Drawing.Point(415, 91)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 94)
        Me.ListBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 262)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Check"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 59)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(258, 23)
        Me.ProgressBar1.TabIndex = 4
        '
        'Timer1
        '
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(12, 295)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(335, 23)
        Me.TextBox3.TabIndex = 5
        Me.TextBox3.Text = "-----"
        '
        'Timer2
        '
        Me.Timer2.Interval = 10
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(11, 354)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(336, 23)
        Me.TextBox4.TabIndex = 6
        Me.TextBox4.Text = "Idle."
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(67, 262)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(49, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Reset"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(210, 32)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(60, 19)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Show?"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(275, 110)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(72, 23)
        Me.TextBox5.TabIndex = 9
        Me.TextBox5.Text = "0"
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(11, 110)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(258, 23)
        Me.ProgressBar2.TabIndex = 4
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(276, 59)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(72, 23)
        Me.TextBox6.TabIndex = 9
        Me.TextBox6.Text = "0"
        '
        'ProgressBar3
        '
        Me.ProgressBar3.Location = New System.Drawing.Point(11, 131)
        Me.ProgressBar3.Maximum = 13
        Me.ProgressBar3.Name = "ProgressBar3"
        Me.ProgressBar3.Size = New System.Drawing.Size(258, 23)
        Me.ProgressBar3.TabIndex = 4
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(275, 131)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(72, 23)
        Me.TextBox7.TabIndex = 9
        Me.TextBox7.Text = "0"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(12, 325)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(335, 23)
        Me.TextBox8.TabIndex = 10
        Me.TextBox8.Text = "N/A"
        '
        'ProgressBar4
        '
        Me.ProgressBar4.Location = New System.Drawing.Point(13, 167)
        Me.ProgressBar4.Maximum = 59
        Me.ProgressBar4.Name = "ProgressBar4"
        Me.ProgressBar4.Size = New System.Drawing.Size(256, 18)
        Me.ProgressBar4.TabIndex = 11
        '
        'ProgressBar5
        '
        Me.ProgressBar5.Location = New System.Drawing.Point(13, 186)
        Me.ProgressBar5.Maximum = 59
        Me.ProgressBar5.Name = "ProgressBar5"
        Me.ProgressBar5.Size = New System.Drawing.Size(256, 18)
        Me.ProgressBar5.TabIndex = 12
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(275, 162)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(72, 23)
        Me.TextBox9.TabIndex = 9
        Me.TextBox9.Text = "0 m"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(275, 186)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(72, 23)
        Me.TextBox10.TabIndex = 9
        Me.TextBox10.Text = "0 s"
        '
        'Timer3
        '
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(485, 217)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(100, 23)
        Me.TextBox11.TabIndex = 13
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(485, 217)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(31, 23)
        Me.TextBox12.TabIndex = 14
        Me.TextBox12.Text = "?"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActionToolStripMenuItem, Me.MethodToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(360, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ActionToolStripMenuItem
        '
        Me.ActionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ActionToolStripMenuItem.Name = "ActionToolStripMenuItem"
        Me.ActionToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ActionToolStripMenuItem.Text = "Action"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MethodToolStripMenuItem
        '
        Me.MethodToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DictonaryAttackToolStripMenuItem, Me.BruToolStripMenuItem})
        Me.MethodToolStripMenuItem.Name = "MethodToolStripMenuItem"
        Me.MethodToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.MethodToolStripMenuItem.Text = "Method"
        '
        'DictonaryAttackToolStripMenuItem
        '
        Me.DictonaryAttackToolStripMenuItem.Name = "DictonaryAttackToolStripMenuItem"
        Me.DictonaryAttackToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.DictonaryAttackToolStripMenuItem.Text = "Dictonary Attack"
        '
        'BruToolStripMenuItem
        '
        Me.BruToolStripMenuItem.Name = "BruToolStripMenuItem"
        Me.BruToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.BruToolStripMenuItem.Text = "Brute Force Attack"
        '
        'Timer4
        '
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(131, 257)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(195, 34)
        Me.CheckBox2.TabIndex = 16
        Me.CheckBox2.Text = "This password is in the database" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of 578 weak passwords."
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'ProgressBar6
        '
        Me.ProgressBar6.Location = New System.Drawing.Point(11, 82)
        Me.ProgressBar6.Name = "ProgressBar6"
        Me.ProgressBar6.Size = New System.Drawing.Size(258, 23)
        Me.ProgressBar6.TabIndex = 4
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(276, 81)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(72, 23)
        Me.TextBox13.TabIndex = 9
        Me.TextBox13.Text = "0"
        '
        'TrackBar1
        '
        Me.TrackBar1.LargeChange = 2
        Me.TrackBar1.Location = New System.Drawing.Point(13, 212)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(334, 45)
        Me.TrackBar1.TabIndex = 17
        Me.TrackBar1.TickFrequency = 10
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.TrackBar1.Value = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 399)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.ProgressBar5)
        Me.Controls.Add(Me.ProgressBar4)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.ProgressBar6)
        Me.Controls.Add(Me.ProgressBar3)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar3 As System.Windows.Forms.ProgressBar
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar4 As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressBar5 As System.Windows.Forms.ProgressBar
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ActionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MethodToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DictonaryAttackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BruToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents ProgressBar6 As System.Windows.Forms.ProgressBar
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar

End Class
