Public Class GameMap


    Dim Pb As PictureBox
    Dim Pb_Array As Array
    Dim PlayerMark As Image
    Dim PlayerSprite As Image
    Dim StartPoint As Point
    Dim CurrI As Integer
    Dim CurrJ As Integer
    Dim CurrentPb As PictureBox

    'GameLoad Chunk
    Public Sub NewGame(ByVal Marker As Image, ByVal Sprite As Image)
        Me.KeyPreview = True
        'Load Player Visuals
        PlayerMark = Marker
        PlayerSprite = Sprite
        Pb_Array = MapFile.GameMapLoad(Panel1, "Level0", PlayerMark)
        For i = 0 To Math.Sqrt(Pb_Array.Length) - 1
            For j = 0 To Math.Sqrt(Pb_Array.Length) - 1
                If Pb_Array(i, j).Image IsNot Nothing Then
                    CurrI = i
                    CurrJ = j
                    CurrentPb = Pb_Array(i, j)
                End If
            Next
        Next
    End Sub

    'Enemies
    Private ActiveEnemy As New List(Of PictureBox)
    Private Sub SpawnEnemy()
        Randomize()
        If Rnd() < 0.25 And ActiveEnemy.Count < 3 Then
            Dim SpawnPoints As New List(Of PictureBox)
            For Each one In Pb_Array
                Dim TileProperty As String() = one.Tag.ToString.Split("|")
                Debug.Print(TileProperty(2))
                If TileProperty(2) = True Then
                    SpawnPoints.Add(one)
                End If
            Next
            Dim RndEnemy = Math.Ceiling(Rnd() * SpawnPoints.Count) - 1
            If SpawnPoints(RndEnemy).Image Is Nothing Then
                SpawnPoints(RndEnemy).Image = My.Resources.Enemy_Goblin_Idle
                ActiveEnemy.Add(SpawnPoints(RndEnemy))
            End If
        End If
    End Sub

    'PC Movement Chunk
    Dim MovingChar As Boolean = False
    Private Sub GameMap_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.D
                If MovingChar = False Then
                    tmpActiveEnemy.Clear()
                    MovePlayer(1, 0)
                    InitEnemyMove()
                    SpawnEnemy()
                    e.Handled = True
                End If
            Case Keys.A
                If MovingChar = False Then
                    tmpActiveEnemy.Clear()
                    MovePlayer(-1, 0)
                    InitEnemyMove()
                    SpawnEnemy()
                    e.Handled = True
                End If
            Case Keys.W
                If MovingChar = False Then
                    tmpActiveEnemy.Clear()
                    MovePlayer(0, -1)
                    InitEnemyMove()
                    SpawnEnemy()
                    e.Handled = True
                End If
            Case Keys.S
                If MovingChar = False Then
                    tmpActiveEnemy.Clear()
                    MovePlayer(0, 1)
                    InitEnemyMove()
                    SpawnEnemy()
                    e.Handled = True
                End If
        End Select
    End Sub
    Dim NextI As Integer
    Dim NextJ As Integer
    Dim NextPb As PictureBox
    Dim tmp_location As Point
    Dim tmpPb As PictureBox
    Private Sub MovePlayer(ByVal i As Integer, ByVal j As Integer)
        'Is player already moving?
        'Find and validate target PictureBox
        ''Set target coords
        NextI = CurrI + i
        NextJ = CurrJ + j
        ''Validate next Pb exists.
        Try
            NextPb = Pb_Array(NextI, NextJ)
            Dim TileProperty As String() = NextPb.Tag.ToString.Split("|")
            If TileProperty(0) <> "True" Then
                'Prevent Movement Call
                MovingChar = True
                'Create temporary clone of current PictureBox for map display
                tmpPb = New PictureBox With {
                        .Size = CurrentPb.Size,
                        .BackgroundImageLayout = ImageLayout.Stretch,
                        .BackgroundImage = CurrentPb.BackgroundImage.Clone(),
                        .Location = CurrentPb.Location,
                        .BorderStyle = BorderStyle.None}
                Panel1.Controls.Add(tmpPb)
                'Store Current picture box's location for restoration post move
                tmp_location = CurrentPb.Location
                'Keep moving box on top
                CurrentPb.BringToFront()
                'Move
                PCMoveTimer.Enabled = True
            End If
        Catch ex As Exception
            PCMoveTimer.Enabled = False
        End Try
    End Sub

    Dim Timer_Count As Integer = 0
    Private Sub PCMoveTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCMoveTimer.Tick
        ' Create directional modifiers
        Dim IMod = (NextI - CurrI)
        Dim JMod = (NextJ - CurrJ)

        'Move Picturebox
        CurrentPb.Location += New Point(CurrentPb.Width * IMod / 26, CurrentPb.Height * JMod / 26)

        'Count check
        If Timer_Count = 25 Then
            Timer_Count = 0
            'Update PictureBox images to post move state
            NextPb.Image = PlayerMark
            CurrentPb.Image = Nothing
            'Update current coords
            CurrI = NextI
            CurrJ = NextJ
            'Reset Pictuerbox location and remove temporary box
            CurrentPb.Location = tmp_location
            Panel1.Controls.Remove(tmpPb)
            'Update CurrentPb, allow further movement and stop tick events
            CurrentPb = Pb_Array(CurrI, CurrJ)
            If NPCMoveTimer.Enabled = False Then
                MovingChar = False
            End If
            sender.Enabled = False
        Else
            Timer_Count += 1
        End If
    End Sub
    Dim EnemyIndex As Integer = 0
    Dim EnemyCurrI As Integer
    Dim EnemyCurrJ As Integer
    Dim EnemyCurrentPb As PictureBox
    Dim EnemyNextI As Integer
    Dim EnemyNextJ As Integer
    Dim EnemyNextPb As PictureBox
    Dim Enemytmp_location As Point
    Dim EnemytmpPb As PictureBox
    Dim tmpActiveEnemy As New List(Of PictureBox)
    Dim EnTimer_Count As Integer = 0
    Private Sub InitEnemyMove()
        'Is player already moving?
        'Find and validate target PictureBox
        ''Set target coords
        If ActiveEnemy.Count > 0 Then
            For i = 0 To Math.Sqrt(Pb_Array.Length) - 1
                For j = 0 To Math.Sqrt(Pb_Array.Length) - 1
                    If Pb_Array(i, j).Equals(ActiveEnemy(EnemyIndex)) Then
                        EnemyCurrI = i
                        EnemyCurrJ = j
                        EnemyNextI = i + (Math.Floor(Rnd() * 2)) * ((-1) ^ Math.Ceiling(Rnd() * 2))
                        If EnemyNextI = i Then
                            EnemyNextJ = j + 1 * ((-1) ^ Math.Ceiling(Rnd() * 2))
                        Else
                            EnemyNextJ = j
                        End If
                        EnemyCurrentPb = ActiveEnemy(EnemyIndex)
                    End If
                Next
            Next
            Try
                EnemyNextPb = Pb_Array(EnemyNextI, EnemyNextJ)
                Dim TileProperty As String() = EnemyNextPb.Tag.ToString.Split("|")
                If TileProperty(0) <> "True" And EnemyNextPb.Image Is Nothing Then
                    'Create temporary clone of current PictureBox for map display
                    EnemytmpPb = New PictureBox With {
                            .Size = EnemyCurrentPb.Size,
                            .BackgroundImageLayout = ImageLayout.Stretch,
                            .BackgroundImage = EnemyCurrentPb.BackgroundImage.Clone(),
                            .Location = EnemyCurrentPb.Location,
                            .BorderStyle = BorderStyle.None}
                    Panel1.Controls.Add(EnemytmpPb)
                    'Store Current picture box's location for restoration post move
                    Enemytmp_location = EnemyCurrentPb.Location
                    'Keep moving box on top
                    EnemyCurrentPb.BringToFront()
                    'Move
                    NPCMoveTimer.Enabled = True
                End If
            Catch ex As Exception
                NPCMoveTimer.Enabled = False
            End Try
        End If
    End Sub

    Private Sub NPCMoveTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NPCMoveTimer.Tick
        ' Create directional modifiers
        Dim IMod = (EnemyNextI - EnemyCurrI)
        Dim JMod = (EnemyNextJ - EnemyCurrJ)

        'Move Picturebox
        EnemyCurrentPb.Location += New Point(EnemyCurrentPb.Width * IMod / 26, EnemyCurrentPb.Height * JMod / 26)

        'Count check
        If EnTimer_Count = 25 Then
            EnTimer_Count = 0
            'Update PictureBox images to post move state
            EnemyNextPb.Image = My.Resources.Enemy_Goblin_Idle
            Dim TagLines() As String
            TagLines = EnemyCurrentPb.Tag.ToString.Split("|")
            TagLines(3) = "TimerOver"
            EnemyCurrentPb.Tag = TagLines(0) & "|" & TagLines(1) & "|" & TagLines(2) & "|" & TagLines(3)
            EnemyCurrentPb.Image = Nothing
            'Reset Pictuerbox location and remove temporary box
            EnemyCurrentPb.Location = Enemytmp_location
            Panel1.Controls.Remove(EnemytmpPb)
            tmpActiveEnemy.Add(EnemyNextPb)
            Dim CheckString As String = ""
            For Each item In ActiveEnemy
                TagLines = item.Tag.ToString.Split("|")
                CheckString += TagLines(3)
            Next
            If CheckString.Contains("TimerCheck") Then
                EnemyIndex += 1
                InitEnemyMove()
            Else
                For Each item In ActiveEnemy
                    TagLines = item.Tag.ToString.Split("|")
                    TagLines(3) = "TimerCheck"
                    item.Tag = TagLines(0) & "|" & TagLines(1) & "|" & TagLines(2) & "|" & TagLines(3)
                Next
                EnemyIndex = 0
                ActiveEnemy.Clear()
                Dim listI As Integer = 0
                For Each item In tmpActiveEnemy
                    ActiveEnemy.Add(item)
                    listI += 1
                Next
                NPCMoveTimer.Enabled = False
                MovingChar = False
            End If
        Else
            EnTimer_Count += 1
        End If
    End Sub

End Class