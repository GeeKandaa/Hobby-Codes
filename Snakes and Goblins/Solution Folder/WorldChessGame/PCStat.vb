Public Class PCStat

    Public PlayerCharacter As Player
    Public Sub NewGame(ByVal Name As String, ByVal StatsArray As List(Of Integer), ByVal skin As Image, ByVal Marker As Image)
        PlayerCharacter = New Player(Name, skin, Marker, StatsArray(2), StatsArray(1), StatsArray(0))
        Me.NameBox.Text = PlayerCharacter.name
        Me.Skin.Image = PlayerCharacter.skin
        Me.Marker.Image = PlayerCharacter.mark
        UpdateCharacter()
    End Sub
    Public Sub UpdateCharacter()
        With PlayerCharacter
            Me.StrStat.Text = .att
            Me.EndStat.Text = .def
            Me.DexStat.Text = .spd
            Me.MaxHealth.Text = .hp
            Me.HpCurr.Text = .hp
            Me.CurrXP.Text = .xp
            Me.NextXP.Text = .xpThresholds(.lvl - 1) - .xp
            If .APMod > 0 Then
                Me.APPoints.Enabled = True
                Me.APPoints.Text = .APMod
                Me.ApPoint_Text.Enabled = True
                Me.IncDex.Enabled = True
                Me.IncEnd.Enabled = True
                Me.IncStr.Enabled = True
            Else
                Me.APPoints.Enabled = False
                Me.ApPoint_Text.Enabled = False
                Me.IncDex.Enabled = False
                Me.IncEnd.Enabled = False
                Me.IncStr.Enabled = False
            End If
        End With
    End Sub

    Private Sub IncStr_Click(sender As Object, e As EventArgs) Handles IncStr.Click
        PlayerCharacter.att += 1
        PlayerCharacter.APMod -= 1
        UpdateCharacter()
    End Sub

    Private Sub IncDex_Click(sender As Object, e As EventArgs) Handles IncDex.Click
        PlayerCharacter.spd += 1
        PlayerCharacter.APMod -= 1
        UpdateCharacter()
    End Sub

    Private Sub IncEnd_Click(sender As Object, e As EventArgs) Handles IncEnd.Click
        PlayerCharacter.def += 1
        PlayerCharacter.APMod -= 1
        UpdateCharacter()
    End Sub
End Class