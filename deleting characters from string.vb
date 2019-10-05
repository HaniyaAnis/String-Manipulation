Module Module1

    Sub Main()
        Dim string1, string2 As String

        Dim counter As Integer
        Dim NextChar, DelChar As Char

        string1 = ""
        string2 = ""
        Counter = 0
        NextChar = ""
        DelChar = ""


        Console.Write("ENTER STRING: ")
        string1 = Console.ReadLine

        Console.Write("ENTER CHARACTER TO BE DELETED: ")
        DelChar = Console.ReadLine

        For counter = 1 To Len(string1)
            NextChar = Mid(string1, counter, 1)

            If NextChar <> DelChar Then  
                string2 = string2 + NextChar
            End If

        Next counter

        Console.WriteLine("FINAL STRING IS: " & string2)

        Console.ReadKey()
    End Sub

End Module
