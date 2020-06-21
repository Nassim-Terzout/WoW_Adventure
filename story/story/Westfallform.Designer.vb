<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Westfallform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Westfallform))
        Me.Westfalldeathtitle = New System.Windows.Forms.Label()
        Me.Westfalldeathmsg = New System.Windows.Forms.Label()
        Me.Bandits = New System.Windows.Forms.PictureBox()
        Me.RestartButtonwestfall = New System.Windows.Forms.Button()
        CType(Me.Bandits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Westfalldeathtitle
        '
        Me.Westfalldeathtitle.Font = New System.Drawing.Font("Viner Hand ITC", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Westfalldeathtitle.ForeColor = System.Drawing.Color.Red
        Me.Westfalldeathtitle.Location = New System.Drawing.Point(133, 9)
        Me.Westfalldeathtitle.Name = "Westfalldeathtitle"
        Me.Westfalldeathtitle.Size = New System.Drawing.Size(726, 57)
        Me.Westfalldeathtitle.TabIndex = 2
        Me.Westfalldeathtitle.Text = "You Died..."
        Me.Westfalldeathtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Westfalldeathmsg
        '
        Me.Westfalldeathmsg.Font = New System.Drawing.Font("Viner Hand ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Westfalldeathmsg.ForeColor = System.Drawing.Color.Red
        Me.Westfalldeathmsg.Location = New System.Drawing.Point(87, 66)
        Me.Westfalldeathmsg.Name = "Westfalldeathmsg"
        Me.Westfalldeathmsg.Size = New System.Drawing.Size(808, 69)
        Me.Westfalldeathmsg.TabIndex = 3
        Me.Westfalldeathmsg.Text = "You died! A group of bandits ganged up on you while you were walking to Westfall." &
    " They beat you to death, took all your goods and left you to rot."
        '
        'Bandits
        '
        Me.Bandits.Image = CType(resources.GetObject("Bandits.Image"), System.Drawing.Image)
        Me.Bandits.Location = New System.Drawing.Point(93, 156)
        Me.Bandits.Name = "Bandits"
        Me.Bandits.Size = New System.Drawing.Size(802, 332)
        Me.Bandits.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bandits.TabIndex = 4
        Me.Bandits.TabStop = False
        '
        'RestartButtonwestfall
        '
        Me.RestartButtonwestfall.BackColor = System.Drawing.SystemColors.ControlText
        Me.RestartButtonwestfall.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RestartButtonwestfall.ForeColor = System.Drawing.Color.Goldenrod
        Me.RestartButtonwestfall.Location = New System.Drawing.Point(678, 566)
        Me.RestartButtonwestfall.Name = "RestartButtonwestfall"
        Me.RestartButtonwestfall.Size = New System.Drawing.Size(300, 100)
        Me.RestartButtonwestfall.TabIndex = 5
        Me.RestartButtonwestfall.Text = "Restart"
        Me.RestartButtonwestfall.UseVisualStyleBackColor = False
        '
        'Westfallform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(990, 678)
        Me.Controls.Add(Me.RestartButtonwestfall)
        Me.Controls.Add(Me.Bandits)
        Me.Controls.Add(Me.Westfalldeathmsg)
        Me.Controls.Add(Me.Westfalldeathtitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Westfallform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "You died!"
        CType(Me.Bandits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Westfalldeathtitle As Label
    Friend WithEvents Westfalldeathmsg As Label
    Friend WithEvents Bandits As PictureBox
    Friend WithEvents RestartButtonwestfall As Button
End Class
