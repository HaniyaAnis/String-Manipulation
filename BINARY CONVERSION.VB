Module Module1

    Sub Main()
        Dim BinStr As String
        Dim Counter, Index, Length, DENARY, NEXTVAL As Integer
        Dim NextChar As String
        Dim ValidBinaryString As Boolean
        Dim answer As Char
        BinStr = ""
        Denary = 0
        Counter = 0
        Index = 0
        Length = 0
        NextChar = ""
        NEXTVAL = 0
        ValidBinaryString = True
        answer = ""

        Console.Write("Enter Binary Number: ")
        BinStr = Console.ReadLine

        If Len(BinStr) >= 1 And Len(BinStr) <= 8 Then
            ValidBinaryString = True

            For Counter = 1 To Len(BinStr)
                NextChar = Mid(BinStr, Counter, 1)
                If NextChar = 0 Or NextChar = 1 Then
                    ValidBinaryString = True
                Else
                    ValidBinaryString = False
                End If
            Next
        Else
            ValidBinaryString = False

        End If

        If ValidBinaryString = True Then
            Console.WriteLine(" A Valid Binary Number. Do you want to proceed to conversion? enter 'Y' for yes.")
            answer = Console.ReadLine
            While answer = "Y"
                Index = 0
                For Length = 1 To Len(BinStr)
                    NEXTVAL = Right(BinStr, Length)
                    If NEXTVAL <> 0 Then
                        DENARY = DENARY + (2 ^ Index)
                        Index = Index + 1
                    Else
                        Index = Index + 1
                    End If

                Next
                Console.WriteLine(BinStr & " = " & DENARY)
            End While
        Else
            Console.WriteLine(" Not a valid binary number...")
        End If
        Console.ReadKey()
    End Sub

End Module
