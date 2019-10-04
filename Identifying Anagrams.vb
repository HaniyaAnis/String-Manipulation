Module Module1

    Sub Main()

        Dim string1, string2 As String
        Dim Counter, var1, var2 As Integer

        string1 = ""
        string2 = ""
        Counter = 0
        var1 = 0
        var2 = 0

        Console.Write("ENTER STRING1: ")
        string1 = Console.ReadLine
        Console.Write("ENTER STRING2: ")
        string2 = Console.ReadLine

        If Len(string1) <> Len(string2) Then

            Console.WriteLine(string1 & " AND " & string2 & " are not anagrams")
        Else


            LCase(string1)
            LCase(string2)

            For Counter = 1 To Len(string1)

                var1 = var1 + Asc(Mid(string1, Counter, 1))
                var2 = var2 + Asc(Mid(string2, Counter, 1))

            Next Counter
            If var1 = var2 Then

                Console.WriteLine(string1 & " AND " & string2 & " are anagrams")
            Else

                Console.WriteLine(string1 & " AND " & string2 & " are not anagrams")
            End If
        End If
        Console.ReadKey()

    End Sub

End Module
