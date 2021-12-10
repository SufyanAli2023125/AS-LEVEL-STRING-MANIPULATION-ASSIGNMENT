Module Module1

    Sub Main()
        Dim str1, str2, str3, replace As String
        Dim char1, char2 As Char
        Dim i As Integer

        str1 = ""
        str2 = ""
        str3 = ""
        replace = "*"
        char1 = ""
        char2 = ""
        i = 0

        Console.WriteLine("enter your string: ")
        str1 = Console.ReadLine


        For i = 2 To Len(str1)
            char1 = Left(str1, 1)
            char2 = Mid(str1, i, 1)

            If char1 <> char2 Then
                str2 = str2 & char2

            Else
                str2 = str2 & replace


            End If
        Next
        Console.WriteLine("altered string: " & char1 & str2)
        Console.ReadKey()


    End Sub

End Module
