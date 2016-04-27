Public Class Form1

    Private Sub rbdEnglish_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbdEnglish.CheckedChanged, rbdFrench.CheckedChanged, rbdGerman.CheckedChanged, rbdIndonesian.CheckedChanged
        If rbdEnglish.Checked Then
            lblGreeting.Text = "Hello"
        ElseIf rbdFrench.Checked Then
            lblGreeting.Text = "Bonjour"
        ElseIf rbdGerman.Checked Then
            lblGreeting.Text = "Gutan Tag"
        ElseIf rbdIndonesian.Checked Then
            lblGreeting.Text = "Apa kabar"
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
