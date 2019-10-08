Module Module1

    Sub Main()

        Dim str1, str2, str3, str4 As String
        Dim sum, NUM, length, alpha, count As Integer
        Dim panagram, flag As Boolean
        Dim NextChar As Char
        Const SP = " "
        str1 = ""
        sum = 0
        panagram = False
        alpha = 96
        NextChar = ""
        str2 = ""
        flag = False
        count = 1

        Console.Write("ENTER STRING: ")
        str1 = Console.ReadLine

        For length = 1 To Len(str1)
            NextChar = Mid(str1, length, 1)
            If NextChar <> SP Then
                str2 = str2 & NextChar
            End If

        Next


        str3 = LCase(str2)

        For count = 1 To 26
            alpha = alpha + 1
            str4 = Chr(alpha)
            NUM = InStr(str3, str4)
            If NUM <> 0 Then
                flag = True
                panagram = True
            Else
                flag = False
                panagram = False
            End If

        Next
        If panagram = True Then
            Console.WriteLine(" IS A PANAGRAM")
        Else
            panagram = False
            Console.WriteLine(" NOT A PANAGRAM")


        End If
        Console.ReadKey()

    End Sub

End Module
