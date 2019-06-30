Public Class BattleScreen
    Private ReadOnly Opponents As New Dictionary(Of Integer, Object)
    Public Pc As Player
    Private XP_Pot
    Private esc As Integer
    Public ForceClose As Boolean

    'Initialises Player object
    Public Sub NewCharacter(ByVal PlayerName As String, ByVal Marker As Image, ByVal Skin As Image, ByVal Attack As Integer, ByVal Defense As Integer, ByVal Speed As Integer, Health As Integer)
        Me.PlayerSkin.Image = Skin
        Pc = New Player(PlayerName, Skin, Marker, Attack, Defense, Speed, Health)
    End Sub

    'Initialises UI and generates enemies
    Public Sub Encounter(ByVal num As Integer)

        Me.PlayerName.Text = Pc.nm
        Me.PlayerHP.Text = Pc.hp
        Me.PlayerHP_Bar.Value = Pc.hp / Pc.hpMax * 100
        Me.PlayerXP.Text = Pc.xp
        Me.PlayerXP_Bar.Value = Pc.xp / Pc.xpThresholds(Pc.PCLvl - 1) * 100
        Me.XP_Mod.Text = ""

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

            XP_Pot += Opponents(i).xp
        Next
    End Sub

    'Updates player UI and checks for win state
    Public Sub UpdateScreen()
        Me.PlayerHP.Text = Pc.hp
        Try
            Me.PlayerHP_Bar.Value = Pc.hp / Pc.hpMax * 100
        Finally
            'Likely error is negative value or dividing by zero,
            'The next If Statement effectively acts as a catch
        End Try

        If Pc.hp < 1 Then
            Me.Hide()
            GameOver.Show()
        End If
        If Opponents.Count() = 0 Then
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = True
            Me.XP_Mod.Text = "+" & XP_Pot
            Pc.EarnXP(XP_Pot)
            Me.PlayerXP_Bar.Value = Pc.xp / Pc.xpThresholds(Pc.PCLvl - 1) * 100
        End If
    End Sub
    'Called from CombatPicker.vb, enemy objects calculate damage
    'After hp calculation, object may be removed from dictionary or status is updated
    'to reflect overall damage
    Public Sub Attack(ByVal enemyIndex As Integer)
        Opponents(enemyIndex).Attacked(Pc.att)
        If Opponents(enemyIndex).hp < 1 Then
            CombatPicker.Controls("Enemy" & enemyIndex & "Choose").BackgroundImage = Nothing
            Me.Controls("Enemy" & enemyIndex & "Status").Text = "Dead"
            Me.Controls("Enemy" & enemyIndex & "Desc").Text = Opponents(enemyIndex).Death
            Opponents.Remove(enemyIndex)
        ElseIf Opponents(enemyIndex).hp < Opponents(enemyIndex).hpMax / 3 Then
            Me.Controls("Enemy" & enemyIndex & "Status").Text = Opponents(enemyIndex).Hurt2
        ElseIf Opponents(enemyIndex).hp < Opponents(enemyIndex).hpMax / 3 * 2 Then
            Me.Controls("Enemy" & enemyIndex & "Status").Text = Opponents(enemyIndex).Hurt1
        End If
        Defend()
        UpdateScreen()

    End Sub

    'Calculate enemy actions and calculate player damage if attacked.
    Private Sub Defend()
        For Each Enemy In Opponents
            If Enemy.Value.Act(Pc.PCLvl) = True Then
                Pc.Attacked(Enemy.Value.att)
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
        If Pc.spd >= esc Then
            Me.Hide()
            Map.Show()
            ResetScreen()
        ElseIf Pc.spd >= Math.Floor(esc / 2) And Rnd() < 0.5 Then
            Me.Hide()
            Map.Show()
            ResetScreen()
        Else
            Defend()
            UpdateScreen()
        End If
    End Sub

    'As Player Object is contained in this form, the form is prevented from closing
    Private Sub BattleScreen_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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