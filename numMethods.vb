Public Class WebForm1
    Inherits System.Web.UI.Page

    Dim number As Double
    Dim result As Double

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        number = TextBox1.Text
        result = Math.Abs(number)
        MsgBox("Absolute Value of " & number & " is " & result)
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        number = TextBox1.Text
        result = Math.Exp(number)
        MsgBox("Exponential Value of " & number & " is " & result)
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        number = TextBox1.Text
        result = Math.Floor(number)
        MsgBox("Floor Value of " & number & " is " & result)
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        number = TextBox1.Text
        result = Math.Truncate(number)
        MsgBox("Truncate Value of " & number & " is " & result)
    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        number = TextBox1.Text
        result = Math.Round(number)
        MsgBox("Round Value of " & number & " is " & result)
    End Sub

    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        number = TextBox1.Text
        result = Math.Ceiling(number)
        MsgBox("Ceiling Value of " & number & " is " & result)
    End Sub

End Class
