Public Class captcha

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If TextBox1.Text = "hastens Frank" Then
            MsgBox("Gratulacje! Jesteś człowiekiem.", MsgBoxStyle.OkOnly, "CAPTCHA Passed!")
            If vbOK Then
                End
            End If
        Else
            MsgBox("Robot!!", MsgBoxStyle.OkOnly, "CAPTCHA Failed!!!")
            If vbOK Then
                Form5.Show()
            End If
        End If
    End Sub
End Class