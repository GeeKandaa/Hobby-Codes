Module Module2

    'RipSheets() - Load multiple publically accessible Dictionaries of game images. 
    Public Tiles As New Dictionary(Of String, Bitmap)
    Public TilesRef As New Dictionary(Of String, Integer)
    Public PC As New Dictionary(Of String, Bitmap)
    Public Levels As New Dictionary(Of String, String)
    Public Sub RipSheets()
        'Set AllResources to contain My.Resources
        Dim AllResources = My.Resources.ResourceManager.GetResourceSet(System.Globalization.CultureInfo.CurrentCulture, True, True)
        Dim Res As DictionaryEntry

        'Array to store ComponentID of filenames
        Dim ComponentID() As String
        For Each Res In AllResources

            'Cut naming template from File name
            ComponentID = Res.Key.ToString.Split("_")
            ReDim Preserve ComponentID(3)
            ' For clarity:  (0) = Classifier,   eg. Tile, Pc, etc..
            '               (1) = Type,         eg. Skin, Foreground, etc..
            '               (2) = Name,         eg. Ashgrounds, Ninja, etc..
            '               (3) = ID,           eg. 1, Attack, etc..

            'If a Tileset, image is dissected into 16x16 bit images
            If Res.Value.GetType() = GetType(System.Drawing.Bitmap) Then
                If ComponentID(0) = "Tileset" Then
                    TilesRef.Add(ComponentID(1), Res.Value.Width / 16)
                    For j = 0 To (Res.Value.Height / 16) - 1
                        For i = 0 To (Res.Value.Width / 16) - 1
                            'Position Cut of Resource
                            Dim SaveString As String
                            Dim ImgSource As Bitmap = Res.Value
                            Dim Img As New Bitmap(16, 16)
                            Dim g As Graphics = Graphics.FromImage(Img)
                            'Cheap fix for sorting of tiles. Allows mapeditor to display tiles correctly.
                            If ((Res.Value.Width / 16) * j + i) < 10 Then
                                SaveString = ComponentID(0) & "_" & ComponentID(1) & "_" & ComponentID(2) & "_" & "000" & ((Res.Value.Width / 16) * j + i).ToString
                            ElseIf ((Res.Value.Width / 16) * j + i) < 100 Then
                                SaveString = ComponentID(0) & "_" & ComponentID(1) & "_" & ComponentID(2) & "_" & "00" & ((Res.Value.Width / 16) * j + i).ToString
                            ElseIf ((Res.Value.Width / 16) * j + i) < 1000 Then
                                SaveString = ComponentID(0) & "_" & ComponentID(1) & "_" & ComponentID(2) & "_" & "0" & ((Res.Value.Width / 16) * j + i).ToString
                            Else
                                SaveString = ComponentID(0) & "_" & ComponentID(1) & "_" & ComponentID(2) & "_" & ((Res.Value.Width / 16) * j + i).ToString
                            End If
                            Dim CutI As Integer = -16 * i
                            Dim CutJ As Integer = -16 * j
                            'Cut image and save to Dictionary
                            g.DrawImage(ImgSource, CutI, CutJ)
                            g.Save()
                            Tiles.Add(SaveString, Img)
                            'Dim Filename = "C:\Users\User\source\repos\Snakes and Goblins\WorldChessGame\Images\Tilesets\TestFolder\" & SaveString & ".png"
                            'Img.Save(Filename)
                            'Loop Modifier
                            g.Dispose()
                        Next
                    Next
                ElseIf ComponentID(0) = "PC" Then
                    'Statics are loaded as is
                    If ComponentID.Contains("Markers") Then
                        For i = 0 To (Res.Value.Width / 50) - 1
                            'Key
                            Dim SaveString = ComponentID(0) & "_" & ComponentID(1) & "_" & i.ToString
                            'Position Cut of Resource
                            Dim ImgSource As Bitmap = Res.Value
                            Dim Img As New Bitmap(50, 50)
                            Dim g As Graphics = Graphics.FromImage(Img)
                            Dim CutI As Integer = -50 * i
                            Dim CutJ As Integer = 0
                            'Cut image and save to Dictionary
                            g.DrawImage(ImgSource, CutI, CutJ)
                            g.Save()
                            PC.Add(SaveString, Img)
                            'Loop Modifier
                        Next
                    ElseIf ComponentID.Contains("Static") Then
                        Dim StaticsRef = My.Resources.PC_Skins_Static_Ref.Split("|")
                        For i = 0 To (Res.Value.Width / 250) - 1
                            'Key
                            Dim SaveString = ComponentID(0) & "_" & ComponentID(1) & "_" & StaticsRef(i) & "_" & ComponentID(2)
                            'Position Cut of Resource
                            Dim ImgSource As Bitmap = Res.Value
                            Dim Img As New Bitmap(250, 300)
                            Dim g As Graphics = Graphics.FromImage(Img)
                            Dim CutI As Integer = -250 * i
                            Dim CutJ As Integer = 0
                            'Cut image and save to Dictionary
                            g.DrawImage(ImgSource, CutI, CutJ)
                            g.Save()
                            PC.Add(SaveString, Img)
                            'Loop Modifier
                        Next

                    Else
                        'Counter
                        Dim Identifier = New String() {"Idle", "Attack", "Hurt"}
                        For j = 0 To (Res.Value.Height / 300) - 1
                            For i = 0 To (Res.Value.Width / 250) - 1
                                'Key
                                Dim SaveString = ComponentID(0) & "_" & ComponentID(1) & "_" & ComponentID(2) & "_" & Identifier(j) & "" & i.ToString
                                'Position Cut of Resource
                                Dim ImgSource As Bitmap = Res.Value
                                Dim Img As New Bitmap(250, 300)
                                Dim g As Graphics = Graphics.FromImage(Img)
                                Dim CutI As Integer = -250 * i
                                Dim CutJ As Integer = -300 * j
                                'Cut image and save to Dictionary
                                g.DrawImage(ImgSource, CutI, CutJ)
                                g.Save()
                                PC.Add(SaveString, Img)
                                'Loop Modifier
                            Next
                        Next
                    End If
                End If
            ElseIf Res.Value.GetType() = GetType(String) And Res.Key.ToString.Contains("Level") Then
                'MsgBox(Res.Key)   ' Resource Name
                'MsgBox(Res.Value) ' Resource FileContent
            End If
        Next
    End Sub

    Public Function DynPbBoxes(ByVal LookupStr() As String, ByVal Library As Dictionary(Of String, Bitmap), ByVal n As Integer, ByVal Container As Control, ByVal HandlerAddress As EventHandler)
        Dim PbDisp As New SortedDictionary(Of String, PictureBox)
        Dim TopMod = 0
        Dim LeftMod = 0
        For Each Img In Library
            If Img.Key.ToString.Contains(LookupStr(0)) And Img.Key.ToString.Contains(LookupStr(1)) Then
                Dim pb As New PictureBox With {
                    .Tag = Img.Key,  'Dependent: PickClick()
                    .SizeMode = PictureBoxSizeMode.StretchImage,
                    .Image = Img.Value
                }
                'Add PictureBox to Sorted
                PbDisp.Add(Img.Key, pb)
            End If
        Next
        For Each PbRef In PbDisp
            With PbRef.Value
                .Width = (Container.Width) / n    'Size and Spacing
                .Height = (Container.Height) / n
                .Top = TopMod * (Container.Height) / n
                .Left = LeftMod * (Container.Width) / n

                'Add Control to Display
                Container.Controls.Add(PbRef.Value)
                AddHandler PbRef.Value.Click, HandlerAddress
                '
                LeftMod = (LeftMod + 1) Mod n
                If LeftMod = 0 Then
                    TopMod += 1
                End If
            End With
        Next
        Return PbDisp
    End Function


End Module
