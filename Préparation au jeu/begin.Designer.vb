<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Begin
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gb_player = New System.Windows.Forms.GroupBox()
        Me.lbl_remplir = New System.Windows.Forms.Label()
        Me.btn_OK = New System.Windows.Forms.Button()
        Me.txt_box_age3 = New System.Windows.Forms.TextBox()
        Me.txt_box_age4 = New System.Windows.Forms.TextBox()
        Me.txt_box_age2 = New System.Windows.Forms.TextBox()
        Me.txt_box_age1 = New System.Windows.Forms.TextBox()
        Me.txt_box_fname4 = New System.Windows.Forms.TextBox()
        Me.txt_box_fname2 = New System.Windows.Forms.TextBox()
        Me.txt_box_fname3 = New System.Windows.Forms.TextBox()
        Me.txt_box_fname1 = New System.Windows.Forms.TextBox()
        Me.lbl_age = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.num_nb_player = New System.Windows.Forms.NumericUpDown()
        Me.lbl_nb_player = New System.Windows.Forms.Label()
        Me.gb_order = New System.Windows.Forms.GroupBox()
        Me.lbl_fourth_name = New System.Windows.Forms.Label()
        Me.lbl_third_name = New System.Windows.Forms.Label()
        Me.lbl_second_name = New System.Windows.Forms.Label()
        Me.lbl_first_name = New System.Windows.Forms.Label()
        Me.lbl_third_player = New System.Windows.Forms.Label()
        Me.lbl_fourth_player = New System.Windows.Forms.Label()
        Me.lbl_second_player = New System.Windows.Forms.Label()
        Me.lbl_first_player = New System.Windows.Forms.Label()
        Me.btn_play = New System.Windows.Forms.Button()
        Me.gb_choice = New System.Windows.Forms.GroupBox()
        Me.lbl_name_player = New System.Windows.Forms.Label()
        Me.btn_OK2 = New System.Windows.Forms.Button()
        Me.lbl_false = New System.Windows.Forms.Label()
        Me.chbox6 = New System.Windows.Forms.CheckBox()
        Me.chbox5 = New System.Windows.Forms.CheckBox()
        Me.chbox4 = New System.Windows.Forms.CheckBox()
        Me.chbox3 = New System.Windows.Forms.CheckBox()
        Me.chbox2 = New System.Windows.Forms.CheckBox()
        Me.chbox1 = New System.Windows.Forms.CheckBox()
        Me.picbox_6 = New System.Windows.Forms.PictureBox()
        Me.picbox_5 = New System.Windows.Forms.PictureBox()
        Me.picbox_4 = New System.Windows.Forms.PictureBox()
        Me.picbox_3 = New System.Windows.Forms.PictureBox()
        Me.picbox_2 = New System.Windows.Forms.PictureBox()
        Me.picbox_1 = New System.Windows.Forms.PictureBox()
        Me.gb_player.SuspendLayout()
        CType(Me.num_nb_player, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_order.SuspendLayout()
        Me.gb_choice.SuspendLayout()
        CType(Me.picbox_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbox_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbox_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbox_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbox_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbox_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_player
        '
        Me.gb_player.Controls.Add(Me.lbl_remplir)
        Me.gb_player.Controls.Add(Me.btn_OK)
        Me.gb_player.Controls.Add(Me.txt_box_age3)
        Me.gb_player.Controls.Add(Me.txt_box_age4)
        Me.gb_player.Controls.Add(Me.txt_box_age2)
        Me.gb_player.Controls.Add(Me.txt_box_age1)
        Me.gb_player.Controls.Add(Me.txt_box_fname4)
        Me.gb_player.Controls.Add(Me.txt_box_fname2)
        Me.gb_player.Controls.Add(Me.txt_box_fname3)
        Me.gb_player.Controls.Add(Me.txt_box_fname1)
        Me.gb_player.Controls.Add(Me.lbl_age)
        Me.gb_player.Controls.Add(Me.lbl_name)
        Me.gb_player.Controls.Add(Me.num_nb_player)
        Me.gb_player.Controls.Add(Me.lbl_nb_player)
        Me.gb_player.Location = New System.Drawing.Point(52, 55)
        Me.gb_player.Name = "gb_player"
        Me.gb_player.Size = New System.Drawing.Size(333, 234)
        Me.gb_player.TabIndex = 0
        Me.gb_player.TabStop = False
        Me.gb_player.Text = "Joueurs"
        '
        'lbl_remplir
        '
        Me.lbl_remplir.AutoSize = True
        Me.lbl_remplir.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_remplir.Location = New System.Drawing.Point(145, 208)
        Me.lbl_remplir.Name = "lbl_remplir"
        Me.lbl_remplir.Size = New System.Drawing.Size(121, 13)
        Me.lbl_remplir.TabIndex = 15
        Me.lbl_remplir.Text = "Remplir tous les champs"
        '
        'btn_OK
        '
        Me.btn_OK.Location = New System.Drawing.Point(22, 188)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(93, 33)
        Me.btn_OK.TabIndex = 13
        Me.btn_OK.Text = "Valider"
        Me.btn_OK.UseVisualStyleBackColor = True
        '
        'txt_box_age3
        '
        Me.txt_box_age3.Location = New System.Drawing.Point(226, 136)
        Me.txt_box_age3.Name = "txt_box_age3"
        Me.txt_box_age3.Size = New System.Drawing.Size(53, 20)
        Me.txt_box_age3.TabIndex = 12
        '
        'txt_box_age4
        '
        Me.txt_box_age4.Location = New System.Drawing.Point(226, 174)
        Me.txt_box_age4.Name = "txt_box_age4"
        Me.txt_box_age4.Size = New System.Drawing.Size(53, 20)
        Me.txt_box_age4.TabIndex = 11
        '
        'txt_box_age2
        '
        Me.txt_box_age2.Location = New System.Drawing.Point(226, 99)
        Me.txt_box_age2.Name = "txt_box_age2"
        Me.txt_box_age2.Size = New System.Drawing.Size(53, 20)
        Me.txt_box_age2.TabIndex = 10
        '
        'txt_box_age1
        '
        Me.txt_box_age1.Location = New System.Drawing.Point(226, 64)
        Me.txt_box_age1.Name = "txt_box_age1"
        Me.txt_box_age1.Size = New System.Drawing.Size(53, 20)
        Me.txt_box_age1.TabIndex = 9
        '
        'txt_box_fname4
        '
        Me.txt_box_fname4.Location = New System.Drawing.Point(148, 174)
        Me.txt_box_fname4.Name = "txt_box_fname4"
        Me.txt_box_fname4.Size = New System.Drawing.Size(58, 20)
        Me.txt_box_fname4.TabIndex = 8
        '
        'txt_box_fname2
        '
        Me.txt_box_fname2.Location = New System.Drawing.Point(148, 99)
        Me.txt_box_fname2.Name = "txt_box_fname2"
        Me.txt_box_fname2.Size = New System.Drawing.Size(58, 20)
        Me.txt_box_fname2.TabIndex = 7
        '
        'txt_box_fname3
        '
        Me.txt_box_fname3.Location = New System.Drawing.Point(148, 136)
        Me.txt_box_fname3.Name = "txt_box_fname3"
        Me.txt_box_fname3.Size = New System.Drawing.Size(58, 20)
        Me.txt_box_fname3.TabIndex = 6
        '
        'txt_box_fname1
        '
        Me.txt_box_fname1.Location = New System.Drawing.Point(148, 63)
        Me.txt_box_fname1.Name = "txt_box_fname1"
        Me.txt_box_fname1.Size = New System.Drawing.Size(58, 20)
        Me.txt_box_fname1.TabIndex = 5
        '
        'lbl_age
        '
        Me.lbl_age.AutoSize = True
        Me.lbl_age.Location = New System.Drawing.Point(232, 34)
        Me.lbl_age.Name = "lbl_age"
        Me.lbl_age.Size = New System.Drawing.Size(26, 13)
        Me.lbl_age.TabIndex = 4
        Me.lbl_age.Text = "Âge"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(145, 34)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(43, 13)
        Me.lbl_name.TabIndex = 3
        Me.lbl_name.Text = "Prénom"
        '
        'num_nb_player
        '
        Me.num_nb_player.Location = New System.Drawing.Point(22, 64)
        Me.num_nb_player.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.num_nb_player.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.num_nb_player.Name = "num_nb_player"
        Me.num_nb_player.Size = New System.Drawing.Size(64, 20)
        Me.num_nb_player.TabIndex = 2
        Me.num_nb_player.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'lbl_nb_player
        '
        Me.lbl_nb_player.AutoSize = True
        Me.lbl_nb_player.Location = New System.Drawing.Point(19, 34)
        Me.lbl_nb_player.Name = "lbl_nb_player"
        Me.lbl_nb_player.Size = New System.Drawing.Size(96, 13)
        Me.lbl_nb_player.TabIndex = 0
        Me.lbl_nb_player.Text = "Nombre de joueurs"
        '
        'gb_order
        '
        Me.gb_order.Controls.Add(Me.lbl_fourth_name)
        Me.gb_order.Controls.Add(Me.lbl_third_name)
        Me.gb_order.Controls.Add(Me.lbl_second_name)
        Me.gb_order.Controls.Add(Me.lbl_first_name)
        Me.gb_order.Controls.Add(Me.lbl_third_player)
        Me.gb_order.Controls.Add(Me.lbl_fourth_player)
        Me.gb_order.Controls.Add(Me.lbl_second_player)
        Me.gb_order.Controls.Add(Me.lbl_first_player)
        Me.gb_order.Location = New System.Drawing.Point(453, 55)
        Me.gb_order.Name = "gb_order"
        Me.gb_order.Size = New System.Drawing.Size(333, 234)
        Me.gb_order.TabIndex = 1
        Me.gb_order.TabStop = False
        Me.gb_order.Text = "Ordre des joueurs"
        '
        'lbl_fourth_name
        '
        Me.lbl_fourth_name.AutoSize = True
        Me.lbl_fourth_name.Location = New System.Drawing.Point(126, 177)
        Me.lbl_fourth_name.Name = "lbl_fourth_name"
        Me.lbl_fourth_name.Size = New System.Drawing.Size(79, 13)
        Me.lbl_fourth_name.TabIndex = 18
        Me.lbl_fourth_name.Text = "Nom du Joueur"
        '
        'lbl_third_name
        '
        Me.lbl_third_name.AutoSize = True
        Me.lbl_third_name.Location = New System.Drawing.Point(126, 139)
        Me.lbl_third_name.Name = "lbl_third_name"
        Me.lbl_third_name.Size = New System.Drawing.Size(79, 13)
        Me.lbl_third_name.TabIndex = 17
        Me.lbl_third_name.Text = "Nom du Joueur"
        '
        'lbl_second_name
        '
        Me.lbl_second_name.AutoSize = True
        Me.lbl_second_name.Location = New System.Drawing.Point(126, 102)
        Me.lbl_second_name.Name = "lbl_second_name"
        Me.lbl_second_name.Size = New System.Drawing.Size(79, 13)
        Me.lbl_second_name.TabIndex = 16
        Me.lbl_second_name.Text = "Nom du Joueur"
        '
        'lbl_first_name
        '
        Me.lbl_first_name.AutoSize = True
        Me.lbl_first_name.Location = New System.Drawing.Point(126, 66)
        Me.lbl_first_name.Name = "lbl_first_name"
        Me.lbl_first_name.Size = New System.Drawing.Size(79, 13)
        Me.lbl_first_name.TabIndex = 15
        Me.lbl_first_name.Text = "Nom du Joueur"
        '
        'lbl_third_player
        '
        Me.lbl_third_player.AutoSize = True
        Me.lbl_third_player.Location = New System.Drawing.Point(27, 139)
        Me.lbl_third_player.Name = "lbl_third_player"
        Me.lbl_third_player.Size = New System.Drawing.Size(74, 13)
        Me.lbl_third_player.TabIndex = 3
        Me.lbl_third_player.Text = "3eme Joueur :"
        '
        'lbl_fourth_player
        '
        Me.lbl_fourth_player.AutoSize = True
        Me.lbl_fourth_player.Location = New System.Drawing.Point(27, 177)
        Me.lbl_fourth_player.Name = "lbl_fourth_player"
        Me.lbl_fourth_player.Size = New System.Drawing.Size(74, 13)
        Me.lbl_fourth_player.TabIndex = 2
        Me.lbl_fourth_player.Text = "4eme Joueur :"
        '
        'lbl_second_player
        '
        Me.lbl_second_player.AutoSize = True
        Me.lbl_second_player.Location = New System.Drawing.Point(27, 102)
        Me.lbl_second_player.Name = "lbl_second_player"
        Me.lbl_second_player.Size = New System.Drawing.Size(74, 13)
        Me.lbl_second_player.TabIndex = 1
        Me.lbl_second_player.Text = "2eme Joueur :"
        '
        'lbl_first_player
        '
        Me.lbl_first_player.AutoSize = True
        Me.lbl_first_player.Location = New System.Drawing.Point(38, 67)
        Me.lbl_first_player.Name = "lbl_first_player"
        Me.lbl_first_player.Size = New System.Drawing.Size(63, 13)
        Me.lbl_first_player.TabIndex = 0
        Me.lbl_first_player.Text = "1er Joueur :"
        '
        'btn_play
        '
        Me.btn_play.Location = New System.Drawing.Point(278, 557)
        Me.btn_play.Name = "btn_play"
        Me.btn_play.Size = New System.Drawing.Size(306, 33)
        Me.btn_play.TabIndex = 14
        Me.btn_play.Text = "Jouer"
        Me.btn_play.UseVisualStyleBackColor = True
        '
        'gb_choice
        '
        Me.gb_choice.Controls.Add(Me.lbl_name_player)
        Me.gb_choice.Controls.Add(Me.btn_OK2)
        Me.gb_choice.Controls.Add(Me.lbl_false)
        Me.gb_choice.Controls.Add(Me.chbox6)
        Me.gb_choice.Controls.Add(Me.chbox5)
        Me.gb_choice.Controls.Add(Me.chbox4)
        Me.gb_choice.Controls.Add(Me.chbox3)
        Me.gb_choice.Controls.Add(Me.chbox2)
        Me.gb_choice.Controls.Add(Me.chbox1)
        Me.gb_choice.Controls.Add(Me.picbox_6)
        Me.gb_choice.Controls.Add(Me.picbox_5)
        Me.gb_choice.Controls.Add(Me.picbox_4)
        Me.gb_choice.Controls.Add(Me.picbox_3)
        Me.gb_choice.Controls.Add(Me.picbox_2)
        Me.gb_choice.Controls.Add(Me.picbox_1)
        Me.gb_choice.Location = New System.Drawing.Point(52, 323)
        Me.gb_choice.Name = "gb_choice"
        Me.gb_choice.Size = New System.Drawing.Size(733, 228)
        Me.gb_choice.TabIndex = 2
        Me.gb_choice.TabStop = False
        Me.gb_choice.Text = "Choix combinaison départ"
        '
        'lbl_name_player
        '
        Me.lbl_name_player.AutoSize = True
        Me.lbl_name_player.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name_player.Location = New System.Drawing.Point(310, 8)
        Me.lbl_name_player.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_name_player.Name = "lbl_name_player"
        Me.lbl_name_player.Size = New System.Drawing.Size(139, 25)
        Me.lbl_name_player.TabIndex = 15
        Me.lbl_name_player.Text = "Nom du joueur"
        '
        'btn_OK2
        '
        Me.btn_OK2.Location = New System.Drawing.Point(563, 177)
        Me.btn_OK2.Name = "btn_OK2"
        Me.btn_OK2.Size = New System.Drawing.Size(129, 33)
        Me.btn_OK2.TabIndex = 14
        Me.btn_OK2.Text = "Valider"
        Me.btn_OK2.UseVisualStyleBackColor = True
        '
        'lbl_false
        '
        Me.lbl_false.AutoSize = True
        Me.lbl_false.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_false.Location = New System.Drawing.Point(44, 177)
        Me.lbl_false.Name = "lbl_false"
        Me.lbl_false.Size = New System.Drawing.Size(173, 13)
        Me.lbl_false.TabIndex = 12
        Me.lbl_false.Text = "Attention, combinaison incohérente"
        '
        'chbox6
        '
        Me.chbox6.AutoSize = True
        Me.chbox6.Location = New System.Drawing.Point(644, 143)
        Me.chbox6.Name = "chbox6"
        Me.chbox6.Size = New System.Drawing.Size(15, 14)
        Me.chbox6.TabIndex = 11
        Me.chbox6.UseVisualStyleBackColor = True
        '
        'chbox5
        '
        Me.chbox5.AutoSize = True
        Me.chbox5.Location = New System.Drawing.Point(530, 143)
        Me.chbox5.Name = "chbox5"
        Me.chbox5.Size = New System.Drawing.Size(15, 14)
        Me.chbox5.TabIndex = 10
        Me.chbox5.UseVisualStyleBackColor = True
        '
        'chbox4
        '
        Me.chbox4.AutoSize = True
        Me.chbox4.Location = New System.Drawing.Point(416, 143)
        Me.chbox4.Name = "chbox4"
        Me.chbox4.Size = New System.Drawing.Size(15, 14)
        Me.chbox4.TabIndex = 9
        Me.chbox4.UseVisualStyleBackColor = True
        '
        'chbox3
        '
        Me.chbox3.AutoSize = True
        Me.chbox3.Location = New System.Drawing.Point(308, 143)
        Me.chbox3.Name = "chbox3"
        Me.chbox3.Size = New System.Drawing.Size(15, 14)
        Me.chbox3.TabIndex = 8
        Me.chbox3.UseVisualStyleBackColor = True
        '
        'chbox2
        '
        Me.chbox2.AutoSize = True
        Me.chbox2.Location = New System.Drawing.Point(182, 143)
        Me.chbox2.Name = "chbox2"
        Me.chbox2.Size = New System.Drawing.Size(15, 14)
        Me.chbox2.TabIndex = 7
        Me.chbox2.UseVisualStyleBackColor = True
        '
        'chbox1
        '
        Me.chbox1.AutoSize = True
        Me.chbox1.Location = New System.Drawing.Point(62, 143)
        Me.chbox1.Name = "chbox1"
        Me.chbox1.Size = New System.Drawing.Size(15, 14)
        Me.chbox1.TabIndex = 6
        Me.chbox1.UseVisualStyleBackColor = True
        '
        'picbox_6
        '
        Me.picbox_6.Location = New System.Drawing.Point(605, 41)
        Me.picbox_6.Name = "picbox_6"
        Me.picbox_6.Size = New System.Drawing.Size(87, 86)
        Me.picbox_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picbox_6.TabIndex = 5
        Me.picbox_6.TabStop = False
        '
        'picbox_5
        '
        Me.picbox_5.Location = New System.Drawing.Point(490, 41)
        Me.picbox_5.Name = "picbox_5"
        Me.picbox_5.Size = New System.Drawing.Size(87, 86)
        Me.picbox_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picbox_5.TabIndex = 4
        Me.picbox_5.TabStop = False
        '
        'picbox_4
        '
        Me.picbox_4.Location = New System.Drawing.Point(380, 41)
        Me.picbox_4.Name = "picbox_4"
        Me.picbox_4.Size = New System.Drawing.Size(87, 86)
        Me.picbox_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picbox_4.TabIndex = 3
        Me.picbox_4.TabStop = False
        '
        'picbox_3
        '
        Me.picbox_3.Location = New System.Drawing.Point(267, 41)
        Me.picbox_3.Name = "picbox_3"
        Me.picbox_3.Size = New System.Drawing.Size(87, 86)
        Me.picbox_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picbox_3.TabIndex = 2
        Me.picbox_3.TabStop = False
        '
        'picbox_2
        '
        Me.picbox_2.Location = New System.Drawing.Point(148, 41)
        Me.picbox_2.Name = "picbox_2"
        Me.picbox_2.Size = New System.Drawing.Size(87, 86)
        Me.picbox_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picbox_2.TabIndex = 1
        Me.picbox_2.TabStop = False
        '
        'picbox_1
        '
        Me.picbox_1.Location = New System.Drawing.Point(28, 41)
        Me.picbox_1.Name = "picbox_1"
        Me.picbox_1.Size = New System.Drawing.Size(87, 86)
        Me.picbox_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picbox_1.TabIndex = 0
        Me.picbox_1.TabStop = False
        '
        'Form_Begin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 603)
        Me.Controls.Add(Me.gb_choice)
        Me.Controls.Add(Me.gb_order)
        Me.Controls.Add(Me.gb_player)
        Me.Controls.Add(Me.btn_play)
        Me.Name = "Form_Begin"
        Me.Text = "Préparation"
        Me.gb_player.ResumeLayout(False)
        Me.gb_player.PerformLayout()
        CType(Me.num_nb_player, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_order.ResumeLayout(False)
        Me.gb_order.PerformLayout()
        Me.gb_choice.ResumeLayout(False)
        Me.gb_choice.PerformLayout()
        CType(Me.picbox_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbox_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbox_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbox_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbox_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbox_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gb_player As System.Windows.Forms.GroupBox
    Friend WithEvents btn_OK As System.Windows.Forms.Button
    Friend WithEvents txt_box_age3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_box_age4 As System.Windows.Forms.TextBox
    Friend WithEvents txt_box_age2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_box_age1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_box_fname4 As System.Windows.Forms.TextBox
    Friend WithEvents txt_box_fname2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_box_fname3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_box_fname1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_age As System.Windows.Forms.Label
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents num_nb_player As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_nb_player As System.Windows.Forms.Label
    Friend WithEvents gb_order As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_fourth_name As System.Windows.Forms.Label
    Friend WithEvents lbl_third_name As System.Windows.Forms.Label
    Friend WithEvents lbl_second_name As System.Windows.Forms.Label
    Friend WithEvents lbl_first_name As System.Windows.Forms.Label
    Friend WithEvents lbl_third_player As System.Windows.Forms.Label
    Friend WithEvents lbl_fourth_player As System.Windows.Forms.Label
    Friend WithEvents lbl_second_player As System.Windows.Forms.Label
    Friend WithEvents lbl_first_player As System.Windows.Forms.Label
    Friend WithEvents btn_play As System.Windows.Forms.Button
    Friend WithEvents gb_choice As System.Windows.Forms.GroupBox
    Friend WithEvents btn_OK2 As System.Windows.Forms.Button
    Friend WithEvents lbl_false As System.Windows.Forms.Label
    Friend WithEvents chbox6 As System.Windows.Forms.CheckBox
    Friend WithEvents chbox5 As System.Windows.Forms.CheckBox
    Friend WithEvents chbox4 As System.Windows.Forms.CheckBox
    Friend WithEvents chbox3 As System.Windows.Forms.CheckBox
    Friend WithEvents chbox2 As System.Windows.Forms.CheckBox
    Friend WithEvents chbox1 As System.Windows.Forms.CheckBox
    Friend WithEvents picbox_6 As System.Windows.Forms.PictureBox
    Friend WithEvents picbox_5 As System.Windows.Forms.PictureBox
    Friend WithEvents picbox_4 As System.Windows.Forms.PictureBox
    Friend WithEvents picbox_3 As System.Windows.Forms.PictureBox
    Friend WithEvents picbox_2 As System.Windows.Forms.PictureBox
    Friend WithEvents picbox_1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_remplir As System.Windows.Forms.Label
    Friend WithEvents lbl_name_player As Label
End Class
