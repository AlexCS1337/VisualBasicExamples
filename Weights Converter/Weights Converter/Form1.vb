Public Class Form1

    Private Sub hsbWeight_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles hsbWeight.Scroll
        lblEarthWeight.Text = Format(hsbWeight.Value, "0")
        lblMoonWeight.Text = Format(hsbWeight.Value * 0.165, "0.0")
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
