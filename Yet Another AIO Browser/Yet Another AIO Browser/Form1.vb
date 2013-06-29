Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Select Case ComboBox1.Text
            Case "Wolfram|Alpha"
                WebBrowser1.Navigate("http://m.wolframalpha.com/input/?i=" & TextBox1.Text)
            Case "Google"
                WebBrowser1.Navigate("http://www.google.com/search?q=" & TextBox1.Text)
            Case "WOT"
                WebBrowser1.Navigate("http://www.mywot.com/en/scorecard/" & TextBox1.Text)
            Case "SiteAdvisor"
                WebBrowser1.Navigate("http://www.siteadvisor.com/sites/" & TextBox1.Text)
            Case "Safe Web"
                WebBrowser1.Navigate("http://safeweb.norton.com/report/show?url=" & TextBox1.Text)
            Case "Yahoo!"
                WebBrowser1.Navigate("http://search.yahoo.com/search;_ylt=AmX9MHwCBS617jH5hOOzOaSbvZx4?vc=&fp_ip=ph&p=" & TextBox1.Text)
            Case "Bing"
                WebBrowser1.Navigate("http://www.bing.com/search?q=" & TextBox1.Text)
            Case "YouTube"
                WebBrowser1.Navigate("http://www.youtube.com/results?search_query=" & TextBox1.Text)
            Case "Wikipedia"
                WebBrowser1.Navigate("http://en.m.wikipedia.org/wiki?search=" & TextBox1.Text)
            Case "ISBNdb.com"
                WebBrowser1.Navigate("http://isbndb.com/search-all.html?kw=" & TextBox1.Text)
            Case "True Knowledge"
                WebBrowser1.Navigate("http://www.trueknowledge.com/q/" & TextBox1.Text)
            Case "Whois DomainTools"
                WebBrowser1.Navigate("http://whois.domaintools.com/" & TextBox1.Text)
            Case "Process Library"
                WebBrowser1.Navigate("http://www.processlibrary.com/search/?q=" & TextBox1.Text)
            Case "Wayback Machine"
                WebBrowser1.Navigate("http://web.archive.org/web/*/" & TextBox1.Text)
            Case "Instructables"
                WebBrowser1.Navigate("http://www.instructables.com/pages/search/search.jsp&ie=ISO-8859-1&q=" & TextBox1.Text)
            Case "M-W Dictionary"
                WebBrowser1.Navigate("http://www.merriam-webster.com/dictionary/" & TextBox1.Text)
            Case "Y! Video"
                WebBrowser1.Navigate("http://video.yahoo.com/search/?p=" & TextBox1.Text)
            Case "Google Videos"
                WebBrowser1.Navigate("http://www.google.com/search?q=" & TextBox1.Text & "&tbo=p&tbs=vid%3A1&source=vgc&aq=f")
            Case "Google Code Search"
                WebBrowser1.Navigate("http://www.google.com/codesearch?q=" & TextBox1.Text & "&hl=en&btnG=Search+Code")
            Case "Yandex"
                WebBrowser1.Navigate("http://yandex.com/yandsearch?text=" & TextBox1.Text & "&rpt=rad&lr=183")
            Case "Duck Duck Go"
                WebBrowser1.Navigate("http://duckduckgo.com/?q=" & TextBox1.Text)
            Case "Google Product Search"
                WebBrowser1.Navigate("http://www.google.com/products?q=" & TextBox1.Text)
            Case "Y! Answers"
                WebBrowser1.Navigate("http://answers.yahoo.com/search/search_result;_ylt=AldBonfogszFjf3vYgUDTKvj1KIX;_ylv=3?p=" & TextBox1.Text)
            Case "Flickr"
                WebBrowser1.Navigate("http://www.flickr.com/search/?q=" & TextBox1.Text)
            Case "Google Images"
                WebBrowser1.Navigate("http://www.google.com/images?hl=en&source=imghp&q=" & TextBox1.Text)
            Case "Y! Images"
                WebBrowser1.Navigate("http://images.search.yahoo.com/search/images;_ylt=A0S0205vORJMqgYAWj2LuLkF?p=" & TextBox1.Text & "&ei=utf-8&iscqry=&fr=sfp")
            Case "Iconfinder"
                WebBrowser1.Navigate("http://www.iconfinder.com/search/?q=" & TextBox1.Text)
            Case "Google Trends"
                WebBrowser1.Navigate("http://www.google.com/trends?q=" & TextBox1.Text)
            Case "Symantec Threat Explorer"
                WebBrowser1.Navigate("http://searchg.symantec.com/search?q=" & TextBox1.Text & "&charset=utf-8&nh=10&hitsceil=100&st=1&proxystylesheet=symc_en_US&client=symc_en_US&site=symc_en_US_vir&output=xml_no_dtd&context=hho")
            Case "Xmarks Topics"
                WebBrowser1.Navigate("http://www.xmarks.com/topic/" & TextBox1.Text)
            Case "Xmarks Sites"
                WebBrowser1.Navigate("http://www.xmarks.com/site/" & TextBox1.Text)
            Case "Google Realtime Search"
                WebBrowser1.Navigate("http://www.google.com/search?tbs=mbl%3A1&hl=en&source=hp&q=" & TextBox1.Text)
            Case "Dictionary.com"
                WebBrowser1.Navigate("http://dictionary.reference.com/browse/" & TextBox1.Text)
            Case "Thesaurus.com"
                WebBrowser1.Navigate("http://thesaurus.com/browse/" & TextBox1.Text)
            Case "Reference.com"
                WebBrowser1.Navigate("http://www.reference.com/browse/" & TextBox1.Text)
            Case "The Urban Dictionary"
                If MsgBox("The Website is not intended for children under 13. By using the Website, you are representing" & vbNewLine & "that you are at least 18, or that you are at least 13 years old and have your parents' permission to use the Website." & vbNewLine & "Are you sure you want to continue?", MsgBoxStyle.YesNo, "You have been warned.") _
                = Windows.Forms.DialogResult.Yes Then
                    WebBrowser1.Navigate("http://www.urbandictionary.com/define.php?term=" & TextBox1.Text)
                Else
                    MsgBox("Ok, then.")
                End If
            Case "The Free Dictionary - Dictionary & Thesaurus"
                WebBrowser1.Navigate("http://www.thefreedictionary.com/" & TextBox1.Text)
            Case "The Free Dictionary - Medical"
                WebBrowser1.Navigate("http://medical-dictionary.thefreedictionary.com/" & TextBox1.Text)
            Case "The Free Dictionary - Legal"
                WebBrowser1.Navigate("http://legal-dictionary.thefreedictionary.com/" & TextBox1.Text)
            Case "The Free Dictionary - Acronyms"
                WebBrowser1.Navigate("http://acronyms.thefreedictionary.com/" & TextBox1.Text)
            Case "The Free Dictionary - Idioms"
                WebBrowser1.Navigate("http://idioms.thefreedictionary.com/" & TextBox1.Text)
            Case "The Free Dictionary - Encyclopedia"
                WebBrowser1.Navigate("http://encyclopedia2.thefreedictionary.com/" & TextBox1.Text)
            Case "Yehey!"
                WebBrowser1.Navigate("http://www.yehey.com/web?query=" & TextBox1.Text)
                'Add your own engines here:
            Case ""
                WebBrowser1.Navigate("" & TextBox1.Text)
            Case ""
                WebBrowser1.Navigate("" & TextBox1.Text)
            Case ""
                WebBrowser1.Navigate("" & TextBox1.Text)
            Case ""
                WebBrowser1.Navigate("" & TextBox1.Text)
            Case ""
                WebBrowser1.Navigate("" & TextBox1.Text)

        End Select
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub WebBrowser1_Navigating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles WebBrowser1.Navigating
        PictureBox2.Image = My.Resources.load
        PictureBox3.Image = My.Resources.load
    End Sub

    Private Sub WebBrowser1_Navigated(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated
        PictureBox2.Image = My.Resources.load3
        PictureBox3.Image = My.Resources.load3
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        PictureBox2.Image = My.Resources.load2
        PictureBox3.Image = My.Resources.load2
        Form2.WebBrowser1.Url = WebBrowser1.Url
        Label3.Text = "You are here: " & WebBrowser1.DocumentTitle & ControlChars.NewLine & WebBrowser1.Url.ToString
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form2.Show()
        Form2.WebBrowser1.Navigate(WebBrowser1.Url)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label4.Text = "There are " & ComboBox1.Items.Count & " engines and counting..."
    End Sub
End Class
