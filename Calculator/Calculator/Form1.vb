Option Explicit On
Public Class Form1
    Dim FirstNumber As Single
    Dim SecondNumber As Single
    Dim AnswerNumber As Single
    Dim ArithmeticProcess As String
    Private Sub cmd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1.Click
        txtDisplay.Text = txtDisplay.Text & 1
    End Sub
    Private Sub cmd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd2.Click
        txtDisplay.Text = txtDisplay.Text & 2
    End Sub
    Private Sub cmd3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd3.Click
        txtDisplay.Text = txtDisplay.Text & 3
    End Sub
    Private Sub cmd4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd4.Click
        txtDisplay.Text = txtDisplay.Text & 4
    End Sub
    Private Sub cmd5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd5.Click
        txtDisplay.Text = txtDisplay.Text & 5
    End Sub
    Private Sub cmd6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd6.Click
        txtDisplay.Text = txtDisplay.Text & 6
    End Sub
    Private Sub cmd7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd7.Click
        txtDisplay.Text = txtDisplay.Text & 7
    End Sub
    Private Sub cmd8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd8.Click
        txtDisplay.Text = txtDisplay.Text & 8
    End Sub
    Private Sub cmd9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd9.Click
        txtDisplay.Text = txtDisplay.Text & 9
    End Sub
    Private Sub cmdDecimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDecimal.Click
        txtDisplay.Text = txtDisplay.Text & "."
    End Sub
    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        txtDisplay.Text = "0"
    End Sub
    Private Sub cmd00_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd00.Click
        txtDisplay.Text = txtDisplay.Text & "00"
    End Sub
    Private Sub cmdPi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPi.Click
        txtDisplay.Text = "3.14159"
    End Sub
    Private Sub cmdE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdE.Click
        txtDisplay.Text = "2.71828"
    End Sub


    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = "0"
        ArithmeticProcess = "+"
    End Sub
    Private Sub cmdEquals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEquals.Click
        SecondNumber = Val(txtDisplay.Text)
        If ArithmeticProcess = "+" Then
            AnswerNumber = FirstNumber + SecondNumber
        End If
        If ArithmeticProcess = "-" Then
            AnswerNumber = FirstNumber - SecondNumber
        End If
        If ArithmeticProcess = "X" Then
            AnswerNumber = FirstNumber * SecondNumber
        End If
        If ArithmeticProcess = "/" Then
            If SecondNumber = "0" Then
                txtDisplay.Text = "Invalid operation."
                Exit Sub
            End If
            AnswerNumber = FirstNumber / SecondNumber
        End If
        If ArithmeticProcess = "10^" Then
            AnswerNumber = 10 ^ FirstNumber
        End If
        If ArithmeticProcess = "2^" Then
            AnswerNumber = 2 ^ FirstNumber
        End If
        If ArithmeticProcess = "x^y" Then
            AnswerNumber = FirstNumber ^ SecondNumber
        End If
        If ArithmeticProcess = "sqrt" Then
            AnswerNumber = FirstNumber ^ (1 / 2)
        End If
        If ArithmeticProcess = "recip" Then
            If FirstNumber = "0" Then
                txtDisplay.Text = "Invalid operation."
                Exit Sub
            End If
            AnswerNumber = 1 / FirstNumber
        End If
        txtDisplay.Text = AnswerNumber
    End Sub
    Private Sub cmdMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMinus.Click
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = "0"
        ArithmeticProcess = "-"
    End Sub
    Private Sub cmdMultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMultiply.Click
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = "0"
        ArithmeticProcess = "X"
    End Sub
    Private Sub cmdDivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDivide.Click
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = "0"
        ArithmeticProcess = "/"
    End Sub
    Private Sub cmd10p_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd10p.Click
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = "0"
        ArithmeticProcess = "10^"
    End Sub
    Private Sub cmd2p_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd2p.Click
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = "0"
        ArithmeticProcess = "2^"
    End Sub
    Private Sub cmdXpY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdXpY.Click
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = "0"
        ArithmeticProcess = "x^y"
    End Sub
    Private Sub cmdSqrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSqrt.Click
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = "0"
        ArithmeticProcess = "sqrt"
    End Sub
    Private Sub cmdRecip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRecip.Click
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = "0"
        ArithmeticProcess = "recip"
    End Sub
End Class
