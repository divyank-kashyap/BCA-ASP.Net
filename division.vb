Imports System

Module Program
    Sub Main()
        Dim total As Integer
        Dim name As String
        Dim per As Double
        Dim marks As Double() = New Double(5) {}

        Console.WriteLine("Enter name:")
        name = Console.ReadLine()
        For i = 0 To 4 Step 1
            Console.WriteLine("Enter marks for subject " & (i + 1))
            marks(i) = Console.ReadLine()
        Next

        For i = 0 To 4 Step 1
            total += marks(i)
        Next
        per = total / 500 * 100
        Console.WriteLine("Total Marks = " & total)
        Console.WriteLine("Percentage = " & per)

        If (per >= 75) Then
            Console.WriteLine("1st Division")

        ElseIf (per >= 60) Then
            Console.WriteLine("2nd Division")

        ElseIf (per >= 40) Then
            Console.WriteLine("3rd Division")

        Else
            Console.WriteLine("Fail")
        End If
        Console.ReadLine()
    End Sub
End Module
