Imports System.Math
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Public Function Math_Mod(ByVal x As Integer, ByVal y As Integer) As Integer
        Return Round(x - Floor(x / y) * y)
    End Function


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim hrs As Integer = DateAndTime.Now.Hour
        Dim min As Integer = DateAndTime.Now.Minute
        Dim sec As Integer = DateAndTime.Now.Second
        Dim mil As Integer = DateAndTime.Now.Millisecond
        Dim col As String = ":"
        Dim spc As String = " "
        Dim totalmil As Integer = mil + (sec * 1000) + (min * 1000 * 60) + (hrs * 1000 * 60 * 60)
        Dim totalmetsecs As Integer = totalmil / 864
        Dim methrs As Integer = totalmetsecs / 10000
        Dim metmin As Integer = Math_Mod(totalmetsecs, 10000) / 100
        Dim metsec As Integer = Math_Mod(totalmetsecs, 100)
        Dim metclock As String
        Dim normclock As String
        Dim apm As String

        If methrs <= 9 Then
            methrs = "0" & methrs.ToString
        End If
        If metmin <= 9 Then
            metmin = "0" & metmin.ToString
        End If
        If metsec <= 9 Then
            metsec = "0" & metsec.ToString
        End If

        If 11 < hrs Then
            apm = "PM"
            hrs -= 12
        Else
            apm = "AM"
        End If

        If hrs = 0 Then
            hrs = 12
        End If
        If min <= 9 Then
            min = "0" & min.ToString
        End If
        If sec <= 9 Then
            sec = "0" & sec.ToString
        End If

        normclock = hrs & col & min & col & sec & spc & apm
        metclock = methrs & col & metmin & col & metsec

        Label1.Text = metclock
        Label2.Text = normclock

    End Sub
End Class
