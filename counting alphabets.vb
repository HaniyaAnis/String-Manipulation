Module Module1

    Sub Main()
        Dim str As String
        Dim MyChar As Char
        Dim Alphabets, NotAlphabets, Counter As Integer

        str = ""
        MyChar = ""
        Alphabets = 0
        NotAlphabets = 0
        Counter = 0

        Console.Write("ENTER STRING: ")
        str = Console.ReadLine

        For Counter = 1 To Len(str)
            MyChar = Mid(str, Counter, 1)
            If LCase(MyChar) >= "a" And LCase(MyChar) <= "z" Then

                Alphabets = Alphabets + 1
            Else
                NotAlphabets = NotAlphabets + 1
            End If
        Next Counter

        Console.Write("NUMBER OF ALPHABETS ARE " & Alphabets & " AND NIMBER OF CHARACTERS ARE " & NotAlphabets)
        Console.ReadKey()


    End Sub

End Module
