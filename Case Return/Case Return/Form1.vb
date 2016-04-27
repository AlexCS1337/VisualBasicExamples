Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        lblName.Text = txtName.Text
        lblNumber.Text = txtNumber.Text
        If lblNumber.Text > 8 Then
            lblCredit.Text = lblNumber.Text * 4
        Else
            lblCredit.Text = lblNumber.Text * 3.5
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblCredit.Text = 0
        lblNumber.Text = 0
        lblName.Text = "Name"
    End Sub
End Class
