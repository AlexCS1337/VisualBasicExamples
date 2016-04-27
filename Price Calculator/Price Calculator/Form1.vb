Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        lblPrice.Text = Val(txtPrice1.Text) + Val(txtPrice2.Text) + Val(txtPrice3.Text) + Val(txtPrice4.Text) + Val(txtPrice5.Text)
        lblTaxPayable.Text = lblPrice.Text * Val(txtTaxRate.Text) / 100
        lblTaxPrice.Text = Val(lblPrice.Text) + Val(lblTaxPayable.Text)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
