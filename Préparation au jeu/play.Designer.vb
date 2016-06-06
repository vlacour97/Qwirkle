<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Partie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Partie))
        Me.lbl_name_player = New System.Windows.Forms.Label()
        Me.lbl_name_player2 = New System.Windows.Forms.Label()
        Me.lbl_score = New System.Windows.Forms.Label()
        Me.gb_tuiles = New System.Windows.Forms.GroupBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dropzone = New System.Windows.Forms.PictureBox()
        Me.picbox_switch = New System.Windows.Forms.PictureBox()
        Me.picbox_past = New System.Windows.Forms.PictureBox()
        Me.lbl_nbOfToken = New System.Windows.Forms.Label()
        Me.gb_tuiles.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dropzone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbox_switch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbox_past, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_name_player
        '
        Me.lbl_name_player.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_name_player.AutoSize = True
        Me.lbl_name_player.Location = New System.Drawing.Point(812, 31)
        Me.lbl_name_player.Name = "lbl_name_player"
        Me.lbl_name_player.Size = New System.Drawing.Size(79, 13)
        Me.lbl_name_player.TabIndex = 0
        Me.lbl_name_player.Text = "Nom du Joueur"
        '
        'lbl_name_player2
        '
        Me.lbl_name_player2.AutoSize = True
        Me.lbl_name_player2.Location = New System.Drawing.Point(136, 19)
        Me.lbl_name_player2.Name = "lbl_name_player2"
        Me.lbl_name_player2.Size = New System.Drawing.Size(0, 13)
        Me.lbl_name_player2.TabIndex = 1
        '
        'lbl_score
        '
        Me.lbl_score.AutoSize = True
        Me.lbl_score.Location = New System.Drawing.Point(25, 31)
        Me.lbl_score.Name = "lbl_score"
        Me.lbl_score.Size = New System.Drawing.Size(70, 13)
        Me.lbl_score.TabIndex = 2
        Me.lbl_score.Text = "Nombre point"
        '
        'gb_tuiles
        '
        Me.gb_tuiles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_tuiles.Controls.Add(Me.PictureBox6)
        Me.gb_tuiles.Controls.Add(Me.PictureBox5)
        Me.gb_tuiles.Controls.Add(Me.PictureBox4)
        Me.gb_tuiles.Controls.Add(Me.PictureBox3)
        Me.gb_tuiles.Controls.Add(Me.PictureBox2)
        Me.gb_tuiles.Controls.Add(Me.PictureBox1)
        Me.gb_tuiles.Location = New System.Drawing.Point(117, 508)
        Me.gb_tuiles.Name = "gb_tuiles"
        Me.gb_tuiles.Size = New System.Drawing.Size(670, 107)
        Me.gb_tuiles.TabIndex = 3
        Me.gb_tuiles.TabStop = False
        Me.gb_tuiles.Text = "Tuiles"
        '
        'PictureBox6
        '
        Me.PictureBox6.Location = New System.Drawing.Point(568, 19)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 5
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New System.Drawing.Point(468, 19)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(355, 19)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(255, 19)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(146, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(38, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.dropzone)
        Me.Panel1.Location = New System.Drawing.Point(8, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(900, 420)
        Me.Panel1.TabIndex = 4
        '
        'dropzone
        '
        Me.dropzone.Image = CType(resources.GetObject("dropzone.Image"), System.Drawing.Image)
        Me.dropzone.Location = New System.Drawing.Point(400, 144)
        Me.dropzone.Name = "dropzone"
        Me.dropzone.Size = New System.Drawing.Size(60, 60)
        Me.dropzone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.dropzone.TabIndex = 0
        Me.dropzone.TabStop = False
        '
        'picbox_switch
        '
        Me.picbox_switch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picbox_switch.Image = CType(resources.GetObject("picbox_switch.Image"), System.Drawing.Image)
        Me.picbox_switch.InitialImage = CType(resources.GetObject("picbox_switch.InitialImage"), System.Drawing.Image)
        Me.picbox_switch.Location = New System.Drawing.Point(43, 527)
        Me.picbox_switch.Name = "picbox_switch"
        Me.picbox_switch.Size = New System.Drawing.Size(39, 40)
        Me.picbox_switch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picbox_switch.TabIndex = 6
        Me.picbox_switch.TabStop = False
        '
        'picbox_past
        '
        Me.picbox_past.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picbox_past.Image = CType(resources.GetObject("picbox_past.Image"), System.Drawing.Image)
        Me.picbox_past.InitialImage = CType(resources.GetObject("picbox_past.InitialImage"), System.Drawing.Image)
        Me.picbox_past.Location = New System.Drawing.Point(802, 531)
        Me.picbox_past.Name = "picbox_past"
        Me.picbox_past.Size = New System.Drawing.Size(89, 29)
        Me.picbox_past.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picbox_past.TabIndex = 6
        Me.picbox_past.TabStop = False
        '
        'lbl_nbOfToken
        '
        Me.lbl_nbOfToken.AutoSize = True
        Me.lbl_nbOfToken.Location = New System.Drawing.Point(369, 31)
        Me.lbl_nbOfToken.Name = "lbl_nbOfToken"
        Me.lbl_nbOfToken.Size = New System.Drawing.Size(163, 13)
        Me.lbl_nbOfToken.TabIndex = 7
        Me.lbl_nbOfToken.Text = "Nombre de jeton dans la pioche :"
        Me.lbl_nbOfToken.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form_Partie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 592)
        Me.Controls.Add(Me.lbl_nbOfToken)
        Me.Controls.Add(Me.picbox_past)
        Me.Controls.Add(Me.picbox_switch)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gb_tuiles)
        Me.Controls.Add(Me.lbl_score)
        Me.Controls.Add(Me.lbl_name_player2)
        Me.Controls.Add(Me.lbl_name_player)
        Me.Name = "Form_Partie"
        Me.Text = "Partie"
        Me.gb_tuiles.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dropzone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbox_switch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbox_past, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_name_player As System.Windows.Forms.Label
    Friend WithEvents lbl_name_player2 As System.Windows.Forms.Label
    Friend WithEvents lbl_score As System.Windows.Forms.Label
    Friend WithEvents gb_tuiles As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dropzone As System.Windows.Forms.PictureBox
    Friend WithEvents picbox_switch As System.Windows.Forms.PictureBox
    Friend WithEvents picbox_past As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_nbOfToken As Label
End Class
