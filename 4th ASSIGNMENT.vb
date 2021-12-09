Module Module1

    Sub Main()
        Dim str1, str2 As String
        Dim char1, char2, char3 As Char
        Dim i, j, counter, mostrepeated As Integer

        str1 = ""
        str2 = ""
        char1 = ""
        i = 0
        j = 0
        counter = 0
        mostrepeated = 0


        Console.WriteLine("enter your string: ")
        str1 = Console.ReadLine

        For i = 1 To Len(str1)
            char3 = Mid(str1, i, 1)
            counter = 0
            For j = 1 To Len(str1)
                char2 = Mid(str1, j, 1)
                If char2 = char3 Then
                    counter = counter + 1

                End If

            Next j

            If mostrepeated < counter Then
                mostrepeated = counter
                char1 = char3
            End If


        Next i

        Console.WriteLine("most repeated is: " & char1)
        Console.ReadKey()

    End Sub

End Module
