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
        Me.lblGreeting = New System.Windows.Forms.Label
        Me.rbdEnglish = New System.Windows.Forms.RadioButton
        Me.rbdFrench = New System.Windows.Forms.RadioButton
        Me.rbdGerman = New System.Windows.Forms.RadioButton
        Me.rbdIndonesian = New System.Windows.Forms.RadioButton
        Me.btnExit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Greeting:"
        '
        'lblGreeting
        '
        Me.lblGreeting.AutoSize = True
        Me.lblGreeting.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreeting.Location = New System.Drawing.Point(52, 129)
        Me.lblGreeting.Name = "lblGreeting"
        Me.lblGreeting.Size = New System.Drawing.Size(0, 16)
        Me.lblGreeting.TabIndex = 1
        '
        'rbdEnglish
        '
        Me.rbdEnglish.AutoSize = True
        Me.rbdEnglish.Location = New System.Drawing.Point(265, 91)
        Me.rbdEnglish.Name = "rbdEnglish"
        Me.rbdEnglish.Size = New System.Drawing.Size(59, 17)
        Me.rbdEnglish.TabIndex = 2
        Me.rbdEnglish.TabStop = True
        Me.rbdEnglish.Text = "English"
        Me.rbdEnglish.UseVisualStyleBackColor = True
        '
        'rbdFrench
        '
        Me.rbdFrench.AutoSize = True
        Me.rbdFrench.Location = New System.Drawing.Point(265, 142)
        Me.rbdFrench.Name = "rbdFrench"
        Me.rbdFrench.Size = New System.Drawing.Size(58, 17)
        Me.rbdFrench.TabIndex = 3
        Me.rbdFrench.TabStop = True
        Me.rbdFrench.Text = "French"
        Me.rbdFrench.UseVisualStyleBackColor = True
        '
        'rbdGerman
        '
        Me.rbdGerman.AutoSize = True
        Me.rbdGerman.Location = New System.Drawing.Point(265, 186)
        Me.rbdGerman.Name = "rbdGerman"
        Me.rbdGerman.Size = New System.Drawing.Size(62, 17)
        Me.rbdGerman.TabIndex = 4
        Me.rbdGerman.TabStop = True
        Me.rbdGerman.Text = "German"
        Me.rbdGerman.UseVisualStyleBackColor = True
        '
        'rbdIndonesian
        '
        Me.rbdIndonesian.AutoSize = True
        Me.rbdIndonesian.Location = New System.Drawing.Point(265, 225)
        Me.rbdIndonesian.Name = "rbdIndonesian"
        Me.rbdIndonesian.Size = New System.Drawing.Size(77, 17)
        Me.rbdIndonesian.TabIndex = 5
        Me.rbdIndonesian.TabStop = True
        Me.rbdIndonesian.Text = "Indonesian"
        Me.rbdIndonesian.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(338, 292)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(109, 39)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 343)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.rbdIndonesian)
        Me.Controls.Add(Me.rbdGerman)
        Me.Controls.Add(Me.rbdFrench)
        Me.Controls.Add(Me.rbdEnglish)
        Me.Controls.Add(Me.lblGreeting)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Greetings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblGreeting As System.Windows.Forms.Label
    Friend WithEvents rbdEnglish As System.Windows.Forms.RadioButton
    Friend WithEvents rbdFrench As System.Windows.Forms.RadioButton
    Friend WithEvents rbdGerman As System.Windows.Forms.RadioButton
    Friend WithEvents rbdIndonesian As System.Windows.Forms.RadioButton
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
