<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mainform))
        Me.Startbutton = New System.Windows.Forms.Button()
        Me.Bigimgintro = New System.Windows.Forms.PictureBox()
        Me.Instructionslabelf1 = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        CType(Me.Bigimgintro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Startbutton
        '
        Me.Startbutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Startbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Startbutton.ForeColor = System.Drawing.Color.Goldenrod
        Me.Startbutton.Location = New System.Drawing.Point(768, 620)
        Me.Startbutton.Name = "Startbutton"
        Me.Startbutton.Size = New System.Drawing.Size(182, 46)
        Me.Startbutton.TabIndex = 5
        Me.Startbutton.Text = "Start"
        Me.Startbutton.UseVisualStyleBackColor = False
        '
        'Bigimgintro
        '
        Me.Bigimgintro.BackColor = System.Drawing.Color.Transparent
        Me.Bigimgintro.Image = CType(resources.GetObject("Bigimgintro.Image"), System.Drawing.Image)
        Me.Bigimgintro.Location = New System.Drawing.Point(-1, -5)
        Me.Bigimgintro.Name = "Bigimgintro"
        Me.Bigimgintro.Size = New System.Drawing.Size(1090, 759)
        Me.Bigimgintro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bigimgintro.TabIndex = 6
        Me.Bigimgintro.TabStop = False
        '
        'Instructionslabelf1
        '
        Me.Instructionslabelf1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Instructionslabelf1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Instructionslabelf1.ForeColor = System.Drawing.Color.Goldenrod
        Me.Instructionslabelf1.Location = New System.Drawing.Point(768, 568)
        Me.Instructionslabelf1.Name = "Instructionslabelf1"
        Me.Instructionslabelf1.Size = New System.Drawing.Size(182, 46)
        Me.Instructionslabelf1.TabIndex = 7
        Me.Instructionslabelf1.Text = "Instructions"
        Me.Instructionslabelf1.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.ForeColor = System.Drawing.Color.Goldenrod
        Me.ExitButton.Location = New System.Drawing.Point(768, 516)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(182, 46)
        Me.ExitButton.TabIndex = 8
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'Mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(990, 678)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Instructionslabelf1)
        Me.Controls.Add(Me.Startbutton)
        Me.Controls.Add(Me.Bigimgintro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Mainform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "World of Warcraft story"
        CType(Me.Bigimgintro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Startbutton As Button
    Friend WithEvents Bigimgintro As PictureBox
    Friend WithEvents Instructionslabelf1 As Button
    Friend WithEvents ExitButton As Button
End Class
