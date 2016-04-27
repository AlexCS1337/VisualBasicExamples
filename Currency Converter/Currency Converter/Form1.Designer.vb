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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtAUS = New System.Windows.Forms.TextBox
        Me.rbdUS = New System.Windows.Forms.RadioButton
        Me.rbdNZ = New System.Windows.Forms.RadioButton
        Me.rbdYen = New System.Windows.Forms.RadioButton
        Me.rbdUK = New System.Windows.Forms.RadioButton
        Me.lblCurrency = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(367, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter in Australian Currency then click on the currency you wish to conver to"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "$AUS"
        '
        'txtAUS
        '
        Me.txtAUS.Location = New System.Drawing.Point(21, 104)
        Me.txtAUS.Name = "txtAUS"
        Me.txtAUS.Size = New System.Drawing.Size(100, 20)
        Me.txtAUS.TabIndex = 2
        '
        'rbdUS
        '
        Me.rbdUS.AutoSize = True
        Me.rbdUS.Location = New System.Drawing.Point(234, 104)
        Me.rbdUS.Name = "rbdUS"
        Me.rbdUS.Size = New System.Drawing.Size(46, 17)
        Me.rbdUS.TabIndex = 3
        Me.rbdUS.TabStop = True
        Me.rbdUS.Text = "$US"
        Me.rbdUS.UseVisualStyleBackColor = True
        '
        'rbdNZ
        '
        Me.rbdNZ.AutoSize = True
        Me.rbdNZ.Location = New System.Drawing.Point(234, 142)
        Me.rbdNZ.Name = "rbdNZ"
        Me.rbdNZ.Size = New System.Drawing.Size(46, 17)
        Me.rbdNZ.TabIndex = 4
        Me.rbdNZ.TabStop = True
        Me.rbdNZ.Text = "$NZ"
        Me.rbdNZ.UseVisualStyleBackColor = True
        '
        'rbdYen
        '
        Me.rbdYen.AutoSize = True
        Me.rbdYen.Location = New System.Drawing.Point(234, 186)
        Me.rbdYen.Name = "rbdYen"
        Me.rbdYen.Size = New System.Drawing.Size(50, 17)
        Me.rbdYen.TabIndex = 5
        Me.rbdYen.TabStop = True
        Me.rbdYen.Text = "¥Yen"
        Me.rbdYen.UseVisualStyleBackColor = True
        '
        'rbdUK
        '
        Me.rbdUK.AutoSize = True
        Me.rbdUK.Location = New System.Drawing.Point(234, 226)
        Me.rbdUK.Name = "rbdUK"
        Me.rbdUK.Size = New System.Drawing.Size(46, 17)
        Me.rbdUK.TabIndex = 6
        Me.rbdUK.TabStop = True
        Me.rbdUK.Text = "£UK"
        Me.rbdUK.UseVisualStyleBackColor = True
        '
        'lblCurrency
        '
        Me.lblCurrency.AutoSize = True
        Me.lblCurrency.Location = New System.Drawing.Point(35, 269)
        Me.lblCurrency.Name = "lblCurrency"
        Me.lblCurrency.Size = New System.Drawing.Size(0, 13)
        Me.lblCurrency.TabIndex = 7
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(259, 290)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 33)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Currency Amount"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 344)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblCurrency)
        Me.Controls.Add(Me.rbdUK)
        Me.Controls.Add(Me.rbdYen)
        Me.Controls.Add(Me.rbdNZ)
        Me.Controls.Add(Me.rbdUS)
        Me.Controls.Add(Me.txtAUS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Currency Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAUS As System.Windows.Forms.TextBox
    Friend WithEvents rbdUS As System.Windows.Forms.RadioButton
    Friend WithEvents rbdNZ As System.Windows.Forms.RadioButton
    Friend WithEvents rbdYen As System.Windows.Forms.RadioButton
    Friend WithEvents rbdUK As System.Windows.Forms.RadioButton
    Friend WithEvents lblCurrency As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
