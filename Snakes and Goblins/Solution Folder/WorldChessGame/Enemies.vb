Public Class Enemy

    '_____________
    ' Data Members
    ''''''''''''''

    ' Data Member Variables
    Public nm As String
    Public portrait As Image
    Public eneLvl As Integer
    Public att As Integer
    Public def As Integer
    Public spd As Integer
    Public hp As Integer
    Public hpMax As Integer
    Public xp As Integer
<<<<<<< HEAD:Snakes and Goblins/Solution Folder/WorldChessGame/Enemies.vb
    Public flavour As String
    Public Hurt1 As String
    Public Hurt2 As String
    Public AttText As String
    Public Death As String

    ' Member Events
    Public Event AnimDie()
    Public Event AnimCry()
    Public Event AnimAtt()
    'Public Event AnimHeal()

=======
    Public ActiveDesc As String
    Protected flavour As String
    Protected Hurt1 As String
    Protected Hurt2 As String
    Public AttText As String
    Protected Death As String
>>>>>>> Edit:Snakes and Goblins/Solution Folder/WorldChessGame/Enemies.vb

    '________________
    'Function Members
    '''''''''''''''''

    'Method
    'Public Sub Instakill()
    'RaiseEvent Die()
    'End Sub
<<<<<<< HEAD:Snakes and Goblins/Solution Folder/WorldChessGame/Enemies.vb
    Public Sub Attacked(ByVal Attack As Integer)
        hp -= Math.Ceiling(Attack - Math.Ceiling(def / 2))
    End Sub
=======
    Public Function Damage(ByVal Attack As Integer)
        hp -= Math.Ceiling(Attack - Math.Ceiling(def / 2))
        If hp <= 0 Then
            PCStat.PlayerCharacter.EarnXP(xp)
            ActiveDesc = Death
        ElseIf hp < hpMax / 3 Then
            ActiveDesc = Hurt2
        ElseIf hp < hpMax * 2 / 3 Then
            ActiveDesc = Hurt1
        End If
        Return True
    End Function
>>>>>>> Edit:Snakes and Goblins/Solution Folder/WorldChessGame/Enemies.vb
    Public Function Act(ByVal lvl As Integer)
        Randomize()
        Dim rng = Rnd()
        If rng <= 0.1 Then
<<<<<<< HEAD:Snakes and Goblins/Solution Folder/WorldChessGame/Enemies.vb
            RaiseEvent AnimAtt()
            Return True
        ElseIf rng * eneLvl <= lvl / 10 Then
            RaiseEvent AnimCry()
            Return False
        Else
            Return True
            RaiseEvent AnimAtt()
=======
            Return True
        ElseIf rng * eneLvl <= lvl / 10 Then
            Return False
        Else
            Return True
>>>>>>> Edit:Snakes and Goblins/Solution Folder/WorldChessGame/Enemies.vb
        End If
    End Function

End Class

Public Class Goblin
    Inherits Enemy
    Public Sub New()
        nm = "Goblin"
<<<<<<< HEAD:Snakes and Goblins/Solution Folder/WorldChessGame/Enemies.vb
        portrait = My.Resources.Enemy_Goblin_Idle
=======
        portrait = Nothing
>>>>>>> Edit:Snakes and Goblins/Solution Folder/WorldChessGame/Enemies.vb
        eneLvl = 1
        att = 3
        def = 1
        spd = 1
        hp = 5
        hpMax = 5
        xp = 20
        flavour = "The goblin glares at you, grits it teeth and lets out a bloodcurdling shriek!"
        Hurt1 = "It looks injured!"
        Hurt2 = "Seriously bloodied and bruised"
        AttText = "With a gargling cry, the goblin claws at you!"
        Death = "The goblin slumps dead, it's green blood pools beneath it."

    End Sub

End Class

Public Class Snake
    Inherits Enemy
    Public Sub New()
        nm = "Snake"
<<<<<<< HEAD:Snakes and Goblins/Solution Folder/WorldChessGame/Enemies.vb
        portrait = My.Resources.Enemy_Snake_Idle
=======
        portrait = Nothing
>>>>>>> Edit:Snakes and Goblins/Solution Folder/WorldChessGame/Enemies.vb
        eneLvl = 1
        att = 2
        def = 1
        spd = 3
        hp = 2
        xp = 10
        flavour = "The snake is poised to attack, it's poison coated fangs glisten."
        Hurt1 = "It looks hesistant!"
        Hurt2 = "Writhing in agony"
        AttText = "With a hiss, the snake lunges at you!"
        Death = "With one fell strike the snake's head comes clean from it's body."
    End Sub
End Class