Public Class CCTool
    Dim tot As Integer
    'Load
    Private Sub CCTools_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        tot = Str_ApModBox.Value + End_ApModBox.Value + Dex_ApModBox.Value
        Total_APDispBox.Text = 6 - tot
    End Sub
    'Ap point restrictors
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
    'PC Skin and Marker Clicks
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Skin_Preview.Click
        PCSkin.Show()
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles Marker_Preview.Click
        PCMarker.Show()
    End Sub
    'Accept and Close Buttons
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MenuScreen.Show()
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim StatArray As New List(Of Integer)
        For Each number In Controls.OfType(Of NumericUpDown)
            StatArray.Add(number.Value)
            '(0) - Dexterity 
            '(1) - Endurance 
            '(2) - Strength
            Debug.WriteLine(number.Value)
        Next
        GameMap.NewGame(Me.Marker_Preview.Image, Me.Skin_Preview.Image)
        GameMap.Show()
        'My.Computer.Audio.Play("C:\Users\User\source\repos\Snakes and Goblins\WorldChessGame\Audio\gamesong_mixdown.wav", AudioPlayMode.BackgroundLoop)
        'Pass initial data to in game player character
        PCStat.NewGame(Conversion.Val(Me.CCTool_NameBox.Text), StatArray, Me.Skin_Preview.Image, Me.Marker_Preview.Image)
        PCStat.UpdateCharacter()
        Me.Close()
    End Sub
End Class