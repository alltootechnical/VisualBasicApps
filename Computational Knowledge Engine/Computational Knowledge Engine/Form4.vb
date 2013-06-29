Public Class Form4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.WebBrowser1.Navigate("http://www.bing.com/search?q=" & TextBox1.Text)
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.WebBrowser1.Navigate("http://search.yahoo.com/search;_ylt=AmX9MHwCBS617jH5hOOzOaSbvZx4?vc=&fp_ip=ph&p=" & TextBox1.Text)
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1.WebBrowser1.Navigate("http://en.wikipedia.org/w/index.php?title=Special%3ASearch&search=" & TextBox1.Text & "&fulltext=Search")
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click, PictureBox5.Click

    End Sub

    Private Sub Button6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form1.WebBrowser1.Navigate("http://linkscanner.explabs.com/linkscanner/checksite.aspx?NS=ChkOnly&SRC=apps.explabs.com&CS=" & TextBox2.Text)
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form1.WebBrowser1.Navigate("http://www.youtube.com/results?search_query=" & TextBox1.Text)
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form1.WebBrowser1.Navigate("http://www.google.com/safebrowsing/diagnostic?site=" & TextBox2.Text)
        Me.Close()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Form5.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button8.Click
        Form5.ListBox1.Items.Clear()
    End Sub

    Private Sub Button9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button9.Click
        PaintForm.Show()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Form1.WebBrowser1.Navigate("http://isbndb.com/search-all.html?kw=" & TextBox3.Text)
        Me.Close()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Form1.WebBrowser1.Navigate("http://whois.domaintools.com/" & TextBox4.Text)
        Me.Close()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Form1.WebBrowser1.Navigate("http://www.trueknowledge.com/q/" & TextBox5.Text)
        Me.Close()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Form1.WebBrowser1.Navigate("http://www.processlibrary.com/search/?q=" & TextBox6.Text)
        Me.Close()
    End Sub
End Class