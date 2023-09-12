Imports System

Module Program
    Sub Main(args As String())
        Dim item As Integer
        Dim bill As Integer
        Dim order As Integer
        Dim totalbill As Integer

        Console.WriteLine("Welcome to the Cafe!")
        Console.WriteLine("Menu:")
        Console.WriteLine("1. Coffee - 20 INR")
        Console.WriteLine("2. Tea - 10 INR")
        Console.WriteLine("3. Cold Drink - 30 INR")
        Console.WriteLine("4. Sandwich - 45 INR")
        Console.WriteLine("5. Pastry - 50 INR")
        Console.WriteLine("6. Cake - 140 INR")


        Dim ans As String = "yes"
        While True
            If (ans = "no") Then
                Exit While
            ElseIf ans = "yes" Then
                Console.WriteLine("Enter order no. = ")
                item = Console.ReadLine()
                Select Case item
                    Case 1
                        Console.WriteLine("How many Coffee do you want to order?")
                        order = Console.ReadLine()
                        bill = order * 20
                        totalbill += bill
                        Console.WriteLine("Do you want to order anything else? :)  (yes/no)")
                        ans = Console.ReadLine()

                    Case 2
                        Console.WriteLine("How many Tea do you want to order?")
                        order = Console.ReadLine()
                        bill = order * 10
                        totalbill += bill
                        Console.WriteLine("Do you want to order anything else? :)   (yes/no)")
                        ans = Console.ReadLine()

                    Case 3
                        Console.WriteLine("How many Cold Drinks do you want to order ?")
                        order = Console.ReadLine()
                        bill = order * 30
                        totalbill += bill
                        Console.WriteLine("Do you want to order anything else? :)   (yes/no)")
                        ans = Console.ReadLine()

                    Case 4
                        Console.WriteLine("How many Sandwich do you want to order ?")
                        order = Console.ReadLine()
                        bill = order * 45
                        totalbill += bill
                        Console.WriteLine()
                        Console.WriteLine("Do you want to order anything else? :)    (yes/no)")
                        ans = Console.ReadLine()
                    Case 5
                        Console.WriteLine("How many Pastry do you want to order ?")
                        order = Console.ReadLine()
                        bill = order * 50
                        totalbill += bill
                        Console.WriteLine("Do you want to order anything else? :)    (yes/no)")
                        ans = Console.ReadLine()
                    Case 6
                        Console.WriteLine("How many Cake do you want to order ?")
                        order = Console.ReadLine()
                        bill = order * 140
                        totalbill += bill
                        Console.WriteLine("Do you want to order anything else? :)    (yes/no)")
                        ans = Console.ReadLine()
                    Case Else
                        Console.WriteLine("Invalid Operation!")
                End Select

            End If
        End While
        Console.WriteLine(vbCrLf & "Total bill of your order is = {0}", totalbill & "INR" & vbCrLf & "THANK YOU FOR COMING :>)... HAVE A NICE DAY ")
        Console.ReadLine()
    End Sub
End Module
