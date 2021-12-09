Module Module1

    Sub Main()
        Dim s, str2, str3 As String
        Dim char1 As Char
        Dim i As Integer

        s = ""
        str2 = ""
        str3 = ""
        char1 = ""
        i = 0

        Console.WriteLine("enter your string: ")
        s = Console.ReadLine

        str2 = Left(s, 2)
        str3 = Right(s, 2)

        For i = 1 To Len(s)
            char1 = Mid(s, 3, 2)

            str2 = str2 & str3



            Console.WriteLine("altered string: " & str2)
            Console.ReadKey()

        Next



    End Sub

End Module
