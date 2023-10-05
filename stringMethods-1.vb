Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Dim str1 As String = "hello world"
    Dim str2 As String = "HELLO PEOPLE"
    Dim str3 As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim letter1 As Char
        Dim letter2 As Char
        letter1 = str1.Chars(3)
        letter2 = str2.Chars(8)
        MsgBox("Character on 3rd position of string is " & letter1 & vbCrLf & "Character on 8th position of string is " & letter2)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        str3 = String.Copy(str1 & str2)
        MsgBox("After copying both strings in a 3rd string : " & str3)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim l As Integer
        Dim l1 As Integer
        l = str1.Length
        l1 = str2.Length
        MsgBox("Length of 1st string is " & l & vbCrLf & "Length of 2nd string is " & l1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim str As String
        MsgBox("String 1 in uppercase form = " & str1.ToUpper() & vbCrLf & "String 2 in lowercase form = " & str2.ToLower())
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim r As String
        Dim r1 As String
        r = str1 + str2
        r1 = str1 & str2
        MsgBox("After appending both strings : " & r1 & vbCrLf & "After joining both strings : " & r)
    End Sub
End Class

