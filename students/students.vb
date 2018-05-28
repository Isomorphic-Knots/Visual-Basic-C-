Module Module1
    Class STUDENT
        Public firstname As String
        Public lastname As String
        Public dob As Date

    End Class

    Dim students(9) As STUDENT
    Dim studentCount As Integer = 0
    Sub Main()

        For Each element As STUDENT In students
            element = New STUDENT
            studentCount += 1
        Next


    End Sub

End Module
