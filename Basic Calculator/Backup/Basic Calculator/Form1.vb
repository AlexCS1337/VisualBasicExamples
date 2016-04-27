Public Class Form1

    Private Sub btbCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbCalculate.Click
        lblSum.Text = Val(txtNumber1.Text) + Val(txtNumber2.Text)
        lblDifference.Text = Val(txtNumber1.Text) - Val(txtNumber2.Text)
        lblProduct.Text = Val(txtNumber1.Text) * Val(txtNumber2.Text)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
