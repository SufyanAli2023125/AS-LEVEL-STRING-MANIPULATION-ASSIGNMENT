Module Module1

    Sub Main()
        Dim a, b, str1, str2, e, f, g, h, l As String
        Dim i, j, z As Integer

        a = ""
        b = ""
        str1 = ""
        str2 = ""
        e = ""
        f = ""
        g = ""
        h = ""
        l = ""
        z = 0
        i = 0
        j = 0

        Console.WriteLine("enter first string: ")
        str1 = Console.ReadLine

        Console.WriteLine("enter second string: ")
        str2 = Console.ReadLine

        For i = 1 To Len(str1)

            e = Mid(str1, 1, 2)
            a = e

        Next

        For j = 1 To Len(str2)
            f = Mid(str2, 1, 2)
            b = f

        Next

        For i = 1 To Len(str1)
            g = Right(str1, 1)


        Next

        For j = 1 To Len(str2)
            h = Right(str2, 1)

        Next


        For z = 1 To Len(str2)
            l = Mid(str2, 3)


        Next



        Console.WriteLine("your altered string: " & b & g & " " & a & l)
        Console.ReadKey()




    End Sub

End Module
