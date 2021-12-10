Module Module1

    Sub Main()
        Dim str1, str2, str3, str4, str5 As String
        Dim i, j As Integer

        str1 = ""
        str2 = "ing"
        str3 = "ly"
        str4 = ""
        str5 = ""
        i = 0
        j = 0

        Console.WriteLine("enter your string: ")
        str1 = Console.ReadLine



        If Len(str1) < 3 Then

        Else
            str4 = Right(str1, 3)
            If str4 <> str2 Then
                str1 = str1 & str2


            Else
                If str4 = str2 Then
                    str1 = str1 & str3

                End If
            End If

        End If

        Console.WriteLine("your final string: " & str1)
        Console.ReadKey()
    End Sub

End Module
