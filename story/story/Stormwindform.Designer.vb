<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stormwindform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stormwindform))
        Me.Letsgo3 = New System.Windows.Forms.Button()
        Me.outputstormwind = New System.Windows.Forms.Label()
        Me.Burningsteppes2 = New System.Windows.Forms.RadioButton()
        Me.Westfall = New System.Windows.Forms.RadioButton()
        Me.Stormwindmap = New System.Windows.Forms.PictureBox()
        Me.mainmenustormwind = New System.Windows.Forms.Button()
        Me.Stormwindexit = New System.Windows.Forms.Button()
        Me.Help = New System.Windows.Forms.Button()
        Me.Helplabelstormwind = New System.Windows.Forms.Label()
        CType(Me.Stormwindmap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Letsgo3
        '
        Me.Letsgo3.BackColor = System.Drawing.SystemColors.ControlText
        Me.Letsgo3.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Letsgo3.ForeColor = System.Drawing.Color.Goldenrod
        Me.Letsgo3.Location = New System.Drawing.Point(678, 566)
        Me.Letsgo3.Name = "Letsgo3"
        Me.Letsgo3.Size = New System.Drawing.Size(300, 100)
        Me.Letsgo3.TabIndex = 5
        Me.Letsgo3.Text = "Let's Go!"
        Me.Letsgo3.UseVisualStyleBackColor = False
        '
        'outputstormwind
        '
        Me.outputstormwind.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.outputstormwind.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputstormwind.ForeColor = System.Drawing.Color.Goldenrod
        Me.outputstormwind.Location = New System.Drawing.Point(8, 483)
        Me.outputstormwind.Name = "outputstormwind"
        Me.outputstormwind.Size = New System.Drawing.Size(708, 110)
        Me.outputstormwind.TabIndex = 6
        '
        'Burningsteppes2
        '
        Me.Burningsteppes2.AutoSize = True
        Me.Burningsteppes2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Burningsteppes2.ForeColor = System.Drawing.Color.Goldenrod
        Me.Burningsteppes2.Location = New System.Drawing.Point(12, 596)
        Me.Burningsteppes2.Name = "Burningsteppes2"
        Me.Burningsteppes2.Size = New System.Drawing.Size(470, 26)
        Me.Burningsteppes2.TabIndex = 7
        Me.Burningsteppes2.TabStop = True
        Me.Burningsteppes2.Text = "Head to the Burning Steppes and fight with what you have!"
        Me.Burningsteppes2.UseVisualStyleBackColor = True
        '
        'Westfall
        '
        Me.Westfall.AutoSize = True
        Me.Westfall.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Westfall.ForeColor = System.Drawing.Color.Goldenrod
        Me.Westfall.Location = New System.Drawing.Point(12, 619)
        Me.Westfall.Name = "Westfall"
        Me.Westfall.Size = New System.Drawing.Size(547, 26)
        Me.Westfall.TabIndex = 8
        Me.Westfall.TabStop = True
        Me.Westfall.Text = "Leave the army and head down to Westfall to look for additional help."
        Me.Westfall.UseVisualStyleBackColor = True
        '
        'Stormwindmap
        '
        Me.Stormwindmap.Image = CType(resources.GetObject("Stormwindmap.Image"), System.Drawing.Image)
        Me.Stormwindmap.Location = New System.Drawing.Point(12, 12)
        Me.Stormwindmap.Name = "Stormwindmap"
        Me.Stormwindmap.Size = New System.Drawing.Size(704, 468)
        Me.Stormwindmap.TabIndex = 9
        Me.Stormwindmap.TabStop = False
        '
        'mainmenustormwind
        '
        Me.mainmenustormwind.BackColor = System.Drawing.SystemColors.ControlText
        Me.mainmenustormwind.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainmenustormwind.ForeColor = System.Drawing.Color.Goldenrod
        Me.mainmenustormwind.Location = New System.Drawing.Point(722, 104)
        Me.mainmenustormwind.Name = "mainmenustormwind"
        Me.mainmenustormwind.Size = New System.Drawing.Size(256, 86)
        Me.mainmenustormwind.TabIndex = 10
        Me.mainmenustormwind.Text = "Restart"
        Me.mainmenustormwind.UseVisualStyleBackColor = False
        '
        'Stormwindexit
        '
        Me.Stormwindexit.BackColor = System.Drawing.SystemColors.ControlText
        Me.Stormwindexit.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stormwindexit.ForeColor = System.Drawing.Color.Goldenrod
        Me.Stormwindexit.Location = New System.Drawing.Point(722, 12)
        Me.Stormwindexit.Name = "Stormwindexit"
        Me.Stormwindexit.Size = New System.Drawing.Size(256, 86)
        Me.Stormwindexit.TabIndex = 11
        Me.Stormwindexit.Text = "Exit"
        Me.Stormwindexit.UseVisualStyleBackColor = False
        '
        'Help
        '
        Me.Help.BackColor = System.Drawing.SystemColors.ControlText
        Me.Help.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Help.ForeColor = System.Drawing.Color.Goldenrod
        Me.Help.Location = New System.Drawing.Point(722, 196)
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(256, 86)
        Me.Help.TabIndex = 12
        Me.Help.Text = "Help"
        Me.Help.UseVisualStyleBackColor = False
        '
        'Helplabelstormwind
        '
        Me.Helplabelstormwind.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Helplabelstormwind.ForeColor = System.Drawing.Color.Goldenrod
        Me.Helplabelstormwind.Location = New System.Drawing.Point(722, 292)
        Me.Helplabelstormwind.Name = "Helplabelstormwind"
        Me.Helplabelstormwind.Size = New System.Drawing.Size(256, 187)
        Me.Helplabelstormwind.TabIndex = 13
        Me.Helplabelstormwind.Text = "Analyze the map and read the text below it. Based on what you've read choose an o" &
    "ption and hit the ""Let's Go!"" button."
        Me.Helplabelstormwind.Visible = False
        '
        'Stormwindform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(990, 678)
        Me.Controls.Add(Me.Helplabelstormwind)
        Me.Controls.Add(Me.Help)
        Me.Controls.Add(Me.Stormwindexit)
        Me.Controls.Add(Me.mainmenustormwind)
        Me.Controls.Add(Me.Stormwindmap)
        Me.Controls.Add(Me.Westfall)
        Me.Controls.Add(Me.Burningsteppes2)
        Me.Controls.Add(Me.Letsgo3)
        Me.Controls.Add(Me.outputstormwind)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Stormwindform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "You made it to Stormwind City!"
        CType(Me.Stormwindmap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Letsgo3 As Button
    Friend WithEvents outputstormwind As Label
    Friend WithEvents Burningsteppes2 As RadioButton
    Friend WithEvents Westfall As RadioButton
    Friend WithEvents Stormwindmap As PictureBox
    Friend WithEvents mainmenustormwind As Button
    Friend WithEvents Stormwindexit As Button
    Friend WithEvents Help As Button
    Friend WithEvents Helplabelstormwind As Label
End Class
