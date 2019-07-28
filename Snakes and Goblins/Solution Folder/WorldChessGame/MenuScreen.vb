Public Class MenuScreen
    Private Sub MenuScreen_Load(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Module2.RipSheets()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Player Name Input
        Dim PCName As String
        PCName = InputBox("What is your name?", "New Hero", "Kandaricus the Brave")
        While PCName.Length > 30
            PCName = InputBox("Too long! Do you have a shorter nickname?", "New Hero", PCName)
        End While
        'Player stats Input
        If Name.Length = 0 Then
            'DoNothing
        Else
            CCTool.CCTool_NameBox.Text = PCName
            CCTool.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MapEditor.Show()
        Me.Hide()
    End Sub
End Class
