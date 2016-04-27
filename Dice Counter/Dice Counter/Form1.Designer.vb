<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblOnes = New System.Windows.Forms.Label
        Me.lblTwos = New System.Windows.Forms.Label
        Me.lblThrees = New System.Windows.Forms.Label
        Me.lblFours = New System.Windows.Forms.Label
        Me.lblFives = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblSixes = New System.Windows.Forms.Label
        Me.picDice = New System.Windows.Forms.PictureBox
        Me.imlDice = New System.Windows.Forms.ImageList(Me.components)
        Me.btnRoll = New System.Windows.Forms.Button
        Me.btnReset = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblCount = New System.Windows.Forms.Label
        CType(Me.picDice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ones"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Twos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Threes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fours"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fives"
        '
        'lblOnes
        '
        Me.lblOnes.AutoSize = True
        Me.lblOnes.Location = New System.Drawing.Point(95, 45)
        Me.lblOnes.Name = "lblOnes"
        Me.lblOnes.Size = New System.Drawing.Size(39, 13)
        Me.lblOnes.TabIndex = 5
        Me.lblOnes.Text = "Label6"
        '
        'lblTwos
        '
        Me.lblTwos.AutoSize = True
        Me.lblTwos.Location = New System.Drawing.Point(95, 83)
        Me.lblTwos.Name = "lblTwos"
        Me.lblTwos.Size = New System.Drawing.Size(39, 13)
        Me.lblTwos.TabIndex = 6
        Me.lblTwos.Text = "Label7"
        '
        'lblThrees
        '
        Me.lblThrees.AutoSize = True
        Me.lblThrees.Location = New System.Drawing.Point(95, 121)
        Me.lblThrees.Name = "lblThrees"
        Me.lblThrees.Size = New System.Drawing.Size(39, 13)
        Me.lblThrees.TabIndex = 7
        Me.lblThrees.Text = "Label8"
        '
        'lblFours
        '
        Me.lblFours.AutoSize = True
        Me.lblFours.Location = New System.Drawing.Point(95, 161)
        Me.lblFours.Name = "lblFours"
        Me.lblFours.Size = New System.Drawing.Size(39, 13)
        Me.lblFours.TabIndex = 8
        Me.lblFours.Text = "Label9"
        '
        'lblFives
        '
        Me.lblFives.AutoSize = True
        Me.lblFives.Location = New System.Drawing.Point(95, 201)
        Me.lblFives.Name = "lblFives"
        Me.lblFives.Size = New System.Drawing.Size(45, 13)
        Me.lblFives.TabIndex = 9
        Me.lblFives.Text = "Label10"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(23, 243)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Sixes"
        '
        'lblSixes
        '
        Me.lblSixes.AutoSize = True
        Me.lblSixes.Location = New System.Drawing.Point(95, 243)
        Me.lblSixes.Name = "lblSixes"
        Me.lblSixes.Size = New System.Drawing.Size(45, 13)
        Me.lblSixes.TabIndex = 11
        Me.lblSixes.Text = "Label12"
        '
        'picDice
        '
        Me.picDice.Image = CType(resources.GetObject("picDice.Image"), System.Drawing.Image)
        Me.picDice.Location = New System.Drawing.Point(197, 71)
        Me.picDice.Name = "picDice"
        Me.picDice.Size = New System.Drawing.Size(83, 83)
        Me.picDice.TabIndex = 12
        Me.picDice.TabStop = False
        '
        'imlDice
        '
        Me.imlDice.ImageStream = CType(resources.GetObject("imlDice.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlDice.TransparentColor = System.Drawing.Color.Transparent
        Me.imlDice.Images.SetKeyName(0, "one.bmp")
        Me.imlDice.Images.SetKeyName(1, "two.bmp")
        Me.imlDice.Images.SetKeyName(2, "three.bmp")
        Me.imlDice.Images.SetKeyName(3, "four.bmp")
        Me.imlDice.Images.SetKeyName(4, "five.bmp")
        Me.imlDice.Images.SetKeyName(5, "six.bmp")
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(173, 191)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(75, 23)
        Me.btnRoll.TabIndex = 13
        Me.btnRoll.Text = "Roll"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(290, 191)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(290, 262)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(182, 262)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(39, 13)
        Me.lblCount.TabIndex = 16
        Me.lblCount.Text = "Label6"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 319)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.picDice)
        Me.Controls.Add(Me.lblSixes)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblFives)
        Me.Controls.Add(Me.lblFours)
        Me.Controls.Add(Me.lblThrees)
        Me.Controls.Add(Me.lblTwos)
        Me.Controls.Add(Me.lblOnes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Dice Counter"
        CType(Me.picDice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblOnes As System.Windows.Forms.Label
    Friend WithEvents lblTwos As System.Windows.Forms.Label
    Friend WithEvents lblThrees As System.Windows.Forms.Label
    Friend WithEvents lblFours As System.Windows.Forms.Label
    Friend WithEvents lblFives As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblSixes As System.Windows.Forms.Label
    Friend WithEvents picDice As System.Windows.Forms.PictureBox
    Friend WithEvents imlDice As System.Windows.Forms.ImageList
    Friend WithEvents btnRoll As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblCount As System.Windows.Forms.Label

End Class
