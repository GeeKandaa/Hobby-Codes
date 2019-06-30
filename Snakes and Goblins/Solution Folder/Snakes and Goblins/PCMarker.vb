Public Class PCMarker
    Private ReadOnly Res_List As New List(Of PictureBox)
    Private Resources As Object
    Private dictEntry As DictionaryEntry
    Private Sub PCSkin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Generate list of resources
        Resources = My.Resources.ResourceManager.GetResourceSet(System.Globalization.CultureInfo.CurrentCulture, True, True)
        'Modifiers for positioning PictureBoxes
        Dim LeftModifier = 0
        Dim TopModifier = 0

        'Scans through Resources for PC_Skin and displays PictureBox
        For Each dictEntry In Resources
            If dictEntry.Key.ToString.Contains("PC_Marker") Then
                Debug.WriteLine(dictEntry.Key)
                Dim pb As New PictureBox With {
                    .Width = 100,
                    .Height = 100,
                    .SizeMode = PictureBoxSizeMode.StretchImage,
                    .Top = TopModifier * 100,
                    .Left = LeftModifier * 100,
                    .Tag = False,
                    .Image = dictEntry.Value
                }
                Me.Panel.Controls.Add(pb)
                Res_List.Add(pb)
                LeftModifier = (LeftModifier + 1) Mod 5
                Debug.WriteLine(LeftModifier)
                If LeftModifier = 0 Then
                    TopModifier += 1
                End If
                AddHandler pb.Click, AddressOf PicClick
            End If
        Next
    End Sub

    Private Sub PicClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim pb As PictureBox = DirectCast(sender, PictureBox)
        For Each item In Res_List
            item.BorderStyle = BorderStyle.None
            item.Tag = False
        Next
        pb.BorderStyle = BorderStyle.FixedSingle
        pb.Tag = True
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        For Each item In Res_List
            If item.Tag = True Then
                CCTool.Marker_Preview.Image = item.Image
            End If
        Next
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class