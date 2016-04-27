Public Class Form1

    Dim Die1 As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblOnes.Text = 0
        lblTwos.Text = 0
        lblThrees.Text = 0
        lblFours.Text = 0
        lblFives.Text = 0
        lblSixes.Text = 0
        lblCount.Text = 0
    End Sub

    Private Sub btnRoll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoll.Click
        Randomize()                 'sets sequence of rando numbers
        Die1 = Int(Rnd() * 6) + 1   'generates random number between 1 and 6
        Select Case Die1
            Case 1                                  'if number is 1
                lblOnes.Text = lblOnes.Text + 1     'increment ones
                picDice.Image = imlDice.Images(0)   'loads one dice
            Case 2                                  'if number is 2
                lblTwos.Text = lblTwos.Text + 1     'increment twos
                picDice.Image = imlDice.Images(1)   'loads two dice
            Case 3                                  'if number is 3
                lblThrees.Text = lblThrees.Text + 1 'increment threes
                picDice.Image = imlDice.Images(2)   'loads three dice
            Case 4                                  'if number is 4
                lblFours.Text = lblFours.Text + 1   'increment fours
                picDice.Image = imlDice.Images(3)   'loads four dice
            Case 5                                  'if number is 5
                lblFives.Text = lblFives.Text + 1   'increment fives
                picDice.Image = imlDice.Images(4)   'loads five dice
            Case 6                                  'if number is 6
                lblSixes.Text = lblSixes.Text + 1   'increment sixes
                picDice.Image = imlDice.Images(5)   'loads six dice
        End Select
        lblCount.Text = lblCount.Text + 1           'increments counter
        If lblCount.Text = 100 Then
            btnRoll.Enabled = False
        End If
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        lblOnes.Text = 0   'resets counters to 0
        lblTwos.Text = 0
        lblThrees.Text = 0
        lblFours.Text = 0
        lblFives.Text = 0
        lblSixes.Text = 0
        lblCount.Text = 0
        btnRoll.Enabled = True
    End Sub
End Class
