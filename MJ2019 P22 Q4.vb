Module Module1

    Sub Main()
        Dim NewString As String
        Dim Index, Selected, NewValue As Integer
        Dim NextChar As Char
        NewString = ""
        Selected = 0
        Const InString = "12 34 5  39"
        For Index = 1 To Len(InString)
            NextChar = Mid(InString, Index, 1)
            If NextChar < "0" Or NextChar > "9" Then
                NewValue = Val(NewString)
                If NewValue > Selected Then

                    Selected = NewValue
                End If
                NewString = 0
            Else
                NewString = NewString & NextChar
            End If
        Next Index
        Console.WriteLine(Selected)
        Console.ReadKey()

    End Sub

End Module
