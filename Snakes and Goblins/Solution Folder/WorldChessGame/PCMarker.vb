Public Class PCMarker
    Private PbDisp As New SortedDictionary(Of String, PictureBox)
    Private Sub PCMarker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Handler = New EventHandler(AddressOf PicClick)
        Dim LookupStr = New String() {"PC", "Marker"}
        PbDisp = Module2.DynPbBoxes(LookupStr, PC, 3, Panel1, Handler)
    End Sub

    Private Sub PicClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim pb As PictureBox = DirectCast(sender, PictureBox)
        For Each OtherPb In PbDisp
            OtherPb.Value.BorderStyle = BorderStyle.None
            OtherPb.Value.Tag = False
        Next
        pb.BorderStyle = BorderStyle.FixedSingle
        pb.Tag = True
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        For Each pb In PbDisp
            If pb.Value.Tag = True Then
                CCTool.Marker_Preview.Image = pb.Value.Image
            End If
        Next
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class