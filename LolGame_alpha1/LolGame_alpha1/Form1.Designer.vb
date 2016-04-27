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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnStart = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnLoad = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnStart.ForeColor = System.Drawing.Color.Yellow
        Me.btnStart.Location = New System.Drawing.Point(35, 209)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(90, 26)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "New Game"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnExit.Location = New System.Drawing.Point(229, 287)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 27)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.Yellow
        Me.btnLoad.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLoad.Location = New System.Drawing.Point(174, 209)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(92, 26)
        Me.btnLoad.TabIndex = 2
        Me.btnLoad.Text = "Load Game"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(306, 315)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnStart)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "LolGame"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button

End Class
