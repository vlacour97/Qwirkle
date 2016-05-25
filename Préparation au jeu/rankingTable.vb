Imports System
Imports System.IO

Public Class rankingTable

    Dim users() As User
    Dim nb_player As Integer

    Private Sub rankingTable_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim sr As StreamReader = New StreamReader("../../Resources/datas/bestPlayers.txt")
        Dim line As String
        Do
            ReDim Preserve users(nb_player)
            line = sr.ReadLine()
            Dim dataPlayersArray() As String = Split(line, "_")
            Try
                Dim tempUser As User = New User(dataPlayersArray(0), CInt(dataPlayersArray(1)))
                users(nb_player) = tempUser
                users(nb_player).setNbPoints(CInt(dataPlayersArray(2)))
                nb_player += 1
            Catch ex As Exception

            End Try

        Loop Until line Is Nothing
        sr.Close()

        users = organizeUserByScore()

        initTab()

        For countLine As Integer = 0 To nb_player - 1
            Dim lbl = New Label
            With lbl
                .Name = "lbl" & countLine + 1 & 1
                .TextAlign = ContentAlignment.MiddleCenter
                .Text = users(countLine).getName()
                .Font = New Font(Font.SystemFontName, 10, Font.Style.Regular, Font.Unit.Point)
                .Dock = DockStyle.Fill
                .AutoSize = True
            End With
            rank.Controls.Add(lbl, 0, countLine + 1)
            Dim lbl1 = New Label
            With lbl1
                .Name = "lbl" & countLine + 1 & 2
                .TextAlign = ContentAlignment.MiddleCenter
                .Text = users(countLine).getAge()
                .Font = New Font(Font.SystemFontName, 10, Font.Style.Regular, Font.Unit.Point)
                .Dock = DockStyle.Fill
                .AutoSize = True
            End With
            rank.Controls.Add(lbl1, 1, countLine + 1)
            Dim lbl2 = New Label
            With lbl2
                .Name = "lbl" & countLine + 1 & 3
                .TextAlign = ContentAlignment.MiddleCenter
                .Text = users(countLine).getNbPoints()
                .Font = New Font(Font.SystemFontName, 10, Font.Style.Regular, Font.Unit.Point)
                .Dock = DockStyle.Fill
                .AutoSize = True
            End With
            rank.Controls.Add(lbl2, 2, countLine + 1)
            If (countLine = 9) Then
                Exit For
            End If
        Next

    End Sub

    Sub initTab()
        Dim lbl = New Label
        With lbl
            .Name = "lbl" & 0 & 1
            .TextAlign = ContentAlignment.MiddleCenter
            .Text = "Nom"
            .Font = New Font(Font.SystemFontName, 10, Font.Style.Bold, Font.Unit.Point)
            .Dock = DockStyle.Fill
            .AutoSize = True
        End With
        rank.Controls.Add(lbl, 0, 0)
        Dim lbl1 = New Label
        With lbl1
            .Name = "lbl" & 0 & 2
            .TextAlign = ContentAlignment.MiddleCenter
            .Text = "Age"
            .Font = New Font(Font.SystemFontName, 10, Font.Style.Bold, Font.Unit.Point)
            .Dock = DockStyle.Fill
            .AutoSize = True
        End With
        rank.Controls.Add(lbl1, 1, 0)
        Dim lbl2 = New Label
        With lbl2
            .Name = "lbl" & 0 & 3
            .TextAlign = ContentAlignment.MiddleCenter
            .Text = "Nombre de Points"
            .Font = New Font(Font.SystemFontName, 10, Font.Style.Bold, Font.Unit.Point)
            .Dock = DockStyle.Fill
            .AutoSize = True
        End With
        rank.Controls.Add(lbl2, 2, 0)
    End Sub

    Function organizeUserByScore() As User()
        Dim usersTemp(users.Length) As User
        Dim response(users.Length) As User
        For counter As Integer = 0 To users.Length - 1
            If (Not IsNothing(users(counter))) Then
                usersTemp(counter) = users(counter)
            End If
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

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        My.Forms.Form_menu.Show()
        Me.Close()
    End Sub
End Class