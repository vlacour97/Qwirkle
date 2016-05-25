Public Class User

    Dim name As String
    Dim age As Integer
    Dim nb_points As Integer
    Dim deckArray(5) As Integer
    Dim sizeBestDeck As Integer

    Sub New(ByVal nameValue As String, ByVal ageValue As Integer)
        name = nameValue
        age = ageValue
        nb_points = 0
        sizeBestDeck = 0
    End Sub

    Sub setNbPoints(ByVal nbPoints As Integer)
        nb_points = nbPoints
    End Sub

    Function getAge() As Integer
        Return age
    End Function

    Function getName() As String
        Return name
    End Function

    Function getNbPoints() As Integer
        Return nb_points
    End Function

    Sub generateDeck(ByRef pick)
        Dim tokenId As Integer
        For counter As Integer = 0 To deckArray.Length - 1
            Dim pickIsEmpty As Boolean = pick.isEmpty
            If (Not pickIsEmpty) Then
                While (deckArray(counter) = 0 And Not pickIsEmpty)
                    tokenId = CInt(107 * Rnd())
                    deckArray(counter) = pick.getToken(tokenId)
                End While
            End If
        Next
    End Sub

    Function getDeckArray() As Integer()
        Return deckArray
    End Function

    Sub setDeckArray(ByVal array() As Integer)
        deckArray = array
    End Sub

    Sub setSizeBestDeck(ByVal size As Integer)
        sizeBestDeck = size
    End Sub

    Function getSizeBestDeck() As Integer
        Return sizeBestDeck
    End Function

    Sub deleteToken(ByVal id As Integer)
        For i As Integer = 0 To deckArray.Length - 1
            If (deckArray(i) = id) Then
                deckArray(i) = 0
                Exit For
            End If
        Next
    End Sub

    Function deckIsEmpty() As Boolean
        Dim response As Boolean = True
        For Each token In deckArray
            If (Not (token = 0)) Then
                response = False
            End If
        Next
        Return response
    End Function

    Sub AddPoints(ByVal nb_point As Integer)
        nb_points += nb_point
    End Sub

    Sub dipIntoPick(ByRef pick)
        Dim tokenId As Integer
        For i As Integer = 0 To deckArray.Length - 1
            Dim pickIsEmpty As Boolean = pick.isEmpty
            If (Not pickIsEmpty And deckArray(i) = 0) Then
                While (deckArray(i) = 0 And Not pickIsEmpty)
                    tokenId = CInt(107 * Rnd())
                    deckArray(i) = pick.getToken(tokenId)
                End While
            End If
        Next
    End Sub

    Function getTokenName(ByVal tokenCode As Integer)
        Dim color As String
        Dim form As String
        Select Case tokenCode
            Case 10 To 16
                color = "Rouge"
            Case 20 To 26
                color = "Orange"
            Case 30 To 36
                color = "Jaune"
            Case 40 To 46
                color = "Vert"
            Case 50 To 56
                color = "Bleu"
            Case 60 To 66
                color = "Violet"
            Case Else
                Return "nothing"
        End Select
        Select Case tokenCode Mod 10
            Case 1
                form = "Rond"
            Case 2
                form = "Croix"
            Case 3
                form = "Losange"
            Case 4
                form = "Carre"
            Case 5
                form = "Etoile"
            Case 6
                form = "Trefle"
            Case Else
                Return "nothing"
        End Select
        Return form & color
    End Function

    'Indicateur de couleur
    '10 : Rouge
    '20 : Orange
    '30 : Jaune
    '40 : Vert
    '50 : Bleu
    '60 : Violet
    'Indicateur de forme
    '1 : Rond
    '2 : Croix
    '3 : Losange
    '4 : Carré
    '5 : Etoile
    '6 : Plus
End Class
