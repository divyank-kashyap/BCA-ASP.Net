Imports System

Module Program
    Sub Main()
        Dim a As Integer = 10
        Dim b As Integer = 20

        Console.WriteLine("Before swapping:")
        Console.WriteLine("a = " & a)
        Console.WriteLine("b = " & b)

        ' Swap using pass by value
        SwapByValue(a, b)

        Console.WriteLine("After swapping by value:")
        Console.WriteLine("a = " & a)
        Console.WriteLine("b = " & b)

        ' Swap using pass by reference
        SwapByReference(a, b)

        Console.WriteLine("After swapping by reference:")
        Console.WriteLine("a = " & a)
        Console.WriteLine("b = " & b)

        Console.ReadLine()
    End Sub

    Sub SwapByValue(ByVal x As Integer, ByVal y As Integer)
        Dim temp As Integer
        temp = x
        x = y
        y = temp
    End Sub

    Sub SwapByReference(ByRef x As Integer, ByRef y As Integer)
        Dim temp As Integer
        temp = x
        x = y
        y = temp
    End Sub
End Module
