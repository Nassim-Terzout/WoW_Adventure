<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ch2Goldshire
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ch2Goldshire))
        Me.Goldshiremap = New System.Windows.Forms.PictureBox()
        Me.Stormwind = New System.Windows.Forms.RadioButton()
        Me.eastvale = New System.Windows.Forms.RadioButton()
        Me.outputgoldshirech2 = New System.Windows.Forms.Label()
        Me.Letsgo2 = New System.Windows.Forms.Button()
        Me.goldshireexit = New System.Windows.Forms.Button()
        Me.goldshirerestart = New System.Windows.Forms.Button()
        Me.goldshirehelp = New System.Windows.Forms.Button()
        Me.Helplabelgoldshire = New System.Windows.Forms.Label()
        CType(Me.Goldshiremap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Goldshiremap
        '
        Me.Goldshiremap.Image = CType(resources.GetObject("Goldshiremap.Image"), System.Drawing.Image)
        Me.Goldshiremap.Location = New System.Drawing.Point(12, 12)
        Me.Goldshiremap.Name = "Goldshiremap"
        Me.Goldshiremap.Size = New System.Drawing.Size(704, 468)
        Me.Goldshiremap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Goldshiremap.TabIndex = 0
        Me.Goldshiremap.TabStop = False
        '
        'Stormwind
        '
        Me.Stormwind.AutoSize = True
        Me.Stormwind.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stormwind.ForeColor = System.Drawing.Color.Goldenrod
        Me.Stormwind.Location = New System.Drawing.Point(12, 594)
        Me.Stormwind.Name = "Stormwind"
        Me.Stormwind.Size = New System.Drawing.Size(322, 26)
        Me.Stormwind.TabIndex = 1
        Me.Stormwind.TabStop = True
        Me.Stormwind.Text = "Head to Stormwind City and seek help."
        Me.Stormwind.UseVisualStyleBackColor = True
        '
        'eastvale
        '
        Me.eastvale.AutoSize = True
        Me.eastvale.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eastvale.ForeColor = System.Drawing.Color.Goldenrod
        Me.eastvale.Location = New System.Drawing.Point(12, 616)
        Me.eastvale.Name = "eastvale"
        Me.eastvale.Size = New System.Drawing.Size(387, 26)
        Me.eastvale.TabIndex = 2
        Me.eastvale.TabStop = True
        Me.eastvale.Text = "Head to Eastvale Logging Camp and warn them."
        Me.eastvale.UseVisualStyleBackColor = True
        '
        'outputgoldshirech2
        '
        Me.outputgoldshirech2.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputgoldshirech2.ForeColor = System.Drawing.Color.Goldenrod
        Me.outputgoldshirech2.Location = New System.Drawing.Point(12, 483)
        Me.outputgoldshirech2.Name = "outputgoldshirech2"
        Me.outputgoldshirech2.Size = New System.Drawing.Size(704, 108)
        Me.outputgoldshirech2.TabIndex = 3
        '
        'Letsgo2
        '
        Me.Letsgo2.BackColor = System.Drawing.SystemColors.ControlText
        Me.Letsgo2.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Letsgo2.ForeColor = System.Drawing.Color.Goldenrod
        Me.Letsgo2.Location = New System.Drawing.Point(678, 566)
        Me.Letsgo2.Name = "Letsgo2"
        Me.Letsgo2.Size = New System.Drawing.Size(300, 100)
        Me.Letsgo2.TabIndex = 5
        Me.Letsgo2.Text = "Let's Go!"
        Me.Letsgo2.UseVisualStyleBackColor = False
        '
        'goldshireexit
        '
        Me.goldshireexit.BackColor = System.Drawing.SystemColors.ControlText
        Me.goldshireexit.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.goldshireexit.ForeColor = System.Drawing.Color.Goldenrod
        Me.goldshireexit.Location = New System.Drawing.Point(722, 12)
        Me.goldshireexit.Name = "goldshireexit"
        Me.goldshireexit.Size = New System.Drawing.Size(256, 86)
        Me.goldshireexit.TabIndex = 13
        Me.goldshireexit.Text = "Exit"
        Me.goldshireexit.UseVisualStyleBackColor = False
        '
        'goldshirerestart
        '
        Me.goldshirerestart.BackColor = System.Drawing.SystemColors.ControlText
        Me.goldshirerestart.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.goldshirerestart.ForeColor = System.Drawing.Color.Goldenrod
        Me.goldshirerestart.Location = New System.Drawing.Point(722, 104)
        Me.goldshirerestart.Name = "goldshirerestart"
        Me.goldshirerestart.Size = New System.Drawing.Size(256, 86)
        Me.goldshirerestart.TabIndex = 14
        Me.goldshirerestart.Text = "Restart"
        Me.goldshirerestart.UseVisualStyleBackColor = False
        '
        'goldshirehelp
        '
        Me.goldshirehelp.BackColor = System.Drawing.SystemColors.ControlText
        Me.goldshirehelp.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.goldshirehelp.ForeColor = System.Drawing.Color.Goldenrod
        Me.goldshirehelp.Location = New System.Drawing.Point(722, 196)
        Me.goldshirehelp.Name = "goldshirehelp"
        Me.goldshirehelp.Size = New System.Drawing.Size(256, 86)
        Me.goldshirehelp.TabIndex = 15
        Me.goldshirehelp.Text = "Help"
        Me.goldshirehelp.UseVisualStyleBackColor = False
        '
        'Helplabelgoldshire
        '
        Me.Helplabelgoldshire.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Helplabelgoldshire.ForeColor = System.Drawing.Color.Goldenrod
        Me.Helplabelgoldshire.Location = New System.Drawing.Point(722, 293)
        Me.Helplabelgoldshire.Name = "Helplabelgoldshire"
        Me.Helplabelgoldshire.Size = New System.Drawing.Size(256, 187)
        Me.Helplabelgoldshire.TabIndex = 16
        Me.Helplabelgoldshire.Text = "Analyze the map and read the text below it. Based on what you've read choose an o" &
    "ption and hit the ""Let's Go!"" button."
        Me.Helplabelgoldshire.Visible = False
        '
        'Ch2Goldshire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(990, 678)
        Me.Controls.Add(Me.Helplabelgoldshire)
        Me.Controls.Add(Me.goldshirehelp)
        Me.Controls.Add(Me.goldshirerestart)
        Me.Controls.Add(Me.goldshireexit)
        Me.Controls.Add(Me.Letsgo2)
        Me.Controls.Add(Me.outputgoldshirech2)
        Me.Controls.Add(Me.eastvale)
        Me.Controls.Add(Me.Stormwind)
        Me.Controls.Add(Me.Goldshiremap)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ch2Goldshire"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "You made it to Goldshire!"
        CType(Me.Goldshiremap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Goldshiremap As PictureBox
    Friend WithEvents Stormwind As RadioButton
    Friend WithEvents eastvale As RadioButton
    Friend WithEvents outputgoldshirech2 As Label
    Friend WithEvents Letsgo2 As Button
    Friend WithEvents goldshireexit As Button
    Friend WithEvents goldshirerestart As Button
    Friend WithEvents goldshirehelp As Button
    Friend WithEvents Helplabelgoldshire As Label
End Class
