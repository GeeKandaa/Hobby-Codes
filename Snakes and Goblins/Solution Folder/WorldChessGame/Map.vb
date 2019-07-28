' Form2 Script
Public Class Map
    '_________________
    ' Member variables
    ''''''''''''''''''
    Private xPos As Integer
    Private yPos As Integer


    'OnLoad code variable
    'Dim newgame As Boolean

    ' MovePlayer() Variables
    Private CurrentPb As PictureBox
    Private NextPb As PictureBox
    Private ReadOnly TileList As New List(Of PictureBox)(8)

    '_______________
    ' Member Methods
    ''''''''''''''''
    Private PlayerMark As Image
    Public Sub InitialiseGame(ByVal Marker As Image)
        PlayerMark = Marker
    End Sub



    Private Sub Map_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'initial x,y
        xPos = 1
        yPos = 1
        'Place Player marker on map
        CurrentPb = TableLayoutPanel1.Controls("Disp" & xPos & yPos)
        CurrentPb.Image = PlayerMark
        Unfog(xPos, yPos)
    End Sub



    Private Sub Unfog(ByVal xPos As Integer, ByVal yPos As Integer)
        'Check each surrounding tile exists and set to visible if so
        TileList.Add(TableLayoutPanel1.Controls("Disp" & xPos + 1 & yPos + 1))
        TileList.Add(TableLayoutPanel1.Controls("Disp" & xPos + 1 & yPos - 1))
        TileList.Add(TableLayoutPanel1.Controls("Disp" & xPos - 1 & yPos + 1))
        TileList.Add(TableLayoutPanel1.Controls("Disp" & xPos - 1 & yPos - 1))
        TileList.Add(TableLayoutPanel1.Controls("Disp" & xPos + 1 & yPos))
        TileList.Add(TableLayoutPanel1.Controls("Disp" & xPos - 1 & yPos))
        TileList.Add(TableLayoutPanel1.Controls("Disp" & xPos & yPos + 1))
        TileList.Add(TableLayoutPanel1.Controls("Disp" & xPos & yPos - 1))
        For Each item In TileList
            If item IsNot Nothing Then
                item.Visible = True
            End If
        Next
    End Sub


    Private Sub Map_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        BattleScreen.ForceClose = True
        Application.Exit()
    End Sub


    Private Sub ToolbarEquipment_Click(sender As Object, e As EventArgs) Handles ToolbarEquipment.Click
        If PCStat.Visible Then
            PCStat.Hide()
        Else
            PCStat.UpdateCharacter()
            PCStat.Show()
        End If
    End Sub

    Private Sub X600ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles X600ToolStripMenuItem.Click
        Me.Size = New Size(800, 600)
    End Sub

    Private Sub X768ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles X768ToolStripMenuItem.Click
        Me.Size = New Size(1024, 768)
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Me.Size = New Size(1280, 1024)
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Me.Size = New Size(1366, 768)
    End Sub
    Private Sub QuitGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitGameToolStripMenuItem.Click
        BattleScreen.ForceClose = True
        Application.Exit()
    End Sub

    'Generates Enemies randomly
    Private Sub EncounterCheck()
        Randomize()
        Dim rng = Rnd()
        If rng < 0.1 Then
            Me.Hide()
            BattleScreen.Show()
            BattleScreen.Encounter(3)
        ElseIf rng < 0.3 Then
            Me.Hide()
            BattleScreen.Show()
            BattleScreen.Encounter(2)
        ElseIf rng < 0.4 Then
            Me.Hide()
            BattleScreen.Show()
            BattleScreen.Encounter(1)
        End If
    End Sub

End Class