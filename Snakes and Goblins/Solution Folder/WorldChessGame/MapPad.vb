Public Class MapPad
    Public PbDisp As New SortedDictionary(Of String, PictureBox)
    Private Sub MapPad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TilePad.Controls.Clear()
        'Function parameters
        Dim Handler = New EventHandler(AddressOf PicClick)
        Dim LookupStr = New String() {"Tileset", ComboBox1.SelectedItem.ToString}
        'Function call
        PbDisp = Module2.DynPbBoxes(LookupStr, Module2.Tiles, Module2.TilesRef(ComboBox1.SelectedItem.ToString), TilePad, Handler)
    End Sub
    Private Sub PicClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim pb As PictureBox = DirectCast(sender, PictureBox)
        For Each item In PbDisp
            item.Value.BorderStyle = BorderStyle.None
        Next
        MapEditor.CustomTile = pb.Image
        MapEditor.CustomTag = pb.Tag
        pb.BorderStyle = BorderStyle.FixedSingle
    End Sub
End Class