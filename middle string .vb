Module Module1

    Sub Main()
        Dim str1, Midword As String
        Dim sp1, sp2 As Integer

        str1 = ""
        Midword = ""
        sp1 = 0
        sp2 = 0


        Console.Write("ENTER STRING: ")
        str1 = Console.ReadLine

        sp1 = InStr(str1, " ")
        sp2 = InStr(sp1 + 1, str1, " ")
        Midword = Mid(str1, sp1 + 1, sp2 - sp1 - 1)

        Console.Write(" MIDDLE WORD IS: " & Midword)
        Console.ReadKey()



    End Sub

End Module
