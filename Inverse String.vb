Module Module1

    Sub Main()
        Dim str1, str2 As String
        Dim index As Integer
        Dim nextchar As Char

        str1 = ""
        str2 = ""
        index = 0
        nextchar = ""

        Console.Write(" ENTER STRING: ")
        str1 = Console.ReadLine

        For index = 1 To Len(str1)
            nextchar = Right(str1, index)
            str2 = str2 & nextchar

        Next

        Console.Write("inverse string: " & str2)
        Console.ReadKey()

    End Sub

End Module
