Public Class Form_End

    Dim users(3) As User
    Dim nb_player As Integer

    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        My.Forms.Form_menu.Show()
        Me.Close()
    End Sub

    Private Sub btn_replay_Click(sender As Object, e As EventArgs) Handles btn_replay.Click
        My.Forms.Form_Begin.Show()
        Me.Close()
    End Sub

    Private Sub Form_End_Load(sender As Object, e As EventArgs) Handles Me.Load
        nb_player = My.Forms.Form_Begin.getNbPlayer()
        users = My.Forms.Form_Begin.getUsers()
        users(0) = New User("Antoine", 19)
        users(1) = New User("Valentin", 15)
        users(0).setNbPoints(12)
        users(1).setNbPoints(19)

        'Trie des joueurs
        Dim userListByScore(3) As User
        userListByScore = organizeUserByScore()

        'Affichage Score
        lbl_first_name.Text = userListByScore(0).getName()
        lbl_score1.Text = userListByScore(0).getNbPoints()
        lbl_second_name.Text = userListByScore(1).getName()
        lbl_score2.Text = userListByScore(1).getNbPoints()
        If (nb_player > 2) Then
            lbl_third_name.Text = userListByScore(2).getName()
            lbl_score3.Text = userListByScore(2).getNbPoints()
        Else
            lbl_third_name.Text = "NC"
            lbl_score3.Text = "0"
        End If
        If (nb_player > 3) Then
            lbl_fourth_place.Text = userListByScore(3).getName()
            lbl_score4.Text = userListByScore(3).getNbPoints()
        Else
            lbl_fourth_place.Text = "NC"
            lbl_score4.Text = "0"
        End If

        'Affichage Vainqueur 
        Message.Text = "Le joueur qui a gagné est " & userListByScore(0).getName() & " ! Bravo !"

    End Sub

    Function organizeUserByScore() As User()
        Dim usersTemp(3) As User
        Dim response(3) As User
        For counter As Integer = 0 To users.Length - 1
            usersTemp(counter) = users(counter)
        Next
        Dim tempUser As User
        For counter As Integer = 0 To users.Length - 1
            tempUser = maxScoreUser(usersTemp)
            response(counter) = tempUser
            deleteUserInArray(usersTemp, tempUser)
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

    Function maxScoreUser(ByVal users() As User) As User
        Dim response As User
        response = New User("NC", 0)
        For counter As Integer = 0 To nb_player - 1
            If (users(counter).getNbPoints > response.getNbPoints) Then
                response = users(counter)
            End If
        Next
        Return response
    End Function

End Class
