
Imports System
Module Program
    Sub Main()
        Console.WriteLine("Welcome to the Cafe!")
        Console.WriteLine(Environment.NewLine)
        Console.WriteLine("\n Menu : Price")
        Dim menuItems As New Dictionary(Of String, Integer) From {
            {"Tea", 10},
            {"Samosa", 15},
            {"Pizza", 70},
            {"Burger", 40}
        }

        For Each item As KeyValuePair(Of String, Integer) In menuItems
            For i = 1 To 5

            Next
            Console.WriteLine(i & item.Key & " : " & item.Value)
        Next






        ' Console.WriteLine("Thank you for your order!")
        'Console.ReadLine()
    End Sub
End Module
