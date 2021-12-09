Module Module1

    Sub Main()
        Dim str1 As String
        Dim i, donutcounter, donuts As Integer

        donuts = 0
        donutcounter = 0
        i = 0

        Console.WriteLine("donuts: ")
        donutcounter = Console.ReadLine

        For i = 1 To 10
            If donutcounter >= "1" And donutcounter <= "10" Then
                str1 = donutcounter

                Console.WriteLine("number of donuts: " & str1)


            ElseIf donutcounter > 10 Then
                Console.WriteLine("too many donuts")
            End If
            Console.ReadKey()
        Next
    End Sub

End Module
