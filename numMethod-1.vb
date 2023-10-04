Public Class working_with_numbers
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Double
        num1 = Val(TextBox1.Text)
        TextBox2.Text = Math.Abs(num1)
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num2 As Double
        num2 = Val(TextBox1.Text)
        TextBox2.Text = Math.Exp(num2)
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num3 As Double
        num3 = Val(TextBox1.Text)
        TextBox2.Text = Math.Sqrt(num3)
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num4 As Double
        num4 = Val(TextBox1.Text)
        TextBox2.Text = Math.Log(num4)
    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim num5 As Double
        num5 = Val(TextBox1.Text)
        TextBox2.Text = Math.Tan(num5)


    End Sub
End Class
