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
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtPrice1 = New System.Windows.Forms.TextBox
        Me.txtPrice2 = New System.Windows.Forms.TextBox
        Me.txtPrice3 = New System.Windows.Forms.TextBox
        Me.txtPrice4 = New System.Windows.Forms.TextBox
        Me.txtPrice5 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtTaxRate = New System.Windows.Forms.TextBox
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblPrice = New System.Windows.Forms.Label
        Me.lblTaxPayable = New System.Windows.Forms.Label
        Me.lblTaxPrice = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please enter five prices and the tax rate then press Calculate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Price 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Price 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Price 3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Price 4"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Price 5"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(50, 344)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Price"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(47, 374)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "TaxPayable"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(50, 401)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "TaxPrice"
        '
        'txtPrice1
        '
        Me.txtPrice1.Location = New System.Drawing.Point(113, 98)
        Me.txtPrice1.Name = "txtPrice1"
        Me.txtPrice1.Size = New System.Drawing.Size(68, 20)
        Me.txtPrice1.TabIndex = 9
        '
        'txtPrice2
        '
        Me.txtPrice2.Location = New System.Drawing.Point(113, 134)
        Me.txtPrice2.Name = "txtPrice2"
        Me.txtPrice2.Size = New System.Drawing.Size(68, 20)
        Me.txtPrice2.TabIndex = 10
        '
        'txtPrice3
        '
        Me.txtPrice3.Location = New System.Drawing.Point(114, 173)
        Me.txtPrice3.Name = "txtPrice3"
        Me.txtPrice3.Size = New System.Drawing.Size(66, 20)
        Me.txtPrice3.TabIndex = 11
        '
        'txtPrice4
        '
        Me.txtPrice4.Location = New System.Drawing.Point(114, 212)
        Me.txtPrice4.Name = "txtPrice4"
        Me.txtPrice4.Size = New System.Drawing.Size(66, 20)
        Me.txtPrice4.TabIndex = 12
        '
        'txtPrice5
        '
        Me.txtPrice5.Location = New System.Drawing.Point(114, 246)
        Me.txtPrice5.Name = "txtPrice5"
        Me.txtPrice5.Size = New System.Drawing.Size(70, 20)
        Me.txtPrice5.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(42, 286)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Tax Rate"
        '
        'txtTaxRate
        '
        Me.txtTaxRate.Location = New System.Drawing.Point(114, 279)
        Me.txtTaxRate.Name = "txtTaxRate"
        Me.txtTaxRate.Size = New System.Drawing.Size(71, 20)
        Me.txtTaxRate.TabIndex = 15
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(312, 243)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(136, 56)
        Me.btnCalculate.TabIndex = 16
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(351, 388)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(97, 39)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(125, 344)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(0, 13)
        Me.lblPrice.TabIndex = 18
        '
        'lblTaxPayable
        '
        Me.lblTaxPayable.AutoSize = True
        Me.lblTaxPayable.Location = New System.Drawing.Point(125, 374)
        Me.lblTaxPayable.Name = "lblTaxPayable"
        Me.lblTaxPayable.Size = New System.Drawing.Size(0, 13)
        Me.lblTaxPayable.TabIndex = 19
        '
        'lblTaxPrice
        '
        Me.lblTaxPrice.AutoSize = True
        Me.lblTaxPrice.Location = New System.Drawing.Point(125, 401)
        Me.lblTaxPrice.Name = "lblTaxPrice"
        Me.lblTaxPrice.Size = New System.Drawing.Size(0, 13)
        Me.lblTaxPrice.TabIndex = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 441)
        Me.Controls.Add(Me.lblTaxPrice)
        Me.Controls.Add(Me.lblTaxPayable)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtTaxRate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtPrice5)
        Me.Controls.Add(Me.txtPrice4)
        Me.Controls.Add(Me.txtPrice3)
        Me.Controls.Add(Me.txtPrice2)
        Me.Controls.Add(Me.txtPrice1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Price Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPrice1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice3 As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice4 As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice5 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTaxRate As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblTaxPayable As System.Windows.Forms.Label
    Friend WithEvents lblTaxPrice As System.Windows.Forms.Label

End Class
