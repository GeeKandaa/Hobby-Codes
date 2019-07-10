Public Class GameMap
    Dim Pb As PictureBox
    Dim Tiles As New Dictionary(Of String, Image)
    Dim PlayerMark As Image
    Dim PlayerSprite As Image

    Public Sub GameMapLoad(ByVal LevelFile As String, ByVal Marker As Image)
        PlayerMark = Marker
        PlayerSprite = My.Resources.PC_Anim_Ninja_Walk2
        Dim Loadout As String = My.Resources.ResourceManager.GetObject(LevelFile)
        Dim LoadData() As String = Loadout.Split("|")
        Dim N As Integer = LoadData(0)
        Dim InitI = LoadData(1)
        Dim InitJ = LoadData(2)
        'Dim ConvertObj As System.ComponentModel.TypeConverter = System.ComponentModel.TypeDescriptor.GetConverter(GetType(Point))
        'Dim StartPoint As Point = ConvertObj.ConvertFromString(LoadData(1))
        Dim AllResources As Object
        Dim Res As DictionaryEntry
        'Generate list of resources
        AllResources = My.Resources.ResourceManager.GetResourceSet(System.Globalization.CultureInfo.CurrentCulture, True, True)
        For Each Res In AllResources
            If Res.Value.GetType() = GetType(System.Drawing.Bitmap) Then
                Tiles.Add(Res.Key, Res.Value)
            End If
        Next
        Dim Pb_Array(N - 1, N - 1) As PictureBox
        Dim k As Integer = 3
        For i = 0 To N - 1
            For j = 0 To N - 1
                LoadPb(N, LoadData(k), LoadData(k + 1), LoadData(k + 2), LoadData(k + 3), i, j)
                Pb_Array(i, j) = Pb
                k += 4
            Next
        Next
        Dim InitLeft As Integer = Pb_Array(InitI, InitJ).Left
        Dim InitTop As Integer = Pb_Array(InitI, InitJ).Top

        'Attempted to use Panel1.GetChildAtPoint(StartPoint) to no avail. As loading time/memory is not
        'a major issue yet the following is a math hack method to perform the same calculation.
        'For Each Pb In Pb_tmpArray
        'If Pb.Location.Y <= StartPoint.Y AndAlso Pb.Location.Y + Pb.Height >= StartPoint.Y Then
        'If Pb.Location.X <= StartPoint.X AndAlso Pb.Location.X + Pb.Width >= StartPoint.X Then
        'posX = Pb.Left
        'posY = Pb.Top
        'End If
        'End If
        'Next

        Dim PlayerBox = New PictureBox With {
        .Height = (Panel1.Height - 20) / N,
        .Width = (Panel1.Width - 20) / N,
        .Left = InitLeft,
        .Top = InitTop,
        .Image = PlayerSprite,
        .BorderStyle = BorderStyle.None,
        .BackColor = Color.Transparent,
        .BackgroundImage = Nothing,
        .SizeMode = PictureBoxSizeMode.StretchImage}
        Panel1.Controls.Add(PlayerBox)
        PlayerBox.BringToFront()
    End Sub

    Private Sub LoadPb(N, ForeTileRef, BackTileRef, WallRef, DoorRef, RowNum, ColNum)
        'Adjust size and postioning.
        Pb = New PictureBox With {
            .Height = (Panel1.Height - 20) / N,
            .Width = (Panel1.Width - 20) / N,
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
        Pb.Tag = WallRef.ToString & "|" & DoorRef.ToString
        'Display Pb
        Panel1.Controls.Add(Pb)
    End Sub

    Private Sub GameMap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class