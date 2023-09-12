Imports System
Imports System.Runtime.ConstrainedExecution

Module Program
    Sub Main()
        Dim sub1, sub2, sub3, sub4, sub5, total As Integer
        Dim name As String
        Dim per As Double

        Console.WriteLine("Enter the name:")
        name = Console.ReadLine()

        Console.WriteLine("Enter the Marks:")
        sub1 = Console.ReadLine()
        Console.WriteLine("Enter the Marks:")
        sub2 = Console.ReadLine()
        Console.WriteLine("Enter the Marks:")
        sub3 = Console.ReadLine()
        Console.WriteLine("Enter the Marks:")
        sub4 = Console.ReadLine()
        Console.WriteLine("Enter the Marks:")
        sub5 = Console.ReadLine()

        total = sub1 + sub2 + sub3 + sub4 + sub5
        per = total / 5
        Console.WriteLine("Total Marks = " & total)
        Console.WriteLine("Average = " & per)




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
