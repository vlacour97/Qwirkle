Public Class Form_Begin

    Dim nb_player As Integer
    Dim users(3) As User

    Private Sub Form_Begin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enableNames()
        lbl_remplir.Visible = False
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
                If (txt_box_fname1.Text.Length > 0 And txt_box_fname2.Text.Length > 0 And (txt_box_age1.Text) And IsNumeric(txt_box_age2.Text) And Not IsNumeric(txt_box_fname1.Text) And Not IsNumeric(txt_box_fname2.Text)) Then
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
        usersTemp(0) = New User(txt_box_fname1.Text, txt_box_age1.Text)
        usersTemp(1) = New User(txt_box_fname2.Text, txt_box_age2.Text)
        If (nb_player > 2) Then
            usersTemp(2) = New User(txt_box_fname3.Text, txt_box_age3.Text)
        Else
            usersTemp(2) = New User("NC", 0)
        End If
        If (nb_player > 3) Then
            usersTemp(3) = New User(txt_box_fname4.Text, txt_box_age4.Text)
        Else
            usersTemp(3) = New User("NC", 0)
        End If
        'Trie du tableau
        Dim tempUser As User
        For counter As Integer = 0 To users.Length - 1
            tempUser = OldestUserInArray(usersTemp)
            users(counter) = tempUser
            deleteUserInArray(usersTemp, tempUser)
        Next
    End Sub

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

    Sub showPlayerNames()
        generateUsertab()
        lbl_first_name.Text = users(0).getName
        lbl_second_name.Text = users(1).getName
        lbl_third_name.Text = users(2).getName
        lbl_fourth_name.Text = users(3).getName
    End Sub

    Private Sub btn_OK_Click(sender As Object, e As EventArgs) Handles btn_OK.Click
        If (formIsValid()) Then
            lbl_remplir.Visible = False
            showPlayerNames()
        Else
            lbl_remplir.Visible = True
        End If
    End Sub
End Class


Public Class User

    Dim name As String
    Dim age As Integer
    Dim nb_points As Integer

    Sub New(ByVal nameValue As String, ByVal ageValue As Integer)
        name = nameValue
        age = ageValue
        nb_points = 0
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

End Class