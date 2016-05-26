Public Class Form_Partie

    Dim users(3) As User
    Dim nb_player As Integer
    Dim pick As Pick
    Dim activeUser As User
    Dim nb_tour As Integer

    Private Structure dragPictBoxInfo
        Dim img As Image
        Dim tag As Object
    End Structure

    Private Sub Form_Partie_Load(sender As Object, e As EventArgs) Handles Me.Load
        users = My.Forms.Form_Begin.getUsers()
        nb_player = My.Forms.Form_Begin.getNbPlayer()
        pick = My.Forms.Form_Begin.getPick()
        dropzone.AllowDrop = True
        users(0) = New User("Antoine", 19)
        users(1) = New User("Valentin", 15)
        users(2) = New User("NC", 0)
        users(3) = New User("NC", 0)
        For Each user In users
            user.generateDeck(pick)
        Next
        changePlayer()

        'Methode de test
        'pick.ClearPick()
    End Sub

    Sub updateLblData()
        lbl_name_player.Text = "Joueur : " & activeUser.getName
        lbl_score.Text = "Score : " & activeUser.getNbPoints
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
        If (combinaisonWasAutorised(sender, datas.tag) Or sender.Equals(dropzone)) Then
            If (sender.Equals(dropzone)) Then
                AddPointToActiveUser(1)
            End If
            sender.Image = datas.img
            sender.Tag = datas.tag
            sender.allowDrop = False
            createDropzones(sender)
        Else
            'Annuler un drag&drop
        End If
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
        If e.Data.GetDataPresent(GetType(dragPictBoxInfo)) Then
            e.Effect = DragDropEffects.Move
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Sub createDropzones(ByVal dropzone As PictureBox)
        Dim newPictureBox1 As New PictureBox
        Dim newPictureBox2 As New PictureBox
        Dim newPictureBox3 As New PictureBox
        Dim newPictureBox4 As New PictureBox
        'Parametre communs
        newPictureBox1.Image = My.Resources.ResourceManager.GetObject("dropzone")
        newPictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        newPictureBox1.AllowDrop = True
        newPictureBox2.Image = My.Resources.ResourceManager.GetObject("dropzone")
        newPictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        newPictureBox2.AllowDrop = True
        newPictureBox3.Image = My.Resources.ResourceManager.GetObject("dropzone")
        newPictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        newPictureBox3.AllowDrop = True
        newPictureBox4.Image = My.Resources.ResourceManager.GetObject("dropzone")
        newPictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        newPictureBox4.AllowDrop = True
        'Dropzone en dessous
        newPictureBox1.Name = "dropzone" & Panel1.Controls.Count - 1
        newPictureBox1.Visible = True
        newPictureBox1.Top = dropzone.Top + dropzone.Height
        newPictureBox1.Width = dropzone.Width
        newPictureBox1.Height = dropzone.Height
        newPictureBox1.Left = dropzone.Left
        If (Not isInTheSamePlace(newPictureBox1)) Then
            Panel1.Controls.Add(newPictureBox1)
            AddHandler Panel1.Controls.Item(Panel1.Controls.Count - 1).DragDrop, AddressOf dropzone_DragDrop
            AddHandler Panel1.Controls.Item(Panel1.Controls.Count - 1).DragEnter, AddressOf dropzone_DragEnter
        End If
        'Dropzone au dessus
        newPictureBox2.Name = "dropzone" & Panel1.Controls.Count - 1
        newPictureBox2.Visible = True
        newPictureBox2.Top = dropzone.Top - dropzone.Height
        newPictureBox2.Width = dropzone.Width
        newPictureBox2.Height = dropzone.Height
        newPictureBox2.Left = dropzone.Left
        If (Not isInTheSamePlace(newPictureBox2)) Then
            Panel1.Controls.Add(newPictureBox2)
            AddHandler Panel1.Controls.Item(Panel1.Controls.Count - 1).DragDrop, AddressOf dropzone_DragDrop
            AddHandler Panel1.Controls.Item(Panel1.Controls.Count - 1).DragEnter, AddressOf dropzone_DragEnter
        End If
        'Dropzone à droite
        newPictureBox3.Name = "dropzone" & Panel1.Controls.Count - 1
        newPictureBox3.Visible = True
        newPictureBox3.Top = dropzone.Top
        newPictureBox3.Width = dropzone.Width
        newPictureBox3.Height = dropzone.Height
        newPictureBox3.Left = dropzone.Left + dropzone.Width
        If (Not isInTheSamePlace(newPictureBox3)) Then
            Panel1.Controls.Add(newPictureBox3)
            AddHandler Panel1.Controls.Item(Panel1.Controls.Count - 1).DragDrop, AddressOf dropzone_DragDrop
            AddHandler Panel1.Controls.Item(Panel1.Controls.Count - 1).DragEnter, AddressOf dropzone_DragEnter
        End If
        'Dropzone à gauche
        newPictureBox4.Name = "dropzone" & Panel1.Controls.Count - 1
        newPictureBox4.Visible = True
        newPictureBox4.Top = dropzone.Top
        newPictureBox4.Width = dropzone.Width
        newPictureBox4.Height = dropzone.Height
        newPictureBox4.Left = dropzone.Left - dropzone.Width
        If (Not isInTheSamePlace(newPictureBox4)) Then
            Panel1.Controls.Add(newPictureBox4)
            AddHandler Panel1.Controls.Item(Panel1.Controls.Count - 1).DragDrop, AddressOf dropzone_DragDrop
            AddHandler Panel1.Controls.Item(Panel1.Controls.Count - 1).DragEnter, AddressOf dropzone_DragEnter
        End If
    End Sub

    Function isInTheSamePlace(ByVal picboxArg As PictureBox) As Boolean
        For Each picBox As PictureBox In Panel1.Controls
            If (picBox.Top = picboxArg.Top And picBox.Left = picboxArg.Left) Then
                Return True
            End If
        Next
        Return False
    End Function

    Function combinaisonWasAutorised(ByVal picBoxWasDroped As PictureBox, ByVal picBoxTag As Integer) As Boolean


        Dim checkingArround() As Integer = {3, 3, 3, 3}

        For Each picBox In Panel1.Controls
            'Verification Ligne
            If (picBoxWasDroped.Top = picBox.Top) Then
                If (picBox.Left = picBoxWasDroped.Left - dropzone.Width) Then
                    'Verification gauche
                    If (IsNothing(picBox.Tag)) Then
                        checkingArround(0) = 1
                    ElseIf (pick.tokenInSameColor(picBox.Tag, picBoxTag) Or pick.tokenInSameForm(picBox.Tag, picBoxTag))
                        checkingArround(0) = 2
                    Else
                        checkingArround(0) = 0
                    End If
                End If
                If (picBox.Left = picBoxWasDroped.Left + dropzone.Width) Then
                    'Verification droite
                    If (IsNothing(picBox.Tag)) Then
                        checkingArround(1) = 1
                    ElseIf (pick.tokenInSameColor(picBox.Tag, picBoxTag) Or pick.tokenInSameForm(picBox.Tag, picBoxTag))
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
                    ElseIf (pick.tokenInSameColor(picBox.Tag, picBoxTag) Or pick.tokenInSameForm(picBox.Tag, picBoxTag))
                        checkingArround(2) = 2
                    Else
                        checkingArround(2) = 0
                    End If
                End If
                If (picBox.Top = picBoxWasDroped.Top + dropzone.Height) Then
                    'Verification bas
                    If (IsNothing(picBox.Tag)) Then
                        checkingArround(3) = 1
                    ElseIf (pick.tokenInSameColor(picBox.Tag, picBoxTag) Or pick.tokenInSameForm(picBox.Tag, picBoxTag))
                        checkingArround(3) = 2
                    Else
                        checkingArround(3) = 0
                    End If
                End If
            End If
        Next

        If (InIntegerArray(2, checkingArround) = 0) Then
            'Revois Faux
            Return False
        Else
            If (InIntegerArray(2, checkingArround) = 1) Then
                'Revois Vrai + 1 point
                AddPointToActiveUser(1)
            ElseIf (InIntegerArray(2, checkingArround) > 1)
                'Revois Vrai + 2 point
                AddPointToActiveUser(2)
            End If
            Return True
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

    'Pioche de tuiles
    Private Sub picbox_reserve_Click(sender As Object, e As EventArgs) Handles picbox_reserve.Click
        activeUser.dipIntoPick(pick)
        showDeck(activeUser)
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
            changePlayer()
        End If
    End Sub
End Class
