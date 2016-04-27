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
        Me.btnA = New System.Windows.Forms.Button
        Me.btnB = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnA
        '
        Me.btnA.Location = New System.Drawing.Point(28, 59)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(149, 122)
        Me.btnA.TabIndex = 0
        Me.btnA.Text = "Button A"
        Me.btnA.UseVisualStyleBackColor = True
        '
        'btnB
        '
        Me.btnB.Location = New System.Drawing.Point(207, 59)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(149, 122)
        Me.btnB.TabIndex = 1
        Me.btnB.Text = "Button B"
        Me.btnB.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(222, 237)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(134, 90)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 361)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnB)
        Me.Controls.Add(Me.btnA)
        Me.Name = "Form1"
        Me.Text = "ButtonApp"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnA As System.Windows.Forms.Button
    Friend WithEvents btnB As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
