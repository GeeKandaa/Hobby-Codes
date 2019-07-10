Module Module1

    Public ReadOnly Res_List As New SortedDictionary(Of String, PictureBox)
    Public Sub SelectResources(ByRef HandlerMethod As EventHandler, ByRef Container As Panel, ByVal LookUp As String, ByVal n As Integer)

        Dim AllResources As Object
        Dim Res As DictionaryEntry
        'Generate list of resources
        AllResources = My.Resources.ResourceManager.GetResourceSet(System.Globalization.CultureInfo.CurrentCulture, True, True)
        'Modifiers for positioning PictureBoxes
        Dim TopMod = 0
        Dim LeftMod = 0
        Res_List.Clear()

        'Scans through Resources for PC_Skin and displays PictureBox
        For Each Res In AllResources
            If Res.Key.ToString.Contains(LookUp) Then
                Dim pb As New PictureBox With {
                .Tag = Res.Key,  'Dependent: PickClick()
                .SizeMode = PictureBoxSizeMode.StretchImage,
                .Image = Res.Value}
                Res_List.Add(Res.Key, pb)
            End If
        Next
        For Each pb In Res_List
            With pb.Value
                .Width = (Container.Width - 20) / n    'Size and Spacing
                .Height = (Container.Height - 20) / n
                .Top = 10 + TopMod * (Container.Height - 20) / n
                .Left = 10 + LeftMod * (Container.Width - 20) / n
            End With

            'Add Control
            Container.Controls.Add(pb.Value)
            AddHandler pb.Value.Click, HandlerMethod
            Debug.WriteLine(pb.Key)
            Debug.Write(pb.Value)
            'Count
            LeftMod = (LeftMod + 1) Mod n
            If LeftMod = 0 Then
                TopMod += 1
            End If
        Next
    End Sub

End Module
