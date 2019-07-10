Public Class CCTool
    Dim tot As Integer
    Private Sub CCTools_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        tot = Str_ApModBox.Value + End_ApModBox.Value + Dex_ApModBox.Value
        Total_APDispBox.Text = 6 - tot
    End Sub

    'Ensure initial stats cannot be set higher than 4 or lower than 1
    Private Sub CheckVal(ByVal sender As Object)
        tot = Str_ApModBox.Value + End_ApModBox.Value + Dex_ApModBox.Value
        If tot > 6 Then
            sender.Value = sender.Value - 1
        ElseIf tot < 0 Or sender.Value = 0 Then
            sender.Value = sender.Value + 1
        Else
            Total_APDispBox.Text = 6 - tot
        End If
    End Sub
    Private Sub Str_ApModBox_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Str_ApModBox.ValueChanged
        CheckVal(sender)
    End Sub
    Private Sub End_ApModBox_ValueChanged(sender As Object, e As EventArgs) Handles End_ApModBox.ValueChanged
        CheckVal(sender)
    End Sub
    Private Sub Dex_ApModBox_ValueChanged(sender As Object, e As EventArgs) Handles Dex_ApModBox.ValueChanged
        CheckVal(sender)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Skin_Preview.Click
        PCSkin.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles Marker_Preview.Click
        PCMarker.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MenuScreen.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GameMap.GameMapLoad("Level0", Me.Marker_Preview.Image)
        GameMap.Show()
        'Pass initial data to in game player character
        BattleScreen.NewCharacter(Me.CCTool_NameBox.Text, Me.Skin_Preview.Image, Me.Marker_Preview.Image, Me.Str_ApModBox.Value, Me.End_ApModBox.Value, Me.Dex_ApModBox.Value, Me.MaxHealth.Text)
        PCStat.UpdateCharacter()
        Me.Close()
    End Sub
End Class