'David Harmon
'RCET0265
'Fall 2020
'Say My Name
'https://github.com/harmdavi/David_sayMyName.git


Option Strict On
Option Explicit On
Option Compare Binary


Module David_sayMyName

    Sub Main()
        Dim userResponce As String
        Do Until userResponce = "q"
            Console.WriteLine("Hello There! What is your name?")
            userResponce = Console.ReadLine()
            If userResponce = "Say my name" Then
                Console.WriteLine("umm... come again?")
                userResponce = Console.ReadLine()
            ElseIf userResponce = "q" Then
                Exit Sub
            End If
            If userResponce = "Say my name" Then
                Console.WriteLine("Heisenberg")
            ElseIf userResponce = "q" Then
                Exit Sub
            Else Console.WriteLine("Well hello there " & userResponce & "!" & vbNewLine & "Press Q to Exit")

            End If
            If Console.ReadLine() = "q" Then
                Exit Sub
            End If
            Console.Clear()
        Loop
    End Sub


End Module
