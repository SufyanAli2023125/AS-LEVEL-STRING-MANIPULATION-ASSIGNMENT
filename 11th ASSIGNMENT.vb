Module Module1

    Sub Main()
        Dim str1, str2, str3, replace, str5, str6, str7 As String
        Dim i As Integer

        str1 = ""
        str2 = " not"
        str3 = "bad"
        replace = "good"
        str5 = ""
        str6 = ""
        str7 = ""
        i = 0

        Console.WriteLine("enter your string: ")
        str1 = Console.ReadLine

        For i = 2 To Len(str1)
            str5 = Mid(str1, i, 4)
            If str5 = str2 Then
                str6 = i
                str7 = Left(str1, i)

                str1 = str7 & replace


            End If



        Next
        Console.WriteLine("your final string: " & str1)
        Console.ReadKey()
    End Sub

End Module
