Public Class Form1
    Dim SAPI = CreateObject("sapi.spvoice")

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Goes to m.wolframalpha.com
        WebBrowser1.Navigate("http://m.wolframalpha.com/input/?i=" & TextBox1.Text)
        'Adds the query to the list box in Form2
        Form2.ListBox1.Items.Add(TextBox1.Text & "- Computed by Wolfram|Alpha")
        SAPI.Speak("Computing...")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button156.Click
        TextBox1.Text = TextBox1.Text & "7"
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button155.Click
        TextBox1.Text = TextBox1.Text & "8"
        TextBox1.Focus()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button163.Click
        TextBox1.Text = TextBox1.Text & "9"
        TextBox1.Focus()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button165.Click
        TextBox1.Text = TextBox1.Text & "/"
        TextBox1.Focus()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button182.Click
        TextBox1.Text = TextBox1.Text & "("
        TextBox1.Focus()
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button184.Click
        TextBox1.Text = TextBox1.Text & ")"
        TextBox1.Focus()
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button191.Click
        TextBox1.Text = TextBox1.Text & "!"
        TextBox1.Focus()
    End Sub

    Private Sub Button37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button192.Click
        TextBox1.Text = TextBox1.Text & "?"
        TextBox1.Focus()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button158.Click
        TextBox1.Text = TextBox1.Text & "4"
        TextBox1.Focus()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button157.Click
        TextBox1.Text = TextBox1.Text & "5"
        TextBox1.Focus()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button164.Click
        TextBox1.Text = TextBox1.Text & "6"
        TextBox1.Focus()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button167.Click
        TextBox1.Text = TextBox1.Text & "*"
        TextBox1.Focus()
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button185.Click
        TextBox1.Text = TextBox1.Text & "["
        TextBox1.Focus()
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button186.Click
        TextBox1.Text = TextBox1.Text & "]"
        TextBox1.Focus()
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button193.Click
        TextBox1.Text = TextBox1.Text & " percent"
        TextBox1.Focus()
    End Sub

    Private Sub Button38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button194.Click
        TextBox1.Text = TextBox1.Text & " degrees"
        TextBox1.Focus()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button159.Click
        TextBox1.Text = TextBox1.Text & "1"
        TextBox1.Focus()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button161.Click
        TextBox1.Text = TextBox1.Text & "2"
        TextBox1.Focus()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button166.Click
        TextBox1.Text = TextBox1.Text & "3"
        TextBox1.Focus()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button168.Click
        TextBox1.Text = TextBox1.Text & "-"
        TextBox1.Focus()
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button187.Click
        TextBox1.Text = TextBox1.Text & "{"
        TextBox1.Focus()
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button188.Click
        TextBox1.Text = TextBox1.Text & "}"
        TextBox1.Focus()
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button195.Click
        TextBox1.Text = TextBox1.Text & "^"
        TextBox1.Focus()
    End Sub

    Private Sub Button39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button196.Click
        TextBox1.Text = TextBox1.Text & "'"
        TextBox1.Focus()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button160.Click
        TextBox1.Text = TextBox1.Text & "0"
        TextBox1.Focus()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button162.Click
        TextBox1.Text = TextBox1.Text & "."
        TextBox1.Focus()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button169.Click
        TextBox1.Text = TextBox1.Text & ","
        TextBox1.Focus()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button171.Click
        TextBox1.Text = TextBox1.Text & " plus "
        TextBox1.Focus()
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button189.Click
        TextBox1.Text = TextBox1.Text & "<"
        TextBox1.Focus()
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button190.Click
        TextBox1.Text = TextBox1.Text & ">"
        TextBox1.Focus()
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button197.Click
        TextBox1.Text = TextBox1.Text & "#"
        TextBox1.Focus()
    End Sub

    Private Sub Button40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button198.Click
        TextBox1.Text = TextBox1.Text & """"
        TextBox1.Focus()
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button175.Click
        TextBox1.Text = TextBox1.Text & " sqrt("
        TextBox1.Focus()
    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button178.Click
        TextBox1.Text = TextBox1.Text & "infinity"
        TextBox1.Focus()
    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button180.Click
        TextBox1.Text = TextBox1.Text & "integrate "
        TextBox1.Focus()
    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button173.Click
        TextBox1.Text = TextBox1.Text & "="
        TextBox1.Focus()
    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button200.Click
        TextBox1.Text = TextBox1.Text & "sum of "
        TextBox1.Focus()
    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button201.Click
        TextBox1.Text = TextBox1.Text & " pi"
        TextBox1.Focus()
    End Sub

    Private Sub Button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button199.Click
        TextBox1.Text = TextBox1.Text & " theta"
        TextBox1.Focus()
    End Sub

    Private Sub Button41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button202.Click
        TextBox1.Text = TextBox1.Text & "differentiate "
        TextBox1.Focus()
    End Sub

    Private Sub Button42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button213.Click
        TextBox1.Text = TextBox1.Text & "a"
        TextBox1.Focus()
    End Sub

    Private Sub Button46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button226.Click
        TextBox1.Text = TextBox1.Text & "b"
        TextBox1.Focus()
    End Sub

    Private Sub Button51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button225.Click
        TextBox1.Text = TextBox1.Text & "c"
        TextBox1.Focus()
    End Sub

    Private Sub Button54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button215.Click
        TextBox1.Text = TextBox1.Text & "d"
        TextBox1.Focus()
    End Sub

    Private Sub Button56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button205.Click
        TextBox1.Text = TextBox1.Text & "e"
        TextBox1.Focus()
    End Sub

    Private Sub Button57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button217.Click
        TextBox1.Text = TextBox1.Text & "f"
        TextBox1.Focus()
    End Sub

    Private Sub Button59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button218.Click
        TextBox1.Text = TextBox1.Text & "g"
        TextBox1.Focus()
    End Sub

    Private Sub Button60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button219.Click
        TextBox1.Text = TextBox1.Text & "h"
        TextBox1.Focus()
    End Sub

    Private Sub Button43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button210.Click
        TextBox1.Text = TextBox1.Text & "i"
        TextBox1.Focus()
    End Sub

    Private Sub Button48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button220.Click
        TextBox1.Text = TextBox1.Text & "j"
        TextBox1.Focus()
    End Sub

    Private Sub Button53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button221.Click
        TextBox1.Text = TextBox1.Text & "k"
        TextBox1.Focus()
    End Sub

    Private Sub Button58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button222.Click
        TextBox1.Text = TextBox1.Text & "l"
        TextBox1.Focus()
    End Sub

    Private Sub Button62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button229.Click
        TextBox1.Text = TextBox1.Text & "m"
        TextBox1.Focus()
    End Sub

    Private Sub Button63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button228.Click
        TextBox1.Text = TextBox1.Text & "n"
        TextBox1.Focus()
    End Sub

    Private Sub Button64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button211.Click
        TextBox1.Text = TextBox1.Text & "o"
        TextBox1.Focus()
    End Sub

    Private Sub Button65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button212.Click
        TextBox1.Text = TextBox1.Text & "p"
        TextBox1.Focus()
    End Sub

    Private Sub Button44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button203.Click
        TextBox1.Text = TextBox1.Text & "q"
        TextBox1.Focus()
    End Sub

    Private Sub Button49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button206.Click
        TextBox1.Text = TextBox1.Text & "r"
        TextBox1.Focus()
    End Sub

    Private Sub Button55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button214.Click
        TextBox1.Text = TextBox1.Text & "s"
        TextBox1.Focus()
    End Sub

    Private Sub Button61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button207.Click
        TextBox1.Text = TextBox1.Text & "t"
        TextBox1.Focus()
    End Sub

    Private Sub Button67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button209.Click
        TextBox1.Text = TextBox1.Text & "u"
        TextBox1.Focus()
    End Sub

    Private Sub Button69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button227.Click
        TextBox1.Text = TextBox1.Text & "v"
        TextBox1.Focus()
    End Sub

    Private Sub Button70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button204.Click
        TextBox1.Text = TextBox1.Text & "w"
        TextBox1.Focus()
    End Sub

    Private Sub Button71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button224.Click
        TextBox1.Text = TextBox1.Text & "x"
        TextBox1.Focus()
    End Sub

    Private Sub Button45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button208.Click
        TextBox1.Text = TextBox1.Text & "y"
        TextBox1.Focus()
    End Sub

    Private Sub Button50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button223.Click
        TextBox1.Text = TextBox1.Text & "z"
        TextBox1.Focus()
    End Sub

    Private Sub Button66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button230.Click, Button126.Click
        TextBox1.Text = TextBox1.Text & " "
        TextBox1.Focus()
    End Sub

    Private Sub Button47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button47.Click
        WebBrowser1.Navigate("http://m.wolframalpha.com/examples/")
    End Sub

    Private Sub Button52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button52.Click
        WebBrowser1.Navigate("http://www.wolframalpha.com/faqs.html")
    End Sub

    Private Sub Button73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button73.Click
        WebBrowser1.Navigate("http://www.wolframalpha.com/gallery.html")
    End Sub

    Private Sub Button75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button231.Click, Button154.Click
        TextBox1.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub Button74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button74.Click
        End
    End Sub

    Private Sub Button72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button72.Click
        Form2.Show()
    End Sub

    Private Sub WebBrowser1_ProgressChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged
        




    End Sub

    Private Sub Button76_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button128.Click
        TextBox1.Text = TextBox1.Text & "A"
        TextBox1.Focus()
    End Sub

    Private Sub Button77_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button138.Click
        TextBox1.Text = TextBox1.Text & "B"
        TextBox1.Focus()
    End Sub

    Private Sub Button78_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button142.Click
        TextBox1.Text = TextBox1.Text & "C"
        TextBox1.Focus()
    End Sub

    Private Sub Button79_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button145.Click
        TextBox1.Text = TextBox1.Text & "D"
        TextBox1.Focus()
    End Sub

    Private Sub Button80_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button148.Click
        TextBox1.Text = TextBox1.Text & "E"
        TextBox1.Focus()
    End Sub

    Private Sub Button81_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button151.Click
        TextBox1.Text = TextBox1.Text & "F"
        TextBox1.Focus()
    End Sub

    Private Sub Button89_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button132.Click
        TextBox1.Text = TextBox1.Text & "G"
        TextBox1.Focus()
    End Sub

    Private Sub Button88_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button130.Click
        TextBox1.Text = TextBox1.Text & "H"
        TextBox1.Focus()
    End Sub

    Private Sub Button82_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button129.Click
        TextBox1.Text = TextBox1.Text & "I"
        TextBox1.Focus()
    End Sub

    Private Sub Button83_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button139.Click
        TextBox1.Text = TextBox1.Text & "J"
        TextBox1.Focus()
    End Sub

    Private Sub Button84_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button143.Click
        TextBox1.Text = TextBox1.Text & "K"
        TextBox1.Focus()
    End Sub

    Private Sub Button85_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button146.Click
        TextBox1.Text = TextBox1.Text & "L"
        TextBox1.Focus()
    End Sub

    Private Sub Button86_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button149.Click
        TextBox1.Text = TextBox1.Text & "M"
        TextBox1.Focus()
    End Sub

    Private Sub Button87_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button152.Click
        TextBox1.Text = TextBox1.Text & "N"
        TextBox1.Focus()
    End Sub

    Private Sub Button92_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button135.Click
        TextBox1.Text = TextBox1.Text & "O"
        TextBox1.Focus()
    End Sub

    Private Sub Button91_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button134.Click
        TextBox1.Text = TextBox1.Text & "P"
        TextBox1.Focus()
    End Sub

    Private Sub Button90_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button131.Click
        TextBox1.Text = TextBox1.Text & "Q"
        TextBox1.Focus()
    End Sub

    Private Sub Button93_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button140.Click
        TextBox1.Text = TextBox1.Text & "R"
        TextBox1.Focus()
    End Sub

    Private Sub Button94_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button144.Click
        TextBox1.Text = TextBox1.Text & "S"
        TextBox1.Focus()
    End Sub

    Private Sub Button95_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button147.Click
        TextBox1.Text = TextBox1.Text & "T"
        TextBox1.Focus()
    End Sub

    Private Sub Button96_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button150.Click
        TextBox1.Text = TextBox1.Text & "U"
        TextBox1.Focus()
    End Sub

    Private Sub Button97_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button153.Click
        TextBox1.Text = TextBox1.Text & "V"
        TextBox1.Focus()
    End Sub

    Private Sub Button100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button137.Click
        TextBox1.Text = TextBox1.Text & "W"
        TextBox1.Focus()
    End Sub

    Private Sub Button99_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button136.Click
        TextBox1.Text = TextBox1.Text & "X"
        TextBox1.Focus()
    End Sub

    Private Sub Button98_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button133.Click
        TextBox1.Text = TextBox1.Text & "Y"
        TextBox1.Focus()
    End Sub

    Private Sub Button101_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button141.Click
        TextBox1.Text = TextBox1.Text & "Z"
        TextBox1.Focus()
    End Sub

    Private Sub Button68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button68.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button102_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button102.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub Button103_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button103.Click
        WebBrowser1.Navigate("http://www.wolframalpha.com")
    End Sub

    Private Sub Button104_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button104.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub Button105_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button105.Click
        WebBrowser1.Navigate("http://www.wolframalpha.com/about.html")
    End Sub

    Private Sub Button106_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button106.Click
        WebBrowser1.Navigate("http://blog.wolframalpha.com")
    End Sub

    Private Sub WebBrowser1_Navigated(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated
        ProgressBar1.Visible = False

    End Sub

    Private Sub Button108_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button108.Click
        WebBrowser1.Navigate("http://www.wolframalpha.com/images/home-popup.png")
    End Sub

    Private Sub Button109_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button183.Click
        TextBox1.Text = TextBox1.Text & "!!"
        TextBox1.Focus()
    End Sub

    Private Sub Button110_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button181.Click
        TextBox1.Text = TextBox1.Text & " != "
        TextBox1.Focus()
    End Sub

    Private Sub Button111_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button179.Click
        TextBox1.Text = TextBox1.Text & " <= "
        TextBox1.Focus()
    End Sub

    Private Sub Button112_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button177.Click
        TextBox1.Text = TextBox1.Text & " => "
        TextBox1.Focus()
    End Sub

    Private Sub Button113_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button176.Click
        TextBox1.Text = TextBox1.Text & " intersect "
        TextBox1.Focus()
    End Sub

    Private Sub Button114_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button174.Click
        TextBox1.Text = TextBox1.Text & " union "
        TextBox1.Focus()
    End Sub

    Private Sub Button115_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button172.Click
        TextBox1.Text = TextBox1.Text & "subset of "
        TextBox1.Focus()
    End Sub

    Private Sub Button116_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button170.Click
        TextBox1.Text = TextBox1.Text & " complement "
        TextBox1.Focus()
    End Sub

    Private Sub Button117_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button117.Click
        Form3.Show()
    End Sub

    Private Sub Button118_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button118.Click, Button216.Click, Button127.Click
        If TextBox1.Text < " " Then
            TextBox1.Text = Mid(TextBox1.Text, 1, Len(TextBox1.Text) - 1 + 1)
        Else
            TextBox1.Text = Mid(TextBox1.Text, 1, Len(TextBox1.Text) - 1)
        End If
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub Button119_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button119.Click
        WebBrowser1.Navigate(TextBox2.Text)
    End Sub

    Private Sub Button120_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button120.Click
        WebBrowser1.Navigate("http://www.mywot.com/en/scorecard/" & TextBox3.Text)
        Form3.ListBox1.Items.Add(TextBox3.Text & "- WOT is used.")
    End Sub

    Private Sub Button121_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button121.Click
        WebBrowser1.Navigate("http://www.siteadvisor.com/sites/" & TextBox3.Text)
        Form3.ListBox1.Items.Add(TextBox3.Text & "- McAfee SiteAdvisor is used.")
    End Sub

    Private Sub Button122_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button122.Click
        WebBrowser1.Navigate("http://safeweb.norton.com/report/show?url=" & TextBox3.Text)
        Form3.ListBox1.Items.Add(TextBox3.Text & "- Norton SafeWeb is used.")
    End Sub

    Private Sub WebBrowser1_StatusTextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles WebBrowser1.DocumentCompleted


        Label1.Text = WebBrowser1.StatusText
        Form5.ListBox1.Items.Add(WebBrowser1.StatusText)
        Form4.Label4.Text = Form5.ListBox1.Items.Count & " item(s) in log."
        TextBox2.Text = WebBrowser1.Url.ToString

    End Sub

    Private Sub TextBox3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox3.KeyDown
        If e.KeyCode = Keys.Alt Then
            Button120.PerformClick()
        End If
    End Sub

    Private Sub Button120_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Button120.KeyDown
        If e.KeyCode = Keys.Alt + Keys.Enter Then
            Button120.PerformClick()
        End If
    End Sub

    Private Sub Button107_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button107.Click
        WebBrowser1.Navigate("http://www.google.com/search?q=" & TextBox1.Text)
        Form2.ListBox1.Items.Add(TextBox1.Text & "- Searched by Google")
        SAPI.Speak("Searching...")
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        WebBrowser1.Navigate("http://www.wolframalpha.com")
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        WebBrowser1.Navigate("http://www.google.com")
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        WebBrowser1.Navigate("http://www.mywot.com")
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        WebBrowser1.Navigate("http://www.siteadvisor.com")
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        WebBrowser1.Navigate("http://safeweb.norton.com")
    End Sub

    Private Sub Button123_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button123.Click
        Form4.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TextBox1.Focus()

    End Sub
End Class
