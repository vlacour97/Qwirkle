﻿Public Class Form_Partie

    Dim users(3) As User
    Dim nb_player As Integer
    Dim pick As Pick
    Dim activeUser As User
    Dim nb_tour As Integer
    Dim nb_points_tour As Integer = 0

    'TODO Vérification de lignes 

    Private Structure dragPictBoxInfo
        Dim img As Image
        Dim tag As Object
    End Structure

    Private Sub Form_Partie_Load(sender As Object, e As EventArgs) Handles Me.Load
        users = My.Forms.Form_Begin.getUsers()
        nb_player = My.Forms.Form_Begin.getNbPlayer()
        pick = My.Forms.Form_Begin.getPick()
        dropzone.AllowDrop = True
        'Préparation pout test : initialisation des joueurs
        'users(0) = New User("Antoine", 19)
        'users(1) = New User("Valentin", 15)
        'users(2) = New User("NC", 0)
        'users(3) = New User("NC", 0)
        'users(0).setFirstBestCombinaison(users(0).getDeckArray)
        'For Each user In users
        'User.generateDeck(pick)
        'Next
        changePlayer()

        'Methode de test : Pioche Vidé
        'pick.ClearPick()
    End Sub

    Sub updateLblData()
        lbl_name_player.Text = "Joueur : " & activeUser.getName
        lbl_score.Text = "Score : " & activeUser.getNbPoints
        lbl_nbOfToken.Text = "Nombre de jetons dans la pioche : " & pick.count
    End Sub

    Sub changePlayer()
        activeUser = users(nb_tour Mod nb_player)
        If (nb_tour = 0) Then
            MsgBox(activeUser.getName & " commence la partie !")
        Else
            MsgBox("Au tour de " & activeUser.getName)
        End If
        updateLblData()
        showDeck(activeUser)
        nb_tour = nb_tour + 1
    End Sub

    Sub showDeck(ByVal user As User)
        PictureBox1.Image = My.Resources.ResourceManager.GetObject(user.getTokenName(user.getDeckArray(0)))
        PictureBox2.Image = My.Resources.ResourceManager.GetObject(user.getTokenName(user.getDeckArray(1)))
        PictureBox3.Image = My.Resources.ResourceManager.GetObject(user.getTokenName(user.getDeckArray(2)))
        PictureBox4.Image = My.Resources.ResourceManager.GetObject(user.getTokenName(user.getDeckArray(3)))
        PictureBox5.Image = My.Resources.ResourceManager.GetObject(user.getTokenName(user.getDeckArray(4)))
        PictureBox6.Image = My.Resources.ResourceManager.GetObject(user.getTokenName(user.getDeckArray(5)))
        PictureBox1.Tag = user.getDeckArray(0)
        PictureBox2.Tag = user.getDeckArray(1)
        PictureBox3.Tag = user.getDeckArray(2)
        PictureBox4.Tag = user.getDeckArray(3)
        PictureBox5.Tag = user.getDeckArray(4)
        PictureBox6.Tag = user.getDeckArray(5)
    End Sub


    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove, PictureBox2.MouseMove, PictureBox3.MouseMove, PictureBox4.MouseMove, PictureBox5.MouseMove, PictureBox6.MouseMove
        Dim rep As DragDropEffects
        Try
            rep = sender.DoDragDrop(New dragPictBoxInfo With {.img = sender.Image, .tag = sender.Tag}, DragDropEffects.Move)
            If rep = DragDropEffects.Move Then
                sender.Image = Nothing
                updateDeck()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dropzone_DragDrop(sender As Object, e As DragEventArgs) Handles dropzone.DragDrop
        Dim datas As dragPictBoxInfo = e.Data.GetData(GetType(dragPictBoxInfo))
        If (sender.Equals(dropzone)) Then
            AddPointToActiveUser(1)
        End If
        sender.Image = datas.img
        sender.Tag = datas.tag
        sender.allowDrop = False
        createDropzones(sender)
        AddPointToActiveUser(nb_points_tour)
        nb_points_tour = 0
    End Sub

    Function allDeckIsEmpty() As Boolean
        If (Not pick.isEmpty) Then
            Return False
        End If
        For i As Integer = 0 To nb_player - 1
            If (Not users(i).deckIsEmpty) Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub dropzone_DragEnter(sender As Object, e As DragEventArgs) Handles dropzone.DragEnter
        Dim datas As dragPictBoxInfo = e.Data.GetData(GetType(dragPictBoxInfo))
        nb_points_tour = combinaisonWasAutorised(sender, datas.tag)
        If e.Data.GetDataPresent(GetType(dragPictBoxInfo)) And ((nb_points_tour > 0 Or sender.Equals(dropzone)) And ((nb_tour = 1 And activeUser.inFirstBestCombinaison(datas.tag)) Or nb_tour > 1)) Then
            e.Effect = DragDropEffects.Move
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Sub createDropzones(ByRef dropzone As PictureBox)
        'Verification de sortie de zone de jeu
        If (isToHigh(dropzone)) Then
            mouvToBottom(dropzone)
        End If
        If (isToLeft(dropzone)) Then
            mouvToLeft(dropzone)
        End If
        'Dropzone en dessous
        createDropzone(dropzone, dropzone.Top + dropzone.Height, dropzone.Left)
        'Dropzone au dessus
        createDropzone(dropzone, dropzone.Top - dropzone.Height, dropzone.Left)
        'Dropzone à droite
        createDropzone(dropzone, dropzone.Top, dropzone.Left + dropzone.Width)
        'Dropzone à gauche
        createDropzone(dropzone, dropzone.Top, dropzone.Left - dropzone.Width)
    End Sub

    Sub createDropzone(ByVal dropzone As PictureBox, ByVal top As Integer, ByVal left As Integer)
        Dim newPictureBox As New PictureBox
        newPictureBox.Image = My.Resources.ResourceManager.GetObject("dropzone")
        newPictureBox.SizeMode = PictureBoxSizeMode.Zoom
        newPictureBox.AllowDrop = True
        newPictureBox.Name = "dropzone" & Panel1.Controls.Count - 1
        newPictureBox.Visible = True
        newPictureBox.Top = top
        newPictureBox.Width = dropzone.Width
        newPictureBox.Height = dropzone.Height
        newPictureBox.Left = left
        If (Not isInTheSamePlace(newPictureBox)) Then
            Panel1.Controls.Add(newPictureBox)
            AddHandler Panel1.Controls.Item(Panel1.Controls.Count - 1).DragDrop, AddressOf dropzone_DragDrop
            AddHandler Panel1.Controls.Item(Panel1.Controls.Count - 1).DragEnter, AddressOf dropzone_DragEnter
        End If
    End Sub

    Function isToHigh(ByVal sender As PictureBox) As Boolean
        Return (sender.Top - sender.Height) < 0
    End Function

    Function isToLeft(ByVal sender As PictureBox) As Boolean
        Return (sender.Left - sender.Width) < 0
    End Function

    Sub mouvToBottom(ByVal dropzone As PictureBox)
        Dim difference As Double = -dropzone.Top + dropzone.Height
        For Each pictureBox In Panel1.Controls
            pictureBox.Top += difference
        Next
    End Sub

    Sub mouvToLeft(ByVal dropzone As PictureBox)
        Dim difference As Double = -dropzone.Left + dropzone.Width
        For Each pictureBox In Panel1.Controls
            pictureBox.Left += difference
        Next
    End Sub

    Function isInTheSamePlace(ByVal picboxArg As PictureBox) As Boolean
        For Each picBox As PictureBox In Panel1.Controls
            If (picBox.Top = picboxArg.Top And picBox.Left = picboxArg.Left) Then
                Return True
            End If
        Next
        Return False
    End Function

    Function combinaisonWasAutorised(ByVal picBoxWasDroped As PictureBox, ByVal picBoxTag As Integer) As Integer


        Dim checkingArround() As Integer = {3, 3, 3, 3}

        For Each picBox In Panel1.Controls
            'Verification Ligne
            If (picBoxWasDroped.Top = picBox.Top) Then
                If (picBox.Left = picBoxWasDroped.Left - dropzone.Width) Then
                    'Verification gauche
                    If (IsNothing(picBox.Tag)) Then
                        checkingArround(0) = 1
                    ElseIf (pick.tokenInSameColor(picBox.Tag, picBoxTag) Or pick.tokenInSameForm(picBox.Tag, picBoxTag)) Then
                        checkingArround(0) = 2
                    Else
                        checkingArround(0) = 0
                    End If
                End If
                If (picBox.Left = picBoxWasDroped.Left + dropzone.Width) Then
                    'Verification droite
                    If (IsNothing(picBox.Tag)) Then
                        checkingArround(1) = 1
                    ElseIf (pick.tokenInSameColor(picBox.Tag, picBoxTag) Or pick.tokenInSameForm(picBox.Tag, picBoxTag)) Then
                        checkingArround(1) = 2
                    Else
                        checkingArround(1) = 0
                    End If
                End If
            End If
            'Verification Colonne
            If (picBoxWasDroped.Left = picBox.Left) Then
                If (picBox.Top = picBoxWasDroped.Top - dropzone.Height) Then
                    'Verification haut
                    If (IsNothing(picBox.Tag)) Then
                        checkingArround(2) = 1
                    ElseIf (pick.tokenInSameColor(picBox.Tag, picBoxTag) Or pick.tokenInSameForm(picBox.Tag, picBoxTag)) Then
                        checkingArround(2) = 2
                    Else
                        checkingArround(2) = 0
                    End If
                End If
                If (picBox.Top = picBoxWasDroped.Top + dropzone.Height) Then
                    'Verification bas
                    If (IsNothing(picBox.Tag)) Then
                        checkingArround(3) = 1
                    ElseIf (pick.tokenInSameColor(picBox.Tag, picBoxTag) Or pick.tokenInSameForm(picBox.Tag, picBoxTag)) Then
                        checkingArround(3) = 2
                    Else
                        checkingArround(3) = 0
                    End If
                End If
            End If
        Next

        If (InIntegerArray(2, checkingArround) = 0 Or InIntegerArray(0, checkingArround) > 0) Then
            'Revois Faux
            Return 0
        Else
            If (InIntegerArray(2, checkingArround) = 1 And InIntegerArray(0, checkingArround) = 0) Then
                'Revois Vrai + 1 point
                Return 1
            ElseIf (InIntegerArray(2, checkingArround) > 1 And InIntegerArray(0, checkingArround) = 0) Then
                'Revois Vrai + 2 point
                Return 2
            End If
            Return 1
        End If

    End Function

    Function InIntegerArray(ByVal int As Integer, ByVal array() As Integer) As Integer
        Dim response As Integer = 0
        For Each line In array
            If (line = int) Then
                response += 1
            End If
        Next
        Return response
    End Function

    Sub updateDeck()
        If (IsNothing(PictureBox1.Image)) Then
            activeUser.deleteToken(PictureBox1.Tag)
        End If
        If (IsNothing(PictureBox2.Image)) Then
            activeUser.deleteToken(PictureBox2.Tag)
        End If
        If (IsNothing(PictureBox3.Image)) Then
            activeUser.deleteToken(PictureBox3.Tag)
        End If
        If (IsNothing(PictureBox4.Image)) Then
            activeUser.deleteToken(PictureBox4.Tag)
        End If
        If (IsNothing(PictureBox5.Image)) Then
            activeUser.deleteToken(PictureBox5.Tag)
        End If
        If (IsNothing(PictureBox6.Image)) Then
            activeUser.deleteToken(PictureBox6.Tag)
        End If
    End Sub

    'Echange de tuiles
    Private Sub picbox_switch_Click(sender As Object, e As EventArgs) Handles picbox_switch.Click
        My.Forms.Form_Switch.setActiveUser(activeUser)
        My.Forms.Form_Switch.setPick(pick)
        blockDeck(True)
        My.Forms.Form_Switch.Show()
    End Sub

    Sub blockDeck(ByVal bool As Boolean)
        If (bool) Then
            PictureBox1.Enabled = False
            PictureBox2.Enabled = False
            PictureBox3.Enabled = False
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
            PictureBox6.Enabled = False
        Else
            PictureBox1.Enabled = True
            PictureBox2.Enabled = True
            PictureBox3.Enabled = True
            PictureBox4.Enabled = True
            PictureBox5.Enabled = True
            PictureBox6.Enabled = True
        End If
    End Sub

    Sub AddPointToActiveUser(ByVal nb_points As Integer)
        activeUser.AddPoints(nb_points)
        updateLblData()
    End Sub

    Private Sub picbox_past_Click(sender As Object, e As EventArgs) Handles picbox_past.Click
        If (allDeckIsEmpty()) Then
            AddPointToActiveUser(6)
            MsgBox("Fin de la partie !")
            My.Forms.Form_End.Show()
            Me.Close()
        Else
            activeUser.dipIntoPick(pick)
            changePlayer()
        End If
    End Sub
End Class
