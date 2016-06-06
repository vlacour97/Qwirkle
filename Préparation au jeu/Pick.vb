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
        Dim value As Integer = tokens(id)
        tokens(id) = Nothing
        Return value
    End Function

    Function count() As Integer
        Dim response As Integer = 0
        For Each token As Integer In tokens
            If (Not (token = 0)) Then
                response += 1
            End If
        Next
        Return response
    End Function

    Function isEmpty() As Boolean
        For Each token As Integer In tokens
            If (Not (token = 0)) Then
                Return False
            End If
        Next
        Return True
    End Function

    Function tokenInSameColor(ByVal token1 As Integer, ByVal token2 As Integer)
        If (Math.Truncate(token1 / 10) = Math.Truncate(token2 / 10)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function tokenInSameForm(ByVal token1 As Integer, ByVal token2 As Integer)
        If (token1 Mod 10 = token2 Mod 10) Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub DropTokenInPick(ByVal tokensArray() As Integer)
        Dim counter As Integer = 0
        For i As Integer = 0 To tokens.Length
            If (tokens(i) = 0) Then
                tokens(i) = tokensArray(counter)
                counter = counter + 1
            End If
            If (counter = tokensArray.Length) Then
                Exit For
            End If
        Next
    End Sub

    Sub ClearPick()
        For i As Integer = 0 To tokens.Length - 1
            tokens(i) = 0
        Next
    End Sub

End Class
