Imports System

Module Program
    Sub Main()
        Dim totalCost As Integer = 0

        Console.WriteLine("Welcome to the Cafe Menu!")
        Console.WriteLine("Menu:")
        Console.WriteLine("1. Coffee - INR 20")
        Console.WriteLine("2. Tea - INR 10")
        Console.WriteLine("3. Sandwich - INR35")
        Console.WriteLine("4. Pizza - INR 70")
        Console.WriteLine("5. Burger - INR 40")
        Console.WriteLine("6. Noodles - INR 50")
        Console.WriteLine("7. Exit")

        While True
            Console.Write("Enter your choice (1-5): ")
            Dim choice As Integer = Console.ReadLine()

            Select Case choice
                Case 1
                    totalCost += 20
                Case 2
                    totalCost += 10
                Case 3
                    totalCost += 35
                Case 4
                    totalCost += 70
                Case 5
                    totalCost += 40
                Case 6
                    totalCost += 50
                Case 7
                    Exit While
                Case Else
                    Console.WriteLine("Invalid choice! Please enter a valid option.")
            End Select
        End While

        Console.WriteLine("Thank you for your order!")
        Console.WriteLine("Enjoy your meal :-)")
        Console.WriteLine("Your total cost is: " & totalCost & " INR")

    End Sub


End Module