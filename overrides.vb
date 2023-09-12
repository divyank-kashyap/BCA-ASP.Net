Imports System

Module Program

    Class Person
        Private name As String
        Private phone As Int64

        Public Overridable Sub Read()
            Console.WriteLine("Enter name :")
            name = Console.ReadLine()
            Console.WriteLine("Enter Phone No. :")
            phone = Convert.ToInt64(Console.ReadLine())
        End Sub

        Public Overridable Sub Show()
            Console.WriteLine("Name = {0}", name)
            Console.WriteLine("Phone No. = {0}", phone)
        End Sub
    End Class

    Class Student
        Inherits Person
        Private roll As Integer
        Private course As String

        Public Overrides Sub Read()
            MyBase.Read()
            Console.WriteLine("Enter Roll No. : ")
            roll = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine("Enter Course : ")
            course = Console.ReadLine()
        End Sub

        Public Overrides Sub Show()
            MyBase.Show()
            Console.WriteLine("Roll No. = {0}", roll)
            Console.WriteLine("Course = {0}", course)
        End Sub
    End Class

    Sub Main()
        Dim s1 As New Student()
        s1.Read()
        Console.WriteLine("Display student info = ")
        s1.Show()
    End Sub

End Module
