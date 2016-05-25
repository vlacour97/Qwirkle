<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rankingTable
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
        Me.rank = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_description = New System.Windows.Forms.Label()
        Me.Back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rank
        '
        Me.rank.ColumnCount = 3
        Me.rank.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.rank.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.rank.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.rank.Location = New System.Drawing.Point(26, 67)
        Me.rank.Name = "rank"
        Me.rank.RowCount = 11
        Me.rank.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.rank.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.rank.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.rank.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.rank.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.rank.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.rank.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.rank.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.rank.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.rank.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.rank.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.rank.Size = New System.Drawing.Size(682, 460)
        Me.rank.TabIndex = 0
        '
        'lbl_description
        '
        Me.lbl_description.AutoSize = True
        Me.lbl_description.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_description.Location = New System.Drawing.Point(198, 20)
        Me.lbl_description.Name = "lbl_description"
        Me.lbl_description.Size = New System.Drawing.Size(331, 25)
        Me.lbl_description.TabIndex = 1
        Me.lbl_description.Text = "Classement des 10 meilleurs joueurs"
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(230, 533)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(247, 38)
        Me.Back.TabIndex = 2
        Me.Back.Text = "Retour"
        Me.Back.UseVisualStyleBackColor = True
        '
        'rankingTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 588)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.lbl_description)
        Me.Controls.Add(Me.rank)
        Me.Name = "rankingTable"
        Me.Text = "rankingTable"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rank As TableLayoutPanel
    Friend WithEvents lbl_description As Label
    Friend WithEvents Back As Button
End Class
