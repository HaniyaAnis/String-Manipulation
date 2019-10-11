Module Module1

    Sub Main()
        Dim str1, characters, numbers, letters As String
        Dim index As Integer
        Dim nextchar As Char

        str1 = ""
        characters = ""
        letters = ""
        numbers = ""
        index = 0
        nextchar = ""

        Console.Write(" ENTER STRING: ")
        str1 = Console.ReadLine


        For index = 1 To Len(str1)
            nextchar = Mid(str1, index, 1)
            If nextchar >= "a" And nextchar <= "z" Then
                letters = letters & nextchar
            ElseIf nextchar >= "0" And nextchar <= "9" Then
                numbers = numbers & nextchar
            Else
                characters = characters & nextchar
            End If

        Next

        Console.Write("letters in string are: " & letters & " " & "characters in string are: " & characters & " " & "numbers in string are: " & numbers)
        Console.ReadKey()


    End Sub

End Module
