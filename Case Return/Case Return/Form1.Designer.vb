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
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txtNumber = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.lblName = New System.Windows.Forms.Label
        Me.lblNumber = New System.Windows.Forms.Label
        Me.lblCredit = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(205, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number of cases"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(26, 111)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 2
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(208, 111)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(389, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Please enter in your name and the number of cases returned then press calculate"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(115, 175)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(121, 36)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(87, 239)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 13)
        Me.lblName.TabIndex = 6
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(197, 244)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(0, 13)
        Me.lblNumber.TabIndex = 7
        '
        'lblCredit
        '
        Me.lblCredit.AutoSize = True
        Me.lblCredit.Location = New System.Drawing.Point(127, 288)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(39, 13)
        Me.lblCredit.TabIndex = 8
        Me.lblCredit.Text = "Label6"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Customer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(242, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Cases Returned"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 288)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Credit Due ($)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 325)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblCredit)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Case Return"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblNumber As System.Windows.Forms.Label
    Friend WithEvents lblCredit As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
