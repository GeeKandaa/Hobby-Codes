Module MapFile
    Private ActiveContainer As Control
    Private ActivePb As PictureBox
    Private Pb_Array As Array
    Public Function GameMapLoad(ByVal Container As Control, ByVal LevelFile As String, PlayerMarker As Image)
        'Load Level Data
        ActiveContainer = Container
        Dim Loadout As String = My.Resources.ResourceManager.GetObject(LevelFile)
        Dim LoadData() As String = Loadout.Split("|")
        Dim N As Integer = LoadData(0)
        'Load Player Move Variables
        'Generate Array of PictureBoxes and Display
        Dim Pb_tmpArray(N - 1, N - 1) As PictureBox
        'Loop
        Dim k As Integer = 3
        For i = 0 To N - 1
            For j = 0 To N - 1
                LoadPb(N, LoadData(k), LoadData(k + 1), LoadData(k + 2), LoadData(k + 3), LoadData(k + 4), i, j)
                Pb_tmpArray(i, j) = ActivePb
                k += 5
            Next
        Next
        'Set Starting Point and Display
        Pb_tmpArray(LoadData(1), LoadData(2)).Image = PlayerMarker
        'Set Public Array
        Return Pb_tmpArray
        'Dispose temp array?
        'Pb_tmpArray = Nothing
    End Function
    Private Sub LoadPb(N As Integer, ForeTileRef As String, BackTileRef As String, WallRef As String, DoorRef As String, SpawnRef As String, RowNum As Integer, ColNum As Integer)
        'Adjust size and positioning
        ActivePb = New PictureBox With {
            .Height = (ActiveContainer.Height - 20) / N,
            .Width = (ActiveContainer.Width - 20) / N,
            .Left = 0 + .Width * RowNum,
            .Top = 0 + .Height * ColNum,
            .BorderStyle = BorderStyle.None,
            .BackgroundImageLayout = ImageLayout.Stretch,
            .SizeMode = PictureBoxSizeMode.StretchImage
        }
        'Combine Image and BackgroundImage to Background Image
        If ForeTileRef <> "Void" AndAlso BackTileRef <> "Void" Then
            Dim MergedImg As New Bitmap(Tiles(BackTileRef).Width, Tiles(BackTileRef).Height)
            Dim g As Graphics = Graphics.FromImage(MergedImg)
            'Merge
            g.DrawImage(Tiles(BackTileRef), 0, 0)
            g.DrawImage(Tiles(ForeTileRef), 0, 0)
            ActivePb.BackgroundImage = MergedImg
            'Display Tile in BackgroundImage
        ElseIf ForeTileRef.ToString <> "Void" Then
            ActivePb.BackgroundImage = Tiles(ForeTileRef)
        ElseIf BackTileRef.ToString <> "Void" Then
            ActivePb.BackgroundImage = Tiles(BackTileRef)
        End If
        'Set Tile Properties.
        ActivePb.Tag = WallRef & "|" & DoorRef & "|" & SpawnRef & "|" & "TimerCheck"
        'Display
        ActiveContainer.Controls.Add(ActivePb)
    End Sub
End Module
