<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Deathwingdeath1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Deathwingdeath1))
        Me.Deathwingdeath1img = New System.Windows.Forms.PictureBox()
        Me.Deathwingdeath1title = New System.Windows.Forms.Label()
        Me.Deathwingdeathmsg = New System.Windows.Forms.Label()
        Me.RestartButtondeathwingdeath = New System.Windows.Forms.Button()
        CType(Me.Deathwingdeath1img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Deathwingdeath1img
        '
        Me.Deathwingdeath1img.Image = CType(resources.GetObject("Deathwingdeath1img.Image"), System.Drawing.Image)
        Me.Deathwingdeath1img.Location = New System.Drawing.Point(120, 158)
        Me.Deathwingdeath1img.Name = "Deathwingdeath1img"
        Me.Deathwingdeath1img.Size = New System.Drawing.Size(726, 393)
        Me.Deathwingdeath1img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Deathwingdeath1img.TabIndex = 0
        Me.Deathwingdeath1img.TabStop = False
        '
        'Deathwingdeath1title
        '
        Me.Deathwingdeath1title.Font = New System.Drawing.Font("Viner Hand ITC", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deathwingdeath1title.ForeColor = System.Drawing.Color.Red
        Me.Deathwingdeath1title.Location = New System.Drawing.Point(120, 9)
        Me.Deathwingdeath1title.Name = "Deathwingdeath1title"
        Me.Deathwingdeath1title.Size = New System.Drawing.Size(726, 57)
        Me.Deathwingdeath1title.TabIndex = 1
        Me.Deathwingdeath1title.Text = "You Died..."
        Me.Deathwingdeath1title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Deathwingdeathmsg
        '
        Me.Deathwingdeathmsg.Font = New System.Drawing.Font("Viner Hand ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deathwingdeathmsg.ForeColor = System.Drawing.Color.Red
        Me.Deathwingdeathmsg.Location = New System.Drawing.Point(120, 97)
        Me.Deathwingdeathmsg.Name = "Deathwingdeathmsg"
        Me.Deathwingdeathmsg.Size = New System.Drawing.Size(726, 69)
        Me.Deathwingdeathmsg.TabIndex = 2
        Me.Deathwingdeathmsg.Text = "Deathwing was in the Burning Steppes. He found you and was pleased that god bless" &
    "ed him with such a great breakfast."
        '
        'RestartButtondeathwingdeath
        '
        Me.RestartButtondeathwingdeath.BackColor = System.Drawing.SystemColors.ControlText
        Me.RestartButtondeathwingdeath.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RestartButtondeathwingdeath.ForeColor = System.Drawing.Color.Goldenrod
        Me.RestartButtondeathwingdeath.Location = New System.Drawing.Point(678, 566)
        Me.RestartButtondeathwingdeath.Name = "RestartButtondeathwingdeath"
        Me.RestartButtondeathwingdeath.Size = New System.Drawing.Size(300, 100)
        Me.RestartButtondeathwingdeath.TabIndex = 3
        Me.RestartButtondeathwingdeath.Text = "Restart"
        Me.RestartButtondeathwingdeath.UseVisualStyleBackColor = False
        '
        'Deathwingdeath1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(990, 678)
        Me.Controls.Add(Me.RestartButtondeathwingdeath)
        Me.Controls.Add(Me.Deathwingdeathmsg)
        Me.Controls.Add(Me.Deathwingdeath1title)
        Me.Controls.Add(Me.Deathwingdeath1img)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Deathwingdeath1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "You Died!"
        CType(Me.Deathwingdeath1img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Deathwingdeath1img As PictureBox
    Friend WithEvents Deathwingdeath1title As Label
    Friend WithEvents Deathwingdeathmsg As Label
    Friend WithEvents RestartButtondeathwingdeath As Button
End Class
