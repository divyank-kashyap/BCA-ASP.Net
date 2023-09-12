Module Program
    Sub Main(args As String())
        Dim marks As Integer() = New Integer(9) {} ' Change the size to 9 to store 10 values (0 to 9)

        For i = 0 To 9 Step 1
            Console.WriteLine("Enter marks for student " & (i + 1) & " : ")
            marks(i) = Integer.Parse(Console.ReadLine())
        Next

        Array.Sort(marks)
        Console.WriteLine("Marks after sorting: ")

        For i = 0 To 9 Step 1
            Console.WriteLine("Student " & (i + 1) & " : " & marks(i))
        Next
    End Sub
End Module
