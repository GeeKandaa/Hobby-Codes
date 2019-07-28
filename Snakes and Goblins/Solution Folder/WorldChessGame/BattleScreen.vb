Public Class BattleScreen
    Private ReadOnly Opponents As New Dictionary(Of Integer, Object)
    Private esc As Integer
    Private Xp_Pot
    Public ForceClose As Boolean


    'Initialises UI and generates enemies
    Public Sub Encounter(ByVal num As Integer)
        'UI Setup
        With PCStat.PlayerCharacter
            Me.PlayerName.Text = .name
            Me.PlayerHP.Text = .hp
            Me.PlayerHP_Bar.Value = .hp / .hpMax * 100
            Me.PlayerXP.Text = .xp
            Me.PlayerXP_Bar.Value = .xp / .xpThresholds(.lvl - 1) * 100
            Me.XP_Mod.Text = ""
        End With
        'Generate enemies
        For i = 0 To num - 1
            Dim rng = Rnd()
            If rng < 0.5 Then
                Opponents.Add(i, New Goblin)
            Else
                Opponents.Add(i, New Snake)
            End If
            Me.Controls("Enemy" & i).BackgroundImage = Opponents(i).portrait
            CombatPicker.Controls("Enemy" & i & "Choose").BackgroundImage = Opponents(i).portrait
            Me.Controls("Enemy" & i & "Name").Text = Opponents(i).nm
            Me.Controls("Enemy" & i & "Desc").Text = Opponents(i).flavour
        Next
    End Sub


    'Updates player UI and checks for win state
    Public Sub UpdateScreen()
        Me.PlayerHP.Text = PCStat.PlayerCharacter.hp
        Me.PlayerHP_Bar.Value = PCStat.PlayerCharacter.hp / PCStat.PlayerCharacter.hpMax * 100

        If Opponents.Count() = 0 Then
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = True
            PCStat.PlayerCharacter.EarnXP(XP_Pot)
            Me.PlayerXP_Bar.Value = PCStat.PlayerCharacter.xp / PCStat.PlayerCharacter.xpThresholds(PCStat.PlayerCharacter.lvl - 1) * 100
        End If
    End Sub


    'Called from CombatPicker.vb, enemy objects calculate damage
    'After hp calculation, object may be removed from dictionary or status is updated
    'to reflect overall damage
    Public Sub Attack(ByVal enemyIndex As Integer)
        Dim dead As Boolean = Opponents(enemyIndex).Damage(PCStat.PlayerCharacter.att)
        If dead Then
            CombatPicker.Controls("Enemy" & enemyIndex & "Choose").BackgroundImage = Nothing
            Me.Controls("Enemy" & enemyIndex & "Status").Text = "Dead"
            Me.Controls("Enemy" & enemyIndex & "Desc").Text = Opponents(enemyIndex).ActiveDesc
            Me.XP_Mod.Text = "+" & Opponents(enemyIndex).xp
            Opponents.Remove(enemyIndex)
        Else
            Me.Controls("Enemy" & enemyIndex & "Status").Text = Opponents(enemyIndex).ActiveDesc
        End If
        Defend()
        UpdateScreen()
    End Sub


    'Calculate enemy actions and calculate player damage if attacked.
    Private Sub Defend()
        For Each Enemy In Opponents
            If Enemy.Value.Act(PCStat.PlayerCharacter.lvl) = True Then
                PCStat.PlayerCharacter.Damage(Enemy.Value.att)
                Me.Controls("Enemy" & Enemy.Key & "Desc").Text = Enemy.Value.AttText
                CombatPicker.Controls("Enemy" & Enemy.Key & "Choose").BackgroundImage = Opponents(Enemy.Key).portrait
            End If

        Next
    End Sub

    Private Sub ResetScreen()
        Opponents.Clear()
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = False
        XP_Pot = 0
        For i = 0 To 2
            Me.Controls("Enemy" & i & "Status").Text = ""
            CombatPicker.Controls("Enemy" & i & "Choose").BackgroundImage = Nothing
            Me.Controls("Enemy" & i).BackgroundImage = Nothing
            Me.Controls("Enemy" & i & "Name").Text = Nothing
            Me.Controls("Enemy" & i & "Desc").Text = Nothing

        Next
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CombatPicker.Show()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each Opponent In Opponents
            esc += Opponent.Value.spd
        Next
        If PCStat.PlayerCharacter.spd >= esc Then
            Me.Hide()
            Map.Show()
            ResetScreen()
        ElseIf PCStat.PlayerCharacter.spd >= Math.Floor(esc / 2) And Rnd() < 0.5 Then
            Me.Hide()
            Map.Show()
            ResetScreen()
        Else
            Defend()
            UpdateScreen()
        End If
    End Sub


    Private Sub BattleScreen_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'As Player Object is contained in this form, the form is prevented from closing 
        'unless Application Is exited via an expected method.
        If ForceClose = False Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Map.Show()
        ResetScreen()
    End Sub
End Class