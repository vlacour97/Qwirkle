Public Class Form_Begin

    Dim nb_player As Integer
    Dim users(3) As User

    Private Sub Form_Begin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enableNames()
        lbl_remplir.Visible = False
        lbl_false.Visible = False
        lbl_name_player.Visible = False
    End Sub

    Private Sub num_nb_player_ValueChanged(sender As Object, e As EventArgs) Handles num_nb_player.ValueChanged
        enableNames()
    End Sub

    Sub enableNames()
        nb_player = num_nb_player.Value
        Select Case nb_player
            Case 2
                txt_box_fname3.Enabled = False
                txt_box_fname4.Enabled = False
                txt_box_age3.Enabled = False
                txt_box_age4.Enabled = False
            Case 3
                txt_box_fname3.Enabled = True
                txt_box_fname4.Enabled = False
                txt_box_age3.Enabled = True
                txt_box_age4.Enabled = False
            Case 4
                txt_box_fname3.Enabled = True
                txt_box_fname4.Enabled = True
                txt_box_age3.Enabled = True
                txt_box_age4.Enabled = True
        End Select
    End Sub

    Function formIsValid() As Boolean
        Dim response As Boolean
        response = False
        Select Case nb_player
            Case 2
                If (txt_box_fname1.Text.Length > 0 And txt_box_fname2.Text.Length > 0 And IsNumeric(txt_box_age1.Text) And IsNumeric(txt_box_age2.Text) And Not IsNumeric(txt_box_fname1.Text) And Not IsNumeric(txt_box_fname2.Text)) Then
                    response = True
                Else
                    response = False
                End If
            Case 3
                If (txt_box_fname1.Text.Length > 0 And txt_box_fname2.Text.Length > 0 And txt_box_fname3.Text.Length > 0 And IsNumeric(txt_box_age1.Text) And IsNumeric(txt_box_age2.Text) And IsNumeric(txt_box_age3.Text) And Not IsNumeric(txt_box_fname1.Text) And Not IsNumeric(txt_box_fname2.Text) And Not IsNumeric(txt_box_fname3.Text)) Then
                    response = True
                Else
                    response = False
                End If
            Case 4
                If (txt_box_fname1.Text.Length > 0 And txt_box_fname2.Text.Length > 0 And txt_box_fname3.Text.Length > 0 And txt_box_fname4.Text.Length > 0 And IsNumeric(txt_box_age1.Text) And IsNumeric(txt_box_age2.Text) And IsNumeric(txt_box_age3.Text) And IsNumeric(txt_box_age4.Text) And Not IsNumeric(txt_box_fname1.Text) And Not IsNumeric(txt_box_fname2.Text) And Not IsNumeric(txt_box_fname3.Text) And Not IsNumeric(txt_box_fname4.Text)) Then
                    response = True
                Else
                    response = False
                End If
        End Select
        Return response
    End Function

    Sub generateUsertab()
        'Génération du tableau temporaire
        Dim usersTemp(3) As User
        For counter As Integer = 0 To users.Length - 1
            usersTemp(counter) = users(counter)
        Next
        'Trie du tableau
        Dim tempUser As User
        For counter As Integer = 0 To users.Length - 1
            tempUser = BestDeckUserInArray(usersTemp)
            users(counter) = tempUser
            deleteUserInArray(usersTemp, tempUser)
        Next
        If users(0).getSizeBestDeck() = users(1).getSizeBestDeck() Then
            For counter As Integer = 0 To users.Length - 1
                usersTemp(counter) = users(counter)
            Next
            Dim counter2 As Integer = 0
            While (usersTemp(counter2).getSizeBestDeck = usersTemp(counter2 + 1).getSizeBestDeck() And counter2 < 2)
                tempUser = OldestUserInArray(usersTemp)
                users(counter2) = tempUser
                deleteUserInArray(usersTemp, tempUser)
                counter2 = counter2 + 1
            End While
        End If
    End Sub

    Function BestDeckUserInArray(ByVal users() As User) As User
        Dim response As User
        response = New User("NC", 0)
        For Each user As User In users
            If (user.getSizeBestDeck > response.getSizeBestDeck) Then
                response = user
            End If
        Next
        Return response
    End Function

    Function OldestUserInArray(ByVal users() As User) As User
        Dim response As User
        response = New User("NC", 0)
        For Each user As User In users
            If (user.getAge > response.getAge) Then
                response = user
            End If
        Next
        Return response
    End Function

    Sub deleteUserInArray(ByRef userArray() As User, ByVal user As User)
        For counter As Integer = 0 To userArray.Length - 1
            If userArray(counter) Is user Then
                userArray(counter) = New User("NC", 0)
            End If
        Next
    End Sub

    Sub initializeUsers()
        users(0) = New User(txt_box_fname1.Text, txt_box_age1.Text)
        users(1) = New User(txt_box_fname2.Text, txt_box_age2.Text)
        If (nb_player > 2) Then
            users(2) = New User(txt_box_fname3.Text, txt_box_age3.Text)
        Else
            users(2) = New User("NC", 0)
        End If
        If (nb_player > 3) Then
            users(3) = New User(txt_box_fname4.Text, txt_box_age4.Text)
        Else
            users(3) = New User("NC", 0)
        End If
    End Sub

    Sub showPlayerNames()
        generateUsertab()
        lbl_first_name.Text = users(0).getName
        lbl_second_name.Text = users(1).getName
        lbl_third_name.Text = users(2).getName
        lbl_fourth_name.Text = users(3).getName
    End Sub

    Sub showDeck(ByVal idUser As Integer)
        Dim user As User = users(idUser)
        user.generateDeck()
        lbl_name_player.Visible = True
        lbl_name_player.Text = user.getName()
        chbox1.Checked = False
        chbox2.Checked = False
        chbox3.Checked = False
        chbox4.Checked = False
        chbox5.Checked = False
        chbox6.Checked = False
        picbox_1.Image = My.Resources.ResourceManager.GetObject(user.getTokenName(user.getDeckArray(0)))
        picbox_2.Image = My.Resources.ResourceManager.GetObject(user.getTokenName(user.getDeckArray(1)))
        picbox_3.Image = My.Resources.ResourceManager.GetObject(user.getTokenName(user.getDeckArray(2)))
        picbox_4.Image = My.Resources.ResourceManager.GetObject(user.getTokenName(user.getDeckArray(3)))
        picbox_5.Image = My.Resources.ResourceManager.GetObject(user.getTokenName(user.getDeckArray(4)))
        picbox_6.Image = My.Resources.ResourceManager.GetObject(user.getTokenName(user.getDeckArray(5)))
        chbox1.Tag = user.getDeckArray(0)
        chbox2.Tag = user.getDeckArray(1)
        chbox3.Tag = user.getDeckArray(2)
        chbox4.Tag = user.getDeckArray(3)
        chbox5.Tag = user.getDeckArray(4)
        chbox6.Tag = user.getDeckArray(5)
        btn_OK2.Tag = idUser
    End Sub

    Private Sub btn_OK_Click(sender As Object, e As EventArgs) Handles btn_OK.Click
        If (formIsValid()) Then
            lbl_remplir.Visible = False
            initializeUsers()
            showDeck(0)
        Else
            lbl_remplir.Visible = True
        End If
    End Sub

    Sub cleanDeck()
        chbox1.Checked = False
        chbox2.Checked = False
        chbox3.Checked = False
        chbox4.Checked = False
        chbox5.Checked = False
        chbox6.Checked = False
        picbox_1.Image = My.Resources.ResourceManager.GetObject("Nothing")
        picbox_2.Image = My.Resources.ResourceManager.GetObject("Nothing")
        picbox_3.Image = My.Resources.ResourceManager.GetObject("Nothing")
        picbox_4.Image = My.Resources.ResourceManager.GetObject("Nothing")
        picbox_5.Image = My.Resources.ResourceManager.GetObject("Nothing")
        picbox_6.Image = My.Resources.ResourceManager.GetObject("Nothing")
        lbl_name_player.Visible = False
        btn_OK2.Tag = Nothing
    End Sub

    Private Sub btn_OK2_Click(sender As Object, e As EventArgs) Handles btn_OK2.Click
        If (Not IsNothing(btn_OK2.Tag)) Then
            'Récuperation de l'utilisateur et Initialisation
            Dim idUser As Integer = sender.Tag
            Dim bestDeck(5) As Integer
            Dim counter As Integer = 0
            Dim AbleForms As Integer = 0
            Dim AbleColors As Integer = 0
            'Vérification de la combinaison
            If chbox1.Checked Then
                bestDeck(counter) = chbox1.Tag
                counter = counter + 1
            End If
            If chbox2.Checked Then
                bestDeck(counter) = chbox2.Tag
                counter = counter + 1
            End If
            If chbox3.Checked Then
                bestDeck(counter) = chbox3.Tag
                counter = counter + 1
            End If
            If chbox4.Checked Then
                bestDeck(counter) = chbox4.Tag
                counter = counter + 1
            End If
            If chbox5.Checked Then
                bestDeck(counter) = chbox5.Tag
                counter = counter + 1
            End If
            If chbox6.Checked Then
                bestDeck(counter) = chbox6.Tag
                counter = counter + 1
            End If
            'Vérification Couleur
            For counter2 As Integer = 1 To counter - 1
                If Math.Truncate(bestDeck(counter2) / 10) = Math.Truncate(bestDeck(counter2 - 1) / 10) Then
                    AbleColors = AbleColors + 1
                End If
            Next
            'Vérification Forme
            For counter2 As Integer = 1 To counter - 1
                Dim aa As Double = bestDeck(counter2) Mod 10
                Dim bb As Double = bestDeck(counter2 - 1) Mod 10
                If bestDeck(counter2 - 1) Mod 10 = bestDeck(counter2) Mod 10 Then
                    AbleForms = AbleForms + 1
                End If
            Next
            'Inscription de la taille de la combinaison
            If (AbleForms + 1 = counter Or AbleColors + 1 = counter) Then
                lbl_false.Visible = False
                users(idUser).setSizeBestDeck(counter)
                If (idUser + 1 < nb_player) Then
                    showDeck(idUser + 1)
                Else
                    cleanDeck()
                    showPlayerNames()
                End If
            Else
                lbl_false.Visible = True
            End If
        End If
    End Sub

End Class


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

    Function getAge() As Integer
        Return age
    End Function

    Function getName() As String
        Return name
    End Function

    Function getNbPoints() As Integer
        Return nb_points
    End Function

    Sub generateDeck()
        Dim tempColor As Integer
        Dim tempForm As Integer
        For counter As Integer = 0 To deckArray.Length - 1
            tempColor = CInt(Int((6 * Rnd()) + 1)) * 10
            tempForm = CInt(Int((6 * Rnd()) + 1))
            deckArray(counter) = tempColor + tempForm
        Next
    End Sub

    Function getDeckArray() As Integer()
        Return deckArray
    End Function

    Sub setSizeBestDeck(ByVal size As Integer)
        sizeBestDeck = size
    End Sub

    Function getSizeBestDeck() As Integer
        Return sizeBestDeck
    End Function

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