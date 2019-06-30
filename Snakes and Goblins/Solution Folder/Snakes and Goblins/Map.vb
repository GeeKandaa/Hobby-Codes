' Form2 Script
Public Class Map
    '_________________
    ' Member variables
    ''''''''''''''''''
    Private xPos As Integer
    Private yPos As Integer
    Private PlayerMark As Image

    'OnLoad code variable
    'Dim newgame As Boolean

    ' MovePlayer() Variables
    Private CurrentPb As PictureBox
    Private NextPb As PictureBox
    Private ReadOnly TileList As New List(Of PictureBox)(8)

    '_______________
    ' Member Methods
    ''''''''''''''''

    Public Sub InitialiseGame(ByVal Marker As Image)
        PlayerMark = Marker
    End Sub



    Private Sub Map_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StartPosition = FormStartPosition.CenterScreen
        'initial x,y
        xPos = 7
        yPos = 4
        CurrentPb = TableLayoutPanel1.Controls("Disp" & xPos & yPos)
        CurrentPb.Image = PlayerMark
        'Check each surrounding tile exists and set to visible if so
        TileList.Insert(0, TableLayoutPanel1.Controls("Disp" & xPos + 1 & yPos + 1))
        TileList.Insert(1, TableLayoutPanel1.Controls("Disp" & xPos + 1 & yPos))
        TileList.Insert(2, TableLayoutPanel1.Controls("Disp" & xPos + 1 & yPos - 1))
        TileList.Insert(3, TableLayoutPanel1.Controls("Disp" & xPos - 1 & yPos + 1))
        TileList.Insert(4, TableLayoutPanel1.Controls("Disp" & xPos - 1 & yPos))
        TileList.Insert(5, TableLayoutPanel1.Controls("Disp" & xPos - 1 & yPos - 1))
        TileList.Insert(6, TableLayoutPanel1.Controls("Disp" & xPos & yPos + 1))
        TileList.Insert(7, TableLayoutPanel1.Controls("Disp" & xPos & yPos - 1))
        For Each item In TileList
            If item IsNot Nothing Then
                item.Visible = True
            End If
        Next
        'Will change with OnLoad?
    End Sub

    'Player Movement and tile unfogging mechanic
    Private Sub MovePlayer(ByVal xPos2 As Integer, ByVal yPos2 As Integer)
        'Establish Player's current and next PictureBox
        CurrentPb = TableLayoutPanel1.Controls("Disp" & xPos & yPos)
        NextPb = TableLayoutPanel1.Controls("Disp" & xPos2 & yPos2)
        If NextPb IsNot Nothing Then
            'Update Current Coords
            xPos = xPos2
            yPos = yPos2
            'Clear current image, set next image
            CurrentPb.Image = Nothing
            NextPb.Image = PlayerMark
            '"Unfog" tile
            NextPb.Visible = True
            'Check each surrounding tile exists and set to visible if so
            TileList.Insert(0, TableLayoutPanel1.Controls("Disp" & xPos2 + 1 & yPos2 + 1))
            TileList.Insert(1, TableLayoutPanel1.Controls("Disp" & xPos2 + 1 & yPos2))
            TileList.Insert(2, TableLayoutPanel1.Controls("Disp" & xPos2 + 1 & yPos2 - 1))
            TileList.Insert(3, TableLayoutPanel1.Controls("Disp" & xPos2 - 1 & yPos2 + 1))
            TileList.Insert(4, TableLayoutPanel1.Controls("Disp" & xPos2 - 1 & yPos2))
            TileList.Insert(5, TableLayoutPanel1.Controls("Disp" & xPos2 - 1 & yPos2 - 1))
            TileList.Insert(6, TableLayoutPanel1.Controls("Disp" & xPos2 & yPos2 + 1))
            TileList.Insert(7, TableLayoutPanel1.Controls("Disp" & xPos2 & yPos2 - 1))
            For Each item In TileList
                If item IsNot Nothing Then
                    item.Visible = True
                End If
            Next
            EncounterCheck()
        Else
            'DoNothing
        End If


    End Sub
    Private Sub Map_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.D
                MovePlayer(xPos + 1, yPos)
                e.Handled = True
            Case Keys.A
                MovePlayer(xPos - 1, yPos)
                e.Handled = True
            Case Keys.W
                MovePlayer(xPos, yPos - 1)
                e.Handled = True
            Case Keys.S
                MovePlayer(xPos, yPos + 1)
                e.Handled = True
        End Select
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