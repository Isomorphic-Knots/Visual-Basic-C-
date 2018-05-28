Module Module1

    Function JoinStrings(strings() As String) As String

        If strings.Length = 0 Then
            Console.WriteLine("String array is empty!")
            Return Nothing
        Else
            Dim result As String = strings(0)
            For i = 1 To strings.Length - 1
                result &= " " & strings(i)
            Next

            Return result
        End If


    End Function


    Sub Main()

        Dim Str As String
        Dim stringz As New List(Of String)

        Do
            Console.Write("Please enter a sentence (ENTER to exit): ")
            Str = Console.ReadLine

            If Str <> "" Then
                stringz.Add(Str)
            End If

        Loop Until Str = ""

        Console.WriteLine(JoinStrings(stringz.ToArray))
        Console.ReadLine()
    End Sub

End Module
