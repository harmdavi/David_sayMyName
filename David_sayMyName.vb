'David Harmon
'RCET0265
'Fall 2020
'Say My Name
'https://github.com/rosstimo/MyRepo.git


Option Strict On
Option Explicit On
Option Compare Binary


Module David_sayMyName

    Sub Main()

        Dim userResponce As String
        Console.WriteLine("Hello There! What is your name?")
        userResponce = Console.ReadLine()
        If userResponce = "Say my name" Then
            Console.WriteLine("umm... come again?")
            userResponce = Console.ReadLine()
        End If
        If userResponce = "Say my name" Then
            Console.WriteLine("Heisenberg")
        Else Console.WriteLine("Well hello there " & userResponce & "!")

        End If
        Console.ReadLine()
    End Sub

End Module
