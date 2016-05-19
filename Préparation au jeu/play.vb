Public Class Form_Partie

    Dim users(3) As User
    Dim nb_player As Integer
    Dim pick As Pick

    Private Sub Form_Partie_Load(sender As Object, e As EventArgs) Handles Me.Load
        users = My.Forms.Form_Begin.getUsers()
        nb_player = My.Forms.Form_Begin.getNbPlayer()
        pick = My.Forms.Form_Begin.getPick()
        users(0) = New User("Antoine", 19)
        users(1) = New User("Valentin", 15)
        users(2) = New User("NC", 0)
        users(3) = New User("NC", 0)
        For Each user In users
            user.generateDeck(pick)
        Next
        MsgBox(users(0).getName & " commence la partie !")
        updateLblData(users(0))
        showDeck(users(0))
    End Sub

    Sub updateLblData(ByVal user As User)
        lbl_name_player.Text = "Joueur : " & user.getName
        lbl_score.Text = "Score : " & user.getNbPoints
    End Sub

    Sub showDeck(ByVal user As User)
        PictureBox1.Image = My.Resources.ResourceManager.GetObject(user.getTokenName(user.getDeckArray(0)))
        PictureBox2.Image = My.Resources.ResourceManager.GetObject(user.getTokenName(user.getDeckArray(1)))
        PictureBox3.Image = My.Resources.ResourceManager.GetObject(user.getTokenName(user.getDeckArray(2)))
        PictureBox4.Image = My.Resources.ResourceManager.GetObject(user.getTokenName(user.getDeckArray(3)))
        PictureBox5.Image = My.Resources.ResourceManager.GetObject(user.getTokenName(user.getDeckArray(4)))
        PictureBox6.Image = My.Resources.ResourceManager.GetObject(user.getTokenName(user.getDeckArray(5)))
    End Sub

End Class
