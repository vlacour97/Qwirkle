<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Switch
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
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.btn_switch = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.chbox1 = New System.Windows.Forms.CheckBox()
        Me.chbox2 = New System.Windows.Forms.CheckBox()
        Me.chbox3 = New System.Windows.Forms.CheckBox()
        Me.chbox4 = New System.Windows.Forms.CheckBox()
        Me.chbox5 = New System.Windows.Forms.CheckBox()
        Me.chbox6 = New System.Windows.Forms.CheckBox()
        Me.lbl_need = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(39, 34)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(76, 13)
        Me.lbl_name.TabIndex = 0
        Me.lbl_name.Text = "Nom du joueur"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(31, 66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(111, 66)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(188, 66)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(265, 66)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New System.Drawing.Point(342, 66)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 6
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Location = New System.Drawing.Point(417, 66)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 7
        Me.PictureBox6.TabStop = False
        '
        'btn_switch
        '
        Me.btn_switch.Location = New System.Drawing.Point(65, 179)
        Me.btn_switch.Name = "btn_switch"
        Me.btn_switch.Size = New System.Drawing.Size(88, 34)
        Me.btn_switch.TabIndex = 8
        Me.btn_switch.Text = "Echanger"
        Me.btn_switch.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(176, 179)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(88, 34)
        Me.btn_cancel.TabIndex = 9
        Me.btn_cancel.Text = "Annuler"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'chbox1
        '
        Me.chbox1.AutoSize = True
        Me.chbox1.Location = New System.Drawing.Point(54, 146)
        Me.chbox1.Name = "chbox1"
        Me.chbox1.Size = New System.Drawing.Size(15, 14)
        Me.chbox1.TabIndex = 10
        Me.chbox1.UseVisualStyleBackColor = True
        '
        'chbox2
        '
        Me.chbox2.AutoSize = True
        Me.chbox2.Location = New System.Drawing.Point(138, 146)
        Me.chbox2.Name = "chbox2"
        Me.chbox2.Size = New System.Drawing.Size(15, 14)
        Me.chbox2.TabIndex = 11
        Me.chbox2.UseVisualStyleBackColor = True
        '
        'chbox3
        '
        Me.chbox3.AutoSize = True
        Me.chbox3.Location = New System.Drawing.Point(212, 146)
        Me.chbox3.Name = "chbox3"
        Me.chbox3.Size = New System.Drawing.Size(15, 14)
        Me.chbox3.TabIndex = 12
        Me.chbox3.UseVisualStyleBackColor = True
        '
        'chbox4
        '
        Me.chbox4.AutoSize = True
        Me.chbox4.Location = New System.Drawing.Point(288, 146)
        Me.chbox4.Name = "chbox4"
        Me.chbox4.Size = New System.Drawing.Size(15, 14)
        Me.chbox4.TabIndex = 13
        Me.chbox4.UseVisualStyleBackColor = True
        '
        'chbox5
        '
        Me.chbox5.AutoSize = True
        Me.chbox5.Location = New System.Drawing.Point(367, 146)
        Me.chbox5.Name = "chbox5"
        Me.chbox5.Size = New System.Drawing.Size(15, 14)
        Me.chbox5.TabIndex = 14
        Me.chbox5.UseVisualStyleBackColor = True
        '
        'chbox6
        '
        Me.chbox6.AutoSize = True
        Me.chbox6.Location = New System.Drawing.Point(444, 146)
        Me.chbox6.Name = "chbox6"
        Me.chbox6.Size = New System.Drawing.Size(15, 14)
        Me.chbox6.TabIndex = 15
        Me.chbox6.UseVisualStyleBackColor = True
        '
        'lbl_need
        '
        Me.lbl_need.AutoSize = True
        Me.lbl_need.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_need.Location = New System.Drawing.Point(52, 234)
        Me.lbl_need.Name = "lbl_need"
        Me.lbl_need.Size = New System.Drawing.Size(101, 13)
        Me.lbl_need.TabIndex = 16
        Me.lbl_need.Text = "Nécessite des tuiles"
        '
        'Form_Switch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 280)
        Me.Controls.Add(Me.lbl_need)
        Me.Controls.Add(Me.chbox6)
        Me.Controls.Add(Me.chbox5)
        Me.Controls.Add(Me.chbox4)
        Me.Controls.Add(Me.chbox3)
        Me.Controls.Add(Me.chbox2)
        Me.Controls.Add(Me.chbox1)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_switch)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_name)
        Me.Name = "Form_Switch"
        Me.Text = "Echange des tuiles"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_switch As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents chbox1 As System.Windows.Forms.CheckBox
    Friend WithEvents chbox2 As System.Windows.Forms.CheckBox
    Friend WithEvents chbox3 As System.Windows.Forms.CheckBox
    Friend WithEvents chbox4 As System.Windows.Forms.CheckBox
    Friend WithEvents chbox5 As System.Windows.Forms.CheckBox
    Friend WithEvents chbox6 As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_need As System.Windows.Forms.Label

End Class
