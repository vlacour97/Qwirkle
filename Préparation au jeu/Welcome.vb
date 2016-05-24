Public Class Form_menu
    Private Sub btn_begin_Click(sender As Object, e As EventArgs) Handles btn_begin.Click
        My.Forms.Form_Begin.Show()
        Me.Close()
    End Sub

    Private Sub btn_leave_Click(sender As Object, e As EventArgs) Handles btn_leave.Click
        Me.Close()
    End Sub
End Class
