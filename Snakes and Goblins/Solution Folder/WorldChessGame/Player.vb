﻿Public Class Player
    '_____________
    ' Data Members
    ''''''''''''''

    ' Data Member Variables
<<<<<<< HEAD:Snakes and Goblins/Solution Folder/WorldChessGame/Player.vb
    Public nm As String
    Public skn As Image
    Public mrk As Image
    Public PCLvl As Integer
=======
    Public name As String
    Public skin As Image
    Public mark As Image
    Public lvl As Integer
>>>>>>> Edit:Snakes and Goblins/Solution Folder/WorldChessGame/Player.vb
    Public att As Integer
    Public def As Integer
    Public spd As Integer
    Public hp As Integer
    Public hpMax As Integer
    Public xp As Integer
    Public APMod As Integer
    Public ReadOnly xpThresholds As New List(Of Integer)(20) From
        {100, 250, 500, 1000, 2000, 4000, 6000, 8000, 10000, 12000, 15000, 18000, 21000, 25000, 29000, 33000, 37000, 41000, 45000, 50000}

    Public Sub EarnXP(ByVal Experience As Integer)
        xp += Experience
<<<<<<< HEAD:Snakes and Goblins/Solution Folder/WorldChessGame/Player.vb
        While xp >= xpThresholds(PCLvl - 1)
            PCLvl += 1
            APMod += 2
        End While
    End Sub
    Public Sub Attacked(ByVal Attack As Integer)
        hp -= Math.Ceiling(Attack - Math.Ceiling(def / 2))
    End Sub
    Public Sub New(ByVal PlayerName As String, ByVal Skin As Image, ByVal Marker As Image, ByVal Attack As Integer, ByVal Defense As Integer, ByVal Speed As Integer, Health As Integer)
        nm = PlayerName
        skn = Skin
        mrk = Marker
        PCLvl = 1
        att = Attack
        def = Defense
        spd = Speed
        hp = Health
        hpMax = Health
=======
        While xp >= xpThresholds(lvl - 1)
            lvl += 1
            APMod += 2
        End While
    End Sub
    Public Sub Damage(ByVal Attack As Integer)
        hp -= Math.Ceiling(Attack - Math.Ceiling(def / 2))
        If hp <= 0 Then
            For Each frm In Application.OpenForms
                frm.Hide()
            Next
            GameOver.Show()
        End If
    End Sub
    Public Sub New(ByVal PlayerName As String, ByVal Skn As Image, ByVal Marker As Image, ByVal Attack As Integer, ByVal Defense As Integer, ByVal Speed As Integer)
        name = PlayerName
        skin = Skn
        mark = Marker
        lvl = 1
        att = Attack
        def = Defense
        spd = Speed
        hp = 20 + Defense * 4
        hpMax = 20 + Defense * 4
>>>>>>> Edit:Snakes and Goblins/Solution Folder/WorldChessGame/Player.vb
        xp = 0
        APMod = 0
    End Sub
End Class