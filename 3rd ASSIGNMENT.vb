Module Module1

    Sub Main()
        Dim str1, str2, str3, str4, str5, spch As String
        Dim char1, char2 As Char
        Dim i, wordcounter, chrcount, digicounter, alphacount, spchcount As Integer

        str1 = ""
        str2 = ""
        i = 0
        wordcounter = 0
        str3 = ""
        str4 = ""
        str5 = ""
        chrcount = 0
        digicounter = 0
        char1 = ""
        char2 = ""
        spch = ""
        alphacount = 0
        spchcount = 0


        Console.Write("Enter your string: ")
        str3 = Console.ReadLine

        Console.Write("Enter character for counting: ")
        str5 = Console.ReadLine

        For i = 1 To Len(str3)
            str1 = Mid(str3, i, 1)

            If (str1) = (str5) Then
                chrcount = chrcount + 1

            End If
        Next
        Console.WriteLine("this character appears this many times: " & chrcount)

        For i = 1 To Len(str3)
            char1 = Mid(str3, i, 1)
            str3 = LCase(str3)
            If char1 >= "a" And char1 <= "z" Then
                alphacount = alphacount + 1

            ElseIf char1 >= "0" And char1 <= "9" Then
                digicounter = digicounter + 1

            Else

                spchcount = spchcount + 1
            End If

        Next i

        Console.WriteLine("The alphabets in this sentence are: " & alphacount)
        Console.WriteLine("The digits in this sentence is: " & digicounter)
        Console.WriteLine("number of special characters: " & spchcount)
            Console.ReadKey()
    End Sub

End Module
