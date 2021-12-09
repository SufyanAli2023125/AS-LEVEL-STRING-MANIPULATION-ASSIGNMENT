Module Module1

    Sub Main()
        Dim str1 As String
        Dim char1, char2, char3, char4, char5 As Char
        Dim i, vowelcounta, vowelcounte, vowelcounti, vowelcounto, vowelcountu As Integer

        str1 = ""
        char1 = ""
        i = 0
        vowelcounta = 0
        vowelcounta = 0
        vowelcounte = 0
        vowelcounti = 0
        vowelcounto = 0
        vowelcountu = 0
        char2 = ""
        char3 = ""
        char4 = ""
        char5 = ""


        Console.WriteLine("enter your string(please keep pressing enter for updated count): ")
        str1 = Console.ReadLine

        For i = 1 To Len(str1)
            char1 = Mid(str1, i, 1)
            char1 = LCase(char1)

            If char1 = "a" Then
                vowelcounta = vowelcounta + 1




            End If
        Next i
        Console.WriteLine("number of a's: " & vowelcounta)

        For i = 1 To Len(str1)

            char2 = Mid(str1, i, 1)
            char2 = LCase(char2)

            If char2 = "e" Then
                vowelcounte = vowelcounte + 1



            End If
        Next i
        Console.WriteLine("number of e's: " & vowelcounte)

        For i = 1 To Len(str1)
            char3 = Mid(str1, i, 1)
            char3 = LCase(char3)


            If char3 = "i" Then
                vowelcounti = vowelcounti + 1




            End If
        Next i
        Console.WriteLine("number of i's: " & vowelcounti)

        For i = 1 To Len(str1)
            char4 = Mid(str1, i, 1)
            char4 = LCase(char4)


            If char4 = "o" Then
                vowelcounto = vowelcounto + 1


              
            End If
        Next i
        Console.WriteLine("number of o's: " & vowelcounto)


        For i = 1 To Len(str1)
            char5 = Mid(str1, i, 1)
            char5 = LCase(char5)

            If char5 = "u" Then
                vowelcountu = vowelcountu + 1



            End If
        Next i
        Console.WriteLine("number of u's: " & vowelcountu)
        Console.ReadKey()
    End Sub

End Module
