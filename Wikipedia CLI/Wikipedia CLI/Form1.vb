Public Class Form1

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            WebBrowser1.Navigate("http://en.wikipedia.org/wiki/" & TextBox1.Text)
            TextBox1.Clear()
        End If
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        TextBox2.Text = WebBrowser1.Document.Body.InnerText
        If TextBox1.Text.Contains("exit") = True Then
            End
        End If
    End Sub
End Class
