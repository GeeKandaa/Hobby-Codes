Public Class CombatPicker
    Private Sub Enemy0Choose_Click(sender As Object, e As EventArgs) Handles Enemy0Choose.Click
        Hide()
        BattleScreen.Attack(0)
    End Sub
    Private Sub Enemy1Choose_Click(sender As Object, e As EventArgs) Handles Enemy1Choose.Click
        Hide()
        BattleScreen.Attack(1)
    End Sub
    Private Sub Enemy2Choose_Click(sender As Object, e As EventArgs) Handles Enemy2Choose.Click
        Hide()
        BattleScreen.Attack(2)
    End Sub
End Class