<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eastvaledeath
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Eastvaledeath))
        Me.eastvaledeath1title = New System.Windows.Forms.Label()
        Me.eastvaledeathmsg = New System.Windows.Forms.Label()
        Me.Murlocs = New System.Windows.Forms.PictureBox()
        Me.EastvaleRestartButton = New System.Windows.Forms.Button()
        CType(Me.Murlocs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'eastvaledeath1title
        '
        Me.eastvaledeath1title.Font = New System.Drawing.Font("Viner Hand ITC", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eastvaledeath1title.ForeColor = System.Drawing.Color.Red
        Me.eastvaledeath1title.Location = New System.Drawing.Point(99, 21)
        Me.eastvaledeath1title.Name = "eastvaledeath1title"
        Me.eastvaledeath1title.Size = New System.Drawing.Size(787, 57)
        Me.eastvaledeath1title.TabIndex = 2
        Me.eastvaledeath1title.Text = "You Died..."
        Me.eastvaledeath1title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'eastvaledeathmsg
        '
        Me.eastvaledeathmsg.Font = New System.Drawing.Font("Viner Hand ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eastvaledeathmsg.ForeColor = System.Drawing.Color.Red
        Me.eastvaledeathmsg.Location = New System.Drawing.Point(129, 78)
        Me.eastvaledeathmsg.Name = "eastvaledeathmsg"
        Me.eastvaledeathmsg.Size = New System.Drawing.Size(726, 69)
        Me.eastvaledeathmsg.TabIndex = 3
        Me.eastvaledeathmsg.Text = "A horde of 20 murlocs caught you on the way to Eastvale! They yelled Mrgggggrlrrr" &
    "rrrrrr! They killed you and stole all your goods."
        '
        'Murlocs
        '
        Me.Murlocs.Image = CType(resources.GetObject("Murlocs.Image"), System.Drawing.Image)
        Me.Murlocs.Location = New System.Drawing.Point(66, 177)
        Me.Murlocs.Name = "Murlocs"
        Me.Murlocs.Size = New System.Drawing.Size(873, 329)
        Me.Murlocs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Murlocs.TabIndex = 4
        Me.Murlocs.TabStop = False
        '
        'EastvaleRestartButton
        '
        Me.EastvaleRestartButton.BackColor = System.Drawing.SystemColors.ControlText
        Me.EastvaleRestartButton.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EastvaleRestartButton.ForeColor = System.Drawing.Color.Goldenrod
        Me.EastvaleRestartButton.Location = New System.Drawing.Point(678, 566)
        Me.EastvaleRestartButton.Name = "EastvaleRestartButton"
        Me.EastvaleRestartButton.Size = New System.Drawing.Size(300, 100)
        Me.EastvaleRestartButton.TabIndex = 5
        Me.EastvaleRestartButton.Text = "Restart"
        Me.EastvaleRestartButton.UseVisualStyleBackColor = False
        '
        'Eastvaledeath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(990, 678)
        Me.Controls.Add(Me.EastvaleRestartButton)
        Me.Controls.Add(Me.Murlocs)
        Me.Controls.Add(Me.eastvaledeathmsg)
        Me.Controls.Add(Me.eastvaledeath1title)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Eastvaledeath"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "You died!"
        CType(Me.Murlocs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents eastvaledeath1title As Label
    Friend WithEvents eastvaledeathmsg As Label
    Friend WithEvents Murlocs As PictureBox
    Friend WithEvents EastvaleRestartButton As Button
End Class
