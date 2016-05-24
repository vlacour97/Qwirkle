<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_End
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
        Me.gb_results = New System.Windows.Forms.GroupBox()
        Me.lbl_score4 = New System.Windows.Forms.Label()
        Me.lbl_score3 = New System.Windows.Forms.Label()
        Me.lbl_score2 = New System.Windows.Forms.Label()
        Me.lbl_score1 = New System.Windows.Forms.Label()
        Me.lbl_fourth_place = New System.Windows.Forms.Label()
        Me.lbl_third_name = New System.Windows.Forms.Label()
        Me.lbl_second_name = New System.Windows.Forms.Label()
        Me.lbl_first_name = New System.Windows.Forms.Label()
        Me.btn_replay = New System.Windows.Forms.Button()
        Me.btn_menu = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gb_results.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_results
        '
        Me.gb_results.Controls.Add(Me.lbl_score4)
        Me.gb_results.Controls.Add(Me.lbl_score3)
        Me.gb_results.Controls.Add(Me.lbl_score2)
        Me.gb_results.Controls.Add(Me.lbl_score1)
        Me.gb_results.Controls.Add(Me.lbl_fourth_place)
        Me.gb_results.Controls.Add(Me.lbl_third_name)
        Me.gb_results.Controls.Add(Me.lbl_second_name)
        Me.gb_results.Controls.Add(Me.lbl_first_name)
        Me.gb_results.Location = New System.Drawing.Point(38, 53)
        Me.gb_results.Name = "gb_results"
        Me.gb_results.Size = New System.Drawing.Size(369, 215)
        Me.gb_results.TabIndex = 0
        Me.gb_results.TabStop = False
        Me.gb_results.Text = "Résultats"
        '
        'lbl_score4
        '
        Me.lbl_score4.AutoSize = True
        Me.lbl_score4.Location = New System.Drawing.Point(194, 159)
        Me.lbl_score4.Name = "lbl_score4"
        Me.lbl_score4.Size = New System.Drawing.Size(33, 13)
        Me.lbl_score4.TabIndex = 7
        Me.lbl_score4.Text = "score"
        '
        'lbl_score3
        '
        Me.lbl_score3.AutoSize = True
        Me.lbl_score3.Location = New System.Drawing.Point(194, 116)
        Me.lbl_score3.Name = "lbl_score3"
        Me.lbl_score3.Size = New System.Drawing.Size(33, 13)
        Me.lbl_score3.TabIndex = 6
        Me.lbl_score3.Text = "score"
        '
        'lbl_score2
        '
        Me.lbl_score2.AutoSize = True
        Me.lbl_score2.Location = New System.Drawing.Point(194, 78)
        Me.lbl_score2.Name = "lbl_score2"
        Me.lbl_score2.Size = New System.Drawing.Size(33, 13)
        Me.lbl_score2.TabIndex = 5
        Me.lbl_score2.Text = "score"
        '
        'lbl_score1
        '
        Me.lbl_score1.AutoSize = True
        Me.lbl_score1.Location = New System.Drawing.Point(194, 39)
        Me.lbl_score1.Name = "lbl_score1"
        Me.lbl_score1.Size = New System.Drawing.Size(33, 13)
        Me.lbl_score1.TabIndex = 4
        Me.lbl_score1.Text = "score"
        '
        'lbl_fourth_place
        '
        Me.lbl_fourth_place.AutoSize = True
        Me.lbl_fourth_place.Location = New System.Drawing.Point(31, 159)
        Me.lbl_fourth_place.Name = "lbl_fourth_place"
        Me.lbl_fourth_place.Size = New System.Drawing.Size(76, 13)
        Me.lbl_fourth_place.TabIndex = 3
        Me.lbl_fourth_place.Text = "Nom du joueur"
        '
        'lbl_third_name
        '
        Me.lbl_third_name.AutoSize = True
        Me.lbl_third_name.Location = New System.Drawing.Point(31, 116)
        Me.lbl_third_name.Name = "lbl_third_name"
        Me.lbl_third_name.Size = New System.Drawing.Size(76, 13)
        Me.lbl_third_name.TabIndex = 2
        Me.lbl_third_name.Text = "Nom du joueur"
        '
        'lbl_second_name
        '
        Me.lbl_second_name.AutoSize = True
        Me.lbl_second_name.Location = New System.Drawing.Point(31, 78)
        Me.lbl_second_name.Name = "lbl_second_name"
        Me.lbl_second_name.Size = New System.Drawing.Size(76, 13)
        Me.lbl_second_name.TabIndex = 1
        Me.lbl_second_name.Text = "Nom du joueur"
        '
        'lbl_first_name
        '
        Me.lbl_first_name.AutoSize = True
        Me.lbl_first_name.Location = New System.Drawing.Point(31, 39)
        Me.lbl_first_name.Name = "lbl_first_name"
        Me.lbl_first_name.Size = New System.Drawing.Size(76, 13)
        Me.lbl_first_name.TabIndex = 0
        Me.lbl_first_name.Text = "Nom du joueur"
        '
        'btn_replay
        '
        Me.btn_replay.Location = New System.Drawing.Point(23, 341)
        Me.btn_replay.Name = "btn_replay"
        Me.btn_replay.Size = New System.Drawing.Size(184, 69)
        Me.btn_replay.TabIndex = 2
        Me.btn_replay.Text = "Rejouer"
        Me.btn_replay.UseVisualStyleBackColor = False
        '
        'btn_menu
        '
        Me.btn_menu.Location = New System.Drawing.Point(235, 341)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(184, 69)
        Me.btn_menu.TabIndex = 3
        Me.btn_menu.Text = "Menu"
        Me.btn_menu.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 299)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Le joueur qui a gagné est ___________ ! Bravo !"
        '
        'Form_End
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 456)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_menu)
        Me.Controls.Add(Me.btn_replay)
        Me.Controls.Add(Me.gb_results)
        Me.Name = "Form_End"
        Me.Text = "Fin de la partie"
        Me.gb_results.ResumeLayout(False)
        Me.gb_results.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gb_results As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_score4 As System.Windows.Forms.Label
    Friend WithEvents lbl_score3 As System.Windows.Forms.Label
    Friend WithEvents lbl_score2 As System.Windows.Forms.Label
    Friend WithEvents lbl_score1 As System.Windows.Forms.Label
    Friend WithEvents lbl_fourth_place As System.Windows.Forms.Label
    Friend WithEvents lbl_third_name As System.Windows.Forms.Label
    Friend WithEvents lbl_second_name As System.Windows.Forms.Label
    Friend WithEvents lbl_first_name As System.Windows.Forms.Label
    Friend WithEvents btn_replay As System.Windows.Forms.Button
    Friend WithEvents btn_menu As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
