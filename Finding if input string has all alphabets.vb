Module Module1

    Sub Main()
        Dim str1, str2 As String
        Dim char1 As Char
        Dim i As Integer
        Dim alphabets As Boolean

        str1 = ""
        str2 = "abcdefghijklmnopqrstuvwxyz"
        char1 = ""
        i = "0"
        alphabets = "true"




        Console.WriteLine("enter your string: ")
        str1 = Console.ReadLine
        str1 = LCase(str1)





        For i = 1 To Len(str2)
            char1 = Mid(str2, i, 1)

            If InStr(str1, char1) = 0 Then
                alphabets = False
                If alphabets = False Then Exit For


            End If

        Next i

        If alphabets = True Then

            Console.WriteLine("the entered string has all the alphabets")
        Else

            Console.WriteLine("entered string does not have all of the alphabets")


        End If

        Console.ReadKey()






    End Sub

End Module
