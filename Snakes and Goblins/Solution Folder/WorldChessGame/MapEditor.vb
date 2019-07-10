Public Class MapEditor
    '__________
    ' MapEditor
    '''''''''''
    ''
    ''
    '' 
    ''     Windows Form - Map Editor
    ''     '''''''''''''''''''''''''
    ''     
    ''     ''' InitialiseMap_Click
    ''         - Generate a square array of variables, ij; components
    ''         - Generate a visual index using PictureBox class variables.
    ''         
    ''     ''' Depends on: InitialisePb()
    ''     
    ''     ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    ''     
    ''     '''InitialisePb()
    ''         - Assign each component variable a reference to PictureBox visual variables.
    ''         - Position each ij variable dynamically on screen.
    ''     '''
    ''     
    ''     ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    ''     
    ''     '''
    ''     
    ''     '''
    '' 
    ''     '''

    '_________
    'Variables
    ''''''''''
    Dim Pb As PictureBox
    Dim Pb_Array As Array
    Dim DefaultTile As Image
    Dim N As Integer
    'Dependents:    InitialiseMap_Click()
    '               InitialisePb()

    ReadOnly Tag1 As String
    ReadOnly Tag2 As String
    'Dependents:    ComboBox1_SelectedIndexChanged()

    Dim StartPoint As Point
    Dim CustomTile As Image
    Dim CustomTag As String
    Dim CompileTag() As String
    Dim oldStr() As String
    Dim chckStr As String
    Dim newStr As New List(Of String)
    'Dependents:    PbClick()

    Dim AllResources As Object
    Dim Res As DictionaryEntry
    Dim Tiles As New Dictionary(Of String, Image)
    'Dependents:    MapLoad()
    '____
    'Subs
    '''''

    'Load Cluster
    Private Sub MapEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DefaultTile = My.Resources.Ashlands_Overworld_00__1_
        CustomTile = My.Resources.Ashlands_Overworld_00__1_
        ComboBox1.SelectedIndex = 0
        'Generate list of resources
        AllResources = My.Resources.ResourceManager.GetResourceSet(System.Globalization.CultureInfo.CurrentCulture, True, True)
        For Each Res In AllResources
            If Res.Value.GetType() = GetType(System.Drawing.Bitmap) Then
                Tiles.Add(Res.Key, Res.Value)
            End If
        Next
    End Sub

    'InitialMap Cluster
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
            Debug.WriteLine("OldArray")
            Debug.Print(Pb_Array.Length.ToString)
            Pb_Array = Pb_tmpArray
            Debug.WriteLine("NewArray")
            Debug.Print(Pb_Array.Length.ToString)
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
    Private Sub InitialisePb(RowNum, ColNum)
        'Adjust size and postioning.
        Pb = New PictureBox With {
            .Height = (Panel_MapDisplay.Height - 20) / N,
            .Width = (Panel_MapDisplay.Width - 20) / N,
            .Tag = "Void|Ashlands_Overworld_00__1_|False|False|False"
        }
        Pb.Left = 0 + Pb.Width * RowNum
        Pb.Top = 0 + Pb.Height * ColNum
        ' Optional displays
        If Options_Borders.Checked = True Then
            Pb.BorderStyle = BorderStyle.None
        Else
            Pb.BorderStyle = BorderStyle.FixedSingle
        End If
        Pb.BackgroundImage = DefaultTile
        Pb.BackgroundImageLayout = ImageLayout.Stretch
        Pb.SizeMode = PictureBoxSizeMode.StretchImage
        'Display Pb
        Panel_MapDisplay.Controls.Add(Pb)
        AddHandler Pb.Click, AddressOf PbClick
    End Sub

    'CustomTile Cluster
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TilePanel.Controls.Clear()
        Dim Handler = New EventHandler(AddressOf PicClick)
        Module1.SelectResources(Handler, Me.TilePanel, ComboBox1.SelectedItem.ToString, 3)
    End Sub
    Private Sub PicClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim pb As PictureBox = DirectCast(sender, PictureBox)
        For Each item In Module1.Res_List
            item.Value.BorderStyle = BorderStyle.None
        Next
        CustomTile = pb.Image
        CustomTag = pb.Tag
        pb.BorderStyle = BorderStyle.FixedSingle
    End Sub

    'Map edit click events. Convoluted, needs splitting into distinct methods
    Private Sub PbClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs)
        Dim pb As PictureBox = DirectCast(sender, PictureBox)
        If e.Button = MouseButtons.Left Then
            If ComboBox1.SelectedItem.ToString = "Foreground" Then
                pb.Image = CustomTile
                CompileTag = pb.Tag.ToString.Split("|")
                CompileTag(0) = CustomTag
                ConcatTag(pb, CompileTag)
            Else
                pb.BackgroundImage = CustomTile
                CompileTag = pb.Tag.ToString.Split("|")
                CompileTag(1) = CustomTag
                ConcatTag(pb, CompileTag)
            End If
        ElseIf e.Button = MouseButtons.Middle Then
            If ComboBox1.SelectedItem.ToString = "Foreground" Then
                pb.Image = Nothing
                CompileTag = pb.Tag.ToString.Split("|")
                CompileTag(0) = "Void"
                ConcatTag(pb, CompileTag)
            Else
                pb.BackgroundImage = Nothing
                CompileTag = pb.Tag.ToString.Split("|")
                CompileTag(1) = "Void"
                ConcatTag(pb, CompileTag)
            End If
        ElseIf e.Button = MouseButtons.Right Then
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
                'The Following two ElseIf blocks could potentially share a function. Very messy as it is
            ElseIf WallCheck.Checked = True Then
                CompileTag = pb.Tag.ToString.Split("|")
                For i = 0 To Math.Sqrt(Pb_Array.Length) - 1
                    For j = 0 To Math.Sqrt(Pb_Array.Length) - 1
                        If Pb_Array(i, j).Equals(pb) Then
                            If CompileTag(3) = "False" Then
                                CompileTag(3) = "True"
                                WallsListDisp.AppendText(vbCrLf & "( " & i.ToString & ", " & j.ToString & " )")
                            Else
                                CompileTag(3) = "False"
                                chckStr = "( " & i.ToString & ", " & j.ToString & " )"
                                oldStr = WallsListDisp.Lines
                                newStr.Clear()
                                For Each tmpStr In oldStr
                                    If tmpStr <> chckStr Then
                                        newStr.Add(tmpStr)
                                    End If
                                Next
                                WallsListDisp.Lines = newStr.ToArray

                            End If
                            ConcatTag(pb, CompileTag)
                        End If
                    Next
                Next
            ElseIf LockedDoorCheck.Checked = True Then
                CompileTag = pb.Tag.ToString.Split("|")
                For i = 0 To Math.Sqrt(Pb_Array.Length) - 1
                    For j = 0 To Math.Sqrt(Pb_Array.Length) - 1
                        If Pb_Array(i, j).Equals(pb) Then
                            If CompileTag(4) = "False" Then
                                CompileTag(4) = "True"
                                DoorsListDisp.AppendText(vbCrLf & "( " & i.ToString & ", " & j.ToString & " )")
                            Else
                                CompileTag(4) = "False"
                                chckStr = "( " & i.ToString & ", " & j.ToString & " )"
                                oldStr = DoorsListDisp.Lines
                                newStr.Clear()
                                For Each tmpStr In oldStr
                                    If tmpStr <> chckStr Then
                                        newStr.Add(tmpStr)
                                    End If
                                Next
                                DoorsListDisp.Lines = newStr.ToArray
                            End If
                            ConcatTag(pb, CompileTag)
                        End If
                    Next
                Next
            End If
        End If

    End Sub
    Private Sub ConcatTag(ByVal PbElement As PictureBox, ByVal TagCompilation() As String)
        PbElement.Tag = TagCompilation(0) & "|" & TagCompilation(1) & "|" & TagCompilation(2) & "|" & TagCompilation(3) & "|" & TagCompilation(4)
    End Sub
    Private Sub Buttom_SaveMap_Click(sender As Object, e As EventArgs) Handles Buttom_SaveMap.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        If Pb_Array.Length > 0 Then
            Dim SaveString As String = N.ToString


            'Dim ConvertObj As System.ComponentModel.TypeConverter = System.ComponentModel.TypeDescriptor.GetConverter(GetType(Point))
            'Dim StartPoint_String As String = ConvertObj.ConvertToString(StartPoint)
            'SaveString &= "|" & StartPoint_String
            Debug.WriteLine(Pb_Array)
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
                SaveString &= "|" & CompileTag(0) & "|" & CompileTag(1) & "|" & CompileTag(3) & "|" & CompileTag(4)
                'Debug.WriteLine(Pb.Tag.ToString)
            Next
            'Debug.WriteLine(SaveString)
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, SaveString, False)
        End If
    End Sub
    Private Sub MapEditor_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
    End Sub

    Public Sub MapLoad(ByVal LevelFile As String)
        Panel_MapDisplay.Controls.Clear()
        DoorsListDisp.Text = "Doors Set at:"
        WallsListDisp.Text = "Walls Set at:"
        Dim Loadout As String = My.Computer.FileSystem.ReadAllText(LevelFile)
        Dim LoadData() As String = Loadout.Split("|")
        N = LoadData(0)
        Dim InitI = LoadData(1)
        Dim InitJ = LoadData(2)
        'Dim ConvertObj As System.ComponentModel.TypeConverter = System.ComponentModel.TypeDescriptor.GetConverter(GetType(Point))
        'Dim StartPoint As Point = ConvertObj.ConvertFromString(LoadData(1))
        Dim Pb_tmpArray(N - 1, N - 1) As PictureBox
        Dim k As Integer = 3
        For i = 0 To N - 1
            For j = 0 To N - 1
                LoadPb(N, LoadData(k), LoadData(k + 1), LoadData(k + 2), LoadData(k + 3), i, j)
                Pb_tmpArray(i, j) = Pb
                k += 4
            Next
        Next
        With Pb_tmpArray(InitI, InitJ)
            CompileTag = .Tag.ToString.Split("|")
            .Tag = CompileTag(0) & "|" & CompileTag(1) & "|" & "True" & "|" & CompileTag(3) & "|" & CompileTag(4)
        End With
        StartPointDisp.Text = "( " & InitI & ", " & InitJ & " )"
        Pb_Array = Pb_tmpArray
    End Sub

    Private Sub LoadPb(N, ForeTileRef, BackTileRef, WallRef, DoorRef, RowNum, ColNum)
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
        If DoorRef = "True" Then
            DoorsListDisp.AppendText(vbCrLf & "( " & RowNum.ToString & ", " & ColNum.ToString & " )")
        End If
        Pb.Tag = ForeTileRef.ToString & "|" & BackTileRef.ToString & "|" & "False" & "|" & WallRef.ToString & "|" & DoorRef.ToString
        'Display Pb
        Panel_MapDisplay.Controls.Add(Pb)
        AddHandler Pb.Click, AddressOf PbClick
    End Sub

    Private Sub Button_LoadMap_Click(sender As Object, e As EventArgs) Handles Button_LoadMap.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        MapLoad(OpenFileDialog1.FileName)
    End Sub
End Class