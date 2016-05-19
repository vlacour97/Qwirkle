Public Class Pick

    Dim tokens(107) As Integer

    Sub New()
        generatePick()
    End Sub

    Sub generatePick()
        Dim counter As Integer = 0
        For nb_pick As Integer = 0 To 2
            For tempColor As Integer = 1 To 6
                For tempForm As Integer = 1 To 6
                    tokens(counter) = tempColor * 10 + tempForm
                    counter = counter + 1
                Next
            Next
        Next
    End Sub

    Function getToken(ByVal id As Integer) As Integer
        Return tokens(id)
    End Function

    Function isEmpty() As Boolean
        Dim response As Boolean = True
        For Each token As Boolean In tokens
            If (Not IsNothing(token)) Then
                response = False
            End If
        Next
        Return response
    End Function

End Class
