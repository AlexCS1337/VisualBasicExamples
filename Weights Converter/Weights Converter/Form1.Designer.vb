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
        Me.lblEarthWeight = New System.Windows.Forms.Label
        Me.lblMoonWeight = New System.Windows.Forms.Label
        Me.hsbWeight = New System.Windows.Forms.HScrollBar
        Me.btnExit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Earth Weight"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(211, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Moon Weight"
        '
        'lblEarthWeight
        '
        Me.lblEarthWeight.AutoSize = True
        Me.lblEarthWeight.Location = New System.Drawing.Point(74, 91)
        Me.lblEarthWeight.Name = "lblEarthWeight"
        Me.lblEarthWeight.Size = New System.Drawing.Size(0, 13)
        Me.lblEarthWeight.TabIndex = 2
        '
        'lblMoonWeight
        '
        Me.lblMoonWeight.AutoSize = True
        Me.lblMoonWeight.Location = New System.Drawing.Point(233, 93)
        Me.lblMoonWeight.Name = "lblMoonWeight"
        Me.lblMoonWeight.Size = New System.Drawing.Size(0, 13)
        Me.lblMoonWeight.TabIndex = 3
        '
        'hsbWeight
        '
        Me.hsbWeight.Location = New System.Drawing.Point(39, 158)
        Me.hsbWeight.Maximum = 200
        Me.hsbWeight.Name = "hsbWeight"
        Me.hsbWeight.Size = New System.Drawing.Size(283, 23)
        Me.hsbWeight.TabIndex = 4
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(268, 222)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 257)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.hsbWeight)
        Me.Controls.Add(Me.lblMoonWeight)
        Me.Controls.Add(Me.lblEarthWeight)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Weights Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblEarthWeight As System.Windows.Forms.Label
    Friend WithEvents lblMoonWeight As System.Windows.Forms.Label
    Friend WithEvents hsbWeight As System.Windows.Forms.HScrollBar
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
