Public Class FrmEntry

    Private Sub BtnSolo_Click(sender As Object, e As EventArgs) Handles BtnSolo.Click
        FrmOffline.Show()
        Me.Close()
    End Sub

    Private Sub BtnOnlinePlay_Click(sender As Object, e As EventArgs) Handles BtnOnlinePlay.Click
        FrmGamePeruser.Show()
        Me.Close()
    End Sub

    Private Sub OnKeyPressed(sender As Object, E As KeyEventArgs) Handles Me.KeyDown
        If E.KeyCode = Keys.F1 Then
            FrmHelp.Show()
        End If
    End Sub

    Private Sub DebugMeBtn_Click(sender As Object, e As EventArgs) Handles DebugMeBtn.Click
        FrmMPlayerGame.Show()
    End Sub
End Class