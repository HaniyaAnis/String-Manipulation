Module Module1

    Sub Main()
        Dim string1, string2, FirstWord, SecondWord As String
        Dim space As Integer

        string1 = ""
        string2 = ""
        space = 0
        FirstWord = ""
        SecondWord = ""

        Console.Write(" ENTER FIRST STRING: ")
        string1 = Console.ReadLine
        Console.Write(" ENTER SECOND STRING: ")
        string2 = Console.ReadLine

        space = InStr(string1, " ")
        FirstWord = Left(string1, space - 1)

        space = InStr(string2, " ")
        SecondWord = Right(string2, Len(string2) - space)

        Console.WriteLine(" FINAL STRING = " & FirstWord & " " & SecondWord)
        Console.ReadKey()


    End Sub

End Module
