Public Class PCSkin
    Private Sub PCSkin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Handler = New EventHandler(AddressOf PicClick)
        Module1.SelectResources(Handler, Me.Panel, "PC_Skin", 3)
    End Sub

    Public Sub PicClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim pb As PictureBox = DirectCast(sender, PictureBox)
        For Each item In Res_List
            item.Value.BorderStyle = BorderStyle.None
            item.Value.Tag = False
        Next
        pb.BorderStyle = BorderStyle.FixedSingle
        pb.Tag = True
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        For Each item In Module1.Res_List
            If item.Value.Tag = True Then
                CCTool.Skin_Preview.Image = item.Value.Image
            End If
        Next
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class
