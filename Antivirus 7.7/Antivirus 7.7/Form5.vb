Public Class Form5

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("$39.99 has been sent to your Internet provider." & ControlChars.NewLine & "Thank you for purchasing Antivirus 7.7 !", MsgBoxStyle.Information)
        Me.Close()
    End Sub
End Class