Public Class PCStat
    Public Sub UpdateCharacter()
        Me.NameBox.Text = BattleScreen.Pc.nm
        Me.StrStat.Text = BattleScreen.Pc.att
        Me.EndStat.Text = BattleScreen.Pc.def
        Me.DexStat.Text = BattleScreen.Pc.spd
        Me.MaxHealth.Text = BattleScreen.Pc.hp
        Me.CurrXP.Text = BattleScreen.Pc.xp
        Me.Skin.Image = BattleScreen.Pc.skn
        Me.Marker.Image = BattleScreen.Pc.mrk
    End Sub
End Class