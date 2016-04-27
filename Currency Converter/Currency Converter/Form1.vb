Public Class Form1

    Private Sub rbdUS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbdUS.CheckedChanged, rbdNZ.CheckedChanged, rbdUK.CheckedChanged, rbdYen.CheckedChanged
        If rbdUS.Checked Then
            lblCurrency.Text = Val(txtAUS.Text) * 0.7687
        ElseIf rbdNZ.Checked Then
            lblCurrency.Text = Val(txtAUS.Text) * 1.09
        ElseIf rbdYen.Checked Then
            lblCurrency.Text = Val(txtAUS.Text) * 82.72
        ElseIf rbdUK.Checked Then
            lblCurrency.Text = Val(txtAUS.Text) * 0.4233
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
