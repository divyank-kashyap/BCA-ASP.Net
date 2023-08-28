Imports System

Module Program
    Sub Main(args As String())
        Dim rollNo() As Integer = {1, 2, 3, 4, 5}
        Dim name() As String
        name = {"Akshay", "Anup", "Divyank", "Vikrant", "Nitish"}

        For i As Integer = 0 To 4 Step 1
            Console.WriteLine("My name is " & name(i) & " and my Roll Number is " & rollNo(i))
        Next



    End Sub

End Module
