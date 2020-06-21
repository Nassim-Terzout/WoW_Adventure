<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Deathwingending
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Deathwingending))
        Me.Deathwingdied = New System.Windows.Forms.PictureBox()
        Me.endingtext = New System.Windows.Forms.Label()
        Me.Endingexit = New System.Windows.Forms.Button()
        CType(Me.Deathwingdied, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Deathwingdied
        '
        Me.Deathwingdied.Image = CType(resources.GetObject("Deathwingdied.Image"), System.Drawing.Image)
        Me.Deathwingdied.Location = New System.Drawing.Point(-1, -2)
        Me.Deathwingdied.Name = "Deathwingdied"
        Me.Deathwingdied.Size = New System.Drawing.Size(993, 720)
        Me.Deathwingdied.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Deathwingdied.TabIndex = 0
        Me.Deathwingdied.TabStop = False
        '
        'endingtext
        '
        Me.endingtext.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.endingtext.ForeColor = System.Drawing.Color.Goldenrod
        Me.endingtext.Location = New System.Drawing.Point(0, 587)
        Me.endingtext.Name = "endingtext"
        Me.endingtext.Size = New System.Drawing.Size(992, 93)
        Me.endingtext.TabIndex = 1
        '
        'Endingexit
        '
        Me.Endingexit.BackColor = System.Drawing.SystemColors.ControlText
        Me.Endingexit.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Endingexit.ForeColor = System.Drawing.Color.Goldenrod
        Me.Endingexit.Location = New System.Drawing.Point(769, 501)
        Me.Endingexit.Name = "Endingexit"
        Me.Endingexit.Size = New System.Drawing.Size(209, 83)
        Me.Endingexit.TabIndex = 2
        Me.Endingexit.Text = "Exit"
        Me.Endingexit.UseVisualStyleBackColor = False
        '
        'Deathwingending
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(990, 678)
        Me.Controls.Add(Me.Endingexit)
        Me.Controls.Add(Me.endingtext)
        Me.Controls.Add(Me.Deathwingdied)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Deathwingending"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "You've slain Deathwing!"
        CType(Me.Deathwingdied, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Deathwingdied As PictureBox
    Friend WithEvents endingtext As Label
    Friend WithEvents Endingexit As Button
End Class
