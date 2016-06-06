Public Class Form_Switch

    Dim ActiveUser As User
    Dim pick As Pick

    Private Sub Form_Switch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_need.Visible = False
        lbl_name.Text = "Joueur : " & ActiveUser.getName()
        showDeck(ActiveUser)
    End Sub

    Sub showDeck(ByVal user As User)
        PictureBox1.Image = My.Resources.ResourceManager.GetObject(user.getTokenName(user.getDeckArray(0)))
        PictureBox2.Image = My.Resources.ResourceManager.GetObject(user.getTokenName(user.getDeckArray(1)))
        PictureBox3.Image = My.Resources.ResourceManager.GetObject(user.getTokenName(user.getDeckArray(2)))
        PictureBox4.Image = My.Resources.ResourceManager.GetObject(user.getTokenName(user.getDeckArray(3)))
        PictureBox5.Image = My.Resources.ResourceManager.GetObject(user.getTokenName(user.getDeckArray(4)))
        PictureBox6.Image = My.Resources.ResourceManager.GetObject(user.getTokenName(user.getDeckArray(5)))
        chbox1.Tag = user.getDeckArray(0)
        chbox2.Tag = user.getDeckArray(1)
        chbox3.Tag = user.getDeckArray(2)
        chbox4.Tag = user.getDeckArray(3)
        chbox5.Tag = user.getDeckArray(4)
        chbox6.Tag = user.getDeckArray(5)
    End Sub

    Sub setActiveUser(ByRef user As User)
        ActiveUser = user
    End Sub

    Sub setPick(ByRef pickArg As Pick)
        pick = pickArg
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        My.Forms.Form_Partie.blockDeck(False)
        Me.Close()
    End Sub

    Private Sub btn_switch_Click(sender As Object, e As EventArgs) Handles btn_switch.Click
        Dim oldTokensWasUnchecked(5) As Integer
        Dim oldTokensWasChecked(5) As Integer
        Dim newTokens(5) As Integer
        Dim counterForChecked As Integer = 0
        Dim counterForUnchecked As Integer = 0

        If (chbox1.Checked) Then
            oldTokensWasChecked(counterForChecked) = chbox1.Tag
            counterForChecked = counterForChecked + 1
        Else
            oldTokensWasUnchecked(counterForUnchecked) = chbox1.Tag
            counterForUnchecked = counterForUnchecked + 1
        End If
        If (chbox2.Checked) Then
            oldTokensWasChecked(counterForChecked) = chbox2.Tag
            counterForChecked = counterForChecked + 1
        Else
            oldTokensWasUnchecked(counterForUnchecked) = chbox2.Tag
            counterForUnchecked = counterForUnchecked + 1
        End If
        If (chbox3.Checked) Then
            oldTokensWasChecked(counterForChecked) = chbox3.Tag
            counterForChecked = counterForChecked + 1
        Else
            oldTokensWasUnchecked(counterForUnchecked) = chbox3.Tag
            counterForUnchecked = counterForUnchecked + 1
        End If
        If (chbox4.Checked) Then
            oldTokensWasChecked(counterForChecked) = chbox4.Tag
            counterForChecked = counterForChecked + 1
        Else
            oldTokensWasUnchecked(counterForUnchecked) = chbox4.Tag
            counterForUnchecked = counterForUnchecked + 1
        End If
        If (chbox5.Checked) Then
            oldTokensWasChecked(counterForChecked) = chbox5.Tag
            counterForChecked = counterForChecked + 1
        Else
            oldTokensWasUnchecked(counterForUnchecked) = chbox5.Tag
            counterForUnchecked = counterForUnchecked + 1
        End If
        If (chbox6.Checked) Then
            oldTokensWasChecked(counterForChecked) = chbox6.Tag
            counterForChecked = counterForChecked + 1
        Else
            oldTokensWasUnchecked(counterForUnchecked) = chbox6.Tag
            counterForUnchecked = counterForUnchecked + 1
        End If

        If (counterForChecked = 0) Then
            lbl_need.Visible = True
        Else
            lbl_need.Visible = False
            'Récupération des nouvelles tuiles
            newTokens = generateNewPersonnalizeDeck(counterForChecked)

            'Sauvegarde des nouvelles tuiles
            For i As Integer = counterForChecked To 5
                newTokens(i) = oldTokensWasUnchecked(i - counterForChecked)
            Next
            ActiveUser.setDeckArray(newTokens)

            'Remise des anciennes tuiles
            pick.DropTokenInPick(oldTokensWasChecked)

            My.Forms.Form_Partie.showDeck(ActiveUser)
            My.Forms.Form_Partie.blockDeck(False)
            Me.Close()
            My.Forms.Form_Partie.changePlayer()
        End If

    End Sub

    Function generateNewPersonnalizeDeck(ByVal size As Integer) As Integer()
        If (size > 6) Then
            size = 6
        End If
        Dim response(5) As Integer
        Dim tokenId As Integer
        For i As Integer = 0 To size - 1
            Dim pickIsEmpty As Boolean = pick.isEmpty
            If (Not pickIsEmpty) Then
                While (response(i) = 0 And Not pickIsEmpty)
                    tokenId = CInt(107 * Rnd())
                    response(i) = pick.getToken(tokenId)
                End While
            End If
        Next
        Return response
    End Function



End Class
