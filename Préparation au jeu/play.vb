Public Class Form_Partie

    Dim users(3) As User
    Dim nb_player As Integer
    Dim pick As Pick
    Dim DropZoneCounter As Integer = 0

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
        PictureBox1.Tag = user.getDeckArray(0)
        PictureBox1.Tag = user.getDeckArray(1)
        PictureBox1.Tag = user.getDeckArray(2)
        PictureBox1.Tag = user.getDeckArray(3)
        PictureBox1.Tag = user.getDeckArray(4)
        PictureBox1.Tag = user.getDeckArray(5)
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove, PictureBox2.MouseMove, PictureBox3.MouseMove, PictureBox4.MouseMove, PictureBox5.MouseMove, PictureBox6.MouseMove
        Dim rep As DragDropEffects
        Try
            rep = sender.DoDragDrop(sender.Image, DragDropEffects.Move)
            If rep = DragDropEffects.Move Then
                sender.Image = Nothing
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dropzone_DragDrop(sender As Object, e As DragEventArgs) Handles dropzone.DragDrop
        If (combinaisonWasAutorised()) Then
            sender.Image = e.Data.GetData(DataFormats.Bitmap)
            sender.allowDrop = False
            createDropzones(sender)
        Else
            MsgBox("La combinaison n'est pas bonne !")
        End If

    End Sub

    Private Sub dropzone_DragEnter(sender As Object, e As DragEventArgs) Handles dropzone.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
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
        newPictureBox1.Name = "dropzone" & DropZoneCounter
        newPictureBox1.Visible = True
        newPictureBox1.Top = dropzone.Top + dropzone.Height
        newPictureBox1.Width = dropzone.Width
        newPictureBox1.Height = dropzone.Height
        newPictureBox1.Left = dropzone.Left
        If (Not isInTheSamePlace(newPictureBox1)) Then
            Panel1.Controls.Add(newPictureBox1)
            AddHandler Panel1.Controls.Item(DropZoneCounter).DragDrop, AddressOf dropzone_DragDrop
            AddHandler Panel1.Controls.Item(DropZoneCounter).DragEnter, AddressOf dropzone_DragEnter
            DropZoneCounter = DropZoneCounter + 1
        End If
        'Dropzone au dessus
        newPictureBox2.Name = "dropzone" & DropZoneCounter
        newPictureBox2.Visible = True
        newPictureBox2.Top = dropzone.Top - dropzone.Height
        newPictureBox2.Width = dropzone.Width
        newPictureBox2.Height = dropzone.Height
        newPictureBox2.Left = dropzone.Left
        If (Not isInTheSamePlace(newPictureBox2)) Then
            Panel1.Controls.Add(newPictureBox2)
            AddHandler Panel1.Controls.Item(DropZoneCounter).DragDrop, AddressOf dropzone_DragDrop
            AddHandler Panel1.Controls.Item(DropZoneCounter).DragEnter, AddressOf dropzone_DragEnter
            DropZoneCounter = DropZoneCounter + 1
        End If
        'Dropzone à droite
        newPictureBox3.Name = "dropzone" & DropZoneCounter
        newPictureBox3.Visible = True
        newPictureBox3.Top = dropzone.Top
        newPictureBox3.Width = dropzone.Width
        newPictureBox3.Height = dropzone.Height
        newPictureBox3.Left = dropzone.Left + dropzone.Width
        If (Not isInTheSamePlace(newPictureBox3)) Then
            Panel1.Controls.Add(newPictureBox3)
            AddHandler Panel1.Controls.Item(DropZoneCounter).DragDrop, AddressOf dropzone_DragDrop
            AddHandler Panel1.Controls.Item(DropZoneCounter).DragEnter, AddressOf dropzone_DragEnter
            DropZoneCounter = DropZoneCounter + 1
        End If
        'Dropzone à gauche
        newPictureBox4.Name = "dropzone" & DropZoneCounter
        newPictureBox4.Visible = True
        newPictureBox4.Top = dropzone.Top
        newPictureBox4.Width = dropzone.Width
        newPictureBox4.Height = dropzone.Height
        newPictureBox4.Left = dropzone.Left - dropzone.Width
        If (Not isInTheSamePlace(newPictureBox4)) Then
            Panel1.Controls.Add(newPictureBox4)
            AddHandler Panel1.Controls.Item(DropZoneCounter).DragDrop, AddressOf dropzone_DragDrop
            AddHandler Panel1.Controls.Item(DropZoneCounter).DragEnter, AddressOf dropzone_DragEnter
            DropZoneCounter = DropZoneCounter + 1
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

    Function combinaisonWasAutorised() As Boolean
        Return True
    End Function

    Private Sub picbox_reserve_Click(sender As Object, e As EventArgs) Handles picbox_reserve.Click
        MsgBox("eeee")
    End Sub
End Class
