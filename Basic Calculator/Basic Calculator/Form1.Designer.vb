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
        Me.txtNumber1 = New System.Windows.Forms.TextBox
        Me.btbCalculate = New System.Windows.Forms.Button
        Me.txtNumber2 = New System.Windows.Forms.TextBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblSum = New System.Windows.Forms.Label
        Me.lblDifference = New System.Windows.Forms.Label
        Me.lblProduct = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtNumber1
        '
        Me.txtNumber1.Location = New System.Drawing.Point(36, 52)
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.Size = New System.Drawing.Size(95, 20)
        Me.txtNumber1.TabIndex = 0
        '
        'btbCalculate
        '
        Me.btbCalculate.Location = New System.Drawing.Point(184, 147)
        Me.btbCalculate.Name = "btbCalculate"
        Me.btbCalculate.Size = New System.Drawing.Size(89, 34)
        Me.btbCalculate.TabIndex = 2
        Me.btbCalculate.Text = "Calculate"
        Me.btbCalculate.UseVisualStyleBackColor = True
        '
        'txtNumber2
        '
        Me.txtNumber2.Location = New System.Drawing.Point(184, 52)
        Me.txtNumber2.Name = "txtNumber2"
        Me.txtNumber2.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber2.TabIndex = 3
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(209, 235)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Sum"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Difference"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Product"
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.Location = New System.Drawing.Point(34, 137)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(0, 13)
        Me.lblSum.TabIndex = 8
        '
        'lblDifference
        '
        Me.lblDifference.AutoSize = True
        Me.lblDifference.Location = New System.Drawing.Point(39, 190)
        Me.lblDifference.Name = "lblDifference"
        Me.lblDifference.Size = New System.Drawing.Size(0, 13)
        Me.lblDifference.TabIndex = 9
        '
        'lblProduct
        '
        Me.lblProduct.AutoSize = True
        Me.lblProduct.Location = New System.Drawing.Point(39, 245)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(0, 13)
        Me.lblProduct.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 282)
        Me.Controls.Add(Me.lblProduct)
        Me.Controls.Add(Me.lblDifference)
        Me.Controls.Add(Me.lblSum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtNumber2)
        Me.Controls.Add(Me.btbCalculate)
        Me.Controls.Add(Me.txtNumber1)
        Me.Name = "Form1"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNumber1 As System.Windows.Forms.TextBox
    Friend WithEvents btbCalculate As System.Windows.Forms.Button
    Friend WithEvents txtNumber2 As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblSum As System.Windows.Forms.Label
    Friend WithEvents lblDifference As System.Windows.Forms.Label
    Friend WithEvents lblProduct As System.Windows.Forms.Label

End Class
