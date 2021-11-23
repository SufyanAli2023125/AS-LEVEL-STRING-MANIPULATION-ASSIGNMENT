Module Module1

    Sub Main()
        Dim STR1, STR2 As String
        Dim CHAR1, CHAR2, CHAR3 As Char
        Dim I As Integer

        STR1 = ""
        STR2 = ""
        CHAR1 = ""
        CHAR2 = ""
        CHAR3 = ""
        I = 0

        Console.WriteLine("ENTER THE STRING YOU WANT TO PROCESS: ")
        STR1 = Console.ReadLine

        Console.WriteLine("ENTER THE WORD YOU WANT TO CHANGE: ")
        CHAR1 = Console.ReadLine

        Console.WriteLine("ENTER THE WORD FOR YOUR REPLACEMENT: ")
        CHAR3 = Console.ReadLine


        For I = 1 To Len(STR1)
            CHAR2 = Mid(STR1, I, 1)
            If CHAR1 <> CHAR2 Then
                STR2 = STR2 & CHAR2
            Else
                STR2 = STR2 & CHAR3

            End If
        Next
        Console.WriteLine("HERE IS YOUR CHANGED WORD: " & STR2)

        Console.ReadKey()

    End Sub

End Module
