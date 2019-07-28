Public Class MapEditor

    'FormLoad
    Dim DefaultTile As Image
    Public CustomTile As Image
    Private Sub MapEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Display tools window
        MapPad.Show()
        MapPad.Location = New Point(Location.X + Width, Location.Y)
        'Checkbox event handlers
        AddHandler StartPointCheck.CheckedChanged, AddressOf PreventCheck
        AddHandler WallCheck.CheckedChanged, AddressOf PreventCheck
        AddHandler LockedDoorCheck.CheckedChanged, AddressOf PreventCheck
        AddHandler SpawnPointCheck.CheckedChanged, AddressOf PreventCheck
        AddHandler UnlockedDoorCheck.CheckedChanged, AddressOf PreventCheck
        'Grab Dictionary of resources
        DefaultTile = Tiles("Tileset_Terrain_Ground1_0000")
        CustomTile = Tiles("Tileset_Terrain_Ground1_0000")
    End Sub
    'Load

    'InitialMap Cluster
    Dim Pb As PictureBox
    Dim Pb_Array As Array
    Dim N As Integer
    Private Sub InitialiseMap_Click(sender As Object, e As EventArgs) Handles InitialiseMap.Click
        If Option_Room.Checked = True Then
            Panel_MapDisplay.Controls.Clear()
            N = 10
            'Declare and initialise array
            Dim Pb_tmpArray(N - 1, N - 1) As PictureBox
            For i = 0 To N - 1
                For j = 0 To N - 1
                    InitialisePb(i, j)
                    Pb_tmpArray(i, j) = Pb
                Next
            Next
            Debug.WriteLine("OldArray")
            Debug.Print(Pb_tmpArray.Length.ToString)
            Pb_Array = Pb_tmpArray
            Debug.WriteLine("NewArray")
            Debug.Print(Pb_Array.Length.ToString)
        ElseIf Option_Town.Checked = True Then
            Panel_MapDisplay.Controls.Clear()
            N = 20
            Dim Pb_tmpArray(N - 1, N - 1) As PictureBox
            For i = 0 To N - 1
                For j = 0 To N - 1
                    InitialisePb(i, j)
                    Pb_tmpArray(i, j) = Pb
                Next
            Next
            'Debug.WriteLine("OldArray")
            'Debug.Print(Pb_Array.Length.ToString)
            Pb_Array = Pb_tmpArray
            'Debug.WriteLine("NewArray")
            'Debug.Print(Pb_Array.Length.ToString)
        ElseIf Option_Overworld.Checked = True Then
            Panel_MapDisplay.Controls.Clear()
            N = 40
            Dim Pb_tmpArray(N - 1, N - 1) As PictureBox
            For i = 0 To N - 1
                For j = 0 To N - 1
                    InitialisePb(i, j)
                    Pb_tmpArray(i, j) = Pb
                Next
            Next
            Debug.WriteLine("OldArray")
            Debug.Print(Pb_Array.Length.ToString)
            Pb_Array = Pb_tmpArray
            Debug.WriteLine("NewArray")
            Debug.Print(Pb_Array.Length.ToString)
        End If

    End Sub
    'Map Initialisation method
    'Functions:
    Private Sub InitialisePb(RowNum, ColNum)
        'Adjust size and postioning.
        Pb = New PictureBox With {
            .Height = (Panel_MapDisplay.Height - 20) / N,
            .Width = (Panel_MapDisplay.Width - 20) / N,
            .Tag = "Void|Tileset_Terrain_Ground1_0000|False|False|Void|False"
        }   'Save element = "Foreground|Background|StartBool|WallBool|DoorString|SpawnBool

        Pb.Left = 0 + Pb.Width * RowNum
        Pb.Top = 0 + Pb.Height * ColNum
        Pb.BorderStyle = BorderStyle.None
        Pb.BackgroundImage = DefaultTile
        Pb.BackgroundImageLayout = ImageLayout.Stretch
        Pb.SizeMode = PictureBoxSizeMode.StretchImage
        'Display Pb
        Panel_MapDisplay.Controls.Add(Pb)
        AddHandler Pb.Click, AddressOf PbClick
    End Sub

    'Map edit click events. Convoluted, needs splitting into distinct methods
    Public CustomTag As String
    Dim CompileTag() As String
    Dim oldStr() As String
    Dim chckStr As String
    Dim newStr As New List(Of String)
    Private Sub PbClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs)
        Pb = DirectCast(sender, PictureBox)
        If e.Button = MouseButtons.Left Then
            If My.Computer.Keyboard.CtrlKeyDown Then
                If StartPointCheck.Checked = True Then
                    For i = 0 To Math.Sqrt(Pb_Array.Length) - 1
                        For j = 0 To Math.Sqrt(Pb_Array.Length) - 1
                            CompileTag = Pb_Array(i, j).Tag.ToString.Split("|")
                            If Pb_Array(i, j).Equals(pb) Then
                                CompileTag(2) = "True"
                                StartPointDisp.Text = "( " & i.ToString & ", " & j.ToString & " )"
                                ConcatTag(Pb_Array(i, j), CompileTag)
                            Else
                                CompileTag(2) = "False"
                                ConcatTag(Pb_Array(i, j), CompileTag)
                            End If
                        Next
                    Next
                ElseIf WallCheck.Checked = True Then
                    UpdateTileProperties(3, WallsListDisp)
                ElseIf LockedDoorCheck.Checked = True Then
                    UpdateTileProperties(4, LockedDoorsListDisp)
                ElseIf UnlockedDoorCheck.Checked = True Then
                    UpdateTileProperties(4, UnlockedDoorsListDisp)
                ElseIf SpawnPointCheck.Checked = True Then
                    UpdateTileProperties(5, SpawnListDisp)
                End If
            Else
                Pb.BackgroundImage = CustomTile
                CompileTag = Pb.Tag.ToString.Split("|")
                CompileTag(1) = CustomTag
                ConcatTag(Pb, CompileTag)
            End If
        ElseIf e.Button = MouseButtons.Middle Then
            Pb.Image = Nothing
            Pb.BackgroundImage = Nothing
            CompileTag = Pb.Tag.ToString.Split("|")
            CompileTag(0) = "Void"
            CompileTag(1) = "Void"
            ConcatTag(Pb, CompileTag)
        ElseIf e.Button = MouseButtons.Right Then
            Pb.Image = CustomTile
            CompileTag = Pb.Tag.ToString.Split("|")
            CompileTag(0) = CustomTag
            ConcatTag(Pb, CompileTag)
        End If
    End Sub
    'Map Tile Click event
    'Functions:
    Private Sub UpdateTileProperties(TagNum As Integer, DispBox As TextBox)
        CompileTag = Pb.Tag.ToString.Split("|")
        For i = 0 To Math.Sqrt(Pb_Array.Length) - 1
            For j = 0 To Math.Sqrt(Pb_Array.Length) - 1
                If Pb_Array(i, j).Equals(Pb) Then
                    If CompileTag(TagNum) = "Void" Then
                        If LockedDoorCheck.Checked = True Then
                            CompileTag(TagNum) = "Locked"
                        Else
                            CompileTag(TagNum) = "Unlocked"
                        End If
                        DispBox.AppendText(vbCrLf & "( " & i.ToString & ", " & j.ToString & " )")
                    ElseIf CompileTag(TagNum) = "Locked" Or CompileTag(TagNum) = "Unlocked" Then
                        CompileTag(TagNum) = "Void"
                        chckStr = "( " & i.ToString & ", " & j.ToString & " )"
                        oldStr = DispBox.Lines
                        newStr.Clear()
                        For Each tmpStr In oldStr
                            If tmpStr <> chckStr Then
                                newStr.Add(tmpStr)
                            End If
                        Next
                        DispBox.Lines = newStr.ToArray
                    ElseIf CompileTag(TagNum) = "False" Then
                        CompileTag(TagNum) = "True"
                        DispBox.AppendText(vbCrLf & "( " & i.ToString & ", " & j.ToString & " )")
                    Else
                        CompileTag(TagNum) = "False"
                        chckStr = "( " & i.ToString & ", " & j.ToString & " )"
                        oldStr = DispBox.Lines
                        newStr.Clear()
                        For Each tmpStr In oldStr
                            If tmpStr <> chckStr Then
                                newStr.Add(tmpStr)
                            End If
                        Next
                        DispBox.Lines = newStr.ToArray

                    End If
                    ConcatTag(Pb, CompileTag)
                End If
            Next
        Next
    End Sub
    Private Sub ConcatTag(ByVal PbElement As PictureBox, ByVal TagCompilation() As String)
        PbElement.Tag = TagCompilation(0) & "|" & TagCompilation(1) & "|" & TagCompilation(2) & "|" & TagCompilation(3) & "|" & TagCompilation(4) & "|" & TagCompilation(5)
    End Sub


    Private Sub Button_SaveMap_Click(sender As Object, e As EventArgs) Handles Button_SaveMap.Click
        SaveFileDialog1.ShowDialog()
    End Sub
    'Save
    'Dialogs:
    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        If Pb_Array.Length > 0 Then
            Dim SaveString As String = N.ToString



            For i = 0 To Math.Sqrt(Pb_Array.Length) - 1
                For j = 0 To Math.Sqrt(Pb_Array.Length) - 1
                    CompileTag = Pb_Array(i, j).Tag.ToString.Split("|")
                    If CompileTag(2) = "True" Then
                        SaveString &= "|" & i.ToString & "|" & j.ToString
                    End If
                Next
            Next
            For Each Pb In Pb_Array
                CompileTag = Pb.Tag.ToString.Split("|")
                SaveString &= "|" & CompileTag(0) & "|" & CompileTag(1) & "|" & CompileTag(3) & "|" & CompileTag(4) & "|" & CompileTag(5)
            Next
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, SaveString, False)
        End If
    End Sub


    Private Sub Button_LoadMap_Click(sender As Object, e As EventArgs) Handles Button_LoadMap.Click
        OpenFileDialog1.ShowDialog()
    End Sub
    'Load Click event 
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Panel_MapDisplay.Controls.Clear()
        LockedDoorsListDisp.Text = "Locked Doors Set at:"
        WallsListDisp.Text = "Walls Set at:"
        UnlockedDoorsListDisp.Text = "Unlocked Doors Set at:"
        SpawnListDisp.Text = "Spawns Set at:"
        Dim Loadout As String = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
        Dim LoadData() As String = Loadout.Split("|")
        N = LoadData(0)
        Dim InitI = LoadData(1)
        Dim InitJ = LoadData(2)
        Dim Pb_tmpArray(N - 1, N - 1) As PictureBox
        Dim k As Integer = 3
        For i = 0 To N - 1
            For j = 0 To N - 1
                LoadPb(N, LoadData(k), LoadData(k + 1), LoadData(k + 2), LoadData(k + 3), LoadData(k + 4), i, j)
                Pb_tmpArray(i, j) = Pb
                k += 5
            Next
        Next
        With Pb_tmpArray(InitI, InitJ)
            CompileTag = .Tag.ToString.Split("|")
            .Tag = CompileTag(0) & "|" & CompileTag(1) & "|" & "True" & "|" & CompileTag(3) & "|" & CompileTag(4) & "|" & CompileTag(5)
        End With
        StartPointDisp.Text = "( " & InitI & ", " & InitJ & " )"
        Pb_Array = Pb_tmpArray
    End Sub
    'Load
    'Functions:
    Private Sub LoadPb(N As Integer, ForeTileRef As String, BackTileRef As String, WallRef As String, DoorRef As String, SpawnRef As String, RowNum As Integer, ColNum As Integer)
        'Adjust size and postioning.
        Pb = New PictureBox With {
            .Height = (Panel_MapDisplay.Height - 20) / N,
            .Width = (Panel_MapDisplay.Width - 20) / N,
            .Left = 0 + .Width * RowNum,
            .Top = 0 + .Height * ColNum,
            .BorderStyle = BorderStyle.None,
            .BackgroundImageLayout = ImageLayout.Stretch,
            .SizeMode = PictureBoxSizeMode.StretchImage
        }

        If ForeTileRef.ToString <> "Void" Then
            Pb.Image = Tiles(ForeTileRef)
        End If
        If BackTileRef.ToString <> "Void" Then
            Pb.BackgroundImage = Tiles(BackTileRef)
        End If
        If WallRef = "True" Then
            WallsListDisp.AppendText(vbCrLf & "( " & RowNum.ToString & ", " & ColNum.ToString & " )")
        End If
        If DoorRef = "Locked" Then
            LockedDoorsListDisp.AppendText(vbCrLf & "( " & RowNum.ToString & ", " & ColNum.ToString & " )")
        End If
        If DoorRef = "Unlocked" Then
            UnlockedDoorsListDisp.AppendText(vbCrLf & "( " & RowNum.ToString & ", " & ColNum.ToString & " )")
        End If
        If SpawnRef = "True" Then
            SpawnListDisp.AppendText(vbCrLf & "( " & RowNum.ToString & ", " & ColNum.ToString & " )")
        End If
        Pb.Tag = ForeTileRef & "|" & BackTileRef & "|" & "False" & "|" & WallRef & "|" & DoorRef & "|" & SpawnRef
        'Display Pb
        Panel_MapDisplay.Controls.Add(Pb)
        AddHandler Pb.Click, AddressOf PbClick
    End Sub


    'Prevent multiple checkbox checked
    Private Sub PreventCheck(sender As Object, e As EventArgs)
        Dim SelectedCheck = DirectCast(sender, CheckBox)
        If SelectedCheck.Checked = True Then
            For Each cb In Me.Controls.OfType(Of CheckBox)
                If cb IsNot SelectedCheck Then
                    cb.Checked = False
                End If
            Next
        End If
    End Sub
    'Checkbox Click event
    Dim PropertyDisplay = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each Pb In Pb_Array
            CompileTag = Pb.Tag.ToString.Split("|")
            '"Foreground|Background|StartBool|WallBool|DoorString|SpawnBool
            If PropertyDisplay = True Then
                If CompileTag(0) <> "Void" Then
                    Pb.Image = Tiles(CompileTag(0))
                Else
                    Pb.Image = Nothing
                End If
            Else
                If CompileTag(4) = "Locked" Then
                    Pb.Image = My.Resources.LockedDoor
                ElseIf CompileTag(4) = "Unlocked" Then
                    Pb.Image = My.Resources.UnlockedDoor
                ElseIf CompileTag(3) Then
                    Pb.Image = My.Resources.Wall
                ElseIf CompileTag(5) Then
                    Pb.Image = My.Resources.SpawnPoint
                End If
            End If
        Next
        PropertyDisplay = Not (PropertyDisplay)
    End Sub

End Class