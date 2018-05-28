Module Module1

    Sub Main()

        Dim numbers As New List(Of Integer)
        Dim summation As Integer
        Dim filenum = FreeFile()

        'Openmode to start new file if it doesnt exist
        'Append to add to a file that does exist
        'here we use open mode
        FileOpen(filenum, "testfile.txt", OpenMode.Output)

        For i = 0 To 100

            numbers.Add(i)
        Next

        PrintLine(filenum, "Number of list elements: " & numbers.Count)
        Print(filenum, "list of elements: ")

        For i = 0 To numbers.Count - 1
            Print(filenum, numbers(i) & " ")

            summation = numbers(i) + summation
        Next

        PrintLine(filenum, " ")
        PrintLine(filenum, "Summation of all integers: " & summation)

        FileClose(filenum)

        'tests for input to console for output'
        FileOpen(filenum, "testfile.txt", OpenMode.Input)
        While Not EOF(filenum)
            Console.WriteLine(LineInput(filenum))
            Console.ReadLine()
        End While
        FileClose(filenum)


    End Sub

End Module
