﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_menu
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
        Me.btn_begin = New System.Windows.Forms.Button()
        Me.btn_leave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_begin
        '
        Me.btn_begin.Location = New System.Drawing.Point(42, 36)
        Me.btn_begin.Name = "btn_begin"
        Me.btn_begin.Size = New System.Drawing.Size(193, 90)
        Me.btn_begin.TabIndex = 0
        Me.btn_begin.Text = "Commencer"
        Me.btn_begin.UseVisualStyleBackColor = True
        '
        'btn_leave
        '
        Me.btn_leave.Location = New System.Drawing.Point(42, 163)
        Me.btn_leave.Name = "btn_leave"
        Me.btn_leave.Size = New System.Drawing.Size(192, 73)
        Me.btn_leave.TabIndex = 1
        Me.btn_leave.Text = "Quitter"
        Me.btn_leave.UseVisualStyleBackColor = True
        '
        'Form_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btn_leave)
        Me.Controls.Add(Me.btn_begin)
        Me.Name = "Form_menu"
        Me.Text = "Quirckle"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_begin As System.Windows.Forms.Button
    Friend WithEvents btn_leave As System.Windows.Forms.Button

End Class