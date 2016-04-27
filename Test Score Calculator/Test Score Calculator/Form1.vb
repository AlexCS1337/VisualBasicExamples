Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        lblAverage.Text = Val(txtTest1.Text) + Val(txtTest2.Text) + Val(txtTest3.Text) + Val(txtTest4.Text) / 4
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
