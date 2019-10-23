Module Module1

    Sub Main()
        Dim str, str1, str2, str3 As String
        Dim sp, sp1 As Integer

        Console.Write(" enter string: ")
        str = Console.ReadLine
        sp = InStr(str, " ")
        str1 = Left(str, sp - 1)
        sp1 = InStr(sp + 1, str, " ")
        str2 = Mid(str, sp + 1, sp1 - sp)
        str3 = Mid(str, sp1 + 1, Len(str) - sp1)
        Console.WriteLine(str1)
        Console.WriteLine(str2)
        Console.WriteLine(str3)
        Console.WriteLine(sp1)
        Console.ReadKey()



    End Sub

End Module
