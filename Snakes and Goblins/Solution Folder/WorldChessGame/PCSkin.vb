Public Class PCSkin
    Public PbDisp As New SortedDictionary(Of String, PictureBox)
    'Load
    Private Sub PCSkin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Handler = New EventHandler(AddressOf PicClick)
        Dim LookupStr = New String() {"Skin", "Static"}
        PbDisp = DynPbBoxes(LookupStr, PC, 3, Panel1, Handler)
    End Sub
    'PictureBox Click Handler
    Public Sub PicClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim pb As PictureBox = DirectCast(sender, PictureBox)
        For Each OtherPb In PbDisp
            OtherPb.Value.BorderStyle = BorderStyle.None
            OtherPb.Value.Tag = False
        Next
        pb.BorderStyle = BorderStyle.FixedSingle
        pb.Tag = True
    End Sub
    'Cancel and Ok Buttons
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        For Each Pb In PbDisp
            If Pb.Value.Tag = True Then
                CCTool.Skin_Preview.Image = Pb.Value.Image
            End If
        Next
        Me.Close()
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class
